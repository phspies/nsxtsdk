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
    public class TransportNodeLcm
    {
        private RestClient restClient;
        private int retry;
        private int timeout;
        private CancellationToken cancellationToken;

        public TransportNodeLcm(RestClient Client, CancellationToken _cancellationToken, int _timeout, int _retry)
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
        public async Task RefreshTransportNode(string TransportNodeId, bool? ReadOnly = null)
        {
            if (TransportNodeId == null) { throw new System.ArgumentNullException("TransportNodeId cannot be null"); }
            StringBuilder RefreshTransportNodeServiceURL = new StringBuilder("/transport-nodes/{transport-node-id}?action=refresh_node_configuration&resource_type=EdgeNode");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Post
            };
            RefreshTransportNodeServiceURL.Replace("{transport-node-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(TransportNodeId, System.Globalization.CultureInfo.InvariantCulture)));
            if (ReadOnly != null) { request.AddQueryParameter("read_only", ReadOnly.ToString()); }
            request.Resource = RefreshTransportNodeServiceURL.ToString();
            RestResponse response = await restClient.ExecuteTaskAsyncWithPolicy(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Post operation to " + RefreshTransportNodeServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTTransportNodeType> ReapplyTnprofileOnDiscoveredNode(string NodeExtId)
        {
            if (NodeExtId == null) { throw new System.ArgumentNullException("NodeExtId cannot be null"); }
            StringBuilder ReapplyTnprofileOnDiscoveredNodeServiceURL = new StringBuilder("/fabric/discovered-nodes/{node-ext-id}?action=reapply_cluster_config");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Post
            };
            ReapplyTnprofileOnDiscoveredNodeServiceURL.Replace("{node-ext-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(NodeExtId, System.Globalization.CultureInfo.InvariantCulture)));
            request.Resource = ReapplyTnprofileOnDiscoveredNodeServiceURL.ToString();
            RestResponse<NSXTTransportNodeType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTTransportNodeType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Post operation to " + ReapplyTnprofileOnDiscoveredNodeServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task RestartTransportNodeInventorySync(string TransportNodeId)
        {
            if (TransportNodeId == null) { throw new System.ArgumentNullException("TransportNodeId cannot be null"); }
            StringBuilder RestartTransportNodeInventorySyncServiceURL = new StringBuilder("/transport-nodes/{transport-node-id}?action=restart_inventory_sync");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Post
            };
            RestartTransportNodeInventorySyncServiceURL.Replace("{transport-node-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(TransportNodeId, System.Globalization.CultureInfo.InvariantCulture)));
            request.Resource = RestartTransportNodeInventorySyncServiceURL.ToString();
            RestResponse response = await restClient.ExecuteTaskAsyncWithPolicy(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Post operation to " + RestartTransportNodeInventorySyncServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTTransportNodeType> CreateTransportNodeForDiscoveredNode(string NodeExtId, NSXTTransportNodeType TransportNode)
        {
            if (NodeExtId == null) { throw new System.ArgumentNullException("NodeExtId cannot be null"); }
            if (TransportNode == null) { throw new System.ArgumentNullException("TransportNode cannot be null"); }
            StringBuilder CreateTransportNodeForDiscoveredNodeServiceURL = new StringBuilder("/fabric/discovered-nodes/{node-ext-id}?action=create_transport_node");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Post
            };
            CreateTransportNodeForDiscoveredNodeServiceURL.Replace("{node-ext-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(NodeExtId, System.Globalization.CultureInfo.InvariantCulture)));
            request.AddJsonBody(TransportNode);
            request.Resource = CreateTransportNodeForDiscoveredNodeServiceURL.ToString();
            RestResponse<NSXTTransportNodeType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTTransportNodeType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Post operation to " + CreateTransportNodeForDiscoveredNodeServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTNodeCapabilitiesResultType> ListTransportNodeCapabilities(string TransportNodeId)
        {
            if (TransportNodeId == null) { throw new System.ArgumentNullException("TransportNodeId cannot be null"); }
            StringBuilder ListTransportNodeCapabilitiesServiceURL = new StringBuilder("/transport-nodes/{transport-node-id}/capabilities");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Get
            };
            ListTransportNodeCapabilitiesServiceURL.Replace("{transport-node-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(TransportNodeId, System.Globalization.CultureInfo.InvariantCulture)));
            request.Resource = ListTransportNodeCapabilitiesServiceURL.ToString();
            RestResponse<NSXTNodeCapabilitiesResultType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTNodeCapabilitiesResultType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Get operation to " + ListTransportNodeCapabilitiesServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task ResyncTransportNode(string TransportnodeId)
        {
            if (TransportnodeId == null) { throw new System.ArgumentNullException("TransportnodeId cannot be null"); }
            StringBuilder ResyncTransportNodeServiceURL = new StringBuilder("/transport-nodes/{transportnode-id}?action=resync_host_config");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Post
            };
            ResyncTransportNodeServiceURL.Replace("{transportnode-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(TransportnodeId, System.Globalization.CultureInfo.InvariantCulture)));
            request.Resource = ResyncTransportNodeServiceURL.ToString();
            RestResponse response = await restClient.ExecuteTaskAsyncWithPolicy(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Post operation to " + ResyncTransportNodeServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task RestoreParentClusterConfiguration(string TransportNodeId)
        {
            if (TransportNodeId == null) { throw new System.ArgumentNullException("TransportNodeId cannot be null"); }
            StringBuilder RestoreParentClusterConfigurationServiceURL = new StringBuilder("/transport-nodes/{transport-node-id}?action=restore_cluster_config");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Post
            };
            RestoreParentClusterConfigurationServiceURL.Replace("{transport-node-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(TransportNodeId, System.Globalization.CultureInfo.InvariantCulture)));
            request.Resource = RestoreParentClusterConfigurationServiceURL.ToString();
            RestResponse response = await restClient.ExecuteTaskAsyncWithPolicy(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Post operation to " + RestoreParentClusterConfigurationServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTTransportNodeStateType> GetTransportNodeStateWithDeploymentInfo(string TransportNodeId)
        {
            if (TransportNodeId == null) { throw new System.ArgumentNullException("TransportNodeId cannot be null"); }
            StringBuilder GetTransportNodeStateWithDeploymentInfoServiceURL = new StringBuilder("/transport-nodes/{transport-node-id}/state");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Get
            };
            GetTransportNodeStateWithDeploymentInfoServiceURL.Replace("{transport-node-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(TransportNodeId, System.Globalization.CultureInfo.InvariantCulture)));
            request.Resource = GetTransportNodeStateWithDeploymentInfoServiceURL.ToString();
            RestResponse<NSXTTransportNodeStateType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTTransportNodeStateType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Get operation to " + GetTransportNodeStateWithDeploymentInfoServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTTransportNodeType> RedeployEdgeTransportNode(string NodeId, NSXTTransportNodeType TransportNode)
        {
            if (NodeId == null) { throw new System.ArgumentNullException("NodeId cannot be null"); }
            if (TransportNode == null) { throw new System.ArgumentNullException("TransportNode cannot be null"); }
            StringBuilder RedeployEdgeTransportNodeServiceURL = new StringBuilder("/transport-nodes/{node-id}?action=redeploy");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Post
            };
            RedeployEdgeTransportNodeServiceURL.Replace("{node-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(NodeId, System.Globalization.CultureInfo.InvariantCulture)));
            request.AddJsonBody(TransportNode);
            request.Resource = RedeployEdgeTransportNodeServiceURL.ToString();
            RestResponse<NSXTTransportNodeType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTTransportNodeType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Post operation to " + RedeployEdgeTransportNodeServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task EnableFlowCache(string TransportNodeId)
        {
            if (TransportNodeId == null) { throw new System.ArgumentNullException("TransportNodeId cannot be null"); }
            StringBuilder EnableFlowCacheServiceURL = new StringBuilder("/transport-nodes/{transport-node-id}?action=enable_flow_cache");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Post
            };
            EnableFlowCacheServiceURL.Replace("{transport-node-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(TransportNodeId, System.Globalization.CultureInfo.InvariantCulture)));
            request.Resource = EnableFlowCacheServiceURL.ToString();
            RestResponse response = await restClient.ExecuteTaskAsyncWithPolicy(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Post operation to " + EnableFlowCacheServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTTransportNodeType> UpdateTransportNodeWithDeploymentInfo(string TransportNodeId, NSXTTransportNodeType TransportNode, string? EsxMgmtIfMigrationDest = null, string? IfId = null, string? PingIp = null, bool? SkipValidation = null, string? Vnic = null, string? VnicMigrationDest = null)
        {
            if (TransportNodeId == null) { throw new System.ArgumentNullException("TransportNodeId cannot be null"); }
            if (TransportNode == null) { throw new System.ArgumentNullException("TransportNode cannot be null"); }
            StringBuilder UpdateTransportNodeWithDeploymentInfoServiceURL = new StringBuilder("/transport-nodes/{transport-node-id}");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Put
            };
            UpdateTransportNodeWithDeploymentInfoServiceURL.Replace("{transport-node-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(TransportNodeId, System.Globalization.CultureInfo.InvariantCulture)));
            request.AddJsonBody(TransportNode);
            if (EsxMgmtIfMigrationDest != null) { request.AddQueryParameter("esx_mgmt_if_migration_dest", EsxMgmtIfMigrationDest.ToString()); }
            if (IfId != null) { request.AddQueryParameter("if_id", IfId.ToString()); }
            if (PingIp != null) { request.AddQueryParameter("ping_ip", PingIp.ToString()); }
            if (SkipValidation != null) { request.AddQueryParameter("skip_validation", SkipValidation.ToString()); }
            if (Vnic != null) { request.AddQueryParameter("vnic", Vnic.ToString()); }
            if (VnicMigrationDest != null) { request.AddQueryParameter("vnic_migration_dest", VnicMigrationDest.ToString()); }
            request.Resource = UpdateTransportNodeWithDeploymentInfoServiceURL.ToString();
            RestResponse<NSXTTransportNodeType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTTransportNodeType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Put operation to " + UpdateTransportNodeWithDeploymentInfoServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task DeleteTransportNodeWithDeploymentInfo(string TransportNodeId, bool? Force = null, bool? UnprepareHost = null)
        {
            if (TransportNodeId == null) { throw new System.ArgumentNullException("TransportNodeId cannot be null"); }
            StringBuilder DeleteTransportNodeWithDeploymentInfoServiceURL = new StringBuilder("/transport-nodes/{transport-node-id}");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Delete
            };
            DeleteTransportNodeWithDeploymentInfoServiceURL.Replace("{transport-node-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(TransportNodeId, System.Globalization.CultureInfo.InvariantCulture)));
            if (Force != null) { request.AddQueryParameter("force", Force.ToString()); }
            if (UnprepareHost != null) { request.AddQueryParameter("unprepare_host", UnprepareHost.ToString()); }
            request.Resource = DeleteTransportNodeWithDeploymentInfoServiceURL.ToString();
            RestResponse response = await restClient.ExecuteTaskAsyncWithPolicy(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Delete operation to " + DeleteTransportNodeWithDeploymentInfoServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTTransportNodeType> GetTransportNodeWithDeploymentInfo(string TransportNodeId)
        {
            if (TransportNodeId == null) { throw new System.ArgumentNullException("TransportNodeId cannot be null"); }
            StringBuilder GetTransportNodeWithDeploymentInfoServiceURL = new StringBuilder("/transport-nodes/{transport-node-id}");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Get
            };
            GetTransportNodeWithDeploymentInfoServiceURL.Replace("{transport-node-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(TransportNodeId, System.Globalization.CultureInfo.InvariantCulture)));
            request.Resource = GetTransportNodeWithDeploymentInfoServiceURL.ToString();
            RestResponse<NSXTTransportNodeType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTTransportNodeType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Get operation to " + GetTransportNodeWithDeploymentInfoServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTTransportNodeType> CreateTransportNodeWithDeploymentInfo(NSXTTransportNodeType TransportNode)
        {
            if (TransportNode == null) { throw new System.ArgumentNullException("TransportNode cannot be null"); }
            StringBuilder CreateTransportNodeWithDeploymentInfoServiceURL = new StringBuilder("/transport-nodes");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Post
            };
            request.AddJsonBody(TransportNode);
            request.Resource = CreateTransportNodeWithDeploymentInfoServiceURL.ToString();
            RestResponse<NSXTTransportNodeType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTTransportNodeType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Post operation to " + CreateTransportNodeWithDeploymentInfoServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTTransportNodeListResultType> ListTransportNodesWithDeploymentInfo(string? Cursor = null, bool? InMaintenanceMode = null, string? IncludedFields = null, string? NodeId = null, string? NodeIp = null, string? NodeTypes = null, long? PageSize = null, bool? SortAscending = null, string? SortBy = null, string? TransportZoneId = null)
        {
            StringBuilder ListTransportNodesWithDeploymentInfoServiceURL = new StringBuilder("/transport-nodes");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Get
            };
            if (Cursor != null) { request.AddQueryParameter("cursor", Cursor.ToString()); }
            if (InMaintenanceMode != null) { request.AddQueryParameter("in_maintenance_mode", InMaintenanceMode.ToString()); }
            if (IncludedFields != null) { request.AddQueryParameter("included_fields", IncludedFields.ToString()); }
            if (NodeId != null) { request.AddQueryParameter("node_id", NodeId.ToString()); }
            if (NodeIp != null) { request.AddQueryParameter("node_ip", NodeIp.ToString()); }
            if (NodeTypes != null) { request.AddQueryParameter("node_types", NodeTypes.ToString()); }
            if (PageSize != null) { request.AddQueryParameter("page_size", PageSize.ToString()); }
            if (SortAscending != null) { request.AddQueryParameter("sort_ascending", SortAscending.ToString()); }
            if (SortBy != null) { request.AddQueryParameter("sort_by", SortBy.ToString()); }
            if (TransportZoneId != null) { request.AddQueryParameter("transport_zone_id", TransportZoneId.ToString()); }
            request.Resource = ListTransportNodesWithDeploymentInfoServiceURL.ToString();
            RestResponse<NSXTTransportNodeListResultType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTTransportNodeListResultType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Get operation to " + ListTransportNodesWithDeploymentInfoServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task DisableFlowCache(string TransportNodeId)
        {
            if (TransportNodeId == null) { throw new System.ArgumentNullException("TransportNodeId cannot be null"); }
            StringBuilder DisableFlowCacheServiceURL = new StringBuilder("/transport-nodes/{transport-node-id}?action=disable_flow_cache");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Post
            };
            DisableFlowCacheServiceURL.Replace("{transport-node-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(TransportNodeId, System.Globalization.CultureInfo.InvariantCulture)));
            request.Resource = DisableFlowCacheServiceURL.ToString();
            RestResponse response = await restClient.ExecuteTaskAsyncWithPolicy(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Post operation to " + DisableFlowCacheServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTSoftwareModuleResultType> GetFabricNodeModulesOfTransportNode(string NodeId)
        {
            if (NodeId == null) { throw new System.ArgumentNullException("NodeId cannot be null"); }
            StringBuilder GetFabricNodeModulesOfTransportNodeServiceURL = new StringBuilder("/transport-nodes/{node-id}/modules");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Get
            };
            GetFabricNodeModulesOfTransportNodeServiceURL.Replace("{node-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(NodeId, System.Globalization.CultureInfo.InvariantCulture)));
            request.Resource = GetFabricNodeModulesOfTransportNodeServiceURL.ToString();
            RestResponse<NSXTSoftwareModuleResultType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTSoftwareModuleResultType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Get operation to " + GetFabricNodeModulesOfTransportNodeServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTTransportNodeStateListResultType> ListTransportNodesByStateWithDeploymentInfo(string? MmState = null, string? Status = null, string? VtepIp = null)
        {
            StringBuilder ListTransportNodesByStateWithDeploymentInfoServiceURL = new StringBuilder("/transport-nodes/state");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Get
            };
            if (MmState != null) { request.AddQueryParameter("mm_state", MmState.ToString()); }
            if (Status != null) { request.AddQueryParameter("status", Status.ToString()); }
            if (VtepIp != null) { request.AddQueryParameter("vtep_ip", VtepIp.ToString()); }
            request.Resource = ListTransportNodesByStateWithDeploymentInfoServiceURL.ToString();
            RestResponse<NSXTTransportNodeStateListResultType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTTransportNodeStateListResultType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Get operation to " + ListTransportNodesByStateWithDeploymentInfoServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
    }
}
