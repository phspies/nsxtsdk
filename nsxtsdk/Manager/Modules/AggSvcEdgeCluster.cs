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
    public class AggSvcEdgeCluster
    {
        private RestClient restClient;
        private int retry;
        private int timeout;
        private CancellationToken cancellationToken;

        public AggSvcEdgeCluster(RestClient Client, CancellationToken _cancellationToken, int _timeout, int _retry)
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
        public async Task<NSXTEdgeClusterStatusType> GetEdgeClusterStatus(string EdgeClusterId, string? Source = null)
        {
            if (EdgeClusterId == null) { throw new System.ArgumentNullException("EdgeClusterId cannot be null"); }
            StringBuilder GetEdgeClusterStatusServiceURL = new StringBuilder("/edge-clusters/{edge-cluster-id}/status");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Get
            };
            GetEdgeClusterStatusServiceURL.Replace("{edge-cluster-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(EdgeClusterId, System.Globalization.CultureInfo.InvariantCulture)));
            if (Source != null) { request.AddQueryParameter("source", Source.ToString()); }
            request.Resource = GetEdgeClusterStatusServiceURL.ToString();
            RestResponse<NSXTEdgeClusterStatusType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTEdgeClusterStatusType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Get operation to " + GetEdgeClusterStatusServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTEdgeClusterInterSiteStatusType> GetEdgeClusterInterSiteStatus(string EdgeClusterId)
        {
            if (EdgeClusterId == null) { throw new System.ArgumentNullException("EdgeClusterId cannot be null"); }
            StringBuilder GetEdgeClusterInterSiteStatusServiceURL = new StringBuilder("/edge-clusters/{edge-cluster-id}/inter-site/status");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Get
            };
            GetEdgeClusterInterSiteStatusServiceURL.Replace("{edge-cluster-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(EdgeClusterId, System.Globalization.CultureInfo.InvariantCulture)));
            request.Resource = GetEdgeClusterInterSiteStatusServiceURL.ToString();
            RestResponse<NSXTEdgeClusterInterSiteStatusType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTEdgeClusterInterSiteStatusType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Get operation to " + GetEdgeClusterInterSiteStatusServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
    }
}
