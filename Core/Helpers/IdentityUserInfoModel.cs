namespace Core.Helpers;

public class IdentityUserInfoModel
{
    public IdentityUserInfoModel(string? id, string? email, string? givenName, string? familyName, string? phoneNumber)
    {
        Id = id;
        Email = email;
        GivenName = givenName;
        FamilyName = familyName;
        PhoneNumber = phoneNumber;
    }
    public string? Id { get; }
    public string? Email { get; }
    public string? GivenName { get; }
    public string? FamilyName { get; }
    public string? PhoneNumber { get; }
    
}