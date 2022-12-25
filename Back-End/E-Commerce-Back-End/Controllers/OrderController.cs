
using E_CommerceDB;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace E_Commerce_Back_End.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [Authorize]
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

        [HttpGet]
        [Route("~/api/GetOrderDetails/{Id}")]
        public async Task<IActionResult> GetOrderDetails(string Id)
        {
            var OrderDetails =  order.GetOrderDetails(Id);
            if (OrderDetails != null)
            {

                return Ok(OrderDetails);
            }
            else
            {
                return BadRequest();
            }
        }
       

        [HttpGet]
        [Route("~/api/GetOrderitems/{Id}")]
        public async Task<IActionResult> GetOrderItems(int Id)
        {
            var OrderItems = await order.GetOrderItems(Id);
            if (OrderItems != null)
            {
                
                return Ok(OrderItems);
            }
            else
            {
                return BadRequest();
            }
        }
    }
}
