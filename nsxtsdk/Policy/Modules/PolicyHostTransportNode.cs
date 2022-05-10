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
    public class PolicyHostTransportNode
    {
        private RestClient restClient;
        private int retry;
        private int timeout;
        private CancellationToken cancellationToken;

        public PolicyHostTransportNode(RestClient Client, CancellationToken _cancellationToken, int _timeout, int _retry)
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
        public async Task ResyncHostTransportNode(string SiteId, string EnforcementpointId, string HostTransportNodeId)
        {
            if (SiteId == null) { throw new System.ArgumentNullException("SiteId cannot be null"); }
            if (EnforcementpointId == null) { throw new System.ArgumentNullException("EnforcementpointId cannot be null"); }
            if (HostTransportNodeId == null) { throw new System.ArgumentNullException("HostTransportNodeId cannot be null"); }
            StringBuilder ResyncHostTransportNodeServiceURL = new StringBuilder("/infra/sites/{site-id}/enforcement-points/{enforcementpoint-id}/host-transport-nodes/{host-transport-node-id}?action=resync_host_config");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Post
            };
            ResyncHostTransportNodeServiceURL.Replace("{site-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(SiteId, System.Globalization.CultureInfo.InvariantCulture)));
            ResyncHostTransportNodeServiceURL.Replace("{enforcementpoint-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(EnforcementpointId, System.Globalization.CultureInfo.InvariantCulture)));
            ResyncHostTransportNodeServiceURL.Replace("{host-transport-node-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(HostTransportNodeId, System.Globalization.CultureInfo.InvariantCulture)));
            request.Resource = ResyncHostTransportNodeServiceURL.ToString();
            RestResponse response = await restClient.ExecuteTaskAsyncWithPolicy(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Post operation to " + ResyncHostTransportNodeServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTDiscoveredVifStateListResultType> ListVdsVifsOnTransportNode(string SiteId, string EnforcementpointId, string HostTransportNodeId, string? Cursor = null, string? HostSwitchId = null, string? IncludedFields = null, long? PageSize = null, string? SegmentId = null, bool? SortAscending = null, string? SortBy = null)
        {
            if (SiteId == null) { throw new System.ArgumentNullException("SiteId cannot be null"); }
            if (EnforcementpointId == null) { throw new System.ArgumentNullException("EnforcementpointId cannot be null"); }
            if (HostTransportNodeId == null) { throw new System.ArgumentNullException("HostTransportNodeId cannot be null"); }
            StringBuilder ListVdsVifsOnTransportNodeServiceURL = new StringBuilder("/infra/sites/{site-id}/enforcement-points/{enforcementpoint-id}/host-transport-nodes/{host-transport-node-id}/discovered-vifs");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Get
            };
            ListVdsVifsOnTransportNodeServiceURL.Replace("{site-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(SiteId, System.Globalization.CultureInfo.InvariantCulture)));
            ListVdsVifsOnTransportNodeServiceURL.Replace("{enforcementpoint-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(EnforcementpointId, System.Globalization.CultureInfo.InvariantCulture)));
            ListVdsVifsOnTransportNodeServiceURL.Replace("{host-transport-node-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(HostTransportNodeId, System.Globalization.CultureInfo.InvariantCulture)));
            if (Cursor != null) { request.AddQueryParameter("cursor", Cursor.ToString()); }
            if (HostSwitchId != null) { request.AddQueryParameter("host_switch_id", HostSwitchId.ToString()); }
            if (IncludedFields != null) { request.AddQueryParameter("included_fields", IncludedFields.ToString()); }
            if (PageSize != null) { request.AddQueryParameter("page_size", PageSize.ToString()); }
            if (SegmentId != null) { request.AddQueryParameter("segment_id", SegmentId.ToString()); }
            if (SortAscending != null) { request.AddQueryParameter("sort_ascending", SortAscending.ToString()); }
            if (SortBy != null) { request.AddQueryParameter("sort_by", SortBy.ToString()); }
            request.Resource = ListVdsVifsOnTransportNodeServiceURL.ToString();
            RestResponse<NSXTDiscoveredVifStateListResultType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTDiscoveredVifStateListResultType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Get operation to " + ListVdsVifsOnTransportNodeServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTTransportNodeStateListResultType> ListHostTransportNodesByState(string SiteId, string EnforcementpointId, string? MmState = null, string? Status = null, string? VtepIp = null)
        {
            if (SiteId == null) { throw new System.ArgumentNullException("SiteId cannot be null"); }
            if (EnforcementpointId == null) { throw new System.ArgumentNullException("EnforcementpointId cannot be null"); }
            StringBuilder ListHostTransportNodesByStateServiceURL = new StringBuilder("/infra/sites/{site-id}/enforcement-points/{enforcementpoint-id}/host-transport-nodes/state");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Get
            };
            ListHostTransportNodesByStateServiceURL.Replace("{site-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(SiteId, System.Globalization.CultureInfo.InvariantCulture)));
            ListHostTransportNodesByStateServiceURL.Replace("{enforcementpoint-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(EnforcementpointId, System.Globalization.CultureInfo.InvariantCulture)));
            if (MmState != null) { request.AddQueryParameter("mm_state", MmState.ToString()); }
            if (Status != null) { request.AddQueryParameter("status", Status.ToString()); }
            if (VtepIp != null) { request.AddQueryParameter("vtep_ip", VtepIp.ToString()); }
            request.Resource = ListHostTransportNodesByStateServiceURL.ToString();
            RestResponse<NSXTTransportNodeStateListResultType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTTransportNodeStateListResultType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Get operation to " + ListHostTransportNodesByStateServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTHostTransportNodeListResultType> ListHostTransportNodes(string SiteId, string EnforcementpointId, string? Cursor = null, string? DiscoveredNodeId = null, bool? InMaintenanceMode = null, string? IncludedFields = null, string? NodeIp = null, string? NodeTypes = null, long? PageSize = null, bool? SortAscending = null, string? SortBy = null, string? TransportZonePath = null)
        {
            if (SiteId == null) { throw new System.ArgumentNullException("SiteId cannot be null"); }
            if (EnforcementpointId == null) { throw new System.ArgumentNullException("EnforcementpointId cannot be null"); }
            StringBuilder ListHostTransportNodesServiceURL = new StringBuilder("/infra/sites/{site-id}/enforcement-points/{enforcementpoint-id}/host-transport-nodes");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Get
            };
            ListHostTransportNodesServiceURL.Replace("{site-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(SiteId, System.Globalization.CultureInfo.InvariantCulture)));
            ListHostTransportNodesServiceURL.Replace("{enforcementpoint-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(EnforcementpointId, System.Globalization.CultureInfo.InvariantCulture)));
            if (Cursor != null) { request.AddQueryParameter("cursor", Cursor.ToString()); }
            if (DiscoveredNodeId != null) { request.AddQueryParameter("discovered_node_id", DiscoveredNodeId.ToString()); }
            if (InMaintenanceMode != null) { request.AddQueryParameter("in_maintenance_mode", InMaintenanceMode.ToString()); }
            if (IncludedFields != null) { request.AddQueryParameter("included_fields", IncludedFields.ToString()); }
            if (NodeIp != null) { request.AddQueryParameter("node_ip", NodeIp.ToString()); }
            if (NodeTypes != null) { request.AddQueryParameter("node_types", NodeTypes.ToString()); }
            if (PageSize != null) { request.AddQueryParameter("page_size", PageSize.ToString()); }
            if (SortAscending != null) { request.AddQueryParameter("sort_ascending", SortAscending.ToString()); }
            if (SortBy != null) { request.AddQueryParameter("sort_by", SortBy.ToString()); }
            if (TransportZonePath != null) { request.AddQueryParameter("transport_zone_path", TransportZonePath.ToString()); }
            request.Resource = ListHostTransportNodesServiceURL.ToString();
            RestResponse<NSXTHostTransportNodeListResultType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTHostTransportNodeListResultType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Get operation to " + ListHostTransportNodesServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTTransportNodeStateType> GetHostTransportNodeState(string SiteId, string EnforcementpointId, string HostTransportNodeId)
        {
            if (SiteId == null) { throw new System.ArgumentNullException("SiteId cannot be null"); }
            if (EnforcementpointId == null) { throw new System.ArgumentNullException("EnforcementpointId cannot be null"); }
            if (HostTransportNodeId == null) { throw new System.ArgumentNullException("HostTransportNodeId cannot be null"); }
            StringBuilder GetHostTransportNodeStateServiceURL = new StringBuilder("/infra/sites/{site-id}/enforcement-points/{enforcementpoint-id}/host-transport-nodes/{host-transport-node-id}/state");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Get
            };
            GetHostTransportNodeStateServiceURL.Replace("{site-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(SiteId, System.Globalization.CultureInfo.InvariantCulture)));
            GetHostTransportNodeStateServiceURL.Replace("{enforcementpoint-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(EnforcementpointId, System.Globalization.CultureInfo.InvariantCulture)));
            GetHostTransportNodeStateServiceURL.Replace("{host-transport-node-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(HostTransportNodeId, System.Globalization.CultureInfo.InvariantCulture)));
            request.Resource = GetHostTransportNodeStateServiceURL.ToString();
            RestResponse<NSXTTransportNodeStateType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTTransportNodeStateType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Get operation to " + GetHostTransportNodeStateServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTHostTransportNodeType> CreateOrUpdateHostTransportNode(string SiteId, string EnforcementpointId, string HostTransportNodeId, NSXTHostTransportNodeType HostTransportNode, string? EsxMgmtIfMigrationDest = null, string? IfId = null, string? PingIp = null, bool? SkipValidation = null, string? Vnic = null, string? VnicMigrationDest = null)
        {
            if (SiteId == null) { throw new System.ArgumentNullException("SiteId cannot be null"); }
            if (EnforcementpointId == null) { throw new System.ArgumentNullException("EnforcementpointId cannot be null"); }
            if (HostTransportNodeId == null) { throw new System.ArgumentNullException("HostTransportNodeId cannot be null"); }
            if (HostTransportNode == null) { throw new System.ArgumentNullException("HostTransportNode cannot be null"); }
            StringBuilder CreateOrUpdateHostTransportNodeServiceURL = new StringBuilder("/infra/sites/{site-id}/enforcement-points/{enforcementpoint-id}/host-transport-nodes/{host-transport-node-id}");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Put
            };
            CreateOrUpdateHostTransportNodeServiceURL.Replace("{site-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(SiteId, System.Globalization.CultureInfo.InvariantCulture)));
            CreateOrUpdateHostTransportNodeServiceURL.Replace("{enforcementpoint-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(EnforcementpointId, System.Globalization.CultureInfo.InvariantCulture)));
            CreateOrUpdateHostTransportNodeServiceURL.Replace("{host-transport-node-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(HostTransportNodeId, System.Globalization.CultureInfo.InvariantCulture)));
            request.AddJsonBody(HostTransportNode);
            if (EsxMgmtIfMigrationDest != null) { request.AddQueryParameter("esx_mgmt_if_migration_dest", EsxMgmtIfMigrationDest.ToString()); }
            if (IfId != null) { request.AddQueryParameter("if_id", IfId.ToString()); }
            if (PingIp != null) { request.AddQueryParameter("ping_ip", PingIp.ToString()); }
            if (SkipValidation != null) { request.AddQueryParameter("skip_validation", SkipValidation.ToString()); }
            if (Vnic != null) { request.AddQueryParameter("vnic", Vnic.ToString()); }
            if (VnicMigrationDest != null) { request.AddQueryParameter("vnic_migration_dest", VnicMigrationDest.ToString()); }
            request.Resource = CreateOrUpdateHostTransportNodeServiceURL.ToString();
            RestResponse<NSXTHostTransportNodeType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTHostTransportNodeType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Put operation to " + CreateOrUpdateHostTransportNodeServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task DeleteHostTransportNode(string SiteId, string EnforcementpointId, string HostTransportNodeId, bool? Force = null, bool? UnprepareHost = null)
        {
            if (SiteId == null) { throw new System.ArgumentNullException("SiteId cannot be null"); }
            if (EnforcementpointId == null) { throw new System.ArgumentNullException("EnforcementpointId cannot be null"); }
            if (HostTransportNodeId == null) { throw new System.ArgumentNullException("HostTransportNodeId cannot be null"); }
            StringBuilder DeleteHostTransportNodeServiceURL = new StringBuilder("/infra/sites/{site-id}/enforcement-points/{enforcementpoint-id}/host-transport-nodes/{host-transport-node-id}");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Delete
            };
            DeleteHostTransportNodeServiceURL.Replace("{site-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(SiteId, System.Globalization.CultureInfo.InvariantCulture)));
            DeleteHostTransportNodeServiceURL.Replace("{enforcementpoint-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(EnforcementpointId, System.Globalization.CultureInfo.InvariantCulture)));
            DeleteHostTransportNodeServiceURL.Replace("{host-transport-node-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(HostTransportNodeId, System.Globalization.CultureInfo.InvariantCulture)));
            if (Force != null) { request.AddQueryParameter("force", Force.ToString()); }
            if (UnprepareHost != null) { request.AddQueryParameter("unprepare_host", UnprepareHost.ToString()); }
            request.Resource = DeleteHostTransportNodeServiceURL.ToString();
            RestResponse response = await restClient.ExecuteTaskAsyncWithPolicy(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Delete operation to " + DeleteHostTransportNodeServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task PatchHostTransportNode(string SiteId, string EnforcementpointId, string HostTransportNodeId, NSXTHostTransportNodeType HostTransportNode, string? EsxMgmtIfMigrationDest = null, string? IfId = null, string? PingIp = null, bool? SkipValidation = null, string? Vnic = null, string? VnicMigrationDest = null)
        {
            if (SiteId == null) { throw new System.ArgumentNullException("SiteId cannot be null"); }
            if (EnforcementpointId == null) { throw new System.ArgumentNullException("EnforcementpointId cannot be null"); }
            if (HostTransportNodeId == null) { throw new System.ArgumentNullException("HostTransportNodeId cannot be null"); }
            if (HostTransportNode == null) { throw new System.ArgumentNullException("HostTransportNode cannot be null"); }
            StringBuilder PatchHostTransportNodeServiceURL = new StringBuilder("/infra/sites/{site-id}/enforcement-points/{enforcementpoint-id}/host-transport-nodes/{host-transport-node-id}");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Patch
            };
            PatchHostTransportNodeServiceURL.Replace("{site-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(SiteId, System.Globalization.CultureInfo.InvariantCulture)));
            PatchHostTransportNodeServiceURL.Replace("{enforcementpoint-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(EnforcementpointId, System.Globalization.CultureInfo.InvariantCulture)));
            PatchHostTransportNodeServiceURL.Replace("{host-transport-node-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(HostTransportNodeId, System.Globalization.CultureInfo.InvariantCulture)));
            request.AddJsonBody(HostTransportNode);
            if (EsxMgmtIfMigrationDest != null) { request.AddQueryParameter("esx_mgmt_if_migration_dest", EsxMgmtIfMigrationDest.ToString()); }
            if (IfId != null) { request.AddQueryParameter("if_id", IfId.ToString()); }
            if (PingIp != null) { request.AddQueryParameter("ping_ip", PingIp.ToString()); }
            if (SkipValidation != null) { request.AddQueryParameter("skip_validation", SkipValidation.ToString()); }
            if (Vnic != null) { request.AddQueryParameter("vnic", Vnic.ToString()); }
            if (VnicMigrationDest != null) { request.AddQueryParameter("vnic_migration_dest", VnicMigrationDest.ToString()); }
            request.Resource = PatchHostTransportNodeServiceURL.ToString();
            RestResponse response = await restClient.ExecuteTaskAsyncWithPolicy(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Patch operation to " + PatchHostTransportNodeServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTHostTransportNodeType> GetHostTransportNode(string SiteId, string EnforcementpointId, string HostTransportNodeId)
        {
            if (SiteId == null) { throw new System.ArgumentNullException("SiteId cannot be null"); }
            if (EnforcementpointId == null) { throw new System.ArgumentNullException("EnforcementpointId cannot be null"); }
            if (HostTransportNodeId == null) { throw new System.ArgumentNullException("HostTransportNodeId cannot be null"); }
            StringBuilder GetHostTransportNodeServiceURL = new StringBuilder("/infra/sites/{site-id}/enforcement-points/{enforcementpoint-id}/host-transport-nodes/{host-transport-node-id}");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Get
            };
            GetHostTransportNodeServiceURL.Replace("{site-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(SiteId, System.Globalization.CultureInfo.InvariantCulture)));
            GetHostTransportNodeServiceURL.Replace("{enforcementpoint-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(EnforcementpointId, System.Globalization.CultureInfo.InvariantCulture)));
            GetHostTransportNodeServiceURL.Replace("{host-transport-node-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(HostTransportNodeId, System.Globalization.CultureInfo.InvariantCulture)));
            request.Resource = GetHostTransportNodeServiceURL.ToString();
            RestResponse<NSXTHostTransportNodeType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTHostTransportNodeType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Get operation to " + GetHostTransportNodeServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTSoftwareModuleResultType> GetFabricNodeModulesOfHostTransportNode(string SiteId, string EnforcementpointId, string HostTransportNodeId)
        {
            if (SiteId == null) { throw new System.ArgumentNullException("SiteId cannot be null"); }
            if (EnforcementpointId == null) { throw new System.ArgumentNullException("EnforcementpointId cannot be null"); }
            if (HostTransportNodeId == null) { throw new System.ArgumentNullException("HostTransportNodeId cannot be null"); }
            StringBuilder GetFabricNodeModulesOfHostTransportNodeServiceURL = new StringBuilder("/infra/sites/{site-id}/enforcement-points/{enforcementpoint-id}/host-transport-nodes/{host-transport-node-id}/modules");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Get
            };
            GetFabricNodeModulesOfHostTransportNodeServiceURL.Replace("{site-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(SiteId, System.Globalization.CultureInfo.InvariantCulture)));
            GetFabricNodeModulesOfHostTransportNodeServiceURL.Replace("{enforcementpoint-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(EnforcementpointId, System.Globalization.CultureInfo.InvariantCulture)));
            GetFabricNodeModulesOfHostTransportNodeServiceURL.Replace("{host-transport-node-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(HostTransportNodeId, System.Globalization.CultureInfo.InvariantCulture)));
            request.Resource = GetFabricNodeModulesOfHostTransportNodeServiceURL.ToString();
            RestResponse<NSXTSoftwareModuleResultType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTSoftwareModuleResultType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Get operation to " + GetFabricNodeModulesOfHostTransportNodeServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task RestoreParentClusterConfigurationOnHostTransportNode(string SiteId, string EnforcementpointId, string HostTransportNodeId)
        {
            if (SiteId == null) { throw new System.ArgumentNullException("SiteId cannot be null"); }
            if (EnforcementpointId == null) { throw new System.ArgumentNullException("EnforcementpointId cannot be null"); }
            if (HostTransportNodeId == null) { throw new System.ArgumentNullException("HostTransportNodeId cannot be null"); }
            StringBuilder RestoreParentClusterConfigurationOnHostTransportNodeServiceURL = new StringBuilder("/infra/sites/{site-id}/enforcement-points/{enforcementpoint-id}/host-transport-nodes/{host-transport-node-id}?action=restore_cluster_config");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Put
            };
            RestoreParentClusterConfigurationOnHostTransportNodeServiceURL.Replace("{site-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(SiteId, System.Globalization.CultureInfo.InvariantCulture)));
            RestoreParentClusterConfigurationOnHostTransportNodeServiceURL.Replace("{enforcementpoint-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(EnforcementpointId, System.Globalization.CultureInfo.InvariantCulture)));
            RestoreParentClusterConfigurationOnHostTransportNodeServiceURL.Replace("{host-transport-node-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(HostTransportNodeId, System.Globalization.CultureInfo.InvariantCulture)));
            request.Resource = RestoreParentClusterConfigurationOnHostTransportNodeServiceURL.ToString();
            RestResponse response = await restClient.ExecuteTaskAsyncWithPolicy(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Put operation to " + RestoreParentClusterConfigurationOnHostTransportNodeServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            
        }
    }
}
