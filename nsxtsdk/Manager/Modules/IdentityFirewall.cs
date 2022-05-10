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
    public class IdentityFirewall
    {
        private RestClient restClient;
        private int retry;
        private int timeout;
        private CancellationToken cancellationToken;

        public IdentityFirewall(RestClient Client, CancellationToken _cancellationToken, int _timeout, int _retry)
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
        public async Task<NSXTIdfwMasterSwitchSettingType> UpdateMasterSwitchSetting(NSXTIdfwMasterSwitchSettingType IdfwMasterSwitchSetting)
        {
            if (IdfwMasterSwitchSetting == null) { throw new System.ArgumentNullException("IdfwMasterSwitchSetting cannot be null"); }
            StringBuilder UpdateMasterSwitchSettingServiceURL = new StringBuilder("/idfw/master-switch-setting");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Put
            };
            request.AddJsonBody(IdfwMasterSwitchSetting);
            request.Resource = UpdateMasterSwitchSettingServiceURL.ToString();
            RestResponse<NSXTIdfwMasterSwitchSettingType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTIdfwMasterSwitchSettingType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Put operation to " + UpdateMasterSwitchSettingServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTIdfwMasterSwitchSettingType> GetMasterSwitchSetting()
        {
            StringBuilder GetMasterSwitchSettingServiceURL = new StringBuilder("/idfw/master-switch-setting");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Get
            };
            request.Resource = GetMasterSwitchSettingServiceURL.ToString();
            RestResponse<NSXTIdfwMasterSwitchSettingType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTIdfwMasterSwitchSettingType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Get operation to " + GetMasterSwitchSettingServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTIdfwEnabledComputeCollectionType> UpdateEnabledComputeCollection(string CcExtId, NSXTIdfwEnabledComputeCollectionType IdfwEnabledComputeCollection)
        {
            if (CcExtId == null) { throw new System.ArgumentNullException("CcExtId cannot be null"); }
            if (IdfwEnabledComputeCollection == null) { throw new System.ArgumentNullException("IdfwEnabledComputeCollection cannot be null"); }
            StringBuilder UpdateEnabledComputeCollectionServiceURL = new StringBuilder("/idfw/idfw-compute-collections/{cc-ext-id}");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Put
            };
            UpdateEnabledComputeCollectionServiceURL.Replace("{cc-ext-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(CcExtId, System.Globalization.CultureInfo.InvariantCulture)));
            request.AddJsonBody(IdfwEnabledComputeCollection);
            request.Resource = UpdateEnabledComputeCollectionServiceURL.ToString();
            RestResponse<NSXTIdfwEnabledComputeCollectionType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTIdfwEnabledComputeCollectionType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Put operation to " + UpdateEnabledComputeCollectionServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTIdfwEnabledComputeCollectionType> GetEnabledComputeCollection(string CcExtId)
        {
            if (CcExtId == null) { throw new System.ArgumentNullException("CcExtId cannot be null"); }
            StringBuilder GetEnabledComputeCollectionServiceURL = new StringBuilder("/idfw/idfw-compute-collections/{cc-ext-id}");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Get
            };
            GetEnabledComputeCollectionServiceURL.Replace("{cc-ext-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(CcExtId, System.Globalization.CultureInfo.InvariantCulture)));
            request.Resource = GetEnabledComputeCollectionServiceURL.ToString();
            RestResponse<NSXTIdfwEnabledComputeCollectionType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTIdfwEnabledComputeCollectionType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Get operation to " + GetEnabledComputeCollectionServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task DeleteEnabledComputeCollection(string CcExtId)
        {
            if (CcExtId == null) { throw new System.ArgumentNullException("CcExtId cannot be null"); }
            StringBuilder DeleteEnabledComputeCollectionServiceURL = new StringBuilder("/idfw/idfw-compute-collections/{cc-ext-id}");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Delete
            };
            DeleteEnabledComputeCollectionServiceURL.Replace("{cc-ext-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(CcExtId, System.Globalization.CultureInfo.InvariantCulture)));
            request.Resource = DeleteEnabledComputeCollectionServiceURL.ToString();
            RestResponse response = await restClient.ExecuteTaskAsyncWithPolicy(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Delete operation to " + DeleteEnabledComputeCollectionServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTIdfwTransportNodeStatusListResultType> ListTransportNodeStatusesByComputeCollectionId(string CcExtId)
        {
            if (CcExtId == null) { throw new System.ArgumentNullException("CcExtId cannot be null"); }
            StringBuilder ListTransportNodeStatusesByComputeCollectionIdServiceURL = new StringBuilder("/idfw/compute-collections/{cc-ext-id}/transport-nodes/status");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Get
            };
            ListTransportNodeStatusesByComputeCollectionIdServiceURL.Replace("{cc-ext-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(CcExtId, System.Globalization.CultureInfo.InvariantCulture)));
            request.Resource = ListTransportNodeStatusesByComputeCollectionIdServiceURL.ToString();
            RestResponse<NSXTIdfwTransportNodeStatusListResultType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTIdfwTransportNodeStatusListResultType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Get operation to " + ListTransportNodeStatusesByComputeCollectionIdServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTIdfwComputeCollectionStatusType> GetComputeCollectionStatusById(string ComputeCollectionExtId)
        {
            if (ComputeCollectionExtId == null) { throw new System.ArgumentNullException("ComputeCollectionExtId cannot be null"); }
            StringBuilder GetComputeCollectionStatusByIdServiceURL = new StringBuilder("/idfw/compute-collections/{compute-collection-ext-id}/status");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Get
            };
            GetComputeCollectionStatusByIdServiceURL.Replace("{compute-collection-ext-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(ComputeCollectionExtId, System.Globalization.CultureInfo.InvariantCulture)));
            request.Resource = GetComputeCollectionStatusByIdServiceURL.ToString();
            RestResponse<NSXTIdfwComputeCollectionStatusType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTIdfwComputeCollectionStatusType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Get operation to " + GetComputeCollectionStatusByIdServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTIdfwVmStatsType> GetVmStats(string VmExtId)
        {
            if (VmExtId == null) { throw new System.ArgumentNullException("VmExtId cannot be null"); }
            StringBuilder GetVmStatsServiceURL = new StringBuilder("/idfw/vm-stats/{vm-ext-id}");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Get
            };
            GetVmStatsServiceURL.Replace("{vm-ext-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(VmExtId, System.Globalization.CultureInfo.InvariantCulture)));
            request.Resource = GetVmStatsServiceURL.ToString();
            RestResponse<NSXTIdfwVmStatsType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTIdfwVmStatsType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Get operation to " + GetVmStatsServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTIdfwSystemStatsType> GetSystemStats()
        {
            StringBuilder GetSystemStatsServiceURL = new StringBuilder("/idfw/system-stats");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Get
            };
            request.Resource = GetSystemStatsServiceURL.ToString();
            RestResponse<NSXTIdfwSystemStatsType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTIdfwSystemStatsType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Get operation to " + GetSystemStatsServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTIdfwNsgroupVmDetailListResultType> GetNsgroupVmDetails(string GroupId)
        {
            if (GroupId == null) { throw new System.ArgumentNullException("GroupId cannot be null"); }
            StringBuilder GetNsgroupVmDetailsServiceURL = new StringBuilder("/idfw/nsgroup-vm-details/{group-id}");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Get
            };
            GetNsgroupVmDetailsServiceURL.Replace("{group-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(GroupId, System.Globalization.CultureInfo.InvariantCulture)));
            request.Resource = GetNsgroupVmDetailsServiceURL.ToString();
            RestResponse<NSXTIdfwNsgroupVmDetailListResultType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTIdfwNsgroupVmDetailListResultType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Get operation to " + GetNsgroupVmDetailsServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTIdfwUserSessionDataAndMappingsType> ListUserSessions()
        {
            StringBuilder ListUserSessionsServiceURL = new StringBuilder("/idfw/user-session-data");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Get
            };
            request.Resource = ListUserSessionsServiceURL.ToString();
            RestResponse<NSXTIdfwUserSessionDataAndMappingsType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTIdfwUserSessionDataAndMappingsType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Get operation to " + ListUserSessionsServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTIdfwEnabledComputeCollectionListResultType> ListEnabledComputeCollections(string? Cursor = null, string? IncludedFields = null, long? PageSize = null, bool? SortAscending = null, string? SortBy = null)
        {
            StringBuilder ListEnabledComputeCollectionsServiceURL = new StringBuilder("/idfw/idfw-compute-collections");
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
            request.Resource = ListEnabledComputeCollectionsServiceURL.ToString();
            RestResponse<NSXTIdfwEnabledComputeCollectionListResultType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTIdfwEnabledComputeCollectionListResultType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Get operation to " + ListEnabledComputeCollectionsServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTIdfwVirtualMachineStatusListResultType> ListVirtualMachineStatusesByTransportNodeId(string TransportNodeId)
        {
            if (TransportNodeId == null) { throw new System.ArgumentNullException("TransportNodeId cannot be null"); }
            StringBuilder ListVirtualMachineStatusesByTransportNodeIdServiceURL = new StringBuilder("/idfw/transport-nodes/{transport-node-id}/vms/status");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Get
            };
            ListVirtualMachineStatusesByTransportNodeIdServiceURL.Replace("{transport-node-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(TransportNodeId, System.Globalization.CultureInfo.InvariantCulture)));
            request.Resource = ListVirtualMachineStatusesByTransportNodeIdServiceURL.ToString();
            RestResponse<NSXTIdfwVirtualMachineStatusListResultType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTIdfwVirtualMachineStatusListResultType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Get operation to " + ListVirtualMachineStatusesByTransportNodeIdServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTIdfwStandaloneHostsSwitchSettingType> UpdateStandaloneHostsSwitchSetting(NSXTIdfwStandaloneHostsSwitchSettingType IdfwStandaloneHostsSwitchSetting)
        {
            if (IdfwStandaloneHostsSwitchSetting == null) { throw new System.ArgumentNullException("IdfwStandaloneHostsSwitchSetting cannot be null"); }
            StringBuilder UpdateStandaloneHostsSwitchSettingServiceURL = new StringBuilder("/idfw/standalone-host-switch-setting");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Put
            };
            request.AddJsonBody(IdfwStandaloneHostsSwitchSetting);
            request.Resource = UpdateStandaloneHostsSwitchSettingServiceURL.ToString();
            RestResponse<NSXTIdfwStandaloneHostsSwitchSettingType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTIdfwStandaloneHostsSwitchSettingType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Put operation to " + UpdateStandaloneHostsSwitchSettingServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTIdfwStandaloneHostsSwitchSettingType> GetStandaloneHostsSwitchSetting()
        {
            StringBuilder GetStandaloneHostsSwitchSettingServiceURL = new StringBuilder("/idfw/standalone-host-switch-setting");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Get
            };
            request.Resource = GetStandaloneHostsSwitchSettingServiceURL.ToString();
            RestResponse<NSXTIdfwStandaloneHostsSwitchSettingType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTIdfwStandaloneHostsSwitchSettingType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Get operation to " + GetStandaloneHostsSwitchSettingServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTIdfwUserStatsType> GetUserStats(string UserId)
        {
            if (UserId == null) { throw new System.ArgumentNullException("UserId cannot be null"); }
            StringBuilder GetUserStatsServiceURL = new StringBuilder("/idfw/user-stats/{user-id}");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Get
            };
            GetUserStatsServiceURL.Replace("{user-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(UserId, System.Globalization.CultureInfo.InvariantCulture)));
            request.Resource = GetUserStatsServiceURL.ToString();
            RestResponse<NSXTIdfwUserStatsType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTIdfwUserStatsType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Get operation to " + GetUserStatsServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTIdfwComputeCollectionListResultType> ListComputeCollectionStatuses()
        {
            StringBuilder ListComputeCollectionStatusesServiceURL = new StringBuilder("/idfw/compute-collections/status");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Get
            };
            request.Resource = ListComputeCollectionStatusesServiceURL.ToString();
            RestResponse<NSXTIdfwComputeCollectionListResultType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTIdfwComputeCollectionListResultType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Get operation to " + ListComputeCollectionStatusesServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
    }
}
