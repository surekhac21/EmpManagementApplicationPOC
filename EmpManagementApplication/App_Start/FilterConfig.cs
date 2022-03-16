using System.Web;
using System.Web.Mvc;

namespace EmpManagementApplication
{
    public class FilterConfig
    {
        /// <summary>
        /// Implement Default Register
        /// </summary>
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
            //Place holder for custom filter implementations.
        }
    }
}
