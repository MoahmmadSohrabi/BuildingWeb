using Building.DataLayer.Entities.Order;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Building.Core.DTOs.CreateHouseViewModel;

namespace Building.Core.Services.Interfaces
{
    public  interface IOrderService
    {
        int AddOrder(string userName, int courseId);
        Order GetOrderForUserPanel(string userName,int orderId);
        bool FinalyOrder(string userName,int orderId);
        List<Order> GetUserOrders(string userName);
        List<ShowOrderForAdminViewModel> GetAllOrderForAdmin();
    }
}
