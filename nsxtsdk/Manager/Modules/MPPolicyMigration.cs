// <auto-generated>
// Changes may cause incorrect behavior and will be lost if the code is regenerated.
// </auto-generated>

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
        RestClient restClient;
        JsonSerializerSettings defaultSerializationSettings;
        public MPPolicyMigration(RestClient Client, JsonSerializerSettings DefaultSerializationSettings)
        {
            restClient = Client;
            defaultSerializationSettings = DefaultSerializationSettings;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public void MigrateMpdataToPolicy(NSXTMpMigrationDataType MpMigrationData)
        {
            if (MpMigrationData == null) { throw new System.ArgumentNullException("MpMigrationData cannot be null"); }
            
            StringBuilder MigrateMpdataToPolicyServiceURL = new StringBuilder("/migration/mp-to-policy");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.POST
            };
            request.AddHeader("Content-type", "application/json");
            request.AddJsonBody(JsonConvert.SerializeObject(MpMigrationData, defaultSerializationSettings));
            request.Resource = MigrateMpdataToPolicyServiceURL.ToString();
            var response = restClient.Execute(request);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP POST operation to " + MigrateMpdataToPolicyServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, null);
			}
            
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public NSXTMPPolicyPromotionHistoryListType GetMppolicyPromotionHistory()
        {
            NSXTMPPolicyPromotionHistoryListType returnValue = default(NSXTMPPolicyPromotionHistoryListType);
            StringBuilder GetMppolicyPromotionHistoryServiceURL = new StringBuilder("/migration/mp-policy-promotion/history");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.GET
            };
            request.AddHeader("Content-type", "application/json");
            request.Resource = GetMppolicyPromotionHistoryServiceURL.ToString();
            var response = restClient.Execute(request);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP GET operation to " + GetMppolicyPromotionHistoryServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, null);
			}
            else
			{
				try
				{
					returnValue = JsonConvert.DeserializeObject<NSXTMPPolicyPromotionHistoryListType>(response.Content, defaultSerializationSettings);
				}
				catch (Exception ex)
				{
					var message = "Could not deserialize the response body string as " + typeof(NSXTMPPolicyPromotionHistoryListType).FullName + ".";
					throw new NSXTException(message, (int)response.StatusCode, response.Content, response.Headers, ex.InnerException);
				}
			}
			return returnValue;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public NSXTMigratedObjectListResultType ListMigratedResources(string ResourceType, string? Cursor = null, string? IncludedFields = null, long? PageSize = null, string? ResourceId = null, bool? SortAscending = null, string? SortBy = null)
        {
            if (ResourceType == null) { throw new System.ArgumentNullException("ResourceType cannot be null"); }
            NSXTMigratedObjectListResultType returnValue = default(NSXTMigratedObjectListResultType);
            StringBuilder ListMigratedResourcesServiceURL = new StringBuilder("/migration/migrated-resources");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.GET
            };
            request.AddHeader("Content-type", "application/json");
            if (Cursor != null) { request.AddQueryParameter("cursor", Cursor.ToString()); }
            if (IncludedFields != null) { request.AddQueryParameter("included_fields", IncludedFields.ToString()); }
            if (PageSize != null) { request.AddQueryParameter("page_size", PageSize.ToString()); }
            if (ResourceId != null) { request.AddQueryParameter("resource_id", ResourceId.ToString()); }
            if (ResourceType != null) { request.AddQueryParameter("resource_type", ResourceType.ToString()); }
            if (SortAscending != null) { request.AddQueryParameter("sort_ascending", SortAscending.ToString()); }
            if (SortBy != null) { request.AddQueryParameter("sort_by", SortBy.ToString()); }
            request.Resource = ListMigratedResourcesServiceURL.ToString();
            var response = restClient.Execute(request);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP GET operation to " + ListMigratedResourcesServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, null);
			}
            else
			{
				try
				{
					returnValue = JsonConvert.DeserializeObject<NSXTMigratedObjectListResultType>(response.Content, defaultSerializationSettings);
				}
				catch (Exception ex)
				{
					var message = "Could not deserialize the response body string as " + typeof(NSXTMigratedObjectListResultType).FullName + ".";
					throw new NSXTException(message, (int)response.StatusCode, response.Content, response.Headers, ex.InnerException);
				}
			}
			return returnValue;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public NSXTMPPolicyPromotionStateType GetMppolicyPromotionState()
        {
            NSXTMPPolicyPromotionStateType returnValue = default(NSXTMPPolicyPromotionStateType);
            StringBuilder GetMppolicyPromotionStateServiceURL = new StringBuilder("/migration/mp-policy-promotion/state");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.GET
            };
            request.AddHeader("Content-type", "application/json");
            request.Resource = GetMppolicyPromotionStateServiceURL.ToString();
            var response = restClient.Execute(request);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP GET operation to " + GetMppolicyPromotionStateServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, null);
			}
            else
			{
				try
				{
					returnValue = JsonConvert.DeserializeObject<NSXTMPPolicyPromotionStateType>(response.Content, defaultSerializationSettings);
				}
				catch (Exception ex)
				{
					var message = "Could not deserialize the response body string as " + typeof(NSXTMPPolicyPromotionStateType).FullName + ".";
					throw new NSXTException(message, (int)response.StatusCode, response.Content, response.Headers, ex.InnerException);
				}
			}
			return returnValue;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public NSXTMigrationStatsResultType Mp2PolicyMigrationStats(string? Location = null, bool? PrePromotion = null)
        {
            NSXTMigrationStatsResultType returnValue = default(NSXTMigrationStatsResultType);
            StringBuilder Mp2PolicyMigrationStatsServiceURL = new StringBuilder("/migration/mp-to-policy/stats");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.GET
            };
            request.AddHeader("Content-type", "application/json");
            if (Location != null) { request.AddQueryParameter("location", Location.ToString()); }
            if (PrePromotion != null) { request.AddQueryParameter("pre_promotion", PrePromotion.ToString()); }
            request.Resource = Mp2PolicyMigrationStatsServiceURL.ToString();
            var response = restClient.Execute(request);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP GET operation to " + Mp2PolicyMigrationStatsServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, null);
			}
            else
			{
				try
				{
					returnValue = JsonConvert.DeserializeObject<NSXTMigrationStatsResultType>(response.Content, defaultSerializationSettings);
				}
				catch (Exception ex)
				{
					var message = "Could not deserialize the response body string as " + typeof(NSXTMigrationStatsResultType).FullName + ".";
					throw new NSXTException(message, (int)response.StatusCode, response.Content, response.Headers, ex.InnerException);
				}
			}
			return returnValue;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public NSXTFeedBackListResultType Mp2PolicyMigrationFeedback(string? Cursor = null, string? IncludedFields = null, string? Location = null, string? MpDisplayName = null, string? MpId = null, long? PageSize = null, string? ResourceType = null, bool? SortAscending = null, string? SortBy = null)
        {
            NSXTFeedBackListResultType returnValue = default(NSXTFeedBackListResultType);
            StringBuilder Mp2PolicyMigrationFeedbackServiceURL = new StringBuilder("/migration/mp-to-policy/feedback");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.GET
            };
            request.AddHeader("Content-type", "application/json");
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
            var response = restClient.Execute(request);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP GET operation to " + Mp2PolicyMigrationFeedbackServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, null);
			}
            else
			{
				try
				{
					returnValue = JsonConvert.DeserializeObject<NSXTFeedBackListResultType>(response.Content, defaultSerializationSettings);
				}
				catch (Exception ex)
				{
					var message = "Could not deserialize the response body string as " + typeof(NSXTFeedBackListResultType).FullName + ".";
					throw new NSXTException(message, (int)response.StatusCode, response.Content, response.Headers, ex.InnerException);
				}
			}
			return returnValue;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public void CancelPromotion()
        {
            
            StringBuilder CancelPromotionServiceURL = new StringBuilder("/migration/mp-to-policy/cancel");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.POST
            };
            request.AddHeader("Content-type", "application/json");
            request.Resource = CancelPromotionServiceURL.ToString();
            var response = restClient.Execute(request);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP POST operation to " + CancelPromotionServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, null);
			}
            
        }
    }
}
