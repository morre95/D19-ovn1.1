using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace D19_ovn1._1
{
    internal static class UrlHelper
    {

        public static bool IsValidUrl(string url)
        {
            if (!Uri.IsWellFormedUriString(url, UriKind.RelativeOrAbsolute))
            {
                return false; 
            }
            return true;
        }

    }
}
