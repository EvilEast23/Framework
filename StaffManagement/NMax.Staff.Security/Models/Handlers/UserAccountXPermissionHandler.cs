using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NMax.Staff.Security.Models.Handlers
{
    public class UserAccountXPermissionHandler
    {
        public List<UserAccountXPermission> LoadByUserNameAndPermissionName(string userName, string permissionName)
        {
            using (var db = new NMaxStaffContext())
            {
                return db.UserAccountXPermissions.Where(x => x.UserAccount.UserName == userName && x.Permission.Name == permissionName).ToList();
            }
        }
    }
}
