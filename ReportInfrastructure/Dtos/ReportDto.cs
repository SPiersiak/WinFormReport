using System.ComponentModel;

namespace ReportInfrastructure.Dtos;
public class ReportDto
{
    [DisplayName("Nazwa")]
    public string Name { get; set; }

    [DisplayName("Data")]
    public DateTime Date { get; set; }

    [DisplayName("Godzina")]
    public TimeSpan Time { get; set; }

    [DisplayName("Użytkownik")]
    public string User { get; set; }

    [DisplayName("Lokal")]
    public string Permises { get; set; }
}
