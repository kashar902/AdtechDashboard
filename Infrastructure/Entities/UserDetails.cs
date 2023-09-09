using Common.Enums;
using System.ComponentModel.DataAnnotations;

namespace Infrastructure.Entities
{
    public class UserDetails
    {
        [Key]
        public int ID { get; set; }
        public UserDetails()
        {
            StatusId = (int)UserStatus.Pending;
            CreatedOn = DateTime.Now;
            UpdatedOn = DateTime.Now;
            EncPassword = string.Empty;
        }
        public string UserId { get; set; }
        public ApplicationUser User { get; set; }
        public string EncPassword { get; set; }
        [StringLength(50)]
        public string SecondaryContact { get; set; }
        [StringLength(100)]
        public string Domain { get; set; }
        public string Views { get; set; }
        public int StatusId { get; set; }
        public DateTime CreatedOn { get; set; }
        public DateTime UpdatedOn { get; set; }
    }
}
