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
    public class ClusterNodeBackupRestore
    {
        private RestClient restClient;
        private int retry;
        private int timeout;
        private CancellationToken cancellationToken;

        public ClusterNodeBackupRestore(RestClient Client, CancellationToken _cancellationToken, int _timeout, int _retry)
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
        public async Task<NSXTClusterRestoreStatusType> QueryClusterRestoreStatus(string? RestoreComponent = null)
        {
            StringBuilder QueryClusterRestoreStatusServiceURL = new StringBuilder("/cluster/restore/status");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Get
            };
            if (RestoreComponent != null) { request.AddQueryParameter("restore_component", RestoreComponent.ToString()); }
            request.Resource = QueryClusterRestoreStatusServiceURL.ToString();
            RestResponse<NSXTClusterRestoreStatusType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTClusterRestoreStatusType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Get operation to " + QueryClusterRestoreStatusServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTBackupUiFramesInfoListType> GetBackupUiFramesInfo(string? Cursor = null, string? IncludedFields = null, long? PageSize = null, bool? SortAscending = null, string? SortBy = null, string? UiTabType = null)
        {
            StringBuilder GetBackupUiFramesInfoServiceURL = new StringBuilder("/cluster/backups/ui_frames");
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
            if (UiTabType != null) { request.AddQueryParameter("ui_tab_type", UiTabType.ToString()); }
            request.Resource = GetBackupUiFramesInfoServiceURL.ToString();
            RestResponse<NSXTBackupUiFramesInfoListType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTBackupUiFramesInfoListType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Get operation to " + GetBackupUiFramesInfoServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
    }
}
