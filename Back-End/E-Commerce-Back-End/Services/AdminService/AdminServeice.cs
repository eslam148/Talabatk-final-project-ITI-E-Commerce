using E_CommerceDB;
using Microsoft.AspNetCore.Identity;

namespace E_Commerce_Back_End
{
    public class AdminServeice: IAdmin
    {
        private LibraryContext db;
        IConfiguration con;
        RoleManager<IdentityRole> RoleManager;

        public AdminServeice(LibraryContext _db, IConfiguration _con)
        {
            db = _db;
            con = _con;
        }

        public async Task AddRole(RoleCreateModel Role, RoleManager<IdentityRole> roleManager)
        {
            
            RoleManager = roleManager;

            await RoleManager.CreateAsync(new IdentityRole { Name=Role.Name });

        }

      
    }
}
