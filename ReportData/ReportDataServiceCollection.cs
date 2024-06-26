﻿using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using ReportData.Models;

namespace ReportData;
public static class ReportDataServiceCollection
{
    public static void ReportDataConfigureServices(this ServiceCollection services)
    {
        services.AddDbContextFactory<LsiReportDbContext>(options =>
            options.UseSqlServer("Server=.\\SQLEXPRESS;Database=LsiReportDB;Trusted_Connection=True;encrypt=false;"));
    }
}
