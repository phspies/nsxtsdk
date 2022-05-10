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
    public class AggSvcLogicalPort
    {
        private RestClient restClient;
        private int retry;
        private int timeout;
        private CancellationToken cancellationToken;

        public AggSvcLogicalPort(RestClient Client, CancellationToken _cancellationToken, int _timeout, int _retry)
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
        public async Task<NSXTLogicalPortOperationalStatusType> GetLogicalPortOperationalStatus(string LportId, string? Source = null)
        {
            if (LportId == null) { throw new System.ArgumentNullException("LportId cannot be null"); }
            StringBuilder GetLogicalPortOperationalStatusServiceURL = new StringBuilder("/logical-ports/{lport-id}/status");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Get
            };
            GetLogicalPortOperationalStatusServiceURL.Replace("{lport-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(LportId, System.Globalization.CultureInfo.InvariantCulture)));
            if (Source != null) { request.AddQueryParameter("source", Source.ToString()); }
            request.Resource = GetLogicalPortOperationalStatusServiceURL.ToString();
            RestResponse<NSXTLogicalPortOperationalStatusType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTLogicalPortOperationalStatusType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Get operation to " + GetLogicalPortOperationalStatusServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTLogicalPortMacAddressCsvListResultType> GetLogicalPortMacTableInCsvFormat(string LportId, string? Cursor = null, string? IncludedFields = null, long? PageSize = null, bool? SortAscending = null, string? SortBy = null, string? Source = null, string? TransportNodeId = null)
        {
            if (LportId == null) { throw new System.ArgumentNullException("LportId cannot be null"); }
            StringBuilder GetLogicalPortMacTableInCsvFormatServiceURL = new StringBuilder("/logical-ports/{lport-id}/mac-table?format=csv");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Get
            };
            GetLogicalPortMacTableInCsvFormatServiceURL.Replace("{lport-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(LportId, System.Globalization.CultureInfo.InvariantCulture)));
            if (Cursor != null) { request.AddQueryParameter("cursor", Cursor.ToString()); }
            if (IncludedFields != null) { request.AddQueryParameter("included_fields", IncludedFields.ToString()); }
            if (PageSize != null) { request.AddQueryParameter("page_size", PageSize.ToString()); }
            if (SortAscending != null) { request.AddQueryParameter("sort_ascending", SortAscending.ToString()); }
            if (SortBy != null) { request.AddQueryParameter("sort_by", SortBy.ToString()); }
            if (Source != null) { request.AddQueryParameter("source", Source.ToString()); }
            if (TransportNodeId != null) { request.AddQueryParameter("transport_node_id", TransportNodeId.ToString()); }
            request.Resource = GetLogicalPortMacTableInCsvFormatServiceURL.ToString();
            RestResponse<NSXTLogicalPortMacAddressCsvListResultType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTLogicalPortMacAddressCsvListResultType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Get operation to " + GetLogicalPortMacTableInCsvFormatServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTLogicalPortMacAddressListResultType> GetLogicalPortMacTable(string LportId, string? Cursor = null, string? IncludedFields = null, long? PageSize = null, bool? SortAscending = null, string? SortBy = null, string? Source = null, string? TransportNodeId = null)
        {
            if (LportId == null) { throw new System.ArgumentNullException("LportId cannot be null"); }
            StringBuilder GetLogicalPortMacTableServiceURL = new StringBuilder("/logical-ports/{lport-id}/mac-table");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Get
            };
            GetLogicalPortMacTableServiceURL.Replace("{lport-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(LportId, System.Globalization.CultureInfo.InvariantCulture)));
            if (Cursor != null) { request.AddQueryParameter("cursor", Cursor.ToString()); }
            if (IncludedFields != null) { request.AddQueryParameter("included_fields", IncludedFields.ToString()); }
            if (PageSize != null) { request.AddQueryParameter("page_size", PageSize.ToString()); }
            if (SortAscending != null) { request.AddQueryParameter("sort_ascending", SortAscending.ToString()); }
            if (SortBy != null) { request.AddQueryParameter("sort_by", SortBy.ToString()); }
            if (Source != null) { request.AddQueryParameter("source", Source.ToString()); }
            if (TransportNodeId != null) { request.AddQueryParameter("transport_node_id", TransportNodeId.ToString()); }
            request.Resource = GetLogicalPortMacTableServiceURL.ToString();
            RestResponse<NSXTLogicalPortMacAddressListResultType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTLogicalPortMacAddressListResultType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Get operation to " + GetLogicalPortMacTableServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTLogicalPortStatusSummaryType> GetLogicalPortStatusSummary(string? AttachmentId = null, string? AttachmentType = null, string? BridgeClusterId = null, bool? ContainerPortsOnly = null, string? Cursor = null, bool? Diagnostic = null, string? IncludedFields = null, string? LogicalSwitchId = null, long? PageSize = null, string? ParentVifId = null, bool? SortAscending = null, string? SortBy = null, string? Source = null, string? SwitchingProfileId = null, string? TransportNodeId = null, string? TransportZoneId = null)
        {
            StringBuilder GetLogicalPortStatusSummaryServiceURL = new StringBuilder("/logical-ports/status");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Get
            };
            if (AttachmentId != null) { request.AddQueryParameter("attachment_id", AttachmentId.ToString()); }
            if (AttachmentType != null) { request.AddQueryParameter("attachment_type", AttachmentType.ToString()); }
            if (BridgeClusterId != null) { request.AddQueryParameter("bridge_cluster_id", BridgeClusterId.ToString()); }
            if (ContainerPortsOnly != null) { request.AddQueryParameter("container_ports_only", ContainerPortsOnly.ToString()); }
            if (Cursor != null) { request.AddQueryParameter("cursor", Cursor.ToString()); }
            if (Diagnostic != null) { request.AddQueryParameter("diagnostic", Diagnostic.ToString()); }
            if (IncludedFields != null) { request.AddQueryParameter("included_fields", IncludedFields.ToString()); }
            if (LogicalSwitchId != null) { request.AddQueryParameter("logical_switch_id", LogicalSwitchId.ToString()); }
            if (PageSize != null) { request.AddQueryParameter("page_size", PageSize.ToString()); }
            if (ParentVifId != null) { request.AddQueryParameter("parent_vif_id", ParentVifId.ToString()); }
            if (SortAscending != null) { request.AddQueryParameter("sort_ascending", SortAscending.ToString()); }
            if (SortBy != null) { request.AddQueryParameter("sort_by", SortBy.ToString()); }
            if (Source != null) { request.AddQueryParameter("source", Source.ToString()); }
            if (SwitchingProfileId != null) { request.AddQueryParameter("switching_profile_id", SwitchingProfileId.ToString()); }
            if (TransportNodeId != null) { request.AddQueryParameter("transport_node_id", TransportNodeId.ToString()); }
            if (TransportZoneId != null) { request.AddQueryParameter("transport_zone_id", TransportZoneId.ToString()); }
            request.Resource = GetLogicalPortStatusSummaryServiceURL.ToString();
            RestResponse<NSXTLogicalPortStatusSummaryType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTLogicalPortStatusSummaryType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Get operation to " + GetLogicalPortStatusSummaryServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTLogicalPortStatisticsType> GetLogicalPortStatistics(string LportId, string? Source = null)
        {
            if (LportId == null) { throw new System.ArgumentNullException("LportId cannot be null"); }
            StringBuilder GetLogicalPortStatisticsServiceURL = new StringBuilder("/logical-ports/{lport-id}/statistics");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Get
            };
            GetLogicalPortStatisticsServiceURL.Replace("{lport-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(LportId, System.Globalization.CultureInfo.InvariantCulture)));
            if (Source != null) { request.AddQueryParameter("source", Source.ToString()); }
            request.Resource = GetLogicalPortStatisticsServiceURL.ToString();
            RestResponse<NSXTLogicalPortStatisticsType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTLogicalPortStatisticsType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Get operation to " + GetLogicalPortStatisticsServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
    }
}
