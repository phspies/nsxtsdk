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
    public class BridgeEndpointProfile
    {
        private RestClient restClient;
        private int retry;
        private int timeout;
        private CancellationToken cancellationToken;

        public BridgeEndpointProfile(RestClient Client, CancellationToken _cancellationToken, int _timeout, int _retry)
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
        public async Task<NSXTBridgeEndpointProfileType> UpdateBridgeEndpointProfile(string BridgeendpointprofileId, NSXTBridgeEndpointProfileType BridgeEndpointProfile)
        {
            if (BridgeendpointprofileId == null) { throw new System.ArgumentNullException("BridgeendpointprofileId cannot be null"); }
            if (BridgeEndpointProfile == null) { throw new System.ArgumentNullException("BridgeEndpointProfile cannot be null"); }
            StringBuilder UpdateBridgeEndpointProfileServiceURL = new StringBuilder("/bridge-endpoint-profiles/{bridgeendpointprofile-id}");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Put
            };
            UpdateBridgeEndpointProfileServiceURL.Replace("{bridgeendpointprofile-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(BridgeendpointprofileId, System.Globalization.CultureInfo.InvariantCulture)));
            request.AddJsonBody(BridgeEndpointProfile);
            request.Resource = UpdateBridgeEndpointProfileServiceURL.ToString();
            RestResponse<NSXTBridgeEndpointProfileType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTBridgeEndpointProfileType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Put operation to " + UpdateBridgeEndpointProfileServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTBridgeEndpointProfileType> GetBridgeEndpointProfile(string BridgeendpointprofileId)
        {
            if (BridgeendpointprofileId == null) { throw new System.ArgumentNullException("BridgeendpointprofileId cannot be null"); }
            StringBuilder GetBridgeEndpointProfileServiceURL = new StringBuilder("/bridge-endpoint-profiles/{bridgeendpointprofile-id}");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Get
            };
            GetBridgeEndpointProfileServiceURL.Replace("{bridgeendpointprofile-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(BridgeendpointprofileId, System.Globalization.CultureInfo.InvariantCulture)));
            request.Resource = GetBridgeEndpointProfileServiceURL.ToString();
            RestResponse<NSXTBridgeEndpointProfileType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTBridgeEndpointProfileType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Get operation to " + GetBridgeEndpointProfileServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task DeleteBridgeEndpointProfile(string BridgeendpointprofileId)
        {
            if (BridgeendpointprofileId == null) { throw new System.ArgumentNullException("BridgeendpointprofileId cannot be null"); }
            StringBuilder DeleteBridgeEndpointProfileServiceURL = new StringBuilder("/bridge-endpoint-profiles/{bridgeendpointprofile-id}");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Delete
            };
            DeleteBridgeEndpointProfileServiceURL.Replace("{bridgeendpointprofile-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(BridgeendpointprofileId, System.Globalization.CultureInfo.InvariantCulture)));
            request.Resource = DeleteBridgeEndpointProfileServiceURL.ToString();
            RestResponse response = await restClient.ExecuteTaskAsyncWithPolicy(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Delete operation to " + DeleteBridgeEndpointProfileServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTBridgeEndpointProfileType> CreateBridgeEndpointProfile(NSXTBridgeEndpointProfileType BridgeEndpointProfile)
        {
            if (BridgeEndpointProfile == null) { throw new System.ArgumentNullException("BridgeEndpointProfile cannot be null"); }
            StringBuilder CreateBridgeEndpointProfileServiceURL = new StringBuilder("/bridge-endpoint-profiles");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Post
            };
            request.AddJsonBody(BridgeEndpointProfile);
            request.Resource = CreateBridgeEndpointProfileServiceURL.ToString();
            RestResponse<NSXTBridgeEndpointProfileType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTBridgeEndpointProfileType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Post operation to " + CreateBridgeEndpointProfileServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTBridgeEndpointProfileListResultType> ListBridgeEndpointProfiles(string? Cursor = null, string? EdgeClusterId = null, string? FailoverMode = null, string? IncludedFields = null, long? PageSize = null, bool? SortAscending = null, string? SortBy = null)
        {
            StringBuilder ListBridgeEndpointProfilesServiceURL = new StringBuilder("/bridge-endpoint-profiles");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Get
            };
            if (Cursor != null) { request.AddQueryParameter("cursor", Cursor.ToString()); }
            if (EdgeClusterId != null) { request.AddQueryParameter("edge_cluster_id", EdgeClusterId.ToString()); }
            if (FailoverMode != null) { request.AddQueryParameter("failover_mode", FailoverMode.ToString()); }
            if (IncludedFields != null) { request.AddQueryParameter("included_fields", IncludedFields.ToString()); }
            if (PageSize != null) { request.AddQueryParameter("page_size", PageSize.ToString()); }
            if (SortAscending != null) { request.AddQueryParameter("sort_ascending", SortAscending.ToString()); }
            if (SortBy != null) { request.AddQueryParameter("sort_by", SortBy.ToString()); }
            request.Resource = ListBridgeEndpointProfilesServiceURL.ToString();
            RestResponse<NSXTBridgeEndpointProfileListResultType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTBridgeEndpointProfileListResultType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Get operation to " + ListBridgeEndpointProfilesServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
    }
}
