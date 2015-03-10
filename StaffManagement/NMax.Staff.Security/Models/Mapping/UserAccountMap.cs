using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace NMax.Staff.Security.Models.Mapping
{
    public class UserAccountMap : EntityTypeConfiguration<UserAccount>
    {
        public UserAccountMap()
        {
            // Primary Key
            this.HasKey(t => t.ID);

            // Properties
            this.Property(t => t.UserName)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.Password)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.Email)
                .IsRequired()
                .HasMaxLength(100);

            this.Property(t => t.Status)
                .IsRequired()
                .HasMaxLength(15);

            this.Property(t => t.ApplicationName)
                .IsRequired()
                .HasMaxLength(250);

            this.Property(t => t.PasswordQuestion)
                .HasMaxLength(250);

            this.Property(t => t.PasswordAnswer)
                .HasMaxLength(250);

            // Table & Column Mappings
            this.ToTable("UserAccount");
            this.Property(t => t.ID).HasColumnName("ID");
            this.Property(t => t.CreatedDate).HasColumnName("CreatedDate");
            this.Property(t => t.CreatedBy).HasColumnName("CreatedBy");
            this.Property(t => t.LastModifiedDate).HasColumnName("LastModifiedDate");
            this.Property(t => t.LastModifiedBy).HasColumnName("LastModifiedBy");
            this.Property(t => t.UserName).HasColumnName("UserName");
            this.Property(t => t.Password).HasColumnName("Password");
            this.Property(t => t.Email).HasColumnName("Email");
            this.Property(t => t.Status).HasColumnName("Status");
            this.Property(t => t.LastLogon).HasColumnName("LastLogon");
            this.Property(t => t.ApplicationName).HasColumnName("ApplicationName");
            this.Property(t => t.PasswordQuestion).HasColumnName("PasswordQuestion");
            this.Property(t => t.PasswordAnswer).HasColumnName("PasswordAnswer");
            this.Property(t => t.IsOnline).HasColumnName("IsOnline");
            this.Property(t => t.FailedPasswordAttemptCount).HasColumnName("FailedPasswordAttemptCount");
            this.Property(t => t.FailedPasswordAttemptStartTime).HasColumnName("FailedPasswordAttemptStartTime");
            this.Property(t => t.FailedPasswordAnswerAttemptCount).HasColumnName("FailedPasswordAnswerAttemptCount");
            this.Property(t => t.FailedPasswordAnswerAttemptStartTime).HasColumnName("FailedPasswordAnswerAttemptStartTime");
            this.Property(t => t.RequireOneTimePassword).HasColumnName("RequireOneTimePassword");
        }
    }
}
