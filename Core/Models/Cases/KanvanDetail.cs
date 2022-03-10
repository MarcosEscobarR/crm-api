namespace Core.Models.Cases;

public class KanvanDetail
{
    public string Issue { get; set; }
    public string TicketNumber { get; set; }
    public string Type { get; set; }
    public string Subtype { get; set; }
    public List<string> ResolutionAreas { get; set; }
    public List<string> Resolver { get; set; }
}