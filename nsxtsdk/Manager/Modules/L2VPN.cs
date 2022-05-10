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
    public class L2VPN
    {
        private RestClient restClient;
        private int retry;
        private int timeout;
        private CancellationToken cancellationToken;

        public L2VPN(RestClient Client, CancellationToken _cancellationToken, int _timeout, int _retry)
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
        public async Task<NSXTL2VpnSessionType> UpdateL2VpnSession(string L2vpnSessionId, NSXTL2VpnSessionType L2VpnSession)
        {
            if (L2vpnSessionId == null) { throw new System.ArgumentNullException("L2vpnSessionId cannot be null"); }
            if (L2VpnSession == null) { throw new System.ArgumentNullException("L2VpnSession cannot be null"); }
            StringBuilder UpdateL2VpnSessionServiceURL = new StringBuilder("/vpn/l2vpn/sessions/{l2vpn-session-id}");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Put
            };
            UpdateL2VpnSessionServiceURL.Replace("{l2vpn-session-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(L2vpnSessionId, System.Globalization.CultureInfo.InvariantCulture)));
            request.AddJsonBody(L2VpnSession);
            request.Resource = UpdateL2VpnSessionServiceURL.ToString();
            RestResponse<NSXTL2VpnSessionType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTL2VpnSessionType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Put operation to " + UpdateL2VpnSessionServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task DeleteL2VpnSession(string L2vpnSessionId)
        {
            if (L2vpnSessionId == null) { throw new System.ArgumentNullException("L2vpnSessionId cannot be null"); }
            StringBuilder DeleteL2VpnSessionServiceURL = new StringBuilder("/vpn/l2vpn/sessions/{l2vpn-session-id}");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Delete
            };
            DeleteL2VpnSessionServiceURL.Replace("{l2vpn-session-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(L2vpnSessionId, System.Globalization.CultureInfo.InvariantCulture)));
            request.Resource = DeleteL2VpnSessionServiceURL.ToString();
            RestResponse response = await restClient.ExecuteTaskAsyncWithPolicy(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Delete operation to " + DeleteL2VpnSessionServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTL2VpnSessionType> GetL2VpnSession(string L2vpnSessionId)
        {
            if (L2vpnSessionId == null) { throw new System.ArgumentNullException("L2vpnSessionId cannot be null"); }
            StringBuilder GetL2VpnSessionServiceURL = new StringBuilder("/vpn/l2vpn/sessions/{l2vpn-session-id}");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Get
            };
            GetL2VpnSessionServiceURL.Replace("{l2vpn-session-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(L2vpnSessionId, System.Globalization.CultureInfo.InvariantCulture)));
            request.Resource = GetL2VpnSessionServiceURL.ToString();
            RestResponse<NSXTL2VpnSessionType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTL2VpnSessionType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Get operation to " + GetL2VpnSessionServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTL2VpnSessionType> CreateL2VpnSession(NSXTL2VpnSessionType L2VpnSession)
        {
            if (L2VpnSession == null) { throw new System.ArgumentNullException("L2VpnSession cannot be null"); }
            StringBuilder CreateL2VpnSessionServiceURL = new StringBuilder("/vpn/l2vpn/sessions");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Post
            };
            request.AddJsonBody(L2VpnSession);
            request.Resource = CreateL2VpnSessionServiceURL.ToString();
            RestResponse<NSXTL2VpnSessionType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTL2VpnSessionType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Post operation to " + CreateL2VpnSessionServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTL2VpnSessionListResultType> ListL2VpnSessions(string? Cursor = null, string? IncludedFields = null, string? L2vpnServiceId = null, long? PageSize = null, bool? SortAscending = null, string? SortBy = null)
        {
            StringBuilder ListL2VpnSessionsServiceURL = new StringBuilder("/vpn/l2vpn/sessions");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Get
            };
            if (Cursor != null) { request.AddQueryParameter("cursor", Cursor.ToString()); }
            if (IncludedFields != null) { request.AddQueryParameter("included_fields", IncludedFields.ToString()); }
            if (L2vpnServiceId != null) { request.AddQueryParameter("l2vpn_service_id", L2vpnServiceId.ToString()); }
            if (PageSize != null) { request.AddQueryParameter("page_size", PageSize.ToString()); }
            if (SortAscending != null) { request.AddQueryParameter("sort_ascending", SortAscending.ToString()); }
            if (SortBy != null) { request.AddQueryParameter("sort_by", SortBy.ToString()); }
            request.Resource = ListL2VpnSessionsServiceURL.ToString();
            RestResponse<NSXTL2VpnSessionListResultType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTL2VpnSessionListResultType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Get operation to " + ListL2VpnSessionsServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTL2VpnServiceType> CreateL2VpnService(NSXTL2VpnServiceType L2VpnService)
        {
            if (L2VpnService == null) { throw new System.ArgumentNullException("L2VpnService cannot be null"); }
            StringBuilder CreateL2VpnServiceServiceURL = new StringBuilder("/vpn/l2vpn/services");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Post
            };
            request.AddJsonBody(L2VpnService);
            request.Resource = CreateL2VpnServiceServiceURL.ToString();
            RestResponse<NSXTL2VpnServiceType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTL2VpnServiceType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Post operation to " + CreateL2VpnServiceServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTL2VpnServiceListResultType> ListL2VpnServices(string? Cursor = null, string? IncludedFields = null, long? PageSize = null, bool? SortAscending = null, string? SortBy = null)
        {
            StringBuilder ListL2VpnServicesServiceURL = new StringBuilder("/vpn/l2vpn/services");
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
            request.Resource = ListL2VpnServicesServiceURL.ToString();
            RestResponse<NSXTL2VpnServiceListResultType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTL2VpnServiceListResultType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Get operation to " + ListL2VpnServicesServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTL2VpnSessionPeerCodesType> GetL2VpnSessionPeerCodes(string L2vpnSessionId)
        {
            if (L2vpnSessionId == null) { throw new System.ArgumentNullException("L2vpnSessionId cannot be null"); }
            StringBuilder GetL2VpnSessionPeerCodesServiceURL = new StringBuilder("/vpn/l2vpn/sessions/{l2vpn-session-id}/peer-codes");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Get
            };
            GetL2VpnSessionPeerCodesServiceURL.Replace("{l2vpn-session-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(L2vpnSessionId, System.Globalization.CultureInfo.InvariantCulture)));
            request.Resource = GetL2VpnSessionPeerCodesServiceURL.ToString();
            RestResponse<NSXTL2VpnSessionPeerCodesType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTL2VpnSessionPeerCodesType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Get operation to " + GetL2VpnSessionPeerCodesServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTL2VpnServiceType> UpdateL2VpnService(string L2vpnServiceId, NSXTL2VpnServiceType L2VpnService)
        {
            if (L2vpnServiceId == null) { throw new System.ArgumentNullException("L2vpnServiceId cannot be null"); }
            if (L2VpnService == null) { throw new System.ArgumentNullException("L2VpnService cannot be null"); }
            StringBuilder UpdateL2VpnServiceServiceURL = new StringBuilder("/vpn/l2vpn/services/{l2vpn-service-id}");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Put
            };
            UpdateL2VpnServiceServiceURL.Replace("{l2vpn-service-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(L2vpnServiceId, System.Globalization.CultureInfo.InvariantCulture)));
            request.AddJsonBody(L2VpnService);
            request.Resource = UpdateL2VpnServiceServiceURL.ToString();
            RestResponse<NSXTL2VpnServiceType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTL2VpnServiceType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Put operation to " + UpdateL2VpnServiceServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task DeleteL2VpnService(string L2vpnServiceId, bool? Force = null)
        {
            if (L2vpnServiceId == null) { throw new System.ArgumentNullException("L2vpnServiceId cannot be null"); }
            StringBuilder DeleteL2VpnServiceServiceURL = new StringBuilder("/vpn/l2vpn/services/{l2vpn-service-id}");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Delete
            };
            DeleteL2VpnServiceServiceURL.Replace("{l2vpn-service-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(L2vpnServiceId, System.Globalization.CultureInfo.InvariantCulture)));
            if (Force != null) { request.AddQueryParameter("force", Force.ToString()); }
            request.Resource = DeleteL2VpnServiceServiceURL.ToString();
            RestResponse response = await restClient.ExecuteTaskAsyncWithPolicy(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Delete operation to " + DeleteL2VpnServiceServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTL2VpnServiceType> GetL2VpnService(string L2vpnServiceId)
        {
            if (L2vpnServiceId == null) { throw new System.ArgumentNullException("L2vpnServiceId cannot be null"); }
            StringBuilder GetL2VpnServiceServiceURL = new StringBuilder("/vpn/l2vpn/services/{l2vpn-service-id}");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Get
            };
            GetL2VpnServiceServiceURL.Replace("{l2vpn-service-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(L2vpnServiceId, System.Globalization.CultureInfo.InvariantCulture)));
            request.Resource = GetL2VpnServiceServiceURL.ToString();
            RestResponse<NSXTL2VpnServiceType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTL2VpnServiceType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Get operation to " + GetL2VpnServiceServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
    }
}
