using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Entities
{
    public class Website
    {
        public Website()
        {
            CreatedOn = DateTime.Now;
            UpdatedOn = DateTime.Now;
        }

        [Key]
        public int Id { get; set; }
        [StringLength(50)]
        public string FullName { get; set; }
        [DataType(DataType.Url)]
        public string Url { get; set; }
        [StringLength(250)]
        public string Alexa { get; set; }
        [StringLength(50)]
        public string Country { get; set; }
        public string UserId { get; set; }
        public DateTime CreatedOn { get; set; }
        public DateTime UpdatedOn { get; set; }
    }
}
