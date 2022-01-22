using Building.Core.Services.Interfaces;
using Building.DataLayer.Entities.Course;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Building.Web.Areas.UserPanel.Controllers
{
    [Area("UserPanel")]
    public class CourseController : Controller
    {
        private ICourseService _courseService;
        private IOrderService _orderService;

        public CourseController(ICourseService courseService, IOrderService orderService)
        {
            _courseService = courseService;
            _orderService = orderService;
        }
        //[BindProperty]
        //public Course Course { get; set; }
        //public IActionResult Index(int pageId = 1, string filter = ""
        //    , string getType = "all", string orderByType = "date",
        //    int startPrice = 0, int endPrice = 0, List<int> selectedGroups = null)
        //{
        //    //ViewBag.selectedGroups = selectedGroups;
        //    //ViewBag.Groups = _courseService.GetAllGroup();
        //    //ViewBag.pageId = pageId;
        //    //return View(_courseService.GetCourse(pageId, filter, getType, orderByType, startPrice, endPrice, selectedGroups, 9));
        //}


        //[Route("ShowCourse/{id}")]
        //public IActionResult ShowCourse(int id)
        //{
        //    //var course = _courseService.GetCourseForShow(id);
        //    //if (course == null)
        //    //{
        //    //    return NotFound();
        //    //}

        //    return View(course);
        //}

        //[Authorize]

        [Route("/UserPanel/Course/")]
        public ActionResult BuyCourse(int id)
        {
           int orderId= _orderService.AddOrder(User.Identity.Name, id);
            return Redirect("/Userpanel/MyOrders/ShowOrder/"+orderId);
            //return View();
        }

        //public ActionResult Factor()
        //{
        //    //_orderService.AddOrder(User.Identity.Name, id);
        //    //return Redirect("/ShowCourse/" + id);
        //    return View();
        //}
    }
}
