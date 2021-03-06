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
    public class LogicalRouterPorts
    {
        private RestClient restClient;
        private int retry;
        private int timeout;
        private CancellationToken cancellationToken;

        public LogicalRouterPorts(RestClient Client, CancellationToken _cancellationToken, int _timeout, int _retry)
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
        public async Task<NSXTLogicalRouterPortStateType> GetLogicalRouterPortState(string LogicalRouterPortId, long? BarrierId = null, string? RequestId = null)
        {
            if (LogicalRouterPortId == null) { throw new System.ArgumentNullException("LogicalRouterPortId cannot be null"); }
            StringBuilder GetLogicalRouterPortStateServiceURL = new StringBuilder("/logical-router-ports/{logical-router-port-id}/state");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Get
            };
            GetLogicalRouterPortStateServiceURL.Replace("{logical-router-port-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(LogicalRouterPortId, System.Globalization.CultureInfo.InvariantCulture)));
            if (BarrierId != null) { request.AddQueryParameter("barrier_id", BarrierId.ToString()); }
            if (RequestId != null) { request.AddQueryParameter("request_id", RequestId.ToString()); }
            request.Resource = GetLogicalRouterPortStateServiceURL.ToString();
            RestResponse<NSXTLogicalRouterPortStateType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTLogicalRouterPortStateType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Get operation to " + GetLogicalRouterPortStateServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTLogicalRouterPortType> CreateLogicalRouterPort(NSXTLogicalRouterPortType LogicalRouterPort)
        {
            if (LogicalRouterPort == null) { throw new System.ArgumentNullException("LogicalRouterPort cannot be null"); }
            StringBuilder CreateLogicalRouterPortServiceURL = new StringBuilder("/logical-router-ports");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Post
            };
            request.AddJsonBody(LogicalRouterPort);
            request.Resource = CreateLogicalRouterPortServiceURL.ToString();
            RestResponse<NSXTLogicalRouterPortType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTLogicalRouterPortType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Post operation to " + CreateLogicalRouterPortServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTLogicalRouterPortListResultType> ListLogicalRouterPorts(string? Cursor = null, string? IncludedFields = null, string? LogicalRouterId = null, string? LogicalSwitchId = null, long? PageSize = null, string? ResourceType = null, bool? SortAscending = null, string? SortBy = null)
        {
            StringBuilder ListLogicalRouterPortsServiceURL = new StringBuilder("/logical-router-ports");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Get
            };
            if (Cursor != null) { request.AddQueryParameter("cursor", Cursor.ToString()); }
            if (IncludedFields != null) { request.AddQueryParameter("included_fields", IncludedFields.ToString()); }
            if (LogicalRouterId != null) { request.AddQueryParameter("logical_router_id", LogicalRouterId.ToString()); }
            if (LogicalSwitchId != null) { request.AddQueryParameter("logical_switch_id", LogicalSwitchId.ToString()); }
            if (PageSize != null) { request.AddQueryParameter("page_size", PageSize.ToString()); }
            if (ResourceType != null) { request.AddQueryParameter("resource_type", ResourceType.ToString()); }
            if (SortAscending != null) { request.AddQueryParameter("sort_ascending", SortAscending.ToString()); }
            if (SortBy != null) { request.AddQueryParameter("sort_by", SortBy.ToString()); }
            request.Resource = ListLogicalRouterPortsServiceURL.ToString();
            RestResponse<NSXTLogicalRouterPortListResultType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTLogicalRouterPortListResultType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Get operation to " + ListLogicalRouterPortsServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTLogicalRouterPortType> UpdateLogicalRouterPort(string LogicalRouterPortId, NSXTLogicalRouterPortType LogicalRouterPort)
        {
            if (LogicalRouterPortId == null) { throw new System.ArgumentNullException("LogicalRouterPortId cannot be null"); }
            if (LogicalRouterPort == null) { throw new System.ArgumentNullException("LogicalRouterPort cannot be null"); }
            StringBuilder UpdateLogicalRouterPortServiceURL = new StringBuilder("/logical-router-ports/{logical-router-port-id}");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Put
            };
            UpdateLogicalRouterPortServiceURL.Replace("{logical-router-port-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(LogicalRouterPortId, System.Globalization.CultureInfo.InvariantCulture)));
            request.AddJsonBody(LogicalRouterPort);
            request.Resource = UpdateLogicalRouterPortServiceURL.ToString();
            RestResponse<NSXTLogicalRouterPortType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTLogicalRouterPortType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Put operation to " + UpdateLogicalRouterPortServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTLogicalRouterPortType> ReadLogicalRouterPort(string LogicalRouterPortId)
        {
            if (LogicalRouterPortId == null) { throw new System.ArgumentNullException("LogicalRouterPortId cannot be null"); }
            StringBuilder ReadLogicalRouterPortServiceURL = new StringBuilder("/logical-router-ports/{logical-router-port-id}");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Get
            };
            ReadLogicalRouterPortServiceURL.Replace("{logical-router-port-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(LogicalRouterPortId, System.Globalization.CultureInfo.InvariantCulture)));
            request.Resource = ReadLogicalRouterPortServiceURL.ToString();
            RestResponse<NSXTLogicalRouterPortType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTLogicalRouterPortType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Get operation to " + ReadLogicalRouterPortServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task DeleteLogicalRouterPort(string LogicalRouterPortId, bool? CascadeDeleteLinkedPorts = null, bool? Force = null)
        {
            if (LogicalRouterPortId == null) { throw new System.ArgumentNullException("LogicalRouterPortId cannot be null"); }
            StringBuilder DeleteLogicalRouterPortServiceURL = new StringBuilder("/logical-router-ports/{logical-router-port-id}");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Delete
            };
            DeleteLogicalRouterPortServiceURL.Replace("{logical-router-port-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(LogicalRouterPortId, System.Globalization.CultureInfo.InvariantCulture)));
            if (CascadeDeleteLinkedPorts != null) { request.AddQueryParameter("cascade_delete_linked_ports", CascadeDeleteLinkedPorts.ToString()); }
            if (Force != null) { request.AddQueryParameter("force", Force.ToString()); }
            request.Resource = DeleteLogicalRouterPortServiceURL.ToString();
            RestResponse response = await restClient.ExecuteTaskAsyncWithPolicy(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Delete operation to " + DeleteLogicalRouterPortServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            
        }
    }
}
