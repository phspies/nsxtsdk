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
    public class LogicalRouter
    {
        private RestClient restClient;
        private int retry;
        private int timeout;
        private CancellationToken cancellationToken;

        public LogicalRouter(RestClient Client, CancellationToken _cancellationToken, int _timeout, int _retry)
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
        public async Task<NSXTLogicalRouterType> CreateLogicalRouter(NSXTLogicalRouterType LogicalRouter)
        {
            if (LogicalRouter == null) { throw new System.ArgumentNullException("LogicalRouter cannot be null"); }
            StringBuilder CreateLogicalRouterServiceURL = new StringBuilder("/logical-routers");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Post
            };
            request.AddJsonBody(LogicalRouter);
            request.Resource = CreateLogicalRouterServiceURL.ToString();
            RestResponse<NSXTLogicalRouterType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTLogicalRouterType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Post operation to " + CreateLogicalRouterServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTLogicalRouterListResultType> ListLogicalRouters(string? Cursor = null, string? IncludedFields = null, long? PageSize = null, string? RouterType = null, bool? SortAscending = null, string? SortBy = null, string? VrfsOnLogicalRouterId = null)
        {
            StringBuilder ListLogicalRoutersServiceURL = new StringBuilder("/logical-routers");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Get
            };
            if (Cursor != null) { request.AddQueryParameter("cursor", Cursor.ToString()); }
            if (IncludedFields != null) { request.AddQueryParameter("included_fields", IncludedFields.ToString()); }
            if (PageSize != null) { request.AddQueryParameter("page_size", PageSize.ToString()); }
            if (RouterType != null) { request.AddQueryParameter("router_type", RouterType.ToString()); }
            if (SortAscending != null) { request.AddQueryParameter("sort_ascending", SortAscending.ToString()); }
            if (SortBy != null) { request.AddQueryParameter("sort_by", SortBy.ToString()); }
            if (VrfsOnLogicalRouterId != null) { request.AddQueryParameter("vrfs_on_logical_router_id", VrfsOnLogicalRouterId.ToString()); }
            request.Resource = ListLogicalRoutersServiceURL.ToString();
            RestResponse<NSXTLogicalRouterListResultType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTLogicalRouterListResultType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Get operation to " + ListLogicalRoutersServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task ReProcessLogicalRouter(string LogicalRouterId)
        {
            if (LogicalRouterId == null) { throw new System.ArgumentNullException("LogicalRouterId cannot be null"); }
            StringBuilder ReProcessLogicalRouterServiceURL = new StringBuilder("/logical-routers/{logical-router-id}?action=reprocess");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Post
            };
            ReProcessLogicalRouterServiceURL.Replace("{logical-router-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(LogicalRouterId, System.Globalization.CultureInfo.InvariantCulture)));
            request.Resource = ReProcessLogicalRouterServiceURL.ToString();
            RestResponse response = await restClient.ExecuteTaskAsyncWithPolicy(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Post operation to " + ReProcessLogicalRouterServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<string> ReadDebugInfo(string LogicalRouterId)
        {
            if (LogicalRouterId == null) { throw new System.ArgumentNullException("LogicalRouterId cannot be null"); }
            StringBuilder ReadDebugInfoServiceURL = new StringBuilder("/logical-routers/{logical-router-id}/debug-info?format=text");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Get
            };
            ReadDebugInfoServiceURL.Replace("{logical-router-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(LogicalRouterId, System.Globalization.CultureInfo.InvariantCulture)));
            request.Resource = ReadDebugInfoServiceURL.ToString();
            RestResponse<string> response = await restClient.ExecuteTaskAsyncWithPolicy<string>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Get operation to " + ReadDebugInfoServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTLogicalRouterStateType> GetLogicalRouterState(string LogicalRouterId, long? BarrierId = null, string? RequestId = null)
        {
            if (LogicalRouterId == null) { throw new System.ArgumentNullException("LogicalRouterId cannot be null"); }
            StringBuilder GetLogicalRouterStateServiceURL = new StringBuilder("/logical-routers/{logical-router-id}/state");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Get
            };
            GetLogicalRouterStateServiceURL.Replace("{logical-router-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(LogicalRouterId, System.Globalization.CultureInfo.InvariantCulture)));
            if (BarrierId != null) { request.AddQueryParameter("barrier_id", BarrierId.ToString()); }
            if (RequestId != null) { request.AddQueryParameter("request_id", RequestId.ToString()); }
            request.Resource = GetLogicalRouterStateServiceURL.ToString();
            RestResponse<NSXTLogicalRouterStateType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTLogicalRouterStateType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Get operation to " + GetLogicalRouterStateServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTLogicalRouterType> ReAllocateServiceRouters(string LogicalRouterId, NSXTServiceRouterAllocationConfigType ServiceRouterAllocationConfig)
        {
            if (LogicalRouterId == null) { throw new System.ArgumentNullException("LogicalRouterId cannot be null"); }
            if (ServiceRouterAllocationConfig == null) { throw new System.ArgumentNullException("ServiceRouterAllocationConfig cannot be null"); }
            StringBuilder ReAllocateServiceRoutersServiceURL = new StringBuilder("/logical-routers/{logical-router-id}?action=reallocate");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Post
            };
            ReAllocateServiceRoutersServiceURL.Replace("{logical-router-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(LogicalRouterId, System.Globalization.CultureInfo.InvariantCulture)));
            request.AddJsonBody(ServiceRouterAllocationConfig);
            request.Resource = ReAllocateServiceRoutersServiceURL.ToString();
            RestResponse<NSXTLogicalRouterType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTLogicalRouterType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Post operation to " + ReAllocateServiceRoutersServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTLogicalRouterType> UpdateLogicalRouter(string LogicalRouterId, NSXTLogicalRouterType LogicalRouter)
        {
            if (LogicalRouterId == null) { throw new System.ArgumentNullException("LogicalRouterId cannot be null"); }
            if (LogicalRouter == null) { throw new System.ArgumentNullException("LogicalRouter cannot be null"); }
            StringBuilder UpdateLogicalRouterServiceURL = new StringBuilder("/logical-routers/{logical-router-id}");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Put
            };
            UpdateLogicalRouterServiceURL.Replace("{logical-router-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(LogicalRouterId, System.Globalization.CultureInfo.InvariantCulture)));
            request.AddJsonBody(LogicalRouter);
            request.Resource = UpdateLogicalRouterServiceURL.ToString();
            RestResponse<NSXTLogicalRouterType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTLogicalRouterType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Put operation to " + UpdateLogicalRouterServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTLogicalRouterType> ReadLogicalRouter(string LogicalRouterId)
        {
            if (LogicalRouterId == null) { throw new System.ArgumentNullException("LogicalRouterId cannot be null"); }
            StringBuilder ReadLogicalRouterServiceURL = new StringBuilder("/logical-routers/{logical-router-id}");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Get
            };
            ReadLogicalRouterServiceURL.Replace("{logical-router-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(LogicalRouterId, System.Globalization.CultureInfo.InvariantCulture)));
            request.Resource = ReadLogicalRouterServiceURL.ToString();
            RestResponse<NSXTLogicalRouterType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTLogicalRouterType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Get operation to " + ReadLogicalRouterServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task DeleteLogicalRouter(string LogicalRouterId, bool? CascadeDeleteLinkedPorts = null, bool? Force = null)
        {
            if (LogicalRouterId == null) { throw new System.ArgumentNullException("LogicalRouterId cannot be null"); }
            StringBuilder DeleteLogicalRouterServiceURL = new StringBuilder("/logical-routers/{logical-router-id}");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Delete
            };
            DeleteLogicalRouterServiceURL.Replace("{logical-router-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(LogicalRouterId, System.Globalization.CultureInfo.InvariantCulture)));
            if (CascadeDeleteLinkedPorts != null) { request.AddQueryParameter("cascade_delete_linked_ports", CascadeDeleteLinkedPorts.ToString()); }
            if (Force != null) { request.AddQueryParameter("force", Force.ToString()); }
            request.Resource = DeleteLogicalRouterServiceURL.ToString();
            RestResponse response = await restClient.ExecuteTaskAsyncWithPolicy(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Delete operation to " + DeleteLogicalRouterServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTLogicalServiceRouterClusterStateType> GetLogicalServiceRouterClusterState(string LogicalRouterId, long? BarrierId = null, string? RequestId = null)
        {
            if (LogicalRouterId == null) { throw new System.ArgumentNullException("LogicalRouterId cannot be null"); }
            StringBuilder GetLogicalServiceRouterClusterStateServiceURL = new StringBuilder("/logical-routers/{logical-router-id}/service-cluster/state");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Get
            };
            GetLogicalServiceRouterClusterStateServiceURL.Replace("{logical-router-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(LogicalRouterId, System.Globalization.CultureInfo.InvariantCulture)));
            if (BarrierId != null) { request.AddQueryParameter("barrier_id", BarrierId.ToString()); }
            if (RequestId != null) { request.AddQueryParameter("request_id", RequestId.ToString()); }
            request.Resource = GetLogicalServiceRouterClusterStateServiceURL.ToString();
            RestResponse<NSXTLogicalServiceRouterClusterStateType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTLogicalServiceRouterClusterStateType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Get operation to " + GetLogicalServiceRouterClusterStateServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
    }
}
