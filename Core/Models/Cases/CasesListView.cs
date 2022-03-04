using Core.Helpers;

namespace Core.Models.Cases;

public class CasesListView
{
    public DatatableValue<int> Id { get; set; }
    public DatatableValue<string> CreatedAt { get; set; }
    public DatatableValue<string> TicketNumber { get; set; }
    public DatatableValue<string> TypeName { get; set; }
    public DatatableValue<string> SubtypeName { get; set; }
    public DatatableValue<string> TypificationName  { get; set; }
    public DatatableValue<string> ReceptionBranch  { get; set; }
    public DatatableValue<string> ReceptionTime  { get; set; }
    public DatatableValue<string> BranchAffected  { get; set; }
    public DatatableValue<string> CaseStatusName  { get; set; }
    public DatatableValue<string> OriginName  { get; set; }
    public DatatableValue<string> Subject  { get; set; }
    public DatatableValue<string> Description  { get; set; }
    public DatatableValue<string> CaseOwnerName  { get; set; }
    public DatatableValue<string> ResolverAreas  { get; set; }
    public DatatableValue<string> CompanyName  { get; set; }
    public DatatableValue<string> CallDirection  { get; set; }
    public DatatableValue<List<string>> Tags  { get; set; }
    public DatatableValue<string> UpdatedAt  { get; set; }
    public DatatableValue<string> Solution  { get; set; }
    public DatatableValue<string> Comment  { get; set; }
    public DatatableValue<string> RequestExtension  { get; set; }
    public DatatableValue<string> BusinessOfficer  { get; set; }
    public DatatableValue<string> Promoter { get; set; }
    public DatatableValue<int> NumberOfComments { get; set; }
    public DatatableValue<string> ContactName { get; set; }
    public DatatableValue<string> ContactEmail { get; set; }
    public DatatableValue<string> ClientNumber { get; set; }
    public DatatableValue<string> ContactPhone { get; set; }
    public DatatableValue<string> ContactFullName { get; set; }
    public DatatableValue<string> ClientBranch { get; set; }
    public DatatableValue<string> Layout { get; set; }

}