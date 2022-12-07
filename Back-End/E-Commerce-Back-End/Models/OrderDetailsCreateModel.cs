using E_Commerce_Back_End.Models;
using E_CommerceDB;
using System.ComponentModel.DataAnnotations;

namespace E_Commerce_Back_End
{
    public class OrderDetailsCreateModel
    {
        //public int Id { get; set; }
        public string User_id { get; set; }
        [Required(ErrorMessage = "This field is Required")]
        public decimal Total { get; set; }
        public int Payment_id { get; set; }
        [Required(ErrorMessage = "This field is Required")]
        public DateTime Created_at { get; set; }
        [Required(ErrorMessage = "This field is Required")]
        public DateTime Modified_at { get; set; }
        public bool IsDeleted { get; set; } = false;

        public int Progress { get; set; } = 0;

    }
}
