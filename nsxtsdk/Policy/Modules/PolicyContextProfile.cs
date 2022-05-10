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
        private RestClient restClient;
        private int retry;
        private int timeout;
        private CancellationToken cancellationToken;

        public PolicyContextProfile(RestClient Client, CancellationToken _cancellationToken, int _timeout, int _retry)
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
        public async Task<NSXTPolicyContextProfileListResultType> GlobalGlobalInfraListProfileSupportedAttributes(string? AttributeKey = null, string? AttributeSource = null, string? Cursor = null, bool? IncludeMarkForDeleteObjects = null, string? IncludedFields = null, long? PageSize = null, bool? SortAscending = null, string? SortBy = null)
        {
            StringBuilder GlobalInfraListProfileSupportedAttributesServiceURL = new StringBuilder("/global-infra/context-profiles/attributes");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Get
            };
            if (AttributeKey != null) { request.AddQueryParameter("attribute_key", AttributeKey.ToString()); }
            if (AttributeSource != null) { request.AddQueryParameter("attribute_source", AttributeSource.ToString()); }
            if (Cursor != null) { request.AddQueryParameter("cursor", Cursor.ToString()); }
            if (IncludeMarkForDeleteObjects != null) { request.AddQueryParameter("include_mark_for_delete_objects", IncludeMarkForDeleteObjects.ToString()); }
            if (IncludedFields != null) { request.AddQueryParameter("included_fields", IncludedFields.ToString()); }
            if (PageSize != null) { request.AddQueryParameter("page_size", PageSize.ToString()); }
            if (SortAscending != null) { request.AddQueryParameter("sort_ascending", SortAscending.ToString()); }
            if (SortBy != null) { request.AddQueryParameter("sort_by", SortBy.ToString()); }
            request.Resource = GlobalInfraListProfileSupportedAttributesServiceURL.ToString();
            RestResponse<NSXTPolicyContextProfileListResultType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTPolicyContextProfileListResultType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Get operation to " + GlobalInfraListProfileSupportedAttributesServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTPolicyContextProfileListResultType> GlobalGlobalInfraListPolicyContextProfiles(string? Cursor = null, bool? IncludeMarkForDeleteObjects = null, string? IncludedFields = null, long? PageSize = null, bool? SortAscending = null, string? SortBy = null)
        {
            StringBuilder GlobalInfraListPolicyContextProfilesServiceURL = new StringBuilder("/global-infra/context-profiles");
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
            request.Resource = GlobalInfraListPolicyContextProfilesServiceURL.ToString();
            RestResponse<NSXTPolicyContextProfileListResultType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTPolicyContextProfileListResultType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Get operation to " + GlobalInfraListPolicyContextProfilesServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task GlobalGlobalInfraAddRemoveCustomAttributeValues(NSXTPolicyAttributesType PolicyAttributes, string Action)
        {
            if (PolicyAttributes == null) { throw new System.ArgumentNullException("PolicyAttributes cannot be null"); }
            if (Action == null) { throw new System.ArgumentNullException("Action cannot be null"); }
            StringBuilder GlobalInfraAddRemoveCustomAttributeValuesServiceURL = new StringBuilder("/global-infra/context-profiles/custom-attributes");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Post
            };
            request.AddJsonBody(PolicyAttributes);
            if (Action != null) { request.AddQueryParameter("action", Action.ToString()); }
            request.Resource = GlobalInfraAddRemoveCustomAttributeValuesServiceURL.ToString();
            RestResponse response = await restClient.ExecuteTaskAsyncWithPolicy(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Post operation to " + GlobalInfraAddRemoveCustomAttributeValuesServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task GlobalGlobalInfraPatchCustomAttributeList(NSXTPolicyAttributesType PolicyAttributes)
        {
            if (PolicyAttributes == null) { throw new System.ArgumentNullException("PolicyAttributes cannot be null"); }
            StringBuilder GlobalInfraPatchCustomAttributeListServiceURL = new StringBuilder("/global-infra/context-profiles/custom-attributes");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Patch
            };
            request.AddJsonBody(PolicyAttributes);
            request.Resource = GlobalInfraPatchCustomAttributeListServiceURL.ToString();
            RestResponse response = await restClient.ExecuteTaskAsyncWithPolicy(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Patch operation to " + GlobalInfraPatchCustomAttributeListServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTPolicyContextProfileListResultType> ListProfileSupportedAttributes(string? AttributeKey = null, string? AttributeSource = null, string? Cursor = null, bool? IncludeMarkForDeleteObjects = null, string? IncludedFields = null, long? PageSize = null, bool? SortAscending = null, string? SortBy = null)
        {
            StringBuilder ListProfileSupportedAttributesServiceURL = new StringBuilder("/infra/context-profiles/attributes");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Get
            };
            if (AttributeKey != null) { request.AddQueryParameter("attribute_key", AttributeKey.ToString()); }
            if (AttributeSource != null) { request.AddQueryParameter("attribute_source", AttributeSource.ToString()); }
            if (Cursor != null) { request.AddQueryParameter("cursor", Cursor.ToString()); }
            if (IncludeMarkForDeleteObjects != null) { request.AddQueryParameter("include_mark_for_delete_objects", IncludeMarkForDeleteObjects.ToString()); }
            if (IncludedFields != null) { request.AddQueryParameter("included_fields", IncludedFields.ToString()); }
            if (PageSize != null) { request.AddQueryParameter("page_size", PageSize.ToString()); }
            if (SortAscending != null) { request.AddQueryParameter("sort_ascending", SortAscending.ToString()); }
            if (SortBy != null) { request.AddQueryParameter("sort_by", SortBy.ToString()); }
            request.Resource = ListProfileSupportedAttributesServiceURL.ToString();
            RestResponse<NSXTPolicyContextProfileListResultType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTPolicyContextProfileListResultType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Get operation to " + ListProfileSupportedAttributesServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task AddRemoveCustomAttribute(NSXTPolicyCustomAttributesType PolicyCustomAttributes, string Action)
        {
            if (PolicyCustomAttributes == null) { throw new System.ArgumentNullException("PolicyCustomAttributes cannot be null"); }
            if (Action == null) { throw new System.ArgumentNullException("Action cannot be null"); }
            StringBuilder AddRemoveCustomAttributeServiceURL = new StringBuilder("/infra/context-profiles/custom-attributes/default");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Post
            };
            request.AddJsonBody(PolicyCustomAttributes);
            if (Action != null) { request.AddQueryParameter("action", Action.ToString()); }
            request.Resource = AddRemoveCustomAttributeServiceURL.ToString();
            RestResponse response = await restClient.ExecuteTaskAsyncWithPolicy(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Post operation to " + AddRemoveCustomAttributeServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task PatchCustomAttribute(NSXTPolicyCustomAttributesType PolicyCustomAttributes)
        {
            if (PolicyCustomAttributes == null) { throw new System.ArgumentNullException("PolicyCustomAttributes cannot be null"); }
            StringBuilder PatchCustomAttributeServiceURL = new StringBuilder("/infra/context-profiles/custom-attributes/default");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Patch
            };
            request.AddJsonBody(PolicyCustomAttributes);
            request.Resource = PatchCustomAttributeServiceURL.ToString();
            RestResponse response = await restClient.ExecuteTaskAsyncWithPolicy(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Patch operation to " + PatchCustomAttributeServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTPolicyContextProfileListResultType> GetCustomAttribute(string? AttributeKey = null, string? AttributeSource = null, string? Cursor = null, bool? IncludeMarkForDeleteObjects = null, string? IncludedFields = null, long? PageSize = null, bool? SortAscending = null, string? SortBy = null)
        {
            StringBuilder GetCustomAttributeServiceURL = new StringBuilder("/infra/context-profiles/custom-attributes/default");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Get
            };
            if (AttributeKey != null) { request.AddQueryParameter("attribute_key", AttributeKey.ToString()); }
            if (AttributeSource != null) { request.AddQueryParameter("attribute_source", AttributeSource.ToString()); }
            if (Cursor != null) { request.AddQueryParameter("cursor", Cursor.ToString()); }
            if (IncludeMarkForDeleteObjects != null) { request.AddQueryParameter("include_mark_for_delete_objects", IncludeMarkForDeleteObjects.ToString()); }
            if (IncludedFields != null) { request.AddQueryParameter("included_fields", IncludedFields.ToString()); }
            if (PageSize != null) { request.AddQueryParameter("page_size", PageSize.ToString()); }
            if (SortAscending != null) { request.AddQueryParameter("sort_ascending", SortAscending.ToString()); }
            if (SortBy != null) { request.AddQueryParameter("sort_by", SortBy.ToString()); }
            request.Resource = GetCustomAttributeServiceURL.ToString();
            RestResponse<NSXTPolicyContextProfileListResultType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTPolicyContextProfileListResultType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Get operation to " + GetCustomAttributeServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTPolicyContextProfileType> GlobalGlobalInfraPutCreateOrUpdatePolicyContextProfile(string ContextProfileId, NSXTPolicyContextProfileType PolicyContextProfile, bool? Override = null)
        {
            if (ContextProfileId == null) { throw new System.ArgumentNullException("ContextProfileId cannot be null"); }
            if (PolicyContextProfile == null) { throw new System.ArgumentNullException("PolicyContextProfile cannot be null"); }
            StringBuilder GlobalInfraPutCreateOrUpdatePolicyContextProfileServiceURL = new StringBuilder("/global-infra/context-profiles/{context-profile-id}");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Put
            };
            GlobalInfraPutCreateOrUpdatePolicyContextProfileServiceURL.Replace("{context-profile-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(ContextProfileId, System.Globalization.CultureInfo.InvariantCulture)));
            request.AddJsonBody(PolicyContextProfile);
            if (Override != null) { request.AddQueryParameter("override", Override.ToString()); }
            request.Resource = GlobalInfraPutCreateOrUpdatePolicyContextProfileServiceURL.ToString();
            RestResponse<NSXTPolicyContextProfileType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTPolicyContextProfileType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Put operation to " + GlobalInfraPutCreateOrUpdatePolicyContextProfileServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task GlobalGlobalInfraDeletePolicyContextProfile(string ContextProfileId, bool? Force = null, bool? Override = null)
        {
            if (ContextProfileId == null) { throw new System.ArgumentNullException("ContextProfileId cannot be null"); }
            StringBuilder GlobalInfraDeletePolicyContextProfileServiceURL = new StringBuilder("/global-infra/context-profiles/{context-profile-id}");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Delete
            };
            GlobalInfraDeletePolicyContextProfileServiceURL.Replace("{context-profile-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(ContextProfileId, System.Globalization.CultureInfo.InvariantCulture)));
            if (Force != null) { request.AddQueryParameter("force", Force.ToString()); }
            if (Override != null) { request.AddQueryParameter("override", Override.ToString()); }
            request.Resource = GlobalInfraDeletePolicyContextProfileServiceURL.ToString();
            RestResponse response = await restClient.ExecuteTaskAsyncWithPolicy(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Delete operation to " + GlobalInfraDeletePolicyContextProfileServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task GlobalGlobalInfraPatchCreateOrUpdatePolicyContextProfile(string ContextProfileId, NSXTPolicyContextProfileType PolicyContextProfile, bool? Override = null)
        {
            if (ContextProfileId == null) { throw new System.ArgumentNullException("ContextProfileId cannot be null"); }
            if (PolicyContextProfile == null) { throw new System.ArgumentNullException("PolicyContextProfile cannot be null"); }
            StringBuilder GlobalInfraPatchCreateOrUpdatePolicyContextProfileServiceURL = new StringBuilder("/global-infra/context-profiles/{context-profile-id}");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Patch
            };
            GlobalInfraPatchCreateOrUpdatePolicyContextProfileServiceURL.Replace("{context-profile-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(ContextProfileId, System.Globalization.CultureInfo.InvariantCulture)));
            request.AddJsonBody(PolicyContextProfile);
            if (Override != null) { request.AddQueryParameter("override", Override.ToString()); }
            request.Resource = GlobalInfraPatchCreateOrUpdatePolicyContextProfileServiceURL.ToString();
            RestResponse response = await restClient.ExecuteTaskAsyncWithPolicy(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Patch operation to " + GlobalInfraPatchCreateOrUpdatePolicyContextProfileServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTPolicyContextProfileType> GlobalGlobalInfraGetPolicyContextProfile(string ContextProfileId)
        {
            if (ContextProfileId == null) { throw new System.ArgumentNullException("ContextProfileId cannot be null"); }
            StringBuilder GlobalInfraGetPolicyContextProfileServiceURL = new StringBuilder("/global-infra/context-profiles/{context-profile-id}");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Get
            };
            GlobalInfraGetPolicyContextProfileServiceURL.Replace("{context-profile-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(ContextProfileId, System.Globalization.CultureInfo.InvariantCulture)));
            request.Resource = GlobalInfraGetPolicyContextProfileServiceURL.ToString();
            RestResponse<NSXTPolicyContextProfileType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTPolicyContextProfileType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Get operation to " + GlobalInfraGetPolicyContextProfileServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTPolicyContextProfileListResultType> ListPolicyContextProfiles(string? Cursor = null, bool? IncludeMarkForDeleteObjects = null, string? IncludedFields = null, long? PageSize = null, bool? SortAscending = null, string? SortBy = null)
        {
            StringBuilder ListPolicyContextProfilesServiceURL = new StringBuilder("/infra/context-profiles");
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
            request.Resource = ListPolicyContextProfilesServiceURL.ToString();
            RestResponse<NSXTPolicyContextProfileListResultType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTPolicyContextProfileListResultType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Get operation to " + ListPolicyContextProfilesServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTPolicyContextProfileType> PutCreateOrUpdatePolicyContextProfile(string ContextProfileId, NSXTPolicyContextProfileType PolicyContextProfile, bool? Override = null)
        {
            if (ContextProfileId == null) { throw new System.ArgumentNullException("ContextProfileId cannot be null"); }
            if (PolicyContextProfile == null) { throw new System.ArgumentNullException("PolicyContextProfile cannot be null"); }
            StringBuilder PutCreateOrUpdatePolicyContextProfileServiceURL = new StringBuilder("/infra/context-profiles/{context-profile-id}");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Put
            };
            PutCreateOrUpdatePolicyContextProfileServiceURL.Replace("{context-profile-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(ContextProfileId, System.Globalization.CultureInfo.InvariantCulture)));
            request.AddJsonBody(PolicyContextProfile);
            if (Override != null) { request.AddQueryParameter("override", Override.ToString()); }
            request.Resource = PutCreateOrUpdatePolicyContextProfileServiceURL.ToString();
            RestResponse<NSXTPolicyContextProfileType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTPolicyContextProfileType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Put operation to " + PutCreateOrUpdatePolicyContextProfileServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task DeletePolicyContextProfile(string ContextProfileId, bool? Force = null, bool? Override = null)
        {
            if (ContextProfileId == null) { throw new System.ArgumentNullException("ContextProfileId cannot be null"); }
            StringBuilder DeletePolicyContextProfileServiceURL = new StringBuilder("/infra/context-profiles/{context-profile-id}");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Delete
            };
            DeletePolicyContextProfileServiceURL.Replace("{context-profile-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(ContextProfileId, System.Globalization.CultureInfo.InvariantCulture)));
            if (Force != null) { request.AddQueryParameter("force", Force.ToString()); }
            if (Override != null) { request.AddQueryParameter("override", Override.ToString()); }
            request.Resource = DeletePolicyContextProfileServiceURL.ToString();
            RestResponse response = await restClient.ExecuteTaskAsyncWithPolicy(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Delete operation to " + DeletePolicyContextProfileServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task PatchCreateOrUpdatePolicyContextProfile(string ContextProfileId, NSXTPolicyContextProfileType PolicyContextProfile, bool? Override = null)
        {
            if (ContextProfileId == null) { throw new System.ArgumentNullException("ContextProfileId cannot be null"); }
            if (PolicyContextProfile == null) { throw new System.ArgumentNullException("PolicyContextProfile cannot be null"); }
            StringBuilder PatchCreateOrUpdatePolicyContextProfileServiceURL = new StringBuilder("/infra/context-profiles/{context-profile-id}");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Patch
            };
            PatchCreateOrUpdatePolicyContextProfileServiceURL.Replace("{context-profile-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(ContextProfileId, System.Globalization.CultureInfo.InvariantCulture)));
            request.AddJsonBody(PolicyContextProfile);
            if (Override != null) { request.AddQueryParameter("override", Override.ToString()); }
            request.Resource = PatchCreateOrUpdatePolicyContextProfileServiceURL.ToString();
            RestResponse response = await restClient.ExecuteTaskAsyncWithPolicy(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Patch operation to " + PatchCreateOrUpdatePolicyContextProfileServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTPolicyContextProfileType> GetPolicyContextProfile(string ContextProfileId)
        {
            if (ContextProfileId == null) { throw new System.ArgumentNullException("ContextProfileId cannot be null"); }
            StringBuilder GetPolicyContextProfileServiceURL = new StringBuilder("/infra/context-profiles/{context-profile-id}");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Get
            };
            GetPolicyContextProfileServiceURL.Replace("{context-profile-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(ContextProfileId, System.Globalization.CultureInfo.InvariantCulture)));
            request.Resource = GetPolicyContextProfileServiceURL.ToString();
            RestResponse<NSXTPolicyContextProfileType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTPolicyContextProfileType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Get operation to " + GetPolicyContextProfileServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task GlobalGlobalInfraAddRemoveCustomAttribute(NSXTPolicyCustomAttributesType PolicyCustomAttributes, string Action)
        {
            if (PolicyCustomAttributes == null) { throw new System.ArgumentNullException("PolicyCustomAttributes cannot be null"); }
            if (Action == null) { throw new System.ArgumentNullException("Action cannot be null"); }
            StringBuilder GlobalInfraAddRemoveCustomAttributeServiceURL = new StringBuilder("/global-infra/context-profiles/custom-attributes/default");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Post
            };
            request.AddJsonBody(PolicyCustomAttributes);
            if (Action != null) { request.AddQueryParameter("action", Action.ToString()); }
            request.Resource = GlobalInfraAddRemoveCustomAttributeServiceURL.ToString();
            RestResponse response = await restClient.ExecuteTaskAsyncWithPolicy(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Post operation to " + GlobalInfraAddRemoveCustomAttributeServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task GlobalGlobalInfraPatchCustomAttribute(NSXTPolicyCustomAttributesType PolicyCustomAttributes)
        {
            if (PolicyCustomAttributes == null) { throw new System.ArgumentNullException("PolicyCustomAttributes cannot be null"); }
            StringBuilder GlobalInfraPatchCustomAttributeServiceURL = new StringBuilder("/global-infra/context-profiles/custom-attributes/default");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Patch
            };
            request.AddJsonBody(PolicyCustomAttributes);
            request.Resource = GlobalInfraPatchCustomAttributeServiceURL.ToString();
            RestResponse response = await restClient.ExecuteTaskAsyncWithPolicy(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Patch operation to " + GlobalInfraPatchCustomAttributeServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTPolicyContextProfileListResultType> GlobalGlobalInfraGetCustomAttribute(string? AttributeKey = null, string? AttributeSource = null, string? Cursor = null, bool? IncludeMarkForDeleteObjects = null, string? IncludedFields = null, long? PageSize = null, bool? SortAscending = null, string? SortBy = null)
        {
            StringBuilder GlobalInfraGetCustomAttributeServiceURL = new StringBuilder("/global-infra/context-profiles/custom-attributes/default");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Get
            };
            if (AttributeKey != null) { request.AddQueryParameter("attribute_key", AttributeKey.ToString()); }
            if (AttributeSource != null) { request.AddQueryParameter("attribute_source", AttributeSource.ToString()); }
            if (Cursor != null) { request.AddQueryParameter("cursor", Cursor.ToString()); }
            if (IncludeMarkForDeleteObjects != null) { request.AddQueryParameter("include_mark_for_delete_objects", IncludeMarkForDeleteObjects.ToString()); }
            if (IncludedFields != null) { request.AddQueryParameter("included_fields", IncludedFields.ToString()); }
            if (PageSize != null) { request.AddQueryParameter("page_size", PageSize.ToString()); }
            if (SortAscending != null) { request.AddQueryParameter("sort_ascending", SortAscending.ToString()); }
            if (SortBy != null) { request.AddQueryParameter("sort_by", SortBy.ToString()); }
            request.Resource = GlobalInfraGetCustomAttributeServiceURL.ToString();
            RestResponse<NSXTPolicyContextProfileListResultType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTPolicyContextProfileListResultType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Get operation to " + GlobalInfraGetCustomAttributeServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task AddRemoveCustomAttributeValues(NSXTPolicyAttributesType PolicyAttributes, string Action)
        {
            if (PolicyAttributes == null) { throw new System.ArgumentNullException("PolicyAttributes cannot be null"); }
            if (Action == null) { throw new System.ArgumentNullException("Action cannot be null"); }
            StringBuilder AddRemoveCustomAttributeValuesServiceURL = new StringBuilder("/infra/context-profiles/custom-attributes");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Post
            };
            request.AddJsonBody(PolicyAttributes);
            if (Action != null) { request.AddQueryParameter("action", Action.ToString()); }
            request.Resource = AddRemoveCustomAttributeValuesServiceURL.ToString();
            RestResponse response = await restClient.ExecuteTaskAsyncWithPolicy(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Post operation to " + AddRemoveCustomAttributeValuesServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task PatchCustomAttributeList(NSXTPolicyAttributesType PolicyAttributes)
        {
            if (PolicyAttributes == null) { throw new System.ArgumentNullException("PolicyAttributes cannot be null"); }
            StringBuilder PatchCustomAttributeListServiceURL = new StringBuilder("/infra/context-profiles/custom-attributes");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Patch
            };
            request.AddJsonBody(PolicyAttributes);
            request.Resource = PatchCustomAttributeListServiceURL.ToString();
            RestResponse response = await restClient.ExecuteTaskAsyncWithPolicy(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Patch operation to " + PatchCustomAttributeListServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            
        }
    }
}
