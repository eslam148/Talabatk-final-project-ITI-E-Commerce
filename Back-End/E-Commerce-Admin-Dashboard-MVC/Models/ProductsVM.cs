namespace E_Commerce_Admin_Dashboard_MVC.Models
{
    public class ProductsVM
    {
        public int No { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        //public string SKU { get; set; }
        public int Price { get; set; }
        public DateTime created_at { get; set; }
        public DateTime modified_at { get; set; }
        public DateTime deleted_at { get; set; }
        public string Category { get; set; }
        public int inventory_Id { get; set; }
        public string? Discount { get; set; }
        public int Progress { get; set; } = 0;
        public bool? IsDeleted { get; set; } = false;
    }
}
