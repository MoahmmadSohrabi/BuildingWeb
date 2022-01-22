using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Building.Core.DTOs;
using Building.Core.Security;
using Building.Core.Services.Interfaces;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Building.Web.Pages.Admin.Users
{
    [PermissionChecker(3)]
    public class CreateUserModel : PageModel
    {
        private IUserService _userService;
        private IPermissionService _permissionService;
        public CreateUserModel(IUserService userService, IPermissionService permissionService)
        {
            _userService = userService;
            _permissionService = permissionService;
        }
        [BindProperty]
        public CreateUserViewModel CreateUserViewModel { get; set; }
        public void OnGet()
        {
            ViewData["Roles"] = _permissionService.GetRoles();
        }
        public IActionResult OnPost(List<int> SelectedRoles)
        {
            ///control por ya khali bodn field ha ro bar dashtam chon nmidonstam kodom field ro error mide ke bayad por shavad
            //if (!ModelState.IsValid)
            //{
            //    return Page();
            //}
            /////
            int userId = _userService.AddUserFromAdmin(CreateUserViewModel);
            ///Add Roles
            _permissionService.AddRolesToUser(SelectedRoles, userId);

            return Redirect("/Admin/Users");
        }
    }
}
