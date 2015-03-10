using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NMax.Staff.Security.Models.Handlers
{
    public class UserAccountHandler
    {
        public UserAccount LoadByUserNameAndPassword(string username, string password)
        {
            using (var context = new NMaxStaffContext())
            {
                UserAccount ua = context.UserAccounts.Where(x => x.UserName == username && x.Password == password).FirstOrDefault();
                return ua;
            }
        }

        public void Update(UserAccount ua)
        {
            using (var context = new NMaxStaffContext())
            {
                context.Entry<UserAccount>(ua).State = System.Data.Entity.EntityState.Modified;
                context.SaveChanges();
            }
        }

    }
}
