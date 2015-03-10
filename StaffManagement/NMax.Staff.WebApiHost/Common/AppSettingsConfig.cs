using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.CompilerServices;
using System.Configuration;

namespace NMax.Staff.WebApiHost
{
    public static class AppSettingsConfig
    {
        private static string AppSettingValue([CallerMemberName] string key = null)
        {
            return ConfigurationManager.AppSettings[key];
        }

        public static string BaseAddress
        {
            get
            {
                return AppSettingValue();
            }
        }

        public static string ApiPath
        {
            get
            {
                return AppSettingValue();
            }
        }
    }
}
