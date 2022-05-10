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
    public class PolicyUrlCategorization
    {
        private RestClient restClient;
        private int retry;
        private int timeout;
        private CancellationToken cancellationToken;

        public PolicyUrlCategorization(RestClient Client, CancellationToken _cancellationToken, int _timeout, int _retry)
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
        public async Task<NSXTPolicyUrlCategorizationConfigType> PutPolicyUrlCategorizationConfig(string SiteId, string EnforcementPointId, string EdgeClusterId, string UrlCategorizationConfigId, NSXTPolicyUrlCategorizationConfigType PolicyUrlCategorizationConfig)
        {
            if (SiteId == null) { throw new System.ArgumentNullException("SiteId cannot be null"); }
            if (EnforcementPointId == null) { throw new System.ArgumentNullException("EnforcementPointId cannot be null"); }
            if (EdgeClusterId == null) { throw new System.ArgumentNullException("EdgeClusterId cannot be null"); }
            if (UrlCategorizationConfigId == null) { throw new System.ArgumentNullException("UrlCategorizationConfigId cannot be null"); }
            if (PolicyUrlCategorizationConfig == null) { throw new System.ArgumentNullException("PolicyUrlCategorizationConfig cannot be null"); }
            StringBuilder PutPolicyUrlCategorizationConfigServiceURL = new StringBuilder("/infra/sites/{site-id}/enforcement-points/{enforcement-point-id}/edge-clusters/{edge-cluster-id}/url-categorization-configs/{url-categorization-config-id}");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Put
            };
            PutPolicyUrlCategorizationConfigServiceURL.Replace("{site-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(SiteId, System.Globalization.CultureInfo.InvariantCulture)));
            PutPolicyUrlCategorizationConfigServiceURL.Replace("{enforcement-point-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(EnforcementPointId, System.Globalization.CultureInfo.InvariantCulture)));
            PutPolicyUrlCategorizationConfigServiceURL.Replace("{edge-cluster-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(EdgeClusterId, System.Globalization.CultureInfo.InvariantCulture)));
            PutPolicyUrlCategorizationConfigServiceURL.Replace("{url-categorization-config-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(UrlCategorizationConfigId, System.Globalization.CultureInfo.InvariantCulture)));
            request.AddJsonBody(PolicyUrlCategorizationConfig);
            request.Resource = PutPolicyUrlCategorizationConfigServiceURL.ToString();
            RestResponse<NSXTPolicyUrlCategorizationConfigType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTPolicyUrlCategorizationConfigType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Put operation to " + PutPolicyUrlCategorizationConfigServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task DeletePolicyUrlCategorizationConfig(string SiteId, string EnforcementPointId, string EdgeClusterId, string UrlCategorizationConfigId)
        {
            if (SiteId == null) { throw new System.ArgumentNullException("SiteId cannot be null"); }
            if (EnforcementPointId == null) { throw new System.ArgumentNullException("EnforcementPointId cannot be null"); }
            if (EdgeClusterId == null) { throw new System.ArgumentNullException("EdgeClusterId cannot be null"); }
            if (UrlCategorizationConfigId == null) { throw new System.ArgumentNullException("UrlCategorizationConfigId cannot be null"); }
            StringBuilder DeletePolicyUrlCategorizationConfigServiceURL = new StringBuilder("/infra/sites/{site-id}/enforcement-points/{enforcement-point-id}/edge-clusters/{edge-cluster-id}/url-categorization-configs/{url-categorization-config-id}");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Delete
            };
            DeletePolicyUrlCategorizationConfigServiceURL.Replace("{site-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(SiteId, System.Globalization.CultureInfo.InvariantCulture)));
            DeletePolicyUrlCategorizationConfigServiceURL.Replace("{enforcement-point-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(EnforcementPointId, System.Globalization.CultureInfo.InvariantCulture)));
            DeletePolicyUrlCategorizationConfigServiceURL.Replace("{edge-cluster-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(EdgeClusterId, System.Globalization.CultureInfo.InvariantCulture)));
            DeletePolicyUrlCategorizationConfigServiceURL.Replace("{url-categorization-config-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(UrlCategorizationConfigId, System.Globalization.CultureInfo.InvariantCulture)));
            request.Resource = DeletePolicyUrlCategorizationConfigServiceURL.ToString();
            RestResponse response = await restClient.ExecuteTaskAsyncWithPolicy(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Delete operation to " + DeletePolicyUrlCategorizationConfigServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTPolicyUrlCategorizationConfigType> GetPolicyUrlCategorizationConfig(string SiteId, string EnforcementPointId, string EdgeClusterId, string UrlCategorizationConfigId)
        {
            if (SiteId == null) { throw new System.ArgumentNullException("SiteId cannot be null"); }
            if (EnforcementPointId == null) { throw new System.ArgumentNullException("EnforcementPointId cannot be null"); }
            if (EdgeClusterId == null) { throw new System.ArgumentNullException("EdgeClusterId cannot be null"); }
            if (UrlCategorizationConfigId == null) { throw new System.ArgumentNullException("UrlCategorizationConfigId cannot be null"); }
            StringBuilder GetPolicyUrlCategorizationConfigServiceURL = new StringBuilder("/infra/sites/{site-id}/enforcement-points/{enforcement-point-id}/edge-clusters/{edge-cluster-id}/url-categorization-configs/{url-categorization-config-id}");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Get
            };
            GetPolicyUrlCategorizationConfigServiceURL.Replace("{site-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(SiteId, System.Globalization.CultureInfo.InvariantCulture)));
            GetPolicyUrlCategorizationConfigServiceURL.Replace("{enforcement-point-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(EnforcementPointId, System.Globalization.CultureInfo.InvariantCulture)));
            GetPolicyUrlCategorizationConfigServiceURL.Replace("{edge-cluster-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(EdgeClusterId, System.Globalization.CultureInfo.InvariantCulture)));
            GetPolicyUrlCategorizationConfigServiceURL.Replace("{url-categorization-config-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(UrlCategorizationConfigId, System.Globalization.CultureInfo.InvariantCulture)));
            request.Resource = GetPolicyUrlCategorizationConfigServiceURL.ToString();
            RestResponse<NSXTPolicyUrlCategorizationConfigType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTPolicyUrlCategorizationConfigType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Get operation to " + GetPolicyUrlCategorizationConfigServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTPolicyUrlCategorizationConfigType> PatchPolicyUrlCategorizationConfig(string SiteId, string EnforcementPointId, string EdgeClusterId, string UrlCategorizationConfigId, NSXTPolicyUrlCategorizationConfigType PolicyUrlCategorizationConfig)
        {
            if (SiteId == null) { throw new System.ArgumentNullException("SiteId cannot be null"); }
            if (EnforcementPointId == null) { throw new System.ArgumentNullException("EnforcementPointId cannot be null"); }
            if (EdgeClusterId == null) { throw new System.ArgumentNullException("EdgeClusterId cannot be null"); }
            if (UrlCategorizationConfigId == null) { throw new System.ArgumentNullException("UrlCategorizationConfigId cannot be null"); }
            if (PolicyUrlCategorizationConfig == null) { throw new System.ArgumentNullException("PolicyUrlCategorizationConfig cannot be null"); }
            StringBuilder PatchPolicyUrlCategorizationConfigServiceURL = new StringBuilder("/infra/sites/{site-id}/enforcement-points/{enforcement-point-id}/edge-clusters/{edge-cluster-id}/url-categorization-configs/{url-categorization-config-id}");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Patch
            };
            PatchPolicyUrlCategorizationConfigServiceURL.Replace("{site-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(SiteId, System.Globalization.CultureInfo.InvariantCulture)));
            PatchPolicyUrlCategorizationConfigServiceURL.Replace("{enforcement-point-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(EnforcementPointId, System.Globalization.CultureInfo.InvariantCulture)));
            PatchPolicyUrlCategorizationConfigServiceURL.Replace("{edge-cluster-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(EdgeClusterId, System.Globalization.CultureInfo.InvariantCulture)));
            PatchPolicyUrlCategorizationConfigServiceURL.Replace("{url-categorization-config-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(UrlCategorizationConfigId, System.Globalization.CultureInfo.InvariantCulture)));
            request.AddJsonBody(PolicyUrlCategorizationConfig);
            request.Resource = PatchPolicyUrlCategorizationConfigServiceURL.ToString();
            RestResponse<NSXTPolicyUrlCategorizationConfigType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTPolicyUrlCategorizationConfigType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Patch operation to " + PatchPolicyUrlCategorizationConfigServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTFqdnAnalysisConfigType> PutFqdnAnalysisConfig(string SiteId, string EnforcementPointId, string EdgeClusterId, NSXTFqdnAnalysisConfigType FqdnAnalysisConfig)
        {
            if (SiteId == null) { throw new System.ArgumentNullException("SiteId cannot be null"); }
            if (EnforcementPointId == null) { throw new System.ArgumentNullException("EnforcementPointId cannot be null"); }
            if (EdgeClusterId == null) { throw new System.ArgumentNullException("EdgeClusterId cannot be null"); }
            if (FqdnAnalysisConfig == null) { throw new System.ArgumentNullException("FqdnAnalysisConfig cannot be null"); }
            StringBuilder PutFqdnAnalysisConfigServiceURL = new StringBuilder("/infra/sites/{site-id}/enforcement-points/{enforcement-point-id}/edge-clusters/{edge-cluster-id}/fqdn-analysis-config");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Put
            };
            PutFqdnAnalysisConfigServiceURL.Replace("{site-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(SiteId, System.Globalization.CultureInfo.InvariantCulture)));
            PutFqdnAnalysisConfigServiceURL.Replace("{enforcement-point-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(EnforcementPointId, System.Globalization.CultureInfo.InvariantCulture)));
            PutFqdnAnalysisConfigServiceURL.Replace("{edge-cluster-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(EdgeClusterId, System.Globalization.CultureInfo.InvariantCulture)));
            request.AddJsonBody(FqdnAnalysisConfig);
            request.Resource = PutFqdnAnalysisConfigServiceURL.ToString();
            RestResponse<NSXTFqdnAnalysisConfigType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTFqdnAnalysisConfigType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Put operation to " + PutFqdnAnalysisConfigServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task DeleteFqdnAnalysisConfig(string SiteId, string EnforcementPointId, string EdgeClusterId)
        {
            if (SiteId == null) { throw new System.ArgumentNullException("SiteId cannot be null"); }
            if (EnforcementPointId == null) { throw new System.ArgumentNullException("EnforcementPointId cannot be null"); }
            if (EdgeClusterId == null) { throw new System.ArgumentNullException("EdgeClusterId cannot be null"); }
            StringBuilder DeleteFqdnAnalysisConfigServiceURL = new StringBuilder("/infra/sites/{site-id}/enforcement-points/{enforcement-point-id}/edge-clusters/{edge-cluster-id}/fqdn-analysis-config");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Delete
            };
            DeleteFqdnAnalysisConfigServiceURL.Replace("{site-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(SiteId, System.Globalization.CultureInfo.InvariantCulture)));
            DeleteFqdnAnalysisConfigServiceURL.Replace("{enforcement-point-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(EnforcementPointId, System.Globalization.CultureInfo.InvariantCulture)));
            DeleteFqdnAnalysisConfigServiceURL.Replace("{edge-cluster-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(EdgeClusterId, System.Globalization.CultureInfo.InvariantCulture)));
            request.Resource = DeleteFqdnAnalysisConfigServiceURL.ToString();
            RestResponse response = await restClient.ExecuteTaskAsyncWithPolicy(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Delete operation to " + DeleteFqdnAnalysisConfigServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTFqdnAnalysisConfigType> GetFqdnAnalysisConfig(string SiteId, string EnforcementPointId, string EdgeClusterId)
        {
            if (SiteId == null) { throw new System.ArgumentNullException("SiteId cannot be null"); }
            if (EnforcementPointId == null) { throw new System.ArgumentNullException("EnforcementPointId cannot be null"); }
            if (EdgeClusterId == null) { throw new System.ArgumentNullException("EdgeClusterId cannot be null"); }
            StringBuilder GetFqdnAnalysisConfigServiceURL = new StringBuilder("/infra/sites/{site-id}/enforcement-points/{enforcement-point-id}/edge-clusters/{edge-cluster-id}/fqdn-analysis-config");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Get
            };
            GetFqdnAnalysisConfigServiceURL.Replace("{site-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(SiteId, System.Globalization.CultureInfo.InvariantCulture)));
            GetFqdnAnalysisConfigServiceURL.Replace("{enforcement-point-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(EnforcementPointId, System.Globalization.CultureInfo.InvariantCulture)));
            GetFqdnAnalysisConfigServiceURL.Replace("{edge-cluster-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(EdgeClusterId, System.Globalization.CultureInfo.InvariantCulture)));
            request.Resource = GetFqdnAnalysisConfigServiceURL.ToString();
            RestResponse<NSXTFqdnAnalysisConfigType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTFqdnAnalysisConfigType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Get operation to " + GetFqdnAnalysisConfigServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTFqdnAnalysisConfigType> PatchFqdnAnalysisConfig(string SiteId, string EnforcementPointId, string EdgeClusterId, NSXTFqdnAnalysisConfigType FqdnAnalysisConfig)
        {
            if (SiteId == null) { throw new System.ArgumentNullException("SiteId cannot be null"); }
            if (EnforcementPointId == null) { throw new System.ArgumentNullException("EnforcementPointId cannot be null"); }
            if (EdgeClusterId == null) { throw new System.ArgumentNullException("EdgeClusterId cannot be null"); }
            if (FqdnAnalysisConfig == null) { throw new System.ArgumentNullException("FqdnAnalysisConfig cannot be null"); }
            StringBuilder PatchFqdnAnalysisConfigServiceURL = new StringBuilder("/infra/sites/{site-id}/enforcement-points/{enforcement-point-id}/edge-clusters/{edge-cluster-id}/fqdn-analysis-config");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Patch
            };
            PatchFqdnAnalysisConfigServiceURL.Replace("{site-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(SiteId, System.Globalization.CultureInfo.InvariantCulture)));
            PatchFqdnAnalysisConfigServiceURL.Replace("{enforcement-point-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(EnforcementPointId, System.Globalization.CultureInfo.InvariantCulture)));
            PatchFqdnAnalysisConfigServiceURL.Replace("{edge-cluster-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(EdgeClusterId, System.Globalization.CultureInfo.InvariantCulture)));
            request.AddJsonBody(FqdnAnalysisConfig);
            request.Resource = PatchFqdnAnalysisConfigServiceURL.ToString();
            RestResponse<NSXTFqdnAnalysisConfigType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTFqdnAnalysisConfigType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Patch operation to " + PatchFqdnAnalysisConfigServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTPolicyUrlCategoryListResultType> ListPolicyUrlCategories(string? Cursor = null, bool? IncludeMarkForDeleteObjects = null, string? IncludedFields = null, long? PageSize = null, bool? SortAscending = null, string? SortBy = null)
        {
            StringBuilder ListPolicyUrlCategoriesServiceURL = new StringBuilder("/infra/url-categories");
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
            request.Resource = ListPolicyUrlCategoriesServiceURL.ToString();
            RestResponse<NSXTPolicyUrlCategoryListResultType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTPolicyUrlCategoryListResultType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Get operation to " + ListPolicyUrlCategoriesServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTPolicyUrlReputationSeverityListResultType> ListPolicyUrlReputationSeverities(string? Cursor = null, bool? IncludeMarkForDeleteObjects = null, string? IncludedFields = null, long? PageSize = null, bool? SortAscending = null, string? SortBy = null)
        {
            StringBuilder ListPolicyUrlReputationSeveritiesServiceURL = new StringBuilder("/infra/url-reputation-severities");
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
            request.Resource = ListPolicyUrlReputationSeveritiesServiceURL.ToString();
            RestResponse<NSXTPolicyUrlReputationSeverityListResultType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTPolicyUrlReputationSeverityListResultType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Get operation to " + ListPolicyUrlReputationSeveritiesServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
    }
}
