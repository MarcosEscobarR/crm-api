namespace Core.Entities.Cases;

public class Resolver
{
    public int Id { get; set; }
    public Case Case { get; set; }
    public int CaseId { get; set; }
    public User.User User { get; set; }
    public int UserId { get; set; }
}