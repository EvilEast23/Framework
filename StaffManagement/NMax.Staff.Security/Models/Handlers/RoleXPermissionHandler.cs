using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NMax.Staff.Security.Models.Handlers
{
    public class RoleXPermissionHandler
    {
        public List<RoleXPermission> LoadByRoleNameAndPermissionName(string roleName, string permissionName)
        {
            using (var db = new NMaxStaffContext())
            {
                return db.RoleXPermissions.Where(x => x.Role.Name == roleName && x.Permission.Name == permissionName).ToList();
            }
        }
    }
}
