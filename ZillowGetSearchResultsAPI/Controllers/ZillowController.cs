// --------------------------------------------------------------------------------------------------------------------
// <copyright file="ZillowController.cs" company="Liang">
//   Liang Yuan
// </copyright>
// <summary>
//   Defines the ValuesController type.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace ZillowGetSearchResultsAPI.Controllers
{
    using System;
    using System.Collections.Specialized;
    using System.IO;
    using System.Net;
    using System.Net.Http;
    using System.Threading.Tasks;
    using System.Web;
    using System.Web.Http;
    using System.Xml;

    using Swashbuckle.Swagger.Annotations;

    using ZillowGetSearchResultsAPI.Data;

    /// <summary>The values controller.</summary>
    public class ZillowController : ApiController
    {
        /// <summary>The ZWS ID.</summary>
        private const string ZWSID = "X1-ZWz1fi61fdynm3_9r65p";

        /// <summary>The zillow root.</summary>
        private const string ZillowRoot = "http://www.zillow.com/webservice/GetSearchResults.htm";

        // GET api/zillow

        /// <summary>The get.</summary>
        /// <returns>The <see cref="Task"/>.</returns>
        [SwaggerOperation("Get")]
        [SwaggerResponse(HttpStatusCode.OK)]
        [SwaggerResponse(HttpStatusCode.NotFound)]
        [SwaggerResponse(HttpStatusCode.BadRequest)]
        [AllowCrossSite]
        public async Task<string> Get()
        {
            string result = null;
            var col = this.Request.RequestUri.ParseQueryString();
            using (var client = new HttpClient())
            {
                using (var response = await client.GetAsync(GenerateRequestUrl(col)))
                {
                    if (response.StatusCode != HttpStatusCode.OK)
                    {
                        throw new HttpResponseException(response);
                    }

                    try
                    {
                        using (var stream = await response.Content.ReadAsStreamAsync())
                        {
                            var xmlDocument = new XmlDocument();
                            xmlDocument.Load(stream);
                            result = xmlDocument.OuterXml;
                        }
                    }
                    catch (Exception e)
                    {
                        throw new HttpResponseException(
                                  new HttpResponseMessage(HttpStatusCode.BadRequest)
                                  {
                                      Content = new StringContent(e.Message)
                                  });
                    }
                }
            }

            return result;
        }

        // GET api/zillow/id

        /// <summary>The get test.</summary>
        /// <param name="id">The id.</param>
        /// <returns>The <see cref="string"/>.</returns>
        [SwaggerOperation("GetById")]
        [SwaggerResponse(HttpStatusCode.OK)]
        [SwaggerResponse(HttpStatusCode.NotFound)]
        [AllowCrossSite]
        public string Get(int id)
        {
            string path = "C:\\Users\\liang.yuan\\Desktop\\Business Entities\\ZillowGetSearchResultsAPI\\ZillowGetSearchResultsAPI2\\ZillowGetSearchResultsAPI\\sample-response.xml";
            string ret = null;

            using (var reader = new StreamReader(path))
            {
                var xmlDocument = new XmlDocument();
                xmlDocument.Load(reader);
                ret = xmlDocument.OuterXml;
            }

            return ret;
        }

        /// <summary>The generate request url.</summary>
        /// <param name="rawCollection">The raw Collection.</param>
        /// <returns>The <see cref="Uri"/>.</returns>
        private static Uri GenerateRequestUrl(NameValueCollection rawCollection)
        {
            var collection = HttpUtility.ParseQueryString(string.Empty);
            collection["zws-id"] = ZWSID;

            if (rawCollection != null)
            {
                if (rawCollection["address"] != null)
                {
                    collection["address"] = rawCollection["address"];
                }

                if (rawCollection["citystatezip"] != null)
                {
                    collection["citystatezip"] = rawCollection["citystatezip"];
                }
            }

            var builder = new UriBuilder(ZillowRoot) { Query = collection.ToString() };
            return builder.Uri;
        }
    }
}
