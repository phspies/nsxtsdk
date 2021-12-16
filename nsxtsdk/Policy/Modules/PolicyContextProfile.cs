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
    public class PolicyContextProfile
    {
        RestClient restClient;
        JsonSerializerSettings defaultSerializationSettings;
        public PolicyContextProfile(RestClient Client, JsonSerializerSettings DefaultSerializationSettings)
        {
            restClient = Client;
            defaultSerializationSettings = DefaultSerializationSettings;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public NSXTPolicyContextProfileListResultType GlobalListProfileSupportedAttributes(string? AttributeKey = null, string? AttributeSource = null, string? Cursor = null, bool? IncludeMarkForDeleteObjects = null, string? IncludedFields = null, long? PageSize = null, bool? SortAscending = null, string? SortBy = null)
        {
            NSXTPolicyContextProfileListResultType returnValue = default(NSXTPolicyContextProfileListResultType);
            StringBuilder ListProfileSupportedAttributesServiceURL = new StringBuilder("/global-infra/context-profiles/attributes");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.GET
            };
            request.AddHeader("Content-type", "application/json");
            if (AttributeKey != null) { request.AddQueryParameter("attribute_key", AttributeKey.ToString()); }
            if (AttributeSource != null) { request.AddQueryParameter("attribute_source", AttributeSource.ToString()); }
            if (Cursor != null) { request.AddQueryParameter("cursor", Cursor.ToString()); }
            if (IncludeMarkForDeleteObjects != null) { request.AddQueryParameter("include_mark_for_delete_objects", IncludeMarkForDeleteObjects.ToString()); }
            if (IncludedFields != null) { request.AddQueryParameter("included_fields", IncludedFields.ToString()); }
            if (PageSize != null) { request.AddQueryParameter("page_size", PageSize.ToString()); }
            if (SortAscending != null) { request.AddQueryParameter("sort_ascending", SortAscending.ToString()); }
            if (SortBy != null) { request.AddQueryParameter("sort_by", SortBy.ToString()); }
            request.Resource = ListProfileSupportedAttributesServiceURL.ToString();
            var response = restClient.Execute(request);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP GET operation to " + ListProfileSupportedAttributesServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, null);
			}
            else
			{
				try
				{
					returnValue = JsonConvert.DeserializeObject<NSXTPolicyContextProfileListResultType>(response.Content, defaultSerializationSettings);
				}
				catch (Exception ex)
				{
					var message = "Could not deserialize the response body string as " + typeof(NSXTPolicyContextProfileListResultType).FullName + ".";
					throw new NSXTException(message, (int)response.StatusCode, response.Content, response.Headers, ex.InnerException);
				}
			}
			return returnValue;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public NSXTPolicyContextProfileListResultType GlobalListPolicyContextProfiles(string? Cursor = null, bool? IncludeMarkForDeleteObjects = null, string? IncludedFields = null, long? PageSize = null, bool? SortAscending = null, string? SortBy = null)
        {
            NSXTPolicyContextProfileListResultType returnValue = default(NSXTPolicyContextProfileListResultType);
            StringBuilder ListPolicyContextProfilesServiceURL = new StringBuilder("/global-infra/context-profiles");
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
            request.Resource = ListPolicyContextProfilesServiceURL.ToString();
            var response = restClient.Execute(request);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP GET operation to " + ListPolicyContextProfilesServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, null);
			}
            else
			{
				try
				{
					returnValue = JsonConvert.DeserializeObject<NSXTPolicyContextProfileListResultType>(response.Content, defaultSerializationSettings);
				}
				catch (Exception ex)
				{
					var message = "Could not deserialize the response body string as " + typeof(NSXTPolicyContextProfileListResultType).FullName + ".";
					throw new NSXTException(message, (int)response.StatusCode, response.Content, response.Headers, ex.InnerException);
				}
			}
			return returnValue;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public void GlobalAddRemoveCustomAttributeValues(NSXTPolicyAttributesType PolicyAttributes, string Action)
        {
            if (PolicyAttributes == null) { throw new System.ArgumentNullException("PolicyAttributes cannot be null"); }
            if (Action == null) { throw new System.ArgumentNullException("Action cannot be null"); }
            
            StringBuilder AddRemoveCustomAttributeValuesServiceURL = new StringBuilder("/global-infra/context-profiles/custom-attributes");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.POST
            };
            request.AddHeader("Content-type", "application/json");
            request.AddJsonBody(JsonConvert.SerializeObject(PolicyAttributes, defaultSerializationSettings));
            if (Action != null) { request.AddQueryParameter("action", Action.ToString()); }
            request.Resource = AddRemoveCustomAttributeValuesServiceURL.ToString();
            var response = restClient.Execute(request);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP POST operation to " + AddRemoveCustomAttributeValuesServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, null);
			}
            
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public void GlobalPatchCustomAttributeList(NSXTPolicyAttributesType PolicyAttributes)
        {
            if (PolicyAttributes == null) { throw new System.ArgumentNullException("PolicyAttributes cannot be null"); }
            
            StringBuilder PatchCustomAttributeListServiceURL = new StringBuilder("/global-infra/context-profiles/custom-attributes");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.PATCH
            };
            request.AddHeader("Content-type", "application/json");
            request.AddJsonBody(JsonConvert.SerializeObject(PolicyAttributes, defaultSerializationSettings));
            request.Resource = PatchCustomAttributeListServiceURL.ToString();
            var response = restClient.Execute(request);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP PATCH operation to " + PatchCustomAttributeListServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, null);
			}
            
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public NSXTPolicyContextProfileType GlobalPutCreateOrUpdatePolicyContextProfile(string ContextProfileId, NSXTPolicyContextProfileType PolicyContextProfile, bool? Override = null)
        {
            if (ContextProfileId == null) { throw new System.ArgumentNullException("ContextProfileId cannot be null"); }
            if (PolicyContextProfile == null) { throw new System.ArgumentNullException("PolicyContextProfile cannot be null"); }
            NSXTPolicyContextProfileType returnValue = default(NSXTPolicyContextProfileType);
            StringBuilder PutCreateOrUpdatePolicyContextProfileServiceURL = new StringBuilder("/global-infra/context-profiles/{context-profile-id}");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.PUT
            };
            request.AddHeader("Content-type", "application/json");
            PutCreateOrUpdatePolicyContextProfileServiceURL.Replace("{context-profile-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(ContextProfileId, System.Globalization.CultureInfo.InvariantCulture)));
            request.AddJsonBody(JsonConvert.SerializeObject(PolicyContextProfile, defaultSerializationSettings));
            if (Override != null) { request.AddQueryParameter("override", Override.ToString()); }
            request.Resource = PutCreateOrUpdatePolicyContextProfileServiceURL.ToString();
            var response = restClient.Execute(request);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP PUT operation to " + PutCreateOrUpdatePolicyContextProfileServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, null);
			}
            else
			{
				try
				{
					returnValue = JsonConvert.DeserializeObject<NSXTPolicyContextProfileType>(response.Content, defaultSerializationSettings);
				}
				catch (Exception ex)
				{
					var message = "Could not deserialize the response body string as " + typeof(NSXTPolicyContextProfileType).FullName + ".";
					throw new NSXTException(message, (int)response.StatusCode, response.Content, response.Headers, ex.InnerException);
				}
			}
			return returnValue;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public void GlobalDeletePolicyContextProfile(string ContextProfileId, bool? Force = null, bool? Override = null)
        {
            if (ContextProfileId == null) { throw new System.ArgumentNullException("ContextProfileId cannot be null"); }
            
            StringBuilder DeletePolicyContextProfileServiceURL = new StringBuilder("/global-infra/context-profiles/{context-profile-id}");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.DELETE
            };
            request.AddHeader("Content-type", "application/json");
            DeletePolicyContextProfileServiceURL.Replace("{context-profile-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(ContextProfileId, System.Globalization.CultureInfo.InvariantCulture)));
            if (Force != null) { request.AddQueryParameter("force", Force.ToString()); }
            if (Override != null) { request.AddQueryParameter("override", Override.ToString()); }
            request.Resource = DeletePolicyContextProfileServiceURL.ToString();
            var response = restClient.Execute(request);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP DELETE operation to " + DeletePolicyContextProfileServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, null);
			}
            
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public void GlobalPatchCreateOrUpdatePolicyContextProfile(string ContextProfileId, NSXTPolicyContextProfileType PolicyContextProfile, bool? Override = null)
        {
            if (ContextProfileId == null) { throw new System.ArgumentNullException("ContextProfileId cannot be null"); }
            if (PolicyContextProfile == null) { throw new System.ArgumentNullException("PolicyContextProfile cannot be null"); }
            
            StringBuilder PatchCreateOrUpdatePolicyContextProfileServiceURL = new StringBuilder("/global-infra/context-profiles/{context-profile-id}");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.PATCH
            };
            request.AddHeader("Content-type", "application/json");
            PatchCreateOrUpdatePolicyContextProfileServiceURL.Replace("{context-profile-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(ContextProfileId, System.Globalization.CultureInfo.InvariantCulture)));
            request.AddJsonBody(JsonConvert.SerializeObject(PolicyContextProfile, defaultSerializationSettings));
            if (Override != null) { request.AddQueryParameter("override", Override.ToString()); }
            request.Resource = PatchCreateOrUpdatePolicyContextProfileServiceURL.ToString();
            var response = restClient.Execute(request);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP PATCH operation to " + PatchCreateOrUpdatePolicyContextProfileServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, null);
			}
            
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public NSXTPolicyContextProfileType GlobalGetPolicyContextProfile(string ContextProfileId)
        {
            if (ContextProfileId == null) { throw new System.ArgumentNullException("ContextProfileId cannot be null"); }
            NSXTPolicyContextProfileType returnValue = default(NSXTPolicyContextProfileType);
            StringBuilder GetPolicyContextProfileServiceURL = new StringBuilder("/global-infra/context-profiles/{context-profile-id}");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.GET
            };
            request.AddHeader("Content-type", "application/json");
            GetPolicyContextProfileServiceURL.Replace("{context-profile-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(ContextProfileId, System.Globalization.CultureInfo.InvariantCulture)));
            request.Resource = GetPolicyContextProfileServiceURL.ToString();
            var response = restClient.Execute(request);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP GET operation to " + GetPolicyContextProfileServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, null);
			}
            else
			{
				try
				{
					returnValue = JsonConvert.DeserializeObject<NSXTPolicyContextProfileType>(response.Content, defaultSerializationSettings);
				}
				catch (Exception ex)
				{
					var message = "Could not deserialize the response body string as " + typeof(NSXTPolicyContextProfileType).FullName + ".";
					throw new NSXTException(message, (int)response.StatusCode, response.Content, response.Headers, ex.InnerException);
				}
			}
			return returnValue;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public NSXTPolicyContextProfileListResultType ListProfileSupportedAttributes(string? AttributeKey = null, string? AttributeSource = null, string? Cursor = null, bool? IncludeMarkForDeleteObjects = null, string? IncludedFields = null, long? PageSize = null, bool? SortAscending = null, string? SortBy = null)
        {
            NSXTPolicyContextProfileListResultType returnValue = default(NSXTPolicyContextProfileListResultType);
            StringBuilder ListProfileSupportedAttributesServiceURL = new StringBuilder("/infra/context-profiles/attributes");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.GET
            };
            request.AddHeader("Content-type", "application/json");
            if (AttributeKey != null) { request.AddQueryParameter("attribute_key", AttributeKey.ToString()); }
            if (AttributeSource != null) { request.AddQueryParameter("attribute_source", AttributeSource.ToString()); }
            if (Cursor != null) { request.AddQueryParameter("cursor", Cursor.ToString()); }
            if (IncludeMarkForDeleteObjects != null) { request.AddQueryParameter("include_mark_for_delete_objects", IncludeMarkForDeleteObjects.ToString()); }
            if (IncludedFields != null) { request.AddQueryParameter("included_fields", IncludedFields.ToString()); }
            if (PageSize != null) { request.AddQueryParameter("page_size", PageSize.ToString()); }
            if (SortAscending != null) { request.AddQueryParameter("sort_ascending", SortAscending.ToString()); }
            if (SortBy != null) { request.AddQueryParameter("sort_by", SortBy.ToString()); }
            request.Resource = ListProfileSupportedAttributesServiceURL.ToString();
            var response = restClient.Execute(request);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP GET operation to " + ListProfileSupportedAttributesServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, null);
			}
            else
			{
				try
				{
					returnValue = JsonConvert.DeserializeObject<NSXTPolicyContextProfileListResultType>(response.Content, defaultSerializationSettings);
				}
				catch (Exception ex)
				{
					var message = "Could not deserialize the response body string as " + typeof(NSXTPolicyContextProfileListResultType).FullName + ".";
					throw new NSXTException(message, (int)response.StatusCode, response.Content, response.Headers, ex.InnerException);
				}
			}
			return returnValue;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public NSXTPolicyContextProfileListResultType ListPolicyContextProfiles(string? Cursor = null, bool? IncludeMarkForDeleteObjects = null, string? IncludedFields = null, long? PageSize = null, bool? SortAscending = null, string? SortBy = null)
        {
            NSXTPolicyContextProfileListResultType returnValue = default(NSXTPolicyContextProfileListResultType);
            StringBuilder ListPolicyContextProfilesServiceURL = new StringBuilder("/infra/context-profiles");
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
            request.Resource = ListPolicyContextProfilesServiceURL.ToString();
            var response = restClient.Execute(request);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP GET operation to " + ListPolicyContextProfilesServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, null);
			}
            else
			{
				try
				{
					returnValue = JsonConvert.DeserializeObject<NSXTPolicyContextProfileListResultType>(response.Content, defaultSerializationSettings);
				}
				catch (Exception ex)
				{
					var message = "Could not deserialize the response body string as " + typeof(NSXTPolicyContextProfileListResultType).FullName + ".";
					throw new NSXTException(message, (int)response.StatusCode, response.Content, response.Headers, ex.InnerException);
				}
			}
			return returnValue;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public NSXTPolicyContextProfileType PutCreateOrUpdatePolicyContextProfile(string ContextProfileId, NSXTPolicyContextProfileType PolicyContextProfile, bool? Override = null)
        {
            if (ContextProfileId == null) { throw new System.ArgumentNullException("ContextProfileId cannot be null"); }
            if (PolicyContextProfile == null) { throw new System.ArgumentNullException("PolicyContextProfile cannot be null"); }
            NSXTPolicyContextProfileType returnValue = default(NSXTPolicyContextProfileType);
            StringBuilder PutCreateOrUpdatePolicyContextProfileServiceURL = new StringBuilder("/infra/context-profiles/{context-profile-id}");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.PUT
            };
            request.AddHeader("Content-type", "application/json");
            PutCreateOrUpdatePolicyContextProfileServiceURL.Replace("{context-profile-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(ContextProfileId, System.Globalization.CultureInfo.InvariantCulture)));
            request.AddJsonBody(JsonConvert.SerializeObject(PolicyContextProfile, defaultSerializationSettings));
            if (Override != null) { request.AddQueryParameter("override", Override.ToString()); }
            request.Resource = PutCreateOrUpdatePolicyContextProfileServiceURL.ToString();
            var response = restClient.Execute(request);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP PUT operation to " + PutCreateOrUpdatePolicyContextProfileServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, null);
			}
            else
			{
				try
				{
					returnValue = JsonConvert.DeserializeObject<NSXTPolicyContextProfileType>(response.Content, defaultSerializationSettings);
				}
				catch (Exception ex)
				{
					var message = "Could not deserialize the response body string as " + typeof(NSXTPolicyContextProfileType).FullName + ".";
					throw new NSXTException(message, (int)response.StatusCode, response.Content, response.Headers, ex.InnerException);
				}
			}
			return returnValue;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public void DeletePolicyContextProfile(string ContextProfileId, bool? Force = null, bool? Override = null)
        {
            if (ContextProfileId == null) { throw new System.ArgumentNullException("ContextProfileId cannot be null"); }
            
            StringBuilder DeletePolicyContextProfileServiceURL = new StringBuilder("/infra/context-profiles/{context-profile-id}");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.DELETE
            };
            request.AddHeader("Content-type", "application/json");
            DeletePolicyContextProfileServiceURL.Replace("{context-profile-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(ContextProfileId, System.Globalization.CultureInfo.InvariantCulture)));
            if (Force != null) { request.AddQueryParameter("force", Force.ToString()); }
            if (Override != null) { request.AddQueryParameter("override", Override.ToString()); }
            request.Resource = DeletePolicyContextProfileServiceURL.ToString();
            var response = restClient.Execute(request);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP DELETE operation to " + DeletePolicyContextProfileServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, null);
			}
            
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public void PatchCreateOrUpdatePolicyContextProfile(string ContextProfileId, NSXTPolicyContextProfileType PolicyContextProfile, bool? Override = null)
        {
            if (ContextProfileId == null) { throw new System.ArgumentNullException("ContextProfileId cannot be null"); }
            if (PolicyContextProfile == null) { throw new System.ArgumentNullException("PolicyContextProfile cannot be null"); }
            
            StringBuilder PatchCreateOrUpdatePolicyContextProfileServiceURL = new StringBuilder("/infra/context-profiles/{context-profile-id}");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.PATCH
            };
            request.AddHeader("Content-type", "application/json");
            PatchCreateOrUpdatePolicyContextProfileServiceURL.Replace("{context-profile-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(ContextProfileId, System.Globalization.CultureInfo.InvariantCulture)));
            request.AddJsonBody(JsonConvert.SerializeObject(PolicyContextProfile, defaultSerializationSettings));
            if (Override != null) { request.AddQueryParameter("override", Override.ToString()); }
            request.Resource = PatchCreateOrUpdatePolicyContextProfileServiceURL.ToString();
            var response = restClient.Execute(request);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP PATCH operation to " + PatchCreateOrUpdatePolicyContextProfileServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, null);
			}
            
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public NSXTPolicyContextProfileType GetPolicyContextProfile(string ContextProfileId)
        {
            if (ContextProfileId == null) { throw new System.ArgumentNullException("ContextProfileId cannot be null"); }
            NSXTPolicyContextProfileType returnValue = default(NSXTPolicyContextProfileType);
            StringBuilder GetPolicyContextProfileServiceURL = new StringBuilder("/infra/context-profiles/{context-profile-id}");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.GET
            };
            request.AddHeader("Content-type", "application/json");
            GetPolicyContextProfileServiceURL.Replace("{context-profile-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(ContextProfileId, System.Globalization.CultureInfo.InvariantCulture)));
            request.Resource = GetPolicyContextProfileServiceURL.ToString();
            var response = restClient.Execute(request);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP GET operation to " + GetPolicyContextProfileServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, null);
			}
            else
			{
				try
				{
					returnValue = JsonConvert.DeserializeObject<NSXTPolicyContextProfileType>(response.Content, defaultSerializationSettings);
				}
				catch (Exception ex)
				{
					var message = "Could not deserialize the response body string as " + typeof(NSXTPolicyContextProfileType).FullName + ".";
					throw new NSXTException(message, (int)response.StatusCode, response.Content, response.Headers, ex.InnerException);
				}
			}
			return returnValue;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public void AddRemoveCustomAttributeValues(NSXTPolicyAttributesType PolicyAttributes, string Action)
        {
            if (PolicyAttributes == null) { throw new System.ArgumentNullException("PolicyAttributes cannot be null"); }
            if (Action == null) { throw new System.ArgumentNullException("Action cannot be null"); }
            
            StringBuilder AddRemoveCustomAttributeValuesServiceURL = new StringBuilder("/infra/context-profiles/custom-attributes");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.POST
            };
            request.AddHeader("Content-type", "application/json");
            request.AddJsonBody(JsonConvert.SerializeObject(PolicyAttributes, defaultSerializationSettings));
            if (Action != null) { request.AddQueryParameter("action", Action.ToString()); }
            request.Resource = AddRemoveCustomAttributeValuesServiceURL.ToString();
            var response = restClient.Execute(request);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP POST operation to " + AddRemoveCustomAttributeValuesServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, null);
			}
            
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public void PatchCustomAttributeList(NSXTPolicyAttributesType PolicyAttributes)
        {
            if (PolicyAttributes == null) { throw new System.ArgumentNullException("PolicyAttributes cannot be null"); }
            
            StringBuilder PatchCustomAttributeListServiceURL = new StringBuilder("/infra/context-profiles/custom-attributes");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.PATCH
            };
            request.AddHeader("Content-type", "application/json");
            request.AddJsonBody(JsonConvert.SerializeObject(PolicyAttributes, defaultSerializationSettings));
            request.Resource = PatchCustomAttributeListServiceURL.ToString();
            var response = restClient.Execute(request);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP PATCH operation to " + PatchCustomAttributeListServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, null);
			}
            
        }
    }
}
