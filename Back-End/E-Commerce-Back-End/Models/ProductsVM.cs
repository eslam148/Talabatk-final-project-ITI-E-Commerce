using System.ComponentModel.DataAnnotations;

namespace E_Commerce_Back_End
{
    public class ProductsVM
    {
        //[Required]
        ////public int id { set; get; }
        //public int No { get; set; }
        //[Required(ErrorMessage = "Name is Required")]
        //public string Name { get; set; }
        //[Required(ErrorMessage = "Description Required")]
        //[DataType(DataType.MultilineText)]
        //public string Description { get; set; }
        ////public string SKU { get; set; }
        //[Required(ErrorMessage = "Price is Required")]
        //public int Price { get; set; }
        //[Required (ErrorMessage = "Record Required")]
        //public DateTime created_at { get; set; }
        //[Required(ErrorMessage = "Record Required")]
        //public DateTime modified_at { get; set; }

        //public DateTime? deleted_at { get; set; }

        //public string Category { get; set; }
        //[Required(ErrorMessage = "Category Required")]
        //public int subCategory { get; set; }
        //public int? inventory_Id { get; set; }
        //public int DiscountID { get; set; }

        //public string Discount { get; set; }
        //public int? Progress { get; set; } = 0;
        //public bool? IsDeleted { get; set; } = false;
        //[Required(ErrorMessage = "Qunatity is Required")]
        //public int Qauntity { get; set; }

        //public int? SelledQauntity { get; set; } = 0;
        //public string? SellerId { get; set; }

        [Required]
        public int No { get; set; }
        [Required(ErrorMessage = "Name is Required")]
        public string Name { get; set; }
        [Required(ErrorMessage = "Name is Required")]
        public string NameAr { get; set; }
        [Required(ErrorMessage = "Description Required")]
        [DataType(DataType.MultilineText)]
        public string Description { get; set; }
        [Required(ErrorMessage = "Description Required")]
        [DataType(DataType.MultilineText)]
        public string DescriptionAr { get; set; }
        //public string SKU { get; set; }
        [Required(ErrorMessage = "Price is Required")]
        public int Price { get; set; }
        [Required(ErrorMessage = "Record Required")]
        public DateTime created_at { get; set; }
        [Required(ErrorMessage = "Record Required")]
        public DateTime modified_at { get; set; }

        public DateTime? deleted_at { get; set; }

        public string Category { get; set; }
        public string CategoryAr { get; set; }
        [Required(ErrorMessage = "Category Required")]
        public int subCategory { get; set; }
        public int? inventory_Id { get; set; }
        public int DiscountID { get; set; }

        public string Discount { get; set; }
        public int? Progress { get; set; } = 0;
        public bool? IsDeleted { get; set; } = false;
        [Required(ErrorMessage = "Qunatity is Required")]
        public int Quantity { get; set; }

        public int ratingCount { get; set; } = 0;
        public int totalRating { get; set; } = 0;

        public int? SelledQauntity { get; set; } = 0;
        public string? SellerId { get; set; }
        //  [Required(ErrorMessage = "Images is Required at least one")]

        public List<IFormFile> Images { get; set; }
        public List<string> images2 { get; set; }


    }
}
