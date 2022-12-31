using E_CommerceDB;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.IdentityModel.Tokens;
using System.IdentityModel.Tokens.Jwt;
using System.Net.Mail;
using System.Net;
using System.Security.Claims;
using System.Text;
using Microsoft.AspNetCore.Authorization;

namespace E_Commerce_Back_End.Controllers
{
    //ValidationProblem()
    //    BadRequest()
    [Route("api/[controller]")]
    [ApiController]
    public class AuthController : ControllerBase
    {
        UserManager<User> UserManager;
        SignInManager<User> SignInManager;
        public static IWebHostEnvironment _environment;
        public AuthController(UserManager<User> _UserManager,
          SignInManager<User> _SignInManager,
          IWebHostEnvironment environment)
        {
            UserManager = _UserManager;
            SignInManager = _SignInManager;
            _environment = environment;
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
                if (result.IsNotAllowed == false)
                {
                    myModel.Success = false;
                    myModel.Message = "Invalid UserName Or Password ";
                    return Unauthorized(myModel);
                }
                else if (result.IsLockedOut)
                {
                    myModel.Success = false;
                    myModel.Message = "Is Locked Out";
                    return Unauthorized(myModel);
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
                            expires: DateTime.Now.AddHours(1),
                            claims: claims
                        );

                    string tokenValue = new JwtSecurityTokenHandler().WriteToken(token);
                    myModel.Success = true;
                    myModel.Message = "Successfulyy Loged In";
                    myModel.Token = tokenValue.ToString();
                    myModel.Data = new
                    {
                        id = user.Id,
                        FirstName = user.First_Name, 
                        LastName = user.Last_Name,
                        ProfileImage = user.ProfilieImage,
                        email = user.Email,
                        Roles = roles,
                        PhoneNumber= user.PhoneNumber,
                        expires = DateTime.Now.AddHours(1)
                    };
                }
            }
            return Ok(myModel);
        }

        [HttpPost]
        [Route("~/api/SignUpSeller")]
        public async Task<IActionResult> SignUpForSeller([FromBody] UserRegistrationModel model)
        {
            if (ModelState.IsValid == false)
                return null;
            else
            {
                User user = new User()
                {
                    First_Name = model.FirstName,
                    Last_Name = model.LastName,
                    UserName = model.UserName,
                    Email = model.Email,
                    PhoneNumber = model.PhoneNumber,
                };
                IdentityResult result = await UserManager.CreateAsync(user, model.Password);
                if (result.Succeeded == false)
                {
                    result.Errors.ToList().ForEach(i => { ModelState.AddModelError("", i.Description); });
                    return BadRequest(ModelState);
                }
                else
                {
                    await UserManager.AddToRoleAsync(user, "Seller");
                    //string token = await UserManager.GenerateEmailConfirmationTokenAsync(user);
                    //var client = new SmtpClient("smtp.mailtrap.io", 2525)
                    //{
                    //    Credentials = new NetworkCredential("2776941d240720", "519e53aa9648ab"),
                    //    EnableSsl = true
                    //};
                    //string body = $"Please Click Here For Verification: https://localhost:59750/User/ConfirmEmail?uid={user.Id}&token={token}";
                    //client.Send("Info@lib.edu.com", model.Email, "Email Confirmation", body);
                    return Ok(user);
                }
            }
        }



        [HttpPost]
        [Route("~/api/SignUpForBuyer")]
        public async Task<IActionResult> SignUpForBuyer([FromBody] UserRegistrationModel model)
        {
            if (ModelState.IsValid == false)
                return null;
            else
            {
                User user = new User()
                {
                    First_Name = model.FirstName,
                    Last_Name = model.LastName,
                    UserName = model.UserName,
                    Email = model.Email,
                    PhoneNumber = model.PhoneNumber,
                };
                IdentityResult result = await UserManager.CreateAsync(user, model.Password);
                if (result.Succeeded == false)
                {
                    result.Errors.ToList().ForEach(i => { ModelState.AddModelError("", i.Description); });
                    return BadRequest(ModelState);
                }
                else
                {
                    await UserManager.AddToRoleAsync(user, "Buyer");
                    //string token = await UserManager.GenerateEmailConfirmationTokenAsync(user);
                    //var client = new SmtpClient("smtp.mailtrap.io", 2525)
                    //{
                    //    Credentials = new NetworkCredential("2776941d240720", "519e53aa9648ab"),
                    //    EnableSsl = true
                    //};
                    //string body = $"Please Click Here For Verification: https://localhost:59750/User/ConfirmEmail?uid={user.Id}&token={token}";
                    //client.Send("Info@lib.edu.com", model.Email, "Email Confirmation", body);
                    return Ok(user);
                }
            }
        }

        [HttpGet]
        [Route("~/api/SignOut")]
        public new async Task<IActionResult> SignOut()
        {
            await SignInManager.SignOutAsync();
            return Ok();
        }

        [HttpPost]
        [Route("~/api/ChangePassword")]
        [Authorize]
        public async Task<IActionResult> ChangePassword([FromBody] ChangePasswordModel model)
        {
            if (ModelState.IsValid == false) return null;
            else
            {
                var user = await UserManager.FindByIdAsync(model.Id);
                var result = await UserManager.ChangePasswordAsync(user, model.CurrentPassword, model.NewPassword);
                if (result.Succeeded == true)
                {
                    return Ok(model);

                }
                else
                {
                    return BadRequest(model);
                }
            }
        }

        

        

        [HttpPost]
        [Route("~/api/EditUserInfo")]
        public async Task<ActionResult> EditUserInfo([FromBody] UserEditModel model)
        {
            ResultViewModel myModel = new ResultViewModel();

            if (ModelState.IsValid == false)
            {
                myModel.Success = false;
                myModel.Data =
                    ModelState.Values.SelectMany
                            (i => i.Errors.Select(x => x.ErrorMessage));
                return BadRequest(myModel);
            }
            else
            {
                var user = await UserManager.FindByIdAsync(model.Id);
                user.First_Name = model.FirstName;
                user.Last_Name = model.LastName;
                user.PhoneNumber = model.PhoneNumber;
                user.Email = model.Email;
                var result = await UserManager.UpdateAsync(user);
                return Ok(result);
            }
        }

    }
    
}
