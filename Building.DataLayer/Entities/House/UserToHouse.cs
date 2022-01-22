using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Building.DataLayer.Entities.House
{
    public  class UserToHouse
    {
        public UserToHouse()
        {

        }
        [Key]
        public int UT_Id { get; set; }
        public int HouseId { get; set; }
        public int UserId { get; set; }
        public int HouseRoleId { get; set; }

        #region Relation
        [ForeignKey("HouseId")]
        public virtual HouseInformation HouseInformation { get; set; }
        public virtual User.User User { get; set; }
        public virtual HouseRole HouseRole { get; set; }

        #endregion
    }
}
