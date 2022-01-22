using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Building.Core.Services.Interfaces;
using Building.DataLayer.Entities.Course;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using static Building.Core.DTOs.CreateHouseViewModel;

namespace Building.Web.Pages.Admin
{

    public class IndexModel : PageModel
    {
        private IHouseService _houseService;
        private ICourseService _courseService;
        private IOrderService _orderService;
        public IndexModel(IHouseService houseService, ICourseService courseService, IOrderService orderService)
        {
            _houseService = houseService;
            _courseService = courseService;
            _orderService = orderService;
        }
        public List<Bulletin> bulletins { get; set; }
        public List<ShowHouseForAdminViewModel> ListHouse { get; set; }
        public List<ShowOrderForAdminViewModel> ListOrder { get; set; }
        public void OnGet()
        {
            ListHouse = _houseService.GetHousesForAdmin();
            bulletins = _courseService.GetAllBulletin();
            ListOrder = _orderService.GetAllOrderForAdmin();

        }
    }
}
