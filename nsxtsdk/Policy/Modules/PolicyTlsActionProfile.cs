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
        private RestClient restClient;
        private int retry;
        private int timeout;
        private CancellationToken cancellationToken;

        public PolicyTlsActionProfile(RestClient Client, CancellationToken _cancellationToken, int _timeout, int _retry)
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
        public async Task<NSXTTlsProfileListResultType> ListTlsProfiles(string? Cursor = null, bool? IncludeMarkForDeleteObjects = null, string? IncludedFields = null, long? PageSize = null, bool? SortAscending = null, string? SortBy = null)
        {
            StringBuilder ListTlsProfilesServiceURL = new StringBuilder("/infra/tls-inspection-action-profiles");
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
            request.Resource = ListTlsProfilesServiceURL.ToString();
            RestResponse<NSXTTlsProfileListResultType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTTlsProfileListResultType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Get operation to " + ListTlsProfilesServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTTlsProfileType> CreateOrUpdateTlsProfile(string ActionProfileId, NSXTTlsProfileType TlsProfile)
        {
            if (ActionProfileId == null) { throw new System.ArgumentNullException("ActionProfileId cannot be null"); }
            if (TlsProfile == null) { throw new System.ArgumentNullException("TlsProfile cannot be null"); }
            StringBuilder CreateOrUpdateTlsProfileServiceURL = new StringBuilder("/infra/tls-inspection-action-profiles/{action-profile-id}");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Put
            };
            CreateOrUpdateTlsProfileServiceURL.Replace("{action-profile-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(ActionProfileId, System.Globalization.CultureInfo.InvariantCulture)));
            request.AddJsonBody(TlsProfile);
            request.Resource = CreateOrUpdateTlsProfileServiceURL.ToString();
            RestResponse<NSXTTlsProfileType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTTlsProfileType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Put operation to " + CreateOrUpdateTlsProfileServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTTlsProfileType> GetTlsProfile(string ActionProfileId)
        {
            if (ActionProfileId == null) { throw new System.ArgumentNullException("ActionProfileId cannot be null"); }
            StringBuilder GetTlsProfileServiceURL = new StringBuilder("/infra/tls-inspection-action-profiles/{action-profile-id}");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Get
            };
            GetTlsProfileServiceURL.Replace("{action-profile-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(ActionProfileId, System.Globalization.CultureInfo.InvariantCulture)));
            request.Resource = GetTlsProfileServiceURL.ToString();
            RestResponse<NSXTTlsProfileType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTTlsProfileType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Get operation to " + GetTlsProfileServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task DeleteTlsProfile(string ActionProfileId)
        {
            if (ActionProfileId == null) { throw new System.ArgumentNullException("ActionProfileId cannot be null"); }
            StringBuilder DeleteTlsProfileServiceURL = new StringBuilder("/infra/tls-inspection-action-profiles/{action-profile-id}");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Delete
            };
            DeleteTlsProfileServiceURL.Replace("{action-profile-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(ActionProfileId, System.Globalization.CultureInfo.InvariantCulture)));
            request.Resource = DeleteTlsProfileServiceURL.ToString();
            RestResponse response = await restClient.ExecuteTaskAsyncWithPolicy(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Delete operation to " + DeleteTlsProfileServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTTlsProfileType> PatchTlsProfile(string ActionProfileId, NSXTTlsProfileType TlsProfile)
        {
            if (ActionProfileId == null) { throw new System.ArgumentNullException("ActionProfileId cannot be null"); }
            if (TlsProfile == null) { throw new System.ArgumentNullException("TlsProfile cannot be null"); }
            StringBuilder PatchTlsProfileServiceURL = new StringBuilder("/infra/tls-inspection-action-profiles/{action-profile-id}");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Patch
            };
            PatchTlsProfileServiceURL.Replace("{action-profile-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(ActionProfileId, System.Globalization.CultureInfo.InvariantCulture)));
            request.AddJsonBody(TlsProfile);
            request.Resource = PatchTlsProfileServiceURL.ToString();
            RestResponse<NSXTTlsProfileType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTTlsProfileType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Patch operation to " + PatchTlsProfileServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
    }
}
