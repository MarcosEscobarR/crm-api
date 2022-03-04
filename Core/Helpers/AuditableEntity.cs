using Core.Entities.User;

namespace Core.Helpers
{

    public class AuditableEntity
    {
        public DateTime CreatedAt { get; set; }
        public DateTime? UpdatedAt { get; set; }
        public User UserWhoCreated { get; set; }
        public int UserWhoCreatedId { get; set; }
        public User UserWhoModified { get; set; }
        public int? UserWhoModifiedId { get; set; }
    }
}