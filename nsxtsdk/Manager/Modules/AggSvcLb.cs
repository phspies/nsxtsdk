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
    public class AggSvcLb
    {
        private RestClient restClient;
        private int retry;
        private int timeout;
        private CancellationToken cancellationToken;

        public AggSvcLb(RestClient Client, CancellationToken _cancellationToken, int _timeout, int _retry)
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
        public async Task<NSXTLbVirtualServerStatusListResultType> ListLoadBalancerVirtualServerStatuses(string ServiceId, string? Source = null)
        {
            if (ServiceId == null) { throw new System.ArgumentNullException("ServiceId cannot be null"); }
            StringBuilder ListLoadBalancerVirtualServerStatusesServiceURL = new StringBuilder("/loadbalancer/services/{service-id}/virtual-servers/status");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Get
            };
            ListLoadBalancerVirtualServerStatusesServiceURL.Replace("{service-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(ServiceId, System.Globalization.CultureInfo.InvariantCulture)));
            if (Source != null) { request.AddQueryParameter("source", Source.ToString()); }
            request.Resource = ListLoadBalancerVirtualServerStatusesServiceURL.ToString();
            RestResponse<NSXTLbVirtualServerStatusListResultType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTLbVirtualServerStatusListResultType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Get operation to " + ListLoadBalancerVirtualServerStatusesServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTLbPoolStatisticsListResultType> ListLoadBalancerPoolStatistics(string ServiceId, string? Source = null)
        {
            if (ServiceId == null) { throw new System.ArgumentNullException("ServiceId cannot be null"); }
            StringBuilder ListLoadBalancerPoolStatisticsServiceURL = new StringBuilder("/loadbalancer/services/{service-id}/pools/statistics");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Get
            };
            ListLoadBalancerPoolStatisticsServiceURL.Replace("{service-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(ServiceId, System.Globalization.CultureInfo.InvariantCulture)));
            if (Source != null) { request.AddQueryParameter("source", Source.ToString()); }
            request.Resource = ListLoadBalancerPoolStatisticsServiceURL.ToString();
            RestResponse<NSXTLbPoolStatisticsListResultType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTLbPoolStatisticsListResultType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Get operation to " + ListLoadBalancerPoolStatisticsServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTLbVirtualServerStatusType> GetLoadBalancerVirtualServerStatus(string ServiceId, string VirtualServerId, string? Source = null)
        {
            if (ServiceId == null) { throw new System.ArgumentNullException("ServiceId cannot be null"); }
            if (VirtualServerId == null) { throw new System.ArgumentNullException("VirtualServerId cannot be null"); }
            StringBuilder GetLoadBalancerVirtualServerStatusServiceURL = new StringBuilder("/loadbalancer/services/{service-id}/virtual-servers/{virtual-server-id}/status");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Get
            };
            GetLoadBalancerVirtualServerStatusServiceURL.Replace("{service-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(ServiceId, System.Globalization.CultureInfo.InvariantCulture)));
            GetLoadBalancerVirtualServerStatusServiceURL.Replace("{virtual-server-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(VirtualServerId, System.Globalization.CultureInfo.InvariantCulture)));
            if (Source != null) { request.AddQueryParameter("source", Source.ToString()); }
            request.Resource = GetLoadBalancerVirtualServerStatusServiceURL.ToString();
            RestResponse<NSXTLbVirtualServerStatusType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTLbVirtualServerStatusType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Get operation to " + GetLoadBalancerVirtualServerStatusServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTLbVirtualServerStatisticsType> GetLoadBalancerVirtualServerStatistics(string ServiceId, string VirtualServerId, string? Source = null)
        {
            if (ServiceId == null) { throw new System.ArgumentNullException("ServiceId cannot be null"); }
            if (VirtualServerId == null) { throw new System.ArgumentNullException("VirtualServerId cannot be null"); }
            StringBuilder GetLoadBalancerVirtualServerStatisticsServiceURL = new StringBuilder("/loadbalancer/services/{service-id}/virtual-servers/{virtual-server-id}/statistics");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Get
            };
            GetLoadBalancerVirtualServerStatisticsServiceURL.Replace("{service-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(ServiceId, System.Globalization.CultureInfo.InvariantCulture)));
            GetLoadBalancerVirtualServerStatisticsServiceURL.Replace("{virtual-server-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(VirtualServerId, System.Globalization.CultureInfo.InvariantCulture)));
            if (Source != null) { request.AddQueryParameter("source", Source.ToString()); }
            request.Resource = GetLoadBalancerVirtualServerStatisticsServiceURL.ToString();
            RestResponse<NSXTLbVirtualServerStatisticsType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTLbVirtualServerStatisticsType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Get operation to " + GetLoadBalancerVirtualServerStatisticsServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTLbPoolStatusType> GetLoadBalancerPoolStatus(string ServiceId, string PoolId, string? Source = null)
        {
            if (ServiceId == null) { throw new System.ArgumentNullException("ServiceId cannot be null"); }
            if (PoolId == null) { throw new System.ArgumentNullException("PoolId cannot be null"); }
            StringBuilder GetLoadBalancerPoolStatusServiceURL = new StringBuilder("/loadbalancer/services/{service-id}/pools/{pool-id}/status");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Get
            };
            GetLoadBalancerPoolStatusServiceURL.Replace("{service-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(ServiceId, System.Globalization.CultureInfo.InvariantCulture)));
            GetLoadBalancerPoolStatusServiceURL.Replace("{pool-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(PoolId, System.Globalization.CultureInfo.InvariantCulture)));
            if (Source != null) { request.AddQueryParameter("source", Source.ToString()); }
            request.Resource = GetLoadBalancerPoolStatusServiceURL.ToString();
            RestResponse<NSXTLbPoolStatusType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTLbPoolStatusType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Get operation to " + GetLoadBalancerPoolStatusServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTLbVirtualServerStatisticsListResultType> ListLoadBalancerVirtualServersStatistics(string ServiceId, string? Source = null)
        {
            if (ServiceId == null) { throw new System.ArgumentNullException("ServiceId cannot be null"); }
            StringBuilder ListLoadBalancerVirtualServersStatisticsServiceURL = new StringBuilder("/loadbalancer/services/{service-id}/virtual-servers/statistics");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Get
            };
            ListLoadBalancerVirtualServersStatisticsServiceURL.Replace("{service-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(ServiceId, System.Globalization.CultureInfo.InvariantCulture)));
            if (Source != null) { request.AddQueryParameter("source", Source.ToString()); }
            request.Resource = ListLoadBalancerVirtualServersStatisticsServiceURL.ToString();
            RestResponse<NSXTLbVirtualServerStatisticsListResultType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTLbVirtualServerStatisticsListResultType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Get operation to " + ListLoadBalancerVirtualServersStatisticsServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTLbServiceStatisticsType> GetLoadBalancerServiceStatistics(string ServiceId, string? Source = null)
        {
            if (ServiceId == null) { throw new System.ArgumentNullException("ServiceId cannot be null"); }
            StringBuilder GetLoadBalancerServiceStatisticsServiceURL = new StringBuilder("/loadbalancer/services/{service-id}/statistics");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Get
            };
            GetLoadBalancerServiceStatisticsServiceURL.Replace("{service-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(ServiceId, System.Globalization.CultureInfo.InvariantCulture)));
            if (Source != null) { request.AddQueryParameter("source", Source.ToString()); }
            request.Resource = GetLoadBalancerServiceStatisticsServiceURL.ToString();
            RestResponse<NSXTLbServiceStatisticsType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTLbServiceStatisticsType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Get operation to " + GetLoadBalancerServiceStatisticsServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTLbPoolStatusListResultType> ListLoadBalancerPoolStatuses(string ServiceId, string? Source = null)
        {
            if (ServiceId == null) { throw new System.ArgumentNullException("ServiceId cannot be null"); }
            StringBuilder ListLoadBalancerPoolStatusesServiceURL = new StringBuilder("/loadbalancer/services/{service-id}/pools/status");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Get
            };
            ListLoadBalancerPoolStatusesServiceURL.Replace("{service-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(ServiceId, System.Globalization.CultureInfo.InvariantCulture)));
            if (Source != null) { request.AddQueryParameter("source", Source.ToString()); }
            request.Resource = ListLoadBalancerPoolStatusesServiceURL.ToString();
            RestResponse<NSXTLbPoolStatusListResultType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTLbPoolStatusListResultType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Get operation to " + ListLoadBalancerPoolStatusesServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTLbServiceStatusType> GetLoadBalancerServiceStatus(string ServiceId, bool? IncludeInstanceDetails = null, string? Source = null, string? TransportNodeIds = null)
        {
            if (ServiceId == null) { throw new System.ArgumentNullException("ServiceId cannot be null"); }
            StringBuilder GetLoadBalancerServiceStatusServiceURL = new StringBuilder("/loadbalancer/services/{service-id}/status");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Get
            };
            GetLoadBalancerServiceStatusServiceURL.Replace("{service-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(ServiceId, System.Globalization.CultureInfo.InvariantCulture)));
            if (IncludeInstanceDetails != null) { request.AddQueryParameter("include_instance_details", IncludeInstanceDetails.ToString()); }
            if (Source != null) { request.AddQueryParameter("source", Source.ToString()); }
            if (TransportNodeIds != null) { request.AddQueryParameter("transport_node_ids", TransportNodeIds.ToString()); }
            request.Resource = GetLoadBalancerServiceStatusServiceURL.ToString();
            RestResponse<NSXTLbServiceStatusType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTLbServiceStatusType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Get operation to " + GetLoadBalancerServiceStatusServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTLbPoolStatisticsType> GetLoadBalancerPoolStatistics(string ServiceId, string PoolId, string? Source = null)
        {
            if (ServiceId == null) { throw new System.ArgumentNullException("ServiceId cannot be null"); }
            if (PoolId == null) { throw new System.ArgumentNullException("PoolId cannot be null"); }
            StringBuilder GetLoadBalancerPoolStatisticsServiceURL = new StringBuilder("/loadbalancer/services/{service-id}/pools/{pool-id}/statistics");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Get
            };
            GetLoadBalancerPoolStatisticsServiceURL.Replace("{service-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(ServiceId, System.Globalization.CultureInfo.InvariantCulture)));
            GetLoadBalancerPoolStatisticsServiceURL.Replace("{pool-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(PoolId, System.Globalization.CultureInfo.InvariantCulture)));
            if (Source != null) { request.AddQueryParameter("source", Source.ToString()); }
            request.Resource = GetLoadBalancerPoolStatisticsServiceURL.ToString();
            RestResponse<NSXTLbPoolStatisticsType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTLbPoolStatisticsType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Get operation to " + GetLoadBalancerPoolStatisticsServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
    }
}
