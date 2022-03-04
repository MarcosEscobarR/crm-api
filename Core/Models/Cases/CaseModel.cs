namespace Core.Models.Cases;

public class CaseModel
{
    public int Id { get; set; }
    public string CaseStatus { get; set; }
    public string CaseOrigin { get; set; }
    public string CaseOwnerName { get; set; }
    public string ContactName { get; set; }
    public string ContactPhone { get; set; }
    public string TicketNumber { get; set; }
    public string Time { get; set; }
    public string CompanyName { get; set; }
    public string DocumentTypeName { get; set; }
    public string DocumentNumber { get; set; }
    public string ClientCode { get; set; }
    public string ClientBranch { get; set; }
    public string ContactMobile { get; set; }
    public string PromoterName { get; set; }
    public string PromoterPhone { get; set; }
    public string PromoterDocumentNumber { get; set; }
    public string PromoterEmail { get; set; }
    public string TypeName { get; set; }
    public string SubtypeName { get; set; }
    public string TypificationName { get; set; }
    public string Description { get; set; }
    public string CaseOriginName { get; set; }
    public string Design { get; set; }
    public string CallDirection { get; set; }
    public string UpdatedAt { get; set; }
    public string CreatedAt { get; set; }
    public string IdServidesk { get; set; }
    public List<string> ResolverAreas { get; set; }
    public List<string> Resolvers { get; set; }
    public string BusinessOfficerName { get; set; }
    public string Solution { get; set; }
    public string RequestExtension { get; set; }

}