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
    public class BridgeEndpoint
    {
        private RestClient restClient;
        private int retry;
        private int timeout;
        private CancellationToken cancellationToken;

        public BridgeEndpoint(RestClient Client, CancellationToken _cancellationToken, int _timeout, int _retry)
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
        public async Task<NSXTBridgeEndpointType> CreateBridgeEndpoint(NSXTBridgeEndpointType BridgeEndpoint)
        {
            if (BridgeEndpoint == null) { throw new System.ArgumentNullException("BridgeEndpoint cannot be null"); }
            StringBuilder CreateBridgeEndpointServiceURL = new StringBuilder("/bridge-endpoints");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Post
            };
            request.AddJsonBody(BridgeEndpoint);
            request.Resource = CreateBridgeEndpointServiceURL.ToString();
            RestResponse<NSXTBridgeEndpointType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTBridgeEndpointType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Post operation to " + CreateBridgeEndpointServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTBridgeEndpointListResultType> ListBridgeEndpoints(string? BridgeClusterId = null, string? BridgeEndpointProfileId = null, string? Cursor = null, string? IncludedFields = null, string? LogicalSwitchId = null, long? PageSize = null, bool? SortAscending = null, string? SortBy = null, string? VlanTransportZoneId = null)
        {
            StringBuilder ListBridgeEndpointsServiceURL = new StringBuilder("/bridge-endpoints");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Get
            };
            if (BridgeClusterId != null) { request.AddQueryParameter("bridge_cluster_id", BridgeClusterId.ToString()); }
            if (BridgeEndpointProfileId != null) { request.AddQueryParameter("bridge_endpoint_profile_id", BridgeEndpointProfileId.ToString()); }
            if (Cursor != null) { request.AddQueryParameter("cursor", Cursor.ToString()); }
            if (IncludedFields != null) { request.AddQueryParameter("included_fields", IncludedFields.ToString()); }
            if (LogicalSwitchId != null) { request.AddQueryParameter("logical_switch_id", LogicalSwitchId.ToString()); }
            if (PageSize != null) { request.AddQueryParameter("page_size", PageSize.ToString()); }
            if (SortAscending != null) { request.AddQueryParameter("sort_ascending", SortAscending.ToString()); }
            if (SortBy != null) { request.AddQueryParameter("sort_by", SortBy.ToString()); }
            if (VlanTransportZoneId != null) { request.AddQueryParameter("vlan_transport_zone_id", VlanTransportZoneId.ToString()); }
            request.Resource = ListBridgeEndpointsServiceURL.ToString();
            RestResponse<NSXTBridgeEndpointListResultType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTBridgeEndpointListResultType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Get operation to " + ListBridgeEndpointsServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTBridgeEndpointType> UpdateBridgeEndpoint(string BridgeendpointId, NSXTBridgeEndpointType BridgeEndpoint)
        {
            if (BridgeendpointId == null) { throw new System.ArgumentNullException("BridgeendpointId cannot be null"); }
            if (BridgeEndpoint == null) { throw new System.ArgumentNullException("BridgeEndpoint cannot be null"); }
            StringBuilder UpdateBridgeEndpointServiceURL = new StringBuilder("/bridge-endpoints/{bridgeendpoint-id}");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Put
            };
            UpdateBridgeEndpointServiceURL.Replace("{bridgeendpoint-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(BridgeendpointId, System.Globalization.CultureInfo.InvariantCulture)));
            request.AddJsonBody(BridgeEndpoint);
            request.Resource = UpdateBridgeEndpointServiceURL.ToString();
            RestResponse<NSXTBridgeEndpointType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTBridgeEndpointType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Put operation to " + UpdateBridgeEndpointServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTBridgeEndpointType> GetBridgeEndpoint(string BridgeendpointId)
        {
            if (BridgeendpointId == null) { throw new System.ArgumentNullException("BridgeendpointId cannot be null"); }
            StringBuilder GetBridgeEndpointServiceURL = new StringBuilder("/bridge-endpoints/{bridgeendpoint-id}");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Get
            };
            GetBridgeEndpointServiceURL.Replace("{bridgeendpoint-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(BridgeendpointId, System.Globalization.CultureInfo.InvariantCulture)));
            request.Resource = GetBridgeEndpointServiceURL.ToString();
            RestResponse<NSXTBridgeEndpointType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTBridgeEndpointType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Get operation to " + GetBridgeEndpointServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task DeleteBridgeEndpoint(string BridgeendpointId)
        {
            if (BridgeendpointId == null) { throw new System.ArgumentNullException("BridgeendpointId cannot be null"); }
            StringBuilder DeleteBridgeEndpointServiceURL = new StringBuilder("/bridge-endpoints/{bridgeendpoint-id}");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Delete
            };
            DeleteBridgeEndpointServiceURL.Replace("{bridgeendpoint-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(BridgeendpointId, System.Globalization.CultureInfo.InvariantCulture)));
            request.Resource = DeleteBridgeEndpointServiceURL.ToString();
            RestResponse response = await restClient.ExecuteTaskAsyncWithPolicy(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Delete operation to " + DeleteBridgeEndpointServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            
        }
    }
}
