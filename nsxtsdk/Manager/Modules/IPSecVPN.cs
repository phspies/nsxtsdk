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
    public class IPSecVPN
    {
        private RestClient restClient;
        private int retry;
        private int timeout;
        private CancellationToken cancellationToken;

        public IPSecVPN(RestClient Client, CancellationToken _cancellationToken, int _timeout, int _retry)
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
        public async Task<NSXTIPSecVPNServiceType> UpdateIpsecVpnservice(string IpsecVpnServiceId, NSXTIPSecVPNServiceType IpsecVpnservice)
        {
            if (IpsecVpnServiceId == null) { throw new System.ArgumentNullException("IpsecVpnServiceId cannot be null"); }
            if (IpsecVpnservice == null) { throw new System.ArgumentNullException("IpsecVpnservice cannot be null"); }
            StringBuilder UpdateIpsecVpnserviceServiceURL = new StringBuilder("/vpn/ipsec/services/{ipsec-vpn-service-id}");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Put
            };
            UpdateIpsecVpnserviceServiceURL.Replace("{ipsec-vpn-service-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(IpsecVpnServiceId, System.Globalization.CultureInfo.InvariantCulture)));
            request.AddJsonBody(IpsecVpnservice);
            request.Resource = UpdateIpsecVpnserviceServiceURL.ToString();
            RestResponse<NSXTIPSecVPNServiceType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTIPSecVPNServiceType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Put operation to " + UpdateIpsecVpnserviceServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTIPSecVPNServiceType> GetIpsecVpnservice(string IpsecVpnServiceId)
        {
            if (IpsecVpnServiceId == null) { throw new System.ArgumentNullException("IpsecVpnServiceId cannot be null"); }
            StringBuilder GetIpsecVpnserviceServiceURL = new StringBuilder("/vpn/ipsec/services/{ipsec-vpn-service-id}");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Get
            };
            GetIpsecVpnserviceServiceURL.Replace("{ipsec-vpn-service-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(IpsecVpnServiceId, System.Globalization.CultureInfo.InvariantCulture)));
            request.Resource = GetIpsecVpnserviceServiceURL.ToString();
            RestResponse<NSXTIPSecVPNServiceType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTIPSecVPNServiceType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Get operation to " + GetIpsecVpnserviceServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task DeleteIpsecVpnservice(string IpsecVpnServiceId, bool? Force = null)
        {
            if (IpsecVpnServiceId == null) { throw new System.ArgumentNullException("IpsecVpnServiceId cannot be null"); }
            StringBuilder DeleteIpsecVpnserviceServiceURL = new StringBuilder("/vpn/ipsec/services/{ipsec-vpn-service-id}");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Delete
            };
            DeleteIpsecVpnserviceServiceURL.Replace("{ipsec-vpn-service-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(IpsecVpnServiceId, System.Globalization.CultureInfo.InvariantCulture)));
            if (Force != null) { request.AddQueryParameter("force", Force.ToString()); }
            request.Resource = DeleteIpsecVpnserviceServiceURL.ToString();
            RestResponse response = await restClient.ExecuteTaskAsyncWithPolicy(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Delete operation to " + DeleteIpsecVpnserviceServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTIPSecVPNPeerEndpointType> UpdateIpsecVpnpeerEndpoint(string IpsecVpnPeerEndpointId, NSXTIPSecVPNPeerEndpointType IpsecVpnpeerEndpoint)
        {
            if (IpsecVpnPeerEndpointId == null) { throw new System.ArgumentNullException("IpsecVpnPeerEndpointId cannot be null"); }
            if (IpsecVpnpeerEndpoint == null) { throw new System.ArgumentNullException("IpsecVpnpeerEndpoint cannot be null"); }
            StringBuilder UpdateIpsecVpnpeerEndpointServiceURL = new StringBuilder("/vpn/ipsec/peer-endpoints/{ipsec-vpn-peer-endpoint-id}");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Put
            };
            UpdateIpsecVpnpeerEndpointServiceURL.Replace("{ipsec-vpn-peer-endpoint-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(IpsecVpnPeerEndpointId, System.Globalization.CultureInfo.InvariantCulture)));
            request.AddJsonBody(IpsecVpnpeerEndpoint);
            request.Resource = UpdateIpsecVpnpeerEndpointServiceURL.ToString();
            RestResponse<NSXTIPSecVPNPeerEndpointType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTIPSecVPNPeerEndpointType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Put operation to " + UpdateIpsecVpnpeerEndpointServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTIPSecVPNPeerEndpointType> GetIpsecVpnpeerEndpoint(string IpsecVpnPeerEndpointId)
        {
            if (IpsecVpnPeerEndpointId == null) { throw new System.ArgumentNullException("IpsecVpnPeerEndpointId cannot be null"); }
            StringBuilder GetIpsecVpnpeerEndpointServiceURL = new StringBuilder("/vpn/ipsec/peer-endpoints/{ipsec-vpn-peer-endpoint-id}");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Get
            };
            GetIpsecVpnpeerEndpointServiceURL.Replace("{ipsec-vpn-peer-endpoint-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(IpsecVpnPeerEndpointId, System.Globalization.CultureInfo.InvariantCulture)));
            request.Resource = GetIpsecVpnpeerEndpointServiceURL.ToString();
            RestResponse<NSXTIPSecVPNPeerEndpointType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTIPSecVPNPeerEndpointType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Get operation to " + GetIpsecVpnpeerEndpointServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task DeleteIpsecVpnpeerEndpoint(string IpsecVpnPeerEndpointId, bool? Force = null)
        {
            if (IpsecVpnPeerEndpointId == null) { throw new System.ArgumentNullException("IpsecVpnPeerEndpointId cannot be null"); }
            StringBuilder DeleteIpsecVpnpeerEndpointServiceURL = new StringBuilder("/vpn/ipsec/peer-endpoints/{ipsec-vpn-peer-endpoint-id}");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Delete
            };
            DeleteIpsecVpnpeerEndpointServiceURL.Replace("{ipsec-vpn-peer-endpoint-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(IpsecVpnPeerEndpointId, System.Globalization.CultureInfo.InvariantCulture)));
            if (Force != null) { request.AddQueryParameter("force", Force.ToString()); }
            request.Resource = DeleteIpsecVpnpeerEndpointServiceURL.ToString();
            RestResponse response = await restClient.ExecuteTaskAsyncWithPolicy(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Delete operation to " + DeleteIpsecVpnpeerEndpointServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTIPSecVPNTunnelProfileType> UpdateIpsecVpntunnelProfile(string IpsecVpnTunnelProfileId, NSXTIPSecVPNTunnelProfileType IpsecVpntunnelProfile)
        {
            if (IpsecVpnTunnelProfileId == null) { throw new System.ArgumentNullException("IpsecVpnTunnelProfileId cannot be null"); }
            if (IpsecVpntunnelProfile == null) { throw new System.ArgumentNullException("IpsecVpntunnelProfile cannot be null"); }
            StringBuilder UpdateIpsecVpntunnelProfileServiceURL = new StringBuilder("/vpn/ipsec/tunnel-profiles/{ipsec-vpn-tunnel-profile-id}");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Put
            };
            UpdateIpsecVpntunnelProfileServiceURL.Replace("{ipsec-vpn-tunnel-profile-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(IpsecVpnTunnelProfileId, System.Globalization.CultureInfo.InvariantCulture)));
            request.AddJsonBody(IpsecVpntunnelProfile);
            request.Resource = UpdateIpsecVpntunnelProfileServiceURL.ToString();
            RestResponse<NSXTIPSecVPNTunnelProfileType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTIPSecVPNTunnelProfileType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Put operation to " + UpdateIpsecVpntunnelProfileServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTIPSecVPNTunnelProfileType> GetIpsecVpntunnelProfile(string IpsecVpnTunnelProfileId)
        {
            if (IpsecVpnTunnelProfileId == null) { throw new System.ArgumentNullException("IpsecVpnTunnelProfileId cannot be null"); }
            StringBuilder GetIpsecVpntunnelProfileServiceURL = new StringBuilder("/vpn/ipsec/tunnel-profiles/{ipsec-vpn-tunnel-profile-id}");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Get
            };
            GetIpsecVpntunnelProfileServiceURL.Replace("{ipsec-vpn-tunnel-profile-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(IpsecVpnTunnelProfileId, System.Globalization.CultureInfo.InvariantCulture)));
            request.Resource = GetIpsecVpntunnelProfileServiceURL.ToString();
            RestResponse<NSXTIPSecVPNTunnelProfileType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTIPSecVPNTunnelProfileType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Get operation to " + GetIpsecVpntunnelProfileServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task DeleteIpsecVpntunnelProfile(string IpsecVpnTunnelProfileId, bool? Force = null)
        {
            if (IpsecVpnTunnelProfileId == null) { throw new System.ArgumentNullException("IpsecVpnTunnelProfileId cannot be null"); }
            StringBuilder DeleteIpsecVpntunnelProfileServiceURL = new StringBuilder("/vpn/ipsec/tunnel-profiles/{ipsec-vpn-tunnel-profile-id}");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Delete
            };
            DeleteIpsecVpntunnelProfileServiceURL.Replace("{ipsec-vpn-tunnel-profile-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(IpsecVpnTunnelProfileId, System.Globalization.CultureInfo.InvariantCulture)));
            if (Force != null) { request.AddQueryParameter("force", Force.ToString()); }
            request.Resource = DeleteIpsecVpntunnelProfileServiceURL.ToString();
            RestResponse response = await restClient.ExecuteTaskAsyncWithPolicy(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Delete operation to " + DeleteIpsecVpntunnelProfileServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTIPSecVPNLocalEndpointType> CreateIpsecVpnlocalEndpoint(NSXTIPSecVPNLocalEndpointType IpsecVpnlocalEndpoint)
        {
            if (IpsecVpnlocalEndpoint == null) { throw new System.ArgumentNullException("IpsecVpnlocalEndpoint cannot be null"); }
            StringBuilder CreateIpsecVpnlocalEndpointServiceURL = new StringBuilder("/vpn/ipsec/local-endpoints");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Post
            };
            request.AddJsonBody(IpsecVpnlocalEndpoint);
            request.Resource = CreateIpsecVpnlocalEndpointServiceURL.ToString();
            RestResponse<NSXTIPSecVPNLocalEndpointType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTIPSecVPNLocalEndpointType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Post operation to " + CreateIpsecVpnlocalEndpointServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTIPSecVPNLocalEndpointListResultType> ListIpsecVpnlocalEndpoints(string? Cursor = null, string? IncludedFields = null, string? IpsecVpnServiceId = null, string? LogicalRouterId = null, long? PageSize = null, bool? SortAscending = null, string? SortBy = null)
        {
            StringBuilder ListIpsecVpnlocalEndpointsServiceURL = new StringBuilder("/vpn/ipsec/local-endpoints");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Get
            };
            if (Cursor != null) { request.AddQueryParameter("cursor", Cursor.ToString()); }
            if (IncludedFields != null) { request.AddQueryParameter("included_fields", IncludedFields.ToString()); }
            if (IpsecVpnServiceId != null) { request.AddQueryParameter("ipsec_vpn_service_id", IpsecVpnServiceId.ToString()); }
            if (LogicalRouterId != null) { request.AddQueryParameter("logical_router_id", LogicalRouterId.ToString()); }
            if (PageSize != null) { request.AddQueryParameter("page_size", PageSize.ToString()); }
            if (SortAscending != null) { request.AddQueryParameter("sort_ascending", SortAscending.ToString()); }
            if (SortBy != null) { request.AddQueryParameter("sort_by", SortBy.ToString()); }
            request.Resource = ListIpsecVpnlocalEndpointsServiceURL.ToString();
            RestResponse<NSXTIPSecVPNLocalEndpointListResultType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTIPSecVPNLocalEndpointListResultType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Get operation to " + ListIpsecVpnlocalEndpointsServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTIPSecVPNPeerEndpointType> GetIpsecVpnpeerEndpointWithPSK(string IpsecVpnPeerEndpointId)
        {
            if (IpsecVpnPeerEndpointId == null) { throw new System.ArgumentNullException("IpsecVpnPeerEndpointId cannot be null"); }
            StringBuilder GetIpsecVpnpeerEndpointWithPSKServiceURL = new StringBuilder("/vpn/ipsec/peer-endpoints/{ipsec-vpn-peer-endpoint-id}?action=show-sensitive-data");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Get
            };
            GetIpsecVpnpeerEndpointWithPSKServiceURL.Replace("{ipsec-vpn-peer-endpoint-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(IpsecVpnPeerEndpointId, System.Globalization.CultureInfo.InvariantCulture)));
            request.Resource = GetIpsecVpnpeerEndpointWithPSKServiceURL.ToString();
            RestResponse<NSXTIPSecVPNPeerEndpointType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTIPSecVPNPeerEndpointType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Get operation to " + GetIpsecVpnpeerEndpointWithPSKServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTIPSecVPNIKEProfileType> UpdateIpsecVpnikeprofile(string IpsecVpnIkeProfileId, NSXTIPSecVPNIKEProfileType IpsecVpnikeprofile)
        {
            if (IpsecVpnIkeProfileId == null) { throw new System.ArgumentNullException("IpsecVpnIkeProfileId cannot be null"); }
            if (IpsecVpnikeprofile == null) { throw new System.ArgumentNullException("IpsecVpnikeprofile cannot be null"); }
            StringBuilder UpdateIpsecVpnikeprofileServiceURL = new StringBuilder("/vpn/ipsec/ike-profiles/{ipsec-vpn-ike-profile-id}");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Put
            };
            UpdateIpsecVpnikeprofileServiceURL.Replace("{ipsec-vpn-ike-profile-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(IpsecVpnIkeProfileId, System.Globalization.CultureInfo.InvariantCulture)));
            request.AddJsonBody(IpsecVpnikeprofile);
            request.Resource = UpdateIpsecVpnikeprofileServiceURL.ToString();
            RestResponse<NSXTIPSecVPNIKEProfileType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTIPSecVPNIKEProfileType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Put operation to " + UpdateIpsecVpnikeprofileServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTIPSecVPNIKEProfileType> GetIpsecVpnikeprofile(string IpsecVpnIkeProfileId)
        {
            if (IpsecVpnIkeProfileId == null) { throw new System.ArgumentNullException("IpsecVpnIkeProfileId cannot be null"); }
            StringBuilder GetIpsecVpnikeprofileServiceURL = new StringBuilder("/vpn/ipsec/ike-profiles/{ipsec-vpn-ike-profile-id}");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Get
            };
            GetIpsecVpnikeprofileServiceURL.Replace("{ipsec-vpn-ike-profile-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(IpsecVpnIkeProfileId, System.Globalization.CultureInfo.InvariantCulture)));
            request.Resource = GetIpsecVpnikeprofileServiceURL.ToString();
            RestResponse<NSXTIPSecVPNIKEProfileType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTIPSecVPNIKEProfileType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Get operation to " + GetIpsecVpnikeprofileServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task DeleteIpsecVpnikeprofile(string IpsecVpnIkeProfileId, bool? Force = null)
        {
            if (IpsecVpnIkeProfileId == null) { throw new System.ArgumentNullException("IpsecVpnIkeProfileId cannot be null"); }
            StringBuilder DeleteIpsecVpnikeprofileServiceURL = new StringBuilder("/vpn/ipsec/ike-profiles/{ipsec-vpn-ike-profile-id}");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Delete
            };
            DeleteIpsecVpnikeprofileServiceURL.Replace("{ipsec-vpn-ike-profile-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(IpsecVpnIkeProfileId, System.Globalization.CultureInfo.InvariantCulture)));
            if (Force != null) { request.AddQueryParameter("force", Force.ToString()); }
            request.Resource = DeleteIpsecVpnikeprofileServiceURL.ToString();
            RestResponse response = await restClient.ExecuteTaskAsyncWithPolicy(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Delete operation to " + DeleteIpsecVpnikeprofileServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTIPSecVPNSessionStateType> GetIpsecVpnsessionState(string IpsecVpnSessionId, long? BarrierId = null, string? RequestId = null)
        {
            if (IpsecVpnSessionId == null) { throw new System.ArgumentNullException("IpsecVpnSessionId cannot be null"); }
            StringBuilder GetIpsecVpnsessionStateServiceURL = new StringBuilder("/vpn/ipsec/sessions/{ipsec-vpn-session-id}/state");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Get
            };
            GetIpsecVpnsessionStateServiceURL.Replace("{ipsec-vpn-session-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(IpsecVpnSessionId, System.Globalization.CultureInfo.InvariantCulture)));
            if (BarrierId != null) { request.AddQueryParameter("barrier_id", BarrierId.ToString()); }
            if (RequestId != null) { request.AddQueryParameter("request_id", RequestId.ToString()); }
            request.Resource = GetIpsecVpnsessionStateServiceURL.ToString();
            RestResponse<NSXTIPSecVPNSessionStateType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTIPSecVPNSessionStateType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Get operation to " + GetIpsecVpnsessionStateServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTIPSecVPNSessionType> UpdateIpsecVpnsession(string IpsecVpnSessionId, NSXTIPSecVPNSessionType IpsecVpnsession)
        {
            if (IpsecVpnSessionId == null) { throw new System.ArgumentNullException("IpsecVpnSessionId cannot be null"); }
            if (IpsecVpnsession == null) { throw new System.ArgumentNullException("IpsecVpnsession cannot be null"); }
            StringBuilder UpdateIpsecVpnsessionServiceURL = new StringBuilder("/vpn/ipsec/sessions/{ipsec-vpn-session-id}");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Put
            };
            UpdateIpsecVpnsessionServiceURL.Replace("{ipsec-vpn-session-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(IpsecVpnSessionId, System.Globalization.CultureInfo.InvariantCulture)));
            request.AddJsonBody(IpsecVpnsession);
            request.Resource = UpdateIpsecVpnsessionServiceURL.ToString();
            RestResponse<NSXTIPSecVPNSessionType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTIPSecVPNSessionType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Put operation to " + UpdateIpsecVpnsessionServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task DeleteIpsecVpnsession(string IpsecVpnSessionId, bool? Force = null)
        {
            if (IpsecVpnSessionId == null) { throw new System.ArgumentNullException("IpsecVpnSessionId cannot be null"); }
            StringBuilder DeleteIpsecVpnsessionServiceURL = new StringBuilder("/vpn/ipsec/sessions/{ipsec-vpn-session-id}");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Delete
            };
            DeleteIpsecVpnsessionServiceURL.Replace("{ipsec-vpn-session-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(IpsecVpnSessionId, System.Globalization.CultureInfo.InvariantCulture)));
            if (Force != null) { request.AddQueryParameter("force", Force.ToString()); }
            request.Resource = DeleteIpsecVpnsessionServiceURL.ToString();
            RestResponse response = await restClient.ExecuteTaskAsyncWithPolicy(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Delete operation to " + DeleteIpsecVpnsessionServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTIPSecVPNSessionType> GetIpsecVpnsession(string IpsecVpnSessionId)
        {
            if (IpsecVpnSessionId == null) { throw new System.ArgumentNullException("IpsecVpnSessionId cannot be null"); }
            StringBuilder GetIpsecVpnsessionServiceURL = new StringBuilder("/vpn/ipsec/sessions/{ipsec-vpn-session-id}");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Get
            };
            GetIpsecVpnsessionServiceURL.Replace("{ipsec-vpn-session-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(IpsecVpnSessionId, System.Globalization.CultureInfo.InvariantCulture)));
            request.Resource = GetIpsecVpnsessionServiceURL.ToString();
            RestResponse<NSXTIPSecVPNSessionType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTIPSecVPNSessionType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Get operation to " + GetIpsecVpnsessionServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTIPSecVPNDPDProfileType> UpdateIpsecVpndpdprofile(string IpsecVpnDpdProfileId, NSXTIPSecVPNDPDProfileType IpsecVpndpdprofile)
        {
            if (IpsecVpnDpdProfileId == null) { throw new System.ArgumentNullException("IpsecVpnDpdProfileId cannot be null"); }
            if (IpsecVpndpdprofile == null) { throw new System.ArgumentNullException("IpsecVpndpdprofile cannot be null"); }
            StringBuilder UpdateIpsecVpndpdprofileServiceURL = new StringBuilder("/vpn/ipsec/dpd-profiles/{ipsec-vpn-dpd-profile-id}");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Put
            };
            UpdateIpsecVpndpdprofileServiceURL.Replace("{ipsec-vpn-dpd-profile-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(IpsecVpnDpdProfileId, System.Globalization.CultureInfo.InvariantCulture)));
            request.AddJsonBody(IpsecVpndpdprofile);
            request.Resource = UpdateIpsecVpndpdprofileServiceURL.ToString();
            RestResponse<NSXTIPSecVPNDPDProfileType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTIPSecVPNDPDProfileType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Put operation to " + UpdateIpsecVpndpdprofileServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task DeleteIpsecVpndpdprofile(string IpsecVpnDpdProfileId, bool? Force = null)
        {
            if (IpsecVpnDpdProfileId == null) { throw new System.ArgumentNullException("IpsecVpnDpdProfileId cannot be null"); }
            StringBuilder DeleteIpsecVpndpdprofileServiceURL = new StringBuilder("/vpn/ipsec/dpd-profiles/{ipsec-vpn-dpd-profile-id}");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Delete
            };
            DeleteIpsecVpndpdprofileServiceURL.Replace("{ipsec-vpn-dpd-profile-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(IpsecVpnDpdProfileId, System.Globalization.CultureInfo.InvariantCulture)));
            if (Force != null) { request.AddQueryParameter("force", Force.ToString()); }
            request.Resource = DeleteIpsecVpndpdprofileServiceURL.ToString();
            RestResponse response = await restClient.ExecuteTaskAsyncWithPolicy(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Delete operation to " + DeleteIpsecVpndpdprofileServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTIPSecVPNDPDProfileType> GetIpsecVpndpdprofile(string IpsecVpnDpdProfileId)
        {
            if (IpsecVpnDpdProfileId == null) { throw new System.ArgumentNullException("IpsecVpnDpdProfileId cannot be null"); }
            StringBuilder GetIpsecVpndpdprofileServiceURL = new StringBuilder("/vpn/ipsec/dpd-profiles/{ipsec-vpn-dpd-profile-id}");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Get
            };
            GetIpsecVpndpdprofileServiceURL.Replace("{ipsec-vpn-dpd-profile-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(IpsecVpnDpdProfileId, System.Globalization.CultureInfo.InvariantCulture)));
            request.Resource = GetIpsecVpndpdprofileServiceURL.ToString();
            RestResponse<NSXTIPSecVPNDPDProfileType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTIPSecVPNDPDProfileType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Get operation to " + GetIpsecVpndpdprofileServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTIPSecVPNPeerEndpointType> CreateIpsecVpnpeerEndPoint(NSXTIPSecVPNPeerEndpointType IpsecVpnpeerEndpoint)
        {
            if (IpsecVpnpeerEndpoint == null) { throw new System.ArgumentNullException("IpsecVpnpeerEndpoint cannot be null"); }
            StringBuilder CreateIpsecVpnpeerEndPointServiceURL = new StringBuilder("/vpn/ipsec/peer-endpoints");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Post
            };
            request.AddJsonBody(IpsecVpnpeerEndpoint);
            request.Resource = CreateIpsecVpnpeerEndPointServiceURL.ToString();
            RestResponse<NSXTIPSecVPNPeerEndpointType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTIPSecVPNPeerEndpointType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Post operation to " + CreateIpsecVpnpeerEndPointServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTIPSecVPNPeerEndpointListResultType> ListIpsecVpnpeerEndpoints(string? Cursor = null, string? IncludedFields = null, long? PageSize = null, bool? SortAscending = null, string? SortBy = null)
        {
            StringBuilder ListIpsecVpnpeerEndpointsServiceURL = new StringBuilder("/vpn/ipsec/peer-endpoints");
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
            request.Resource = ListIpsecVpnpeerEndpointsServiceURL.ToString();
            RestResponse<NSXTIPSecVPNPeerEndpointListResultType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTIPSecVPNPeerEndpointListResultType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Get operation to " + ListIpsecVpnpeerEndpointsServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTIPSecVPNDPDProfileType> CreateIpsecVpndpdprofile(NSXTIPSecVPNDPDProfileType IpsecVpndpdprofile)
        {
            if (IpsecVpndpdprofile == null) { throw new System.ArgumentNullException("IpsecVpndpdprofile cannot be null"); }
            StringBuilder CreateIpsecVpndpdprofileServiceURL = new StringBuilder("/vpn/ipsec/dpd-profiles");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Post
            };
            request.AddJsonBody(IpsecVpndpdprofile);
            request.Resource = CreateIpsecVpndpdprofileServiceURL.ToString();
            RestResponse<NSXTIPSecVPNDPDProfileType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTIPSecVPNDPDProfileType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Post operation to " + CreateIpsecVpndpdprofileServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTIPSecVPNDPDProfileListResultType> ListIpsecVpndpdprofiles(string? Cursor = null, string? IncludedFields = null, long? PageSize = null, bool? SortAscending = null, string? SortBy = null)
        {
            StringBuilder ListIpsecVpndpdprofilesServiceURL = new StringBuilder("/vpn/ipsec/dpd-profiles");
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
            request.Resource = ListIpsecVpndpdprofilesServiceURL.ToString();
            RestResponse<NSXTIPSecVPNDPDProfileListResultType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTIPSecVPNDPDProfileListResultType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Get operation to " + ListIpsecVpndpdprofilesServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTIPSecVPNSessionType> CreateIpsecVpnsession(NSXTIPSecVPNSessionType IpsecVpnsession)
        {
            if (IpsecVpnsession == null) { throw new System.ArgumentNullException("IpsecVpnsession cannot be null"); }
            StringBuilder CreateIpsecVpnsessionServiceURL = new StringBuilder("/vpn/ipsec/sessions");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Post
            };
            request.AddJsonBody(IpsecVpnsession);
            request.Resource = CreateIpsecVpnsessionServiceURL.ToString();
            RestResponse<NSXTIPSecVPNSessionType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTIPSecVPNSessionType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Post operation to " + CreateIpsecVpnsessionServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTIPSecVPNSessionListResultType> ListIpsecVpnsessions(string? Cursor = null, string? IncludedFields = null, string? IpsecVpnServiceId = null, string? LogicalRouterId = null, long? PageSize = null, string? SessionType = null, bool? SortAscending = null, string? SortBy = null)
        {
            StringBuilder ListIpsecVpnsessionsServiceURL = new StringBuilder("/vpn/ipsec/sessions");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Get
            };
            if (Cursor != null) { request.AddQueryParameter("cursor", Cursor.ToString()); }
            if (IncludedFields != null) { request.AddQueryParameter("included_fields", IncludedFields.ToString()); }
            if (IpsecVpnServiceId != null) { request.AddQueryParameter("ipsec_vpn_service_id", IpsecVpnServiceId.ToString()); }
            if (LogicalRouterId != null) { request.AddQueryParameter("logical_router_id", LogicalRouterId.ToString()); }
            if (PageSize != null) { request.AddQueryParameter("page_size", PageSize.ToString()); }
            if (SessionType != null) { request.AddQueryParameter("session_type", SessionType.ToString()); }
            if (SortAscending != null) { request.AddQueryParameter("sort_ascending", SortAscending.ToString()); }
            if (SortBy != null) { request.AddQueryParameter("sort_by", SortBy.ToString()); }
            request.Resource = ListIpsecVpnsessionsServiceURL.ToString();
            RestResponse<NSXTIPSecVPNSessionListResultType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTIPSecVPNSessionListResultType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Get operation to " + ListIpsecVpnsessionsServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTIPSecVPNLocalEndpointType> UpdateIpsecVpnlocalEndpoint(string IpsecVpnLocalEndpointId, NSXTIPSecVPNLocalEndpointType IpsecVpnlocalEndpoint)
        {
            if (IpsecVpnLocalEndpointId == null) { throw new System.ArgumentNullException("IpsecVpnLocalEndpointId cannot be null"); }
            if (IpsecVpnlocalEndpoint == null) { throw new System.ArgumentNullException("IpsecVpnlocalEndpoint cannot be null"); }
            StringBuilder UpdateIpsecVpnlocalEndpointServiceURL = new StringBuilder("/vpn/ipsec/local-endpoints/{ipsec-vpn-local-endpoint-id}");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Put
            };
            UpdateIpsecVpnlocalEndpointServiceURL.Replace("{ipsec-vpn-local-endpoint-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(IpsecVpnLocalEndpointId, System.Globalization.CultureInfo.InvariantCulture)));
            request.AddJsonBody(IpsecVpnlocalEndpoint);
            request.Resource = UpdateIpsecVpnlocalEndpointServiceURL.ToString();
            RestResponse<NSXTIPSecVPNLocalEndpointType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTIPSecVPNLocalEndpointType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Put operation to " + UpdateIpsecVpnlocalEndpointServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTIPSecVPNLocalEndpointType> GetIpsecVpnlocalEndpoint(string IpsecVpnLocalEndpointId)
        {
            if (IpsecVpnLocalEndpointId == null) { throw new System.ArgumentNullException("IpsecVpnLocalEndpointId cannot be null"); }
            StringBuilder GetIpsecVpnlocalEndpointServiceURL = new StringBuilder("/vpn/ipsec/local-endpoints/{ipsec-vpn-local-endpoint-id}");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Get
            };
            GetIpsecVpnlocalEndpointServiceURL.Replace("{ipsec-vpn-local-endpoint-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(IpsecVpnLocalEndpointId, System.Globalization.CultureInfo.InvariantCulture)));
            request.Resource = GetIpsecVpnlocalEndpointServiceURL.ToString();
            RestResponse<NSXTIPSecVPNLocalEndpointType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTIPSecVPNLocalEndpointType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Get operation to " + GetIpsecVpnlocalEndpointServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task DeleteIpsecVpnlocalEndpoint(string IpsecVpnLocalEndpointId, bool? Force = null)
        {
            if (IpsecVpnLocalEndpointId == null) { throw new System.ArgumentNullException("IpsecVpnLocalEndpointId cannot be null"); }
            StringBuilder DeleteIpsecVpnlocalEndpointServiceURL = new StringBuilder("/vpn/ipsec/local-endpoints/{ipsec-vpn-local-endpoint-id}");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Delete
            };
            DeleteIpsecVpnlocalEndpointServiceURL.Replace("{ipsec-vpn-local-endpoint-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(IpsecVpnLocalEndpointId, System.Globalization.CultureInfo.InvariantCulture)));
            if (Force != null) { request.AddQueryParameter("force", Force.ToString()); }
            request.Resource = DeleteIpsecVpnlocalEndpointServiceURL.ToString();
            RestResponse response = await restClient.ExecuteTaskAsyncWithPolicy(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Delete operation to " + DeleteIpsecVpnlocalEndpointServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTIPSecVPNServiceType> CreateIpsecVpnservice(NSXTIPSecVPNServiceType IpsecVpnservice)
        {
            if (IpsecVpnservice == null) { throw new System.ArgumentNullException("IpsecVpnservice cannot be null"); }
            StringBuilder CreateIpsecVpnserviceServiceURL = new StringBuilder("/vpn/ipsec/services");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Post
            };
            request.AddJsonBody(IpsecVpnservice);
            request.Resource = CreateIpsecVpnserviceServiceURL.ToString();
            RestResponse<NSXTIPSecVPNServiceType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTIPSecVPNServiceType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Post operation to " + CreateIpsecVpnserviceServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTIPSecVPNServiceListResultType> ListIpsecVpnservices(string? Cursor = null, string? IncludedFields = null, long? PageSize = null, bool? SortAscending = null, string? SortBy = null)
        {
            StringBuilder ListIpsecVpnservicesServiceURL = new StringBuilder("/vpn/ipsec/services");
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
            request.Resource = ListIpsecVpnservicesServiceURL.ToString();
            RestResponse<NSXTIPSecVPNServiceListResultType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTIPSecVPNServiceListResultType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Get operation to " + ListIpsecVpnservicesServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTIPSecVPNIKEProfileType> CreateIpsecVpnikeprofile(NSXTIPSecVPNIKEProfileType IpsecVpnikeprofile)
        {
            if (IpsecVpnikeprofile == null) { throw new System.ArgumentNullException("IpsecVpnikeprofile cannot be null"); }
            StringBuilder CreateIpsecVpnikeprofileServiceURL = new StringBuilder("/vpn/ipsec/ike-profiles");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Post
            };
            request.AddJsonBody(IpsecVpnikeprofile);
            request.Resource = CreateIpsecVpnikeprofileServiceURL.ToString();
            RestResponse<NSXTIPSecVPNIKEProfileType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTIPSecVPNIKEProfileType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Post operation to " + CreateIpsecVpnikeprofileServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTIPSecVPNIKEProfileListResultType> ListIpsecVpnikeprofiles(string? Cursor = null, string? IncludedFields = null, long? PageSize = null, bool? SortAscending = null, string? SortBy = null)
        {
            StringBuilder ListIpsecVpnikeprofilesServiceURL = new StringBuilder("/vpn/ipsec/ike-profiles");
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
            request.Resource = ListIpsecVpnikeprofilesServiceURL.ToString();
            RestResponse<NSXTIPSecVPNIKEProfileListResultType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTIPSecVPNIKEProfileListResultType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Get operation to " + ListIpsecVpnikeprofilesServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<string> GetPeerConfig(string IpsecVpnSessionId)
        {
            if (IpsecVpnSessionId == null) { throw new System.ArgumentNullException("IpsecVpnSessionId cannot be null"); }
            StringBuilder GetPeerConfigServiceURL = new StringBuilder("/vpn/ipsec/sessions/{ipsec-vpn-session-id}/peer-config");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Get
            };
            GetPeerConfigServiceURL.Replace("{ipsec-vpn-session-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(IpsecVpnSessionId, System.Globalization.CultureInfo.InvariantCulture)));
            request.Resource = GetPeerConfigServiceURL.ToString();
            RestResponse<string> response = await restClient.ExecuteTaskAsyncWithPolicy<string>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Get operation to " + GetPeerConfigServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTIPSecVPNTunnelProfileType> CreateIpsecVpntunnelProfile(NSXTIPSecVPNTunnelProfileType IpsecVpntunnelProfile)
        {
            if (IpsecVpntunnelProfile == null) { throw new System.ArgumentNullException("IpsecVpntunnelProfile cannot be null"); }
            StringBuilder CreateIpsecVpntunnelProfileServiceURL = new StringBuilder("/vpn/ipsec/tunnel-profiles");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Post
            };
            request.AddJsonBody(IpsecVpntunnelProfile);
            request.Resource = CreateIpsecVpntunnelProfileServiceURL.ToString();
            RestResponse<NSXTIPSecVPNTunnelProfileType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTIPSecVPNTunnelProfileType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Post operation to " + CreateIpsecVpntunnelProfileServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTIPSecVPNTunnelProfileListResultType> ListIpsecVpntunnelProfiles(string? Cursor = null, string? IncludedFields = null, long? PageSize = null, bool? SortAscending = null, string? SortBy = null)
        {
            StringBuilder ListIpsecVpntunnelProfilesServiceURL = new StringBuilder("/vpn/ipsec/tunnel-profiles");
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
            request.Resource = ListIpsecVpntunnelProfilesServiceURL.ToString();
            RestResponse<NSXTIPSecVPNTunnelProfileListResultType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTIPSecVPNTunnelProfileListResultType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Get operation to " + ListIpsecVpntunnelProfilesServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
    }
}
