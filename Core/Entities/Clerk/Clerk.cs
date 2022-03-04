namespace Core.Entities.Clerk
{
    public class Clerk
    {
        public int Id { get; set; }
        public User.User User { get; set; }
        public int UserId { get; set; }
    }
}