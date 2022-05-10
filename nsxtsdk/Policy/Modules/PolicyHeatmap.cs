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
    public class PolicyHeatmap
    {
        private RestClient restClient;
        private int retry;
        private int timeout;
        private CancellationToken cancellationToken;

        public PolicyHeatmap(RestClient Client, CancellationToken _cancellationToken, int _timeout, int _retry)
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
        public async Task<NSXTTunnelPropertiesType> GetTunnelByName(string SiteId, string EnforcementPointId, string NodeId, string TunnelName, string? Source = null)
        {
            if (SiteId == null) { throw new System.ArgumentNullException("SiteId cannot be null"); }
            if (EnforcementPointId == null) { throw new System.ArgumentNullException("EnforcementPointId cannot be null"); }
            if (NodeId == null) { throw new System.ArgumentNullException("NodeId cannot be null"); }
            if (TunnelName == null) { throw new System.ArgumentNullException("TunnelName cannot be null"); }
            StringBuilder GetTunnelByNameServiceURL = new StringBuilder("/infra/sites/{site-id}/enforcement-points/{enforcement-point-id}/host-transport-nodes/{node-id}/tunnels/{tunnel-name}");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Get
            };
            GetTunnelByNameServiceURL.Replace("{site-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(SiteId, System.Globalization.CultureInfo.InvariantCulture)));
            GetTunnelByNameServiceURL.Replace("{enforcement-point-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(EnforcementPointId, System.Globalization.CultureInfo.InvariantCulture)));
            GetTunnelByNameServiceURL.Replace("{node-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(NodeId, System.Globalization.CultureInfo.InvariantCulture)));
            GetTunnelByNameServiceURL.Replace("{tunnel-name}", System.Uri.EscapeDataString(Helpers.ConvertToString(TunnelName, System.Globalization.CultureInfo.InvariantCulture)));
            if (Source != null) { request.AddQueryParameter("source", Source.ToString()); }
            request.Resource = GetTunnelByNameServiceURL.ToString();
            RestResponse<NSXTTunnelPropertiesType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTTunnelPropertiesType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Get operation to " + GetTunnelByNameServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTContainerClusterStatusType> AddContainerClusterStatus(string SiteId, string EnforcementPointId, NSXTContainerClusterStatusType ContainerClusterStatus)
        {
            if (SiteId == null) { throw new System.ArgumentNullException("SiteId cannot be null"); }
            if (EnforcementPointId == null) { throw new System.ArgumentNullException("EnforcementPointId cannot be null"); }
            if (ContainerClusterStatus == null) { throw new System.ArgumentNullException("ContainerClusterStatus cannot be null"); }
            StringBuilder AddContainerClusterStatusServiceURL = new StringBuilder("/infra/sites/{site-id}/enforcement-points/{enforcement-point-id}/container-cluster-ncpstatus");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Post
            };
            AddContainerClusterStatusServiceURL.Replace("{site-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(SiteId, System.Globalization.CultureInfo.InvariantCulture)));
            AddContainerClusterStatusServiceURL.Replace("{enforcement-point-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(EnforcementPointId, System.Globalization.CultureInfo.InvariantCulture)));
            request.AddJsonBody(ContainerClusterStatus);
            request.Resource = AddContainerClusterStatusServiceURL.ToString();
            RestResponse<NSXTContainerClusterStatusType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTContainerClusterStatusType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Post operation to " + AddContainerClusterStatusServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTContainerClusterStatusListType> GetContainerClusterStatusList(string SiteId, string EnforcementPointId, string? Cursor = null, string? IncludedFields = null, long? PageSize = null, bool? SortAscending = null, string? SortBy = null, string? Status = null)
        {
            if (SiteId == null) { throw new System.ArgumentNullException("SiteId cannot be null"); }
            if (EnforcementPointId == null) { throw new System.ArgumentNullException("EnforcementPointId cannot be null"); }
            StringBuilder GetContainerClusterStatusListServiceURL = new StringBuilder("/infra/sites/{site-id}/enforcement-points/{enforcement-point-id}/container-cluster-ncpstatus");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Get
            };
            GetContainerClusterStatusListServiceURL.Replace("{site-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(SiteId, System.Globalization.CultureInfo.InvariantCulture)));
            GetContainerClusterStatusListServiceURL.Replace("{enforcement-point-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(EnforcementPointId, System.Globalization.CultureInfo.InvariantCulture)));
            if (Cursor != null) { request.AddQueryParameter("cursor", Cursor.ToString()); }
            if (IncludedFields != null) { request.AddQueryParameter("included_fields", IncludedFields.ToString()); }
            if (PageSize != null) { request.AddQueryParameter("page_size", PageSize.ToString()); }
            if (SortAscending != null) { request.AddQueryParameter("sort_ascending", SortAscending.ToString()); }
            if (SortBy != null) { request.AddQueryParameter("sort_by", SortBy.ToString()); }
            if (Status != null) { request.AddQueryParameter("status", Status.ToString()); }
            request.Resource = GetContainerClusterStatusListServiceURL.ToString();
            RestResponse<NSXTContainerClusterStatusListType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTContainerClusterStatusListType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Get operation to " + GetContainerClusterStatusListServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTHeatMapTransportZoneStatusType> GetHeatmapTzstatus(string SiteId, string EnforcementPointId, string ZoneId, string? Source = null)
        {
            if (SiteId == null) { throw new System.ArgumentNullException("SiteId cannot be null"); }
            if (EnforcementPointId == null) { throw new System.ArgumentNullException("EnforcementPointId cannot be null"); }
            if (ZoneId == null) { throw new System.ArgumentNullException("ZoneId cannot be null"); }
            StringBuilder GetHeatmapTzstatusServiceURL = new StringBuilder("/infra/sites/{site-id}/enforcement-points/{enforcement-point-id}/transport-zones/{zone-id}/status");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Get
            };
            GetHeatmapTzstatusServiceURL.Replace("{site-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(SiteId, System.Globalization.CultureInfo.InvariantCulture)));
            GetHeatmapTzstatusServiceURL.Replace("{enforcement-point-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(EnforcementPointId, System.Globalization.CultureInfo.InvariantCulture)));
            GetHeatmapTzstatusServiceURL.Replace("{zone-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(ZoneId, System.Globalization.CultureInfo.InvariantCulture)));
            if (Source != null) { request.AddQueryParameter("source", Source.ToString()); }
            request.Resource = GetHeatmapTzstatusServiceURL.ToString();
            RestResponse<NSXTHeatMapTransportZoneStatusType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTHeatMapTransportZoneStatusType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Get operation to " + GetHeatmapTzstatusServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTContainerClusterSummaryType> GetContainerClusterStatus(string SiteId, string EnforcementPointId, string ClusterId)
        {
            if (SiteId == null) { throw new System.ArgumentNullException("SiteId cannot be null"); }
            if (EnforcementPointId == null) { throw new System.ArgumentNullException("EnforcementPointId cannot be null"); }
            if (ClusterId == null) { throw new System.ArgumentNullException("ClusterId cannot be null"); }
            StringBuilder GetContainerClusterStatusServiceURL = new StringBuilder("/infra/sites/{site-id}/enforcement-points/{enforcement-point-id}/container-cluster/{cluster-id}/ncpstatus");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Get
            };
            GetContainerClusterStatusServiceURL.Replace("{site-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(SiteId, System.Globalization.CultureInfo.InvariantCulture)));
            GetContainerClusterStatusServiceURL.Replace("{enforcement-point-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(EnforcementPointId, System.Globalization.CultureInfo.InvariantCulture)));
            GetContainerClusterStatusServiceURL.Replace("{cluster-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(ClusterId, System.Globalization.CultureInfo.InvariantCulture)));
            request.Resource = GetContainerClusterStatusServiceURL.ToString();
            RestResponse<NSXTContainerClusterSummaryType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTContainerClusterSummaryType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Get operation to " + GetContainerClusterStatusServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task DeleteContainerClusterStatus(string SiteId, string EnforcementPointId, string ClusterId)
        {
            if (SiteId == null) { throw new System.ArgumentNullException("SiteId cannot be null"); }
            if (EnforcementPointId == null) { throw new System.ArgumentNullException("EnforcementPointId cannot be null"); }
            if (ClusterId == null) { throw new System.ArgumentNullException("ClusterId cannot be null"); }
            StringBuilder DeleteContainerClusterStatusServiceURL = new StringBuilder("/infra/sites/{site-id}/enforcement-points/{enforcement-point-id}/container-cluster/{cluster-id}/ncpstatus");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Delete
            };
            DeleteContainerClusterStatusServiceURL.Replace("{site-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(SiteId, System.Globalization.CultureInfo.InvariantCulture)));
            DeleteContainerClusterStatusServiceURL.Replace("{enforcement-point-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(EnforcementPointId, System.Globalization.CultureInfo.InvariantCulture)));
            DeleteContainerClusterStatusServiceURL.Replace("{cluster-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(ClusterId, System.Globalization.CultureInfo.InvariantCulture)));
            request.Resource = DeleteContainerClusterStatusServiceURL.ToString();
            RestResponse response = await restClient.ExecuteTaskAsyncWithPolicy(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Delete operation to " + DeleteContainerClusterStatusServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTTransportNodeStatusListResultType> ListRemoteTnstatus(string SiteId, string EnforcementPointId, string NodeId, string? BfdDiagnosticCode = null, string? Cursor = null, string? IncludedFields = null, long? PageSize = null, bool? SortAscending = null, string? SortBy = null, string? Source = null, string? TunnelStatus = null)
        {
            if (SiteId == null) { throw new System.ArgumentNullException("SiteId cannot be null"); }
            if (EnforcementPointId == null) { throw new System.ArgumentNullException("EnforcementPointId cannot be null"); }
            if (NodeId == null) { throw new System.ArgumentNullException("NodeId cannot be null"); }
            StringBuilder ListRemoteTnstatusServiceURL = new StringBuilder("/infra/sites/{site-id}/enforcement-points/{enforcement-point-id}/host-transport-nodes/{node-id}/remote-transport-node-status");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Get
            };
            ListRemoteTnstatusServiceURL.Replace("{site-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(SiteId, System.Globalization.CultureInfo.InvariantCulture)));
            ListRemoteTnstatusServiceURL.Replace("{enforcement-point-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(EnforcementPointId, System.Globalization.CultureInfo.InvariantCulture)));
            ListRemoteTnstatusServiceURL.Replace("{node-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(NodeId, System.Globalization.CultureInfo.InvariantCulture)));
            if (BfdDiagnosticCode != null) { request.AddQueryParameter("bfd_diagnostic_code", BfdDiagnosticCode.ToString()); }
            if (Cursor != null) { request.AddQueryParameter("cursor", Cursor.ToString()); }
            if (IncludedFields != null) { request.AddQueryParameter("included_fields", IncludedFields.ToString()); }
            if (PageSize != null) { request.AddQueryParameter("page_size", PageSize.ToString()); }
            if (SortAscending != null) { request.AddQueryParameter("sort_ascending", SortAscending.ToString()); }
            if (SortBy != null) { request.AddQueryParameter("sort_by", SortBy.ToString()); }
            if (Source != null) { request.AddQueryParameter("source", Source.ToString()); }
            if (TunnelStatus != null) { request.AddQueryParameter("tunnel_status", TunnelStatus.ToString()); }
            request.Resource = ListRemoteTnstatusServiceURL.ToString();
            RestResponse<NSXTTransportNodeStatusListResultType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTTransportNodeStatusListResultType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Get operation to " + ListRemoteTnstatusServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task GetTnreport(string SiteId, string EnforcementPointId, string? Source = null, string? Status = null)
        {
            if (SiteId == null) { throw new System.ArgumentNullException("SiteId cannot be null"); }
            if (EnforcementPointId == null) { throw new System.ArgumentNullException("EnforcementPointId cannot be null"); }
            StringBuilder GetTnreportServiceURL = new StringBuilder("/infra/sites/{site-id}/enforcement-points/{enforcement-point-id}/transport-node-status-report");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Get
            };
            GetTnreportServiceURL.Replace("{site-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(SiteId, System.Globalization.CultureInfo.InvariantCulture)));
            GetTnreportServiceURL.Replace("{enforcement-point-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(EnforcementPointId, System.Globalization.CultureInfo.InvariantCulture)));
            if (Source != null) { request.AddQueryParameter("source", Source.ToString()); }
            if (Status != null) { request.AddQueryParameter("status", Status.ToString()); }
            request.Resource = GetTnreportServiceURL.ToString();
            RestResponse response = await restClient.ExecuteTaskAsyncWithPolicy(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Get operation to " + GetTnreportServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTHeatMapTransportNodesAggregateStatusType> GetAllTzstatus(string SiteId, string EnforcementPointId)
        {
            if (SiteId == null) { throw new System.ArgumentNullException("SiteId cannot be null"); }
            if (EnforcementPointId == null) { throw new System.ArgumentNullException("EnforcementPointId cannot be null"); }
            StringBuilder GetAllTzstatusServiceURL = new StringBuilder("/infra/sites/{site-id}/enforcement-points/{enforcement-point-id}/transport-zones-aggstatus");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Get
            };
            GetAllTzstatusServiceURL.Replace("{site-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(SiteId, System.Globalization.CultureInfo.InvariantCulture)));
            GetAllTzstatusServiceURL.Replace("{enforcement-point-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(EnforcementPointId, System.Globalization.CultureInfo.InvariantCulture)));
            request.Resource = GetAllTzstatusServiceURL.ToString();
            RestResponse<NSXTHeatMapTransportNodesAggregateStatusType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTHeatMapTransportNodesAggregateStatusType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Get operation to " + GetAllTzstatusServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTPnicBondStatusListResultType> GetPnicStatusesForTN(string SiteId, string EnforcementPointId, string NodeId, string? Status = null)
        {
            if (SiteId == null) { throw new System.ArgumentNullException("SiteId cannot be null"); }
            if (EnforcementPointId == null) { throw new System.ArgumentNullException("EnforcementPointId cannot be null"); }
            if (NodeId == null) { throw new System.ArgumentNullException("NodeId cannot be null"); }
            StringBuilder GetPnicStatusesForTNServiceURL = new StringBuilder("/infra/sites/{site-id}/enforcement-points/{enforcement-point-id}/host-transport-nodes/{node-id}/pnic-bond-status");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Get
            };
            GetPnicStatusesForTNServiceURL.Replace("{site-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(SiteId, System.Globalization.CultureInfo.InvariantCulture)));
            GetPnicStatusesForTNServiceURL.Replace("{enforcement-point-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(EnforcementPointId, System.Globalization.CultureInfo.InvariantCulture)));
            GetPnicStatusesForTNServiceURL.Replace("{node-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(NodeId, System.Globalization.CultureInfo.InvariantCulture)));
            if (Status != null) { request.AddQueryParameter("status", Status.ToString()); }
            request.Resource = GetPnicStatusesForTNServiceURL.ToString();
            RestResponse<NSXTPnicBondStatusListResultType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTPnicBondStatusListResultType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Get operation to " + GetPnicStatusesForTNServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task GetTnreportForATZ(string SiteId, string EnforcementPointId, string ZoneId, string? Source = null, string? Status = null)
        {
            if (SiteId == null) { throw new System.ArgumentNullException("SiteId cannot be null"); }
            if (EnforcementPointId == null) { throw new System.ArgumentNullException("EnforcementPointId cannot be null"); }
            if (ZoneId == null) { throw new System.ArgumentNullException("ZoneId cannot be null"); }
            StringBuilder GetTnreportForATZServiceURL = new StringBuilder("/infra/sites/{site-id}/enforcement-points/{enforcement-point-id}/transport-zones/{zone-id}/transport-node-status-report");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Get
            };
            GetTnreportForATZServiceURL.Replace("{site-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(SiteId, System.Globalization.CultureInfo.InvariantCulture)));
            GetTnreportForATZServiceURL.Replace("{enforcement-point-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(EnforcementPointId, System.Globalization.CultureInfo.InvariantCulture)));
            GetTnreportForATZServiceURL.Replace("{zone-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(ZoneId, System.Globalization.CultureInfo.InvariantCulture)));
            if (Source != null) { request.AddQueryParameter("source", Source.ToString()); }
            if (Status != null) { request.AddQueryParameter("status", Status.ToString()); }
            request.Resource = GetTnreportForATZServiceURL.ToString();
            RestResponse response = await restClient.ExecuteTaskAsyncWithPolicy(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Get operation to " + GetTnreportForATZServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTHeatMapTransportZoneStatusType> GetAllTnsStatus(string SiteId, string EnforcementPointId, string? NodeType = null)
        {
            if (SiteId == null) { throw new System.ArgumentNullException("SiteId cannot be null"); }
            if (EnforcementPointId == null) { throw new System.ArgumentNullException("EnforcementPointId cannot be null"); }
            StringBuilder GetAllTnsStatusServiceURL = new StringBuilder("/infra/sites/{site-id}/enforcement-points/{enforcement-point-id}/host-transport-nodes-aggstatus");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Get
            };
            GetAllTnsStatusServiceURL.Replace("{site-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(SiteId, System.Globalization.CultureInfo.InvariantCulture)));
            GetAllTnsStatusServiceURL.Replace("{enforcement-point-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(EnforcementPointId, System.Globalization.CultureInfo.InvariantCulture)));
            if (NodeType != null) { request.AddQueryParameter("node_type", NodeType.ToString()); }
            request.Resource = GetAllTnsStatusServiceURL.ToString();
            RestResponse<NSXTHeatMapTransportZoneStatusType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTHeatMapTransportZoneStatusType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Get operation to " + GetAllTnsStatusServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTTunnelListType> GetTunnels(string SiteId, string EnforcementPointId, string NodeId, string? BfdDiagnosticCode = null, string? Cursor = null, string? IncludedFields = null, long? PageSize = null, string? RemoteNodeId = null, bool? SortAscending = null, string? SortBy = null, string? Source = null, string? Status = null)
        {
            if (SiteId == null) { throw new System.ArgumentNullException("SiteId cannot be null"); }
            if (EnforcementPointId == null) { throw new System.ArgumentNullException("EnforcementPointId cannot be null"); }
            if (NodeId == null) { throw new System.ArgumentNullException("NodeId cannot be null"); }
            StringBuilder GetTunnelsServiceURL = new StringBuilder("/infra/sites/{site-id}/enforcement-points/{enforcement-point-id}/host-transport-nodes/{node-id}/tunnels");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Get
            };
            GetTunnelsServiceURL.Replace("{site-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(SiteId, System.Globalization.CultureInfo.InvariantCulture)));
            GetTunnelsServiceURL.Replace("{enforcement-point-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(EnforcementPointId, System.Globalization.CultureInfo.InvariantCulture)));
            GetTunnelsServiceURL.Replace("{node-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(NodeId, System.Globalization.CultureInfo.InvariantCulture)));
            if (BfdDiagnosticCode != null) { request.AddQueryParameter("bfd_diagnostic_code", BfdDiagnosticCode.ToString()); }
            if (Cursor != null) { request.AddQueryParameter("cursor", Cursor.ToString()); }
            if (IncludedFields != null) { request.AddQueryParameter("included_fields", IncludedFields.ToString()); }
            if (PageSize != null) { request.AddQueryParameter("page_size", PageSize.ToString()); }
            if (RemoteNodeId != null) { request.AddQueryParameter("remote_node_id", RemoteNodeId.ToString()); }
            if (SortAscending != null) { request.AddQueryParameter("sort_ascending", SortAscending.ToString()); }
            if (SortBy != null) { request.AddQueryParameter("sort_by", SortBy.ToString()); }
            if (Source != null) { request.AddQueryParameter("source", Source.ToString()); }
            if (Status != null) { request.AddQueryParameter("status", Status.ToString()); }
            request.Resource = GetTunnelsServiceURL.ToString();
            RestResponse<NSXTTunnelListType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTTunnelListType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Get operation to " + GetTunnelsServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTTransportNodeStatusListResultType> ListTnstatusForTZ(string SiteId, string EnforcementPointId, string ZoneId, string? Cursor = null, string? IncludedFields = null, long? PageSize = null, bool? SortAscending = null, string? SortBy = null, string? Source = null, string? Status = null)
        {
            if (SiteId == null) { throw new System.ArgumentNullException("SiteId cannot be null"); }
            if (EnforcementPointId == null) { throw new System.ArgumentNullException("EnforcementPointId cannot be null"); }
            if (ZoneId == null) { throw new System.ArgumentNullException("ZoneId cannot be null"); }
            StringBuilder ListTnstatusForTZServiceURL = new StringBuilder("/infra/sites/{site-id}/enforcement-points/{enforcement-point-id}/transport-zones/{zone-id}/transport-node-status");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Get
            };
            ListTnstatusForTZServiceURL.Replace("{site-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(SiteId, System.Globalization.CultureInfo.InvariantCulture)));
            ListTnstatusForTZServiceURL.Replace("{enforcement-point-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(EnforcementPointId, System.Globalization.CultureInfo.InvariantCulture)));
            ListTnstatusForTZServiceURL.Replace("{zone-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(ZoneId, System.Globalization.CultureInfo.InvariantCulture)));
            if (Cursor != null) { request.AddQueryParameter("cursor", Cursor.ToString()); }
            if (IncludedFields != null) { request.AddQueryParameter("included_fields", IncludedFields.ToString()); }
            if (PageSize != null) { request.AddQueryParameter("page_size", PageSize.ToString()); }
            if (SortAscending != null) { request.AddQueryParameter("sort_ascending", SortAscending.ToString()); }
            if (SortBy != null) { request.AddQueryParameter("sort_by", SortBy.ToString()); }
            if (Source != null) { request.AddQueryParameter("source", Source.ToString()); }
            if (Status != null) { request.AddQueryParameter("status", Status.ToString()); }
            request.Resource = ListTnstatusForTZServiceURL.ToString();
            RestResponse<NSXTTransportNodeStatusListResultType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTTransportNodeStatusListResultType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Get operation to " + ListTnstatusForTZServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTTnHyperbusStatusType> GetTnHyperbusStatus(string SiteId, string EnforcementPointId, string NodeId)
        {
            if (SiteId == null) { throw new System.ArgumentNullException("SiteId cannot be null"); }
            if (EnforcementPointId == null) { throw new System.ArgumentNullException("EnforcementPointId cannot be null"); }
            if (NodeId == null) { throw new System.ArgumentNullException("NodeId cannot be null"); }
            StringBuilder GetTnHyperbusStatusServiceURL = new StringBuilder("/infra/sites/{site-id}/enforcement-points/{enforcement-point-id}/host-transport-nodes/{node-id}/hyperbus-status");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Get
            };
            GetTnHyperbusStatusServiceURL.Replace("{site-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(SiteId, System.Globalization.CultureInfo.InvariantCulture)));
            GetTnHyperbusStatusServiceURL.Replace("{enforcement-point-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(EnforcementPointId, System.Globalization.CultureInfo.InvariantCulture)));
            GetTnHyperbusStatusServiceURL.Replace("{node-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(NodeId, System.Globalization.CultureInfo.InvariantCulture)));
            request.Resource = GetTnHyperbusStatusServiceURL.ToString();
            RestResponse<NSXTTnHyperbusStatusType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTTnHyperbusStatusType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Get operation to " + GetTnHyperbusStatusServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTTransportNodeStatusListResultType> ListHostTnstatus(string SiteId, string EnforcementPointId, string? Cursor = null, string? IncludedFields = null, long? PageSize = null, bool? SortAscending = null, string? SortBy = null, string? Source = null, string? Status = null)
        {
            if (SiteId == null) { throw new System.ArgumentNullException("SiteId cannot be null"); }
            if (EnforcementPointId == null) { throw new System.ArgumentNullException("EnforcementPointId cannot be null"); }
            StringBuilder ListHostTnstatusServiceURL = new StringBuilder("/infra/sites/{site-id}/enforcement-points/{enforcement-point-id}/host-transport-nodes-status");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Get
            };
            ListHostTnstatusServiceURL.Replace("{site-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(SiteId, System.Globalization.CultureInfo.InvariantCulture)));
            ListHostTnstatusServiceURL.Replace("{enforcement-point-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(EnforcementPointId, System.Globalization.CultureInfo.InvariantCulture)));
            if (Cursor != null) { request.AddQueryParameter("cursor", Cursor.ToString()); }
            if (IncludedFields != null) { request.AddQueryParameter("included_fields", IncludedFields.ToString()); }
            if (PageSize != null) { request.AddQueryParameter("page_size", PageSize.ToString()); }
            if (SortAscending != null) { request.AddQueryParameter("sort_ascending", SortAscending.ToString()); }
            if (SortBy != null) { request.AddQueryParameter("sort_by", SortBy.ToString()); }
            if (Source != null) { request.AddQueryParameter("source", Source.ToString()); }
            if (Status != null) { request.AddQueryParameter("status", Status.ToString()); }
            request.Resource = ListHostTnstatusServiceURL.ToString();
            RestResponse<NSXTTransportNodeStatusListResultType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTTransportNodeStatusListResultType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Get operation to " + ListHostTnstatusServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTTransportNodeStatusType> GetHostTnstatus(string SiteId, string EnforcementPointId, string NodeId, string? Source = null)
        {
            if (SiteId == null) { throw new System.ArgumentNullException("SiteId cannot be null"); }
            if (EnforcementPointId == null) { throw new System.ArgumentNullException("EnforcementPointId cannot be null"); }
            if (NodeId == null) { throw new System.ArgumentNullException("NodeId cannot be null"); }
            StringBuilder GetHostTnstatusServiceURL = new StringBuilder("/infra/sites/{site-id}/enforcement-points/{enforcement-point-id}/host-transport-nodes/{node-id}/status");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Get
            };
            GetHostTnstatusServiceURL.Replace("{site-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(SiteId, System.Globalization.CultureInfo.InvariantCulture)));
            GetHostTnstatusServiceURL.Replace("{enforcement-point-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(EnforcementPointId, System.Globalization.CultureInfo.InvariantCulture)));
            GetHostTnstatusServiceURL.Replace("{node-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(NodeId, System.Globalization.CultureInfo.InvariantCulture)));
            if (Source != null) { request.AddQueryParameter("source", Source.ToString()); }
            request.Resource = GetHostTnstatusServiceURL.ToString();
            RestResponse<NSXTTransportNodeStatusType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTTransportNodeStatusType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Get operation to " + GetHostTnstatusServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTTnNodeAgentStatusListResultType> GetTnContainerAgentStatus(string SiteId, string EnforcementPointId, string NodeId, string? Cursor = null, string? IncludedFields = null, long? PageSize = null, bool? SortAscending = null, string? SortBy = null)
        {
            if (SiteId == null) { throw new System.ArgumentNullException("SiteId cannot be null"); }
            if (EnforcementPointId == null) { throw new System.ArgumentNullException("EnforcementPointId cannot be null"); }
            if (NodeId == null) { throw new System.ArgumentNullException("NodeId cannot be null"); }
            StringBuilder GetTnContainerAgentStatusServiceURL = new StringBuilder("/infra/sites/{site-id}/enforcement-points/{enforcement-point-id}/host-transport-nodes/{node-id}/node-agent-status");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Get
            };
            GetTnContainerAgentStatusServiceURL.Replace("{site-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(SiteId, System.Globalization.CultureInfo.InvariantCulture)));
            GetTnContainerAgentStatusServiceURL.Replace("{enforcement-point-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(EnforcementPointId, System.Globalization.CultureInfo.InvariantCulture)));
            GetTnContainerAgentStatusServiceURL.Replace("{node-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(NodeId, System.Globalization.CultureInfo.InvariantCulture)));
            if (Cursor != null) { request.AddQueryParameter("cursor", Cursor.ToString()); }
            if (IncludedFields != null) { request.AddQueryParameter("included_fields", IncludedFields.ToString()); }
            if (PageSize != null) { request.AddQueryParameter("page_size", PageSize.ToString()); }
            if (SortAscending != null) { request.AddQueryParameter("sort_ascending", SortAscending.ToString()); }
            if (SortBy != null) { request.AddQueryParameter("sort_by", SortBy.ToString()); }
            request.Resource = GetTnContainerAgentStatusServiceURL.ToString();
            RestResponse<NSXTTnNodeAgentStatusListResultType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTTnNodeAgentStatusListResultType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Get operation to " + GetTnContainerAgentStatusServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
    }
}
