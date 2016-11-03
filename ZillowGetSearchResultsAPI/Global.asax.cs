// --------------------------------------------------------------------------------------------------------------------
// <copyright file="Global.asax.cs" company="Liang">
//   Created By Liang Yuan
// </copyright>
// <summary>
//   Defines the WebApiApplication type.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace ZillowGetSearchResultsAPI
{
    using System.Web.Http;

    /// <summary>The web API application.</summary>
    public class WebApiApplication : System.Web.HttpApplication
    {
        /// <summary>The application_ start.</summary>
        protected void Application_Start()
        {
            GlobalConfiguration.Configure(WebApiConfig.Register);
        }
    }
}
