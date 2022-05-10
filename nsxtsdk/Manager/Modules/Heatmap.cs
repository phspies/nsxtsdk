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
    public class Heatmap
    {
        private RestClient restClient;
        private int retry;
        private int timeout;
        private CancellationToken cancellationToken;

        public Heatmap(RestClient Client, CancellationToken _cancellationToken, int _timeout, int _retry)
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
        public async Task<NSXTTransportNodeStatusListResultType> ListTransportNodeStatusForTransportZone(string ZoneId, string? Cursor = null, string? IncludedFields = null, long? PageSize = null, bool? SortAscending = null, string? SortBy = null, string? Source = null, string? Status = null)
        {
            if (ZoneId == null) { throw new System.ArgumentNullException("ZoneId cannot be null"); }
            StringBuilder ListTransportNodeStatusForTransportZoneServiceURL = new StringBuilder("/transport-zones/{zone-id}/transport-node-status");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Get
            };
            ListTransportNodeStatusForTransportZoneServiceURL.Replace("{zone-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(ZoneId, System.Globalization.CultureInfo.InvariantCulture)));
            if (Cursor != null) { request.AddQueryParameter("cursor", Cursor.ToString()); }
            if (IncludedFields != null) { request.AddQueryParameter("included_fields", IncludedFields.ToString()); }
            if (PageSize != null) { request.AddQueryParameter("page_size", PageSize.ToString()); }
            if (SortAscending != null) { request.AddQueryParameter("sort_ascending", SortAscending.ToString()); }
            if (SortBy != null) { request.AddQueryParameter("sort_by", SortBy.ToString()); }
            if (Source != null) { request.AddQueryParameter("source", Source.ToString()); }
            if (Status != null) { request.AddQueryParameter("status", Status.ToString()); }
            request.Resource = ListTransportNodeStatusForTransportZoneServiceURL.ToString();
            RestResponse<NSXTTransportNodeStatusListResultType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTTransportNodeStatusListResultType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Get operation to " + ListTransportNodeStatusForTransportZoneServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTPnicBondStatusListResultType> GetPnicStatusesForTransportNode(string NodeId, string? Status = null)
        {
            if (NodeId == null) { throw new System.ArgumentNullException("NodeId cannot be null"); }
            StringBuilder GetPnicStatusesForTransportNodeServiceURL = new StringBuilder("/transport-nodes/{node-id}/pnic-bond-status");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Get
            };
            GetPnicStatusesForTransportNodeServiceURL.Replace("{node-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(NodeId, System.Globalization.CultureInfo.InvariantCulture)));
            if (Status != null) { request.AddQueryParameter("status", Status.ToString()); }
            request.Resource = GetPnicStatusesForTransportNodeServiceURL.ToString();
            RestResponse<NSXTPnicBondStatusListResultType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTPnicBondStatusListResultType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Get operation to " + GetPnicStatusesForTransportNodeServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTHeatMapTransportZoneStatusType> GetAllTransportNodesStatus(string? NodeType = null)
        {
            StringBuilder GetAllTransportNodesStatusServiceURL = new StringBuilder("/transport-nodes/status");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Get
            };
            if (NodeType != null) { request.AddQueryParameter("node_type", NodeType.ToString()); }
            request.Resource = GetAllTransportNodesStatusServiceURL.ToString();
            RestResponse<NSXTHeatMapTransportZoneStatusType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTHeatMapTransportZoneStatusType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Get operation to " + GetAllTransportNodesStatusServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTTransportNodeStatusListResultType> ListRemoteTransportNodeStatus(string NodeId, string? BfdDiagnosticCode = null, string? Cursor = null, string? IncludedFields = null, long? PageSize = null, bool? SortAscending = null, string? SortBy = null, string? Source = null, string? TunnelStatus = null)
        {
            if (NodeId == null) { throw new System.ArgumentNullException("NodeId cannot be null"); }
            StringBuilder ListRemoteTransportNodeStatusServiceURL = new StringBuilder("/transport-nodes/{node-id}/remote-transport-node-status");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Get
            };
            ListRemoteTransportNodeStatusServiceURL.Replace("{node-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(NodeId, System.Globalization.CultureInfo.InvariantCulture)));
            if (BfdDiagnosticCode != null) { request.AddQueryParameter("bfd_diagnostic_code", BfdDiagnosticCode.ToString()); }
            if (Cursor != null) { request.AddQueryParameter("cursor", Cursor.ToString()); }
            if (IncludedFields != null) { request.AddQueryParameter("included_fields", IncludedFields.ToString()); }
            if (PageSize != null) { request.AddQueryParameter("page_size", PageSize.ToString()); }
            if (SortAscending != null) { request.AddQueryParameter("sort_ascending", SortAscending.ToString()); }
            if (SortBy != null) { request.AddQueryParameter("sort_by", SortBy.ToString()); }
            if (Source != null) { request.AddQueryParameter("source", Source.ToString()); }
            if (TunnelStatus != null) { request.AddQueryParameter("tunnel_status", TunnelStatus.ToString()); }
            request.Resource = ListRemoteTransportNodeStatusServiceURL.ToString();
            RestResponse<NSXTTransportNodeStatusListResultType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTTransportNodeStatusListResultType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Get operation to " + ListRemoteTransportNodeStatusServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTTransportNodeStatusType> GetTransportNodeStatus(string NodeId, string? Source = null)
        {
            if (NodeId == null) { throw new System.ArgumentNullException("NodeId cannot be null"); }
            StringBuilder GetTransportNodeStatusServiceURL = new StringBuilder("/transport-nodes/{node-id}/status");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Get
            };
            GetTransportNodeStatusServiceURL.Replace("{node-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(NodeId, System.Globalization.CultureInfo.InvariantCulture)));
            if (Source != null) { request.AddQueryParameter("source", Source.ToString()); }
            request.Resource = GetTransportNodeStatusServiceURL.ToString();
            RestResponse<NSXTTransportNodeStatusType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTTransportNodeStatusType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Get operation to " + GetTransportNodeStatusServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTHeatMapTransportNodesAggregateStatusType> GetAllTransportZoneStatus()
        {
            StringBuilder GetAllTransportZoneStatusServiceURL = new StringBuilder("/transport-zones/status");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Get
            };
            request.Resource = GetAllTransportZoneStatusServiceURL.ToString();
            RestResponse<NSXTHeatMapTransportNodesAggregateStatusType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTHeatMapTransportNodesAggregateStatusType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Get operation to " + GetAllTransportZoneStatusServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTHeatMapTransportZoneStatusType> GetHeatmapTransportZoneStatus(string ZoneId, string? Source = null)
        {
            if (ZoneId == null) { throw new System.ArgumentNullException("ZoneId cannot be null"); }
            StringBuilder GetHeatmapTransportZoneStatusServiceURL = new StringBuilder("/transport-zones/{zone-id}/status");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Get
            };
            GetHeatmapTransportZoneStatusServiceURL.Replace("{zone-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(ZoneId, System.Globalization.CultureInfo.InvariantCulture)));
            if (Source != null) { request.AddQueryParameter("source", Source.ToString()); }
            request.Resource = GetHeatmapTransportZoneStatusServiceURL.ToString();
            RestResponse<NSXTHeatMapTransportZoneStatusType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTHeatMapTransportZoneStatusType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Get operation to " + GetHeatmapTransportZoneStatusServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task GetTransportNodeReportForAtransportZone(string ZoneId, string? Source = null, string? Status = null)
        {
            if (ZoneId == null) { throw new System.ArgumentNullException("ZoneId cannot be null"); }
            StringBuilder GetTransportNodeReportForAtransportZoneServiceURL = new StringBuilder("/transport-zones/{zone-id}/transport-node-status-report");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Get
            };
            GetTransportNodeReportForAtransportZoneServiceURL.Replace("{zone-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(ZoneId, System.Globalization.CultureInfo.InvariantCulture)));
            if (Source != null) { request.AddQueryParameter("source", Source.ToString()); }
            if (Status != null) { request.AddQueryParameter("status", Status.ToString()); }
            request.Resource = GetTransportNodeReportForAtransportZoneServiceURL.ToString();
            RestResponse response = await restClient.ExecuteTaskAsyncWithPolicy(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Get operation to " + GetTransportNodeReportForAtransportZoneServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task GetTransportNodeReport(string? Source = null, string? Status = null)
        {
            StringBuilder GetTransportNodeReportServiceURL = new StringBuilder("/transport-zones/transport-node-status-report");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Get
            };
            if (Source != null) { request.AddQueryParameter("source", Source.ToString()); }
            if (Status != null) { request.AddQueryParameter("status", Status.ToString()); }
            request.Resource = GetTransportNodeReportServiceURL.ToString();
            RestResponse response = await restClient.ExecuteTaskAsyncWithPolicy(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Get operation to " + GetTransportNodeReportServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTTransportNodeStatusListResultType> ListTransportNodeStatus(string? Cursor = null, string? IncludedFields = null, long? PageSize = null, bool? SortAscending = null, string? SortBy = null, string? Source = null, string? Status = null)
        {
            StringBuilder ListTransportNodeStatusServiceURL = new StringBuilder("/transport-zones/transport-node-status");
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
            if (Source != null) { request.AddQueryParameter("source", Source.ToString()); }
            if (Status != null) { request.AddQueryParameter("status", Status.ToString()); }
            request.Resource = ListTransportNodeStatusServiceURL.ToString();
            RestResponse<NSXTTransportNodeStatusListResultType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTTransportNodeStatusListResultType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Get operation to " + ListTransportNodeStatusServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
    }
}
