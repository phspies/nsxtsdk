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
    public class GroupingObjectsProviders
    {
        private RestClient restClient;
        private int retry;
        private int timeout;
        private CancellationToken cancellationToken;

        public GroupingObjectsProviders(RestClient Client, CancellationToken _cancellationToken, int _timeout, int _retry)
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
        public async Task<NSXTServiceAssociationListResultType> GetServiceAssociations(string NsgroupId, string ServiceType, string? Cursor = null, bool? FetchParentgroupAssociations = null, string? IncludedFields = null, long? PageSize = null, bool? SortAscending = null, string? SortBy = null)
        {
            if (NsgroupId == null) { throw new System.ArgumentNullException("NsgroupId cannot be null"); }
            if (ServiceType == null) { throw new System.ArgumentNullException("ServiceType cannot be null"); }
            StringBuilder GetServiceAssociationsServiceURL = new StringBuilder("/ns-groups/{nsgroup-id}/service-associations");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Get
            };
            GetServiceAssociationsServiceURL.Replace("{nsgroup-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(NsgroupId, System.Globalization.CultureInfo.InvariantCulture)));
            if (Cursor != null) { request.AddQueryParameter("cursor", Cursor.ToString()); }
            if (FetchParentgroupAssociations != null) { request.AddQueryParameter("fetch_parentgroup_associations", FetchParentgroupAssociations.ToString()); }
            if (IncludedFields != null) { request.AddQueryParameter("included_fields", IncludedFields.ToString()); }
            if (PageSize != null) { request.AddQueryParameter("page_size", PageSize.ToString()); }
            if (ServiceType != null) { request.AddQueryParameter("service_type", ServiceType.ToString()); }
            if (SortAscending != null) { request.AddQueryParameter("sort_ascending", SortAscending.ToString()); }
            if (SortBy != null) { request.AddQueryParameter("sort_by", SortBy.ToString()); }
            request.Resource = GetServiceAssociationsServiceURL.ToString();
            RestResponse<NSXTServiceAssociationListResultType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTServiceAssociationListResultType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Get operation to " + GetServiceAssociationsServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTConsolidatedEffectiveIPAddressMemberListResultType> GetConsolidatedEffectiveIpaddressMembers(string NsGroupId, string? Cursor = null, string? IncludedFields = null, string? IpFilter = null, long? PageSize = null, string? SiteId = null, bool? SortAscending = null, string? SortBy = null)
        {
            if (NsGroupId == null) { throw new System.ArgumentNullException("NsGroupId cannot be null"); }
            StringBuilder GetConsolidatedEffectiveIpaddressMembersServiceURL = new StringBuilder("/ns-groups/{ns-group-id}/consolidated-effective-ip-address-members");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Get
            };
            GetConsolidatedEffectiveIpaddressMembersServiceURL.Replace("{ns-group-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(NsGroupId, System.Globalization.CultureInfo.InvariantCulture)));
            if (Cursor != null) { request.AddQueryParameter("cursor", Cursor.ToString()); }
            if (IncludedFields != null) { request.AddQueryParameter("included_fields", IncludedFields.ToString()); }
            if (IpFilter != null) { request.AddQueryParameter("ip_filter", IpFilter.ToString()); }
            if (PageSize != null) { request.AddQueryParameter("page_size", PageSize.ToString()); }
            if (SiteId != null) { request.AddQueryParameter("site_id", SiteId.ToString()); }
            if (SortAscending != null) { request.AddQueryParameter("sort_ascending", SortAscending.ToString()); }
            if (SortBy != null) { request.AddQueryParameter("sort_by", SortBy.ToString()); }
            request.Resource = GetConsolidatedEffectiveIpaddressMembersServiceURL.ToString();
            RestResponse<NSXTConsolidatedEffectiveIPAddressMemberListResultType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTConsolidatedEffectiveIPAddressMemberListResultType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Get operation to " + GetConsolidatedEffectiveIpaddressMembersServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTUnassociatedVMListResultType> GetUnassociatedVirtualMachines(string? Cursor = null, string? DisplayName = null, string? ExcludeVmType = null, string? ExternalId = null, string? HostId = null, string? IncludedFields = null, long? PageSize = null, bool? SortAscending = null, string? SortBy = null)
        {
            StringBuilder GetUnassociatedVirtualMachinesServiceURL = new StringBuilder("/ns-groups/unassociated-virtual-machines");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Get
            };
            if (Cursor != null) { request.AddQueryParameter("cursor", Cursor.ToString()); }
            if (DisplayName != null) { request.AddQueryParameter("display_name", DisplayName.ToString()); }
            if (ExcludeVmType != null) { request.AddQueryParameter("exclude_vm_type", ExcludeVmType.ToString()); }
            if (ExternalId != null) { request.AddQueryParameter("external_id", ExternalId.ToString()); }
            if (HostId != null) { request.AddQueryParameter("host_id", HostId.ToString()); }
            if (IncludedFields != null) { request.AddQueryParameter("included_fields", IncludedFields.ToString()); }
            if (PageSize != null) { request.AddQueryParameter("page_size", PageSize.ToString()); }
            if (SortAscending != null) { request.AddQueryParameter("sort_ascending", SortAscending.ToString()); }
            if (SortBy != null) { request.AddQueryParameter("sort_by", SortBy.ToString()); }
            request.Resource = GetUnassociatedVirtualMachinesServiceURL.ToString();
            RestResponse<NSXTUnassociatedVMListResultType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTUnassociatedVMListResultType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Get operation to " + GetUnassociatedVirtualMachinesServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
    }
}
