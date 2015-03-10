using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;

namespace NMax.Staff.Security
{
    public class NMaxPrincipal : IPrincipal
    {
        public NMaxPrincipal(NMaxIdentity identity)
        {
            this.Identity = identity;
        }

        public IIdentity Identity
        {
            get;
            private set;
        }

        private NMaxIdentity nmaxIdentity
        {
            get
            {
                return Identity as NMaxIdentity;
            }
        }

        public bool IsInRole(string role)
        {
            NMaxSecurityManager securityManager = new NMaxSecurityManager();
            if (securityManager.IsUserInRole(nmaxIdentity.Name, role))
            {
                return true;
            }
            return false;
        }
    }
}
