using Microsoft.AspNetCore.Identity;

namespace Services { 
    public interface IAdmin
    {
        public Task AddRole(RoleCreateModel Role, RoleManager<IdentityRole> roleManager);
    }
}
