
using E_CommerceDB;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace E_Commerce_Back_End.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class OrderController : ControllerBase
    {
        private readonly Iorder order;
        public OrderController(Iorder _order)
        {
            order = _order;
        }

        [HttpPost]
        [Route("~/api/AddOrderItems")]
        public IActionResult AddOrderItems(OrderItemsCreateModel[] orderItemsModel)
        {
            if (ModelState.IsValid)
            {
                order.AddOrder(orderItemsModel);
                return Ok(orderItemsModel);
            }
            else
            {
                return BadRequest("Validation Error");
            }
        }

        [HttpPost]
        [Route("~/api/AddOrderDetails")]
        public IActionResult AddOrderDetails(OrderDetailsCreateModel orderDetailsModel)
        {
            if (ModelState.IsValid)
            {
               var OrderDetalis =  order.AddOrderDetails(orderDetailsModel);
                return Ok(OrderDetalis);
            }
            else
            {
                return BadRequest(orderDetailsModel);
            }
        }
    }
}
