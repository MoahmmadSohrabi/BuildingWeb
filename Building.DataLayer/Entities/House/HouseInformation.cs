using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Building.DataLayer.Entities.House
{
    public  class HouseInformation
    {
        public HouseInformation()
        {

        }
        [Key]
        public int HouseId { get; set; }
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
        //[Display(Name = "نوع قرارداد")]
        //[Required(ErrorMessage = "لطفا {0}را وارد کنید")]
        //[MaxLength(200, ErrorMessage = "لطفا طول نوشته بیشتر از 200 کارکتر نشود")]
        //اگر خواستی اجاره داده شده یا نشده را کنترل کنی این را اضافه کن
        //public bool IsDelete { get; set; }

        #region relation
        public virtual List<UserToHouse> UserToHouses { get; set; }
        #endregion
    }
}
