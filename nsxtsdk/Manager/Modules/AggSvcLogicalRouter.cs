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
    public class AggSvcLogicalRouter
    {
        private RestClient restClient;
        private int retry;
        private int timeout;
        private CancellationToken cancellationToken;

        public AggSvcLogicalRouter(RestClient Client, CancellationToken _cancellationToken, int _timeout, int _retry)
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
        public async Task<NSXTLogicalRouterRouteTableType> GetLogicalRouterForwardingTable(string LogicalRouterId, string TransportNodeId, string? Cursor = null, string? IncludedFields = null, string? NetworkPrefix = null, long? PageSize = null, bool? SortAscending = null, string? SortBy = null, string? Source = null)
        {
            if (LogicalRouterId == null) { throw new System.ArgumentNullException("LogicalRouterId cannot be null"); }
            if (TransportNodeId == null) { throw new System.ArgumentNullException("TransportNodeId cannot be null"); }
            StringBuilder GetLogicalRouterForwardingTableServiceURL = new StringBuilder("/logical-routers/{logical-router-id}/routing/forwarding-table");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Get
            };
            GetLogicalRouterForwardingTableServiceURL.Replace("{logical-router-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(LogicalRouterId, System.Globalization.CultureInfo.InvariantCulture)));
            if (Cursor != null) { request.AddQueryParameter("cursor", Cursor.ToString()); }
            if (IncludedFields != null) { request.AddQueryParameter("included_fields", IncludedFields.ToString()); }
            if (NetworkPrefix != null) { request.AddQueryParameter("network_prefix", NetworkPrefix.ToString()); }
            if (PageSize != null) { request.AddQueryParameter("page_size", PageSize.ToString()); }
            if (SortAscending != null) { request.AddQueryParameter("sort_ascending", SortAscending.ToString()); }
            if (SortBy != null) { request.AddQueryParameter("sort_by", SortBy.ToString()); }
            if (Source != null) { request.AddQueryParameter("source", Source.ToString()); }
            if (TransportNodeId != null) { request.AddQueryParameter("transport_node_id", TransportNodeId.ToString()); }
            request.Resource = GetLogicalRouterForwardingTableServiceURL.ToString();
            RestResponse<NSXTLogicalRouterRouteTableType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTLogicalRouterRouteTableType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Get operation to " + GetLogicalRouterForwardingTableServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTNatStatisticsPerRuleType> GetNatStatisticsPerRule(string LogicalRouterId, string RuleId, string? Source = null)
        {
            if (LogicalRouterId == null) { throw new System.ArgumentNullException("LogicalRouterId cannot be null"); }
            if (RuleId == null) { throw new System.ArgumentNullException("RuleId cannot be null"); }
            StringBuilder GetNatStatisticsPerRuleServiceURL = new StringBuilder("/logical-routers/{logical-router-id}/nat/rules/{rule-id}/statistics");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Get
            };
            GetNatStatisticsPerRuleServiceURL.Replace("{logical-router-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(LogicalRouterId, System.Globalization.CultureInfo.InvariantCulture)));
            GetNatStatisticsPerRuleServiceURL.Replace("{rule-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(RuleId, System.Globalization.CultureInfo.InvariantCulture)));
            if (Source != null) { request.AddQueryParameter("source", Source.ToString()); }
            request.Resource = GetNatStatisticsPerRuleServiceURL.ToString();
            RestResponse<NSXTNatStatisticsPerRuleType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTNatStatisticsPerRuleType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Get operation to " + GetNatStatisticsPerRuleServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTLogicalRouterRouteTableInCsvFormatType> GetLogicalRouterRouteTableInCsvFormat(string LogicalRouterId, string TransportNodeId, string? Source = null)
        {
            if (LogicalRouterId == null) { throw new System.ArgumentNullException("LogicalRouterId cannot be null"); }
            if (TransportNodeId == null) { throw new System.ArgumentNullException("TransportNodeId cannot be null"); }
            StringBuilder GetLogicalRouterRouteTableInCsvFormatServiceURL = new StringBuilder("/logical-routers/{logical-router-id}/routing/route-table?format=csv");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Get
            };
            GetLogicalRouterRouteTableInCsvFormatServiceURL.Replace("{logical-router-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(LogicalRouterId, System.Globalization.CultureInfo.InvariantCulture)));
            if (Source != null) { request.AddQueryParameter("source", Source.ToString()); }
            if (TransportNodeId != null) { request.AddQueryParameter("transport_node_id", TransportNodeId.ToString()); }
            request.Resource = GetLogicalRouterRouteTableInCsvFormatServiceURL.ToString();
            RestResponse<NSXTLogicalRouterRouteTableInCsvFormatType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTLogicalRouterRouteTableInCsvFormatType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Get operation to " + GetLogicalRouterRouteTableInCsvFormatServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTLogicalRouterStatusType> GetLogicalRouterStatus(string LogicalRouterId, string? Source = null)
        {
            if (LogicalRouterId == null) { throw new System.ArgumentNullException("LogicalRouterId cannot be null"); }
            StringBuilder GetLogicalRouterStatusServiceURL = new StringBuilder("/logical-routers/{logical-router-id}/status");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Get
            };
            GetLogicalRouterStatusServiceURL.Replace("{logical-router-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(LogicalRouterId, System.Globalization.CultureInfo.InvariantCulture)));
            if (Source != null) { request.AddQueryParameter("source", Source.ToString()); }
            request.Resource = GetLogicalRouterStatusServiceURL.ToString();
            RestResponse<NSXTLogicalRouterStatusType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTLogicalRouterStatusType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Get operation to " + GetLogicalRouterStatusServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTBgpNeighborsStatusListResultType> GetBgpNeighborsStatus(string LogicalRouterId, string? Cursor = null, string? IncludedFields = null, long? PageSize = null, bool? SortAscending = null, string? SortBy = null, string? Source = null, string? TransportNodeId = null)
        {
            if (LogicalRouterId == null) { throw new System.ArgumentNullException("LogicalRouterId cannot be null"); }
            StringBuilder GetBgpNeighborsStatusServiceURL = new StringBuilder("/logical-routers/{logical-router-id}/routing/bgp/neighbors/status");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Get
            };
            GetBgpNeighborsStatusServiceURL.Replace("{logical-router-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(LogicalRouterId, System.Globalization.CultureInfo.InvariantCulture)));
            if (Cursor != null) { request.AddQueryParameter("cursor", Cursor.ToString()); }
            if (IncludedFields != null) { request.AddQueryParameter("included_fields", IncludedFields.ToString()); }
            if (PageSize != null) { request.AddQueryParameter("page_size", PageSize.ToString()); }
            if (SortAscending != null) { request.AddQueryParameter("sort_ascending", SortAscending.ToString()); }
            if (SortBy != null) { request.AddQueryParameter("sort_by", SortBy.ToString()); }
            if (Source != null) { request.AddQueryParameter("source", Source.ToString()); }
            if (TransportNodeId != null) { request.AddQueryParameter("transport_node_id", TransportNodeId.ToString()); }
            request.Resource = GetBgpNeighborsStatusServiceURL.ToString();
            RestResponse<NSXTBgpNeighborsStatusListResultType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTBgpNeighborsStatusListResultType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Get operation to " + GetBgpNeighborsStatusServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTBgpNeighborRouteDetailsInCsvFormatType> GetBgpNeighborRoutesInCsvFormat(string LogicalRouterId, string NeighborId)
        {
            if (LogicalRouterId == null) { throw new System.ArgumentNullException("LogicalRouterId cannot be null"); }
            if (NeighborId == null) { throw new System.ArgumentNullException("NeighborId cannot be null"); }
            StringBuilder GetBgpNeighborRoutesInCsvFormatServiceURL = new StringBuilder("/logical-routers/{logical-router-id}/routing/bgp/neighbors/{neighbor-id}/routes?format=csv");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Get
            };
            GetBgpNeighborRoutesInCsvFormatServiceURL.Replace("{logical-router-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(LogicalRouterId, System.Globalization.CultureInfo.InvariantCulture)));
            GetBgpNeighborRoutesInCsvFormatServiceURL.Replace("{neighbor-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(NeighborId, System.Globalization.CultureInfo.InvariantCulture)));
            request.Resource = GetBgpNeighborRoutesInCsvFormatServiceURL.ToString();
            RestResponse<NSXTBgpNeighborRouteDetailsInCsvFormatType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTBgpNeighborRouteDetailsInCsvFormatType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Get operation to " + GetBgpNeighborRoutesInCsvFormatServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTBgpNeighborRouteDetailsType> GetBgpNeighborRoutes(string LogicalRouterId, string NeighborId)
        {
            if (LogicalRouterId == null) { throw new System.ArgumentNullException("LogicalRouterId cannot be null"); }
            if (NeighborId == null) { throw new System.ArgumentNullException("NeighborId cannot be null"); }
            StringBuilder GetBgpNeighborRoutesServiceURL = new StringBuilder("/logical-routers/{logical-router-id}/routing/bgp/neighbors/{neighbor-id}/routes");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Get
            };
            GetBgpNeighborRoutesServiceURL.Replace("{logical-router-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(LogicalRouterId, System.Globalization.CultureInfo.InvariantCulture)));
            GetBgpNeighborRoutesServiceURL.Replace("{neighbor-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(NeighborId, System.Globalization.CultureInfo.InvariantCulture)));
            request.Resource = GetBgpNeighborRoutesServiceURL.ToString();
            RestResponse<NSXTBgpNeighborRouteDetailsType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTBgpNeighborRouteDetailsType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Get operation to " + GetBgpNeighborRoutesServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTLogicalRouterRouteTableType> GetLogicalRouterRouteTable(string LogicalRouterId, string TransportNodeId, string? Cursor = null, string? IncludedFields = null, long? PageSize = null, bool? SortAscending = null, string? SortBy = null, string? Source = null)
        {
            if (LogicalRouterId == null) { throw new System.ArgumentNullException("LogicalRouterId cannot be null"); }
            if (TransportNodeId == null) { throw new System.ArgumentNullException("TransportNodeId cannot be null"); }
            StringBuilder GetLogicalRouterRouteTableServiceURL = new StringBuilder("/logical-routers/{logical-router-id}/routing/route-table");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Get
            };
            GetLogicalRouterRouteTableServiceURL.Replace("{logical-router-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(LogicalRouterId, System.Globalization.CultureInfo.InvariantCulture)));
            if (Cursor != null) { request.AddQueryParameter("cursor", Cursor.ToString()); }
            if (IncludedFields != null) { request.AddQueryParameter("included_fields", IncludedFields.ToString()); }
            if (PageSize != null) { request.AddQueryParameter("page_size", PageSize.ToString()); }
            if (SortAscending != null) { request.AddQueryParameter("sort_ascending", SortAscending.ToString()); }
            if (SortBy != null) { request.AddQueryParameter("sort_by", SortBy.ToString()); }
            if (Source != null) { request.AddQueryParameter("source", Source.ToString()); }
            if (TransportNodeId != null) { request.AddQueryParameter("transport_node_id", TransportNodeId.ToString()); }
            request.Resource = GetLogicalRouterRouteTableServiceURL.ToString();
            RestResponse<NSXTLogicalRouterRouteTableType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTLogicalRouterRouteTableType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Get operation to " + GetLogicalRouterRouteTableServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTLogicalRouterRouteTableInCsvFormatType> GetLogicalRouterForwardingTableInCsvFormat(string LogicalRouterId, string TransportNodeId, string? NetworkPrefix = null, string? Source = null)
        {
            if (LogicalRouterId == null) { throw new System.ArgumentNullException("LogicalRouterId cannot be null"); }
            if (TransportNodeId == null) { throw new System.ArgumentNullException("TransportNodeId cannot be null"); }
            StringBuilder GetLogicalRouterForwardingTableInCsvFormatServiceURL = new StringBuilder("/logical-routers/{logical-router-id}/routing/forwarding-table?format=csv");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Get
            };
            GetLogicalRouterForwardingTableInCsvFormatServiceURL.Replace("{logical-router-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(LogicalRouterId, System.Globalization.CultureInfo.InvariantCulture)));
            if (NetworkPrefix != null) { request.AddQueryParameter("network_prefix", NetworkPrefix.ToString()); }
            if (Source != null) { request.AddQueryParameter("source", Source.ToString()); }
            if (TransportNodeId != null) { request.AddQueryParameter("transport_node_id", TransportNodeId.ToString()); }
            request.Resource = GetLogicalRouterForwardingTableInCsvFormatServiceURL.ToString();
            RestResponse<NSXTLogicalRouterRouteTableInCsvFormatType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTLogicalRouterRouteTableInCsvFormatType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Get operation to " + GetLogicalRouterForwardingTableInCsvFormatServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTLogicalRouterRouteTableType> GetLogicalRouterRoutingTable(string LogicalRouterId, string TransportNodeId, string? Cursor = null, string? IncludedFields = null, string? NetworkPrefix = null, long? PageSize = null, string? RouteSource = null, bool? SortAscending = null, string? SortBy = null, string? Source = null, string? VrfTable = null)
        {
            if (LogicalRouterId == null) { throw new System.ArgumentNullException("LogicalRouterId cannot be null"); }
            if (TransportNodeId == null) { throw new System.ArgumentNullException("TransportNodeId cannot be null"); }
            StringBuilder GetLogicalRouterRoutingTableServiceURL = new StringBuilder("/logical-routers/{logical-router-id}/routing/routing-table");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Get
            };
            GetLogicalRouterRoutingTableServiceURL.Replace("{logical-router-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(LogicalRouterId, System.Globalization.CultureInfo.InvariantCulture)));
            if (Cursor != null) { request.AddQueryParameter("cursor", Cursor.ToString()); }
            if (IncludedFields != null) { request.AddQueryParameter("included_fields", IncludedFields.ToString()); }
            if (NetworkPrefix != null) { request.AddQueryParameter("network_prefix", NetworkPrefix.ToString()); }
            if (PageSize != null) { request.AddQueryParameter("page_size", PageSize.ToString()); }
            if (RouteSource != null) { request.AddQueryParameter("route_source", RouteSource.ToString()); }
            if (SortAscending != null) { request.AddQueryParameter("sort_ascending", SortAscending.ToString()); }
            if (SortBy != null) { request.AddQueryParameter("sort_by", SortBy.ToString()); }
            if (Source != null) { request.AddQueryParameter("source", Source.ToString()); }
            if (TransportNodeId != null) { request.AddQueryParameter("transport_node_id", TransportNodeId.ToString()); }
            if (VrfTable != null) { request.AddQueryParameter("vrf_table", VrfTable.ToString()); }
            request.Resource = GetLogicalRouterRoutingTableServiceURL.ToString();
            RestResponse<NSXTLogicalRouterRouteTableType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTLogicalRouterRouteTableType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Get operation to " + GetLogicalRouterRoutingTableServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTNatStatisticsPerLogicalRouterType> GetNatStatisticsPerLogicalRouter(string LogicalRouterId, string? Source = null)
        {
            if (LogicalRouterId == null) { throw new System.ArgumentNullException("LogicalRouterId cannot be null"); }
            StringBuilder GetNatStatisticsPerLogicalRouterServiceURL = new StringBuilder("/logical-routers/{logical-router-id}/nat/rules/statistics");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Get
            };
            GetNatStatisticsPerLogicalRouterServiceURL.Replace("{logical-router-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(LogicalRouterId, System.Globalization.CultureInfo.InvariantCulture)));
            if (Source != null) { request.AddQueryParameter("source", Source.ToString()); }
            request.Resource = GetNatStatisticsPerLogicalRouterServiceURL.ToString();
            RestResponse<NSXTNatStatisticsPerLogicalRouterType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTNatStatisticsPerLogicalRouterType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Get operation to " + GetNatStatisticsPerLogicalRouterServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTNatStatisticsPerTransportNodeType> GetNatStatisticsPerTransportNode(string NodeId, string? Source = null)
        {
            if (NodeId == null) { throw new System.ArgumentNullException("NodeId cannot be null"); }
            StringBuilder GetNatStatisticsPerTransportNodeServiceURL = new StringBuilder("/transport-nodes/{node-id}/statistics/nat-rules");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Get
            };
            GetNatStatisticsPerTransportNodeServiceURL.Replace("{node-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(NodeId, System.Globalization.CultureInfo.InvariantCulture)));
            if (Source != null) { request.AddQueryParameter("source", Source.ToString()); }
            request.Resource = GetNatStatisticsPerTransportNodeServiceURL.ToString();
            RestResponse<NSXTNatStatisticsPerTransportNodeType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTNatStatisticsPerTransportNodeType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Get operation to " + GetNatStatisticsPerTransportNodeServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTBgpNeighborRouteDetailsInCsvFormatType> GetBgpNeighborAdvertisedRoutesInCsvFormat(string LogicalRouterId, string NeighborId)
        {
            if (LogicalRouterId == null) { throw new System.ArgumentNullException("LogicalRouterId cannot be null"); }
            if (NeighborId == null) { throw new System.ArgumentNullException("NeighborId cannot be null"); }
            StringBuilder GetBgpNeighborAdvertisedRoutesInCsvFormatServiceURL = new StringBuilder("/logical-routers/{logical-router-id}/routing/bgp/neighbors/{neighbor-id}/advertised-routes?format=csv");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Get
            };
            GetBgpNeighborAdvertisedRoutesInCsvFormatServiceURL.Replace("{logical-router-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(LogicalRouterId, System.Globalization.CultureInfo.InvariantCulture)));
            GetBgpNeighborAdvertisedRoutesInCsvFormatServiceURL.Replace("{neighbor-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(NeighborId, System.Globalization.CultureInfo.InvariantCulture)));
            request.Resource = GetBgpNeighborAdvertisedRoutesInCsvFormatServiceURL.ToString();
            RestResponse<NSXTBgpNeighborRouteDetailsInCsvFormatType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTBgpNeighborRouteDetailsInCsvFormatType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Get operation to " + GetBgpNeighborAdvertisedRoutesInCsvFormatServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTLogicalRouterRouteTableInCsvFormatType> GetLogicalRouterRoutingTableInCsvFormat(string LogicalRouterId, string TransportNodeId, string? NetworkPrefix = null, string? RouteSource = null, string? Source = null, string? VrfTable = null)
        {
            if (LogicalRouterId == null) { throw new System.ArgumentNullException("LogicalRouterId cannot be null"); }
            if (TransportNodeId == null) { throw new System.ArgumentNullException("TransportNodeId cannot be null"); }
            StringBuilder GetLogicalRouterRoutingTableInCsvFormatServiceURL = new StringBuilder("/logical-routers/{logical-router-id}/routing/routing-table?format=csv");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Get
            };
            GetLogicalRouterRoutingTableInCsvFormatServiceURL.Replace("{logical-router-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(LogicalRouterId, System.Globalization.CultureInfo.InvariantCulture)));
            if (NetworkPrefix != null) { request.AddQueryParameter("network_prefix", NetworkPrefix.ToString()); }
            if (RouteSource != null) { request.AddQueryParameter("route_source", RouteSource.ToString()); }
            if (Source != null) { request.AddQueryParameter("source", Source.ToString()); }
            if (TransportNodeId != null) { request.AddQueryParameter("transport_node_id", TransportNodeId.ToString()); }
            if (VrfTable != null) { request.AddQueryParameter("vrf_table", VrfTable.ToString()); }
            request.Resource = GetLogicalRouterRoutingTableInCsvFormatServiceURL.ToString();
            RestResponse<NSXTLogicalRouterRouteTableInCsvFormatType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTLogicalRouterRouteTableInCsvFormatType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Get operation to " + GetLogicalRouterRoutingTableInCsvFormatServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTBgpNeighborRouteDetailsType> GetBgpNeighborAdvertisedRoutes(string LogicalRouterId, string NeighborId)
        {
            if (LogicalRouterId == null) { throw new System.ArgumentNullException("LogicalRouterId cannot be null"); }
            if (NeighborId == null) { throw new System.ArgumentNullException("NeighborId cannot be null"); }
            StringBuilder GetBgpNeighborAdvertisedRoutesServiceURL = new StringBuilder("/logical-routers/{logical-router-id}/routing/bgp/neighbors/{neighbor-id}/advertised-routes");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Get
            };
            GetBgpNeighborAdvertisedRoutesServiceURL.Replace("{logical-router-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(LogicalRouterId, System.Globalization.CultureInfo.InvariantCulture)));
            GetBgpNeighborAdvertisedRoutesServiceURL.Replace("{neighbor-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(NeighborId, System.Globalization.CultureInfo.InvariantCulture)));
            request.Resource = GetBgpNeighborAdvertisedRoutesServiceURL.ToString();
            RestResponse<NSXTBgpNeighborRouteDetailsType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTBgpNeighborRouteDetailsType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Get operation to " + GetBgpNeighborAdvertisedRoutesServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
    }
}
