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
    public class Ipam
    {
        private RestClient restClient;
        private int retry;
        private int timeout;
        private CancellationToken cancellationToken;

        public Ipam(RestClient Client, CancellationToken _cancellationToken, int _timeout, int _retry)
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
        public async Task<NSXTIpBlockSubnetType> CreateIpBlockSubnet(NSXTIpBlockSubnetType IpBlockSubnet)
        {
            if (IpBlockSubnet == null) { throw new System.ArgumentNullException("IpBlockSubnet cannot be null"); }
            StringBuilder CreateIpBlockSubnetServiceURL = new StringBuilder("/pools/ip-subnets");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Post
            };
            request.AddJsonBody(IpBlockSubnet);
            request.Resource = CreateIpBlockSubnetServiceURL.ToString();
            RestResponse<NSXTIpBlockSubnetType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTIpBlockSubnetType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Post operation to " + CreateIpBlockSubnetServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTIpBlockSubnetListResultType> ListIpBlockSubnets(string? BlockId = null, string? Cursor = null, string? IncludedFields = null, long? PageSize = null, bool? SortAscending = null, string? SortBy = null)
        {
            StringBuilder ListIpBlockSubnetsServiceURL = new StringBuilder("/pools/ip-subnets");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Get
            };
            if (BlockId != null) { request.AddQueryParameter("block_id", BlockId.ToString()); }
            if (Cursor != null) { request.AddQueryParameter("cursor", Cursor.ToString()); }
            if (IncludedFields != null) { request.AddQueryParameter("included_fields", IncludedFields.ToString()); }
            if (PageSize != null) { request.AddQueryParameter("page_size", PageSize.ToString()); }
            if (SortAscending != null) { request.AddQueryParameter("sort_ascending", SortAscending.ToString()); }
            if (SortBy != null) { request.AddQueryParameter("sort_by", SortBy.ToString()); }
            request.Resource = ListIpBlockSubnetsServiceURL.ToString();
            RestResponse<NSXTIpBlockSubnetListResultType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTIpBlockSubnetListResultType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Get operation to " + ListIpBlockSubnetsServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTIpBlockType> CreateIpBlock(NSXTIpBlockType IpBlock)
        {
            if (IpBlock == null) { throw new System.ArgumentNullException("IpBlock cannot be null"); }
            StringBuilder CreateIpBlockServiceURL = new StringBuilder("/pools/ip-blocks");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Post
            };
            request.AddJsonBody(IpBlock);
            request.Resource = CreateIpBlockServiceURL.ToString();
            RestResponse<NSXTIpBlockType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTIpBlockType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Post operation to " + CreateIpBlockServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTIpBlockListResultType> ListIpBlocks(string? Cursor = null, string? IncludedFields = null, long? PageSize = null, bool? SortAscending = null, string? SortBy = null)
        {
            StringBuilder ListIpBlocksServiceURL = new StringBuilder("/pools/ip-blocks");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Get
            };
            if (Cursor != null) { request.AddQueryParameter("cursor", Cursor.ToString()); }
            if (IncludedFields != null) { request.AddQueryParameter("included_fields", IncludedFields.ToString()); }
            if (PageSize != null) { request.AddQueryParameter("page_size", PageSize.ToString()); }
            if (SortAscending != null) { request.AddQueryParameter("sort_ascending", SortAscending.ToString()); }
            if (SortBy != null) { request.AddQueryParameter("sort_by", SortBy.ToString()); }
            request.Resource = ListIpBlocksServiceURL.ToString();
            RestResponse<NSXTIpBlockListResultType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTIpBlockListResultType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Get operation to " + ListIpBlocksServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTIpBlockType> UpdateIpBlock(string BlockId, NSXTIpBlockType IpBlock)
        {
            if (BlockId == null) { throw new System.ArgumentNullException("BlockId cannot be null"); }
            if (IpBlock == null) { throw new System.ArgumentNullException("IpBlock cannot be null"); }
            StringBuilder UpdateIpBlockServiceURL = new StringBuilder("/pools/ip-blocks/{block-id}");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Put
            };
            UpdateIpBlockServiceURL.Replace("{block-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(BlockId, System.Globalization.CultureInfo.InvariantCulture)));
            request.AddJsonBody(IpBlock);
            request.Resource = UpdateIpBlockServiceURL.ToString();
            RestResponse<NSXTIpBlockType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTIpBlockType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Put operation to " + UpdateIpBlockServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTIpBlockType> ReadIpBlock(string BlockId)
        {
            if (BlockId == null) { throw new System.ArgumentNullException("BlockId cannot be null"); }
            StringBuilder ReadIpBlockServiceURL = new StringBuilder("/pools/ip-blocks/{block-id}");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Get
            };
            ReadIpBlockServiceURL.Replace("{block-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(BlockId, System.Globalization.CultureInfo.InvariantCulture)));
            request.Resource = ReadIpBlockServiceURL.ToString();
            RestResponse<NSXTIpBlockType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTIpBlockType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Get operation to " + ReadIpBlockServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task DeleteIpBlock(string BlockId)
        {
            if (BlockId == null) { throw new System.ArgumentNullException("BlockId cannot be null"); }
            StringBuilder DeleteIpBlockServiceURL = new StringBuilder("/pools/ip-blocks/{block-id}");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Delete
            };
            DeleteIpBlockServiceURL.Replace("{block-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(BlockId, System.Globalization.CultureInfo.InvariantCulture)));
            request.Resource = DeleteIpBlockServiceURL.ToString();
            RestResponse response = await restClient.ExecuteTaskAsyncWithPolicy(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Delete operation to " + DeleteIpBlockServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTAllocationIpAddressType> AllocateOrReleaseFromIpBlockSubnet(string SubnetId, NSXTAllocationIpAddressType AllocationIpAddress, string Action)
        {
            if (SubnetId == null) { throw new System.ArgumentNullException("SubnetId cannot be null"); }
            if (AllocationIpAddress == null) { throw new System.ArgumentNullException("AllocationIpAddress cannot be null"); }
            if (Action == null) { throw new System.ArgumentNullException("Action cannot be null"); }
            StringBuilder AllocateOrReleaseFromIpBlockSubnetServiceURL = new StringBuilder("/pools/ip-subnets/{subnet-id}");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Post
            };
            AllocateOrReleaseFromIpBlockSubnetServiceURL.Replace("{subnet-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(SubnetId, System.Globalization.CultureInfo.InvariantCulture)));
            request.AddJsonBody(AllocationIpAddress);
            if (Action != null) { request.AddQueryParameter("action", Action.ToString()); }
            request.Resource = AllocateOrReleaseFromIpBlockSubnetServiceURL.ToString();
            RestResponse<NSXTAllocationIpAddressType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTAllocationIpAddressType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Post operation to " + AllocateOrReleaseFromIpBlockSubnetServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task DeleteIpBlockSubnet(string SubnetId)
        {
            if (SubnetId == null) { throw new System.ArgumentNullException("SubnetId cannot be null"); }
            StringBuilder DeleteIpBlockSubnetServiceURL = new StringBuilder("/pools/ip-subnets/{subnet-id}");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Delete
            };
            DeleteIpBlockSubnetServiceURL.Replace("{subnet-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(SubnetId, System.Globalization.CultureInfo.InvariantCulture)));
            request.Resource = DeleteIpBlockSubnetServiceURL.ToString();
            RestResponse response = await restClient.ExecuteTaskAsyncWithPolicy(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Delete operation to " + DeleteIpBlockSubnetServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTIpBlockSubnetType> ReadIpBlockSubnet(string SubnetId)
        {
            if (SubnetId == null) { throw new System.ArgumentNullException("SubnetId cannot be null"); }
            StringBuilder ReadIpBlockSubnetServiceURL = new StringBuilder("/pools/ip-subnets/{subnet-id}");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Get
            };
            ReadIpBlockSubnetServiceURL.Replace("{subnet-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(SubnetId, System.Globalization.CultureInfo.InvariantCulture)));
            request.Resource = ReadIpBlockSubnetServiceURL.ToString();
            RestResponse<NSXTIpBlockSubnetType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTIpBlockSubnetType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Get operation to " + ReadIpBlockSubnetServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTIpPoolType> CreateIpPool(NSXTIpPoolType IpPool)
        {
            if (IpPool == null) { throw new System.ArgumentNullException("IpPool cannot be null"); }
            StringBuilder CreateIpPoolServiceURL = new StringBuilder("/pools/ip-pools");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Post
            };
            request.AddJsonBody(IpPool);
            request.Resource = CreateIpPoolServiceURL.ToString();
            RestResponse<NSXTIpPoolType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTIpPoolType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Post operation to " + CreateIpPoolServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTIpPoolListResultType> ListIpPools(string? Cursor = null, string? IncludedFields = null, long? PageSize = null, bool? SortAscending = null, string? SortBy = null)
        {
            StringBuilder ListIpPoolsServiceURL = new StringBuilder("/pools/ip-pools");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Get
            };
            if (Cursor != null) { request.AddQueryParameter("cursor", Cursor.ToString()); }
            if (IncludedFields != null) { request.AddQueryParameter("included_fields", IncludedFields.ToString()); }
            if (PageSize != null) { request.AddQueryParameter("page_size", PageSize.ToString()); }
            if (SortAscending != null) { request.AddQueryParameter("sort_ascending", SortAscending.ToString()); }
            if (SortBy != null) { request.AddQueryParameter("sort_by", SortBy.ToString()); }
            request.Resource = ListIpPoolsServiceURL.ToString();
            RestResponse<NSXTIpPoolListResultType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTIpPoolListResultType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Get operation to " + ListIpPoolsServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTIpPoolType> UpdateIpPool(string PoolId, NSXTIpPoolType IpPool)
        {
            if (PoolId == null) { throw new System.ArgumentNullException("PoolId cannot be null"); }
            if (IpPool == null) { throw new System.ArgumentNullException("IpPool cannot be null"); }
            StringBuilder UpdateIpPoolServiceURL = new StringBuilder("/pools/ip-pools/{pool-id}");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Put
            };
            UpdateIpPoolServiceURL.Replace("{pool-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(PoolId, System.Globalization.CultureInfo.InvariantCulture)));
            request.AddJsonBody(IpPool);
            request.Resource = UpdateIpPoolServiceURL.ToString();
            RestResponse<NSXTIpPoolType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTIpPoolType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Put operation to " + UpdateIpPoolServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTAllocationIpAddressType> AllocateOrReleaseFromIpPool(string PoolId, NSXTAllocationIpAddressType AllocationIpAddress, string Action)
        {
            if (PoolId == null) { throw new System.ArgumentNullException("PoolId cannot be null"); }
            if (AllocationIpAddress == null) { throw new System.ArgumentNullException("AllocationIpAddress cannot be null"); }
            if (Action == null) { throw new System.ArgumentNullException("Action cannot be null"); }
            StringBuilder AllocateOrReleaseFromIpPoolServiceURL = new StringBuilder("/pools/ip-pools/{pool-id}");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Post
            };
            AllocateOrReleaseFromIpPoolServiceURL.Replace("{pool-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(PoolId, System.Globalization.CultureInfo.InvariantCulture)));
            request.AddJsonBody(AllocationIpAddress);
            if (Action != null) { request.AddQueryParameter("action", Action.ToString()); }
            request.Resource = AllocateOrReleaseFromIpPoolServiceURL.ToString();
            RestResponse<NSXTAllocationIpAddressType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTAllocationIpAddressType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Post operation to " + AllocateOrReleaseFromIpPoolServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTIpPoolType> ReadIpPool(string PoolId)
        {
            if (PoolId == null) { throw new System.ArgumentNullException("PoolId cannot be null"); }
            StringBuilder ReadIpPoolServiceURL = new StringBuilder("/pools/ip-pools/{pool-id}");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Get
            };
            ReadIpPoolServiceURL.Replace("{pool-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(PoolId, System.Globalization.CultureInfo.InvariantCulture)));
            request.Resource = ReadIpPoolServiceURL.ToString();
            RestResponse<NSXTIpPoolType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTIpPoolType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Get operation to " + ReadIpPoolServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task DeleteIpPool(string PoolId, bool? Force = null)
        {
            if (PoolId == null) { throw new System.ArgumentNullException("PoolId cannot be null"); }
            StringBuilder DeleteIpPoolServiceURL = new StringBuilder("/pools/ip-pools/{pool-id}");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Delete
            };
            DeleteIpPoolServiceURL.Replace("{pool-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(PoolId, System.Globalization.CultureInfo.InvariantCulture)));
            if (Force != null) { request.AddQueryParameter("force", Force.ToString()); }
            request.Resource = DeleteIpPoolServiceURL.ToString();
            RestResponse response = await restClient.ExecuteTaskAsyncWithPolicy(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Delete operation to " + DeleteIpPoolServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTAllocationIpAddressListResultType> ListIpPoolAllocations(string PoolId)
        {
            if (PoolId == null) { throw new System.ArgumentNullException("PoolId cannot be null"); }
            StringBuilder ListIpPoolAllocationsServiceURL = new StringBuilder("/pools/ip-pools/{pool-id}/allocations");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Get
            };
            ListIpPoolAllocationsServiceURL.Replace("{pool-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(PoolId, System.Globalization.CultureInfo.InvariantCulture)));
            request.Resource = ListIpPoolAllocationsServiceURL.ToString();
            RestResponse<NSXTAllocationIpAddressListResultType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTAllocationIpAddressListResultType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Get operation to " + ListIpPoolAllocationsServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
    }
}
