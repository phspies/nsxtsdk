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
    public class AggSvcLogicalRouterPort
    {
        private RestClient restClient;
        private int retry;
        private int timeout;
        private CancellationToken cancellationToken;

        public AggSvcLogicalRouterPort(RestClient Client, CancellationToken _cancellationToken, int _timeout, int _retry)
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
        public async Task<NSXTLogicalRouterPortStatisticsSummaryType> GetLogicalRouterPortStatisticsSummary(string LogicalRouterPortId, string? Source = null)
        {
            if (LogicalRouterPortId == null) { throw new System.ArgumentNullException("LogicalRouterPortId cannot be null"); }
            StringBuilder GetLogicalRouterPortStatisticsSummaryServiceURL = new StringBuilder("/logical-router-ports/{logical-router-port-id}/statistics/summary");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Get
            };
            GetLogicalRouterPortStatisticsSummaryServiceURL.Replace("{logical-router-port-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(LogicalRouterPortId, System.Globalization.CultureInfo.InvariantCulture)));
            if (Source != null) { request.AddQueryParameter("source", Source.ToString()); }
            request.Resource = GetLogicalRouterPortStatisticsSummaryServiceURL.ToString();
            RestResponse<NSXTLogicalRouterPortStatisticsSummaryType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTLogicalRouterPortStatisticsSummaryType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Get operation to " + GetLogicalRouterPortStatisticsSummaryServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTLogicalRouterPortStatisticsType> GetLogicalRouterPortStatistics(string LogicalRouterPortId, string? Source = null, string? TransportNodeId = null)
        {
            if (LogicalRouterPortId == null) { throw new System.ArgumentNullException("LogicalRouterPortId cannot be null"); }
            StringBuilder GetLogicalRouterPortStatisticsServiceURL = new StringBuilder("/logical-router-ports/{logical-router-port-id}/statistics");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Get
            };
            GetLogicalRouterPortStatisticsServiceURL.Replace("{logical-router-port-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(LogicalRouterPortId, System.Globalization.CultureInfo.InvariantCulture)));
            if (Source != null) { request.AddQueryParameter("source", Source.ToString()); }
            if (TransportNodeId != null) { request.AddQueryParameter("transport_node_id", TransportNodeId.ToString()); }
            request.Resource = GetLogicalRouterPortStatisticsServiceURL.ToString();
            RestResponse<NSXTLogicalRouterPortStatisticsType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTLogicalRouterPortStatisticsType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Get operation to " + GetLogicalRouterPortStatisticsServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTLogicalRouterPortArpTableType> GetLogicalRouterPortArpTable(string LogicalRouterPortId, string? Cursor = null, string? IncludedFields = null, long? PageSize = null, bool? SortAscending = null, string? SortBy = null, string? Source = null, string? TransportNodeId = null)
        {
            if (LogicalRouterPortId == null) { throw new System.ArgumentNullException("LogicalRouterPortId cannot be null"); }
            StringBuilder GetLogicalRouterPortArpTableServiceURL = new StringBuilder("/logical-router-ports/{logical-router-port-id}/arp-table");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Get
            };
            GetLogicalRouterPortArpTableServiceURL.Replace("{logical-router-port-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(LogicalRouterPortId, System.Globalization.CultureInfo.InvariantCulture)));
            if (Cursor != null) { request.AddQueryParameter("cursor", Cursor.ToString()); }
            if (IncludedFields != null) { request.AddQueryParameter("included_fields", IncludedFields.ToString()); }
            if (PageSize != null) { request.AddQueryParameter("page_size", PageSize.ToString()); }
            if (SortAscending != null) { request.AddQueryParameter("sort_ascending", SortAscending.ToString()); }
            if (SortBy != null) { request.AddQueryParameter("sort_by", SortBy.ToString()); }
            if (Source != null) { request.AddQueryParameter("source", Source.ToString()); }
            if (TransportNodeId != null) { request.AddQueryParameter("transport_node_id", TransportNodeId.ToString()); }
            request.Resource = GetLogicalRouterPortArpTableServiceURL.ToString();
            RestResponse<NSXTLogicalRouterPortArpTableType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTLogicalRouterPortArpTableType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Get operation to " + GetLogicalRouterPortArpTableServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTLogicalRouterPortArpTableInCsvFormatType> GetLogicalRouterPortArpTableInCsvFormat(string LogicalRouterPortId, string? Source = null, string? TransportNodeId = null)
        {
            if (LogicalRouterPortId == null) { throw new System.ArgumentNullException("LogicalRouterPortId cannot be null"); }
            StringBuilder GetLogicalRouterPortArpTableInCsvFormatServiceURL = new StringBuilder("/logical-router-ports/{logical-router-port-id}/arp-table?format=csv");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Get
            };
            GetLogicalRouterPortArpTableInCsvFormatServiceURL.Replace("{logical-router-port-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(LogicalRouterPortId, System.Globalization.CultureInfo.InvariantCulture)));
            if (Source != null) { request.AddQueryParameter("source", Source.ToString()); }
            if (TransportNodeId != null) { request.AddQueryParameter("transport_node_id", TransportNodeId.ToString()); }
            request.Resource = GetLogicalRouterPortArpTableInCsvFormatServiceURL.ToString();
            RestResponse<NSXTLogicalRouterPortArpTableInCsvFormatType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTLogicalRouterPortArpTableInCsvFormatType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Get operation to " + GetLogicalRouterPortArpTableInCsvFormatServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
    }
}
