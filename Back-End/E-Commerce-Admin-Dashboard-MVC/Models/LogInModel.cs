using Microsoft.Build.Framework;

namespace E_Commerce_Admin_Dashboard_MVC.Models
{
    public class LogInModel
    {
        [Required]
        public String UserName { get; set; }
        [Required]
        public String Password { get; set; }
    }
}
