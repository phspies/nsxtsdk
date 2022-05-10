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
    public class BaseHostSwitchProfile
    {
        private RestClient restClient;
        private int retry;
        private int timeout;
        private CancellationToken cancellationToken;

        public BaseHostSwitchProfile(RestClient Client, CancellationToken _cancellationToken, int _timeout, int _retry)
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
        public async Task<NSXTBaseHostSwitchProfileType> UpdateHostSwitchProfile(string HostSwitchProfileId, NSXTBaseHostSwitchProfileType BaseHostSwitchProfile)
        {
            if (HostSwitchProfileId == null) { throw new System.ArgumentNullException("HostSwitchProfileId cannot be null"); }
            if (BaseHostSwitchProfile == null) { throw new System.ArgumentNullException("BaseHostSwitchProfile cannot be null"); }
            StringBuilder UpdateHostSwitchProfileServiceURL = new StringBuilder("/host-switch-profiles/{host-switch-profile-id}");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Put
            };
            UpdateHostSwitchProfileServiceURL.Replace("{host-switch-profile-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(HostSwitchProfileId, System.Globalization.CultureInfo.InvariantCulture)));
            request.AddJsonBody(BaseHostSwitchProfile);
            request.Resource = UpdateHostSwitchProfileServiceURL.ToString();
            RestResponse<NSXTBaseHostSwitchProfileType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTBaseHostSwitchProfileType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Put operation to " + UpdateHostSwitchProfileServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTBaseHostSwitchProfileType> GetHostSwitchProfile(string HostSwitchProfileId)
        {
            if (HostSwitchProfileId == null) { throw new System.ArgumentNullException("HostSwitchProfileId cannot be null"); }
            StringBuilder GetHostSwitchProfileServiceURL = new StringBuilder("/host-switch-profiles/{host-switch-profile-id}");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Get
            };
            GetHostSwitchProfileServiceURL.Replace("{host-switch-profile-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(HostSwitchProfileId, System.Globalization.CultureInfo.InvariantCulture)));
            request.Resource = GetHostSwitchProfileServiceURL.ToString();
            RestResponse<NSXTBaseHostSwitchProfileType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTBaseHostSwitchProfileType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Get operation to " + GetHostSwitchProfileServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task DeleteHostSwitchProfile(string HostSwitchProfileId)
        {
            if (HostSwitchProfileId == null) { throw new System.ArgumentNullException("HostSwitchProfileId cannot be null"); }
            StringBuilder DeleteHostSwitchProfileServiceURL = new StringBuilder("/host-switch-profiles/{host-switch-profile-id}");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Delete
            };
            DeleteHostSwitchProfileServiceURL.Replace("{host-switch-profile-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(HostSwitchProfileId, System.Globalization.CultureInfo.InvariantCulture)));
            request.Resource = DeleteHostSwitchProfileServiceURL.ToString();
            RestResponse response = await restClient.ExecuteTaskAsyncWithPolicy(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Delete operation to " + DeleteHostSwitchProfileServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTBaseHostSwitchProfileType> CreateHostSwitchProfile(NSXTBaseHostSwitchProfileType BaseHostSwitchProfile)
        {
            if (BaseHostSwitchProfile == null) { throw new System.ArgumentNullException("BaseHostSwitchProfile cannot be null"); }
            StringBuilder CreateHostSwitchProfileServiceURL = new StringBuilder("/host-switch-profiles");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Post
            };
            request.AddJsonBody(BaseHostSwitchProfile);
            request.Resource = CreateHostSwitchProfileServiceURL.ToString();
            RestResponse<NSXTBaseHostSwitchProfileType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTBaseHostSwitchProfileType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Post operation to " + CreateHostSwitchProfileServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTHostSwitchProfilesListResultType> ListHostSwitchProfiles(string? Cursor = null, string? DeploymentType = null, string? HostswitchProfileType = null, bool? IncludeSystemOwned = null, string? IncludedFields = null, string? NodeType = null, long? PageSize = null, bool? SortAscending = null, string? SortBy = null, string? UplinkTeamingPolicyName = null)
        {
            StringBuilder ListHostSwitchProfilesServiceURL = new StringBuilder("/host-switch-profiles");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Get
            };
            if (Cursor != null) { request.AddQueryParameter("cursor", Cursor.ToString()); }
            if (DeploymentType != null) { request.AddQueryParameter("deployment_type", DeploymentType.ToString()); }
            if (HostswitchProfileType != null) { request.AddQueryParameter("hostswitch_profile_type", HostswitchProfileType.ToString()); }
            if (IncludeSystemOwned != null) { request.AddQueryParameter("include_system_owned", IncludeSystemOwned.ToString()); }
            if (IncludedFields != null) { request.AddQueryParameter("included_fields", IncludedFields.ToString()); }
            if (NodeType != null) { request.AddQueryParameter("node_type", NodeType.ToString()); }
            if (PageSize != null) { request.AddQueryParameter("page_size", PageSize.ToString()); }
            if (SortAscending != null) { request.AddQueryParameter("sort_ascending", SortAscending.ToString()); }
            if (SortBy != null) { request.AddQueryParameter("sort_by", SortBy.ToString()); }
            if (UplinkTeamingPolicyName != null) { request.AddQueryParameter("uplink_teaming_policy_name", UplinkTeamingPolicyName.ToString()); }
            request.Resource = ListHostSwitchProfilesServiceURL.ToString();
            RestResponse<NSXTHostSwitchProfilesListResultType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTHostSwitchProfilesListResultType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Get operation to " + ListHostSwitchProfilesServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
    }
}
