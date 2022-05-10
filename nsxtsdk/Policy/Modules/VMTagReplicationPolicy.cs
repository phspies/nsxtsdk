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
    public class VMTagReplicationPolicy
    {
        private RestClient restClient;
        private int retry;
        private int timeout;
        private CancellationToken cancellationToken;

        public VMTagReplicationPolicy(RestClient Client, CancellationToken _cancellationToken, int _timeout, int _retry)
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
        public async Task<NSXTVMTagReplicationPolicyListResultType> GlobalGlobalInfraListVmtagReplicationPolicies(string? Cursor = null, bool? IncludeMarkForDeleteObjects = null, string? IncludedFields = null, long? PageSize = null, bool? SortAscending = null, string? SortBy = null)
        {
            StringBuilder GlobalInfraListVmtagReplicationPoliciesServiceURL = new StringBuilder("/global-infra/vm-tag-replication-policies");
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
            request.Resource = GlobalInfraListVmtagReplicationPoliciesServiceURL.ToString();
            RestResponse<NSXTVMTagReplicationPolicyListResultType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTVMTagReplicationPolicyListResultType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Get operation to " + GlobalInfraListVmtagReplicationPoliciesServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTVMTagReplicationPolicyType> GlobalGlobalInfraGetVmtagReplicationPolicy(string Id)
        {
            if (Id == null) { throw new System.ArgumentNullException("Id cannot be null"); }
            StringBuilder GlobalInfraGetVmtagReplicationPolicyServiceURL = new StringBuilder("/global-infra/vm-tag-replication-policies/{id}");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Get
            };
            GlobalInfraGetVmtagReplicationPolicyServiceURL.Replace("{id}", System.Uri.EscapeDataString(Helpers.ConvertToString(Id, System.Globalization.CultureInfo.InvariantCulture)));
            request.Resource = GlobalInfraGetVmtagReplicationPolicyServiceURL.ToString();
            RestResponse<NSXTVMTagReplicationPolicyType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTVMTagReplicationPolicyType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Get operation to " + GlobalInfraGetVmtagReplicationPolicyServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
    }
}
