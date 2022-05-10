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
    public class PolicyFirewallFloodProtectionProfileBinding
    {
        private RestClient restClient;
        private int retry;
        private int timeout;
        private CancellationToken cancellationToken;

        public PolicyFirewallFloodProtectionProfileBinding(RestClient Client, CancellationToken _cancellationToken, int _timeout, int _retry)
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
        public async Task<NSXTPolicyFirewallFloodProtectionProfileBindingMapListResultType> ListPolicyFirewallFloodProtectionBindings(string DomainId, string GroupId, string? Cursor = null, bool? IncludeMarkForDeleteObjects = null, string? IncludedFields = null, long? PageSize = null, bool? SortAscending = null, string? SortBy = null)
        {
            if (DomainId == null) { throw new System.ArgumentNullException("DomainId cannot be null"); }
            if (GroupId == null) { throw new System.ArgumentNullException("GroupId cannot be null"); }
            StringBuilder ListPolicyFirewallFloodProtectionBindingsServiceURL = new StringBuilder("/infra/domains/{domain-id}/groups/{group-id}/firewall-flood-protection-profile-binding-maps");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Get
            };
            ListPolicyFirewallFloodProtectionBindingsServiceURL.Replace("{domain-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(DomainId, System.Globalization.CultureInfo.InvariantCulture)));
            ListPolicyFirewallFloodProtectionBindingsServiceURL.Replace("{group-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(GroupId, System.Globalization.CultureInfo.InvariantCulture)));
            if (Cursor != null) { request.AddQueryParameter("cursor", Cursor.ToString()); }
            if (IncludeMarkForDeleteObjects != null) { request.AddQueryParameter("include_mark_for_delete_objects", IncludeMarkForDeleteObjects.ToString()); }
            if (IncludedFields != null) { request.AddQueryParameter("included_fields", IncludedFields.ToString()); }
            if (PageSize != null) { request.AddQueryParameter("page_size", PageSize.ToString()); }
            if (SortAscending != null) { request.AddQueryParameter("sort_ascending", SortAscending.ToString()); }
            if (SortBy != null) { request.AddQueryParameter("sort_by", SortBy.ToString()); }
            request.Resource = ListPolicyFirewallFloodProtectionBindingsServiceURL.ToString();
            RestResponse<NSXTPolicyFirewallFloodProtectionProfileBindingMapListResultType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTPolicyFirewallFloodProtectionProfileBindingMapListResultType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Get operation to " + ListPolicyFirewallFloodProtectionBindingsServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTPolicyFirewallFloodProtectionProfileBindingMapType> UpdatePolicyFirewallFloodProtectionBinding(string DomainId, string GroupId, string FirewallFloodProtectionProfileBindingMapId, NSXTPolicyFirewallFloodProtectionProfileBindingMapType PolicyFirewallFloodProtectionProfileBindingMap)
        {
            if (DomainId == null) { throw new System.ArgumentNullException("DomainId cannot be null"); }
            if (GroupId == null) { throw new System.ArgumentNullException("GroupId cannot be null"); }
            if (FirewallFloodProtectionProfileBindingMapId == null) { throw new System.ArgumentNullException("FirewallFloodProtectionProfileBindingMapId cannot be null"); }
            if (PolicyFirewallFloodProtectionProfileBindingMap == null) { throw new System.ArgumentNullException("PolicyFirewallFloodProtectionProfileBindingMap cannot be null"); }
            StringBuilder UpdatePolicyFirewallFloodProtectionBindingServiceURL = new StringBuilder("/infra/domains/{domain-id}/groups/{group-id}/firewall-flood-protection-profile-binding-maps/{firewall-flood-protection-profile-binding-map-id}");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Put
            };
            UpdatePolicyFirewallFloodProtectionBindingServiceURL.Replace("{domain-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(DomainId, System.Globalization.CultureInfo.InvariantCulture)));
            UpdatePolicyFirewallFloodProtectionBindingServiceURL.Replace("{group-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(GroupId, System.Globalization.CultureInfo.InvariantCulture)));
            UpdatePolicyFirewallFloodProtectionBindingServiceURL.Replace("{firewall-flood-protection-profile-binding-map-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(FirewallFloodProtectionProfileBindingMapId, System.Globalization.CultureInfo.InvariantCulture)));
            request.AddJsonBody(PolicyFirewallFloodProtectionProfileBindingMap);
            request.Resource = UpdatePolicyFirewallFloodProtectionBindingServiceURL.ToString();
            RestResponse<NSXTPolicyFirewallFloodProtectionProfileBindingMapType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTPolicyFirewallFloodProtectionProfileBindingMapType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Put operation to " + UpdatePolicyFirewallFloodProtectionBindingServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task DeletePolicyFirewallFloodProtectionBinding(string DomainId, string GroupId, string FirewallFloodProtectionProfileBindingMapId)
        {
            if (DomainId == null) { throw new System.ArgumentNullException("DomainId cannot be null"); }
            if (GroupId == null) { throw new System.ArgumentNullException("GroupId cannot be null"); }
            if (FirewallFloodProtectionProfileBindingMapId == null) { throw new System.ArgumentNullException("FirewallFloodProtectionProfileBindingMapId cannot be null"); }
            StringBuilder DeletePolicyFirewallFloodProtectionBindingServiceURL = new StringBuilder("/infra/domains/{domain-id}/groups/{group-id}/firewall-flood-protection-profile-binding-maps/{firewall-flood-protection-profile-binding-map-id}");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Delete
            };
            DeletePolicyFirewallFloodProtectionBindingServiceURL.Replace("{domain-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(DomainId, System.Globalization.CultureInfo.InvariantCulture)));
            DeletePolicyFirewallFloodProtectionBindingServiceURL.Replace("{group-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(GroupId, System.Globalization.CultureInfo.InvariantCulture)));
            DeletePolicyFirewallFloodProtectionBindingServiceURL.Replace("{firewall-flood-protection-profile-binding-map-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(FirewallFloodProtectionProfileBindingMapId, System.Globalization.CultureInfo.InvariantCulture)));
            request.Resource = DeletePolicyFirewallFloodProtectionBindingServiceURL.ToString();
            RestResponse response = await restClient.ExecuteTaskAsyncWithPolicy(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Delete operation to " + DeletePolicyFirewallFloodProtectionBindingServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task PatchPolicyFirewallFloodProtectionProfileBindingMap(string DomainId, string GroupId, string FirewallFloodProtectionProfileBindingMapId, NSXTPolicyFirewallFloodProtectionProfileBindingMapType PolicyFirewallFloodProtectionProfileBindingMap)
        {
            if (DomainId == null) { throw new System.ArgumentNullException("DomainId cannot be null"); }
            if (GroupId == null) { throw new System.ArgumentNullException("GroupId cannot be null"); }
            if (FirewallFloodProtectionProfileBindingMapId == null) { throw new System.ArgumentNullException("FirewallFloodProtectionProfileBindingMapId cannot be null"); }
            if (PolicyFirewallFloodProtectionProfileBindingMap == null) { throw new System.ArgumentNullException("PolicyFirewallFloodProtectionProfileBindingMap cannot be null"); }
            StringBuilder PatchPolicyFirewallFloodProtectionProfileBindingMapServiceURL = new StringBuilder("/infra/domains/{domain-id}/groups/{group-id}/firewall-flood-protection-profile-binding-maps/{firewall-flood-protection-profile-binding-map-id}");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Patch
            };
            PatchPolicyFirewallFloodProtectionProfileBindingMapServiceURL.Replace("{domain-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(DomainId, System.Globalization.CultureInfo.InvariantCulture)));
            PatchPolicyFirewallFloodProtectionProfileBindingMapServiceURL.Replace("{group-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(GroupId, System.Globalization.CultureInfo.InvariantCulture)));
            PatchPolicyFirewallFloodProtectionProfileBindingMapServiceURL.Replace("{firewall-flood-protection-profile-binding-map-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(FirewallFloodProtectionProfileBindingMapId, System.Globalization.CultureInfo.InvariantCulture)));
            request.AddJsonBody(PolicyFirewallFloodProtectionProfileBindingMap);
            request.Resource = PatchPolicyFirewallFloodProtectionProfileBindingMapServiceURL.ToString();
            RestResponse response = await restClient.ExecuteTaskAsyncWithPolicy(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Patch operation to " + PatchPolicyFirewallFloodProtectionProfileBindingMapServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTPolicyFirewallFloodProtectionProfileBindingMapType> GetPolicyFirewallFloodProtectionBinding(string DomainId, string GroupId, string FirewallFloodProtectionProfileBindingMapId)
        {
            if (DomainId == null) { throw new System.ArgumentNullException("DomainId cannot be null"); }
            if (GroupId == null) { throw new System.ArgumentNullException("GroupId cannot be null"); }
            if (FirewallFloodProtectionProfileBindingMapId == null) { throw new System.ArgumentNullException("FirewallFloodProtectionProfileBindingMapId cannot be null"); }
            StringBuilder GetPolicyFirewallFloodProtectionBindingServiceURL = new StringBuilder("/infra/domains/{domain-id}/groups/{group-id}/firewall-flood-protection-profile-binding-maps/{firewall-flood-protection-profile-binding-map-id}");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Get
            };
            GetPolicyFirewallFloodProtectionBindingServiceURL.Replace("{domain-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(DomainId, System.Globalization.CultureInfo.InvariantCulture)));
            GetPolicyFirewallFloodProtectionBindingServiceURL.Replace("{group-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(GroupId, System.Globalization.CultureInfo.InvariantCulture)));
            GetPolicyFirewallFloodProtectionBindingServiceURL.Replace("{firewall-flood-protection-profile-binding-map-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(FirewallFloodProtectionProfileBindingMapId, System.Globalization.CultureInfo.InvariantCulture)));
            request.Resource = GetPolicyFirewallFloodProtectionBindingServiceURL.ToString();
            RestResponse<NSXTPolicyFirewallFloodProtectionProfileBindingMapType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTPolicyFirewallFloodProtectionProfileBindingMapType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Get operation to " + GetPolicyFirewallFloodProtectionBindingServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTPolicyFirewallFloodProtectionProfileBindingMapType> GlobalGlobalInfraGetPolicyFirewallFloodProtectionBinding(string DomainId, string GroupId, string FirewallFloodProtectionProfileBindingMapId)
        {
            if (DomainId == null) { throw new System.ArgumentNullException("DomainId cannot be null"); }
            if (GroupId == null) { throw new System.ArgumentNullException("GroupId cannot be null"); }
            if (FirewallFloodProtectionProfileBindingMapId == null) { throw new System.ArgumentNullException("FirewallFloodProtectionProfileBindingMapId cannot be null"); }
            StringBuilder GlobalInfraGetPolicyFirewallFloodProtectionBindingServiceURL = new StringBuilder("/global-infra/domains/{domain-id}/groups/{group-id}/firewall-flood-protection-profile-binding-maps/{firewall-flood-protection-profile-binding-map-id}");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Get
            };
            GlobalInfraGetPolicyFirewallFloodProtectionBindingServiceURL.Replace("{domain-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(DomainId, System.Globalization.CultureInfo.InvariantCulture)));
            GlobalInfraGetPolicyFirewallFloodProtectionBindingServiceURL.Replace("{group-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(GroupId, System.Globalization.CultureInfo.InvariantCulture)));
            GlobalInfraGetPolicyFirewallFloodProtectionBindingServiceURL.Replace("{firewall-flood-protection-profile-binding-map-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(FirewallFloodProtectionProfileBindingMapId, System.Globalization.CultureInfo.InvariantCulture)));
            request.Resource = GlobalInfraGetPolicyFirewallFloodProtectionBindingServiceURL.ToString();
            RestResponse<NSXTPolicyFirewallFloodProtectionProfileBindingMapType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTPolicyFirewallFloodProtectionProfileBindingMapType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Get operation to " + GlobalInfraGetPolicyFirewallFloodProtectionBindingServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTPolicyFirewallFloodProtectionProfileBindingMapListResultType> GlobalGlobalInfraListPolicyFirewallFloodProtectionBindings(string DomainId, string GroupId, string? Cursor = null, bool? IncludeMarkForDeleteObjects = null, string? IncludedFields = null, long? PageSize = null, bool? SortAscending = null, string? SortBy = null)
        {
            if (DomainId == null) { throw new System.ArgumentNullException("DomainId cannot be null"); }
            if (GroupId == null) { throw new System.ArgumentNullException("GroupId cannot be null"); }
            StringBuilder GlobalInfraListPolicyFirewallFloodProtectionBindingsServiceURL = new StringBuilder("/global-infra/domains/{domain-id}/groups/{group-id}/firewall-flood-protection-profile-binding-maps");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Get
            };
            GlobalInfraListPolicyFirewallFloodProtectionBindingsServiceURL.Replace("{domain-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(DomainId, System.Globalization.CultureInfo.InvariantCulture)));
            GlobalInfraListPolicyFirewallFloodProtectionBindingsServiceURL.Replace("{group-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(GroupId, System.Globalization.CultureInfo.InvariantCulture)));
            if (Cursor != null) { request.AddQueryParameter("cursor", Cursor.ToString()); }
            if (IncludeMarkForDeleteObjects != null) { request.AddQueryParameter("include_mark_for_delete_objects", IncludeMarkForDeleteObjects.ToString()); }
            if (IncludedFields != null) { request.AddQueryParameter("included_fields", IncludedFields.ToString()); }
            if (PageSize != null) { request.AddQueryParameter("page_size", PageSize.ToString()); }
            if (SortAscending != null) { request.AddQueryParameter("sort_ascending", SortAscending.ToString()); }
            if (SortBy != null) { request.AddQueryParameter("sort_by", SortBy.ToString()); }
            request.Resource = GlobalInfraListPolicyFirewallFloodProtectionBindingsServiceURL.ToString();
            RestResponse<NSXTPolicyFirewallFloodProtectionProfileBindingMapListResultType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTPolicyFirewallFloodProtectionProfileBindingMapListResultType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Get operation to " + GlobalInfraListPolicyFirewallFloodProtectionBindingsServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTPolicyFirewallFloodProtectionProfileBindingMapListResultType> ListFirewallFloodProtectionBindingsAcrossDomains(string? Cursor = null, bool? IncludeMarkForDeleteObjects = null, string? IncludedFields = null, long? PageSize = null, bool? SortAscending = null, string? SortBy = null)
        {
            StringBuilder ListFirewallFloodProtectionBindingsAcrossDomainsServiceURL = new StringBuilder("/infra/domains/firewall-flood-protection-profile-binding-maps");
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
            request.Resource = ListFirewallFloodProtectionBindingsAcrossDomainsServiceURL.ToString();
            RestResponse<NSXTPolicyFirewallFloodProtectionProfileBindingMapListResultType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTPolicyFirewallFloodProtectionProfileBindingMapListResultType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Get operation to " + ListFirewallFloodProtectionBindingsAcrossDomainsServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
    }
}
