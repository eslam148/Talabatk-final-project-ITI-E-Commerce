
using E_Commerce_Back_End.Models;
using E_Commerce_Back_End.Services;
using E_CommerceDB;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Data;
using Microsoft.AspNetCore.Authorization;

namespace E_Commerce_Back_End.Controllers
{
    [Authorize]
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
                return Ok(addressModel);
            }
            else
            {
                return BadRequest("Validation Error");
            }
        }

    }
}
