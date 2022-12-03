using Castle.Core.Configuration;
using Services;
using E_CommerceDB;
using Microsoft.AspNetCore.Identity;

namespace Services
{
    public class AdminServeice: IAdmin
    {
        public  LibraryContext db;
        IConfiguration con;
        RoleManager<IdentityRole> RoleManager;

        public AdminServeice(LibraryContext _db, IConfiguration _con)
        {
            db = new LibraryContext(); //_db;
            con = _con;
        }

        public async Task AddRole(RoleCreateModel Role, RoleManager<IdentityRole> roleManager)
        {
            
            RoleManager = roleManager;

            await RoleManager.CreateAsync(new IdentityRole { Name=Role.Name });

        }

      
    }
}
