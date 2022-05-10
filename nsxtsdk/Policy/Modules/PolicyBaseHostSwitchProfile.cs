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
    public class PolicyBaseHostSwitchProfile
    {
        private RestClient restClient;
        private int retry;
        private int timeout;
        private CancellationToken cancellationToken;

        public PolicyBaseHostSwitchProfile(RestClient Client, CancellationToken _cancellationToken, int _timeout, int _retry)
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
        public async Task<NSXTPolicyHostSwitchProfilesListResultType> ListPolicyHostSwitchProfiles(string? Cursor = null, string? DeploymentType = null, string? HostswitchProfileType = null, bool? IncludeMarkForDeleteObjects = null, bool? IncludeSystemOwned = null, string? IncludedFields = null, int? MaxActiveUplinkCount = null, string? NodeType = null, long? PageSize = null, bool? SortAscending = null, string? SortBy = null, string? UplinkTeamingPolicyName = null)
        {
            StringBuilder ListPolicyHostSwitchProfilesServiceURL = new StringBuilder("/infra/host-switch-profiles");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Get
            };
            if (Cursor != null) { request.AddQueryParameter("cursor", Cursor.ToString()); }
            if (DeploymentType != null) { request.AddQueryParameter("deployment_type", DeploymentType.ToString()); }
            if (HostswitchProfileType != null) { request.AddQueryParameter("hostswitch_profile_type", HostswitchProfileType.ToString()); }
            if (IncludeMarkForDeleteObjects != null) { request.AddQueryParameter("include_mark_for_delete_objects", IncludeMarkForDeleteObjects.ToString()); }
            if (IncludeSystemOwned != null) { request.AddQueryParameter("include_system_owned", IncludeSystemOwned.ToString()); }
            if (IncludedFields != null) { request.AddQueryParameter("included_fields", IncludedFields.ToString()); }
            if (MaxActiveUplinkCount != null) { request.AddQueryParameter("max_active_uplink_count", MaxActiveUplinkCount.ToString()); }
            if (NodeType != null) { request.AddQueryParameter("node_type", NodeType.ToString()); }
            if (PageSize != null) { request.AddQueryParameter("page_size", PageSize.ToString()); }
            if (SortAscending != null) { request.AddQueryParameter("sort_ascending", SortAscending.ToString()); }
            if (SortBy != null) { request.AddQueryParameter("sort_by", SortBy.ToString()); }
            if (UplinkTeamingPolicyName != null) { request.AddQueryParameter("uplink_teaming_policy_name", UplinkTeamingPolicyName.ToString()); }
            request.Resource = ListPolicyHostSwitchProfilesServiceURL.ToString();
            RestResponse<NSXTPolicyHostSwitchProfilesListResultType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTPolicyHostSwitchProfilesListResultType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Get operation to " + ListPolicyHostSwitchProfilesServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTPolicyBaseHostSwitchProfileType> CreateOrUpdatePolicyHostSwitchProfile(string HostSwitchProfileId, NSXTPolicyBaseHostSwitchProfileType PolicyBaseHostSwitchProfile)
        {
            if (HostSwitchProfileId == null) { throw new System.ArgumentNullException("HostSwitchProfileId cannot be null"); }
            if (PolicyBaseHostSwitchProfile == null) { throw new System.ArgumentNullException("PolicyBaseHostSwitchProfile cannot be null"); }
            StringBuilder CreateOrUpdatePolicyHostSwitchProfileServiceURL = new StringBuilder("/infra/host-switch-profiles/{host-switch-profile-id}");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Put
            };
            CreateOrUpdatePolicyHostSwitchProfileServiceURL.Replace("{host-switch-profile-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(HostSwitchProfileId, System.Globalization.CultureInfo.InvariantCulture)));
            request.AddJsonBody(PolicyBaseHostSwitchProfile);
            request.Resource = CreateOrUpdatePolicyHostSwitchProfileServiceURL.ToString();
            RestResponse<NSXTPolicyBaseHostSwitchProfileType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTPolicyBaseHostSwitchProfileType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Put operation to " + CreateOrUpdatePolicyHostSwitchProfileServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTPolicyBaseHostSwitchProfileType> PatchPolicyHostSwitchProfile(string HostSwitchProfileId, NSXTPolicyBaseHostSwitchProfileType PolicyBaseHostSwitchProfile)
        {
            if (HostSwitchProfileId == null) { throw new System.ArgumentNullException("HostSwitchProfileId cannot be null"); }
            if (PolicyBaseHostSwitchProfile == null) { throw new System.ArgumentNullException("PolicyBaseHostSwitchProfile cannot be null"); }
            StringBuilder PatchPolicyHostSwitchProfileServiceURL = new StringBuilder("/infra/host-switch-profiles/{host-switch-profile-id}");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Patch
            };
            PatchPolicyHostSwitchProfileServiceURL.Replace("{host-switch-profile-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(HostSwitchProfileId, System.Globalization.CultureInfo.InvariantCulture)));
            request.AddJsonBody(PolicyBaseHostSwitchProfile);
            request.Resource = PatchPolicyHostSwitchProfileServiceURL.ToString();
            RestResponse<NSXTPolicyBaseHostSwitchProfileType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTPolicyBaseHostSwitchProfileType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Patch operation to " + PatchPolicyHostSwitchProfileServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTPolicyBaseHostSwitchProfileType> GetPolicyHostSwitchProfile(string HostSwitchProfileId)
        {
            if (HostSwitchProfileId == null) { throw new System.ArgumentNullException("HostSwitchProfileId cannot be null"); }
            StringBuilder GetPolicyHostSwitchProfileServiceURL = new StringBuilder("/infra/host-switch-profiles/{host-switch-profile-id}");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Get
            };
            GetPolicyHostSwitchProfileServiceURL.Replace("{host-switch-profile-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(HostSwitchProfileId, System.Globalization.CultureInfo.InvariantCulture)));
            request.Resource = GetPolicyHostSwitchProfileServiceURL.ToString();
            RestResponse<NSXTPolicyBaseHostSwitchProfileType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTPolicyBaseHostSwitchProfileType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Get operation to " + GetPolicyHostSwitchProfileServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task DeletePolicyHostSwitchProfile(string HostSwitchProfileId)
        {
            if (HostSwitchProfileId == null) { throw new System.ArgumentNullException("HostSwitchProfileId cannot be null"); }
            StringBuilder DeletePolicyHostSwitchProfileServiceURL = new StringBuilder("/infra/host-switch-profiles/{host-switch-profile-id}");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Delete
            };
            DeletePolicyHostSwitchProfileServiceURL.Replace("{host-switch-profile-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(HostSwitchProfileId, System.Globalization.CultureInfo.InvariantCulture)));
            request.Resource = DeletePolicyHostSwitchProfileServiceURL.ToString();
            RestResponse response = await restClient.ExecuteTaskAsyncWithPolicy(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Delete operation to " + DeletePolicyHostSwitchProfileServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            
        }
    }
}
