using E_CommerceDB;
using System.ComponentModel.DataAnnotations;

namespace E_Commerce_Back_End.Models
{
    public class UserAddressCreateModel
    {
        //public int Id { get; set; }
        [Required(ErrorMessage = "This field is Required")]
        [MinLength(3)]
        public string Address_line1 { get; set; }
        [Required(ErrorMessage = "This field is Required")]
        [MinLength(3)]
        public string Country { get; set; }
        [Required(ErrorMessage = "This field is Required")]
        [MinLength(3)]
        public string City { get; set; }
        [Required(ErrorMessage = "This field is Required")]
        [MinLength(3)]
        public string Postal_Code { get; set; }
        [Required(ErrorMessage = "This field is Required")]
        [RegularExpression(@"^(010|011|012|015)[0-9]{8}$")]
        public string Mobile { get; set; }
        public string User_id { get; set; }
        public bool IsDeleted { get; set; } = false;

    }
}
