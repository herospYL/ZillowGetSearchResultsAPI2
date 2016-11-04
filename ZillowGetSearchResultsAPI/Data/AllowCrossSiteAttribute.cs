// --------------------------------------------------------------------------------------------------------------------
// <copyright file="AllowCrossSiteAttribute.cs" company="Liang">
//   Created By Liang Yuan
// </copyright>
// <summary>
//   Defines the AllowCrossSiteAttribute type.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace ZillowGetSearchResultsAPI.Data
{
    using System.Web.Http.Filters;

    /// <summary>The allow cross site attribute.</summary>
    public class AllowCrossSiteAttribute : ActionFilterAttribute
    {
        /// <summary>The on action executed.</summary>
        /// <param name="actionExecutedContext">The action executed context.</param>
        public override void OnActionExecuted(HttpActionExecutedContext actionExecutedContext)
        {
            actionExecutedContext.Response?.Headers.Add("Access-Control-Allow-Origin", "*");
            base.OnActionExecuted(actionExecutedContext);
        }
    }
}