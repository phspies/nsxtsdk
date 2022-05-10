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
    public class PolicyFirewallSessionTimerProfile
    {
        private RestClient restClient;
        private int retry;
        private int timeout;
        private CancellationToken cancellationToken;

        public PolicyFirewallSessionTimerProfile(RestClient Client, CancellationToken _cancellationToken, int _timeout, int _retry)
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
        public async Task<NSXTPolicyFirewallSessionTimerProfileType> GlobalGlobalInfraUpdatePolicyFirewallSessionTimerProfile(string FirewallSessionTimerProfileId, NSXTPolicyFirewallSessionTimerProfileType PolicyFirewallSessionTimerProfile, bool? Override = null)
        {
            if (FirewallSessionTimerProfileId == null) { throw new System.ArgumentNullException("FirewallSessionTimerProfileId cannot be null"); }
            if (PolicyFirewallSessionTimerProfile == null) { throw new System.ArgumentNullException("PolicyFirewallSessionTimerProfile cannot be null"); }
            StringBuilder GlobalInfraUpdatePolicyFirewallSessionTimerProfileServiceURL = new StringBuilder("/global-infra/firewall-session-timer-profiles/{firewall-session-timer-profile-id}");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Put
            };
            GlobalInfraUpdatePolicyFirewallSessionTimerProfileServiceURL.Replace("{firewall-session-timer-profile-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(FirewallSessionTimerProfileId, System.Globalization.CultureInfo.InvariantCulture)));
            request.AddJsonBody(PolicyFirewallSessionTimerProfile);
            if (Override != null) { request.AddQueryParameter("override", Override.ToString()); }
            request.Resource = GlobalInfraUpdatePolicyFirewallSessionTimerProfileServiceURL.ToString();
            RestResponse<NSXTPolicyFirewallSessionTimerProfileType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTPolicyFirewallSessionTimerProfileType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Put operation to " + GlobalInfraUpdatePolicyFirewallSessionTimerProfileServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTPolicyFirewallSessionTimerProfileType> GlobalGlobalInfraGetPolicyFirewallSessionTimerProfile(string FirewallSessionTimerProfileId)
        {
            if (FirewallSessionTimerProfileId == null) { throw new System.ArgumentNullException("FirewallSessionTimerProfileId cannot be null"); }
            StringBuilder GlobalInfraGetPolicyFirewallSessionTimerProfileServiceURL = new StringBuilder("/global-infra/firewall-session-timer-profiles/{firewall-session-timer-profile-id}");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Get
            };
            GlobalInfraGetPolicyFirewallSessionTimerProfileServiceURL.Replace("{firewall-session-timer-profile-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(FirewallSessionTimerProfileId, System.Globalization.CultureInfo.InvariantCulture)));
            request.Resource = GlobalInfraGetPolicyFirewallSessionTimerProfileServiceURL.ToString();
            RestResponse<NSXTPolicyFirewallSessionTimerProfileType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTPolicyFirewallSessionTimerProfileType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Get operation to " + GlobalInfraGetPolicyFirewallSessionTimerProfileServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task GlobalGlobalInfraDeletePolicyFirewallSessionTimerProfile(string FirewallSessionTimerProfileId, bool? Override = null)
        {
            if (FirewallSessionTimerProfileId == null) { throw new System.ArgumentNullException("FirewallSessionTimerProfileId cannot be null"); }
            StringBuilder GlobalInfraDeletePolicyFirewallSessionTimerProfileServiceURL = new StringBuilder("/global-infra/firewall-session-timer-profiles/{firewall-session-timer-profile-id}");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Delete
            };
            GlobalInfraDeletePolicyFirewallSessionTimerProfileServiceURL.Replace("{firewall-session-timer-profile-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(FirewallSessionTimerProfileId, System.Globalization.CultureInfo.InvariantCulture)));
            if (Override != null) { request.AddQueryParameter("override", Override.ToString()); }
            request.Resource = GlobalInfraDeletePolicyFirewallSessionTimerProfileServiceURL.ToString();
            RestResponse response = await restClient.ExecuteTaskAsyncWithPolicy(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Delete operation to " + GlobalInfraDeletePolicyFirewallSessionTimerProfileServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task GlobalGlobalInfraPatchPolicyFirewallSessionTimerProfile(string FirewallSessionTimerProfileId, NSXTPolicyFirewallSessionTimerProfileType PolicyFirewallSessionTimerProfile, bool? Override = null)
        {
            if (FirewallSessionTimerProfileId == null) { throw new System.ArgumentNullException("FirewallSessionTimerProfileId cannot be null"); }
            if (PolicyFirewallSessionTimerProfile == null) { throw new System.ArgumentNullException("PolicyFirewallSessionTimerProfile cannot be null"); }
            StringBuilder GlobalInfraPatchPolicyFirewallSessionTimerProfileServiceURL = new StringBuilder("/global-infra/firewall-session-timer-profiles/{firewall-session-timer-profile-id}");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Patch
            };
            GlobalInfraPatchPolicyFirewallSessionTimerProfileServiceURL.Replace("{firewall-session-timer-profile-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(FirewallSessionTimerProfileId, System.Globalization.CultureInfo.InvariantCulture)));
            request.AddJsonBody(PolicyFirewallSessionTimerProfile);
            if (Override != null) { request.AddQueryParameter("override", Override.ToString()); }
            request.Resource = GlobalInfraPatchPolicyFirewallSessionTimerProfileServiceURL.ToString();
            RestResponse response = await restClient.ExecuteTaskAsyncWithPolicy(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Patch operation to " + GlobalInfraPatchPolicyFirewallSessionTimerProfileServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTPolicyFirewallSessionTimerProfileListResultType> ListPolicyFirewallSessionTimerProfiles(string? Cursor = null, bool? IncludeMarkForDeleteObjects = null, string? IncludedFields = null, long? PageSize = null, bool? SortAscending = null, string? SortBy = null)
        {
            StringBuilder ListPolicyFirewallSessionTimerProfilesServiceURL = new StringBuilder("/infra/firewall-session-timer-profiles");
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
            request.Resource = ListPolicyFirewallSessionTimerProfilesServiceURL.ToString();
            RestResponse<NSXTPolicyFirewallSessionTimerProfileListResultType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTPolicyFirewallSessionTimerProfileListResultType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Get operation to " + ListPolicyFirewallSessionTimerProfilesServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTPolicyFirewallSessionTimerProfileListResultType> GlobalGlobalInfraListPolicyFirewallSessionTimerProfiles(string? Cursor = null, bool? IncludeMarkForDeleteObjects = null, string? IncludedFields = null, long? PageSize = null, bool? SortAscending = null, string? SortBy = null)
        {
            StringBuilder GlobalInfraListPolicyFirewallSessionTimerProfilesServiceURL = new StringBuilder("/global-infra/firewall-session-timer-profiles");
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
            request.Resource = GlobalInfraListPolicyFirewallSessionTimerProfilesServiceURL.ToString();
            RestResponse<NSXTPolicyFirewallSessionTimerProfileListResultType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTPolicyFirewallSessionTimerProfileListResultType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Get operation to " + GlobalInfraListPolicyFirewallSessionTimerProfilesServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTPolicyFirewallSessionTimerProfileType> UpdatePolicyFirewallSessionTimerProfile(string FirewallSessionTimerProfileId, NSXTPolicyFirewallSessionTimerProfileType PolicyFirewallSessionTimerProfile, bool? Override = null)
        {
            if (FirewallSessionTimerProfileId == null) { throw new System.ArgumentNullException("FirewallSessionTimerProfileId cannot be null"); }
            if (PolicyFirewallSessionTimerProfile == null) { throw new System.ArgumentNullException("PolicyFirewallSessionTimerProfile cannot be null"); }
            StringBuilder UpdatePolicyFirewallSessionTimerProfileServiceURL = new StringBuilder("/infra/firewall-session-timer-profiles/{firewall-session-timer-profile-id}");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Put
            };
            UpdatePolicyFirewallSessionTimerProfileServiceURL.Replace("{firewall-session-timer-profile-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(FirewallSessionTimerProfileId, System.Globalization.CultureInfo.InvariantCulture)));
            request.AddJsonBody(PolicyFirewallSessionTimerProfile);
            if (Override != null) { request.AddQueryParameter("override", Override.ToString()); }
            request.Resource = UpdatePolicyFirewallSessionTimerProfileServiceURL.ToString();
            RestResponse<NSXTPolicyFirewallSessionTimerProfileType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTPolicyFirewallSessionTimerProfileType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Put operation to " + UpdatePolicyFirewallSessionTimerProfileServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTPolicyFirewallSessionTimerProfileType> GetPolicyFirewallSessionTimerProfile(string FirewallSessionTimerProfileId)
        {
            if (FirewallSessionTimerProfileId == null) { throw new System.ArgumentNullException("FirewallSessionTimerProfileId cannot be null"); }
            StringBuilder GetPolicyFirewallSessionTimerProfileServiceURL = new StringBuilder("/infra/firewall-session-timer-profiles/{firewall-session-timer-profile-id}");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Get
            };
            GetPolicyFirewallSessionTimerProfileServiceURL.Replace("{firewall-session-timer-profile-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(FirewallSessionTimerProfileId, System.Globalization.CultureInfo.InvariantCulture)));
            request.Resource = GetPolicyFirewallSessionTimerProfileServiceURL.ToString();
            RestResponse<NSXTPolicyFirewallSessionTimerProfileType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTPolicyFirewallSessionTimerProfileType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Get operation to " + GetPolicyFirewallSessionTimerProfileServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task DeletePolicyFirewallSessionTimerProfile(string FirewallSessionTimerProfileId, bool? Override = null)
        {
            if (FirewallSessionTimerProfileId == null) { throw new System.ArgumentNullException("FirewallSessionTimerProfileId cannot be null"); }
            StringBuilder DeletePolicyFirewallSessionTimerProfileServiceURL = new StringBuilder("/infra/firewall-session-timer-profiles/{firewall-session-timer-profile-id}");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Delete
            };
            DeletePolicyFirewallSessionTimerProfileServiceURL.Replace("{firewall-session-timer-profile-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(FirewallSessionTimerProfileId, System.Globalization.CultureInfo.InvariantCulture)));
            if (Override != null) { request.AddQueryParameter("override", Override.ToString()); }
            request.Resource = DeletePolicyFirewallSessionTimerProfileServiceURL.ToString();
            RestResponse response = await restClient.ExecuteTaskAsyncWithPolicy(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Delete operation to " + DeletePolicyFirewallSessionTimerProfileServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task PatchPolicyFirewallSessionTimerProfile(string FirewallSessionTimerProfileId, NSXTPolicyFirewallSessionTimerProfileType PolicyFirewallSessionTimerProfile, bool? Override = null)
        {
            if (FirewallSessionTimerProfileId == null) { throw new System.ArgumentNullException("FirewallSessionTimerProfileId cannot be null"); }
            if (PolicyFirewallSessionTimerProfile == null) { throw new System.ArgumentNullException("PolicyFirewallSessionTimerProfile cannot be null"); }
            StringBuilder PatchPolicyFirewallSessionTimerProfileServiceURL = new StringBuilder("/infra/firewall-session-timer-profiles/{firewall-session-timer-profile-id}");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Patch
            };
            PatchPolicyFirewallSessionTimerProfileServiceURL.Replace("{firewall-session-timer-profile-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(FirewallSessionTimerProfileId, System.Globalization.CultureInfo.InvariantCulture)));
            request.AddJsonBody(PolicyFirewallSessionTimerProfile);
            if (Override != null) { request.AddQueryParameter("override", Override.ToString()); }
            request.Resource = PatchPolicyFirewallSessionTimerProfileServiceURL.ToString();
            RestResponse response = await restClient.ExecuteTaskAsyncWithPolicy(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Patch operation to " + PatchPolicyFirewallSessionTimerProfileServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            
        }
    }
}
