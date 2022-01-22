using Building.Core.Services.Interfaces;
using Building.DataLayer.Context;
using Building.DataLayer.Entities.Course;
using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Building.Core.Services
{
    public class CourseService : ICourseService
    {
        private BuildingContext _context;
        public CourseService(BuildingContext context)
        {
            _context = context;
        }

        public void AddBulletin(Bulletin bulletin)
        {

            _context.Bulletins.Add(bulletin);
            _context.SaveChanges();
        }

        public void AddComment(Comment comment)
        {
            _context.Comments.Add(comment);
            _context.SaveChanges();
        }

        public List<Bulletin> GetAllBulletin()
        {
            return _context.Bulletins.ToList();
        }

        public List<Comment> GetAllComment()
        {
            return _context.Comments.Where(c => !c.IsDelete).OrderByDescending(c=>c.CreateDate).ToList();
        }

        public List<CourseGroup> GetAllGroup()
        {
            return _context.CourseGroups.ToList();
        }

        public List<SelectListItem> GetSubUserNameForManageCourse(int userId)
        {
            return _context.Users.Where(g => g.UserId == userId)
               .Select(g => new SelectListItem()
               {
                   Text = g.PhoneNumber,
                   Value = g.UserId.ToString()
               }).ToList();
        }

        public List<SelectListItem> GetUserNameForManageCourse()
        {
            return _context.Users
               .Select(g => new SelectListItem()
               {
                   Text = g.UserName,
                   Value = g.UserId.ToString()
               }).ToList();
        }
    }
}
