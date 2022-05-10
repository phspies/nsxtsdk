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
    public class IDSMetrics
    {
        private RestClient restClient;
        private int retry;
        private int timeout;
        private CancellationToken cancellationToken;

        public IDSMetrics(RestClient Client, CancellationToken _cancellationToken, int _timeout, int _retry)
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
        public async Task<NSXTIDSEventsBySignatureResultType> GetAllIdsEvents(NSXTIDSEventDataRequestType IdseventDataRequest)
        {
            if (IdseventDataRequest == null) { throw new System.ArgumentNullException("IdseventDataRequest cannot be null"); }
            StringBuilder GetAllIdsEventsServiceURL = new StringBuilder("/intrusion-services/ids-events");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Post
            };
            request.AddJsonBody(IdseventDataRequest);
            request.Resource = GetAllIdsEventsServiceURL.ToString();
            RestResponse<NSXTIDSEventsBySignatureResultType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTIDSEventsBySignatureResultType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Post operation to " + GetAllIdsEventsServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTIdsVmListType> GetAffectedVms(NSXTIDSEventDataRequestType IdseventDataRequest, string? Cursor = null, string? IncludedFields = null, long? PageSize = null, bool? SortAscending = null, string? SortBy = null)
        {
            if (IdseventDataRequest == null) { throw new System.ArgumentNullException("IdseventDataRequest cannot be null"); }
            StringBuilder GetAffectedVmsServiceURL = new StringBuilder("/intrusion-services/affected-vms");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Post
            };
            request.AddJsonBody(IdseventDataRequest);
            if (Cursor != null) { request.AddQueryParameter("cursor", Cursor.ToString()); }
            if (IncludedFields != null) { request.AddQueryParameter("included_fields", IncludedFields.ToString()); }
            if (PageSize != null) { request.AddQueryParameter("page_size", PageSize.ToString()); }
            if (SortAscending != null) { request.AddQueryParameter("sort_ascending", SortAscending.ToString()); }
            if (SortBy != null) { request.AddQueryParameter("sort_by", SortBy.ToString()); }
            request.Resource = GetAffectedVmsServiceURL.ToString();
            RestResponse<NSXTIdsVmListType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTIdsVmListType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Post operation to " + GetAffectedVmsServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTIDSSummaryListResultType> GetIdsDashboardSummary(NSXTIDSEventDataRequestType IdseventDataRequest, string? Cursor = null, string? IncludedFields = null, long? PageSize = null, bool? SortAscending = null, string? SortBy = null)
        {
            if (IdseventDataRequest == null) { throw new System.ArgumentNullException("IdseventDataRequest cannot be null"); }
            StringBuilder GetIdsDashboardSummaryServiceURL = new StringBuilder("/intrusion-services/ids-summary");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Post
            };
            request.AddJsonBody(IdseventDataRequest);
            if (Cursor != null) { request.AddQueryParameter("cursor", Cursor.ToString()); }
            if (IncludedFields != null) { request.AddQueryParameter("included_fields", IncludedFields.ToString()); }
            if (PageSize != null) { request.AddQueryParameter("page_size", PageSize.ToString()); }
            if (SortAscending != null) { request.AddQueryParameter("sort_ascending", SortAscending.ToString()); }
            if (SortBy != null) { request.AddQueryParameter("sort_by", SortBy.ToString()); }
            request.Resource = GetIdsDashboardSummaryServiceURL.ToString();
            RestResponse<NSXTIDSSummaryListResultType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTIDSSummaryListResultType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Post operation to " + GetIdsDashboardSummaryServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTIdsUserListType> GetAffectedUsers(NSXTIDSEventDataRequestType IdseventDataRequest, string? Cursor = null, string? IncludedFields = null, long? PageSize = null, bool? SortAscending = null, string? SortBy = null)
        {
            if (IdseventDataRequest == null) { throw new System.ArgumentNullException("IdseventDataRequest cannot be null"); }
            StringBuilder GetAffectedUsersServiceURL = new StringBuilder("/intrusion-services/affected-users");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Post
            };
            request.AddJsonBody(IdseventDataRequest);
            if (Cursor != null) { request.AddQueryParameter("cursor", Cursor.ToString()); }
            if (IncludedFields != null) { request.AddQueryParameter("included_fields", IncludedFields.ToString()); }
            if (PageSize != null) { request.AddQueryParameter("page_size", PageSize.ToString()); }
            if (SortAscending != null) { request.AddQueryParameter("sort_ascending", SortAscending.ToString()); }
            if (SortBy != null) { request.AddQueryParameter("sort_by", SortBy.ToString()); }
            request.Resource = GetAffectedUsersServiceURL.ToString();
            RestResponse<NSXTIdsUserListType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTIdsUserListType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Post operation to " + GetAffectedUsersServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
    }
}
