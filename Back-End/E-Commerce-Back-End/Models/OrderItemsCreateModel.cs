using E_CommerceDB;
using System.ComponentModel.DataAnnotations;

namespace E_Commerce_Back_End
{
    public class OrderItemsCreateModel
    {
        //public int id { get; set; }
        public int Order_Details_id { get; set; }
        public int Product_id { get; set; }
        [Required(ErrorMessage = "This field is Required")]
        public int Quantity { get; set; }
        [Required(ErrorMessage = "This field is Required")] 
        public DateTime created_at { get; set; }
        [Required(ErrorMessage = "This field is Required")] 
        public DateTime modified_at { get; set; }
        public bool IsDeleted { get; set; } = false;

    }
}
