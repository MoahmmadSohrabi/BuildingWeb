using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Building.DataLayer.Entities.Order
{
    public class Order
    {
        [Key]
        public int OrderId { get; set; }
        [Required]
        public int UserId { get; set; }
        //برای در نظر گرفتن تخفیف از این استفاده میشه حالا جلوتر ببینیم ضروری هست که ما هم استفاده کنیم یا خیر
        public int OrderSum { get; set; }
        public bool IsFinaly { get; set; }
        [Required]
        public DateTime CreateDate { get; set; }

        #region Relation
        [ForeignKey("UserId")]
        public virtual User.User User { get; set; }
        #endregion
    }
}
