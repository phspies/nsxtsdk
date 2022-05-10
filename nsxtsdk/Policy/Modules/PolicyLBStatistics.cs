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
    public class PolicyLBStatistics
    {
        private RestClient restClient;
        private int retry;
        private int timeout;
        private CancellationToken cancellationToken;

        public PolicyLBStatistics(RestClient Client, CancellationToken _cancellationToken, int _timeout, int _retry)
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
        public async Task<NSXTAggregateLBServiceStatusType> GetLbserviceStatus(string LbServiceId, string? EnforcementPointPath = null, bool? IncludeInstanceDetails = null, string? Source = null, string? TransportNodeIds = null)
        {
            if (LbServiceId == null) { throw new System.ArgumentNullException("LbServiceId cannot be null"); }
            StringBuilder GetLbserviceStatusServiceURL = new StringBuilder("/infra/lb-services/{lb-service-id}/detailed-status");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Get
            };
            GetLbserviceStatusServiceURL.Replace("{lb-service-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(LbServiceId, System.Globalization.CultureInfo.InvariantCulture)));
            if (EnforcementPointPath != null) { request.AddQueryParameter("enforcement_point_path", EnforcementPointPath.ToString()); }
            if (IncludeInstanceDetails != null) { request.AddQueryParameter("include_instance_details", IncludeInstanceDetails.ToString()); }
            if (Source != null) { request.AddQueryParameter("source", Source.ToString()); }
            if (TransportNodeIds != null) { request.AddQueryParameter("transport_node_ids", TransportNodeIds.ToString()); }
            request.Resource = GetLbserviceStatusServiceURL.ToString();
            RestResponse<NSXTAggregateLBServiceStatusType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTAggregateLBServiceStatusType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Get operation to " + GetLbserviceStatusServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTLBNodeUsageType> GetLbnodeUsage(string NodePath)
        {
            if (NodePath == null) { throw new System.ArgumentNullException("NodePath cannot be null"); }
            StringBuilder GetLbnodeUsageServiceURL = new StringBuilder("/infra/lb-node-usage");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Get
            };
            if (NodePath != null) { request.AddQueryParameter("node_path", NodePath.ToString()); }
            request.Resource = GetLbnodeUsageServiceURL.ToString();
            RestResponse<NSXTLBNodeUsageType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTLBNodeUsageType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Get operation to " + GetLbnodeUsageServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTAggregateLBPoolStatusType> GetLbpoolStatus(string LbServiceId, string LbPoolId, string? EnforcementPointPath = null, string? Source = null)
        {
            if (LbServiceId == null) { throw new System.ArgumentNullException("LbServiceId cannot be null"); }
            if (LbPoolId == null) { throw new System.ArgumentNullException("LbPoolId cannot be null"); }
            StringBuilder GetLbpoolStatusServiceURL = new StringBuilder("/infra/lb-services/{lb-service-id}/lb-pools/{lb-pool-id}/detailed-status");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Get
            };
            GetLbpoolStatusServiceURL.Replace("{lb-service-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(LbServiceId, System.Globalization.CultureInfo.InvariantCulture)));
            GetLbpoolStatusServiceURL.Replace("{lb-pool-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(LbPoolId, System.Globalization.CultureInfo.InvariantCulture)));
            if (EnforcementPointPath != null) { request.AddQueryParameter("enforcement_point_path", EnforcementPointPath.ToString()); }
            if (Source != null) { request.AddQueryParameter("source", Source.ToString()); }
            request.Resource = GetLbpoolStatusServiceURL.ToString();
            RestResponse<NSXTAggregateLBPoolStatusType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTAggregateLBPoolStatusType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Get operation to " + GetLbpoolStatusServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTAggregateLBServiceStatisticsType> GetLbserviceStatistics(string LbServiceId, string? EnforcementPointPath = null, string? Source = null)
        {
            if (LbServiceId == null) { throw new System.ArgumentNullException("LbServiceId cannot be null"); }
            StringBuilder GetLbserviceStatisticsServiceURL = new StringBuilder("/infra/lb-services/{lb-service-id}/statistics");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Get
            };
            GetLbserviceStatisticsServiceURL.Replace("{lb-service-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(LbServiceId, System.Globalization.CultureInfo.InvariantCulture)));
            if (EnforcementPointPath != null) { request.AddQueryParameter("enforcement_point_path", EnforcementPointPath.ToString()); }
            if (Source != null) { request.AddQueryParameter("source", Source.ToString()); }
            request.Resource = GetLbserviceStatisticsServiceURL.ToString();
            RestResponse<NSXTAggregateLBServiceStatisticsType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTAggregateLBServiceStatisticsType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Get operation to " + GetLbserviceStatisticsServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTAggregateLBVirtualServerStatisticsType> GetLbvirtualServerStatistics(string LbServiceId, string LbVirtualServerId, string? EnforcementPointPath = null, string? Source = null)
        {
            if (LbServiceId == null) { throw new System.ArgumentNullException("LbServiceId cannot be null"); }
            if (LbVirtualServerId == null) { throw new System.ArgumentNullException("LbVirtualServerId cannot be null"); }
            StringBuilder GetLbvirtualServerStatisticsServiceURL = new StringBuilder("/infra/lb-services/{lb-service-id}/lb-virtual-servers/{lb-virtual-server-id}/statistics");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Get
            };
            GetLbvirtualServerStatisticsServiceURL.Replace("{lb-service-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(LbServiceId, System.Globalization.CultureInfo.InvariantCulture)));
            GetLbvirtualServerStatisticsServiceURL.Replace("{lb-virtual-server-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(LbVirtualServerId, System.Globalization.CultureInfo.InvariantCulture)));
            if (EnforcementPointPath != null) { request.AddQueryParameter("enforcement_point_path", EnforcementPointPath.ToString()); }
            if (Source != null) { request.AddQueryParameter("source", Source.ToString()); }
            request.Resource = GetLbvirtualServerStatisticsServiceURL.ToString();
            RestResponse<NSXTAggregateLBVirtualServerStatisticsType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTAggregateLBVirtualServerStatisticsType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Get operation to " + GetLbvirtualServerStatisticsServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTAggregateLBVirtualServerStatusType> GetLbvirtualServerStatus(string LbServiceId, string LbVirtualServerId, string? EnforcementPointPath = null, string? Source = null)
        {
            if (LbServiceId == null) { throw new System.ArgumentNullException("LbServiceId cannot be null"); }
            if (LbVirtualServerId == null) { throw new System.ArgumentNullException("LbVirtualServerId cannot be null"); }
            StringBuilder GetLbvirtualServerStatusServiceURL = new StringBuilder("/infra/lb-services/{lb-service-id}/lb-virtual-servers/{lb-virtual-server-id}/detailed-status");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Get
            };
            GetLbvirtualServerStatusServiceURL.Replace("{lb-service-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(LbServiceId, System.Globalization.CultureInfo.InvariantCulture)));
            GetLbvirtualServerStatusServiceURL.Replace("{lb-virtual-server-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(LbVirtualServerId, System.Globalization.CultureInfo.InvariantCulture)));
            if (EnforcementPointPath != null) { request.AddQueryParameter("enforcement_point_path", EnforcementPointPath.ToString()); }
            if (Source != null) { request.AddQueryParameter("source", Source.ToString()); }
            request.Resource = GetLbvirtualServerStatusServiceURL.ToString();
            RestResponse<NSXTAggregateLBVirtualServerStatusType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTAggregateLBVirtualServerStatusType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Get operation to " + GetLbvirtualServerStatusServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTLBServiceUsageSummaryType> GetLbserviceUsageSummary(bool? IncludeUsages = null)
        {
            StringBuilder GetLbserviceUsageSummaryServiceURL = new StringBuilder("/infra/lb-service-usage-summary");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Get
            };
            if (IncludeUsages != null) { request.AddQueryParameter("include_usages", IncludeUsages.ToString()); }
            request.Resource = GetLbserviceUsageSummaryServiceURL.ToString();
            RestResponse<NSXTLBServiceUsageSummaryType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTLBServiceUsageSummaryType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Get operation to " + GetLbserviceUsageSummaryServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTAggregateLBPoolStatisticsType> GetLbpoolStatistics(string LbServiceId, string LbPoolId, string? EnforcementPointPath = null, string? Source = null)
        {
            if (LbServiceId == null) { throw new System.ArgumentNullException("LbServiceId cannot be null"); }
            if (LbPoolId == null) { throw new System.ArgumentNullException("LbPoolId cannot be null"); }
            StringBuilder GetLbpoolStatisticsServiceURL = new StringBuilder("/infra/lb-services/{lb-service-id}/lb-pools/{lb-pool-id}/statistics");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Get
            };
            GetLbpoolStatisticsServiceURL.Replace("{lb-service-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(LbServiceId, System.Globalization.CultureInfo.InvariantCulture)));
            GetLbpoolStatisticsServiceURL.Replace("{lb-pool-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(LbPoolId, System.Globalization.CultureInfo.InvariantCulture)));
            if (EnforcementPointPath != null) { request.AddQueryParameter("enforcement_point_path", EnforcementPointPath.ToString()); }
            if (Source != null) { request.AddQueryParameter("source", Source.ToString()); }
            request.Resource = GetLbpoolStatisticsServiceURL.ToString();
            RestResponse<NSXTAggregateLBPoolStatisticsType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTAggregateLBPoolStatisticsType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Get operation to " + GetLbpoolStatisticsServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTAggregateLBServiceUsageType> GetLbserviceUsage(string LbServiceId, string? EnforcementPointPath = null, string? Source = null)
        {
            if (LbServiceId == null) { throw new System.ArgumentNullException("LbServiceId cannot be null"); }
            StringBuilder GetLbserviceUsageServiceURL = new StringBuilder("/infra/lb-services/{lb-service-id}/service-usage");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Get
            };
            GetLbserviceUsageServiceURL.Replace("{lb-service-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(LbServiceId, System.Globalization.CultureInfo.InvariantCulture)));
            if (EnforcementPointPath != null) { request.AddQueryParameter("enforcement_point_path", EnforcementPointPath.ToString()); }
            if (Source != null) { request.AddQueryParameter("source", Source.ToString()); }
            request.Resource = GetLbserviceUsageServiceURL.ToString();
            RestResponse<NSXTAggregateLBServiceUsageType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTAggregateLBServiceUsageType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Get operation to " + GetLbserviceUsageServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTAggregateLBNodeUsageSummaryType> GetLbnodeUsageSummary(string? EnforcementPointPath = null, bool? IncludeUsages = null)
        {
            StringBuilder GetLbnodeUsageSummaryServiceURL = new StringBuilder("/infra/lb-node-usage-summary");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Get
            };
            if (EnforcementPointPath != null) { request.AddQueryParameter("enforcement_point_path", EnforcementPointPath.ToString()); }
            if (IncludeUsages != null) { request.AddQueryParameter("include_usages", IncludeUsages.ToString()); }
            request.Resource = GetLbnodeUsageSummaryServiceURL.ToString();
            RestResponse<NSXTAggregateLBNodeUsageSummaryType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTAggregateLBNodeUsageSummaryType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Get operation to " + GetLbnodeUsageSummaryServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
    }
}
