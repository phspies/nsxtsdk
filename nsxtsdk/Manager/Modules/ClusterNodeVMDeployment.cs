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
    public class ClusterNodeVMDeployment
    {
        private RestClient restClient;
        private int retry;
        private int timeout;
        private CancellationToken cancellationToken;

        public ClusterNodeVMDeployment(RestClient Client, CancellationToken _cancellationToken, int _timeout, int _retry)
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
        public async Task<NSXTClusterNodeVMDeploymentStatusReportType> ReadClusterNodeVmdeploymentStatus(string NodeId)
        {
            if (NodeId == null) { throw new System.ArgumentNullException("NodeId cannot be null"); }
            StringBuilder ReadClusterNodeVmdeploymentStatusServiceURL = new StringBuilder("/cluster/nodes/deployments/{node-id}/status");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Get
            };
            ReadClusterNodeVmdeploymentStatusServiceURL.Replace("{node-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(NodeId, System.Globalization.CultureInfo.InvariantCulture)));
            request.Resource = ReadClusterNodeVmdeploymentStatusServiceURL.ToString();
            RestResponse<NSXTClusterNodeVMDeploymentStatusReportType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTClusterNodeVMDeploymentStatusReportType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Get operation to " + ReadClusterNodeVmdeploymentStatusServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task PerformRepoSync()
        {
            StringBuilder PerformRepoSyncServiceURL = new StringBuilder("/cluster/node?action=repo_sync");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Post
            };
            request.Resource = PerformRepoSyncServiceURL.ToString();
            RestResponse response = await restClient.ExecuteTaskAsyncWithPolicy(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Post operation to " + PerformRepoSyncServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task DeleteAutoDeployedClusterNodeVM(string NodeId, bool? ForceDelete = null)
        {
            if (NodeId == null) { throw new System.ArgumentNullException("NodeId cannot be null"); }
            StringBuilder DeleteAutoDeployedClusterNodeVMServiceURL = new StringBuilder("/cluster/nodes/deployments/{node-id}?action=delete");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Post
            };
            DeleteAutoDeployedClusterNodeVMServiceURL.Replace("{node-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(NodeId, System.Globalization.CultureInfo.InvariantCulture)));
            if (ForceDelete != null) { request.AddQueryParameter("force_delete", ForceDelete.ToString()); }
            request.Resource = DeleteAutoDeployedClusterNodeVMServiceURL.ToString();
            RestResponse response = await restClient.ExecuteTaskAsyncWithPolicy(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Post operation to " + DeleteAutoDeployedClusterNodeVMServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTRepoSyncStatusReportType> GetRepoSyncStatus(string NodeId)
        {
            if (NodeId == null) { throw new System.ArgumentNullException("NodeId cannot be null"); }
            StringBuilder GetRepoSyncStatusServiceURL = new StringBuilder("/cluster/nodes/{node-id}/repo_sync/status");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Get
            };
            GetRepoSyncStatusServiceURL.Replace("{node-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(NodeId, System.Globalization.CultureInfo.InvariantCulture)));
            request.Resource = GetRepoSyncStatusServiceURL.ToString();
            RestResponse<NSXTRepoSyncStatusReportType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTRepoSyncStatusReportType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Get operation to " + GetRepoSyncStatusServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTClusterNodeVMDeploymentRequestListType> AddClusterNodeVM(NSXTAddClusterNodeVMInfoType AddClusterNodeVminfo)
        {
            if (AddClusterNodeVminfo == null) { throw new System.ArgumentNullException("AddClusterNodeVminfo cannot be null"); }
            StringBuilder AddClusterNodeVMServiceURL = new StringBuilder("/cluster/nodes/deployments");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Post
            };
            request.AddJsonBody(AddClusterNodeVminfo);
            request.Resource = AddClusterNodeVMServiceURL.ToString();
            RestResponse<NSXTClusterNodeVMDeploymentRequestListType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTClusterNodeVMDeploymentRequestListType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Post operation to " + AddClusterNodeVMServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTClusterNodeVMDeploymentRequestListType> ListClusterNodeVmdeploymentRequests()
        {
            StringBuilder ListClusterNodeVmdeploymentRequestsServiceURL = new StringBuilder("/cluster/nodes/deployments");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Get
            };
            request.Resource = ListClusterNodeVmdeploymentRequestsServiceURL.ToString();
            RestResponse<NSXTClusterNodeVMDeploymentRequestListType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTClusterNodeVMDeploymentRequestListType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Get operation to " + ListClusterNodeVmdeploymentRequestsServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTClusterNodeVMDeploymentRequestType> ReadClusterNodeVmdeploymentRequest(string NodeId)
        {
            if (NodeId == null) { throw new System.ArgumentNullException("NodeId cannot be null"); }
            StringBuilder ReadClusterNodeVmdeploymentRequestServiceURL = new StringBuilder("/cluster/nodes/deployments/{node-id}");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Get
            };
            ReadClusterNodeVmdeploymentRequestServiceURL.Replace("{node-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(NodeId, System.Globalization.CultureInfo.InvariantCulture)));
            request.Resource = ReadClusterNodeVmdeploymentRequestServiceURL.ToString();
            RestResponse<NSXTClusterNodeVMDeploymentRequestType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTClusterNodeVMDeploymentRequestType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Get operation to " + ReadClusterNodeVmdeploymentRequestServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
    }
}
