// --------------------------------------------------------------------------------------------------------------------
// <copyright file="GoogleMapKeyController.cs" company="Liang">
//   Created By Liang Yuan
// </copyright>
// <summary>
//   Defines the GoogleMapKeyController type.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace ZillowGetSearchResultsAPI.Controllers
{
    using System.Net;
    using System.Web.Http;

    using Swashbuckle.Swagger.Annotations;

    /// <summary>The google map key controller.</summary>
    public class GoogleMapKeyController : ApiController
    {
        /// <summary>The google map key.</summary>
        private const string GoogleMapKey = "AIzaSyD3E1D9b-Z7ekrT3tbhl_dy8DCXuIuDDRc";

        // GET api/google-map-key

        /// <summary>The get.</summary>
        /// <returns>The <see cref="string"/>.</returns>
        [SwaggerOperation("Get")]
        [SwaggerResponse(HttpStatusCode.OK)]
        public string Get()
        {
            return GoogleMapKey;
        }
    }
}