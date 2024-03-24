using Microsoft.Extensions.DependencyInjection;
using ReportInfrastructure;

namespace WinFromReport;
public static class AppServiceCollection
{
    public static void AppConfigureServices(this ServiceCollection services)
    {
        services.AddScoped<MainForm>();
        services.ReportInfrastructureConfigureServices();
    }
}
