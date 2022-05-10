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
    public class Migration
    {
        private RestClient restClient;
        private int retry;
        private int timeout;
        private CancellationToken cancellationToken;

        public Migration(RestClient Client, CancellationToken _cancellationToken, int _timeout, int _retry)
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
        public async Task<NSXTLogicalConstructMigrationStatsListResultType> GetLogicalConstructMigrationStats(string? Cursor = null, string? IncludedFields = null, long? PageSize = null, bool? SortAscending = null, string? SortBy = null)
        {
            StringBuilder GetLogicalConstructMigrationStatsServiceURL = new StringBuilder("/migration/logical-constructs/stats");
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
            request.Resource = GetLogicalConstructMigrationStatsServiceURL.ToString();
            RestResponse<NSXTLogicalConstructMigrationStatsListResultType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTLogicalConstructMigrationStatsListResultType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Get operation to " + GetLogicalConstructMigrationStatsServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTMigrationSwitchListResultType> GetMigratedSwitches(string? Cursor = null, string? IncludedFields = null, long? PageSize = null, bool? SortAscending = null, string? SortBy = null)
        {
            StringBuilder GetMigratedSwitchesServiceURL = new StringBuilder("/migration/migrated-switches");
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
            request.Resource = GetMigratedSwitchesServiceURL.ToString();
            RestResponse<NSXTMigrationSwitchListResultType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTMigrationSwitchListResultType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Get operation to " + GetMigratedSwitchesServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTMigrationFeedbackSummaryListResultType> GetFeedbackSummary(string? Cursor = null, string? IncludedFields = null, string? NetworkLayer = null, long? PageSize = null, bool? SortAscending = null, string? SortBy = null)
        {
            StringBuilder GetFeedbackSummaryServiceURL = new StringBuilder("/migration/feedback-summary");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Get
            };
            if (Cursor != null) { request.AddQueryParameter("cursor", Cursor.ToString()); }
            if (IncludedFields != null) { request.AddQueryParameter("included_fields", IncludedFields.ToString()); }
            if (NetworkLayer != null) { request.AddQueryParameter("network_layer", NetworkLayer.ToString()); }
            if (PageSize != null) { request.AddQueryParameter("page_size", PageSize.ToString()); }
            if (SortAscending != null) { request.AddQueryParameter("sort_ascending", SortAscending.ToString()); }
            if (SortBy != null) { request.AddQueryParameter("sort_by", SortBy.ToString()); }
            request.Resource = GetFeedbackSummaryServiceURL.ToString();
            RestResponse<NSXTMigrationFeedbackSummaryListResultType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTMigrationFeedbackSummaryListResultType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Get operation to " + GetFeedbackSummaryServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task AbortMigration()
        {
            StringBuilder AbortMigrationServiceURL = new StringBuilder("/migration/plan?action=abort");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Post
            };
            request.Resource = AbortMigrationServiceURL.ToString();
            RestResponse response = await restClient.ExecuteTaskAsyncWithPolicy(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Post operation to " + AbortMigrationServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTMigrationStatusType> GetMigrationStatusSummary(string? ComponentType = null)
        {
            StringBuilder GetMigrationStatusSummaryServiceURL = new StringBuilder("/migration/status-summary");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Get
            };
            if (ComponentType != null) { request.AddQueryParameter("component_type", ComponentType.ToString()); }
            request.Resource = GetMigrationStatusSummaryServiceURL.ToString();
            RestResponse<NSXTMigrationStatusType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTMigrationStatusType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Get operation to " + GetMigrationStatusSummaryServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task StartMigration()
        {
            StringBuilder StartMigrationServiceURL = new StringBuilder("/migration/plan?action=start");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Post
            };
            request.Resource = StartMigrationServiceURL.ToString();
            RestResponse response = await restClient.ExecuteTaskAsyncWithPolicy(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Post operation to " + StartMigrationServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTMigrationUnitTypeStatsListType> GetMigrationUnitsStats(string? Cursor = null, string? IncludedFields = null, long? PageSize = null, bool? SortAscending = null, string? SortBy = null, bool? Sync = null)
        {
            StringBuilder GetMigrationUnitsStatsServiceURL = new StringBuilder("/migration/migration-units-stats");
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
            request.Resource = GetMigrationUnitsStatsServiceURL.ToString();
            RestResponse<NSXTMigrationUnitTypeStatsListType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTMigrationUnitTypeStatsListType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Get operation to " + GetMigrationUnitsStatsServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task SetEsgToRouterMappingOption(string MappingOption)
        {
            if (MappingOption == null) { throw new System.ArgumentNullException("MappingOption cannot be null"); }
            StringBuilder SetEsgToRouterMappingOptionServiceURL = new StringBuilder("/migration/setup?action=setEsgToRouterMappingOption");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Put
            };
            if (MappingOption != null) { request.AddQueryParameter("mapping_option", MappingOption.ToString()); }
            request.Resource = SetEsgToRouterMappingOptionServiceURL.ToString();
            RestResponse response = await restClient.ExecuteTaskAsyncWithPolicy(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Put operation to " + SetEsgToRouterMappingOptionServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task FinalizeInfra()
        {
            StringBuilder FinalizeInfraServiceURL = new StringBuilder("/migration?action=finalize_infra");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Post
            };
            request.Resource = FinalizeInfraServiceURL.ToString();
            RestResponse response = await restClient.ExecuteTaskAsyncWithPolicy(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Post operation to " + FinalizeInfraServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task AcceptRecommendedValueInFeedback(string? NetworkLayer = null)
        {
            StringBuilder AcceptRecommendedValueInFeedbackServiceURL = new StringBuilder("/migration/feedback-response?action=accept-recommended");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Post
            };
            if (NetworkLayer != null) { request.AddQueryParameter("network_layer", NetworkLayer.ToString()); }
            request.Resource = AcceptRecommendedValueInFeedbackServiceURL.ToString();
            RestResponse response = await restClient.ExecuteTaskAsyncWithPolicy(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Post operation to " + AcceptRecommendedValueInFeedbackServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task PostVmGroupMigrate(NSXTPostVmGroupMigrationSpecType PostVmGroupMigrationSpec)
        {
            if (PostVmGroupMigrationSpec == null) { throw new System.ArgumentNullException("PostVmGroupMigrationSpec cannot be null"); }
            StringBuilder PostVmGroupMigrateServiceURL = new StringBuilder("/migration/vmgroup?action=post_migrate");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Post
            };
            request.AddJsonBody(PostVmGroupMigrationSpec);
            request.Resource = PostVmGroupMigrateServiceURL.ToString();
            RestResponse response = await restClient.ExecuteTaskAsyncWithPolicy(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Post operation to " + PostVmGroupMigrateServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task ReorderMigrationUnit(string GroupId, string MigrationUnitId, NSXTReorderMigrationRequestType ReorderMigrationRequest)
        {
            if (GroupId == null) { throw new System.ArgumentNullException("GroupId cannot be null"); }
            if (MigrationUnitId == null) { throw new System.ArgumentNullException("MigrationUnitId cannot be null"); }
            if (ReorderMigrationRequest == null) { throw new System.ArgumentNullException("ReorderMigrationRequest cannot be null"); }
            StringBuilder ReorderMigrationUnitServiceURL = new StringBuilder("/migration/migration-unit-groups/{group-id}/migration-unit/{migration-unit-id}?action=reorder");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Post
            };
            ReorderMigrationUnitServiceURL.Replace("{group-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(GroupId, System.Globalization.CultureInfo.InvariantCulture)));
            ReorderMigrationUnitServiceURL.Replace("{migration-unit-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(MigrationUnitId, System.Globalization.CultureInfo.InvariantCulture)));
            request.AddJsonBody(ReorderMigrationRequest);
            request.Resource = ReorderMigrationUnitServiceURL.ToString();
            RestResponse response = await restClient.ExecuteTaskAsyncWithPolicy(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Post operation to " + ReorderMigrationUnitServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task ResetMigrationPlan(string ComponentType)
        {
            if (ComponentType == null) { throw new System.ArgumentNullException("ComponentType cannot be null"); }
            StringBuilder ResetMigrationPlanServiceURL = new StringBuilder("/migration/plan?action=reset");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Post
            };
            if (ComponentType != null) { request.AddQueryParameter("component_type", ComponentType.ToString()); }
            request.Resource = ResetMigrationPlanServiceURL.ToString();
            RestResponse response = await restClient.ExecuteTaskAsyncWithPolicy(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Post operation to " + ResetMigrationPlanServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTMigrationUnitGroupStatusListResultType> GetMigrationUnitGroupsStatus(string? ComponentType = null, string? Cursor = null, string? IncludedFields = null, long? PageSize = null, bool? SortAscending = null, string? SortBy = null)
        {
            StringBuilder GetMigrationUnitGroupsStatusServiceURL = new StringBuilder("/migration/migration-unit-groups-status");
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
            request.Resource = GetMigrationUnitGroupsStatusServiceURL.ToString();
            RestResponse<NSXTMigrationUnitGroupStatusListResultType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTMigrationUnitGroupStatusListResultType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Get operation to " + GetMigrationUnitGroupsStatusServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task PauseMigration()
        {
            StringBuilder PauseMigrationServiceURL = new StringBuilder("/migration/plan?action=pause");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Post
            };
            request.Resource = PauseMigrationServiceURL.ToString();
            RestResponse response = await restClient.ExecuteTaskAsyncWithPolicy(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Post operation to " + PauseMigrationServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTMigrationUnitListType> AddMigrationUnitsToGroup(string GroupId, NSXTMigrationUnitListType MigrationUnitList)
        {
            if (GroupId == null) { throw new System.ArgumentNullException("GroupId cannot be null"); }
            if (MigrationUnitList == null) { throw new System.ArgumentNullException("MigrationUnitList cannot be null"); }
            StringBuilder AddMigrationUnitsToGroupServiceURL = new StringBuilder("/migration/migration-unit-groups/{group-id}?action=add_migration_units");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Post
            };
            AddMigrationUnitsToGroupServiceURL.Replace("{group-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(GroupId, System.Globalization.CultureInfo.InvariantCulture)));
            request.AddJsonBody(MigrationUnitList);
            request.Resource = AddMigrationUnitsToGroupServiceURL.ToString();
            RestResponse<NSXTMigrationUnitListType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTMigrationUnitListType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Post operation to " + AddMigrationUnitsToGroupServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTMigrationUnitStatusListResultType> GetMigrationUnitGroupStatus(string GroupId, string? Cursor = null, bool? HasErrors = null, string? IncludedFields = null, long? PageSize = null, bool? SortAscending = null, string? SortBy = null)
        {
            if (GroupId == null) { throw new System.ArgumentNullException("GroupId cannot be null"); }
            StringBuilder GetMigrationUnitGroupStatusServiceURL = new StringBuilder("/migration/migration-unit-groups/{group-id}/status");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Get
            };
            GetMigrationUnitGroupStatusServiceURL.Replace("{group-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(GroupId, System.Globalization.CultureInfo.InvariantCulture)));
            if (Cursor != null) { request.AddQueryParameter("cursor", Cursor.ToString()); }
            if (HasErrors != null) { request.AddQueryParameter("has_errors", HasErrors.ToString()); }
            if (IncludedFields != null) { request.AddQueryParameter("included_fields", IncludedFields.ToString()); }
            if (PageSize != null) { request.AddQueryParameter("page_size", PageSize.ToString()); }
            if (SortAscending != null) { request.AddQueryParameter("sort_ascending", SortAscending.ToString()); }
            if (SortBy != null) { request.AddQueryParameter("sort_by", SortBy.ToString()); }
            request.Resource = GetMigrationUnitGroupStatusServiceURL.ToString();
            RestResponse<NSXTMigrationUnitStatusListResultType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTMigrationUnitStatusListResultType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Get operation to " + GetMigrationUnitGroupStatusServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTMigrationUnitGroupType> CreateMigrationUnitGroup(NSXTMigrationUnitGroupType MigrationUnitGroup)
        {
            if (MigrationUnitGroup == null) { throw new System.ArgumentNullException("MigrationUnitGroup cannot be null"); }
            StringBuilder CreateMigrationUnitGroupServiceURL = new StringBuilder("/migration/migration-unit-groups");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Post
            };
            request.AddJsonBody(MigrationUnitGroup);
            request.Resource = CreateMigrationUnitGroupServiceURL.ToString();
            RestResponse<NSXTMigrationUnitGroupType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTMigrationUnitGroupType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Post operation to " + CreateMigrationUnitGroupServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTMigrationUnitGroupListResultType> GetMigrationUnitGroups(string? ComponentType = null, string? Cursor = null, string? IncludedFields = null, long? PageSize = null, bool? SortAscending = null, string? SortBy = null, bool? Summary = null, bool? Sync = null)
        {
            StringBuilder GetMigrationUnitGroupsServiceURL = new StringBuilder("/migration/migration-unit-groups");
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
            request.Resource = GetMigrationUnitGroupsServiceURL.ToString();
            RestResponse<NSXTMigrationUnitGroupListResultType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTMigrationUnitGroupListResultType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Get operation to " + GetMigrationUnitGroupsServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task StartRollbackMigration()
        {
            StringBuilder StartRollbackMigrationServiceURL = new StringBuilder("/migration/plan?action=rollback");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Post
            };
            request.Resource = StartRollbackMigrationServiceURL.ToString();
            RestResponse response = await restClient.ExecuteTaskAsyncWithPolicy(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Post operation to " + StartRollbackMigrationServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTNodeSummaryListType> GetMigrationNodesSummary()
        {
            StringBuilder GetMigrationNodesSummaryServiceURL = new StringBuilder("/migration/nodes-summary");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Get
            };
            request.Resource = GetMigrationNodesSummaryServiceURL.ToString();
            RestResponse<NSXTNodeSummaryListType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTNodeSummaryListType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Get operation to " + GetMigrationNodesSummaryServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTGroupedMigrationFeedbackRequestListResultType> GetGroupedFeedbackRequests(string? Category = null, string? Cursor = null, string? FederationSiteId = null, string? Hash = null, string? IncludedFields = null, string? NetworkLayer = null, long? PageSize = null, bool? SortAscending = null, string? SortBy = null, string? State = null, string? SubCategory = null)
        {
            StringBuilder GetGroupedFeedbackRequestsServiceURL = new StringBuilder("/migration/grouped-feedback-requests");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Get
            };
            if (Category != null) { request.AddQueryParameter("category", Category.ToString()); }
            if (Cursor != null) { request.AddQueryParameter("cursor", Cursor.ToString()); }
            if (FederationSiteId != null) { request.AddQueryParameter("federation_site_id", FederationSiteId.ToString()); }
            if (Hash != null) { request.AddQueryParameter("hash", Hash.ToString()); }
            if (IncludedFields != null) { request.AddQueryParameter("included_fields", IncludedFields.ToString()); }
            if (NetworkLayer != null) { request.AddQueryParameter("network_layer", NetworkLayer.ToString()); }
            if (PageSize != null) { request.AddQueryParameter("page_size", PageSize.ToString()); }
            if (SortAscending != null) { request.AddQueryParameter("sort_ascending", SortAscending.ToString()); }
            if (SortBy != null) { request.AddQueryParameter("sort_by", SortBy.ToString()); }
            if (State != null) { request.AddQueryParameter("state", State.ToString()); }
            if (SubCategory != null) { request.AddQueryParameter("sub_category", SubCategory.ToString()); }
            request.Resource = GetGroupedFeedbackRequestsServiceURL.ToString();
            RestResponse<NSXTGroupedMigrationFeedbackRequestListResultType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTGroupedMigrationFeedbackRequestListResultType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Get operation to " + GetGroupedFeedbackRequestsServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task AddAlbInfo(NSXTAviEndPointType AviEndPoint)
        {
            if (AviEndPoint == null) { throw new System.ArgumentNullException("AviEndPoint cannot be null"); }
            StringBuilder AddAlbInfoServiceURL = new StringBuilder("/migration/setup?action=addAlbInfo");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Put
            };
            request.AddJsonBody(AviEndPoint);
            request.Resource = AddAlbInfoServiceURL.ToString();
            RestResponse response = await restClient.ExecuteTaskAsyncWithPolicy(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Put operation to " + AddAlbInfoServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTNodeInfoListResultType> GetMigrationNodes(string? ComponentType = null, string? ComponentVersion = null, string? Cursor = null, string? IncludedFields = null, long? PageSize = null, bool? SortAscending = null, string? SortBy = null)
        {
            StringBuilder GetMigrationNodesServiceURL = new StringBuilder("/migration/nodes");
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
            request.Resource = GetMigrationNodesServiceURL.ToString();
            RestResponse<NSXTNodeInfoListResultType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTNodeInfoListResultType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Get operation to " + GetMigrationNodesServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTMigrationSetupInfoType> UpdateNsxvSetupDetails(NSXTMigrationSetupInfoType MigrationSetupInfo)
        {
            if (MigrationSetupInfo == null) { throw new System.ArgumentNullException("MigrationSetupInfo cannot be null"); }
            StringBuilder UpdateNsxvSetupDetailsServiceURL = new StringBuilder("/migration/setup");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Put
            };
            request.AddJsonBody(MigrationSetupInfo);
            request.Resource = UpdateNsxvSetupDetailsServiceURL.ToString();
            RestResponse<NSXTMigrationSetupInfoType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTMigrationSetupInfoType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Put operation to " + UpdateNsxvSetupDetailsServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTMigrationSetupInfoType> GetNsxvSetupDetails()
        {
            StringBuilder GetNsxvSetupDetailsServiceURL = new StringBuilder("/migration/setup");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Get
            };
            request.Resource = GetNsxvSetupDetailsServiceURL.ToString();
            RestResponse<NSXTMigrationSetupInfoType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTMigrationSetupInfoType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Get operation to " + GetNsxvSetupDetailsServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task ReorderMigrationUnitGroup(string GroupId, NSXTReorderMigrationRequestType ReorderMigrationRequest)
        {
            if (GroupId == null) { throw new System.ArgumentNullException("GroupId cannot be null"); }
            if (ReorderMigrationRequest == null) { throw new System.ArgumentNullException("ReorderMigrationRequest cannot be null"); }
            StringBuilder ReorderMigrationUnitGroupServiceURL = new StringBuilder("/migration/migration-unit-groups/{group-id}?action=reorder");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Post
            };
            ReorderMigrationUnitGroupServiceURL.Replace("{group-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(GroupId, System.Globalization.CultureInfo.InvariantCulture)));
            request.AddJsonBody(ReorderMigrationRequest);
            request.Resource = ReorderMigrationUnitGroupServiceURL.ToString();
            RestResponse response = await restClient.ExecuteTaskAsyncWithPolicy(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Post operation to " + ReorderMigrationUnitGroupServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task DownloadMigrationData(string FileType, string? FederationSiteId = null)
        {
            if (FileType == null) { throw new System.ArgumentNullException("FileType cannot be null"); }
            StringBuilder DownloadMigrationDataServiceURL = new StringBuilder("/migration/data/download");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Get
            };
            if (FederationSiteId != null) { request.AddQueryParameter("federation_site_id", FederationSiteId.ToString()); }
            if (FileType != null) { request.AddQueryParameter("file_type", FileType.ToString()); }
            request.Resource = DownloadMigrationDataServiceURL.ToString();
            RestResponse response = await restClient.ExecuteTaskAsyncWithPolicy(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Get operation to " + DownloadMigrationDataServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTMigrationDataInfoType> GetMigrationDataInfo(string FileType, string? FederationSiteId = null)
        {
            if (FileType == null) { throw new System.ArgumentNullException("FileType cannot be null"); }
            StringBuilder GetMigrationDataInfoServiceURL = new StringBuilder("/migration/data");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Get
            };
            if (FederationSiteId != null) { request.AddQueryParameter("federation_site_id", FederationSiteId.ToString()); }
            if (FileType != null) { request.AddQueryParameter("file_type", FileType.ToString()); }
            request.Resource = GetMigrationDataInfoServiceURL.ToString();
            RestResponse<NSXTMigrationDataInfoType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTMigrationDataInfoType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Get operation to " + GetMigrationDataInfoServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task DeleteMigrationDataFile(string FileType, string? FederationSiteId = null)
        {
            if (FileType == null) { throw new System.ArgumentNullException("FileType cannot be null"); }
            StringBuilder DeleteMigrationDataFileServiceURL = new StringBuilder("/migration/data");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Delete
            };
            if (FederationSiteId != null) { request.AddQueryParameter("federation_site_id", FederationSiteId.ToString()); }
            if (FileType != null) { request.AddQueryParameter("file_type", FileType.ToString()); }
            request.Resource = DeleteMigrationDataFileServiceURL.ToString();
            RestResponse response = await restClient.ExecuteTaskAsyncWithPolicy(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Delete operation to " + DeleteMigrationDataFileServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTMigrationUnitGroupType> UpdateMigrationUnitGroup(string GroupId, NSXTMigrationUnitGroupType MigrationUnitGroup)
        {
            if (GroupId == null) { throw new System.ArgumentNullException("GroupId cannot be null"); }
            if (MigrationUnitGroup == null) { throw new System.ArgumentNullException("MigrationUnitGroup cannot be null"); }
            StringBuilder UpdateMigrationUnitGroupServiceURL = new StringBuilder("/migration/migration-unit-groups/{group-id}");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Put
            };
            UpdateMigrationUnitGroupServiceURL.Replace("{group-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(GroupId, System.Globalization.CultureInfo.InvariantCulture)));
            request.AddJsonBody(MigrationUnitGroup);
            request.Resource = UpdateMigrationUnitGroupServiceURL.ToString();
            RestResponse<NSXTMigrationUnitGroupType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTMigrationUnitGroupType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Put operation to " + UpdateMigrationUnitGroupServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTMigrationUnitGroupType> GetMigrationUnitGroup(string GroupId, bool? Summary = null)
        {
            if (GroupId == null) { throw new System.ArgumentNullException("GroupId cannot be null"); }
            StringBuilder GetMigrationUnitGroupServiceURL = new StringBuilder("/migration/migration-unit-groups/{group-id}");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Get
            };
            GetMigrationUnitGroupServiceURL.Replace("{group-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(GroupId, System.Globalization.CultureInfo.InvariantCulture)));
            if (Summary != null) { request.AddQueryParameter("summary", Summary.ToString()); }
            request.Resource = GetMigrationUnitGroupServiceURL.ToString();
            RestResponse<NSXTMigrationUnitGroupType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTMigrationUnitGroupType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Get operation to " + GetMigrationUnitGroupServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task DeleteMigrationUnitGroup(string GroupId)
        {
            if (GroupId == null) { throw new System.ArgumentNullException("GroupId cannot be null"); }
            StringBuilder DeleteMigrationUnitGroupServiceURL = new StringBuilder("/migration/migration-unit-groups/{group-id}");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Delete
            };
            DeleteMigrationUnitGroupServiceURL.Replace("{group-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(GroupId, System.Globalization.CultureInfo.InvariantCulture)));
            request.Resource = DeleteMigrationUnitGroupServiceURL.ToString();
            RestResponse response = await restClient.ExecuteTaskAsyncWithPolicy(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Delete operation to " + DeleteMigrationUnitGroupServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTMigrationSummaryType> GetMigrationSummary()
        {
            StringBuilder GetMigrationSummaryServiceURL = new StringBuilder("/migration/summary");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Get
            };
            request.Resource = GetMigrationSummaryServiceURL.ToString();
            RestResponse<NSXTMigrationSummaryType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTMigrationSummaryType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Get operation to " + GetMigrationSummaryServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTMigrationPlanSettingsType> UpdateMigrationPlanSettings(string ComponentType, NSXTMigrationPlanSettingsType MigrationPlanSettings)
        {
            if (ComponentType == null) { throw new System.ArgumentNullException("ComponentType cannot be null"); }
            if (MigrationPlanSettings == null) { throw new System.ArgumentNullException("MigrationPlanSettings cannot be null"); }
            StringBuilder UpdateMigrationPlanSettingsServiceURL = new StringBuilder("/migration/plan/{component_type}/settings");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Put
            };
            UpdateMigrationPlanSettingsServiceURL.Replace("{component_type}", System.Uri.EscapeDataString(Helpers.ConvertToString(ComponentType, System.Globalization.CultureInfo.InvariantCulture)));
            request.AddJsonBody(MigrationPlanSettings);
            request.Resource = UpdateMigrationPlanSettingsServiceURL.ToString();
            RestResponse<NSXTMigrationPlanSettingsType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTMigrationPlanSettingsType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Put operation to " + UpdateMigrationPlanSettingsServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTMigrationPlanSettingsType> GetMigrationPlanSettings(string ComponentType)
        {
            if (ComponentType == null) { throw new System.ArgumentNullException("ComponentType cannot be null"); }
            StringBuilder GetMigrationPlanSettingsServiceURL = new StringBuilder("/migration/plan/{component_type}/settings");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Get
            };
            GetMigrationPlanSettingsServiceURL.Replace("{component_type}", System.Uri.EscapeDataString(Helpers.ConvertToString(ComponentType, System.Globalization.CultureInfo.InvariantCulture)));
            request.Resource = GetMigrationPlanSettingsServiceURL.ToString();
            RestResponse<NSXTMigrationPlanSettingsType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTMigrationPlanSettingsType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Get operation to " + GetMigrationPlanSettingsServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task FinishMigration()
        {
            StringBuilder FinishMigrationServiceURL = new StringBuilder("/migration/plan?action=finish");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Post
            };
            request.Resource = FinishMigrationServiceURL.ToString();
            RestResponse response = await restClient.ExecuteTaskAsyncWithPolicy(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Post operation to " + FinishMigrationServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task ContinueMigration(bool? Skip = null)
        {
            StringBuilder ContinueMigrationServiceURL = new StringBuilder("/migration/plan?action=continue");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Post
            };
            if (Skip != null) { request.AddQueryParameter("skip", Skip.ToString()); }
            request.Resource = ContinueMigrationServiceURL.ToString();
            RestResponse response = await restClient.ExecuteTaskAsyncWithPolicy(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Post operation to " + ContinueMigrationServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTMigrationFeedbackRequestListResultType> GetFeedbackRequests(string? Category = null, string? Cursor = null, string? FederationSiteId = null, string? Hash = null, string? IncludedFields = null, string? NetworkLayer = null, long? PageSize = null, bool? SortAscending = null, string? SortBy = null, string? State = null, string? SubCategory = null)
        {
            StringBuilder GetFeedbackRequestsServiceURL = new StringBuilder("/migration/feedback-requests");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Get
            };
            if (Category != null) { request.AddQueryParameter("category", Category.ToString()); }
            if (Cursor != null) { request.AddQueryParameter("cursor", Cursor.ToString()); }
            if (FederationSiteId != null) { request.AddQueryParameter("federation_site_id", FederationSiteId.ToString()); }
            if (Hash != null) { request.AddQueryParameter("hash", Hash.ToString()); }
            if (IncludedFields != null) { request.AddQueryParameter("included_fields", IncludedFields.ToString()); }
            if (NetworkLayer != null) { request.AddQueryParameter("network_layer", NetworkLayer.ToString()); }
            if (PageSize != null) { request.AddQueryParameter("page_size", PageSize.ToString()); }
            if (SortAscending != null) { request.AddQueryParameter("sort_ascending", SortAscending.ToString()); }
            if (SortBy != null) { request.AddQueryParameter("sort_by", SortBy.ToString()); }
            if (State != null) { request.AddQueryParameter("state", State.ToString()); }
            if (SubCategory != null) { request.AddQueryParameter("sub_category", SubCategory.ToString()); }
            request.Resource = GetFeedbackRequestsServiceURL.ToString();
            RestResponse<NSXTMigrationFeedbackRequestListResultType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTMigrationFeedbackRequestListResultType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Get operation to " + GetFeedbackRequestsServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task PreVmGroupMigrate(NSXTPreVmGroupMigrationSpecType PreVmGroupMigrationSpec)
        {
            if (PreVmGroupMigrationSpec == null) { throw new System.ArgumentNullException("PreVmGroupMigrationSpec cannot be null"); }
            StringBuilder PreVmGroupMigrateServiceURL = new StringBuilder("/migration/vmgroup?action=pre_migrate");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Post
            };
            request.AddJsonBody(PreVmGroupMigrationSpec);
            request.Resource = PreVmGroupMigrateServiceURL.ToString();
            RestResponse response = await restClient.ExecuteTaskAsyncWithPolicy(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Post operation to " + PreVmGroupMigrateServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTMigrationSwitchListResultType> GetDiscoveredSwitches(string? Cursor = null, string? IncludedFields = null, long? PageSize = null, bool? SortAscending = null, string? SortBy = null)
        {
            StringBuilder GetDiscoveredSwitchesServiceURL = new StringBuilder("/migration/discovered-switches");
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
            request.Resource = GetDiscoveredSwitchesServiceURL.ToString();
            RestResponse<NSXTMigrationSwitchListResultType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTMigrationSwitchListResultType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Get operation to " + GetDiscoveredSwitchesServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTMigrationUnitAggregateInfoListResultType> GetMigrationUnitAggregateInfo(string? ComponentType = null, string? Cursor = null, string? GroupId = null, bool? HasErrors = null, string? IncludedFields = null, string? Metadata = null, long? PageSize = null, string? SelectionStatus = null, bool? SortAscending = null, string? SortBy = null)
        {
            StringBuilder GetMigrationUnitAggregateInfoServiceURL = new StringBuilder("/migration/migration-units/aggregate-info");
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
            request.Resource = GetMigrationUnitAggregateInfoServiceURL.ToString();
            RestResponse<NSXTMigrationUnitAggregateInfoListResultType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTMigrationUnitAggregateInfoListResultType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Get operation to " + GetMigrationUnitAggregateInfoServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTMigrationUnitListResultType> GetMigrationUnits(string? ComponentType = null, string? CurrentVersion = null, string? Cursor = null, string? GroupId = null, bool? HasWarnings = null, string? IncludedFields = null, string? Metadata = null, string? MigrationUnitType = null, long? PageSize = null, bool? SortAscending = null, string? SortBy = null)
        {
            StringBuilder GetMigrationUnitsServiceURL = new StringBuilder("/migration/migration-units");
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
            if (MigrationUnitType != null) { request.AddQueryParameter("migration_unit_type", MigrationUnitType.ToString()); }
            if (PageSize != null) { request.AddQueryParameter("page_size", PageSize.ToString()); }
            if (SortAscending != null) { request.AddQueryParameter("sort_ascending", SortAscending.ToString()); }
            if (SortBy != null) { request.AddQueryParameter("sort_by", SortBy.ToString()); }
            request.Resource = GetMigrationUnitsServiceURL.ToString();
            RestResponse<NSXTMigrationUnitListResultType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTMigrationUnitListResultType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Get operation to " + GetMigrationUnitsServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTMigrationSwitchInfoType> SetMigrationSwitch(NSXTMigrationSwitchInfoType MigrationSwitchInfo)
        {
            if (MigrationSwitchInfo == null) { throw new System.ArgumentNullException("MigrationSwitchInfo cannot be null"); }
            StringBuilder SetMigrationSwitchServiceURL = new StringBuilder("/migration/switch");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Put
            };
            request.AddJsonBody(MigrationSwitchInfo);
            request.Resource = SetMigrationSwitchServiceURL.ToString();
            RestResponse<NSXTMigrationSwitchInfoType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTMigrationSwitchInfoType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Put operation to " + SetMigrationSwitchServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTMigrationSwitchInfoType> GetMigrationSwitch()
        {
            StringBuilder GetMigrationSwitchServiceURL = new StringBuilder("/migration/switch");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Get
            };
            request.Resource = GetMigrationSwitchServiceURL.ToString();
            RestResponse<NSXTMigrationSwitchInfoType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTMigrationSwitchInfoType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Get operation to " + GetMigrationSwitchServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTMigrationUnitGroupAggregateInfoListResultType> GetMigrationUnitGroupAggregateInfo(string? ComponentType = null, string? Cursor = null, string? IncludedFields = null, long? PageSize = null, bool? SortAscending = null, string? SortBy = null, bool? Summary = null, bool? Sync = null)
        {
            StringBuilder GetMigrationUnitGroupAggregateInfoServiceURL = new StringBuilder("/migration/migration-unit-groups/aggregate-info");
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
            request.Resource = GetMigrationUnitGroupAggregateInfoServiceURL.ToString();
            RestResponse<NSXTMigrationUnitGroupAggregateInfoListResultType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTMigrationUnitGroupAggregateInfoListResultType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Get operation to " + GetMigrationUnitGroupAggregateInfoServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTMigrationUnitType> GetMigrationUnit(string MigrationUnitId)
        {
            if (MigrationUnitId == null) { throw new System.ArgumentNullException("MigrationUnitId cannot be null"); }
            StringBuilder GetMigrationUnitServiceURL = new StringBuilder("/migration/migration-units/{migration-unit-id}");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Get
            };
            GetMigrationUnitServiceURL.Replace("{migration-unit-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(MigrationUnitId, System.Globalization.CultureInfo.InvariantCulture)));
            request.Resource = GetMigrationUnitServiceURL.ToString();
            RestResponse<NSXTMigrationUnitType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTMigrationUnitType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Get operation to " + GetMigrationUnitServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task UpdateFeedbackResponse(NSXTMigrationFeedbackResponseListType MigrationFeedbackResponseList, string? NetworkLayer = null)
        {
            if (MigrationFeedbackResponseList == null) { throw new System.ArgumentNullException("MigrationFeedbackResponseList cannot be null"); }
            StringBuilder UpdateFeedbackResponseServiceURL = new StringBuilder("/migration/feedback-response");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Put
            };
            request.AddJsonBody(MigrationFeedbackResponseList);
            if (NetworkLayer != null) { request.AddQueryParameter("network_layer", NetworkLayer.ToString()); }
            request.Resource = UpdateFeedbackResponseServiceURL.ToString();
            RestResponse response = await restClient.ExecuteTaskAsyncWithPolicy(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Put operation to " + UpdateFeedbackResponseServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            
        }
    }
}
