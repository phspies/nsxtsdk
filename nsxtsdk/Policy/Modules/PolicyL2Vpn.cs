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
    public class PolicyL2Vpn
    {
        private RestClient restClient;
        private int retry;
        private int timeout;
        private CancellationToken cancellationToken;

        public PolicyL2Vpn(RestClient Client, CancellationToken _cancellationToken, int _timeout, int _retry)
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
        public async Task<NSXTL2VpnListResultType> ListL2Vpns(string Tier0Id, string LocaleServiceId, string? Cursor = null, bool? IncludeMarkForDeleteObjects = null, string? IncludedFields = null, long? PageSize = null, bool? SortAscending = null, string? SortBy = null)
        {
            if (Tier0Id == null) { throw new System.ArgumentNullException("Tier0Id cannot be null"); }
            if (LocaleServiceId == null) { throw new System.ArgumentNullException("LocaleServiceId cannot be null"); }
            StringBuilder ListL2VpnsServiceURL = new StringBuilder("/infra/tier-0s/{tier-0-id}/locale-services/{locale-service-id}/l2vpn-context/l2vpns");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Get
            };
            ListL2VpnsServiceURL.Replace("{tier-0-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(Tier0Id, System.Globalization.CultureInfo.InvariantCulture)));
            ListL2VpnsServiceURL.Replace("{locale-service-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(LocaleServiceId, System.Globalization.CultureInfo.InvariantCulture)));
            if (Cursor != null) { request.AddQueryParameter("cursor", Cursor.ToString()); }
            if (IncludeMarkForDeleteObjects != null) { request.AddQueryParameter("include_mark_for_delete_objects", IncludeMarkForDeleteObjects.ToString()); }
            if (IncludedFields != null) { request.AddQueryParameter("included_fields", IncludedFields.ToString()); }
            if (PageSize != null) { request.AddQueryParameter("page_size", PageSize.ToString()); }
            if (SortAscending != null) { request.AddQueryParameter("sort_ascending", SortAscending.ToString()); }
            if (SortBy != null) { request.AddQueryParameter("sort_by", SortBy.ToString()); }
            request.Resource = ListL2VpnsServiceURL.ToString();
            RestResponse<NSXTL2VpnListResultType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTL2VpnListResultType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Get operation to " + ListL2VpnsServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTAggregateL2VpnPeerConfigType> ReadL2VpnPeerConfig(string Tier0Id, string LocaleServiceId, string L2vpnId, string? EnforcementPointPath = null)
        {
            if (Tier0Id == null) { throw new System.ArgumentNullException("Tier0Id cannot be null"); }
            if (LocaleServiceId == null) { throw new System.ArgumentNullException("LocaleServiceId cannot be null"); }
            if (L2vpnId == null) { throw new System.ArgumentNullException("L2vpnId cannot be null"); }
            StringBuilder ReadL2VpnPeerConfigServiceURL = new StringBuilder("/infra/tier-0s/{tier-0-id}/locale-services/{locale-service-id}/l2vpn-context/l2vpns/{l2vpn-id}/peer-config");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Get
            };
            ReadL2VpnPeerConfigServiceURL.Replace("{tier-0-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(Tier0Id, System.Globalization.CultureInfo.InvariantCulture)));
            ReadL2VpnPeerConfigServiceURL.Replace("{locale-service-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(LocaleServiceId, System.Globalization.CultureInfo.InvariantCulture)));
            ReadL2VpnPeerConfigServiceURL.Replace("{l2vpn-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(L2vpnId, System.Globalization.CultureInfo.InvariantCulture)));
            if (EnforcementPointPath != null) { request.AddQueryParameter("enforcement_point_path", EnforcementPointPath.ToString()); }
            request.Resource = ReadL2VpnPeerConfigServiceURL.ToString();
            RestResponse<NSXTAggregateL2VpnPeerConfigType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTAggregateL2VpnPeerConfigType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Get operation to " + ReadL2VpnPeerConfigServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTL2VpnContextType> ReadL2VpnContext(string Tier0Id, string LocaleServiceId)
        {
            if (Tier0Id == null) { throw new System.ArgumentNullException("Tier0Id cannot be null"); }
            if (LocaleServiceId == null) { throw new System.ArgumentNullException("LocaleServiceId cannot be null"); }
            StringBuilder ReadL2VpnContextServiceURL = new StringBuilder("/infra/tier-0s/{tier-0-id}/locale-services/{locale-service-id}/l2vpn-context");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Get
            };
            ReadL2VpnContextServiceURL.Replace("{tier-0-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(Tier0Id, System.Globalization.CultureInfo.InvariantCulture)));
            ReadL2VpnContextServiceURL.Replace("{locale-service-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(LocaleServiceId, System.Globalization.CultureInfo.InvariantCulture)));
            request.Resource = ReadL2VpnContextServiceURL.ToString();
            RestResponse<NSXTL2VpnContextType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTL2VpnContextType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Get operation to " + ReadL2VpnContextServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTL2VpnType> CreateOrReplaceL2Vpn(string Tier0Id, string LocaleServiceId, string L2vpnId, NSXTL2VpnType L2Vpn)
        {
            if (Tier0Id == null) { throw new System.ArgumentNullException("Tier0Id cannot be null"); }
            if (LocaleServiceId == null) { throw new System.ArgumentNullException("LocaleServiceId cannot be null"); }
            if (L2vpnId == null) { throw new System.ArgumentNullException("L2vpnId cannot be null"); }
            if (L2Vpn == null) { throw new System.ArgumentNullException("L2Vpn cannot be null"); }
            StringBuilder CreateOrReplaceL2VpnServiceURL = new StringBuilder("/infra/tier-0s/{tier-0-id}/locale-services/{locale-service-id}/l2vpn-context/l2vpns/{l2vpn-id}");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Put
            };
            CreateOrReplaceL2VpnServiceURL.Replace("{tier-0-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(Tier0Id, System.Globalization.CultureInfo.InvariantCulture)));
            CreateOrReplaceL2VpnServiceURL.Replace("{locale-service-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(LocaleServiceId, System.Globalization.CultureInfo.InvariantCulture)));
            CreateOrReplaceL2VpnServiceURL.Replace("{l2vpn-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(L2vpnId, System.Globalization.CultureInfo.InvariantCulture)));
            request.AddJsonBody(L2Vpn);
            request.Resource = CreateOrReplaceL2VpnServiceURL.ToString();
            RestResponse<NSXTL2VpnType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTL2VpnType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Put operation to " + CreateOrReplaceL2VpnServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task DeleteL2Vpn(string Tier0Id, string LocaleServiceId, string L2vpnId)
        {
            if (Tier0Id == null) { throw new System.ArgumentNullException("Tier0Id cannot be null"); }
            if (LocaleServiceId == null) { throw new System.ArgumentNullException("LocaleServiceId cannot be null"); }
            if (L2vpnId == null) { throw new System.ArgumentNullException("L2vpnId cannot be null"); }
            StringBuilder DeleteL2VpnServiceURL = new StringBuilder("/infra/tier-0s/{tier-0-id}/locale-services/{locale-service-id}/l2vpn-context/l2vpns/{l2vpn-id}");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Delete
            };
            DeleteL2VpnServiceURL.Replace("{tier-0-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(Tier0Id, System.Globalization.CultureInfo.InvariantCulture)));
            DeleteL2VpnServiceURL.Replace("{locale-service-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(LocaleServiceId, System.Globalization.CultureInfo.InvariantCulture)));
            DeleteL2VpnServiceURL.Replace("{l2vpn-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(L2vpnId, System.Globalization.CultureInfo.InvariantCulture)));
            request.Resource = DeleteL2VpnServiceURL.ToString();
            RestResponse response = await restClient.ExecuteTaskAsyncWithPolicy(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Delete operation to " + DeleteL2VpnServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task CreateOrPatchL2Vpn(string Tier0Id, string LocaleServiceId, string L2vpnId, NSXTL2VpnType L2Vpn)
        {
            if (Tier0Id == null) { throw new System.ArgumentNullException("Tier0Id cannot be null"); }
            if (LocaleServiceId == null) { throw new System.ArgumentNullException("LocaleServiceId cannot be null"); }
            if (L2vpnId == null) { throw new System.ArgumentNullException("L2vpnId cannot be null"); }
            if (L2Vpn == null) { throw new System.ArgumentNullException("L2Vpn cannot be null"); }
            StringBuilder CreateOrPatchL2VpnServiceURL = new StringBuilder("/infra/tier-0s/{tier-0-id}/locale-services/{locale-service-id}/l2vpn-context/l2vpns/{l2vpn-id}");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Patch
            };
            CreateOrPatchL2VpnServiceURL.Replace("{tier-0-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(Tier0Id, System.Globalization.CultureInfo.InvariantCulture)));
            CreateOrPatchL2VpnServiceURL.Replace("{locale-service-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(LocaleServiceId, System.Globalization.CultureInfo.InvariantCulture)));
            CreateOrPatchL2VpnServiceURL.Replace("{l2vpn-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(L2vpnId, System.Globalization.CultureInfo.InvariantCulture)));
            request.AddJsonBody(L2Vpn);
            request.Resource = CreateOrPatchL2VpnServiceURL.ToString();
            RestResponse response = await restClient.ExecuteTaskAsyncWithPolicy(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Patch operation to " + CreateOrPatchL2VpnServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTL2VpnType> ReadL2Vpn(string Tier0Id, string LocaleServiceId, string L2vpnId)
        {
            if (Tier0Id == null) { throw new System.ArgumentNullException("Tier0Id cannot be null"); }
            if (LocaleServiceId == null) { throw new System.ArgumentNullException("LocaleServiceId cannot be null"); }
            if (L2vpnId == null) { throw new System.ArgumentNullException("L2vpnId cannot be null"); }
            StringBuilder ReadL2VpnServiceURL = new StringBuilder("/infra/tier-0s/{tier-0-id}/locale-services/{locale-service-id}/l2vpn-context/l2vpns/{l2vpn-id}");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Get
            };
            ReadL2VpnServiceURL.Replace("{tier-0-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(Tier0Id, System.Globalization.CultureInfo.InvariantCulture)));
            ReadL2VpnServiceURL.Replace("{locale-service-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(LocaleServiceId, System.Globalization.CultureInfo.InvariantCulture)));
            ReadL2VpnServiceURL.Replace("{l2vpn-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(L2vpnId, System.Globalization.CultureInfo.InvariantCulture)));
            request.Resource = ReadL2VpnServiceURL.ToString();
            RestResponse<NSXTL2VpnType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTL2VpnType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Get operation to " + ReadL2VpnServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
    }
}
