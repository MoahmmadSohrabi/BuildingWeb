using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Building.DataLayer.Entities.Course
{
    public class Bulletin
    {
        [Key]
        public int BulletinId { get; set; }
        [Display(Name = "عنوان اعلامیه ")]
        [Required(ErrorMessage = "لطفا {0} را وارد کنید")]
        [MaxLength(450, ErrorMessage = "{0} نمی تواند بیشتر از {1} کاراکتر باشد .")]
        public string BulletinHeader { get; set; }
        [Display(Name = "متن اعلامیه ")]
        [Required(ErrorMessage = "لطفا {0} را وارد کنید")]
        [MaxLength(450, ErrorMessage = "{0} نمی تواند بیشتر از {1} کاراکتر باشد .")]
        public string BulletinText { get; set; }
        [Display(Name = "تصویر اعلامیه ")]
        [Required(ErrorMessage = "لطفا {0} را وارد کنید")]
        [MaxLength(450, ErrorMessage = "{0} نمی تواند بیشتر از {1} کاراکتر باشد .")]
        public string? BulletinImg { get; set; }
        public DateTime CreateDate { get; set; }
    }
}
