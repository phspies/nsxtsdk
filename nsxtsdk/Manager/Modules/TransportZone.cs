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
    public class TransportZone
    {
        private RestClient restClient;
        private int retry;
        private int timeout;
        private CancellationToken cancellationToken;

        public TransportZone(RestClient Client, CancellationToken _cancellationToken, int _timeout, int _retry)
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
        public async Task<NSXTTransportZoneType> UpdateTransportZone(string ZoneId, NSXTTransportZoneType TransportZone)
        {
            if (ZoneId == null) { throw new System.ArgumentNullException("ZoneId cannot be null"); }
            if (TransportZone == null) { throw new System.ArgumentNullException("TransportZone cannot be null"); }
            StringBuilder UpdateTransportZoneServiceURL = new StringBuilder("/transport-zones/{zone-id}");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Put
            };
            UpdateTransportZoneServiceURL.Replace("{zone-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(ZoneId, System.Globalization.CultureInfo.InvariantCulture)));
            request.AddJsonBody(TransportZone);
            request.Resource = UpdateTransportZoneServiceURL.ToString();
            RestResponse<NSXTTransportZoneType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTTransportZoneType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Put operation to " + UpdateTransportZoneServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTTransportZoneType> GetTransportZone(string ZoneId)
        {
            if (ZoneId == null) { throw new System.ArgumentNullException("ZoneId cannot be null"); }
            StringBuilder GetTransportZoneServiceURL = new StringBuilder("/transport-zones/{zone-id}");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Get
            };
            GetTransportZoneServiceURL.Replace("{zone-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(ZoneId, System.Globalization.CultureInfo.InvariantCulture)));
            request.Resource = GetTransportZoneServiceURL.ToString();
            RestResponse<NSXTTransportZoneType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTTransportZoneType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Get operation to " + GetTransportZoneServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task DeleteTransportZone(string ZoneId)
        {
            if (ZoneId == null) { throw new System.ArgumentNullException("ZoneId cannot be null"); }
            StringBuilder DeleteTransportZoneServiceURL = new StringBuilder("/transport-zones/{zone-id}");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Delete
            };
            DeleteTransportZoneServiceURL.Replace("{zone-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(ZoneId, System.Globalization.CultureInfo.InvariantCulture)));
            request.Resource = DeleteTransportZoneServiceURL.ToString();
            RestResponse response = await restClient.ExecuteTaskAsyncWithPolicy(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Delete operation to " + DeleteTransportZoneServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTTransportZoneStatusType> GetTransportZoneStatus(string ZoneId)
        {
            if (ZoneId == null) { throw new System.ArgumentNullException("ZoneId cannot be null"); }
            StringBuilder GetTransportZoneStatusServiceURL = new StringBuilder("/transport-zones/{zone-id}/summary");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Get
            };
            GetTransportZoneStatusServiceURL.Replace("{zone-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(ZoneId, System.Globalization.CultureInfo.InvariantCulture)));
            request.Resource = GetTransportZoneStatusServiceURL.ToString();
            RestResponse<NSXTTransportZoneStatusType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTTransportZoneStatusType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Get operation to " + GetTransportZoneStatusServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTTransportZoneType> CreateTransportZone(NSXTTransportZoneType TransportZone)
        {
            if (TransportZone == null) { throw new System.ArgumentNullException("TransportZone cannot be null"); }
            StringBuilder CreateTransportZoneServiceURL = new StringBuilder("/transport-zones");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Post
            };
            request.AddJsonBody(TransportZone);
            request.Resource = CreateTransportZoneServiceURL.ToString();
            RestResponse<NSXTTransportZoneType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTTransportZoneType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Post operation to " + CreateTransportZoneServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTTransportZoneListResultType> ListTransportZones(string? Cursor = null, string? DisplayName = null, bool? IncludeSystemOwned = null, string? IncludedFields = null, bool? IsDefault = null, long? PageSize = null, bool? SortAscending = null, string? SortBy = null, string? TransportType = null, string? UplinkTeamingPolicyName = null)
        {
            StringBuilder ListTransportZonesServiceURL = new StringBuilder("/transport-zones");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Get
            };
            if (Cursor != null) { request.AddQueryParameter("cursor", Cursor.ToString()); }
            if (DisplayName != null) { request.AddQueryParameter("display_name", DisplayName.ToString()); }
            if (IncludeSystemOwned != null) { request.AddQueryParameter("include_system_owned", IncludeSystemOwned.ToString()); }
            if (IncludedFields != null) { request.AddQueryParameter("included_fields", IncludedFields.ToString()); }
            if (IsDefault != null) { request.AddQueryParameter("is_default", IsDefault.ToString()); }
            if (PageSize != null) { request.AddQueryParameter("page_size", PageSize.ToString()); }
            if (SortAscending != null) { request.AddQueryParameter("sort_ascending", SortAscending.ToString()); }
            if (SortBy != null) { request.AddQueryParameter("sort_by", SortBy.ToString()); }
            if (TransportType != null) { request.AddQueryParameter("transport_type", TransportType.ToString()); }
            if (UplinkTeamingPolicyName != null) { request.AddQueryParameter("uplink_teaming_policy_name", UplinkTeamingPolicyName.ToString()); }
            request.Resource = ListTransportZonesServiceURL.ToString();
            RestResponse<NSXTTransportZoneListResultType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTTransportZoneListResultType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Get operation to " + ListTransportZonesServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
    }
}
