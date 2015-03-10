using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;

namespace NMax.Staff.Security.Models.Handlers
{
    public class RoleXUserAccountHandler
    {
        public List<RoleXUserAccount> LoadByUserName(string userName)
        {
            using (var db = new NMaxStaffContext())
            {
                var rxuaList = db.RoleXUserAccounts.Include(c => c.Role)
                                                   .Where(c => c.UserAccount.UserName == userName);
                return rxuaList.ToList();
            }
        }
    }
}