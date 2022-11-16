namespace Guarantee.Models
{
    public class TheGuarantor
    {
        public int Id { get; set; }
        public string? Address { get; set; }
        public string FIO  { get; set; }
        public string? PhoneNumber { get; set; }

        public List<GuaranteeAgreement> guaranteeAgreements { get; set; }


    }
}