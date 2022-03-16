using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace EmpManagementApplication.Auth
{

    /// <summary>
    /// This method will handle the auth Request
    /// </summary>
    /// <remarks>
    /// Placholder for Handles the custom authentications and authorizations in the class
    /// </remarks>

    public class AuthUser : ActionFilterAttribute
    {
        public override void OnActionExecuting(ActionExecutingContext filterContext)
        {

        }
    }
    public class AuthorizeUser : ActionFilterAttribute
    {
        /// <summary>
        /// This method will handle the 
        /// </summary>
        /// <remarks>
        /// Placholder for Handles the custom authorizations using authorize filter attribute
        /// </remarks>
        public AuthorizeUser()
        {

        }
    }
}