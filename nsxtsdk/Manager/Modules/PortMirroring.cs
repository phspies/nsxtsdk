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
    public class PortMirroring
    {
        private RestClient restClient;
        private int retry;
        private int timeout;
        private CancellationToken cancellationToken;

        public PortMirroring(RestClient Client, CancellationToken _cancellationToken, int _timeout, int _retry)
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
        public async Task<NSXTPortMirroringSessionType> CreatePortMirroringSessions(NSXTPortMirroringSessionType PortMirroringSession)
        {
            if (PortMirroringSession == null) { throw new System.ArgumentNullException("PortMirroringSession cannot be null"); }
            StringBuilder CreatePortMirroringSessionsServiceURL = new StringBuilder("/mirror-sessions");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Post
            };
            request.AddJsonBody(PortMirroringSession);
            request.Resource = CreatePortMirroringSessionsServiceURL.ToString();
            RestResponse<NSXTPortMirroringSessionType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTPortMirroringSessionType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Post operation to " + CreatePortMirroringSessionsServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTPortMirroringSessionListResultType> ListPortMirroringSession(string? Cursor = null, string? IncludedFields = null, long? PageSize = null, bool? SortAscending = null, string? SortBy = null)
        {
            StringBuilder ListPortMirroringSessionServiceURL = new StringBuilder("/mirror-sessions");
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
            request.Resource = ListPortMirroringSessionServiceURL.ToString();
            RestResponse<NSXTPortMirroringSessionListResultType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTPortMirroringSessionListResultType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Get operation to " + ListPortMirroringSessionServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTPortMirroringSessionType> UpdatePortMirroringSession(string MirrorSessionId, NSXTPortMirroringSessionType PortMirroringSession)
        {
            if (MirrorSessionId == null) { throw new System.ArgumentNullException("MirrorSessionId cannot be null"); }
            if (PortMirroringSession == null) { throw new System.ArgumentNullException("PortMirroringSession cannot be null"); }
            StringBuilder UpdatePortMirroringSessionServiceURL = new StringBuilder("/mirror-sessions/{mirror-session-id}");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Put
            };
            UpdatePortMirroringSessionServiceURL.Replace("{mirror-session-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(MirrorSessionId, System.Globalization.CultureInfo.InvariantCulture)));
            request.AddJsonBody(PortMirroringSession);
            request.Resource = UpdatePortMirroringSessionServiceURL.ToString();
            RestResponse<NSXTPortMirroringSessionType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTPortMirroringSessionType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Put operation to " + UpdatePortMirroringSessionServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTPortMirroringSessionType> GetPortMirroringSession(string MirrorSessionId)
        {
            if (MirrorSessionId == null) { throw new System.ArgumentNullException("MirrorSessionId cannot be null"); }
            StringBuilder GetPortMirroringSessionServiceURL = new StringBuilder("/mirror-sessions/{mirror-session-id}");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Get
            };
            GetPortMirroringSessionServiceURL.Replace("{mirror-session-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(MirrorSessionId, System.Globalization.CultureInfo.InvariantCulture)));
            request.Resource = GetPortMirroringSessionServiceURL.ToString();
            RestResponse<NSXTPortMirroringSessionType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTPortMirroringSessionType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Get operation to " + GetPortMirroringSessionServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task DeletePortMirroringSession(string MirrorSessionId)
        {
            if (MirrorSessionId == null) { throw new System.ArgumentNullException("MirrorSessionId cannot be null"); }
            StringBuilder DeletePortMirroringSessionServiceURL = new StringBuilder("/mirror-sessions/{mirror-session-id}");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Delete
            };
            DeletePortMirroringSessionServiceURL.Replace("{mirror-session-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(MirrorSessionId, System.Globalization.CultureInfo.InvariantCulture)));
            request.Resource = DeletePortMirroringSessionServiceURL.ToString();
            RestResponse response = await restClient.ExecuteTaskAsyncWithPolicy(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Delete operation to " + DeletePortMirroringSessionServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTMirrorStackStatusListResultType> GetMirrorStackStatus(string MirrorSessionId, string? Cursor = null, string? IncludedFields = null, long? PageSize = null, bool? SortAscending = null, string? SortBy = null)
        {
            if (MirrorSessionId == null) { throw new System.ArgumentNullException("MirrorSessionId cannot be null"); }
            StringBuilder GetMirrorStackStatusServiceURL = new StringBuilder("/mirror-sessions/{mirror-session-id}/mirror-stack-status");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Get
            };
            GetMirrorStackStatusServiceURL.Replace("{mirror-session-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(MirrorSessionId, System.Globalization.CultureInfo.InvariantCulture)));
            if (Cursor != null) { request.AddQueryParameter("cursor", Cursor.ToString()); }
            if (IncludedFields != null) { request.AddQueryParameter("included_fields", IncludedFields.ToString()); }
            if (PageSize != null) { request.AddQueryParameter("page_size", PageSize.ToString()); }
            if (SortAscending != null) { request.AddQueryParameter("sort_ascending", SortAscending.ToString()); }
            if (SortBy != null) { request.AddQueryParameter("sort_by", SortBy.ToString()); }
            request.Resource = GetMirrorStackStatusServiceURL.ToString();
            RestResponse<NSXTMirrorStackStatusListResultType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTMirrorStackStatusListResultType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Get operation to " + GetMirrorStackStatusServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task VerifyPortMirroringSession(string MirrorSessionId)
        {
            if (MirrorSessionId == null) { throw new System.ArgumentNullException("MirrorSessionId cannot be null"); }
            StringBuilder VerifyPortMirroringSessionServiceURL = new StringBuilder("/mirror-sessions/{mirror-session-id}?action=verify");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Post
            };
            VerifyPortMirroringSessionServiceURL.Replace("{mirror-session-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(MirrorSessionId, System.Globalization.CultureInfo.InvariantCulture)));
            request.Resource = VerifyPortMirroringSessionServiceURL.ToString();
            RestResponse response = await restClient.ExecuteTaskAsyncWithPolicy(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Post operation to " + VerifyPortMirroringSessionServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            
        }
    }
}
