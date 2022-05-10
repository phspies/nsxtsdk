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
    public class PolicyVpnIPSecVpn
    {
        private RestClient restClient;
        private int retry;
        private int timeout;
        private CancellationToken cancellationToken;

        public PolicyVpnIPSecVpn(RestClient Client, CancellationToken _cancellationToken, int _timeout, int _retry)
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
        public async Task<NSXTIPSecVpnSessionType> CreateOrUpdateTier1VpnIpsecVpnSession(string Tier1Id, string ServiceId, string SessionId, NSXTIPSecVpnSessionType IpsecVpnSession)
        {
            if (Tier1Id == null) { throw new System.ArgumentNullException("Tier1Id cannot be null"); }
            if (ServiceId == null) { throw new System.ArgumentNullException("ServiceId cannot be null"); }
            if (SessionId == null) { throw new System.ArgumentNullException("SessionId cannot be null"); }
            if (IpsecVpnSession == null) { throw new System.ArgumentNullException("IpsecVpnSession cannot be null"); }
            StringBuilder CreateOrUpdateTier1VpnIpsecVpnSessionServiceURL = new StringBuilder("/infra/tier-1s/{tier-1-id}/ipsec-vpn-services/{service-id}/sessions/{session-id}");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Put
            };
            CreateOrUpdateTier1VpnIpsecVpnSessionServiceURL.Replace("{tier-1-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(Tier1Id, System.Globalization.CultureInfo.InvariantCulture)));
            CreateOrUpdateTier1VpnIpsecVpnSessionServiceURL.Replace("{service-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(ServiceId, System.Globalization.CultureInfo.InvariantCulture)));
            CreateOrUpdateTier1VpnIpsecVpnSessionServiceURL.Replace("{session-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(SessionId, System.Globalization.CultureInfo.InvariantCulture)));
            request.AddJsonBody(IpsecVpnSession);
            request.Resource = CreateOrUpdateTier1VpnIpsecVpnSessionServiceURL.ToString();
            RestResponse<NSXTIPSecVpnSessionType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTIPSecVpnSessionType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Put operation to " + CreateOrUpdateTier1VpnIpsecVpnSessionServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task DeleteTier1VpnIpsecVpnSession(string Tier1Id, string ServiceId, string SessionId)
        {
            if (Tier1Id == null) { throw new System.ArgumentNullException("Tier1Id cannot be null"); }
            if (ServiceId == null) { throw new System.ArgumentNullException("ServiceId cannot be null"); }
            if (SessionId == null) { throw new System.ArgumentNullException("SessionId cannot be null"); }
            StringBuilder DeleteTier1VpnIpsecVpnSessionServiceURL = new StringBuilder("/infra/tier-1s/{tier-1-id}/ipsec-vpn-services/{service-id}/sessions/{session-id}");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Delete
            };
            DeleteTier1VpnIpsecVpnSessionServiceURL.Replace("{tier-1-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(Tier1Id, System.Globalization.CultureInfo.InvariantCulture)));
            DeleteTier1VpnIpsecVpnSessionServiceURL.Replace("{service-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(ServiceId, System.Globalization.CultureInfo.InvariantCulture)));
            DeleteTier1VpnIpsecVpnSessionServiceURL.Replace("{session-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(SessionId, System.Globalization.CultureInfo.InvariantCulture)));
            request.Resource = DeleteTier1VpnIpsecVpnSessionServiceURL.ToString();
            RestResponse response = await restClient.ExecuteTaskAsyncWithPolicy(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Delete operation to " + DeleteTier1VpnIpsecVpnSessionServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTIPSecVpnSessionType> GetTier1VpnIpsecVpnSession(string Tier1Id, string ServiceId, string SessionId)
        {
            if (Tier1Id == null) { throw new System.ArgumentNullException("Tier1Id cannot be null"); }
            if (ServiceId == null) { throw new System.ArgumentNullException("ServiceId cannot be null"); }
            if (SessionId == null) { throw new System.ArgumentNullException("SessionId cannot be null"); }
            StringBuilder GetTier1VpnIpsecVpnSessionServiceURL = new StringBuilder("/infra/tier-1s/{tier-1-id}/ipsec-vpn-services/{service-id}/sessions/{session-id}");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Get
            };
            GetTier1VpnIpsecVpnSessionServiceURL.Replace("{tier-1-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(Tier1Id, System.Globalization.CultureInfo.InvariantCulture)));
            GetTier1VpnIpsecVpnSessionServiceURL.Replace("{service-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(ServiceId, System.Globalization.CultureInfo.InvariantCulture)));
            GetTier1VpnIpsecVpnSessionServiceURL.Replace("{session-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(SessionId, System.Globalization.CultureInfo.InvariantCulture)));
            request.Resource = GetTier1VpnIpsecVpnSessionServiceURL.ToString();
            RestResponse<NSXTIPSecVpnSessionType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTIPSecVpnSessionType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Get operation to " + GetTier1VpnIpsecVpnSessionServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task CreateOrPatchTier1VpnIpsecVpnSession(string Tier1Id, string ServiceId, string SessionId, NSXTIPSecVpnSessionType IpsecVpnSession)
        {
            if (Tier1Id == null) { throw new System.ArgumentNullException("Tier1Id cannot be null"); }
            if (ServiceId == null) { throw new System.ArgumentNullException("ServiceId cannot be null"); }
            if (SessionId == null) { throw new System.ArgumentNullException("SessionId cannot be null"); }
            if (IpsecVpnSession == null) { throw new System.ArgumentNullException("IpsecVpnSession cannot be null"); }
            StringBuilder CreateOrPatchTier1VpnIpsecVpnSessionServiceURL = new StringBuilder("/infra/tier-1s/{tier-1-id}/ipsec-vpn-services/{service-id}/sessions/{session-id}");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Patch
            };
            CreateOrPatchTier1VpnIpsecVpnSessionServiceURL.Replace("{tier-1-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(Tier1Id, System.Globalization.CultureInfo.InvariantCulture)));
            CreateOrPatchTier1VpnIpsecVpnSessionServiceURL.Replace("{service-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(ServiceId, System.Globalization.CultureInfo.InvariantCulture)));
            CreateOrPatchTier1VpnIpsecVpnSessionServiceURL.Replace("{session-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(SessionId, System.Globalization.CultureInfo.InvariantCulture)));
            request.AddJsonBody(IpsecVpnSession);
            request.Resource = CreateOrPatchTier1VpnIpsecVpnSessionServiceURL.ToString();
            RestResponse response = await restClient.ExecuteTaskAsyncWithPolicy(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Patch operation to " + CreateOrPatchTier1VpnIpsecVpnSessionServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTIPSecVpnServiceListResultType> ListTier1VpnIpsecVpnServices(string Tier1Id, string? Cursor = null, bool? IncludeMarkForDeleteObjects = null, string? IncludedFields = null, long? PageSize = null, bool? SortAscending = null, string? SortBy = null)
        {
            if (Tier1Id == null) { throw new System.ArgumentNullException("Tier1Id cannot be null"); }
            StringBuilder ListTier1VpnIpsecVpnServicesServiceURL = new StringBuilder("/infra/tier-1s/{tier-1-id}/ipsec-vpn-services");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Get
            };
            ListTier1VpnIpsecVpnServicesServiceURL.Replace("{tier-1-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(Tier1Id, System.Globalization.CultureInfo.InvariantCulture)));
            if (Cursor != null) { request.AddQueryParameter("cursor", Cursor.ToString()); }
            if (IncludeMarkForDeleteObjects != null) { request.AddQueryParameter("include_mark_for_delete_objects", IncludeMarkForDeleteObjects.ToString()); }
            if (IncludedFields != null) { request.AddQueryParameter("included_fields", IncludedFields.ToString()); }
            if (PageSize != null) { request.AddQueryParameter("page_size", PageSize.ToString()); }
            if (SortAscending != null) { request.AddQueryParameter("sort_ascending", SortAscending.ToString()); }
            if (SortBy != null) { request.AddQueryParameter("sort_by", SortBy.ToString()); }
            request.Resource = ListTier1VpnIpsecVpnServicesServiceURL.ToString();
            RestResponse<NSXTIPSecVpnServiceListResultType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTIPSecVpnServiceListResultType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Get operation to " + ListTier1VpnIpsecVpnServicesServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<string> GetTier0VpnIpsecVpnPeerConfig(string Tier0Id, string ServiceId, string SessionId, string? EnforcementPointPath = null)
        {
            if (Tier0Id == null) { throw new System.ArgumentNullException("Tier0Id cannot be null"); }
            if (ServiceId == null) { throw new System.ArgumentNullException("ServiceId cannot be null"); }
            if (SessionId == null) { throw new System.ArgumentNullException("SessionId cannot be null"); }
            StringBuilder GetTier0VpnIpsecVpnPeerConfigServiceURL = new StringBuilder("/infra/tier-0s/{tier-0-id}/ipsec-vpn-services/{service-id}/sessions/{session-id}/peer-config");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Get
            };
            GetTier0VpnIpsecVpnPeerConfigServiceURL.Replace("{tier-0-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(Tier0Id, System.Globalization.CultureInfo.InvariantCulture)));
            GetTier0VpnIpsecVpnPeerConfigServiceURL.Replace("{service-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(ServiceId, System.Globalization.CultureInfo.InvariantCulture)));
            GetTier0VpnIpsecVpnPeerConfigServiceURL.Replace("{session-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(SessionId, System.Globalization.CultureInfo.InvariantCulture)));
            if (EnforcementPointPath != null) { request.AddQueryParameter("enforcement_point_path", EnforcementPointPath.ToString()); }
            request.Resource = GetTier0VpnIpsecVpnPeerConfigServiceURL.ToString();
            RestResponse<string> response = await restClient.ExecuteTaskAsyncWithPolicy<string>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Get operation to " + GetTier0VpnIpsecVpnPeerConfigServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTIPSecVpnIkeProfileListResultType> ListIpsecVpnIkeProfiles(string? Cursor = null, bool? IncludeMarkForDeleteObjects = null, string? IncludedFields = null, long? PageSize = null, bool? SortAscending = null, string? SortBy = null)
        {
            StringBuilder ListIpsecVpnIkeProfilesServiceURL = new StringBuilder("/infra/ipsec-vpn-ike-profiles");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Get
            };
            if (Cursor != null) { request.AddQueryParameter("cursor", Cursor.ToString()); }
            if (IncludeMarkForDeleteObjects != null) { request.AddQueryParameter("include_mark_for_delete_objects", IncludeMarkForDeleteObjects.ToString()); }
            if (IncludedFields != null) { request.AddQueryParameter("included_fields", IncludedFields.ToString()); }
            if (PageSize != null) { request.AddQueryParameter("page_size", PageSize.ToString()); }
            if (SortAscending != null) { request.AddQueryParameter("sort_ascending", SortAscending.ToString()); }
            if (SortBy != null) { request.AddQueryParameter("sort_by", SortBy.ToString()); }
            request.Resource = ListIpsecVpnIkeProfilesServiceURL.ToString();
            RestResponse<NSXTIPSecVpnIkeProfileListResultType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTIPSecVpnIkeProfileListResultType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Get operation to " + ListIpsecVpnIkeProfilesServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTIPSecVpnIkeProfileType> CreateOrUpdateIpsecVpnIkeProfile(string IkeProfileId, NSXTIPSecVpnIkeProfileType IpsecVpnIkeProfile)
        {
            if (IkeProfileId == null) { throw new System.ArgumentNullException("IkeProfileId cannot be null"); }
            if (IpsecVpnIkeProfile == null) { throw new System.ArgumentNullException("IpsecVpnIkeProfile cannot be null"); }
            StringBuilder CreateOrUpdateIpsecVpnIkeProfileServiceURL = new StringBuilder("/infra/ipsec-vpn-ike-profiles/{ike-profile-id}");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Put
            };
            CreateOrUpdateIpsecVpnIkeProfileServiceURL.Replace("{ike-profile-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(IkeProfileId, System.Globalization.CultureInfo.InvariantCulture)));
            request.AddJsonBody(IpsecVpnIkeProfile);
            request.Resource = CreateOrUpdateIpsecVpnIkeProfileServiceURL.ToString();
            RestResponse<NSXTIPSecVpnIkeProfileType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTIPSecVpnIkeProfileType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Put operation to " + CreateOrUpdateIpsecVpnIkeProfileServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task DeleteIpsecVpnIkeProfile(string IkeProfileId)
        {
            if (IkeProfileId == null) { throw new System.ArgumentNullException("IkeProfileId cannot be null"); }
            StringBuilder DeleteIpsecVpnIkeProfileServiceURL = new StringBuilder("/infra/ipsec-vpn-ike-profiles/{ike-profile-id}");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Delete
            };
            DeleteIpsecVpnIkeProfileServiceURL.Replace("{ike-profile-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(IkeProfileId, System.Globalization.CultureInfo.InvariantCulture)));
            request.Resource = DeleteIpsecVpnIkeProfileServiceURL.ToString();
            RestResponse response = await restClient.ExecuteTaskAsyncWithPolicy(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Delete operation to " + DeleteIpsecVpnIkeProfileServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTIPSecVpnIkeProfileType> GetIpsecVpnIkeProfile(string IkeProfileId)
        {
            if (IkeProfileId == null) { throw new System.ArgumentNullException("IkeProfileId cannot be null"); }
            StringBuilder GetIpsecVpnIkeProfileServiceURL = new StringBuilder("/infra/ipsec-vpn-ike-profiles/{ike-profile-id}");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Get
            };
            GetIpsecVpnIkeProfileServiceURL.Replace("{ike-profile-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(IkeProfileId, System.Globalization.CultureInfo.InvariantCulture)));
            request.Resource = GetIpsecVpnIkeProfileServiceURL.ToString();
            RestResponse<NSXTIPSecVpnIkeProfileType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTIPSecVpnIkeProfileType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Get operation to " + GetIpsecVpnIkeProfileServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task CreateOrPatchIpsecVpnIkeProfile(string IkeProfileId, NSXTIPSecVpnIkeProfileType IpsecVpnIkeProfile)
        {
            if (IkeProfileId == null) { throw new System.ArgumentNullException("IkeProfileId cannot be null"); }
            if (IpsecVpnIkeProfile == null) { throw new System.ArgumentNullException("IpsecVpnIkeProfile cannot be null"); }
            StringBuilder CreateOrPatchIpsecVpnIkeProfileServiceURL = new StringBuilder("/infra/ipsec-vpn-ike-profiles/{ike-profile-id}");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Patch
            };
            CreateOrPatchIpsecVpnIkeProfileServiceURL.Replace("{ike-profile-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(IkeProfileId, System.Globalization.CultureInfo.InvariantCulture)));
            request.AddJsonBody(IpsecVpnIkeProfile);
            request.Resource = CreateOrPatchIpsecVpnIkeProfileServiceURL.ToString();
            RestResponse response = await restClient.ExecuteTaskAsyncWithPolicy(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Patch operation to " + CreateOrPatchIpsecVpnIkeProfileServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTIPSecVpnLocalEndpointListResultType> ListTier0VpnIpsecVpnLocalEndpoints(string Tier0Id, string ServiceId, string? Cursor = null, bool? IncludeMarkForDeleteObjects = null, string? IncludedFields = null, long? PageSize = null, bool? SortAscending = null, string? SortBy = null)
        {
            if (Tier0Id == null) { throw new System.ArgumentNullException("Tier0Id cannot be null"); }
            if (ServiceId == null) { throw new System.ArgumentNullException("ServiceId cannot be null"); }
            StringBuilder ListTier0VpnIpsecVpnLocalEndpointsServiceURL = new StringBuilder("/infra/tier-0s/{tier-0-id}/ipsec-vpn-services/{service-id}/local-endpoints");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Get
            };
            ListTier0VpnIpsecVpnLocalEndpointsServiceURL.Replace("{tier-0-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(Tier0Id, System.Globalization.CultureInfo.InvariantCulture)));
            ListTier0VpnIpsecVpnLocalEndpointsServiceURL.Replace("{service-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(ServiceId, System.Globalization.CultureInfo.InvariantCulture)));
            if (Cursor != null) { request.AddQueryParameter("cursor", Cursor.ToString()); }
            if (IncludeMarkForDeleteObjects != null) { request.AddQueryParameter("include_mark_for_delete_objects", IncludeMarkForDeleteObjects.ToString()); }
            if (IncludedFields != null) { request.AddQueryParameter("included_fields", IncludedFields.ToString()); }
            if (PageSize != null) { request.AddQueryParameter("page_size", PageSize.ToString()); }
            if (SortAscending != null) { request.AddQueryParameter("sort_ascending", SortAscending.ToString()); }
            if (SortBy != null) { request.AddQueryParameter("sort_by", SortBy.ToString()); }
            request.Resource = ListTier0VpnIpsecVpnLocalEndpointsServiceURL.ToString();
            RestResponse<NSXTIPSecVpnLocalEndpointListResultType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTIPSecVpnLocalEndpointListResultType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Get operation to " + ListTier0VpnIpsecVpnLocalEndpointsServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTIPSecVpnTunnelProfileType> CreateOrUpdateIpsecVpnTunnelProfile(string TunnelProfileId, NSXTIPSecVpnTunnelProfileType IpsecVpnTunnelProfile)
        {
            if (TunnelProfileId == null) { throw new System.ArgumentNullException("TunnelProfileId cannot be null"); }
            if (IpsecVpnTunnelProfile == null) { throw new System.ArgumentNullException("IpsecVpnTunnelProfile cannot be null"); }
            StringBuilder CreateOrUpdateIpsecVpnTunnelProfileServiceURL = new StringBuilder("/infra/ipsec-vpn-tunnel-profiles/{tunnel-profile-id}");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Put
            };
            CreateOrUpdateIpsecVpnTunnelProfileServiceURL.Replace("{tunnel-profile-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(TunnelProfileId, System.Globalization.CultureInfo.InvariantCulture)));
            request.AddJsonBody(IpsecVpnTunnelProfile);
            request.Resource = CreateOrUpdateIpsecVpnTunnelProfileServiceURL.ToString();
            RestResponse<NSXTIPSecVpnTunnelProfileType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTIPSecVpnTunnelProfileType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Put operation to " + CreateOrUpdateIpsecVpnTunnelProfileServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task DeleteIpsecVpnTunnelProfile(string TunnelProfileId)
        {
            if (TunnelProfileId == null) { throw new System.ArgumentNullException("TunnelProfileId cannot be null"); }
            StringBuilder DeleteIpsecVpnTunnelProfileServiceURL = new StringBuilder("/infra/ipsec-vpn-tunnel-profiles/{tunnel-profile-id}");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Delete
            };
            DeleteIpsecVpnTunnelProfileServiceURL.Replace("{tunnel-profile-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(TunnelProfileId, System.Globalization.CultureInfo.InvariantCulture)));
            request.Resource = DeleteIpsecVpnTunnelProfileServiceURL.ToString();
            RestResponse response = await restClient.ExecuteTaskAsyncWithPolicy(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Delete operation to " + DeleteIpsecVpnTunnelProfileServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTIPSecVpnTunnelProfileType> GetIpsecVpnTunnelProfile(string TunnelProfileId)
        {
            if (TunnelProfileId == null) { throw new System.ArgumentNullException("TunnelProfileId cannot be null"); }
            StringBuilder GetIpsecVpnTunnelProfileServiceURL = new StringBuilder("/infra/ipsec-vpn-tunnel-profiles/{tunnel-profile-id}");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Get
            };
            GetIpsecVpnTunnelProfileServiceURL.Replace("{tunnel-profile-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(TunnelProfileId, System.Globalization.CultureInfo.InvariantCulture)));
            request.Resource = GetIpsecVpnTunnelProfileServiceURL.ToString();
            RestResponse<NSXTIPSecVpnTunnelProfileType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTIPSecVpnTunnelProfileType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Get operation to " + GetIpsecVpnTunnelProfileServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task CreateOrPatchIpsecVpnTunnelProfile(string TunnelProfileId, NSXTIPSecVpnTunnelProfileType IpsecVpnTunnelProfile)
        {
            if (TunnelProfileId == null) { throw new System.ArgumentNullException("TunnelProfileId cannot be null"); }
            if (IpsecVpnTunnelProfile == null) { throw new System.ArgumentNullException("IpsecVpnTunnelProfile cannot be null"); }
            StringBuilder CreateOrPatchIpsecVpnTunnelProfileServiceURL = new StringBuilder("/infra/ipsec-vpn-tunnel-profiles/{tunnel-profile-id}");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Patch
            };
            CreateOrPatchIpsecVpnTunnelProfileServiceURL.Replace("{tunnel-profile-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(TunnelProfileId, System.Globalization.CultureInfo.InvariantCulture)));
            request.AddJsonBody(IpsecVpnTunnelProfile);
            request.Resource = CreateOrPatchIpsecVpnTunnelProfileServiceURL.ToString();
            RestResponse response = await restClient.ExecuteTaskAsyncWithPolicy(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Patch operation to " + CreateOrPatchIpsecVpnTunnelProfileServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTIPSecVpnServiceType> CreateOrUpdateTier0VpnIpsecVpnService(string Tier0Id, string ServiceId, NSXTIPSecVpnServiceType IpsecVpnService)
        {
            if (Tier0Id == null) { throw new System.ArgumentNullException("Tier0Id cannot be null"); }
            if (ServiceId == null) { throw new System.ArgumentNullException("ServiceId cannot be null"); }
            if (IpsecVpnService == null) { throw new System.ArgumentNullException("IpsecVpnService cannot be null"); }
            StringBuilder CreateOrUpdateTier0VpnIpsecVpnServiceServiceURL = new StringBuilder("/infra/tier-0s/{tier-0-id}/ipsec-vpn-services/{service-id}");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Put
            };
            CreateOrUpdateTier0VpnIpsecVpnServiceServiceURL.Replace("{tier-0-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(Tier0Id, System.Globalization.CultureInfo.InvariantCulture)));
            CreateOrUpdateTier0VpnIpsecVpnServiceServiceURL.Replace("{service-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(ServiceId, System.Globalization.CultureInfo.InvariantCulture)));
            request.AddJsonBody(IpsecVpnService);
            request.Resource = CreateOrUpdateTier0VpnIpsecVpnServiceServiceURL.ToString();
            RestResponse<NSXTIPSecVpnServiceType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTIPSecVpnServiceType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Put operation to " + CreateOrUpdateTier0VpnIpsecVpnServiceServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTIPSecVpnServiceType> GetTier0VpnIpsecVpnService(string Tier0Id, string ServiceId)
        {
            if (Tier0Id == null) { throw new System.ArgumentNullException("Tier0Id cannot be null"); }
            if (ServiceId == null) { throw new System.ArgumentNullException("ServiceId cannot be null"); }
            StringBuilder GetTier0VpnIpsecVpnServiceServiceURL = new StringBuilder("/infra/tier-0s/{tier-0-id}/ipsec-vpn-services/{service-id}");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Get
            };
            GetTier0VpnIpsecVpnServiceServiceURL.Replace("{tier-0-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(Tier0Id, System.Globalization.CultureInfo.InvariantCulture)));
            GetTier0VpnIpsecVpnServiceServiceURL.Replace("{service-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(ServiceId, System.Globalization.CultureInfo.InvariantCulture)));
            request.Resource = GetTier0VpnIpsecVpnServiceServiceURL.ToString();
            RestResponse<NSXTIPSecVpnServiceType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTIPSecVpnServiceType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Get operation to " + GetTier0VpnIpsecVpnServiceServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task DeleteTier0VpnIpsecVpnService(string Tier0Id, string ServiceId)
        {
            if (Tier0Id == null) { throw new System.ArgumentNullException("Tier0Id cannot be null"); }
            if (ServiceId == null) { throw new System.ArgumentNullException("ServiceId cannot be null"); }
            StringBuilder DeleteTier0VpnIpsecVpnServiceServiceURL = new StringBuilder("/infra/tier-0s/{tier-0-id}/ipsec-vpn-services/{service-id}");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Delete
            };
            DeleteTier0VpnIpsecVpnServiceServiceURL.Replace("{tier-0-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(Tier0Id, System.Globalization.CultureInfo.InvariantCulture)));
            DeleteTier0VpnIpsecVpnServiceServiceURL.Replace("{service-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(ServiceId, System.Globalization.CultureInfo.InvariantCulture)));
            request.Resource = DeleteTier0VpnIpsecVpnServiceServiceURL.ToString();
            RestResponse response = await restClient.ExecuteTaskAsyncWithPolicy(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Delete operation to " + DeleteTier0VpnIpsecVpnServiceServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task CreateOrPatchTier0VpnIpsecVpnService(string Tier0Id, string ServiceId, NSXTIPSecVpnServiceType IpsecVpnService)
        {
            if (Tier0Id == null) { throw new System.ArgumentNullException("Tier0Id cannot be null"); }
            if (ServiceId == null) { throw new System.ArgumentNullException("ServiceId cannot be null"); }
            if (IpsecVpnService == null) { throw new System.ArgumentNullException("IpsecVpnService cannot be null"); }
            StringBuilder CreateOrPatchTier0VpnIpsecVpnServiceServiceURL = new StringBuilder("/infra/tier-0s/{tier-0-id}/ipsec-vpn-services/{service-id}");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Patch
            };
            CreateOrPatchTier0VpnIpsecVpnServiceServiceURL.Replace("{tier-0-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(Tier0Id, System.Globalization.CultureInfo.InvariantCulture)));
            CreateOrPatchTier0VpnIpsecVpnServiceServiceURL.Replace("{service-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(ServiceId, System.Globalization.CultureInfo.InvariantCulture)));
            request.AddJsonBody(IpsecVpnService);
            request.Resource = CreateOrPatchTier0VpnIpsecVpnServiceServiceURL.ToString();
            RestResponse response = await restClient.ExecuteTaskAsyncWithPolicy(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Patch operation to " + CreateOrPatchTier0VpnIpsecVpnServiceServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTIPSecVpnLocalEndpointType> CreateOrUpdateTier1VpnIpsecVpnLocalEndpoint(string Tier1Id, string ServiceId, string LocalEndpointId, NSXTIPSecVpnLocalEndpointType IpsecVpnLocalEndpoint)
        {
            if (Tier1Id == null) { throw new System.ArgumentNullException("Tier1Id cannot be null"); }
            if (ServiceId == null) { throw new System.ArgumentNullException("ServiceId cannot be null"); }
            if (LocalEndpointId == null) { throw new System.ArgumentNullException("LocalEndpointId cannot be null"); }
            if (IpsecVpnLocalEndpoint == null) { throw new System.ArgumentNullException("IpsecVpnLocalEndpoint cannot be null"); }
            StringBuilder CreateOrUpdateTier1VpnIpsecVpnLocalEndpointServiceURL = new StringBuilder("/infra/tier-1s/{tier-1-id}/ipsec-vpn-services/{service-id}/local-endpoints/{local-endpoint-id}");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Put
            };
            CreateOrUpdateTier1VpnIpsecVpnLocalEndpointServiceURL.Replace("{tier-1-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(Tier1Id, System.Globalization.CultureInfo.InvariantCulture)));
            CreateOrUpdateTier1VpnIpsecVpnLocalEndpointServiceURL.Replace("{service-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(ServiceId, System.Globalization.CultureInfo.InvariantCulture)));
            CreateOrUpdateTier1VpnIpsecVpnLocalEndpointServiceURL.Replace("{local-endpoint-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(LocalEndpointId, System.Globalization.CultureInfo.InvariantCulture)));
            request.AddJsonBody(IpsecVpnLocalEndpoint);
            request.Resource = CreateOrUpdateTier1VpnIpsecVpnLocalEndpointServiceURL.ToString();
            RestResponse<NSXTIPSecVpnLocalEndpointType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTIPSecVpnLocalEndpointType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Put operation to " + CreateOrUpdateTier1VpnIpsecVpnLocalEndpointServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task CreateOrPatchTier1VpnIpsecVpnLocalEndpoint(string Tier1Id, string ServiceId, string LocalEndpointId, NSXTIPSecVpnLocalEndpointType IpsecVpnLocalEndpoint)
        {
            if (Tier1Id == null) { throw new System.ArgumentNullException("Tier1Id cannot be null"); }
            if (ServiceId == null) { throw new System.ArgumentNullException("ServiceId cannot be null"); }
            if (LocalEndpointId == null) { throw new System.ArgumentNullException("LocalEndpointId cannot be null"); }
            if (IpsecVpnLocalEndpoint == null) { throw new System.ArgumentNullException("IpsecVpnLocalEndpoint cannot be null"); }
            StringBuilder CreateOrPatchTier1VpnIpsecVpnLocalEndpointServiceURL = new StringBuilder("/infra/tier-1s/{tier-1-id}/ipsec-vpn-services/{service-id}/local-endpoints/{local-endpoint-id}");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Patch
            };
            CreateOrPatchTier1VpnIpsecVpnLocalEndpointServiceURL.Replace("{tier-1-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(Tier1Id, System.Globalization.CultureInfo.InvariantCulture)));
            CreateOrPatchTier1VpnIpsecVpnLocalEndpointServiceURL.Replace("{service-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(ServiceId, System.Globalization.CultureInfo.InvariantCulture)));
            CreateOrPatchTier1VpnIpsecVpnLocalEndpointServiceURL.Replace("{local-endpoint-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(LocalEndpointId, System.Globalization.CultureInfo.InvariantCulture)));
            request.AddJsonBody(IpsecVpnLocalEndpoint);
            request.Resource = CreateOrPatchTier1VpnIpsecVpnLocalEndpointServiceURL.ToString();
            RestResponse response = await restClient.ExecuteTaskAsyncWithPolicy(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Patch operation to " + CreateOrPatchTier1VpnIpsecVpnLocalEndpointServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task DeleteTier1VpnIpsecVpnLocalEndpoint(string Tier1Id, string ServiceId, string LocalEndpointId)
        {
            if (Tier1Id == null) { throw new System.ArgumentNullException("Tier1Id cannot be null"); }
            if (ServiceId == null) { throw new System.ArgumentNullException("ServiceId cannot be null"); }
            if (LocalEndpointId == null) { throw new System.ArgumentNullException("LocalEndpointId cannot be null"); }
            StringBuilder DeleteTier1VpnIpsecVpnLocalEndpointServiceURL = new StringBuilder("/infra/tier-1s/{tier-1-id}/ipsec-vpn-services/{service-id}/local-endpoints/{local-endpoint-id}");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Delete
            };
            DeleteTier1VpnIpsecVpnLocalEndpointServiceURL.Replace("{tier-1-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(Tier1Id, System.Globalization.CultureInfo.InvariantCulture)));
            DeleteTier1VpnIpsecVpnLocalEndpointServiceURL.Replace("{service-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(ServiceId, System.Globalization.CultureInfo.InvariantCulture)));
            DeleteTier1VpnIpsecVpnLocalEndpointServiceURL.Replace("{local-endpoint-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(LocalEndpointId, System.Globalization.CultureInfo.InvariantCulture)));
            request.Resource = DeleteTier1VpnIpsecVpnLocalEndpointServiceURL.ToString();
            RestResponse response = await restClient.ExecuteTaskAsyncWithPolicy(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Delete operation to " + DeleteTier1VpnIpsecVpnLocalEndpointServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTIPSecVpnLocalEndpointType> GetTier1VpnIpsecVpnLocalEndpoint(string Tier1Id, string ServiceId, string LocalEndpointId)
        {
            if (Tier1Id == null) { throw new System.ArgumentNullException("Tier1Id cannot be null"); }
            if (ServiceId == null) { throw new System.ArgumentNullException("ServiceId cannot be null"); }
            if (LocalEndpointId == null) { throw new System.ArgumentNullException("LocalEndpointId cannot be null"); }
            StringBuilder GetTier1VpnIpsecVpnLocalEndpointServiceURL = new StringBuilder("/infra/tier-1s/{tier-1-id}/ipsec-vpn-services/{service-id}/local-endpoints/{local-endpoint-id}");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Get
            };
            GetTier1VpnIpsecVpnLocalEndpointServiceURL.Replace("{tier-1-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(Tier1Id, System.Globalization.CultureInfo.InvariantCulture)));
            GetTier1VpnIpsecVpnLocalEndpointServiceURL.Replace("{service-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(ServiceId, System.Globalization.CultureInfo.InvariantCulture)));
            GetTier1VpnIpsecVpnLocalEndpointServiceURL.Replace("{local-endpoint-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(LocalEndpointId, System.Globalization.CultureInfo.InvariantCulture)));
            request.Resource = GetTier1VpnIpsecVpnLocalEndpointServiceURL.ToString();
            RestResponse<NSXTIPSecVpnLocalEndpointType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTIPSecVpnLocalEndpointType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Get operation to " + GetTier1VpnIpsecVpnLocalEndpointServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTIPSecVpnTunnelProfileListResultType> ListIpsecVpnTunnelProfiles(string? Cursor = null, bool? IncludeMarkForDeleteObjects = null, string? IncludedFields = null, long? PageSize = null, bool? SortAscending = null, string? SortBy = null)
        {
            StringBuilder ListIpsecVpnTunnelProfilesServiceURL = new StringBuilder("/infra/ipsec-vpn-tunnel-profiles");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Get
            };
            if (Cursor != null) { request.AddQueryParameter("cursor", Cursor.ToString()); }
            if (IncludeMarkForDeleteObjects != null) { request.AddQueryParameter("include_mark_for_delete_objects", IncludeMarkForDeleteObjects.ToString()); }
            if (IncludedFields != null) { request.AddQueryParameter("included_fields", IncludedFields.ToString()); }
            if (PageSize != null) { request.AddQueryParameter("page_size", PageSize.ToString()); }
            if (SortAscending != null) { request.AddQueryParameter("sort_ascending", SortAscending.ToString()); }
            if (SortBy != null) { request.AddQueryParameter("sort_by", SortBy.ToString()); }
            request.Resource = ListIpsecVpnTunnelProfilesServiceURL.ToString();
            RestResponse<NSXTIPSecVpnTunnelProfileListResultType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTIPSecVpnTunnelProfileListResultType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Get operation to " + ListIpsecVpnTunnelProfilesServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTIPSecVpnLocalEndpointType> CreateOrUpdateTier0VpnIpsecVpnLocalEndpoint(string Tier0Id, string ServiceId, string LocalEndpointId, NSXTIPSecVpnLocalEndpointType IpsecVpnLocalEndpoint)
        {
            if (Tier0Id == null) { throw new System.ArgumentNullException("Tier0Id cannot be null"); }
            if (ServiceId == null) { throw new System.ArgumentNullException("ServiceId cannot be null"); }
            if (LocalEndpointId == null) { throw new System.ArgumentNullException("LocalEndpointId cannot be null"); }
            if (IpsecVpnLocalEndpoint == null) { throw new System.ArgumentNullException("IpsecVpnLocalEndpoint cannot be null"); }
            StringBuilder CreateOrUpdateTier0VpnIpsecVpnLocalEndpointServiceURL = new StringBuilder("/infra/tier-0s/{tier-0-id}/ipsec-vpn-services/{service-id}/local-endpoints/{local-endpoint-id}");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Put
            };
            CreateOrUpdateTier0VpnIpsecVpnLocalEndpointServiceURL.Replace("{tier-0-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(Tier0Id, System.Globalization.CultureInfo.InvariantCulture)));
            CreateOrUpdateTier0VpnIpsecVpnLocalEndpointServiceURL.Replace("{service-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(ServiceId, System.Globalization.CultureInfo.InvariantCulture)));
            CreateOrUpdateTier0VpnIpsecVpnLocalEndpointServiceURL.Replace("{local-endpoint-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(LocalEndpointId, System.Globalization.CultureInfo.InvariantCulture)));
            request.AddJsonBody(IpsecVpnLocalEndpoint);
            request.Resource = CreateOrUpdateTier0VpnIpsecVpnLocalEndpointServiceURL.ToString();
            RestResponse<NSXTIPSecVpnLocalEndpointType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTIPSecVpnLocalEndpointType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Put operation to " + CreateOrUpdateTier0VpnIpsecVpnLocalEndpointServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task CreateOrPatchTier0VpnIpsecVpnLocalEndpoint(string Tier0Id, string ServiceId, string LocalEndpointId, NSXTIPSecVpnLocalEndpointType IpsecVpnLocalEndpoint)
        {
            if (Tier0Id == null) { throw new System.ArgumentNullException("Tier0Id cannot be null"); }
            if (ServiceId == null) { throw new System.ArgumentNullException("ServiceId cannot be null"); }
            if (LocalEndpointId == null) { throw new System.ArgumentNullException("LocalEndpointId cannot be null"); }
            if (IpsecVpnLocalEndpoint == null) { throw new System.ArgumentNullException("IpsecVpnLocalEndpoint cannot be null"); }
            StringBuilder CreateOrPatchTier0VpnIpsecVpnLocalEndpointServiceURL = new StringBuilder("/infra/tier-0s/{tier-0-id}/ipsec-vpn-services/{service-id}/local-endpoints/{local-endpoint-id}");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Patch
            };
            CreateOrPatchTier0VpnIpsecVpnLocalEndpointServiceURL.Replace("{tier-0-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(Tier0Id, System.Globalization.CultureInfo.InvariantCulture)));
            CreateOrPatchTier0VpnIpsecVpnLocalEndpointServiceURL.Replace("{service-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(ServiceId, System.Globalization.CultureInfo.InvariantCulture)));
            CreateOrPatchTier0VpnIpsecVpnLocalEndpointServiceURL.Replace("{local-endpoint-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(LocalEndpointId, System.Globalization.CultureInfo.InvariantCulture)));
            request.AddJsonBody(IpsecVpnLocalEndpoint);
            request.Resource = CreateOrPatchTier0VpnIpsecVpnLocalEndpointServiceURL.ToString();
            RestResponse response = await restClient.ExecuteTaskAsyncWithPolicy(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Patch operation to " + CreateOrPatchTier0VpnIpsecVpnLocalEndpointServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task DeleteTier0VpnIpsecVpnLocalEndpoint(string Tier0Id, string ServiceId, string LocalEndpointId)
        {
            if (Tier0Id == null) { throw new System.ArgumentNullException("Tier0Id cannot be null"); }
            if (ServiceId == null) { throw new System.ArgumentNullException("ServiceId cannot be null"); }
            if (LocalEndpointId == null) { throw new System.ArgumentNullException("LocalEndpointId cannot be null"); }
            StringBuilder DeleteTier0VpnIpsecVpnLocalEndpointServiceURL = new StringBuilder("/infra/tier-0s/{tier-0-id}/ipsec-vpn-services/{service-id}/local-endpoints/{local-endpoint-id}");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Delete
            };
            DeleteTier0VpnIpsecVpnLocalEndpointServiceURL.Replace("{tier-0-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(Tier0Id, System.Globalization.CultureInfo.InvariantCulture)));
            DeleteTier0VpnIpsecVpnLocalEndpointServiceURL.Replace("{service-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(ServiceId, System.Globalization.CultureInfo.InvariantCulture)));
            DeleteTier0VpnIpsecVpnLocalEndpointServiceURL.Replace("{local-endpoint-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(LocalEndpointId, System.Globalization.CultureInfo.InvariantCulture)));
            request.Resource = DeleteTier0VpnIpsecVpnLocalEndpointServiceURL.ToString();
            RestResponse response = await restClient.ExecuteTaskAsyncWithPolicy(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Delete operation to " + DeleteTier0VpnIpsecVpnLocalEndpointServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTIPSecVpnLocalEndpointType> GetTier0VpnIpsecVpnLocalEndpoint(string Tier0Id, string ServiceId, string LocalEndpointId)
        {
            if (Tier0Id == null) { throw new System.ArgumentNullException("Tier0Id cannot be null"); }
            if (ServiceId == null) { throw new System.ArgumentNullException("ServiceId cannot be null"); }
            if (LocalEndpointId == null) { throw new System.ArgumentNullException("LocalEndpointId cannot be null"); }
            StringBuilder GetTier0VpnIpsecVpnLocalEndpointServiceURL = new StringBuilder("/infra/tier-0s/{tier-0-id}/ipsec-vpn-services/{service-id}/local-endpoints/{local-endpoint-id}");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Get
            };
            GetTier0VpnIpsecVpnLocalEndpointServiceURL.Replace("{tier-0-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(Tier0Id, System.Globalization.CultureInfo.InvariantCulture)));
            GetTier0VpnIpsecVpnLocalEndpointServiceURL.Replace("{service-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(ServiceId, System.Globalization.CultureInfo.InvariantCulture)));
            GetTier0VpnIpsecVpnLocalEndpointServiceURL.Replace("{local-endpoint-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(LocalEndpointId, System.Globalization.CultureInfo.InvariantCulture)));
            request.Resource = GetTier0VpnIpsecVpnLocalEndpointServiceURL.ToString();
            RestResponse<NSXTIPSecVpnLocalEndpointType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTIPSecVpnLocalEndpointType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Get operation to " + GetTier0VpnIpsecVpnLocalEndpointServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTIPSecVpnSessionListResultType> ListTier1VpnIpsecVpnSessions(string Tier1Id, string ServiceId, string? Cursor = null, bool? IncludeMarkForDeleteObjects = null, string? IncludedFields = null, long? PageSize = null, bool? SortAscending = null, string? SortBy = null)
        {
            if (Tier1Id == null) { throw new System.ArgumentNullException("Tier1Id cannot be null"); }
            if (ServiceId == null) { throw new System.ArgumentNullException("ServiceId cannot be null"); }
            StringBuilder ListTier1VpnIpsecVpnSessionsServiceURL = new StringBuilder("/infra/tier-1s/{tier-1-id}/ipsec-vpn-services/{service-id}/sessions");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Get
            };
            ListTier1VpnIpsecVpnSessionsServiceURL.Replace("{tier-1-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(Tier1Id, System.Globalization.CultureInfo.InvariantCulture)));
            ListTier1VpnIpsecVpnSessionsServiceURL.Replace("{service-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(ServiceId, System.Globalization.CultureInfo.InvariantCulture)));
            if (Cursor != null) { request.AddQueryParameter("cursor", Cursor.ToString()); }
            if (IncludeMarkForDeleteObjects != null) { request.AddQueryParameter("include_mark_for_delete_objects", IncludeMarkForDeleteObjects.ToString()); }
            if (IncludedFields != null) { request.AddQueryParameter("included_fields", IncludedFields.ToString()); }
            if (PageSize != null) { request.AddQueryParameter("page_size", PageSize.ToString()); }
            if (SortAscending != null) { request.AddQueryParameter("sort_ascending", SortAscending.ToString()); }
            if (SortBy != null) { request.AddQueryParameter("sort_by", SortBy.ToString()); }
            request.Resource = ListTier1VpnIpsecVpnSessionsServiceURL.ToString();
            RestResponse<NSXTIPSecVpnSessionListResultType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTIPSecVpnSessionListResultType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Get operation to " + ListTier1VpnIpsecVpnSessionsServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTIPSecVpnSessionType> GetTier0VpnIpsecVpnSessionWithSensitiveData(string Tier0Id, string ServiceId, string SessionId)
        {
            if (Tier0Id == null) { throw new System.ArgumentNullException("Tier0Id cannot be null"); }
            if (ServiceId == null) { throw new System.ArgumentNullException("ServiceId cannot be null"); }
            if (SessionId == null) { throw new System.ArgumentNullException("SessionId cannot be null"); }
            StringBuilder GetTier0VpnIpsecVpnSessionWithSensitiveDataServiceURL = new StringBuilder("/infra/tier-0s/{tier-0-id}/ipsec-vpn-services/{service-id}/sessions/{session-id}?action=show_sensitive_data");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Get
            };
            GetTier0VpnIpsecVpnSessionWithSensitiveDataServiceURL.Replace("{tier-0-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(Tier0Id, System.Globalization.CultureInfo.InvariantCulture)));
            GetTier0VpnIpsecVpnSessionWithSensitiveDataServiceURL.Replace("{service-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(ServiceId, System.Globalization.CultureInfo.InvariantCulture)));
            GetTier0VpnIpsecVpnSessionWithSensitiveDataServiceURL.Replace("{session-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(SessionId, System.Globalization.CultureInfo.InvariantCulture)));
            request.Resource = GetTier0VpnIpsecVpnSessionWithSensitiveDataServiceURL.ToString();
            RestResponse<NSXTIPSecVpnSessionType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTIPSecVpnSessionType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Get operation to " + GetTier0VpnIpsecVpnSessionWithSensitiveDataServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<string> GetTier1VpnIpsecVpnPeerConfig(string Tier1Id, string ServiceId, string SessionId, string? EnforcementPointPath = null)
        {
            if (Tier1Id == null) { throw new System.ArgumentNullException("Tier1Id cannot be null"); }
            if (ServiceId == null) { throw new System.ArgumentNullException("ServiceId cannot be null"); }
            if (SessionId == null) { throw new System.ArgumentNullException("SessionId cannot be null"); }
            StringBuilder GetTier1VpnIpsecVpnPeerConfigServiceURL = new StringBuilder("/infra/tier-1s/{tier-1-id}/ipsec-vpn-services/{service-id}/sessions/{session-id}/peer-config");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Get
            };
            GetTier1VpnIpsecVpnPeerConfigServiceURL.Replace("{tier-1-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(Tier1Id, System.Globalization.CultureInfo.InvariantCulture)));
            GetTier1VpnIpsecVpnPeerConfigServiceURL.Replace("{service-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(ServiceId, System.Globalization.CultureInfo.InvariantCulture)));
            GetTier1VpnIpsecVpnPeerConfigServiceURL.Replace("{session-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(SessionId, System.Globalization.CultureInfo.InvariantCulture)));
            if (EnforcementPointPath != null) { request.AddQueryParameter("enforcement_point_path", EnforcementPointPath.ToString()); }
            request.Resource = GetTier1VpnIpsecVpnPeerConfigServiceURL.ToString();
            RestResponse<string> response = await restClient.ExecuteTaskAsyncWithPolicy<string>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Get operation to " + GetTier1VpnIpsecVpnPeerConfigServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTIPSecVpnServiceListResultType> ListTier0VpnIpsecVpnServices(string Tier0Id, string? Cursor = null, bool? IncludeMarkForDeleteObjects = null, string? IncludedFields = null, long? PageSize = null, bool? SortAscending = null, string? SortBy = null)
        {
            if (Tier0Id == null) { throw new System.ArgumentNullException("Tier0Id cannot be null"); }
            StringBuilder ListTier0VpnIpsecVpnServicesServiceURL = new StringBuilder("/infra/tier-0s/{tier-0-id}/ipsec-vpn-services");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Get
            };
            ListTier0VpnIpsecVpnServicesServiceURL.Replace("{tier-0-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(Tier0Id, System.Globalization.CultureInfo.InvariantCulture)));
            if (Cursor != null) { request.AddQueryParameter("cursor", Cursor.ToString()); }
            if (IncludeMarkForDeleteObjects != null) { request.AddQueryParameter("include_mark_for_delete_objects", IncludeMarkForDeleteObjects.ToString()); }
            if (IncludedFields != null) { request.AddQueryParameter("included_fields", IncludedFields.ToString()); }
            if (PageSize != null) { request.AddQueryParameter("page_size", PageSize.ToString()); }
            if (SortAscending != null) { request.AddQueryParameter("sort_ascending", SortAscending.ToString()); }
            if (SortBy != null) { request.AddQueryParameter("sort_by", SortBy.ToString()); }
            request.Resource = ListTier0VpnIpsecVpnServicesServiceURL.ToString();
            RestResponse<NSXTIPSecVpnServiceListResultType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTIPSecVpnServiceListResultType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Get operation to " + ListTier0VpnIpsecVpnServicesServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTIPSecVpnLocalEndpointListResultType> ListTier1VpnIpsecVpnLocalEndpoints(string Tier1Id, string ServiceId, string? Cursor = null, bool? IncludeMarkForDeleteObjects = null, string? IncludedFields = null, long? PageSize = null, bool? SortAscending = null, string? SortBy = null)
        {
            if (Tier1Id == null) { throw new System.ArgumentNullException("Tier1Id cannot be null"); }
            if (ServiceId == null) { throw new System.ArgumentNullException("ServiceId cannot be null"); }
            StringBuilder ListTier1VpnIpsecVpnLocalEndpointsServiceURL = new StringBuilder("/infra/tier-1s/{tier-1-id}/ipsec-vpn-services/{service-id}/local-endpoints");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Get
            };
            ListTier1VpnIpsecVpnLocalEndpointsServiceURL.Replace("{tier-1-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(Tier1Id, System.Globalization.CultureInfo.InvariantCulture)));
            ListTier1VpnIpsecVpnLocalEndpointsServiceURL.Replace("{service-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(ServiceId, System.Globalization.CultureInfo.InvariantCulture)));
            if (Cursor != null) { request.AddQueryParameter("cursor", Cursor.ToString()); }
            if (IncludeMarkForDeleteObjects != null) { request.AddQueryParameter("include_mark_for_delete_objects", IncludeMarkForDeleteObjects.ToString()); }
            if (IncludedFields != null) { request.AddQueryParameter("included_fields", IncludedFields.ToString()); }
            if (PageSize != null) { request.AddQueryParameter("page_size", PageSize.ToString()); }
            if (SortAscending != null) { request.AddQueryParameter("sort_ascending", SortAscending.ToString()); }
            if (SortBy != null) { request.AddQueryParameter("sort_by", SortBy.ToString()); }
            request.Resource = ListTier1VpnIpsecVpnLocalEndpointsServiceURL.ToString();
            RestResponse<NSXTIPSecVpnLocalEndpointListResultType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTIPSecVpnLocalEndpointListResultType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Get operation to " + ListTier1VpnIpsecVpnLocalEndpointsServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTIPSecVpnDpdProfileType> CreateOrUpdateIpsecVpnDpdProfile(string DpdProfileId, NSXTIPSecVpnDpdProfileType IpsecVpnDpdProfile)
        {
            if (DpdProfileId == null) { throw new System.ArgumentNullException("DpdProfileId cannot be null"); }
            if (IpsecVpnDpdProfile == null) { throw new System.ArgumentNullException("IpsecVpnDpdProfile cannot be null"); }
            StringBuilder CreateOrUpdateIpsecVpnDpdProfileServiceURL = new StringBuilder("/infra/ipsec-vpn-dpd-profiles/{dpd-profile-id}");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Put
            };
            CreateOrUpdateIpsecVpnDpdProfileServiceURL.Replace("{dpd-profile-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(DpdProfileId, System.Globalization.CultureInfo.InvariantCulture)));
            request.AddJsonBody(IpsecVpnDpdProfile);
            request.Resource = CreateOrUpdateIpsecVpnDpdProfileServiceURL.ToString();
            RestResponse<NSXTIPSecVpnDpdProfileType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTIPSecVpnDpdProfileType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Put operation to " + CreateOrUpdateIpsecVpnDpdProfileServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task DeleteIpsecVpnDpdProfile(string DpdProfileId)
        {
            if (DpdProfileId == null) { throw new System.ArgumentNullException("DpdProfileId cannot be null"); }
            StringBuilder DeleteIpsecVpnDpdProfileServiceURL = new StringBuilder("/infra/ipsec-vpn-dpd-profiles/{dpd-profile-id}");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Delete
            };
            DeleteIpsecVpnDpdProfileServiceURL.Replace("{dpd-profile-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(DpdProfileId, System.Globalization.CultureInfo.InvariantCulture)));
            request.Resource = DeleteIpsecVpnDpdProfileServiceURL.ToString();
            RestResponse response = await restClient.ExecuteTaskAsyncWithPolicy(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Delete operation to " + DeleteIpsecVpnDpdProfileServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task CreateOrPatchIpsecVpnDpdProfile(string DpdProfileId, NSXTIPSecVpnDpdProfileType IpsecVpnDpdProfile)
        {
            if (DpdProfileId == null) { throw new System.ArgumentNullException("DpdProfileId cannot be null"); }
            if (IpsecVpnDpdProfile == null) { throw new System.ArgumentNullException("IpsecVpnDpdProfile cannot be null"); }
            StringBuilder CreateOrPatchIpsecVpnDpdProfileServiceURL = new StringBuilder("/infra/ipsec-vpn-dpd-profiles/{dpd-profile-id}");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Patch
            };
            CreateOrPatchIpsecVpnDpdProfileServiceURL.Replace("{dpd-profile-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(DpdProfileId, System.Globalization.CultureInfo.InvariantCulture)));
            request.AddJsonBody(IpsecVpnDpdProfile);
            request.Resource = CreateOrPatchIpsecVpnDpdProfileServiceURL.ToString();
            RestResponse response = await restClient.ExecuteTaskAsyncWithPolicy(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Patch operation to " + CreateOrPatchIpsecVpnDpdProfileServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTIPSecVpnDpdProfileType> GetIpsecVpnDpdProfile(string DpdProfileId)
        {
            if (DpdProfileId == null) { throw new System.ArgumentNullException("DpdProfileId cannot be null"); }
            StringBuilder GetIpsecVpnDpdProfileServiceURL = new StringBuilder("/infra/ipsec-vpn-dpd-profiles/{dpd-profile-id}");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Get
            };
            GetIpsecVpnDpdProfileServiceURL.Replace("{dpd-profile-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(DpdProfileId, System.Globalization.CultureInfo.InvariantCulture)));
            request.Resource = GetIpsecVpnDpdProfileServiceURL.ToString();
            RestResponse<NSXTIPSecVpnDpdProfileType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTIPSecVpnDpdProfileType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Get operation to " + GetIpsecVpnDpdProfileServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTIPSecVpnSessionListResultType> ListTier0VpnIpsecVpnSessions(string Tier0Id, string ServiceId, string? Cursor = null, bool? IncludeMarkForDeleteObjects = null, string? IncludedFields = null, long? PageSize = null, bool? SortAscending = null, string? SortBy = null)
        {
            if (Tier0Id == null) { throw new System.ArgumentNullException("Tier0Id cannot be null"); }
            if (ServiceId == null) { throw new System.ArgumentNullException("ServiceId cannot be null"); }
            StringBuilder ListTier0VpnIpsecVpnSessionsServiceURL = new StringBuilder("/infra/tier-0s/{tier-0-id}/ipsec-vpn-services/{service-id}/sessions");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Get
            };
            ListTier0VpnIpsecVpnSessionsServiceURL.Replace("{tier-0-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(Tier0Id, System.Globalization.CultureInfo.InvariantCulture)));
            ListTier0VpnIpsecVpnSessionsServiceURL.Replace("{service-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(ServiceId, System.Globalization.CultureInfo.InvariantCulture)));
            if (Cursor != null) { request.AddQueryParameter("cursor", Cursor.ToString()); }
            if (IncludeMarkForDeleteObjects != null) { request.AddQueryParameter("include_mark_for_delete_objects", IncludeMarkForDeleteObjects.ToString()); }
            if (IncludedFields != null) { request.AddQueryParameter("included_fields", IncludedFields.ToString()); }
            if (PageSize != null) { request.AddQueryParameter("page_size", PageSize.ToString()); }
            if (SortAscending != null) { request.AddQueryParameter("sort_ascending", SortAscending.ToString()); }
            if (SortBy != null) { request.AddQueryParameter("sort_by", SortBy.ToString()); }
            request.Resource = ListTier0VpnIpsecVpnSessionsServiceURL.ToString();
            RestResponse<NSXTIPSecVpnSessionListResultType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTIPSecVpnSessionListResultType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Get operation to " + ListTier0VpnIpsecVpnSessionsServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTIPSecVpnServiceType> CreateOrUpdateTier1VpnIpsecVpnService(string Tier1Id, string ServiceId, NSXTIPSecVpnServiceType IpsecVpnService)
        {
            if (Tier1Id == null) { throw new System.ArgumentNullException("Tier1Id cannot be null"); }
            if (ServiceId == null) { throw new System.ArgumentNullException("ServiceId cannot be null"); }
            if (IpsecVpnService == null) { throw new System.ArgumentNullException("IpsecVpnService cannot be null"); }
            StringBuilder CreateOrUpdateTier1VpnIpsecVpnServiceServiceURL = new StringBuilder("/infra/tier-1s/{tier-1-id}/ipsec-vpn-services/{service-id}");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Put
            };
            CreateOrUpdateTier1VpnIpsecVpnServiceServiceURL.Replace("{tier-1-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(Tier1Id, System.Globalization.CultureInfo.InvariantCulture)));
            CreateOrUpdateTier1VpnIpsecVpnServiceServiceURL.Replace("{service-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(ServiceId, System.Globalization.CultureInfo.InvariantCulture)));
            request.AddJsonBody(IpsecVpnService);
            request.Resource = CreateOrUpdateTier1VpnIpsecVpnServiceServiceURL.ToString();
            RestResponse<NSXTIPSecVpnServiceType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTIPSecVpnServiceType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Put operation to " + CreateOrUpdateTier1VpnIpsecVpnServiceServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task DeleteTier1VpnIpsecVpnService(string Tier1Id, string ServiceId)
        {
            if (Tier1Id == null) { throw new System.ArgumentNullException("Tier1Id cannot be null"); }
            if (ServiceId == null) { throw new System.ArgumentNullException("ServiceId cannot be null"); }
            StringBuilder DeleteTier1VpnIpsecVpnServiceServiceURL = new StringBuilder("/infra/tier-1s/{tier-1-id}/ipsec-vpn-services/{service-id}");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Delete
            };
            DeleteTier1VpnIpsecVpnServiceServiceURL.Replace("{tier-1-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(Tier1Id, System.Globalization.CultureInfo.InvariantCulture)));
            DeleteTier1VpnIpsecVpnServiceServiceURL.Replace("{service-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(ServiceId, System.Globalization.CultureInfo.InvariantCulture)));
            request.Resource = DeleteTier1VpnIpsecVpnServiceServiceURL.ToString();
            RestResponse response = await restClient.ExecuteTaskAsyncWithPolicy(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Delete operation to " + DeleteTier1VpnIpsecVpnServiceServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTIPSecVpnServiceType> GetTier1VpnIpsecVpnService(string Tier1Id, string ServiceId)
        {
            if (Tier1Id == null) { throw new System.ArgumentNullException("Tier1Id cannot be null"); }
            if (ServiceId == null) { throw new System.ArgumentNullException("ServiceId cannot be null"); }
            StringBuilder GetTier1VpnIpsecVpnServiceServiceURL = new StringBuilder("/infra/tier-1s/{tier-1-id}/ipsec-vpn-services/{service-id}");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Get
            };
            GetTier1VpnIpsecVpnServiceServiceURL.Replace("{tier-1-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(Tier1Id, System.Globalization.CultureInfo.InvariantCulture)));
            GetTier1VpnIpsecVpnServiceServiceURL.Replace("{service-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(ServiceId, System.Globalization.CultureInfo.InvariantCulture)));
            request.Resource = GetTier1VpnIpsecVpnServiceServiceURL.ToString();
            RestResponse<NSXTIPSecVpnServiceType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTIPSecVpnServiceType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Get operation to " + GetTier1VpnIpsecVpnServiceServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task CreateOrPatchTier1VpnIpsecVpnService(string Tier1Id, string ServiceId, NSXTIPSecVpnServiceType IpsecVpnService)
        {
            if (Tier1Id == null) { throw new System.ArgumentNullException("Tier1Id cannot be null"); }
            if (ServiceId == null) { throw new System.ArgumentNullException("ServiceId cannot be null"); }
            if (IpsecVpnService == null) { throw new System.ArgumentNullException("IpsecVpnService cannot be null"); }
            StringBuilder CreateOrPatchTier1VpnIpsecVpnServiceServiceURL = new StringBuilder("/infra/tier-1s/{tier-1-id}/ipsec-vpn-services/{service-id}");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Patch
            };
            CreateOrPatchTier1VpnIpsecVpnServiceServiceURL.Replace("{tier-1-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(Tier1Id, System.Globalization.CultureInfo.InvariantCulture)));
            CreateOrPatchTier1VpnIpsecVpnServiceServiceURL.Replace("{service-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(ServiceId, System.Globalization.CultureInfo.InvariantCulture)));
            request.AddJsonBody(IpsecVpnService);
            request.Resource = CreateOrPatchTier1VpnIpsecVpnServiceServiceURL.ToString();
            RestResponse response = await restClient.ExecuteTaskAsyncWithPolicy(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Patch operation to " + CreateOrPatchTier1VpnIpsecVpnServiceServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTIPSecVpnDpdProfileListResultType> ListIpsecVpnDpdProfiles(string? Cursor = null, bool? IncludeMarkForDeleteObjects = null, string? IncludedFields = null, long? PageSize = null, bool? SortAscending = null, string? SortBy = null)
        {
            StringBuilder ListIpsecVpnDpdProfilesServiceURL = new StringBuilder("/infra/ipsec-vpn-dpd-profiles");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Get
            };
            if (Cursor != null) { request.AddQueryParameter("cursor", Cursor.ToString()); }
            if (IncludeMarkForDeleteObjects != null) { request.AddQueryParameter("include_mark_for_delete_objects", IncludeMarkForDeleteObjects.ToString()); }
            if (IncludedFields != null) { request.AddQueryParameter("included_fields", IncludedFields.ToString()); }
            if (PageSize != null) { request.AddQueryParameter("page_size", PageSize.ToString()); }
            if (SortAscending != null) { request.AddQueryParameter("sort_ascending", SortAscending.ToString()); }
            if (SortBy != null) { request.AddQueryParameter("sort_by", SortBy.ToString()); }
            request.Resource = ListIpsecVpnDpdProfilesServiceURL.ToString();
            RestResponse<NSXTIPSecVpnDpdProfileListResultType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTIPSecVpnDpdProfileListResultType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Get operation to " + ListIpsecVpnDpdProfilesServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTIPSecVpnSessionType> GetTier1VpnIpsecVpnSessionWithSensitiveData(string Tier1Id, string ServiceId, string SessionId)
        {
            if (Tier1Id == null) { throw new System.ArgumentNullException("Tier1Id cannot be null"); }
            if (ServiceId == null) { throw new System.ArgumentNullException("ServiceId cannot be null"); }
            if (SessionId == null) { throw new System.ArgumentNullException("SessionId cannot be null"); }
            StringBuilder GetTier1VpnIpsecVpnSessionWithSensitiveDataServiceURL = new StringBuilder("/infra/tier-1s/{tier-1-id}/ipsec-vpn-services/{service-id}/sessions/{session-id}?action=show_sensitive_data");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Get
            };
            GetTier1VpnIpsecVpnSessionWithSensitiveDataServiceURL.Replace("{tier-1-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(Tier1Id, System.Globalization.CultureInfo.InvariantCulture)));
            GetTier1VpnIpsecVpnSessionWithSensitiveDataServiceURL.Replace("{service-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(ServiceId, System.Globalization.CultureInfo.InvariantCulture)));
            GetTier1VpnIpsecVpnSessionWithSensitiveDataServiceURL.Replace("{session-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(SessionId, System.Globalization.CultureInfo.InvariantCulture)));
            request.Resource = GetTier1VpnIpsecVpnSessionWithSensitiveDataServiceURL.ToString();
            RestResponse<NSXTIPSecVpnSessionType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTIPSecVpnSessionType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Get operation to " + GetTier1VpnIpsecVpnSessionWithSensitiveDataServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTIPSecVpnSessionType> CreateOrUpdateTier0VpnIpsecVpnSession(string Tier0Id, string ServiceId, string SessionId, NSXTIPSecVpnSessionType IpsecVpnSession)
        {
            if (Tier0Id == null) { throw new System.ArgumentNullException("Tier0Id cannot be null"); }
            if (ServiceId == null) { throw new System.ArgumentNullException("ServiceId cannot be null"); }
            if (SessionId == null) { throw new System.ArgumentNullException("SessionId cannot be null"); }
            if (IpsecVpnSession == null) { throw new System.ArgumentNullException("IpsecVpnSession cannot be null"); }
            StringBuilder CreateOrUpdateTier0VpnIpsecVpnSessionServiceURL = new StringBuilder("/infra/tier-0s/{tier-0-id}/ipsec-vpn-services/{service-id}/sessions/{session-id}");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Put
            };
            CreateOrUpdateTier0VpnIpsecVpnSessionServiceURL.Replace("{tier-0-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(Tier0Id, System.Globalization.CultureInfo.InvariantCulture)));
            CreateOrUpdateTier0VpnIpsecVpnSessionServiceURL.Replace("{service-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(ServiceId, System.Globalization.CultureInfo.InvariantCulture)));
            CreateOrUpdateTier0VpnIpsecVpnSessionServiceURL.Replace("{session-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(SessionId, System.Globalization.CultureInfo.InvariantCulture)));
            request.AddJsonBody(IpsecVpnSession);
            request.Resource = CreateOrUpdateTier0VpnIpsecVpnSessionServiceURL.ToString();
            RestResponse<NSXTIPSecVpnSessionType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTIPSecVpnSessionType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Put operation to " + CreateOrUpdateTier0VpnIpsecVpnSessionServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTIPSecVpnSessionType> GetTier0VpnIpsecVpnSession(string Tier0Id, string ServiceId, string SessionId)
        {
            if (Tier0Id == null) { throw new System.ArgumentNullException("Tier0Id cannot be null"); }
            if (ServiceId == null) { throw new System.ArgumentNullException("ServiceId cannot be null"); }
            if (SessionId == null) { throw new System.ArgumentNullException("SessionId cannot be null"); }
            StringBuilder GetTier0VpnIpsecVpnSessionServiceURL = new StringBuilder("/infra/tier-0s/{tier-0-id}/ipsec-vpn-services/{service-id}/sessions/{session-id}");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Get
            };
            GetTier0VpnIpsecVpnSessionServiceURL.Replace("{tier-0-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(Tier0Id, System.Globalization.CultureInfo.InvariantCulture)));
            GetTier0VpnIpsecVpnSessionServiceURL.Replace("{service-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(ServiceId, System.Globalization.CultureInfo.InvariantCulture)));
            GetTier0VpnIpsecVpnSessionServiceURL.Replace("{session-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(SessionId, System.Globalization.CultureInfo.InvariantCulture)));
            request.Resource = GetTier0VpnIpsecVpnSessionServiceURL.ToString();
            RestResponse<NSXTIPSecVpnSessionType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTIPSecVpnSessionType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Get operation to " + GetTier0VpnIpsecVpnSessionServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task DeleteTier0VpnIpsecVpnSession(string Tier0Id, string ServiceId, string SessionId)
        {
            if (Tier0Id == null) { throw new System.ArgumentNullException("Tier0Id cannot be null"); }
            if (ServiceId == null) { throw new System.ArgumentNullException("ServiceId cannot be null"); }
            if (SessionId == null) { throw new System.ArgumentNullException("SessionId cannot be null"); }
            StringBuilder DeleteTier0VpnIpsecVpnSessionServiceURL = new StringBuilder("/infra/tier-0s/{tier-0-id}/ipsec-vpn-services/{service-id}/sessions/{session-id}");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Delete
            };
            DeleteTier0VpnIpsecVpnSessionServiceURL.Replace("{tier-0-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(Tier0Id, System.Globalization.CultureInfo.InvariantCulture)));
            DeleteTier0VpnIpsecVpnSessionServiceURL.Replace("{service-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(ServiceId, System.Globalization.CultureInfo.InvariantCulture)));
            DeleteTier0VpnIpsecVpnSessionServiceURL.Replace("{session-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(SessionId, System.Globalization.CultureInfo.InvariantCulture)));
            request.Resource = DeleteTier0VpnIpsecVpnSessionServiceURL.ToString();
            RestResponse response = await restClient.ExecuteTaskAsyncWithPolicy(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Delete operation to " + DeleteTier0VpnIpsecVpnSessionServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task CreateOrPatchTier0VpnIpsecVpnSession(string Tier0Id, string ServiceId, string SessionId, NSXTIPSecVpnSessionType IpsecVpnSession)
        {
            if (Tier0Id == null) { throw new System.ArgumentNullException("Tier0Id cannot be null"); }
            if (ServiceId == null) { throw new System.ArgumentNullException("ServiceId cannot be null"); }
            if (SessionId == null) { throw new System.ArgumentNullException("SessionId cannot be null"); }
            if (IpsecVpnSession == null) { throw new System.ArgumentNullException("IpsecVpnSession cannot be null"); }
            StringBuilder CreateOrPatchTier0VpnIpsecVpnSessionServiceURL = new StringBuilder("/infra/tier-0s/{tier-0-id}/ipsec-vpn-services/{service-id}/sessions/{session-id}");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Patch
            };
            CreateOrPatchTier0VpnIpsecVpnSessionServiceURL.Replace("{tier-0-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(Tier0Id, System.Globalization.CultureInfo.InvariantCulture)));
            CreateOrPatchTier0VpnIpsecVpnSessionServiceURL.Replace("{service-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(ServiceId, System.Globalization.CultureInfo.InvariantCulture)));
            CreateOrPatchTier0VpnIpsecVpnSessionServiceURL.Replace("{session-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(SessionId, System.Globalization.CultureInfo.InvariantCulture)));
            request.AddJsonBody(IpsecVpnSession);
            request.Resource = CreateOrPatchTier0VpnIpsecVpnSessionServiceURL.ToString();
            RestResponse response = await restClient.ExecuteTaskAsyncWithPolicy(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Patch operation to " + CreateOrPatchTier0VpnIpsecVpnSessionServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            
        }
    }
}
