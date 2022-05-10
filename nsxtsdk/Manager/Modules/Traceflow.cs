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
    public class Traceflow
    {
        private RestClient restClient;
        private int retry;
        private int timeout;
        private CancellationToken cancellationToken;

        public Traceflow(RestClient Client, CancellationToken _cancellationToken, int _timeout, int _retry)
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
        public async Task DeleteTraceflow(string TraceflowId)
        {
            if (TraceflowId == null) { throw new System.ArgumentNullException("TraceflowId cannot be null"); }
            StringBuilder DeleteTraceflowServiceURL = new StringBuilder("/traceflows/{traceflow-id}");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Delete
            };
            DeleteTraceflowServiceURL.Replace("{traceflow-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(TraceflowId, System.Globalization.CultureInfo.InvariantCulture)));
            request.Resource = DeleteTraceflowServiceURL.ToString();
            RestResponse response = await restClient.ExecuteTaskAsyncWithPolicy(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Delete operation to " + DeleteTraceflowServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTTraceflowType> GetTraceflow(string TraceflowId)
        {
            if (TraceflowId == null) { throw new System.ArgumentNullException("TraceflowId cannot be null"); }
            StringBuilder GetTraceflowServiceURL = new StringBuilder("/traceflows/{traceflow-id}");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Get
            };
            GetTraceflowServiceURL.Replace("{traceflow-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(TraceflowId, System.Globalization.CultureInfo.InvariantCulture)));
            request.Resource = GetTraceflowServiceURL.ToString();
            RestResponse<NSXTTraceflowType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTTraceflowType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Get operation to " + GetTraceflowServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTTraceflowType> CreateTraceflow(NSXTTraceflowRequestType TraceflowRequest)
        {
            if (TraceflowRequest == null) { throw new System.ArgumentNullException("TraceflowRequest cannot be null"); }
            StringBuilder CreateTraceflowServiceURL = new StringBuilder("/traceflows");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Post
            };
            request.AddJsonBody(TraceflowRequest);
            request.Resource = CreateTraceflowServiceURL.ToString();
            RestResponse<NSXTTraceflowType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTTraceflowType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Post operation to " + CreateTraceflowServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTTraceflowListResultType> ListTraceflows(string? Cursor = null, string? IncludedFields = null, string? LportId = null, long? PageSize = null, bool? SortAscending = null, string? SortBy = null)
        {
            StringBuilder ListTraceflowsServiceURL = new StringBuilder("/traceflows");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Get
            };
            if (Cursor != null) { request.AddQueryParameter("cursor", Cursor.ToString()); }
            if (IncludedFields != null) { request.AddQueryParameter("included_fields", IncludedFields.ToString()); }
            if (LportId != null) { request.AddQueryParameter("lport_id", LportId.ToString()); }
            if (PageSize != null) { request.AddQueryParameter("page_size", PageSize.ToString()); }
            if (SortAscending != null) { request.AddQueryParameter("sort_ascending", SortAscending.ToString()); }
            if (SortBy != null) { request.AddQueryParameter("sort_by", SortBy.ToString()); }
            request.Resource = ListTraceflowsServiceURL.ToString();
            RestResponse<NSXTTraceflowListResultType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTTraceflowListResultType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Get operation to " + ListTraceflowsServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTTraceflowObservationListResultType> GetTraceflowObservations(string TraceflowId, string? ComponentName = null, string? ComponentType = null, string? Cursor = null, string? IncludedFields = null, long? PageSize = null, string? ResourceType = null, bool? SortAscending = null, string? SortBy = null, string? TransportNodeName = null)
        {
            if (TraceflowId == null) { throw new System.ArgumentNullException("TraceflowId cannot be null"); }
            StringBuilder GetTraceflowObservationsServiceURL = new StringBuilder("/traceflows/{traceflow-id}/observations");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Get
            };
            GetTraceflowObservationsServiceURL.Replace("{traceflow-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(TraceflowId, System.Globalization.CultureInfo.InvariantCulture)));
            if (ComponentName != null) { request.AddQueryParameter("component_name", ComponentName.ToString()); }
            if (ComponentType != null) { request.AddQueryParameter("component_type", ComponentType.ToString()); }
            if (Cursor != null) { request.AddQueryParameter("cursor", Cursor.ToString()); }
            if (IncludedFields != null) { request.AddQueryParameter("included_fields", IncludedFields.ToString()); }
            if (PageSize != null) { request.AddQueryParameter("page_size", PageSize.ToString()); }
            if (ResourceType != null) { request.AddQueryParameter("resource_type", ResourceType.ToString()); }
            if (SortAscending != null) { request.AddQueryParameter("sort_ascending", SortAscending.ToString()); }
            if (SortBy != null) { request.AddQueryParameter("sort_by", SortBy.ToString()); }
            if (TransportNodeName != null) { request.AddQueryParameter("transport_node_name", TransportNodeName.ToString()); }
            request.Resource = GetTraceflowObservationsServiceURL.ToString();
            RestResponse<NSXTTraceflowObservationListResultType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTTraceflowObservationListResultType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Get operation to " + GetTraceflowObservationsServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
    }
}
