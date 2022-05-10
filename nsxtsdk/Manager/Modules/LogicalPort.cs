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
    public class LogicalPort
    {
        private RestClient restClient;
        private int retry;
        private int timeout;
        private CancellationToken cancellationToken;

        public LogicalPort(RestClient Client, CancellationToken _cancellationToken, int _timeout, int _retry)
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
        public async Task<NSXTLogicalPortType> CreateLogicalPort(NSXTLogicalPortType LogicalPort)
        {
            if (LogicalPort == null) { throw new System.ArgumentNullException("LogicalPort cannot be null"); }
            StringBuilder CreateLogicalPortServiceURL = new StringBuilder("/logical-ports");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Post
            };
            request.AddJsonBody(LogicalPort);
            request.Resource = CreateLogicalPortServiceURL.ToString();
            RestResponse<NSXTLogicalPortType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTLogicalPortType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Post operation to " + CreateLogicalPortServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTLogicalPortListResultType> ListLogicalPorts(string? AttachmentId = null, string? AttachmentType = null, string? BridgeClusterId = null, bool? ContainerPortsOnly = null, string? Cursor = null, bool? Diagnostic = null, string? IncludedFields = null, string? LogicalSwitchId = null, long? PageSize = null, string? ParentVifId = null, bool? SortAscending = null, string? SortBy = null, string? SwitchingProfileId = null, string? TransportNodeId = null, string? TransportZoneId = null)
        {
            StringBuilder ListLogicalPortsServiceURL = new StringBuilder("/logical-ports");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Get
            };
            if (AttachmentId != null) { request.AddQueryParameter("attachment_id", AttachmentId.ToString()); }
            if (AttachmentType != null) { request.AddQueryParameter("attachment_type", AttachmentType.ToString()); }
            if (BridgeClusterId != null) { request.AddQueryParameter("bridge_cluster_id", BridgeClusterId.ToString()); }
            if (ContainerPortsOnly != null) { request.AddQueryParameter("container_ports_only", ContainerPortsOnly.ToString()); }
            if (Cursor != null) { request.AddQueryParameter("cursor", Cursor.ToString()); }
            if (Diagnostic != null) { request.AddQueryParameter("diagnostic", Diagnostic.ToString()); }
            if (IncludedFields != null) { request.AddQueryParameter("included_fields", IncludedFields.ToString()); }
            if (LogicalSwitchId != null) { request.AddQueryParameter("logical_switch_id", LogicalSwitchId.ToString()); }
            if (PageSize != null) { request.AddQueryParameter("page_size", PageSize.ToString()); }
            if (ParentVifId != null) { request.AddQueryParameter("parent_vif_id", ParentVifId.ToString()); }
            if (SortAscending != null) { request.AddQueryParameter("sort_ascending", SortAscending.ToString()); }
            if (SortBy != null) { request.AddQueryParameter("sort_by", SortBy.ToString()); }
            if (SwitchingProfileId != null) { request.AddQueryParameter("switching_profile_id", SwitchingProfileId.ToString()); }
            if (TransportNodeId != null) { request.AddQueryParameter("transport_node_id", TransportNodeId.ToString()); }
            if (TransportZoneId != null) { request.AddQueryParameter("transport_zone_id", TransportZoneId.ToString()); }
            request.Resource = ListLogicalPortsServiceURL.ToString();
            RestResponse<NSXTLogicalPortListResultType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTLogicalPortListResultType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Get operation to " + ListLogicalPortsServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTLogicalPortStateType> GetLogicalPortState(string LportId)
        {
            if (LportId == null) { throw new System.ArgumentNullException("LportId cannot be null"); }
            StringBuilder GetLogicalPortStateServiceURL = new StringBuilder("/logical-ports/{lport-id}/state");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Get
            };
            GetLogicalPortStateServiceURL.Replace("{lport-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(LportId, System.Globalization.CultureInfo.InvariantCulture)));
            request.Resource = GetLogicalPortStateServiceURL.ToString();
            RestResponse<NSXTLogicalPortStateType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTLogicalPortStateType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Get operation to " + GetLogicalPortStateServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTLogicalPortType> UpdateLogicalPort(string LportId, NSXTLogicalPortType LogicalPort)
        {
            if (LportId == null) { throw new System.ArgumentNullException("LportId cannot be null"); }
            if (LogicalPort == null) { throw new System.ArgumentNullException("LogicalPort cannot be null"); }
            StringBuilder UpdateLogicalPortServiceURL = new StringBuilder("/logical-ports/{lport-id}");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Put
            };
            UpdateLogicalPortServiceURL.Replace("{lport-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(LportId, System.Globalization.CultureInfo.InvariantCulture)));
            request.AddJsonBody(LogicalPort);
            request.Resource = UpdateLogicalPortServiceURL.ToString();
            RestResponse<NSXTLogicalPortType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTLogicalPortType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Put operation to " + UpdateLogicalPortServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTLogicalPortType> GetLogicalPort(string LportId)
        {
            if (LportId == null) { throw new System.ArgumentNullException("LportId cannot be null"); }
            StringBuilder GetLogicalPortServiceURL = new StringBuilder("/logical-ports/{lport-id}");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Get
            };
            GetLogicalPortServiceURL.Replace("{lport-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(LportId, System.Globalization.CultureInfo.InvariantCulture)));
            request.Resource = GetLogicalPortServiceURL.ToString();
            RestResponse<NSXTLogicalPortType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTLogicalPortType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Get operation to " + GetLogicalPortServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task DeleteLogicalPort(string LportId, bool? Detach = null)
        {
            if (LportId == null) { throw new System.ArgumentNullException("LportId cannot be null"); }
            StringBuilder DeleteLogicalPortServiceURL = new StringBuilder("/logical-ports/{lport-id}");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Delete
            };
            DeleteLogicalPortServiceURL.Replace("{lport-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(LportId, System.Globalization.CultureInfo.InvariantCulture)));
            if (Detach != null) { request.AddQueryParameter("detach", Detach.ToString()); }
            request.Resource = DeleteLogicalPortServiceURL.ToString();
            RestResponse response = await restClient.ExecuteTaskAsyncWithPolicy(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Delete operation to " + DeleteLogicalPortServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            
        }
    }
}
