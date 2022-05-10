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
    public class PolicyLayer2VPN
    {
        private RestClient restClient;
        private int retry;
        private int timeout;
        private CancellationToken cancellationToken;

        public PolicyLayer2VPN(RestClient Client, CancellationToken _cancellationToken, int _timeout, int _retry)
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
        public async Task<NSXTL2VPNServiceListResultType> ListTier1L2Vpnservices(string Tier1Id, string LocaleServiceId, string? Cursor = null, bool? IncludeMarkForDeleteObjects = null, string? IncludedFields = null, long? PageSize = null, bool? SortAscending = null, string? SortBy = null)
        {
            if (Tier1Id == null) { throw new System.ArgumentNullException("Tier1Id cannot be null"); }
            if (LocaleServiceId == null) { throw new System.ArgumentNullException("LocaleServiceId cannot be null"); }
            StringBuilder ListTier1L2VpnservicesServiceURL = new StringBuilder("/infra/tier-1s/{tier-1-id}/locale-services/{locale-service-id}/l2vpn-services");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Get
            };
            ListTier1L2VpnservicesServiceURL.Replace("{tier-1-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(Tier1Id, System.Globalization.CultureInfo.InvariantCulture)));
            ListTier1L2VpnservicesServiceURL.Replace("{locale-service-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(LocaleServiceId, System.Globalization.CultureInfo.InvariantCulture)));
            if (Cursor != null) { request.AddQueryParameter("cursor", Cursor.ToString()); }
            if (IncludeMarkForDeleteObjects != null) { request.AddQueryParameter("include_mark_for_delete_objects", IncludeMarkForDeleteObjects.ToString()); }
            if (IncludedFields != null) { request.AddQueryParameter("included_fields", IncludedFields.ToString()); }
            if (PageSize != null) { request.AddQueryParameter("page_size", PageSize.ToString()); }
            if (SortAscending != null) { request.AddQueryParameter("sort_ascending", SortAscending.ToString()); }
            if (SortBy != null) { request.AddQueryParameter("sort_by", SortBy.ToString()); }
            request.Resource = ListTier1L2VpnservicesServiceURL.ToString();
            RestResponse<NSXTL2VPNServiceListResultType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTL2VPNServiceListResultType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Get operation to " + ListTier1L2VpnservicesServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTL2VPNSessionListResultType> ListL2Vpnsessions(string Tier0Id, string LocaleServiceId, string ServiceId, string? Cursor = null, bool? IncludeMarkForDeleteObjects = null, string? IncludedFields = null, long? PageSize = null, bool? SortAscending = null, string? SortBy = null)
        {
            if (Tier0Id == null) { throw new System.ArgumentNullException("Tier0Id cannot be null"); }
            if (LocaleServiceId == null) { throw new System.ArgumentNullException("LocaleServiceId cannot be null"); }
            if (ServiceId == null) { throw new System.ArgumentNullException("ServiceId cannot be null"); }
            StringBuilder ListL2VpnsessionsServiceURL = new StringBuilder("/infra/tier-0s/{tier-0-id}/locale-services/{locale-service-id}/l2vpn-services/{service-id}/sessions");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Get
            };
            ListL2VpnsessionsServiceURL.Replace("{tier-0-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(Tier0Id, System.Globalization.CultureInfo.InvariantCulture)));
            ListL2VpnsessionsServiceURL.Replace("{locale-service-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(LocaleServiceId, System.Globalization.CultureInfo.InvariantCulture)));
            ListL2VpnsessionsServiceURL.Replace("{service-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(ServiceId, System.Globalization.CultureInfo.InvariantCulture)));
            if (Cursor != null) { request.AddQueryParameter("cursor", Cursor.ToString()); }
            if (IncludeMarkForDeleteObjects != null) { request.AddQueryParameter("include_mark_for_delete_objects", IncludeMarkForDeleteObjects.ToString()); }
            if (IncludedFields != null) { request.AddQueryParameter("included_fields", IncludedFields.ToString()); }
            if (PageSize != null) { request.AddQueryParameter("page_size", PageSize.ToString()); }
            if (SortAscending != null) { request.AddQueryParameter("sort_ascending", SortAscending.ToString()); }
            if (SortBy != null) { request.AddQueryParameter("sort_by", SortBy.ToString()); }
            request.Resource = ListL2VpnsessionsServiceURL.ToString();
            RestResponse<NSXTL2VPNSessionListResultType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTL2VPNSessionListResultType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Get operation to " + ListL2VpnsessionsServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTL2VPNServiceListResultType> ListL2Vpnservices(string Tier0Id, string LocaleServiceId, string? Cursor = null, bool? IncludeMarkForDeleteObjects = null, string? IncludedFields = null, long? PageSize = null, bool? SortAscending = null, string? SortBy = null)
        {
            if (Tier0Id == null) { throw new System.ArgumentNullException("Tier0Id cannot be null"); }
            if (LocaleServiceId == null) { throw new System.ArgumentNullException("LocaleServiceId cannot be null"); }
            StringBuilder ListL2VpnservicesServiceURL = new StringBuilder("/infra/tier-0s/{tier-0-id}/locale-services/{locale-service-id}/l2vpn-services");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Get
            };
            ListL2VpnservicesServiceURL.Replace("{tier-0-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(Tier0Id, System.Globalization.CultureInfo.InvariantCulture)));
            ListL2VpnservicesServiceURL.Replace("{locale-service-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(LocaleServiceId, System.Globalization.CultureInfo.InvariantCulture)));
            if (Cursor != null) { request.AddQueryParameter("cursor", Cursor.ToString()); }
            if (IncludeMarkForDeleteObjects != null) { request.AddQueryParameter("include_mark_for_delete_objects", IncludeMarkForDeleteObjects.ToString()); }
            if (IncludedFields != null) { request.AddQueryParameter("included_fields", IncludedFields.ToString()); }
            if (PageSize != null) { request.AddQueryParameter("page_size", PageSize.ToString()); }
            if (SortAscending != null) { request.AddQueryParameter("sort_ascending", SortAscending.ToString()); }
            if (SortBy != null) { request.AddQueryParameter("sort_by", SortBy.ToString()); }
            request.Resource = ListL2VpnservicesServiceURL.ToString();
            RestResponse<NSXTL2VPNServiceListResultType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTL2VPNServiceListResultType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Get operation to " + ListL2VpnservicesServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task CreateOrPatchL2VpnsessionFromPeerCodes(string Tier0Id, string LocaleServiceId, string ServiceId, string SessionId, NSXTL2VPNSessionDataType L2VpnsessionData)
        {
            if (Tier0Id == null) { throw new System.ArgumentNullException("Tier0Id cannot be null"); }
            if (LocaleServiceId == null) { throw new System.ArgumentNullException("LocaleServiceId cannot be null"); }
            if (ServiceId == null) { throw new System.ArgumentNullException("ServiceId cannot be null"); }
            if (SessionId == null) { throw new System.ArgumentNullException("SessionId cannot be null"); }
            if (L2VpnsessionData == null) { throw new System.ArgumentNullException("L2VpnsessionData cannot be null"); }
            StringBuilder CreateOrPatchL2VpnsessionFromPeerCodesServiceURL = new StringBuilder("/infra/tier-0s/{tier-0-id}/locale-services/{locale-service-id}/l2vpn-services/{service-id}/sessions/{session-id}?action=create_with_peer_code");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Post
            };
            CreateOrPatchL2VpnsessionFromPeerCodesServiceURL.Replace("{tier-0-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(Tier0Id, System.Globalization.CultureInfo.InvariantCulture)));
            CreateOrPatchL2VpnsessionFromPeerCodesServiceURL.Replace("{locale-service-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(LocaleServiceId, System.Globalization.CultureInfo.InvariantCulture)));
            CreateOrPatchL2VpnsessionFromPeerCodesServiceURL.Replace("{service-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(ServiceId, System.Globalization.CultureInfo.InvariantCulture)));
            CreateOrPatchL2VpnsessionFromPeerCodesServiceURL.Replace("{session-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(SessionId, System.Globalization.CultureInfo.InvariantCulture)));
            request.AddJsonBody(L2VpnsessionData);
            request.Resource = CreateOrPatchL2VpnsessionFromPeerCodesServiceURL.ToString();
            RestResponse response = await restClient.ExecuteTaskAsyncWithPolicy(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Post operation to " + CreateOrPatchL2VpnsessionFromPeerCodesServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTAggregateL2VPNSessionPeerConfigType> GetTier1L2VpnsessionPeerConfig(string Tier1Id, string LocaleServiceId, string ServiceId, string SessionId, string? EnforcementPointPath = null)
        {
            if (Tier1Id == null) { throw new System.ArgumentNullException("Tier1Id cannot be null"); }
            if (LocaleServiceId == null) { throw new System.ArgumentNullException("LocaleServiceId cannot be null"); }
            if (ServiceId == null) { throw new System.ArgumentNullException("ServiceId cannot be null"); }
            if (SessionId == null) { throw new System.ArgumentNullException("SessionId cannot be null"); }
            StringBuilder GetTier1L2VpnsessionPeerConfigServiceURL = new StringBuilder("/infra/tier-1s/{tier-1-id}/locale-services/{locale-service-id}/l2vpn-services/{service-id}/sessions/{session-id}/peer-config");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Get
            };
            GetTier1L2VpnsessionPeerConfigServiceURL.Replace("{tier-1-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(Tier1Id, System.Globalization.CultureInfo.InvariantCulture)));
            GetTier1L2VpnsessionPeerConfigServiceURL.Replace("{locale-service-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(LocaleServiceId, System.Globalization.CultureInfo.InvariantCulture)));
            GetTier1L2VpnsessionPeerConfigServiceURL.Replace("{service-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(ServiceId, System.Globalization.CultureInfo.InvariantCulture)));
            GetTier1L2VpnsessionPeerConfigServiceURL.Replace("{session-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(SessionId, System.Globalization.CultureInfo.InvariantCulture)));
            if (EnforcementPointPath != null) { request.AddQueryParameter("enforcement_point_path", EnforcementPointPath.ToString()); }
            request.Resource = GetTier1L2VpnsessionPeerConfigServiceURL.ToString();
            RestResponse<NSXTAggregateL2VPNSessionPeerConfigType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTAggregateL2VPNSessionPeerConfigType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Get operation to " + GetTier1L2VpnsessionPeerConfigServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTL2VPNServiceType> CreateOrUpdateL2Vpnservice(string Tier0Id, string LocaleServiceId, string ServiceId, NSXTL2VPNServiceType L2Vpnservice)
        {
            if (Tier0Id == null) { throw new System.ArgumentNullException("Tier0Id cannot be null"); }
            if (LocaleServiceId == null) { throw new System.ArgumentNullException("LocaleServiceId cannot be null"); }
            if (ServiceId == null) { throw new System.ArgumentNullException("ServiceId cannot be null"); }
            if (L2Vpnservice == null) { throw new System.ArgumentNullException("L2Vpnservice cannot be null"); }
            StringBuilder CreateOrUpdateL2VpnserviceServiceURL = new StringBuilder("/infra/tier-0s/{tier-0-id}/locale-services/{locale-service-id}/l2vpn-services/{service-id}");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Put
            };
            CreateOrUpdateL2VpnserviceServiceURL.Replace("{tier-0-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(Tier0Id, System.Globalization.CultureInfo.InvariantCulture)));
            CreateOrUpdateL2VpnserviceServiceURL.Replace("{locale-service-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(LocaleServiceId, System.Globalization.CultureInfo.InvariantCulture)));
            CreateOrUpdateL2VpnserviceServiceURL.Replace("{service-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(ServiceId, System.Globalization.CultureInfo.InvariantCulture)));
            request.AddJsonBody(L2Vpnservice);
            request.Resource = CreateOrUpdateL2VpnserviceServiceURL.ToString();
            RestResponse<NSXTL2VPNServiceType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTL2VPNServiceType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Put operation to " + CreateOrUpdateL2VpnserviceServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task CreateOrPatchL2Vpnservice(string Tier0Id, string LocaleServiceId, string ServiceId, NSXTL2VPNServiceType L2Vpnservice)
        {
            if (Tier0Id == null) { throw new System.ArgumentNullException("Tier0Id cannot be null"); }
            if (LocaleServiceId == null) { throw new System.ArgumentNullException("LocaleServiceId cannot be null"); }
            if (ServiceId == null) { throw new System.ArgumentNullException("ServiceId cannot be null"); }
            if (L2Vpnservice == null) { throw new System.ArgumentNullException("L2Vpnservice cannot be null"); }
            StringBuilder CreateOrPatchL2VpnserviceServiceURL = new StringBuilder("/infra/tier-0s/{tier-0-id}/locale-services/{locale-service-id}/l2vpn-services/{service-id}");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Patch
            };
            CreateOrPatchL2VpnserviceServiceURL.Replace("{tier-0-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(Tier0Id, System.Globalization.CultureInfo.InvariantCulture)));
            CreateOrPatchL2VpnserviceServiceURL.Replace("{locale-service-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(LocaleServiceId, System.Globalization.CultureInfo.InvariantCulture)));
            CreateOrPatchL2VpnserviceServiceURL.Replace("{service-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(ServiceId, System.Globalization.CultureInfo.InvariantCulture)));
            request.AddJsonBody(L2Vpnservice);
            request.Resource = CreateOrPatchL2VpnserviceServiceURL.ToString();
            RestResponse response = await restClient.ExecuteTaskAsyncWithPolicy(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Patch operation to " + CreateOrPatchL2VpnserviceServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTL2VPNServiceType> GetL2Vpnservice(string Tier0Id, string LocaleServiceId, string ServiceId)
        {
            if (Tier0Id == null) { throw new System.ArgumentNullException("Tier0Id cannot be null"); }
            if (LocaleServiceId == null) { throw new System.ArgumentNullException("LocaleServiceId cannot be null"); }
            if (ServiceId == null) { throw new System.ArgumentNullException("ServiceId cannot be null"); }
            StringBuilder GetL2VpnserviceServiceURL = new StringBuilder("/infra/tier-0s/{tier-0-id}/locale-services/{locale-service-id}/l2vpn-services/{service-id}");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Get
            };
            GetL2VpnserviceServiceURL.Replace("{tier-0-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(Tier0Id, System.Globalization.CultureInfo.InvariantCulture)));
            GetL2VpnserviceServiceURL.Replace("{locale-service-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(LocaleServiceId, System.Globalization.CultureInfo.InvariantCulture)));
            GetL2VpnserviceServiceURL.Replace("{service-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(ServiceId, System.Globalization.CultureInfo.InvariantCulture)));
            request.Resource = GetL2VpnserviceServiceURL.ToString();
            RestResponse<NSXTL2VPNServiceType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTL2VPNServiceType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Get operation to " + GetL2VpnserviceServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task DeleteL2Vpnservice(string Tier0Id, string LocaleServiceId, string ServiceId)
        {
            if (Tier0Id == null) { throw new System.ArgumentNullException("Tier0Id cannot be null"); }
            if (LocaleServiceId == null) { throw new System.ArgumentNullException("LocaleServiceId cannot be null"); }
            if (ServiceId == null) { throw new System.ArgumentNullException("ServiceId cannot be null"); }
            StringBuilder DeleteL2VpnserviceServiceURL = new StringBuilder("/infra/tier-0s/{tier-0-id}/locale-services/{locale-service-id}/l2vpn-services/{service-id}");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Delete
            };
            DeleteL2VpnserviceServiceURL.Replace("{tier-0-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(Tier0Id, System.Globalization.CultureInfo.InvariantCulture)));
            DeleteL2VpnserviceServiceURL.Replace("{locale-service-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(LocaleServiceId, System.Globalization.CultureInfo.InvariantCulture)));
            DeleteL2VpnserviceServiceURL.Replace("{service-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(ServiceId, System.Globalization.CultureInfo.InvariantCulture)));
            request.Resource = DeleteL2VpnserviceServiceURL.ToString();
            RestResponse response = await restClient.ExecuteTaskAsyncWithPolicy(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Delete operation to " + DeleteL2VpnserviceServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTL2VPNSessionListResultType> ListTier1L2Vpnsessions(string Tier1Id, string LocaleServiceId, string ServiceId, string? Cursor = null, bool? IncludeMarkForDeleteObjects = null, string? IncludedFields = null, long? PageSize = null, bool? SortAscending = null, string? SortBy = null)
        {
            if (Tier1Id == null) { throw new System.ArgumentNullException("Tier1Id cannot be null"); }
            if (LocaleServiceId == null) { throw new System.ArgumentNullException("LocaleServiceId cannot be null"); }
            if (ServiceId == null) { throw new System.ArgumentNullException("ServiceId cannot be null"); }
            StringBuilder ListTier1L2VpnsessionsServiceURL = new StringBuilder("/infra/tier-1s/{tier-1-id}/locale-services/{locale-service-id}/l2vpn-services/{service-id}/sessions");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Get
            };
            ListTier1L2VpnsessionsServiceURL.Replace("{tier-1-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(Tier1Id, System.Globalization.CultureInfo.InvariantCulture)));
            ListTier1L2VpnsessionsServiceURL.Replace("{locale-service-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(LocaleServiceId, System.Globalization.CultureInfo.InvariantCulture)));
            ListTier1L2VpnsessionsServiceURL.Replace("{service-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(ServiceId, System.Globalization.CultureInfo.InvariantCulture)));
            if (Cursor != null) { request.AddQueryParameter("cursor", Cursor.ToString()); }
            if (IncludeMarkForDeleteObjects != null) { request.AddQueryParameter("include_mark_for_delete_objects", IncludeMarkForDeleteObjects.ToString()); }
            if (IncludedFields != null) { request.AddQueryParameter("included_fields", IncludedFields.ToString()); }
            if (PageSize != null) { request.AddQueryParameter("page_size", PageSize.ToString()); }
            if (SortAscending != null) { request.AddQueryParameter("sort_ascending", SortAscending.ToString()); }
            if (SortBy != null) { request.AddQueryParameter("sort_by", SortBy.ToString()); }
            request.Resource = ListTier1L2VpnsessionsServiceURL.ToString();
            RestResponse<NSXTL2VPNSessionListResultType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTL2VPNSessionListResultType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Get operation to " + ListTier1L2VpnsessionsServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTL2VPNServiceType> CreateOrUpdateTier1L2Vpnservice(string Tier1Id, string LocaleServiceId, string ServiceId, NSXTL2VPNServiceType L2Vpnservice)
        {
            if (Tier1Id == null) { throw new System.ArgumentNullException("Tier1Id cannot be null"); }
            if (LocaleServiceId == null) { throw new System.ArgumentNullException("LocaleServiceId cannot be null"); }
            if (ServiceId == null) { throw new System.ArgumentNullException("ServiceId cannot be null"); }
            if (L2Vpnservice == null) { throw new System.ArgumentNullException("L2Vpnservice cannot be null"); }
            StringBuilder CreateOrUpdateTier1L2VpnserviceServiceURL = new StringBuilder("/infra/tier-1s/{tier-1-id}/locale-services/{locale-service-id}/l2vpn-services/{service-id}");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Put
            };
            CreateOrUpdateTier1L2VpnserviceServiceURL.Replace("{tier-1-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(Tier1Id, System.Globalization.CultureInfo.InvariantCulture)));
            CreateOrUpdateTier1L2VpnserviceServiceURL.Replace("{locale-service-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(LocaleServiceId, System.Globalization.CultureInfo.InvariantCulture)));
            CreateOrUpdateTier1L2VpnserviceServiceURL.Replace("{service-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(ServiceId, System.Globalization.CultureInfo.InvariantCulture)));
            request.AddJsonBody(L2Vpnservice);
            request.Resource = CreateOrUpdateTier1L2VpnserviceServiceURL.ToString();
            RestResponse<NSXTL2VPNServiceType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTL2VPNServiceType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Put operation to " + CreateOrUpdateTier1L2VpnserviceServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task DeleteTier1L2Vpnservice(string Tier1Id, string LocaleServiceId, string ServiceId)
        {
            if (Tier1Id == null) { throw new System.ArgumentNullException("Tier1Id cannot be null"); }
            if (LocaleServiceId == null) { throw new System.ArgumentNullException("LocaleServiceId cannot be null"); }
            if (ServiceId == null) { throw new System.ArgumentNullException("ServiceId cannot be null"); }
            StringBuilder DeleteTier1L2VpnserviceServiceURL = new StringBuilder("/infra/tier-1s/{tier-1-id}/locale-services/{locale-service-id}/l2vpn-services/{service-id}");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Delete
            };
            DeleteTier1L2VpnserviceServiceURL.Replace("{tier-1-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(Tier1Id, System.Globalization.CultureInfo.InvariantCulture)));
            DeleteTier1L2VpnserviceServiceURL.Replace("{locale-service-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(LocaleServiceId, System.Globalization.CultureInfo.InvariantCulture)));
            DeleteTier1L2VpnserviceServiceURL.Replace("{service-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(ServiceId, System.Globalization.CultureInfo.InvariantCulture)));
            request.Resource = DeleteTier1L2VpnserviceServiceURL.ToString();
            RestResponse response = await restClient.ExecuteTaskAsyncWithPolicy(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Delete operation to " + DeleteTier1L2VpnserviceServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task CreateOrPatchTier1L2Vpnservice(string Tier1Id, string LocaleServiceId, string ServiceId, NSXTL2VPNServiceType L2Vpnservice)
        {
            if (Tier1Id == null) { throw new System.ArgumentNullException("Tier1Id cannot be null"); }
            if (LocaleServiceId == null) { throw new System.ArgumentNullException("LocaleServiceId cannot be null"); }
            if (ServiceId == null) { throw new System.ArgumentNullException("ServiceId cannot be null"); }
            if (L2Vpnservice == null) { throw new System.ArgumentNullException("L2Vpnservice cannot be null"); }
            StringBuilder CreateOrPatchTier1L2VpnserviceServiceURL = new StringBuilder("/infra/tier-1s/{tier-1-id}/locale-services/{locale-service-id}/l2vpn-services/{service-id}");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Patch
            };
            CreateOrPatchTier1L2VpnserviceServiceURL.Replace("{tier-1-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(Tier1Id, System.Globalization.CultureInfo.InvariantCulture)));
            CreateOrPatchTier1L2VpnserviceServiceURL.Replace("{locale-service-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(LocaleServiceId, System.Globalization.CultureInfo.InvariantCulture)));
            CreateOrPatchTier1L2VpnserviceServiceURL.Replace("{service-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(ServiceId, System.Globalization.CultureInfo.InvariantCulture)));
            request.AddJsonBody(L2Vpnservice);
            request.Resource = CreateOrPatchTier1L2VpnserviceServiceURL.ToString();
            RestResponse response = await restClient.ExecuteTaskAsyncWithPolicy(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Patch operation to " + CreateOrPatchTier1L2VpnserviceServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTL2VPNServiceType> GetTier1L2Vpnservice(string Tier1Id, string LocaleServiceId, string ServiceId)
        {
            if (Tier1Id == null) { throw new System.ArgumentNullException("Tier1Id cannot be null"); }
            if (LocaleServiceId == null) { throw new System.ArgumentNullException("LocaleServiceId cannot be null"); }
            if (ServiceId == null) { throw new System.ArgumentNullException("ServiceId cannot be null"); }
            StringBuilder GetTier1L2VpnserviceServiceURL = new StringBuilder("/infra/tier-1s/{tier-1-id}/locale-services/{locale-service-id}/l2vpn-services/{service-id}");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Get
            };
            GetTier1L2VpnserviceServiceURL.Replace("{tier-1-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(Tier1Id, System.Globalization.CultureInfo.InvariantCulture)));
            GetTier1L2VpnserviceServiceURL.Replace("{locale-service-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(LocaleServiceId, System.Globalization.CultureInfo.InvariantCulture)));
            GetTier1L2VpnserviceServiceURL.Replace("{service-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(ServiceId, System.Globalization.CultureInfo.InvariantCulture)));
            request.Resource = GetTier1L2VpnserviceServiceURL.ToString();
            RestResponse<NSXTL2VPNServiceType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTL2VPNServiceType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Get operation to " + GetTier1L2VpnserviceServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTL2VPNSessionType> CreateOrUpdateTier1L2Vpnsession(string Tier1Id, string LocaleServiceId, string ServiceId, string SessionId, NSXTL2VPNSessionType L2Vpnsession)
        {
            if (Tier1Id == null) { throw new System.ArgumentNullException("Tier1Id cannot be null"); }
            if (LocaleServiceId == null) { throw new System.ArgumentNullException("LocaleServiceId cannot be null"); }
            if (ServiceId == null) { throw new System.ArgumentNullException("ServiceId cannot be null"); }
            if (SessionId == null) { throw new System.ArgumentNullException("SessionId cannot be null"); }
            if (L2Vpnsession == null) { throw new System.ArgumentNullException("L2Vpnsession cannot be null"); }
            StringBuilder CreateOrUpdateTier1L2VpnsessionServiceURL = new StringBuilder("/infra/tier-1s/{tier-1-id}/locale-services/{locale-service-id}/l2vpn-services/{service-id}/sessions/{session-id}");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Put
            };
            CreateOrUpdateTier1L2VpnsessionServiceURL.Replace("{tier-1-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(Tier1Id, System.Globalization.CultureInfo.InvariantCulture)));
            CreateOrUpdateTier1L2VpnsessionServiceURL.Replace("{locale-service-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(LocaleServiceId, System.Globalization.CultureInfo.InvariantCulture)));
            CreateOrUpdateTier1L2VpnsessionServiceURL.Replace("{service-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(ServiceId, System.Globalization.CultureInfo.InvariantCulture)));
            CreateOrUpdateTier1L2VpnsessionServiceURL.Replace("{session-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(SessionId, System.Globalization.CultureInfo.InvariantCulture)));
            request.AddJsonBody(L2Vpnsession);
            request.Resource = CreateOrUpdateTier1L2VpnsessionServiceURL.ToString();
            RestResponse<NSXTL2VPNSessionType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTL2VPNSessionType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Put operation to " + CreateOrUpdateTier1L2VpnsessionServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTL2VPNSessionType> GetTier1L2Vpnsession(string Tier1Id, string LocaleServiceId, string ServiceId, string SessionId)
        {
            if (Tier1Id == null) { throw new System.ArgumentNullException("Tier1Id cannot be null"); }
            if (LocaleServiceId == null) { throw new System.ArgumentNullException("LocaleServiceId cannot be null"); }
            if (ServiceId == null) { throw new System.ArgumentNullException("ServiceId cannot be null"); }
            if (SessionId == null) { throw new System.ArgumentNullException("SessionId cannot be null"); }
            StringBuilder GetTier1L2VpnsessionServiceURL = new StringBuilder("/infra/tier-1s/{tier-1-id}/locale-services/{locale-service-id}/l2vpn-services/{service-id}/sessions/{session-id}");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Get
            };
            GetTier1L2VpnsessionServiceURL.Replace("{tier-1-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(Tier1Id, System.Globalization.CultureInfo.InvariantCulture)));
            GetTier1L2VpnsessionServiceURL.Replace("{locale-service-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(LocaleServiceId, System.Globalization.CultureInfo.InvariantCulture)));
            GetTier1L2VpnsessionServiceURL.Replace("{service-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(ServiceId, System.Globalization.CultureInfo.InvariantCulture)));
            GetTier1L2VpnsessionServiceURL.Replace("{session-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(SessionId, System.Globalization.CultureInfo.InvariantCulture)));
            request.Resource = GetTier1L2VpnsessionServiceURL.ToString();
            RestResponse<NSXTL2VPNSessionType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTL2VPNSessionType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Get operation to " + GetTier1L2VpnsessionServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task DeleteTier1L2Vpnsession(string Tier1Id, string LocaleServiceId, string ServiceId, string SessionId)
        {
            if (Tier1Id == null) { throw new System.ArgumentNullException("Tier1Id cannot be null"); }
            if (LocaleServiceId == null) { throw new System.ArgumentNullException("LocaleServiceId cannot be null"); }
            if (ServiceId == null) { throw new System.ArgumentNullException("ServiceId cannot be null"); }
            if (SessionId == null) { throw new System.ArgumentNullException("SessionId cannot be null"); }
            StringBuilder DeleteTier1L2VpnsessionServiceURL = new StringBuilder("/infra/tier-1s/{tier-1-id}/locale-services/{locale-service-id}/l2vpn-services/{service-id}/sessions/{session-id}");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Delete
            };
            DeleteTier1L2VpnsessionServiceURL.Replace("{tier-1-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(Tier1Id, System.Globalization.CultureInfo.InvariantCulture)));
            DeleteTier1L2VpnsessionServiceURL.Replace("{locale-service-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(LocaleServiceId, System.Globalization.CultureInfo.InvariantCulture)));
            DeleteTier1L2VpnsessionServiceURL.Replace("{service-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(ServiceId, System.Globalization.CultureInfo.InvariantCulture)));
            DeleteTier1L2VpnsessionServiceURL.Replace("{session-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(SessionId, System.Globalization.CultureInfo.InvariantCulture)));
            request.Resource = DeleteTier1L2VpnsessionServiceURL.ToString();
            RestResponse response = await restClient.ExecuteTaskAsyncWithPolicy(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Delete operation to " + DeleteTier1L2VpnsessionServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task CreateOrPatchTier1L2Vpnsession(string Tier1Id, string LocaleServiceId, string ServiceId, string SessionId, NSXTL2VPNSessionType L2Vpnsession)
        {
            if (Tier1Id == null) { throw new System.ArgumentNullException("Tier1Id cannot be null"); }
            if (LocaleServiceId == null) { throw new System.ArgumentNullException("LocaleServiceId cannot be null"); }
            if (ServiceId == null) { throw new System.ArgumentNullException("ServiceId cannot be null"); }
            if (SessionId == null) { throw new System.ArgumentNullException("SessionId cannot be null"); }
            if (L2Vpnsession == null) { throw new System.ArgumentNullException("L2Vpnsession cannot be null"); }
            StringBuilder CreateOrPatchTier1L2VpnsessionServiceURL = new StringBuilder("/infra/tier-1s/{tier-1-id}/locale-services/{locale-service-id}/l2vpn-services/{service-id}/sessions/{session-id}");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Patch
            };
            CreateOrPatchTier1L2VpnsessionServiceURL.Replace("{tier-1-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(Tier1Id, System.Globalization.CultureInfo.InvariantCulture)));
            CreateOrPatchTier1L2VpnsessionServiceURL.Replace("{locale-service-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(LocaleServiceId, System.Globalization.CultureInfo.InvariantCulture)));
            CreateOrPatchTier1L2VpnsessionServiceURL.Replace("{service-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(ServiceId, System.Globalization.CultureInfo.InvariantCulture)));
            CreateOrPatchTier1L2VpnsessionServiceURL.Replace("{session-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(SessionId, System.Globalization.CultureInfo.InvariantCulture)));
            request.AddJsonBody(L2Vpnsession);
            request.Resource = CreateOrPatchTier1L2VpnsessionServiceURL.ToString();
            RestResponse response = await restClient.ExecuteTaskAsyncWithPolicy(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Patch operation to " + CreateOrPatchTier1L2VpnsessionServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTAggregateL2VPNSessionPeerConfigType> GetL2VpnsessionPeerConfig(string Tier0Id, string LocaleServiceId, string ServiceId, string SessionId, string? EnforcementPointPath = null)
        {
            if (Tier0Id == null) { throw new System.ArgumentNullException("Tier0Id cannot be null"); }
            if (LocaleServiceId == null) { throw new System.ArgumentNullException("LocaleServiceId cannot be null"); }
            if (ServiceId == null) { throw new System.ArgumentNullException("ServiceId cannot be null"); }
            if (SessionId == null) { throw new System.ArgumentNullException("SessionId cannot be null"); }
            StringBuilder GetL2VpnsessionPeerConfigServiceURL = new StringBuilder("/infra/tier-0s/{tier-0-id}/locale-services/{locale-service-id}/l2vpn-services/{service-id}/sessions/{session-id}/peer-config");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Get
            };
            GetL2VpnsessionPeerConfigServiceURL.Replace("{tier-0-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(Tier0Id, System.Globalization.CultureInfo.InvariantCulture)));
            GetL2VpnsessionPeerConfigServiceURL.Replace("{locale-service-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(LocaleServiceId, System.Globalization.CultureInfo.InvariantCulture)));
            GetL2VpnsessionPeerConfigServiceURL.Replace("{service-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(ServiceId, System.Globalization.CultureInfo.InvariantCulture)));
            GetL2VpnsessionPeerConfigServiceURL.Replace("{session-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(SessionId, System.Globalization.CultureInfo.InvariantCulture)));
            if (EnforcementPointPath != null) { request.AddQueryParameter("enforcement_point_path", EnforcementPointPath.ToString()); }
            request.Resource = GetL2VpnsessionPeerConfigServiceURL.ToString();
            RestResponse<NSXTAggregateL2VPNSessionPeerConfigType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTAggregateL2VPNSessionPeerConfigType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Get operation to " + GetL2VpnsessionPeerConfigServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task CreateOrPatchTier1L2VpnsessionFromPeerCodes(string Tier1Id, string LocaleServiceId, string ServiceId, string SessionId, NSXTL2VPNSessionDataType L2VpnsessionData)
        {
            if (Tier1Id == null) { throw new System.ArgumentNullException("Tier1Id cannot be null"); }
            if (LocaleServiceId == null) { throw new System.ArgumentNullException("LocaleServiceId cannot be null"); }
            if (ServiceId == null) { throw new System.ArgumentNullException("ServiceId cannot be null"); }
            if (SessionId == null) { throw new System.ArgumentNullException("SessionId cannot be null"); }
            if (L2VpnsessionData == null) { throw new System.ArgumentNullException("L2VpnsessionData cannot be null"); }
            StringBuilder CreateOrPatchTier1L2VpnsessionFromPeerCodesServiceURL = new StringBuilder("/infra/tier-1s/{tier-1-id}/locale-services/{locale-service-id}/l2vpn-services/{service-id}/sessions/{session-id}?action=create_with_peer_code");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Post
            };
            CreateOrPatchTier1L2VpnsessionFromPeerCodesServiceURL.Replace("{tier-1-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(Tier1Id, System.Globalization.CultureInfo.InvariantCulture)));
            CreateOrPatchTier1L2VpnsessionFromPeerCodesServiceURL.Replace("{locale-service-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(LocaleServiceId, System.Globalization.CultureInfo.InvariantCulture)));
            CreateOrPatchTier1L2VpnsessionFromPeerCodesServiceURL.Replace("{service-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(ServiceId, System.Globalization.CultureInfo.InvariantCulture)));
            CreateOrPatchTier1L2VpnsessionFromPeerCodesServiceURL.Replace("{session-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(SessionId, System.Globalization.CultureInfo.InvariantCulture)));
            request.AddJsonBody(L2VpnsessionData);
            request.Resource = CreateOrPatchTier1L2VpnsessionFromPeerCodesServiceURL.ToString();
            RestResponse response = await restClient.ExecuteTaskAsyncWithPolicy(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Post operation to " + CreateOrPatchTier1L2VpnsessionFromPeerCodesServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTL2VPNSessionType> CreateOrUpdateL2Vpnsession(string Tier0Id, string LocaleServiceId, string ServiceId, string SessionId, NSXTL2VPNSessionType L2Vpnsession)
        {
            if (Tier0Id == null) { throw new System.ArgumentNullException("Tier0Id cannot be null"); }
            if (LocaleServiceId == null) { throw new System.ArgumentNullException("LocaleServiceId cannot be null"); }
            if (ServiceId == null) { throw new System.ArgumentNullException("ServiceId cannot be null"); }
            if (SessionId == null) { throw new System.ArgumentNullException("SessionId cannot be null"); }
            if (L2Vpnsession == null) { throw new System.ArgumentNullException("L2Vpnsession cannot be null"); }
            StringBuilder CreateOrUpdateL2VpnsessionServiceURL = new StringBuilder("/infra/tier-0s/{tier-0-id}/locale-services/{locale-service-id}/l2vpn-services/{service-id}/sessions/{session-id}");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Put
            };
            CreateOrUpdateL2VpnsessionServiceURL.Replace("{tier-0-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(Tier0Id, System.Globalization.CultureInfo.InvariantCulture)));
            CreateOrUpdateL2VpnsessionServiceURL.Replace("{locale-service-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(LocaleServiceId, System.Globalization.CultureInfo.InvariantCulture)));
            CreateOrUpdateL2VpnsessionServiceURL.Replace("{service-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(ServiceId, System.Globalization.CultureInfo.InvariantCulture)));
            CreateOrUpdateL2VpnsessionServiceURL.Replace("{session-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(SessionId, System.Globalization.CultureInfo.InvariantCulture)));
            request.AddJsonBody(L2Vpnsession);
            request.Resource = CreateOrUpdateL2VpnsessionServiceURL.ToString();
            RestResponse<NSXTL2VPNSessionType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTL2VPNSessionType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Put operation to " + CreateOrUpdateL2VpnsessionServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task CreateOrPatchL2Vpnsession(string Tier0Id, string LocaleServiceId, string ServiceId, string SessionId, NSXTL2VPNSessionType L2Vpnsession)
        {
            if (Tier0Id == null) { throw new System.ArgumentNullException("Tier0Id cannot be null"); }
            if (LocaleServiceId == null) { throw new System.ArgumentNullException("LocaleServiceId cannot be null"); }
            if (ServiceId == null) { throw new System.ArgumentNullException("ServiceId cannot be null"); }
            if (SessionId == null) { throw new System.ArgumentNullException("SessionId cannot be null"); }
            if (L2Vpnsession == null) { throw new System.ArgumentNullException("L2Vpnsession cannot be null"); }
            StringBuilder CreateOrPatchL2VpnsessionServiceURL = new StringBuilder("/infra/tier-0s/{tier-0-id}/locale-services/{locale-service-id}/l2vpn-services/{service-id}/sessions/{session-id}");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Patch
            };
            CreateOrPatchL2VpnsessionServiceURL.Replace("{tier-0-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(Tier0Id, System.Globalization.CultureInfo.InvariantCulture)));
            CreateOrPatchL2VpnsessionServiceURL.Replace("{locale-service-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(LocaleServiceId, System.Globalization.CultureInfo.InvariantCulture)));
            CreateOrPatchL2VpnsessionServiceURL.Replace("{service-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(ServiceId, System.Globalization.CultureInfo.InvariantCulture)));
            CreateOrPatchL2VpnsessionServiceURL.Replace("{session-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(SessionId, System.Globalization.CultureInfo.InvariantCulture)));
            request.AddJsonBody(L2Vpnsession);
            request.Resource = CreateOrPatchL2VpnsessionServiceURL.ToString();
            RestResponse response = await restClient.ExecuteTaskAsyncWithPolicy(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Patch operation to " + CreateOrPatchL2VpnsessionServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task DeleteL2Vpnsession(string Tier0Id, string LocaleServiceId, string ServiceId, string SessionId)
        {
            if (Tier0Id == null) { throw new System.ArgumentNullException("Tier0Id cannot be null"); }
            if (LocaleServiceId == null) { throw new System.ArgumentNullException("LocaleServiceId cannot be null"); }
            if (ServiceId == null) { throw new System.ArgumentNullException("ServiceId cannot be null"); }
            if (SessionId == null) { throw new System.ArgumentNullException("SessionId cannot be null"); }
            StringBuilder DeleteL2VpnsessionServiceURL = new StringBuilder("/infra/tier-0s/{tier-0-id}/locale-services/{locale-service-id}/l2vpn-services/{service-id}/sessions/{session-id}");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Delete
            };
            DeleteL2VpnsessionServiceURL.Replace("{tier-0-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(Tier0Id, System.Globalization.CultureInfo.InvariantCulture)));
            DeleteL2VpnsessionServiceURL.Replace("{locale-service-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(LocaleServiceId, System.Globalization.CultureInfo.InvariantCulture)));
            DeleteL2VpnsessionServiceURL.Replace("{service-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(ServiceId, System.Globalization.CultureInfo.InvariantCulture)));
            DeleteL2VpnsessionServiceURL.Replace("{session-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(SessionId, System.Globalization.CultureInfo.InvariantCulture)));
            request.Resource = DeleteL2VpnsessionServiceURL.ToString();
            RestResponse response = await restClient.ExecuteTaskAsyncWithPolicy(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Delete operation to " + DeleteL2VpnsessionServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTL2VPNSessionType> GetL2Vpnsession(string Tier0Id, string LocaleServiceId, string ServiceId, string SessionId)
        {
            if (Tier0Id == null) { throw new System.ArgumentNullException("Tier0Id cannot be null"); }
            if (LocaleServiceId == null) { throw new System.ArgumentNullException("LocaleServiceId cannot be null"); }
            if (ServiceId == null) { throw new System.ArgumentNullException("ServiceId cannot be null"); }
            if (SessionId == null) { throw new System.ArgumentNullException("SessionId cannot be null"); }
            StringBuilder GetL2VpnsessionServiceURL = new StringBuilder("/infra/tier-0s/{tier-0-id}/locale-services/{locale-service-id}/l2vpn-services/{service-id}/sessions/{session-id}");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Get
            };
            GetL2VpnsessionServiceURL.Replace("{tier-0-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(Tier0Id, System.Globalization.CultureInfo.InvariantCulture)));
            GetL2VpnsessionServiceURL.Replace("{locale-service-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(LocaleServiceId, System.Globalization.CultureInfo.InvariantCulture)));
            GetL2VpnsessionServiceURL.Replace("{service-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(ServiceId, System.Globalization.CultureInfo.InvariantCulture)));
            GetL2VpnsessionServiceURL.Replace("{session-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(SessionId, System.Globalization.CultureInfo.InvariantCulture)));
            request.Resource = GetL2VpnsessionServiceURL.ToString();
            RestResponse<NSXTL2VPNSessionType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTL2VPNSessionType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Get operation to " + GetL2VpnsessionServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
    }
}
