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
    public class ClusterRestore
    {
        private RestClient restClient;
        private int retry;
        private int timeout;
        private CancellationToken cancellationToken;

        public ClusterRestore(RestClient Client, CancellationToken _cancellationToken, int _timeout, int _retry)
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
        public async Task<NSXTClusterRestoreStatusType> RetryClusterRestore()
        {
            StringBuilder RetryClusterRestoreServiceURL = new StringBuilder("/cluster/restore?action=retry");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Post
            };
            request.Resource = RetryClusterRestoreServiceURL.ToString();
            RestResponse<NSXTClusterRestoreStatusType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTClusterRestoreStatusType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Post operation to " + RetryClusterRestoreServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTClusterBackupInfoListResultType> ListClusterBackupTimestamps(string? Cursor = null, string? IncludedFields = null, long? PageSize = null, bool? SortAscending = null, string? SortBy = null)
        {
            StringBuilder ListClusterBackupTimestampsServiceURL = new StringBuilder("/cluster/restore/backuptimestamps");
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
            request.Resource = ListClusterBackupTimestampsServiceURL.ToString();
            RestResponse<NSXTClusterBackupInfoListResultType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTClusterBackupInfoListResultType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Get operation to " + ListClusterBackupTimestampsServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTActionableResourceListResultType> ListRestoreInstructionResources(string InstructionId, string? Cursor = null, string? IncludedFields = null, long? PageSize = null, bool? SortAscending = null, string? SortBy = null)
        {
            if (InstructionId == null) { throw new System.ArgumentNullException("InstructionId cannot be null"); }
            StringBuilder ListRestoreInstructionResourcesServiceURL = new StringBuilder("/cluster/restore/instruction-resources");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Get
            };
            if (Cursor != null) { request.AddQueryParameter("cursor", Cursor.ToString()); }
            if (IncludedFields != null) { request.AddQueryParameter("included_fields", IncludedFields.ToString()); }
            if (InstructionId != null) { request.AddQueryParameter("instruction_id", InstructionId.ToString()); }
            if (PageSize != null) { request.AddQueryParameter("page_size", PageSize.ToString()); }
            if (SortAscending != null) { request.AddQueryParameter("sort_ascending", SortAscending.ToString()); }
            if (SortBy != null) { request.AddQueryParameter("sort_by", SortBy.ToString()); }
            request.Resource = ListRestoreInstructionResourcesServiceURL.ToString();
            RestResponse<NSXTActionableResourceListResultType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTActionableResourceListResultType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Get operation to " + ListRestoreInstructionResourcesServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTClusterRestoreStatusType> CancelClusterRestore()
        {
            StringBuilder CancelClusterRestoreServiceURL = new StringBuilder("/cluster/restore?action=cancel");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Post
            };
            request.Resource = CancelClusterRestoreServiceURL.ToString();
            RestResponse<NSXTClusterRestoreStatusType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTClusterRestoreStatusType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Post operation to " + CancelClusterRestoreServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTClusterRestoreStatusType> AdvanceClusterRestore(NSXTAdvanceClusterRestoreRequestType AdvanceClusterRestoreRequest)
        {
            if (AdvanceClusterRestoreRequest == null) { throw new System.ArgumentNullException("AdvanceClusterRestoreRequest cannot be null"); }
            StringBuilder AdvanceClusterRestoreServiceURL = new StringBuilder("/cluster/restore?action=advance");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Post
            };
            request.AddJsonBody(AdvanceClusterRestoreRequest);
            request.Resource = AdvanceClusterRestoreServiceURL.ToString();
            RestResponse<NSXTClusterRestoreStatusType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTClusterRestoreStatusType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Post operation to " + AdvanceClusterRestoreServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTClusterRestoreStatusType> SuspendClusterRestore()
        {
            StringBuilder SuspendClusterRestoreServiceURL = new StringBuilder("/cluster/restore?action=suspend");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Post
            };
            request.Resource = SuspendClusterRestoreServiceURL.ToString();
            RestResponse<NSXTClusterRestoreStatusType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTClusterRestoreStatusType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Post operation to " + SuspendClusterRestoreServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTClusterRestoreStatusType> InitiateClusterRestore(NSXTInitiateClusterRestoreRequestType InitiateClusterRestoreRequest)
        {
            if (InitiateClusterRestoreRequest == null) { throw new System.ArgumentNullException("InitiateClusterRestoreRequest cannot be null"); }
            StringBuilder InitiateClusterRestoreServiceURL = new StringBuilder("/cluster/restore?action=start");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Post
            };
            request.AddJsonBody(InitiateClusterRestoreRequest);
            request.Resource = InitiateClusterRestoreServiceURL.ToString();
            RestResponse<NSXTClusterRestoreStatusType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTClusterRestoreStatusType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Post operation to " + InitiateClusterRestoreServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
    }
}
