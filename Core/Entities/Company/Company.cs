using Core.Entities.Common;
using Core.Helpers;

namespace Core.Entities.Company
{
    public class Company : AuditableEntity
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Ruc { get; set; }
        public DateTime Foundation { get; set; }
        public GenericStatus Status { get; set; }
        public ClientType Type { get; set; }
        public string Nationality { get; set; }
        public string Website { get; set; }
        public List<Contact.Contact> Contacts { get; set; }
        // public Company ParentCompany { get; set; }
        // public int? ParentCompanyId { get; set; } = null; 
        public string Description { get; set; }
        public int EmployersQuantity { get; set; }
        public string EconomicActivity { get; set; }
        public int BillingRange { get; set; }
        public WalletType WalletType { get; set; }
        public int WalletTypeId { get; set; }
        public string PaymentEntity { get; set; }
        public List<OperatingEntity> OperatingEntities { get; set; }
        public List<EconomicActivity> EconomicActivities { get; set; }
        public string Address { get; set; }
        public string Zone { get; set; }
        public string Reference { get; set; }
        public int HomeNumber { get; set; }
        public string Department { get; set; }
        public string City { get; set; }
        public string Neighborhood { get; set; }
        public string BillingCountry { get; set; }
        public string BillingState { get; set; }
        public string BillingStreet { get; set; }
        public GenericConditional IsClient { get; set; }
        public string ClientCode { get; set; }
        public Banca Banca { get; set; }
        public GenericStatus ClientState { get; set; }
        public Clerk.Clerk OwnerCompany { get; set; }
        public int OwnerCompanyId { get; set; }
        public Branch.Branch Branch { get; set; }
        public int BranchId { get; set; }
        public User.User Official { get; set; }
        public int OfficialId { get; set; }
        public ClientFont ClientFont { get; set; }
        public User.User SupervisorUser { get; set; }
        public int SupervisorUserId { get; set; }
        public User.User TeamLeaderUser { get; set; }
        public int TeamLeaderUserId { get; set; }
        public User.User BranchManagerUser { get; set; }
        public int BranchManagerUserId { get; set; }
        public Clerk.Clerk SupervisorClerk { get; set; }
        public int SupervisorClerkId { get; set; }
        public Clerk.Clerk TeamLeaderClerk { get; set; }
        public int TeamLeaderClerkId { get; set; }
        public Clerk.Clerk BranchManagerClerk { get; set; }
        public int BranchManagerClerkId { get; set; }
        public LeadsSource LeadsSource { get; set; }
        public List<Lead.Lead> Leads { get; set; }
        public Clerk.Clerk ContactOwner { get; set; }
        public int ContactOwnerId { get; set; }
    }
}