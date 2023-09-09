using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Entities
{
    public class Report
    {
        public Report()
        {
            CreatedOn= DateTime.Now;
            UpdatedOn= DateTime.Now;
        }
        [Key]
        public int Id { get; set; }
        public int WebsiteId { get; set; }
        public string UserId { get; set; }
        public DateTime Date { get; set; }
        public int AdRequest { get; set; }
        public double FillRate { get; set; }
        public int AdImpression { get; set; }
        public int Clicks { get; set; }
        public double Ctr { get; set; }
        public double Ecpm { get; set; }
        public double Revenue { get; set; }
        public DateTime CreatedOn { get; set; }
        public DateTime UpdatedOn { get; set; }
    }
}
