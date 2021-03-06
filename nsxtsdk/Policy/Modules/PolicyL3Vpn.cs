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
    public class PolicyL3Vpn
    {
        private RestClient restClient;
        private int retry;
        private int timeout;
        private CancellationToken cancellationToken;

        public PolicyL3Vpn(RestClient Client, CancellationToken _cancellationToken, int _timeout, int _retry)
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
        public async Task<string> ReadL3VpnPeerConfig(string Tier0Id, string LocaleServiceId, string L3vpnId, string? EnforcementPointPath = null)
        {
            if (Tier0Id == null) { throw new System.ArgumentNullException("Tier0Id cannot be null"); }
            if (LocaleServiceId == null) { throw new System.ArgumentNullException("LocaleServiceId cannot be null"); }
            if (L3vpnId == null) { throw new System.ArgumentNullException("L3vpnId cannot be null"); }
            StringBuilder ReadL3VpnPeerConfigServiceURL = new StringBuilder("/infra/tier-0s/{tier-0-id}/locale-services/{locale-service-id}/l3vpns/{l3vpn-id}/peer-config");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Get
            };
            ReadL3VpnPeerConfigServiceURL.Replace("{tier-0-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(Tier0Id, System.Globalization.CultureInfo.InvariantCulture)));
            ReadL3VpnPeerConfigServiceURL.Replace("{locale-service-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(LocaleServiceId, System.Globalization.CultureInfo.InvariantCulture)));
            ReadL3VpnPeerConfigServiceURL.Replace("{l3vpn-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(L3vpnId, System.Globalization.CultureInfo.InvariantCulture)));
            if (EnforcementPointPath != null) { request.AddQueryParameter("enforcement_point_path", EnforcementPointPath.ToString()); }
            request.Resource = ReadL3VpnPeerConfigServiceURL.ToString();
            RestResponse<string> response = await restClient.ExecuteTaskAsyncWithPolicy<string>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Get operation to " + ReadL3VpnPeerConfigServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTL3VpnType> ReadL3VpnWithSensitiveData(string Tier0Id, string LocaleServiceId, string L3vpnId)
        {
            if (Tier0Id == null) { throw new System.ArgumentNullException("Tier0Id cannot be null"); }
            if (LocaleServiceId == null) { throw new System.ArgumentNullException("LocaleServiceId cannot be null"); }
            if (L3vpnId == null) { throw new System.ArgumentNullException("L3vpnId cannot be null"); }
            StringBuilder ReadL3VpnWithSensitiveDataServiceURL = new StringBuilder("/infra/tier-0s/{tier-0-id}/locale-services/{locale-service-id}/l3vpns/{l3vpn-id}?action=show_sensitive_data");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Get
            };
            ReadL3VpnWithSensitiveDataServiceURL.Replace("{tier-0-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(Tier0Id, System.Globalization.CultureInfo.InvariantCulture)));
            ReadL3VpnWithSensitiveDataServiceURL.Replace("{locale-service-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(LocaleServiceId, System.Globalization.CultureInfo.InvariantCulture)));
            ReadL3VpnWithSensitiveDataServiceURL.Replace("{l3vpn-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(L3vpnId, System.Globalization.CultureInfo.InvariantCulture)));
            request.Resource = ReadL3VpnWithSensitiveDataServiceURL.ToString();
            RestResponse<NSXTL3VpnType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTL3VpnType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Get operation to " + ReadL3VpnWithSensitiveDataServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTL3VpnListResultType> ListL3Vpns(string Tier0Id, string LocaleServiceId, string? Cursor = null, bool? IncludeMarkForDeleteObjects = null, string? IncludedFields = null, string? L3vpnSession = null, long? PageSize = null, bool? SortAscending = null, string? SortBy = null)
        {
            if (Tier0Id == null) { throw new System.ArgumentNullException("Tier0Id cannot be null"); }
            if (LocaleServiceId == null) { throw new System.ArgumentNullException("LocaleServiceId cannot be null"); }
            StringBuilder ListL3VpnsServiceURL = new StringBuilder("/infra/tier-0s/{tier-0-id}/locale-services/{locale-service-id}/l3vpns");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Get
            };
            ListL3VpnsServiceURL.Replace("{tier-0-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(Tier0Id, System.Globalization.CultureInfo.InvariantCulture)));
            ListL3VpnsServiceURL.Replace("{locale-service-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(LocaleServiceId, System.Globalization.CultureInfo.InvariantCulture)));
            if (Cursor != null) { request.AddQueryParameter("cursor", Cursor.ToString()); }
            if (IncludeMarkForDeleteObjects != null) { request.AddQueryParameter("include_mark_for_delete_objects", IncludeMarkForDeleteObjects.ToString()); }
            if (IncludedFields != null) { request.AddQueryParameter("included_fields", IncludedFields.ToString()); }
            if (L3vpnSession != null) { request.AddQueryParameter("l3vpn_session", L3vpnSession.ToString()); }
            if (PageSize != null) { request.AddQueryParameter("page_size", PageSize.ToString()); }
            if (SortAscending != null) { request.AddQueryParameter("sort_ascending", SortAscending.ToString()); }
            if (SortBy != null) { request.AddQueryParameter("sort_by", SortBy.ToString()); }
            request.Resource = ListL3VpnsServiceURL.ToString();
            RestResponse<NSXTL3VpnListResultType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTL3VpnListResultType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Get operation to " + ListL3VpnsServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTL3VpnType> CreateOrReplaceL3Vpn(string Tier0Id, string LocaleServiceId, string L3vpnId, NSXTL3VpnType L3Vpn)
        {
            if (Tier0Id == null) { throw new System.ArgumentNullException("Tier0Id cannot be null"); }
            if (LocaleServiceId == null) { throw new System.ArgumentNullException("LocaleServiceId cannot be null"); }
            if (L3vpnId == null) { throw new System.ArgumentNullException("L3vpnId cannot be null"); }
            if (L3Vpn == null) { throw new System.ArgumentNullException("L3Vpn cannot be null"); }
            StringBuilder CreateOrReplaceL3VpnServiceURL = new StringBuilder("/infra/tier-0s/{tier-0-id}/locale-services/{locale-service-id}/l3vpns/{l3vpn-id}");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Put
            };
            CreateOrReplaceL3VpnServiceURL.Replace("{tier-0-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(Tier0Id, System.Globalization.CultureInfo.InvariantCulture)));
            CreateOrReplaceL3VpnServiceURL.Replace("{locale-service-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(LocaleServiceId, System.Globalization.CultureInfo.InvariantCulture)));
            CreateOrReplaceL3VpnServiceURL.Replace("{l3vpn-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(L3vpnId, System.Globalization.CultureInfo.InvariantCulture)));
            request.AddJsonBody(L3Vpn);
            request.Resource = CreateOrReplaceL3VpnServiceURL.ToString();
            RestResponse<NSXTL3VpnType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTL3VpnType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Put operation to " + CreateOrReplaceL3VpnServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task DeleteL3Vpn(string Tier0Id, string LocaleServiceId, string L3vpnId)
        {
            if (Tier0Id == null) { throw new System.ArgumentNullException("Tier0Id cannot be null"); }
            if (LocaleServiceId == null) { throw new System.ArgumentNullException("LocaleServiceId cannot be null"); }
            if (L3vpnId == null) { throw new System.ArgumentNullException("L3vpnId cannot be null"); }
            StringBuilder DeleteL3VpnServiceURL = new StringBuilder("/infra/tier-0s/{tier-0-id}/locale-services/{locale-service-id}/l3vpns/{l3vpn-id}");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Delete
            };
            DeleteL3VpnServiceURL.Replace("{tier-0-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(Tier0Id, System.Globalization.CultureInfo.InvariantCulture)));
            DeleteL3VpnServiceURL.Replace("{locale-service-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(LocaleServiceId, System.Globalization.CultureInfo.InvariantCulture)));
            DeleteL3VpnServiceURL.Replace("{l3vpn-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(L3vpnId, System.Globalization.CultureInfo.InvariantCulture)));
            request.Resource = DeleteL3VpnServiceURL.ToString();
            RestResponse response = await restClient.ExecuteTaskAsyncWithPolicy(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Delete operation to " + DeleteL3VpnServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTL3VpnType> ReadL3Vpn(string Tier0Id, string LocaleServiceId, string L3vpnId)
        {
            if (Tier0Id == null) { throw new System.ArgumentNullException("Tier0Id cannot be null"); }
            if (LocaleServiceId == null) { throw new System.ArgumentNullException("LocaleServiceId cannot be null"); }
            if (L3vpnId == null) { throw new System.ArgumentNullException("L3vpnId cannot be null"); }
            StringBuilder ReadL3VpnServiceURL = new StringBuilder("/infra/tier-0s/{tier-0-id}/locale-services/{locale-service-id}/l3vpns/{l3vpn-id}");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Get
            };
            ReadL3VpnServiceURL.Replace("{tier-0-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(Tier0Id, System.Globalization.CultureInfo.InvariantCulture)));
            ReadL3VpnServiceURL.Replace("{locale-service-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(LocaleServiceId, System.Globalization.CultureInfo.InvariantCulture)));
            ReadL3VpnServiceURL.Replace("{l3vpn-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(L3vpnId, System.Globalization.CultureInfo.InvariantCulture)));
            request.Resource = ReadL3VpnServiceURL.ToString();
            RestResponse<NSXTL3VpnType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTL3VpnType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Get operation to " + ReadL3VpnServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task CreateOrPatchL3Vpn(string Tier0Id, string LocaleServiceId, string L3vpnId, NSXTL3VpnType L3Vpn)
        {
            if (Tier0Id == null) { throw new System.ArgumentNullException("Tier0Id cannot be null"); }
            if (LocaleServiceId == null) { throw new System.ArgumentNullException("LocaleServiceId cannot be null"); }
            if (L3vpnId == null) { throw new System.ArgumentNullException("L3vpnId cannot be null"); }
            if (L3Vpn == null) { throw new System.ArgumentNullException("L3Vpn cannot be null"); }
            StringBuilder CreateOrPatchL3VpnServiceURL = new StringBuilder("/infra/tier-0s/{tier-0-id}/locale-services/{locale-service-id}/l3vpns/{l3vpn-id}");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Patch
            };
            CreateOrPatchL3VpnServiceURL.Replace("{tier-0-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(Tier0Id, System.Globalization.CultureInfo.InvariantCulture)));
            CreateOrPatchL3VpnServiceURL.Replace("{locale-service-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(LocaleServiceId, System.Globalization.CultureInfo.InvariantCulture)));
            CreateOrPatchL3VpnServiceURL.Replace("{l3vpn-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(L3vpnId, System.Globalization.CultureInfo.InvariantCulture)));
            request.AddJsonBody(L3Vpn);
            request.Resource = CreateOrPatchL3VpnServiceURL.ToString();
            RestResponse response = await restClient.ExecuteTaskAsyncWithPolicy(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Patch operation to " + CreateOrPatchL3VpnServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTL3VpnContextType> ReadL3VpnContext(string Tier0Id, string LocaleServiceId)
        {
            if (Tier0Id == null) { throw new System.ArgumentNullException("Tier0Id cannot be null"); }
            if (LocaleServiceId == null) { throw new System.ArgumentNullException("LocaleServiceId cannot be null"); }
            StringBuilder ReadL3VpnContextServiceURL = new StringBuilder("/infra/tier-0s/{tier-0-id}/locale-services/{locale-service-id}/l3vpn-context");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Get
            };
            ReadL3VpnContextServiceURL.Replace("{tier-0-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(Tier0Id, System.Globalization.CultureInfo.InvariantCulture)));
            ReadL3VpnContextServiceURL.Replace("{locale-service-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(LocaleServiceId, System.Globalization.CultureInfo.InvariantCulture)));
            request.Resource = ReadL3VpnContextServiceURL.ToString();
            RestResponse<NSXTL3VpnContextType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTL3VpnContextType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Get operation to " + ReadL3VpnContextServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
    }
}
