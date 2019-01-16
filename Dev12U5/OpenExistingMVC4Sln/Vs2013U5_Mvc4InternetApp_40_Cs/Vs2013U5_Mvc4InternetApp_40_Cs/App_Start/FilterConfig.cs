using System.Web;
using System.Web.Mvc;

namespace Vs2013U5_Mvc4InternetApp_40_Cs
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}