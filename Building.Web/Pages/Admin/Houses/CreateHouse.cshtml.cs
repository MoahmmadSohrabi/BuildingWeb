using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using Building.Core.DTOs;
using Building.Core.Services.Interfaces;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Building.Web.Pages.Admin.Houses
{
    public class CreateHouseModel : PageModel
    {
        private IPermissionService _permissionService;
        private IHouseService _houseService;
        
        public CreateHouseModel(IHouseService houseService,IPermissionService permissionService)
        {
            _houseService = houseService;
            _permissionService = permissionService;
        }
        [BindProperty]
        public CreateHouseViewModel CreateHouseViewModel { get; set; }
        //public EditUserViewModel EditUserViewModel { get; set; }
        public void OnGet()
        {
            ViewData["Roles"] = _houseService.GetHouseRoles();
        }
        public IActionResult OnPost(List<int> SelectedRoles)
        {
            ///control por ya khali bodn field ha ro bar dashtam chon nmidonstam kodom field ro error mide ke bayad por shavad
            //if (!ModelState.IsValid)
            //{
            //    return Page();
            //}
            /////
            int houseId = _houseService.AddHouseFromAdmin(CreateHouseViewModel);
            //////////چجوری یوزر ایدی رو بگیرم نمیدونم
            var userId = User.FindFirstValue(ClaimTypes.NameIdentifier);
            ///Add Roles
            _permissionService.AddRolesToHouse(SelectedRoles, houseId,int.Parse(userId));

            return Redirect("/Admin/Users");
        }
    }
}
