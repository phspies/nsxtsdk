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
    public class PolicyTransportZoneProfile
    {
        private RestClient restClient;
        private int retry;
        private int timeout;
        private CancellationToken cancellationToken;

        public PolicyTransportZoneProfile(RestClient Client, CancellationToken _cancellationToken, int _timeout, int _retry)
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
        public async Task<NSXTPolicyTransportZoneProfileListResultType> GetPolicyTransportZoneProfiles(string? Cursor = null, bool? IncludeMarkForDeleteObjects = null, string? IncludedFields = null, long? PageSize = null, bool? SortAscending = null, string? SortBy = null)
        {
            StringBuilder GetPolicyTransportZoneProfilesServiceURL = new StringBuilder("/infra/transport-zone-profiles");
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
            request.Resource = GetPolicyTransportZoneProfilesServiceURL.ToString();
            RestResponse<NSXTPolicyTransportZoneProfileListResultType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTPolicyTransportZoneProfileListResultType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Get operation to " + GetPolicyTransportZoneProfilesServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTPolicyTransportZoneProfileType> GlobalGlobalInfraGetPolicyTransportZoneProfile(string TzProfileId)
        {
            if (TzProfileId == null) { throw new System.ArgumentNullException("TzProfileId cannot be null"); }
            StringBuilder GlobalInfraGetPolicyTransportZoneProfileServiceURL = new StringBuilder("/global-infra/transport-zone-profiles/{tz-profile-id}");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Get
            };
            GlobalInfraGetPolicyTransportZoneProfileServiceURL.Replace("{tz-profile-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(TzProfileId, System.Globalization.CultureInfo.InvariantCulture)));
            request.Resource = GlobalInfraGetPolicyTransportZoneProfileServiceURL.ToString();
            RestResponse<NSXTPolicyTransportZoneProfileType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTPolicyTransportZoneProfileType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Get operation to " + GlobalInfraGetPolicyTransportZoneProfileServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTPolicyTransportZoneProfileType> CreateOrUpdatePolicyTransportZoneProfile(string TzProfileId, NSXTPolicyTransportZoneProfileType PolicyTransportZoneProfile)
        {
            if (TzProfileId == null) { throw new System.ArgumentNullException("TzProfileId cannot be null"); }
            if (PolicyTransportZoneProfile == null) { throw new System.ArgumentNullException("PolicyTransportZoneProfile cannot be null"); }
            StringBuilder CreateOrUpdatePolicyTransportZoneProfileServiceURL = new StringBuilder("/infra/transport-zone-profiles/{tz-profile-id}");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Put
            };
            CreateOrUpdatePolicyTransportZoneProfileServiceURL.Replace("{tz-profile-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(TzProfileId, System.Globalization.CultureInfo.InvariantCulture)));
            request.AddJsonBody(PolicyTransportZoneProfile);
            request.Resource = CreateOrUpdatePolicyTransportZoneProfileServiceURL.ToString();
            RestResponse<NSXTPolicyTransportZoneProfileType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTPolicyTransportZoneProfileType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Put operation to " + CreateOrUpdatePolicyTransportZoneProfileServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTPolicyTransportZoneProfileType> PatchPolicyTransportZoneProfile(string TzProfileId, NSXTPolicyTransportZoneProfileType PolicyTransportZoneProfile)
        {
            if (TzProfileId == null) { throw new System.ArgumentNullException("TzProfileId cannot be null"); }
            if (PolicyTransportZoneProfile == null) { throw new System.ArgumentNullException("PolicyTransportZoneProfile cannot be null"); }
            StringBuilder PatchPolicyTransportZoneProfileServiceURL = new StringBuilder("/infra/transport-zone-profiles/{tz-profile-id}");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Patch
            };
            PatchPolicyTransportZoneProfileServiceURL.Replace("{tz-profile-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(TzProfileId, System.Globalization.CultureInfo.InvariantCulture)));
            request.AddJsonBody(PolicyTransportZoneProfile);
            request.Resource = PatchPolicyTransportZoneProfileServiceURL.ToString();
            RestResponse<NSXTPolicyTransportZoneProfileType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTPolicyTransportZoneProfileType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Patch operation to " + PatchPolicyTransportZoneProfileServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task DeletePolicyTransportZoneProfile(string TzProfileId)
        {
            if (TzProfileId == null) { throw new System.ArgumentNullException("TzProfileId cannot be null"); }
            StringBuilder DeletePolicyTransportZoneProfileServiceURL = new StringBuilder("/infra/transport-zone-profiles/{tz-profile-id}");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Delete
            };
            DeletePolicyTransportZoneProfileServiceURL.Replace("{tz-profile-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(TzProfileId, System.Globalization.CultureInfo.InvariantCulture)));
            request.Resource = DeletePolicyTransportZoneProfileServiceURL.ToString();
            RestResponse response = await restClient.ExecuteTaskAsyncWithPolicy(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Delete operation to " + DeletePolicyTransportZoneProfileServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTPolicyTransportZoneProfileType> GetPolicyTransportZoneProfile(string TzProfileId)
        {
            if (TzProfileId == null) { throw new System.ArgumentNullException("TzProfileId cannot be null"); }
            StringBuilder GetPolicyTransportZoneProfileServiceURL = new StringBuilder("/infra/transport-zone-profiles/{tz-profile-id}");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Get
            };
            GetPolicyTransportZoneProfileServiceURL.Replace("{tz-profile-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(TzProfileId, System.Globalization.CultureInfo.InvariantCulture)));
            request.Resource = GetPolicyTransportZoneProfileServiceURL.ToString();
            RestResponse<NSXTPolicyTransportZoneProfileType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTPolicyTransportZoneProfileType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Get operation to " + GetPolicyTransportZoneProfileServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTPolicyTransportZoneProfileListResultType> GlobalGlobalInfraGetPolicyTransportZoneProfiles(string? Cursor = null, bool? IncludeMarkForDeleteObjects = null, string? IncludedFields = null, long? PageSize = null, bool? SortAscending = null, string? SortBy = null)
        {
            StringBuilder GlobalInfraGetPolicyTransportZoneProfilesServiceURL = new StringBuilder("/global-infra/transport-zone-profiles");
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
            request.Resource = GlobalInfraGetPolicyTransportZoneProfilesServiceURL.ToString();
            RestResponse<NSXTPolicyTransportZoneProfileListResultType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTPolicyTransportZoneProfileListResultType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Get operation to " + GlobalInfraGetPolicyTransportZoneProfilesServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
    }
}
