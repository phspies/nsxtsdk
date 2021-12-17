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
    public class PolicyTlsActionProfile
    {
        RestClient restClient;
        JsonSerializerSettings defaultSerializationSettings;
        public PolicyTlsActionProfile(RestClient Client, JsonSerializerSettings DefaultSerializationSettings)
        {
            restClient = Client;
            defaultSerializationSettings = DefaultSerializationSettings;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public NSXTTlsProfileListResultType ListTlsProfiles(string? Cursor = null, bool? IncludeMarkForDeleteObjects = null, string? IncludedFields = null, long? PageSize = null, bool? SortAscending = null, string? SortBy = null)
        {
            NSXTTlsProfileListResultType returnValue = default(NSXTTlsProfileListResultType);
            StringBuilder ListTlsProfilesServiceURL = new StringBuilder("/infra/tls-inspection-action-profiles");
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
            request.Resource = ListTlsProfilesServiceURL.ToString();
            var response = restClient.Execute(request);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP GET operation to " + ListTlsProfilesServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, null);
			}
            else
			{
				try
				{
					returnValue = JsonConvert.DeserializeObject<NSXTTlsProfileListResultType>(response.Content, defaultSerializationSettings);
				}
				catch (Exception ex)
				{
					var message = "Could not deserialize the response body string as " + typeof(NSXTTlsProfileListResultType).FullName + ".";
					throw new NSXTException(message, (int)response.StatusCode, response.Content, response.Headers, ex.InnerException);
				}
			}
			return returnValue;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public NSXTTlsProfileType CreateOrUpdateTlsProfile(string ActionProfileId, NSXTTlsProfileType TlsProfile)
        {
            if (ActionProfileId == null) { throw new System.ArgumentNullException("ActionProfileId cannot be null"); }
            if (TlsProfile == null) { throw new System.ArgumentNullException("TlsProfile cannot be null"); }
            NSXTTlsProfileType returnValue = default(NSXTTlsProfileType);
            StringBuilder CreateOrUpdateTlsProfileServiceURL = new StringBuilder("/infra/tls-inspection-action-profiles/{action-profile-id}");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.PUT
            };
            request.AddHeader("Content-type", "application/json");
            CreateOrUpdateTlsProfileServiceURL.Replace("{action-profile-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(ActionProfileId, System.Globalization.CultureInfo.InvariantCulture)));
            request.AddJsonBody(JsonConvert.SerializeObject(TlsProfile, defaultSerializationSettings));
            request.Resource = CreateOrUpdateTlsProfileServiceURL.ToString();
            var response = restClient.Execute(request);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP PUT operation to " + CreateOrUpdateTlsProfileServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, null);
			}
            else
			{
				try
				{
					returnValue = JsonConvert.DeserializeObject<NSXTTlsProfileType>(response.Content, defaultSerializationSettings);
				}
				catch (Exception ex)
				{
					var message = "Could not deserialize the response body string as " + typeof(NSXTTlsProfileType).FullName + ".";
					throw new NSXTException(message, (int)response.StatusCode, response.Content, response.Headers, ex.InnerException);
				}
			}
			return returnValue;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public NSXTTlsProfileType GetTlsProfile(string ActionProfileId)
        {
            if (ActionProfileId == null) { throw new System.ArgumentNullException("ActionProfileId cannot be null"); }
            NSXTTlsProfileType returnValue = default(NSXTTlsProfileType);
            StringBuilder GetTlsProfileServiceURL = new StringBuilder("/infra/tls-inspection-action-profiles/{action-profile-id}");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.GET
            };
            request.AddHeader("Content-type", "application/json");
            GetTlsProfileServiceURL.Replace("{action-profile-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(ActionProfileId, System.Globalization.CultureInfo.InvariantCulture)));
            request.Resource = GetTlsProfileServiceURL.ToString();
            var response = restClient.Execute(request);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP GET operation to " + GetTlsProfileServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, null);
			}
            else
			{
				try
				{
					returnValue = JsonConvert.DeserializeObject<NSXTTlsProfileType>(response.Content, defaultSerializationSettings);
				}
				catch (Exception ex)
				{
					var message = "Could not deserialize the response body string as " + typeof(NSXTTlsProfileType).FullName + ".";
					throw new NSXTException(message, (int)response.StatusCode, response.Content, response.Headers, ex.InnerException);
				}
			}
			return returnValue;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public void DeleteTlsProfile(string ActionProfileId)
        {
            if (ActionProfileId == null) { throw new System.ArgumentNullException("ActionProfileId cannot be null"); }
            
            StringBuilder DeleteTlsProfileServiceURL = new StringBuilder("/infra/tls-inspection-action-profiles/{action-profile-id}");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.DELETE
            };
            request.AddHeader("Content-type", "application/json");
            DeleteTlsProfileServiceURL.Replace("{action-profile-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(ActionProfileId, System.Globalization.CultureInfo.InvariantCulture)));
            request.Resource = DeleteTlsProfileServiceURL.ToString();
            var response = restClient.Execute(request);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP DELETE operation to " + DeleteTlsProfileServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, null);
			}
            
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public NSXTTlsProfileType PatchTlsProfile(string ActionProfileId, NSXTTlsProfileType TlsProfile)
        {
            if (ActionProfileId == null) { throw new System.ArgumentNullException("ActionProfileId cannot be null"); }
            if (TlsProfile == null) { throw new System.ArgumentNullException("TlsProfile cannot be null"); }
            NSXTTlsProfileType returnValue = default(NSXTTlsProfileType);
            StringBuilder PatchTlsProfileServiceURL = new StringBuilder("/infra/tls-inspection-action-profiles/{action-profile-id}");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.PATCH
            };
            request.AddHeader("Content-type", "application/json");
            PatchTlsProfileServiceURL.Replace("{action-profile-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(ActionProfileId, System.Globalization.CultureInfo.InvariantCulture)));
            request.AddJsonBody(JsonConvert.SerializeObject(TlsProfile, defaultSerializationSettings));
            request.Resource = PatchTlsProfileServiceURL.ToString();
            var response = restClient.Execute(request);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP PATCH operation to " + PatchTlsProfileServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, null);
			}
            else
			{
				try
				{
					returnValue = JsonConvert.DeserializeObject<NSXTTlsProfileType>(response.Content, defaultSerializationSettings);
				}
				catch (Exception ex)
				{
					var message = "Could not deserialize the response body string as " + typeof(NSXTTlsProfileType).FullName + ".";
					throw new NSXTException(message, (int)response.StatusCode, response.Content, response.Headers, ex.InnerException);
				}
			}
			return returnValue;
        }
    }
}
