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
    public class PolicySpoofGuard
    {
        private RestClient restClient;
        private int retry;
        private int timeout;
        private CancellationToken cancellationToken;

        public PolicySpoofGuard(RestClient Client, CancellationToken _cancellationToken, int _timeout, int _retry)
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
        public async Task<NSXTSpoofGuardProfileListResultType> GlobalGlobalInfraListSpoofGuardProfiles(string? Cursor = null, bool? IncludeMarkForDeleteObjects = null, string? IncludedFields = null, long? PageSize = null, bool? SortAscending = null, string? SortBy = null)
        {
            StringBuilder GlobalInfraListSpoofGuardProfilesServiceURL = new StringBuilder("/global-infra/spoofguard-profiles");
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
            request.Resource = GlobalInfraListSpoofGuardProfilesServiceURL.ToString();
            RestResponse<NSXTSpoofGuardProfileListResultType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTSpoofGuardProfileListResultType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Get operation to " + GlobalInfraListSpoofGuardProfilesServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTSpoofGuardProfileType> CreateOrUpdateSpoofGuardProfile(string SpoofguardProfileId, NSXTSpoofGuardProfileType SpoofGuardProfile, bool? Override = null)
        {
            if (SpoofguardProfileId == null) { throw new System.ArgumentNullException("SpoofguardProfileId cannot be null"); }
            if (SpoofGuardProfile == null) { throw new System.ArgumentNullException("SpoofGuardProfile cannot be null"); }
            StringBuilder CreateOrUpdateSpoofGuardProfileServiceURL = new StringBuilder("/infra/spoofguard-profiles/{spoofguard-profile-id}");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Put
            };
            CreateOrUpdateSpoofGuardProfileServiceURL.Replace("{spoofguard-profile-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(SpoofguardProfileId, System.Globalization.CultureInfo.InvariantCulture)));
            request.AddJsonBody(SpoofGuardProfile);
            if (Override != null) { request.AddQueryParameter("override", Override.ToString()); }
            request.Resource = CreateOrUpdateSpoofGuardProfileServiceURL.ToString();
            RestResponse<NSXTSpoofGuardProfileType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTSpoofGuardProfileType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Put operation to " + CreateOrUpdateSpoofGuardProfileServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task PatchSpoofGuardProfile(string SpoofguardProfileId, NSXTSpoofGuardProfileType SpoofGuardProfile, bool? Override = null)
        {
            if (SpoofguardProfileId == null) { throw new System.ArgumentNullException("SpoofguardProfileId cannot be null"); }
            if (SpoofGuardProfile == null) { throw new System.ArgumentNullException("SpoofGuardProfile cannot be null"); }
            StringBuilder PatchSpoofGuardProfileServiceURL = new StringBuilder("/infra/spoofguard-profiles/{spoofguard-profile-id}");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Patch
            };
            PatchSpoofGuardProfileServiceURL.Replace("{spoofguard-profile-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(SpoofguardProfileId, System.Globalization.CultureInfo.InvariantCulture)));
            request.AddJsonBody(SpoofGuardProfile);
            if (Override != null) { request.AddQueryParameter("override", Override.ToString()); }
            request.Resource = PatchSpoofGuardProfileServiceURL.ToString();
            RestResponse response = await restClient.ExecuteTaskAsyncWithPolicy(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Patch operation to " + PatchSpoofGuardProfileServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTSpoofGuardProfileType> GetSpoofGuardProfile(string SpoofguardProfileId)
        {
            if (SpoofguardProfileId == null) { throw new System.ArgumentNullException("SpoofguardProfileId cannot be null"); }
            StringBuilder GetSpoofGuardProfileServiceURL = new StringBuilder("/infra/spoofguard-profiles/{spoofguard-profile-id}");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Get
            };
            GetSpoofGuardProfileServiceURL.Replace("{spoofguard-profile-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(SpoofguardProfileId, System.Globalization.CultureInfo.InvariantCulture)));
            request.Resource = GetSpoofGuardProfileServiceURL.ToString();
            RestResponse<NSXTSpoofGuardProfileType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTSpoofGuardProfileType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Get operation to " + GetSpoofGuardProfileServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task DeleteSpoofGuardProfile(string SpoofguardProfileId, bool? Override = null)
        {
            if (SpoofguardProfileId == null) { throw new System.ArgumentNullException("SpoofguardProfileId cannot be null"); }
            StringBuilder DeleteSpoofGuardProfileServiceURL = new StringBuilder("/infra/spoofguard-profiles/{spoofguard-profile-id}");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Delete
            };
            DeleteSpoofGuardProfileServiceURL.Replace("{spoofguard-profile-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(SpoofguardProfileId, System.Globalization.CultureInfo.InvariantCulture)));
            if (Override != null) { request.AddQueryParameter("override", Override.ToString()); }
            request.Resource = DeleteSpoofGuardProfileServiceURL.ToString();
            RestResponse response = await restClient.ExecuteTaskAsyncWithPolicy(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Delete operation to " + DeleteSpoofGuardProfileServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTSpoofGuardProfileListResultType> ListSpoofGuardProfiles(string? Cursor = null, bool? IncludeMarkForDeleteObjects = null, string? IncludedFields = null, long? PageSize = null, bool? SortAscending = null, string? SortBy = null)
        {
            StringBuilder ListSpoofGuardProfilesServiceURL = new StringBuilder("/infra/spoofguard-profiles");
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
            request.Resource = ListSpoofGuardProfilesServiceURL.ToString();
            RestResponse<NSXTSpoofGuardProfileListResultType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTSpoofGuardProfileListResultType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Get operation to " + ListSpoofGuardProfilesServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTSpoofGuardProfileType> GlobalGlobalInfraCreateOrUpdateSpoofGuardProfile(string SpoofguardProfileId, NSXTSpoofGuardProfileType SpoofGuardProfile, bool? Override = null)
        {
            if (SpoofguardProfileId == null) { throw new System.ArgumentNullException("SpoofguardProfileId cannot be null"); }
            if (SpoofGuardProfile == null) { throw new System.ArgumentNullException("SpoofGuardProfile cannot be null"); }
            StringBuilder GlobalInfraCreateOrUpdateSpoofGuardProfileServiceURL = new StringBuilder("/global-infra/spoofguard-profiles/{spoofguard-profile-id}");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Put
            };
            GlobalInfraCreateOrUpdateSpoofGuardProfileServiceURL.Replace("{spoofguard-profile-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(SpoofguardProfileId, System.Globalization.CultureInfo.InvariantCulture)));
            request.AddJsonBody(SpoofGuardProfile);
            if (Override != null) { request.AddQueryParameter("override", Override.ToString()); }
            request.Resource = GlobalInfraCreateOrUpdateSpoofGuardProfileServiceURL.ToString();
            RestResponse<NSXTSpoofGuardProfileType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTSpoofGuardProfileType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Put operation to " + GlobalInfraCreateOrUpdateSpoofGuardProfileServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task GlobalGlobalInfraPatchSpoofGuardProfile(string SpoofguardProfileId, NSXTSpoofGuardProfileType SpoofGuardProfile, bool? Override = null)
        {
            if (SpoofguardProfileId == null) { throw new System.ArgumentNullException("SpoofguardProfileId cannot be null"); }
            if (SpoofGuardProfile == null) { throw new System.ArgumentNullException("SpoofGuardProfile cannot be null"); }
            StringBuilder GlobalInfraPatchSpoofGuardProfileServiceURL = new StringBuilder("/global-infra/spoofguard-profiles/{spoofguard-profile-id}");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Patch
            };
            GlobalInfraPatchSpoofGuardProfileServiceURL.Replace("{spoofguard-profile-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(SpoofguardProfileId, System.Globalization.CultureInfo.InvariantCulture)));
            request.AddJsonBody(SpoofGuardProfile);
            if (Override != null) { request.AddQueryParameter("override", Override.ToString()); }
            request.Resource = GlobalInfraPatchSpoofGuardProfileServiceURL.ToString();
            RestResponse response = await restClient.ExecuteTaskAsyncWithPolicy(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Patch operation to " + GlobalInfraPatchSpoofGuardProfileServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTSpoofGuardProfileType> GlobalGlobalInfraGetSpoofGuardProfile(string SpoofguardProfileId)
        {
            if (SpoofguardProfileId == null) { throw new System.ArgumentNullException("SpoofguardProfileId cannot be null"); }
            StringBuilder GlobalInfraGetSpoofGuardProfileServiceURL = new StringBuilder("/global-infra/spoofguard-profiles/{spoofguard-profile-id}");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Get
            };
            GlobalInfraGetSpoofGuardProfileServiceURL.Replace("{spoofguard-profile-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(SpoofguardProfileId, System.Globalization.CultureInfo.InvariantCulture)));
            request.Resource = GlobalInfraGetSpoofGuardProfileServiceURL.ToString();
            RestResponse<NSXTSpoofGuardProfileType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTSpoofGuardProfileType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Get operation to " + GlobalInfraGetSpoofGuardProfileServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task GlobalGlobalInfraDeleteSpoofGuardProfile(string SpoofguardProfileId, bool? Override = null)
        {
            if (SpoofguardProfileId == null) { throw new System.ArgumentNullException("SpoofguardProfileId cannot be null"); }
            StringBuilder GlobalInfraDeleteSpoofGuardProfileServiceURL = new StringBuilder("/global-infra/spoofguard-profiles/{spoofguard-profile-id}");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Delete
            };
            GlobalInfraDeleteSpoofGuardProfileServiceURL.Replace("{spoofguard-profile-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(SpoofguardProfileId, System.Globalization.CultureInfo.InvariantCulture)));
            if (Override != null) { request.AddQueryParameter("override", Override.ToString()); }
            request.Resource = GlobalInfraDeleteSpoofGuardProfileServiceURL.ToString();
            RestResponse response = await restClient.ExecuteTaskAsyncWithPolicy(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Delete operation to " + GlobalInfraDeleteSpoofGuardProfileServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            
        }
    }
}
