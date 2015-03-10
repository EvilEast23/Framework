using NMax.Staff.Security.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;
using System.Web;
using System.Web.Security;

namespace NMax.Staff.Security
{
    public class NMaxIdentity : IIdentity
    {
        public NMaxIdentity(string name)
        {
            this.Name = name;
        }
        
        public string Name
        {
            get;
            private set;
        }
        //public NMaxIdentity(UserAccount identityObject)
        //{
        //    this.IdentityObject = identityObject;
        //}

        //public UserAccount IdentityObject
        //{
        //    get;
        //    private set;
        //}

        public string AuthenticationType
        {
            get { return "NMaxIdentity"; }
        }

        public bool IsAuthenticated 
        {
            get
            {
                //var cookie = FormsAuthentication.GetAuthCookie(HttpContext.Current.User.Identity.Name, false);
                return !string.IsNullOrEmpty(this.Name);
            }
        }

    }
}
