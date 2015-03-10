using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NMax.Staff.Security.Models;
using NMax.Staff.Security.Models.Handlers;

namespace NMax.Staff.Security
{
    public class NMaxSecurityManager
    {
        public static string GetHashPassword(string password)
        {
            return password.GetHashCode().ToString();
        }

        public UserAccount Login(string username, string hashPassword)
        {
            UserAccountHandler uaHandler = new UserAccountHandler();
            UserAccount ua = uaHandler.LoadByUserNameAndPassword(username, hashPassword);
            if (ua != null && ua.Status == "Active")
            {
                ua.LastLogon = DateTime.Now;
                uaHandler.Update(ua);
                // If it can retrieve the useraccount object with no exception means login ok
                // we can now set the principle to the current thread
                NMaxIdentity identity = new NMaxIdentity(username);
                NMaxPrincipal principal = new NMaxPrincipal(identity);
                System.Threading.Thread.CurrentPrincipal = principal;
            }
            return ua;
        }

        public bool IsUserInRole(string userName, string roleOrPermissionName)
        {
            //first step, check the user belongs to a role
            RoleXUserAccountHandler rxuaHandler = new RoleXUserAccountHandler();
            RoleXPermissionHandler rxpHandler = new RoleXPermissionHandler();
            List<RoleXUserAccount> rxuaList = rxuaHandler.LoadByUserName(userName);
            foreach (RoleXUserAccount rxua in rxuaList)
            {
                if (rxua.Role.Name.ToUpper() == roleOrPermissionName.ToUpper())
                {
                    return true;
                }
                List<RoleXPermission> rxpList = rxpHandler.LoadByRoleNameAndPermissionName(rxua.Role.Name, roleOrPermissionName);
                if (rxpList.Count > 0)
                {
                    return true;
                }
            }
            //second step, check the user has permission
            UserAccountXPermissionHandler uaxpHandler = new UserAccountXPermissionHandler();
            List<UserAccountXPermission> uaxpList = uaxpHandler.LoadByUserNameAndPermissionName(userName, roleOrPermissionName);
            if (uaxpList.Count > 0)
            {
                return true;
            }
            return false;
        }
    }
}
