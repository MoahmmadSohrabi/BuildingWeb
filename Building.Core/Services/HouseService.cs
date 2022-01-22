using Building.Core.DTOs;
using Building.Core.Services.Interfaces;
using Building.DataLayer.Context;
using Building.DataLayer.Entities.House;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Building.Core.DTOs.CreateHouseViewModel;

namespace Building.Core.Services
{
    public class HouseService : IHouseService
    {
        private BuildingContext _context;

        public HouseService(BuildingContext context)
        {
            _context = context;
        }

        public int AddHouse(HouseInformation houseInformation)
        {
            _context.HouseInformations.Add(houseInformation);
            _context.SaveChanges();
            return houseInformation.HouseId;
        }

        public int AddHouseFromAdmin(CreateHouseViewModel house)
        {
            HouseInformation addHouse = new HouseInformation();

            addHouse.Floor = house.Floor;
            addHouse.Cost = house.Cost;
            addHouse.Facility = house.Facility;

            return AddHouse(addHouse);
        }

        public HouseInformation GetHouseById(int houseId)
        {
            return _context.HouseInformations.Find(houseId);
        }

        public List<HouseRole> GetHouseRoles()
        {
            return _context.HouseRoles.ToList();
        }

        public List<ShowHouseForAdminViewModel> GetHousesForAdmin()
        {
            
            return _context.UserToHouses.Select(c => new ShowHouseForAdminViewModel()
            {
                
                HouseId = c.HouseId,
                UserId =c.UserId ,
                UserName = c.User.UserName,
                CreateDate=c.User.RegisterDate,
                Floor = c.HouseInformation.Floor,
                Cost=c.HouseInformation.Cost,
                HouseRoleId = c.HouseRoleId
                
            }).ToList();
        }
    }
}
