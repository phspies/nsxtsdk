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
    public class TnContainerStatus
    {
        private RestClient restClient;
        private int retry;
        private int timeout;
        private CancellationToken cancellationToken;

        public TnContainerStatus(RestClient Client, CancellationToken _cancellationToken, int _timeout, int _retry)
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
        public async Task<NSXTContainerClusterSummaryType> ReadContainerClusterStatus(string ClusterId)
        {
            if (ClusterId == null) { throw new System.ArgumentNullException("ClusterId cannot be null"); }
            StringBuilder ReadContainerClusterStatusServiceURL = new StringBuilder("/systemhealth/container-cluster/{cluster-id}/ncp/status");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Get
            };
            ReadContainerClusterStatusServiceURL.Replace("{cluster-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(ClusterId, System.Globalization.CultureInfo.InvariantCulture)));
            request.Resource = ReadContainerClusterStatusServiceURL.ToString();
            RestResponse<NSXTContainerClusterSummaryType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTContainerClusterSummaryType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Get operation to " + ReadContainerClusterStatusServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task DeleteContainerClusterSummary(string ClusterId)
        {
            if (ClusterId == null) { throw new System.ArgumentNullException("ClusterId cannot be null"); }
            StringBuilder DeleteContainerClusterSummaryServiceURL = new StringBuilder("/systemhealth/container-cluster/{cluster-id}/ncp/status");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Delete
            };
            DeleteContainerClusterSummaryServiceURL.Replace("{cluster-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(ClusterId, System.Globalization.CultureInfo.InvariantCulture)));
            request.Resource = DeleteContainerClusterSummaryServiceURL.ToString();
            RestResponse response = await restClient.ExecuteTaskAsyncWithPolicy(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Delete operation to " + DeleteContainerClusterSummaryServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTTnHyperbusStatusType> ReadTnHyperbusStatus(string NodeId)
        {
            if (NodeId == null) { throw new System.ArgumentNullException("NodeId cannot be null"); }
            StringBuilder ReadTnHyperbusStatusServiceURL = new StringBuilder("/systemhealth/transport-nodes/{node-id}/container/hyperbus/status");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Get
            };
            ReadTnHyperbusStatusServiceURL.Replace("{node-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(NodeId, System.Globalization.CultureInfo.InvariantCulture)));
            request.Resource = ReadTnHyperbusStatusServiceURL.ToString();
            RestResponse<NSXTTnHyperbusStatusType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTTnHyperbusStatusType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Get operation to " + ReadTnHyperbusStatusServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTTnNodeAgentStatusListResultType> ReadTnContainerAgentStatus(string NodeId, string? Cursor = null, string? IncludedFields = null, long? PageSize = null, bool? SortAscending = null, string? SortBy = null)
        {
            if (NodeId == null) { throw new System.ArgumentNullException("NodeId cannot be null"); }
            StringBuilder ReadTnContainerAgentStatusServiceURL = new StringBuilder("/systemhealth/transport-nodes/{node-id}/container/agent/status");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Get
            };
            ReadTnContainerAgentStatusServiceURL.Replace("{node-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(NodeId, System.Globalization.CultureInfo.InvariantCulture)));
            if (Cursor != null) { request.AddQueryParameter("cursor", Cursor.ToString()); }
            if (IncludedFields != null) { request.AddQueryParameter("included_fields", IncludedFields.ToString()); }
            if (PageSize != null) { request.AddQueryParameter("page_size", PageSize.ToString()); }
            if (SortAscending != null) { request.AddQueryParameter("sort_ascending", SortAscending.ToString()); }
            if (SortBy != null) { request.AddQueryParameter("sort_by", SortBy.ToString()); }
            request.Resource = ReadTnContainerAgentStatusServiceURL.ToString();
            RestResponse<NSXTTnNodeAgentStatusListResultType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTTnNodeAgentStatusListResultType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Get operation to " + ReadTnContainerAgentStatusServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTContainerClusterStatusType> CreateContainerClusterStatus(NSXTContainerClusterStatusType ContainerClusterStatus)
        {
            if (ContainerClusterStatus == null) { throw new System.ArgumentNullException("ContainerClusterStatus cannot be null"); }
            StringBuilder CreateContainerClusterStatusServiceURL = new StringBuilder("/systemhealth/container-cluster/ncp/status");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Post
            };
            request.AddJsonBody(ContainerClusterStatus);
            request.Resource = CreateContainerClusterStatusServiceURL.ToString();
            RestResponse<NSXTContainerClusterStatusType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTContainerClusterStatusType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Post operation to " + CreateContainerClusterStatusServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTContainerClusterStatusListType> ReadContainerClusterStatusList(string? Cursor = null, string? IncludedFields = null, long? PageSize = null, bool? SortAscending = null, string? SortBy = null, string? Status = null)
        {
            StringBuilder ReadContainerClusterStatusListServiceURL = new StringBuilder("/systemhealth/container-cluster/ncp/status");
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
            if (Status != null) { request.AddQueryParameter("status", Status.ToString()); }
            request.Resource = ReadContainerClusterStatusListServiceURL.ToString();
            RestResponse<NSXTContainerClusterStatusListType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTContainerClusterStatusListType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Get operation to " + ReadContainerClusterStatusListServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
    }
}
