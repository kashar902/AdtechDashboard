using System.ComponentModel.DataAnnotations;

namespace Infrastructure.Entities
{
    public class Invoice
    {
        [Key]
        public int Id { get; set; }
        public DateTime? Date { get; set; }
        public DateTime? GeneratedDate { get; set; }
        public double Amount { get; set; }
        public int WebsiteId { get; set; }
        public double Deduction { get; set; }
        public int StatusId { get; set; }
    }
}
