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
    public class BackupConfiguration
    {
        private RestClient restClient;
        private int retry;
        private int timeout;
        private CancellationToken cancellationToken;

        public BackupConfiguration(RestClient Client, CancellationToken _cancellationToken, int _timeout, int _retry)
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
        public async Task<NSXTBackupConfigurationType> ConfigureBackupConfig(NSXTBackupConfigurationType BackupConfiguration, string? FrameType = null, string? SiteId = null)
        {
            if (BackupConfiguration == null) { throw new System.ArgumentNullException("BackupConfiguration cannot be null"); }
            StringBuilder ConfigureBackupConfigServiceURL = new StringBuilder("/cluster/backups/config");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Put
            };
            request.AddJsonBody(BackupConfiguration);
            if (FrameType != null) { request.AddQueryParameter("frame_type", FrameType.ToString()); }
            if (SiteId != null) { request.AddQueryParameter("site_id", SiteId.ToString()); }
            request.Resource = ConfigureBackupConfigServiceURL.ToString();
            RestResponse<NSXTBackupConfigurationType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTBackupConfigurationType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Put operation to " + ConfigureBackupConfigServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTBackupConfigurationType> GetBackupConfig()
        {
            StringBuilder GetBackupConfigServiceURL = new StringBuilder("/cluster/backups/config");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Get
            };
            request.Resource = GetBackupConfigServiceURL.ToString();
            RestResponse<NSXTBackupConfigurationType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTBackupConfigurationType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Get operation to " + GetBackupConfigServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTBackupOperationHistoryType> GetBackupHistory()
        {
            StringBuilder GetBackupHistoryServiceURL = new StringBuilder("/cluster/backups/history");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Get
            };
            request.Resource = GetBackupHistoryServiceURL.ToString();
            RestResponse<NSXTBackupOperationHistoryType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTBackupOperationHistoryType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Get operation to " + GetBackupHistoryServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task RequestOnetimeBackup(string? FrameType = null, string? SiteId = null)
        {
            StringBuilder RequestOnetimeBackupServiceURL = new StringBuilder("/cluster?action=backup_to_remote");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Post
            };
            if (FrameType != null) { request.AddQueryParameter("frame_type", FrameType.ToString()); }
            if (SiteId != null) { request.AddQueryParameter("site_id", SiteId.ToString()); }
            request.Resource = RequestOnetimeBackupServiceURL.ToString();
            RestResponse response = await restClient.ExecuteTaskAsyncWithPolicy(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Post operation to " + RequestOnetimeBackupServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTCurrentBackupOperationStatusType> GetBackupStatus()
        {
            StringBuilder GetBackupStatusServiceURL = new StringBuilder("/cluster/backups/status");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Get
            };
            request.Resource = GetBackupStatusServiceURL.ToString();
            RestResponse<NSXTCurrentBackupOperationStatusType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTCurrentBackupOperationStatusType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Get operation to " + GetBackupStatusServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTRestoreConfigurationType> ConfigureRestoreConfig(NSXTRestoreConfigurationType RestoreConfiguration)
        {
            if (RestoreConfiguration == null) { throw new System.ArgumentNullException("RestoreConfiguration cannot be null"); }
            StringBuilder ConfigureRestoreConfigServiceURL = new StringBuilder("/cluster/restore/config");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Put
            };
            request.AddJsonBody(RestoreConfiguration);
            request.Resource = ConfigureRestoreConfigServiceURL.ToString();
            RestResponse<NSXTRestoreConfigurationType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTRestoreConfigurationType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Put operation to " + ConfigureRestoreConfigServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTRestoreConfigurationType> GetRestoreConfig()
        {
            StringBuilder GetRestoreConfigServiceURL = new StringBuilder("/cluster/restore/config");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Get
            };
            request.Resource = GetRestoreConfigServiceURL.ToString();
            RestResponse<NSXTRestoreConfigurationType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTRestoreConfigurationType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Get operation to " + GetRestoreConfigServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTBackupOverviewType> GetBackupOverview(string? Cursor = null, string? FrameType = null, string? IncludedFields = null, long? PageSize = null, bool? ShowBackupsList = null, string? SiteId = null, bool? SortAscending = null, string? SortBy = null)
        {
            StringBuilder GetBackupOverviewServiceURL = new StringBuilder("/cluster/backups/overview");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Get
            };
            if (Cursor != null) { request.AddQueryParameter("cursor", Cursor.ToString()); }
            if (FrameType != null) { request.AddQueryParameter("frame_type", FrameType.ToString()); }
            if (IncludedFields != null) { request.AddQueryParameter("included_fields", IncludedFields.ToString()); }
            if (PageSize != null) { request.AddQueryParameter("page_size", PageSize.ToString()); }
            if (ShowBackupsList != null) { request.AddQueryParameter("show_backups_list", ShowBackupsList.ToString()); }
            if (SiteId != null) { request.AddQueryParameter("site_id", SiteId.ToString()); }
            if (SortAscending != null) { request.AddQueryParameter("sort_ascending", SortAscending.ToString()); }
            if (SortBy != null) { request.AddQueryParameter("sort_by", SortBy.ToString()); }
            request.Resource = GetBackupOverviewServiceURL.ToString();
            RestResponse<NSXTBackupOverviewType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTBackupOverviewType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Get operation to " + GetBackupOverviewServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task RequestOnetimeInventorySummary()
        {
            StringBuilder RequestOnetimeInventorySummaryServiceURL = new StringBuilder("/cluster?action=summarize_inventory_to_remote");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Post
            };
            request.Resource = RequestOnetimeInventorySummaryServiceURL.ToString();
            RestResponse response = await restClient.ExecuteTaskAsyncWithPolicy(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Post operation to " + RequestOnetimeInventorySummaryServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTRemoteServerFingerprintType> GetSshFingerprintOfServer(NSXTRemoteServerFingerprintRequestType RemoteServerFingerprintRequest)
        {
            if (RemoteServerFingerprintRequest == null) { throw new System.ArgumentNullException("RemoteServerFingerprintRequest cannot be null"); }
            StringBuilder GetSshFingerprintOfServerServiceURL = new StringBuilder("/cluster/backups?action=retrieve_ssh_fingerprint");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Post
            };
            request.AddJsonBody(RemoteServerFingerprintRequest);
            request.Resource = GetSshFingerprintOfServerServiceURL.ToString();
            RestResponse<NSXTRemoteServerFingerprintType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTRemoteServerFingerprintType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Post operation to " + GetSshFingerprintOfServerServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
    }
}
