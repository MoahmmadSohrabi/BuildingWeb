using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Building.DataLayer.Entities.House
{
    public class HouseRole
    {
        public HouseRole()
        {

        }
        [Key]
        public int HouseRoleId { get; set; }
        public string HouseRoleTitle { get; set; }

        #region Relations
        public virtual List<UserToHouse> UserToHouses { get; set; }

        #endregion
    }
}
