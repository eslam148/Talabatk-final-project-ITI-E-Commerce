using E_Commerce_Back_End.Models;
using E_Commerce_Back_End.Services;
using E_CommerceDB;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace E_Commerce_Back_End.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PaymentController : ControllerBase
    {
        private readonly IuserPayment userpayemet;
        private readonly Ipayment paymentDetails;
        public PaymentController(IuserPayment _userpayemet, Ipayment _paymentDetails)
        {
            userpayemet = _userpayemet;
            paymentDetails = _paymentDetails;
        }

        [HttpPost]
        [Route("~/api/AddUserPayment")]
        public IActionResult AddUserPayment(UserPaymentCreateModel userPaymentModel)
        {
            if (ModelState.IsValid)
            {
               userpayemet.AddUserPayment(userPaymentModel);
                return Ok("User Payments Is Added Successfully");
            }
            else
            {
                return BadRequest("Validation Error");
            }
        }

        [HttpPost]
        [Route("~/api/AddPaymentDetails")]
        public IActionResult AddPaymentDetails(PaymentDetailsCreateModel paymentDetailsModel)
        {
            if (ModelState.IsValid)
            {
                paymentDetails.AddPayment(paymentDetailsModel);
                return Ok("Payment Details Is Added Successfully");
            }
            else
            {
                return BadRequest("Validation Error");
            }
        }
    }
}
