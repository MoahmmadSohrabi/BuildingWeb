using Building.DataLayer.Entities.Course;
using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Building.Core.Services.Interfaces
{
    public interface ICourseService
    {
        #region Group
        List<CourseGroup> GetAllGroup();
        //List<SelectListItem> GetGroupForManageCourse();
        //List<SelectListItem> GetSubGroupForManageCourse(int groupId);
        #endregion

        #region SendMessage
        List<SelectListItem> GetUserNameForManageCourse();
        List<SelectListItem> GetSubUserNameForManageCourse(int userId);
        #endregion

        #region Comment
        void AddComment(Comment comment);
        List<Comment> GetAllComment();
        
        #endregion

        #region Bulletin
        void AddBulletin(Bulletin bulletin);
        List<Bulletin> GetAllBulletin();

        #endregion
    }
}
