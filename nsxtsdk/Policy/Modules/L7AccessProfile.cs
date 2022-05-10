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
    public class L7AccessProfile
    {
        private RestClient restClient;
        private int retry;
        private int timeout;
        private CancellationToken cancellationToken;

        public L7AccessProfile(RestClient Client, CancellationToken _cancellationToken, int _timeout, int _retry)
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
        public async Task<NSXTL7AccessProfileListResultType> ListL7AccessProfiles(string? Cursor = null, bool? IncludeEntryCount = null, bool? IncludeMarkForDeleteObjects = null, string? IncludedFields = null, long? PageSize = null, bool? SortAscending = null, string? SortBy = null)
        {
            StringBuilder ListL7AccessProfilesServiceURL = new StringBuilder("/infra/l7-access-profiles");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Get
            };
            if (Cursor != null) { request.AddQueryParameter("cursor", Cursor.ToString()); }
            if (IncludeEntryCount != null) { request.AddQueryParameter("include_entry_count", IncludeEntryCount.ToString()); }
            if (IncludeMarkForDeleteObjects != null) { request.AddQueryParameter("include_mark_for_delete_objects", IncludeMarkForDeleteObjects.ToString()); }
            if (IncludedFields != null) { request.AddQueryParameter("included_fields", IncludedFields.ToString()); }
            if (PageSize != null) { request.AddQueryParameter("page_size", PageSize.ToString()); }
            if (SortAscending != null) { request.AddQueryParameter("sort_ascending", SortAscending.ToString()); }
            if (SortBy != null) { request.AddQueryParameter("sort_by", SortBy.ToString()); }
            request.Resource = ListL7AccessProfilesServiceURL.ToString();
            RestResponse<NSXTL7AccessProfileListResultType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTL7AccessProfileListResultType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Get operation to " + ListL7AccessProfilesServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTL7AccessProfileType> CreateOrUpdateL7AccessProfile(string L7AccessProfileId, NSXTL7AccessProfileType L7AccessProfile, bool? Override = null)
        {
            if (L7AccessProfileId == null) { throw new System.ArgumentNullException("L7AccessProfileId cannot be null"); }
            if (L7AccessProfile == null) { throw new System.ArgumentNullException("L7AccessProfile cannot be null"); }
            StringBuilder CreateOrUpdateL7AccessProfileServiceURL = new StringBuilder("/infra/l7-access-profiles/{l7-access-profile-id}");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Put
            };
            CreateOrUpdateL7AccessProfileServiceURL.Replace("{l7-access-profile-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(L7AccessProfileId, System.Globalization.CultureInfo.InvariantCulture)));
            request.AddJsonBody(L7AccessProfile);
            if (Override != null) { request.AddQueryParameter("override", Override.ToString()); }
            request.Resource = CreateOrUpdateL7AccessProfileServiceURL.ToString();
            RestResponse<NSXTL7AccessProfileType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTL7AccessProfileType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Put operation to " + CreateOrUpdateL7AccessProfileServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task DeleteL7AccessProfile(string L7AccessProfileId, bool? Override = null)
        {
            if (L7AccessProfileId == null) { throw new System.ArgumentNullException("L7AccessProfileId cannot be null"); }
            StringBuilder DeleteL7AccessProfileServiceURL = new StringBuilder("/infra/l7-access-profiles/{l7-access-profile-id}");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Delete
            };
            DeleteL7AccessProfileServiceURL.Replace("{l7-access-profile-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(L7AccessProfileId, System.Globalization.CultureInfo.InvariantCulture)));
            if (Override != null) { request.AddQueryParameter("override", Override.ToString()); }
            request.Resource = DeleteL7AccessProfileServiceURL.ToString();
            RestResponse response = await restClient.ExecuteTaskAsyncWithPolicy(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Delete operation to " + DeleteL7AccessProfileServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTL7AccessProfileType> PatchL7AccessProfile(string L7AccessProfileId, NSXTL7AccessProfileType L7AccessProfile, bool? Override = null)
        {
            if (L7AccessProfileId == null) { throw new System.ArgumentNullException("L7AccessProfileId cannot be null"); }
            if (L7AccessProfile == null) { throw new System.ArgumentNullException("L7AccessProfile cannot be null"); }
            StringBuilder PatchL7AccessProfileServiceURL = new StringBuilder("/infra/l7-access-profiles/{l7-access-profile-id}");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Patch
            };
            PatchL7AccessProfileServiceURL.Replace("{l7-access-profile-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(L7AccessProfileId, System.Globalization.CultureInfo.InvariantCulture)));
            request.AddJsonBody(L7AccessProfile);
            if (Override != null) { request.AddQueryParameter("override", Override.ToString()); }
            request.Resource = PatchL7AccessProfileServiceURL.ToString();
            RestResponse<NSXTL7AccessProfileType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTL7AccessProfileType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Patch operation to " + PatchL7AccessProfileServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTL7AccessProfileType> GetL7AccessProfile(string L7AccessProfileId)
        {
            if (L7AccessProfileId == null) { throw new System.ArgumentNullException("L7AccessProfileId cannot be null"); }
            StringBuilder GetL7AccessProfileServiceURL = new StringBuilder("/infra/l7-access-profiles/{l7-access-profile-id}");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Get
            };
            GetL7AccessProfileServiceURL.Replace("{l7-access-profile-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(L7AccessProfileId, System.Globalization.CultureInfo.InvariantCulture)));
            request.Resource = GetL7AccessProfileServiceURL.ToString();
            RestResponse<NSXTL7AccessProfileType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTL7AccessProfileType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Get operation to " + GetL7AccessProfileServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTL7AccessEntryListResultType> ListL7AccessEntries(string L7AccessProfileId, string? Cursor = null, bool? IncludeMarkForDeleteObjects = null, string? IncludedFields = null, long? PageSize = null, bool? SortAscending = null, string? SortBy = null)
        {
            if (L7AccessProfileId == null) { throw new System.ArgumentNullException("L7AccessProfileId cannot be null"); }
            StringBuilder ListL7AccessEntriesServiceURL = new StringBuilder("/infra/l7-access-profiles/{l7-access-profile-id}/entries");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Get
            };
            ListL7AccessEntriesServiceURL.Replace("{l7-access-profile-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(L7AccessProfileId, System.Globalization.CultureInfo.InvariantCulture)));
            if (Cursor != null) { request.AddQueryParameter("cursor", Cursor.ToString()); }
            if (IncludeMarkForDeleteObjects != null) { request.AddQueryParameter("include_mark_for_delete_objects", IncludeMarkForDeleteObjects.ToString()); }
            if (IncludedFields != null) { request.AddQueryParameter("included_fields", IncludedFields.ToString()); }
            if (PageSize != null) { request.AddQueryParameter("page_size", PageSize.ToString()); }
            if (SortAscending != null) { request.AddQueryParameter("sort_ascending", SortAscending.ToString()); }
            if (SortBy != null) { request.AddQueryParameter("sort_by", SortBy.ToString()); }
            request.Resource = ListL7AccessEntriesServiceURL.ToString();
            RestResponse<NSXTL7AccessEntryListResultType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTL7AccessEntryListResultType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Get operation to " + ListL7AccessEntriesServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTPolicyContextProfileListResultType> ListL7AccessProfileProfileSupportedAttributes(string? AttributeKey = null, string? AttributeSource = null, string? Cursor = null, bool? IncludeMarkForDeleteObjects = null, string? IncludedFields = null, long? PageSize = null, bool? SortAscending = null, string? SortBy = null)
        {
            StringBuilder ListL7AccessProfileProfileSupportedAttributesServiceURL = new StringBuilder("/infra/l7-access-profiles/attributes");
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
            request.Resource = ListL7AccessProfileProfileSupportedAttributesServiceURL.ToString();
            RestResponse<NSXTPolicyContextProfileListResultType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTPolicyContextProfileListResultType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Get operation to " + ListL7AccessProfileProfileSupportedAttributesServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTL7AccessEntryType> CreateOrUpdateL7AccessEntry(string L7AccessProfileId, string L7AccessEntryId, NSXTL7AccessEntryType L7AccessEntry)
        {
            if (L7AccessProfileId == null) { throw new System.ArgumentNullException("L7AccessProfileId cannot be null"); }
            if (L7AccessEntryId == null) { throw new System.ArgumentNullException("L7AccessEntryId cannot be null"); }
            if (L7AccessEntry == null) { throw new System.ArgumentNullException("L7AccessEntry cannot be null"); }
            StringBuilder CreateOrUpdateL7AccessEntryServiceURL = new StringBuilder("/infra/l7-access-profiles/{l7-access-profile-id}/entries/{l7-access-entry-id}");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Put
            };
            CreateOrUpdateL7AccessEntryServiceURL.Replace("{l7-access-profile-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(L7AccessProfileId, System.Globalization.CultureInfo.InvariantCulture)));
            CreateOrUpdateL7AccessEntryServiceURL.Replace("{l7-access-entry-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(L7AccessEntryId, System.Globalization.CultureInfo.InvariantCulture)));
            request.AddJsonBody(L7AccessEntry);
            request.Resource = CreateOrUpdateL7AccessEntryServiceURL.ToString();
            RestResponse<NSXTL7AccessEntryType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTL7AccessEntryType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Put operation to " + CreateOrUpdateL7AccessEntryServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTL7AccessEntryType> ReadL7AccessEntry(string L7AccessProfileId, string L7AccessEntryId)
        {
            if (L7AccessProfileId == null) { throw new System.ArgumentNullException("L7AccessProfileId cannot be null"); }
            if (L7AccessEntryId == null) { throw new System.ArgumentNullException("L7AccessEntryId cannot be null"); }
            StringBuilder ReadL7AccessEntryServiceURL = new StringBuilder("/infra/l7-access-profiles/{l7-access-profile-id}/entries/{l7-access-entry-id}");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Get
            };
            ReadL7AccessEntryServiceURL.Replace("{l7-access-profile-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(L7AccessProfileId, System.Globalization.CultureInfo.InvariantCulture)));
            ReadL7AccessEntryServiceURL.Replace("{l7-access-entry-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(L7AccessEntryId, System.Globalization.CultureInfo.InvariantCulture)));
            request.Resource = ReadL7AccessEntryServiceURL.ToString();
            RestResponse<NSXTL7AccessEntryType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTL7AccessEntryType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Get operation to " + ReadL7AccessEntryServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTL7AccessEntryType> PatchL7AccessEntry(string L7AccessProfileId, string L7AccessEntryId, NSXTL7AccessEntryType L7AccessEntry)
        {
            if (L7AccessProfileId == null) { throw new System.ArgumentNullException("L7AccessProfileId cannot be null"); }
            if (L7AccessEntryId == null) { throw new System.ArgumentNullException("L7AccessEntryId cannot be null"); }
            if (L7AccessEntry == null) { throw new System.ArgumentNullException("L7AccessEntry cannot be null"); }
            StringBuilder PatchL7AccessEntryServiceURL = new StringBuilder("/infra/l7-access-profiles/{l7-access-profile-id}/entries/{l7-access-entry-id}");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Patch
            };
            PatchL7AccessEntryServiceURL.Replace("{l7-access-profile-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(L7AccessProfileId, System.Globalization.CultureInfo.InvariantCulture)));
            PatchL7AccessEntryServiceURL.Replace("{l7-access-entry-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(L7AccessEntryId, System.Globalization.CultureInfo.InvariantCulture)));
            request.AddJsonBody(L7AccessEntry);
            request.Resource = PatchL7AccessEntryServiceURL.ToString();
            RestResponse<NSXTL7AccessEntryType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTL7AccessEntryType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Patch operation to " + PatchL7AccessEntryServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task DeleteL7AccessEntry(string L7AccessProfileId, string L7AccessEntryId, bool? Override = null)
        {
            if (L7AccessProfileId == null) { throw new System.ArgumentNullException("L7AccessProfileId cannot be null"); }
            if (L7AccessEntryId == null) { throw new System.ArgumentNullException("L7AccessEntryId cannot be null"); }
            StringBuilder DeleteL7AccessEntryServiceURL = new StringBuilder("/infra/l7-access-profiles/{l7-access-profile-id}/entries/{l7-access-entry-id}");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Delete
            };
            DeleteL7AccessEntryServiceURL.Replace("{l7-access-profile-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(L7AccessProfileId, System.Globalization.CultureInfo.InvariantCulture)));
            DeleteL7AccessEntryServiceURL.Replace("{l7-access-entry-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(L7AccessEntryId, System.Globalization.CultureInfo.InvariantCulture)));
            if (Override != null) { request.AddQueryParameter("override", Override.ToString()); }
            request.Resource = DeleteL7AccessEntryServiceURL.ToString();
            RestResponse response = await restClient.ExecuteTaskAsyncWithPolicy(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Delete operation to " + DeleteL7AccessEntryServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            
        }
    }
}
