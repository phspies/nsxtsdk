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
    public class PolicyIpam
    {
        private RestClient restClient;
        private int retry;
        private int timeout;
        private CancellationToken cancellationToken;

        public PolicyIpam(RestClient Client, CancellationToken _cancellationToken, int _timeout, int _retry)
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
        public async Task<NSXTIpAddressPoolType> ReadManagerIpPool(string ManagerIpPoolId)
        {
            if (ManagerIpPoolId == null) { throw new System.ArgumentNullException("ManagerIpPoolId cannot be null"); }
            StringBuilder ReadManagerIpPoolServiceURL = new StringBuilder("/infra/manager-ip-pools/{manager-ip-pool-id}");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Get
            };
            ReadManagerIpPoolServiceURL.Replace("{manager-ip-pool-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(ManagerIpPoolId, System.Globalization.CultureInfo.InvariantCulture)));
            request.Resource = ReadManagerIpPoolServiceURL.ToString();
            RestResponse<NSXTIpAddressPoolType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTIpAddressPoolType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Get operation to " + ReadManagerIpPoolServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTIpAddressPoolSubnetType> CreateOrReplaceIpAddressPoolSubnet(string IpPoolId, string IpSubnetId, NSXTIpAddressPoolSubnetType IpAddressPoolSubnet)
        {
            if (IpPoolId == null) { throw new System.ArgumentNullException("IpPoolId cannot be null"); }
            if (IpSubnetId == null) { throw new System.ArgumentNullException("IpSubnetId cannot be null"); }
            if (IpAddressPoolSubnet == null) { throw new System.ArgumentNullException("IpAddressPoolSubnet cannot be null"); }
            StringBuilder CreateOrReplaceIpAddressPoolSubnetServiceURL = new StringBuilder("/infra/ip-pools/{ip-pool-id}/ip-subnets/{ip-subnet-id}");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Put
            };
            CreateOrReplaceIpAddressPoolSubnetServiceURL.Replace("{ip-pool-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(IpPoolId, System.Globalization.CultureInfo.InvariantCulture)));
            CreateOrReplaceIpAddressPoolSubnetServiceURL.Replace("{ip-subnet-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(IpSubnetId, System.Globalization.CultureInfo.InvariantCulture)));
            request.AddJsonBody(IpAddressPoolSubnet);
            request.Resource = CreateOrReplaceIpAddressPoolSubnetServiceURL.ToString();
            RestResponse<NSXTIpAddressPoolSubnetType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTIpAddressPoolSubnetType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Put operation to " + CreateOrReplaceIpAddressPoolSubnetServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTIpAddressPoolSubnetType> ReadIpAddressPoolSubnet(string IpPoolId, string IpSubnetId)
        {
            if (IpPoolId == null) { throw new System.ArgumentNullException("IpPoolId cannot be null"); }
            if (IpSubnetId == null) { throw new System.ArgumentNullException("IpSubnetId cannot be null"); }
            StringBuilder ReadIpAddressPoolSubnetServiceURL = new StringBuilder("/infra/ip-pools/{ip-pool-id}/ip-subnets/{ip-subnet-id}");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Get
            };
            ReadIpAddressPoolSubnetServiceURL.Replace("{ip-pool-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(IpPoolId, System.Globalization.CultureInfo.InvariantCulture)));
            ReadIpAddressPoolSubnetServiceURL.Replace("{ip-subnet-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(IpSubnetId, System.Globalization.CultureInfo.InvariantCulture)));
            request.Resource = ReadIpAddressPoolSubnetServiceURL.ToString();
            RestResponse<NSXTIpAddressPoolSubnetType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTIpAddressPoolSubnetType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Get operation to " + ReadIpAddressPoolSubnetServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task CreateOrPatchIpAddressPoolSubnet(string IpPoolId, string IpSubnetId, NSXTIpAddressPoolSubnetType IpAddressPoolSubnet)
        {
            if (IpPoolId == null) { throw new System.ArgumentNullException("IpPoolId cannot be null"); }
            if (IpSubnetId == null) { throw new System.ArgumentNullException("IpSubnetId cannot be null"); }
            if (IpAddressPoolSubnet == null) { throw new System.ArgumentNullException("IpAddressPoolSubnet cannot be null"); }
            StringBuilder CreateOrPatchIpAddressPoolSubnetServiceURL = new StringBuilder("/infra/ip-pools/{ip-pool-id}/ip-subnets/{ip-subnet-id}");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Patch
            };
            CreateOrPatchIpAddressPoolSubnetServiceURL.Replace("{ip-pool-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(IpPoolId, System.Globalization.CultureInfo.InvariantCulture)));
            CreateOrPatchIpAddressPoolSubnetServiceURL.Replace("{ip-subnet-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(IpSubnetId, System.Globalization.CultureInfo.InvariantCulture)));
            request.AddJsonBody(IpAddressPoolSubnet);
            request.Resource = CreateOrPatchIpAddressPoolSubnetServiceURL.ToString();
            RestResponse response = await restClient.ExecuteTaskAsyncWithPolicy(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Patch operation to " + CreateOrPatchIpAddressPoolSubnetServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task DeleteIpAddressPoolSubnet(string IpPoolId, string IpSubnetId)
        {
            if (IpPoolId == null) { throw new System.ArgumentNullException("IpPoolId cannot be null"); }
            if (IpSubnetId == null) { throw new System.ArgumentNullException("IpSubnetId cannot be null"); }
            StringBuilder DeleteIpAddressPoolSubnetServiceURL = new StringBuilder("/infra/ip-pools/{ip-pool-id}/ip-subnets/{ip-subnet-id}");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Delete
            };
            DeleteIpAddressPoolSubnetServiceURL.Replace("{ip-pool-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(IpPoolId, System.Globalization.CultureInfo.InvariantCulture)));
            DeleteIpAddressPoolSubnetServiceURL.Replace("{ip-subnet-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(IpSubnetId, System.Globalization.CultureInfo.InvariantCulture)));
            request.Resource = DeleteIpAddressPoolSubnetServiceURL.ToString();
            RestResponse response = await restClient.ExecuteTaskAsyncWithPolicy(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Delete operation to " + DeleteIpAddressPoolSubnetServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTIpAddressPoolSubnetListResultType> ListIpAddressPoolSubnets(string IpPoolId, string? Cursor = null, bool? IncludeMarkForDeleteObjects = null, string? IncludedFields = null, long? PageSize = null, bool? SortAscending = null, string? SortBy = null)
        {
            if (IpPoolId == null) { throw new System.ArgumentNullException("IpPoolId cannot be null"); }
            StringBuilder ListIpAddressPoolSubnetsServiceURL = new StringBuilder("/infra/ip-pools/{ip-pool-id}/ip-subnets");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Get
            };
            ListIpAddressPoolSubnetsServiceURL.Replace("{ip-pool-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(IpPoolId, System.Globalization.CultureInfo.InvariantCulture)));
            if (Cursor != null) { request.AddQueryParameter("cursor", Cursor.ToString()); }
            if (IncludeMarkForDeleteObjects != null) { request.AddQueryParameter("include_mark_for_delete_objects", IncludeMarkForDeleteObjects.ToString()); }
            if (IncludedFields != null) { request.AddQueryParameter("included_fields", IncludedFields.ToString()); }
            if (PageSize != null) { request.AddQueryParameter("page_size", PageSize.ToString()); }
            if (SortAscending != null) { request.AddQueryParameter("sort_ascending", SortAscending.ToString()); }
            if (SortBy != null) { request.AddQueryParameter("sort_by", SortBy.ToString()); }
            request.Resource = ListIpAddressPoolSubnetsServiceURL.ToString();
            RestResponse<NSXTIpAddressPoolSubnetListResultType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTIpAddressPoolSubnetListResultType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Get operation to " + ListIpAddressPoolSubnetsServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTIpAddressPoolType> CreateOrReplaceIpAddressPool(string IpPoolId, NSXTIpAddressPoolType IpAddressPool)
        {
            if (IpPoolId == null) { throw new System.ArgumentNullException("IpPoolId cannot be null"); }
            if (IpAddressPool == null) { throw new System.ArgumentNullException("IpAddressPool cannot be null"); }
            StringBuilder CreateOrReplaceIpAddressPoolServiceURL = new StringBuilder("/infra/ip-pools/{ip-pool-id}");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Put
            };
            CreateOrReplaceIpAddressPoolServiceURL.Replace("{ip-pool-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(IpPoolId, System.Globalization.CultureInfo.InvariantCulture)));
            request.AddJsonBody(IpAddressPool);
            request.Resource = CreateOrReplaceIpAddressPoolServiceURL.ToString();
            RestResponse<NSXTIpAddressPoolType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTIpAddressPoolType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Put operation to " + CreateOrReplaceIpAddressPoolServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task DeleteIpAddressPool(string IpPoolId)
        {
            if (IpPoolId == null) { throw new System.ArgumentNullException("IpPoolId cannot be null"); }
            StringBuilder DeleteIpAddressPoolServiceURL = new StringBuilder("/infra/ip-pools/{ip-pool-id}");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Delete
            };
            DeleteIpAddressPoolServiceURL.Replace("{ip-pool-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(IpPoolId, System.Globalization.CultureInfo.InvariantCulture)));
            request.Resource = DeleteIpAddressPoolServiceURL.ToString();
            RestResponse response = await restClient.ExecuteTaskAsyncWithPolicy(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Delete operation to " + DeleteIpAddressPoolServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTIpAddressPoolType> ReadIpAddressPool(string IpPoolId)
        {
            if (IpPoolId == null) { throw new System.ArgumentNullException("IpPoolId cannot be null"); }
            StringBuilder ReadIpAddressPoolServiceURL = new StringBuilder("/infra/ip-pools/{ip-pool-id}");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Get
            };
            ReadIpAddressPoolServiceURL.Replace("{ip-pool-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(IpPoolId, System.Globalization.CultureInfo.InvariantCulture)));
            request.Resource = ReadIpAddressPoolServiceURL.ToString();
            RestResponse<NSXTIpAddressPoolType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTIpAddressPoolType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Get operation to " + ReadIpAddressPoolServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task CreateOrPatchIpAddressPool(string IpPoolId, NSXTIpAddressPoolType IpAddressPool)
        {
            if (IpPoolId == null) { throw new System.ArgumentNullException("IpPoolId cannot be null"); }
            if (IpAddressPool == null) { throw new System.ArgumentNullException("IpAddressPool cannot be null"); }
            StringBuilder CreateOrPatchIpAddressPoolServiceURL = new StringBuilder("/infra/ip-pools/{ip-pool-id}");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Patch
            };
            CreateOrPatchIpAddressPoolServiceURL.Replace("{ip-pool-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(IpPoolId, System.Globalization.CultureInfo.InvariantCulture)));
            request.AddJsonBody(IpAddressPool);
            request.Resource = CreateOrPatchIpAddressPoolServiceURL.ToString();
            RestResponse response = await restClient.ExecuteTaskAsyncWithPolicy(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Patch operation to " + CreateOrPatchIpAddressPoolServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTIpAddressPoolListResultType> ListManagerIpPools(string? Cursor = null, bool? IncludeMarkForDeleteObjects = null, string? IncludedFields = null, long? PageSize = null, bool? SortAscending = null, string? SortBy = null)
        {
            StringBuilder ListManagerIpPoolsServiceURL = new StringBuilder("/infra/manager-ip-pools");
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
            request.Resource = ListManagerIpPoolsServiceURL.ToString();
            RestResponse<NSXTIpAddressPoolListResultType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTIpAddressPoolListResultType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Get operation to " + ListManagerIpPoolsServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTIpAddressAllocationType> CreateOrReplaceIpAddressPoolAllocation(string IpPoolId, string IpAllocationId, NSXTIpAddressAllocationType IpAddressAllocation)
        {
            if (IpPoolId == null) { throw new System.ArgumentNullException("IpPoolId cannot be null"); }
            if (IpAllocationId == null) { throw new System.ArgumentNullException("IpAllocationId cannot be null"); }
            if (IpAddressAllocation == null) { throw new System.ArgumentNullException("IpAddressAllocation cannot be null"); }
            StringBuilder CreateOrReplaceIpAddressPoolAllocationServiceURL = new StringBuilder("/infra/ip-pools/{ip-pool-id}/ip-allocations/{ip-allocation-id}");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Put
            };
            CreateOrReplaceIpAddressPoolAllocationServiceURL.Replace("{ip-pool-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(IpPoolId, System.Globalization.CultureInfo.InvariantCulture)));
            CreateOrReplaceIpAddressPoolAllocationServiceURL.Replace("{ip-allocation-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(IpAllocationId, System.Globalization.CultureInfo.InvariantCulture)));
            request.AddJsonBody(IpAddressAllocation);
            request.Resource = CreateOrReplaceIpAddressPoolAllocationServiceURL.ToString();
            RestResponse<NSXTIpAddressAllocationType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTIpAddressAllocationType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Put operation to " + CreateOrReplaceIpAddressPoolAllocationServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTIpAddressAllocationType> ReadIpAddressPoolAllocation(string IpPoolId, string IpAllocationId)
        {
            if (IpPoolId == null) { throw new System.ArgumentNullException("IpPoolId cannot be null"); }
            if (IpAllocationId == null) { throw new System.ArgumentNullException("IpAllocationId cannot be null"); }
            StringBuilder ReadIpAddressPoolAllocationServiceURL = new StringBuilder("/infra/ip-pools/{ip-pool-id}/ip-allocations/{ip-allocation-id}");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Get
            };
            ReadIpAddressPoolAllocationServiceURL.Replace("{ip-pool-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(IpPoolId, System.Globalization.CultureInfo.InvariantCulture)));
            ReadIpAddressPoolAllocationServiceURL.Replace("{ip-allocation-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(IpAllocationId, System.Globalization.CultureInfo.InvariantCulture)));
            request.Resource = ReadIpAddressPoolAllocationServiceURL.ToString();
            RestResponse<NSXTIpAddressAllocationType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTIpAddressAllocationType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Get operation to " + ReadIpAddressPoolAllocationServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task CreateOrPatchIpAddressPoolAllocation(string IpPoolId, string IpAllocationId, NSXTIpAddressAllocationType IpAddressAllocation)
        {
            if (IpPoolId == null) { throw new System.ArgumentNullException("IpPoolId cannot be null"); }
            if (IpAllocationId == null) { throw new System.ArgumentNullException("IpAllocationId cannot be null"); }
            if (IpAddressAllocation == null) { throw new System.ArgumentNullException("IpAddressAllocation cannot be null"); }
            StringBuilder CreateOrPatchIpAddressPoolAllocationServiceURL = new StringBuilder("/infra/ip-pools/{ip-pool-id}/ip-allocations/{ip-allocation-id}");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Patch
            };
            CreateOrPatchIpAddressPoolAllocationServiceURL.Replace("{ip-pool-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(IpPoolId, System.Globalization.CultureInfo.InvariantCulture)));
            CreateOrPatchIpAddressPoolAllocationServiceURL.Replace("{ip-allocation-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(IpAllocationId, System.Globalization.CultureInfo.InvariantCulture)));
            request.AddJsonBody(IpAddressAllocation);
            request.Resource = CreateOrPatchIpAddressPoolAllocationServiceURL.ToString();
            RestResponse response = await restClient.ExecuteTaskAsyncWithPolicy(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Patch operation to " + CreateOrPatchIpAddressPoolAllocationServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task DeleteIpAddressPoolAllocation(string IpPoolId, string IpAllocationId)
        {
            if (IpPoolId == null) { throw new System.ArgumentNullException("IpPoolId cannot be null"); }
            if (IpAllocationId == null) { throw new System.ArgumentNullException("IpAllocationId cannot be null"); }
            StringBuilder DeleteIpAddressPoolAllocationServiceURL = new StringBuilder("/infra/ip-pools/{ip-pool-id}/ip-allocations/{ip-allocation-id}");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Delete
            };
            DeleteIpAddressPoolAllocationServiceURL.Replace("{ip-pool-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(IpPoolId, System.Globalization.CultureInfo.InvariantCulture)));
            DeleteIpAddressPoolAllocationServiceURL.Replace("{ip-allocation-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(IpAllocationId, System.Globalization.CultureInfo.InvariantCulture)));
            request.Resource = DeleteIpAddressPoolAllocationServiceURL.ToString();
            RestResponse response = await restClient.ExecuteTaskAsyncWithPolicy(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Delete operation to " + DeleteIpAddressPoolAllocationServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTIpAddressAllocationListResultType> ListIpAddressPoolAllocations(string IpPoolId, string? Cursor = null, bool? IncludeMarkForDeleteObjects = null, string? IncludedFields = null, long? PageSize = null, bool? SortAscending = null, string? SortBy = null)
        {
            if (IpPoolId == null) { throw new System.ArgumentNullException("IpPoolId cannot be null"); }
            StringBuilder ListIpAddressPoolAllocationsServiceURL = new StringBuilder("/infra/ip-pools/{ip-pool-id}/ip-allocations");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Get
            };
            ListIpAddressPoolAllocationsServiceURL.Replace("{ip-pool-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(IpPoolId, System.Globalization.CultureInfo.InvariantCulture)));
            if (Cursor != null) { request.AddQueryParameter("cursor", Cursor.ToString()); }
            if (IncludeMarkForDeleteObjects != null) { request.AddQueryParameter("include_mark_for_delete_objects", IncludeMarkForDeleteObjects.ToString()); }
            if (IncludedFields != null) { request.AddQueryParameter("included_fields", IncludedFields.ToString()); }
            if (PageSize != null) { request.AddQueryParameter("page_size", PageSize.ToString()); }
            if (SortAscending != null) { request.AddQueryParameter("sort_ascending", SortAscending.ToString()); }
            if (SortBy != null) { request.AddQueryParameter("sort_by", SortBy.ToString()); }
            request.Resource = ListIpAddressPoolAllocationsServiceURL.ToString();
            RestResponse<NSXTIpAddressAllocationListResultType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTIpAddressAllocationListResultType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Get operation to " + ListIpAddressPoolAllocationsServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTIpAddressPoolListResultType> ListIpAddressPools(string? Cursor = null, bool? IncludeMarkForDeleteObjects = null, string? IncludedFields = null, long? PageSize = null, bool? SortAscending = null, string? SortBy = null)
        {
            StringBuilder ListIpAddressPoolsServiceURL = new StringBuilder("/infra/ip-pools");
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
            request.Resource = ListIpAddressPoolsServiceURL.ToString();
            RestResponse<NSXTIpAddressPoolListResultType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTIpAddressPoolListResultType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Get operation to " + ListIpAddressPoolsServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTIpAddressBlockType> CreateOrReplaceIpAddressBlock(string IpBlockId, NSXTIpAddressBlockType IpAddressBlock)
        {
            if (IpBlockId == null) { throw new System.ArgumentNullException("IpBlockId cannot be null"); }
            if (IpAddressBlock == null) { throw new System.ArgumentNullException("IpAddressBlock cannot be null"); }
            StringBuilder CreateOrReplaceIpAddressBlockServiceURL = new StringBuilder("/infra/ip-blocks/{ip-block-id}");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Put
            };
            CreateOrReplaceIpAddressBlockServiceURL.Replace("{ip-block-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(IpBlockId, System.Globalization.CultureInfo.InvariantCulture)));
            request.AddJsonBody(IpAddressBlock);
            request.Resource = CreateOrReplaceIpAddressBlockServiceURL.ToString();
            RestResponse<NSXTIpAddressBlockType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTIpAddressBlockType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Put operation to " + CreateOrReplaceIpAddressBlockServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task DeleteIpAddressBlock(string IpBlockId)
        {
            if (IpBlockId == null) { throw new System.ArgumentNullException("IpBlockId cannot be null"); }
            StringBuilder DeleteIpAddressBlockServiceURL = new StringBuilder("/infra/ip-blocks/{ip-block-id}");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Delete
            };
            DeleteIpAddressBlockServiceURL.Replace("{ip-block-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(IpBlockId, System.Globalization.CultureInfo.InvariantCulture)));
            request.Resource = DeleteIpAddressBlockServiceURL.ToString();
            RestResponse response = await restClient.ExecuteTaskAsyncWithPolicy(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Delete operation to " + DeleteIpAddressBlockServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task CreateOrPatchIpAddressBlock(string IpBlockId, NSXTIpAddressBlockType IpAddressBlock)
        {
            if (IpBlockId == null) { throw new System.ArgumentNullException("IpBlockId cannot be null"); }
            if (IpAddressBlock == null) { throw new System.ArgumentNullException("IpAddressBlock cannot be null"); }
            StringBuilder CreateOrPatchIpAddressBlockServiceURL = new StringBuilder("/infra/ip-blocks/{ip-block-id}");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Patch
            };
            CreateOrPatchIpAddressBlockServiceURL.Replace("{ip-block-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(IpBlockId, System.Globalization.CultureInfo.InvariantCulture)));
            request.AddJsonBody(IpAddressBlock);
            request.Resource = CreateOrPatchIpAddressBlockServiceURL.ToString();
            RestResponse response = await restClient.ExecuteTaskAsyncWithPolicy(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Patch operation to " + CreateOrPatchIpAddressBlockServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTIpAddressBlockType> ReadIpAddressBlock(string IpBlockId)
        {
            if (IpBlockId == null) { throw new System.ArgumentNullException("IpBlockId cannot be null"); }
            StringBuilder ReadIpAddressBlockServiceURL = new StringBuilder("/infra/ip-blocks/{ip-block-id}");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Get
            };
            ReadIpAddressBlockServiceURL.Replace("{ip-block-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(IpBlockId, System.Globalization.CultureInfo.InvariantCulture)));
            request.Resource = ReadIpAddressBlockServiceURL.ToString();
            RestResponse<NSXTIpAddressBlockType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTIpAddressBlockType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Get operation to " + ReadIpAddressBlockServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTIpAddressBlockListResultType> ListIpAddressBlocks(string? Cursor = null, bool? IncludeMarkForDeleteObjects = null, string? IncludedFields = null, long? PageSize = null, bool? SortAscending = null, string? SortBy = null)
        {
            StringBuilder ListIpAddressBlocksServiceURL = new StringBuilder("/infra/ip-blocks");
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
            request.Resource = ListIpAddressBlocksServiceURL.ToString();
            RestResponse<NSXTIpAddressBlockListResultType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTIpAddressBlockListResultType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Get operation to " + ListIpAddressBlocksServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
    }
}
