using Microsoft.EntityFrameworkCore;
using ReportData.Models;
using ReportInfrastructure.Dtos;
using ReportInfrastructure.Services.Interfaces;

namespace ReportInfrastructure.Services;
public class PremisesService : IPremisesService
{
    private readonly IDbContextFactory<LsiReportDbContext> _contextFactory;

    public PremisesService(IDbContextFactory<LsiReportDbContext> contextFactory)
    {
        _contextFactory = contextFactory;
    }

    public List<PremisesDto> GetPremises()
    {
        using var context = _contextFactory.CreateDbContext();

        return context.Premises
            .Select(s => new PremisesDto()
            {
                Id = s.Id,
                Name = s.PremisesName,
            }).AsNoTracking().ToList();
    }
}
