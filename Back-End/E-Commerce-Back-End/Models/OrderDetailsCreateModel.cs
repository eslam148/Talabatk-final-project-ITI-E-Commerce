using E_CommerceDB;

namespace E_Commerce_Back_End
{
    public class OrderDetailsCreateModel
    {
        public int Id { get; set; }
        public string User_id { get; set; }
        public decimal Total { get; set; }
        public int Payment_id { get; set; }

        public DateTime Created_at { get; set; }
        public DateTime Modified_at { get; set; }
        public bool? IsDeleted { get; set; } = false;

        public enum Progress
        {
            Pending=0,
            Delivered=1
        };

    }
}
