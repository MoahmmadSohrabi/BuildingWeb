using Building.DataLayer.Entities.Course;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Building.DataLayer.Entities.User
{
    public  class User
    {
        public User()
        {

        }
        [Key]
        public int UserId { get; set; }

        [Display(Name = "نام کاربری")]
        [Required(ErrorMessage = "لطفا نام کاربری را وارد کنید")]
        [MaxLength(200, ErrorMessage = "تعداد کارکتر زیاد است کارکتر زیاد است")]
        public string UserName { get; set; }

        [Display(Name = "ایمیل")]
        [Required(ErrorMessage = "لطفا ایمیل را وارد کنید")]
        [MaxLength(200, ErrorMessage = "تعداد کارکتر زیاد است کارکتر زیاد است")]
        [EmailAddress(ErrorMessage = "")]
        public string Email { get; set; }

        [Display(Name = "شماره تلفن")]
        [Required(ErrorMessage = "لطفا شماره تلفن را وارد کنید")]
        [MaxLength(200, ErrorMessage = "تعداد کارکتر زیاد است کارکتر زیاد است")]
        [EmailAddress(ErrorMessage = "")]
        public string PhoneNumber { get; set; }

        [Display(Name = "کلمه عبور")]
        [Required(ErrorMessage = "لطفا کلمه عبور را وارد کنید")]
        [MaxLength(200, ErrorMessage = "تعداد کارکتر زیاد است کارکتر زیاد است")]
        public string Password { get; set; }

        [Display(Name = "کد فعال سازی")]
        [MaxLength(50, ErrorMessage = "کد فعال سازی باید کمتر از 50 کارکتر باشد")]
        public string ActiveCode { get; set; }

        [Display(Name = "وضعیت")]
        public bool IsActive { get; set; }

        [Display(Name = "آواتار")]
        [MaxLength(200, ErrorMessage = "")]
        public string UserAvatar { get; set; }

        [Display(Name = "تاریخ عضویت")]
        public DateTime RegisterDate { get; set; }
        public bool IsDelete { get; set; }

        #region Relations
        public virtual List<UserRole> UserRoles { get; set; }
        public virtual List<Wallet.Wallet> Wallets { get; set; }
        public virtual List<Order.Order> Orders { get; set; }
        public virtual List<Comment> Comments { get; set; }
        #endregion
    }
}
