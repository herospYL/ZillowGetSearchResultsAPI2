// --------------------------------------------------------------------------------------------------------------------
// <copyright file="WebApiConfig.cs" company="Liang">
//   Created By Liang Yuan
// </copyright>
// <summary>
//   Defines the WebApiConfig type.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace ZillowGetSearchResultsAPI
{
    using System.Web.Http;

    /// <summary>The web API config.</summary>
    public static class WebApiConfig
    {
        /// <summary>The register.</summary>
        /// <param name="config">The config.</param>
        public static void Register(HttpConfiguration config)
        {
            // Web API configuration and services

            // Web API routes
            config.MapHttpAttributeRoutes();

            config.Routes.MapHttpRoute(
                name: "DefaultApi",
                routeTemplate: "api/{controller}/{id}",
                defaults: new { id = RouteParameter.Optional });
        }
    }
}
