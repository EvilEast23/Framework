using System;
using System.Collections.Generic;

namespace NMax.Staff.Security.Models
{
    public partial class Role
    {
        public Role()
        {
            this.RoleXPermissions = new List<RoleXPermission>();
            this.RoleXUserAccounts = new List<RoleXUserAccount>();
        }

        public long ID { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public virtual ICollection<RoleXPermission> RoleXPermissions { get; set; }
        public virtual ICollection<RoleXUserAccount> RoleXUserAccounts { get; set; }
    }
}
