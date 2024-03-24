using ReportInfrastructure.Dtos;

namespace ReportInfrastructure.Services.Interfaces;
public interface IReportService
{
    (List<ReportDto>, int) GetReports(DateTime? dateFrom, DateTime? dateTo, long? premises, int page);
}
