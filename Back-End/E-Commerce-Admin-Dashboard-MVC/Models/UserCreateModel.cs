namespace E_Commerce_Admin_Dashboard_MVC.Models
{
    public class UserCreateModel
    {
        public string First_Name { get; set; }
        public string Last_Name { get; set; }
        public string Email { get; set; }
        public string UserName { get; set; }
        public string PhoneNumber { get; set; }

        public DateTime Created_at { get; set; } = DateTime.Now;
        public DateTime modified_at { get; set; } = DateTime.Now;

        public bool IsDeleted { get; set; } = false;
        public string Role { get; set; }
       
    }
}
