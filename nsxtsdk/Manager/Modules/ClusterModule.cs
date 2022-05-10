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
    public class ClusterModule
    {
        private RestClient restClient;
        private int retry;
        private int timeout;
        private CancellationToken cancellationToken;

        public ClusterModule(RestClient Client, CancellationToken _cancellationToken, int _timeout, int _retry)
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
        public async Task<NSXTClusterConfigurationType> DetachClusterNodeRemoveNode(string NodeId, string? Force = null, string? GracefulShutdown = null, string? IgnoreRepositoryIpCheck = null)
        {
            if (NodeId == null) { throw new System.ArgumentNullException("NodeId cannot be null"); }
            StringBuilder DetachClusterNodeRemoveNodeServiceURL = new StringBuilder("/cluster/{node-id}?action=remove_node");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Post
            };
            DetachClusterNodeRemoveNodeServiceURL.Replace("{node-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(NodeId, System.Globalization.CultureInfo.InvariantCulture)));
            if (Force != null) { request.AddQueryParameter("force", Force.ToString()); }
            if (GracefulShutdown != null) { request.AddQueryParameter("graceful-shutdown", GracefulShutdown.ToString()); }
            if (IgnoreRepositoryIpCheck != null) { request.AddQueryParameter("ignore-repository-ip-check", IgnoreRepositoryIpCheck.ToString()); }
            request.Resource = DetachClusterNodeRemoveNodeServiceURL.ToString();
            RestResponse<NSXTClusterConfigurationType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTClusterConfigurationType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Post operation to " + DetachClusterNodeRemoveNodeServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTClusterConfigurationType> JoinClusterJoinCluster(NSXTJoinClusterParametersType JoinClusterParameters)
        {
            if (JoinClusterParameters == null) { throw new System.ArgumentNullException("JoinClusterParameters cannot be null"); }
            StringBuilder JoinClusterJoinClusterServiceURL = new StringBuilder("/cluster?action=join_cluster");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Post
            };
            request.AddJsonBody(JoinClusterParameters);
            request.Resource = JoinClusterJoinClusterServiceURL.ToString();
            RestResponse<NSXTClusterConfigurationType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTClusterConfigurationType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Post operation to " + JoinClusterJoinClusterServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
    }
}
