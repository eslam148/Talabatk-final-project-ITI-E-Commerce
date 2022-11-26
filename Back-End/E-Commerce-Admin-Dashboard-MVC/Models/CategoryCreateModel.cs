using Castle.Core.Resource;
using System.ComponentModel.DataAnnotations;
using System.Xml.Linq;

namespace E_Commerce_Admin_Dashboard_MVC.Models
{
    public class CategoryCreateModel
    {
        [Display(Name = "Category Name")]
        [Required(ErrorMessage = "This Faild is Requerd")]
        [MinLength(4, ErrorMessage = "Must Be More Than Or Equals 4 Chars.")]
         public string Name { get; set; }
        [Required]
        [MinLength(5)]
        [Display(Name = "Category Description")]
        [DataType(DataType.MultilineText)]
        public string Description { get; set; }
        public DateTime created_at { get; set; } = DateTime.Now;
        public DateTime modified_at { get; set; }= DateTime.Now;
        public DateTime deleted_at { get; set; }=DateTime.Now;

    }
}
