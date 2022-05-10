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
    public class InventoryCmObj
    {
        private RestClient restClient;
        private int retry;
        private int timeout;
        private CancellationToken cancellationToken;

        public InventoryCmObj(RestClient Client, CancellationToken _cancellationToken, int _timeout, int _retry)
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
        public async Task<NSXTComputeManagerStatusType> ReadComputeManagerStatus(string ComputeManagerId)
        {
            if (ComputeManagerId == null) { throw new System.ArgumentNullException("ComputeManagerId cannot be null"); }
            StringBuilder ReadComputeManagerStatusServiceURL = new StringBuilder("/fabric/compute-managers/{compute-manager-id}/status");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Get
            };
            ReadComputeManagerStatusServiceURL.Replace("{compute-manager-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(ComputeManagerId, System.Globalization.CultureInfo.InvariantCulture)));
            request.Resource = ReadComputeManagerStatusServiceURL.ToString();
            RestResponse<NSXTComputeManagerStatusType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTComputeManagerStatusType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Get operation to " + ReadComputeManagerStatusServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTComputeCollectionListResultType> ListComputeCollections(string? CmLocalId = null, string? Cursor = null, string? DiscoveredNodeId = null, string? DisplayName = null, string? ExternalId = null, string? IncludedFields = null, string? NodeId = null, string? OriginId = null, string? OriginType = null, string? OwnerId = null, long? PageSize = null, bool? SortAscending = null, string? SortBy = null)
        {
            StringBuilder ListComputeCollectionsServiceURL = new StringBuilder("/fabric/compute-collections");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Get
            };
            if (CmLocalId != null) { request.AddQueryParameter("cm_local_id", CmLocalId.ToString()); }
            if (Cursor != null) { request.AddQueryParameter("cursor", Cursor.ToString()); }
            if (DiscoveredNodeId != null) { request.AddQueryParameter("discovered_node_id", DiscoveredNodeId.ToString()); }
            if (DisplayName != null) { request.AddQueryParameter("display_name", DisplayName.ToString()); }
            if (ExternalId != null) { request.AddQueryParameter("external_id", ExternalId.ToString()); }
            if (IncludedFields != null) { request.AddQueryParameter("included_fields", IncludedFields.ToString()); }
            if (NodeId != null) { request.AddQueryParameter("node_id", NodeId.ToString()); }
            if (OriginId != null) { request.AddQueryParameter("origin_id", OriginId.ToString()); }
            if (OriginType != null) { request.AddQueryParameter("origin_type", OriginType.ToString()); }
            if (OwnerId != null) { request.AddQueryParameter("owner_id", OwnerId.ToString()); }
            if (PageSize != null) { request.AddQueryParameter("page_size", PageSize.ToString()); }
            if (SortAscending != null) { request.AddQueryParameter("sort_ascending", SortAscending.ToString()); }
            if (SortBy != null) { request.AddQueryParameter("sort_by", SortBy.ToString()); }
            request.Resource = ListComputeCollectionsServiceURL.ToString();
            RestResponse<NSXTComputeCollectionListResultType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTComputeCollectionListResultType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Get operation to " + ListComputeCollectionsServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task PerformActionOnComputeCollection(string CcExtId, string? Action = null)
        {
            if (CcExtId == null) { throw new System.ArgumentNullException("CcExtId cannot be null"); }
            StringBuilder PerformActionOnComputeCollectionServiceURL = new StringBuilder("/fabric/compute-collections/{cc-ext-id}");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Post
            };
            PerformActionOnComputeCollectionServiceURL.Replace("{cc-ext-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(CcExtId, System.Globalization.CultureInfo.InvariantCulture)));
            if (Action != null) { request.AddQueryParameter("action", Action.ToString()); }
            request.Resource = PerformActionOnComputeCollectionServiceURL.ToString();
            RestResponse response = await restClient.ExecuteTaskAsyncWithPolicy(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Post operation to " + PerformActionOnComputeCollectionServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTComputeCollectionType> ReadComputeCollection(string CcExtId)
        {
            if (CcExtId == null) { throw new System.ArgumentNullException("CcExtId cannot be null"); }
            StringBuilder ReadComputeCollectionServiceURL = new StringBuilder("/fabric/compute-collections/{cc-ext-id}");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Get
            };
            ReadComputeCollectionServiceURL.Replace("{cc-ext-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(CcExtId, System.Globalization.CultureInfo.InvariantCulture)));
            request.Resource = ReadComputeCollectionServiceURL.ToString();
            RestResponse<NSXTComputeCollectionType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTComputeCollectionType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Get operation to " + ReadComputeCollectionServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTDiscoveredNodeType> ReadDiscoveredNode(string NodeExtId)
        {
            if (NodeExtId == null) { throw new System.ArgumentNullException("NodeExtId cannot be null"); }
            StringBuilder ReadDiscoveredNodeServiceURL = new StringBuilder("/fabric/discovered-nodes/{node-ext-id}");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Get
            };
            ReadDiscoveredNodeServiceURL.Replace("{node-ext-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(NodeExtId, System.Globalization.CultureInfo.InvariantCulture)));
            request.Resource = ReadDiscoveredNodeServiceURL.ToString();
            RestResponse<NSXTDiscoveredNodeType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTDiscoveredNodeType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Get operation to " + ReadDiscoveredNodeServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTComputeManagerType> AddComputeManager(NSXTComputeManagerType ComputeManager)
        {
            if (ComputeManager == null) { throw new System.ArgumentNullException("ComputeManager cannot be null"); }
            StringBuilder AddComputeManagerServiceURL = new StringBuilder("/fabric/compute-managers");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Post
            };
            request.AddJsonBody(ComputeManager);
            request.Resource = AddComputeManagerServiceURL.ToString();
            RestResponse<NSXTComputeManagerType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTComputeManagerType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Post operation to " + AddComputeManagerServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTComputeManagerListResultType> ListComputeManagers(string? Cursor = null, string? IncludedFields = null, string? OriginType = null, long? PageSize = null, string? Server = null, bool? SortAscending = null, string? SortBy = null)
        {
            StringBuilder ListComputeManagersServiceURL = new StringBuilder("/fabric/compute-managers");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Get
            };
            if (Cursor != null) { request.AddQueryParameter("cursor", Cursor.ToString()); }
            if (IncludedFields != null) { request.AddQueryParameter("included_fields", IncludedFields.ToString()); }
            if (OriginType != null) { request.AddQueryParameter("origin_type", OriginType.ToString()); }
            if (PageSize != null) { request.AddQueryParameter("page_size", PageSize.ToString()); }
            if (Server != null) { request.AddQueryParameter("server", Server.ToString()); }
            if (SortAscending != null) { request.AddQueryParameter("sort_ascending", SortAscending.ToString()); }
            if (SortBy != null) { request.AddQueryParameter("sort_by", SortBy.ToString()); }
            request.Resource = ListComputeManagersServiceURL.ToString();
            RestResponse<NSXTComputeManagerListResultType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTComputeManagerListResultType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Get operation to " + ListComputeManagersServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTComputeCollectionNetworkInterfacesListResultType> ListComputeCollectionPhysicalNetworkInterfaces(string CcExtId)
        {
            if (CcExtId == null) { throw new System.ArgumentNullException("CcExtId cannot be null"); }
            StringBuilder ListComputeCollectionPhysicalNetworkInterfacesServiceURL = new StringBuilder("/fabric/compute-collections/{cc-ext-id}/network/physical-interfaces");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Get
            };
            ListComputeCollectionPhysicalNetworkInterfacesServiceURL.Replace("{cc-ext-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(CcExtId, System.Globalization.CultureInfo.InvariantCulture)));
            request.Resource = ListComputeCollectionPhysicalNetworkInterfacesServiceURL.ToString();
            RestResponse<NSXTComputeCollectionNetworkInterfacesListResultType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTComputeCollectionNetworkInterfacesListResultType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Get operation to " + ListComputeCollectionPhysicalNetworkInterfacesServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTConfigurationStateType> GetComputeManagerState(string ComputeManagerId)
        {
            if (ComputeManagerId == null) { throw new System.ArgumentNullException("ComputeManagerId cannot be null"); }
            StringBuilder GetComputeManagerStateServiceURL = new StringBuilder("/fabric/compute-managers/{compute-manager-id}/state");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Get
            };
            GetComputeManagerStateServiceURL.Replace("{compute-manager-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(ComputeManagerId, System.Globalization.CultureInfo.InvariantCulture)));
            request.Resource = GetComputeManagerStateServiceURL.ToString();
            RestResponse<NSXTConfigurationStateType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTConfigurationStateType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Get operation to " + GetComputeManagerStateServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTVirtualSwitchListResultType> ListVirtualSwitches(string? CmLocalId = null, string? Cursor = null, string? DiscoveredNodeId = null, string? DisplayName = null, string? ExternalId = null, string? IncludedFields = null, string? OriginId = null, long? PageSize = null, bool? SortAscending = null, string? SortBy = null, string? Uuid = null)
        {
            StringBuilder ListVirtualSwitchesServiceURL = new StringBuilder("/fabric/virtual-switches");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Get
            };
            if (CmLocalId != null) { request.AddQueryParameter("cm_local_id", CmLocalId.ToString()); }
            if (Cursor != null) { request.AddQueryParameter("cursor", Cursor.ToString()); }
            if (DiscoveredNodeId != null) { request.AddQueryParameter("discovered_node_id", DiscoveredNodeId.ToString()); }
            if (DisplayName != null) { request.AddQueryParameter("display_name", DisplayName.ToString()); }
            if (ExternalId != null) { request.AddQueryParameter("external_id", ExternalId.ToString()); }
            if (IncludedFields != null) { request.AddQueryParameter("included_fields", IncludedFields.ToString()); }
            if (OriginId != null) { request.AddQueryParameter("origin_id", OriginId.ToString()); }
            if (PageSize != null) { request.AddQueryParameter("page_size", PageSize.ToString()); }
            if (SortAscending != null) { request.AddQueryParameter("sort_ascending", SortAscending.ToString()); }
            if (SortBy != null) { request.AddQueryParameter("sort_by", SortBy.ToString()); }
            if (Uuid != null) { request.AddQueryParameter("uuid", Uuid.ToString()); }
            request.Resource = ListVirtualSwitchesServiceURL.ToString();
            RestResponse<NSXTVirtualSwitchListResultType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTVirtualSwitchListResultType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Get operation to " + ListVirtualSwitchesServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTComputeManagerType> UpdateComputeManager(string ComputeManagerId, NSXTComputeManagerType ComputeManager)
        {
            if (ComputeManagerId == null) { throw new System.ArgumentNullException("ComputeManagerId cannot be null"); }
            if (ComputeManager == null) { throw new System.ArgumentNullException("ComputeManager cannot be null"); }
            StringBuilder UpdateComputeManagerServiceURL = new StringBuilder("/fabric/compute-managers/{compute-manager-id}");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Put
            };
            UpdateComputeManagerServiceURL.Replace("{compute-manager-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(ComputeManagerId, System.Globalization.CultureInfo.InvariantCulture)));
            request.AddJsonBody(ComputeManager);
            request.Resource = UpdateComputeManagerServiceURL.ToString();
            RestResponse<NSXTComputeManagerType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTComputeManagerType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Put operation to " + UpdateComputeManagerServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task DeleteComputeManager(string ComputeManagerId)
        {
            if (ComputeManagerId == null) { throw new System.ArgumentNullException("ComputeManagerId cannot be null"); }
            StringBuilder DeleteComputeManagerServiceURL = new StringBuilder("/fabric/compute-managers/{compute-manager-id}");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Delete
            };
            DeleteComputeManagerServiceURL.Replace("{compute-manager-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(ComputeManagerId, System.Globalization.CultureInfo.InvariantCulture)));
            request.Resource = DeleteComputeManagerServiceURL.ToString();
            RestResponse response = await restClient.ExecuteTaskAsyncWithPolicy(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Delete operation to " + DeleteComputeManagerServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTComputeManagerType> ReadComputeManager(string ComputeManagerId)
        {
            if (ComputeManagerId == null) { throw new System.ArgumentNullException("ComputeManagerId cannot be null"); }
            StringBuilder ReadComputeManagerServiceURL = new StringBuilder("/fabric/compute-managers/{compute-manager-id}");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Get
            };
            ReadComputeManagerServiceURL.Replace("{compute-manager-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(ComputeManagerId, System.Globalization.CultureInfo.InvariantCulture)));
            request.Resource = ReadComputeManagerServiceURL.ToString();
            RestResponse<NSXTComputeManagerType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTComputeManagerType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Get operation to " + ReadComputeManagerServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTDiscoveredNodeListResultType> ListDiscoveredNodes(string? CmLocalId = null, string? Cursor = null, string? DisplayName = null, string? ExternalId = null, string? HasParent = null, string? IncludedFields = null, string? IpAddress = null, string? NodeId = null, string? NodeType = null, string? OriginId = null, long? PageSize = null, string? ParentComputeCollection = null, bool? SortAscending = null, string? SortBy = null)
        {
            StringBuilder ListDiscoveredNodesServiceURL = new StringBuilder("/fabric/discovered-nodes");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Get
            };
            if (CmLocalId != null) { request.AddQueryParameter("cm_local_id", CmLocalId.ToString()); }
            if (Cursor != null) { request.AddQueryParameter("cursor", Cursor.ToString()); }
            if (DisplayName != null) { request.AddQueryParameter("display_name", DisplayName.ToString()); }
            if (ExternalId != null) { request.AddQueryParameter("external_id", ExternalId.ToString()); }
            if (HasParent != null) { request.AddQueryParameter("has_parent", HasParent.ToString()); }
            if (IncludedFields != null) { request.AddQueryParameter("included_fields", IncludedFields.ToString()); }
            if (IpAddress != null) { request.AddQueryParameter("ip_address", IpAddress.ToString()); }
            if (NodeId != null) { request.AddQueryParameter("node_id", NodeId.ToString()); }
            if (NodeType != null) { request.AddQueryParameter("node_type", NodeType.ToString()); }
            if (OriginId != null) { request.AddQueryParameter("origin_id", OriginId.ToString()); }
            if (PageSize != null) { request.AddQueryParameter("page_size", PageSize.ToString()); }
            if (ParentComputeCollection != null) { request.AddQueryParameter("parent_compute_collection", ParentComputeCollection.ToString()); }
            if (SortAscending != null) { request.AddQueryParameter("sort_ascending", SortAscending.ToString()); }
            if (SortBy != null) { request.AddQueryParameter("sort_by", SortBy.ToString()); }
            request.Resource = ListDiscoveredNodesServiceURL.ToString();
            RestResponse<NSXTDiscoveredNodeListResultType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTDiscoveredNodeListResultType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Get operation to " + ListDiscoveredNodesServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
    }
}
