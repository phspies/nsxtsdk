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
using nsxtsdk.PolicyModels;

namespace nsxtapi.PolicyModules
{
    public class PolicyVpnLayer2VPN
    {
        private RestClient restClient;
        private int retry;
        private int timeout;
        private CancellationToken cancellationToken;

        public PolicyVpnLayer2VPN(RestClient Client, CancellationToken _cancellationToken, int _timeout, int _retry)
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
        public async Task CreateOrPatchTier0VpnL2VpnsessionFromPeerCodes(string Tier0Id, string ServiceId, string SessionId, NSXTL2VPNSessionDataType L2VpnsessionData)
        {
            if (Tier0Id == null) { throw new System.ArgumentNullException("Tier0Id cannot be null"); }
            if (ServiceId == null) { throw new System.ArgumentNullException("ServiceId cannot be null"); }
            if (SessionId == null) { throw new System.ArgumentNullException("SessionId cannot be null"); }
            if (L2VpnsessionData == null) { throw new System.ArgumentNullException("L2VpnsessionData cannot be null"); }
            StringBuilder CreateOrPatchTier0VpnL2VpnsessionFromPeerCodesServiceURL = new StringBuilder("/infra/tier-0s/{tier-0-id}/l2vpn-services/{service-id}/sessions/{session-id}?action=create_with_peer_code");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Post
            };
            CreateOrPatchTier0VpnL2VpnsessionFromPeerCodesServiceURL.Replace("{tier-0-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(Tier0Id, System.Globalization.CultureInfo.InvariantCulture)));
            CreateOrPatchTier0VpnL2VpnsessionFromPeerCodesServiceURL.Replace("{service-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(ServiceId, System.Globalization.CultureInfo.InvariantCulture)));
            CreateOrPatchTier0VpnL2VpnsessionFromPeerCodesServiceURL.Replace("{session-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(SessionId, System.Globalization.CultureInfo.InvariantCulture)));
            request.AddJsonBody(L2VpnsessionData);
            request.Resource = CreateOrPatchTier0VpnL2VpnsessionFromPeerCodesServiceURL.ToString();
            RestResponse response = await restClient.ExecuteTaskAsyncWithPolicy(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Post operation to " + CreateOrPatchTier0VpnL2VpnsessionFromPeerCodesServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTL2VPNServiceType> CreateOrUpdateTier1VpnL2Vpnservice(string Tier1Id, string ServiceId, NSXTL2VPNServiceType L2Vpnservice)
        {
            if (Tier1Id == null) { throw new System.ArgumentNullException("Tier1Id cannot be null"); }
            if (ServiceId == null) { throw new System.ArgumentNullException("ServiceId cannot be null"); }
            if (L2Vpnservice == null) { throw new System.ArgumentNullException("L2Vpnservice cannot be null"); }
            StringBuilder CreateOrUpdateTier1VpnL2VpnserviceServiceURL = new StringBuilder("/infra/tier-1s/{tier-1-id}/l2vpn-services/{service-id}");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Put
            };
            CreateOrUpdateTier1VpnL2VpnserviceServiceURL.Replace("{tier-1-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(Tier1Id, System.Globalization.CultureInfo.InvariantCulture)));
            CreateOrUpdateTier1VpnL2VpnserviceServiceURL.Replace("{service-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(ServiceId, System.Globalization.CultureInfo.InvariantCulture)));
            request.AddJsonBody(L2Vpnservice);
            request.Resource = CreateOrUpdateTier1VpnL2VpnserviceServiceURL.ToString();
            RestResponse<NSXTL2VPNServiceType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTL2VPNServiceType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Put operation to " + CreateOrUpdateTier1VpnL2VpnserviceServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task DeleteTier1VpnL2Vpnservice(string Tier1Id, string ServiceId)
        {
            if (Tier1Id == null) { throw new System.ArgumentNullException("Tier1Id cannot be null"); }
            if (ServiceId == null) { throw new System.ArgumentNullException("ServiceId cannot be null"); }
            StringBuilder DeleteTier1VpnL2VpnserviceServiceURL = new StringBuilder("/infra/tier-1s/{tier-1-id}/l2vpn-services/{service-id}");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Delete
            };
            DeleteTier1VpnL2VpnserviceServiceURL.Replace("{tier-1-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(Tier1Id, System.Globalization.CultureInfo.InvariantCulture)));
            DeleteTier1VpnL2VpnserviceServiceURL.Replace("{service-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(ServiceId, System.Globalization.CultureInfo.InvariantCulture)));
            request.Resource = DeleteTier1VpnL2VpnserviceServiceURL.ToString();
            RestResponse response = await restClient.ExecuteTaskAsyncWithPolicy(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Delete operation to " + DeleteTier1VpnL2VpnserviceServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task CreateOrPatchTier1VpnL2Vpnservice(string Tier1Id, string ServiceId, NSXTL2VPNServiceType L2Vpnservice)
        {
            if (Tier1Id == null) { throw new System.ArgumentNullException("Tier1Id cannot be null"); }
            if (ServiceId == null) { throw new System.ArgumentNullException("ServiceId cannot be null"); }
            if (L2Vpnservice == null) { throw new System.ArgumentNullException("L2Vpnservice cannot be null"); }
            StringBuilder CreateOrPatchTier1VpnL2VpnserviceServiceURL = new StringBuilder("/infra/tier-1s/{tier-1-id}/l2vpn-services/{service-id}");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Patch
            };
            CreateOrPatchTier1VpnL2VpnserviceServiceURL.Replace("{tier-1-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(Tier1Id, System.Globalization.CultureInfo.InvariantCulture)));
            CreateOrPatchTier1VpnL2VpnserviceServiceURL.Replace("{service-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(ServiceId, System.Globalization.CultureInfo.InvariantCulture)));
            request.AddJsonBody(L2Vpnservice);
            request.Resource = CreateOrPatchTier1VpnL2VpnserviceServiceURL.ToString();
            RestResponse response = await restClient.ExecuteTaskAsyncWithPolicy(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Patch operation to " + CreateOrPatchTier1VpnL2VpnserviceServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTL2VPNServiceType> GetTier1VpnL2Vpnservice(string Tier1Id, string ServiceId)
        {
            if (Tier1Id == null) { throw new System.ArgumentNullException("Tier1Id cannot be null"); }
            if (ServiceId == null) { throw new System.ArgumentNullException("ServiceId cannot be null"); }
            StringBuilder GetTier1VpnL2VpnserviceServiceURL = new StringBuilder("/infra/tier-1s/{tier-1-id}/l2vpn-services/{service-id}");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Get
            };
            GetTier1VpnL2VpnserviceServiceURL.Replace("{tier-1-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(Tier1Id, System.Globalization.CultureInfo.InvariantCulture)));
            GetTier1VpnL2VpnserviceServiceURL.Replace("{service-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(ServiceId, System.Globalization.CultureInfo.InvariantCulture)));
            request.Resource = GetTier1VpnL2VpnserviceServiceURL.ToString();
            RestResponse<NSXTL2VPNServiceType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTL2VPNServiceType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Get operation to " + GetTier1VpnL2VpnserviceServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTL2VPNServiceListResultType> ListTier0VpnL2Vpnservices(string Tier0Id, string? Cursor = null, bool? IncludeMarkForDeleteObjects = null, string? IncludedFields = null, long? PageSize = null, bool? SortAscending = null, string? SortBy = null)
        {
            if (Tier0Id == null) { throw new System.ArgumentNullException("Tier0Id cannot be null"); }
            StringBuilder ListTier0VpnL2VpnservicesServiceURL = new StringBuilder("/infra/tier-0s/{tier-0-id}/l2vpn-services");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Get
            };
            ListTier0VpnL2VpnservicesServiceURL.Replace("{tier-0-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(Tier0Id, System.Globalization.CultureInfo.InvariantCulture)));
            if (Cursor != null) { request.AddQueryParameter("cursor", Cursor.ToString()); }
            if (IncludeMarkForDeleteObjects != null) { request.AddQueryParameter("include_mark_for_delete_objects", IncludeMarkForDeleteObjects.ToString()); }
            if (IncludedFields != null) { request.AddQueryParameter("included_fields", IncludedFields.ToString()); }
            if (PageSize != null) { request.AddQueryParameter("page_size", PageSize.ToString()); }
            if (SortAscending != null) { request.AddQueryParameter("sort_ascending", SortAscending.ToString()); }
            if (SortBy != null) { request.AddQueryParameter("sort_by", SortBy.ToString()); }
            request.Resource = ListTier0VpnL2VpnservicesServiceURL.ToString();
            RestResponse<NSXTL2VPNServiceListResultType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTL2VPNServiceListResultType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Get operation to " + ListTier0VpnL2VpnservicesServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task CreateOrPatchTier1VpnL2VpnsessionFromPeerCodes(string Tier1Id, string ServiceId, string SessionId, NSXTL2VPNSessionDataType L2VpnsessionData)
        {
            if (Tier1Id == null) { throw new System.ArgumentNullException("Tier1Id cannot be null"); }
            if (ServiceId == null) { throw new System.ArgumentNullException("ServiceId cannot be null"); }
            if (SessionId == null) { throw new System.ArgumentNullException("SessionId cannot be null"); }
            if (L2VpnsessionData == null) { throw new System.ArgumentNullException("L2VpnsessionData cannot be null"); }
            StringBuilder CreateOrPatchTier1VpnL2VpnsessionFromPeerCodesServiceURL = new StringBuilder("/infra/tier-1s/{tier-1-id}/l2vpn-services/{service-id}/sessions/{session-id}?action=create_with_peer_code");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Post
            };
            CreateOrPatchTier1VpnL2VpnsessionFromPeerCodesServiceURL.Replace("{tier-1-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(Tier1Id, System.Globalization.CultureInfo.InvariantCulture)));
            CreateOrPatchTier1VpnL2VpnsessionFromPeerCodesServiceURL.Replace("{service-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(ServiceId, System.Globalization.CultureInfo.InvariantCulture)));
            CreateOrPatchTier1VpnL2VpnsessionFromPeerCodesServiceURL.Replace("{session-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(SessionId, System.Globalization.CultureInfo.InvariantCulture)));
            request.AddJsonBody(L2VpnsessionData);
            request.Resource = CreateOrPatchTier1VpnL2VpnsessionFromPeerCodesServiceURL.ToString();
            RestResponse response = await restClient.ExecuteTaskAsyncWithPolicy(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Post operation to " + CreateOrPatchTier1VpnL2VpnsessionFromPeerCodesServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTAggregateL2VPNSessionPeerConfigType> GetTier1VpnL2VpnsessionPeerConfig(string Tier1Id, string ServiceId, string SessionId, string? EnforcementPointPath = null)
        {
            if (Tier1Id == null) { throw new System.ArgumentNullException("Tier1Id cannot be null"); }
            if (ServiceId == null) { throw new System.ArgumentNullException("ServiceId cannot be null"); }
            if (SessionId == null) { throw new System.ArgumentNullException("SessionId cannot be null"); }
            StringBuilder GetTier1VpnL2VpnsessionPeerConfigServiceURL = new StringBuilder("/infra/tier-1s/{tier-1-id}/l2vpn-services/{service-id}/sessions/{session-id}/peer-config");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Get
            };
            GetTier1VpnL2VpnsessionPeerConfigServiceURL.Replace("{tier-1-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(Tier1Id, System.Globalization.CultureInfo.InvariantCulture)));
            GetTier1VpnL2VpnsessionPeerConfigServiceURL.Replace("{service-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(ServiceId, System.Globalization.CultureInfo.InvariantCulture)));
            GetTier1VpnL2VpnsessionPeerConfigServiceURL.Replace("{session-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(SessionId, System.Globalization.CultureInfo.InvariantCulture)));
            if (EnforcementPointPath != null) { request.AddQueryParameter("enforcement_point_path", EnforcementPointPath.ToString()); }
            request.Resource = GetTier1VpnL2VpnsessionPeerConfigServiceURL.ToString();
            RestResponse<NSXTAggregateL2VPNSessionPeerConfigType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTAggregateL2VPNSessionPeerConfigType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Get operation to " + GetTier1VpnL2VpnsessionPeerConfigServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTL2VPNSessionListResultType> ListTier1VpnL2Vpnsessions(string Tier1Id, string ServiceId, string? Cursor = null, bool? IncludeMarkForDeleteObjects = null, string? IncludedFields = null, long? PageSize = null, bool? SortAscending = null, string? SortBy = null)
        {
            if (Tier1Id == null) { throw new System.ArgumentNullException("Tier1Id cannot be null"); }
            if (ServiceId == null) { throw new System.ArgumentNullException("ServiceId cannot be null"); }
            StringBuilder ListTier1VpnL2VpnsessionsServiceURL = new StringBuilder("/infra/tier-1s/{tier-1-id}/l2vpn-services/{service-id}/sessions");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Get
            };
            ListTier1VpnL2VpnsessionsServiceURL.Replace("{tier-1-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(Tier1Id, System.Globalization.CultureInfo.InvariantCulture)));
            ListTier1VpnL2VpnsessionsServiceURL.Replace("{service-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(ServiceId, System.Globalization.CultureInfo.InvariantCulture)));
            if (Cursor != null) { request.AddQueryParameter("cursor", Cursor.ToString()); }
            if (IncludeMarkForDeleteObjects != null) { request.AddQueryParameter("include_mark_for_delete_objects", IncludeMarkForDeleteObjects.ToString()); }
            if (IncludedFields != null) { request.AddQueryParameter("included_fields", IncludedFields.ToString()); }
            if (PageSize != null) { request.AddQueryParameter("page_size", PageSize.ToString()); }
            if (SortAscending != null) { request.AddQueryParameter("sort_ascending", SortAscending.ToString()); }
            if (SortBy != null) { request.AddQueryParameter("sort_by", SortBy.ToString()); }
            request.Resource = ListTier1VpnL2VpnsessionsServiceURL.ToString();
            RestResponse<NSXTL2VPNSessionListResultType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTL2VPNSessionListResultType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Get operation to " + ListTier1VpnL2VpnsessionsServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTAggregateL2VPNSessionPeerConfigType> GetTier0VpnL2VpnsessionPeerConfig(string Tier0Id, string ServiceId, string SessionId, string? EnforcementPointPath = null)
        {
            if (Tier0Id == null) { throw new System.ArgumentNullException("Tier0Id cannot be null"); }
            if (ServiceId == null) { throw new System.ArgumentNullException("ServiceId cannot be null"); }
            if (SessionId == null) { throw new System.ArgumentNullException("SessionId cannot be null"); }
            StringBuilder GetTier0VpnL2VpnsessionPeerConfigServiceURL = new StringBuilder("/infra/tier-0s/{tier-0-id}/l2vpn-services/{service-id}/sessions/{session-id}/peer-config");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Get
            };
            GetTier0VpnL2VpnsessionPeerConfigServiceURL.Replace("{tier-0-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(Tier0Id, System.Globalization.CultureInfo.InvariantCulture)));
            GetTier0VpnL2VpnsessionPeerConfigServiceURL.Replace("{service-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(ServiceId, System.Globalization.CultureInfo.InvariantCulture)));
            GetTier0VpnL2VpnsessionPeerConfigServiceURL.Replace("{session-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(SessionId, System.Globalization.CultureInfo.InvariantCulture)));
            if (EnforcementPointPath != null) { request.AddQueryParameter("enforcement_point_path", EnforcementPointPath.ToString()); }
            request.Resource = GetTier0VpnL2VpnsessionPeerConfigServiceURL.ToString();
            RestResponse<NSXTAggregateL2VPNSessionPeerConfigType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTAggregateL2VPNSessionPeerConfigType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Get operation to " + GetTier0VpnL2VpnsessionPeerConfigServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTL2VPNServiceType> CreateOrUpdateTier0VpnL2Vpnservice(string Tier0Id, string ServiceId, NSXTL2VPNServiceType L2Vpnservice)
        {
            if (Tier0Id == null) { throw new System.ArgumentNullException("Tier0Id cannot be null"); }
            if (ServiceId == null) { throw new System.ArgumentNullException("ServiceId cannot be null"); }
            if (L2Vpnservice == null) { throw new System.ArgumentNullException("L2Vpnservice cannot be null"); }
            StringBuilder CreateOrUpdateTier0VpnL2VpnserviceServiceURL = new StringBuilder("/infra/tier-0s/{tier-0-id}/l2vpn-services/{service-id}");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Put
            };
            CreateOrUpdateTier0VpnL2VpnserviceServiceURL.Replace("{tier-0-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(Tier0Id, System.Globalization.CultureInfo.InvariantCulture)));
            CreateOrUpdateTier0VpnL2VpnserviceServiceURL.Replace("{service-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(ServiceId, System.Globalization.CultureInfo.InvariantCulture)));
            request.AddJsonBody(L2Vpnservice);
            request.Resource = CreateOrUpdateTier0VpnL2VpnserviceServiceURL.ToString();
            RestResponse<NSXTL2VPNServiceType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTL2VPNServiceType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Put operation to " + CreateOrUpdateTier0VpnL2VpnserviceServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTL2VPNServiceType> GetTier0VpnL2Vpnservice(string Tier0Id, string ServiceId)
        {
            if (Tier0Id == null) { throw new System.ArgumentNullException("Tier0Id cannot be null"); }
            if (ServiceId == null) { throw new System.ArgumentNullException("ServiceId cannot be null"); }
            StringBuilder GetTier0VpnL2VpnserviceServiceURL = new StringBuilder("/infra/tier-0s/{tier-0-id}/l2vpn-services/{service-id}");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Get
            };
            GetTier0VpnL2VpnserviceServiceURL.Replace("{tier-0-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(Tier0Id, System.Globalization.CultureInfo.InvariantCulture)));
            GetTier0VpnL2VpnserviceServiceURL.Replace("{service-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(ServiceId, System.Globalization.CultureInfo.InvariantCulture)));
            request.Resource = GetTier0VpnL2VpnserviceServiceURL.ToString();
            RestResponse<NSXTL2VPNServiceType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTL2VPNServiceType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Get operation to " + GetTier0VpnL2VpnserviceServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task DeleteTier0VpnL2Vpnservice(string Tier0Id, string ServiceId)
        {
            if (Tier0Id == null) { throw new System.ArgumentNullException("Tier0Id cannot be null"); }
            if (ServiceId == null) { throw new System.ArgumentNullException("ServiceId cannot be null"); }
            StringBuilder DeleteTier0VpnL2VpnserviceServiceURL = new StringBuilder("/infra/tier-0s/{tier-0-id}/l2vpn-services/{service-id}");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Delete
            };
            DeleteTier0VpnL2VpnserviceServiceURL.Replace("{tier-0-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(Tier0Id, System.Globalization.CultureInfo.InvariantCulture)));
            DeleteTier0VpnL2VpnserviceServiceURL.Replace("{service-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(ServiceId, System.Globalization.CultureInfo.InvariantCulture)));
            request.Resource = DeleteTier0VpnL2VpnserviceServiceURL.ToString();
            RestResponse response = await restClient.ExecuteTaskAsyncWithPolicy(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Delete operation to " + DeleteTier0VpnL2VpnserviceServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task CreateOrPatchTier0VpnL2Vpnservice(string Tier0Id, string ServiceId, NSXTL2VPNServiceType L2Vpnservice)
        {
            if (Tier0Id == null) { throw new System.ArgumentNullException("Tier0Id cannot be null"); }
            if (ServiceId == null) { throw new System.ArgumentNullException("ServiceId cannot be null"); }
            if (L2Vpnservice == null) { throw new System.ArgumentNullException("L2Vpnservice cannot be null"); }
            StringBuilder CreateOrPatchTier0VpnL2VpnserviceServiceURL = new StringBuilder("/infra/tier-0s/{tier-0-id}/l2vpn-services/{service-id}");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Patch
            };
            CreateOrPatchTier0VpnL2VpnserviceServiceURL.Replace("{tier-0-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(Tier0Id, System.Globalization.CultureInfo.InvariantCulture)));
            CreateOrPatchTier0VpnL2VpnserviceServiceURL.Replace("{service-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(ServiceId, System.Globalization.CultureInfo.InvariantCulture)));
            request.AddJsonBody(L2Vpnservice);
            request.Resource = CreateOrPatchTier0VpnL2VpnserviceServiceURL.ToString();
            RestResponse response = await restClient.ExecuteTaskAsyncWithPolicy(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Patch operation to " + CreateOrPatchTier0VpnL2VpnserviceServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTL2VPNSessionType> CreateOrUpdateTier0VpnL2Vpnsession(string Tier0Id, string ServiceId, string SessionId, NSXTL2VPNSessionType L2Vpnsession)
        {
            if (Tier0Id == null) { throw new System.ArgumentNullException("Tier0Id cannot be null"); }
            if (ServiceId == null) { throw new System.ArgumentNullException("ServiceId cannot be null"); }
            if (SessionId == null) { throw new System.ArgumentNullException("SessionId cannot be null"); }
            if (L2Vpnsession == null) { throw new System.ArgumentNullException("L2Vpnsession cannot be null"); }
            StringBuilder CreateOrUpdateTier0VpnL2VpnsessionServiceURL = new StringBuilder("/infra/tier-0s/{tier-0-id}/l2vpn-services/{service-id}/sessions/{session-id}");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Put
            };
            CreateOrUpdateTier0VpnL2VpnsessionServiceURL.Replace("{tier-0-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(Tier0Id, System.Globalization.CultureInfo.InvariantCulture)));
            CreateOrUpdateTier0VpnL2VpnsessionServiceURL.Replace("{service-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(ServiceId, System.Globalization.CultureInfo.InvariantCulture)));
            CreateOrUpdateTier0VpnL2VpnsessionServiceURL.Replace("{session-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(SessionId, System.Globalization.CultureInfo.InvariantCulture)));
            request.AddJsonBody(L2Vpnsession);
            request.Resource = CreateOrUpdateTier0VpnL2VpnsessionServiceURL.ToString();
            RestResponse<NSXTL2VPNSessionType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTL2VPNSessionType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Put operation to " + CreateOrUpdateTier0VpnL2VpnsessionServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTL2VPNSessionType> GetTier0VpnL2Vpnsession(string Tier0Id, string ServiceId, string SessionId)
        {
            if (Tier0Id == null) { throw new System.ArgumentNullException("Tier0Id cannot be null"); }
            if (ServiceId == null) { throw new System.ArgumentNullException("ServiceId cannot be null"); }
            if (SessionId == null) { throw new System.ArgumentNullException("SessionId cannot be null"); }
            StringBuilder GetTier0VpnL2VpnsessionServiceURL = new StringBuilder("/infra/tier-0s/{tier-0-id}/l2vpn-services/{service-id}/sessions/{session-id}");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Get
            };
            GetTier0VpnL2VpnsessionServiceURL.Replace("{tier-0-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(Tier0Id, System.Globalization.CultureInfo.InvariantCulture)));
            GetTier0VpnL2VpnsessionServiceURL.Replace("{service-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(ServiceId, System.Globalization.CultureInfo.InvariantCulture)));
            GetTier0VpnL2VpnsessionServiceURL.Replace("{session-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(SessionId, System.Globalization.CultureInfo.InvariantCulture)));
            request.Resource = GetTier0VpnL2VpnsessionServiceURL.ToString();
            RestResponse<NSXTL2VPNSessionType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTL2VPNSessionType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Get operation to " + GetTier0VpnL2VpnsessionServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task DeleteTier0VpnL2Vpnsession(string Tier0Id, string ServiceId, string SessionId)
        {
            if (Tier0Id == null) { throw new System.ArgumentNullException("Tier0Id cannot be null"); }
            if (ServiceId == null) { throw new System.ArgumentNullException("ServiceId cannot be null"); }
            if (SessionId == null) { throw new System.ArgumentNullException("SessionId cannot be null"); }
            StringBuilder DeleteTier0VpnL2VpnsessionServiceURL = new StringBuilder("/infra/tier-0s/{tier-0-id}/l2vpn-services/{service-id}/sessions/{session-id}");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Delete
            };
            DeleteTier0VpnL2VpnsessionServiceURL.Replace("{tier-0-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(Tier0Id, System.Globalization.CultureInfo.InvariantCulture)));
            DeleteTier0VpnL2VpnsessionServiceURL.Replace("{service-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(ServiceId, System.Globalization.CultureInfo.InvariantCulture)));
            DeleteTier0VpnL2VpnsessionServiceURL.Replace("{session-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(SessionId, System.Globalization.CultureInfo.InvariantCulture)));
            request.Resource = DeleteTier0VpnL2VpnsessionServiceURL.ToString();
            RestResponse response = await restClient.ExecuteTaskAsyncWithPolicy(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Delete operation to " + DeleteTier0VpnL2VpnsessionServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task CreateOrPatchTier0VpnL2Vpnsession(string Tier0Id, string ServiceId, string SessionId, NSXTL2VPNSessionType L2Vpnsession)
        {
            if (Tier0Id == null) { throw new System.ArgumentNullException("Tier0Id cannot be null"); }
            if (ServiceId == null) { throw new System.ArgumentNullException("ServiceId cannot be null"); }
            if (SessionId == null) { throw new System.ArgumentNullException("SessionId cannot be null"); }
            if (L2Vpnsession == null) { throw new System.ArgumentNullException("L2Vpnsession cannot be null"); }
            StringBuilder CreateOrPatchTier0VpnL2VpnsessionServiceURL = new StringBuilder("/infra/tier-0s/{tier-0-id}/l2vpn-services/{service-id}/sessions/{session-id}");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Patch
            };
            CreateOrPatchTier0VpnL2VpnsessionServiceURL.Replace("{tier-0-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(Tier0Id, System.Globalization.CultureInfo.InvariantCulture)));
            CreateOrPatchTier0VpnL2VpnsessionServiceURL.Replace("{service-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(ServiceId, System.Globalization.CultureInfo.InvariantCulture)));
            CreateOrPatchTier0VpnL2VpnsessionServiceURL.Replace("{session-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(SessionId, System.Globalization.CultureInfo.InvariantCulture)));
            request.AddJsonBody(L2Vpnsession);
            request.Resource = CreateOrPatchTier0VpnL2VpnsessionServiceURL.ToString();
            RestResponse response = await restClient.ExecuteTaskAsyncWithPolicy(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Patch operation to " + CreateOrPatchTier0VpnL2VpnsessionServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTL2VPNSessionListResultType> ListTier0VpnL2Vpnsessions(string Tier0Id, string ServiceId, string? Cursor = null, bool? IncludeMarkForDeleteObjects = null, string? IncludedFields = null, long? PageSize = null, bool? SortAscending = null, string? SortBy = null)
        {
            if (Tier0Id == null) { throw new System.ArgumentNullException("Tier0Id cannot be null"); }
            if (ServiceId == null) { throw new System.ArgumentNullException("ServiceId cannot be null"); }
            StringBuilder ListTier0VpnL2VpnsessionsServiceURL = new StringBuilder("/infra/tier-0s/{tier-0-id}/l2vpn-services/{service-id}/sessions");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Get
            };
            ListTier0VpnL2VpnsessionsServiceURL.Replace("{tier-0-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(Tier0Id, System.Globalization.CultureInfo.InvariantCulture)));
            ListTier0VpnL2VpnsessionsServiceURL.Replace("{service-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(ServiceId, System.Globalization.CultureInfo.InvariantCulture)));
            if (Cursor != null) { request.AddQueryParameter("cursor", Cursor.ToString()); }
            if (IncludeMarkForDeleteObjects != null) { request.AddQueryParameter("include_mark_for_delete_objects", IncludeMarkForDeleteObjects.ToString()); }
            if (IncludedFields != null) { request.AddQueryParameter("included_fields", IncludedFields.ToString()); }
            if (PageSize != null) { request.AddQueryParameter("page_size", PageSize.ToString()); }
            if (SortAscending != null) { request.AddQueryParameter("sort_ascending", SortAscending.ToString()); }
            if (SortBy != null) { request.AddQueryParameter("sort_by", SortBy.ToString()); }
            request.Resource = ListTier0VpnL2VpnsessionsServiceURL.ToString();
            RestResponse<NSXTL2VPNSessionListResultType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTL2VPNSessionListResultType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Get operation to " + ListTier0VpnL2VpnsessionsServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTL2VPNServiceListResultType> ListTier1VpnL2Vpnservices(string Tier1Id, string? Cursor = null, bool? IncludeMarkForDeleteObjects = null, string? IncludedFields = null, long? PageSize = null, bool? SortAscending = null, string? SortBy = null)
        {
            if (Tier1Id == null) { throw new System.ArgumentNullException("Tier1Id cannot be null"); }
            StringBuilder ListTier1VpnL2VpnservicesServiceURL = new StringBuilder("/infra/tier-1s/{tier-1-id}/l2vpn-services");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Get
            };
            ListTier1VpnL2VpnservicesServiceURL.Replace("{tier-1-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(Tier1Id, System.Globalization.CultureInfo.InvariantCulture)));
            if (Cursor != null) { request.AddQueryParameter("cursor", Cursor.ToString()); }
            if (IncludeMarkForDeleteObjects != null) { request.AddQueryParameter("include_mark_for_delete_objects", IncludeMarkForDeleteObjects.ToString()); }
            if (IncludedFields != null) { request.AddQueryParameter("included_fields", IncludedFields.ToString()); }
            if (PageSize != null) { request.AddQueryParameter("page_size", PageSize.ToString()); }
            if (SortAscending != null) { request.AddQueryParameter("sort_ascending", SortAscending.ToString()); }
            if (SortBy != null) { request.AddQueryParameter("sort_by", SortBy.ToString()); }
            request.Resource = ListTier1VpnL2VpnservicesServiceURL.ToString();
            RestResponse<NSXTL2VPNServiceListResultType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTL2VPNServiceListResultType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Get operation to " + ListTier1VpnL2VpnservicesServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTL2VPNSessionType> CreateOrUpdateTier1VpnL2Vpnsession(string Tier1Id, string ServiceId, string SessionId, NSXTL2VPNSessionType L2Vpnsession)
        {
            if (Tier1Id == null) { throw new System.ArgumentNullException("Tier1Id cannot be null"); }
            if (ServiceId == null) { throw new System.ArgumentNullException("ServiceId cannot be null"); }
            if (SessionId == null) { throw new System.ArgumentNullException("SessionId cannot be null"); }
            if (L2Vpnsession == null) { throw new System.ArgumentNullException("L2Vpnsession cannot be null"); }
            StringBuilder CreateOrUpdateTier1VpnL2VpnsessionServiceURL = new StringBuilder("/infra/tier-1s/{tier-1-id}/l2vpn-services/{service-id}/sessions/{session-id}");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Put
            };
            CreateOrUpdateTier1VpnL2VpnsessionServiceURL.Replace("{tier-1-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(Tier1Id, System.Globalization.CultureInfo.InvariantCulture)));
            CreateOrUpdateTier1VpnL2VpnsessionServiceURL.Replace("{service-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(ServiceId, System.Globalization.CultureInfo.InvariantCulture)));
            CreateOrUpdateTier1VpnL2VpnsessionServiceURL.Replace("{session-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(SessionId, System.Globalization.CultureInfo.InvariantCulture)));
            request.AddJsonBody(L2Vpnsession);
            request.Resource = CreateOrUpdateTier1VpnL2VpnsessionServiceURL.ToString();
            RestResponse<NSXTL2VPNSessionType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTL2VPNSessionType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Put operation to " + CreateOrUpdateTier1VpnL2VpnsessionServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTL2VPNSessionType> GetTier1VpnL2Vpnsession(string Tier1Id, string ServiceId, string SessionId)
        {
            if (Tier1Id == null) { throw new System.ArgumentNullException("Tier1Id cannot be null"); }
            if (ServiceId == null) { throw new System.ArgumentNullException("ServiceId cannot be null"); }
            if (SessionId == null) { throw new System.ArgumentNullException("SessionId cannot be null"); }
            StringBuilder GetTier1VpnL2VpnsessionServiceURL = new StringBuilder("/infra/tier-1s/{tier-1-id}/l2vpn-services/{service-id}/sessions/{session-id}");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Get
            };
            GetTier1VpnL2VpnsessionServiceURL.Replace("{tier-1-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(Tier1Id, System.Globalization.CultureInfo.InvariantCulture)));
            GetTier1VpnL2VpnsessionServiceURL.Replace("{service-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(ServiceId, System.Globalization.CultureInfo.InvariantCulture)));
            GetTier1VpnL2VpnsessionServiceURL.Replace("{session-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(SessionId, System.Globalization.CultureInfo.InvariantCulture)));
            request.Resource = GetTier1VpnL2VpnsessionServiceURL.ToString();
            RestResponse<NSXTL2VPNSessionType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTL2VPNSessionType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Get operation to " + GetTier1VpnL2VpnsessionServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task CreateOrPatchTier1VpnL2Vpnsession(string Tier1Id, string ServiceId, string SessionId, NSXTL2VPNSessionType L2Vpnsession)
        {
            if (Tier1Id == null) { throw new System.ArgumentNullException("Tier1Id cannot be null"); }
            if (ServiceId == null) { throw new System.ArgumentNullException("ServiceId cannot be null"); }
            if (SessionId == null) { throw new System.ArgumentNullException("SessionId cannot be null"); }
            if (L2Vpnsession == null) { throw new System.ArgumentNullException("L2Vpnsession cannot be null"); }
            StringBuilder CreateOrPatchTier1VpnL2VpnsessionServiceURL = new StringBuilder("/infra/tier-1s/{tier-1-id}/l2vpn-services/{service-id}/sessions/{session-id}");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Patch
            };
            CreateOrPatchTier1VpnL2VpnsessionServiceURL.Replace("{tier-1-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(Tier1Id, System.Globalization.CultureInfo.InvariantCulture)));
            CreateOrPatchTier1VpnL2VpnsessionServiceURL.Replace("{service-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(ServiceId, System.Globalization.CultureInfo.InvariantCulture)));
            CreateOrPatchTier1VpnL2VpnsessionServiceURL.Replace("{session-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(SessionId, System.Globalization.CultureInfo.InvariantCulture)));
            request.AddJsonBody(L2Vpnsession);
            request.Resource = CreateOrPatchTier1VpnL2VpnsessionServiceURL.ToString();
            RestResponse response = await restClient.ExecuteTaskAsyncWithPolicy(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Patch operation to " + CreateOrPatchTier1VpnL2VpnsessionServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task DeleteTier1VpnL2Vpnsession(string Tier1Id, string ServiceId, string SessionId)
        {
            if (Tier1Id == null) { throw new System.ArgumentNullException("Tier1Id cannot be null"); }
            if (ServiceId == null) { throw new System.ArgumentNullException("ServiceId cannot be null"); }
            if (SessionId == null) { throw new System.ArgumentNullException("SessionId cannot be null"); }
            StringBuilder DeleteTier1VpnL2VpnsessionServiceURL = new StringBuilder("/infra/tier-1s/{tier-1-id}/l2vpn-services/{service-id}/sessions/{session-id}");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Delete
            };
            DeleteTier1VpnL2VpnsessionServiceURL.Replace("{tier-1-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(Tier1Id, System.Globalization.CultureInfo.InvariantCulture)));
            DeleteTier1VpnL2VpnsessionServiceURL.Replace("{service-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(ServiceId, System.Globalization.CultureInfo.InvariantCulture)));
            DeleteTier1VpnL2VpnsessionServiceURL.Replace("{session-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(SessionId, System.Globalization.CultureInfo.InvariantCulture)));
            request.Resource = DeleteTier1VpnL2VpnsessionServiceURL.ToString();
            RestResponse response = await restClient.ExecuteTaskAsyncWithPolicy(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Delete operation to " + DeleteTier1VpnL2VpnsessionServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            
        }
    }
}
