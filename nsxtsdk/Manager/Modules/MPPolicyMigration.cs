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
    public class MPPolicyMigration
    {
        private RestClient restClient;
        private int retry;
        private int timeout;
        private CancellationToken cancellationToken;

        public MPPolicyMigration(RestClient Client, CancellationToken _cancellationToken, int _timeout, int _retry)
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
        public async Task MigrateMpdataToPolicy(NSXTMpMigrationDataType MpMigrationData)
        {
            if (MpMigrationData == null) { throw new System.ArgumentNullException("MpMigrationData cannot be null"); }
            StringBuilder MigrateMpdataToPolicyServiceURL = new StringBuilder("/migration/mp-to-policy");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Post
            };
            request.AddJsonBody(MpMigrationData);
            request.Resource = MigrateMpdataToPolicyServiceURL.ToString();
            RestResponse response = await restClient.ExecuteTaskAsyncWithPolicy(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Post operation to " + MigrateMpdataToPolicyServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTMPPolicyPromotionHistoryListType> GetMppolicyPromotionHistory()
        {
            StringBuilder GetMppolicyPromotionHistoryServiceURL = new StringBuilder("/migration/mp-policy-promotion/history");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Get
            };
            request.Resource = GetMppolicyPromotionHistoryServiceURL.ToString();
            RestResponse<NSXTMPPolicyPromotionHistoryListType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTMPPolicyPromotionHistoryListType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Get operation to " + GetMppolicyPromotionHistoryServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTMigratedObjectListResultType> ListMigratedResources(string ResourceType, string? Cursor = null, string? IncludedFields = null, long? PageSize = null, string? ResourceId = null, bool? SortAscending = null, string? SortBy = null)
        {
            if (ResourceType == null) { throw new System.ArgumentNullException("ResourceType cannot be null"); }
            StringBuilder ListMigratedResourcesServiceURL = new StringBuilder("/migration/migrated-resources");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Get
            };
            if (Cursor != null) { request.AddQueryParameter("cursor", Cursor.ToString()); }
            if (IncludedFields != null) { request.AddQueryParameter("included_fields", IncludedFields.ToString()); }
            if (PageSize != null) { request.AddQueryParameter("page_size", PageSize.ToString()); }
            if (ResourceId != null) { request.AddQueryParameter("resource_id", ResourceId.ToString()); }
            if (ResourceType != null) { request.AddQueryParameter("resource_type", ResourceType.ToString()); }
            if (SortAscending != null) { request.AddQueryParameter("sort_ascending", SortAscending.ToString()); }
            if (SortBy != null) { request.AddQueryParameter("sort_by", SortBy.ToString()); }
            request.Resource = ListMigratedResourcesServiceURL.ToString();
            RestResponse<NSXTMigratedObjectListResultType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTMigratedObjectListResultType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Get operation to " + ListMigratedResourcesServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTMPPolicyPromotionStateType> GetMppolicyPromotionState()
        {
            StringBuilder GetMppolicyPromotionStateServiceURL = new StringBuilder("/migration/mp-policy-promotion/state");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Get
            };
            request.Resource = GetMppolicyPromotionStateServiceURL.ToString();
            RestResponse<NSXTMPPolicyPromotionStateType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTMPPolicyPromotionStateType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Get operation to " + GetMppolicyPromotionStateServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTMigrationStatsResultType> Mp2PolicyMigrationStats(string? Location = null, bool? PrePromotion = null)
        {
            StringBuilder Mp2PolicyMigrationStatsServiceURL = new StringBuilder("/migration/mp-to-policy/stats");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Get
            };
            if (Location != null) { request.AddQueryParameter("location", Location.ToString()); }
            if (PrePromotion != null) { request.AddQueryParameter("pre_promotion", PrePromotion.ToString()); }
            request.Resource = Mp2PolicyMigrationStatsServiceURL.ToString();
            RestResponse<NSXTMigrationStatsResultType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTMigrationStatsResultType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Get operation to " + Mp2PolicyMigrationStatsServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTFeedBackListResultType> Mp2PolicyMigrationFeedback(string? Cursor = null, string? IncludedFields = null, string? Location = null, string? MpDisplayName = null, string? MpId = null, long? PageSize = null, string? ResourceType = null, bool? SortAscending = null, string? SortBy = null)
        {
            StringBuilder Mp2PolicyMigrationFeedbackServiceURL = new StringBuilder("/migration/mp-to-policy/feedback");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Get
            };
            if (Cursor != null) { request.AddQueryParameter("cursor", Cursor.ToString()); }
            if (IncludedFields != null) { request.AddQueryParameter("included_fields", IncludedFields.ToString()); }
            if (Location != null) { request.AddQueryParameter("location", Location.ToString()); }
            if (MpDisplayName != null) { request.AddQueryParameter("mp_display_name", MpDisplayName.ToString()); }
            if (MpId != null) { request.AddQueryParameter("mp_id", MpId.ToString()); }
            if (PageSize != null) { request.AddQueryParameter("page_size", PageSize.ToString()); }
            if (ResourceType != null) { request.AddQueryParameter("resource_type", ResourceType.ToString()); }
            if (SortAscending != null) { request.AddQueryParameter("sort_ascending", SortAscending.ToString()); }
            if (SortBy != null) { request.AddQueryParameter("sort_by", SortBy.ToString()); }
            request.Resource = Mp2PolicyMigrationFeedbackServiceURL.ToString();
            RestResponse<NSXTFeedBackListResultType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTFeedBackListResultType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Get operation to " + Mp2PolicyMigrationFeedbackServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task CancelPromotion()
        {
            StringBuilder CancelPromotionServiceURL = new StringBuilder("/migration/mp-to-policy/cancel");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Post
            };
            request.Resource = CancelPromotionServiceURL.ToString();
            RestResponse response = await restClient.ExecuteTaskAsyncWithPolicy(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Post operation to " + CancelPromotionServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            
        }
    }
}
