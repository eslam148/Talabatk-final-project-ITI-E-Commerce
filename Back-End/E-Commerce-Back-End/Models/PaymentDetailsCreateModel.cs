using E_CommerceDB;
using System.ComponentModel.DataAnnotations;

namespace E_Commerce_Back_End.Models
{
    public class PaymentDetailsCreateModel
    {
        [Required(ErrorMessage = "This field is Required")]
        public int Amount { get; set; }
        [Required(ErrorMessage = "This field is Required")] 
        public string Provider { get; set; }
        [Required(ErrorMessage = "This field is Required")] 
        public string Status { get; set; }
        [Required(ErrorMessage = "This field is Required")] 
        public DateTime Created_at { get; set; }
        [Required(ErrorMessage = "This field is Required")] 
        public DateTime Modified_at { get; set; }

    }
}
