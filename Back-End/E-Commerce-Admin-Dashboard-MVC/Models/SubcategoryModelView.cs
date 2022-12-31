using System.ComponentModel.DataAnnotations;
using System.Xml.Linq;

namespace E_Commerce_Admin_Dashboard_MVC.Models
{
    public class SubcategoryModelView
    {
        public int Id { get; set; }
        [Display(Name = "Brand Name")]
        [Required(ErrorMessage = "This Faild is Requerd")]
        [MinLength(4, ErrorMessage = "Must Be More Than Or Equals 4 Chars.")]
        public string BrandName { get; set; }
        [Display(Name = "Brand Name")]
        [Required(ErrorMessage = "This Faild is Requerd")]
        [MinLength(4, ErrorMessage = "Must Be More Than Or Equals 4 Chars.")]
        public string BrandNameAr { get; set; }
        [Required]
        [Display(Name = "Category")]
        public int CategoryId { get; set; }
        [Required]
        public bool? IsDeleted { get; set; } = false;
        public string CategoryName { get; set; }
        public string CategoryNameAr { get; set; }
        public DateTime created_at { get; set; } = DateTime.Now;
        public DateTime modified_at { get; set; } = DateTime.Now;

    }
}
