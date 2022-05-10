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
    public class DhcpRelay
    {
        private RestClient restClient;
        private int retry;
        private int timeout;
        private CancellationToken cancellationToken;

        public DhcpRelay(RestClient Client, CancellationToken _cancellationToken, int _timeout, int _retry)
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
        public async Task<NSXTDhcpRelayServiceType> UpdateDhcpRelay(string RelayId, NSXTDhcpRelayServiceType DhcpRelayService)
        {
            if (RelayId == null) { throw new System.ArgumentNullException("RelayId cannot be null"); }
            if (DhcpRelayService == null) { throw new System.ArgumentNullException("DhcpRelayService cannot be null"); }
            StringBuilder UpdateDhcpRelayServiceURL = new StringBuilder("/dhcp/relays/{relay-id}");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Put
            };
            UpdateDhcpRelayServiceURL.Replace("{relay-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(RelayId, System.Globalization.CultureInfo.InvariantCulture)));
            request.AddJsonBody(DhcpRelayService);
            request.Resource = UpdateDhcpRelayServiceURL.ToString();
            RestResponse<NSXTDhcpRelayServiceType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTDhcpRelayServiceType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Put operation to " + UpdateDhcpRelayServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task DeleteDhcpRelay(string RelayId)
        {
            if (RelayId == null) { throw new System.ArgumentNullException("RelayId cannot be null"); }
            StringBuilder DeleteDhcpRelayServiceURL = new StringBuilder("/dhcp/relays/{relay-id}");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Delete
            };
            DeleteDhcpRelayServiceURL.Replace("{relay-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(RelayId, System.Globalization.CultureInfo.InvariantCulture)));
            request.Resource = DeleteDhcpRelayServiceURL.ToString();
            RestResponse response = await restClient.ExecuteTaskAsyncWithPolicy(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Delete operation to " + DeleteDhcpRelayServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTDhcpRelayServiceType> ReadDhcpRelay(string RelayId)
        {
            if (RelayId == null) { throw new System.ArgumentNullException("RelayId cannot be null"); }
            StringBuilder ReadDhcpRelayServiceURL = new StringBuilder("/dhcp/relays/{relay-id}");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Get
            };
            ReadDhcpRelayServiceURL.Replace("{relay-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(RelayId, System.Globalization.CultureInfo.InvariantCulture)));
            request.Resource = ReadDhcpRelayServiceURL.ToString();
            RestResponse<NSXTDhcpRelayServiceType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTDhcpRelayServiceType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Get operation to " + ReadDhcpRelayServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTDhcpRelayProfileType> UpdateDhcpRelayProfile(string RelayProfileId, NSXTDhcpRelayProfileType DhcpRelayProfile)
        {
            if (RelayProfileId == null) { throw new System.ArgumentNullException("RelayProfileId cannot be null"); }
            if (DhcpRelayProfile == null) { throw new System.ArgumentNullException("DhcpRelayProfile cannot be null"); }
            StringBuilder UpdateDhcpRelayProfileServiceURL = new StringBuilder("/dhcp/relay-profiles/{relay-profile-id}");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Put
            };
            UpdateDhcpRelayProfileServiceURL.Replace("{relay-profile-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(RelayProfileId, System.Globalization.CultureInfo.InvariantCulture)));
            request.AddJsonBody(DhcpRelayProfile);
            request.Resource = UpdateDhcpRelayProfileServiceURL.ToString();
            RestResponse<NSXTDhcpRelayProfileType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTDhcpRelayProfileType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Put operation to " + UpdateDhcpRelayProfileServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task DeleteDhcpRelayProfile(string RelayProfileId)
        {
            if (RelayProfileId == null) { throw new System.ArgumentNullException("RelayProfileId cannot be null"); }
            StringBuilder DeleteDhcpRelayProfileServiceURL = new StringBuilder("/dhcp/relay-profiles/{relay-profile-id}");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Delete
            };
            DeleteDhcpRelayProfileServiceURL.Replace("{relay-profile-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(RelayProfileId, System.Globalization.CultureInfo.InvariantCulture)));
            request.Resource = DeleteDhcpRelayProfileServiceURL.ToString();
            RestResponse response = await restClient.ExecuteTaskAsyncWithPolicy(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Delete operation to " + DeleteDhcpRelayProfileServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTDhcpRelayProfileType> ReadDhcpRelayProfile(string RelayProfileId)
        {
            if (RelayProfileId == null) { throw new System.ArgumentNullException("RelayProfileId cannot be null"); }
            StringBuilder ReadDhcpRelayProfileServiceURL = new StringBuilder("/dhcp/relay-profiles/{relay-profile-id}");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Get
            };
            ReadDhcpRelayProfileServiceURL.Replace("{relay-profile-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(RelayProfileId, System.Globalization.CultureInfo.InvariantCulture)));
            request.Resource = ReadDhcpRelayProfileServiceURL.ToString();
            RestResponse<NSXTDhcpRelayProfileType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTDhcpRelayProfileType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Get operation to " + ReadDhcpRelayProfileServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTDhcpRelayProfileType> CreateDhcpRelayProfile(NSXTDhcpRelayProfileType DhcpRelayProfile)
        {
            if (DhcpRelayProfile == null) { throw new System.ArgumentNullException("DhcpRelayProfile cannot be null"); }
            StringBuilder CreateDhcpRelayProfileServiceURL = new StringBuilder("/dhcp/relay-profiles");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Post
            };
            request.AddJsonBody(DhcpRelayProfile);
            request.Resource = CreateDhcpRelayProfileServiceURL.ToString();
            RestResponse<NSXTDhcpRelayProfileType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTDhcpRelayProfileType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Post operation to " + CreateDhcpRelayProfileServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTDhcpRelayProfileListResultType> ListDhcpRelayProfiles(string? Cursor = null, string? IncludedFields = null, long? PageSize = null, bool? SortAscending = null, string? SortBy = null)
        {
            StringBuilder ListDhcpRelayProfilesServiceURL = new StringBuilder("/dhcp/relay-profiles");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Get
            };
            if (Cursor != null) { request.AddQueryParameter("cursor", Cursor.ToString()); }
            if (IncludedFields != null) { request.AddQueryParameter("included_fields", IncludedFields.ToString()); }
            if (PageSize != null) { request.AddQueryParameter("page_size", PageSize.ToString()); }
            if (SortAscending != null) { request.AddQueryParameter("sort_ascending", SortAscending.ToString()); }
            if (SortBy != null) { request.AddQueryParameter("sort_by", SortBy.ToString()); }
            request.Resource = ListDhcpRelayProfilesServiceURL.ToString();
            RestResponse<NSXTDhcpRelayProfileListResultType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTDhcpRelayProfileListResultType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Get operation to " + ListDhcpRelayProfilesServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTDhcpRelayServiceType> CreateDhcpRelay(NSXTDhcpRelayServiceType DhcpRelayService)
        {
            if (DhcpRelayService == null) { throw new System.ArgumentNullException("DhcpRelayService cannot be null"); }
            StringBuilder CreateDhcpRelayServiceURL = new StringBuilder("/dhcp/relays");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Post
            };
            request.AddJsonBody(DhcpRelayService);
            request.Resource = CreateDhcpRelayServiceURL.ToString();
            RestResponse<NSXTDhcpRelayServiceType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTDhcpRelayServiceType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Post operation to " + CreateDhcpRelayServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTDhcpRelayServiceListResultType> ListDhcpRelays(string? Cursor = null, string? IncludedFields = null, long? PageSize = null, bool? SortAscending = null, string? SortBy = null)
        {
            StringBuilder ListDhcpRelaysServiceURL = new StringBuilder("/dhcp/relays");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Get
            };
            if (Cursor != null) { request.AddQueryParameter("cursor", Cursor.ToString()); }
            if (IncludedFields != null) { request.AddQueryParameter("included_fields", IncludedFields.ToString()); }
            if (PageSize != null) { request.AddQueryParameter("page_size", PageSize.ToString()); }
            if (SortAscending != null) { request.AddQueryParameter("sort_ascending", SortAscending.ToString()); }
            if (SortBy != null) { request.AddQueryParameter("sort_by", SortBy.ToString()); }
            request.Resource = ListDhcpRelaysServiceURL.ToString();
            RestResponse<NSXTDhcpRelayServiceListResultType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTDhcpRelayServiceListResultType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Get operation to " + ListDhcpRelaysServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
    }
}
