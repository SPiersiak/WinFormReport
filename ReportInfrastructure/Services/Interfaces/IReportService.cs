using ReportInfrastructure.Dtos;

namespace ReportInfrastructure.Services.Interfaces;
public interface IReportService
{
    List<ReportDto> GetReports(DateTime? dateFrom, DateTime? dateTo, long? premises);
}
