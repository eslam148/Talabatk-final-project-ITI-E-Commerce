using System.ComponentModel.DataAnnotations;
using System.Xml.Linq;

namespace E_Commerce_Back_End
{
    public class ChangePasswordModel
    {
        [Required]
        public string Id { get; set; }
        [Required, MinLength(4), MaxLength(16),
           Display(Name = "Current Password"),
           DataType(DataType.Password)]
        public string CurrentPassword { get; set; }
        [Required, MinLength(4), MaxLength(16),
        Display(Name = "New Password"),
        DataType(DataType.Password)]
        public string NewPassword { get; set; }
        [Compare("NewPassword"), Display(Name = "Confirm New Password")
            , DataType(DataType.Password)]
        public string ConfirmNewPassword { get; set; }
    }
}
