using E_CommerceDB;
using System.ComponentModel.DataAnnotations;

namespace E_Commerce_Back_End.Models
{
    public class UserPaymentCreateModel
    {
        //public int Id { get; set; }
        public string User_id { get; set; }
        [Required(ErrorMessage = "This field is Required")] 
        public string Payment_Type { get; set; }
        [Required(ErrorMessage = "This field is Required")] 
        public string Provider { get; set; }
        [Required(ErrorMessage = "This field is Required")] 
        public int Account_No { get; set; }
        [Required(ErrorMessage = "This field is Required")] 
        public DateTime Expire_Date { get; set; }
        public bool IsDeleted { get; set; } = false;
    }
}
