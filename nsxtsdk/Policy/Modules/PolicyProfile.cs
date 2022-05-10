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
    public class PolicyProfile
    {
        private RestClient restClient;
        private int retry;
        private int timeout;
        private CancellationToken cancellationToken;

        public PolicyProfile(RestClient Client, CancellationToken _cancellationToken, int _timeout, int _retry)
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
        public async Task<NSXTDnsSecurityProfileListResultType> ListDnsSecurityProfiles(string? Cursor = null, bool? IncludeMarkForDeleteObjects = null, string? IncludedFields = null, long? PageSize = null, bool? SortAscending = null, string? SortBy = null)
        {
            StringBuilder ListDnsSecurityProfilesServiceURL = new StringBuilder("/infra/dns-security-profiles");
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
            request.Resource = ListDnsSecurityProfilesServiceURL.ToString();
            RestResponse<NSXTDnsSecurityProfileListResultType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTDnsSecurityProfileListResultType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Get operation to " + ListDnsSecurityProfilesServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTPolicyFirewallCpuMemThresholdsProfileListResultType> GlobalGlobalInfraListCpumemThresholdsProfiles(string? Cursor = null, bool? IncludeMarkForDeleteObjects = null, string? IncludedFields = null, long? PageSize = null, bool? SortAscending = null, string? SortBy = null)
        {
            StringBuilder GlobalInfraListCpumemThresholdsProfilesServiceURL = new StringBuilder("/global-infra/settings/firewall/cpu-mem-thresholds-profiles");
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
            request.Resource = GlobalInfraListCpumemThresholdsProfilesServiceURL.ToString();
            RestResponse<NSXTPolicyFirewallCpuMemThresholdsProfileListResultType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTPolicyFirewallCpuMemThresholdsProfileListResultType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Get operation to " + GlobalInfraListCpumemThresholdsProfilesServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTFloodProtectionProfileListResultType> GlobalGlobalInfraListFloodProtectionProfiles(string? Cursor = null, bool? IncludeMarkForDeleteObjects = null, string? IncludedFields = null, long? PageSize = null, bool? SortAscending = null, string? SortBy = null)
        {
            StringBuilder GlobalInfraListFloodProtectionProfilesServiceURL = new StringBuilder("/global-infra/flood-protection-profiles");
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
            request.Resource = GlobalInfraListFloodProtectionProfilesServiceURL.ToString();
            RestResponse<NSXTFloodProtectionProfileListResultType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTFloodProtectionProfileListResultType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Get operation to " + GlobalInfraListFloodProtectionProfilesServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTFloodProtectionProfileBindingListResultType> ListFloodProtectionProfileBindings(string FloodProtectionProfileId, string? Cursor = null, bool? IncludeMarkForDeleteObjects = null, string? IncludedFields = null, long? PageSize = null, bool? SortAscending = null, string? SortBy = null)
        {
            if (FloodProtectionProfileId == null) { throw new System.ArgumentNullException("FloodProtectionProfileId cannot be null"); }
            StringBuilder ListFloodProtectionProfileBindingsServiceURL = new StringBuilder("/infra/flood-protection-profiles/{flood-protection-profile-id}/bindings");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Get
            };
            ListFloodProtectionProfileBindingsServiceURL.Replace("{flood-protection-profile-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(FloodProtectionProfileId, System.Globalization.CultureInfo.InvariantCulture)));
            if (Cursor != null) { request.AddQueryParameter("cursor", Cursor.ToString()); }
            if (IncludeMarkForDeleteObjects != null) { request.AddQueryParameter("include_mark_for_delete_objects", IncludeMarkForDeleteObjects.ToString()); }
            if (IncludedFields != null) { request.AddQueryParameter("included_fields", IncludedFields.ToString()); }
            if (PageSize != null) { request.AddQueryParameter("page_size", PageSize.ToString()); }
            if (SortAscending != null) { request.AddQueryParameter("sort_ascending", SortAscending.ToString()); }
            if (SortBy != null) { request.AddQueryParameter("sort_by", SortBy.ToString()); }
            request.Resource = ListFloodProtectionProfileBindingsServiceURL.ToString();
            RestResponse<NSXTFloodProtectionProfileBindingListResultType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTFloodProtectionProfileBindingListResultType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Get operation to " + ListFloodProtectionProfileBindingsServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTPolicyFirewallCpuMemThresholdsProfileType> UpdateCpumemThresholdsProfile(string ProfileId, NSXTPolicyFirewallCpuMemThresholdsProfileType PolicyFirewallCpuMemThresholdsProfile, bool? Override = null)
        {
            if (ProfileId == null) { throw new System.ArgumentNullException("ProfileId cannot be null"); }
            if (PolicyFirewallCpuMemThresholdsProfile == null) { throw new System.ArgumentNullException("PolicyFirewallCpuMemThresholdsProfile cannot be null"); }
            StringBuilder UpdateCpumemThresholdsProfileServiceURL = new StringBuilder("/infra/settings/firewall/cpu-mem-thresholds-profiles/{profile-id}");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Put
            };
            UpdateCpumemThresholdsProfileServiceURL.Replace("{profile-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(ProfileId, System.Globalization.CultureInfo.InvariantCulture)));
            request.AddJsonBody(PolicyFirewallCpuMemThresholdsProfile);
            if (Override != null) { request.AddQueryParameter("override", Override.ToString()); }
            request.Resource = UpdateCpumemThresholdsProfileServiceURL.ToString();
            RestResponse<NSXTPolicyFirewallCpuMemThresholdsProfileType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTPolicyFirewallCpuMemThresholdsProfileType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Put operation to " + UpdateCpumemThresholdsProfileServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task DeleteCpumemThresholdsProfile(string ProfileId, bool? Override = null)
        {
            if (ProfileId == null) { throw new System.ArgumentNullException("ProfileId cannot be null"); }
            StringBuilder DeleteCpumemThresholdsProfileServiceURL = new StringBuilder("/infra/settings/firewall/cpu-mem-thresholds-profiles/{profile-id}");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Delete
            };
            DeleteCpumemThresholdsProfileServiceURL.Replace("{profile-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(ProfileId, System.Globalization.CultureInfo.InvariantCulture)));
            if (Override != null) { request.AddQueryParameter("override", Override.ToString()); }
            request.Resource = DeleteCpumemThresholdsProfileServiceURL.ToString();
            RestResponse response = await restClient.ExecuteTaskAsyncWithPolicy(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Delete operation to " + DeleteCpumemThresholdsProfileServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTPolicyFirewallCpuMemThresholdsProfileType> ReadCpumemThresholdsProfile(string ProfileId)
        {
            if (ProfileId == null) { throw new System.ArgumentNullException("ProfileId cannot be null"); }
            StringBuilder ReadCpumemThresholdsProfileServiceURL = new StringBuilder("/infra/settings/firewall/cpu-mem-thresholds-profiles/{profile-id}");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Get
            };
            ReadCpumemThresholdsProfileServiceURL.Replace("{profile-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(ProfileId, System.Globalization.CultureInfo.InvariantCulture)));
            request.Resource = ReadCpumemThresholdsProfileServiceURL.ToString();
            RestResponse<NSXTPolicyFirewallCpuMemThresholdsProfileType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTPolicyFirewallCpuMemThresholdsProfileType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Get operation to " + ReadCpumemThresholdsProfileServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task PatchCpumemThresholdsProfile(string ProfileId, NSXTPolicyFirewallCpuMemThresholdsProfileType PolicyFirewallCpuMemThresholdsProfile, bool? Override = null)
        {
            if (ProfileId == null) { throw new System.ArgumentNullException("ProfileId cannot be null"); }
            if (PolicyFirewallCpuMemThresholdsProfile == null) { throw new System.ArgumentNullException("PolicyFirewallCpuMemThresholdsProfile cannot be null"); }
            StringBuilder PatchCpumemThresholdsProfileServiceURL = new StringBuilder("/infra/settings/firewall/cpu-mem-thresholds-profiles/{profile-id}");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Patch
            };
            PatchCpumemThresholdsProfileServiceURL.Replace("{profile-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(ProfileId, System.Globalization.CultureInfo.InvariantCulture)));
            request.AddJsonBody(PolicyFirewallCpuMemThresholdsProfile);
            if (Override != null) { request.AddQueryParameter("override", Override.ToString()); }
            request.Resource = PatchCpumemThresholdsProfileServiceURL.ToString();
            RestResponse response = await restClient.ExecuteTaskAsyncWithPolicy(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Patch operation to " + PatchCpumemThresholdsProfileServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTFloodProtectionProfileBindingListResultType> GlobalGlobalInfraListFloodProtectionProfileBindings(string FloodProtectionProfileId, string? Cursor = null, bool? IncludeMarkForDeleteObjects = null, string? IncludedFields = null, long? PageSize = null, bool? SortAscending = null, string? SortBy = null)
        {
            if (FloodProtectionProfileId == null) { throw new System.ArgumentNullException("FloodProtectionProfileId cannot be null"); }
            StringBuilder GlobalInfraListFloodProtectionProfileBindingsServiceURL = new StringBuilder("/global-infra/flood-protection-profiles/{flood-protection-profile-id}/bindings");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Get
            };
            GlobalInfraListFloodProtectionProfileBindingsServiceURL.Replace("{flood-protection-profile-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(FloodProtectionProfileId, System.Globalization.CultureInfo.InvariantCulture)));
            if (Cursor != null) { request.AddQueryParameter("cursor", Cursor.ToString()); }
            if (IncludeMarkForDeleteObjects != null) { request.AddQueryParameter("include_mark_for_delete_objects", IncludeMarkForDeleteObjects.ToString()); }
            if (IncludedFields != null) { request.AddQueryParameter("included_fields", IncludedFields.ToString()); }
            if (PageSize != null) { request.AddQueryParameter("page_size", PageSize.ToString()); }
            if (SortAscending != null) { request.AddQueryParameter("sort_ascending", SortAscending.ToString()); }
            if (SortBy != null) { request.AddQueryParameter("sort_by", SortBy.ToString()); }
            request.Resource = GlobalInfraListFloodProtectionProfileBindingsServiceURL.ToString();
            RestResponse<NSXTFloodProtectionProfileBindingListResultType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTFloodProtectionProfileBindingListResultType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Get operation to " + GlobalInfraListFloodProtectionProfileBindingsServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTDnsSecurityProfileListResultType> GlobalGlobalInfraListDnsSecurityProfiles(string? Cursor = null, bool? IncludeMarkForDeleteObjects = null, string? IncludedFields = null, long? PageSize = null, bool? SortAscending = null, string? SortBy = null)
        {
            StringBuilder GlobalInfraListDnsSecurityProfilesServiceURL = new StringBuilder("/global-infra/dns-security-profiles");
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
            request.Resource = GlobalInfraListDnsSecurityProfilesServiceURL.ToString();
            RestResponse<NSXTDnsSecurityProfileListResultType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTDnsSecurityProfileListResultType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Get operation to " + GlobalInfraListDnsSecurityProfilesServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTSessionTimerProfileBindingListResultType> ListSessionTimerProfileBindings(string SessionTimerProfileId, string? Cursor = null, bool? IncludeMarkForDeleteObjects = null, string? IncludedFields = null, long? PageSize = null, bool? SortAscending = null, string? SortBy = null)
        {
            if (SessionTimerProfileId == null) { throw new System.ArgumentNullException("SessionTimerProfileId cannot be null"); }
            StringBuilder ListSessionTimerProfileBindingsServiceURL = new StringBuilder("/infra/session-timer-profiles/{session-timer-profile-id}/bindings");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Get
            };
            ListSessionTimerProfileBindingsServiceURL.Replace("{session-timer-profile-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(SessionTimerProfileId, System.Globalization.CultureInfo.InvariantCulture)));
            if (Cursor != null) { request.AddQueryParameter("cursor", Cursor.ToString()); }
            if (IncludeMarkForDeleteObjects != null) { request.AddQueryParameter("include_mark_for_delete_objects", IncludeMarkForDeleteObjects.ToString()); }
            if (IncludedFields != null) { request.AddQueryParameter("included_fields", IncludedFields.ToString()); }
            if (PageSize != null) { request.AddQueryParameter("page_size", PageSize.ToString()); }
            if (SortAscending != null) { request.AddQueryParameter("sort_ascending", SortAscending.ToString()); }
            if (SortBy != null) { request.AddQueryParameter("sort_by", SortBy.ToString()); }
            request.Resource = ListSessionTimerProfileBindingsServiceURL.ToString();
            RestResponse<NSXTSessionTimerProfileBindingListResultType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTSessionTimerProfileBindingListResultType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Get operation to " + ListSessionTimerProfileBindingsServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTDnsSecurityProfileType> UpdateDnsSecurityProfile(string ProfileId, NSXTDnsSecurityProfileType DnsSecurityProfile, bool? Override = null)
        {
            if (ProfileId == null) { throw new System.ArgumentNullException("ProfileId cannot be null"); }
            if (DnsSecurityProfile == null) { throw new System.ArgumentNullException("DnsSecurityProfile cannot be null"); }
            StringBuilder UpdateDnsSecurityProfileServiceURL = new StringBuilder("/infra/dns-security-profiles/{profile-id}");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Put
            };
            UpdateDnsSecurityProfileServiceURL.Replace("{profile-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(ProfileId, System.Globalization.CultureInfo.InvariantCulture)));
            request.AddJsonBody(DnsSecurityProfile);
            if (Override != null) { request.AddQueryParameter("override", Override.ToString()); }
            request.Resource = UpdateDnsSecurityProfileServiceURL.ToString();
            RestResponse<NSXTDnsSecurityProfileType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTDnsSecurityProfileType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Put operation to " + UpdateDnsSecurityProfileServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTDnsSecurityProfileType> ReadDnsSecurityProfile(string ProfileId)
        {
            if (ProfileId == null) { throw new System.ArgumentNullException("ProfileId cannot be null"); }
            StringBuilder ReadDnsSecurityProfileServiceURL = new StringBuilder("/infra/dns-security-profiles/{profile-id}");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Get
            };
            ReadDnsSecurityProfileServiceURL.Replace("{profile-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(ProfileId, System.Globalization.CultureInfo.InvariantCulture)));
            request.Resource = ReadDnsSecurityProfileServiceURL.ToString();
            RestResponse<NSXTDnsSecurityProfileType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTDnsSecurityProfileType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Get operation to " + ReadDnsSecurityProfileServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task PatchDnsSecurityProfile(string ProfileId, NSXTDnsSecurityProfileType DnsSecurityProfile, bool? Override = null)
        {
            if (ProfileId == null) { throw new System.ArgumentNullException("ProfileId cannot be null"); }
            if (DnsSecurityProfile == null) { throw new System.ArgumentNullException("DnsSecurityProfile cannot be null"); }
            StringBuilder PatchDnsSecurityProfileServiceURL = new StringBuilder("/infra/dns-security-profiles/{profile-id}");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Patch
            };
            PatchDnsSecurityProfileServiceURL.Replace("{profile-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(ProfileId, System.Globalization.CultureInfo.InvariantCulture)));
            request.AddJsonBody(DnsSecurityProfile);
            if (Override != null) { request.AddQueryParameter("override", Override.ToString()); }
            request.Resource = PatchDnsSecurityProfileServiceURL.ToString();
            RestResponse response = await restClient.ExecuteTaskAsyncWithPolicy(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Patch operation to " + PatchDnsSecurityProfileServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task DeleteDnsSecurityProfile(string ProfileId, bool? Override = null)
        {
            if (ProfileId == null) { throw new System.ArgumentNullException("ProfileId cannot be null"); }
            StringBuilder DeleteDnsSecurityProfileServiceURL = new StringBuilder("/infra/dns-security-profiles/{profile-id}");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Delete
            };
            DeleteDnsSecurityProfileServiceURL.Replace("{profile-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(ProfileId, System.Globalization.CultureInfo.InvariantCulture)));
            if (Override != null) { request.AddQueryParameter("override", Override.ToString()); }
            request.Resource = DeleteDnsSecurityProfileServiceURL.ToString();
            RestResponse response = await restClient.ExecuteTaskAsyncWithPolicy(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Delete operation to " + DeleteDnsSecurityProfileServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTPolicyFirewallCpuMemThresholdsProfileListResultType> ListCpumemThresholdsProfiles(string? Cursor = null, bool? IncludeMarkForDeleteObjects = null, string? IncludedFields = null, long? PageSize = null, bool? SortAscending = null, string? SortBy = null)
        {
            StringBuilder ListCpumemThresholdsProfilesServiceURL = new StringBuilder("/infra/settings/firewall/cpu-mem-thresholds-profiles");
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
            request.Resource = ListCpumemThresholdsProfilesServiceURL.ToString();
            RestResponse<NSXTPolicyFirewallCpuMemThresholdsProfileListResultType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTPolicyFirewallCpuMemThresholdsProfileListResultType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Get operation to " + ListCpumemThresholdsProfilesServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTFloodProtectionProfileListResultType> ListFloodProtectionProfiles(string? Cursor = null, bool? IncludeMarkForDeleteObjects = null, string? IncludedFields = null, long? PageSize = null, bool? SortAscending = null, string? SortBy = null)
        {
            StringBuilder ListFloodProtectionProfilesServiceURL = new StringBuilder("/infra/flood-protection-profiles");
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
            request.Resource = ListFloodProtectionProfilesServiceURL.ToString();
            RestResponse<NSXTFloodProtectionProfileListResultType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTFloodProtectionProfileListResultType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Get operation to " + ListFloodProtectionProfilesServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTFloodProtectionProfileType> UpdateFloodProtectionProfile(string FloodProtectionProfileId, NSXTFloodProtectionProfileType FloodProtectionProfile, bool? Override = null)
        {
            if (FloodProtectionProfileId == null) { throw new System.ArgumentNullException("FloodProtectionProfileId cannot be null"); }
            if (FloodProtectionProfile == null) { throw new System.ArgumentNullException("FloodProtectionProfile cannot be null"); }
            StringBuilder UpdateFloodProtectionProfileServiceURL = new StringBuilder("/infra/flood-protection-profiles/{flood-protection-profile-id}");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Put
            };
            UpdateFloodProtectionProfileServiceURL.Replace("{flood-protection-profile-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(FloodProtectionProfileId, System.Globalization.CultureInfo.InvariantCulture)));
            request.AddJsonBody(FloodProtectionProfile);
            if (Override != null) { request.AddQueryParameter("override", Override.ToString()); }
            request.Resource = UpdateFloodProtectionProfileServiceURL.ToString();
            RestResponse<NSXTFloodProtectionProfileType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTFloodProtectionProfileType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Put operation to " + UpdateFloodProtectionProfileServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTFloodProtectionProfileType> GetFloodProtectionProfile(string FloodProtectionProfileId)
        {
            if (FloodProtectionProfileId == null) { throw new System.ArgumentNullException("FloodProtectionProfileId cannot be null"); }
            StringBuilder GetFloodProtectionProfileServiceURL = new StringBuilder("/infra/flood-protection-profiles/{flood-protection-profile-id}");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Get
            };
            GetFloodProtectionProfileServiceURL.Replace("{flood-protection-profile-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(FloodProtectionProfileId, System.Globalization.CultureInfo.InvariantCulture)));
            request.Resource = GetFloodProtectionProfileServiceURL.ToString();
            RestResponse<NSXTFloodProtectionProfileType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTFloodProtectionProfileType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Get operation to " + GetFloodProtectionProfileServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task DeleteFloodProtectionProfile(string FloodProtectionProfileId, bool? Override = null)
        {
            if (FloodProtectionProfileId == null) { throw new System.ArgumentNullException("FloodProtectionProfileId cannot be null"); }
            StringBuilder DeleteFloodProtectionProfileServiceURL = new StringBuilder("/infra/flood-protection-profiles/{flood-protection-profile-id}");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Delete
            };
            DeleteFloodProtectionProfileServiceURL.Replace("{flood-protection-profile-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(FloodProtectionProfileId, System.Globalization.CultureInfo.InvariantCulture)));
            if (Override != null) { request.AddQueryParameter("override", Override.ToString()); }
            request.Resource = DeleteFloodProtectionProfileServiceURL.ToString();
            RestResponse response = await restClient.ExecuteTaskAsyncWithPolicy(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Delete operation to " + DeleteFloodProtectionProfileServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task PatchFloodProtectionProfile(string FloodProtectionProfileId, NSXTFloodProtectionProfileType FloodProtectionProfile, bool? Override = null)
        {
            if (FloodProtectionProfileId == null) { throw new System.ArgumentNullException("FloodProtectionProfileId cannot be null"); }
            if (FloodProtectionProfile == null) { throw new System.ArgumentNullException("FloodProtectionProfile cannot be null"); }
            StringBuilder PatchFloodProtectionProfileServiceURL = new StringBuilder("/infra/flood-protection-profiles/{flood-protection-profile-id}");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Patch
            };
            PatchFloodProtectionProfileServiceURL.Replace("{flood-protection-profile-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(FloodProtectionProfileId, System.Globalization.CultureInfo.InvariantCulture)));
            request.AddJsonBody(FloodProtectionProfile);
            if (Override != null) { request.AddQueryParameter("override", Override.ToString()); }
            request.Resource = PatchFloodProtectionProfileServiceURL.ToString();
            RestResponse response = await restClient.ExecuteTaskAsyncWithPolicy(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Patch operation to " + PatchFloodProtectionProfileServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTSessionTimerProfileBindingListResultType> GlobalGlobalInfraListSessionTimerProfileBindings(string SessionTimerProfileId, string? Cursor = null, bool? IncludeMarkForDeleteObjects = null, string? IncludedFields = null, long? PageSize = null, bool? SortAscending = null, string? SortBy = null)
        {
            if (SessionTimerProfileId == null) { throw new System.ArgumentNullException("SessionTimerProfileId cannot be null"); }
            StringBuilder GlobalInfraListSessionTimerProfileBindingsServiceURL = new StringBuilder("/global-infra/session-timer-profiles/{session-timer-profile-id}/bindings");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Get
            };
            GlobalInfraListSessionTimerProfileBindingsServiceURL.Replace("{session-timer-profile-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(SessionTimerProfileId, System.Globalization.CultureInfo.InvariantCulture)));
            if (Cursor != null) { request.AddQueryParameter("cursor", Cursor.ToString()); }
            if (IncludeMarkForDeleteObjects != null) { request.AddQueryParameter("include_mark_for_delete_objects", IncludeMarkForDeleteObjects.ToString()); }
            if (IncludedFields != null) { request.AddQueryParameter("included_fields", IncludedFields.ToString()); }
            if (PageSize != null) { request.AddQueryParameter("page_size", PageSize.ToString()); }
            if (SortAscending != null) { request.AddQueryParameter("sort_ascending", SortAscending.ToString()); }
            if (SortBy != null) { request.AddQueryParameter("sort_by", SortBy.ToString()); }
            request.Resource = GlobalInfraListSessionTimerProfileBindingsServiceURL.ToString();
            RestResponse<NSXTSessionTimerProfileBindingListResultType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTSessionTimerProfileBindingListResultType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Get operation to " + GlobalInfraListSessionTimerProfileBindingsServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTPolicyFirewallCpuMemThresholdsProfileType> GlobalGlobalInfraUpdateCpumemThresholdsProfile(string ProfileId, NSXTPolicyFirewallCpuMemThresholdsProfileType PolicyFirewallCpuMemThresholdsProfile, bool? Override = null)
        {
            if (ProfileId == null) { throw new System.ArgumentNullException("ProfileId cannot be null"); }
            if (PolicyFirewallCpuMemThresholdsProfile == null) { throw new System.ArgumentNullException("PolicyFirewallCpuMemThresholdsProfile cannot be null"); }
            StringBuilder GlobalInfraUpdateCpumemThresholdsProfileServiceURL = new StringBuilder("/global-infra/settings/firewall/cpu-mem-thresholds-profiles/{profile-id}");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Put
            };
            GlobalInfraUpdateCpumemThresholdsProfileServiceURL.Replace("{profile-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(ProfileId, System.Globalization.CultureInfo.InvariantCulture)));
            request.AddJsonBody(PolicyFirewallCpuMemThresholdsProfile);
            if (Override != null) { request.AddQueryParameter("override", Override.ToString()); }
            request.Resource = GlobalInfraUpdateCpumemThresholdsProfileServiceURL.ToString();
            RestResponse<NSXTPolicyFirewallCpuMemThresholdsProfileType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTPolicyFirewallCpuMemThresholdsProfileType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Put operation to " + GlobalInfraUpdateCpumemThresholdsProfileServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task GlobalGlobalInfraDeleteCpumemThresholdsProfile(string ProfileId, bool? Override = null)
        {
            if (ProfileId == null) { throw new System.ArgumentNullException("ProfileId cannot be null"); }
            StringBuilder GlobalInfraDeleteCpumemThresholdsProfileServiceURL = new StringBuilder("/global-infra/settings/firewall/cpu-mem-thresholds-profiles/{profile-id}");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Delete
            };
            GlobalInfraDeleteCpumemThresholdsProfileServiceURL.Replace("{profile-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(ProfileId, System.Globalization.CultureInfo.InvariantCulture)));
            if (Override != null) { request.AddQueryParameter("override", Override.ToString()); }
            request.Resource = GlobalInfraDeleteCpumemThresholdsProfileServiceURL.ToString();
            RestResponse response = await restClient.ExecuteTaskAsyncWithPolicy(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Delete operation to " + GlobalInfraDeleteCpumemThresholdsProfileServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTPolicyFirewallCpuMemThresholdsProfileType> GlobalGlobalInfraReadCpumemThresholdsProfile(string ProfileId)
        {
            if (ProfileId == null) { throw new System.ArgumentNullException("ProfileId cannot be null"); }
            StringBuilder GlobalInfraReadCpumemThresholdsProfileServiceURL = new StringBuilder("/global-infra/settings/firewall/cpu-mem-thresholds-profiles/{profile-id}");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Get
            };
            GlobalInfraReadCpumemThresholdsProfileServiceURL.Replace("{profile-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(ProfileId, System.Globalization.CultureInfo.InvariantCulture)));
            request.Resource = GlobalInfraReadCpumemThresholdsProfileServiceURL.ToString();
            RestResponse<NSXTPolicyFirewallCpuMemThresholdsProfileType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTPolicyFirewallCpuMemThresholdsProfileType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Get operation to " + GlobalInfraReadCpumemThresholdsProfileServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task GlobalGlobalInfraPatchCpumemThresholdsProfile(string ProfileId, NSXTPolicyFirewallCpuMemThresholdsProfileType PolicyFirewallCpuMemThresholdsProfile, bool? Override = null)
        {
            if (ProfileId == null) { throw new System.ArgumentNullException("ProfileId cannot be null"); }
            if (PolicyFirewallCpuMemThresholdsProfile == null) { throw new System.ArgumentNullException("PolicyFirewallCpuMemThresholdsProfile cannot be null"); }
            StringBuilder GlobalInfraPatchCpumemThresholdsProfileServiceURL = new StringBuilder("/global-infra/settings/firewall/cpu-mem-thresholds-profiles/{profile-id}");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Patch
            };
            GlobalInfraPatchCpumemThresholdsProfileServiceURL.Replace("{profile-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(ProfileId, System.Globalization.CultureInfo.InvariantCulture)));
            request.AddJsonBody(PolicyFirewallCpuMemThresholdsProfile);
            if (Override != null) { request.AddQueryParameter("override", Override.ToString()); }
            request.Resource = GlobalInfraPatchCpumemThresholdsProfileServiceURL.ToString();
            RestResponse response = await restClient.ExecuteTaskAsyncWithPolicy(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Patch operation to " + GlobalInfraPatchCpumemThresholdsProfileServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTDnsSecurityProfileType> GlobalGlobalInfraUpdateDnsSecurityProfile(string ProfileId, NSXTDnsSecurityProfileType DnsSecurityProfile, bool? Override = null)
        {
            if (ProfileId == null) { throw new System.ArgumentNullException("ProfileId cannot be null"); }
            if (DnsSecurityProfile == null) { throw new System.ArgumentNullException("DnsSecurityProfile cannot be null"); }
            StringBuilder GlobalInfraUpdateDnsSecurityProfileServiceURL = new StringBuilder("/global-infra/dns-security-profiles/{profile-id}");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Put
            };
            GlobalInfraUpdateDnsSecurityProfileServiceURL.Replace("{profile-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(ProfileId, System.Globalization.CultureInfo.InvariantCulture)));
            request.AddJsonBody(DnsSecurityProfile);
            if (Override != null) { request.AddQueryParameter("override", Override.ToString()); }
            request.Resource = GlobalInfraUpdateDnsSecurityProfileServiceURL.ToString();
            RestResponse<NSXTDnsSecurityProfileType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTDnsSecurityProfileType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Put operation to " + GlobalInfraUpdateDnsSecurityProfileServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTDnsSecurityProfileType> GlobalGlobalInfraReadDnsSecurityProfile(string ProfileId)
        {
            if (ProfileId == null) { throw new System.ArgumentNullException("ProfileId cannot be null"); }
            StringBuilder GlobalInfraReadDnsSecurityProfileServiceURL = new StringBuilder("/global-infra/dns-security-profiles/{profile-id}");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Get
            };
            GlobalInfraReadDnsSecurityProfileServiceURL.Replace("{profile-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(ProfileId, System.Globalization.CultureInfo.InvariantCulture)));
            request.Resource = GlobalInfraReadDnsSecurityProfileServiceURL.ToString();
            RestResponse<NSXTDnsSecurityProfileType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTDnsSecurityProfileType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Get operation to " + GlobalInfraReadDnsSecurityProfileServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task GlobalGlobalInfraPatchDnsSecurityProfile(string ProfileId, NSXTDnsSecurityProfileType DnsSecurityProfile, bool? Override = null)
        {
            if (ProfileId == null) { throw new System.ArgumentNullException("ProfileId cannot be null"); }
            if (DnsSecurityProfile == null) { throw new System.ArgumentNullException("DnsSecurityProfile cannot be null"); }
            StringBuilder GlobalInfraPatchDnsSecurityProfileServiceURL = new StringBuilder("/global-infra/dns-security-profiles/{profile-id}");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Patch
            };
            GlobalInfraPatchDnsSecurityProfileServiceURL.Replace("{profile-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(ProfileId, System.Globalization.CultureInfo.InvariantCulture)));
            request.AddJsonBody(DnsSecurityProfile);
            if (Override != null) { request.AddQueryParameter("override", Override.ToString()); }
            request.Resource = GlobalInfraPatchDnsSecurityProfileServiceURL.ToString();
            RestResponse response = await restClient.ExecuteTaskAsyncWithPolicy(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Patch operation to " + GlobalInfraPatchDnsSecurityProfileServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task GlobalGlobalInfraDeleteDnsSecurityProfile(string ProfileId, bool? Override = null)
        {
            if (ProfileId == null) { throw new System.ArgumentNullException("ProfileId cannot be null"); }
            StringBuilder GlobalInfraDeleteDnsSecurityProfileServiceURL = new StringBuilder("/global-infra/dns-security-profiles/{profile-id}");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Delete
            };
            GlobalInfraDeleteDnsSecurityProfileServiceURL.Replace("{profile-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(ProfileId, System.Globalization.CultureInfo.InvariantCulture)));
            if (Override != null) { request.AddQueryParameter("override", Override.ToString()); }
            request.Resource = GlobalInfraDeleteDnsSecurityProfileServiceURL.ToString();
            RestResponse response = await restClient.ExecuteTaskAsyncWithPolicy(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Delete operation to " + GlobalInfraDeleteDnsSecurityProfileServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTFloodProtectionProfileType> GlobalGlobalInfraUpdateFloodProtectionProfile(string FloodProtectionProfileId, NSXTFloodProtectionProfileType FloodProtectionProfile, bool? Override = null)
        {
            if (FloodProtectionProfileId == null) { throw new System.ArgumentNullException("FloodProtectionProfileId cannot be null"); }
            if (FloodProtectionProfile == null) { throw new System.ArgumentNullException("FloodProtectionProfile cannot be null"); }
            StringBuilder GlobalInfraUpdateFloodProtectionProfileServiceURL = new StringBuilder("/global-infra/flood-protection-profiles/{flood-protection-profile-id}");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Put
            };
            GlobalInfraUpdateFloodProtectionProfileServiceURL.Replace("{flood-protection-profile-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(FloodProtectionProfileId, System.Globalization.CultureInfo.InvariantCulture)));
            request.AddJsonBody(FloodProtectionProfile);
            if (Override != null) { request.AddQueryParameter("override", Override.ToString()); }
            request.Resource = GlobalInfraUpdateFloodProtectionProfileServiceURL.ToString();
            RestResponse<NSXTFloodProtectionProfileType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTFloodProtectionProfileType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Put operation to " + GlobalInfraUpdateFloodProtectionProfileServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTFloodProtectionProfileType> GlobalGlobalInfraGetFloodProtectionProfile(string FloodProtectionProfileId)
        {
            if (FloodProtectionProfileId == null) { throw new System.ArgumentNullException("FloodProtectionProfileId cannot be null"); }
            StringBuilder GlobalInfraGetFloodProtectionProfileServiceURL = new StringBuilder("/global-infra/flood-protection-profiles/{flood-protection-profile-id}");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Get
            };
            GlobalInfraGetFloodProtectionProfileServiceURL.Replace("{flood-protection-profile-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(FloodProtectionProfileId, System.Globalization.CultureInfo.InvariantCulture)));
            request.Resource = GlobalInfraGetFloodProtectionProfileServiceURL.ToString();
            RestResponse<NSXTFloodProtectionProfileType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTFloodProtectionProfileType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Get operation to " + GlobalInfraGetFloodProtectionProfileServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task GlobalGlobalInfraDeleteFloodProtectionProfile(string FloodProtectionProfileId, bool? Override = null)
        {
            if (FloodProtectionProfileId == null) { throw new System.ArgumentNullException("FloodProtectionProfileId cannot be null"); }
            StringBuilder GlobalInfraDeleteFloodProtectionProfileServiceURL = new StringBuilder("/global-infra/flood-protection-profiles/{flood-protection-profile-id}");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Delete
            };
            GlobalInfraDeleteFloodProtectionProfileServiceURL.Replace("{flood-protection-profile-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(FloodProtectionProfileId, System.Globalization.CultureInfo.InvariantCulture)));
            if (Override != null) { request.AddQueryParameter("override", Override.ToString()); }
            request.Resource = GlobalInfraDeleteFloodProtectionProfileServiceURL.ToString();
            RestResponse response = await restClient.ExecuteTaskAsyncWithPolicy(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Delete operation to " + GlobalInfraDeleteFloodProtectionProfileServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task GlobalGlobalInfraPatchFloodProtectionProfile(string FloodProtectionProfileId, NSXTFloodProtectionProfileType FloodProtectionProfile, bool? Override = null)
        {
            if (FloodProtectionProfileId == null) { throw new System.ArgumentNullException("FloodProtectionProfileId cannot be null"); }
            if (FloodProtectionProfile == null) { throw new System.ArgumentNullException("FloodProtectionProfile cannot be null"); }
            StringBuilder GlobalInfraPatchFloodProtectionProfileServiceURL = new StringBuilder("/global-infra/flood-protection-profiles/{flood-protection-profile-id}");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Patch
            };
            GlobalInfraPatchFloodProtectionProfileServiceURL.Replace("{flood-protection-profile-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(FloodProtectionProfileId, System.Globalization.CultureInfo.InvariantCulture)));
            request.AddJsonBody(FloodProtectionProfile);
            if (Override != null) { request.AddQueryParameter("override", Override.ToString()); }
            request.Resource = GlobalInfraPatchFloodProtectionProfileServiceURL.ToString();
            RestResponse response = await restClient.ExecuteTaskAsyncWithPolicy(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Patch operation to " + GlobalInfraPatchFloodProtectionProfileServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            
        }
    }
}
