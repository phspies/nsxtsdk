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
    public class Dhcp
    {
        private RestClient restClient;
        private int retry;
        private int timeout;
        private CancellationToken cancellationToken;

        public Dhcp(RestClient Client, CancellationToken _cancellationToken, int _timeout, int _retry)
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
        public async Task<NSXTDhcpProfileType> ReallocateDhcpProfileEdgeCluster(string ServerProfileId, NSXTDhcpProfileType DhcpProfile)
        {
            if (ServerProfileId == null) { throw new System.ArgumentNullException("ServerProfileId cannot be null"); }
            if (DhcpProfile == null) { throw new System.ArgumentNullException("DhcpProfile cannot be null"); }
            StringBuilder ReallocateDhcpProfileEdgeClusterServiceURL = new StringBuilder("/dhcp/server-profiles/{server-profile-id}?action=reallocate");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Post
            };
            ReallocateDhcpProfileEdgeClusterServiceURL.Replace("{server-profile-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(ServerProfileId, System.Globalization.CultureInfo.InvariantCulture)));
            request.AddJsonBody(DhcpProfile);
            request.Resource = ReallocateDhcpProfileEdgeClusterServiceURL.ToString();
            RestResponse<NSXTDhcpProfileType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTDhcpProfileType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Post operation to " + ReallocateDhcpProfileEdgeClusterServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTDhcpIpPoolType> CreateDhcpIpPool(string ServerId, NSXTDhcpIpPoolType DhcpIpPool)
        {
            if (ServerId == null) { throw new System.ArgumentNullException("ServerId cannot be null"); }
            if (DhcpIpPool == null) { throw new System.ArgumentNullException("DhcpIpPool cannot be null"); }
            StringBuilder CreateDhcpIpPoolServiceURL = new StringBuilder("/dhcp/servers/{server-id}/ip-pools");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Post
            };
            CreateDhcpIpPoolServiceURL.Replace("{server-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(ServerId, System.Globalization.CultureInfo.InvariantCulture)));
            request.AddJsonBody(DhcpIpPool);
            request.Resource = CreateDhcpIpPoolServiceURL.ToString();
            RestResponse<NSXTDhcpIpPoolType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTDhcpIpPoolType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Post operation to " + CreateDhcpIpPoolServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTDhcpIpPoolListResultType> ListDhcpIpPools(string ServerId, string? Cursor = null, string? IncludedFields = null, long? PageSize = null, bool? SortAscending = null, string? SortBy = null)
        {
            if (ServerId == null) { throw new System.ArgumentNullException("ServerId cannot be null"); }
            StringBuilder ListDhcpIpPoolsServiceURL = new StringBuilder("/dhcp/servers/{server-id}/ip-pools");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Get
            };
            ListDhcpIpPoolsServiceURL.Replace("{server-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(ServerId, System.Globalization.CultureInfo.InvariantCulture)));
            if (Cursor != null) { request.AddQueryParameter("cursor", Cursor.ToString()); }
            if (IncludedFields != null) { request.AddQueryParameter("included_fields", IncludedFields.ToString()); }
            if (PageSize != null) { request.AddQueryParameter("page_size", PageSize.ToString()); }
            if (SortAscending != null) { request.AddQueryParameter("sort_ascending", SortAscending.ToString()); }
            if (SortBy != null) { request.AddQueryParameter("sort_by", SortBy.ToString()); }
            request.Resource = ListDhcpIpPoolsServiceURL.ToString();
            RestResponse<NSXTDhcpIpPoolListResultType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTDhcpIpPoolListResultType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Get operation to " + ListDhcpIpPoolsServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTDhcpProfileType> CreateDhcpProfile(NSXTDhcpProfileType DhcpProfile)
        {
            if (DhcpProfile == null) { throw new System.ArgumentNullException("DhcpProfile cannot be null"); }
            StringBuilder CreateDhcpProfileServiceURL = new StringBuilder("/dhcp/server-profiles");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Post
            };
            request.AddJsonBody(DhcpProfile);
            request.Resource = CreateDhcpProfileServiceURL.ToString();
            RestResponse<NSXTDhcpProfileType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTDhcpProfileType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Post operation to " + CreateDhcpProfileServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTDhcpProfileListResultType> ListDhcpProfiles(string? Cursor = null, string? IncludedFields = null, long? PageSize = null, bool? SortAscending = null, string? SortBy = null)
        {
            StringBuilder ListDhcpProfilesServiceURL = new StringBuilder("/dhcp/server-profiles");
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
            request.Resource = ListDhcpProfilesServiceURL.ToString();
            RestResponse<NSXTDhcpProfileListResultType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTDhcpProfileListResultType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Get operation to " + ListDhcpProfilesServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTLogicalDhcpServerType> CreateDhcpServer(NSXTLogicalDhcpServerType LogicalDhcpServer)
        {
            if (LogicalDhcpServer == null) { throw new System.ArgumentNullException("LogicalDhcpServer cannot be null"); }
            StringBuilder CreateDhcpServerServiceURL = new StringBuilder("/dhcp/servers");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Post
            };
            request.AddJsonBody(LogicalDhcpServer);
            request.Resource = CreateDhcpServerServiceURL.ToString();
            RestResponse<NSXTLogicalDhcpServerType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTLogicalDhcpServerType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Post operation to " + CreateDhcpServerServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTLogicalDhcpServerListResultType> ListDhcpServers(string? Cursor = null, string? IncludedFields = null, long? PageSize = null, bool? SortAscending = null, string? SortBy = null)
        {
            StringBuilder ListDhcpServersServiceURL = new StringBuilder("/dhcp/servers");
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
            request.Resource = ListDhcpServersServiceURL.ToString();
            RestResponse<NSXTLogicalDhcpServerListResultType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTLogicalDhcpServerListResultType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Get operation to " + ListDhcpServersServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTDhcpIpPoolType> UpdateDhcpIpPool(string ServerId, string PoolId, NSXTDhcpIpPoolType DhcpIpPool)
        {
            if (ServerId == null) { throw new System.ArgumentNullException("ServerId cannot be null"); }
            if (PoolId == null) { throw new System.ArgumentNullException("PoolId cannot be null"); }
            if (DhcpIpPool == null) { throw new System.ArgumentNullException("DhcpIpPool cannot be null"); }
            StringBuilder UpdateDhcpIpPoolServiceURL = new StringBuilder("/dhcp/servers/{server-id}/ip-pools/{pool-id}");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Put
            };
            UpdateDhcpIpPoolServiceURL.Replace("{server-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(ServerId, System.Globalization.CultureInfo.InvariantCulture)));
            UpdateDhcpIpPoolServiceURL.Replace("{pool-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(PoolId, System.Globalization.CultureInfo.InvariantCulture)));
            request.AddJsonBody(DhcpIpPool);
            request.Resource = UpdateDhcpIpPoolServiceURL.ToString();
            RestResponse<NSXTDhcpIpPoolType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTDhcpIpPoolType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Put operation to " + UpdateDhcpIpPoolServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTDhcpIpPoolType> ReadDhcpIpPool(string ServerId, string PoolId)
        {
            if (ServerId == null) { throw new System.ArgumentNullException("ServerId cannot be null"); }
            if (PoolId == null) { throw new System.ArgumentNullException("PoolId cannot be null"); }
            StringBuilder ReadDhcpIpPoolServiceURL = new StringBuilder("/dhcp/servers/{server-id}/ip-pools/{pool-id}");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Get
            };
            ReadDhcpIpPoolServiceURL.Replace("{server-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(ServerId, System.Globalization.CultureInfo.InvariantCulture)));
            ReadDhcpIpPoolServiceURL.Replace("{pool-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(PoolId, System.Globalization.CultureInfo.InvariantCulture)));
            request.Resource = ReadDhcpIpPoolServiceURL.ToString();
            RestResponse<NSXTDhcpIpPoolType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTDhcpIpPoolType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Get operation to " + ReadDhcpIpPoolServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task DeleteDhcpIpPool(string ServerId, string PoolId)
        {
            if (ServerId == null) { throw new System.ArgumentNullException("ServerId cannot be null"); }
            if (PoolId == null) { throw new System.ArgumentNullException("PoolId cannot be null"); }
            StringBuilder DeleteDhcpIpPoolServiceURL = new StringBuilder("/dhcp/servers/{server-id}/ip-pools/{pool-id}");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Delete
            };
            DeleteDhcpIpPoolServiceURL.Replace("{server-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(ServerId, System.Globalization.CultureInfo.InvariantCulture)));
            DeleteDhcpIpPoolServiceURL.Replace("{pool-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(PoolId, System.Globalization.CultureInfo.InvariantCulture)));
            request.Resource = DeleteDhcpIpPoolServiceURL.ToString();
            RestResponse response = await restClient.ExecuteTaskAsyncWithPolicy(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Delete operation to " + DeleteDhcpIpPoolServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTDhcpStaticBindingType> CreateDhcpStaticBinding(string ServerId, NSXTDhcpStaticBindingType DhcpStaticBinding)
        {
            if (ServerId == null) { throw new System.ArgumentNullException("ServerId cannot be null"); }
            if (DhcpStaticBinding == null) { throw new System.ArgumentNullException("DhcpStaticBinding cannot be null"); }
            StringBuilder CreateDhcpStaticBindingServiceURL = new StringBuilder("/dhcp/servers/{server-id}/static-bindings");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Post
            };
            CreateDhcpStaticBindingServiceURL.Replace("{server-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(ServerId, System.Globalization.CultureInfo.InvariantCulture)));
            request.AddJsonBody(DhcpStaticBinding);
            request.Resource = CreateDhcpStaticBindingServiceURL.ToString();
            RestResponse<NSXTDhcpStaticBindingType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTDhcpStaticBindingType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Post operation to " + CreateDhcpStaticBindingServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTDhcpStaticBindingListResultType> ListDhcpStaticBindings(string ServerId, string? Cursor = null, string? IncludedFields = null, long? PageSize = null, bool? SortAscending = null, string? SortBy = null)
        {
            if (ServerId == null) { throw new System.ArgumentNullException("ServerId cannot be null"); }
            StringBuilder ListDhcpStaticBindingsServiceURL = new StringBuilder("/dhcp/servers/{server-id}/static-bindings");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Get
            };
            ListDhcpStaticBindingsServiceURL.Replace("{server-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(ServerId, System.Globalization.CultureInfo.InvariantCulture)));
            if (Cursor != null) { request.AddQueryParameter("cursor", Cursor.ToString()); }
            if (IncludedFields != null) { request.AddQueryParameter("included_fields", IncludedFields.ToString()); }
            if (PageSize != null) { request.AddQueryParameter("page_size", PageSize.ToString()); }
            if (SortAscending != null) { request.AddQueryParameter("sort_ascending", SortAscending.ToString()); }
            if (SortBy != null) { request.AddQueryParameter("sort_by", SortBy.ToString()); }
            request.Resource = ListDhcpStaticBindingsServiceURL.ToString();
            RestResponse<NSXTDhcpStaticBindingListResultType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTDhcpStaticBindingListResultType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Get operation to " + ListDhcpStaticBindingsServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTConfigurationStateType> GetDhcpServerState(string ServerId, long? BarrierId = null, string? RequestId = null)
        {
            if (ServerId == null) { throw new System.ArgumentNullException("ServerId cannot be null"); }
            StringBuilder GetDhcpServerStateServiceURL = new StringBuilder("/dhcp/servers/{server-id}/state");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Get
            };
            GetDhcpServerStateServiceURL.Replace("{server-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(ServerId, System.Globalization.CultureInfo.InvariantCulture)));
            if (BarrierId != null) { request.AddQueryParameter("barrier_id", BarrierId.ToString()); }
            if (RequestId != null) { request.AddQueryParameter("request_id", RequestId.ToString()); }
            request.Resource = GetDhcpServerStateServiceURL.ToString();
            RestResponse<NSXTConfigurationStateType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTConfigurationStateType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Get operation to " + GetDhcpServerStateServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTLogicalDhcpServerType> UpdateDhcpServer(string ServerId, NSXTLogicalDhcpServerType LogicalDhcpServer)
        {
            if (ServerId == null) { throw new System.ArgumentNullException("ServerId cannot be null"); }
            if (LogicalDhcpServer == null) { throw new System.ArgumentNullException("LogicalDhcpServer cannot be null"); }
            StringBuilder UpdateDhcpServerServiceURL = new StringBuilder("/dhcp/servers/{server-id}");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Put
            };
            UpdateDhcpServerServiceURL.Replace("{server-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(ServerId, System.Globalization.CultureInfo.InvariantCulture)));
            request.AddJsonBody(LogicalDhcpServer);
            request.Resource = UpdateDhcpServerServiceURL.ToString();
            RestResponse<NSXTLogicalDhcpServerType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTLogicalDhcpServerType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Put operation to " + UpdateDhcpServerServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task DeleteDhcpServer(string ServerId)
        {
            if (ServerId == null) { throw new System.ArgumentNullException("ServerId cannot be null"); }
            StringBuilder DeleteDhcpServerServiceURL = new StringBuilder("/dhcp/servers/{server-id}");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Delete
            };
            DeleteDhcpServerServiceURL.Replace("{server-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(ServerId, System.Globalization.CultureInfo.InvariantCulture)));
            request.Resource = DeleteDhcpServerServiceURL.ToString();
            RestResponse response = await restClient.ExecuteTaskAsyncWithPolicy(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Delete operation to " + DeleteDhcpServerServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTLogicalDhcpServerType> ReadDhcpServer(string ServerId)
        {
            if (ServerId == null) { throw new System.ArgumentNullException("ServerId cannot be null"); }
            StringBuilder ReadDhcpServerServiceURL = new StringBuilder("/dhcp/servers/{server-id}");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Get
            };
            ReadDhcpServerServiceURL.Replace("{server-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(ServerId, System.Globalization.CultureInfo.InvariantCulture)));
            request.Resource = ReadDhcpServerServiceURL.ToString();
            RestResponse<NSXTLogicalDhcpServerType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTLogicalDhcpServerType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Get operation to " + ReadDhcpServerServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTDhcpV6IpPoolType> UpdateDhcpV6IpPool(string ServerId, string PoolId, NSXTDhcpV6IpPoolType DhcpV6IpPool)
        {
            if (ServerId == null) { throw new System.ArgumentNullException("ServerId cannot be null"); }
            if (PoolId == null) { throw new System.ArgumentNullException("PoolId cannot be null"); }
            if (DhcpV6IpPool == null) { throw new System.ArgumentNullException("DhcpV6IpPool cannot be null"); }
            StringBuilder UpdateDhcpV6IpPoolServiceURL = new StringBuilder("/dhcp/servers/{server-id}/ipv6-ip-pools/{pool-id}");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Put
            };
            UpdateDhcpV6IpPoolServiceURL.Replace("{server-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(ServerId, System.Globalization.CultureInfo.InvariantCulture)));
            UpdateDhcpV6IpPoolServiceURL.Replace("{pool-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(PoolId, System.Globalization.CultureInfo.InvariantCulture)));
            request.AddJsonBody(DhcpV6IpPool);
            request.Resource = UpdateDhcpV6IpPoolServiceURL.ToString();
            RestResponse<NSXTDhcpV6IpPoolType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTDhcpV6IpPoolType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Put operation to " + UpdateDhcpV6IpPoolServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task DeleteDhcpV6IpPool(string ServerId, string PoolId)
        {
            if (ServerId == null) { throw new System.ArgumentNullException("ServerId cannot be null"); }
            if (PoolId == null) { throw new System.ArgumentNullException("PoolId cannot be null"); }
            StringBuilder DeleteDhcpV6IpPoolServiceURL = new StringBuilder("/dhcp/servers/{server-id}/ipv6-ip-pools/{pool-id}");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Delete
            };
            DeleteDhcpV6IpPoolServiceURL.Replace("{server-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(ServerId, System.Globalization.CultureInfo.InvariantCulture)));
            DeleteDhcpV6IpPoolServiceURL.Replace("{pool-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(PoolId, System.Globalization.CultureInfo.InvariantCulture)));
            request.Resource = DeleteDhcpV6IpPoolServiceURL.ToString();
            RestResponse response = await restClient.ExecuteTaskAsyncWithPolicy(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Delete operation to " + DeleteDhcpV6IpPoolServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTDhcpV6IpPoolType> ReadDhcpV6IpPool(string ServerId, string PoolId)
        {
            if (ServerId == null) { throw new System.ArgumentNullException("ServerId cannot be null"); }
            if (PoolId == null) { throw new System.ArgumentNullException("PoolId cannot be null"); }
            StringBuilder ReadDhcpV6IpPoolServiceURL = new StringBuilder("/dhcp/servers/{server-id}/ipv6-ip-pools/{pool-id}");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Get
            };
            ReadDhcpV6IpPoolServiceURL.Replace("{server-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(ServerId, System.Globalization.CultureInfo.InvariantCulture)));
            ReadDhcpV6IpPoolServiceURL.Replace("{pool-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(PoolId, System.Globalization.CultureInfo.InvariantCulture)));
            request.Resource = ReadDhcpV6IpPoolServiceURL.ToString();
            RestResponse<NSXTDhcpV6IpPoolType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTDhcpV6IpPoolType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Get operation to " + ReadDhcpV6IpPoolServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTDhcpStaticBindingType> UpdateDhcpStaticBinding(string ServerId, string BindingId, NSXTDhcpStaticBindingType DhcpStaticBinding)
        {
            if (ServerId == null) { throw new System.ArgumentNullException("ServerId cannot be null"); }
            if (BindingId == null) { throw new System.ArgumentNullException("BindingId cannot be null"); }
            if (DhcpStaticBinding == null) { throw new System.ArgumentNullException("DhcpStaticBinding cannot be null"); }
            StringBuilder UpdateDhcpStaticBindingServiceURL = new StringBuilder("/dhcp/servers/{server-id}/static-bindings/{binding-id}");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Put
            };
            UpdateDhcpStaticBindingServiceURL.Replace("{server-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(ServerId, System.Globalization.CultureInfo.InvariantCulture)));
            UpdateDhcpStaticBindingServiceURL.Replace("{binding-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(BindingId, System.Globalization.CultureInfo.InvariantCulture)));
            request.AddJsonBody(DhcpStaticBinding);
            request.Resource = UpdateDhcpStaticBindingServiceURL.ToString();
            RestResponse<NSXTDhcpStaticBindingType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTDhcpStaticBindingType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Put operation to " + UpdateDhcpStaticBindingServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task DeleteDhcpStaticBinding(string ServerId, string BindingId)
        {
            if (ServerId == null) { throw new System.ArgumentNullException("ServerId cannot be null"); }
            if (BindingId == null) { throw new System.ArgumentNullException("BindingId cannot be null"); }
            StringBuilder DeleteDhcpStaticBindingServiceURL = new StringBuilder("/dhcp/servers/{server-id}/static-bindings/{binding-id}");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Delete
            };
            DeleteDhcpStaticBindingServiceURL.Replace("{server-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(ServerId, System.Globalization.CultureInfo.InvariantCulture)));
            DeleteDhcpStaticBindingServiceURL.Replace("{binding-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(BindingId, System.Globalization.CultureInfo.InvariantCulture)));
            request.Resource = DeleteDhcpStaticBindingServiceURL.ToString();
            RestResponse response = await restClient.ExecuteTaskAsyncWithPolicy(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Delete operation to " + DeleteDhcpStaticBindingServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTDhcpStaticBindingType> ReadDhcpStaticBinding(string ServerId, string BindingId)
        {
            if (ServerId == null) { throw new System.ArgumentNullException("ServerId cannot be null"); }
            if (BindingId == null) { throw new System.ArgumentNullException("BindingId cannot be null"); }
            StringBuilder ReadDhcpStaticBindingServiceURL = new StringBuilder("/dhcp/servers/{server-id}/static-bindings/{binding-id}");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Get
            };
            ReadDhcpStaticBindingServiceURL.Replace("{server-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(ServerId, System.Globalization.CultureInfo.InvariantCulture)));
            ReadDhcpStaticBindingServiceURL.Replace("{binding-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(BindingId, System.Globalization.CultureInfo.InvariantCulture)));
            request.Resource = ReadDhcpStaticBindingServiceURL.ToString();
            RestResponse<NSXTDhcpStaticBindingType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTDhcpStaticBindingType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Get operation to " + ReadDhcpStaticBindingServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTDhcpProfileType> UpdateDhcpProfile(string ProfileId, NSXTDhcpProfileType DhcpProfile)
        {
            if (ProfileId == null) { throw new System.ArgumentNullException("ProfileId cannot be null"); }
            if (DhcpProfile == null) { throw new System.ArgumentNullException("DhcpProfile cannot be null"); }
            StringBuilder UpdateDhcpProfileServiceURL = new StringBuilder("/dhcp/server-profiles/{profile-id}");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Put
            };
            UpdateDhcpProfileServiceURL.Replace("{profile-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(ProfileId, System.Globalization.CultureInfo.InvariantCulture)));
            request.AddJsonBody(DhcpProfile);
            request.Resource = UpdateDhcpProfileServiceURL.ToString();
            RestResponse<NSXTDhcpProfileType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTDhcpProfileType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Put operation to " + UpdateDhcpProfileServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTDhcpProfileType> ReadDhcpProfile(string ProfileId)
        {
            if (ProfileId == null) { throw new System.ArgumentNullException("ProfileId cannot be null"); }
            StringBuilder ReadDhcpProfileServiceURL = new StringBuilder("/dhcp/server-profiles/{profile-id}");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Get
            };
            ReadDhcpProfileServiceURL.Replace("{profile-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(ProfileId, System.Globalization.CultureInfo.InvariantCulture)));
            request.Resource = ReadDhcpProfileServiceURL.ToString();
            RestResponse<NSXTDhcpProfileType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTDhcpProfileType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Get operation to " + ReadDhcpProfileServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task DeleteDhcpProfile(string ProfileId)
        {
            if (ProfileId == null) { throw new System.ArgumentNullException("ProfileId cannot be null"); }
            StringBuilder DeleteDhcpProfileServiceURL = new StringBuilder("/dhcp/server-profiles/{profile-id}");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Delete
            };
            DeleteDhcpProfileServiceURL.Replace("{profile-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(ProfileId, System.Globalization.CultureInfo.InvariantCulture)));
            request.Resource = DeleteDhcpProfileServiceURL.ToString();
            RestResponse response = await restClient.ExecuteTaskAsyncWithPolicy(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Delete operation to " + DeleteDhcpProfileServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTDhcpV6IpPoolType> CreateDhcpV6IpPool(string ServerId, NSXTDhcpV6IpPoolType DhcpV6IpPool)
        {
            if (ServerId == null) { throw new System.ArgumentNullException("ServerId cannot be null"); }
            if (DhcpV6IpPool == null) { throw new System.ArgumentNullException("DhcpV6IpPool cannot be null"); }
            StringBuilder CreateDhcpV6IpPoolServiceURL = new StringBuilder("/dhcp/servers/{server-id}/ipv6-ip-pools");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Post
            };
            CreateDhcpV6IpPoolServiceURL.Replace("{server-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(ServerId, System.Globalization.CultureInfo.InvariantCulture)));
            request.AddJsonBody(DhcpV6IpPool);
            request.Resource = CreateDhcpV6IpPoolServiceURL.ToString();
            RestResponse<NSXTDhcpV6IpPoolType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTDhcpV6IpPoolType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Post operation to " + CreateDhcpV6IpPoolServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTDhcpV6IpPoolListResultType> ListDhcpV6IpPools(string ServerId, string? Cursor = null, string? IncludedFields = null, long? PageSize = null, bool? SortAscending = null, string? SortBy = null)
        {
            if (ServerId == null) { throw new System.ArgumentNullException("ServerId cannot be null"); }
            StringBuilder ListDhcpV6IpPoolsServiceURL = new StringBuilder("/dhcp/servers/{server-id}/ipv6-ip-pools");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Get
            };
            ListDhcpV6IpPoolsServiceURL.Replace("{server-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(ServerId, System.Globalization.CultureInfo.InvariantCulture)));
            if (Cursor != null) { request.AddQueryParameter("cursor", Cursor.ToString()); }
            if (IncludedFields != null) { request.AddQueryParameter("included_fields", IncludedFields.ToString()); }
            if (PageSize != null) { request.AddQueryParameter("page_size", PageSize.ToString()); }
            if (SortAscending != null) { request.AddQueryParameter("sort_ascending", SortAscending.ToString()); }
            if (SortBy != null) { request.AddQueryParameter("sort_by", SortBy.ToString()); }
            request.Resource = ListDhcpV6IpPoolsServiceURL.ToString();
            RestResponse<NSXTDhcpV6IpPoolListResultType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTDhcpV6IpPoolListResultType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Get operation to " + ListDhcpV6IpPoolsServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTConfigurationStateType> GetDhcpStaticBindingState(string ServerId, string BindingId, long? BarrierId = null, string? RequestId = null)
        {
            if (ServerId == null) { throw new System.ArgumentNullException("ServerId cannot be null"); }
            if (BindingId == null) { throw new System.ArgumentNullException("BindingId cannot be null"); }
            StringBuilder GetDhcpStaticBindingStateServiceURL = new StringBuilder("/dhcp/servers/{server-id}/static-bindings/{binding-id}/state");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Get
            };
            GetDhcpStaticBindingStateServiceURL.Replace("{server-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(ServerId, System.Globalization.CultureInfo.InvariantCulture)));
            GetDhcpStaticBindingStateServiceURL.Replace("{binding-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(BindingId, System.Globalization.CultureInfo.InvariantCulture)));
            if (BarrierId != null) { request.AddQueryParameter("barrier_id", BarrierId.ToString()); }
            if (RequestId != null) { request.AddQueryParameter("request_id", RequestId.ToString()); }
            request.Resource = GetDhcpStaticBindingStateServiceURL.ToString();
            RestResponse<NSXTConfigurationStateType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTConfigurationStateType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Get operation to " + GetDhcpStaticBindingStateServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTConfigurationStateType> GetDhcpIpPoolState(string ServerId, string PoolId, long? BarrierId = null, string? RequestId = null)
        {
            if (ServerId == null) { throw new System.ArgumentNullException("ServerId cannot be null"); }
            if (PoolId == null) { throw new System.ArgumentNullException("PoolId cannot be null"); }
            StringBuilder GetDhcpIpPoolStateServiceURL = new StringBuilder("/dhcp/servers/{server-id}/ip-pools/{pool-id}/state");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Get
            };
            GetDhcpIpPoolStateServiceURL.Replace("{server-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(ServerId, System.Globalization.CultureInfo.InvariantCulture)));
            GetDhcpIpPoolStateServiceURL.Replace("{pool-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(PoolId, System.Globalization.CultureInfo.InvariantCulture)));
            if (BarrierId != null) { request.AddQueryParameter("barrier_id", BarrierId.ToString()); }
            if (RequestId != null) { request.AddQueryParameter("request_id", RequestId.ToString()); }
            request.Resource = GetDhcpIpPoolStateServiceURL.ToString();
            RestResponse<NSXTConfigurationStateType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTConfigurationStateType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Get operation to " + GetDhcpIpPoolStateServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTDhcpV6StaticBindingType> CreateDhcpV6StaticBinding(string ServerId, NSXTDhcpV6StaticBindingType DhcpV6StaticBinding)
        {
            if (ServerId == null) { throw new System.ArgumentNullException("ServerId cannot be null"); }
            if (DhcpV6StaticBinding == null) { throw new System.ArgumentNullException("DhcpV6StaticBinding cannot be null"); }
            StringBuilder CreateDhcpV6StaticBindingServiceURL = new StringBuilder("/dhcp/servers/{server-id}/ipv6-static-bindings");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Post
            };
            CreateDhcpV6StaticBindingServiceURL.Replace("{server-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(ServerId, System.Globalization.CultureInfo.InvariantCulture)));
            request.AddJsonBody(DhcpV6StaticBinding);
            request.Resource = CreateDhcpV6StaticBindingServiceURL.ToString();
            RestResponse<NSXTDhcpV6StaticBindingType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTDhcpV6StaticBindingType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Post operation to " + CreateDhcpV6StaticBindingServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTDhcpV6StaticBindingListResultType> ListDhcpV6StaticBindings(string ServerId, string? Cursor = null, string? IncludedFields = null, long? PageSize = null, bool? SortAscending = null, string? SortBy = null)
        {
            if (ServerId == null) { throw new System.ArgumentNullException("ServerId cannot be null"); }
            StringBuilder ListDhcpV6StaticBindingsServiceURL = new StringBuilder("/dhcp/servers/{server-id}/ipv6-static-bindings");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Get
            };
            ListDhcpV6StaticBindingsServiceURL.Replace("{server-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(ServerId, System.Globalization.CultureInfo.InvariantCulture)));
            if (Cursor != null) { request.AddQueryParameter("cursor", Cursor.ToString()); }
            if (IncludedFields != null) { request.AddQueryParameter("included_fields", IncludedFields.ToString()); }
            if (PageSize != null) { request.AddQueryParameter("page_size", PageSize.ToString()); }
            if (SortAscending != null) { request.AddQueryParameter("sort_ascending", SortAscending.ToString()); }
            if (SortBy != null) { request.AddQueryParameter("sort_by", SortBy.ToString()); }
            request.Resource = ListDhcpV6StaticBindingsServiceURL.ToString();
            RestResponse<NSXTDhcpV6StaticBindingListResultType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTDhcpV6StaticBindingListResultType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Get operation to " + ListDhcpV6StaticBindingsServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTDhcpLeasesType> GetDhcpLeaseInfo(string ServerId, string? Address = null, string? PoolId = null, string? Source = null)
        {
            if (ServerId == null) { throw new System.ArgumentNullException("ServerId cannot be null"); }
            StringBuilder GetDhcpLeaseInfoServiceURL = new StringBuilder("/dhcp/servers/{server-id}/leases");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Get
            };
            GetDhcpLeaseInfoServiceURL.Replace("{server-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(ServerId, System.Globalization.CultureInfo.InvariantCulture)));
            if (Address != null) { request.AddQueryParameter("address", Address.ToString()); }
            if (PoolId != null) { request.AddQueryParameter("pool_id", PoolId.ToString()); }
            if (Source != null) { request.AddQueryParameter("source", Source.ToString()); }
            request.Resource = GetDhcpLeaseInfoServiceURL.ToString();
            RestResponse<NSXTDhcpLeasesType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTDhcpLeasesType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Get operation to " + GetDhcpLeaseInfoServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task DeleteAdhcpLease(string ServerId, string Ip, string Mac)
        {
            if (ServerId == null) { throw new System.ArgumentNullException("ServerId cannot be null"); }
            if (Ip == null) { throw new System.ArgumentNullException("Ip cannot be null"); }
            if (Mac == null) { throw new System.ArgumentNullException("Mac cannot be null"); }
            StringBuilder DeleteAdhcpLeaseServiceURL = new StringBuilder("/dhcp/servers/{server-id}/leases");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Delete
            };
            DeleteAdhcpLeaseServiceURL.Replace("{server-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(ServerId, System.Globalization.CultureInfo.InvariantCulture)));
            if (Ip != null) { request.AddQueryParameter("ip", Ip.ToString()); }
            if (Mac != null) { request.AddQueryParameter("mac", Mac.ToString()); }
            request.Resource = DeleteAdhcpLeaseServiceURL.ToString();
            RestResponse response = await restClient.ExecuteTaskAsyncWithPolicy(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Delete operation to " + DeleteAdhcpLeaseServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTDhcpV6StaticBindingType> UpdateDhcpV6StaticBinding(string ServerId, string BindingId, NSXTDhcpV6StaticBindingType DhcpV6StaticBinding)
        {
            if (ServerId == null) { throw new System.ArgumentNullException("ServerId cannot be null"); }
            if (BindingId == null) { throw new System.ArgumentNullException("BindingId cannot be null"); }
            if (DhcpV6StaticBinding == null) { throw new System.ArgumentNullException("DhcpV6StaticBinding cannot be null"); }
            StringBuilder UpdateDhcpV6StaticBindingServiceURL = new StringBuilder("/dhcp/servers/{server-id}/ipv6-static-bindings/{binding-id}");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Put
            };
            UpdateDhcpV6StaticBindingServiceURL.Replace("{server-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(ServerId, System.Globalization.CultureInfo.InvariantCulture)));
            UpdateDhcpV6StaticBindingServiceURL.Replace("{binding-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(BindingId, System.Globalization.CultureInfo.InvariantCulture)));
            request.AddJsonBody(DhcpV6StaticBinding);
            request.Resource = UpdateDhcpV6StaticBindingServiceURL.ToString();
            RestResponse<NSXTDhcpV6StaticBindingType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTDhcpV6StaticBindingType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Put operation to " + UpdateDhcpV6StaticBindingServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTDhcpV6StaticBindingType> ReadDhcpV6StaticBinding(string ServerId, string BindingId)
        {
            if (ServerId == null) { throw new System.ArgumentNullException("ServerId cannot be null"); }
            if (BindingId == null) { throw new System.ArgumentNullException("BindingId cannot be null"); }
            StringBuilder ReadDhcpV6StaticBindingServiceURL = new StringBuilder("/dhcp/servers/{server-id}/ipv6-static-bindings/{binding-id}");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Get
            };
            ReadDhcpV6StaticBindingServiceURL.Replace("{server-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(ServerId, System.Globalization.CultureInfo.InvariantCulture)));
            ReadDhcpV6StaticBindingServiceURL.Replace("{binding-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(BindingId, System.Globalization.CultureInfo.InvariantCulture)));
            request.Resource = ReadDhcpV6StaticBindingServiceURL.ToString();
            RestResponse<NSXTDhcpV6StaticBindingType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTDhcpV6StaticBindingType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Get operation to " + ReadDhcpV6StaticBindingServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task DeleteDhcpV6StaticBinding(string ServerId, string BindingId)
        {
            if (ServerId == null) { throw new System.ArgumentNullException("ServerId cannot be null"); }
            if (BindingId == null) { throw new System.ArgumentNullException("BindingId cannot be null"); }
            StringBuilder DeleteDhcpV6StaticBindingServiceURL = new StringBuilder("/dhcp/servers/{server-id}/ipv6-static-bindings/{binding-id}");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Delete
            };
            DeleteDhcpV6StaticBindingServiceURL.Replace("{server-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(ServerId, System.Globalization.CultureInfo.InvariantCulture)));
            DeleteDhcpV6StaticBindingServiceURL.Replace("{binding-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(BindingId, System.Globalization.CultureInfo.InvariantCulture)));
            request.Resource = DeleteDhcpV6StaticBindingServiceURL.ToString();
            RestResponse response = await restClient.ExecuteTaskAsyncWithPolicy(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Delete operation to " + DeleteDhcpV6StaticBindingServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            
        }
    }
}
