using System.ComponentModel.DataAnnotations;

namespace Infrastructure.Entities
{
    public class ApplicationUserStatus
    {
        [Key]
        public int Id { get; set; }
        [StringLength(20)]
        public string? Status { get; set; }
    }
}
