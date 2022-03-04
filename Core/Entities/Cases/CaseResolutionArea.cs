using Core.Entities.Common;

namespace Core.Entities.Cases;

public class CaseResolutionArea
{
    public int Id { get; set; }
    public Case Case { get; set; }
    public int CaseId { get; set; }
    public ResolutionArea ResolutionArea { get; set; }
    public int ResolutionAreaId { get; set; }
}