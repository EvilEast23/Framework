using System;
using System.Collections.Generic;

namespace NMax.Staff.Security.Models
{
    public partial class RoleXPermission
    {
        public long ID { get; set; }
        public long RoleID { get; set; }
        public long PermissionID { get; set; }
        public virtual Permission Permission { get; set; }
        public virtual Role Role { get; set; }
    }
}
