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
    public class PolicyALBControllerDeployment
    {
        private RestClient restClient;
        private int retry;
        private int timeout;
        private CancellationToken cancellationToken;

        public PolicyALBControllerDeployment(RestClient Client, CancellationToken _cancellationToken, int _timeout, int _retry)
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
        public async Task<NSXTALBControllerNodeVMClusterConfigType> AddAlbcontrollerNodeClusterConfig(NSXTALBControllerNodeVMClusterConfigType AlbcontrollerNodeVmclusterConfig)
        {
            if (AlbcontrollerNodeVmclusterConfig == null) { throw new System.ArgumentNullException("AlbcontrollerNodeVmclusterConfig cannot be null"); }
            StringBuilder AddAlbcontrollerNodeClusterConfigServiceURL = new StringBuilder("/alb/controller-nodes/clusterconfig");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Post
            };
            request.AddJsonBody(AlbcontrollerNodeVmclusterConfig);
            request.Resource = AddAlbcontrollerNodeClusterConfigServiceURL.ToString();
            RestResponse<NSXTALBControllerNodeVMClusterConfigType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTALBControllerNodeVMClusterConfigType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Post operation to " + AddAlbcontrollerNodeClusterConfigServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTALBControllerNodeVMClusterConfigType> ReadAlbcontrollerNodeClusterConfig()
        {
            StringBuilder ReadAlbcontrollerNodeClusterConfigServiceURL = new StringBuilder("/alb/controller-nodes/clusterconfig");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Get
            };
            request.Resource = ReadAlbcontrollerNodeClusterConfigServiceURL.ToString();
            RestResponse<NSXTALBControllerNodeVMClusterConfigType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTALBControllerNodeVMClusterConfigType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Get operation to " + ReadAlbcontrollerNodeClusterConfigServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTALBControllerNodeFormFactorsType> ListAlbcontrollerFormFactors()
        {
            StringBuilder ListAlbcontrollerFormFactorsServiceURL = new StringBuilder("/alb/controller-nodes/form-factors");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Get
            };
            request.Resource = ListAlbcontrollerFormFactorsServiceURL.ToString();
            RestResponse<NSXTALBControllerNodeFormFactorsType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTALBControllerNodeFormFactorsType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Get operation to " + ListAlbcontrollerFormFactorsServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTALBControllerNodeVMDeploymentRequestListType> AddAlbcontrollerNodeVM(NSXTAddALBControllerNodeVMInfoType AddAlbcontrollerNodeVminfo)
        {
            if (AddAlbcontrollerNodeVminfo == null) { throw new System.ArgumentNullException("AddAlbcontrollerNodeVminfo cannot be null"); }
            StringBuilder AddAlbcontrollerNodeVMServiceURL = new StringBuilder("/alb/controller-nodes/deployments");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Post
            };
            request.AddJsonBody(AddAlbcontrollerNodeVminfo);
            request.Resource = AddAlbcontrollerNodeVMServiceURL.ToString();
            RestResponse<NSXTALBControllerNodeVMDeploymentRequestListType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTALBControllerNodeVMDeploymentRequestListType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Post operation to " + AddAlbcontrollerNodeVMServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTALBControllerNodeVMDeploymentRequestListType> ListAlbcontrollerNodeVmdeploymentRequests(string? State = null)
        {
            StringBuilder ListAlbcontrollerNodeVmdeploymentRequestsServiceURL = new StringBuilder("/alb/controller-nodes/deployments");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Get
            };
            if (State != null) { request.AddQueryParameter("state", State.ToString()); }
            request.Resource = ListAlbcontrollerNodeVmdeploymentRequestsServiceURL.ToString();
            RestResponse<NSXTALBControllerNodeVMDeploymentRequestListType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTALBControllerNodeVMDeploymentRequestListType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Get operation to " + ListAlbcontrollerNodeVmdeploymentRequestsServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTALBControllerClusterTriggerType> RetriggerClustering()
        {
            StringBuilder RetriggerClusteringServiceURL = new StringBuilder("/alb/controller-nodes/cluster");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Put
            };
            request.Resource = RetriggerClusteringServiceURL.ToString();
            RestResponse<NSXTALBControllerClusterTriggerType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTALBControllerClusterTriggerType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Put operation to " + RetriggerClusteringServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTALBControllerClusterInfoType> ListAlbcontrollerClusterInfo()
        {
            StringBuilder ListAlbcontrollerClusterInfoServiceURL = new StringBuilder("/alb/controller-nodes/cluster");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Get
            };
            request.Resource = ListAlbcontrollerClusterInfoServiceURL.ToString();
            RestResponse<NSXTALBControllerClusterInfoType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTALBControllerClusterInfoType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Get operation to " + ListAlbcontrollerClusterInfoServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTALBControllerNodeVMDeploymentRequestType> UpdateAlbcontrollerNodeVmdeploymentRequest(string NodeId, NSXTALBControllerNodeVMDeploymentRequestType AlbcontrollerNodeVmdeploymentRequest, bool? RunningConfig = null)
        {
            if (NodeId == null) { throw new System.ArgumentNullException("NodeId cannot be null"); }
            if (AlbcontrollerNodeVmdeploymentRequest == null) { throw new System.ArgumentNullException("AlbcontrollerNodeVmdeploymentRequest cannot be null"); }
            StringBuilder UpdateAlbcontrollerNodeVmdeploymentRequestServiceURL = new StringBuilder("/alb/controller-nodes/deployments/{node-id}");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Put
            };
            UpdateAlbcontrollerNodeVmdeploymentRequestServiceURL.Replace("{node-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(NodeId, System.Globalization.CultureInfo.InvariantCulture)));
            request.AddJsonBody(AlbcontrollerNodeVmdeploymentRequest);
            if (RunningConfig != null) { request.AddQueryParameter("running_config", RunningConfig.ToString()); }
            request.Resource = UpdateAlbcontrollerNodeVmdeploymentRequestServiceURL.ToString();
            RestResponse<NSXTALBControllerNodeVMDeploymentRequestType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTALBControllerNodeVMDeploymentRequestType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Put operation to " + UpdateAlbcontrollerNodeVmdeploymentRequestServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTALBControllerNodeVMDeploymentRequestType> ReadAlbcontrollerNodeVmdeploymentRequest(string NodeId)
        {
            if (NodeId == null) { throw new System.ArgumentNullException("NodeId cannot be null"); }
            StringBuilder ReadAlbcontrollerNodeVmdeploymentRequestServiceURL = new StringBuilder("/alb/controller-nodes/deployments/{node-id}");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Get
            };
            ReadAlbcontrollerNodeVmdeploymentRequestServiceURL.Replace("{node-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(NodeId, System.Globalization.CultureInfo.InvariantCulture)));
            request.Resource = ReadAlbcontrollerNodeVmdeploymentRequestServiceURL.ToString();
            RestResponse<NSXTALBControllerNodeVMDeploymentRequestType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTALBControllerNodeVMDeploymentRequestType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Get operation to " + ReadAlbcontrollerNodeVmdeploymentRequestServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTALBControllerNodeVMDeploymentStatusReportType> ReadAlbcontrollerNodeVmdeploymentStatus(string NodeId)
        {
            if (NodeId == null) { throw new System.ArgumentNullException("NodeId cannot be null"); }
            StringBuilder ReadAlbcontrollerNodeVmdeploymentStatusServiceURL = new StringBuilder("/alb/controller-nodes/deployments/{node-id}/status");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Get
            };
            ReadAlbcontrollerNodeVmdeploymentStatusServiceURL.Replace("{node-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(NodeId, System.Globalization.CultureInfo.InvariantCulture)));
            request.Resource = ReadAlbcontrollerNodeVmdeploymentStatusServiceURL.ToString();
            RestResponse<NSXTALBControllerNodeVMDeploymentStatusReportType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTALBControllerNodeVMDeploymentStatusReportType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Get operation to " + ReadAlbcontrollerNodeVmdeploymentStatusServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task DeleteAutoDeployedAlbcontrollerNodeVM(string NodeId, bool? ForceDelete = null, string? Inaccessible = null)
        {
            if (NodeId == null) { throw new System.ArgumentNullException("NodeId cannot be null"); }
            StringBuilder DeleteAutoDeployedAlbcontrollerNodeVMServiceURL = new StringBuilder("/alb/controller-nodes/deployments/{node-id}?action=delete");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Post
            };
            DeleteAutoDeployedAlbcontrollerNodeVMServiceURL.Replace("{node-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(NodeId, System.Globalization.CultureInfo.InvariantCulture)));
            if (ForceDelete != null) { request.AddQueryParameter("force_delete", ForceDelete.ToString()); }
            if (Inaccessible != null) { request.AddQueryParameter("inaccessible", Inaccessible.ToString()); }
            request.Resource = DeleteAutoDeployedAlbcontrollerNodeVMServiceURL.ToString();
            RestResponse response = await restClient.ExecuteTaskAsyncWithPolicy(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Post operation to " + DeleteAutoDeployedAlbcontrollerNodeVMServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            
        }
    }
}
