using System;
using System.Collections.Generic;

namespace NMax.Staff.Security.Models
{
    public partial class UserAccountXPermission
    {
        public long ID { get; set; }
        public long UserAccountID { get; set; }
        public long PermissionID { get; set; }
        public virtual Permission Permission { get; set; }
        public virtual UserAccount UserAccount { get; set; }
    }
}
