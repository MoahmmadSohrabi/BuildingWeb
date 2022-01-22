using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Building.Core.DTOs
{
    public class RegisterViewModel
    {
        [Display(Name = "نام کاربری")]
        [Required(ErrorMessage = "لطفا نام کاربری را وارد کنید")]
        [MaxLength(200, ErrorMessage = "تعداد کارکتر زیاد است")]
        public string UserName { get; set; }
        [Display(Name = "ایمیل")]
        [Required(ErrorMessage = "لطفا ایمیل را وارد کنید")]
        [MaxLength(200, ErrorMessage = "تعداد کارکتر زیاد است")]
        [EmailAddress(ErrorMessage = "")]
        public string Email { get; set; }
        [Display(Name = "شماره تلفن")]
        [Required(ErrorMessage = "لطفا شماره تلفن را وارد کنید")]
        [MaxLength(200, ErrorMessage = "تعداد کارکتر زیاد است کارکتر زیاد است")]
        public string PhoneNumber { get; set; }
        [Display(Name = "کلمه عبور")]
        [Required(ErrorMessage = "لطفا کلمه عبور را وارد کنید")]
        [MaxLength(200, ErrorMessage = "تعداد کارکتر زیاد است کارکتر زیاد است")]
        public string Password { get; set; }
        [Display(Name = "تکرار کلمه عبور")]
        [Required(ErrorMessage = "لطفا کلمه عبور را وارد کنید")]
        [MaxLength(200, ErrorMessage = "تعداد کارکتر زیاد است کارکتر زیاد است")]
        [Compare("Password", ErrorMessage = "کلمه عبور مغایرت دارند")]
        public string RePassword { get; set; }
    }

    public class LoginViewModel
    {
        [Display(Name = "ایمیل")]
        [Required(ErrorMessage = "لطفا ایمیل را وارد کنید")]
        [MaxLength(200, ErrorMessage = "تعداد کارکتر زیاد است")]
        [EmailAddress(ErrorMessage = "ایمیل را به درستی وارد کنید")]
        public string Email { get; set; }
        [Display(Name = "کلمه عبور")]
        [Required(ErrorMessage = "لطفا کلمه عبور را وارد کنید")]
        [MaxLength(200, ErrorMessage = "تعداد کارکتر زیاد است کارکتر زیاد است")]
        public string Password { get; set; }
        [Display(Name = "مرا به خاطر بسپار")]
        public bool RememberMe { get; set; }
    }

    public class ForgotPasswordViewModel
    {
        [Display(Name = "ایمیل")]
        [Required(ErrorMessage = "لطفا ایمیل را وارد کنید")]
        [MaxLength(200, ErrorMessage = "تعداد کارکتر زیاد است کارکتر زیاد است")]
        [EmailAddress(ErrorMessage = "")]
        public string Email { get; set; }
    }

    public class ResetPasswordViewModel
    {
        public string ActiveCode { get; set; }
        [Display(Name = "کلمه عبور")]
        [Required(ErrorMessage = "لطفا کلمه عبور را وارد کنید")]
        [MaxLength(200, ErrorMessage = "تعداد کارکتر زیاد است کارکتر زیاد است")]
        public string Password { get; set; }
        [Display(Name = "تکرار کلمه عبور")]
        [Required(ErrorMessage = "لطفا کلمه عبور را وارد کنید")]
        [MaxLength(200, ErrorMessage = "تعداد کارکتر زیاد است کارکتر زیاد است")]
        [Compare("Password", ErrorMessage = "کلمه عبور مغایرت دارند")]
        public string RePassword { get; set; }
    }
}
