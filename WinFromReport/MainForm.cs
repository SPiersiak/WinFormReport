using ReportInfrastructure.Services.Interfaces;

namespace WinFromReport;

public partial class MainForm : Form
{
    private readonly IReportService _reportService;
    public MainForm(IReportService reportService)
    {
        _reportService = reportService;
        InitializeComponent();
    }

    private void confirmButton_Click(object sender, EventArgs e)
    {
        reportGrid.DataSource = _reportService.GetReports(null, null, null);
    }
}
