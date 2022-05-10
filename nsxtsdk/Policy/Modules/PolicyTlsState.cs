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
    public class PolicyTlsState
    {
        private RestClient restClient;
        private int retry;
        private int timeout;
        private CancellationToken cancellationToken;

        public PolicyTlsState(RestClient Client, CancellationToken _cancellationToken, int _timeout, int _retry)
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
        public async Task<NSXTTlsStateObjectListResultType> ListTlsStateFqdns(string Tier1Id, string? Cursor = null, bool? FailedDomains = null, string? Fqdn = null, string? IncludedFields = null, long? PageSize = null, bool? SortAscending = null, string? SortBy = null)
        {
            if (Tier1Id == null) { throw new System.ArgumentNullException("Tier1Id cannot be null"); }
            StringBuilder ListTlsStateFqdnsServiceURL = new StringBuilder("/infra/tier-1s/{tier-1-id}/tls-inspection-state/fqdns");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Get
            };
            ListTlsStateFqdnsServiceURL.Replace("{tier-1-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(Tier1Id, System.Globalization.CultureInfo.InvariantCulture)));
            if (Cursor != null) { request.AddQueryParameter("cursor", Cursor.ToString()); }
            if (FailedDomains != null) { request.AddQueryParameter("failed_domains", FailedDomains.ToString()); }
            if (Fqdn != null) { request.AddQueryParameter("fqdn", Fqdn.ToString()); }
            if (IncludedFields != null) { request.AddQueryParameter("included_fields", IncludedFields.ToString()); }
            if (PageSize != null) { request.AddQueryParameter("page_size", PageSize.ToString()); }
            if (SortAscending != null) { request.AddQueryParameter("sort_ascending", SortAscending.ToString()); }
            if (SortBy != null) { request.AddQueryParameter("sort_by", SortBy.ToString()); }
            request.Resource = ListTlsStateFqdnsServiceURL.ToString();
            RestResponse<NSXTTlsStateObjectListResultType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTTlsStateObjectListResultType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Get operation to " + ListTlsStateFqdnsServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTTlsStateObjectType> GetTlsStateFqdn(string Tier1Id, string FqdnId)
        {
            if (Tier1Id == null) { throw new System.ArgumentNullException("Tier1Id cannot be null"); }
            if (FqdnId == null) { throw new System.ArgumentNullException("FqdnId cannot be null"); }
            StringBuilder GetTlsStateFqdnServiceURL = new StringBuilder("/infra/tier-1s/{tier-1-id}/tls-inspection-state/fqdns/{fqdn-id}");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Get
            };
            GetTlsStateFqdnServiceURL.Replace("{tier-1-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(Tier1Id, System.Globalization.CultureInfo.InvariantCulture)));
            GetTlsStateFqdnServiceURL.Replace("{fqdn-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(FqdnId, System.Globalization.CultureInfo.InvariantCulture)));
            request.Resource = GetTlsStateFqdnServiceURL.ToString();
            RestResponse<NSXTTlsStateObjectType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTTlsStateObjectType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Get operation to " + GetTlsStateFqdnServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTTlsStateObjectListResultType> ListTlsState(string Tier1Id, string? Cursor = null, bool? FailedDomains = null, string? Fqdn = null, string? IncludedFields = null, long? PageSize = null, bool? SortAscending = null, string? SortBy = null)
        {
            if (Tier1Id == null) { throw new System.ArgumentNullException("Tier1Id cannot be null"); }
            StringBuilder ListTlsStateServiceURL = new StringBuilder("/infra/tier-1s/{tier-1-id}/tls-inspection-state");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Get
            };
            ListTlsStateServiceURL.Replace("{tier-1-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(Tier1Id, System.Globalization.CultureInfo.InvariantCulture)));
            if (Cursor != null) { request.AddQueryParameter("cursor", Cursor.ToString()); }
            if (FailedDomains != null) { request.AddQueryParameter("failed_domains", FailedDomains.ToString()); }
            if (Fqdn != null) { request.AddQueryParameter("fqdn", Fqdn.ToString()); }
            if (IncludedFields != null) { request.AddQueryParameter("included_fields", IncludedFields.ToString()); }
            if (PageSize != null) { request.AddQueryParameter("page_size", PageSize.ToString()); }
            if (SortAscending != null) { request.AddQueryParameter("sort_ascending", SortAscending.ToString()); }
            if (SortBy != null) { request.AddQueryParameter("sort_by", SortBy.ToString()); }
            request.Resource = ListTlsStateServiceURL.ToString();
            RestResponse<NSXTTlsStateObjectListResultType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTTlsStateObjectListResultType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Get operation to " + ListTlsStateServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
    }
}
