using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace NMax.Staff.UI.Filters
{
    public class NMaxSecurity : Attribute
    {
        /// <summary>
        /// SecurityID
        /// </summary>
        public string SecurityId { get; set; }

        public NMaxSecurity(string securityId)
        {
            this.SecurityId = securityId;
        }
    }
}