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
    public class LiveTrace
    {
        private RestClient restClient;
        private int retry;
        private int timeout;
        private CancellationToken cancellationToken;

        public LiveTrace(RestClient Client, CancellationToken _cancellationToken, int _timeout, int _retry)
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
        public async Task GetReversePktCapFileProxy(string LivetraceSessionId)
        {
            if (LivetraceSessionId == null) { throw new System.ArgumentNullException("LivetraceSessionId cannot be null"); }
            StringBuilder GetReversePktCapFileProxyServiceURL = new StringBuilder("/livetraces/{livetrace-session-id}/proxy/reverse/capturefile");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Get
            };
            GetReversePktCapFileProxyServiceURL.Replace("{livetrace-session-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(LivetraceSessionId, System.Globalization.CultureInfo.InvariantCulture)));
            request.Resource = GetReversePktCapFileProxyServiceURL.ToString();
            RestResponse response = await restClient.ExecuteTaskAsyncWithPolicy(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Get operation to " + GetReversePktCapFileProxyServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTLiveTraceStatusType> CreateLiveTrace(NSXTLiveTraceRequestType LiveTraceRequest)
        {
            if (LiveTraceRequest == null) { throw new System.ArgumentNullException("LiveTraceRequest cannot be null"); }
            StringBuilder CreateLiveTraceServiceURL = new StringBuilder("/livetraces");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Post
            };
            request.AddJsonBody(LiveTraceRequest);
            request.Resource = CreateLiveTraceServiceURL.ToString();
            RestResponse<NSXTLiveTraceStatusType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTLiveTraceStatusType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Post operation to " + CreateLiveTraceServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTLiveTraceListResultType> ListLiveTrace(string? Cursor = null, string? IncludedFields = null, long? PageSize = null, bool? SortAscending = null, string? SortBy = null)
        {
            StringBuilder ListLiveTraceServiceURL = new StringBuilder("/livetraces");
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
            request.Resource = ListLiveTraceServiceURL.ToString();
            RestResponse<NSXTLiveTraceListResultType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTLiveTraceListResultType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Get operation to " + ListLiveTraceServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task GetForwardPktCapFileProxy(string LivetraceSessionId)
        {
            if (LivetraceSessionId == null) { throw new System.ArgumentNullException("LivetraceSessionId cannot be null"); }
            StringBuilder GetForwardPktCapFileProxyServiceURL = new StringBuilder("/livetraces/{livetrace-session-id}/proxy/forward/capturefile");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Get
            };
            GetForwardPktCapFileProxyServiceURL.Replace("{livetrace-session-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(LivetraceSessionId, System.Globalization.CultureInfo.InvariantCulture)));
            request.Resource = GetForwardPktCapFileProxyServiceURL.ToString();
            RestResponse response = await restClient.ExecuteTaskAsyncWithPolicy(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Get operation to " + GetForwardPktCapFileProxyServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTLiveTraceStatusType> GetLiveTraceStatus(string LivetraceSessionId)
        {
            if (LivetraceSessionId == null) { throw new System.ArgumentNullException("LivetraceSessionId cannot be null"); }
            StringBuilder GetLiveTraceStatusServiceURL = new StringBuilder("/livetraces/{livetrace-session-id}");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Get
            };
            GetLiveTraceStatusServiceURL.Replace("{livetrace-session-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(LivetraceSessionId, System.Globalization.CultureInfo.InvariantCulture)));
            request.Resource = GetLiveTraceStatusServiceURL.ToString();
            RestResponse<NSXTLiveTraceStatusType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTLiveTraceStatusType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Get operation to " + GetLiveTraceStatusServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task DeleteLiveTrace(string LivetraceSessionId)
        {
            if (LivetraceSessionId == null) { throw new System.ArgumentNullException("LivetraceSessionId cannot be null"); }
            StringBuilder DeleteLiveTraceServiceURL = new StringBuilder("/livetraces/{livetrace-session-id}");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Delete
            };
            DeleteLiveTraceServiceURL.Replace("{livetrace-session-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(LivetraceSessionId, System.Globalization.CultureInfo.InvariantCulture)));
            request.Resource = DeleteLiveTraceServiceURL.ToString();
            RestResponse response = await restClient.ExecuteTaskAsyncWithPolicy(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Delete operation to " + DeleteLiveTraceServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTLiveTraceResultType> GetLiveTraceResult(string LivetraceSessionId, string? ActionType = null, string? Cursor = null, string? IncludedFields = null, long? PageSize = null, bool? SortAscending = null, string? SortBy = null)
        {
            if (LivetraceSessionId == null) { throw new System.ArgumentNullException("LivetraceSessionId cannot be null"); }
            StringBuilder GetLiveTraceResultServiceURL = new StringBuilder("/livetraces/{livetrace-session-id}/results");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Get
            };
            GetLiveTraceResultServiceURL.Replace("{livetrace-session-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(LivetraceSessionId, System.Globalization.CultureInfo.InvariantCulture)));
            if (ActionType != null) { request.AddQueryParameter("action_type", ActionType.ToString()); }
            if (Cursor != null) { request.AddQueryParameter("cursor", Cursor.ToString()); }
            if (IncludedFields != null) { request.AddQueryParameter("included_fields", IncludedFields.ToString()); }
            if (PageSize != null) { request.AddQueryParameter("page_size", PageSize.ToString()); }
            if (SortAscending != null) { request.AddQueryParameter("sort_ascending", SortAscending.ToString()); }
            if (SortBy != null) { request.AddQueryParameter("sort_by", SortBy.ToString()); }
            request.Resource = GetLiveTraceResultServiceURL.ToString();
            RestResponse<NSXTLiveTraceResultType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTLiveTraceResultType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Get operation to " + GetLiveTraceResultServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
    }
}
