using System.Web;
using System.Web.Mvc;

namespace WEEK14_ANDAYA_CRUD2
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
