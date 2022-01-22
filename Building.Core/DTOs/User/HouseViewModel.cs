using Building.DataLayer.Entities.House;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Building.Core.DTOs
{
    public class CreateHouseViewModel
    {

        [Display(Name = "طبقه")]
        [Required(ErrorMessage = "لطفا {0}را وارد کنید")]
        [MaxLength(200, ErrorMessage = "لطفا طول نوشته بیشتر از 200 کارکتر نشود")]
        public string Floor { get; set; }
        [Display(Name = "هزینه")]
        [Required(ErrorMessage = "لطفا {0}را وارد کنید")]
        [MaxLength(200, ErrorMessage = "لطفا طول نوشته بیشتر از 200 کارکتر نشود")]
        public string Cost { get; set; }
        [Display(Name = "امکانات")]
        [Required(ErrorMessage = "لطفا {0}را وارد کنید")]
        [MaxLength(200, ErrorMessage = "لطفا طول نوشته بیشتر از 200 کارکتر نشود")]
        public string Facility { get; set; }
        public int UserId { get; set; }
        //[Display(Name = "نوع قرارداد")]
        //[Required(ErrorMessage = "لطفا {0}را وارد کنید")]
        //[MaxLength(200, ErrorMessage = "لطفا طول نوشته بیشتر از 200 کارکتر نشود")]
        //public List<HouseRole> houseRoles { get; set; }

        public class ShowHouseForAdminViewModel
        {
            public int UT_Id { get; set; }
            public string UserName { get; set; }
            public DateTime CreateDate { get; set; }
            public int HouseId { get; set; }
            public string Floor { get; set; }
            public string Cost { get; set; }
            public int UserId { get; set; }
            public int HouseRoleId { get; set; }
        }



        public class ShowOrderForAdminViewModel
        {
            public int OrderId { get; set; }
            public int UserId { get; set; }
            public string UserName { get; set; }
            public int OrderSum { get; set; }
            public bool IsFinaly { get; set; }
            public DateTime CreateDate { get; set; }
        }

    }
}
