using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using NMax.Staff.Security.Models.Mapping;

namespace NMax.Staff.Security.Models
{
    public partial class NMaxStaffContext : DbContext
    {
        static NMaxStaffContext()
        {
            Database.SetInitializer<NMaxStaffContext>(null);
        }

        public NMaxStaffContext()
            : base("Name=NMaxStaffContext")
        {
        }

        public DbSet<Permission> Permissions { get; set; }
        public DbSet<Role> Roles { get; set; }
        public DbSet<RoleXPermission> RoleXPermissions { get; set; }
        public DbSet<RoleXUserAccount> RoleXUserAccounts { get; set; }
        public DbSet<UserAccount> UserAccounts { get; set; }
        public DbSet<UserAccountXPermission> UserAccountXPermissions { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Configurations.Add(new PermissionMap());
            modelBuilder.Configurations.Add(new RoleMap());
            modelBuilder.Configurations.Add(new RoleXPermissionMap());
            modelBuilder.Configurations.Add(new RoleXUserAccountMap());
            modelBuilder.Configurations.Add(new UserAccountMap());
            modelBuilder.Configurations.Add(new UserAccountXPermissionMap());
        }
    }
}
