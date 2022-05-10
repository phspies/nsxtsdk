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
    public class PolicyIPSecVpn
    {
        private RestClient restClient;
        private int retry;
        private int timeout;
        private CancellationToken cancellationToken;

        public PolicyIPSecVpn(RestClient Client, CancellationToken _cancellationToken, int _timeout, int _retry)
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
        public async Task<NSXTIPSecVpnLocalEndpointType> CreateOrUpdateTier1IpsecVpnLocalEndpoint(string Tier1Id, string LocaleServiceId, string ServiceId, string LocalEndpointId, NSXTIPSecVpnLocalEndpointType IpsecVpnLocalEndpoint)
        {
            if (Tier1Id == null) { throw new System.ArgumentNullException("Tier1Id cannot be null"); }
            if (LocaleServiceId == null) { throw new System.ArgumentNullException("LocaleServiceId cannot be null"); }
            if (ServiceId == null) { throw new System.ArgumentNullException("ServiceId cannot be null"); }
            if (LocalEndpointId == null) { throw new System.ArgumentNullException("LocalEndpointId cannot be null"); }
            if (IpsecVpnLocalEndpoint == null) { throw new System.ArgumentNullException("IpsecVpnLocalEndpoint cannot be null"); }
            StringBuilder CreateOrUpdateTier1IpsecVpnLocalEndpointServiceURL = new StringBuilder("/infra/tier-1s/{tier-1-id}/locale-services/{locale-service-id}/ipsec-vpn-services/{service-id}/local-endpoints/{local-endpoint-id}");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Put
            };
            CreateOrUpdateTier1IpsecVpnLocalEndpointServiceURL.Replace("{tier-1-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(Tier1Id, System.Globalization.CultureInfo.InvariantCulture)));
            CreateOrUpdateTier1IpsecVpnLocalEndpointServiceURL.Replace("{locale-service-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(LocaleServiceId, System.Globalization.CultureInfo.InvariantCulture)));
            CreateOrUpdateTier1IpsecVpnLocalEndpointServiceURL.Replace("{service-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(ServiceId, System.Globalization.CultureInfo.InvariantCulture)));
            CreateOrUpdateTier1IpsecVpnLocalEndpointServiceURL.Replace("{local-endpoint-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(LocalEndpointId, System.Globalization.CultureInfo.InvariantCulture)));
            request.AddJsonBody(IpsecVpnLocalEndpoint);
            request.Resource = CreateOrUpdateTier1IpsecVpnLocalEndpointServiceURL.ToString();
            RestResponse<NSXTIPSecVpnLocalEndpointType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTIPSecVpnLocalEndpointType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Put operation to " + CreateOrUpdateTier1IpsecVpnLocalEndpointServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task DeleteTier1IpsecVpnLocalEndpoint(string Tier1Id, string LocaleServiceId, string ServiceId, string LocalEndpointId)
        {
            if (Tier1Id == null) { throw new System.ArgumentNullException("Tier1Id cannot be null"); }
            if (LocaleServiceId == null) { throw new System.ArgumentNullException("LocaleServiceId cannot be null"); }
            if (ServiceId == null) { throw new System.ArgumentNullException("ServiceId cannot be null"); }
            if (LocalEndpointId == null) { throw new System.ArgumentNullException("LocalEndpointId cannot be null"); }
            StringBuilder DeleteTier1IpsecVpnLocalEndpointServiceURL = new StringBuilder("/infra/tier-1s/{tier-1-id}/locale-services/{locale-service-id}/ipsec-vpn-services/{service-id}/local-endpoints/{local-endpoint-id}");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Delete
            };
            DeleteTier1IpsecVpnLocalEndpointServiceURL.Replace("{tier-1-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(Tier1Id, System.Globalization.CultureInfo.InvariantCulture)));
            DeleteTier1IpsecVpnLocalEndpointServiceURL.Replace("{locale-service-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(LocaleServiceId, System.Globalization.CultureInfo.InvariantCulture)));
            DeleteTier1IpsecVpnLocalEndpointServiceURL.Replace("{service-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(ServiceId, System.Globalization.CultureInfo.InvariantCulture)));
            DeleteTier1IpsecVpnLocalEndpointServiceURL.Replace("{local-endpoint-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(LocalEndpointId, System.Globalization.CultureInfo.InvariantCulture)));
            request.Resource = DeleteTier1IpsecVpnLocalEndpointServiceURL.ToString();
            RestResponse response = await restClient.ExecuteTaskAsyncWithPolicy(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Delete operation to " + DeleteTier1IpsecVpnLocalEndpointServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task CreateOrPatchTier1IpsecVpnLocalEndpoint(string Tier1Id, string LocaleServiceId, string ServiceId, string LocalEndpointId, NSXTIPSecVpnLocalEndpointType IpsecVpnLocalEndpoint)
        {
            if (Tier1Id == null) { throw new System.ArgumentNullException("Tier1Id cannot be null"); }
            if (LocaleServiceId == null) { throw new System.ArgumentNullException("LocaleServiceId cannot be null"); }
            if (ServiceId == null) { throw new System.ArgumentNullException("ServiceId cannot be null"); }
            if (LocalEndpointId == null) { throw new System.ArgumentNullException("LocalEndpointId cannot be null"); }
            if (IpsecVpnLocalEndpoint == null) { throw new System.ArgumentNullException("IpsecVpnLocalEndpoint cannot be null"); }
            StringBuilder CreateOrPatchTier1IpsecVpnLocalEndpointServiceURL = new StringBuilder("/infra/tier-1s/{tier-1-id}/locale-services/{locale-service-id}/ipsec-vpn-services/{service-id}/local-endpoints/{local-endpoint-id}");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Patch
            };
            CreateOrPatchTier1IpsecVpnLocalEndpointServiceURL.Replace("{tier-1-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(Tier1Id, System.Globalization.CultureInfo.InvariantCulture)));
            CreateOrPatchTier1IpsecVpnLocalEndpointServiceURL.Replace("{locale-service-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(LocaleServiceId, System.Globalization.CultureInfo.InvariantCulture)));
            CreateOrPatchTier1IpsecVpnLocalEndpointServiceURL.Replace("{service-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(ServiceId, System.Globalization.CultureInfo.InvariantCulture)));
            CreateOrPatchTier1IpsecVpnLocalEndpointServiceURL.Replace("{local-endpoint-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(LocalEndpointId, System.Globalization.CultureInfo.InvariantCulture)));
            request.AddJsonBody(IpsecVpnLocalEndpoint);
            request.Resource = CreateOrPatchTier1IpsecVpnLocalEndpointServiceURL.ToString();
            RestResponse response = await restClient.ExecuteTaskAsyncWithPolicy(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Patch operation to " + CreateOrPatchTier1IpsecVpnLocalEndpointServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTIPSecVpnLocalEndpointType> GetTier1IpsecVpnLocalEndpoint(string Tier1Id, string LocaleServiceId, string ServiceId, string LocalEndpointId)
        {
            if (Tier1Id == null) { throw new System.ArgumentNullException("Tier1Id cannot be null"); }
            if (LocaleServiceId == null) { throw new System.ArgumentNullException("LocaleServiceId cannot be null"); }
            if (ServiceId == null) { throw new System.ArgumentNullException("ServiceId cannot be null"); }
            if (LocalEndpointId == null) { throw new System.ArgumentNullException("LocalEndpointId cannot be null"); }
            StringBuilder GetTier1IpsecVpnLocalEndpointServiceURL = new StringBuilder("/infra/tier-1s/{tier-1-id}/locale-services/{locale-service-id}/ipsec-vpn-services/{service-id}/local-endpoints/{local-endpoint-id}");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Get
            };
            GetTier1IpsecVpnLocalEndpointServiceURL.Replace("{tier-1-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(Tier1Id, System.Globalization.CultureInfo.InvariantCulture)));
            GetTier1IpsecVpnLocalEndpointServiceURL.Replace("{locale-service-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(LocaleServiceId, System.Globalization.CultureInfo.InvariantCulture)));
            GetTier1IpsecVpnLocalEndpointServiceURL.Replace("{service-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(ServiceId, System.Globalization.CultureInfo.InvariantCulture)));
            GetTier1IpsecVpnLocalEndpointServiceURL.Replace("{local-endpoint-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(LocalEndpointId, System.Globalization.CultureInfo.InvariantCulture)));
            request.Resource = GetTier1IpsecVpnLocalEndpointServiceURL.ToString();
            RestResponse<NSXTIPSecVpnLocalEndpointType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTIPSecVpnLocalEndpointType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Get operation to " + GetTier1IpsecVpnLocalEndpointServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<string> GetTier1IpsecVpnPeerConfig(string Tier1Id, string LocaleServiceId, string ServiceId, string SessionId, string? EnforcementPointPath = null)
        {
            if (Tier1Id == null) { throw new System.ArgumentNullException("Tier1Id cannot be null"); }
            if (LocaleServiceId == null) { throw new System.ArgumentNullException("LocaleServiceId cannot be null"); }
            if (ServiceId == null) { throw new System.ArgumentNullException("ServiceId cannot be null"); }
            if (SessionId == null) { throw new System.ArgumentNullException("SessionId cannot be null"); }
            StringBuilder GetTier1IpsecVpnPeerConfigServiceURL = new StringBuilder("/infra/tier-1s/{tier-1-id}/locale-services/{locale-service-id}/ipsec-vpn-services/{service-id}/sessions/{session-id}/peer-config");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Get
            };
            GetTier1IpsecVpnPeerConfigServiceURL.Replace("{tier-1-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(Tier1Id, System.Globalization.CultureInfo.InvariantCulture)));
            GetTier1IpsecVpnPeerConfigServiceURL.Replace("{locale-service-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(LocaleServiceId, System.Globalization.CultureInfo.InvariantCulture)));
            GetTier1IpsecVpnPeerConfigServiceURL.Replace("{service-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(ServiceId, System.Globalization.CultureInfo.InvariantCulture)));
            GetTier1IpsecVpnPeerConfigServiceURL.Replace("{session-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(SessionId, System.Globalization.CultureInfo.InvariantCulture)));
            if (EnforcementPointPath != null) { request.AddQueryParameter("enforcement_point_path", EnforcementPointPath.ToString()); }
            request.Resource = GetTier1IpsecVpnPeerConfigServiceURL.ToString();
            RestResponse<string> response = await restClient.ExecuteTaskAsyncWithPolicy<string>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Get operation to " + GetTier1IpsecVpnPeerConfigServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTIPSecVpnServiceType> CreateOrUpdateTier1IpsecVpnService(string Tier1Id, string LocaleServiceId, string ServiceId, NSXTIPSecVpnServiceType IpsecVpnService)
        {
            if (Tier1Id == null) { throw new System.ArgumentNullException("Tier1Id cannot be null"); }
            if (LocaleServiceId == null) { throw new System.ArgumentNullException("LocaleServiceId cannot be null"); }
            if (ServiceId == null) { throw new System.ArgumentNullException("ServiceId cannot be null"); }
            if (IpsecVpnService == null) { throw new System.ArgumentNullException("IpsecVpnService cannot be null"); }
            StringBuilder CreateOrUpdateTier1IpsecVpnServiceServiceURL = new StringBuilder("/infra/tier-1s/{tier-1-id}/locale-services/{locale-service-id}/ipsec-vpn-services/{service-id}");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Put
            };
            CreateOrUpdateTier1IpsecVpnServiceServiceURL.Replace("{tier-1-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(Tier1Id, System.Globalization.CultureInfo.InvariantCulture)));
            CreateOrUpdateTier1IpsecVpnServiceServiceURL.Replace("{locale-service-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(LocaleServiceId, System.Globalization.CultureInfo.InvariantCulture)));
            CreateOrUpdateTier1IpsecVpnServiceServiceURL.Replace("{service-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(ServiceId, System.Globalization.CultureInfo.InvariantCulture)));
            request.AddJsonBody(IpsecVpnService);
            request.Resource = CreateOrUpdateTier1IpsecVpnServiceServiceURL.ToString();
            RestResponse<NSXTIPSecVpnServiceType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTIPSecVpnServiceType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Put operation to " + CreateOrUpdateTier1IpsecVpnServiceServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task CreateOrPatchTier1IpsecVpnService(string Tier1Id, string LocaleServiceId, string ServiceId, NSXTIPSecVpnServiceType IpsecVpnService)
        {
            if (Tier1Id == null) { throw new System.ArgumentNullException("Tier1Id cannot be null"); }
            if (LocaleServiceId == null) { throw new System.ArgumentNullException("LocaleServiceId cannot be null"); }
            if (ServiceId == null) { throw new System.ArgumentNullException("ServiceId cannot be null"); }
            if (IpsecVpnService == null) { throw new System.ArgumentNullException("IpsecVpnService cannot be null"); }
            StringBuilder CreateOrPatchTier1IpsecVpnServiceServiceURL = new StringBuilder("/infra/tier-1s/{tier-1-id}/locale-services/{locale-service-id}/ipsec-vpn-services/{service-id}");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Patch
            };
            CreateOrPatchTier1IpsecVpnServiceServiceURL.Replace("{tier-1-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(Tier1Id, System.Globalization.CultureInfo.InvariantCulture)));
            CreateOrPatchTier1IpsecVpnServiceServiceURL.Replace("{locale-service-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(LocaleServiceId, System.Globalization.CultureInfo.InvariantCulture)));
            CreateOrPatchTier1IpsecVpnServiceServiceURL.Replace("{service-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(ServiceId, System.Globalization.CultureInfo.InvariantCulture)));
            request.AddJsonBody(IpsecVpnService);
            request.Resource = CreateOrPatchTier1IpsecVpnServiceServiceURL.ToString();
            RestResponse response = await restClient.ExecuteTaskAsyncWithPolicy(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Patch operation to " + CreateOrPatchTier1IpsecVpnServiceServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTIPSecVpnServiceType> GetTier1IpsecVpnService(string Tier1Id, string LocaleServiceId, string ServiceId)
        {
            if (Tier1Id == null) { throw new System.ArgumentNullException("Tier1Id cannot be null"); }
            if (LocaleServiceId == null) { throw new System.ArgumentNullException("LocaleServiceId cannot be null"); }
            if (ServiceId == null) { throw new System.ArgumentNullException("ServiceId cannot be null"); }
            StringBuilder GetTier1IpsecVpnServiceServiceURL = new StringBuilder("/infra/tier-1s/{tier-1-id}/locale-services/{locale-service-id}/ipsec-vpn-services/{service-id}");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Get
            };
            GetTier1IpsecVpnServiceServiceURL.Replace("{tier-1-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(Tier1Id, System.Globalization.CultureInfo.InvariantCulture)));
            GetTier1IpsecVpnServiceServiceURL.Replace("{locale-service-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(LocaleServiceId, System.Globalization.CultureInfo.InvariantCulture)));
            GetTier1IpsecVpnServiceServiceURL.Replace("{service-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(ServiceId, System.Globalization.CultureInfo.InvariantCulture)));
            request.Resource = GetTier1IpsecVpnServiceServiceURL.ToString();
            RestResponse<NSXTIPSecVpnServiceType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTIPSecVpnServiceType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Get operation to " + GetTier1IpsecVpnServiceServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task DeleteTier1IpsecVpnService(string Tier1Id, string LocaleServiceId, string ServiceId)
        {
            if (Tier1Id == null) { throw new System.ArgumentNullException("Tier1Id cannot be null"); }
            if (LocaleServiceId == null) { throw new System.ArgumentNullException("LocaleServiceId cannot be null"); }
            if (ServiceId == null) { throw new System.ArgumentNullException("ServiceId cannot be null"); }
            StringBuilder DeleteTier1IpsecVpnServiceServiceURL = new StringBuilder("/infra/tier-1s/{tier-1-id}/locale-services/{locale-service-id}/ipsec-vpn-services/{service-id}");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Delete
            };
            DeleteTier1IpsecVpnServiceServiceURL.Replace("{tier-1-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(Tier1Id, System.Globalization.CultureInfo.InvariantCulture)));
            DeleteTier1IpsecVpnServiceServiceURL.Replace("{locale-service-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(LocaleServiceId, System.Globalization.CultureInfo.InvariantCulture)));
            DeleteTier1IpsecVpnServiceServiceURL.Replace("{service-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(ServiceId, System.Globalization.CultureInfo.InvariantCulture)));
            request.Resource = DeleteTier1IpsecVpnServiceServiceURL.ToString();
            RestResponse response = await restClient.ExecuteTaskAsyncWithPolicy(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Delete operation to " + DeleteTier1IpsecVpnServiceServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTIPSecVpnLocalEndpointListResultType> ListTier0IpsecVpnLocalEndpoints(string Tier0Id, string LocaleServiceId, string ServiceId, string? Cursor = null, bool? IncludeMarkForDeleteObjects = null, string? IncludedFields = null, long? PageSize = null, bool? SortAscending = null, string? SortBy = null)
        {
            if (Tier0Id == null) { throw new System.ArgumentNullException("Tier0Id cannot be null"); }
            if (LocaleServiceId == null) { throw new System.ArgumentNullException("LocaleServiceId cannot be null"); }
            if (ServiceId == null) { throw new System.ArgumentNullException("ServiceId cannot be null"); }
            StringBuilder ListTier0IpsecVpnLocalEndpointsServiceURL = new StringBuilder("/infra/tier-0s/{tier-0-id}/locale-services/{locale-service-id}/ipsec-vpn-services/{service-id}/local-endpoints");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Get
            };
            ListTier0IpsecVpnLocalEndpointsServiceURL.Replace("{tier-0-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(Tier0Id, System.Globalization.CultureInfo.InvariantCulture)));
            ListTier0IpsecVpnLocalEndpointsServiceURL.Replace("{locale-service-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(LocaleServiceId, System.Globalization.CultureInfo.InvariantCulture)));
            ListTier0IpsecVpnLocalEndpointsServiceURL.Replace("{service-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(ServiceId, System.Globalization.CultureInfo.InvariantCulture)));
            if (Cursor != null) { request.AddQueryParameter("cursor", Cursor.ToString()); }
            if (IncludeMarkForDeleteObjects != null) { request.AddQueryParameter("include_mark_for_delete_objects", IncludeMarkForDeleteObjects.ToString()); }
            if (IncludedFields != null) { request.AddQueryParameter("included_fields", IncludedFields.ToString()); }
            if (PageSize != null) { request.AddQueryParameter("page_size", PageSize.ToString()); }
            if (SortAscending != null) { request.AddQueryParameter("sort_ascending", SortAscending.ToString()); }
            if (SortBy != null) { request.AddQueryParameter("sort_by", SortBy.ToString()); }
            request.Resource = ListTier0IpsecVpnLocalEndpointsServiceURL.ToString();
            RestResponse<NSXTIPSecVpnLocalEndpointListResultType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTIPSecVpnLocalEndpointListResultType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Get operation to " + ListTier0IpsecVpnLocalEndpointsServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTIPSecVpnSessionType> CreateOrUpdateTier0IpsecVpnSession(string Tier0Id, string LocaleServiceId, string ServiceId, string SessionId, NSXTIPSecVpnSessionType IpsecVpnSession)
        {
            if (Tier0Id == null) { throw new System.ArgumentNullException("Tier0Id cannot be null"); }
            if (LocaleServiceId == null) { throw new System.ArgumentNullException("LocaleServiceId cannot be null"); }
            if (ServiceId == null) { throw new System.ArgumentNullException("ServiceId cannot be null"); }
            if (SessionId == null) { throw new System.ArgumentNullException("SessionId cannot be null"); }
            if (IpsecVpnSession == null) { throw new System.ArgumentNullException("IpsecVpnSession cannot be null"); }
            StringBuilder CreateOrUpdateTier0IpsecVpnSessionServiceURL = new StringBuilder("/infra/tier-0s/{tier-0-id}/locale-services/{locale-service-id}/ipsec-vpn-services/{service-id}/sessions/{session-id}");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Put
            };
            CreateOrUpdateTier0IpsecVpnSessionServiceURL.Replace("{tier-0-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(Tier0Id, System.Globalization.CultureInfo.InvariantCulture)));
            CreateOrUpdateTier0IpsecVpnSessionServiceURL.Replace("{locale-service-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(LocaleServiceId, System.Globalization.CultureInfo.InvariantCulture)));
            CreateOrUpdateTier0IpsecVpnSessionServiceURL.Replace("{service-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(ServiceId, System.Globalization.CultureInfo.InvariantCulture)));
            CreateOrUpdateTier0IpsecVpnSessionServiceURL.Replace("{session-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(SessionId, System.Globalization.CultureInfo.InvariantCulture)));
            request.AddJsonBody(IpsecVpnSession);
            request.Resource = CreateOrUpdateTier0IpsecVpnSessionServiceURL.ToString();
            RestResponse<NSXTIPSecVpnSessionType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTIPSecVpnSessionType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Put operation to " + CreateOrUpdateTier0IpsecVpnSessionServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task DeleteTier0IpsecVpnSession(string Tier0Id, string LocaleServiceId, string ServiceId, string SessionId)
        {
            if (Tier0Id == null) { throw new System.ArgumentNullException("Tier0Id cannot be null"); }
            if (LocaleServiceId == null) { throw new System.ArgumentNullException("LocaleServiceId cannot be null"); }
            if (ServiceId == null) { throw new System.ArgumentNullException("ServiceId cannot be null"); }
            if (SessionId == null) { throw new System.ArgumentNullException("SessionId cannot be null"); }
            StringBuilder DeleteTier0IpsecVpnSessionServiceURL = new StringBuilder("/infra/tier-0s/{tier-0-id}/locale-services/{locale-service-id}/ipsec-vpn-services/{service-id}/sessions/{session-id}");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Delete
            };
            DeleteTier0IpsecVpnSessionServiceURL.Replace("{tier-0-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(Tier0Id, System.Globalization.CultureInfo.InvariantCulture)));
            DeleteTier0IpsecVpnSessionServiceURL.Replace("{locale-service-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(LocaleServiceId, System.Globalization.CultureInfo.InvariantCulture)));
            DeleteTier0IpsecVpnSessionServiceURL.Replace("{service-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(ServiceId, System.Globalization.CultureInfo.InvariantCulture)));
            DeleteTier0IpsecVpnSessionServiceURL.Replace("{session-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(SessionId, System.Globalization.CultureInfo.InvariantCulture)));
            request.Resource = DeleteTier0IpsecVpnSessionServiceURL.ToString();
            RestResponse response = await restClient.ExecuteTaskAsyncWithPolicy(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Delete operation to " + DeleteTier0IpsecVpnSessionServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTIPSecVpnSessionType> GetTier0IpsecVpnSession(string Tier0Id, string LocaleServiceId, string ServiceId, string SessionId)
        {
            if (Tier0Id == null) { throw new System.ArgumentNullException("Tier0Id cannot be null"); }
            if (LocaleServiceId == null) { throw new System.ArgumentNullException("LocaleServiceId cannot be null"); }
            if (ServiceId == null) { throw new System.ArgumentNullException("ServiceId cannot be null"); }
            if (SessionId == null) { throw new System.ArgumentNullException("SessionId cannot be null"); }
            StringBuilder GetTier0IpsecVpnSessionServiceURL = new StringBuilder("/infra/tier-0s/{tier-0-id}/locale-services/{locale-service-id}/ipsec-vpn-services/{service-id}/sessions/{session-id}");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Get
            };
            GetTier0IpsecVpnSessionServiceURL.Replace("{tier-0-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(Tier0Id, System.Globalization.CultureInfo.InvariantCulture)));
            GetTier0IpsecVpnSessionServiceURL.Replace("{locale-service-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(LocaleServiceId, System.Globalization.CultureInfo.InvariantCulture)));
            GetTier0IpsecVpnSessionServiceURL.Replace("{service-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(ServiceId, System.Globalization.CultureInfo.InvariantCulture)));
            GetTier0IpsecVpnSessionServiceURL.Replace("{session-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(SessionId, System.Globalization.CultureInfo.InvariantCulture)));
            request.Resource = GetTier0IpsecVpnSessionServiceURL.ToString();
            RestResponse<NSXTIPSecVpnSessionType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTIPSecVpnSessionType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Get operation to " + GetTier0IpsecVpnSessionServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task CreateOrPatchTier0IpsecVpnSession(string Tier0Id, string LocaleServiceId, string ServiceId, string SessionId, NSXTIPSecVpnSessionType IpsecVpnSession)
        {
            if (Tier0Id == null) { throw new System.ArgumentNullException("Tier0Id cannot be null"); }
            if (LocaleServiceId == null) { throw new System.ArgumentNullException("LocaleServiceId cannot be null"); }
            if (ServiceId == null) { throw new System.ArgumentNullException("ServiceId cannot be null"); }
            if (SessionId == null) { throw new System.ArgumentNullException("SessionId cannot be null"); }
            if (IpsecVpnSession == null) { throw new System.ArgumentNullException("IpsecVpnSession cannot be null"); }
            StringBuilder CreateOrPatchTier0IpsecVpnSessionServiceURL = new StringBuilder("/infra/tier-0s/{tier-0-id}/locale-services/{locale-service-id}/ipsec-vpn-services/{service-id}/sessions/{session-id}");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Patch
            };
            CreateOrPatchTier0IpsecVpnSessionServiceURL.Replace("{tier-0-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(Tier0Id, System.Globalization.CultureInfo.InvariantCulture)));
            CreateOrPatchTier0IpsecVpnSessionServiceURL.Replace("{locale-service-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(LocaleServiceId, System.Globalization.CultureInfo.InvariantCulture)));
            CreateOrPatchTier0IpsecVpnSessionServiceURL.Replace("{service-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(ServiceId, System.Globalization.CultureInfo.InvariantCulture)));
            CreateOrPatchTier0IpsecVpnSessionServiceURL.Replace("{session-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(SessionId, System.Globalization.CultureInfo.InvariantCulture)));
            request.AddJsonBody(IpsecVpnSession);
            request.Resource = CreateOrPatchTier0IpsecVpnSessionServiceURL.ToString();
            RestResponse response = await restClient.ExecuteTaskAsyncWithPolicy(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Patch operation to " + CreateOrPatchTier0IpsecVpnSessionServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTIPSecVpnSessionListResultType> ListTier1IpsecVpnSessions(string Tier1Id, string LocaleServiceId, string ServiceId, string? Cursor = null, bool? IncludeMarkForDeleteObjects = null, string? IncludedFields = null, long? PageSize = null, bool? SortAscending = null, string? SortBy = null)
        {
            if (Tier1Id == null) { throw new System.ArgumentNullException("Tier1Id cannot be null"); }
            if (LocaleServiceId == null) { throw new System.ArgumentNullException("LocaleServiceId cannot be null"); }
            if (ServiceId == null) { throw new System.ArgumentNullException("ServiceId cannot be null"); }
            StringBuilder ListTier1IpsecVpnSessionsServiceURL = new StringBuilder("/infra/tier-1s/{tier-1-id}/locale-services/{locale-service-id}/ipsec-vpn-services/{service-id}/sessions");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Get
            };
            ListTier1IpsecVpnSessionsServiceURL.Replace("{tier-1-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(Tier1Id, System.Globalization.CultureInfo.InvariantCulture)));
            ListTier1IpsecVpnSessionsServiceURL.Replace("{locale-service-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(LocaleServiceId, System.Globalization.CultureInfo.InvariantCulture)));
            ListTier1IpsecVpnSessionsServiceURL.Replace("{service-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(ServiceId, System.Globalization.CultureInfo.InvariantCulture)));
            if (Cursor != null) { request.AddQueryParameter("cursor", Cursor.ToString()); }
            if (IncludeMarkForDeleteObjects != null) { request.AddQueryParameter("include_mark_for_delete_objects", IncludeMarkForDeleteObjects.ToString()); }
            if (IncludedFields != null) { request.AddQueryParameter("included_fields", IncludedFields.ToString()); }
            if (PageSize != null) { request.AddQueryParameter("page_size", PageSize.ToString()); }
            if (SortAscending != null) { request.AddQueryParameter("sort_ascending", SortAscending.ToString()); }
            if (SortBy != null) { request.AddQueryParameter("sort_by", SortBy.ToString()); }
            request.Resource = ListTier1IpsecVpnSessionsServiceURL.ToString();
            RestResponse<NSXTIPSecVpnSessionListResultType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTIPSecVpnSessionListResultType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Get operation to " + ListTier1IpsecVpnSessionsServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTIPSecVpnServiceType> CreateOrUpdateTier0IpsecVpnService(string Tier0Id, string LocaleServiceId, string ServiceId, NSXTIPSecVpnServiceType IpsecVpnService)
        {
            if (Tier0Id == null) { throw new System.ArgumentNullException("Tier0Id cannot be null"); }
            if (LocaleServiceId == null) { throw new System.ArgumentNullException("LocaleServiceId cannot be null"); }
            if (ServiceId == null) { throw new System.ArgumentNullException("ServiceId cannot be null"); }
            if (IpsecVpnService == null) { throw new System.ArgumentNullException("IpsecVpnService cannot be null"); }
            StringBuilder CreateOrUpdateTier0IpsecVpnServiceServiceURL = new StringBuilder("/infra/tier-0s/{tier-0-id}/locale-services/{locale-service-id}/ipsec-vpn-services/{service-id}");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Put
            };
            CreateOrUpdateTier0IpsecVpnServiceServiceURL.Replace("{tier-0-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(Tier0Id, System.Globalization.CultureInfo.InvariantCulture)));
            CreateOrUpdateTier0IpsecVpnServiceServiceURL.Replace("{locale-service-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(LocaleServiceId, System.Globalization.CultureInfo.InvariantCulture)));
            CreateOrUpdateTier0IpsecVpnServiceServiceURL.Replace("{service-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(ServiceId, System.Globalization.CultureInfo.InvariantCulture)));
            request.AddJsonBody(IpsecVpnService);
            request.Resource = CreateOrUpdateTier0IpsecVpnServiceServiceURL.ToString();
            RestResponse<NSXTIPSecVpnServiceType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTIPSecVpnServiceType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Put operation to " + CreateOrUpdateTier0IpsecVpnServiceServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTIPSecVpnServiceType> GetTier0IpsecVpnService(string Tier0Id, string LocaleServiceId, string ServiceId)
        {
            if (Tier0Id == null) { throw new System.ArgumentNullException("Tier0Id cannot be null"); }
            if (LocaleServiceId == null) { throw new System.ArgumentNullException("LocaleServiceId cannot be null"); }
            if (ServiceId == null) { throw new System.ArgumentNullException("ServiceId cannot be null"); }
            StringBuilder GetTier0IpsecVpnServiceServiceURL = new StringBuilder("/infra/tier-0s/{tier-0-id}/locale-services/{locale-service-id}/ipsec-vpn-services/{service-id}");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Get
            };
            GetTier0IpsecVpnServiceServiceURL.Replace("{tier-0-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(Tier0Id, System.Globalization.CultureInfo.InvariantCulture)));
            GetTier0IpsecVpnServiceServiceURL.Replace("{locale-service-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(LocaleServiceId, System.Globalization.CultureInfo.InvariantCulture)));
            GetTier0IpsecVpnServiceServiceURL.Replace("{service-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(ServiceId, System.Globalization.CultureInfo.InvariantCulture)));
            request.Resource = GetTier0IpsecVpnServiceServiceURL.ToString();
            RestResponse<NSXTIPSecVpnServiceType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTIPSecVpnServiceType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Get operation to " + GetTier0IpsecVpnServiceServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task DeleteTier0IpsecVpnService(string Tier0Id, string LocaleServiceId, string ServiceId)
        {
            if (Tier0Id == null) { throw new System.ArgumentNullException("Tier0Id cannot be null"); }
            if (LocaleServiceId == null) { throw new System.ArgumentNullException("LocaleServiceId cannot be null"); }
            if (ServiceId == null) { throw new System.ArgumentNullException("ServiceId cannot be null"); }
            StringBuilder DeleteTier0IpsecVpnServiceServiceURL = new StringBuilder("/infra/tier-0s/{tier-0-id}/locale-services/{locale-service-id}/ipsec-vpn-services/{service-id}");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Delete
            };
            DeleteTier0IpsecVpnServiceServiceURL.Replace("{tier-0-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(Tier0Id, System.Globalization.CultureInfo.InvariantCulture)));
            DeleteTier0IpsecVpnServiceServiceURL.Replace("{locale-service-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(LocaleServiceId, System.Globalization.CultureInfo.InvariantCulture)));
            DeleteTier0IpsecVpnServiceServiceURL.Replace("{service-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(ServiceId, System.Globalization.CultureInfo.InvariantCulture)));
            request.Resource = DeleteTier0IpsecVpnServiceServiceURL.ToString();
            RestResponse response = await restClient.ExecuteTaskAsyncWithPolicy(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Delete operation to " + DeleteTier0IpsecVpnServiceServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task CreateOrPatchTier0IpsecVpnService(string Tier0Id, string LocaleServiceId, string ServiceId, NSXTIPSecVpnServiceType IpsecVpnService)
        {
            if (Tier0Id == null) { throw new System.ArgumentNullException("Tier0Id cannot be null"); }
            if (LocaleServiceId == null) { throw new System.ArgumentNullException("LocaleServiceId cannot be null"); }
            if (ServiceId == null) { throw new System.ArgumentNullException("ServiceId cannot be null"); }
            if (IpsecVpnService == null) { throw new System.ArgumentNullException("IpsecVpnService cannot be null"); }
            StringBuilder CreateOrPatchTier0IpsecVpnServiceServiceURL = new StringBuilder("/infra/tier-0s/{tier-0-id}/locale-services/{locale-service-id}/ipsec-vpn-services/{service-id}");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Patch
            };
            CreateOrPatchTier0IpsecVpnServiceServiceURL.Replace("{tier-0-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(Tier0Id, System.Globalization.CultureInfo.InvariantCulture)));
            CreateOrPatchTier0IpsecVpnServiceServiceURL.Replace("{locale-service-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(LocaleServiceId, System.Globalization.CultureInfo.InvariantCulture)));
            CreateOrPatchTier0IpsecVpnServiceServiceURL.Replace("{service-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(ServiceId, System.Globalization.CultureInfo.InvariantCulture)));
            request.AddJsonBody(IpsecVpnService);
            request.Resource = CreateOrPatchTier0IpsecVpnServiceServiceURL.ToString();
            RestResponse response = await restClient.ExecuteTaskAsyncWithPolicy(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Patch operation to " + CreateOrPatchTier0IpsecVpnServiceServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTIPSecVpnServiceListResultType> ListTier0IpsecVpnServices(string Tier0Id, string LocaleServiceId, string? Cursor = null, bool? IncludeMarkForDeleteObjects = null, string? IncludedFields = null, long? PageSize = null, bool? SortAscending = null, string? SortBy = null)
        {
            if (Tier0Id == null) { throw new System.ArgumentNullException("Tier0Id cannot be null"); }
            if (LocaleServiceId == null) { throw new System.ArgumentNullException("LocaleServiceId cannot be null"); }
            StringBuilder ListTier0IpsecVpnServicesServiceURL = new StringBuilder("/infra/tier-0s/{tier-0-id}/locale-services/{locale-service-id}/ipsec-vpn-services");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Get
            };
            ListTier0IpsecVpnServicesServiceURL.Replace("{tier-0-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(Tier0Id, System.Globalization.CultureInfo.InvariantCulture)));
            ListTier0IpsecVpnServicesServiceURL.Replace("{locale-service-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(LocaleServiceId, System.Globalization.CultureInfo.InvariantCulture)));
            if (Cursor != null) { request.AddQueryParameter("cursor", Cursor.ToString()); }
            if (IncludeMarkForDeleteObjects != null) { request.AddQueryParameter("include_mark_for_delete_objects", IncludeMarkForDeleteObjects.ToString()); }
            if (IncludedFields != null) { request.AddQueryParameter("included_fields", IncludedFields.ToString()); }
            if (PageSize != null) { request.AddQueryParameter("page_size", PageSize.ToString()); }
            if (SortAscending != null) { request.AddQueryParameter("sort_ascending", SortAscending.ToString()); }
            if (SortBy != null) { request.AddQueryParameter("sort_by", SortBy.ToString()); }
            request.Resource = ListTier0IpsecVpnServicesServiceURL.ToString();
            RestResponse<NSXTIPSecVpnServiceListResultType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTIPSecVpnServiceListResultType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Get operation to " + ListTier0IpsecVpnServicesServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTIPSecVpnSessionType> CreateOrUpdateTier1IpsecVpnSession(string Tier1Id, string LocaleServiceId, string ServiceId, string SessionId, NSXTIPSecVpnSessionType IpsecVpnSession)
        {
            if (Tier1Id == null) { throw new System.ArgumentNullException("Tier1Id cannot be null"); }
            if (LocaleServiceId == null) { throw new System.ArgumentNullException("LocaleServiceId cannot be null"); }
            if (ServiceId == null) { throw new System.ArgumentNullException("ServiceId cannot be null"); }
            if (SessionId == null) { throw new System.ArgumentNullException("SessionId cannot be null"); }
            if (IpsecVpnSession == null) { throw new System.ArgumentNullException("IpsecVpnSession cannot be null"); }
            StringBuilder CreateOrUpdateTier1IpsecVpnSessionServiceURL = new StringBuilder("/infra/tier-1s/{tier-1-id}/locale-services/{locale-service-id}/ipsec-vpn-services/{service-id}/sessions/{session-id}");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Put
            };
            CreateOrUpdateTier1IpsecVpnSessionServiceURL.Replace("{tier-1-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(Tier1Id, System.Globalization.CultureInfo.InvariantCulture)));
            CreateOrUpdateTier1IpsecVpnSessionServiceURL.Replace("{locale-service-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(LocaleServiceId, System.Globalization.CultureInfo.InvariantCulture)));
            CreateOrUpdateTier1IpsecVpnSessionServiceURL.Replace("{service-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(ServiceId, System.Globalization.CultureInfo.InvariantCulture)));
            CreateOrUpdateTier1IpsecVpnSessionServiceURL.Replace("{session-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(SessionId, System.Globalization.CultureInfo.InvariantCulture)));
            request.AddJsonBody(IpsecVpnSession);
            request.Resource = CreateOrUpdateTier1IpsecVpnSessionServiceURL.ToString();
            RestResponse<NSXTIPSecVpnSessionType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTIPSecVpnSessionType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Put operation to " + CreateOrUpdateTier1IpsecVpnSessionServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTIPSecVpnSessionType> GetTier1IpsecVpnSession(string Tier1Id, string LocaleServiceId, string ServiceId, string SessionId)
        {
            if (Tier1Id == null) { throw new System.ArgumentNullException("Tier1Id cannot be null"); }
            if (LocaleServiceId == null) { throw new System.ArgumentNullException("LocaleServiceId cannot be null"); }
            if (ServiceId == null) { throw new System.ArgumentNullException("ServiceId cannot be null"); }
            if (SessionId == null) { throw new System.ArgumentNullException("SessionId cannot be null"); }
            StringBuilder GetTier1IpsecVpnSessionServiceURL = new StringBuilder("/infra/tier-1s/{tier-1-id}/locale-services/{locale-service-id}/ipsec-vpn-services/{service-id}/sessions/{session-id}");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Get
            };
            GetTier1IpsecVpnSessionServiceURL.Replace("{tier-1-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(Tier1Id, System.Globalization.CultureInfo.InvariantCulture)));
            GetTier1IpsecVpnSessionServiceURL.Replace("{locale-service-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(LocaleServiceId, System.Globalization.CultureInfo.InvariantCulture)));
            GetTier1IpsecVpnSessionServiceURL.Replace("{service-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(ServiceId, System.Globalization.CultureInfo.InvariantCulture)));
            GetTier1IpsecVpnSessionServiceURL.Replace("{session-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(SessionId, System.Globalization.CultureInfo.InvariantCulture)));
            request.Resource = GetTier1IpsecVpnSessionServiceURL.ToString();
            RestResponse<NSXTIPSecVpnSessionType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTIPSecVpnSessionType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Get operation to " + GetTier1IpsecVpnSessionServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task DeleteTier1IpsecVpnSession(string Tier1Id, string LocaleServiceId, string ServiceId, string SessionId)
        {
            if (Tier1Id == null) { throw new System.ArgumentNullException("Tier1Id cannot be null"); }
            if (LocaleServiceId == null) { throw new System.ArgumentNullException("LocaleServiceId cannot be null"); }
            if (ServiceId == null) { throw new System.ArgumentNullException("ServiceId cannot be null"); }
            if (SessionId == null) { throw new System.ArgumentNullException("SessionId cannot be null"); }
            StringBuilder DeleteTier1IpsecVpnSessionServiceURL = new StringBuilder("/infra/tier-1s/{tier-1-id}/locale-services/{locale-service-id}/ipsec-vpn-services/{service-id}/sessions/{session-id}");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Delete
            };
            DeleteTier1IpsecVpnSessionServiceURL.Replace("{tier-1-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(Tier1Id, System.Globalization.CultureInfo.InvariantCulture)));
            DeleteTier1IpsecVpnSessionServiceURL.Replace("{locale-service-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(LocaleServiceId, System.Globalization.CultureInfo.InvariantCulture)));
            DeleteTier1IpsecVpnSessionServiceURL.Replace("{service-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(ServiceId, System.Globalization.CultureInfo.InvariantCulture)));
            DeleteTier1IpsecVpnSessionServiceURL.Replace("{session-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(SessionId, System.Globalization.CultureInfo.InvariantCulture)));
            request.Resource = DeleteTier1IpsecVpnSessionServiceURL.ToString();
            RestResponse response = await restClient.ExecuteTaskAsyncWithPolicy(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Delete operation to " + DeleteTier1IpsecVpnSessionServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task CreateOrPatchTier1IpsecVpnSession(string Tier1Id, string LocaleServiceId, string ServiceId, string SessionId, NSXTIPSecVpnSessionType IpsecVpnSession)
        {
            if (Tier1Id == null) { throw new System.ArgumentNullException("Tier1Id cannot be null"); }
            if (LocaleServiceId == null) { throw new System.ArgumentNullException("LocaleServiceId cannot be null"); }
            if (ServiceId == null) { throw new System.ArgumentNullException("ServiceId cannot be null"); }
            if (SessionId == null) { throw new System.ArgumentNullException("SessionId cannot be null"); }
            if (IpsecVpnSession == null) { throw new System.ArgumentNullException("IpsecVpnSession cannot be null"); }
            StringBuilder CreateOrPatchTier1IpsecVpnSessionServiceURL = new StringBuilder("/infra/tier-1s/{tier-1-id}/locale-services/{locale-service-id}/ipsec-vpn-services/{service-id}/sessions/{session-id}");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Patch
            };
            CreateOrPatchTier1IpsecVpnSessionServiceURL.Replace("{tier-1-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(Tier1Id, System.Globalization.CultureInfo.InvariantCulture)));
            CreateOrPatchTier1IpsecVpnSessionServiceURL.Replace("{locale-service-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(LocaleServiceId, System.Globalization.CultureInfo.InvariantCulture)));
            CreateOrPatchTier1IpsecVpnSessionServiceURL.Replace("{service-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(ServiceId, System.Globalization.CultureInfo.InvariantCulture)));
            CreateOrPatchTier1IpsecVpnSessionServiceURL.Replace("{session-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(SessionId, System.Globalization.CultureInfo.InvariantCulture)));
            request.AddJsonBody(IpsecVpnSession);
            request.Resource = CreateOrPatchTier1IpsecVpnSessionServiceURL.ToString();
            RestResponse response = await restClient.ExecuteTaskAsyncWithPolicy(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Patch operation to " + CreateOrPatchTier1IpsecVpnSessionServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTIPSecVpnSessionListResultType> ListTier0IpsecVpnSessions(string Tier0Id, string LocaleServiceId, string ServiceId, string? Cursor = null, bool? IncludeMarkForDeleteObjects = null, string? IncludedFields = null, long? PageSize = null, bool? SortAscending = null, string? SortBy = null)
        {
            if (Tier0Id == null) { throw new System.ArgumentNullException("Tier0Id cannot be null"); }
            if (LocaleServiceId == null) { throw new System.ArgumentNullException("LocaleServiceId cannot be null"); }
            if (ServiceId == null) { throw new System.ArgumentNullException("ServiceId cannot be null"); }
            StringBuilder ListTier0IpsecVpnSessionsServiceURL = new StringBuilder("/infra/tier-0s/{tier-0-id}/locale-services/{locale-service-id}/ipsec-vpn-services/{service-id}/sessions");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Get
            };
            ListTier0IpsecVpnSessionsServiceURL.Replace("{tier-0-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(Tier0Id, System.Globalization.CultureInfo.InvariantCulture)));
            ListTier0IpsecVpnSessionsServiceURL.Replace("{locale-service-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(LocaleServiceId, System.Globalization.CultureInfo.InvariantCulture)));
            ListTier0IpsecVpnSessionsServiceURL.Replace("{service-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(ServiceId, System.Globalization.CultureInfo.InvariantCulture)));
            if (Cursor != null) { request.AddQueryParameter("cursor", Cursor.ToString()); }
            if (IncludeMarkForDeleteObjects != null) { request.AddQueryParameter("include_mark_for_delete_objects", IncludeMarkForDeleteObjects.ToString()); }
            if (IncludedFields != null) { request.AddQueryParameter("included_fields", IncludedFields.ToString()); }
            if (PageSize != null) { request.AddQueryParameter("page_size", PageSize.ToString()); }
            if (SortAscending != null) { request.AddQueryParameter("sort_ascending", SortAscending.ToString()); }
            if (SortBy != null) { request.AddQueryParameter("sort_by", SortBy.ToString()); }
            request.Resource = ListTier0IpsecVpnSessionsServiceURL.ToString();
            RestResponse<NSXTIPSecVpnSessionListResultType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTIPSecVpnSessionListResultType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Get operation to " + ListTier0IpsecVpnSessionsServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTIPSecVpnSessionType> GetTier1IpsecVpnSessionWithSensitiveData(string Tier1Id, string LocaleServiceId, string ServiceId, string SessionId)
        {
            if (Tier1Id == null) { throw new System.ArgumentNullException("Tier1Id cannot be null"); }
            if (LocaleServiceId == null) { throw new System.ArgumentNullException("LocaleServiceId cannot be null"); }
            if (ServiceId == null) { throw new System.ArgumentNullException("ServiceId cannot be null"); }
            if (SessionId == null) { throw new System.ArgumentNullException("SessionId cannot be null"); }
            StringBuilder GetTier1IpsecVpnSessionWithSensitiveDataServiceURL = new StringBuilder("/infra/tier-1s/{tier-1-id}/locale-services/{locale-service-id}/ipsec-vpn-services/{service-id}/sessions/{session-id}?action=show_sensitive_data");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Get
            };
            GetTier1IpsecVpnSessionWithSensitiveDataServiceURL.Replace("{tier-1-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(Tier1Id, System.Globalization.CultureInfo.InvariantCulture)));
            GetTier1IpsecVpnSessionWithSensitiveDataServiceURL.Replace("{locale-service-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(LocaleServiceId, System.Globalization.CultureInfo.InvariantCulture)));
            GetTier1IpsecVpnSessionWithSensitiveDataServiceURL.Replace("{service-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(ServiceId, System.Globalization.CultureInfo.InvariantCulture)));
            GetTier1IpsecVpnSessionWithSensitiveDataServiceURL.Replace("{session-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(SessionId, System.Globalization.CultureInfo.InvariantCulture)));
            request.Resource = GetTier1IpsecVpnSessionWithSensitiveDataServiceURL.ToString();
            RestResponse<NSXTIPSecVpnSessionType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTIPSecVpnSessionType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Get operation to " + GetTier1IpsecVpnSessionWithSensitiveDataServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<string> GetTier0IpsecVpnPeerConfig(string Tier0Id, string LocaleServiceId, string ServiceId, string SessionId, string? EnforcementPointPath = null)
        {
            if (Tier0Id == null) { throw new System.ArgumentNullException("Tier0Id cannot be null"); }
            if (LocaleServiceId == null) { throw new System.ArgumentNullException("LocaleServiceId cannot be null"); }
            if (ServiceId == null) { throw new System.ArgumentNullException("ServiceId cannot be null"); }
            if (SessionId == null) { throw new System.ArgumentNullException("SessionId cannot be null"); }
            StringBuilder GetTier0IpsecVpnPeerConfigServiceURL = new StringBuilder("/infra/tier-0s/{tier-0-id}/locale-services/{locale-service-id}/ipsec-vpn-services/{service-id}/sessions/{session-id}/peer-config");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Get
            };
            GetTier0IpsecVpnPeerConfigServiceURL.Replace("{tier-0-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(Tier0Id, System.Globalization.CultureInfo.InvariantCulture)));
            GetTier0IpsecVpnPeerConfigServiceURL.Replace("{locale-service-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(LocaleServiceId, System.Globalization.CultureInfo.InvariantCulture)));
            GetTier0IpsecVpnPeerConfigServiceURL.Replace("{service-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(ServiceId, System.Globalization.CultureInfo.InvariantCulture)));
            GetTier0IpsecVpnPeerConfigServiceURL.Replace("{session-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(SessionId, System.Globalization.CultureInfo.InvariantCulture)));
            if (EnforcementPointPath != null) { request.AddQueryParameter("enforcement_point_path", EnforcementPointPath.ToString()); }
            request.Resource = GetTier0IpsecVpnPeerConfigServiceURL.ToString();
            RestResponse<string> response = await restClient.ExecuteTaskAsyncWithPolicy<string>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Get operation to " + GetTier0IpsecVpnPeerConfigServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTIPSecVpnLocalEndpointType> CreateOrUpdateTier0IpsecVpnLocalEndpoint(string Tier0Id, string LocaleServiceId, string ServiceId, string LocalEndpointId, NSXTIPSecVpnLocalEndpointType IpsecVpnLocalEndpoint)
        {
            if (Tier0Id == null) { throw new System.ArgumentNullException("Tier0Id cannot be null"); }
            if (LocaleServiceId == null) { throw new System.ArgumentNullException("LocaleServiceId cannot be null"); }
            if (ServiceId == null) { throw new System.ArgumentNullException("ServiceId cannot be null"); }
            if (LocalEndpointId == null) { throw new System.ArgumentNullException("LocalEndpointId cannot be null"); }
            if (IpsecVpnLocalEndpoint == null) { throw new System.ArgumentNullException("IpsecVpnLocalEndpoint cannot be null"); }
            StringBuilder CreateOrUpdateTier0IpsecVpnLocalEndpointServiceURL = new StringBuilder("/infra/tier-0s/{tier-0-id}/locale-services/{locale-service-id}/ipsec-vpn-services/{service-id}/local-endpoints/{local-endpoint-id}");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Put
            };
            CreateOrUpdateTier0IpsecVpnLocalEndpointServiceURL.Replace("{tier-0-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(Tier0Id, System.Globalization.CultureInfo.InvariantCulture)));
            CreateOrUpdateTier0IpsecVpnLocalEndpointServiceURL.Replace("{locale-service-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(LocaleServiceId, System.Globalization.CultureInfo.InvariantCulture)));
            CreateOrUpdateTier0IpsecVpnLocalEndpointServiceURL.Replace("{service-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(ServiceId, System.Globalization.CultureInfo.InvariantCulture)));
            CreateOrUpdateTier0IpsecVpnLocalEndpointServiceURL.Replace("{local-endpoint-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(LocalEndpointId, System.Globalization.CultureInfo.InvariantCulture)));
            request.AddJsonBody(IpsecVpnLocalEndpoint);
            request.Resource = CreateOrUpdateTier0IpsecVpnLocalEndpointServiceURL.ToString();
            RestResponse<NSXTIPSecVpnLocalEndpointType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTIPSecVpnLocalEndpointType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Put operation to " + CreateOrUpdateTier0IpsecVpnLocalEndpointServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTIPSecVpnLocalEndpointType> GetTier0IpsecVpnLocalEndpoint(string Tier0Id, string LocaleServiceId, string ServiceId, string LocalEndpointId)
        {
            if (Tier0Id == null) { throw new System.ArgumentNullException("Tier0Id cannot be null"); }
            if (LocaleServiceId == null) { throw new System.ArgumentNullException("LocaleServiceId cannot be null"); }
            if (ServiceId == null) { throw new System.ArgumentNullException("ServiceId cannot be null"); }
            if (LocalEndpointId == null) { throw new System.ArgumentNullException("LocalEndpointId cannot be null"); }
            StringBuilder GetTier0IpsecVpnLocalEndpointServiceURL = new StringBuilder("/infra/tier-0s/{tier-0-id}/locale-services/{locale-service-id}/ipsec-vpn-services/{service-id}/local-endpoints/{local-endpoint-id}");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Get
            };
            GetTier0IpsecVpnLocalEndpointServiceURL.Replace("{tier-0-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(Tier0Id, System.Globalization.CultureInfo.InvariantCulture)));
            GetTier0IpsecVpnLocalEndpointServiceURL.Replace("{locale-service-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(LocaleServiceId, System.Globalization.CultureInfo.InvariantCulture)));
            GetTier0IpsecVpnLocalEndpointServiceURL.Replace("{service-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(ServiceId, System.Globalization.CultureInfo.InvariantCulture)));
            GetTier0IpsecVpnLocalEndpointServiceURL.Replace("{local-endpoint-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(LocalEndpointId, System.Globalization.CultureInfo.InvariantCulture)));
            request.Resource = GetTier0IpsecVpnLocalEndpointServiceURL.ToString();
            RestResponse<NSXTIPSecVpnLocalEndpointType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTIPSecVpnLocalEndpointType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Get operation to " + GetTier0IpsecVpnLocalEndpointServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task CreateOrPatchTier0IpsecVpnLocalEndpoint(string Tier0Id, string LocaleServiceId, string ServiceId, string LocalEndpointId, NSXTIPSecVpnLocalEndpointType IpsecVpnLocalEndpoint)
        {
            if (Tier0Id == null) { throw new System.ArgumentNullException("Tier0Id cannot be null"); }
            if (LocaleServiceId == null) { throw new System.ArgumentNullException("LocaleServiceId cannot be null"); }
            if (ServiceId == null) { throw new System.ArgumentNullException("ServiceId cannot be null"); }
            if (LocalEndpointId == null) { throw new System.ArgumentNullException("LocalEndpointId cannot be null"); }
            if (IpsecVpnLocalEndpoint == null) { throw new System.ArgumentNullException("IpsecVpnLocalEndpoint cannot be null"); }
            StringBuilder CreateOrPatchTier0IpsecVpnLocalEndpointServiceURL = new StringBuilder("/infra/tier-0s/{tier-0-id}/locale-services/{locale-service-id}/ipsec-vpn-services/{service-id}/local-endpoints/{local-endpoint-id}");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Patch
            };
            CreateOrPatchTier0IpsecVpnLocalEndpointServiceURL.Replace("{tier-0-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(Tier0Id, System.Globalization.CultureInfo.InvariantCulture)));
            CreateOrPatchTier0IpsecVpnLocalEndpointServiceURL.Replace("{locale-service-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(LocaleServiceId, System.Globalization.CultureInfo.InvariantCulture)));
            CreateOrPatchTier0IpsecVpnLocalEndpointServiceURL.Replace("{service-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(ServiceId, System.Globalization.CultureInfo.InvariantCulture)));
            CreateOrPatchTier0IpsecVpnLocalEndpointServiceURL.Replace("{local-endpoint-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(LocalEndpointId, System.Globalization.CultureInfo.InvariantCulture)));
            request.AddJsonBody(IpsecVpnLocalEndpoint);
            request.Resource = CreateOrPatchTier0IpsecVpnLocalEndpointServiceURL.ToString();
            RestResponse response = await restClient.ExecuteTaskAsyncWithPolicy(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Patch operation to " + CreateOrPatchTier0IpsecVpnLocalEndpointServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task DeleteTier0IpsecVpnLocalEndpoint(string Tier0Id, string LocaleServiceId, string ServiceId, string LocalEndpointId)
        {
            if (Tier0Id == null) { throw new System.ArgumentNullException("Tier0Id cannot be null"); }
            if (LocaleServiceId == null) { throw new System.ArgumentNullException("LocaleServiceId cannot be null"); }
            if (ServiceId == null) { throw new System.ArgumentNullException("ServiceId cannot be null"); }
            if (LocalEndpointId == null) { throw new System.ArgumentNullException("LocalEndpointId cannot be null"); }
            StringBuilder DeleteTier0IpsecVpnLocalEndpointServiceURL = new StringBuilder("/infra/tier-0s/{tier-0-id}/locale-services/{locale-service-id}/ipsec-vpn-services/{service-id}/local-endpoints/{local-endpoint-id}");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Delete
            };
            DeleteTier0IpsecVpnLocalEndpointServiceURL.Replace("{tier-0-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(Tier0Id, System.Globalization.CultureInfo.InvariantCulture)));
            DeleteTier0IpsecVpnLocalEndpointServiceURL.Replace("{locale-service-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(LocaleServiceId, System.Globalization.CultureInfo.InvariantCulture)));
            DeleteTier0IpsecVpnLocalEndpointServiceURL.Replace("{service-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(ServiceId, System.Globalization.CultureInfo.InvariantCulture)));
            DeleteTier0IpsecVpnLocalEndpointServiceURL.Replace("{local-endpoint-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(LocalEndpointId, System.Globalization.CultureInfo.InvariantCulture)));
            request.Resource = DeleteTier0IpsecVpnLocalEndpointServiceURL.ToString();
            RestResponse response = await restClient.ExecuteTaskAsyncWithPolicy(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Delete operation to " + DeleteTier0IpsecVpnLocalEndpointServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTIPSecVpnSessionType> GetTier0IpsecVpnSessionWithSensitiveData(string Tier0Id, string LocaleServiceId, string ServiceId, string SessionId)
        {
            if (Tier0Id == null) { throw new System.ArgumentNullException("Tier0Id cannot be null"); }
            if (LocaleServiceId == null) { throw new System.ArgumentNullException("LocaleServiceId cannot be null"); }
            if (ServiceId == null) { throw new System.ArgumentNullException("ServiceId cannot be null"); }
            if (SessionId == null) { throw new System.ArgumentNullException("SessionId cannot be null"); }
            StringBuilder GetTier0IpsecVpnSessionWithSensitiveDataServiceURL = new StringBuilder("/infra/tier-0s/{tier-0-id}/locale-services/{locale-service-id}/ipsec-vpn-services/{service-id}/sessions/{session-id}?action=show_sensitive_data");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Get
            };
            GetTier0IpsecVpnSessionWithSensitiveDataServiceURL.Replace("{tier-0-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(Tier0Id, System.Globalization.CultureInfo.InvariantCulture)));
            GetTier0IpsecVpnSessionWithSensitiveDataServiceURL.Replace("{locale-service-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(LocaleServiceId, System.Globalization.CultureInfo.InvariantCulture)));
            GetTier0IpsecVpnSessionWithSensitiveDataServiceURL.Replace("{service-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(ServiceId, System.Globalization.CultureInfo.InvariantCulture)));
            GetTier0IpsecVpnSessionWithSensitiveDataServiceURL.Replace("{session-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(SessionId, System.Globalization.CultureInfo.InvariantCulture)));
            request.Resource = GetTier0IpsecVpnSessionWithSensitiveDataServiceURL.ToString();
            RestResponse<NSXTIPSecVpnSessionType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTIPSecVpnSessionType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Get operation to " + GetTier0IpsecVpnSessionWithSensitiveDataServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTIPSecVpnLocalEndpointListResultType> ListTier1IpsecVpnLocalEndpoints(string Tier1Id, string LocaleServiceId, string ServiceId, string? Cursor = null, bool? IncludeMarkForDeleteObjects = null, string? IncludedFields = null, long? PageSize = null, bool? SortAscending = null, string? SortBy = null)
        {
            if (Tier1Id == null) { throw new System.ArgumentNullException("Tier1Id cannot be null"); }
            if (LocaleServiceId == null) { throw new System.ArgumentNullException("LocaleServiceId cannot be null"); }
            if (ServiceId == null) { throw new System.ArgumentNullException("ServiceId cannot be null"); }
            StringBuilder ListTier1IpsecVpnLocalEndpointsServiceURL = new StringBuilder("/infra/tier-1s/{tier-1-id}/locale-services/{locale-service-id}/ipsec-vpn-services/{service-id}/local-endpoints");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Get
            };
            ListTier1IpsecVpnLocalEndpointsServiceURL.Replace("{tier-1-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(Tier1Id, System.Globalization.CultureInfo.InvariantCulture)));
            ListTier1IpsecVpnLocalEndpointsServiceURL.Replace("{locale-service-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(LocaleServiceId, System.Globalization.CultureInfo.InvariantCulture)));
            ListTier1IpsecVpnLocalEndpointsServiceURL.Replace("{service-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(ServiceId, System.Globalization.CultureInfo.InvariantCulture)));
            if (Cursor != null) { request.AddQueryParameter("cursor", Cursor.ToString()); }
            if (IncludeMarkForDeleteObjects != null) { request.AddQueryParameter("include_mark_for_delete_objects", IncludeMarkForDeleteObjects.ToString()); }
            if (IncludedFields != null) { request.AddQueryParameter("included_fields", IncludedFields.ToString()); }
            if (PageSize != null) { request.AddQueryParameter("page_size", PageSize.ToString()); }
            if (SortAscending != null) { request.AddQueryParameter("sort_ascending", SortAscending.ToString()); }
            if (SortBy != null) { request.AddQueryParameter("sort_by", SortBy.ToString()); }
            request.Resource = ListTier1IpsecVpnLocalEndpointsServiceURL.ToString();
            RestResponse<NSXTIPSecVpnLocalEndpointListResultType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTIPSecVpnLocalEndpointListResultType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Get operation to " + ListTier1IpsecVpnLocalEndpointsServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTIPSecVpnServiceListResultType> ListTier1IpsecVpnServices(string Tier1Id, string LocaleServiceId, string? Cursor = null, bool? IncludeMarkForDeleteObjects = null, string? IncludedFields = null, long? PageSize = null, bool? SortAscending = null, string? SortBy = null)
        {
            if (Tier1Id == null) { throw new System.ArgumentNullException("Tier1Id cannot be null"); }
            if (LocaleServiceId == null) { throw new System.ArgumentNullException("LocaleServiceId cannot be null"); }
            StringBuilder ListTier1IpsecVpnServicesServiceURL = new StringBuilder("/infra/tier-1s/{tier-1-id}/locale-services/{locale-service-id}/ipsec-vpn-services");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Get
            };
            ListTier1IpsecVpnServicesServiceURL.Replace("{tier-1-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(Tier1Id, System.Globalization.CultureInfo.InvariantCulture)));
            ListTier1IpsecVpnServicesServiceURL.Replace("{locale-service-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(LocaleServiceId, System.Globalization.CultureInfo.InvariantCulture)));
            if (Cursor != null) { request.AddQueryParameter("cursor", Cursor.ToString()); }
            if (IncludeMarkForDeleteObjects != null) { request.AddQueryParameter("include_mark_for_delete_objects", IncludeMarkForDeleteObjects.ToString()); }
            if (IncludedFields != null) { request.AddQueryParameter("included_fields", IncludedFields.ToString()); }
            if (PageSize != null) { request.AddQueryParameter("page_size", PageSize.ToString()); }
            if (SortAscending != null) { request.AddQueryParameter("sort_ascending", SortAscending.ToString()); }
            if (SortBy != null) { request.AddQueryParameter("sort_by", SortBy.ToString()); }
            request.Resource = ListTier1IpsecVpnServicesServiceURL.ToString();
            RestResponse<NSXTIPSecVpnServiceListResultType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTIPSecVpnServiceListResultType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Get operation to " + ListTier1IpsecVpnServicesServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
    }
}
