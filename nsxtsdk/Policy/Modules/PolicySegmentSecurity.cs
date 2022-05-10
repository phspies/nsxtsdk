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
    public class PolicySegmentSecurity
    {
        private RestClient restClient;
        private int retry;
        private int timeout;
        private CancellationToken cancellationToken;

        public PolicySegmentSecurity(RestClient Client, CancellationToken _cancellationToken, int _timeout, int _retry)
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
        public async Task<NSXTSegmentSecurityProfileType> CreateOrUpdateSegmentSecurityProfile(string SegmentSecurityProfileId, NSXTSegmentSecurityProfileType SegmentSecurityProfile, bool? Override = null)
        {
            if (SegmentSecurityProfileId == null) { throw new System.ArgumentNullException("SegmentSecurityProfileId cannot be null"); }
            if (SegmentSecurityProfile == null) { throw new System.ArgumentNullException("SegmentSecurityProfile cannot be null"); }
            StringBuilder CreateOrUpdateSegmentSecurityProfileServiceURL = new StringBuilder("/infra/segment-security-profiles/{segment-security-profile-id}");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Put
            };
            CreateOrUpdateSegmentSecurityProfileServiceURL.Replace("{segment-security-profile-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(SegmentSecurityProfileId, System.Globalization.CultureInfo.InvariantCulture)));
            request.AddJsonBody(SegmentSecurityProfile);
            if (Override != null) { request.AddQueryParameter("override", Override.ToString()); }
            request.Resource = CreateOrUpdateSegmentSecurityProfileServiceURL.ToString();
            RestResponse<NSXTSegmentSecurityProfileType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTSegmentSecurityProfileType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Put operation to " + CreateOrUpdateSegmentSecurityProfileServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task DeleteSegmentSecurityProfile(string SegmentSecurityProfileId, bool? Override = null)
        {
            if (SegmentSecurityProfileId == null) { throw new System.ArgumentNullException("SegmentSecurityProfileId cannot be null"); }
            StringBuilder DeleteSegmentSecurityProfileServiceURL = new StringBuilder("/infra/segment-security-profiles/{segment-security-profile-id}");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Delete
            };
            DeleteSegmentSecurityProfileServiceURL.Replace("{segment-security-profile-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(SegmentSecurityProfileId, System.Globalization.CultureInfo.InvariantCulture)));
            if (Override != null) { request.AddQueryParameter("override", Override.ToString()); }
            request.Resource = DeleteSegmentSecurityProfileServiceURL.ToString();
            RestResponse response = await restClient.ExecuteTaskAsyncWithPolicy(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Delete operation to " + DeleteSegmentSecurityProfileServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTSegmentSecurityProfileType> GetSegmentSecurityProfile(string SegmentSecurityProfileId)
        {
            if (SegmentSecurityProfileId == null) { throw new System.ArgumentNullException("SegmentSecurityProfileId cannot be null"); }
            StringBuilder GetSegmentSecurityProfileServiceURL = new StringBuilder("/infra/segment-security-profiles/{segment-security-profile-id}");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Get
            };
            GetSegmentSecurityProfileServiceURL.Replace("{segment-security-profile-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(SegmentSecurityProfileId, System.Globalization.CultureInfo.InvariantCulture)));
            request.Resource = GetSegmentSecurityProfileServiceURL.ToString();
            RestResponse<NSXTSegmentSecurityProfileType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTSegmentSecurityProfileType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Get operation to " + GetSegmentSecurityProfileServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task PatchSegmentSecurityProfile(string SegmentSecurityProfileId, NSXTSegmentSecurityProfileType SegmentSecurityProfile, bool? Override = null)
        {
            if (SegmentSecurityProfileId == null) { throw new System.ArgumentNullException("SegmentSecurityProfileId cannot be null"); }
            if (SegmentSecurityProfile == null) { throw new System.ArgumentNullException("SegmentSecurityProfile cannot be null"); }
            StringBuilder PatchSegmentSecurityProfileServiceURL = new StringBuilder("/infra/segment-security-profiles/{segment-security-profile-id}");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Patch
            };
            PatchSegmentSecurityProfileServiceURL.Replace("{segment-security-profile-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(SegmentSecurityProfileId, System.Globalization.CultureInfo.InvariantCulture)));
            request.AddJsonBody(SegmentSecurityProfile);
            if (Override != null) { request.AddQueryParameter("override", Override.ToString()); }
            request.Resource = PatchSegmentSecurityProfileServiceURL.ToString();
            RestResponse response = await restClient.ExecuteTaskAsyncWithPolicy(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Patch operation to " + PatchSegmentSecurityProfileServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTSegmentSecurityProfileType> GlobalGlobalInfraCreateOrUpdateSegmentSecurityProfile(string SegmentSecurityProfileId, NSXTSegmentSecurityProfileType SegmentSecurityProfile, bool? Override = null)
        {
            if (SegmentSecurityProfileId == null) { throw new System.ArgumentNullException("SegmentSecurityProfileId cannot be null"); }
            if (SegmentSecurityProfile == null) { throw new System.ArgumentNullException("SegmentSecurityProfile cannot be null"); }
            StringBuilder GlobalInfraCreateOrUpdateSegmentSecurityProfileServiceURL = new StringBuilder("/global-infra/segment-security-profiles/{segment-security-profile-id}");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Put
            };
            GlobalInfraCreateOrUpdateSegmentSecurityProfileServiceURL.Replace("{segment-security-profile-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(SegmentSecurityProfileId, System.Globalization.CultureInfo.InvariantCulture)));
            request.AddJsonBody(SegmentSecurityProfile);
            if (Override != null) { request.AddQueryParameter("override", Override.ToString()); }
            request.Resource = GlobalInfraCreateOrUpdateSegmentSecurityProfileServiceURL.ToString();
            RestResponse<NSXTSegmentSecurityProfileType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTSegmentSecurityProfileType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Put operation to " + GlobalInfraCreateOrUpdateSegmentSecurityProfileServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task GlobalGlobalInfraDeleteSegmentSecurityProfile(string SegmentSecurityProfileId, bool? Override = null)
        {
            if (SegmentSecurityProfileId == null) { throw new System.ArgumentNullException("SegmentSecurityProfileId cannot be null"); }
            StringBuilder GlobalInfraDeleteSegmentSecurityProfileServiceURL = new StringBuilder("/global-infra/segment-security-profiles/{segment-security-profile-id}");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Delete
            };
            GlobalInfraDeleteSegmentSecurityProfileServiceURL.Replace("{segment-security-profile-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(SegmentSecurityProfileId, System.Globalization.CultureInfo.InvariantCulture)));
            if (Override != null) { request.AddQueryParameter("override", Override.ToString()); }
            request.Resource = GlobalInfraDeleteSegmentSecurityProfileServiceURL.ToString();
            RestResponse response = await restClient.ExecuteTaskAsyncWithPolicy(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Delete operation to " + GlobalInfraDeleteSegmentSecurityProfileServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTSegmentSecurityProfileType> GlobalGlobalInfraGetSegmentSecurityProfile(string SegmentSecurityProfileId)
        {
            if (SegmentSecurityProfileId == null) { throw new System.ArgumentNullException("SegmentSecurityProfileId cannot be null"); }
            StringBuilder GlobalInfraGetSegmentSecurityProfileServiceURL = new StringBuilder("/global-infra/segment-security-profiles/{segment-security-profile-id}");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Get
            };
            GlobalInfraGetSegmentSecurityProfileServiceURL.Replace("{segment-security-profile-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(SegmentSecurityProfileId, System.Globalization.CultureInfo.InvariantCulture)));
            request.Resource = GlobalInfraGetSegmentSecurityProfileServiceURL.ToString();
            RestResponse<NSXTSegmentSecurityProfileType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTSegmentSecurityProfileType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Get operation to " + GlobalInfraGetSegmentSecurityProfileServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task GlobalGlobalInfraPatchSegmentSecurityProfile(string SegmentSecurityProfileId, NSXTSegmentSecurityProfileType SegmentSecurityProfile, bool? Override = null)
        {
            if (SegmentSecurityProfileId == null) { throw new System.ArgumentNullException("SegmentSecurityProfileId cannot be null"); }
            if (SegmentSecurityProfile == null) { throw new System.ArgumentNullException("SegmentSecurityProfile cannot be null"); }
            StringBuilder GlobalInfraPatchSegmentSecurityProfileServiceURL = new StringBuilder("/global-infra/segment-security-profiles/{segment-security-profile-id}");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Patch
            };
            GlobalInfraPatchSegmentSecurityProfileServiceURL.Replace("{segment-security-profile-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(SegmentSecurityProfileId, System.Globalization.CultureInfo.InvariantCulture)));
            request.AddJsonBody(SegmentSecurityProfile);
            if (Override != null) { request.AddQueryParameter("override", Override.ToString()); }
            request.Resource = GlobalInfraPatchSegmentSecurityProfileServiceURL.ToString();
            RestResponse response = await restClient.ExecuteTaskAsyncWithPolicy(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Patch operation to " + GlobalInfraPatchSegmentSecurityProfileServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTSegmentSecurityProfileListResultType> ListSegmentSecurityProfiles(string? Cursor = null, bool? IncludeMarkForDeleteObjects = null, string? IncludedFields = null, long? PageSize = null, bool? SortAscending = null, string? SortBy = null)
        {
            StringBuilder ListSegmentSecurityProfilesServiceURL = new StringBuilder("/infra/segment-security-profiles");
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
            request.Resource = ListSegmentSecurityProfilesServiceURL.ToString();
            RestResponse<NSXTSegmentSecurityProfileListResultType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTSegmentSecurityProfileListResultType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Get operation to " + ListSegmentSecurityProfilesServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTSegmentSecurityProfileListResultType> GlobalGlobalInfraListSegmentSecurityProfiles(string? Cursor = null, bool? IncludeMarkForDeleteObjects = null, string? IncludedFields = null, long? PageSize = null, bool? SortAscending = null, string? SortBy = null)
        {
            StringBuilder GlobalInfraListSegmentSecurityProfilesServiceURL = new StringBuilder("/global-infra/segment-security-profiles");
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
            request.Resource = GlobalInfraListSegmentSecurityProfilesServiceURL.ToString();
            RestResponse<NSXTSegmentSecurityProfileListResultType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTSegmentSecurityProfileListResultType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Get operation to " + GlobalInfraListSegmentSecurityProfilesServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
    }
}
