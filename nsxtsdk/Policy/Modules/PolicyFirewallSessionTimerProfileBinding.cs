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
    public class PolicyFirewallSessionTimerProfileBinding
    {
        private RestClient restClient;
        private int retry;
        private int timeout;
        private CancellationToken cancellationToken;

        public PolicyFirewallSessionTimerProfileBinding(RestClient Client, CancellationToken _cancellationToken, int _timeout, int _retry)
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
        public async Task<NSXTPolicyFirewallSessionTimerProfileBindingMapListResultType> GlobalGlobalInfraListPolicyFirewallSessionTimerBindings(string DomainId, string GroupId, string? Cursor = null, bool? IncludeMarkForDeleteObjects = null, string? IncludedFields = null, long? PageSize = null, bool? SortAscending = null, string? SortBy = null)
        {
            if (DomainId == null) { throw new System.ArgumentNullException("DomainId cannot be null"); }
            if (GroupId == null) { throw new System.ArgumentNullException("GroupId cannot be null"); }
            StringBuilder GlobalInfraListPolicyFirewallSessionTimerBindingsServiceURL = new StringBuilder("/global-infra/domains/{domain-id}/groups/{group-id}/firewall-session-timer-profile-binding-maps");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Get
            };
            GlobalInfraListPolicyFirewallSessionTimerBindingsServiceURL.Replace("{domain-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(DomainId, System.Globalization.CultureInfo.InvariantCulture)));
            GlobalInfraListPolicyFirewallSessionTimerBindingsServiceURL.Replace("{group-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(GroupId, System.Globalization.CultureInfo.InvariantCulture)));
            if (Cursor != null) { request.AddQueryParameter("cursor", Cursor.ToString()); }
            if (IncludeMarkForDeleteObjects != null) { request.AddQueryParameter("include_mark_for_delete_objects", IncludeMarkForDeleteObjects.ToString()); }
            if (IncludedFields != null) { request.AddQueryParameter("included_fields", IncludedFields.ToString()); }
            if (PageSize != null) { request.AddQueryParameter("page_size", PageSize.ToString()); }
            if (SortAscending != null) { request.AddQueryParameter("sort_ascending", SortAscending.ToString()); }
            if (SortBy != null) { request.AddQueryParameter("sort_by", SortBy.ToString()); }
            request.Resource = GlobalInfraListPolicyFirewallSessionTimerBindingsServiceURL.ToString();
            RestResponse<NSXTPolicyFirewallSessionTimerProfileBindingMapListResultType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTPolicyFirewallSessionTimerProfileBindingMapListResultType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Get operation to " + GlobalInfraListPolicyFirewallSessionTimerBindingsServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTPolicyFirewallSessionTimerProfileBindingMapListResultType> ListPolicyFirewallSessionTimerBindings(string DomainId, string GroupId, string? Cursor = null, bool? IncludeMarkForDeleteObjects = null, string? IncludedFields = null, long? PageSize = null, bool? SortAscending = null, string? SortBy = null)
        {
            if (DomainId == null) { throw new System.ArgumentNullException("DomainId cannot be null"); }
            if (GroupId == null) { throw new System.ArgumentNullException("GroupId cannot be null"); }
            StringBuilder ListPolicyFirewallSessionTimerBindingsServiceURL = new StringBuilder("/infra/domains/{domain-id}/groups/{group-id}/firewall-session-timer-profile-binding-maps");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Get
            };
            ListPolicyFirewallSessionTimerBindingsServiceURL.Replace("{domain-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(DomainId, System.Globalization.CultureInfo.InvariantCulture)));
            ListPolicyFirewallSessionTimerBindingsServiceURL.Replace("{group-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(GroupId, System.Globalization.CultureInfo.InvariantCulture)));
            if (Cursor != null) { request.AddQueryParameter("cursor", Cursor.ToString()); }
            if (IncludeMarkForDeleteObjects != null) { request.AddQueryParameter("include_mark_for_delete_objects", IncludeMarkForDeleteObjects.ToString()); }
            if (IncludedFields != null) { request.AddQueryParameter("included_fields", IncludedFields.ToString()); }
            if (PageSize != null) { request.AddQueryParameter("page_size", PageSize.ToString()); }
            if (SortAscending != null) { request.AddQueryParameter("sort_ascending", SortAscending.ToString()); }
            if (SortBy != null) { request.AddQueryParameter("sort_by", SortBy.ToString()); }
            request.Resource = ListPolicyFirewallSessionTimerBindingsServiceURL.ToString();
            RestResponse<NSXTPolicyFirewallSessionTimerProfileBindingMapListResultType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTPolicyFirewallSessionTimerProfileBindingMapListResultType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Get operation to " + ListPolicyFirewallSessionTimerBindingsServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTPolicyFirewallSessionTimerProfileBindingMapListResultType> ListFirewallSessionTimerBindingsAcrossDomains(string? Cursor = null, bool? IncludeMarkForDeleteObjects = null, string? IncludedFields = null, long? PageSize = null, bool? SortAscending = null, string? SortBy = null)
        {
            StringBuilder ListFirewallSessionTimerBindingsAcrossDomainsServiceURL = new StringBuilder("/infra/domains/firewall-session-timer-profile-binding-maps");
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
            request.Resource = ListFirewallSessionTimerBindingsAcrossDomainsServiceURL.ToString();
            RestResponse<NSXTPolicyFirewallSessionTimerProfileBindingMapListResultType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTPolicyFirewallSessionTimerProfileBindingMapListResultType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Get operation to " + ListFirewallSessionTimerBindingsAcrossDomainsServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTPolicyFirewallSessionTimerProfileBindingMapType> GlobalGlobalInfraGetPolicyFirewallSessionTimerBinding(string DomainId, string GroupId, string FirewallSessionTimerProfileBindingMapId)
        {
            if (DomainId == null) { throw new System.ArgumentNullException("DomainId cannot be null"); }
            if (GroupId == null) { throw new System.ArgumentNullException("GroupId cannot be null"); }
            if (FirewallSessionTimerProfileBindingMapId == null) { throw new System.ArgumentNullException("FirewallSessionTimerProfileBindingMapId cannot be null"); }
            StringBuilder GlobalInfraGetPolicyFirewallSessionTimerBindingServiceURL = new StringBuilder("/global-infra/domains/{domain-id}/groups/{group-id}/firewall-session-timer-profile-binding-maps/{firewall-session-timer-profile-binding-map-id}");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Get
            };
            GlobalInfraGetPolicyFirewallSessionTimerBindingServiceURL.Replace("{domain-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(DomainId, System.Globalization.CultureInfo.InvariantCulture)));
            GlobalInfraGetPolicyFirewallSessionTimerBindingServiceURL.Replace("{group-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(GroupId, System.Globalization.CultureInfo.InvariantCulture)));
            GlobalInfraGetPolicyFirewallSessionTimerBindingServiceURL.Replace("{firewall-session-timer-profile-binding-map-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(FirewallSessionTimerProfileBindingMapId, System.Globalization.CultureInfo.InvariantCulture)));
            request.Resource = GlobalInfraGetPolicyFirewallSessionTimerBindingServiceURL.ToString();
            RestResponse<NSXTPolicyFirewallSessionTimerProfileBindingMapType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTPolicyFirewallSessionTimerProfileBindingMapType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Get operation to " + GlobalInfraGetPolicyFirewallSessionTimerBindingServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTPolicyFirewallSessionTimerProfileBindingMapType> UpdatePolicyFirewallSessionTimerBinding(string DomainId, string GroupId, string FirewallSessionTimerProfileBindingMapId, NSXTPolicyFirewallSessionTimerProfileBindingMapType PolicyFirewallSessionTimerProfileBindingMap)
        {
            if (DomainId == null) { throw new System.ArgumentNullException("DomainId cannot be null"); }
            if (GroupId == null) { throw new System.ArgumentNullException("GroupId cannot be null"); }
            if (FirewallSessionTimerProfileBindingMapId == null) { throw new System.ArgumentNullException("FirewallSessionTimerProfileBindingMapId cannot be null"); }
            if (PolicyFirewallSessionTimerProfileBindingMap == null) { throw new System.ArgumentNullException("PolicyFirewallSessionTimerProfileBindingMap cannot be null"); }
            StringBuilder UpdatePolicyFirewallSessionTimerBindingServiceURL = new StringBuilder("/infra/domains/{domain-id}/groups/{group-id}/firewall-session-timer-profile-binding-maps/{firewall-session-timer-profile-binding-map-id}");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Put
            };
            UpdatePolicyFirewallSessionTimerBindingServiceURL.Replace("{domain-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(DomainId, System.Globalization.CultureInfo.InvariantCulture)));
            UpdatePolicyFirewallSessionTimerBindingServiceURL.Replace("{group-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(GroupId, System.Globalization.CultureInfo.InvariantCulture)));
            UpdatePolicyFirewallSessionTimerBindingServiceURL.Replace("{firewall-session-timer-profile-binding-map-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(FirewallSessionTimerProfileBindingMapId, System.Globalization.CultureInfo.InvariantCulture)));
            request.AddJsonBody(PolicyFirewallSessionTimerProfileBindingMap);
            request.Resource = UpdatePolicyFirewallSessionTimerBindingServiceURL.ToString();
            RestResponse<NSXTPolicyFirewallSessionTimerProfileBindingMapType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTPolicyFirewallSessionTimerProfileBindingMapType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Put operation to " + UpdatePolicyFirewallSessionTimerBindingServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task DeletePolicyFirewallSessionTimerBinding(string DomainId, string GroupId, string FirewallSessionTimerProfileBindingMapId)
        {
            if (DomainId == null) { throw new System.ArgumentNullException("DomainId cannot be null"); }
            if (GroupId == null) { throw new System.ArgumentNullException("GroupId cannot be null"); }
            if (FirewallSessionTimerProfileBindingMapId == null) { throw new System.ArgumentNullException("FirewallSessionTimerProfileBindingMapId cannot be null"); }
            StringBuilder DeletePolicyFirewallSessionTimerBindingServiceURL = new StringBuilder("/infra/domains/{domain-id}/groups/{group-id}/firewall-session-timer-profile-binding-maps/{firewall-session-timer-profile-binding-map-id}");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Delete
            };
            DeletePolicyFirewallSessionTimerBindingServiceURL.Replace("{domain-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(DomainId, System.Globalization.CultureInfo.InvariantCulture)));
            DeletePolicyFirewallSessionTimerBindingServiceURL.Replace("{group-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(GroupId, System.Globalization.CultureInfo.InvariantCulture)));
            DeletePolicyFirewallSessionTimerBindingServiceURL.Replace("{firewall-session-timer-profile-binding-map-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(FirewallSessionTimerProfileBindingMapId, System.Globalization.CultureInfo.InvariantCulture)));
            request.Resource = DeletePolicyFirewallSessionTimerBindingServiceURL.ToString();
            RestResponse response = await restClient.ExecuteTaskAsyncWithPolicy(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Delete operation to " + DeletePolicyFirewallSessionTimerBindingServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task PatchPolicyFirewallSessionTimerProfileBindingMap(string DomainId, string GroupId, string FirewallSessionTimerProfileBindingMapId, NSXTPolicyFirewallSessionTimerProfileBindingMapType PolicyFirewallSessionTimerProfileBindingMap)
        {
            if (DomainId == null) { throw new System.ArgumentNullException("DomainId cannot be null"); }
            if (GroupId == null) { throw new System.ArgumentNullException("GroupId cannot be null"); }
            if (FirewallSessionTimerProfileBindingMapId == null) { throw new System.ArgumentNullException("FirewallSessionTimerProfileBindingMapId cannot be null"); }
            if (PolicyFirewallSessionTimerProfileBindingMap == null) { throw new System.ArgumentNullException("PolicyFirewallSessionTimerProfileBindingMap cannot be null"); }
            StringBuilder PatchPolicyFirewallSessionTimerProfileBindingMapServiceURL = new StringBuilder("/infra/domains/{domain-id}/groups/{group-id}/firewall-session-timer-profile-binding-maps/{firewall-session-timer-profile-binding-map-id}");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Patch
            };
            PatchPolicyFirewallSessionTimerProfileBindingMapServiceURL.Replace("{domain-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(DomainId, System.Globalization.CultureInfo.InvariantCulture)));
            PatchPolicyFirewallSessionTimerProfileBindingMapServiceURL.Replace("{group-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(GroupId, System.Globalization.CultureInfo.InvariantCulture)));
            PatchPolicyFirewallSessionTimerProfileBindingMapServiceURL.Replace("{firewall-session-timer-profile-binding-map-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(FirewallSessionTimerProfileBindingMapId, System.Globalization.CultureInfo.InvariantCulture)));
            request.AddJsonBody(PolicyFirewallSessionTimerProfileBindingMap);
            request.Resource = PatchPolicyFirewallSessionTimerProfileBindingMapServiceURL.ToString();
            RestResponse response = await restClient.ExecuteTaskAsyncWithPolicy(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Patch operation to " + PatchPolicyFirewallSessionTimerProfileBindingMapServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTPolicyFirewallSessionTimerProfileBindingMapType> GetPolicyFirewallSessionTimerBinding(string DomainId, string GroupId, string FirewallSessionTimerProfileBindingMapId)
        {
            if (DomainId == null) { throw new System.ArgumentNullException("DomainId cannot be null"); }
            if (GroupId == null) { throw new System.ArgumentNullException("GroupId cannot be null"); }
            if (FirewallSessionTimerProfileBindingMapId == null) { throw new System.ArgumentNullException("FirewallSessionTimerProfileBindingMapId cannot be null"); }
            StringBuilder GetPolicyFirewallSessionTimerBindingServiceURL = new StringBuilder("/infra/domains/{domain-id}/groups/{group-id}/firewall-session-timer-profile-binding-maps/{firewall-session-timer-profile-binding-map-id}");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Get
            };
            GetPolicyFirewallSessionTimerBindingServiceURL.Replace("{domain-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(DomainId, System.Globalization.CultureInfo.InvariantCulture)));
            GetPolicyFirewallSessionTimerBindingServiceURL.Replace("{group-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(GroupId, System.Globalization.CultureInfo.InvariantCulture)));
            GetPolicyFirewallSessionTimerBindingServiceURL.Replace("{firewall-session-timer-profile-binding-map-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(FirewallSessionTimerProfileBindingMapId, System.Globalization.CultureInfo.InvariantCulture)));
            request.Resource = GetPolicyFirewallSessionTimerBindingServiceURL.ToString();
            RestResponse<NSXTPolicyFirewallSessionTimerProfileBindingMapType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTPolicyFirewallSessionTimerProfileBindingMapType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Get operation to " + GetPolicyFirewallSessionTimerBindingServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTPolicyFirewallSessionTimerProfileBindingMapListResultType> GlobalGlobalInfraListFirewallSessionTimerBindingsAcrossDomains(string? Cursor = null, bool? IncludeMarkForDeleteObjects = null, string? IncludedFields = null, long? PageSize = null, bool? SortAscending = null, string? SortBy = null)
        {
            StringBuilder GlobalInfraListFirewallSessionTimerBindingsAcrossDomainsServiceURL = new StringBuilder("/global-infra/domains/firewall-session-timer-profile-binding-maps");
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
            request.Resource = GlobalInfraListFirewallSessionTimerBindingsAcrossDomainsServiceURL.ToString();
            RestResponse<NSXTPolicyFirewallSessionTimerProfileBindingMapListResultType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTPolicyFirewallSessionTimerProfileBindingMapListResultType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Get operation to " + GlobalInfraListFirewallSessionTimerBindingsAcrossDomainsServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
    }
}
