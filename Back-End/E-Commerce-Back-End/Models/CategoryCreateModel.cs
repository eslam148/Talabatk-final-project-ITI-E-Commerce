using Castle.Core.Resource;
using E_CommerceDB;
using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.Xml.Linq;

namespace E_Commerce_Back_End
{
    public class CategoryCreateModel
    {
        public int Id { get; set; }
        [Display(Name = "CategoryName")]
        [Required(ErrorMessage = "Required")]
        [MinLength(4, ErrorMessage = "MinLength")]
         public string Name { get; set; }
        [Display(Name = "CategoryName")]
        [Required(ErrorMessage = "Required")]
        [MinLength(4, ErrorMessage = "MinLength")]
        public string NameAr { get; set; }
        [MinLength(4, ErrorMessage = "MinLength")]
        [Display(Name = "Description")]
        [Required(ErrorMessage = "Required")]
        [DataType(DataType.MultilineText)]
        public string Description { get; set; }
        public DateTime created_at { get; set; } = DateTime.Now;
        public DateTime modified_at { get; set; }= DateTime.Now;
        public DateTime deleted_at { get; set; }=DateTime.Now;

   
    }
}
