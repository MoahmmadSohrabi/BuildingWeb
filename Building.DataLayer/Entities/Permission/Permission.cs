using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Building.DataLayer.Entities.Permission
{
    public class Permission
    {
        [Key]
        public int PermissionId { get; set; }
        [Display(Name = "عنوان نقش")]
        [Required(ErrorMessage = "لطفا {0}را وارد کنید")]
        [MaxLength(200, ErrorMessage = "لطفا طول نوشته بیشتر از 200 کارکتر نشود")]
        public string PermissionTitle { get; set; }
        public int? ParentID { get; set; }
        [ForeignKey("ParentID")]
        public List<Permission> Permissions { get; set; }
        public List<RolePermission> RolePermissions { get; set; }
    }
}
