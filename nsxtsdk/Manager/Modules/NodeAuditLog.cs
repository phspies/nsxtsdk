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
    public class NodeAuditLog
    {
        private RestClient restClient;
        private int retry;
        private int timeout;
        private CancellationToken cancellationToken;

        public NodeAuditLog(RestClient Client, CancellationToken _cancellationToken, int _timeout, int _retry)
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
        public async Task<NSXTAuditLogListResultType> CollectAuditLogs(NSXTAuditLogRequestType AuditLogRequest, long? Cursor = null, string? Fields = null, long? PageSize = null)
        {
            if (AuditLogRequest == null) { throw new System.ArgumentNullException("AuditLogRequest cannot be null"); }
            StringBuilder CollectAuditLogsServiceURL = new StringBuilder("/administration/audit-logs");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Post
            };
            request.AddJsonBody(AuditLogRequest);
            if (Cursor != null) { request.AddQueryParameter("cursor", Cursor.ToString()); }
            if (Fields != null) { request.AddQueryParameter("fields", Fields.ToString()); }
            if (PageSize != null) { request.AddQueryParameter("page_size", PageSize.ToString()); }
            request.Resource = CollectAuditLogsServiceURL.ToString();
            RestResponse<NSXTAuditLogListResultType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTAuditLogListResultType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Post operation to " + CollectAuditLogsServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
    }
}
