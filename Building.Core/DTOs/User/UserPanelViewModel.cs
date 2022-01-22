using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Building.Core.DTOs
{
    public class InformationUserViewModel
    {
        public string UserName { get; set; }
        public string Email { get; set; }
        public DateTime RegisterDate { get; set; }
        public int Wallet { get; set; }
    }
    public class SideBarUserPanelViewModel
    {
        public string UserName { get; set; }
        public DateTime RegisterDate { get; set; }
        public string ImageName { get; set; }
    }
    public class EditProfileViewModel
    {
        [Display(Name = "نام کاربری")]
        [Required(ErrorMessage = "لطفا نام کاربری را وارد کنید")]
        [MaxLength(200, ErrorMessage = "تعداد کارکتر زیاد است کارکتر زیاد است")]
        public string UserName { get; set; }
        [Display(Name = "ایمیل")]
        [Required(ErrorMessage = "لطفا ایمیل را وارد کنید")]
        [MaxLength(200, ErrorMessage = "تعداد کارکتر زیاد است کارکتر زیاد است")]
        [EmailAddress(ErrorMessage = "")]
        public string Email { get; set; }
        public IFormFile UserAvatar { get; set; }
        public string AvatarName { get; set; }
    }
    public class ChangePasswordViewModel
    {
        [Display(Name = " کلمه عبور فعلی")]
        [Required(ErrorMessage = "لطفا کلمه عبور را وارد کنید")]
        [MaxLength(200, ErrorMessage = "تعداد کارکتر زیاد است کارکتر زیاد است")]
        public string OldPassword { get; set; }
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
