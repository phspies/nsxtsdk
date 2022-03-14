// <auto-generated>
// Changes may cause incorrect behavior and will be lost if the code is regenerated.
// </auto-generated>

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
        RestClient restClient;
        JsonSerializerSettings defaultSerializationSettings;
        int retry;
        int timeout;
        CancellationToken cancellationToken;
        public PolicyFullSync(RestClient Client, JsonSerializerSettings DefaultSerializationSettings, CancellationToken _cancellationToken, int _timeout, int _retry)

        {
            restClient = Client;
            defaultSerializationSettings = DefaultSerializationSettings;
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
            NSXTFullSyncStateType returnValue = default(NSXTFullSyncStateType);
            StringBuilder GetFullSyncStatesServiceURL = new StringBuilder("/infra/full-sync-states/{full-sync-id}");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.GET
            };
            request.AddHeader("Content-type", "application/json");
            GetFullSyncStatesServiceURL.Replace("{full-sync-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(FullSyncId, System.Globalization.CultureInfo.InvariantCulture)));
            request.Resource = GetFullSyncStatesServiceURL.ToString();
            IRestResponse<NSXTFullSyncStateType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTFullSyncStateType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP GET operation to " + GetFullSyncStatesServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, null);
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
                Method = Method.POST
            };
            request.AddHeader("Content-type", "application/json");
            if (Action != null) { request.AddQueryParameter("action", Action.ToString()); }
            if (SyncType != null) { request.AddQueryParameter("sync_type", SyncType.ToString()); }
            request.Resource = FullSyncActionsServiceURL.ToString();
            IRestResponse response = await restClient.ExecuteTaskAsyncWithPolicy(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP POST operation to " + FullSyncActionsServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, null);
			}
            
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTFullSyncStateListResultType> GlobalGlobalInfraListFullSyncStates(string? Cursor = null, bool? IncludeMarkForDeleteObjects = null, string? IncludedFields = null, long? PageSize = null, bool? SortAscending = null, string? SortBy = null)
        {
            NSXTFullSyncStateListResultType returnValue = default(NSXTFullSyncStateListResultType);
            StringBuilder GlobalInfraListFullSyncStatesServiceURL = new StringBuilder("/global-infra/full-sync-states");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.GET
            };
            request.AddHeader("Content-type", "application/json");
            if (Cursor != null) { request.AddQueryParameter("cursor", Cursor.ToString()); }
            if (IncludeMarkForDeleteObjects != null) { request.AddQueryParameter("include_mark_for_delete_objects", IncludeMarkForDeleteObjects.ToString()); }
            if (IncludedFields != null) { request.AddQueryParameter("included_fields", IncludedFields.ToString()); }
            if (PageSize != null) { request.AddQueryParameter("page_size", PageSize.ToString()); }
            if (SortAscending != null) { request.AddQueryParameter("sort_ascending", SortAscending.ToString()); }
            if (SortBy != null) { request.AddQueryParameter("sort_by", SortBy.ToString()); }
            request.Resource = GlobalInfraListFullSyncStatesServiceURL.ToString();
            IRestResponse<NSXTFullSyncStateListResultType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTFullSyncStateListResultType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP GET operation to " + GlobalInfraListFullSyncStatesServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, null);
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
            NSXTFullSyncStateType returnValue = default(NSXTFullSyncStateType);
            StringBuilder GlobalInfraGetFullSyncStatesServiceURL = new StringBuilder("/global-infra/full-sync-states/{full-sync-id}");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.GET
            };
            request.AddHeader("Content-type", "application/json");
            GlobalInfraGetFullSyncStatesServiceURL.Replace("{full-sync-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(FullSyncId, System.Globalization.CultureInfo.InvariantCulture)));
            request.Resource = GlobalInfraGetFullSyncStatesServiceURL.ToString();
            IRestResponse<NSXTFullSyncStateType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTFullSyncStateType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP GET operation to " + GlobalInfraGetFullSyncStatesServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, null);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTFullSyncStateListResultType> ListFullSyncStates(string? Cursor = null, bool? IncludeMarkForDeleteObjects = null, string? IncludedFields = null, long? PageSize = null, bool? SortAscending = null, string? SortBy = null)
        {
            NSXTFullSyncStateListResultType returnValue = default(NSXTFullSyncStateListResultType);
            StringBuilder ListFullSyncStatesServiceURL = new StringBuilder("/infra/full-sync-states");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.GET
            };
            request.AddHeader("Content-type", "application/json");
            if (Cursor != null) { request.AddQueryParameter("cursor", Cursor.ToString()); }
            if (IncludeMarkForDeleteObjects != null) { request.AddQueryParameter("include_mark_for_delete_objects", IncludeMarkForDeleteObjects.ToString()); }
            if (IncludedFields != null) { request.AddQueryParameter("included_fields", IncludedFields.ToString()); }
            if (PageSize != null) { request.AddQueryParameter("page_size", PageSize.ToString()); }
            if (SortAscending != null) { request.AddQueryParameter("sort_ascending", SortAscending.ToString()); }
            if (SortBy != null) { request.AddQueryParameter("sort_by", SortBy.ToString()); }
            request.Resource = ListFullSyncStatesServiceURL.ToString();
            IRestResponse<NSXTFullSyncStateListResultType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTFullSyncStateListResultType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP GET operation to " + ListFullSyncStatesServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, null);
			}
            return response.Data;
        }
    }
}
