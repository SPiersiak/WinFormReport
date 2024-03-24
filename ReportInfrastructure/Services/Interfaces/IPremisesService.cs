using ReportInfrastructure.Dtos;

namespace ReportInfrastructure.Services.Interfaces;
public interface IPremisesService
{
    public List<PremisesDto> GetPremises();
}
