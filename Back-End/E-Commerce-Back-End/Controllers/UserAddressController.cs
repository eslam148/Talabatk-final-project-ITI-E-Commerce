using E_Commerce_Admin_Dashboard_MVC;
using E_Commerce_Admin_Dashboard_MVC.Services;
using E_Commerce_Back_End.Models;
using E_Commerce_Back_End.Services;
using E_CommerceDB;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace E_Commerce_Back_End.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserAddressController : ControllerBase
    {
        private readonly Iaddress userAddress;
        public UserAddressController(Iaddress _userAddress)
        {
            userAddress= _userAddress;
        }
        
        [HttpPost]
        [Route("~/api/AddUserAddress")]
        public IActionResult AddUserAddress(UserAddressCreateModel addressModel)
        {
            if (ModelState.IsValid)
            {
                userAddress.AddAddress(addressModel);
                return Ok("UserAdrress Is Added Successfully");
            }
            else
            {
                return BadRequest("Validation Error");
            }
        }

    }
}
