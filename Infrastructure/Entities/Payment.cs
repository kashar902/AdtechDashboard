using System.ComponentModel.DataAnnotations;

namespace Infrastructure.Entities
{
    public class Payment
    {
        [Key]
        public int Id { get; set; }
        public string UserId { get; set; }
        public string? Paypal { get; set; }
        public string? WireTransfer { get; set; }
        public string? Payoneer { get; set; }
        public string? CompanyName { get; set; }
        public string? SwiftCode { get; set; }
        public string? BankName { get; set; } 
        public string? AccountNumber { get; set; }
        public string? IBAN { get; set; }
        public string? AccountCurrency { get; set; }
        public string? BenificiaryName { get; set; }
        public string? BenificiaryAddress { get; set; }
        public string? Email { get; set; }
        public string? Dateofbirth { get; set; }
    }
}
