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
    public class Inventory
    {
        private RestClient restClient;
        private int retry;
        private int timeout;
        private CancellationToken cancellationToken;

        public Inventory(RestClient Client, CancellationToken _cancellationToken, int _timeout, int _retry)
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
        public async Task<NSXTInventoryConfigType> GetInventoryConfig()
        {
            StringBuilder GetInventoryConfigServiceURL = new StringBuilder("/configs/inventory");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Get
            };
            request.Resource = GetInventoryConfigServiceURL.ToString();
            RestResponse<NSXTInventoryConfigType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTInventoryConfigType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Get operation to " + GetInventoryConfigServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTVirtualMachineListResultType> ListVirtualMachines(string? Cursor = null, string? DisplayName = null, string? ExcludeVmType = null, string? ExternalId = null, string? HostId = null, string? IncludedFields = null, long? PageSize = null, bool? SortAscending = null, string? SortBy = null)
        {
            StringBuilder ListVirtualMachinesServiceURL = new StringBuilder("/fabric/virtual-machines");
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
            request.Resource = ListVirtualMachinesServiceURL.ToString();
            RestResponse<NSXTVirtualMachineListResultType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTVirtualMachineListResultType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Get operation to " + ListVirtualMachinesServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTVirtualNetworkInterfaceListResultType> ListVifs(string? Cursor = null, string? HostId = null, string? IncludedFields = null, string? LportAttachmentId = null, string? OwnerVmId = null, long? PageSize = null, bool? SortAscending = null, string? SortBy = null, string? VmId = null)
        {
            StringBuilder ListVifsServiceURL = new StringBuilder("/fabric/vifs");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Get
            };
            if (Cursor != null) { request.AddQueryParameter("cursor", Cursor.ToString()); }
            if (HostId != null) { request.AddQueryParameter("host_id", HostId.ToString()); }
            if (IncludedFields != null) { request.AddQueryParameter("included_fields", IncludedFields.ToString()); }
            if (LportAttachmentId != null) { request.AddQueryParameter("lport_attachment_id", LportAttachmentId.ToString()); }
            if (OwnerVmId != null) { request.AddQueryParameter("owner_vm_id", OwnerVmId.ToString()); }
            if (PageSize != null) { request.AddQueryParameter("page_size", PageSize.ToString()); }
            if (SortAscending != null) { request.AddQueryParameter("sort_ascending", SortAscending.ToString()); }
            if (SortBy != null) { request.AddQueryParameter("sort_by", SortBy.ToString()); }
            if (VmId != null) { request.AddQueryParameter("vm_id", VmId.ToString()); }
            request.Resource = ListVifsServiceURL.ToString();
            RestResponse<NSXTVirtualNetworkInterfaceListResultType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTVirtualNetworkInterfaceListResultType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Get operation to " + ListVifsServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
    }
}
