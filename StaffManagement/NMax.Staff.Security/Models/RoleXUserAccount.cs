using System;
using System.Collections.Generic;

namespace NMax.Staff.Security.Models
{
    public partial class RoleXUserAccount
    {
        public long ID { get; set; }
        public long UserAccountID { get; set; }
        public long RoleID { get; set; }
        public virtual Role Role { get; set; }
        public virtual UserAccount UserAccount { get; set; }
    }
}
