using Core.Helpers;

namespace Core.Entities.Cases
{
    public class Case: AuditableEntity
    {
        public int Id { get; set; }
        public string FinansysTicketNumber { get; set; }
        public DateTime Time { get; set; }
        public Contact.Contact Contact { get; set; }
        public int ContactId { get; set; }
        public Company.Company Company { get; set; }
        public int CompanyId { get; set; }
        public Contact.Contact Promoter { get; set; }
        public int PromoterId { get; set; }     
        public CaseType Type { get; set; }
        public int TypeId { get; set; }
        public CaseSubtype Subtype { get; set; }
        public int SubtypeId { get; set; }
        public CaseTypification Typification { get; set; }
        public int TypificationId { get; set; }
        public string Subject { get; set; }
        public string Description { get; set; }
        public CaseOrigin Origin { get; set; }
        public int OriginId { get; set; }
        public CaseStatus CaseStatus { get; set; }
        public int CaseStatusId { get; set; }
        public string IdServidesk { get; set; }
        public Clerk.Clerk CaseOwner { get; set; }
        public int CaseOwnerId { get; set; }
        public List<CaseResolutionArea> CaseResolutionAreas { get; set; }
        public List<Resolver> Resolvers { get; set; }
        public string BusinessOfficer { get; set; }
        public string Solution { get; set; }
        public string ClientComment { get; set; }
        public string Qualification { get; set; }
        public bool RequestExtension { get; set; }
        public string AttachmentFile { get; set; }
        
    }
}