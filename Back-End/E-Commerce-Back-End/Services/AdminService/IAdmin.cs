using Microsoft.AspNetCore.Identity;

namespace E_Commerce_Admin_Dashboard_MVC { 
    public interface IAdmin
    {
        public Task AddRole(RoleCreateModel Role, RoleManager<IdentityRole> roleManager);
    }
}
