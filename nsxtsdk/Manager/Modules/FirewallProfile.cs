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
    public class FirewallProfile
    {
        private RestClient restClient;
        private int retry;
        private int timeout;
        private CancellationToken cancellationToken;

        public FirewallProfile(RestClient Client, CancellationToken _cancellationToken, int _timeout, int _retry)
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
        public async Task<NSXTBaseFirewallProfileType> CreateFirewallProfile(NSXTBaseFirewallProfileType BaseFirewallProfile)
        {
            if (BaseFirewallProfile == null) { throw new System.ArgumentNullException("BaseFirewallProfile cannot be null"); }
            StringBuilder CreateFirewallProfileServiceURL = new StringBuilder("/firewall/profiles");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Post
            };
            request.AddJsonBody(BaseFirewallProfile);
            request.Resource = CreateFirewallProfileServiceURL.ToString();
            RestResponse<NSXTBaseFirewallProfileType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTBaseFirewallProfileType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Post operation to " + CreateFirewallProfileServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTFirewallProfileListResultType> ListFirewallProfiles(string ResourceType, string? Cursor = null, string? IncludedFields = null, long? PageSize = null, bool? SortAscending = null, string? SortBy = null)
        {
            if (ResourceType == null) { throw new System.ArgumentNullException("ResourceType cannot be null"); }
            StringBuilder ListFirewallProfilesServiceURL = new StringBuilder("/firewall/profiles");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Get
            };
            if (Cursor != null) { request.AddQueryParameter("cursor", Cursor.ToString()); }
            if (IncludedFields != null) { request.AddQueryParameter("included_fields", IncludedFields.ToString()); }
            if (PageSize != null) { request.AddQueryParameter("page_size", PageSize.ToString()); }
            if (ResourceType != null) { request.AddQueryParameter("resource_type", ResourceType.ToString()); }
            if (SortAscending != null) { request.AddQueryParameter("sort_ascending", SortAscending.ToString()); }
            if (SortBy != null) { request.AddQueryParameter("sort_by", SortBy.ToString()); }
            request.Resource = ListFirewallProfilesServiceURL.ToString();
            RestResponse<NSXTFirewallProfileListResultType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTFirewallProfileListResultType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Get operation to " + ListFirewallProfilesServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTBaseFirewallProfileType> UpdateFirewallProfile(string ProfileId, NSXTBaseFirewallProfileType BaseFirewallProfile)
        {
            if (ProfileId == null) { throw new System.ArgumentNullException("ProfileId cannot be null"); }
            if (BaseFirewallProfile == null) { throw new System.ArgumentNullException("BaseFirewallProfile cannot be null"); }
            StringBuilder UpdateFirewallProfileServiceURL = new StringBuilder("/firewall/profiles/{profile-id}");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Put
            };
            UpdateFirewallProfileServiceURL.Replace("{profile-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(ProfileId, System.Globalization.CultureInfo.InvariantCulture)));
            request.AddJsonBody(BaseFirewallProfile);
            request.Resource = UpdateFirewallProfileServiceURL.ToString();
            RestResponse<NSXTBaseFirewallProfileType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTBaseFirewallProfileType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Put operation to " + UpdateFirewallProfileServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task DeleteFirewallProfile(string ProfileId)
        {
            if (ProfileId == null) { throw new System.ArgumentNullException("ProfileId cannot be null"); }
            StringBuilder DeleteFirewallProfileServiceURL = new StringBuilder("/firewall/profiles/{profile-id}");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Delete
            };
            DeleteFirewallProfileServiceURL.Replace("{profile-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(ProfileId, System.Globalization.CultureInfo.InvariantCulture)));
            request.Resource = DeleteFirewallProfileServiceURL.ToString();
            RestResponse response = await restClient.ExecuteTaskAsyncWithPolicy(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Delete operation to " + DeleteFirewallProfileServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTBaseFirewallProfileType> GetFirewallProfile(string ProfileId)
        {
            if (ProfileId == null) { throw new System.ArgumentNullException("ProfileId cannot be null"); }
            StringBuilder GetFirewallProfileServiceURL = new StringBuilder("/firewall/profiles/{profile-id}");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Get
            };
            GetFirewallProfileServiceURL.Replace("{profile-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(ProfileId, System.Globalization.CultureInfo.InvariantCulture)));
            request.Resource = GetFirewallProfileServiceURL.ToString();
            RestResponse<NSXTBaseFirewallProfileType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTBaseFirewallProfileType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Get operation to " + GetFirewallProfileServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
    }
}
