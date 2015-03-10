using System;
using System.Collections.Generic;

namespace NMax.Staff.Security.Models
{
    public partial class UserAccount
    {
        public UserAccount()
        {
            this.RoleXUserAccounts = new List<RoleXUserAccount>();
            this.UserAccountXPermissions = new List<UserAccountXPermission>();
        }

        public long ID { get; set; }
        public System.DateTime CreatedDate { get; set; }
        public long CreatedBy { get; set; }
        public System.DateTime LastModifiedDate { get; set; }
        public long LastModifiedBy { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
        public string Email { get; set; }
        public string Status { get; set; }
        public System.DateTime LastLogon { get; set; }
        public string ApplicationName { get; set; }
        public string PasswordQuestion { get; set; }
        public string PasswordAnswer { get; set; }
        public bool IsOnline { get; set; }
        public Nullable<short> FailedPasswordAttemptCount { get; set; }
        public Nullable<System.DateTime> FailedPasswordAttemptStartTime { get; set; }
        public Nullable<short> FailedPasswordAnswerAttemptCount { get; set; }
        public Nullable<System.DateTime> FailedPasswordAnswerAttemptStartTime { get; set; }
        public bool RequireOneTimePassword { get; set; }
        public virtual ICollection<RoleXUserAccount> RoleXUserAccounts { get; set; }
        public virtual ICollection<UserAccountXPermission> UserAccountXPermissions { get; set; }
    }
}
