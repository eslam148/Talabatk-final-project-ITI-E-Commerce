using System.ComponentModel.DataAnnotations;

namespace E_Commerce_Admin_Dashboard_MVC.Models
{
    public class LogInModel
    {
        [Required]
        [Display(Name = "UserName")]
        public string UserName { get; set; }
        [Required]
        [MinLength(3)]
        [MaxLength(16)]
        [Display(Name = "Password")]
        [DataType(DataType.Password)]
        public string Password { get; set; }
        public bool RememberMe { get; set; }
        public string ReturnUrl { get; set; }
    }
}
