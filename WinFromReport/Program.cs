using Microsoft.Extensions.DependencyInjection;

namespace WinFromReport;

internal static class Program
{
    /// <summary>
    ///  The main entry point for the application.
    /// </summary>
    [STAThread]
    static void Main()
    {
        // To customize application configuration such as set high DPI settings or default font,
        // see https://aka.ms/applicationconfiguration.
        ApplicationConfiguration.Initialize();
        var services = new ServiceCollection();

        services.AppConfigureServices();

        using (ServiceProvider serviceProvider = services.BuildServiceProvider())
        {
            var form1 = serviceProvider.GetRequiredService<MainForm>();
            Application.Run(form1);
        }
    }
}