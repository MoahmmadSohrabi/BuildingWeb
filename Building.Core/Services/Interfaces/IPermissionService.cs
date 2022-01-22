using Building.DataLayer.Entities.Permission;
using Building.DataLayer.Entities.User;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Building.Core.Services.Interfaces
{
    public  interface IPermissionService
    {
        #region Roles
        List<Role> GetRoles();
        void AddRolesToUser(List<int> roleIds, int userId);
        void AddRolesToHouse(List<int> roleIds, int houseId,int userId);
        void EditRolesUser(int userId, List<int> rolesId);
        int AddRole(Role role);
        Role GetRoleById(int roleId);
        void UpdateRole(Role role);
        void DeleteRole(Role role);

        #endregion
        #region Permission
        List<Permission> GetAllPermission();
        void AddPermissionsToRole(int roleId, List<int> permission);
        List<int> PermissionsRole(int roleId);
        void UpdatePermissionsRole(int roleId, List<int> permissions);
        bool CheckPermission(int permissionId, string UserName);
        #endregion
    }
}
