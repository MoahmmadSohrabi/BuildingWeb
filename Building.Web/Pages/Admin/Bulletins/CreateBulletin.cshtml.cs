using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Building.Core.Services.Interfaces;
using Building.DataLayer.Entities.Course;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Building.Web.Pages.Admin.Bulletins
{
    public class CreateBulletinModel : PageModel
    {
        private ICourseService _courseService;
        public CreateBulletinModel(ICourseService courseService)
        {
            _courseService = courseService;
        }
        [BindProperty]
        public Bulletin bulletin { get; set; }
        public void OnGet()
        {

        }

        public IActionResult OnPost()
        {
            _courseService.AddBulletin(bulletin); ;
            return RedirectToPage("/Admin/Bulletins/CreateBulletin");
        }

        
    }
}
