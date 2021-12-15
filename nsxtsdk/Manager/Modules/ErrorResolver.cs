// <auto-generated>
// Changes may cause incorrect behavior and will be lost if the code is regenerated.
// </auto-generated>

using RestSharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using Newtonsoft.Json;
using System.Net;
using nsxtsdk;
using nsxtsdk.Models;
using nsxtsdk.ManagerModels;

namespace nsxtapi.ManagerModules
{
    public class ErrorResolver
    {
        RestClient restClient;
        JsonSerializerSettings defaultSerializationSettings;
        public ErrorResolver(RestClient Client, JsonSerializerSettings DefaultSerializationSettings)
        {
            restClient = Client;
            defaultSerializationSettings = DefaultSerializationSettings;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public NSXTErrorResolverInfoType GetErrorResolverInfo(string ErrorId)
        {
            if (ErrorId == null) { throw new System.ArgumentNullException("ErrorId cannot be null"); }
            NSXTErrorResolverInfoType returnValue = default(NSXTErrorResolverInfoType);
            StringBuilder GetErrorResolverInfoServiceURL = new StringBuilder("/error-resolver/{error_id}");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.GET
            };
            request.AddHeader("Content-type", "application/json");
            GetErrorResolverInfoServiceURL.Replace("{error_id}", System.Uri.EscapeDataString(Helpers.ConvertToString(ErrorId, System.Globalization.CultureInfo.InvariantCulture)));
            request.Resource = GetErrorResolverInfoServiceURL.ToString();
            var response = restClient.Execute(request);
            if (response.StatusCode == HttpStatusCode.OK)
			{
                returnValue = JsonConvert.DeserializeObject<NSXTErrorResolverInfoType>(response.Content, defaultSerializationSettings);
			}
            else
            {
                throw new NSXTException(response.Content, response.StatusCode.ToString());
            }
            return returnValue;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public NSXTErrorResolverInfoListType ListErrorResolverInfo()
        {
            NSXTErrorResolverInfoListType returnValue = default(NSXTErrorResolverInfoListType);
            StringBuilder ListErrorResolverInfoServiceURL = new StringBuilder("/error-resolver");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.GET
            };
            request.AddHeader("Content-type", "application/json");
            request.Resource = ListErrorResolverInfoServiceURL.ToString();
            var response = restClient.Execute(request);
            if (response.StatusCode == HttpStatusCode.OK)
			{
                returnValue = JsonConvert.DeserializeObject<NSXTErrorResolverInfoListType>(response.Content, defaultSerializationSettings);
			}
            else
            {
                throw new NSXTException(response.Content, response.StatusCode.ToString());
            }
            return returnValue;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public void ResolveErrorResolveError(NSXTErrorResolverMetadataListType ErrorResolverMetadataList)
        {
            if (ErrorResolverMetadataList == null) { throw new System.ArgumentNullException("ErrorResolverMetadataList cannot be null"); }
            
            StringBuilder ResolveErrorResolveErrorServiceURL = new StringBuilder("/error-resolver?action=resolve_error");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.POST
            };
            request.AddHeader("Content-type", "application/json");
            request.AddJsonBody(JsonConvert.SerializeObject(ErrorResolverMetadataList, defaultSerializationSettings));
            request.Resource = ResolveErrorResolveErrorServiceURL.ToString();
            var response = restClient.Execute(request);
            if (response.StatusCode == HttpStatusCode.OK)
			{
                
			}
            else
            {
                throw new NSXTException(response.Content, response.StatusCode.ToString());
            }
            
        }
    }
}
