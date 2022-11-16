
using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Guarantee.Models


{
    public class GuaranteeAgreement
    {
        
        public int NumberOfContract { get; set; }
        public string DateOfContract { get; set; }
        
        public int TheGuarantorId { get; set; }
      

      //  public TheGuarantor TheGuarantor { get; set; }
    }
}
