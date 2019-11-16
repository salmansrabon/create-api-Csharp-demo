using System.Web;
using System.Web.Mvc;

namespace API_Creating_With_Stored_Procedure
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}