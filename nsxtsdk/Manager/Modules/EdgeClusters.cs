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
    public class EdgeClusters
    {
        private RestClient restClient;
        private int retry;
        private int timeout;
        private CancellationToken cancellationToken;

        public EdgeClusters(RestClient Client, CancellationToken _cancellationToken, int _timeout, int _retry)
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
        public async Task<NSXTEdgeClusterType> UpdateEdgeCluster(string EdgeClusterId, NSXTEdgeClusterType EdgeCluster)
        {
            if (EdgeClusterId == null) { throw new System.ArgumentNullException("EdgeClusterId cannot be null"); }
            if (EdgeCluster == null) { throw new System.ArgumentNullException("EdgeCluster cannot be null"); }
            StringBuilder UpdateEdgeClusterServiceURL = new StringBuilder("/edge-clusters/{edge-cluster-id}");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Put
            };
            UpdateEdgeClusterServiceURL.Replace("{edge-cluster-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(EdgeClusterId, System.Globalization.CultureInfo.InvariantCulture)));
            request.AddJsonBody(EdgeCluster);
            request.Resource = UpdateEdgeClusterServiceURL.ToString();
            RestResponse<NSXTEdgeClusterType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTEdgeClusterType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Put operation to " + UpdateEdgeClusterServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task DeleteEdgeCluster(string EdgeClusterId)
        {
            if (EdgeClusterId == null) { throw new System.ArgumentNullException("EdgeClusterId cannot be null"); }
            StringBuilder DeleteEdgeClusterServiceURL = new StringBuilder("/edge-clusters/{edge-cluster-id}");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Delete
            };
            DeleteEdgeClusterServiceURL.Replace("{edge-cluster-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(EdgeClusterId, System.Globalization.CultureInfo.InvariantCulture)));
            request.Resource = DeleteEdgeClusterServiceURL.ToString();
            RestResponse response = await restClient.ExecuteTaskAsyncWithPolicy(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Delete operation to " + DeleteEdgeClusterServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTEdgeClusterType> ReadEdgeCluster(string EdgeClusterId)
        {
            if (EdgeClusterId == null) { throw new System.ArgumentNullException("EdgeClusterId cannot be null"); }
            StringBuilder ReadEdgeClusterServiceURL = new StringBuilder("/edge-clusters/{edge-cluster-id}");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Get
            };
            ReadEdgeClusterServiceURL.Replace("{edge-cluster-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(EdgeClusterId, System.Globalization.CultureInfo.InvariantCulture)));
            request.Resource = ReadEdgeClusterServiceURL.ToString();
            RestResponse<NSXTEdgeClusterType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTEdgeClusterType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Get operation to " + ReadEdgeClusterServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTEdgeClusterType> CreateEdgeCluster(NSXTEdgeClusterType EdgeCluster)
        {
            if (EdgeCluster == null) { throw new System.ArgumentNullException("EdgeCluster cannot be null"); }
            StringBuilder CreateEdgeClusterServiceURL = new StringBuilder("/edge-clusters");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Post
            };
            request.AddJsonBody(EdgeCluster);
            request.Resource = CreateEdgeClusterServiceURL.ToString();
            RestResponse<NSXTEdgeClusterType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTEdgeClusterType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Post operation to " + CreateEdgeClusterServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTEdgeClusterListResultType> ListEdgeClusters(string? Cursor = null, string? IncludedFields = null, long? PageSize = null, bool? SortAscending = null, string? SortBy = null)
        {
            StringBuilder ListEdgeClustersServiceURL = new StringBuilder("/edge-clusters");
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
            request.Resource = ListEdgeClustersServiceURL.ToString();
            RestResponse<NSXTEdgeClusterListResultType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTEdgeClusterListResultType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Get operation to " + ListEdgeClustersServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTEdgeClusterType> ReplaceEdgeClusterMemberTransportNode(string EdgeClusterId, NSXTEdgeClusterMemberTransportNodeType EdgeClusterMemberTransportNode)
        {
            if (EdgeClusterId == null) { throw new System.ArgumentNullException("EdgeClusterId cannot be null"); }
            if (EdgeClusterMemberTransportNode == null) { throw new System.ArgumentNullException("EdgeClusterMemberTransportNode cannot be null"); }
            StringBuilder ReplaceEdgeClusterMemberTransportNodeServiceURL = new StringBuilder("/edge-clusters/{edge-cluster-id}?action=replace_transport_node");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Post
            };
            ReplaceEdgeClusterMemberTransportNodeServiceURL.Replace("{edge-cluster-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(EdgeClusterId, System.Globalization.CultureInfo.InvariantCulture)));
            request.AddJsonBody(EdgeClusterMemberTransportNode);
            request.Resource = ReplaceEdgeClusterMemberTransportNodeServiceURL.ToString();
            RestResponse<NSXTEdgeClusterType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTEdgeClusterType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Post operation to " + ReplaceEdgeClusterMemberTransportNodeServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTEdgeClusterStateType> GetEdgeClusterState(string EdgeClusterId, long? BarrierId = null, string? RequestId = null)
        {
            if (EdgeClusterId == null) { throw new System.ArgumentNullException("EdgeClusterId cannot be null"); }
            StringBuilder GetEdgeClusterStateServiceURL = new StringBuilder("/edge-clusters/{edge-cluster-id}/state");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Get
            };
            GetEdgeClusterStateServiceURL.Replace("{edge-cluster-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(EdgeClusterId, System.Globalization.CultureInfo.InvariantCulture)));
            if (BarrierId != null) { request.AddQueryParameter("barrier_id", BarrierId.ToString()); }
            if (RequestId != null) { request.AddQueryParameter("request_id", RequestId.ToString()); }
            request.Resource = GetEdgeClusterStateServiceURL.ToString();
            RestResponse<NSXTEdgeClusterStateType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTEdgeClusterStateType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Get operation to " + GetEdgeClusterStateServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTEdgeClusterAllocationStatusType> GetEdgeClusterAllocationStatus(string EdgeClusterId)
        {
            if (EdgeClusterId == null) { throw new System.ArgumentNullException("EdgeClusterId cannot be null"); }
            StringBuilder GetEdgeClusterAllocationStatusServiceURL = new StringBuilder("/edge-clusters/{edge-cluster-id}/allocation-status");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Get
            };
            GetEdgeClusterAllocationStatusServiceURL.Replace("{edge-cluster-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(EdgeClusterId, System.Globalization.CultureInfo.InvariantCulture)));
            request.Resource = GetEdgeClusterAllocationStatusServiceURL.ToString();
            RestResponse<NSXTEdgeClusterAllocationStatusType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTEdgeClusterAllocationStatusType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Get operation to " + GetEdgeClusterAllocationStatusServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
    }
}
