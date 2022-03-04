namespace Core.Models.Cases;

public class CreateCaseModel
{
    public int ContactId { get; set; }
    public int CompanyId { get; set; }
    public int PromoterId { get; set; }
    public int TypeId { get; set; }
    public int SubtypeId { get; set; }
    public int TypificationId { get; set; }
    public string Subject { get; set; }
    public string Description { get; set; }
    public int OriginId { get; set; }
    public int CaseOwnerId { get; set; }
    public int CaseStatusId { get; set; }
    public string IdServidesk { get; set; }
    public List<int> ResolutionAreaIds { get; set; }
    public List<int> ResolverIds { get; set; }
    public string BusinessOfficer { get; set; }
    public string Solution { get; set; }
    public string ClientComment { get; set; }
    public string Qualification { get; set; }
    public bool RequestExtension { get; set; }
    public string AttachmentFile { get; set; }
}