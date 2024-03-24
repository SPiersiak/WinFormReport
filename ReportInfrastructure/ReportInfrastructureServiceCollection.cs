using Microsoft.Extensions.DependencyInjection;
using ReportData;
using ReportInfrastructure.Services;
using ReportInfrastructure.Services.Interfaces;

namespace ReportInfrastructure;
public static class ReportInfrastructureServiceCollection
{
    public static void ReportInfrastructureConfigureServices(this ServiceCollection services)
    {
        services.ReportDataConfigureServices();
        services.AddTransient<IReportService, ReportService>();
        services.AddTransient<IPremisesService, PremisesService>();
    }
}
