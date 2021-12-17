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
using nsxtsdk.PolicyModels;

namespace nsxtapi.PolicyModules
{
    public class PolicyLatency
    {
        RestClient restClient;
        JsonSerializerSettings defaultSerializationSettings;
        public PolicyLatency(RestClient Client, JsonSerializerSettings DefaultSerializationSettings)
        {
            restClient = Client;
            defaultSerializationSettings = DefaultSerializationSettings;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public NSXTPolicyLatencyStatProfileType CreateOrReplacePolicyLatencyStatProfile(string ProfileId, NSXTPolicyLatencyStatProfileType PolicyLatencyStatProfile)
        {
            if (ProfileId == null) { throw new System.ArgumentNullException("ProfileId cannot be null"); }
            if (PolicyLatencyStatProfile == null) { throw new System.ArgumentNullException("PolicyLatencyStatProfile cannot be null"); }
            NSXTPolicyLatencyStatProfileType returnValue = default(NSXTPolicyLatencyStatProfileType);
            StringBuilder CreateOrReplacePolicyLatencyStatProfileServiceURL = new StringBuilder("/infra/latency-profiles/{profile-id}");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.PUT
            };
            request.AddHeader("Content-type", "application/json");
            CreateOrReplacePolicyLatencyStatProfileServiceURL.Replace("{profile-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(ProfileId, System.Globalization.CultureInfo.InvariantCulture)));
            request.AddJsonBody(JsonConvert.SerializeObject(PolicyLatencyStatProfile, defaultSerializationSettings));
            request.Resource = CreateOrReplacePolicyLatencyStatProfileServiceURL.ToString();
            var response = restClient.Execute(request);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP PUT operation to " + CreateOrReplacePolicyLatencyStatProfileServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, null);
			}
            else
			{
				try
				{
					returnValue = JsonConvert.DeserializeObject<NSXTPolicyLatencyStatProfileType>(response.Content, defaultSerializationSettings);
				}
				catch (Exception ex)
				{
					var message = "Could not deserialize the response body string as " + typeof(NSXTPolicyLatencyStatProfileType).FullName + ".";
					throw new NSXTException(message, (int)response.StatusCode, response.Content, response.Headers, ex.InnerException);
				}
			}
			return returnValue;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public NSXTPolicyLatencyStatProfileType PatchPolicyLatencyStatProfile(string ProfileId, NSXTPolicyLatencyStatProfileType PolicyLatencyStatProfile)
        {
            if (ProfileId == null) { throw new System.ArgumentNullException("ProfileId cannot be null"); }
            if (PolicyLatencyStatProfile == null) { throw new System.ArgumentNullException("PolicyLatencyStatProfile cannot be null"); }
            NSXTPolicyLatencyStatProfileType returnValue = default(NSXTPolicyLatencyStatProfileType);
            StringBuilder PatchPolicyLatencyStatProfileServiceURL = new StringBuilder("/infra/latency-profiles/{profile-id}");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.PATCH
            };
            request.AddHeader("Content-type", "application/json");
            PatchPolicyLatencyStatProfileServiceURL.Replace("{profile-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(ProfileId, System.Globalization.CultureInfo.InvariantCulture)));
            request.AddJsonBody(JsonConvert.SerializeObject(PolicyLatencyStatProfile, defaultSerializationSettings));
            request.Resource = PatchPolicyLatencyStatProfileServiceURL.ToString();
            var response = restClient.Execute(request);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP PATCH operation to " + PatchPolicyLatencyStatProfileServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, null);
			}
            else
			{
				try
				{
					returnValue = JsonConvert.DeserializeObject<NSXTPolicyLatencyStatProfileType>(response.Content, defaultSerializationSettings);
				}
				catch (Exception ex)
				{
					var message = "Could not deserialize the response body string as " + typeof(NSXTPolicyLatencyStatProfileType).FullName + ".";
					throw new NSXTException(message, (int)response.StatusCode, response.Content, response.Headers, ex.InnerException);
				}
			}
			return returnValue;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public void DeletePolicyLatencyStatProfile(string ProfileId)
        {
            if (ProfileId == null) { throw new System.ArgumentNullException("ProfileId cannot be null"); }
            
            StringBuilder DeletePolicyLatencyStatProfileServiceURL = new StringBuilder("/infra/latency-profiles/{profile-id}");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.DELETE
            };
            request.AddHeader("Content-type", "application/json");
            DeletePolicyLatencyStatProfileServiceURL.Replace("{profile-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(ProfileId, System.Globalization.CultureInfo.InvariantCulture)));
            request.Resource = DeletePolicyLatencyStatProfileServiceURL.ToString();
            var response = restClient.Execute(request);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP DELETE operation to " + DeletePolicyLatencyStatProfileServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, null);
			}
            
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public NSXTPolicyLatencyStatProfileType ReadPolicyLatencyStatProfile(string ProfileId)
        {
            if (ProfileId == null) { throw new System.ArgumentNullException("ProfileId cannot be null"); }
            NSXTPolicyLatencyStatProfileType returnValue = default(NSXTPolicyLatencyStatProfileType);
            StringBuilder ReadPolicyLatencyStatProfileServiceURL = new StringBuilder("/infra/latency-profiles/{profile-id}");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.GET
            };
            request.AddHeader("Content-type", "application/json");
            ReadPolicyLatencyStatProfileServiceURL.Replace("{profile-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(ProfileId, System.Globalization.CultureInfo.InvariantCulture)));
            request.Resource = ReadPolicyLatencyStatProfileServiceURL.ToString();
            var response = restClient.Execute(request);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP GET operation to " + ReadPolicyLatencyStatProfileServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, null);
			}
            else
			{
				try
				{
					returnValue = JsonConvert.DeserializeObject<NSXTPolicyLatencyStatProfileType>(response.Content, defaultSerializationSettings);
				}
				catch (Exception ex)
				{
					var message = "Could not deserialize the response body string as " + typeof(NSXTPolicyLatencyStatProfileType).FullName + ".";
					throw new NSXTException(message, (int)response.StatusCode, response.Content, response.Headers, ex.InnerException);
				}
			}
			return returnValue;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public NSXTPolicyLatencyStatProfileListResultType ListPolicyLatencyProfiles(string? Cursor = null, bool? IncludeMarkForDeleteObjects = null, string? IncludedFields = null, long? PageSize = null, bool? SortAscending = null, string? SortBy = null)
        {
            NSXTPolicyLatencyStatProfileListResultType returnValue = default(NSXTPolicyLatencyStatProfileListResultType);
            StringBuilder ListPolicyLatencyProfilesServiceURL = new StringBuilder("/infra/latency-profiles");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.GET
            };
            request.AddHeader("Content-type", "application/json");
            if (Cursor != null) { request.AddQueryParameter("cursor", Cursor.ToString()); }
            if (IncludeMarkForDeleteObjects != null) { request.AddQueryParameter("include_mark_for_delete_objects", IncludeMarkForDeleteObjects.ToString()); }
            if (IncludedFields != null) { request.AddQueryParameter("included_fields", IncludedFields.ToString()); }
            if (PageSize != null) { request.AddQueryParameter("page_size", PageSize.ToString()); }
            if (SortAscending != null) { request.AddQueryParameter("sort_ascending", SortAscending.ToString()); }
            if (SortBy != null) { request.AddQueryParameter("sort_by", SortBy.ToString()); }
            request.Resource = ListPolicyLatencyProfilesServiceURL.ToString();
            var response = restClient.Execute(request);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP GET operation to " + ListPolicyLatencyProfilesServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, null);
			}
            else
			{
				try
				{
					returnValue = JsonConvert.DeserializeObject<NSXTPolicyLatencyStatProfileListResultType>(response.Content, defaultSerializationSettings);
				}
				catch (Exception ex)
				{
					var message = "Could not deserialize the response body string as " + typeof(NSXTPolicyLatencyStatProfileListResultType).FullName + ".";
					throw new NSXTException(message, (int)response.StatusCode, response.Content, response.Headers, ex.InnerException);
				}
			}
			return returnValue;
        }
    }
}