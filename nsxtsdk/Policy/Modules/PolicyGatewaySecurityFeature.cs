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
    public class PolicyGatewaySecurityFeature
    {
        private RestClient restClient;
        private int retry;
        private int timeout;
        private CancellationToken cancellationToken;

        public PolicyGatewaySecurityFeature(RestClient Client, CancellationToken _cancellationToken, int _timeout, int _retry)
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
        public async Task<NSXTSecurityFeaturesType> CreateOrUpdateSecurityFeature(string Tier1Id, NSXTSecurityFeaturesType SecurityFeatures)
        {
            if (Tier1Id == null) { throw new System.ArgumentNullException("Tier1Id cannot be null"); }
            if (SecurityFeatures == null) { throw new System.ArgumentNullException("SecurityFeatures cannot be null"); }
            StringBuilder CreateOrUpdateSecurityFeatureServiceURL = new StringBuilder("/infra/tier-1s/{tier-1-id}/security-config");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Put
            };
            CreateOrUpdateSecurityFeatureServiceURL.Replace("{tier-1-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(Tier1Id, System.Globalization.CultureInfo.InvariantCulture)));
            request.AddJsonBody(SecurityFeatures);
            request.Resource = CreateOrUpdateSecurityFeatureServiceURL.ToString();
            RestResponse<NSXTSecurityFeaturesType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTSecurityFeaturesType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Put operation to " + CreateOrUpdateSecurityFeatureServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTSecurityFeaturesType> PatchSecurityFeature(string Tier1Id, NSXTSecurityFeaturesType SecurityFeatures)
        {
            if (Tier1Id == null) { throw new System.ArgumentNullException("Tier1Id cannot be null"); }
            if (SecurityFeatures == null) { throw new System.ArgumentNullException("SecurityFeatures cannot be null"); }
            StringBuilder PatchSecurityFeatureServiceURL = new StringBuilder("/infra/tier-1s/{tier-1-id}/security-config");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Patch
            };
            PatchSecurityFeatureServiceURL.Replace("{tier-1-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(Tier1Id, System.Globalization.CultureInfo.InvariantCulture)));
            request.AddJsonBody(SecurityFeatures);
            request.Resource = PatchSecurityFeatureServiceURL.ToString();
            RestResponse<NSXTSecurityFeaturesType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTSecurityFeaturesType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Patch operation to " + PatchSecurityFeatureServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTSecurityFeaturesType> ReadSecurityFeature(string Tier1Id, string? Cursor = null, string? Feature = null, string? IncludedFields = null, long? PageSize = null, bool? SortAscending = null, string? SortBy = null)
        {
            if (Tier1Id == null) { throw new System.ArgumentNullException("Tier1Id cannot be null"); }
            StringBuilder ReadSecurityFeatureServiceURL = new StringBuilder("/infra/tier-1s/{tier-1-id}/security-config");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Get
            };
            ReadSecurityFeatureServiceURL.Replace("{tier-1-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(Tier1Id, System.Globalization.CultureInfo.InvariantCulture)));
            if (Cursor != null) { request.AddQueryParameter("cursor", Cursor.ToString()); }
            if (Feature != null) { request.AddQueryParameter("feature", Feature.ToString()); }
            if (IncludedFields != null) { request.AddQueryParameter("included_fields", IncludedFields.ToString()); }
            if (PageSize != null) { request.AddQueryParameter("page_size", PageSize.ToString()); }
            if (SortAscending != null) { request.AddQueryParameter("sort_ascending", SortAscending.ToString()); }
            if (SortBy != null) { request.AddQueryParameter("sort_by", SortBy.ToString()); }
            request.Resource = ReadSecurityFeatureServiceURL.ToString();
            RestResponse<NSXTSecurityFeaturesType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTSecurityFeaturesType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Get operation to " + ReadSecurityFeatureServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTTier0SecurityFeaturesType> CreateOrUpdateTier0SecurityFeature(string Tier0Id, NSXTTier0SecurityFeaturesType Tier0SecurityFeatures)
        {
            if (Tier0Id == null) { throw new System.ArgumentNullException("Tier0Id cannot be null"); }
            if (Tier0SecurityFeatures == null) { throw new System.ArgumentNullException("Tier0SecurityFeatures cannot be null"); }
            StringBuilder CreateOrUpdateTier0SecurityFeatureServiceURL = new StringBuilder("/infra/tier-0s/{tier-0-id}/security-config");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Put
            };
            CreateOrUpdateTier0SecurityFeatureServiceURL.Replace("{tier-0-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(Tier0Id, System.Globalization.CultureInfo.InvariantCulture)));
            request.AddJsonBody(Tier0SecurityFeatures);
            request.Resource = CreateOrUpdateTier0SecurityFeatureServiceURL.ToString();
            RestResponse<NSXTTier0SecurityFeaturesType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTTier0SecurityFeaturesType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Put operation to " + CreateOrUpdateTier0SecurityFeatureServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTTier0SecurityFeaturesType> ReadTier0SecurityFeature(string Tier0Id, string? Cursor = null, string? Feature = null, string? IncludedFields = null, long? PageSize = null, bool? SortAscending = null, string? SortBy = null)
        {
            if (Tier0Id == null) { throw new System.ArgumentNullException("Tier0Id cannot be null"); }
            StringBuilder ReadTier0SecurityFeatureServiceURL = new StringBuilder("/infra/tier-0s/{tier-0-id}/security-config");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Get
            };
            ReadTier0SecurityFeatureServiceURL.Replace("{tier-0-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(Tier0Id, System.Globalization.CultureInfo.InvariantCulture)));
            if (Cursor != null) { request.AddQueryParameter("cursor", Cursor.ToString()); }
            if (Feature != null) { request.AddQueryParameter("feature", Feature.ToString()); }
            if (IncludedFields != null) { request.AddQueryParameter("included_fields", IncludedFields.ToString()); }
            if (PageSize != null) { request.AddQueryParameter("page_size", PageSize.ToString()); }
            if (SortAscending != null) { request.AddQueryParameter("sort_ascending", SortAscending.ToString()); }
            if (SortBy != null) { request.AddQueryParameter("sort_by", SortBy.ToString()); }
            request.Resource = ReadTier0SecurityFeatureServiceURL.ToString();
            RestResponse<NSXTTier0SecurityFeaturesType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTTier0SecurityFeaturesType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Get operation to " + ReadTier0SecurityFeatureServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task DeleteTier0SecurityFeature(string Tier0Id, string? Cursor = null, string? Feature = null, string? IncludedFields = null, long? PageSize = null, bool? SortAscending = null, string? SortBy = null)
        {
            if (Tier0Id == null) { throw new System.ArgumentNullException("Tier0Id cannot be null"); }
            StringBuilder DeleteTier0SecurityFeatureServiceURL = new StringBuilder("/infra/tier-0s/{tier-0-id}/security-config");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Delete
            };
            DeleteTier0SecurityFeatureServiceURL.Replace("{tier-0-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(Tier0Id, System.Globalization.CultureInfo.InvariantCulture)));
            if (Cursor != null) { request.AddQueryParameter("cursor", Cursor.ToString()); }
            if (Feature != null) { request.AddQueryParameter("feature", Feature.ToString()); }
            if (IncludedFields != null) { request.AddQueryParameter("included_fields", IncludedFields.ToString()); }
            if (PageSize != null) { request.AddQueryParameter("page_size", PageSize.ToString()); }
            if (SortAscending != null) { request.AddQueryParameter("sort_ascending", SortAscending.ToString()); }
            if (SortBy != null) { request.AddQueryParameter("sort_by", SortBy.ToString()); }
            request.Resource = DeleteTier0SecurityFeatureServiceURL.ToString();
            RestResponse response = await restClient.ExecuteTaskAsyncWithPolicy(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Delete operation to " + DeleteTier0SecurityFeatureServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTTier0SecurityFeaturesType> PatchTier0SecurityFeature(string Tier0Id, NSXTTier0SecurityFeaturesType Tier0SecurityFeatures)
        {
            if (Tier0Id == null) { throw new System.ArgumentNullException("Tier0Id cannot be null"); }
            if (Tier0SecurityFeatures == null) { throw new System.ArgumentNullException("Tier0SecurityFeatures cannot be null"); }
            StringBuilder PatchTier0SecurityFeatureServiceURL = new StringBuilder("/infra/tier-0s/{tier-0-id}/security-config");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Patch
            };
            PatchTier0SecurityFeatureServiceURL.Replace("{tier-0-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(Tier0Id, System.Globalization.CultureInfo.InvariantCulture)));
            request.AddJsonBody(Tier0SecurityFeatures);
            request.Resource = PatchTier0SecurityFeatureServiceURL.ToString();
            RestResponse<NSXTTier0SecurityFeaturesType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTTier0SecurityFeaturesType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Patch operation to " + PatchTier0SecurityFeatureServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
    }
}
