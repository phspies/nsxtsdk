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
    public class Upgrade
    {
        private RestClient restClient;
        private int retry;
        private int timeout;
        private CancellationToken cancellationToken;

        public Upgrade(RestClient Client, CancellationToken _cancellationToken, int _timeout, int _retry)
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
        public async Task<NSXTNodeSummaryListType> GetNodesSummary()
        {
            StringBuilder GetNodesSummaryServiceURL = new StringBuilder("/upgrade/nodes-summary");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Get
            };
            request.Resource = GetNodesSummaryServiceURL.ToString();
            RestResponse<NSXTNodeSummaryListType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTNodeSummaryListType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Get operation to " + GetNodesSummaryServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task StartUpgrade()
        {
            StringBuilder StartUpgradeServiceURL = new StringBuilder("/upgrade/plan?action=start");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Post
            };
            request.Resource = StartUpgradeServiceURL.ToString();
            RestResponse response = await restClient.ExecuteTaskAsyncWithPolicy(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Post operation to " + StartUpgradeServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task PauseUpgrade()
        {
            StringBuilder PauseUpgradeServiceURL = new StringBuilder("/upgrade/plan?action=pause");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Post
            };
            request.Resource = PauseUpgradeServiceURL.ToString();
            RestResponse response = await restClient.ExecuteTaskAsyncWithPolicy(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Post operation to " + PauseUpgradeServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTUpgradeBundleInfoType> GetUpgradeBundleInfo(string BundleId)
        {
            if (BundleId == null) { throw new System.ArgumentNullException("BundleId cannot be null"); }
            StringBuilder GetUpgradeBundleInfoServiceURL = new StringBuilder("/upgrade/bundles/{bundle-id}");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Get
            };
            GetUpgradeBundleInfoServiceURL.Replace("{bundle-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(BundleId, System.Globalization.CultureInfo.InvariantCulture)));
            request.Resource = GetUpgradeBundleInfoServiceURL.ToString();
            RestResponse<NSXTUpgradeBundleInfoType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTUpgradeBundleInfoType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Get operation to " + GetUpgradeBundleInfoServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTUpgradeUnitGroupType> CreateUpgradeUnitGroup(NSXTUpgradeUnitGroupType UpgradeUnitGroup)
        {
            if (UpgradeUnitGroup == null) { throw new System.ArgumentNullException("UpgradeUnitGroup cannot be null"); }
            StringBuilder CreateUpgradeUnitGroupServiceURL = new StringBuilder("/upgrade/upgrade-unit-groups");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Post
            };
            request.AddJsonBody(UpgradeUnitGroup);
            request.Resource = CreateUpgradeUnitGroupServiceURL.ToString();
            RestResponse<NSXTUpgradeUnitGroupType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTUpgradeUnitGroupType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Post operation to " + CreateUpgradeUnitGroupServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTUpgradeUnitGroupListResultType> GetUpgradeUnitGroups(string? ComponentType = null, string? Cursor = null, string? IncludedFields = null, long? PageSize = null, bool? SortAscending = null, string? SortBy = null, bool? Summary = null, bool? Sync = null)
        {
            StringBuilder GetUpgradeUnitGroupsServiceURL = new StringBuilder("/upgrade/upgrade-unit-groups");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Get
            };
            if (ComponentType != null) { request.AddQueryParameter("component_type", ComponentType.ToString()); }
            if (Cursor != null) { request.AddQueryParameter("cursor", Cursor.ToString()); }
            if (IncludedFields != null) { request.AddQueryParameter("included_fields", IncludedFields.ToString()); }
            if (PageSize != null) { request.AddQueryParameter("page_size", PageSize.ToString()); }
            if (SortAscending != null) { request.AddQueryParameter("sort_ascending", SortAscending.ToString()); }
            if (SortBy != null) { request.AddQueryParameter("sort_by", SortBy.ToString()); }
            if (Summary != null) { request.AddQueryParameter("summary", Summary.ToString()); }
            if (Sync != null) { request.AddQueryParameter("sync", Sync.ToString()); }
            request.Resource = GetUpgradeUnitGroupsServiceURL.ToString();
            RestResponse<NSXTUpgradeUnitGroupListResultType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTUpgradeUnitGroupListResultType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Get operation to " + GetUpgradeUnitGroupsServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTUpgradeUnitTypeStatsListType> GetUpgradeUnitsStats(string? Cursor = null, string? IncludedFields = null, long? PageSize = null, bool? SortAscending = null, string? SortBy = null, bool? Sync = null)
        {
            StringBuilder GetUpgradeUnitsStatsServiceURL = new StringBuilder("/upgrade/upgrade-units-stats");
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
            if (Sync != null) { request.AddQueryParameter("sync", Sync.ToString()); }
            request.Resource = GetUpgradeUnitsStatsServiceURL.ToString();
            RestResponse<NSXTUpgradeUnitTypeStatsListType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTUpgradeUnitTypeStatsListType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Get operation to " + GetUpgradeUnitsStatsServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task TriggerUcUpgrade()
        {
            StringBuilder TriggerUcUpgradeServiceURL = new StringBuilder("/upgrade?action=upgrade_uc");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Post
            };
            request.Resource = TriggerUcUpgradeServiceURL.ToString();
            RestResponse response = await restClient.ExecuteTaskAsyncWithPolicy(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Post operation to " + TriggerUcUpgradeServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTUpgradeUnitAggregateInfoListResultType> GetUpgradeUnitAggregateInfo(string? ComponentType = null, string? Cursor = null, string? GroupId = null, bool? HasErrors = null, string? IncludedFields = null, string? Metadata = null, long? PageSize = null, string? SelectionStatus = null, bool? SortAscending = null, string? SortBy = null, string? UpgradeUnitDisplayName = null)
        {
            StringBuilder GetUpgradeUnitAggregateInfoServiceURL = new StringBuilder("/upgrade/upgrade-units/aggregate-info");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Get
            };
            if (ComponentType != null) { request.AddQueryParameter("component_type", ComponentType.ToString()); }
            if (Cursor != null) { request.AddQueryParameter("cursor", Cursor.ToString()); }
            if (GroupId != null) { request.AddQueryParameter("group_id", GroupId.ToString()); }
            if (HasErrors != null) { request.AddQueryParameter("has_errors", HasErrors.ToString()); }
            if (IncludedFields != null) { request.AddQueryParameter("included_fields", IncludedFields.ToString()); }
            if (Metadata != null) { request.AddQueryParameter("metadata", Metadata.ToString()); }
            if (PageSize != null) { request.AddQueryParameter("page_size", PageSize.ToString()); }
            if (SelectionStatus != null) { request.AddQueryParameter("selection_status", SelectionStatus.ToString()); }
            if (SortAscending != null) { request.AddQueryParameter("sort_ascending", SortAscending.ToString()); }
            if (SortBy != null) { request.AddQueryParameter("sort_by", SortBy.ToString()); }
            if (UpgradeUnitDisplayName != null) { request.AddQueryParameter("upgrade_unit_display_name", UpgradeUnitDisplayName.ToString()); }
            request.Resource = GetUpgradeUnitAggregateInfoServiceURL.ToString();
            RestResponse<NSXTUpgradeUnitAggregateInfoListResultType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTUpgradeUnitAggregateInfoListResultType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Get operation to " + GetUpgradeUnitAggregateInfoServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task ExecutePreUpgradeChecks(string? ComponentType = null, string? Cursor = null, string? IncludedFields = null, long? PageSize = null, bool? SortAscending = null, string? SortBy = null)
        {
            StringBuilder ExecutePreUpgradeChecksServiceURL = new StringBuilder("/upgrade?action=execute_pre_upgrade_checks");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Post
            };
            if (ComponentType != null) { request.AddQueryParameter("component_type", ComponentType.ToString()); }
            if (Cursor != null) { request.AddQueryParameter("cursor", Cursor.ToString()); }
            if (IncludedFields != null) { request.AddQueryParameter("included_fields", IncludedFields.ToString()); }
            if (PageSize != null) { request.AddQueryParameter("page_size", PageSize.ToString()); }
            if (SortAscending != null) { request.AddQueryParameter("sort_ascending", SortAscending.ToString()); }
            if (SortBy != null) { request.AddQueryParameter("sort_by", SortBy.ToString()); }
            request.Resource = ExecutePreUpgradeChecksServiceURL.ToString();
            RestResponse response = await restClient.ExecuteTaskAsyncWithPolicy(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Post operation to " + ExecutePreUpgradeChecksServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task StageUpgrade(string? ComponentType = null)
        {
            StringBuilder StageUpgradeServiceURL = new StringBuilder("/upgrade/plan?action=stage-upgrade");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Post
            };
            if (ComponentType != null) { request.AddQueryParameter("component_type", ComponentType.ToString()); }
            request.Resource = StageUpgradeServiceURL.ToString();
            RestResponse response = await restClient.ExecuteTaskAsyncWithPolicy(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Post operation to " + StageUpgradeServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task ReorderUpgradeUnit(string GroupId, string UpgradeUnitId, NSXTReorderRequestType ReorderRequest)
        {
            if (GroupId == null) { throw new System.ArgumentNullException("GroupId cannot be null"); }
            if (UpgradeUnitId == null) { throw new System.ArgumentNullException("UpgradeUnitId cannot be null"); }
            if (ReorderRequest == null) { throw new System.ArgumentNullException("ReorderRequest cannot be null"); }
            StringBuilder ReorderUpgradeUnitServiceURL = new StringBuilder("/upgrade/upgrade-unit-groups/{group-id}/upgrade-unit/{upgrade-unit-id}?action=reorder");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Post
            };
            ReorderUpgradeUnitServiceURL.Replace("{group-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(GroupId, System.Globalization.CultureInfo.InvariantCulture)));
            ReorderUpgradeUnitServiceURL.Replace("{upgrade-unit-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(UpgradeUnitId, System.Globalization.CultureInfo.InvariantCulture)));
            request.AddJsonBody(ReorderRequest);
            request.Resource = ReorderUpgradeUnitServiceURL.ToString();
            RestResponse response = await restClient.ExecuteTaskAsyncWithPolicy(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Post operation to " + ReorderUpgradeUnitServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTUpgradeUnitGroupStatusListResultType> GetUpgradeUnitGroupsStatus(string? ComponentType = null, string? Cursor = null, string? IncludedFields = null, long? PageSize = null, bool? SortAscending = null, string? SortBy = null)
        {
            StringBuilder GetUpgradeUnitGroupsStatusServiceURL = new StringBuilder("/upgrade/upgrade-unit-groups-status");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Get
            };
            if (ComponentType != null) { request.AddQueryParameter("component_type", ComponentType.ToString()); }
            if (Cursor != null) { request.AddQueryParameter("cursor", Cursor.ToString()); }
            if (IncludedFields != null) { request.AddQueryParameter("included_fields", IncludedFields.ToString()); }
            if (PageSize != null) { request.AddQueryParameter("page_size", PageSize.ToString()); }
            if (SortAscending != null) { request.AddQueryParameter("sort_ascending", SortAscending.ToString()); }
            if (SortBy != null) { request.AddQueryParameter("sort_by", SortBy.ToString()); }
            request.Resource = GetUpgradeUnitGroupsStatusServiceURL.ToString();
            RestResponse<NSXTUpgradeUnitGroupStatusListResultType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTUpgradeUnitGroupStatusListResultType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Get operation to " + GetUpgradeUnitGroupsStatusServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTUcUpgradeStatusType> GetUcUpgradeStatus()
        {
            StringBuilder GetUcUpgradeStatusServiceURL = new StringBuilder("/upgrade/uc-upgrade-status");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Get
            };
            request.Resource = GetUcUpgradeStatusServiceURL.ToString();
            RestResponse<NSXTUcUpgradeStatusType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTUcUpgradeStatusType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Get operation to " + GetUcUpgradeStatusServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTUpgradeUnitGroupAggregateInfoListResultType> GetUpgradeUnitGroupAggregateInfo(string? ComponentType = null, string? Cursor = null, string? IncludedFields = null, long? PageSize = null, bool? SortAscending = null, string? SortBy = null, bool? Summary = null, bool? Sync = null)
        {
            StringBuilder GetUpgradeUnitGroupAggregateInfoServiceURL = new StringBuilder("/upgrade/upgrade-unit-groups/aggregate-info");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Get
            };
            if (ComponentType != null) { request.AddQueryParameter("component_type", ComponentType.ToString()); }
            if (Cursor != null) { request.AddQueryParameter("cursor", Cursor.ToString()); }
            if (IncludedFields != null) { request.AddQueryParameter("included_fields", IncludedFields.ToString()); }
            if (PageSize != null) { request.AddQueryParameter("page_size", PageSize.ToString()); }
            if (SortAscending != null) { request.AddQueryParameter("sort_ascending", SortAscending.ToString()); }
            if (SortBy != null) { request.AddQueryParameter("sort_by", SortBy.ToString()); }
            if (Summary != null) { request.AddQueryParameter("summary", Summary.ToString()); }
            if (Sync != null) { request.AddQueryParameter("sync", Sync.ToString()); }
            request.Resource = GetUpgradeUnitGroupAggregateInfoServiceURL.ToString();
            RestResponse<NSXTUpgradeUnitGroupAggregateInfoListResultType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTUpgradeUnitGroupAggregateInfoListResultType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Get operation to " + GetUpgradeUnitGroupAggregateInfoServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTUpgradeUnitType> GetUpgradeUnit(string UpgradeUnitId)
        {
            if (UpgradeUnitId == null) { throw new System.ArgumentNullException("UpgradeUnitId cannot be null"); }
            StringBuilder GetUpgradeUnitServiceURL = new StringBuilder("/upgrade/upgrade-units/{upgrade-unit-id}");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Get
            };
            GetUpgradeUnitServiceURL.Replace("{upgrade-unit-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(UpgradeUnitId, System.Globalization.CultureInfo.InvariantCulture)));
            request.Resource = GetUpgradeUnitServiceURL.ToString();
            RestResponse<NSXTUpgradeUnitType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTUpgradeUnitType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Get operation to " + GetUpgradeUnitServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task ReorderUpgradeUnitGroup(string GroupId, NSXTReorderRequestType ReorderRequest)
        {
            if (GroupId == null) { throw new System.ArgumentNullException("GroupId cannot be null"); }
            if (ReorderRequest == null) { throw new System.ArgumentNullException("ReorderRequest cannot be null"); }
            StringBuilder ReorderUpgradeUnitGroupServiceURL = new StringBuilder("/upgrade/upgrade-unit-groups/{group-id}?action=reorder");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Post
            };
            ReorderUpgradeUnitGroupServiceURL.Replace("{group-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(GroupId, System.Globalization.CultureInfo.InvariantCulture)));
            request.AddJsonBody(ReorderRequest);
            request.Resource = ReorderUpgradeUnitGroupServiceURL.ToString();
            RestResponse response = await restClient.ExecuteTaskAsyncWithPolicy(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Post operation to " + ReorderUpgradeUnitGroupServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTUpgradeBundleUploadStatusType> GetUpgradeBundleUploadStatus(string BundleId)
        {
            if (BundleId == null) { throw new System.ArgumentNullException("BundleId cannot be null"); }
            StringBuilder GetUpgradeBundleUploadStatusServiceURL = new StringBuilder("/upgrade/bundles/{bundle-id}/upload-status");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Get
            };
            GetUpgradeBundleUploadStatusServiceURL.Replace("{bundle-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(BundleId, System.Globalization.CultureInfo.InvariantCulture)));
            request.Resource = GetUpgradeBundleUploadStatusServiceURL.ToString();
            RestResponse<NSXTUpgradeBundleUploadStatusType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTUpgradeBundleUploadStatusType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Get operation to " + GetUpgradeBundleUploadStatusServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task ContinueUpgrade(string? ComponentType = null, bool? Skip = null)
        {
            StringBuilder ContinueUpgradeServiceURL = new StringBuilder("/upgrade/plan?action=continue");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Post
            };
            if (ComponentType != null) { request.AddQueryParameter("component_type", ComponentType.ToString()); }
            if (Skip != null) { request.AddQueryParameter("skip", Skip.ToString()); }
            request.Resource = ContinueUpgradeServiceURL.ToString();
            RestResponse response = await restClient.ExecuteTaskAsyncWithPolicy(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Post operation to " + ContinueUpgradeServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task CancelUpgradeBundleUpload(string BundleId)
        {
            if (BundleId == null) { throw new System.ArgumentNullException("BundleId cannot be null"); }
            StringBuilder CancelUpgradeBundleUploadServiceURL = new StringBuilder("/upgrade/bundles/{bundle-id}?action=cancel_upload");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Post
            };
            CancelUpgradeBundleUploadServiceURL.Replace("{bundle-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(BundleId, System.Globalization.CultureInfo.InvariantCulture)));
            request.Resource = CancelUpgradeBundleUploadServiceURL.ToString();
            RestResponse response = await restClient.ExecuteTaskAsyncWithPolicy(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Post operation to " + CancelUpgradeBundleUploadServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTUpgradeUnitListType> AddUpgradeUnitsToGroup(string GroupId, NSXTUpgradeUnitListType UpgradeUnitList)
        {
            if (GroupId == null) { throw new System.ArgumentNullException("GroupId cannot be null"); }
            if (UpgradeUnitList == null) { throw new System.ArgumentNullException("UpgradeUnitList cannot be null"); }
            StringBuilder AddUpgradeUnitsToGroupServiceURL = new StringBuilder("/upgrade/upgrade-unit-groups/{group-id}?action=add_upgrade_units");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Post
            };
            AddUpgradeUnitsToGroupServiceURL.Replace("{group-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(GroupId, System.Globalization.CultureInfo.InvariantCulture)));
            request.AddJsonBody(UpgradeUnitList);
            request.Resource = AddUpgradeUnitsToGroupServiceURL.ToString();
            RestResponse<NSXTUpgradeUnitListType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTUpgradeUnitListType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Post operation to " + AddUpgradeUnitsToGroupServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task ExecutePostUpgradeChecks(string ComponentType)
        {
            if (ComponentType == null) { throw new System.ArgumentNullException("ComponentType cannot be null"); }
            StringBuilder ExecutePostUpgradeChecksServiceURL = new StringBuilder("/upgrade/{component-type}?action=execute_post_upgrade_checks");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Post
            };
            ExecutePostUpgradeChecksServiceURL.Replace("{component-type}", System.Uri.EscapeDataString(Helpers.ConvertToString(ComponentType, System.Globalization.CultureInfo.InvariantCulture)));
            request.Resource = ExecutePostUpgradeChecksServiceURL.ToString();
            RestResponse response = await restClient.ExecuteTaskAsyncWithPolicy(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Post operation to " + ExecutePostUpgradeChecksServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task AbortPreUpgradeChecks()
        {
            StringBuilder AbortPreUpgradeChecksServiceURL = new StringBuilder("/upgrade?action=abort_pre_upgrade_checks");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Post
            };
            request.Resource = AbortPreUpgradeChecksServiceURL.ToString();
            RestResponse response = await restClient.ExecuteTaskAsyncWithPolicy(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Post operation to " + AbortPreUpgradeChecksServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTUpgradeUnitListResultType> GetUpgradeUnits(string? ComponentType = null, string? CurrentVersion = null, string? Cursor = null, string? GroupId = null, bool? HasWarnings = null, string? IncludedFields = null, string? Metadata = null, long? PageSize = null, bool? SortAscending = null, string? SortBy = null, string? UpgradeUnitType = null)
        {
            StringBuilder GetUpgradeUnitsServiceURL = new StringBuilder("/upgrade/upgrade-units");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Get
            };
            if (ComponentType != null) { request.AddQueryParameter("component_type", ComponentType.ToString()); }
            if (CurrentVersion != null) { request.AddQueryParameter("current_version", CurrentVersion.ToString()); }
            if (Cursor != null) { request.AddQueryParameter("cursor", Cursor.ToString()); }
            if (GroupId != null) { request.AddQueryParameter("group_id", GroupId.ToString()); }
            if (HasWarnings != null) { request.AddQueryParameter("has_warnings", HasWarnings.ToString()); }
            if (IncludedFields != null) { request.AddQueryParameter("included_fields", IncludedFields.ToString()); }
            if (Metadata != null) { request.AddQueryParameter("metadata", Metadata.ToString()); }
            if (PageSize != null) { request.AddQueryParameter("page_size", PageSize.ToString()); }
            if (SortAscending != null) { request.AddQueryParameter("sort_ascending", SortAscending.ToString()); }
            if (SortBy != null) { request.AddQueryParameter("sort_by", SortBy.ToString()); }
            if (UpgradeUnitType != null) { request.AddQueryParameter("upgrade_unit_type", UpgradeUnitType.ToString()); }
            request.Resource = GetUpgradeUnitsServiceURL.ToString();
            RestResponse<NSXTUpgradeUnitListResultType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTUpgradeUnitListResultType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Get operation to " + GetUpgradeUnitsServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTUpgradeBundleIdType> FetchUpgradeBundleFromUrl(NSXTUpgradeBundleFetchRequestType UpgradeBundleFetchRequest)
        {
            if (UpgradeBundleFetchRequest == null) { throw new System.ArgumentNullException("UpgradeBundleFetchRequest cannot be null"); }
            StringBuilder FetchUpgradeBundleFromUrlServiceURL = new StringBuilder("/upgrade/bundles");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Post
            };
            request.AddJsonBody(UpgradeBundleFetchRequest);
            request.Resource = FetchUpgradeBundleFromUrlServiceURL.ToString();
            RestResponse<NSXTUpgradeBundleIdType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTUpgradeBundleIdType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Post operation to " + FetchUpgradeBundleFromUrlServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTComponentUpgradeChecksInfoListResultType> GetUpgradeChecksInfo(string? ComponentType = null, string? Cursor = null, string? IncludedFields = null, long? PageSize = null, bool? SortAscending = null, string? SortBy = null)
        {
            StringBuilder GetUpgradeChecksInfoServiceURL = new StringBuilder("/upgrade/upgrade-checks-info");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Get
            };
            if (ComponentType != null) { request.AddQueryParameter("component_type", ComponentType.ToString()); }
            if (Cursor != null) { request.AddQueryParameter("cursor", Cursor.ToString()); }
            if (IncludedFields != null) { request.AddQueryParameter("included_fields", IncludedFields.ToString()); }
            if (PageSize != null) { request.AddQueryParameter("page_size", PageSize.ToString()); }
            if (SortAscending != null) { request.AddQueryParameter("sort_ascending", SortAscending.ToString()); }
            if (SortBy != null) { request.AddQueryParameter("sort_by", SortBy.ToString()); }
            request.Resource = GetUpgradeChecksInfoServiceURL.ToString();
            RestResponse<NSXTComponentUpgradeChecksInfoListResultType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTComponentUpgradeChecksInfoListResultType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Get operation to " + GetUpgradeChecksInfoServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTUpgradeStatusType> GetUpgradeStatusSummary(string? ComponentType = null, string? SelectionStatus = null, bool? ShowHistory = null)
        {
            StringBuilder GetUpgradeStatusSummaryServiceURL = new StringBuilder("/upgrade/status-summary");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Get
            };
            if (ComponentType != null) { request.AddQueryParameter("component_type", ComponentType.ToString()); }
            if (SelectionStatus != null) { request.AddQueryParameter("selection_status", SelectionStatus.ToString()); }
            if (ShowHistory != null) { request.AddQueryParameter("show_history", ShowHistory.ToString()); }
            request.Resource = GetUpgradeStatusSummaryServiceURL.ToString();
            RestResponse<NSXTUpgradeStatusType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTUpgradeStatusType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Get operation to " + GetUpgradeStatusSummaryServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTUpgradeUnitGroupType> UpdateUpgradeUnitGroup(string GroupId, NSXTUpgradeUnitGroupType UpgradeUnitGroup)
        {
            if (GroupId == null) { throw new System.ArgumentNullException("GroupId cannot be null"); }
            if (UpgradeUnitGroup == null) { throw new System.ArgumentNullException("UpgradeUnitGroup cannot be null"); }
            StringBuilder UpdateUpgradeUnitGroupServiceURL = new StringBuilder("/upgrade/upgrade-unit-groups/{group-id}");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Put
            };
            UpdateUpgradeUnitGroupServiceURL.Replace("{group-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(GroupId, System.Globalization.CultureInfo.InvariantCulture)));
            request.AddJsonBody(UpgradeUnitGroup);
            request.Resource = UpdateUpgradeUnitGroupServiceURL.ToString();
            RestResponse<NSXTUpgradeUnitGroupType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTUpgradeUnitGroupType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Put operation to " + UpdateUpgradeUnitGroupServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task DeleteUpgradeUnitGroup(string GroupId)
        {
            if (GroupId == null) { throw new System.ArgumentNullException("GroupId cannot be null"); }
            StringBuilder DeleteUpgradeUnitGroupServiceURL = new StringBuilder("/upgrade/upgrade-unit-groups/{group-id}");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Delete
            };
            DeleteUpgradeUnitGroupServiceURL.Replace("{group-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(GroupId, System.Globalization.CultureInfo.InvariantCulture)));
            request.Resource = DeleteUpgradeUnitGroupServiceURL.ToString();
            RestResponse response = await restClient.ExecuteTaskAsyncWithPolicy(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Delete operation to " + DeleteUpgradeUnitGroupServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTUpgradeUnitGroupType> GetUpgradeUnitGroup(string GroupId, bool? Summary = null)
        {
            if (GroupId == null) { throw new System.ArgumentNullException("GroupId cannot be null"); }
            StringBuilder GetUpgradeUnitGroupServiceURL = new StringBuilder("/upgrade/upgrade-unit-groups/{group-id}");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Get
            };
            GetUpgradeUnitGroupServiceURL.Replace("{group-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(GroupId, System.Globalization.CultureInfo.InvariantCulture)));
            if (Summary != null) { request.AddQueryParameter("summary", Summary.ToString()); }
            request.Resource = GetUpgradeUnitGroupServiceURL.ToString();
            RestResponse<NSXTUpgradeUnitGroupType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTUpgradeUnitGroupType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Get operation to " + GetUpgradeUnitGroupServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTUpgradeUnitStatusListResultType> GetUpgradeUnitGroupStatus(string GroupId, string? Cursor = null, bool? HasErrors = null, string? IncludedFields = null, long? PageSize = null, bool? SortAscending = null, string? SortBy = null)
        {
            if (GroupId == null) { throw new System.ArgumentNullException("GroupId cannot be null"); }
            StringBuilder GetUpgradeUnitGroupStatusServiceURL = new StringBuilder("/upgrade/upgrade-unit-groups/{group-id}/status");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Get
            };
            GetUpgradeUnitGroupStatusServiceURL.Replace("{group-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(GroupId, System.Globalization.CultureInfo.InvariantCulture)));
            if (Cursor != null) { request.AddQueryParameter("cursor", Cursor.ToString()); }
            if (HasErrors != null) { request.AddQueryParameter("has_errors", HasErrors.ToString()); }
            if (IncludedFields != null) { request.AddQueryParameter("included_fields", IncludedFields.ToString()); }
            if (PageSize != null) { request.AddQueryParameter("page_size", PageSize.ToString()); }
            if (SortAscending != null) { request.AddQueryParameter("sort_ascending", SortAscending.ToString()); }
            if (SortBy != null) { request.AddQueryParameter("sort_by", SortBy.ToString()); }
            request.Resource = GetUpgradeUnitGroupStatusServiceURL.ToString();
            RestResponse<NSXTUpgradeUnitStatusListResultType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTUpgradeUnitStatusListResultType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Get operation to " + GetUpgradeUnitGroupStatusServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTUpgradeCheckCsvListResultType> GetAllPreUpgradeChecksInCsvFormat()
        {
            StringBuilder GetAllPreUpgradeChecksInCsvFormatServiceURL = new StringBuilder("/upgrade/pre-upgrade-checks?format=csv");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Get
            };
            request.Resource = GetAllPreUpgradeChecksInCsvFormatServiceURL.ToString();
            RestResponse<NSXTUpgradeCheckCsvListResultType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTUpgradeCheckCsvListResultType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Get operation to " + GetAllPreUpgradeChecksInCsvFormatServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task UpgradeSelectedUnits(NSXTUpgradeUnitListType UpgradeUnitList)
        {
            if (UpgradeUnitList == null) { throw new System.ArgumentNullException("UpgradeUnitList cannot be null"); }
            StringBuilder UpgradeSelectedUnitsServiceURL = new StringBuilder("/upgrade/plan?action=upgrade_selected_units");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Post
            };
            request.AddJsonBody(UpgradeUnitList);
            request.Resource = UpgradeSelectedUnitsServiceURL.ToString();
            RestResponse response = await restClient.ExecuteTaskAsyncWithPolicy(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Post operation to " + UpgradeSelectedUnitsServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTUpgradeSummaryType> GetUpgradeSummary()
        {
            StringBuilder GetUpgradeSummaryServiceURL = new StringBuilder("/upgrade/summary");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Get
            };
            request.Resource = GetUpgradeSummaryServiceURL.ToString();
            RestResponse<NSXTUpgradeSummaryType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTUpgradeSummaryType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Get operation to " + GetUpgradeSummaryServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTUpgradeCheckFailureListResultType> GetPreUpgradeCheckFailures(string? ComponentType = null, string? Cursor = null, string? FilterText = null, string? IncludedFields = null, string? OriginType = null, long? PageSize = null, bool? SortAscending = null, string? SortBy = null, string? Type = null)
        {
            StringBuilder GetPreUpgradeCheckFailuresServiceURL = new StringBuilder("/upgrade/pre-upgrade-checks/failures");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Get
            };
            if (ComponentType != null) { request.AddQueryParameter("component_type", ComponentType.ToString()); }
            if (Cursor != null) { request.AddQueryParameter("cursor", Cursor.ToString()); }
            if (FilterText != null) { request.AddQueryParameter("filter_text", FilterText.ToString()); }
            if (IncludedFields != null) { request.AddQueryParameter("included_fields", IncludedFields.ToString()); }
            if (OriginType != null) { request.AddQueryParameter("origin_type", OriginType.ToString()); }
            if (PageSize != null) { request.AddQueryParameter("page_size", PageSize.ToString()); }
            if (SortAscending != null) { request.AddQueryParameter("sort_ascending", SortAscending.ToString()); }
            if (SortBy != null) { request.AddQueryParameter("sort_by", SortBy.ToString()); }
            if (Type != null) { request.AddQueryParameter("type", Type.ToString()); }
            request.Resource = GetPreUpgradeCheckFailuresServiceURL.ToString();
            RestResponse<NSXTUpgradeCheckFailureListResultType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTUpgradeCheckFailureListResultType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Get operation to " + GetPreUpgradeCheckFailuresServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTNodeInfoListResultType> GetNodes(string? ComponentType = null, string? ComponentVersion = null, string? Cursor = null, string? IncludedFields = null, long? PageSize = null, bool? SortAscending = null, string? SortBy = null)
        {
            StringBuilder GetNodesServiceURL = new StringBuilder("/upgrade/nodes");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Get
            };
            if (ComponentType != null) { request.AddQueryParameter("component_type", ComponentType.ToString()); }
            if (ComponentVersion != null) { request.AddQueryParameter("component_version", ComponentVersion.ToString()); }
            if (Cursor != null) { request.AddQueryParameter("cursor", Cursor.ToString()); }
            if (IncludedFields != null) { request.AddQueryParameter("included_fields", IncludedFields.ToString()); }
            if (PageSize != null) { request.AddQueryParameter("page_size", PageSize.ToString()); }
            if (SortAscending != null) { request.AddQueryParameter("sort_ascending", SortAscending.ToString()); }
            if (SortBy != null) { request.AddQueryParameter("sort_by", SortBy.ToString()); }
            request.Resource = GetNodesServiceURL.ToString();
            RestResponse<NSXTNodeInfoListResultType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTNodeInfoListResultType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Get operation to " + GetNodesServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTUcFunctionalStateType> GetUcFunctionalState()
        {
            StringBuilder GetUcFunctionalStateServiceURL = new StringBuilder("/upgrade/functional-state");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Get
            };
            request.Resource = GetUcFunctionalStateServiceURL.ToString();
            RestResponse<NSXTUcFunctionalStateType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTUcFunctionalStateType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Get operation to " + GetUcFunctionalStateServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTUpgradeHistoryListType> GetUpgradeHistory()
        {
            StringBuilder GetUpgradeHistoryServiceURL = new StringBuilder("/upgrade/history");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Get
            };
            request.Resource = GetUpgradeHistoryServiceURL.ToString();
            RestResponse<NSXTUpgradeHistoryListType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTUpgradeHistoryListType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Get operation to " + GetUpgradeHistoryServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTUpgradeBundleIdType> UploadUpgradeBundleAsync(string File)
        {
            if (File == null) { throw new System.ArgumentNullException("File cannot be null"); }
            StringBuilder UploadUpgradeBundleAsyncServiceURL = new StringBuilder("/upgrade/bundles?action=upload");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Post
            };
            
            request.Resource = UploadUpgradeBundleAsyncServiceURL.ToString();
            RestResponse<NSXTUpgradeBundleIdType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTUpgradeBundleIdType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Post operation to " + UploadUpgradeBundleAsyncServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTUpgradePlanSettingsType> UpdateUpgradePlanSettings(string ComponentType, NSXTUpgradePlanSettingsType UpgradePlanSettings)
        {
            if (ComponentType == null) { throw new System.ArgumentNullException("ComponentType cannot be null"); }
            if (UpgradePlanSettings == null) { throw new System.ArgumentNullException("UpgradePlanSettings cannot be null"); }
            StringBuilder UpdateUpgradePlanSettingsServiceURL = new StringBuilder("/upgrade/plan/{component_type}/settings");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Put
            };
            UpdateUpgradePlanSettingsServiceURL.Replace("{component_type}", System.Uri.EscapeDataString(Helpers.ConvertToString(ComponentType, System.Globalization.CultureInfo.InvariantCulture)));
            request.AddJsonBody(UpgradePlanSettings);
            request.Resource = UpdateUpgradePlanSettingsServiceURL.ToString();
            RestResponse<NSXTUpgradePlanSettingsType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTUpgradePlanSettingsType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Put operation to " + UpdateUpgradePlanSettingsServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTUpgradePlanSettingsType> GetUpgradePlanSettings(string ComponentType)
        {
            if (ComponentType == null) { throw new System.ArgumentNullException("ComponentType cannot be null"); }
            StringBuilder GetUpgradePlanSettingsServiceURL = new StringBuilder("/upgrade/plan/{component_type}/settings");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Get
            };
            GetUpgradePlanSettingsServiceURL.Replace("{component_type}", System.Uri.EscapeDataString(Helpers.ConvertToString(ComponentType, System.Globalization.CultureInfo.InvariantCulture)));
            request.Resource = GetUpgradePlanSettingsServiceURL.ToString();
            RestResponse<NSXTUpgradePlanSettingsType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTUpgradePlanSettingsType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Get operation to " + GetUpgradePlanSettingsServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task ResetUpgradePlan(string ComponentType)
        {
            if (ComponentType == null) { throw new System.ArgumentNullException("ComponentType cannot be null"); }
            StringBuilder ResetUpgradePlanServiceURL = new StringBuilder("/upgrade/plan?action=reset");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Post
            };
            if (ComponentType != null) { request.AddQueryParameter("component_type", ComponentType.ToString()); }
            request.Resource = ResetUpgradePlanServiceURL.ToString();
            RestResponse response = await restClient.ExecuteTaskAsyncWithPolicy(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Post operation to " + ResetUpgradePlanServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            
        }
    }
}
