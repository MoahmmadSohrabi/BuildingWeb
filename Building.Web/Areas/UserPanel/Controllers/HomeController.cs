using Building.Core.DTOs;
using Building.Core.Senders;
using Building.Core.Services.Interfaces;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Building.Web.Areas.UserPanel.Controllers
{
    [Area("UserPanel")]
    //[Authorize]
    public class HomeController : Controller
    {
        private IUserService _userService;
        private ICourseService _courseService;
        private IOrderService _orderService;
        public HomeController(IUserService userService, IOrderService orderService, ICourseService courseService)
        {
            _userService = userService;
            _orderService = orderService;
            _courseService = courseService;
        }
        public IActionResult Index()
        {
            return View(_userService.GetUserInformation(User.Identity.Name));
        }
        [Route("UserPanel/EditProfile")]
        public IActionResult EditProfile()
        {
            return View(_userService.GetDataForEditProfileUser(User.Identity.Name));
        }
        [HttpPost]
        [Route("UserPanel/EditProfile")]
        public IActionResult EditProfile(EditProfileViewModel profile)
        {
            if (!ModelState.IsValid)
            {
                return View(profile);
            }
            _userService.EditProfile(User.Identity.Name, profile);

            //Logout
            HttpContext.SignOutAsync(CookieAuthenticationDefaults.AuthenticationScheme);

            return Redirect("/Login?EditProfile=true");
        }
        [Route("UserPanel/ChangePassword")]
        public IActionResult ChangePassword()
        {
            return View();
        }
        [HttpPost]
        [Route("UserPanel/ChangePassword")]
        public IActionResult ChangePassword(ChangePasswordViewModel change)
        {
            string currentUserName = User.Identity.Name;
            if (!ModelState.IsValid)
            {
                return View(change);
            }
            if (!_userService.CompareOldPassword(change.OldPassword, currentUserName))
            {
                ModelState.AddModelError("OldPassword", "کلمه عبور فعلی صحیح نمی باشد");
                return View(change);
            }
            _userService.ChangeUserPassword(currentUserName, change.Password);
            ViewBag.IsSuccess = true;
            return View();
        }
        //[Route("/UserPanel/Course/")]
        //public IActionResult BuyCourse()
        //{
        //    //_orderService.AddOrder(User.Identity.Name, id);
        //    return View();
        //}
        [HttpGet]
        [Route("/UserPanel/GetSubGroups")]
        public IActionResult GetSubGroups(int id)
        {
            List<SelectListItem> list = new List<SelectListItem>()
            {
                new SelectListItem(){Text = "انتخاب کنید",Value = ""}
            };
            list.AddRange(_courseService.GetSubUserNameForManageCourse(id));
            return Json(new SelectList(list, "Value", "Text"));
        }

        [Route("UserPanel/SendMessage")]
        public IActionResult SendMessage()
        {


            if (!ModelState.IsValid)
            {
                return View();
            }
            else
            {

                var groups = _courseService.GetUserNameForManageCourse();
                ViewData["UserName"] = new SelectList(groups, "Value", "Text");
                List<SelectListItem> subgroups = new List<SelectListItem>()
            {
                new SelectListItem(){Text = "انتخاب کنید",Value = ""}
            };
                subgroups.AddRange(_courseService.GetSubUserNameForManageCourse(int.Parse(groups.First().Value)));
                string selectedSubGroup = null;

                //var subGrous = _courseService.GetSubUserNameForManageCourse(int.Parse(groups.First().Value));
                ViewData["subUserName"] = new SelectList(subgroups, "Value", "Text",selectedSubGroup);


                return View();
                //var result = _userService.SendMessage("09928401625", "با سلام جهت پرداخت شارژ");
                //return View(ViewBag.result = result);
            }


        }
    }
}
