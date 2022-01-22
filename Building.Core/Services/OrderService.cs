using Building.Core.DTOs;
using Building.Core.Services.Interfaces;
using Building.DataLayer.Context;
using Building.DataLayer.Entities.Order;
using Building.DataLayer.Entities.Wallet;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Building.Core.DTOs.CreateHouseViewModel;

namespace Building.Core.Services
{
    public class OrderService : IOrderService
    {
        private BuildingContext _context;
        private IUserService _userService;
        public OrderService(BuildingContext context, IUserService userService)
        {
            _context = context;
            _userService = userService;
        }
        public int AddOrder(string userName, int courseId)
         {
            int userId = _userService.GetUserIdByUserName(userName);

            Order order = _context.Orders
                .FirstOrDefault(o => o.UserId == userId && !o.IsFinaly);

            var course = _context.Courses.Find(courseId);

            //if (order==null)
            //{
                order = new Order()
                {
                    UserId = userId,
                    IsFinaly = false,
                    CreateDate = DateTime.Now,
                    OrderSum=course.CoursePrice

                };
                _context.Orders.Add(order);
                //_context.Add(order);
                _context.SaveChanges();

            //}
            //else
            //{
            //    //دستورات جزئیات فاکتور 
            //}

            return order.OrderId;
        }

        public bool FinalyOrder(string userName, int orderId)
        {
            int userId = _userService.GetUserIdByUserName(userName);

            var order = _context.Orders.FirstOrDefault(o=>o.OrderId==orderId && o.UserId==userId);

            if (order==null || order.IsFinaly)
            {
                return false;
            }

            if (_userService.BalanceUserWallet(userName)>= order.OrderSum)
            {
                order.IsFinaly = true;
                _userService.AddWallet(new Wallet()
                {
                    Amount=order.OrderSum,
                    CreateDate=DateTime.Now,
                    IsPay=true,
                    Description="فاکتور شما #"+order.OrderId,
                    UserId=userId,
                    TypeId=2
                });
                _context.Orders.Update(order);
                _context.SaveChanges();
                return true;
            }
            return false;
        }

        public List<CreateHouseViewModel.ShowOrderForAdminViewModel> GetAllOrderForAdmin()
        {
            return _context.Orders.Select(c => new ShowOrderForAdminViewModel()
            {

                OrderId = c.OrderId,
                UserId = c.UserId,
                UserName = c.User.UserName,
                CreateDate = c.CreateDate,
                OrderSum = c.OrderSum,
                IsFinaly=c.IsFinaly

            }).ToList();
        }

        public Order GetOrderForUserPanel(string userName, int orderId)
        {
            int userId = _userService.GetUserIdByUserName(userName);
            //این قسمت یک اینکلود کورس هم داره اگه مشکل پیش آمد

            return _context.Orders.FirstOrDefault(o => o.UserId == userId && o.OrderId == orderId);
        }

        public List<Order> GetUserOrders(string userName)
        {
            int userId = _userService.GetUserIdByUserName(userName);
            return _context.Orders.Where(o => o.UserId == userId).ToList();
        }
    }
}
