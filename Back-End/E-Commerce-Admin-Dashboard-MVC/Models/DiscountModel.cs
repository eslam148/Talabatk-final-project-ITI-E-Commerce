using System.ComponentModel.DataAnnotations;
using System.Xml.Linq;

namespace E_Commerce_Admin_Dashboard_MVC
{
    public class DiscountModel
    {

        [Display(Name = "Discount Name")]
        [Required(ErrorMessage = "This Field is Requerd")]
        //[MinLength(4, ErrorMessage = "Must Be More Than Or Equals 4 Chars.")]
        public string Name { get; set; }
        [Display(Name = "Discount Discription")]
        [Required(ErrorMessage = "This Field is Requerd")]
        public string Description { get; set; }
        [Display(Name = "Discount Discription")]
        [Required(ErrorMessage = "This Field is Requerd")]
        public string DescriptionAr { get; set; }
        [Display(Name = "Discount Percent ")]
        [Required(ErrorMessage = "This Field is Requerd")]
        public decimal Disc_Percent { get; set; }
       

    }
}
