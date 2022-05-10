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
    public class PolicyFirewallDnsSecurityProfileBinding
    {
        private RestClient restClient;
        private int retry;
        private int timeout;
        private CancellationToken cancellationToken;

        public PolicyFirewallDnsSecurityProfileBinding(RestClient Client, CancellationToken _cancellationToken, int _timeout, int _retry)
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
        public async Task<NSXTDnsSecurityProfileBindingMapType> GlobalGlobalInfraGetDnsSecurityProfileBinding(string DomainId, string GroupId, string DnsSecurityProfileBindingMapId)
        {
            if (DomainId == null) { throw new System.ArgumentNullException("DomainId cannot be null"); }
            if (GroupId == null) { throw new System.ArgumentNullException("GroupId cannot be null"); }
            if (DnsSecurityProfileBindingMapId == null) { throw new System.ArgumentNullException("DnsSecurityProfileBindingMapId cannot be null"); }
            StringBuilder GlobalInfraGetDnsSecurityProfileBindingServiceURL = new StringBuilder("/global-infra/domains/{domain-id}/groups/{group-id}/dns-security-profile-binding-maps/{dns-security-profile-binding-map-id}");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Get
            };
            GlobalInfraGetDnsSecurityProfileBindingServiceURL.Replace("{domain-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(DomainId, System.Globalization.CultureInfo.InvariantCulture)));
            GlobalInfraGetDnsSecurityProfileBindingServiceURL.Replace("{group-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(GroupId, System.Globalization.CultureInfo.InvariantCulture)));
            GlobalInfraGetDnsSecurityProfileBindingServiceURL.Replace("{dns-security-profile-binding-map-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(DnsSecurityProfileBindingMapId, System.Globalization.CultureInfo.InvariantCulture)));
            request.Resource = GlobalInfraGetDnsSecurityProfileBindingServiceURL.ToString();
            RestResponse<NSXTDnsSecurityProfileBindingMapType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTDnsSecurityProfileBindingMapType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Get operation to " + GlobalInfraGetDnsSecurityProfileBindingServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTDnsSecurityProfileBindingMapListResultType> GlobalGlobalInfraListDnsSecurityProfileBindings(string DomainId, string GroupId, string? Cursor = null, bool? IncludeMarkForDeleteObjects = null, string? IncludedFields = null, long? PageSize = null, bool? SortAscending = null, string? SortBy = null)
        {
            if (DomainId == null) { throw new System.ArgumentNullException("DomainId cannot be null"); }
            if (GroupId == null) { throw new System.ArgumentNullException("GroupId cannot be null"); }
            StringBuilder GlobalInfraListDnsSecurityProfileBindingsServiceURL = new StringBuilder("/global-infra/domains/{domain-id}/groups/{group-id}/dns-security-profile-binding-maps");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Get
            };
            GlobalInfraListDnsSecurityProfileBindingsServiceURL.Replace("{domain-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(DomainId, System.Globalization.CultureInfo.InvariantCulture)));
            GlobalInfraListDnsSecurityProfileBindingsServiceURL.Replace("{group-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(GroupId, System.Globalization.CultureInfo.InvariantCulture)));
            if (Cursor != null) { request.AddQueryParameter("cursor", Cursor.ToString()); }
            if (IncludeMarkForDeleteObjects != null) { request.AddQueryParameter("include_mark_for_delete_objects", IncludeMarkForDeleteObjects.ToString()); }
            if (IncludedFields != null) { request.AddQueryParameter("included_fields", IncludedFields.ToString()); }
            if (PageSize != null) { request.AddQueryParameter("page_size", PageSize.ToString()); }
            if (SortAscending != null) { request.AddQueryParameter("sort_ascending", SortAscending.ToString()); }
            if (SortBy != null) { request.AddQueryParameter("sort_by", SortBy.ToString()); }
            request.Resource = GlobalInfraListDnsSecurityProfileBindingsServiceURL.ToString();
            RestResponse<NSXTDnsSecurityProfileBindingMapListResultType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTDnsSecurityProfileBindingMapListResultType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Get operation to " + GlobalInfraListDnsSecurityProfileBindingsServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTDnsSecurityProfileBindingMapListResultType> ListDnsSecurityProfileBindings(string DomainId, string GroupId, string? Cursor = null, bool? IncludeMarkForDeleteObjects = null, string? IncludedFields = null, long? PageSize = null, bool? SortAscending = null, string? SortBy = null)
        {
            if (DomainId == null) { throw new System.ArgumentNullException("DomainId cannot be null"); }
            if (GroupId == null) { throw new System.ArgumentNullException("GroupId cannot be null"); }
            StringBuilder ListDnsSecurityProfileBindingsServiceURL = new StringBuilder("/infra/domains/{domain-id}/groups/{group-id}/dns-security-profile-binding-maps");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Get
            };
            ListDnsSecurityProfileBindingsServiceURL.Replace("{domain-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(DomainId, System.Globalization.CultureInfo.InvariantCulture)));
            ListDnsSecurityProfileBindingsServiceURL.Replace("{group-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(GroupId, System.Globalization.CultureInfo.InvariantCulture)));
            if (Cursor != null) { request.AddQueryParameter("cursor", Cursor.ToString()); }
            if (IncludeMarkForDeleteObjects != null) { request.AddQueryParameter("include_mark_for_delete_objects", IncludeMarkForDeleteObjects.ToString()); }
            if (IncludedFields != null) { request.AddQueryParameter("included_fields", IncludedFields.ToString()); }
            if (PageSize != null) { request.AddQueryParameter("page_size", PageSize.ToString()); }
            if (SortAscending != null) { request.AddQueryParameter("sort_ascending", SortAscending.ToString()); }
            if (SortBy != null) { request.AddQueryParameter("sort_by", SortBy.ToString()); }
            request.Resource = ListDnsSecurityProfileBindingsServiceURL.ToString();
            RestResponse<NSXTDnsSecurityProfileBindingMapListResultType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTDnsSecurityProfileBindingMapListResultType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Get operation to " + ListDnsSecurityProfileBindingsServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTDnsSecurityProfileBindingMapType> UpdateDnsSecurityProfileBinding(string DomainId, string GroupId, string DnsSecurityProfileBindingMapId, NSXTDnsSecurityProfileBindingMapType DnsSecurityProfileBindingMap)
        {
            if (DomainId == null) { throw new System.ArgumentNullException("DomainId cannot be null"); }
            if (GroupId == null) { throw new System.ArgumentNullException("GroupId cannot be null"); }
            if (DnsSecurityProfileBindingMapId == null) { throw new System.ArgumentNullException("DnsSecurityProfileBindingMapId cannot be null"); }
            if (DnsSecurityProfileBindingMap == null) { throw new System.ArgumentNullException("DnsSecurityProfileBindingMap cannot be null"); }
            StringBuilder UpdateDnsSecurityProfileBindingServiceURL = new StringBuilder("/infra/domains/{domain-id}/groups/{group-id}/dns-security-profile-binding-maps/{dns-security-profile-binding-map-id}");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Put
            };
            UpdateDnsSecurityProfileBindingServiceURL.Replace("{domain-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(DomainId, System.Globalization.CultureInfo.InvariantCulture)));
            UpdateDnsSecurityProfileBindingServiceURL.Replace("{group-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(GroupId, System.Globalization.CultureInfo.InvariantCulture)));
            UpdateDnsSecurityProfileBindingServiceURL.Replace("{dns-security-profile-binding-map-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(DnsSecurityProfileBindingMapId, System.Globalization.CultureInfo.InvariantCulture)));
            request.AddJsonBody(DnsSecurityProfileBindingMap);
            request.Resource = UpdateDnsSecurityProfileBindingServiceURL.ToString();
            RestResponse<NSXTDnsSecurityProfileBindingMapType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTDnsSecurityProfileBindingMapType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Put operation to " + UpdateDnsSecurityProfileBindingServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task DeleteDnsSecurityProfileBinding(string DomainId, string GroupId, string DnsSecurityProfileBindingMapId)
        {
            if (DomainId == null) { throw new System.ArgumentNullException("DomainId cannot be null"); }
            if (GroupId == null) { throw new System.ArgumentNullException("GroupId cannot be null"); }
            if (DnsSecurityProfileBindingMapId == null) { throw new System.ArgumentNullException("DnsSecurityProfileBindingMapId cannot be null"); }
            StringBuilder DeleteDnsSecurityProfileBindingServiceURL = new StringBuilder("/infra/domains/{domain-id}/groups/{group-id}/dns-security-profile-binding-maps/{dns-security-profile-binding-map-id}");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Delete
            };
            DeleteDnsSecurityProfileBindingServiceURL.Replace("{domain-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(DomainId, System.Globalization.CultureInfo.InvariantCulture)));
            DeleteDnsSecurityProfileBindingServiceURL.Replace("{group-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(GroupId, System.Globalization.CultureInfo.InvariantCulture)));
            DeleteDnsSecurityProfileBindingServiceURL.Replace("{dns-security-profile-binding-map-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(DnsSecurityProfileBindingMapId, System.Globalization.CultureInfo.InvariantCulture)));
            request.Resource = DeleteDnsSecurityProfileBindingServiceURL.ToString();
            RestResponse response = await restClient.ExecuteTaskAsyncWithPolicy(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Delete operation to " + DeleteDnsSecurityProfileBindingServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTDnsSecurityProfileBindingMapType> GetDnsSecurityProfileBinding(string DomainId, string GroupId, string DnsSecurityProfileBindingMapId)
        {
            if (DomainId == null) { throw new System.ArgumentNullException("DomainId cannot be null"); }
            if (GroupId == null) { throw new System.ArgumentNullException("GroupId cannot be null"); }
            if (DnsSecurityProfileBindingMapId == null) { throw new System.ArgumentNullException("DnsSecurityProfileBindingMapId cannot be null"); }
            StringBuilder GetDnsSecurityProfileBindingServiceURL = new StringBuilder("/infra/domains/{domain-id}/groups/{group-id}/dns-security-profile-binding-maps/{dns-security-profile-binding-map-id}");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Get
            };
            GetDnsSecurityProfileBindingServiceURL.Replace("{domain-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(DomainId, System.Globalization.CultureInfo.InvariantCulture)));
            GetDnsSecurityProfileBindingServiceURL.Replace("{group-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(GroupId, System.Globalization.CultureInfo.InvariantCulture)));
            GetDnsSecurityProfileBindingServiceURL.Replace("{dns-security-profile-binding-map-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(DnsSecurityProfileBindingMapId, System.Globalization.CultureInfo.InvariantCulture)));
            request.Resource = GetDnsSecurityProfileBindingServiceURL.ToString();
            RestResponse<NSXTDnsSecurityProfileBindingMapType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTDnsSecurityProfileBindingMapType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Get operation to " + GetDnsSecurityProfileBindingServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task PatchDnsSecurityProfileBinding(string DomainId, string GroupId, string DnsSecurityProfileBindingMapId, NSXTDnsSecurityProfileBindingMapType DnsSecurityProfileBindingMap)
        {
            if (DomainId == null) { throw new System.ArgumentNullException("DomainId cannot be null"); }
            if (GroupId == null) { throw new System.ArgumentNullException("GroupId cannot be null"); }
            if (DnsSecurityProfileBindingMapId == null) { throw new System.ArgumentNullException("DnsSecurityProfileBindingMapId cannot be null"); }
            if (DnsSecurityProfileBindingMap == null) { throw new System.ArgumentNullException("DnsSecurityProfileBindingMap cannot be null"); }
            StringBuilder PatchDnsSecurityProfileBindingServiceURL = new StringBuilder("/infra/domains/{domain-id}/groups/{group-id}/dns-security-profile-binding-maps/{dns-security-profile-binding-map-id}");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Patch
            };
            PatchDnsSecurityProfileBindingServiceURL.Replace("{domain-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(DomainId, System.Globalization.CultureInfo.InvariantCulture)));
            PatchDnsSecurityProfileBindingServiceURL.Replace("{group-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(GroupId, System.Globalization.CultureInfo.InvariantCulture)));
            PatchDnsSecurityProfileBindingServiceURL.Replace("{dns-security-profile-binding-map-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(DnsSecurityProfileBindingMapId, System.Globalization.CultureInfo.InvariantCulture)));
            request.AddJsonBody(DnsSecurityProfileBindingMap);
            request.Resource = PatchDnsSecurityProfileBindingServiceURL.ToString();
            RestResponse response = await restClient.ExecuteTaskAsyncWithPolicy(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Patch operation to " + PatchDnsSecurityProfileBindingServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            
        }
    }
}
