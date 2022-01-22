using Building.Core.DTOs;
using Building.DataLayer.Entities.House;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Building.Core.DTOs.CreateHouseViewModel;

namespace Building.Core.Services.Interfaces
{
    public  interface IHouseService
    {
        #region House
        int AddHouse(HouseInformation houseInformation);
        int AddHouseFromAdmin(CreateHouseViewModel house);
        List<HouseRole> GetHouseRoles();

        List<ShowHouseForAdminViewModel> GetHousesForAdmin();

        HouseInformation GetHouseById(int ouseId);
        #endregion
    }
}
