using Microsoft.EntityFrameworkCore;
using ReportData.Models;
using ReportInfrastructure.Dtos;
using ReportInfrastructure.Services.Interfaces;

namespace ReportInfrastructure.Services;
public class ReportService : IReportService
{
    private readonly IDbContextFactory<LsiReportDbContext> _contextFactory;

    public ReportService(IDbContextFactory<LsiReportDbContext> contextFactory)
    {
        _contextFactory = contextFactory;
    }

    public List<ReportDto> GetReports(DateTime? dateFrom, DateTime? dateTo, long? premises)
    {
        using var context = _contextFactory.CreateDbContext();

        var query = context.Reports
            .Where(x => x.ReportDateTime.Date >= (dateFrom ?? DateTime.MinValue.Date) && x.ReportDateTime.Date <= (dateTo ?? DateTime.MaxValue.Date))
            .Include(i => i.User)
            .Include(i => i.Premises)
            .AsQueryable();
            
        if (premises.HasValue)
        {
            query = query.Where(x => x.PremisesId == premises.Value);
        }

        var result = query.Select(s => new ReportDto()
        {
            Name = s.ReportName,
            Date = s.ReportDateTime.Date,
            Time = s.ReportDateTime.TimeOfDay,
            User = s.User.UserName,
            Permises = s.Premises.PremisesName,
        }).Take(100).ToList();

        return result;
    }
}
