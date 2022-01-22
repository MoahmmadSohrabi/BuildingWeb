using Building.DataLayer.Entities.Permission;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Building.DataLayer.Entities.User
{
    public  class Role
    {
        public Role()
        {

        }
        [Key]
        public int RoleId { get; set; }
        [Display(Name = "عنوان نقش")]
        [Required(ErrorMessage = "لطفا نام کاربر را وارد کنید")]
        [MaxLength(200, ErrorMessage = "لطفا طول نوشته بیشتر از 200 کارکتر نشود")]
        public string RoleTitle { get; set; }
        public bool IsDelete { get; set; }

        #region Relations
        public virtual List<UserRole> UserRoles { get; set; }
        public List<RolePermission> RolePermissions { get; set; }
        #endregion
    }
}
