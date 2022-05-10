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
using nsxtsdk.PolicyModels;

namespace nsxtapi.PolicyModules
{
    public class PolicyFullSync
    {
        private RestClient restClient;
        private int retry;
        private int timeout;
        private CancellationToken cancellationToken;

        public PolicyFullSync(RestClient Client, CancellationToken _cancellationToken, int _timeout, int _retry)
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
        public async Task<NSXTFullSyncStateType> GetFullSyncStates(string FullSyncId)
        {
            if (FullSyncId == null) { throw new System.ArgumentNullException("FullSyncId cannot be null"); }
            StringBuilder GetFullSyncStatesServiceURL = new StringBuilder("/infra/full-sync-states/{full-sync-id}");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Get
            };
            GetFullSyncStatesServiceURL.Replace("{full-sync-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(FullSyncId, System.Globalization.CultureInfo.InvariantCulture)));
            request.Resource = GetFullSyncStatesServiceURL.ToString();
            RestResponse<NSXTFullSyncStateType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTFullSyncStateType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Get operation to " + GetFullSyncStatesServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task FullSyncActions(string Action, string? SyncType = null)
        {
            if (Action == null) { throw new System.ArgumentNullException("Action cannot be null"); }
            StringBuilder FullSyncActionsServiceURL = new StringBuilder("/infra/full-sync-action");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Post
            };
            if (Action != null) { request.AddQueryParameter("action", Action.ToString()); }
            if (SyncType != null) { request.AddQueryParameter("sync_type", SyncType.ToString()); }
            request.Resource = FullSyncActionsServiceURL.ToString();
            RestResponse response = await restClient.ExecuteTaskAsyncWithPolicy(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Post operation to " + FullSyncActionsServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTFullSyncStateListResultType> GlobalGlobalInfraListFullSyncStates(string? Cursor = null, bool? IncludeMarkForDeleteObjects = null, string? IncludedFields = null, long? PageSize = null, bool? SortAscending = null, string? SortBy = null)
        {
            StringBuilder GlobalInfraListFullSyncStatesServiceURL = new StringBuilder("/global-infra/full-sync-states");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Get
            };
            if (Cursor != null) { request.AddQueryParameter("cursor", Cursor.ToString()); }
            if (IncludeMarkForDeleteObjects != null) { request.AddQueryParameter("include_mark_for_delete_objects", IncludeMarkForDeleteObjects.ToString()); }
            if (IncludedFields != null) { request.AddQueryParameter("included_fields", IncludedFields.ToString()); }
            if (PageSize != null) { request.AddQueryParameter("page_size", PageSize.ToString()); }
            if (SortAscending != null) { request.AddQueryParameter("sort_ascending", SortAscending.ToString()); }
            if (SortBy != null) { request.AddQueryParameter("sort_by", SortBy.ToString()); }
            request.Resource = GlobalInfraListFullSyncStatesServiceURL.ToString();
            RestResponse<NSXTFullSyncStateListResultType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTFullSyncStateListResultType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Get operation to " + GlobalInfraListFullSyncStatesServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTFullSyncStateType> GlobalGlobalInfraGetFullSyncStates(string FullSyncId)
        {
            if (FullSyncId == null) { throw new System.ArgumentNullException("FullSyncId cannot be null"); }
            StringBuilder GlobalInfraGetFullSyncStatesServiceURL = new StringBuilder("/global-infra/full-sync-states/{full-sync-id}");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Get
            };
            GlobalInfraGetFullSyncStatesServiceURL.Replace("{full-sync-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(FullSyncId, System.Globalization.CultureInfo.InvariantCulture)));
            request.Resource = GlobalInfraGetFullSyncStatesServiceURL.ToString();
            RestResponse<NSXTFullSyncStateType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTFullSyncStateType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Get operation to " + GlobalInfraGetFullSyncStatesServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTFullSyncStateListResultType> ListFullSyncStates(string? Cursor = null, bool? IncludeMarkForDeleteObjects = null, string? IncludedFields = null, long? PageSize = null, bool? SortAscending = null, string? SortBy = null)
        {
            StringBuilder ListFullSyncStatesServiceURL = new StringBuilder("/infra/full-sync-states");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Get
            };
            if (Cursor != null) { request.AddQueryParameter("cursor", Cursor.ToString()); }
            if (IncludeMarkForDeleteObjects != null) { request.AddQueryParameter("include_mark_for_delete_objects", IncludeMarkForDeleteObjects.ToString()); }
            if (IncludedFields != null) { request.AddQueryParameter("included_fields", IncludedFields.ToString()); }
            if (PageSize != null) { request.AddQueryParameter("page_size", PageSize.ToString()); }
            if (SortAscending != null) { request.AddQueryParameter("sort_ascending", SortAscending.ToString()); }
            if (SortBy != null) { request.AddQueryParameter("sort_by", SortBy.ToString()); }
            request.Resource = ListFullSyncStatesServiceURL.ToString();
            RestResponse<NSXTFullSyncStateListResultType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTFullSyncStateListResultType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Get operation to " + ListFullSyncStatesServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
    }
}
