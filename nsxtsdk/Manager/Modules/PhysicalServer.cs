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
    public class PhysicalServer
    {
        private RestClient restClient;
        private int retry;
        private int timeout;
        private CancellationToken cancellationToken;

        public PhysicalServer(RestClient Client, CancellationToken _cancellationToken, int _timeout, int _retry)
        {
            restClient = Client;
            retry = _retry;
            timeout = _timeout;
            cancellationToken = _cancellationToken;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTPhysicalServerType> GetPhysicalServer(string PhysicalServerId)
        {
            if (PhysicalServerId == null) { throw new System.ArgumentNullException("PhysicalServerId cannot be null"); }
            StringBuilder GetPhysicalServerServiceURL = new StringBuilder("/fabric/physical-servers/{physical-server-id}");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Get
            };
            GetPhysicalServerServiceURL.Replace("{physical-server-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(PhysicalServerId, System.Globalization.CultureInfo.InvariantCulture)));
            request.Resource = GetPhysicalServerServiceURL.ToString();
            RestResponse<NSXTPhysicalServerType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTPhysicalServerType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Get operation to " + GetPhysicalServerServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTPhysicalServerListResultType> ListPhysicalServers(string? Cursor = null, string? DisplayName = null, string? IncludedFields = null, string? OsType = null, long? PageSize = null, bool? SortAscending = null, string? SortBy = null)
        {
            StringBuilder ListPhysicalServersServiceURL = new StringBuilder("/fabric/physical-servers");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Get
            };
            if (Cursor != null) { request.AddQueryParameter("cursor", Cursor.ToString()); }
            if (DisplayName != null) { request.AddQueryParameter("display_name", DisplayName.ToString()); }
            if (IncludedFields != null) { request.AddQueryParameter("included_fields", IncludedFields.ToString()); }
            if (OsType != null) { request.AddQueryParameter("os_type", OsType.ToString()); }
            if (PageSize != null) { request.AddQueryParameter("page_size", PageSize.ToString()); }
            if (SortAscending != null) { request.AddQueryParameter("sort_ascending", SortAscending.ToString()); }
            if (SortBy != null) { request.AddQueryParameter("sort_by", SortBy.ToString()); }
            request.Resource = ListPhysicalServersServiceURL.ToString();
            RestResponse<NSXTPhysicalServerListResultType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTPhysicalServerListResultType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Get operation to " + ListPhysicalServersServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
    }
}
