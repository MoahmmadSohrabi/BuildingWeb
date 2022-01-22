using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Building.DataLayer.Entities.Wallet
{
    public class Wallet
    {
        public Wallet()
        {

        }
        [Key]
        public int WalletId { get; set; }
        [Display(Name = "نوع تراکنش")]
        public int TypeId { get; set; }
        [Display(Name = "کاربر")]
        [Required(ErrorMessage = "لطفا نام کاربر را وارد کنید")]
        public int UserId { get; set; }
        [Display(Name = "مبلغ")]

        public int Amount { get; set; }
        [Display(Name = "شرح")]

        public string Description { get; set; }
        [Display(Name = "تایید شده")]

        public bool IsPay { get; set; }
        [Display(Name = "تاریخ و ساعت")]

        public DateTime CreateDate { get; set; }


        public virtual User.User User { get; set; }
        public virtual WalletType WalletType { get; set; }
    }
}
