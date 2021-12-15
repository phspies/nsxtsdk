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
using nsxtsdk.ManagerModels;

namespace nsxtapi.ManagerModules
{
    public class AggSvcLogicalPort
    {
        RestClient restClient;
        JsonSerializerSettings defaultSerializationSettings;
        public AggSvcLogicalPort(RestClient Client, JsonSerializerSettings DefaultSerializationSettings)
        {
            restClient = Client;
            defaultSerializationSettings = DefaultSerializationSettings;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public NSXTLogicalPortOperationalStatusType GetLogicalPortOperationalStatus(string LportId, string? Source = null)
        {
            if (LportId == null) { throw new System.ArgumentNullException("LportId cannot be null"); }
            NSXTLogicalPortOperationalStatusType returnValue = default(NSXTLogicalPortOperationalStatusType);
            StringBuilder GetLogicalPortOperationalStatusServiceURL = new StringBuilder("/logical-ports/{lport-id}/status");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.GET
            };
            request.AddHeader("Content-type", "application/json");
            GetLogicalPortOperationalStatusServiceURL.Replace("{lport-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(LportId, System.Globalization.CultureInfo.InvariantCulture)));
            if (Source != null) { request.AddQueryParameter("source", Source.ToString()); }
            request.Resource = GetLogicalPortOperationalStatusServiceURL.ToString();
            var response = restClient.Execute(request);
            if (response.StatusCode == HttpStatusCode.OK)
			{
                returnValue = JsonConvert.DeserializeObject<NSXTLogicalPortOperationalStatusType>(response.Content, defaultSerializationSettings);
			}
            else
            {
                throw new NSXTException(response.Content, response.StatusCode.ToString());
            }
            return returnValue;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public NSXTLogicalPortMacAddressCsvListResultType GetLogicalPortMacTableInCsvFormatCsv(string LportId, string? Cursor = null, string? IncludedFields = null, long? PageSize = null, bool? SortAscending = null, string? SortBy = null, string? Source = null, string? TransportNodeId = null)
        {
            if (LportId == null) { throw new System.ArgumentNullException("LportId cannot be null"); }
            NSXTLogicalPortMacAddressCsvListResultType returnValue = default(NSXTLogicalPortMacAddressCsvListResultType);
            StringBuilder GetLogicalPortMacTableInCsvFormatCsvServiceURL = new StringBuilder("/logical-ports/{lport-id}/mac-table?format=csv");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.GET
            };
            request.AddHeader("Content-type", "application/json");
            GetLogicalPortMacTableInCsvFormatCsvServiceURL.Replace("{lport-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(LportId, System.Globalization.CultureInfo.InvariantCulture)));
            if (Cursor != null) { request.AddQueryParameter("cursor", Cursor.ToString()); }
            if (IncludedFields != null) { request.AddQueryParameter("included_fields", IncludedFields.ToString()); }
            if (PageSize != null) { request.AddQueryParameter("page_size", PageSize.ToString()); }
            if (SortAscending != null) { request.AddQueryParameter("sort_ascending", SortAscending.ToString()); }
            if (SortBy != null) { request.AddQueryParameter("sort_by", SortBy.ToString()); }
            if (Source != null) { request.AddQueryParameter("source", Source.ToString()); }
            if (TransportNodeId != null) { request.AddQueryParameter("transport_node_id", TransportNodeId.ToString()); }
            request.Resource = GetLogicalPortMacTableInCsvFormatCsvServiceURL.ToString();
            var response = restClient.Execute(request);
            if (response.StatusCode == HttpStatusCode.OK)
			{
                returnValue = JsonConvert.DeserializeObject<NSXTLogicalPortMacAddressCsvListResultType>(response.Content, defaultSerializationSettings);
			}
            else
            {
                throw new NSXTException(response.Content, response.StatusCode.ToString());
            }
            return returnValue;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public NSXTLogicalPortMacAddressListResultType GetLogicalPortMacTable(string LportId, string? Cursor = null, string? IncludedFields = null, long? PageSize = null, bool? SortAscending = null, string? SortBy = null, string? Source = null, string? TransportNodeId = null)
        {
            if (LportId == null) { throw new System.ArgumentNullException("LportId cannot be null"); }
            NSXTLogicalPortMacAddressListResultType returnValue = default(NSXTLogicalPortMacAddressListResultType);
            StringBuilder GetLogicalPortMacTableServiceURL = new StringBuilder("/logical-ports/{lport-id}/mac-table");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.GET
            };
            request.AddHeader("Content-type", "application/json");
            GetLogicalPortMacTableServiceURL.Replace("{lport-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(LportId, System.Globalization.CultureInfo.InvariantCulture)));
            if (Cursor != null) { request.AddQueryParameter("cursor", Cursor.ToString()); }
            if (IncludedFields != null) { request.AddQueryParameter("included_fields", IncludedFields.ToString()); }
            if (PageSize != null) { request.AddQueryParameter("page_size", PageSize.ToString()); }
            if (SortAscending != null) { request.AddQueryParameter("sort_ascending", SortAscending.ToString()); }
            if (SortBy != null) { request.AddQueryParameter("sort_by", SortBy.ToString()); }
            if (Source != null) { request.AddQueryParameter("source", Source.ToString()); }
            if (TransportNodeId != null) { request.AddQueryParameter("transport_node_id", TransportNodeId.ToString()); }
            request.Resource = GetLogicalPortMacTableServiceURL.ToString();
            var response = restClient.Execute(request);
            if (response.StatusCode == HttpStatusCode.OK)
			{
                returnValue = JsonConvert.DeserializeObject<NSXTLogicalPortMacAddressListResultType>(response.Content, defaultSerializationSettings);
			}
            else
            {
                throw new NSXTException(response.Content, response.StatusCode.ToString());
            }
            return returnValue;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public NSXTLogicalPortStatusSummaryType GetLogicalPortStatusSummary(string? AttachmentId = null, string? AttachmentType = null, string? BridgeClusterId = null, bool? ContainerPortsOnly = null, string? Cursor = null, bool? Diagnostic = null, string? IncludedFields = null, string? LogicalSwitchId = null, long? PageSize = null, string? ParentVifId = null, bool? SortAscending = null, string? SortBy = null, string? Source = null, string? SwitchingProfileId = null, string? TransportNodeId = null, string? TransportZoneId = null)
        {
            NSXTLogicalPortStatusSummaryType returnValue = default(NSXTLogicalPortStatusSummaryType);
            StringBuilder GetLogicalPortStatusSummaryServiceURL = new StringBuilder("/logical-ports/status");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.GET
            };
            request.AddHeader("Content-type", "application/json");
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
            var response = restClient.Execute(request);
            if (response.StatusCode == HttpStatusCode.OK)
			{
                returnValue = JsonConvert.DeserializeObject<NSXTLogicalPortStatusSummaryType>(response.Content, defaultSerializationSettings);
			}
            else
            {
                throw new NSXTException(response.Content, response.StatusCode.ToString());
            }
            return returnValue;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public NSXTLogicalPortStatisticsType GetLogicalPortStatistics(string LportId, string? Source = null)
        {
            if (LportId == null) { throw new System.ArgumentNullException("LportId cannot be null"); }
            NSXTLogicalPortStatisticsType returnValue = default(NSXTLogicalPortStatisticsType);
            StringBuilder GetLogicalPortStatisticsServiceURL = new StringBuilder("/logical-ports/{lport-id}/statistics");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.GET
            };
            request.AddHeader("Content-type", "application/json");
            GetLogicalPortStatisticsServiceURL.Replace("{lport-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(LportId, System.Globalization.CultureInfo.InvariantCulture)));
            if (Source != null) { request.AddQueryParameter("source", Source.ToString()); }
            request.Resource = GetLogicalPortStatisticsServiceURL.ToString();
            var response = restClient.Execute(request);
            if (response.StatusCode == HttpStatusCode.OK)
			{
                returnValue = JsonConvert.DeserializeObject<NSXTLogicalPortStatisticsType>(response.Content, defaultSerializationSettings);
			}
            else
            {
                throw new NSXTException(response.Content, response.StatusCode.ToString());
            }
            return returnValue;
        }
    }
}