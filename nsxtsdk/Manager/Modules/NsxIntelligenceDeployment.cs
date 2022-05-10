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
    public class NsxIntelligenceDeployment
    {
        private RestClient restClient;
        private int retry;
        private int timeout;
        private CancellationToken cancellationToken;

        public NsxIntelligenceDeployment(RestClient Client, CancellationToken _cancellationToken, int _timeout, int _retry)
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
        public async Task<NSXTIntelligenceClusterNodeVMDeploymentRequestListType> AddPaceClusterNodeVM(NSXTAddIntelligenceClusterNodeVMInfoType AddIntelligenceClusterNodeVminfo)
        {
            if (AddIntelligenceClusterNodeVminfo == null) { throw new System.ArgumentNullException("AddIntelligenceClusterNodeVminfo cannot be null"); }
            StringBuilder AddPaceClusterNodeVMServiceURL = new StringBuilder("/intelligence/nodes/deployments");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Post
            };
            request.AddJsonBody(AddIntelligenceClusterNodeVminfo);
            request.Resource = AddPaceClusterNodeVMServiceURL.ToString();
            RestResponse<NSXTIntelligenceClusterNodeVMDeploymentRequestListType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTIntelligenceClusterNodeVMDeploymentRequestListType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Post operation to " + AddPaceClusterNodeVMServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTIntelligenceClusterNodeVMDeploymentRequestListType> ListPaceClusterNodeVmdeploymentRequests()
        {
            StringBuilder ListPaceClusterNodeVmdeploymentRequestsServiceURL = new StringBuilder("/intelligence/nodes/deployments");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Get
            };
            request.Resource = ListPaceClusterNodeVmdeploymentRequestsServiceURL.ToString();
            RestResponse<NSXTIntelligenceClusterNodeVMDeploymentRequestListType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTIntelligenceClusterNodeVMDeploymentRequestListType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Get operation to " + ListPaceClusterNodeVmdeploymentRequestsServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTIntelligenceClusterNodeVMDeploymentStatusReportType> ReadPaceClusterNodeVmdeploymentStatus(string NodeId)
        {
            if (NodeId == null) { throw new System.ArgumentNullException("NodeId cannot be null"); }
            StringBuilder ReadPaceClusterNodeVmdeploymentStatusServiceURL = new StringBuilder("/intelligence/nodes/deployments/{node-id}/status");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Get
            };
            ReadPaceClusterNodeVmdeploymentStatusServiceURL.Replace("{node-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(NodeId, System.Globalization.CultureInfo.InvariantCulture)));
            request.Resource = ReadPaceClusterNodeVmdeploymentStatusServiceURL.ToString();
            RestResponse<NSXTIntelligenceClusterNodeVMDeploymentStatusReportType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTIntelligenceClusterNodeVMDeploymentStatusReportType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Get operation to " + ReadPaceClusterNodeVmdeploymentStatusServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task DeleteAutoDeployedPaceClusterNodeVM(string NodeId, bool? ForceDelete = null)
        {
            if (NodeId == null) { throw new System.ArgumentNullException("NodeId cannot be null"); }
            StringBuilder DeleteAutoDeployedPaceClusterNodeVMServiceURL = new StringBuilder("/intelligence/nodes/deployments/{node-id}?action=delete");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Post
            };
            DeleteAutoDeployedPaceClusterNodeVMServiceURL.Replace("{node-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(NodeId, System.Globalization.CultureInfo.InvariantCulture)));
            if (ForceDelete != null) { request.AddQueryParameter("force_delete", ForceDelete.ToString()); }
            request.Resource = DeleteAutoDeployedPaceClusterNodeVMServiceURL.ToString();
            RestResponse response = await restClient.ExecuteTaskAsyncWithPolicy(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Post operation to " + DeleteAutoDeployedPaceClusterNodeVMServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTIntelligenceClusterNodeVMDeploymentRequestType> ReadPaceClusterNodeVmdeploymentRequest(string NodeId)
        {
            if (NodeId == null) { throw new System.ArgumentNullException("NodeId cannot be null"); }
            StringBuilder ReadPaceClusterNodeVmdeploymentRequestServiceURL = new StringBuilder("/intelligence/nodes/deployments/{node-id}");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Get
            };
            ReadPaceClusterNodeVmdeploymentRequestServiceURL.Replace("{node-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(NodeId, System.Globalization.CultureInfo.InvariantCulture)));
            request.Resource = ReadPaceClusterNodeVmdeploymentRequestServiceURL.ToString();
            RestResponse<NSXTIntelligenceClusterNodeVMDeploymentRequestType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTIntelligenceClusterNodeVMDeploymentRequestType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Get operation to " + ReadPaceClusterNodeVmdeploymentRequestServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
    }
}
