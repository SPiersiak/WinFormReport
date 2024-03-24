using DevExpress.XtraEditors.Controls;
using ReportInfrastructure.Dtos;
using ReportInfrastructure.Services.Interfaces;

namespace WinFromReport;

public partial class MainForm : Form
{
    private readonly IReportService _reportService;
    private readonly IPremisesService _premisesService;
    public MainForm(IReportService reportService, IPremisesService premisesService)
    {
        _reportService = reportService;
        _premisesService = premisesService;
        InitializeComponent();
    }

    private void ConfirmButtonOnClick(object sender, EventArgs e)
    {
        var selectedPremises = (PremisesDto?)premisesDropDown.GetSelectedDataRow();
        reportGrid.DataSource = _reportService.GetReports(
            fromDateEdit.EditValue as DateTime?,
            toDateEdit.EditValue as DateTime?,
            selectedPremises?.Id ?? null);

    }

    private void MainFormOnLoad(object sender, EventArgs e)
    {
        premisesDropDown.Properties.DataSource = _premisesService.GetPremises();
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
}
