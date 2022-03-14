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
    public class UpgradeEULA
    {
        RestClient restClient;
        JsonSerializerSettings defaultSerializationSettings;
        int retry;
        int timeout;
        CancellationToken cancellationToken;
        public UpgradeEULA(RestClient Client, JsonSerializerSettings DefaultSerializationSettings, CancellationToken _cancellationToken, int _timeout, int _retry)

        {
            restClient = Client;
            defaultSerializationSettings = DefaultSerializationSettings;
            retry = _retry;
            timeout = _timeout;
            cancellationToken = _cancellationToken;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task AcceptUpgradeEULA()
        {
            
            StringBuilder AcceptUpgradeEULAServiceURL = new StringBuilder("/upgrade/eula/accept");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.POST
            };
            request.AddHeader("Content-type", "application/json");
            request.Resource = AcceptUpgradeEULAServiceURL.ToString();
            IRestResponse response = await restClient.ExecuteTaskAsyncWithPolicy(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP POST operation to " + AcceptUpgradeEULAServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, null);
			}
            
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTEULAContentType> GetUpgradeEulacontent(string? Cursor = null, string? IncludedFields = null, long? PageSize = null, bool? SortAscending = null, string? SortBy = null, string? ValueFormat = null)
        {
            NSXTEULAContentType returnValue = default(NSXTEULAContentType);
            StringBuilder GetUpgradeEulacontentServiceURL = new StringBuilder("/upgrade/eula/content");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.GET
            };
            request.AddHeader("Content-type", "application/json");
            if (Cursor != null) { request.AddQueryParameter("cursor", Cursor.ToString()); }
            if (IncludedFields != null) { request.AddQueryParameter("included_fields", IncludedFields.ToString()); }
            if (PageSize != null) { request.AddQueryParameter("page_size", PageSize.ToString()); }
            if (SortAscending != null) { request.AddQueryParameter("sort_ascending", SortAscending.ToString()); }
            if (SortBy != null) { request.AddQueryParameter("sort_by", SortBy.ToString()); }
            if (ValueFormat != null) { request.AddQueryParameter("value_format", ValueFormat.ToString()); }
            request.Resource = GetUpgradeEulacontentServiceURL.ToString();
            IRestResponse<NSXTEULAContentType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTEULAContentType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP GET operation to " + GetUpgradeEulacontentServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, null);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTEULAAcceptanceType> GetUpgradeEulaacceptance()
        {
            NSXTEULAAcceptanceType returnValue = default(NSXTEULAAcceptanceType);
            StringBuilder GetUpgradeEulaacceptanceServiceURL = new StringBuilder("/upgrade/eula/acceptance");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.GET
            };
            request.AddHeader("Content-type", "application/json");
            request.Resource = GetUpgradeEulaacceptanceServiceURL.ToString();
            IRestResponse<NSXTEULAAcceptanceType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTEULAAcceptanceType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP GET operation to " + GetUpgradeEulaacceptanceServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, null);
			}
            return response.Data;
        }
    }
}
