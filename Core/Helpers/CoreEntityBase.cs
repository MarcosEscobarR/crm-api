using System.ComponentModel.DataAnnotations;

namespace Core.Helpers
{

    public class CoreEntityBase
    {

        public int Id { get; set; }
        [MaxLength(20)] public string Code { get; set; }
        [MaxLength(30)] public string Name { get; set; }
    }
}