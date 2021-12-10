using System.Web;
using System.Web.Mvc;

namespace CRUD_MVC_12_10_2021_1132
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
