using Core.Entities.Common;
using Core.Helpers;

namespace Core.Entities.Contact
{
    public class Contact : AuditableEntity
    {
        public int Id { get; set; }
        public DocumentType DocumentType { get; set; }
        public int DocumentTypeId { get; set; }
        public string Nationality { get; set; }
        public string DocumentNumber { get; set; }
        public Gender Gender { get; set; }
        public int GenderTypeId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public CivilStatus CivilStatus { get; set; }
        public int CivilStatusId { get; set; }
        public DateTime DateOfBirth { get; set; }
        public WalletType WalletType { get; set; }
        public int WalletTypeId { get; set; }
        public string ClientCode { get; set; }
        public ContactType ContactType { get; set; }
        public int ContactTypeId { get; set; }
        public GenericConditional IsClient { get; set; }
        public string Email { get; set; }
        public string SecondaryEmail { get; set; }
        public string Mobile { get; set; }
        public string Landline { get; set; }
        public string Phone { get; set; }
        public string Address { get; set; }
        public string HomeNumber { get; set; }
        public string Reference { get; set; }
        public string Department { get; set; }
        public string City { get; set; }
        public string Neighborhood { get; set; }
        public string MailingStreet { get; set; }
        public string MailingCountry { get; set; }
        public string MailingState { get; set; }
        public string MailingCity { get; set; }
        public string WorkPlace { get; set; }
        public string CurrentSalary { get; set; }
        public string WorkPhone { get; set; }
        public string AssistantName { get; set; }
        public string AssistantEmail { get; set; }
        public string AssistantPhone { get; set; }
        public List<Company.Company> Companies { get; set; }
        public string EconomicActivity { get; set; }
        public string Description { get; set; }
        public Banca Banca { get; set; }
        public int BancaId { get; set; }
        public Branch.Branch Branch { get; set; }
        public int BranchId { get; set; }
        public Clerk.Clerk SupervisorClerk { get; set; }
        public int SupervisorClerkId { get; set; }
        public Clerk.Clerk TeamLeaderClerk { get; set; }
        public int TeamLeaderClerkId { get; set; }
        public Clerk.Clerk BranchManagerClerk { get; set; }
        public int BranchManagerClerkId { get; set; }
        public Clerk.Clerk Official { get; set; }
        public int OfficialId { get; set; }
        public User.User SupervisorUser { get; set; }
        public int SupervisorUserId { get; set; }
        public User.User TeamLeaderUser { get; set; }
        public int TeamLeaderUserId { get; set; }
        public User.User BranchManagerUser { get; set; }
        public int BranchManagerUserId { get; set; }
        public List<User.User> OfficialUsers { get; set; }
    }
}
