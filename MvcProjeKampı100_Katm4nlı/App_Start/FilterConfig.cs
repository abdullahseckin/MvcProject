using System.Web;
using System.Web.Mvc;

namespace MvcProjeKampı100_Katm4nlı
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
