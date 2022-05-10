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
    public class ClusterVirtualIp
    {
        private RestClient restClient;
        private int retry;
        private int timeout;
        private CancellationToken cancellationToken;

        public ClusterVirtualIp(RestClient Client, CancellationToken _cancellationToken, int _timeout, int _retry)
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
        public async Task<NSXTClusterVirtualIpPropertiesType> GetClusterVirtualIp()
        {
            StringBuilder GetClusterVirtualIpServiceURL = new StringBuilder("/cluster/api-virtual-ip");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Get
            };
            request.Resource = GetClusterVirtualIpServiceURL.ToString();
            RestResponse<NSXTClusterVirtualIpPropertiesType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTClusterVirtualIpPropertiesType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Get operation to " + GetClusterVirtualIpServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTClusterVirtualIpPropertiesType> ClearClusterVirtualIpClearVirtualIp()
        {
            StringBuilder ClearClusterVirtualIpClearVirtualIpServiceURL = new StringBuilder("/cluster/api-virtual-ip?action=clear_virtual_ip");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Post
            };
            request.Resource = ClearClusterVirtualIpClearVirtualIpServiceURL.ToString();
            RestResponse<NSXTClusterVirtualIpPropertiesType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTClusterVirtualIpPropertiesType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Post operation to " + ClearClusterVirtualIpClearVirtualIpServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTClusterVirtualIpPropertiesType> SetClusterVirtualIpSetVirtualIp(string IpAddress)
        {
            if (IpAddress == null) { throw new System.ArgumentNullException("IpAddress cannot be null"); }
            StringBuilder SetClusterVirtualIpSetVirtualIpServiceURL = new StringBuilder("/cluster/api-virtual-ip?action=set_virtual_ip");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Post
            };
            if (IpAddress != null) { request.AddQueryParameter("ip_address", IpAddress.ToString()); }
            request.Resource = SetClusterVirtualIpSetVirtualIpServiceURL.ToString();
            RestResponse<NSXTClusterVirtualIpPropertiesType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTClusterVirtualIpPropertiesType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Post operation to " + SetClusterVirtualIpSetVirtualIpServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
    }
}
