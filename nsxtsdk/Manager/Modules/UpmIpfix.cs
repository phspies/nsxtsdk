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
    public class UpmIpfix
    {
        private RestClient restClient;
        private int retry;
        private int timeout;
        private CancellationToken cancellationToken;

        public UpmIpfix(RestClient Client, CancellationToken _cancellationToken, int _timeout, int _retry)
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
        public async Task<NSXTIpfixUpmProfileType> CreateIpfixUpmProfile(NSXTIpfixUpmProfileType IpfixUpmProfile)
        {
            if (IpfixUpmProfile == null) { throw new System.ArgumentNullException("IpfixUpmProfile cannot be null"); }
            StringBuilder CreateIpfixUpmProfileServiceURL = new StringBuilder("/ipfix-profiles");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Post
            };
            request.AddJsonBody(IpfixUpmProfile);
            request.Resource = CreateIpfixUpmProfileServiceURL.ToString();
            RestResponse<NSXTIpfixUpmProfileType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTIpfixUpmProfileType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Post operation to " + CreateIpfixUpmProfileServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTIpfixUpmProfileListResultType> ListIpfixUpmProfiles(string? AppliedToEntityId = null, string? AppliedToEntityType = null, string? Cursor = null, string? IncludedFields = null, long? PageSize = null, string? ProfileTypes = null, bool? SortAscending = null, string? SortBy = null)
        {
            StringBuilder ListIpfixUpmProfilesServiceURL = new StringBuilder("/ipfix-profiles");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Get
            };
            if (AppliedToEntityId != null) { request.AddQueryParameter("applied_to_entity_id", AppliedToEntityId.ToString()); }
            if (AppliedToEntityType != null) { request.AddQueryParameter("applied_to_entity_type", AppliedToEntityType.ToString()); }
            if (Cursor != null) { request.AddQueryParameter("cursor", Cursor.ToString()); }
            if (IncludedFields != null) { request.AddQueryParameter("included_fields", IncludedFields.ToString()); }
            if (PageSize != null) { request.AddQueryParameter("page_size", PageSize.ToString()); }
            if (ProfileTypes != null) { request.AddQueryParameter("profile_types", ProfileTypes.ToString()); }
            if (SortAscending != null) { request.AddQueryParameter("sort_ascending", SortAscending.ToString()); }
            if (SortBy != null) { request.AddQueryParameter("sort_by", SortBy.ToString()); }
            request.Resource = ListIpfixUpmProfilesServiceURL.ToString();
            RestResponse<NSXTIpfixUpmProfileListResultType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTIpfixUpmProfileListResultType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Get operation to " + ListIpfixUpmProfilesServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTIpfixUpmProfileType> UpdateIpfixUpmProfile(string IpfixProfileId, NSXTIpfixUpmProfileType IpfixUpmProfile)
        {
            if (IpfixProfileId == null) { throw new System.ArgumentNullException("IpfixProfileId cannot be null"); }
            if (IpfixUpmProfile == null) { throw new System.ArgumentNullException("IpfixUpmProfile cannot be null"); }
            StringBuilder UpdateIpfixUpmProfileServiceURL = new StringBuilder("/ipfix-profiles/{ipfix-profile-id}");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Put
            };
            UpdateIpfixUpmProfileServiceURL.Replace("{ipfix-profile-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(IpfixProfileId, System.Globalization.CultureInfo.InvariantCulture)));
            request.AddJsonBody(IpfixUpmProfile);
            request.Resource = UpdateIpfixUpmProfileServiceURL.ToString();
            RestResponse<NSXTIpfixUpmProfileType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTIpfixUpmProfileType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Put operation to " + UpdateIpfixUpmProfileServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTIpfixUpmProfileType> GetIpfixUpmProfile(string IpfixProfileId)
        {
            if (IpfixProfileId == null) { throw new System.ArgumentNullException("IpfixProfileId cannot be null"); }
            StringBuilder GetIpfixUpmProfileServiceURL = new StringBuilder("/ipfix-profiles/{ipfix-profile-id}");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Get
            };
            GetIpfixUpmProfileServiceURL.Replace("{ipfix-profile-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(IpfixProfileId, System.Globalization.CultureInfo.InvariantCulture)));
            request.Resource = GetIpfixUpmProfileServiceURL.ToString();
            RestResponse<NSXTIpfixUpmProfileType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTIpfixUpmProfileType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Get operation to " + GetIpfixUpmProfileServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task DeleteIpfixUpmProfile(string IpfixProfileId)
        {
            if (IpfixProfileId == null) { throw new System.ArgumentNullException("IpfixProfileId cannot be null"); }
            StringBuilder DeleteIpfixUpmProfileServiceURL = new StringBuilder("/ipfix-profiles/{ipfix-profile-id}");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Delete
            };
            DeleteIpfixUpmProfileServiceURL.Replace("{ipfix-profile-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(IpfixProfileId, System.Globalization.CultureInfo.InvariantCulture)));
            request.Resource = DeleteIpfixUpmProfileServiceURL.ToString();
            RestResponse response = await restClient.ExecuteTaskAsyncWithPolicy(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Delete operation to " + DeleteIpfixUpmProfileServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            
        }
    }
}
