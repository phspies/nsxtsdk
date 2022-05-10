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
    public class ClusterProfile
    {
        private RestClient restClient;
        private int retry;
        private int timeout;
        private CancellationToken cancellationToken;

        public ClusterProfile(RestClient Client, CancellationToken _cancellationToken, int _timeout, int _retry)
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
        public async Task<NSXTClusterProfileType> UpdateClusterProfile(string ClusterProfileId, NSXTClusterProfileType ClusterProfile)
        {
            if (ClusterProfileId == null) { throw new System.ArgumentNullException("ClusterProfileId cannot be null"); }
            if (ClusterProfile == null) { throw new System.ArgumentNullException("ClusterProfile cannot be null"); }
            StringBuilder UpdateClusterProfileServiceURL = new StringBuilder("/cluster-profiles/{cluster-profile-id}");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Put
            };
            UpdateClusterProfileServiceURL.Replace("{cluster-profile-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(ClusterProfileId, System.Globalization.CultureInfo.InvariantCulture)));
            request.AddJsonBody(ClusterProfile);
            request.Resource = UpdateClusterProfileServiceURL.ToString();
            RestResponse<NSXTClusterProfileType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTClusterProfileType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Put operation to " + UpdateClusterProfileServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task DeleteClusterProfile(string ClusterProfileId)
        {
            if (ClusterProfileId == null) { throw new System.ArgumentNullException("ClusterProfileId cannot be null"); }
            StringBuilder DeleteClusterProfileServiceURL = new StringBuilder("/cluster-profiles/{cluster-profile-id}");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Delete
            };
            DeleteClusterProfileServiceURL.Replace("{cluster-profile-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(ClusterProfileId, System.Globalization.CultureInfo.InvariantCulture)));
            request.Resource = DeleteClusterProfileServiceURL.ToString();
            RestResponse response = await restClient.ExecuteTaskAsyncWithPolicy(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Delete operation to " + DeleteClusterProfileServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTClusterProfileType> GetClusterProfile(string ClusterProfileId)
        {
            if (ClusterProfileId == null) { throw new System.ArgumentNullException("ClusterProfileId cannot be null"); }
            StringBuilder GetClusterProfileServiceURL = new StringBuilder("/cluster-profiles/{cluster-profile-id}");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Get
            };
            GetClusterProfileServiceURL.Replace("{cluster-profile-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(ClusterProfileId, System.Globalization.CultureInfo.InvariantCulture)));
            request.Resource = GetClusterProfileServiceURL.ToString();
            RestResponse<NSXTClusterProfileType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTClusterProfileType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Get operation to " + GetClusterProfileServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTClusterProfileType> CreateClusterProfile(NSXTClusterProfileType ClusterProfile)
        {
            if (ClusterProfile == null) { throw new System.ArgumentNullException("ClusterProfile cannot be null"); }
            StringBuilder CreateClusterProfileServiceURL = new StringBuilder("/cluster-profiles");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Post
            };
            request.AddJsonBody(ClusterProfile);
            request.Resource = CreateClusterProfileServiceURL.ToString();
            RestResponse<NSXTClusterProfileType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTClusterProfileType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Post operation to " + CreateClusterProfileServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTClusterProfileListResultType> ListClusterProfiles(string? Cursor = null, bool? IncludeSystemOwned = null, string? IncludedFields = null, long? PageSize = null, string? ResourceType = null, bool? SortAscending = null, string? SortBy = null)
        {
            StringBuilder ListClusterProfilesServiceURL = new StringBuilder("/cluster-profiles");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Get
            };
            if (Cursor != null) { request.AddQueryParameter("cursor", Cursor.ToString()); }
            if (IncludeSystemOwned != null) { request.AddQueryParameter("include_system_owned", IncludeSystemOwned.ToString()); }
            if (IncludedFields != null) { request.AddQueryParameter("included_fields", IncludedFields.ToString()); }
            if (PageSize != null) { request.AddQueryParameter("page_size", PageSize.ToString()); }
            if (ResourceType != null) { request.AddQueryParameter("resource_type", ResourceType.ToString()); }
            if (SortAscending != null) { request.AddQueryParameter("sort_ascending", SortAscending.ToString()); }
            if (SortBy != null) { request.AddQueryParameter("sort_by", SortBy.ToString()); }
            request.Resource = ListClusterProfilesServiceURL.ToString();
            RestResponse<NSXTClusterProfileListResultType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTClusterProfileListResultType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Get operation to " + ListClusterProfilesServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
    }
}
