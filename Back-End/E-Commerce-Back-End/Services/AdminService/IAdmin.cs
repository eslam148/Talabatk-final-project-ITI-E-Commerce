using Microsoft.AspNetCore.Identity;

namespace E_Commerce_Back_End
{ 
    public interface IAdmin
    {
        public Task AddRole(RoleCreateModel Role, RoleManager<IdentityRole> roleManager);
    }
}
