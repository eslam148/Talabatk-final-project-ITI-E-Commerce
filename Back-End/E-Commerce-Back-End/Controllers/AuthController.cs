using E_CommerceDB;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.IdentityModel.Tokens;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;

namespace E_Commerce_Back_End.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AuthController : ControllerBase
    {
        UserManager<User> UserManager;
        SignInManager<User> SignInManager;
        public AuthController(UserManager<User> _UserManager,
          SignInManager<User> _SignInManager)
        {
            UserManager = _UserManager;
            SignInManager = _SignInManager;
        }
        [HttpPost]
        [Route("~/api/SignIn")]
        public async Task<IActionResult> SignIn([FromBody] LogInModel model)
        {
            ResultViewModel myModel = new ResultViewModel();
            if (ModelState.IsValid == false)
            {
                myModel.Success = false;
                myModel.Data =
                    ModelState.Values.SelectMany
                            (i => i.Errors.Select(x => x.ErrorMessage));
            }
            else
            {
                var result
                     = await SignInManager.PasswordSignInAsync
                        (model.UserName, model.Password, model.RememberMe,
                             true);
                if (result.IsNotAllowed == true)
                {
                    myModel.Success = false;
                    myModel.Message = "Invalid UserName Or Password ";
                }
                else if (result.IsLockedOut)
                {
                    myModel.Success = false;
                    myModel.Message = "Is Locked Out";
                }
                else
                {
                    var user = await UserManager.FindByNameAsync(model.UserName);
                    List<Claim> claims = new List<Claim>();
                    var roles = await UserManager.GetRolesAsync(user);
                    roles.ToList().ForEach(i =>
                    {
                        claims.Add(new Claim(ClaimTypes.Role, i));
                    });

                    JwtSecurityToken token
                        = new JwtSecurityToken
                        (
                            signingCredentials:
                             new SigningCredentials
                             (
                                 new SymmetricSecurityKey(Encoding.ASCII.GetBytes("IOLJYHSDSIoleJHsdsdsas98WeWsdsdQweweHgsgdf_&6#2"))
                                 ,
                                 SecurityAlgorithms.HmacSha256
                             ),
                            expires: DateTime.Now.AddDays(1),
                            claims: claims
                        );

                    string tokenValue = new JwtSecurityTokenHandler().WriteToken(token);
                    myModel.Success = true;
                    myModel.Message = "Successfulyy Loged In";
                    myModel.Data = new
                    {
                        User = user,
                        Toekn = tokenValue,
                        Roles = roles
                    };
                }
            }
            return Ok(myModel);
        }
    }
}
