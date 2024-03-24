using DevExpress.Utils.Extensions;
using DevExpress.XtraEditors.Controls;
using ReportInfrastructure.Dtos;
using ReportInfrastructure.Services.Interfaces;

namespace WinFromReport;

public partial class MainForm : Form
{
    private readonly IReportService _reportService;
    private readonly IPremisesService _premisesService;
    private int _currentPage = 1;
    private int _possiblePage;
    public MainForm(IReportService reportService, IPremisesService premisesService)
    {
        _reportService = reportService;
        _premisesService = premisesService;
        InitializeComponent();
    }

    private void MainFormOnLoad(object sender, EventArgs e)
    {
        premisesDropDown.Properties.DataSource = _premisesService.GetPremises();
    }

    private void ConfirmButtonOnClick(object sender, EventArgs e)
    {
        SetToDefaultPagginationSetings();

        GetReportData();

        SetPaginationLabelText();
        SetpaginationPagesEnableProperty();
        SetPaginationElementsVisibility(true);
    }

    private void FromDateTimeSelectionOnChanged(object sender, EventArgs e)
    {
        var args = e as ChangingEventArgs;

        if (args.NewValue is DateTime && args.NewValue != args.OldValue)
        {
            toDateEdit.Properties.MinValue = (DateTime)args.NewValue;
            return;
        }

        toDateEdit.Properties.MinValue = DateTime.MinValue;
    }

    private void ToDateTimeSelectionOnChanged(object sender, EventArgs e)
    {
        var args = e as ChangingEventArgs;

        if (args.NewValue is DateTime && args.NewValue != args.OldValue)
        {
            fromDateEdit.Properties.MaxValue = (DateTime)args.NewValue;
            return;
        }

        fromDateEdit.Properties.MaxValue = DateTime.MaxValue;
    }

    private void SetToDefaultPagginationSetings()
    {
        _currentPage = 1;
        _possiblePage = default;
    }

    private void NextPagginationButtonOnClick(object sender, EventArgs e)
    {
        _currentPage += 1;

        GetReportData();

        SetpaginationPagesEnableProperty();
        SetPaginationLabelText();
    }

    private void PreviousPagginationButtonOnClick(object sender, EventArgs e)
    {
        _currentPage -= 1;

        GetReportData();

        SetpaginationPagesEnableProperty();
        SetPaginationLabelText();
    }

    private void SetPaginationElementsVisibility(bool visible)
    {
        paginationLabel.Visible = visible;
        nextPagginationButton.Visible = visible;
        previousPaginationButton.Visible = visible;
    }

    private void SetPaginationLabelText()
    {
        paginationLabel.Text = $"{_currentPage} z {_possiblePage}";
    }

    private void SetpaginationPagesEnableProperty()
    {
        if (_currentPage == 1)
        {
            previousPaginationButton.Enabled = false;
        }
        else
        {
            previousPaginationButton.Enabled = true;
        }

        if (_currentPage >= _possiblePage)
        {
            nextPagginationButton.Enabled = false;
        }
        else
        {
            nextPagginationButton.Enabled = true;
        }
    }

    private void GetReportData()
    {
        var selectedPremises = (PremisesDto?)premisesDropDown.GetSelectedDataRow();
        (reportGrid.DataSource, _possiblePage) = _reportService.GetReports(
            fromDateEdit.EditValue as DateTime?,
            toDateEdit.EditValue as DateTime?,
            selectedPremises?.Id ?? null,
            _currentPage);
    }
}
