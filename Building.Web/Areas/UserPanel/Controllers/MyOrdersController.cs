using Building.Core.Services.Interfaces;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Building.Web.Areas.UserPanel.Controllers
{
    [Area("UserPanel")]
    public class MyOrdersController : Controller
    {
        private IOrderService _orderService;
        public MyOrdersController(IOrderService orderService)
        {
            _orderService = orderService;
        }
        public IActionResult Index()
        {
            return View(_orderService.GetUserOrders(User.Identity.Name));
        }

        public IActionResult ShowOrder(int id,bool finaly=false)
        {
            var order = _orderService.GetOrderForUserPanel(User.Identity.Name, id);
            if (order==null)
            {
                return NotFound();
            }
            ViewBag.finaly = finaly;
            return View(order);
        }

        public IActionResult FinalyOrder(int id) 
        {
            if (_orderService.FinalyOrder(User.Identity.Name,id))
            {

                return Redirect("/UserPanel/MyOrders/ShowOrder/" + id + "?finaly=true");
            }
            return BadRequest();
        }
    }
}
