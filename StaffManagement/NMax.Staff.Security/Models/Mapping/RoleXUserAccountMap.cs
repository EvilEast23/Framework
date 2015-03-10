using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace NMax.Staff.Security.Models.Mapping
{
    public class RoleXUserAccountMap : EntityTypeConfiguration<RoleXUserAccount>
    {
        public RoleXUserAccountMap()
        {
            // Primary Key
            this.HasKey(t => t.ID);

            // Properties
            // Table & Column Mappings
            this.ToTable("RoleXUserAccount");
            this.Property(t => t.ID).HasColumnName("ID");
            this.Property(t => t.UserAccountID).HasColumnName("UserAccountID");
            this.Property(t => t.RoleID).HasColumnName("RoleID");

            // Relationships
            this.HasRequired(t => t.Role)
                .WithMany(t => t.RoleXUserAccounts)
                .HasForeignKey(d => d.RoleID);
            this.HasRequired(t => t.UserAccount)
                .WithMany(t => t.RoleXUserAccounts)
                .HasForeignKey(d => d.UserAccountID);

        }
    }
}
