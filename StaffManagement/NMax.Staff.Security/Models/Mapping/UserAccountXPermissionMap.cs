using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace NMax.Staff.Security.Models.Mapping
{
    public class UserAccountXPermissionMap : EntityTypeConfiguration<UserAccountXPermission>
    {
        public UserAccountXPermissionMap()
        {
            // Primary Key
            this.HasKey(t => t.ID);

            // Properties
            // Table & Column Mappings
            this.ToTable("UserAccountXPermission");
            this.Property(t => t.ID).HasColumnName("ID");
            this.Property(t => t.UserAccountID).HasColumnName("UserAccountID");
            this.Property(t => t.PermissionID).HasColumnName("PermissionID");

            // Relationships
            this.HasRequired(t => t.Permission)
                .WithMany(t => t.UserAccountXPermissions)
                .HasForeignKey(d => d.PermissionID);
            this.HasRequired(t => t.UserAccount)
                .WithMany(t => t.UserAccountXPermissions)
                .HasForeignKey(d => d.UserAccountID);

        }
    }
}
