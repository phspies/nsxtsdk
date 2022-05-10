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
    public class AggSvcLogicalSwitch
    {
        private RestClient restClient;
        private int retry;
        private int timeout;
        private CancellationToken cancellationToken;

        public AggSvcLogicalSwitch(RestClient Client, CancellationToken _cancellationToken, int _timeout, int _retry)
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
        public async Task<NSXTVtepListResultType> GetLogicalSwitchVtepTable(string LswitchId, string? Cursor = null, string? IncludedFields = null, long? PageSize = null, bool? SortAscending = null, string? SortBy = null, string? Source = null, string? TransportNodeId = null)
        {
            if (LswitchId == null) { throw new System.ArgumentNullException("LswitchId cannot be null"); }
            StringBuilder GetLogicalSwitchVtepTableServiceURL = new StringBuilder("/logical-switches/{lswitch-id}/vtep-table");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Get
            };
            GetLogicalSwitchVtepTableServiceURL.Replace("{lswitch-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(LswitchId, System.Globalization.CultureInfo.InvariantCulture)));
            if (Cursor != null) { request.AddQueryParameter("cursor", Cursor.ToString()); }
            if (IncludedFields != null) { request.AddQueryParameter("included_fields", IncludedFields.ToString()); }
            if (PageSize != null) { request.AddQueryParameter("page_size", PageSize.ToString()); }
            if (SortAscending != null) { request.AddQueryParameter("sort_ascending", SortAscending.ToString()); }
            if (SortBy != null) { request.AddQueryParameter("sort_by", SortBy.ToString()); }
            if (Source != null) { request.AddQueryParameter("source", Source.ToString()); }
            if (TransportNodeId != null) { request.AddQueryParameter("transport_node_id", TransportNodeId.ToString()); }
            request.Resource = GetLogicalSwitchVtepTableServiceURL.ToString();
            RestResponse<NSXTVtepListResultType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTVtepListResultType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Get operation to " + GetLogicalSwitchVtepTableServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTLogicalSwitchStatisticsType> GetLogicalSwitchStatistics(string LswitchId, string? Source = null)
        {
            if (LswitchId == null) { throw new System.ArgumentNullException("LswitchId cannot be null"); }
            StringBuilder GetLogicalSwitchStatisticsServiceURL = new StringBuilder("/logical-switches/{lswitch-id}/statistics");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Get
            };
            GetLogicalSwitchStatisticsServiceURL.Replace("{lswitch-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(LswitchId, System.Globalization.CultureInfo.InvariantCulture)));
            if (Source != null) { request.AddQueryParameter("source", Source.ToString()); }
            request.Resource = GetLogicalSwitchStatisticsServiceURL.ToString();
            RestResponse<NSXTLogicalSwitchStatisticsType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTLogicalSwitchStatisticsType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Get operation to " + GetLogicalSwitchStatisticsServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTMacAddressCsvListResultType> GetLogicalSwitchMacTableInCsvFormat(string LswitchId, string? Source = null, string? TransportNodeId = null)
        {
            if (LswitchId == null) { throw new System.ArgumentNullException("LswitchId cannot be null"); }
            StringBuilder GetLogicalSwitchMacTableInCsvFormatServiceURL = new StringBuilder("/logical-switches/{lswitch-id}/mac-table?format=csv");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Get
            };
            GetLogicalSwitchMacTableInCsvFormatServiceURL.Replace("{lswitch-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(LswitchId, System.Globalization.CultureInfo.InvariantCulture)));
            if (Source != null) { request.AddQueryParameter("source", Source.ToString()); }
            if (TransportNodeId != null) { request.AddQueryParameter("transport_node_id", TransportNodeId.ToString()); }
            request.Resource = GetLogicalSwitchMacTableInCsvFormatServiceURL.ToString();
            RestResponse<NSXTMacAddressCsvListResultType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTMacAddressCsvListResultType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Get operation to " + GetLogicalSwitchMacTableInCsvFormatServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTLogicalSwitchStatusSummaryType> GetLogicalSwitchStatusSummary(string? Cursor = null, bool? Diagnostic = null, string? IncludedFields = null, long? PageSize = null, bool? SortAscending = null, string? SortBy = null, string? Source = null, string? SwitchType = null, string? SwitchingProfileId = null, string? TransportType = null, string? TransportZoneId = null, string? UplinkTeamingPolicyName = null, long? Vlan = null, int? Vni = null)
        {
            StringBuilder GetLogicalSwitchStatusSummaryServiceURL = new StringBuilder("/logical-switches/status");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Get
            };
            if (Cursor != null) { request.AddQueryParameter("cursor", Cursor.ToString()); }
            if (Diagnostic != null) { request.AddQueryParameter("diagnostic", Diagnostic.ToString()); }
            if (IncludedFields != null) { request.AddQueryParameter("included_fields", IncludedFields.ToString()); }
            if (PageSize != null) { request.AddQueryParameter("page_size", PageSize.ToString()); }
            if (SortAscending != null) { request.AddQueryParameter("sort_ascending", SortAscending.ToString()); }
            if (SortBy != null) { request.AddQueryParameter("sort_by", SortBy.ToString()); }
            if (Source != null) { request.AddQueryParameter("source", Source.ToString()); }
            if (SwitchType != null) { request.AddQueryParameter("switch_type", SwitchType.ToString()); }
            if (SwitchingProfileId != null) { request.AddQueryParameter("switching_profile_id", SwitchingProfileId.ToString()); }
            if (TransportType != null) { request.AddQueryParameter("transport_type", TransportType.ToString()); }
            if (TransportZoneId != null) { request.AddQueryParameter("transport_zone_id", TransportZoneId.ToString()); }
            if (UplinkTeamingPolicyName != null) { request.AddQueryParameter("uplink_teaming_policy_name", UplinkTeamingPolicyName.ToString()); }
            if (Vlan != null) { request.AddQueryParameter("vlan", Vlan.ToString()); }
            if (Vni != null) { request.AddQueryParameter("vni", Vni.ToString()); }
            request.Resource = GetLogicalSwitchStatusSummaryServiceURL.ToString();
            RestResponse<NSXTLogicalSwitchStatusSummaryType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTLogicalSwitchStatusSummaryType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Get operation to " + GetLogicalSwitchStatusSummaryServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTVtepCsvListResultType> GetLogicalSwitchVtepTableInCsvFormat(string LswitchId, string? Source = null, string? TransportNodeId = null)
        {
            if (LswitchId == null) { throw new System.ArgumentNullException("LswitchId cannot be null"); }
            StringBuilder GetLogicalSwitchVtepTableInCsvFormatServiceURL = new StringBuilder("/logical-switches/{lswitch-id}/vtep-table?format=csv");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Get
            };
            GetLogicalSwitchVtepTableInCsvFormatServiceURL.Replace("{lswitch-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(LswitchId, System.Globalization.CultureInfo.InvariantCulture)));
            if (Source != null) { request.AddQueryParameter("source", Source.ToString()); }
            if (TransportNodeId != null) { request.AddQueryParameter("transport_node_id", TransportNodeId.ToString()); }
            request.Resource = GetLogicalSwitchVtepTableInCsvFormatServiceURL.ToString();
            RestResponse<NSXTVtepCsvListResultType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTVtepCsvListResultType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Get operation to " + GetLogicalSwitchVtepTableInCsvFormatServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTMacAddressListResultType> GetLogicalSwitchMacTable(string LswitchId, string? Cursor = null, string? IncludedFields = null, long? PageSize = null, bool? SortAscending = null, string? SortBy = null, string? Source = null, string? TransportNodeId = null)
        {
            if (LswitchId == null) { throw new System.ArgumentNullException("LswitchId cannot be null"); }
            StringBuilder GetLogicalSwitchMacTableServiceURL = new StringBuilder("/logical-switches/{lswitch-id}/mac-table");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Get
            };
            GetLogicalSwitchMacTableServiceURL.Replace("{lswitch-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(LswitchId, System.Globalization.CultureInfo.InvariantCulture)));
            if (Cursor != null) { request.AddQueryParameter("cursor", Cursor.ToString()); }
            if (IncludedFields != null) { request.AddQueryParameter("included_fields", IncludedFields.ToString()); }
            if (PageSize != null) { request.AddQueryParameter("page_size", PageSize.ToString()); }
            if (SortAscending != null) { request.AddQueryParameter("sort_ascending", SortAscending.ToString()); }
            if (SortBy != null) { request.AddQueryParameter("sort_by", SortBy.ToString()); }
            if (Source != null) { request.AddQueryParameter("source", Source.ToString()); }
            if (TransportNodeId != null) { request.AddQueryParameter("transport_node_id", TransportNodeId.ToString()); }
            request.Resource = GetLogicalSwitchMacTableServiceURL.ToString();
            RestResponse<NSXTMacAddressListResultType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTMacAddressListResultType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Get operation to " + GetLogicalSwitchMacTableServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
    }
}
