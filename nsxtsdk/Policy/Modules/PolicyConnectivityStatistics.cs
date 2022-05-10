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
    public class PolicyConnectivityStatistics
    {
        private RestClient restClient;
        private int retry;
        private int timeout;
        private CancellationToken cancellationToken;

        public PolicyConnectivityStatistics(RestClient Client, CancellationToken _cancellationToken, int _timeout, int _retry)
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
        public async Task<NSXTDhcpStaticBindingStateType> ReadInfraSegmentDhcpStaticBindingState(string SegmentId, string BindingId)
        {
            if (SegmentId == null) { throw new System.ArgumentNullException("SegmentId cannot be null"); }
            if (BindingId == null) { throw new System.ArgumentNullException("BindingId cannot be null"); }
            StringBuilder ReadInfraSegmentDhcpStaticBindingStateServiceURL = new StringBuilder("/infra/segments/{segment-id}/dhcp-static-bindings/{binding-id}/state");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Get
            };
            ReadInfraSegmentDhcpStaticBindingStateServiceURL.Replace("{segment-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(SegmentId, System.Globalization.CultureInfo.InvariantCulture)));
            ReadInfraSegmentDhcpStaticBindingStateServiceURL.Replace("{binding-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(BindingId, System.Globalization.CultureInfo.InvariantCulture)));
            request.Resource = ReadInfraSegmentDhcpStaticBindingStateServiceURL.ToString();
            RestResponse<NSXTDhcpStaticBindingStateType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTDhcpStaticBindingStateType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Get operation to " + ReadInfraSegmentDhcpStaticBindingStateServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTSegmentPortMacAddressCsvListResultType> GetInfraSegmentPortMacTableInCsv(string SegmentId, string PortId, string? EnforcementPointPath = null, string? Source = null, string? TransportNodeId = null)
        {
            if (SegmentId == null) { throw new System.ArgumentNullException("SegmentId cannot be null"); }
            if (PortId == null) { throw new System.ArgumentNullException("PortId cannot be null"); }
            StringBuilder GetInfraSegmentPortMacTableInCsvServiceURL = new StringBuilder("/infra/segments/{segment-id}/ports/{port-id}/mac-table?format=csv");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Get
            };
            GetInfraSegmentPortMacTableInCsvServiceURL.Replace("{segment-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(SegmentId, System.Globalization.CultureInfo.InvariantCulture)));
            GetInfraSegmentPortMacTableInCsvServiceURL.Replace("{port-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(PortId, System.Globalization.CultureInfo.InvariantCulture)));
            if (EnforcementPointPath != null) { request.AddQueryParameter("enforcement_point_path", EnforcementPointPath.ToString()); }
            if (Source != null) { request.AddQueryParameter("source", Source.ToString()); }
            if (TransportNodeId != null) { request.AddQueryParameter("transport_node_id", TransportNodeId.ToString()); }
            request.Resource = GetInfraSegmentPortMacTableInCsvServiceURL.ToString();
            RestResponse<NSXTSegmentPortMacAddressCsvListResultType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTSegmentPortMacAddressCsvListResultType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Get operation to " + GetInfraSegmentPortMacTableInCsvServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTInterfaceArpTableInCsvFormatType> GlobalGlobalInfraGetInfraSegmentInterfaceArpTableCsv(string SegmentId, string? Cursor = null, string? EdgePath = null, string? EnforcementPointPath = null, string? HostTransportNodePath = null, string? IncludedFields = null, long? PageSize = null, bool? SortAscending = null, string? SortBy = null)
        {
            if (SegmentId == null) { throw new System.ArgumentNullException("SegmentId cannot be null"); }
            StringBuilder GlobalInfraGetInfraSegmentInterfaceArpTableCsvServiceURL = new StringBuilder("/global-infra/segments/{segment-id}/arp-table?format=csv");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Get
            };
            GlobalInfraGetInfraSegmentInterfaceArpTableCsvServiceURL.Replace("{segment-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(SegmentId, System.Globalization.CultureInfo.InvariantCulture)));
            if (Cursor != null) { request.AddQueryParameter("cursor", Cursor.ToString()); }
            if (EdgePath != null) { request.AddQueryParameter("edge_path", EdgePath.ToString()); }
            if (EnforcementPointPath != null) { request.AddQueryParameter("enforcement_point_path", EnforcementPointPath.ToString()); }
            if (HostTransportNodePath != null) { request.AddQueryParameter("host_transport_node_path", HostTransportNodePath.ToString()); }
            if (IncludedFields != null) { request.AddQueryParameter("included_fields", IncludedFields.ToString()); }
            if (PageSize != null) { request.AddQueryParameter("page_size", PageSize.ToString()); }
            if (SortAscending != null) { request.AddQueryParameter("sort_ascending", SortAscending.ToString()); }
            if (SortBy != null) { request.AddQueryParameter("sort_by", SortBy.ToString()); }
            request.Resource = GlobalInfraGetInfraSegmentInterfaceArpTableCsvServiceURL.ToString();
            RestResponse<NSXTInterfaceArpTableInCsvFormatType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTInterfaceArpTableInCsvFormatType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Get operation to " + GlobalInfraGetInfraSegmentInterfaceArpTableCsvServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTInterfaceDADStateType> GetDownlinkPortDadStateForTier1Segment(string Tier1Id, string SegmentId, string? EnforcementPointPath = null, string? Source = null)
        {
            if (Tier1Id == null) { throw new System.ArgumentNullException("Tier1Id cannot be null"); }
            if (SegmentId == null) { throw new System.ArgumentNullException("SegmentId cannot be null"); }
            StringBuilder GetDownlinkPortDadStateForTier1SegmentServiceURL = new StringBuilder("/infra/tier-1s/{tier-1-id}/segments/{segment-id}/gateway-interface-dad-state");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Get
            };
            GetDownlinkPortDadStateForTier1SegmentServiceURL.Replace("{tier-1-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(Tier1Id, System.Globalization.CultureInfo.InvariantCulture)));
            GetDownlinkPortDadStateForTier1SegmentServiceURL.Replace("{segment-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(SegmentId, System.Globalization.CultureInfo.InvariantCulture)));
            if (EnforcementPointPath != null) { request.AddQueryParameter("enforcement_point_path", EnforcementPointPath.ToString()); }
            if (Source != null) { request.AddQueryParameter("source", Source.ToString()); }
            request.Resource = GetDownlinkPortDadStateForTier1SegmentServiceURL.ToString();
            RestResponse<NSXTInterfaceDADStateType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTInterfaceDADStateType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Get operation to " + GetDownlinkPortDadStateForTier1SegmentServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTDhcpServerStatisticsType> GlobalGlobalInfraReadDhcpServerStats(string ConfigId, string ConnectivityPath, string? Cursor = null, string? EnforcementPointPath = null, bool? IncludeMarkForDeleteObjects = null, string? IncludedFields = null, long? PageSize = null, bool? SortAscending = null, string? SortBy = null)
        {
            if (ConfigId == null) { throw new System.ArgumentNullException("ConfigId cannot be null"); }
            if (ConnectivityPath == null) { throw new System.ArgumentNullException("ConnectivityPath cannot be null"); }
            StringBuilder GlobalInfraReadDhcpServerStatsServiceURL = new StringBuilder("/global-infra/dhcp-server-configs/{config-id}/stats");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Get
            };
            GlobalInfraReadDhcpServerStatsServiceURL.Replace("{config-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(ConfigId, System.Globalization.CultureInfo.InvariantCulture)));
            if (ConnectivityPath != null) { request.AddQueryParameter("connectivity_path", ConnectivityPath.ToString()); }
            if (Cursor != null) { request.AddQueryParameter("cursor", Cursor.ToString()); }
            if (EnforcementPointPath != null) { request.AddQueryParameter("enforcement_point_path", EnforcementPointPath.ToString()); }
            if (IncludeMarkForDeleteObjects != null) { request.AddQueryParameter("include_mark_for_delete_objects", IncludeMarkForDeleteObjects.ToString()); }
            if (IncludedFields != null) { request.AddQueryParameter("included_fields", IncludedFields.ToString()); }
            if (PageSize != null) { request.AddQueryParameter("page_size", PageSize.ToString()); }
            if (SortAscending != null) { request.AddQueryParameter("sort_ascending", SortAscending.ToString()); }
            if (SortBy != null) { request.AddQueryParameter("sort_by", SortBy.ToString()); }
            request.Resource = GlobalInfraReadDhcpServerStatsServiceURL.ToString();
            RestResponse<NSXTDhcpServerStatisticsType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTDhcpServerStatisticsType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Get operation to " + GlobalInfraReadDhcpServerStatsServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTDhcpServerStateType> GlobalGlobalInfraReadDhcpServerState(string ConfigId, string ConnectivityPath, string? Cursor = null, string? EnforcementPointPath = null, bool? IncludeMarkForDeleteObjects = null, string? IncludedFields = null, long? PageSize = null, bool? SortAscending = null, string? SortBy = null)
        {
            if (ConfigId == null) { throw new System.ArgumentNullException("ConfigId cannot be null"); }
            if (ConnectivityPath == null) { throw new System.ArgumentNullException("ConnectivityPath cannot be null"); }
            StringBuilder GlobalInfraReadDhcpServerStateServiceURL = new StringBuilder("/global-infra/dhcp-server-configs/{config-id}/state");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Get
            };
            GlobalInfraReadDhcpServerStateServiceURL.Replace("{config-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(ConfigId, System.Globalization.CultureInfo.InvariantCulture)));
            if (ConnectivityPath != null) { request.AddQueryParameter("connectivity_path", ConnectivityPath.ToString()); }
            if (Cursor != null) { request.AddQueryParameter("cursor", Cursor.ToString()); }
            if (EnforcementPointPath != null) { request.AddQueryParameter("enforcement_point_path", EnforcementPointPath.ToString()); }
            if (IncludeMarkForDeleteObjects != null) { request.AddQueryParameter("include_mark_for_delete_objects", IncludeMarkForDeleteObjects.ToString()); }
            if (IncludedFields != null) { request.AddQueryParameter("included_fields", IncludedFields.ToString()); }
            if (PageSize != null) { request.AddQueryParameter("page_size", PageSize.ToString()); }
            if (SortAscending != null) { request.AddQueryParameter("sort_ascending", SortAscending.ToString()); }
            if (SortBy != null) { request.AddQueryParameter("sort_by", SortBy.ToString()); }
            request.Resource = GlobalInfraReadDhcpServerStateServiceURL.ToString();
            RestResponse<NSXTDhcpServerStateType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTDhcpServerStateType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Get operation to " + GlobalInfraReadDhcpServerStateServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTPolicyBgpNeighborsStatusListResultType> GetTier0BgpNeighborsStatus(string Tier0Id, string LocaleServiceId, string? Cursor = null, string? EdgePath = null, string? EnforcementPointPath = null, bool? IncludeMarkForDeleteObjects = null, string? IncludedFields = null, long? PageSize = null, bool? SortAscending = null, string? SortBy = null)
        {
            if (Tier0Id == null) { throw new System.ArgumentNullException("Tier0Id cannot be null"); }
            if (LocaleServiceId == null) { throw new System.ArgumentNullException("LocaleServiceId cannot be null"); }
            StringBuilder GetTier0BgpNeighborsStatusServiceURL = new StringBuilder("/infra/tier-0s/{tier-0-id}/locale-services/{locale-service-id}/bgp/neighbors/status");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Get
            };
            GetTier0BgpNeighborsStatusServiceURL.Replace("{tier-0-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(Tier0Id, System.Globalization.CultureInfo.InvariantCulture)));
            GetTier0BgpNeighborsStatusServiceURL.Replace("{locale-service-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(LocaleServiceId, System.Globalization.CultureInfo.InvariantCulture)));
            if (Cursor != null) { request.AddQueryParameter("cursor", Cursor.ToString()); }
            if (EdgePath != null) { request.AddQueryParameter("edge_path", EdgePath.ToString()); }
            if (EnforcementPointPath != null) { request.AddQueryParameter("enforcement_point_path", EnforcementPointPath.ToString()); }
            if (IncludeMarkForDeleteObjects != null) { request.AddQueryParameter("include_mark_for_delete_objects", IncludeMarkForDeleteObjects.ToString()); }
            if (IncludedFields != null) { request.AddQueryParameter("included_fields", IncludedFields.ToString()); }
            if (PageSize != null) { request.AddQueryParameter("page_size", PageSize.ToString()); }
            if (SortAscending != null) { request.AddQueryParameter("sort_ascending", SortAscending.ToString()); }
            if (SortBy != null) { request.AddQueryParameter("sort_by", SortBy.ToString()); }
            request.Resource = GetTier0BgpNeighborsStatusServiceURL.ToString();
            RestResponse<NSXTPolicyBgpNeighborsStatusListResultType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTPolicyBgpNeighborsStatusListResultType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Get operation to " + GetTier0BgpNeighborsStatusServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTInterfaceArpTableInCsvFormatType> GetDownlinkPortArpTableForInfraSegmentInCsv(string SegmentId, string? Cursor = null, string? EdgePath = null, string? EnforcementPointPath = null, string? HostTransportNodePath = null, string? IncludedFields = null, long? PageSize = null, bool? SortAscending = null, string? SortBy = null)
        {
            if (SegmentId == null) { throw new System.ArgumentNullException("SegmentId cannot be null"); }
            StringBuilder GetDownlinkPortArpTableForInfraSegmentInCsvServiceURL = new StringBuilder("/infra/segments/{segment-id}/gateway-interface-arp-table?format=csv");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Get
            };
            GetDownlinkPortArpTableForInfraSegmentInCsvServiceURL.Replace("{segment-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(SegmentId, System.Globalization.CultureInfo.InvariantCulture)));
            if (Cursor != null) { request.AddQueryParameter("cursor", Cursor.ToString()); }
            if (EdgePath != null) { request.AddQueryParameter("edge_path", EdgePath.ToString()); }
            if (EnforcementPointPath != null) { request.AddQueryParameter("enforcement_point_path", EnforcementPointPath.ToString()); }
            if (HostTransportNodePath != null) { request.AddQueryParameter("host_transport_node_path", HostTransportNodePath.ToString()); }
            if (IncludedFields != null) { request.AddQueryParameter("included_fields", IncludedFields.ToString()); }
            if (PageSize != null) { request.AddQueryParameter("page_size", PageSize.ToString()); }
            if (SortAscending != null) { request.AddQueryParameter("sort_ascending", SortAscending.ToString()); }
            if (SortBy != null) { request.AddQueryParameter("sort_by", SortBy.ToString()); }
            request.Resource = GetDownlinkPortArpTableForInfraSegmentInCsvServiceURL.ToString();
            RestResponse<NSXTInterfaceArpTableInCsvFormatType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTInterfaceArpTableInCsvFormatType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Get operation to " + GetDownlinkPortArpTableForInfraSegmentInCsvServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTSegmentConfigurationStateType> GetSegmentState(string Tier1Id, string SegmentsId, string? Cursor = null, string? EdgePath = null, string? EnforcementPointPath = null, bool? IncludeMarkForDeleteObjects = null, string? IncludedFields = null, long? PageSize = null, bool? SortAscending = null, string? SortBy = null)
        {
            if (Tier1Id == null) { throw new System.ArgumentNullException("Tier1Id cannot be null"); }
            if (SegmentsId == null) { throw new System.ArgumentNullException("SegmentsId cannot be null"); }
            StringBuilder GetSegmentStateServiceURL = new StringBuilder("/infra/tier-1s/{tier-1-id}/segments/{segments-id}/state");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Get
            };
            GetSegmentStateServiceURL.Replace("{tier-1-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(Tier1Id, System.Globalization.CultureInfo.InvariantCulture)));
            GetSegmentStateServiceURL.Replace("{segments-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(SegmentsId, System.Globalization.CultureInfo.InvariantCulture)));
            if (Cursor != null) { request.AddQueryParameter("cursor", Cursor.ToString()); }
            if (EdgePath != null) { request.AddQueryParameter("edge_path", EdgePath.ToString()); }
            if (EnforcementPointPath != null) { request.AddQueryParameter("enforcement_point_path", EnforcementPointPath.ToString()); }
            if (IncludeMarkForDeleteObjects != null) { request.AddQueryParameter("include_mark_for_delete_objects", IncludeMarkForDeleteObjects.ToString()); }
            if (IncludedFields != null) { request.AddQueryParameter("included_fields", IncludedFields.ToString()); }
            if (PageSize != null) { request.AddQueryParameter("page_size", PageSize.ToString()); }
            if (SortAscending != null) { request.AddQueryParameter("sort_ascending", SortAscending.ToString()); }
            if (SortBy != null) { request.AddQueryParameter("sort_by", SortBy.ToString()); }
            request.Resource = GetSegmentStateServiceURL.ToString();
            RestResponse<NSXTSegmentConfigurationStateType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTSegmentConfigurationStateType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Get operation to " + GetSegmentStateServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTInterfaceDADStateType> GetTier0InterfaceDadstate(string Tier0Id, string LocaleServiceId, string InterfaceId, string? EnforcementPointPath = null)
        {
            if (Tier0Id == null) { throw new System.ArgumentNullException("Tier0Id cannot be null"); }
            if (LocaleServiceId == null) { throw new System.ArgumentNullException("LocaleServiceId cannot be null"); }
            if (InterfaceId == null) { throw new System.ArgumentNullException("InterfaceId cannot be null"); }
            StringBuilder GetTier0InterfaceDadstateServiceURL = new StringBuilder("/infra/tier-0s/{tier-0-id}/locale-services/{locale-service-id}/interfaces/{interface-id}/dad-state");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Get
            };
            GetTier0InterfaceDadstateServiceURL.Replace("{tier-0-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(Tier0Id, System.Globalization.CultureInfo.InvariantCulture)));
            GetTier0InterfaceDadstateServiceURL.Replace("{locale-service-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(LocaleServiceId, System.Globalization.CultureInfo.InvariantCulture)));
            GetTier0InterfaceDadstateServiceURL.Replace("{interface-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(InterfaceId, System.Globalization.CultureInfo.InvariantCulture)));
            if (EnforcementPointPath != null) { request.AddQueryParameter("enforcement_point_path", EnforcementPointPath.ToString()); }
            request.Resource = GetTier0InterfaceDadstateServiceURL.ToString();
            RestResponse<NSXTInterfaceDADStateType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTInterfaceDADStateType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Get operation to " + GetTier0InterfaceDadstateServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTPolicyInterfaceStatisticsSummaryType> GetTier0RouterLinkSummaryStatistics(string Tier0Id, string Tier1Path, string? Cursor = null, string? EdgePath = null, string? EnforcementPointPath = null, bool? IncludeMarkForDeleteObjects = null, string? IncludedFields = null, long? PageSize = null, bool? SortAscending = null, string? SortBy = null)
        {
            if (Tier0Id == null) { throw new System.ArgumentNullException("Tier0Id cannot be null"); }
            if (Tier1Path == null) { throw new System.ArgumentNullException("Tier1Path cannot be null"); }
            StringBuilder GetTier0RouterLinkSummaryStatisticsServiceURL = new StringBuilder("/infra/tier-0s/{tier-0-id}/tier-1-interface/statistics/summary");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Get
            };
            GetTier0RouterLinkSummaryStatisticsServiceURL.Replace("{tier-0-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(Tier0Id, System.Globalization.CultureInfo.InvariantCulture)));
            if (Cursor != null) { request.AddQueryParameter("cursor", Cursor.ToString()); }
            if (EdgePath != null) { request.AddQueryParameter("edge_path", EdgePath.ToString()); }
            if (EnforcementPointPath != null) { request.AddQueryParameter("enforcement_point_path", EnforcementPointPath.ToString()); }
            if (IncludeMarkForDeleteObjects != null) { request.AddQueryParameter("include_mark_for_delete_objects", IncludeMarkForDeleteObjects.ToString()); }
            if (IncludedFields != null) { request.AddQueryParameter("included_fields", IncludedFields.ToString()); }
            if (PageSize != null) { request.AddQueryParameter("page_size", PageSize.ToString()); }
            if (SortAscending != null) { request.AddQueryParameter("sort_ascending", SortAscending.ToString()); }
            if (SortBy != null) { request.AddQueryParameter("sort_by", SortBy.ToString()); }
            if (Tier1Path != null) { request.AddQueryParameter("tier1_path", Tier1Path.ToString()); }
            request.Resource = GetTier0RouterLinkSummaryStatisticsServiceURL.ToString();
            RestResponse<NSXTPolicyInterfaceStatisticsSummaryType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTPolicyInterfaceStatisticsSummaryType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Get operation to " + GetTier0RouterLinkSummaryStatisticsServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTPolicyMulticastForwardingType> GetPolicyMulticastForwarding(string Tier0Id, string LocaleServicesId, string? Cursor = null, string? EdgePath = null, string? IncludedFields = null, long? PageSize = null, bool? SortAscending = null, string? SortBy = null)
        {
            if (Tier0Id == null) { throw new System.ArgumentNullException("Tier0Id cannot be null"); }
            if (LocaleServicesId == null) { throw new System.ArgumentNullException("LocaleServicesId cannot be null"); }
            StringBuilder GetPolicyMulticastForwardingServiceURL = new StringBuilder("/infra/tier-0s/{tier-0-id}/locale-services/{locale-services-id}/multicast/forwarding");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Get
            };
            GetPolicyMulticastForwardingServiceURL.Replace("{tier-0-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(Tier0Id, System.Globalization.CultureInfo.InvariantCulture)));
            GetPolicyMulticastForwardingServiceURL.Replace("{locale-services-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(LocaleServicesId, System.Globalization.CultureInfo.InvariantCulture)));
            if (Cursor != null) { request.AddQueryParameter("cursor", Cursor.ToString()); }
            if (EdgePath != null) { request.AddQueryParameter("edge_path", EdgePath.ToString()); }
            if (IncludedFields != null) { request.AddQueryParameter("included_fields", IncludedFields.ToString()); }
            if (PageSize != null) { request.AddQueryParameter("page_size", PageSize.ToString()); }
            if (SortAscending != null) { request.AddQueryParameter("sort_ascending", SortAscending.ToString()); }
            if (SortBy != null) { request.AddQueryParameter("sort_by", SortBy.ToString()); }
            request.Resource = GetPolicyMulticastForwardingServiceURL.ToString();
            RestResponse<NSXTPolicyMulticastForwardingType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTPolicyMulticastForwardingType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Get operation to " + GetPolicyMulticastForwardingServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTInterfaceArpTableInCsvFormatType> GetInfraSegmentInterfaceArpTableCsv(string SegmentId, string? Cursor = null, string? EdgePath = null, string? EnforcementPointPath = null, string? HostTransportNodePath = null, string? IncludedFields = null, long? PageSize = null, bool? SortAscending = null, string? SortBy = null)
        {
            if (SegmentId == null) { throw new System.ArgumentNullException("SegmentId cannot be null"); }
            StringBuilder GetInfraSegmentInterfaceArpTableCsvServiceURL = new StringBuilder("/infra/segments/{segment-id}/arp-table?format=csv");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Get
            };
            GetInfraSegmentInterfaceArpTableCsvServiceURL.Replace("{segment-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(SegmentId, System.Globalization.CultureInfo.InvariantCulture)));
            if (Cursor != null) { request.AddQueryParameter("cursor", Cursor.ToString()); }
            if (EdgePath != null) { request.AddQueryParameter("edge_path", EdgePath.ToString()); }
            if (EnforcementPointPath != null) { request.AddQueryParameter("enforcement_point_path", EnforcementPointPath.ToString()); }
            if (HostTransportNodePath != null) { request.AddQueryParameter("host_transport_node_path", HostTransportNodePath.ToString()); }
            if (IncludedFields != null) { request.AddQueryParameter("included_fields", IncludedFields.ToString()); }
            if (PageSize != null) { request.AddQueryParameter("page_size", PageSize.ToString()); }
            if (SortAscending != null) { request.AddQueryParameter("sort_ascending", SortAscending.ToString()); }
            if (SortBy != null) { request.AddQueryParameter("sort_by", SortBy.ToString()); }
            request.Resource = GetInfraSegmentInterfaceArpTableCsvServiceURL.ToString();
            RestResponse<NSXTInterfaceArpTableInCsvFormatType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTInterfaceArpTableInCsvFormatType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Get operation to " + GetInfraSegmentInterfaceArpTableCsvServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTBgpNeighborRoutesListResultType> GlobalGlobalInfraGetTier0BgpNeighborRoutes(string Tier0Id, string LocaleServiceId, string NeighborId, int? Count = null, string? Cursor = null, string? EnforcementPointPath = null, string? IncludedFields = null, long? PageSize = null, bool? SortAscending = null, string? SortBy = null)
        {
            if (Tier0Id == null) { throw new System.ArgumentNullException("Tier0Id cannot be null"); }
            if (LocaleServiceId == null) { throw new System.ArgumentNullException("LocaleServiceId cannot be null"); }
            if (NeighborId == null) { throw new System.ArgumentNullException("NeighborId cannot be null"); }
            StringBuilder GlobalInfraGetTier0BgpNeighborRoutesServiceURL = new StringBuilder("/global-infra/tier-0s/{tier-0-id}/locale-services/{locale-service-id}/bgp/neighbors/{neighbor-id}/routes");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Get
            };
            GlobalInfraGetTier0BgpNeighborRoutesServiceURL.Replace("{tier-0-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(Tier0Id, System.Globalization.CultureInfo.InvariantCulture)));
            GlobalInfraGetTier0BgpNeighborRoutesServiceURL.Replace("{locale-service-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(LocaleServiceId, System.Globalization.CultureInfo.InvariantCulture)));
            GlobalInfraGetTier0BgpNeighborRoutesServiceURL.Replace("{neighbor-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(NeighborId, System.Globalization.CultureInfo.InvariantCulture)));
            if (Count != null) { request.AddQueryParameter("count", Count.ToString()); }
            if (Cursor != null) { request.AddQueryParameter("cursor", Cursor.ToString()); }
            if (EnforcementPointPath != null) { request.AddQueryParameter("enforcement_point_path", EnforcementPointPath.ToString()); }
            if (IncludedFields != null) { request.AddQueryParameter("included_fields", IncludedFields.ToString()); }
            if (PageSize != null) { request.AddQueryParameter("page_size", PageSize.ToString()); }
            if (SortAscending != null) { request.AddQueryParameter("sort_ascending", SortAscending.ToString()); }
            if (SortBy != null) { request.AddQueryParameter("sort_by", SortBy.ToString()); }
            request.Resource = GlobalInfraGetTier0BgpNeighborRoutesServiceURL.ToString();
            RestResponse<NSXTBgpNeighborRoutesListResultType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTBgpNeighborRoutesListResultType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Get operation to " + GlobalInfraGetTier0BgpNeighborRoutesServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTInterfaceArpTableInCsvFormatType> GlobalGlobalInfraGetTier0InterfaceArpTableCsv(string Tier0Id, string LocaleServiceId, string InterfaceId, string? Cursor = null, string? EdgePath = null, string? EnforcementPointPath = null, string? HostTransportNodePath = null, string? IncludedFields = null, long? PageSize = null, bool? SortAscending = null, string? SortBy = null)
        {
            if (Tier0Id == null) { throw new System.ArgumentNullException("Tier0Id cannot be null"); }
            if (LocaleServiceId == null) { throw new System.ArgumentNullException("LocaleServiceId cannot be null"); }
            if (InterfaceId == null) { throw new System.ArgumentNullException("InterfaceId cannot be null"); }
            StringBuilder GlobalInfraGetTier0InterfaceArpTableCsvServiceURL = new StringBuilder("/global-infra/tier-0s/{tier-0-id}/locale-services/{locale-service-id}/interfaces/{interface-id}/arp-table?format=csv");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Get
            };
            GlobalInfraGetTier0InterfaceArpTableCsvServiceURL.Replace("{tier-0-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(Tier0Id, System.Globalization.CultureInfo.InvariantCulture)));
            GlobalInfraGetTier0InterfaceArpTableCsvServiceURL.Replace("{locale-service-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(LocaleServiceId, System.Globalization.CultureInfo.InvariantCulture)));
            GlobalInfraGetTier0InterfaceArpTableCsvServiceURL.Replace("{interface-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(InterfaceId, System.Globalization.CultureInfo.InvariantCulture)));
            if (Cursor != null) { request.AddQueryParameter("cursor", Cursor.ToString()); }
            if (EdgePath != null) { request.AddQueryParameter("edge_path", EdgePath.ToString()); }
            if (EnforcementPointPath != null) { request.AddQueryParameter("enforcement_point_path", EnforcementPointPath.ToString()); }
            if (HostTransportNodePath != null) { request.AddQueryParameter("host_transport_node_path", HostTransportNodePath.ToString()); }
            if (IncludedFields != null) { request.AddQueryParameter("included_fields", IncludedFields.ToString()); }
            if (PageSize != null) { request.AddQueryParameter("page_size", PageSize.ToString()); }
            if (SortAscending != null) { request.AddQueryParameter("sort_ascending", SortAscending.ToString()); }
            if (SortBy != null) { request.AddQueryParameter("sort_by", SortBy.ToString()); }
            request.Resource = GlobalInfraGetTier0InterfaceArpTableCsvServiceURL.ToString();
            RestResponse<NSXTInterfaceArpTableInCsvFormatType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTInterfaceArpTableInCsvFormatType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Get operation to " + GlobalInfraGetTier0InterfaceArpTableCsvServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTPolicyTepCsvListResultType> GetTier1SegmentTepTableInCsv(string Tier1Id, string SegmentId, string? EnforcementPointPath = null, string? Source = null, string? TransportNodeId = null)
        {
            if (Tier1Id == null) { throw new System.ArgumentNullException("Tier1Id cannot be null"); }
            if (SegmentId == null) { throw new System.ArgumentNullException("SegmentId cannot be null"); }
            StringBuilder GetTier1SegmentTepTableInCsvServiceURL = new StringBuilder("/infra/tier-1s/{tier-1-id}/segments/{segment-id}/tep-table?format=csv");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Get
            };
            GetTier1SegmentTepTableInCsvServiceURL.Replace("{tier-1-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(Tier1Id, System.Globalization.CultureInfo.InvariantCulture)));
            GetTier1SegmentTepTableInCsvServiceURL.Replace("{segment-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(SegmentId, System.Globalization.CultureInfo.InvariantCulture)));
            if (EnforcementPointPath != null) { request.AddQueryParameter("enforcement_point_path", EnforcementPointPath.ToString()); }
            if (Source != null) { request.AddQueryParameter("source", Source.ToString()); }
            if (TransportNodeId != null) { request.AddQueryParameter("transport_node_id", TransportNodeId.ToString()); }
            request.Resource = GetTier1SegmentTepTableInCsvServiceURL.ToString();
            RestResponse<NSXTPolicyTepCsvListResultType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTPolicyTepCsvListResultType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Get operation to " + GetTier1SegmentTepTableInCsvServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTPolicyArpProxyTableListResultType> GlobalGlobalInfraGetTier0InterfaceArpProxies(string Tier0Id, string LocaleServiceId, string InterfaceId, string? Cursor = null, string? EnforcementPointPath = null, string? IncludedFields = null, long? PageSize = null, bool? SortAscending = null, string? SortBy = null, string? Source = null, string? TransportNodeId = null)
        {
            if (Tier0Id == null) { throw new System.ArgumentNullException("Tier0Id cannot be null"); }
            if (LocaleServiceId == null) { throw new System.ArgumentNullException("LocaleServiceId cannot be null"); }
            if (InterfaceId == null) { throw new System.ArgumentNullException("InterfaceId cannot be null"); }
            StringBuilder GlobalInfraGetTier0InterfaceArpProxiesServiceURL = new StringBuilder("/global-infra/tier-0s/{tier-0-id}/locale-services/{locale-service-id}/interfaces/{interface-id}/arp-proxy");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Get
            };
            GlobalInfraGetTier0InterfaceArpProxiesServiceURL.Replace("{tier-0-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(Tier0Id, System.Globalization.CultureInfo.InvariantCulture)));
            GlobalInfraGetTier0InterfaceArpProxiesServiceURL.Replace("{locale-service-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(LocaleServiceId, System.Globalization.CultureInfo.InvariantCulture)));
            GlobalInfraGetTier0InterfaceArpProxiesServiceURL.Replace("{interface-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(InterfaceId, System.Globalization.CultureInfo.InvariantCulture)));
            if (Cursor != null) { request.AddQueryParameter("cursor", Cursor.ToString()); }
            if (EnforcementPointPath != null) { request.AddQueryParameter("enforcement_point_path", EnforcementPointPath.ToString()); }
            if (IncludedFields != null) { request.AddQueryParameter("included_fields", IncludedFields.ToString()); }
            if (PageSize != null) { request.AddQueryParameter("page_size", PageSize.ToString()); }
            if (SortAscending != null) { request.AddQueryParameter("sort_ascending", SortAscending.ToString()); }
            if (SortBy != null) { request.AddQueryParameter("sort_by", SortBy.ToString()); }
            if (Source != null) { request.AddQueryParameter("source", Source.ToString()); }
            if (TransportNodeId != null) { request.AddQueryParameter("transport_node_id", TransportNodeId.ToString()); }
            request.Resource = GlobalInfraGetTier0InterfaceArpProxiesServiceURL.ToString();
            RestResponse<NSXTPolicyArpProxyTableListResultType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTPolicyArpProxyTableListResultType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Get operation to " + GlobalInfraGetTier0InterfaceArpProxiesServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTPolicyInterfaceStatisticsType> GetTier0RouterLinkStatistics(string Tier0Id, string Tier1Path, string? Cursor = null, string? EdgePath = null, string? EnforcementPointPath = null, bool? IncludeMarkForDeleteObjects = null, string? IncludedFields = null, long? PageSize = null, bool? SortAscending = null, string? SortBy = null)
        {
            if (Tier0Id == null) { throw new System.ArgumentNullException("Tier0Id cannot be null"); }
            if (Tier1Path == null) { throw new System.ArgumentNullException("Tier1Path cannot be null"); }
            StringBuilder GetTier0RouterLinkStatisticsServiceURL = new StringBuilder("/infra/tier-0s/{tier-0-id}/tier-1-interface/statistics");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Get
            };
            GetTier0RouterLinkStatisticsServiceURL.Replace("{tier-0-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(Tier0Id, System.Globalization.CultureInfo.InvariantCulture)));
            if (Cursor != null) { request.AddQueryParameter("cursor", Cursor.ToString()); }
            if (EdgePath != null) { request.AddQueryParameter("edge_path", EdgePath.ToString()); }
            if (EnforcementPointPath != null) { request.AddQueryParameter("enforcement_point_path", EnforcementPointPath.ToString()); }
            if (IncludeMarkForDeleteObjects != null) { request.AddQueryParameter("include_mark_for_delete_objects", IncludeMarkForDeleteObjects.ToString()); }
            if (IncludedFields != null) { request.AddQueryParameter("included_fields", IncludedFields.ToString()); }
            if (PageSize != null) { request.AddQueryParameter("page_size", PageSize.ToString()); }
            if (SortAscending != null) { request.AddQueryParameter("sort_ascending", SortAscending.ToString()); }
            if (SortBy != null) { request.AddQueryParameter("sort_by", SortBy.ToString()); }
            if (Tier1Path != null) { request.AddQueryParameter("tier1_path", Tier1Path.ToString()); }
            request.Resource = GetTier0RouterLinkStatisticsServiceURL.ToString();
            RestResponse<NSXTPolicyInterfaceStatisticsType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTPolicyInterfaceStatisticsType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Get operation to " + GetTier0RouterLinkStatisticsServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTPolicyArpProxyTableCsvListResultType> GlobalGlobalInfraGetTier1GatewayArpProxiesInCsv(string Tier1Id, string? EnforcementPointPath = null, string? Source = null, string? TransportNodeId = null)
        {
            if (Tier1Id == null) { throw new System.ArgumentNullException("Tier1Id cannot be null"); }
            StringBuilder GlobalInfraGetTier1GatewayArpProxiesInCsvServiceURL = new StringBuilder("/global-infra/tier-1s/{tier-1-id}/arp-proxies?format=csv");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Get
            };
            GlobalInfraGetTier1GatewayArpProxiesInCsvServiceURL.Replace("{tier-1-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(Tier1Id, System.Globalization.CultureInfo.InvariantCulture)));
            if (EnforcementPointPath != null) { request.AddQueryParameter("enforcement_point_path", EnforcementPointPath.ToString()); }
            if (Source != null) { request.AddQueryParameter("source", Source.ToString()); }
            if (TransportNodeId != null) { request.AddQueryParameter("transport_node_id", TransportNodeId.ToString()); }
            request.Resource = GlobalInfraGetTier1GatewayArpProxiesInCsvServiceURL.ToString();
            RestResponse<NSXTPolicyArpProxyTableCsvListResultType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTPolicyArpProxyTableCsvListResultType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Get operation to " + GlobalInfraGetTier1GatewayArpProxiesInCsvServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTBridgeEndpointStatusType> InfraSegmentBridgeEndpointStatus(string SegmentId, string BridgeProfilePath, string? EnforcementPointPath = null)
        {
            if (SegmentId == null) { throw new System.ArgumentNullException("SegmentId cannot be null"); }
            if (BridgeProfilePath == null) { throw new System.ArgumentNullException("BridgeProfilePath cannot be null"); }
            StringBuilder InfraSegmentBridgeEndpointStatusServiceURL = new StringBuilder("/infra/segments/{segment-id}/bep-status");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Get
            };
            InfraSegmentBridgeEndpointStatusServiceURL.Replace("{segment-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(SegmentId, System.Globalization.CultureInfo.InvariantCulture)));
            if (BridgeProfilePath != null) { request.AddQueryParameter("bridge_profile_path", BridgeProfilePath.ToString()); }
            if (EnforcementPointPath != null) { request.AddQueryParameter("enforcement_point_path", EnforcementPointPath.ToString()); }
            request.Resource = InfraSegmentBridgeEndpointStatusServiceURL.ToString();
            RestResponse<NSXTBridgeEndpointStatusType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTBridgeEndpointStatusType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Get operation to " + InfraSegmentBridgeEndpointStatusServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTPolicyArpProxyTableCsvListResultType> GlobalGlobalInfraGetTier0GatewayArpProxiesInCsv(string Tier0Id, string? EnforcementPointPath = null, string? Source = null, string? TransportNodeId = null)
        {
            if (Tier0Id == null) { throw new System.ArgumentNullException("Tier0Id cannot be null"); }
            StringBuilder GlobalInfraGetTier0GatewayArpProxiesInCsvServiceURL = new StringBuilder("/global-infra/tier-0s/{tier-0-id}/arp-proxies?format=csv");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Get
            };
            GlobalInfraGetTier0GatewayArpProxiesInCsvServiceURL.Replace("{tier-0-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(Tier0Id, System.Globalization.CultureInfo.InvariantCulture)));
            if (EnforcementPointPath != null) { request.AddQueryParameter("enforcement_point_path", EnforcementPointPath.ToString()); }
            if (Source != null) { request.AddQueryParameter("source", Source.ToString()); }
            if (TransportNodeId != null) { request.AddQueryParameter("transport_node_id", TransportNodeId.ToString()); }
            request.Resource = GlobalInfraGetTier0GatewayArpProxiesInCsvServiceURL.ToString();
            RestResponse<NSXTPolicyArpProxyTableCsvListResultType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTPolicyArpProxyTableCsvListResultType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Get operation to " + GlobalInfraGetTier0GatewayArpProxiesInCsvServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTSegmentPortMacAddressCsvListResultType> GlobalGlobalInfraGetInfraSegmentPortMacTableInCsv(string SegmentId, string PortId, string? EnforcementPointPath = null, string? Source = null, string? TransportNodeId = null)
        {
            if (SegmentId == null) { throw new System.ArgumentNullException("SegmentId cannot be null"); }
            if (PortId == null) { throw new System.ArgumentNullException("PortId cannot be null"); }
            StringBuilder GlobalInfraGetInfraSegmentPortMacTableInCsvServiceURL = new StringBuilder("/global-infra/segments/{segment-id}/ports/{port-id}/mac-table?format=csv");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Get
            };
            GlobalInfraGetInfraSegmentPortMacTableInCsvServiceURL.Replace("{segment-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(SegmentId, System.Globalization.CultureInfo.InvariantCulture)));
            GlobalInfraGetInfraSegmentPortMacTableInCsvServiceURL.Replace("{port-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(PortId, System.Globalization.CultureInfo.InvariantCulture)));
            if (EnforcementPointPath != null) { request.AddQueryParameter("enforcement_point_path", EnforcementPointPath.ToString()); }
            if (Source != null) { request.AddQueryParameter("source", Source.ToString()); }
            if (TransportNodeId != null) { request.AddQueryParameter("transport_node_id", TransportNodeId.ToString()); }
            request.Resource = GlobalInfraGetInfraSegmentPortMacTableInCsvServiceURL.ToString();
            RestResponse<NSXTSegmentPortMacAddressCsvListResultType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTSegmentPortMacAddressCsvListResultType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Get operation to " + GlobalInfraGetInfraSegmentPortMacTableInCsvServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTIgmpMembershipsInCsvFormatType> GetPolicyIgmpMembershipsInCsvFormat(string Tier0Id, string LocaleServicesId, string? Cursor = null, string? EdgePath = null, string? IncludedFields = null, long? PageSize = null, bool? SortAscending = null, string? SortBy = null)
        {
            if (Tier0Id == null) { throw new System.ArgumentNullException("Tier0Id cannot be null"); }
            if (LocaleServicesId == null) { throw new System.ArgumentNullException("LocaleServicesId cannot be null"); }
            StringBuilder GetPolicyIgmpMembershipsInCsvFormatServiceURL = new StringBuilder("/infra/tier-0s/{tier-0-id}/locale-services/{locale-services-id}/multicast/igmp-memberships?format=csv");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Get
            };
            GetPolicyIgmpMembershipsInCsvFormatServiceURL.Replace("{tier-0-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(Tier0Id, System.Globalization.CultureInfo.InvariantCulture)));
            GetPolicyIgmpMembershipsInCsvFormatServiceURL.Replace("{locale-services-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(LocaleServicesId, System.Globalization.CultureInfo.InvariantCulture)));
            if (Cursor != null) { request.AddQueryParameter("cursor", Cursor.ToString()); }
            if (EdgePath != null) { request.AddQueryParameter("edge_path", EdgePath.ToString()); }
            if (IncludedFields != null) { request.AddQueryParameter("included_fields", IncludedFields.ToString()); }
            if (PageSize != null) { request.AddQueryParameter("page_size", PageSize.ToString()); }
            if (SortAscending != null) { request.AddQueryParameter("sort_ascending", SortAscending.ToString()); }
            if (SortBy != null) { request.AddQueryParameter("sort_by", SortBy.ToString()); }
            request.Resource = GetPolicyIgmpMembershipsInCsvFormatServiceURL.ToString();
            RestResponse<NSXTIgmpMembershipsInCsvFormatType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTIgmpMembershipsInCsvFormatType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Get operation to " + GetPolicyIgmpMembershipsInCsvFormatServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTPolicyArpProxyTableListResultType> GlobalGlobalInfraGetTier1ArpProxies(string Tier1Id, string LocaleServiceId, string? Cursor = null, string? EnforcementPointPath = null, string? IncludedFields = null, long? PageSize = null, bool? SortAscending = null, string? SortBy = null, string? Source = null, string? TransportNodeId = null)
        {
            if (Tier1Id == null) { throw new System.ArgumentNullException("Tier1Id cannot be null"); }
            if (LocaleServiceId == null) { throw new System.ArgumentNullException("LocaleServiceId cannot be null"); }
            StringBuilder GlobalInfraGetTier1ArpProxiesServiceURL = new StringBuilder("/global-infra/tier-1s/{tier-1-id}/locale-services/{locale-service-id}/arp-proxies");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Get
            };
            GlobalInfraGetTier1ArpProxiesServiceURL.Replace("{tier-1-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(Tier1Id, System.Globalization.CultureInfo.InvariantCulture)));
            GlobalInfraGetTier1ArpProxiesServiceURL.Replace("{locale-service-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(LocaleServiceId, System.Globalization.CultureInfo.InvariantCulture)));
            if (Cursor != null) { request.AddQueryParameter("cursor", Cursor.ToString()); }
            if (EnforcementPointPath != null) { request.AddQueryParameter("enforcement_point_path", EnforcementPointPath.ToString()); }
            if (IncludedFields != null) { request.AddQueryParameter("included_fields", IncludedFields.ToString()); }
            if (PageSize != null) { request.AddQueryParameter("page_size", PageSize.ToString()); }
            if (SortAscending != null) { request.AddQueryParameter("sort_ascending", SortAscending.ToString()); }
            if (SortBy != null) { request.AddQueryParameter("sort_by", SortBy.ToString()); }
            if (Source != null) { request.AddQueryParameter("source", Source.ToString()); }
            if (TransportNodeId != null) { request.AddQueryParameter("transport_node_id", TransportNodeId.ToString()); }
            request.Resource = GlobalInfraGetTier1ArpProxiesServiceURL.ToString();
            RestResponse<NSXTPolicyArpProxyTableListResultType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTPolicyArpProxyTableListResultType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Get operation to " + GlobalInfraGetTier1ArpProxiesServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTSegmentMacAddressListResultType> GlobalGlobalInfraGetTier1SegmentMacTable(string Tier1Id, string SegmentId, string? Cursor = null, string? EnforcementPointPath = null, string? IncludedFields = null, long? PageSize = null, bool? SortAscending = null, string? SortBy = null, string? Source = null, string? TransportNodeId = null)
        {
            if (Tier1Id == null) { throw new System.ArgumentNullException("Tier1Id cannot be null"); }
            if (SegmentId == null) { throw new System.ArgumentNullException("SegmentId cannot be null"); }
            StringBuilder GlobalInfraGetTier1SegmentMacTableServiceURL = new StringBuilder("/global-infra/tier-1s/{tier-1-id}/segments/{segment-id}/mac-table");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Get
            };
            GlobalInfraGetTier1SegmentMacTableServiceURL.Replace("{tier-1-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(Tier1Id, System.Globalization.CultureInfo.InvariantCulture)));
            GlobalInfraGetTier1SegmentMacTableServiceURL.Replace("{segment-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(SegmentId, System.Globalization.CultureInfo.InvariantCulture)));
            if (Cursor != null) { request.AddQueryParameter("cursor", Cursor.ToString()); }
            if (EnforcementPointPath != null) { request.AddQueryParameter("enforcement_point_path", EnforcementPointPath.ToString()); }
            if (IncludedFields != null) { request.AddQueryParameter("included_fields", IncludedFields.ToString()); }
            if (PageSize != null) { request.AddQueryParameter("page_size", PageSize.ToString()); }
            if (SortAscending != null) { request.AddQueryParameter("sort_ascending", SortAscending.ToString()); }
            if (SortBy != null) { request.AddQueryParameter("sort_by", SortBy.ToString()); }
            if (Source != null) { request.AddQueryParameter("source", Source.ToString()); }
            if (TransportNodeId != null) { request.AddQueryParameter("transport_node_id", TransportNodeId.ToString()); }
            request.Resource = GlobalInfraGetTier1SegmentMacTableServiceURL.ToString();
            RestResponse<NSXTSegmentMacAddressListResultType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTSegmentMacAddressListResultType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Get operation to " + GlobalInfraGetTier1SegmentMacTableServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTPolicyInterfaceStatisticsSummaryType> GetTier1RouterLinkSummaryStatistics(string Tier1Id, string? Cursor = null, string? EnforcementPointPath = null, string? IncludedFields = null, long? PageSize = null, bool? SortAscending = null, string? SortBy = null)
        {
            if (Tier1Id == null) { throw new System.ArgumentNullException("Tier1Id cannot be null"); }
            StringBuilder GetTier1RouterLinkSummaryStatisticsServiceURL = new StringBuilder("/infra/tier-1s/{tier-1-id}/tier-0-interface/statistics/summary");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Get
            };
            GetTier1RouterLinkSummaryStatisticsServiceURL.Replace("{tier-1-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(Tier1Id, System.Globalization.CultureInfo.InvariantCulture)));
            if (Cursor != null) { request.AddQueryParameter("cursor", Cursor.ToString()); }
            if (EnforcementPointPath != null) { request.AddQueryParameter("enforcement_point_path", EnforcementPointPath.ToString()); }
            if (IncludedFields != null) { request.AddQueryParameter("included_fields", IncludedFields.ToString()); }
            if (PageSize != null) { request.AddQueryParameter("page_size", PageSize.ToString()); }
            if (SortAscending != null) { request.AddQueryParameter("sort_ascending", SortAscending.ToString()); }
            if (SortBy != null) { request.AddQueryParameter("sort_by", SortBy.ToString()); }
            request.Resource = GetTier1RouterLinkSummaryStatisticsServiceURL.ToString();
            RestResponse<NSXTPolicyInterfaceStatisticsSummaryType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTPolicyInterfaceStatisticsSummaryType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Get operation to " + GetTier1RouterLinkSummaryStatisticsServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTPolicyTepListResultType> GlobalGlobalInfraGetTier1SegmentTepTable(string Tier1Id, string SegmentId, string? Cursor = null, string? EnforcementPointPath = null, string? IncludedFields = null, long? PageSize = null, bool? SortAscending = null, string? SortBy = null, string? Source = null, string? TransportNodeId = null)
        {
            if (Tier1Id == null) { throw new System.ArgumentNullException("Tier1Id cannot be null"); }
            if (SegmentId == null) { throw new System.ArgumentNullException("SegmentId cannot be null"); }
            StringBuilder GlobalInfraGetTier1SegmentTepTableServiceURL = new StringBuilder("/global-infra/tier-1s/{tier-1-id}/segments/{segment-id}/tep-table");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Get
            };
            GlobalInfraGetTier1SegmentTepTableServiceURL.Replace("{tier-1-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(Tier1Id, System.Globalization.CultureInfo.InvariantCulture)));
            GlobalInfraGetTier1SegmentTepTableServiceURL.Replace("{segment-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(SegmentId, System.Globalization.CultureInfo.InvariantCulture)));
            if (Cursor != null) { request.AddQueryParameter("cursor", Cursor.ToString()); }
            if (EnforcementPointPath != null) { request.AddQueryParameter("enforcement_point_path", EnforcementPointPath.ToString()); }
            if (IncludedFields != null) { request.AddQueryParameter("included_fields", IncludedFields.ToString()); }
            if (PageSize != null) { request.AddQueryParameter("page_size", PageSize.ToString()); }
            if (SortAscending != null) { request.AddQueryParameter("sort_ascending", SortAscending.ToString()); }
            if (SortBy != null) { request.AddQueryParameter("sort_by", SortBy.ToString()); }
            if (Source != null) { request.AddQueryParameter("source", Source.ToString()); }
            if (TransportNodeId != null) { request.AddQueryParameter("transport_node_id", TransportNodeId.ToString()); }
            request.Resource = GlobalInfraGetTier1SegmentTepTableServiceURL.ToString();
            RestResponse<NSXTPolicyTepListResultType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTPolicyTepListResultType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Get operation to " + GlobalInfraGetTier1SegmentTepTableServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTInterfaceArpTableType> GetSegmentInterfaceArpTable(string Tier1Id, string SegmentId, string? Cursor = null, string? EdgePath = null, string? EnforcementPointPath = null, string? HostTransportNodePath = null, string? IncludedFields = null, long? PageSize = null, bool? SortAscending = null, string? SortBy = null)
        {
            if (Tier1Id == null) { throw new System.ArgumentNullException("Tier1Id cannot be null"); }
            if (SegmentId == null) { throw new System.ArgumentNullException("SegmentId cannot be null"); }
            StringBuilder GetSegmentInterfaceArpTableServiceURL = new StringBuilder("/infra/tier-1s/{tier-1-id}/segments/{segment-id}/arp-table");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Get
            };
            GetSegmentInterfaceArpTableServiceURL.Replace("{tier-1-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(Tier1Id, System.Globalization.CultureInfo.InvariantCulture)));
            GetSegmentInterfaceArpTableServiceURL.Replace("{segment-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(SegmentId, System.Globalization.CultureInfo.InvariantCulture)));
            if (Cursor != null) { request.AddQueryParameter("cursor", Cursor.ToString()); }
            if (EdgePath != null) { request.AddQueryParameter("edge_path", EdgePath.ToString()); }
            if (EnforcementPointPath != null) { request.AddQueryParameter("enforcement_point_path", EnforcementPointPath.ToString()); }
            if (HostTransportNodePath != null) { request.AddQueryParameter("host_transport_node_path", HostTransportNodePath.ToString()); }
            if (IncludedFields != null) { request.AddQueryParameter("included_fields", IncludedFields.ToString()); }
            if (PageSize != null) { request.AddQueryParameter("page_size", PageSize.ToString()); }
            if (SortAscending != null) { request.AddQueryParameter("sort_ascending", SortAscending.ToString()); }
            if (SortBy != null) { request.AddQueryParameter("sort_by", SortBy.ToString()); }
            request.Resource = GetSegmentInterfaceArpTableServiceURL.ToString();
            RestResponse<NSXTInterfaceArpTableType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTInterfaceArpTableType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Get operation to " + GetSegmentInterfaceArpTableServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTPolicyArpProxyTableListResultType> GetTier1ArpProxies(string Tier1Id, string LocaleServiceId, string? Cursor = null, string? EnforcementPointPath = null, string? IncludedFields = null, long? PageSize = null, bool? SortAscending = null, string? SortBy = null, string? Source = null, string? TransportNodeId = null)
        {
            if (Tier1Id == null) { throw new System.ArgumentNullException("Tier1Id cannot be null"); }
            if (LocaleServiceId == null) { throw new System.ArgumentNullException("LocaleServiceId cannot be null"); }
            StringBuilder GetTier1ArpProxiesServiceURL = new StringBuilder("/infra/tier-1s/{tier-1-id}/locale-services/{locale-service-id}/arp-proxies");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Get
            };
            GetTier1ArpProxiesServiceURL.Replace("{tier-1-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(Tier1Id, System.Globalization.CultureInfo.InvariantCulture)));
            GetTier1ArpProxiesServiceURL.Replace("{locale-service-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(LocaleServiceId, System.Globalization.CultureInfo.InvariantCulture)));
            if (Cursor != null) { request.AddQueryParameter("cursor", Cursor.ToString()); }
            if (EnforcementPointPath != null) { request.AddQueryParameter("enforcement_point_path", EnforcementPointPath.ToString()); }
            if (IncludedFields != null) { request.AddQueryParameter("included_fields", IncludedFields.ToString()); }
            if (PageSize != null) { request.AddQueryParameter("page_size", PageSize.ToString()); }
            if (SortAscending != null) { request.AddQueryParameter("sort_ascending", SortAscending.ToString()); }
            if (SortBy != null) { request.AddQueryParameter("sort_by", SortBy.ToString()); }
            if (Source != null) { request.AddQueryParameter("source", Source.ToString()); }
            if (TransportNodeId != null) { request.AddQueryParameter("transport_node_id", TransportNodeId.ToString()); }
            request.Resource = GetTier1ArpProxiesServiceURL.ToString();
            RestResponse<NSXTPolicyArpProxyTableListResultType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTPolicyArpProxyTableListResultType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Get operation to " + GetTier1ArpProxiesServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTSegmentPortStateType> GlobalGlobalInfraGetTier1SegmentPortState(string Tier1Id, string SegmentId, string PortId, string? EnforcementPointPath = null, string? Source = null)
        {
            if (Tier1Id == null) { throw new System.ArgumentNullException("Tier1Id cannot be null"); }
            if (SegmentId == null) { throw new System.ArgumentNullException("SegmentId cannot be null"); }
            if (PortId == null) { throw new System.ArgumentNullException("PortId cannot be null"); }
            StringBuilder GlobalInfraGetTier1SegmentPortStateServiceURL = new StringBuilder("/global-infra/tier-1s/{tier-1-id}/segments/{segment-id}/ports/{port-id}/state");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Get
            };
            GlobalInfraGetTier1SegmentPortStateServiceURL.Replace("{tier-1-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(Tier1Id, System.Globalization.CultureInfo.InvariantCulture)));
            GlobalInfraGetTier1SegmentPortStateServiceURL.Replace("{segment-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(SegmentId, System.Globalization.CultureInfo.InvariantCulture)));
            GlobalInfraGetTier1SegmentPortStateServiceURL.Replace("{port-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(PortId, System.Globalization.CultureInfo.InvariantCulture)));
            if (EnforcementPointPath != null) { request.AddQueryParameter("enforcement_point_path", EnforcementPointPath.ToString()); }
            if (Source != null) { request.AddQueryParameter("source", Source.ToString()); }
            request.Resource = GlobalInfraGetTier1SegmentPortStateServiceURL.ToString();
            RestResponse<NSXTSegmentPortStateType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTSegmentPortStateType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Get operation to " + GlobalInfraGetTier1SegmentPortStateServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTRoutingTableListResultType> GetTier1ForwardingTable(string Tier1Id, string? Cursor = null, string? EdgeId = null, string? EdgePath = null, string? EnforcementPointPath = null, string? IncludedFields = null, string? NetworkPrefix = null, long? PageSize = null, string? RouteSource = null, bool? SortAscending = null, string? SortBy = null)
        {
            if (Tier1Id == null) { throw new System.ArgumentNullException("Tier1Id cannot be null"); }
            StringBuilder GetTier1ForwardingTableServiceURL = new StringBuilder("/infra/tier-1s/{tier-1-id}/forwarding-table");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Get
            };
            GetTier1ForwardingTableServiceURL.Replace("{tier-1-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(Tier1Id, System.Globalization.CultureInfo.InvariantCulture)));
            if (Cursor != null) { request.AddQueryParameter("cursor", Cursor.ToString()); }
            if (EdgeId != null) { request.AddQueryParameter("edge_id", EdgeId.ToString()); }
            if (EdgePath != null) { request.AddQueryParameter("edge_path", EdgePath.ToString()); }
            if (EnforcementPointPath != null) { request.AddQueryParameter("enforcement_point_path", EnforcementPointPath.ToString()); }
            if (IncludedFields != null) { request.AddQueryParameter("included_fields", IncludedFields.ToString()); }
            if (NetworkPrefix != null) { request.AddQueryParameter("network_prefix", NetworkPrefix.ToString()); }
            if (PageSize != null) { request.AddQueryParameter("page_size", PageSize.ToString()); }
            if (RouteSource != null) { request.AddQueryParameter("route_source", RouteSource.ToString()); }
            if (SortAscending != null) { request.AddQueryParameter("sort_ascending", SortAscending.ToString()); }
            if (SortBy != null) { request.AddQueryParameter("sort_by", SortBy.ToString()); }
            request.Resource = GetTier1ForwardingTableServiceURL.ToString();
            RestResponse<NSXTRoutingTableListResultType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTRoutingTableListResultType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Get operation to " + GetTier1ForwardingTableServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTPolicyInterfaceStatisticsType> GetTier1InterfaceStatistics(string Tier1Id, string LocaleServiceId, string InterfaceId, string? Cursor = null, string? EdgePath = null, string? EnforcementPointPath = null, bool? IncludeMarkForDeleteObjects = null, string? IncludedFields = null, long? PageSize = null, bool? SortAscending = null, string? SortBy = null)
        {
            if (Tier1Id == null) { throw new System.ArgumentNullException("Tier1Id cannot be null"); }
            if (LocaleServiceId == null) { throw new System.ArgumentNullException("LocaleServiceId cannot be null"); }
            if (InterfaceId == null) { throw new System.ArgumentNullException("InterfaceId cannot be null"); }
            StringBuilder GetTier1InterfaceStatisticsServiceURL = new StringBuilder("/infra/tier-1s/{tier-1-id}/locale-services/{locale-service-id}/interfaces/{interface-id}/statistics");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Get
            };
            GetTier1InterfaceStatisticsServiceURL.Replace("{tier-1-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(Tier1Id, System.Globalization.CultureInfo.InvariantCulture)));
            GetTier1InterfaceStatisticsServiceURL.Replace("{locale-service-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(LocaleServiceId, System.Globalization.CultureInfo.InvariantCulture)));
            GetTier1InterfaceStatisticsServiceURL.Replace("{interface-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(InterfaceId, System.Globalization.CultureInfo.InvariantCulture)));
            if (Cursor != null) { request.AddQueryParameter("cursor", Cursor.ToString()); }
            if (EdgePath != null) { request.AddQueryParameter("edge_path", EdgePath.ToString()); }
            if (EnforcementPointPath != null) { request.AddQueryParameter("enforcement_point_path", EnforcementPointPath.ToString()); }
            if (IncludeMarkForDeleteObjects != null) { request.AddQueryParameter("include_mark_for_delete_objects", IncludeMarkForDeleteObjects.ToString()); }
            if (IncludedFields != null) { request.AddQueryParameter("included_fields", IncludedFields.ToString()); }
            if (PageSize != null) { request.AddQueryParameter("page_size", PageSize.ToString()); }
            if (SortAscending != null) { request.AddQueryParameter("sort_ascending", SortAscending.ToString()); }
            if (SortBy != null) { request.AddQueryParameter("sort_by", SortBy.ToString()); }
            request.Resource = GetTier1InterfaceStatisticsServiceURL.ToString();
            RestResponse<NSXTPolicyInterfaceStatisticsType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTPolicyInterfaceStatisticsType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Get operation to " + GetTier1InterfaceStatisticsServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTPolicyInterfaceStatisticsType> GlobalGlobalInfraGetTier0InterfaceStatistics(string Tier0Id, string LocaleServiceId, string InterfaceId, string? Cursor = null, string? EdgePath = null, string? EnforcementPointPath = null, bool? IncludeMarkForDeleteObjects = null, string? IncludedFields = null, long? PageSize = null, bool? SortAscending = null, string? SortBy = null)
        {
            if (Tier0Id == null) { throw new System.ArgumentNullException("Tier0Id cannot be null"); }
            if (LocaleServiceId == null) { throw new System.ArgumentNullException("LocaleServiceId cannot be null"); }
            if (InterfaceId == null) { throw new System.ArgumentNullException("InterfaceId cannot be null"); }
            StringBuilder GlobalInfraGetTier0InterfaceStatisticsServiceURL = new StringBuilder("/global-infra/tier-0s/{tier-0-id}/locale-services/{locale-service-id}/interfaces/{interface-id}/statistics");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Get
            };
            GlobalInfraGetTier0InterfaceStatisticsServiceURL.Replace("{tier-0-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(Tier0Id, System.Globalization.CultureInfo.InvariantCulture)));
            GlobalInfraGetTier0InterfaceStatisticsServiceURL.Replace("{locale-service-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(LocaleServiceId, System.Globalization.CultureInfo.InvariantCulture)));
            GlobalInfraGetTier0InterfaceStatisticsServiceURL.Replace("{interface-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(InterfaceId, System.Globalization.CultureInfo.InvariantCulture)));
            if (Cursor != null) { request.AddQueryParameter("cursor", Cursor.ToString()); }
            if (EdgePath != null) { request.AddQueryParameter("edge_path", EdgePath.ToString()); }
            if (EnforcementPointPath != null) { request.AddQueryParameter("enforcement_point_path", EnforcementPointPath.ToString()); }
            if (IncludeMarkForDeleteObjects != null) { request.AddQueryParameter("include_mark_for_delete_objects", IncludeMarkForDeleteObjects.ToString()); }
            if (IncludedFields != null) { request.AddQueryParameter("included_fields", IncludedFields.ToString()); }
            if (PageSize != null) { request.AddQueryParameter("page_size", PageSize.ToString()); }
            if (SortAscending != null) { request.AddQueryParameter("sort_ascending", SortAscending.ToString()); }
            if (SortBy != null) { request.AddQueryParameter("sort_by", SortBy.ToString()); }
            request.Resource = GlobalInfraGetTier0InterfaceStatisticsServiceURL.ToString();
            RestResponse<NSXTPolicyInterfaceStatisticsType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTPolicyInterfaceStatisticsType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Get operation to " + GlobalInfraGetTier0InterfaceStatisticsServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTIgmpMembershipsType> GetPolicyIgmpMemberships(string Tier0Id, string LocaleServicesId, string? Cursor = null, string? EdgePath = null, string? IncludedFields = null, long? PageSize = null, bool? SortAscending = null, string? SortBy = null)
        {
            if (Tier0Id == null) { throw new System.ArgumentNullException("Tier0Id cannot be null"); }
            if (LocaleServicesId == null) { throw new System.ArgumentNullException("LocaleServicesId cannot be null"); }
            StringBuilder GetPolicyIgmpMembershipsServiceURL = new StringBuilder("/infra/tier-0s/{tier-0-id}/locale-services/{locale-services-id}/multicast/igmp-memberships");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Get
            };
            GetPolicyIgmpMembershipsServiceURL.Replace("{tier-0-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(Tier0Id, System.Globalization.CultureInfo.InvariantCulture)));
            GetPolicyIgmpMembershipsServiceURL.Replace("{locale-services-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(LocaleServicesId, System.Globalization.CultureInfo.InvariantCulture)));
            if (Cursor != null) { request.AddQueryParameter("cursor", Cursor.ToString()); }
            if (EdgePath != null) { request.AddQueryParameter("edge_path", EdgePath.ToString()); }
            if (IncludedFields != null) { request.AddQueryParameter("included_fields", IncludedFields.ToString()); }
            if (PageSize != null) { request.AddQueryParameter("page_size", PageSize.ToString()); }
            if (SortAscending != null) { request.AddQueryParameter("sort_ascending", SortAscending.ToString()); }
            if (SortBy != null) { request.AddQueryParameter("sort_by", SortBy.ToString()); }
            request.Resource = GetPolicyIgmpMembershipsServiceURL.ToString();
            RestResponse<NSXTIgmpMembershipsType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTIgmpMembershipsType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Get operation to " + GetPolicyIgmpMembershipsServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTPolicyInterfaceStatisticsSummaryType> GlobalGlobalInfraGetTier0InterfaceStatisticsSummary(string Tier0Id, string LocaleServiceId, string InterfaceId, string? Cursor = null, string? EnforcementPointPath = null, string? IncludedFields = null, long? PageSize = null, bool? SortAscending = null, string? SortBy = null)
        {
            if (Tier0Id == null) { throw new System.ArgumentNullException("Tier0Id cannot be null"); }
            if (LocaleServiceId == null) { throw new System.ArgumentNullException("LocaleServiceId cannot be null"); }
            if (InterfaceId == null) { throw new System.ArgumentNullException("InterfaceId cannot be null"); }
            StringBuilder GlobalInfraGetTier0InterfaceStatisticsSummaryServiceURL = new StringBuilder("/global-infra/tier-0s/{tier-0-id}/locale-services/{locale-service-id}/interfaces/{interface-id}/statistics/summary");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Get
            };
            GlobalInfraGetTier0InterfaceStatisticsSummaryServiceURL.Replace("{tier-0-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(Tier0Id, System.Globalization.CultureInfo.InvariantCulture)));
            GlobalInfraGetTier0InterfaceStatisticsSummaryServiceURL.Replace("{locale-service-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(LocaleServiceId, System.Globalization.CultureInfo.InvariantCulture)));
            GlobalInfraGetTier0InterfaceStatisticsSummaryServiceURL.Replace("{interface-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(InterfaceId, System.Globalization.CultureInfo.InvariantCulture)));
            if (Cursor != null) { request.AddQueryParameter("cursor", Cursor.ToString()); }
            if (EnforcementPointPath != null) { request.AddQueryParameter("enforcement_point_path", EnforcementPointPath.ToString()); }
            if (IncludedFields != null) { request.AddQueryParameter("included_fields", IncludedFields.ToString()); }
            if (PageSize != null) { request.AddQueryParameter("page_size", PageSize.ToString()); }
            if (SortAscending != null) { request.AddQueryParameter("sort_ascending", SortAscending.ToString()); }
            if (SortBy != null) { request.AddQueryParameter("sort_by", SortBy.ToString()); }
            request.Resource = GlobalInfraGetTier0InterfaceStatisticsSummaryServiceURL.ToString();
            RestResponse<NSXTPolicyInterfaceStatisticsSummaryType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTPolicyInterfaceStatisticsSummaryType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Get operation to " + GlobalInfraGetTier0InterfaceStatisticsSummaryServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTPolicyArpProxyTableCsvListResultType> GetTier0GatewayArpProxiesInCsv(string Tier0Id, string? EnforcementPointPath = null, string? Source = null, string? TransportNodeId = null)
        {
            if (Tier0Id == null) { throw new System.ArgumentNullException("Tier0Id cannot be null"); }
            StringBuilder GetTier0GatewayArpProxiesInCsvServiceURL = new StringBuilder("/infra/tier-0s/{tier-0-id}/arp-proxies?format=csv");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Get
            };
            GetTier0GatewayArpProxiesInCsvServiceURL.Replace("{tier-0-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(Tier0Id, System.Globalization.CultureInfo.InvariantCulture)));
            if (EnforcementPointPath != null) { request.AddQueryParameter("enforcement_point_path", EnforcementPointPath.ToString()); }
            if (Source != null) { request.AddQueryParameter("source", Source.ToString()); }
            if (TransportNodeId != null) { request.AddQueryParameter("transport_node_id", TransportNodeId.ToString()); }
            request.Resource = GetTier0GatewayArpProxiesInCsvServiceURL.ToString();
            RestResponse<NSXTPolicyArpProxyTableCsvListResultType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTPolicyArpProxyTableCsvListResultType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Get operation to " + GetTier0GatewayArpProxiesInCsvServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTPolicyMulticastForwardingInCsvFormatType> GetTier1PolicyMulticastForwardingInCsvFormat(string Tier1Id, string LocaleServicesId, string? Cursor = null, string? EdgePath = null, string? IncludedFields = null, long? PageSize = null, bool? SortAscending = null, string? SortBy = null)
        {
            if (Tier1Id == null) { throw new System.ArgumentNullException("Tier1Id cannot be null"); }
            if (LocaleServicesId == null) { throw new System.ArgumentNullException("LocaleServicesId cannot be null"); }
            StringBuilder GetTier1PolicyMulticastForwardingInCsvFormatServiceURL = new StringBuilder("/infra/tier-1s/{tier-1-id}/locale-services/{locale-services-id}/multicast/forwarding?format=csv");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Get
            };
            GetTier1PolicyMulticastForwardingInCsvFormatServiceURL.Replace("{tier-1-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(Tier1Id, System.Globalization.CultureInfo.InvariantCulture)));
            GetTier1PolicyMulticastForwardingInCsvFormatServiceURL.Replace("{locale-services-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(LocaleServicesId, System.Globalization.CultureInfo.InvariantCulture)));
            if (Cursor != null) { request.AddQueryParameter("cursor", Cursor.ToString()); }
            if (EdgePath != null) { request.AddQueryParameter("edge_path", EdgePath.ToString()); }
            if (IncludedFields != null) { request.AddQueryParameter("included_fields", IncludedFields.ToString()); }
            if (PageSize != null) { request.AddQueryParameter("page_size", PageSize.ToString()); }
            if (SortAscending != null) { request.AddQueryParameter("sort_ascending", SortAscending.ToString()); }
            if (SortBy != null) { request.AddQueryParameter("sort_by", SortBy.ToString()); }
            request.Resource = GetTier1PolicyMulticastForwardingInCsvFormatServiceURL.ToString();
            RestResponse<NSXTPolicyMulticastForwardingInCsvFormatType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTPolicyMulticastForwardingInCsvFormatType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Get operation to " + GetTier1PolicyMulticastForwardingInCsvFormatServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTInterfaceArpTableInCsvFormatType> GetTier0RouterLinkArpTableCsv(string Tier0Id, string Tier1Path, string? Cursor = null, string? EdgePath = null, string? EnforcementPointPath = null, bool? IncludeMarkForDeleteObjects = null, string? IncludedFields = null, long? PageSize = null, bool? SortAscending = null, string? SortBy = null)
        {
            if (Tier0Id == null) { throw new System.ArgumentNullException("Tier0Id cannot be null"); }
            if (Tier1Path == null) { throw new System.ArgumentNullException("Tier1Path cannot be null"); }
            StringBuilder GetTier0RouterLinkArpTableCsvServiceURL = new StringBuilder("/infra/tier-0s/{tier-0-id}/tier-1-interface/arp-table?format=csv");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Get
            };
            GetTier0RouterLinkArpTableCsvServiceURL.Replace("{tier-0-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(Tier0Id, System.Globalization.CultureInfo.InvariantCulture)));
            if (Cursor != null) { request.AddQueryParameter("cursor", Cursor.ToString()); }
            if (EdgePath != null) { request.AddQueryParameter("edge_path", EdgePath.ToString()); }
            if (EnforcementPointPath != null) { request.AddQueryParameter("enforcement_point_path", EnforcementPointPath.ToString()); }
            if (IncludeMarkForDeleteObjects != null) { request.AddQueryParameter("include_mark_for_delete_objects", IncludeMarkForDeleteObjects.ToString()); }
            if (IncludedFields != null) { request.AddQueryParameter("included_fields", IncludedFields.ToString()); }
            if (PageSize != null) { request.AddQueryParameter("page_size", PageSize.ToString()); }
            if (SortAscending != null) { request.AddQueryParameter("sort_ascending", SortAscending.ToString()); }
            if (SortBy != null) { request.AddQueryParameter("sort_by", SortBy.ToString()); }
            if (Tier1Path != null) { request.AddQueryParameter("tier1_path", Tier1Path.ToString()); }
            request.Resource = GetTier0RouterLinkArpTableCsvServiceURL.ToString();
            RestResponse<NSXTInterfaceArpTableInCsvFormatType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTInterfaceArpTableInCsvFormatType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Get operation to " + GetTier0RouterLinkArpTableCsvServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTBridgeEndpointStatisticsType> InfraSegmentBridgeEndpointStatistics(string SegmentId, string BridgeProfilePath, string? EnforcementPointPath = null)
        {
            if (SegmentId == null) { throw new System.ArgumentNullException("SegmentId cannot be null"); }
            if (BridgeProfilePath == null) { throw new System.ArgumentNullException("BridgeProfilePath cannot be null"); }
            StringBuilder InfraSegmentBridgeEndpointStatisticsServiceURL = new StringBuilder("/infra/segments/{segment-id}/bep-statistics");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Get
            };
            InfraSegmentBridgeEndpointStatisticsServiceURL.Replace("{segment-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(SegmentId, System.Globalization.CultureInfo.InvariantCulture)));
            if (BridgeProfilePath != null) { request.AddQueryParameter("bridge_profile_path", BridgeProfilePath.ToString()); }
            if (EnforcementPointPath != null) { request.AddQueryParameter("enforcement_point_path", EnforcementPointPath.ToString()); }
            request.Resource = InfraSegmentBridgeEndpointStatisticsServiceURL.ToString();
            RestResponse<NSXTBridgeEndpointStatisticsType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTBridgeEndpointStatisticsType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Get operation to " + InfraSegmentBridgeEndpointStatisticsServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTPolicyInterfaceStatisticsSummaryType> GetDownlinkPortStatisticsSummaryForInfraSegment(string SegmentId, string? EnforcementPointPath = null, string? Source = null)
        {
            if (SegmentId == null) { throw new System.ArgumentNullException("SegmentId cannot be null"); }
            StringBuilder GetDownlinkPortStatisticsSummaryForInfraSegmentServiceURL = new StringBuilder("/infra/segments/{segment-id}/gateway-interface-statistics/summary");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Get
            };
            GetDownlinkPortStatisticsSummaryForInfraSegmentServiceURL.Replace("{segment-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(SegmentId, System.Globalization.CultureInfo.InvariantCulture)));
            if (EnforcementPointPath != null) { request.AddQueryParameter("enforcement_point_path", EnforcementPointPath.ToString()); }
            if (Source != null) { request.AddQueryParameter("source", Source.ToString()); }
            request.Resource = GetDownlinkPortStatisticsSummaryForInfraSegmentServiceURL.ToString();
            RestResponse<NSXTPolicyInterfaceStatisticsSummaryType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTPolicyInterfaceStatisticsSummaryType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Get operation to " + GetDownlinkPortStatisticsSummaryForInfraSegmentServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTBgpNeighborRouteDetailsInCsvFormatType> GetTier0BgpNeighborAdvertisedRoutesInCsvFormat(string Tier0Id, string LocaleServiceId, string NeighborId, int? Count = null, string? Cursor = null, string? EnforcementPointPath = null, string? IncludedFields = null, long? PageSize = null, bool? SortAscending = null, string? SortBy = null)
        {
            if (Tier0Id == null) { throw new System.ArgumentNullException("Tier0Id cannot be null"); }
            if (LocaleServiceId == null) { throw new System.ArgumentNullException("LocaleServiceId cannot be null"); }
            if (NeighborId == null) { throw new System.ArgumentNullException("NeighborId cannot be null"); }
            StringBuilder GetTier0BgpNeighborAdvertisedRoutesInCsvFormatServiceURL = new StringBuilder("/infra/tier-0s/{tier-0-id}/locale-services/{locale-service-id}/bgp/neighbors/{neighbor-id}/advertised-routes?format=csv");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Get
            };
            GetTier0BgpNeighborAdvertisedRoutesInCsvFormatServiceURL.Replace("{tier-0-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(Tier0Id, System.Globalization.CultureInfo.InvariantCulture)));
            GetTier0BgpNeighborAdvertisedRoutesInCsvFormatServiceURL.Replace("{locale-service-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(LocaleServiceId, System.Globalization.CultureInfo.InvariantCulture)));
            GetTier0BgpNeighborAdvertisedRoutesInCsvFormatServiceURL.Replace("{neighbor-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(NeighborId, System.Globalization.CultureInfo.InvariantCulture)));
            if (Count != null) { request.AddQueryParameter("count", Count.ToString()); }
            if (Cursor != null) { request.AddQueryParameter("cursor", Cursor.ToString()); }
            if (EnforcementPointPath != null) { request.AddQueryParameter("enforcement_point_path", EnforcementPointPath.ToString()); }
            if (IncludedFields != null) { request.AddQueryParameter("included_fields", IncludedFields.ToString()); }
            if (PageSize != null) { request.AddQueryParameter("page_size", PageSize.ToString()); }
            if (SortAscending != null) { request.AddQueryParameter("sort_ascending", SortAscending.ToString()); }
            if (SortBy != null) { request.AddQueryParameter("sort_by", SortBy.ToString()); }
            request.Resource = GetTier0BgpNeighborAdvertisedRoutesInCsvFormatServiceURL.ToString();
            RestResponse<NSXTBgpNeighborRouteDetailsInCsvFormatType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTBgpNeighborRouteDetailsInCsvFormatType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Get operation to " + GetTier0BgpNeighborAdvertisedRoutesInCsvFormatServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTPolicyArpProxyTableListResultType> GlobalGlobalInfraGetDownlinkPortArpProxiesForInfraSegment(string SegmentId, string? Cursor = null, string? EnforcementPointPath = null, string? IncludedFields = null, long? PageSize = null, bool? SortAscending = null, string? SortBy = null, string? Source = null, string? TransportNodeId = null)
        {
            if (SegmentId == null) { throw new System.ArgumentNullException("SegmentId cannot be null"); }
            StringBuilder GlobalInfraGetDownlinkPortArpProxiesForInfraSegmentServiceURL = new StringBuilder("/global-infra/segments/{segment-id}/arp-proxy");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Get
            };
            GlobalInfraGetDownlinkPortArpProxiesForInfraSegmentServiceURL.Replace("{segment-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(SegmentId, System.Globalization.CultureInfo.InvariantCulture)));
            if (Cursor != null) { request.AddQueryParameter("cursor", Cursor.ToString()); }
            if (EnforcementPointPath != null) { request.AddQueryParameter("enforcement_point_path", EnforcementPointPath.ToString()); }
            if (IncludedFields != null) { request.AddQueryParameter("included_fields", IncludedFields.ToString()); }
            if (PageSize != null) { request.AddQueryParameter("page_size", PageSize.ToString()); }
            if (SortAscending != null) { request.AddQueryParameter("sort_ascending", SortAscending.ToString()); }
            if (SortBy != null) { request.AddQueryParameter("sort_by", SortBy.ToString()); }
            if (Source != null) { request.AddQueryParameter("source", Source.ToString()); }
            if (TransportNodeId != null) { request.AddQueryParameter("transport_node_id", TransportNodeId.ToString()); }
            request.Resource = GlobalInfraGetDownlinkPortArpProxiesForInfraSegmentServiceURL.ToString();
            RestResponse<NSXTPolicyArpProxyTableListResultType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTPolicyArpProxyTableListResultType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Get operation to " + GlobalInfraGetDownlinkPortArpProxiesForInfraSegmentServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTPolicyArpProxyTableCsvListResultType> GlobalGlobalInfraGetDownlinkPortArpProxiesForTier1SegmentInCsv(string Tier1Id, string SegmentId, string? EnforcementPointPath = null, string? Source = null, string? TransportNodeId = null)
        {
            if (Tier1Id == null) { throw new System.ArgumentNullException("Tier1Id cannot be null"); }
            if (SegmentId == null) { throw new System.ArgumentNullException("SegmentId cannot be null"); }
            StringBuilder GlobalInfraGetDownlinkPortArpProxiesForTier1SegmentInCsvServiceURL = new StringBuilder("/global-infra/tier-1s/{tier-1-id}/segments/{segment-id}/arp-proxy?format=csv");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Get
            };
            GlobalInfraGetDownlinkPortArpProxiesForTier1SegmentInCsvServiceURL.Replace("{tier-1-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(Tier1Id, System.Globalization.CultureInfo.InvariantCulture)));
            GlobalInfraGetDownlinkPortArpProxiesForTier1SegmentInCsvServiceURL.Replace("{segment-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(SegmentId, System.Globalization.CultureInfo.InvariantCulture)));
            if (EnforcementPointPath != null) { request.AddQueryParameter("enforcement_point_path", EnforcementPointPath.ToString()); }
            if (Source != null) { request.AddQueryParameter("source", Source.ToString()); }
            if (TransportNodeId != null) { request.AddQueryParameter("transport_node_id", TransportNodeId.ToString()); }
            request.Resource = GlobalInfraGetDownlinkPortArpProxiesForTier1SegmentInCsvServiceURL.ToString();
            RestResponse<NSXTPolicyArpProxyTableCsvListResultType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTPolicyArpProxyTableCsvListResultType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Get operation to " + GlobalInfraGetDownlinkPortArpProxiesForTier1SegmentInCsvServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTSegmentL2ForwarderSiteSpanInfoType> GlobalGlobalInfraGetInfraSegmentCsSpanInfo(string SegmentId, string? Cursor = null, string? EdgePath = null, string? EnforcementPointPath = null, bool? IncludeMarkForDeleteObjects = null, string? IncludedFields = null, long? PageSize = null, bool? SortAscending = null, string? SortBy = null)
        {
            if (SegmentId == null) { throw new System.ArgumentNullException("SegmentId cannot be null"); }
            StringBuilder GlobalInfraGetInfraSegmentCsSpanInfoServiceURL = new StringBuilder("/global-infra/segments/{segment-id}/inter-site-forwarder/site-span-info");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Get
            };
            GlobalInfraGetInfraSegmentCsSpanInfoServiceURL.Replace("{segment-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(SegmentId, System.Globalization.CultureInfo.InvariantCulture)));
            if (Cursor != null) { request.AddQueryParameter("cursor", Cursor.ToString()); }
            if (EdgePath != null) { request.AddQueryParameter("edge_path", EdgePath.ToString()); }
            if (EnforcementPointPath != null) { request.AddQueryParameter("enforcement_point_path", EnforcementPointPath.ToString()); }
            if (IncludeMarkForDeleteObjects != null) { request.AddQueryParameter("include_mark_for_delete_objects", IncludeMarkForDeleteObjects.ToString()); }
            if (IncludedFields != null) { request.AddQueryParameter("included_fields", IncludedFields.ToString()); }
            if (PageSize != null) { request.AddQueryParameter("page_size", PageSize.ToString()); }
            if (SortAscending != null) { request.AddQueryParameter("sort_ascending", SortAscending.ToString()); }
            if (SortBy != null) { request.AddQueryParameter("sort_by", SortBy.ToString()); }
            request.Resource = GlobalInfraGetInfraSegmentCsSpanInfoServiceURL.ToString();
            RestResponse<NSXTSegmentL2ForwarderSiteSpanInfoType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTSegmentL2ForwarderSiteSpanInfoType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Get operation to " + GlobalInfraGetInfraSegmentCsSpanInfoServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTMacAddressCsvListResultType> GetInfraSegmentMacTableInCsv(string SegmentId, string? EnforcementPointPath = null, string? Source = null, string? TransportNodeId = null)
        {
            if (SegmentId == null) { throw new System.ArgumentNullException("SegmentId cannot be null"); }
            StringBuilder GetInfraSegmentMacTableInCsvServiceURL = new StringBuilder("/infra/segments/{segment-id}/mac-table?format=csv");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Get
            };
            GetInfraSegmentMacTableInCsvServiceURL.Replace("{segment-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(SegmentId, System.Globalization.CultureInfo.InvariantCulture)));
            if (EnforcementPointPath != null) { request.AddQueryParameter("enforcement_point_path", EnforcementPointPath.ToString()); }
            if (Source != null) { request.AddQueryParameter("source", Source.ToString()); }
            if (TransportNodeId != null) { request.AddQueryParameter("transport_node_id", TransportNodeId.ToString()); }
            request.Resource = GetInfraSegmentMacTableInCsvServiceURL.ToString();
            RestResponse<NSXTMacAddressCsvListResultType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTMacAddressCsvListResultType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Get operation to " + GetInfraSegmentMacTableInCsvServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTInterfaceArpTableType> GlobalGlobalInfraGetDownlinkPortArpTableForInfraSegment(string SegmentId, string? Cursor = null, string? EdgePath = null, string? EnforcementPointPath = null, string? HostTransportNodePath = null, string? IncludedFields = null, long? PageSize = null, bool? SortAscending = null, string? SortBy = null)
        {
            if (SegmentId == null) { throw new System.ArgumentNullException("SegmentId cannot be null"); }
            StringBuilder GlobalInfraGetDownlinkPortArpTableForInfraSegmentServiceURL = new StringBuilder("/global-infra/segments/{segment-id}/gateway-interface-arp-table");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Get
            };
            GlobalInfraGetDownlinkPortArpTableForInfraSegmentServiceURL.Replace("{segment-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(SegmentId, System.Globalization.CultureInfo.InvariantCulture)));
            if (Cursor != null) { request.AddQueryParameter("cursor", Cursor.ToString()); }
            if (EdgePath != null) { request.AddQueryParameter("edge_path", EdgePath.ToString()); }
            if (EnforcementPointPath != null) { request.AddQueryParameter("enforcement_point_path", EnforcementPointPath.ToString()); }
            if (HostTransportNodePath != null) { request.AddQueryParameter("host_transport_node_path", HostTransportNodePath.ToString()); }
            if (IncludedFields != null) { request.AddQueryParameter("included_fields", IncludedFields.ToString()); }
            if (PageSize != null) { request.AddQueryParameter("page_size", PageSize.ToString()); }
            if (SortAscending != null) { request.AddQueryParameter("sort_ascending", SortAscending.ToString()); }
            if (SortBy != null) { request.AddQueryParameter("sort_by", SortBy.ToString()); }
            request.Resource = GlobalInfraGetDownlinkPortArpTableForInfraSegmentServiceURL.ToString();
            RestResponse<NSXTInterfaceArpTableType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTInterfaceArpTableType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Get operation to " + GlobalInfraGetDownlinkPortArpTableForInfraSegmentServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTSegmentPortStatusType> GlobalGlobalInfraGetInfraSegmentPortStatus(string SegmentsId, string PortId, string? Cursor = null, string? EdgePath = null, string? EnforcementPointPath = null, bool? IncludeMarkForDeleteObjects = null, string? IncludedFields = null, long? PageSize = null, bool? SortAscending = null, string? SortBy = null)
        {
            if (SegmentsId == null) { throw new System.ArgumentNullException("SegmentsId cannot be null"); }
            if (PortId == null) { throw new System.ArgumentNullException("PortId cannot be null"); }
            StringBuilder GlobalInfraGetInfraSegmentPortStatusServiceURL = new StringBuilder("/global-infra/segments/{segments-id}/ports/{port-id}/status");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Get
            };
            GlobalInfraGetInfraSegmentPortStatusServiceURL.Replace("{segments-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(SegmentsId, System.Globalization.CultureInfo.InvariantCulture)));
            GlobalInfraGetInfraSegmentPortStatusServiceURL.Replace("{port-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(PortId, System.Globalization.CultureInfo.InvariantCulture)));
            if (Cursor != null) { request.AddQueryParameter("cursor", Cursor.ToString()); }
            if (EdgePath != null) { request.AddQueryParameter("edge_path", EdgePath.ToString()); }
            if (EnforcementPointPath != null) { request.AddQueryParameter("enforcement_point_path", EnforcementPointPath.ToString()); }
            if (IncludeMarkForDeleteObjects != null) { request.AddQueryParameter("include_mark_for_delete_objects", IncludeMarkForDeleteObjects.ToString()); }
            if (IncludedFields != null) { request.AddQueryParameter("included_fields", IncludedFields.ToString()); }
            if (PageSize != null) { request.AddQueryParameter("page_size", PageSize.ToString()); }
            if (SortAscending != null) { request.AddQueryParameter("sort_ascending", SortAscending.ToString()); }
            if (SortBy != null) { request.AddQueryParameter("sort_by", SortBy.ToString()); }
            request.Resource = GlobalInfraGetInfraSegmentPortStatusServiceURL.ToString();
            RestResponse<NSXTSegmentPortStatusType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTSegmentPortStatusType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Get operation to " + GlobalInfraGetInfraSegmentPortStatusServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTInterfaceArpTableInCsvFormatType> GlobalGlobalInfraGetTier1InterfaceArpTableCsv(string Tier1Id, string LocaleServiceId, string InterfaceId, string? Cursor = null, string? EdgePath = null, string? EnforcementPointPath = null, string? HostTransportNodePath = null, string? IncludedFields = null, long? PageSize = null, bool? SortAscending = null, string? SortBy = null)
        {
            if (Tier1Id == null) { throw new System.ArgumentNullException("Tier1Id cannot be null"); }
            if (LocaleServiceId == null) { throw new System.ArgumentNullException("LocaleServiceId cannot be null"); }
            if (InterfaceId == null) { throw new System.ArgumentNullException("InterfaceId cannot be null"); }
            StringBuilder GlobalInfraGetTier1InterfaceArpTableCsvServiceURL = new StringBuilder("/global-infra/tier-1s/{tier-1-id}/locale-services/{locale-service-id}/interfaces/{interface-id}/arp-table?format=csv");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Get
            };
            GlobalInfraGetTier1InterfaceArpTableCsvServiceURL.Replace("{tier-1-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(Tier1Id, System.Globalization.CultureInfo.InvariantCulture)));
            GlobalInfraGetTier1InterfaceArpTableCsvServiceURL.Replace("{locale-service-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(LocaleServiceId, System.Globalization.CultureInfo.InvariantCulture)));
            GlobalInfraGetTier1InterfaceArpTableCsvServiceURL.Replace("{interface-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(InterfaceId, System.Globalization.CultureInfo.InvariantCulture)));
            if (Cursor != null) { request.AddQueryParameter("cursor", Cursor.ToString()); }
            if (EdgePath != null) { request.AddQueryParameter("edge_path", EdgePath.ToString()); }
            if (EnforcementPointPath != null) { request.AddQueryParameter("enforcement_point_path", EnforcementPointPath.ToString()); }
            if (HostTransportNodePath != null) { request.AddQueryParameter("host_transport_node_path", HostTransportNodePath.ToString()); }
            if (IncludedFields != null) { request.AddQueryParameter("included_fields", IncludedFields.ToString()); }
            if (PageSize != null) { request.AddQueryParameter("page_size", PageSize.ToString()); }
            if (SortAscending != null) { request.AddQueryParameter("sort_ascending", SortAscending.ToString()); }
            if (SortBy != null) { request.AddQueryParameter("sort_by", SortBy.ToString()); }
            request.Resource = GlobalInfraGetTier1InterfaceArpTableCsvServiceURL.ToString();
            RestResponse<NSXTInterfaceArpTableInCsvFormatType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTInterfaceArpTableInCsvFormatType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Get operation to " + GlobalInfraGetTier1InterfaceArpTableCsvServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTInterfaceArpTableType> GlobalGlobalInfraGetTier1InterfaceArpTable(string Tier1Id, string LocaleServiceId, string InterfaceId, string? Cursor = null, string? EdgePath = null, string? EnforcementPointPath = null, string? HostTransportNodePath = null, string? IncludedFields = null, long? PageSize = null, bool? SortAscending = null, string? SortBy = null)
        {
            if (Tier1Id == null) { throw new System.ArgumentNullException("Tier1Id cannot be null"); }
            if (LocaleServiceId == null) { throw new System.ArgumentNullException("LocaleServiceId cannot be null"); }
            if (InterfaceId == null) { throw new System.ArgumentNullException("InterfaceId cannot be null"); }
            StringBuilder GlobalInfraGetTier1InterfaceArpTableServiceURL = new StringBuilder("/global-infra/tier-1s/{tier-1-id}/locale-services/{locale-service-id}/interfaces/{interface-id}/arp-table");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Get
            };
            GlobalInfraGetTier1InterfaceArpTableServiceURL.Replace("{tier-1-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(Tier1Id, System.Globalization.CultureInfo.InvariantCulture)));
            GlobalInfraGetTier1InterfaceArpTableServiceURL.Replace("{locale-service-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(LocaleServiceId, System.Globalization.CultureInfo.InvariantCulture)));
            GlobalInfraGetTier1InterfaceArpTableServiceURL.Replace("{interface-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(InterfaceId, System.Globalization.CultureInfo.InvariantCulture)));
            if (Cursor != null) { request.AddQueryParameter("cursor", Cursor.ToString()); }
            if (EdgePath != null) { request.AddQueryParameter("edge_path", EdgePath.ToString()); }
            if (EnforcementPointPath != null) { request.AddQueryParameter("enforcement_point_path", EnforcementPointPath.ToString()); }
            if (HostTransportNodePath != null) { request.AddQueryParameter("host_transport_node_path", HostTransportNodePath.ToString()); }
            if (IncludedFields != null) { request.AddQueryParameter("included_fields", IncludedFields.ToString()); }
            if (PageSize != null) { request.AddQueryParameter("page_size", PageSize.ToString()); }
            if (SortAscending != null) { request.AddQueryParameter("sort_ascending", SortAscending.ToString()); }
            if (SortBy != null) { request.AddQueryParameter("sort_by", SortBy.ToString()); }
            request.Resource = GlobalInfraGetTier1InterfaceArpTableServiceURL.ToString();
            RestResponse<NSXTInterfaceArpTableType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTInterfaceArpTableType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Get operation to " + GlobalInfraGetTier1InterfaceArpTableServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTSegmentPortMacAddressListResultType> GlobalGlobalInfraGetInfraSegmentPortMacTable(string SegmentId, string PortId, string? Cursor = null, string? EnforcementPointPath = null, string? IncludedFields = null, long? PageSize = null, bool? SortAscending = null, string? SortBy = null, string? Source = null, string? TransportNodeId = null)
        {
            if (SegmentId == null) { throw new System.ArgumentNullException("SegmentId cannot be null"); }
            if (PortId == null) { throw new System.ArgumentNullException("PortId cannot be null"); }
            StringBuilder GlobalInfraGetInfraSegmentPortMacTableServiceURL = new StringBuilder("/global-infra/segments/{segment-id}/ports/{port-id}/mac-table");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Get
            };
            GlobalInfraGetInfraSegmentPortMacTableServiceURL.Replace("{segment-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(SegmentId, System.Globalization.CultureInfo.InvariantCulture)));
            GlobalInfraGetInfraSegmentPortMacTableServiceURL.Replace("{port-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(PortId, System.Globalization.CultureInfo.InvariantCulture)));
            if (Cursor != null) { request.AddQueryParameter("cursor", Cursor.ToString()); }
            if (EnforcementPointPath != null) { request.AddQueryParameter("enforcement_point_path", EnforcementPointPath.ToString()); }
            if (IncludedFields != null) { request.AddQueryParameter("included_fields", IncludedFields.ToString()); }
            if (PageSize != null) { request.AddQueryParameter("page_size", PageSize.ToString()); }
            if (SortAscending != null) { request.AddQueryParameter("sort_ascending", SortAscending.ToString()); }
            if (SortBy != null) { request.AddQueryParameter("sort_by", SortBy.ToString()); }
            if (Source != null) { request.AddQueryParameter("source", Source.ToString()); }
            if (TransportNodeId != null) { request.AddQueryParameter("transport_node_id", TransportNodeId.ToString()); }
            request.Resource = GlobalInfraGetInfraSegmentPortMacTableServiceURL.ToString();
            RestResponse<NSXTSegmentPortMacAddressListResultType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTSegmentPortMacAddressListResultType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Get operation to " + GlobalInfraGetInfraSegmentPortMacTableServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTBridgeEndpointStatusType> GlobalGlobalInfraTier1SegmentBridgeEndpointStatus(string Tier1Id, string SegmentId, string BridgeProfilePath, string? EnforcementPointPath = null)
        {
            if (Tier1Id == null) { throw new System.ArgumentNullException("Tier1Id cannot be null"); }
            if (SegmentId == null) { throw new System.ArgumentNullException("SegmentId cannot be null"); }
            if (BridgeProfilePath == null) { throw new System.ArgumentNullException("BridgeProfilePath cannot be null"); }
            StringBuilder GlobalInfraTier1SegmentBridgeEndpointStatusServiceURL = new StringBuilder("/global-infra/tier-1s/{tier-1-id}/segments/{segment-id}/bep-status");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Get
            };
            GlobalInfraTier1SegmentBridgeEndpointStatusServiceURL.Replace("{tier-1-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(Tier1Id, System.Globalization.CultureInfo.InvariantCulture)));
            GlobalInfraTier1SegmentBridgeEndpointStatusServiceURL.Replace("{segment-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(SegmentId, System.Globalization.CultureInfo.InvariantCulture)));
            if (BridgeProfilePath != null) { request.AddQueryParameter("bridge_profile_path", BridgeProfilePath.ToString()); }
            if (EnforcementPointPath != null) { request.AddQueryParameter("enforcement_point_path", EnforcementPointPath.ToString()); }
            request.Resource = GlobalInfraTier1SegmentBridgeEndpointStatusServiceURL.ToString();
            RestResponse<NSXTBridgeEndpointStatusType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTBridgeEndpointStatusType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Get operation to " + GlobalInfraTier1SegmentBridgeEndpointStatusServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTPolicyInterfaceStatisticsType> GetDownlinkPortStatisticsForTier1Segment(string Tier1Id, string SegmentId, string? Cursor = null, string? EdgePath = null, string? EnforcementPointPath = null, string? HostTransportNodePath = null, string? IncludedFields = null, long? PageSize = null, bool? SortAscending = null, string? SortBy = null)
        {
            if (Tier1Id == null) { throw new System.ArgumentNullException("Tier1Id cannot be null"); }
            if (SegmentId == null) { throw new System.ArgumentNullException("SegmentId cannot be null"); }
            StringBuilder GetDownlinkPortStatisticsForTier1SegmentServiceURL = new StringBuilder("/infra/tier-1s/{tier-1-id}/segments/{segment-id}/gateway-interface-statistics");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Get
            };
            GetDownlinkPortStatisticsForTier1SegmentServiceURL.Replace("{tier-1-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(Tier1Id, System.Globalization.CultureInfo.InvariantCulture)));
            GetDownlinkPortStatisticsForTier1SegmentServiceURL.Replace("{segment-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(SegmentId, System.Globalization.CultureInfo.InvariantCulture)));
            if (Cursor != null) { request.AddQueryParameter("cursor", Cursor.ToString()); }
            if (EdgePath != null) { request.AddQueryParameter("edge_path", EdgePath.ToString()); }
            if (EnforcementPointPath != null) { request.AddQueryParameter("enforcement_point_path", EnforcementPointPath.ToString()); }
            if (HostTransportNodePath != null) { request.AddQueryParameter("host_transport_node_path", HostTransportNodePath.ToString()); }
            if (IncludedFields != null) { request.AddQueryParameter("included_fields", IncludedFields.ToString()); }
            if (PageSize != null) { request.AddQueryParameter("page_size", PageSize.ToString()); }
            if (SortAscending != null) { request.AddQueryParameter("sort_ascending", SortAscending.ToString()); }
            if (SortBy != null) { request.AddQueryParameter("sort_by", SortBy.ToString()); }
            request.Resource = GetDownlinkPortStatisticsForTier1SegmentServiceURL.ToString();
            RestResponse<NSXTPolicyInterfaceStatisticsType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTPolicyInterfaceStatisticsType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Get operation to " + GetDownlinkPortStatisticsForTier1SegmentServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTGatewayRouteTableInCsvFormatType> GlobalGlobalInfraGetTier1ForwardingTableCsv(string Tier1Id, string? Cursor = null, string? EdgeId = null, string? EdgePath = null, string? EnforcementPointPath = null, string? IncludedFields = null, string? NetworkPrefix = null, long? PageSize = null, string? RouteSource = null, bool? SortAscending = null, string? SortBy = null)
        {
            if (Tier1Id == null) { throw new System.ArgumentNullException("Tier1Id cannot be null"); }
            StringBuilder GlobalInfraGetTier1ForwardingTableCsvServiceURL = new StringBuilder("/global-infra/tier-1s/{tier-1-id}/forwarding-table?format=csv");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Get
            };
            GlobalInfraGetTier1ForwardingTableCsvServiceURL.Replace("{tier-1-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(Tier1Id, System.Globalization.CultureInfo.InvariantCulture)));
            if (Cursor != null) { request.AddQueryParameter("cursor", Cursor.ToString()); }
            if (EdgeId != null) { request.AddQueryParameter("edge_id", EdgeId.ToString()); }
            if (EdgePath != null) { request.AddQueryParameter("edge_path", EdgePath.ToString()); }
            if (EnforcementPointPath != null) { request.AddQueryParameter("enforcement_point_path", EnforcementPointPath.ToString()); }
            if (IncludedFields != null) { request.AddQueryParameter("included_fields", IncludedFields.ToString()); }
            if (NetworkPrefix != null) { request.AddQueryParameter("network_prefix", NetworkPrefix.ToString()); }
            if (PageSize != null) { request.AddQueryParameter("page_size", PageSize.ToString()); }
            if (RouteSource != null) { request.AddQueryParameter("route_source", RouteSource.ToString()); }
            if (SortAscending != null) { request.AddQueryParameter("sort_ascending", SortAscending.ToString()); }
            if (SortBy != null) { request.AddQueryParameter("sort_by", SortBy.ToString()); }
            request.Resource = GlobalInfraGetTier1ForwardingTableCsvServiceURL.ToString();
            RestResponse<NSXTGatewayRouteTableInCsvFormatType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTGatewayRouteTableInCsvFormatType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Get operation to " + GlobalInfraGetTier1ForwardingTableCsvServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTOspfRoutesListResultInCsvFormatType> GetOspfRoutesInCsvFormat(string Tier0Id, string LocaleServiceId, string? Cursor = null, string? EdgePath = null, string? EnforcementPointPath = null, string? IncludedFields = null, string? NetworkPrefix = null, long? PageSize = null, bool? SortAscending = null, string? SortBy = null)
        {
            if (Tier0Id == null) { throw new System.ArgumentNullException("Tier0Id cannot be null"); }
            if (LocaleServiceId == null) { throw new System.ArgumentNullException("LocaleServiceId cannot be null"); }
            StringBuilder GetOspfRoutesInCsvFormatServiceURL = new StringBuilder("/infra/tier-0s/{tier-0-id}/locale-services/{locale-service-id}/ospf/routes?format=csv");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Get
            };
            GetOspfRoutesInCsvFormatServiceURL.Replace("{tier-0-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(Tier0Id, System.Globalization.CultureInfo.InvariantCulture)));
            GetOspfRoutesInCsvFormatServiceURL.Replace("{locale-service-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(LocaleServiceId, System.Globalization.CultureInfo.InvariantCulture)));
            if (Cursor != null) { request.AddQueryParameter("cursor", Cursor.ToString()); }
            if (EdgePath != null) { request.AddQueryParameter("edge_path", EdgePath.ToString()); }
            if (EnforcementPointPath != null) { request.AddQueryParameter("enforcement_point_path", EnforcementPointPath.ToString()); }
            if (IncludedFields != null) { request.AddQueryParameter("included_fields", IncludedFields.ToString()); }
            if (NetworkPrefix != null) { request.AddQueryParameter("network_prefix", NetworkPrefix.ToString()); }
            if (PageSize != null) { request.AddQueryParameter("page_size", PageSize.ToString()); }
            if (SortAscending != null) { request.AddQueryParameter("sort_ascending", SortAscending.ToString()); }
            if (SortBy != null) { request.AddQueryParameter("sort_by", SortBy.ToString()); }
            request.Resource = GetOspfRoutesInCsvFormatServiceURL.ToString();
            RestResponse<NSXTOspfRoutesListResultInCsvFormatType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTOspfRoutesListResultInCsvFormatType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Get operation to " + GetOspfRoutesInCsvFormatServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTMacAddressCsvListResultType> GlobalGlobalInfraGetTier1SegmentMacTableInCsv(string Tier1Id, string SegmentId, string? EnforcementPointPath = null, string? Source = null, string? TransportNodeId = null)
        {
            if (Tier1Id == null) { throw new System.ArgumentNullException("Tier1Id cannot be null"); }
            if (SegmentId == null) { throw new System.ArgumentNullException("SegmentId cannot be null"); }
            StringBuilder GlobalInfraGetTier1SegmentMacTableInCsvServiceURL = new StringBuilder("/global-infra/tier-1s/{tier-1-id}/segments/{segment-id}/mac-table?format=csv");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Get
            };
            GlobalInfraGetTier1SegmentMacTableInCsvServiceURL.Replace("{tier-1-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(Tier1Id, System.Globalization.CultureInfo.InvariantCulture)));
            GlobalInfraGetTier1SegmentMacTableInCsvServiceURL.Replace("{segment-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(SegmentId, System.Globalization.CultureInfo.InvariantCulture)));
            if (EnforcementPointPath != null) { request.AddQueryParameter("enforcement_point_path", EnforcementPointPath.ToString()); }
            if (Source != null) { request.AddQueryParameter("source", Source.ToString()); }
            if (TransportNodeId != null) { request.AddQueryParameter("transport_node_id", TransportNodeId.ToString()); }
            request.Resource = GlobalInfraGetTier1SegmentMacTableInCsvServiceURL.ToString();
            RestResponse<NSXTMacAddressCsvListResultType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTMacAddressCsvListResultType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Get operation to " + GlobalInfraGetTier1SegmentMacTableInCsvServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTPolicyMulticastRoutesType> GetPolicyMulticastRoutes(string Tier0Id, string LocaleServicesId, string? Cursor = null, string? EdgePath = null, string? IncludedFields = null, long? PageSize = null, bool? SortAscending = null, string? SortBy = null)
        {
            if (Tier0Id == null) { throw new System.ArgumentNullException("Tier0Id cannot be null"); }
            if (LocaleServicesId == null) { throw new System.ArgumentNullException("LocaleServicesId cannot be null"); }
            StringBuilder GetPolicyMulticastRoutesServiceURL = new StringBuilder("/infra/tier-0s/{tier-0-id}/locale-services/{locale-services-id}/multicast/routes");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Get
            };
            GetPolicyMulticastRoutesServiceURL.Replace("{tier-0-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(Tier0Id, System.Globalization.CultureInfo.InvariantCulture)));
            GetPolicyMulticastRoutesServiceURL.Replace("{locale-services-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(LocaleServicesId, System.Globalization.CultureInfo.InvariantCulture)));
            if (Cursor != null) { request.AddQueryParameter("cursor", Cursor.ToString()); }
            if (EdgePath != null) { request.AddQueryParameter("edge_path", EdgePath.ToString()); }
            if (IncludedFields != null) { request.AddQueryParameter("included_fields", IncludedFields.ToString()); }
            if (PageSize != null) { request.AddQueryParameter("page_size", PageSize.ToString()); }
            if (SortAscending != null) { request.AddQueryParameter("sort_ascending", SortAscending.ToString()); }
            if (SortBy != null) { request.AddQueryParameter("sort_by", SortBy.ToString()); }
            request.Resource = GetPolicyMulticastRoutesServiceURL.ToString();
            RestResponse<NSXTPolicyMulticastRoutesType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTPolicyMulticastRoutesType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Get operation to " + GetPolicyMulticastRoutesServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTGatewayRouteTableInCsvFormatType> GetTier0ForwardingTableCsv(string Tier0Id, string? Cursor = null, string? EdgeId = null, string? EdgePath = null, string? EnforcementPointPath = null, string? IncludedFields = null, string? NetworkPrefix = null, long? PageSize = null, string? RouteSource = null, bool? SortAscending = null, string? SortBy = null)
        {
            if (Tier0Id == null) { throw new System.ArgumentNullException("Tier0Id cannot be null"); }
            StringBuilder GetTier0ForwardingTableCsvServiceURL = new StringBuilder("/infra/tier-0s/{tier-0-id}/forwarding-table?format=csv");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Get
            };
            GetTier0ForwardingTableCsvServiceURL.Replace("{tier-0-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(Tier0Id, System.Globalization.CultureInfo.InvariantCulture)));
            if (Cursor != null) { request.AddQueryParameter("cursor", Cursor.ToString()); }
            if (EdgeId != null) { request.AddQueryParameter("edge_id", EdgeId.ToString()); }
            if (EdgePath != null) { request.AddQueryParameter("edge_path", EdgePath.ToString()); }
            if (EnforcementPointPath != null) { request.AddQueryParameter("enforcement_point_path", EnforcementPointPath.ToString()); }
            if (IncludedFields != null) { request.AddQueryParameter("included_fields", IncludedFields.ToString()); }
            if (NetworkPrefix != null) { request.AddQueryParameter("network_prefix", NetworkPrefix.ToString()); }
            if (PageSize != null) { request.AddQueryParameter("page_size", PageSize.ToString()); }
            if (RouteSource != null) { request.AddQueryParameter("route_source", RouteSource.ToString()); }
            if (SortAscending != null) { request.AddQueryParameter("sort_ascending", SortAscending.ToString()); }
            if (SortBy != null) { request.AddQueryParameter("sort_by", SortBy.ToString()); }
            request.Resource = GetTier0ForwardingTableCsvServiceURL.ToString();
            RestResponse<NSXTGatewayRouteTableInCsvFormatType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTGatewayRouteTableInCsvFormatType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Get operation to " + GetTier0ForwardingTableCsvServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTInterfaceDADStateType> GetDownlinkPortDadStateForInfraSegment(string SegmentId, string? EnforcementPointPath = null, string? Source = null)
        {
            if (SegmentId == null) { throw new System.ArgumentNullException("SegmentId cannot be null"); }
            StringBuilder GetDownlinkPortDadStateForInfraSegmentServiceURL = new StringBuilder("/infra/segments/{segment-id}/gateway-interface-dad-state");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Get
            };
            GetDownlinkPortDadStateForInfraSegmentServiceURL.Replace("{segment-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(SegmentId, System.Globalization.CultureInfo.InvariantCulture)));
            if (EnforcementPointPath != null) { request.AddQueryParameter("enforcement_point_path", EnforcementPointPath.ToString()); }
            if (Source != null) { request.AddQueryParameter("source", Source.ToString()); }
            request.Resource = GetDownlinkPortDadStateForInfraSegmentServiceURL.ToString();
            RestResponse<NSXTInterfaceDADStateType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTInterfaceDADStateType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Get operation to " + GetDownlinkPortDadStateForInfraSegmentServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTInterfaceArpTableType> GetDownlinkPortArpTableForInfraSegment(string SegmentId, string? Cursor = null, string? EdgePath = null, string? EnforcementPointPath = null, string? HostTransportNodePath = null, string? IncludedFields = null, long? PageSize = null, bool? SortAscending = null, string? SortBy = null)
        {
            if (SegmentId == null) { throw new System.ArgumentNullException("SegmentId cannot be null"); }
            StringBuilder GetDownlinkPortArpTableForInfraSegmentServiceURL = new StringBuilder("/infra/segments/{segment-id}/gateway-interface-arp-table");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Get
            };
            GetDownlinkPortArpTableForInfraSegmentServiceURL.Replace("{segment-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(SegmentId, System.Globalization.CultureInfo.InvariantCulture)));
            if (Cursor != null) { request.AddQueryParameter("cursor", Cursor.ToString()); }
            if (EdgePath != null) { request.AddQueryParameter("edge_path", EdgePath.ToString()); }
            if (EnforcementPointPath != null) { request.AddQueryParameter("enforcement_point_path", EnforcementPointPath.ToString()); }
            if (HostTransportNodePath != null) { request.AddQueryParameter("host_transport_node_path", HostTransportNodePath.ToString()); }
            if (IncludedFields != null) { request.AddQueryParameter("included_fields", IncludedFields.ToString()); }
            if (PageSize != null) { request.AddQueryParameter("page_size", PageSize.ToString()); }
            if (SortAscending != null) { request.AddQueryParameter("sort_ascending", SortAscending.ToString()); }
            if (SortBy != null) { request.AddQueryParameter("sort_by", SortBy.ToString()); }
            request.Resource = GetDownlinkPortArpTableForInfraSegmentServiceURL.ToString();
            RestResponse<NSXTInterfaceArpTableType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTInterfaceArpTableType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Get operation to " + GetDownlinkPortArpTableForInfraSegmentServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTInterfaceDADStateType> GlobalGlobalInfraGetTier1InterfaceDadstate(string Tier1Id, string LocaleServiceId, string InterfaceId, string? EnforcementPointPath = null)
        {
            if (Tier1Id == null) { throw new System.ArgumentNullException("Tier1Id cannot be null"); }
            if (LocaleServiceId == null) { throw new System.ArgumentNullException("LocaleServiceId cannot be null"); }
            if (InterfaceId == null) { throw new System.ArgumentNullException("InterfaceId cannot be null"); }
            StringBuilder GlobalInfraGetTier1InterfaceDadstateServiceURL = new StringBuilder("/global-infra/tier-1s/{tier-1-id}/locale-services/{locale-service-id}/interfaces/{interface-id}/dad-state");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Get
            };
            GlobalInfraGetTier1InterfaceDadstateServiceURL.Replace("{tier-1-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(Tier1Id, System.Globalization.CultureInfo.InvariantCulture)));
            GlobalInfraGetTier1InterfaceDadstateServiceURL.Replace("{locale-service-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(LocaleServiceId, System.Globalization.CultureInfo.InvariantCulture)));
            GlobalInfraGetTier1InterfaceDadstateServiceURL.Replace("{interface-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(InterfaceId, System.Globalization.CultureInfo.InvariantCulture)));
            if (EnforcementPointPath != null) { request.AddQueryParameter("enforcement_point_path", EnforcementPointPath.ToString()); }
            request.Resource = GlobalInfraGetTier1InterfaceDadstateServiceURL.ToString();
            RestResponse<NSXTInterfaceDADStateType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTInterfaceDADStateType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Get operation to " + GlobalInfraGetTier1InterfaceDadstateServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTRoutingTableListResultType> GlobalGlobalInfraGetTier0Routes(string Tier0Id, string? Cursor = null, string? EdgeId = null, string? EdgePath = null, string? EnforcementPointPath = null, string? IncludedFields = null, string? NetworkPrefix = null, long? PageSize = null, string? RouteSource = null, bool? SortAscending = null, string? SortBy = null)
        {
            if (Tier0Id == null) { throw new System.ArgumentNullException("Tier0Id cannot be null"); }
            StringBuilder GlobalInfraGetTier0RoutesServiceURL = new StringBuilder("/global-infra/tier-0s/{tier-0-id}/routing-table");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Get
            };
            GlobalInfraGetTier0RoutesServiceURL.Replace("{tier-0-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(Tier0Id, System.Globalization.CultureInfo.InvariantCulture)));
            if (Cursor != null) { request.AddQueryParameter("cursor", Cursor.ToString()); }
            if (EdgeId != null) { request.AddQueryParameter("edge_id", EdgeId.ToString()); }
            if (EdgePath != null) { request.AddQueryParameter("edge_path", EdgePath.ToString()); }
            if (EnforcementPointPath != null) { request.AddQueryParameter("enforcement_point_path", EnforcementPointPath.ToString()); }
            if (IncludedFields != null) { request.AddQueryParameter("included_fields", IncludedFields.ToString()); }
            if (NetworkPrefix != null) { request.AddQueryParameter("network_prefix", NetworkPrefix.ToString()); }
            if (PageSize != null) { request.AddQueryParameter("page_size", PageSize.ToString()); }
            if (RouteSource != null) { request.AddQueryParameter("route_source", RouteSource.ToString()); }
            if (SortAscending != null) { request.AddQueryParameter("sort_ascending", SortAscending.ToString()); }
            if (SortBy != null) { request.AddQueryParameter("sort_by", SortBy.ToString()); }
            request.Resource = GlobalInfraGetTier0RoutesServiceURL.ToString();
            RestResponse<NSXTRoutingTableListResultType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTRoutingTableListResultType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Get operation to " + GlobalInfraGetTier0RoutesServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTDhcpServerStatusType> GlobalGlobalInfraReadDhcpServerStatus(string ConfigId, string ConnectivityPath, string? Cursor = null, string? EnforcementPointPath = null, bool? IncludeMarkForDeleteObjects = null, string? IncludedFields = null, long? PageSize = null, bool? SortAscending = null, string? SortBy = null)
        {
            if (ConfigId == null) { throw new System.ArgumentNullException("ConfigId cannot be null"); }
            if (ConnectivityPath == null) { throw new System.ArgumentNullException("ConnectivityPath cannot be null"); }
            StringBuilder GlobalInfraReadDhcpServerStatusServiceURL = new StringBuilder("/global-infra/dhcp-server-configs/{config-id}/status");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Get
            };
            GlobalInfraReadDhcpServerStatusServiceURL.Replace("{config-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(ConfigId, System.Globalization.CultureInfo.InvariantCulture)));
            if (ConnectivityPath != null) { request.AddQueryParameter("connectivity_path", ConnectivityPath.ToString()); }
            if (Cursor != null) { request.AddQueryParameter("cursor", Cursor.ToString()); }
            if (EnforcementPointPath != null) { request.AddQueryParameter("enforcement_point_path", EnforcementPointPath.ToString()); }
            if (IncludeMarkForDeleteObjects != null) { request.AddQueryParameter("include_mark_for_delete_objects", IncludeMarkForDeleteObjects.ToString()); }
            if (IncludedFields != null) { request.AddQueryParameter("included_fields", IncludedFields.ToString()); }
            if (PageSize != null) { request.AddQueryParameter("page_size", PageSize.ToString()); }
            if (SortAscending != null) { request.AddQueryParameter("sort_ascending", SortAscending.ToString()); }
            if (SortBy != null) { request.AddQueryParameter("sort_by", SortBy.ToString()); }
            request.Resource = GlobalInfraReadDhcpServerStatusServiceURL.ToString();
            RestResponse<NSXTDhcpServerStatusType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTDhcpServerStatusType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Get operation to " + GlobalInfraReadDhcpServerStatusServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTInterfaceArpTableType> GetInfraSegmentInterfaceArpTable(string SegmentId, string? Cursor = null, string? EdgePath = null, string? EnforcementPointPath = null, string? HostTransportNodePath = null, string? IncludedFields = null, long? PageSize = null, bool? SortAscending = null, string? SortBy = null)
        {
            if (SegmentId == null) { throw new System.ArgumentNullException("SegmentId cannot be null"); }
            StringBuilder GetInfraSegmentInterfaceArpTableServiceURL = new StringBuilder("/infra/segments/{segment-id}/arp-table");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Get
            };
            GetInfraSegmentInterfaceArpTableServiceURL.Replace("{segment-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(SegmentId, System.Globalization.CultureInfo.InvariantCulture)));
            if (Cursor != null) { request.AddQueryParameter("cursor", Cursor.ToString()); }
            if (EdgePath != null) { request.AddQueryParameter("edge_path", EdgePath.ToString()); }
            if (EnforcementPointPath != null) { request.AddQueryParameter("enforcement_point_path", EnforcementPointPath.ToString()); }
            if (HostTransportNodePath != null) { request.AddQueryParameter("host_transport_node_path", HostTransportNodePath.ToString()); }
            if (IncludedFields != null) { request.AddQueryParameter("included_fields", IncludedFields.ToString()); }
            if (PageSize != null) { request.AddQueryParameter("page_size", PageSize.ToString()); }
            if (SortAscending != null) { request.AddQueryParameter("sort_ascending", SortAscending.ToString()); }
            if (SortBy != null) { request.AddQueryParameter("sort_by", SortBy.ToString()); }
            request.Resource = GetInfraSegmentInterfaceArpTableServiceURL.ToString();
            RestResponse<NSXTInterfaceArpTableType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTInterfaceArpTableType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Get operation to " + GetInfraSegmentInterfaceArpTableServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTSegmentPortStatusType> GlobalGlobalInfraGetSegmentPortStatus(string Tier1Id, string SegmentsId, string PortId, string? Cursor = null, string? EdgePath = null, string? EnforcementPointPath = null, bool? IncludeMarkForDeleteObjects = null, string? IncludedFields = null, long? PageSize = null, bool? SortAscending = null, string? SortBy = null)
        {
            if (Tier1Id == null) { throw new System.ArgumentNullException("Tier1Id cannot be null"); }
            if (SegmentsId == null) { throw new System.ArgumentNullException("SegmentsId cannot be null"); }
            if (PortId == null) { throw new System.ArgumentNullException("PortId cannot be null"); }
            StringBuilder GlobalInfraGetSegmentPortStatusServiceURL = new StringBuilder("/global-infra/tier-1s/{tier-1-id}/segments/{segments-id}/ports/{port-id}/status");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Get
            };
            GlobalInfraGetSegmentPortStatusServiceURL.Replace("{tier-1-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(Tier1Id, System.Globalization.CultureInfo.InvariantCulture)));
            GlobalInfraGetSegmentPortStatusServiceURL.Replace("{segments-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(SegmentsId, System.Globalization.CultureInfo.InvariantCulture)));
            GlobalInfraGetSegmentPortStatusServiceURL.Replace("{port-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(PortId, System.Globalization.CultureInfo.InvariantCulture)));
            if (Cursor != null) { request.AddQueryParameter("cursor", Cursor.ToString()); }
            if (EdgePath != null) { request.AddQueryParameter("edge_path", EdgePath.ToString()); }
            if (EnforcementPointPath != null) { request.AddQueryParameter("enforcement_point_path", EnforcementPointPath.ToString()); }
            if (IncludeMarkForDeleteObjects != null) { request.AddQueryParameter("include_mark_for_delete_objects", IncludeMarkForDeleteObjects.ToString()); }
            if (IncludedFields != null) { request.AddQueryParameter("included_fields", IncludedFields.ToString()); }
            if (PageSize != null) { request.AddQueryParameter("page_size", PageSize.ToString()); }
            if (SortAscending != null) { request.AddQueryParameter("sort_ascending", SortAscending.ToString()); }
            if (SortBy != null) { request.AddQueryParameter("sort_by", SortBy.ToString()); }
            request.Resource = GlobalInfraGetSegmentPortStatusServiceURL.ToString();
            RestResponse<NSXTSegmentPortStatusType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTSegmentPortStatusType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Get operation to " + GlobalInfraGetSegmentPortStatusServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTInterfaceDADStateType> GetTier1InterfaceDadstate(string Tier1Id, string LocaleServiceId, string InterfaceId, string? EnforcementPointPath = null)
        {
            if (Tier1Id == null) { throw new System.ArgumentNullException("Tier1Id cannot be null"); }
            if (LocaleServiceId == null) { throw new System.ArgumentNullException("LocaleServiceId cannot be null"); }
            if (InterfaceId == null) { throw new System.ArgumentNullException("InterfaceId cannot be null"); }
            StringBuilder GetTier1InterfaceDadstateServiceURL = new StringBuilder("/infra/tier-1s/{tier-1-id}/locale-services/{locale-service-id}/interfaces/{interface-id}/dad-state");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Get
            };
            GetTier1InterfaceDadstateServiceURL.Replace("{tier-1-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(Tier1Id, System.Globalization.CultureInfo.InvariantCulture)));
            GetTier1InterfaceDadstateServiceURL.Replace("{locale-service-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(LocaleServiceId, System.Globalization.CultureInfo.InvariantCulture)));
            GetTier1InterfaceDadstateServiceURL.Replace("{interface-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(InterfaceId, System.Globalization.CultureInfo.InvariantCulture)));
            if (EnforcementPointPath != null) { request.AddQueryParameter("enforcement_point_path", EnforcementPointPath.ToString()); }
            request.Resource = GetTier1InterfaceDadstateServiceURL.ToString();
            RestResponse<NSXTInterfaceDADStateType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTInterfaceDADStateType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Get operation to " + GetTier1InterfaceDadstateServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTGatewayRouteTableInCsvFormatType> GlobalGlobalInfraGetTier0RoutesCsv(string Tier0Id, string? Cursor = null, string? EdgeId = null, string? EdgePath = null, string? EnforcementPointPath = null, string? IncludedFields = null, string? NetworkPrefix = null, long? PageSize = null, string? RouteSource = null, bool? SortAscending = null, string? SortBy = null)
        {
            if (Tier0Id == null) { throw new System.ArgumentNullException("Tier0Id cannot be null"); }
            StringBuilder GlobalInfraGetTier0RoutesCsvServiceURL = new StringBuilder("/global-infra/tier-0s/{tier-0-id}/routing-table?format=csv");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Get
            };
            GlobalInfraGetTier0RoutesCsvServiceURL.Replace("{tier-0-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(Tier0Id, System.Globalization.CultureInfo.InvariantCulture)));
            if (Cursor != null) { request.AddQueryParameter("cursor", Cursor.ToString()); }
            if (EdgeId != null) { request.AddQueryParameter("edge_id", EdgeId.ToString()); }
            if (EdgePath != null) { request.AddQueryParameter("edge_path", EdgePath.ToString()); }
            if (EnforcementPointPath != null) { request.AddQueryParameter("enforcement_point_path", EnforcementPointPath.ToString()); }
            if (IncludedFields != null) { request.AddQueryParameter("included_fields", IncludedFields.ToString()); }
            if (NetworkPrefix != null) { request.AddQueryParameter("network_prefix", NetworkPrefix.ToString()); }
            if (PageSize != null) { request.AddQueryParameter("page_size", PageSize.ToString()); }
            if (RouteSource != null) { request.AddQueryParameter("route_source", RouteSource.ToString()); }
            if (SortAscending != null) { request.AddQueryParameter("sort_ascending", SortAscending.ToString()); }
            if (SortBy != null) { request.AddQueryParameter("sort_by", SortBy.ToString()); }
            request.Resource = GlobalInfraGetTier0RoutesCsvServiceURL.ToString();
            RestResponse<NSXTGatewayRouteTableInCsvFormatType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTGatewayRouteTableInCsvFormatType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Get operation to " + GlobalInfraGetTier0RoutesCsvServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTSegmentMacAddressListResultType> GlobalGlobalInfraGetInfraSegmentMacTable(string SegmentId, string? Cursor = null, string? EnforcementPointPath = null, string? IncludedFields = null, long? PageSize = null, bool? SortAscending = null, string? SortBy = null, string? Source = null, string? TransportNodeId = null)
        {
            if (SegmentId == null) { throw new System.ArgumentNullException("SegmentId cannot be null"); }
            StringBuilder GlobalInfraGetInfraSegmentMacTableServiceURL = new StringBuilder("/global-infra/segments/{segment-id}/mac-table");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Get
            };
            GlobalInfraGetInfraSegmentMacTableServiceURL.Replace("{segment-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(SegmentId, System.Globalization.CultureInfo.InvariantCulture)));
            if (Cursor != null) { request.AddQueryParameter("cursor", Cursor.ToString()); }
            if (EnforcementPointPath != null) { request.AddQueryParameter("enforcement_point_path", EnforcementPointPath.ToString()); }
            if (IncludedFields != null) { request.AddQueryParameter("included_fields", IncludedFields.ToString()); }
            if (PageSize != null) { request.AddQueryParameter("page_size", PageSize.ToString()); }
            if (SortAscending != null) { request.AddQueryParameter("sort_ascending", SortAscending.ToString()); }
            if (SortBy != null) { request.AddQueryParameter("sort_by", SortBy.ToString()); }
            if (Source != null) { request.AddQueryParameter("source", Source.ToString()); }
            if (TransportNodeId != null) { request.AddQueryParameter("transport_node_id", TransportNodeId.ToString()); }
            request.Resource = GlobalInfraGetInfraSegmentMacTableServiceURL.ToString();
            RestResponse<NSXTSegmentMacAddressListResultType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTSegmentMacAddressListResultType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Get operation to " + GlobalInfraGetInfraSegmentMacTableServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTInterfaceArpTableInCsvFormatType> GlobalGlobalInfraGetSegmentInterfaceArpTableCsv(string Tier1Id, string SegmentId, string? Cursor = null, string? EdgePath = null, string? EnforcementPointPath = null, string? HostTransportNodePath = null, string? IncludedFields = null, long? PageSize = null, bool? SortAscending = null, string? SortBy = null)
        {
            if (Tier1Id == null) { throw new System.ArgumentNullException("Tier1Id cannot be null"); }
            if (SegmentId == null) { throw new System.ArgumentNullException("SegmentId cannot be null"); }
            StringBuilder GlobalInfraGetSegmentInterfaceArpTableCsvServiceURL = new StringBuilder("/global-infra/tier-1s/{tier-1-id}/segments/{segment-id}/arp-table?format=csv");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Get
            };
            GlobalInfraGetSegmentInterfaceArpTableCsvServiceURL.Replace("{tier-1-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(Tier1Id, System.Globalization.CultureInfo.InvariantCulture)));
            GlobalInfraGetSegmentInterfaceArpTableCsvServiceURL.Replace("{segment-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(SegmentId, System.Globalization.CultureInfo.InvariantCulture)));
            if (Cursor != null) { request.AddQueryParameter("cursor", Cursor.ToString()); }
            if (EdgePath != null) { request.AddQueryParameter("edge_path", EdgePath.ToString()); }
            if (EnforcementPointPath != null) { request.AddQueryParameter("enforcement_point_path", EnforcementPointPath.ToString()); }
            if (HostTransportNodePath != null) { request.AddQueryParameter("host_transport_node_path", HostTransportNodePath.ToString()); }
            if (IncludedFields != null) { request.AddQueryParameter("included_fields", IncludedFields.ToString()); }
            if (PageSize != null) { request.AddQueryParameter("page_size", PageSize.ToString()); }
            if (SortAscending != null) { request.AddQueryParameter("sort_ascending", SortAscending.ToString()); }
            if (SortBy != null) { request.AddQueryParameter("sort_by", SortBy.ToString()); }
            request.Resource = GlobalInfraGetSegmentInterfaceArpTableCsvServiceURL.ToString();
            RestResponse<NSXTInterfaceArpTableInCsvFormatType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTInterfaceArpTableInCsvFormatType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Get operation to " + GlobalInfraGetSegmentInterfaceArpTableCsvServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTSegmentStatisticsType> GlobalGlobalInfraGetSegmentStatistics(string Tier1Id, string SegmentsId, string? Cursor = null, string? EdgePath = null, string? EnforcementPointPath = null, bool? IncludeMarkForDeleteObjects = null, string? IncludedFields = null, long? PageSize = null, bool? SortAscending = null, string? SortBy = null)
        {
            if (Tier1Id == null) { throw new System.ArgumentNullException("Tier1Id cannot be null"); }
            if (SegmentsId == null) { throw new System.ArgumentNullException("SegmentsId cannot be null"); }
            StringBuilder GlobalInfraGetSegmentStatisticsServiceURL = new StringBuilder("/global-infra/tier-1s/{tier-1-id}/segments/{segments-id}/statistics");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Get
            };
            GlobalInfraGetSegmentStatisticsServiceURL.Replace("{tier-1-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(Tier1Id, System.Globalization.CultureInfo.InvariantCulture)));
            GlobalInfraGetSegmentStatisticsServiceURL.Replace("{segments-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(SegmentsId, System.Globalization.CultureInfo.InvariantCulture)));
            if (Cursor != null) { request.AddQueryParameter("cursor", Cursor.ToString()); }
            if (EdgePath != null) { request.AddQueryParameter("edge_path", EdgePath.ToString()); }
            if (EnforcementPointPath != null) { request.AddQueryParameter("enforcement_point_path", EnforcementPointPath.ToString()); }
            if (IncludeMarkForDeleteObjects != null) { request.AddQueryParameter("include_mark_for_delete_objects", IncludeMarkForDeleteObjects.ToString()); }
            if (IncludedFields != null) { request.AddQueryParameter("included_fields", IncludedFields.ToString()); }
            if (PageSize != null) { request.AddQueryParameter("page_size", PageSize.ToString()); }
            if (SortAscending != null) { request.AddQueryParameter("sort_ascending", SortAscending.ToString()); }
            if (SortBy != null) { request.AddQueryParameter("sort_by", SortBy.ToString()); }
            request.Resource = GlobalInfraGetSegmentStatisticsServiceURL.ToString();
            RestResponse<NSXTSegmentStatisticsType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTSegmentStatisticsType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Get operation to " + GlobalInfraGetSegmentStatisticsServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTPolicyInterfaceStatisticsSummaryType> GetTier0InterfaceStatisticsSummary(string Tier0Id, string LocaleServiceId, string InterfaceId, string? Cursor = null, string? EnforcementPointPath = null, string? IncludedFields = null, long? PageSize = null, bool? SortAscending = null, string? SortBy = null)
        {
            if (Tier0Id == null) { throw new System.ArgumentNullException("Tier0Id cannot be null"); }
            if (LocaleServiceId == null) { throw new System.ArgumentNullException("LocaleServiceId cannot be null"); }
            if (InterfaceId == null) { throw new System.ArgumentNullException("InterfaceId cannot be null"); }
            StringBuilder GetTier0InterfaceStatisticsSummaryServiceURL = new StringBuilder("/infra/tier-0s/{tier-0-id}/locale-services/{locale-service-id}/interfaces/{interface-id}/statistics/summary");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Get
            };
            GetTier0InterfaceStatisticsSummaryServiceURL.Replace("{tier-0-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(Tier0Id, System.Globalization.CultureInfo.InvariantCulture)));
            GetTier0InterfaceStatisticsSummaryServiceURL.Replace("{locale-service-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(LocaleServiceId, System.Globalization.CultureInfo.InvariantCulture)));
            GetTier0InterfaceStatisticsSummaryServiceURL.Replace("{interface-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(InterfaceId, System.Globalization.CultureInfo.InvariantCulture)));
            if (Cursor != null) { request.AddQueryParameter("cursor", Cursor.ToString()); }
            if (EnforcementPointPath != null) { request.AddQueryParameter("enforcement_point_path", EnforcementPointPath.ToString()); }
            if (IncludedFields != null) { request.AddQueryParameter("included_fields", IncludedFields.ToString()); }
            if (PageSize != null) { request.AddQueryParameter("page_size", PageSize.ToString()); }
            if (SortAscending != null) { request.AddQueryParameter("sort_ascending", SortAscending.ToString()); }
            if (SortBy != null) { request.AddQueryParameter("sort_by", SortBy.ToString()); }
            request.Resource = GetTier0InterfaceStatisticsSummaryServiceURL.ToString();
            RestResponse<NSXTPolicyInterfaceStatisticsSummaryType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTPolicyInterfaceStatisticsSummaryType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Get operation to " + GetTier0InterfaceStatisticsSummaryServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTPolicyArpProxyTableListResultType> GlobalGlobalInfraGetDownlinkPortArpProxiesForTier1Segment(string Tier1Id, string SegmentId, string? Cursor = null, string? EnforcementPointPath = null, string? IncludedFields = null, long? PageSize = null, bool? SortAscending = null, string? SortBy = null, string? Source = null, string? TransportNodeId = null)
        {
            if (Tier1Id == null) { throw new System.ArgumentNullException("Tier1Id cannot be null"); }
            if (SegmentId == null) { throw new System.ArgumentNullException("SegmentId cannot be null"); }
            StringBuilder GlobalInfraGetDownlinkPortArpProxiesForTier1SegmentServiceURL = new StringBuilder("/global-infra/tier-1s/{tier-1-id}/segments/{segment-id}/arp-proxy");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Get
            };
            GlobalInfraGetDownlinkPortArpProxiesForTier1SegmentServiceURL.Replace("{tier-1-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(Tier1Id, System.Globalization.CultureInfo.InvariantCulture)));
            GlobalInfraGetDownlinkPortArpProxiesForTier1SegmentServiceURL.Replace("{segment-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(SegmentId, System.Globalization.CultureInfo.InvariantCulture)));
            if (Cursor != null) { request.AddQueryParameter("cursor", Cursor.ToString()); }
            if (EnforcementPointPath != null) { request.AddQueryParameter("enforcement_point_path", EnforcementPointPath.ToString()); }
            if (IncludedFields != null) { request.AddQueryParameter("included_fields", IncludedFields.ToString()); }
            if (PageSize != null) { request.AddQueryParameter("page_size", PageSize.ToString()); }
            if (SortAscending != null) { request.AddQueryParameter("sort_ascending", SortAscending.ToString()); }
            if (SortBy != null) { request.AddQueryParameter("sort_by", SortBy.ToString()); }
            if (Source != null) { request.AddQueryParameter("source", Source.ToString()); }
            if (TransportNodeId != null) { request.AddQueryParameter("transport_node_id", TransportNodeId.ToString()); }
            request.Resource = GlobalInfraGetDownlinkPortArpProxiesForTier1SegmentServiceURL.ToString();
            RestResponse<NSXTPolicyArpProxyTableListResultType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTPolicyArpProxyTableListResultType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Get operation to " + GlobalInfraGetDownlinkPortArpProxiesForTier1SegmentServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTPolicyTepCsvListResultType> GetInfraSegmentTepTableInCsv(string SegmentId, string? EnforcementPointPath = null, string? Source = null, string? TransportNodeId = null)
        {
            if (SegmentId == null) { throw new System.ArgumentNullException("SegmentId cannot be null"); }
            StringBuilder GetInfraSegmentTepTableInCsvServiceURL = new StringBuilder("/infra/segments/{segment-id}/tep-table?format=csv");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Get
            };
            GetInfraSegmentTepTableInCsvServiceURL.Replace("{segment-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(SegmentId, System.Globalization.CultureInfo.InvariantCulture)));
            if (EnforcementPointPath != null) { request.AddQueryParameter("enforcement_point_path", EnforcementPointPath.ToString()); }
            if (Source != null) { request.AddQueryParameter("source", Source.ToString()); }
            if (TransportNodeId != null) { request.AddQueryParameter("transport_node_id", TransportNodeId.ToString()); }
            request.Resource = GetInfraSegmentTepTableInCsvServiceURL.ToString();
            RestResponse<NSXTPolicyTepCsvListResultType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTPolicyTepCsvListResultType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Get operation to " + GetInfraSegmentTepTableInCsvServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTOspfNeighborsStatusListResultType> GetOspfNeighbors(string Tier0Id, string LocaleServiceId, string? Cursor = null, string? EdgePath = null, string? IncludedFields = null, string? NeighborAddress = null, long? PageSize = null, bool? SortAscending = null, string? SortBy = null)
        {
            if (Tier0Id == null) { throw new System.ArgumentNullException("Tier0Id cannot be null"); }
            if (LocaleServiceId == null) { throw new System.ArgumentNullException("LocaleServiceId cannot be null"); }
            StringBuilder GetOspfNeighborsServiceURL = new StringBuilder("/infra/tier-0s/{tier-0-id}/locale-services/{locale-service-id}/ospf/neighbors");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Get
            };
            GetOspfNeighborsServiceURL.Replace("{tier-0-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(Tier0Id, System.Globalization.CultureInfo.InvariantCulture)));
            GetOspfNeighborsServiceURL.Replace("{locale-service-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(LocaleServiceId, System.Globalization.CultureInfo.InvariantCulture)));
            if (Cursor != null) { request.AddQueryParameter("cursor", Cursor.ToString()); }
            if (EdgePath != null) { request.AddQueryParameter("edge_path", EdgePath.ToString()); }
            if (IncludedFields != null) { request.AddQueryParameter("included_fields", IncludedFields.ToString()); }
            if (NeighborAddress != null) { request.AddQueryParameter("neighbor_address", NeighborAddress.ToString()); }
            if (PageSize != null) { request.AddQueryParameter("page_size", PageSize.ToString()); }
            if (SortAscending != null) { request.AddQueryParameter("sort_ascending", SortAscending.ToString()); }
            if (SortBy != null) { request.AddQueryParameter("sort_by", SortBy.ToString()); }
            request.Resource = GetOspfNeighborsServiceURL.ToString();
            RestResponse<NSXTOspfNeighborsStatusListResultType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTOspfNeighborsStatusListResultType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Get operation to " + GetOspfNeighborsServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTInterfaceArpTableType> GlobalGlobalInfraGetDownlinkPortArpTableForTier1Segment(string Tier1Id, string SegmentId, string? Cursor = null, string? EdgePath = null, string? EnforcementPointPath = null, string? HostTransportNodePath = null, string? IncludedFields = null, long? PageSize = null, bool? SortAscending = null, string? SortBy = null)
        {
            if (Tier1Id == null) { throw new System.ArgumentNullException("Tier1Id cannot be null"); }
            if (SegmentId == null) { throw new System.ArgumentNullException("SegmentId cannot be null"); }
            StringBuilder GlobalInfraGetDownlinkPortArpTableForTier1SegmentServiceURL = new StringBuilder("/global-infra/tier-1s/{tier-1-id}/segments/{segment-id}/gateway-interface-arp-table");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Get
            };
            GlobalInfraGetDownlinkPortArpTableForTier1SegmentServiceURL.Replace("{tier-1-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(Tier1Id, System.Globalization.CultureInfo.InvariantCulture)));
            GlobalInfraGetDownlinkPortArpTableForTier1SegmentServiceURL.Replace("{segment-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(SegmentId, System.Globalization.CultureInfo.InvariantCulture)));
            if (Cursor != null) { request.AddQueryParameter("cursor", Cursor.ToString()); }
            if (EdgePath != null) { request.AddQueryParameter("edge_path", EdgePath.ToString()); }
            if (EnforcementPointPath != null) { request.AddQueryParameter("enforcement_point_path", EnforcementPointPath.ToString()); }
            if (HostTransportNodePath != null) { request.AddQueryParameter("host_transport_node_path", HostTransportNodePath.ToString()); }
            if (IncludedFields != null) { request.AddQueryParameter("included_fields", IncludedFields.ToString()); }
            if (PageSize != null) { request.AddQueryParameter("page_size", PageSize.ToString()); }
            if (SortAscending != null) { request.AddQueryParameter("sort_ascending", SortAscending.ToString()); }
            if (SortBy != null) { request.AddQueryParameter("sort_by", SortBy.ToString()); }
            request.Resource = GlobalInfraGetDownlinkPortArpTableForTier1SegmentServiceURL.ToString();
            RestResponse<NSXTInterfaceArpTableType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTInterfaceArpTableType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Get operation to " + GlobalInfraGetDownlinkPortArpTableForTier1SegmentServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTPolicyArpProxyTableListResultType> GlobalGlobalInfraGetTier1GatewayArpProxies(string Tier1Id, string? Cursor = null, string? EnforcementPointPath = null, string? IncludedFields = null, long? PageSize = null, bool? SortAscending = null, string? SortBy = null, string? Source = null, string? TransportNodeId = null)
        {
            if (Tier1Id == null) { throw new System.ArgumentNullException("Tier1Id cannot be null"); }
            StringBuilder GlobalInfraGetTier1GatewayArpProxiesServiceURL = new StringBuilder("/global-infra/tier-1s/{tier-1-id}/arp-proxies");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Get
            };
            GlobalInfraGetTier1GatewayArpProxiesServiceURL.Replace("{tier-1-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(Tier1Id, System.Globalization.CultureInfo.InvariantCulture)));
            if (Cursor != null) { request.AddQueryParameter("cursor", Cursor.ToString()); }
            if (EnforcementPointPath != null) { request.AddQueryParameter("enforcement_point_path", EnforcementPointPath.ToString()); }
            if (IncludedFields != null) { request.AddQueryParameter("included_fields", IncludedFields.ToString()); }
            if (PageSize != null) { request.AddQueryParameter("page_size", PageSize.ToString()); }
            if (SortAscending != null) { request.AddQueryParameter("sort_ascending", SortAscending.ToString()); }
            if (SortBy != null) { request.AddQueryParameter("sort_by", SortBy.ToString()); }
            if (Source != null) { request.AddQueryParameter("source", Source.ToString()); }
            if (TransportNodeId != null) { request.AddQueryParameter("transport_node_id", TransportNodeId.ToString()); }
            request.Resource = GlobalInfraGetTier1GatewayArpProxiesServiceURL.ToString();
            RestResponse<NSXTPolicyArpProxyTableListResultType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTPolicyArpProxyTableListResultType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Get operation to " + GlobalInfraGetTier1GatewayArpProxiesServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTPolicyMulticastForwardingType> GetTier1PolicyMulticastForwarding(string Tier1Id, string LocaleServicesId, string? Cursor = null, string? EdgePath = null, string? IncludedFields = null, long? PageSize = null, bool? SortAscending = null, string? SortBy = null)
        {
            if (Tier1Id == null) { throw new System.ArgumentNullException("Tier1Id cannot be null"); }
            if (LocaleServicesId == null) { throw new System.ArgumentNullException("LocaleServicesId cannot be null"); }
            StringBuilder GetTier1PolicyMulticastForwardingServiceURL = new StringBuilder("/infra/tier-1s/{tier-1-id}/locale-services/{locale-services-id}/multicast/forwarding");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Get
            };
            GetTier1PolicyMulticastForwardingServiceURL.Replace("{tier-1-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(Tier1Id, System.Globalization.CultureInfo.InvariantCulture)));
            GetTier1PolicyMulticastForwardingServiceURL.Replace("{locale-services-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(LocaleServicesId, System.Globalization.CultureInfo.InvariantCulture)));
            if (Cursor != null) { request.AddQueryParameter("cursor", Cursor.ToString()); }
            if (EdgePath != null) { request.AddQueryParameter("edge_path", EdgePath.ToString()); }
            if (IncludedFields != null) { request.AddQueryParameter("included_fields", IncludedFields.ToString()); }
            if (PageSize != null) { request.AddQueryParameter("page_size", PageSize.ToString()); }
            if (SortAscending != null) { request.AddQueryParameter("sort_ascending", SortAscending.ToString()); }
            if (SortBy != null) { request.AddQueryParameter("sort_by", SortBy.ToString()); }
            request.Resource = GetTier1PolicyMulticastForwardingServiceURL.ToString();
            RestResponse<NSXTPolicyMulticastForwardingType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTPolicyMulticastForwardingType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Get operation to " + GetTier1PolicyMulticastForwardingServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTSegmentPortStatusType> GetSegmentPortStatus(string Tier1Id, string SegmentsId, string PortId, string? Cursor = null, string? EdgePath = null, string? EnforcementPointPath = null, bool? IncludeMarkForDeleteObjects = null, string? IncludedFields = null, long? PageSize = null, bool? SortAscending = null, string? SortBy = null)
        {
            if (Tier1Id == null) { throw new System.ArgumentNullException("Tier1Id cannot be null"); }
            if (SegmentsId == null) { throw new System.ArgumentNullException("SegmentsId cannot be null"); }
            if (PortId == null) { throw new System.ArgumentNullException("PortId cannot be null"); }
            StringBuilder GetSegmentPortStatusServiceURL = new StringBuilder("/infra/tier-1s/{tier-1-id}/segments/{segments-id}/ports/{port-id}/status");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Get
            };
            GetSegmentPortStatusServiceURL.Replace("{tier-1-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(Tier1Id, System.Globalization.CultureInfo.InvariantCulture)));
            GetSegmentPortStatusServiceURL.Replace("{segments-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(SegmentsId, System.Globalization.CultureInfo.InvariantCulture)));
            GetSegmentPortStatusServiceURL.Replace("{port-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(PortId, System.Globalization.CultureInfo.InvariantCulture)));
            if (Cursor != null) { request.AddQueryParameter("cursor", Cursor.ToString()); }
            if (EdgePath != null) { request.AddQueryParameter("edge_path", EdgePath.ToString()); }
            if (EnforcementPointPath != null) { request.AddQueryParameter("enforcement_point_path", EnforcementPointPath.ToString()); }
            if (IncludeMarkForDeleteObjects != null) { request.AddQueryParameter("include_mark_for_delete_objects", IncludeMarkForDeleteObjects.ToString()); }
            if (IncludedFields != null) { request.AddQueryParameter("included_fields", IncludedFields.ToString()); }
            if (PageSize != null) { request.AddQueryParameter("page_size", PageSize.ToString()); }
            if (SortAscending != null) { request.AddQueryParameter("sort_ascending", SortAscending.ToString()); }
            if (SortBy != null) { request.AddQueryParameter("sort_by", SortBy.ToString()); }
            request.Resource = GetSegmentPortStatusServiceURL.ToString();
            RestResponse<NSXTSegmentPortStatusType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTSegmentPortStatusType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Get operation to " + GetSegmentPortStatusServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTBgpNeighborRouteDetailsInCsvFormatType> GlobalGlobalInfraGetTier0BgpNeighborAdvertisedRoutesInCsvFormat(string Tier0Id, string LocaleServiceId, string NeighborId, int? Count = null, string? Cursor = null, string? EnforcementPointPath = null, string? IncludedFields = null, long? PageSize = null, bool? SortAscending = null, string? SortBy = null)
        {
            if (Tier0Id == null) { throw new System.ArgumentNullException("Tier0Id cannot be null"); }
            if (LocaleServiceId == null) { throw new System.ArgumentNullException("LocaleServiceId cannot be null"); }
            if (NeighborId == null) { throw new System.ArgumentNullException("NeighborId cannot be null"); }
            StringBuilder GlobalInfraGetTier0BgpNeighborAdvertisedRoutesInCsvFormatServiceURL = new StringBuilder("/global-infra/tier-0s/{tier-0-id}/locale-services/{locale-service-id}/bgp/neighbors/{neighbor-id}/advertised-routes?format=csv");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Get
            };
            GlobalInfraGetTier0BgpNeighborAdvertisedRoutesInCsvFormatServiceURL.Replace("{tier-0-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(Tier0Id, System.Globalization.CultureInfo.InvariantCulture)));
            GlobalInfraGetTier0BgpNeighborAdvertisedRoutesInCsvFormatServiceURL.Replace("{locale-service-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(LocaleServiceId, System.Globalization.CultureInfo.InvariantCulture)));
            GlobalInfraGetTier0BgpNeighborAdvertisedRoutesInCsvFormatServiceURL.Replace("{neighbor-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(NeighborId, System.Globalization.CultureInfo.InvariantCulture)));
            if (Count != null) { request.AddQueryParameter("count", Count.ToString()); }
            if (Cursor != null) { request.AddQueryParameter("cursor", Cursor.ToString()); }
            if (EnforcementPointPath != null) { request.AddQueryParameter("enforcement_point_path", EnforcementPointPath.ToString()); }
            if (IncludedFields != null) { request.AddQueryParameter("included_fields", IncludedFields.ToString()); }
            if (PageSize != null) { request.AddQueryParameter("page_size", PageSize.ToString()); }
            if (SortAscending != null) { request.AddQueryParameter("sort_ascending", SortAscending.ToString()); }
            if (SortBy != null) { request.AddQueryParameter("sort_by", SortBy.ToString()); }
            request.Resource = GlobalInfraGetTier0BgpNeighborAdvertisedRoutesInCsvFormatServiceURL.ToString();
            RestResponse<NSXTBgpNeighborRouteDetailsInCsvFormatType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTBgpNeighborRouteDetailsInCsvFormatType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Get operation to " + GlobalInfraGetTier0BgpNeighborAdvertisedRoutesInCsvFormatServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTBridgeEndpointStatisticsType> Tier1SegmentBridgeEndpointStatistics(string Tier1Id, string SegmentId, string BridgeProfilePath, string? EnforcementPointPath = null)
        {
            if (Tier1Id == null) { throw new System.ArgumentNullException("Tier1Id cannot be null"); }
            if (SegmentId == null) { throw new System.ArgumentNullException("SegmentId cannot be null"); }
            if (BridgeProfilePath == null) { throw new System.ArgumentNullException("BridgeProfilePath cannot be null"); }
            StringBuilder Tier1SegmentBridgeEndpointStatisticsServiceURL = new StringBuilder("/infra/tier-1s/{tier-1-id}/segments/{segment-id}/bep-statistics");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Get
            };
            Tier1SegmentBridgeEndpointStatisticsServiceURL.Replace("{tier-1-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(Tier1Id, System.Globalization.CultureInfo.InvariantCulture)));
            Tier1SegmentBridgeEndpointStatisticsServiceURL.Replace("{segment-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(SegmentId, System.Globalization.CultureInfo.InvariantCulture)));
            if (BridgeProfilePath != null) { request.AddQueryParameter("bridge_profile_path", BridgeProfilePath.ToString()); }
            if (EnforcementPointPath != null) { request.AddQueryParameter("enforcement_point_path", EnforcementPointPath.ToString()); }
            request.Resource = Tier1SegmentBridgeEndpointStatisticsServiceURL.ToString();
            RestResponse<NSXTBridgeEndpointStatisticsType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTBridgeEndpointStatisticsType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Get operation to " + Tier1SegmentBridgeEndpointStatisticsServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTSegmentConfigurationStateListResultType> GlobalGlobalInfraGetTier1SegmentsByState(string Tier1Id, string? ConfigurationState = null, string? EnforcementPointPath = null, string? Source = null)
        {
            if (Tier1Id == null) { throw new System.ArgumentNullException("Tier1Id cannot be null"); }
            StringBuilder GlobalInfraGetTier1SegmentsByStateServiceURL = new StringBuilder("/global-infra/tier-1s/{tier-1-id}/segments/state");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Get
            };
            GlobalInfraGetTier1SegmentsByStateServiceURL.Replace("{tier-1-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(Tier1Id, System.Globalization.CultureInfo.InvariantCulture)));
            if (ConfigurationState != null) { request.AddQueryParameter("configuration_state", ConfigurationState.ToString()); }
            if (EnforcementPointPath != null) { request.AddQueryParameter("enforcement_point_path", EnforcementPointPath.ToString()); }
            if (Source != null) { request.AddQueryParameter("source", Source.ToString()); }
            request.Resource = GlobalInfraGetTier1SegmentsByStateServiceURL.ToString();
            RestResponse<NSXTSegmentConfigurationStateListResultType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTSegmentConfigurationStateListResultType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Get operation to " + GlobalInfraGetTier1SegmentsByStateServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTPolicyInterfaceStatisticsType> GlobalGlobalInfraGetTier0RouterLinkStatistics(string Tier0Id, string Tier1Path, string? Cursor = null, string? EdgePath = null, string? EnforcementPointPath = null, bool? IncludeMarkForDeleteObjects = null, string? IncludedFields = null, long? PageSize = null, bool? SortAscending = null, string? SortBy = null)
        {
            if (Tier0Id == null) { throw new System.ArgumentNullException("Tier0Id cannot be null"); }
            if (Tier1Path == null) { throw new System.ArgumentNullException("Tier1Path cannot be null"); }
            StringBuilder GlobalInfraGetTier0RouterLinkStatisticsServiceURL = new StringBuilder("/global-infra/tier-0s/{tier-0-id}/tier-1-interface/statistics");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Get
            };
            GlobalInfraGetTier0RouterLinkStatisticsServiceURL.Replace("{tier-0-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(Tier0Id, System.Globalization.CultureInfo.InvariantCulture)));
            if (Cursor != null) { request.AddQueryParameter("cursor", Cursor.ToString()); }
            if (EdgePath != null) { request.AddQueryParameter("edge_path", EdgePath.ToString()); }
            if (EnforcementPointPath != null) { request.AddQueryParameter("enforcement_point_path", EnforcementPointPath.ToString()); }
            if (IncludeMarkForDeleteObjects != null) { request.AddQueryParameter("include_mark_for_delete_objects", IncludeMarkForDeleteObjects.ToString()); }
            if (IncludedFields != null) { request.AddQueryParameter("included_fields", IncludedFields.ToString()); }
            if (PageSize != null) { request.AddQueryParameter("page_size", PageSize.ToString()); }
            if (SortAscending != null) { request.AddQueryParameter("sort_ascending", SortAscending.ToString()); }
            if (SortBy != null) { request.AddQueryParameter("sort_by", SortBy.ToString()); }
            if (Tier1Path != null) { request.AddQueryParameter("tier1_path", Tier1Path.ToString()); }
            request.Resource = GlobalInfraGetTier0RouterLinkStatisticsServiceURL.ToString();
            RestResponse<NSXTPolicyInterfaceStatisticsType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTPolicyInterfaceStatisticsType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Get operation to " + GlobalInfraGetTier0RouterLinkStatisticsServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTDhcpStaticBindingStateType> ReadSegmentDhcpStaticBindingState(string Tier1Id, string SegmentId, string BindingId)
        {
            if (Tier1Id == null) { throw new System.ArgumentNullException("Tier1Id cannot be null"); }
            if (SegmentId == null) { throw new System.ArgumentNullException("SegmentId cannot be null"); }
            if (BindingId == null) { throw new System.ArgumentNullException("BindingId cannot be null"); }
            StringBuilder ReadSegmentDhcpStaticBindingStateServiceURL = new StringBuilder("/infra/tier-1s/{tier-1-id}/segments/{segment-id}/dhcp-static-bindings/{binding-id}/state");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Get
            };
            ReadSegmentDhcpStaticBindingStateServiceURL.Replace("{tier-1-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(Tier1Id, System.Globalization.CultureInfo.InvariantCulture)));
            ReadSegmentDhcpStaticBindingStateServiceURL.Replace("{segment-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(SegmentId, System.Globalization.CultureInfo.InvariantCulture)));
            ReadSegmentDhcpStaticBindingStateServiceURL.Replace("{binding-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(BindingId, System.Globalization.CultureInfo.InvariantCulture)));
            request.Resource = ReadSegmentDhcpStaticBindingStateServiceURL.ToString();
            RestResponse<NSXTDhcpStaticBindingStateType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTDhcpStaticBindingStateType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Get operation to " + ReadSegmentDhcpStaticBindingStateServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTBridgeEndpointStatisticsType> GlobalGlobalInfraTier1SegmentBridgeEndpointStatistics(string Tier1Id, string SegmentId, string BridgeProfilePath, string? EnforcementPointPath = null)
        {
            if (Tier1Id == null) { throw new System.ArgumentNullException("Tier1Id cannot be null"); }
            if (SegmentId == null) { throw new System.ArgumentNullException("SegmentId cannot be null"); }
            if (BridgeProfilePath == null) { throw new System.ArgumentNullException("BridgeProfilePath cannot be null"); }
            StringBuilder GlobalInfraTier1SegmentBridgeEndpointStatisticsServiceURL = new StringBuilder("/global-infra/tier-1s/{tier-1-id}/segments/{segment-id}/bep-statistics");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Get
            };
            GlobalInfraTier1SegmentBridgeEndpointStatisticsServiceURL.Replace("{tier-1-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(Tier1Id, System.Globalization.CultureInfo.InvariantCulture)));
            GlobalInfraTier1SegmentBridgeEndpointStatisticsServiceURL.Replace("{segment-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(SegmentId, System.Globalization.CultureInfo.InvariantCulture)));
            if (BridgeProfilePath != null) { request.AddQueryParameter("bridge_profile_path", BridgeProfilePath.ToString()); }
            if (EnforcementPointPath != null) { request.AddQueryParameter("enforcement_point_path", EnforcementPointPath.ToString()); }
            request.Resource = GlobalInfraTier1SegmentBridgeEndpointStatisticsServiceURL.ToString();
            RestResponse<NSXTBridgeEndpointStatisticsType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTBridgeEndpointStatisticsType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Get operation to " + GlobalInfraTier1SegmentBridgeEndpointStatisticsServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTRoutingTableListResultType> GetTier0ForwardingTable(string Tier0Id, string? Cursor = null, string? EdgeId = null, string? EdgePath = null, string? EnforcementPointPath = null, string? IncludedFields = null, string? NetworkPrefix = null, long? PageSize = null, string? RouteSource = null, bool? SortAscending = null, string? SortBy = null)
        {
            if (Tier0Id == null) { throw new System.ArgumentNullException("Tier0Id cannot be null"); }
            StringBuilder GetTier0ForwardingTableServiceURL = new StringBuilder("/infra/tier-0s/{tier-0-id}/forwarding-table");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Get
            };
            GetTier0ForwardingTableServiceURL.Replace("{tier-0-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(Tier0Id, System.Globalization.CultureInfo.InvariantCulture)));
            if (Cursor != null) { request.AddQueryParameter("cursor", Cursor.ToString()); }
            if (EdgeId != null) { request.AddQueryParameter("edge_id", EdgeId.ToString()); }
            if (EdgePath != null) { request.AddQueryParameter("edge_path", EdgePath.ToString()); }
            if (EnforcementPointPath != null) { request.AddQueryParameter("enforcement_point_path", EnforcementPointPath.ToString()); }
            if (IncludedFields != null) { request.AddQueryParameter("included_fields", IncludedFields.ToString()); }
            if (NetworkPrefix != null) { request.AddQueryParameter("network_prefix", NetworkPrefix.ToString()); }
            if (PageSize != null) { request.AddQueryParameter("page_size", PageSize.ToString()); }
            if (RouteSource != null) { request.AddQueryParameter("route_source", RouteSource.ToString()); }
            if (SortAscending != null) { request.AddQueryParameter("sort_ascending", SortAscending.ToString()); }
            if (SortBy != null) { request.AddQueryParameter("sort_by", SortBy.ToString()); }
            request.Resource = GetTier0ForwardingTableServiceURL.ToString();
            RestResponse<NSXTRoutingTableListResultType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTRoutingTableListResultType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Get operation to " + GetTier0ForwardingTableServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTPolicyMulticastRoutesInCsvFormatType> GetPolicyMulticastRoutesInCsvFormat(string Tier0Id, string LocaleServicesId, string? Cursor = null, string? EdgePath = null, string? IncludedFields = null, long? PageSize = null, bool? SortAscending = null, string? SortBy = null)
        {
            if (Tier0Id == null) { throw new System.ArgumentNullException("Tier0Id cannot be null"); }
            if (LocaleServicesId == null) { throw new System.ArgumentNullException("LocaleServicesId cannot be null"); }
            StringBuilder GetPolicyMulticastRoutesInCsvFormatServiceURL = new StringBuilder("/infra/tier-0s/{tier-0-id}/locale-services/{locale-services-id}/multicast/routes?format=csv");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Get
            };
            GetPolicyMulticastRoutesInCsvFormatServiceURL.Replace("{tier-0-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(Tier0Id, System.Globalization.CultureInfo.InvariantCulture)));
            GetPolicyMulticastRoutesInCsvFormatServiceURL.Replace("{locale-services-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(LocaleServicesId, System.Globalization.CultureInfo.InvariantCulture)));
            if (Cursor != null) { request.AddQueryParameter("cursor", Cursor.ToString()); }
            if (EdgePath != null) { request.AddQueryParameter("edge_path", EdgePath.ToString()); }
            if (IncludedFields != null) { request.AddQueryParameter("included_fields", IncludedFields.ToString()); }
            if (PageSize != null) { request.AddQueryParameter("page_size", PageSize.ToString()); }
            if (SortAscending != null) { request.AddQueryParameter("sort_ascending", SortAscending.ToString()); }
            if (SortBy != null) { request.AddQueryParameter("sort_by", SortBy.ToString()); }
            request.Resource = GetPolicyMulticastRoutesInCsvFormatServiceURL.ToString();
            RestResponse<NSXTPolicyMulticastRoutesInCsvFormatType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTPolicyMulticastRoutesInCsvFormatType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Get operation to " + GetPolicyMulticastRoutesInCsvFormatServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTSegmentCrossSiteTrafficStatsType> GlobalGlobalInfraGetInfraSegmentCsTrafficStats(string SegmentId, string? Cursor = null, string? EdgePath = null, string? EnforcementPointPath = null, bool? IncludeMarkForDeleteObjects = null, string? IncludedFields = null, long? PageSize = null, bool? SortAscending = null, string? SortBy = null)
        {
            if (SegmentId == null) { throw new System.ArgumentNullException("SegmentId cannot be null"); }
            StringBuilder GlobalInfraGetInfraSegmentCsTrafficStatsServiceURL = new StringBuilder("/global-infra/segments/{segment-id}/inter-site-forwarder/status");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Get
            };
            GlobalInfraGetInfraSegmentCsTrafficStatsServiceURL.Replace("{segment-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(SegmentId, System.Globalization.CultureInfo.InvariantCulture)));
            if (Cursor != null) { request.AddQueryParameter("cursor", Cursor.ToString()); }
            if (EdgePath != null) { request.AddQueryParameter("edge_path", EdgePath.ToString()); }
            if (EnforcementPointPath != null) { request.AddQueryParameter("enforcement_point_path", EnforcementPointPath.ToString()); }
            if (IncludeMarkForDeleteObjects != null) { request.AddQueryParameter("include_mark_for_delete_objects", IncludeMarkForDeleteObjects.ToString()); }
            if (IncludedFields != null) { request.AddQueryParameter("included_fields", IncludedFields.ToString()); }
            if (PageSize != null) { request.AddQueryParameter("page_size", PageSize.ToString()); }
            if (SortAscending != null) { request.AddQueryParameter("sort_ascending", SortAscending.ToString()); }
            if (SortBy != null) { request.AddQueryParameter("sort_by", SortBy.ToString()); }
            request.Resource = GlobalInfraGetInfraSegmentCsTrafficStatsServiceURL.ToString();
            RestResponse<NSXTSegmentCrossSiteTrafficStatsType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTSegmentCrossSiteTrafficStatsType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Get operation to " + GlobalInfraGetInfraSegmentCsTrafficStatsServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTSegmentConfigurationStateListResultType> GetInfraSegmentsByState(string? ConfigurationState = null, string? EnforcementPointPath = null, string? Source = null)
        {
            StringBuilder GetInfraSegmentsByStateServiceURL = new StringBuilder("/infra/segments/state");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Get
            };
            if (ConfigurationState != null) { request.AddQueryParameter("configuration_state", ConfigurationState.ToString()); }
            if (EnforcementPointPath != null) { request.AddQueryParameter("enforcement_point_path", EnforcementPointPath.ToString()); }
            if (Source != null) { request.AddQueryParameter("source", Source.ToString()); }
            request.Resource = GetInfraSegmentsByStateServiceURL.ToString();
            RestResponse<NSXTSegmentConfigurationStateListResultType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTSegmentConfigurationStateListResultType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Get operation to " + GetInfraSegmentsByStateServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTSegmentMacAddressListResultType> GetInfraSegmentMacTable(string SegmentId, string? Cursor = null, string? EnforcementPointPath = null, string? IncludedFields = null, long? PageSize = null, bool? SortAscending = null, string? SortBy = null, string? Source = null, string? TransportNodeId = null)
        {
            if (SegmentId == null) { throw new System.ArgumentNullException("SegmentId cannot be null"); }
            StringBuilder GetInfraSegmentMacTableServiceURL = new StringBuilder("/infra/segments/{segment-id}/mac-table");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Get
            };
            GetInfraSegmentMacTableServiceURL.Replace("{segment-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(SegmentId, System.Globalization.CultureInfo.InvariantCulture)));
            if (Cursor != null) { request.AddQueryParameter("cursor", Cursor.ToString()); }
            if (EnforcementPointPath != null) { request.AddQueryParameter("enforcement_point_path", EnforcementPointPath.ToString()); }
            if (IncludedFields != null) { request.AddQueryParameter("included_fields", IncludedFields.ToString()); }
            if (PageSize != null) { request.AddQueryParameter("page_size", PageSize.ToString()); }
            if (SortAscending != null) { request.AddQueryParameter("sort_ascending", SortAscending.ToString()); }
            if (SortBy != null) { request.AddQueryParameter("sort_by", SortBy.ToString()); }
            if (Source != null) { request.AddQueryParameter("source", Source.ToString()); }
            if (TransportNodeId != null) { request.AddQueryParameter("transport_node_id", TransportNodeId.ToString()); }
            request.Resource = GetInfraSegmentMacTableServiceURL.ToString();
            RestResponse<NSXTSegmentMacAddressListResultType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTSegmentMacAddressListResultType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Get operation to " + GetInfraSegmentMacTableServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTGatewayRouteTableInCsvFormatType> GetTier1ForwardingTableCsv(string Tier1Id, string? Cursor = null, string? EdgeId = null, string? EdgePath = null, string? EnforcementPointPath = null, string? IncludedFields = null, string? NetworkPrefix = null, long? PageSize = null, string? RouteSource = null, bool? SortAscending = null, string? SortBy = null)
        {
            if (Tier1Id == null) { throw new System.ArgumentNullException("Tier1Id cannot be null"); }
            StringBuilder GetTier1ForwardingTableCsvServiceURL = new StringBuilder("/infra/tier-1s/{tier-1-id}/forwarding-table?format=csv");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Get
            };
            GetTier1ForwardingTableCsvServiceURL.Replace("{tier-1-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(Tier1Id, System.Globalization.CultureInfo.InvariantCulture)));
            if (Cursor != null) { request.AddQueryParameter("cursor", Cursor.ToString()); }
            if (EdgeId != null) { request.AddQueryParameter("edge_id", EdgeId.ToString()); }
            if (EdgePath != null) { request.AddQueryParameter("edge_path", EdgePath.ToString()); }
            if (EnforcementPointPath != null) { request.AddQueryParameter("enforcement_point_path", EnforcementPointPath.ToString()); }
            if (IncludedFields != null) { request.AddQueryParameter("included_fields", IncludedFields.ToString()); }
            if (NetworkPrefix != null) { request.AddQueryParameter("network_prefix", NetworkPrefix.ToString()); }
            if (PageSize != null) { request.AddQueryParameter("page_size", PageSize.ToString()); }
            if (RouteSource != null) { request.AddQueryParameter("route_source", RouteSource.ToString()); }
            if (SortAscending != null) { request.AddQueryParameter("sort_ascending", SortAscending.ToString()); }
            if (SortBy != null) { request.AddQueryParameter("sort_by", SortBy.ToString()); }
            request.Resource = GetTier1ForwardingTableCsvServiceURL.ToString();
            RestResponse<NSXTGatewayRouteTableInCsvFormatType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTGatewayRouteTableInCsvFormatType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Get operation to " + GetTier1ForwardingTableCsvServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTPolicyInterfaceStatisticsType> GlobalGlobalInfraGetDownlinkPortStatisticsForInfraSegment(string SegmentId, string? Cursor = null, string? EdgePath = null, string? EnforcementPointPath = null, string? HostTransportNodePath = null, string? IncludedFields = null, long? PageSize = null, bool? SortAscending = null, string? SortBy = null)
        {
            if (SegmentId == null) { throw new System.ArgumentNullException("SegmentId cannot be null"); }
            StringBuilder GlobalInfraGetDownlinkPortStatisticsForInfraSegmentServiceURL = new StringBuilder("/global-infra/segments/{segment-id}/gateway-interface-statistics");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Get
            };
            GlobalInfraGetDownlinkPortStatisticsForInfraSegmentServiceURL.Replace("{segment-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(SegmentId, System.Globalization.CultureInfo.InvariantCulture)));
            if (Cursor != null) { request.AddQueryParameter("cursor", Cursor.ToString()); }
            if (EdgePath != null) { request.AddQueryParameter("edge_path", EdgePath.ToString()); }
            if (EnforcementPointPath != null) { request.AddQueryParameter("enforcement_point_path", EnforcementPointPath.ToString()); }
            if (HostTransportNodePath != null) { request.AddQueryParameter("host_transport_node_path", HostTransportNodePath.ToString()); }
            if (IncludedFields != null) { request.AddQueryParameter("included_fields", IncludedFields.ToString()); }
            if (PageSize != null) { request.AddQueryParameter("page_size", PageSize.ToString()); }
            if (SortAscending != null) { request.AddQueryParameter("sort_ascending", SortAscending.ToString()); }
            if (SortBy != null) { request.AddQueryParameter("sort_by", SortBy.ToString()); }
            request.Resource = GlobalInfraGetDownlinkPortStatisticsForInfraSegmentServiceURL.ToString();
            RestResponse<NSXTPolicyInterfaceStatisticsType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTPolicyInterfaceStatisticsType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Get operation to " + GlobalInfraGetDownlinkPortStatisticsForInfraSegmentServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTGatewayRouteTableInCsvFormatType> GetTier0RoutesCsv(string Tier0Id, string? Cursor = null, string? EdgeId = null, string? EdgePath = null, string? EnforcementPointPath = null, string? IncludedFields = null, string? NetworkPrefix = null, long? PageSize = null, string? RouteSource = null, bool? SortAscending = null, string? SortBy = null)
        {
            if (Tier0Id == null) { throw new System.ArgumentNullException("Tier0Id cannot be null"); }
            StringBuilder GetTier0RoutesCsvServiceURL = new StringBuilder("/infra/tier-0s/{tier-0-id}/routing-table?format=csv");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Get
            };
            GetTier0RoutesCsvServiceURL.Replace("{tier-0-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(Tier0Id, System.Globalization.CultureInfo.InvariantCulture)));
            if (Cursor != null) { request.AddQueryParameter("cursor", Cursor.ToString()); }
            if (EdgeId != null) { request.AddQueryParameter("edge_id", EdgeId.ToString()); }
            if (EdgePath != null) { request.AddQueryParameter("edge_path", EdgePath.ToString()); }
            if (EnforcementPointPath != null) { request.AddQueryParameter("enforcement_point_path", EnforcementPointPath.ToString()); }
            if (IncludedFields != null) { request.AddQueryParameter("included_fields", IncludedFields.ToString()); }
            if (NetworkPrefix != null) { request.AddQueryParameter("network_prefix", NetworkPrefix.ToString()); }
            if (PageSize != null) { request.AddQueryParameter("page_size", PageSize.ToString()); }
            if (RouteSource != null) { request.AddQueryParameter("route_source", RouteSource.ToString()); }
            if (SortAscending != null) { request.AddQueryParameter("sort_ascending", SortAscending.ToString()); }
            if (SortBy != null) { request.AddQueryParameter("sort_by", SortBy.ToString()); }
            request.Resource = GetTier0RoutesCsvServiceURL.ToString();
            RestResponse<NSXTGatewayRouteTableInCsvFormatType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTGatewayRouteTableInCsvFormatType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Get operation to " + GetTier0RoutesCsvServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTIgmpMembershipsInCsvFormatType> GetTier1PolicyIgmpMembershipsInCsvFormat(string Tier1Id, string LocaleServicesId, string? Cursor = null, string? EdgePath = null, string? IncludedFields = null, long? PageSize = null, bool? SortAscending = null, string? SortBy = null)
        {
            if (Tier1Id == null) { throw new System.ArgumentNullException("Tier1Id cannot be null"); }
            if (LocaleServicesId == null) { throw new System.ArgumentNullException("LocaleServicesId cannot be null"); }
            StringBuilder GetTier1PolicyIgmpMembershipsInCsvFormatServiceURL = new StringBuilder("/infra/tier-1s/{tier-1-id}/locale-services/{locale-services-id}/multicast/igmp-memberships?format=csv");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Get
            };
            GetTier1PolicyIgmpMembershipsInCsvFormatServiceURL.Replace("{tier-1-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(Tier1Id, System.Globalization.CultureInfo.InvariantCulture)));
            GetTier1PolicyIgmpMembershipsInCsvFormatServiceURL.Replace("{locale-services-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(LocaleServicesId, System.Globalization.CultureInfo.InvariantCulture)));
            if (Cursor != null) { request.AddQueryParameter("cursor", Cursor.ToString()); }
            if (EdgePath != null) { request.AddQueryParameter("edge_path", EdgePath.ToString()); }
            if (IncludedFields != null) { request.AddQueryParameter("included_fields", IncludedFields.ToString()); }
            if (PageSize != null) { request.AddQueryParameter("page_size", PageSize.ToString()); }
            if (SortAscending != null) { request.AddQueryParameter("sort_ascending", SortAscending.ToString()); }
            if (SortBy != null) { request.AddQueryParameter("sort_by", SortBy.ToString()); }
            request.Resource = GetTier1PolicyIgmpMembershipsInCsvFormatServiceURL.ToString();
            RestResponse<NSXTIgmpMembershipsInCsvFormatType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTIgmpMembershipsInCsvFormatType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Get operation to " + GetTier1PolicyIgmpMembershipsInCsvFormatServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTIgmpMembershipsType> GetTier1PolicyIgmpMemberships(string Tier1Id, string LocaleServicesId, string? Cursor = null, string? EdgePath = null, string? IncludedFields = null, long? PageSize = null, bool? SortAscending = null, string? SortBy = null)
        {
            if (Tier1Id == null) { throw new System.ArgumentNullException("Tier1Id cannot be null"); }
            if (LocaleServicesId == null) { throw new System.ArgumentNullException("LocaleServicesId cannot be null"); }
            StringBuilder GetTier1PolicyIgmpMembershipsServiceURL = new StringBuilder("/infra/tier-1s/{tier-1-id}/locale-services/{locale-services-id}/multicast/igmp-memberships");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Get
            };
            GetTier1PolicyIgmpMembershipsServiceURL.Replace("{tier-1-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(Tier1Id, System.Globalization.CultureInfo.InvariantCulture)));
            GetTier1PolicyIgmpMembershipsServiceURL.Replace("{locale-services-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(LocaleServicesId, System.Globalization.CultureInfo.InvariantCulture)));
            if (Cursor != null) { request.AddQueryParameter("cursor", Cursor.ToString()); }
            if (EdgePath != null) { request.AddQueryParameter("edge_path", EdgePath.ToString()); }
            if (IncludedFields != null) { request.AddQueryParameter("included_fields", IncludedFields.ToString()); }
            if (PageSize != null) { request.AddQueryParameter("page_size", PageSize.ToString()); }
            if (SortAscending != null) { request.AddQueryParameter("sort_ascending", SortAscending.ToString()); }
            if (SortBy != null) { request.AddQueryParameter("sort_by", SortBy.ToString()); }
            request.Resource = GetTier1PolicyIgmpMembershipsServiceURL.ToString();
            RestResponse<NSXTIgmpMembershipsType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTIgmpMembershipsType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Get operation to " + GetTier1PolicyIgmpMembershipsServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTPolicyEdgeClusterInterSiteBgpSummaryType> GlobalGlobalInfraGetPolicyInterSiteBgpSummary(string Tier0Id, string LocaleServicesId, string? Cursor = null, string? EdgePath = null, string? IncludedFields = null, long? PageSize = null, bool? SortAscending = null, string? SortBy = null)
        {
            if (Tier0Id == null) { throw new System.ArgumentNullException("Tier0Id cannot be null"); }
            if (LocaleServicesId == null) { throw new System.ArgumentNullException("LocaleServicesId cannot be null"); }
            StringBuilder GlobalInfraGetPolicyInterSiteBgpSummaryServiceURL = new StringBuilder("/global-infra/tier-0s/{tier-0-id}/locale-services/{locale-services-id}/inter-site/bgp-summary");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Get
            };
            GlobalInfraGetPolicyInterSiteBgpSummaryServiceURL.Replace("{tier-0-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(Tier0Id, System.Globalization.CultureInfo.InvariantCulture)));
            GlobalInfraGetPolicyInterSiteBgpSummaryServiceURL.Replace("{locale-services-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(LocaleServicesId, System.Globalization.CultureInfo.InvariantCulture)));
            if (Cursor != null) { request.AddQueryParameter("cursor", Cursor.ToString()); }
            if (EdgePath != null) { request.AddQueryParameter("edge_path", EdgePath.ToString()); }
            if (IncludedFields != null) { request.AddQueryParameter("included_fields", IncludedFields.ToString()); }
            if (PageSize != null) { request.AddQueryParameter("page_size", PageSize.ToString()); }
            if (SortAscending != null) { request.AddQueryParameter("sort_ascending", SortAscending.ToString()); }
            if (SortBy != null) { request.AddQueryParameter("sort_by", SortBy.ToString()); }
            request.Resource = GlobalInfraGetPolicyInterSiteBgpSummaryServiceURL.ToString();
            RestResponse<NSXTPolicyEdgeClusterInterSiteBgpSummaryType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTPolicyEdgeClusterInterSiteBgpSummaryType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Get operation to " + GlobalInfraGetPolicyInterSiteBgpSummaryServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTPolicyArpProxyTableCsvListResultType> GetDownlinkPortArpProxiesForTier1SegmentInCsv(string Tier1Id, string SegmentId, string? EnforcementPointPath = null, string? Source = null, string? TransportNodeId = null)
        {
            if (Tier1Id == null) { throw new System.ArgumentNullException("Tier1Id cannot be null"); }
            if (SegmentId == null) { throw new System.ArgumentNullException("SegmentId cannot be null"); }
            StringBuilder GetDownlinkPortArpProxiesForTier1SegmentInCsvServiceURL = new StringBuilder("/infra/tier-1s/{tier-1-id}/segments/{segment-id}/arp-proxy?format=csv");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Get
            };
            GetDownlinkPortArpProxiesForTier1SegmentInCsvServiceURL.Replace("{tier-1-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(Tier1Id, System.Globalization.CultureInfo.InvariantCulture)));
            GetDownlinkPortArpProxiesForTier1SegmentInCsvServiceURL.Replace("{segment-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(SegmentId, System.Globalization.CultureInfo.InvariantCulture)));
            if (EnforcementPointPath != null) { request.AddQueryParameter("enforcement_point_path", EnforcementPointPath.ToString()); }
            if (Source != null) { request.AddQueryParameter("source", Source.ToString()); }
            if (TransportNodeId != null) { request.AddQueryParameter("transport_node_id", TransportNodeId.ToString()); }
            request.Resource = GetDownlinkPortArpProxiesForTier1SegmentInCsvServiceURL.ToString();
            RestResponse<NSXTPolicyArpProxyTableCsvListResultType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTPolicyArpProxyTableCsvListResultType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Get operation to " + GetDownlinkPortArpProxiesForTier1SegmentInCsvServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTPolicyArpProxyTableCsvListResultType> GetDownlinkPortArpProxiesForInfraSegmentInCsv(string SegmentId, string? EnforcementPointPath = null, string? Source = null, string? TransportNodeId = null)
        {
            if (SegmentId == null) { throw new System.ArgumentNullException("SegmentId cannot be null"); }
            StringBuilder GetDownlinkPortArpProxiesForInfraSegmentInCsvServiceURL = new StringBuilder("/infra/segments/{segment-id}/arp-proxy?format=csv");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Get
            };
            GetDownlinkPortArpProxiesForInfraSegmentInCsvServiceURL.Replace("{segment-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(SegmentId, System.Globalization.CultureInfo.InvariantCulture)));
            if (EnforcementPointPath != null) { request.AddQueryParameter("enforcement_point_path", EnforcementPointPath.ToString()); }
            if (Source != null) { request.AddQueryParameter("source", Source.ToString()); }
            if (TransportNodeId != null) { request.AddQueryParameter("transport_node_id", TransportNodeId.ToString()); }
            request.Resource = GetDownlinkPortArpProxiesForInfraSegmentInCsvServiceURL.ToString();
            RestResponse<NSXTPolicyArpProxyTableCsvListResultType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTPolicyArpProxyTableCsvListResultType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Get operation to " + GetDownlinkPortArpProxiesForInfraSegmentInCsvServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTSegmentMacAddressListResultType> GetTier1SegmentMacTable(string Tier1Id, string SegmentId, string? Cursor = null, string? EnforcementPointPath = null, string? IncludedFields = null, long? PageSize = null, bool? SortAscending = null, string? SortBy = null, string? Source = null, string? TransportNodeId = null)
        {
            if (Tier1Id == null) { throw new System.ArgumentNullException("Tier1Id cannot be null"); }
            if (SegmentId == null) { throw new System.ArgumentNullException("SegmentId cannot be null"); }
            StringBuilder GetTier1SegmentMacTableServiceURL = new StringBuilder("/infra/tier-1s/{tier-1-id}/segments/{segment-id}/mac-table");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Get
            };
            GetTier1SegmentMacTableServiceURL.Replace("{tier-1-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(Tier1Id, System.Globalization.CultureInfo.InvariantCulture)));
            GetTier1SegmentMacTableServiceURL.Replace("{segment-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(SegmentId, System.Globalization.CultureInfo.InvariantCulture)));
            if (Cursor != null) { request.AddQueryParameter("cursor", Cursor.ToString()); }
            if (EnforcementPointPath != null) { request.AddQueryParameter("enforcement_point_path", EnforcementPointPath.ToString()); }
            if (IncludedFields != null) { request.AddQueryParameter("included_fields", IncludedFields.ToString()); }
            if (PageSize != null) { request.AddQueryParameter("page_size", PageSize.ToString()); }
            if (SortAscending != null) { request.AddQueryParameter("sort_ascending", SortAscending.ToString()); }
            if (SortBy != null) { request.AddQueryParameter("sort_by", SortBy.ToString()); }
            if (Source != null) { request.AddQueryParameter("source", Source.ToString()); }
            if (TransportNodeId != null) { request.AddQueryParameter("transport_node_id", TransportNodeId.ToString()); }
            request.Resource = GetTier1SegmentMacTableServiceURL.ToString();
            RestResponse<NSXTSegmentMacAddressListResultType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTSegmentMacAddressListResultType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Get operation to " + GetTier1SegmentMacTableServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTPolicyArpProxyTableCsvListResultType> GlobalGlobalInfraGetDownlinkPortArpProxiesForInfraSegmentInCsv(string SegmentId, string? EnforcementPointPath = null, string? Source = null, string? TransportNodeId = null)
        {
            if (SegmentId == null) { throw new System.ArgumentNullException("SegmentId cannot be null"); }
            StringBuilder GlobalInfraGetDownlinkPortArpProxiesForInfraSegmentInCsvServiceURL = new StringBuilder("/global-infra/segments/{segment-id}/arp-proxy?format=csv");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Get
            };
            GlobalInfraGetDownlinkPortArpProxiesForInfraSegmentInCsvServiceURL.Replace("{segment-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(SegmentId, System.Globalization.CultureInfo.InvariantCulture)));
            if (EnforcementPointPath != null) { request.AddQueryParameter("enforcement_point_path", EnforcementPointPath.ToString()); }
            if (Source != null) { request.AddQueryParameter("source", Source.ToString()); }
            if (TransportNodeId != null) { request.AddQueryParameter("transport_node_id", TransportNodeId.ToString()); }
            request.Resource = GlobalInfraGetDownlinkPortArpProxiesForInfraSegmentInCsvServiceURL.ToString();
            RestResponse<NSXTPolicyArpProxyTableCsvListResultType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTPolicyArpProxyTableCsvListResultType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Get operation to " + GlobalInfraGetDownlinkPortArpProxiesForInfraSegmentInCsvServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTInterfaceArpTableInCsvFormatType> GetTier1InterfaceArpTableCsv(string Tier1Id, string LocaleServiceId, string InterfaceId, string? Cursor = null, string? EdgePath = null, string? EnforcementPointPath = null, string? HostTransportNodePath = null, string? IncludedFields = null, long? PageSize = null, bool? SortAscending = null, string? SortBy = null)
        {
            if (Tier1Id == null) { throw new System.ArgumentNullException("Tier1Id cannot be null"); }
            if (LocaleServiceId == null) { throw new System.ArgumentNullException("LocaleServiceId cannot be null"); }
            if (InterfaceId == null) { throw new System.ArgumentNullException("InterfaceId cannot be null"); }
            StringBuilder GetTier1InterfaceArpTableCsvServiceURL = new StringBuilder("/infra/tier-1s/{tier-1-id}/locale-services/{locale-service-id}/interfaces/{interface-id}/arp-table?format=csv");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Get
            };
            GetTier1InterfaceArpTableCsvServiceURL.Replace("{tier-1-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(Tier1Id, System.Globalization.CultureInfo.InvariantCulture)));
            GetTier1InterfaceArpTableCsvServiceURL.Replace("{locale-service-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(LocaleServiceId, System.Globalization.CultureInfo.InvariantCulture)));
            GetTier1InterfaceArpTableCsvServiceURL.Replace("{interface-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(InterfaceId, System.Globalization.CultureInfo.InvariantCulture)));
            if (Cursor != null) { request.AddQueryParameter("cursor", Cursor.ToString()); }
            if (EdgePath != null) { request.AddQueryParameter("edge_path", EdgePath.ToString()); }
            if (EnforcementPointPath != null) { request.AddQueryParameter("enforcement_point_path", EnforcementPointPath.ToString()); }
            if (HostTransportNodePath != null) { request.AddQueryParameter("host_transport_node_path", HostTransportNodePath.ToString()); }
            if (IncludedFields != null) { request.AddQueryParameter("included_fields", IncludedFields.ToString()); }
            if (PageSize != null) { request.AddQueryParameter("page_size", PageSize.ToString()); }
            if (SortAscending != null) { request.AddQueryParameter("sort_ascending", SortAscending.ToString()); }
            if (SortBy != null) { request.AddQueryParameter("sort_by", SortBy.ToString()); }
            request.Resource = GetTier1InterfaceArpTableCsvServiceURL.ToString();
            RestResponse<NSXTInterfaceArpTableInCsvFormatType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTInterfaceArpTableInCsvFormatType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Get operation to " + GetTier1InterfaceArpTableCsvServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTTier0GatewayStateType> GlobalGlobalInfraGetTier0State(string Tier0Id, string? Cursor = null, string? EnforcementPointPath = null, string? IncludedFields = null, string? InterfacePath = null, long? PageSize = null, bool? SortAscending = null, string? SortBy = null, string? Type = null)
        {
            if (Tier0Id == null) { throw new System.ArgumentNullException("Tier0Id cannot be null"); }
            StringBuilder GlobalInfraGetTier0StateServiceURL = new StringBuilder("/global-infra/tier-0s/{tier-0-id}/state");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Get
            };
            GlobalInfraGetTier0StateServiceURL.Replace("{tier-0-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(Tier0Id, System.Globalization.CultureInfo.InvariantCulture)));
            if (Cursor != null) { request.AddQueryParameter("cursor", Cursor.ToString()); }
            if (EnforcementPointPath != null) { request.AddQueryParameter("enforcement_point_path", EnforcementPointPath.ToString()); }
            if (IncludedFields != null) { request.AddQueryParameter("included_fields", IncludedFields.ToString()); }
            if (InterfacePath != null) { request.AddQueryParameter("interface_path", InterfacePath.ToString()); }
            if (PageSize != null) { request.AddQueryParameter("page_size", PageSize.ToString()); }
            if (SortAscending != null) { request.AddQueryParameter("sort_ascending", SortAscending.ToString()); }
            if (SortBy != null) { request.AddQueryParameter("sort_by", SortBy.ToString()); }
            if (Type != null) { request.AddQueryParameter("type", Type.ToString()); }
            request.Resource = GlobalInfraGetTier0StateServiceURL.ToString();
            RestResponse<NSXTTier0GatewayStateType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTTier0GatewayStateType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Get operation to " + GlobalInfraGetTier0StateServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTInterfaceArpTableType> GetDownlinkPortArpTableForTier1Segment(string Tier1Id, string SegmentId, string? Cursor = null, string? EdgePath = null, string? EnforcementPointPath = null, string? HostTransportNodePath = null, string? IncludedFields = null, long? PageSize = null, bool? SortAscending = null, string? SortBy = null)
        {
            if (Tier1Id == null) { throw new System.ArgumentNullException("Tier1Id cannot be null"); }
            if (SegmentId == null) { throw new System.ArgumentNullException("SegmentId cannot be null"); }
            StringBuilder GetDownlinkPortArpTableForTier1SegmentServiceURL = new StringBuilder("/infra/tier-1s/{tier-1-id}/segments/{segment-id}/gateway-interface-arp-table");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Get
            };
            GetDownlinkPortArpTableForTier1SegmentServiceURL.Replace("{tier-1-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(Tier1Id, System.Globalization.CultureInfo.InvariantCulture)));
            GetDownlinkPortArpTableForTier1SegmentServiceURL.Replace("{segment-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(SegmentId, System.Globalization.CultureInfo.InvariantCulture)));
            if (Cursor != null) { request.AddQueryParameter("cursor", Cursor.ToString()); }
            if (EdgePath != null) { request.AddQueryParameter("edge_path", EdgePath.ToString()); }
            if (EnforcementPointPath != null) { request.AddQueryParameter("enforcement_point_path", EnforcementPointPath.ToString()); }
            if (HostTransportNodePath != null) { request.AddQueryParameter("host_transport_node_path", HostTransportNodePath.ToString()); }
            if (IncludedFields != null) { request.AddQueryParameter("included_fields", IncludedFields.ToString()); }
            if (PageSize != null) { request.AddQueryParameter("page_size", PageSize.ToString()); }
            if (SortAscending != null) { request.AddQueryParameter("sort_ascending", SortAscending.ToString()); }
            if (SortBy != null) { request.AddQueryParameter("sort_by", SortBy.ToString()); }
            request.Resource = GetDownlinkPortArpTableForTier1SegmentServiceURL.ToString();
            RestResponse<NSXTInterfaceArpTableType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTInterfaceArpTableType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Get operation to " + GetDownlinkPortArpTableForTier1SegmentServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTPolicyArpProxyTableListResultType> GlobalGlobalInfraGetTier0GatewayArpProxies(string Tier0Id, string? Cursor = null, string? EnforcementPointPath = null, string? IncludedFields = null, long? PageSize = null, bool? SortAscending = null, string? SortBy = null, string? Source = null, string? TransportNodeId = null)
        {
            if (Tier0Id == null) { throw new System.ArgumentNullException("Tier0Id cannot be null"); }
            StringBuilder GlobalInfraGetTier0GatewayArpProxiesServiceURL = new StringBuilder("/global-infra/tier-0s/{tier-0-id}/arp-proxies");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Get
            };
            GlobalInfraGetTier0GatewayArpProxiesServiceURL.Replace("{tier-0-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(Tier0Id, System.Globalization.CultureInfo.InvariantCulture)));
            if (Cursor != null) { request.AddQueryParameter("cursor", Cursor.ToString()); }
            if (EnforcementPointPath != null) { request.AddQueryParameter("enforcement_point_path", EnforcementPointPath.ToString()); }
            if (IncludedFields != null) { request.AddQueryParameter("included_fields", IncludedFields.ToString()); }
            if (PageSize != null) { request.AddQueryParameter("page_size", PageSize.ToString()); }
            if (SortAscending != null) { request.AddQueryParameter("sort_ascending", SortAscending.ToString()); }
            if (SortBy != null) { request.AddQueryParameter("sort_by", SortBy.ToString()); }
            if (Source != null) { request.AddQueryParameter("source", Source.ToString()); }
            if (TransportNodeId != null) { request.AddQueryParameter("transport_node_id", TransportNodeId.ToString()); }
            request.Resource = GlobalInfraGetTier0GatewayArpProxiesServiceURL.ToString();
            RestResponse<NSXTPolicyArpProxyTableListResultType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTPolicyArpProxyTableListResultType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Get operation to " + GlobalInfraGetTier0GatewayArpProxiesServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTPolicyTepCsvListResultType> GlobalGlobalInfraGetTier1SegmentTepTableInCsv(string Tier1Id, string SegmentId, string? EnforcementPointPath = null, string? Source = null, string? TransportNodeId = null)
        {
            if (Tier1Id == null) { throw new System.ArgumentNullException("Tier1Id cannot be null"); }
            if (SegmentId == null) { throw new System.ArgumentNullException("SegmentId cannot be null"); }
            StringBuilder GlobalInfraGetTier1SegmentTepTableInCsvServiceURL = new StringBuilder("/global-infra/tier-1s/{tier-1-id}/segments/{segment-id}/tep-table?format=csv");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Get
            };
            GlobalInfraGetTier1SegmentTepTableInCsvServiceURL.Replace("{tier-1-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(Tier1Id, System.Globalization.CultureInfo.InvariantCulture)));
            GlobalInfraGetTier1SegmentTepTableInCsvServiceURL.Replace("{segment-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(SegmentId, System.Globalization.CultureInfo.InvariantCulture)));
            if (EnforcementPointPath != null) { request.AddQueryParameter("enforcement_point_path", EnforcementPointPath.ToString()); }
            if (Source != null) { request.AddQueryParameter("source", Source.ToString()); }
            if (TransportNodeId != null) { request.AddQueryParameter("transport_node_id", TransportNodeId.ToString()); }
            request.Resource = GlobalInfraGetTier1SegmentTepTableInCsvServiceURL.ToString();
            RestResponse<NSXTPolicyTepCsvListResultType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTPolicyTepCsvListResultType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Get operation to " + GlobalInfraGetTier1SegmentTepTableInCsvServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTPolicyArpProxyTableCsvListResultType> GetTier1InterfaceArpProxiesInCsv(string Tier1Id, string LocaleServiceId, string InterfaceId, string? EnforcementPointPath = null, string? Source = null, string? TransportNodeId = null)
        {
            if (Tier1Id == null) { throw new System.ArgumentNullException("Tier1Id cannot be null"); }
            if (LocaleServiceId == null) { throw new System.ArgumentNullException("LocaleServiceId cannot be null"); }
            if (InterfaceId == null) { throw new System.ArgumentNullException("InterfaceId cannot be null"); }
            StringBuilder GetTier1InterfaceArpProxiesInCsvServiceURL = new StringBuilder("/infra/tier-1s/{tier-1-id}/locale-services/{locale-service-id}/interfaces/{interface-id}/arp-proxy?format=csv");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Get
            };
            GetTier1InterfaceArpProxiesInCsvServiceURL.Replace("{tier-1-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(Tier1Id, System.Globalization.CultureInfo.InvariantCulture)));
            GetTier1InterfaceArpProxiesInCsvServiceURL.Replace("{locale-service-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(LocaleServiceId, System.Globalization.CultureInfo.InvariantCulture)));
            GetTier1InterfaceArpProxiesInCsvServiceURL.Replace("{interface-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(InterfaceId, System.Globalization.CultureInfo.InvariantCulture)));
            if (EnforcementPointPath != null) { request.AddQueryParameter("enforcement_point_path", EnforcementPointPath.ToString()); }
            if (Source != null) { request.AddQueryParameter("source", Source.ToString()); }
            if (TransportNodeId != null) { request.AddQueryParameter("transport_node_id", TransportNodeId.ToString()); }
            request.Resource = GetTier1InterfaceArpProxiesInCsvServiceURL.ToString();
            RestResponse<NSXTPolicyArpProxyTableCsvListResultType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTPolicyArpProxyTableCsvListResultType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Get operation to " + GetTier1InterfaceArpProxiesInCsvServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTPolicyTepCsvListResultType> GlobalGlobalInfraGetInfraSegmentTepTableInCsv(string SegmentId, string? EnforcementPointPath = null, string? Source = null, string? TransportNodeId = null)
        {
            if (SegmentId == null) { throw new System.ArgumentNullException("SegmentId cannot be null"); }
            StringBuilder GlobalInfraGetInfraSegmentTepTableInCsvServiceURL = new StringBuilder("/global-infra/segments/{segment-id}/tep-table?format=csv");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Get
            };
            GlobalInfraGetInfraSegmentTepTableInCsvServiceURL.Replace("{segment-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(SegmentId, System.Globalization.CultureInfo.InvariantCulture)));
            if (EnforcementPointPath != null) { request.AddQueryParameter("enforcement_point_path", EnforcementPointPath.ToString()); }
            if (Source != null) { request.AddQueryParameter("source", Source.ToString()); }
            if (TransportNodeId != null) { request.AddQueryParameter("transport_node_id", TransportNodeId.ToString()); }
            request.Resource = GlobalInfraGetInfraSegmentTepTableInCsvServiceURL.ToString();
            RestResponse<NSXTPolicyTepCsvListResultType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTPolicyTepCsvListResultType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Get operation to " + GlobalInfraGetInfraSegmentTepTableInCsvServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTSegmentConfigurationStateType> GlobalGlobalInfraGetInfraSegmentState(string SegmentsId, string? Cursor = null, string? EdgePath = null, string? EnforcementPointPath = null, bool? IncludeMarkForDeleteObjects = null, string? IncludedFields = null, long? PageSize = null, bool? SortAscending = null, string? SortBy = null)
        {
            if (SegmentsId == null) { throw new System.ArgumentNullException("SegmentsId cannot be null"); }
            StringBuilder GlobalInfraGetInfraSegmentStateServiceURL = new StringBuilder("/global-infra/segments/{segments-id}/state");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Get
            };
            GlobalInfraGetInfraSegmentStateServiceURL.Replace("{segments-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(SegmentsId, System.Globalization.CultureInfo.InvariantCulture)));
            if (Cursor != null) { request.AddQueryParameter("cursor", Cursor.ToString()); }
            if (EdgePath != null) { request.AddQueryParameter("edge_path", EdgePath.ToString()); }
            if (EnforcementPointPath != null) { request.AddQueryParameter("enforcement_point_path", EnforcementPointPath.ToString()); }
            if (IncludeMarkForDeleteObjects != null) { request.AddQueryParameter("include_mark_for_delete_objects", IncludeMarkForDeleteObjects.ToString()); }
            if (IncludedFields != null) { request.AddQueryParameter("included_fields", IncludedFields.ToString()); }
            if (PageSize != null) { request.AddQueryParameter("page_size", PageSize.ToString()); }
            if (SortAscending != null) { request.AddQueryParameter("sort_ascending", SortAscending.ToString()); }
            if (SortBy != null) { request.AddQueryParameter("sort_by", SortBy.ToString()); }
            request.Resource = GlobalInfraGetInfraSegmentStateServiceURL.ToString();
            RestResponse<NSXTSegmentConfigurationStateType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTSegmentConfigurationStateType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Get operation to " + GlobalInfraGetInfraSegmentStateServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTPolicyArpProxyTableListResultType> GetTier0InterfaceArpProxies(string Tier0Id, string LocaleServiceId, string InterfaceId, string? Cursor = null, string? EnforcementPointPath = null, string? IncludedFields = null, long? PageSize = null, bool? SortAscending = null, string? SortBy = null, string? Source = null, string? TransportNodeId = null)
        {
            if (Tier0Id == null) { throw new System.ArgumentNullException("Tier0Id cannot be null"); }
            if (LocaleServiceId == null) { throw new System.ArgumentNullException("LocaleServiceId cannot be null"); }
            if (InterfaceId == null) { throw new System.ArgumentNullException("InterfaceId cannot be null"); }
            StringBuilder GetTier0InterfaceArpProxiesServiceURL = new StringBuilder("/infra/tier-0s/{tier-0-id}/locale-services/{locale-service-id}/interfaces/{interface-id}/arp-proxy");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Get
            };
            GetTier0InterfaceArpProxiesServiceURL.Replace("{tier-0-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(Tier0Id, System.Globalization.CultureInfo.InvariantCulture)));
            GetTier0InterfaceArpProxiesServiceURL.Replace("{locale-service-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(LocaleServiceId, System.Globalization.CultureInfo.InvariantCulture)));
            GetTier0InterfaceArpProxiesServiceURL.Replace("{interface-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(InterfaceId, System.Globalization.CultureInfo.InvariantCulture)));
            if (Cursor != null) { request.AddQueryParameter("cursor", Cursor.ToString()); }
            if (EnforcementPointPath != null) { request.AddQueryParameter("enforcement_point_path", EnforcementPointPath.ToString()); }
            if (IncludedFields != null) { request.AddQueryParameter("included_fields", IncludedFields.ToString()); }
            if (PageSize != null) { request.AddQueryParameter("page_size", PageSize.ToString()); }
            if (SortAscending != null) { request.AddQueryParameter("sort_ascending", SortAscending.ToString()); }
            if (SortBy != null) { request.AddQueryParameter("sort_by", SortBy.ToString()); }
            if (Source != null) { request.AddQueryParameter("source", Source.ToString()); }
            if (TransportNodeId != null) { request.AddQueryParameter("transport_node_id", TransportNodeId.ToString()); }
            request.Resource = GetTier0InterfaceArpProxiesServiceURL.ToString();
            RestResponse<NSXTPolicyArpProxyTableListResultType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTPolicyArpProxyTableListResultType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Get operation to " + GetTier0InterfaceArpProxiesServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTRoutingTableListResultType> GlobalGlobalInfraGetTier0ForwardingTable(string Tier0Id, string? Cursor = null, string? EdgeId = null, string? EdgePath = null, string? EnforcementPointPath = null, string? IncludedFields = null, string? NetworkPrefix = null, long? PageSize = null, string? RouteSource = null, bool? SortAscending = null, string? SortBy = null)
        {
            if (Tier0Id == null) { throw new System.ArgumentNullException("Tier0Id cannot be null"); }
            StringBuilder GlobalInfraGetTier0ForwardingTableServiceURL = new StringBuilder("/global-infra/tier-0s/{tier-0-id}/forwarding-table");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Get
            };
            GlobalInfraGetTier0ForwardingTableServiceURL.Replace("{tier-0-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(Tier0Id, System.Globalization.CultureInfo.InvariantCulture)));
            if (Cursor != null) { request.AddQueryParameter("cursor", Cursor.ToString()); }
            if (EdgeId != null) { request.AddQueryParameter("edge_id", EdgeId.ToString()); }
            if (EdgePath != null) { request.AddQueryParameter("edge_path", EdgePath.ToString()); }
            if (EnforcementPointPath != null) { request.AddQueryParameter("enforcement_point_path", EnforcementPointPath.ToString()); }
            if (IncludedFields != null) { request.AddQueryParameter("included_fields", IncludedFields.ToString()); }
            if (NetworkPrefix != null) { request.AddQueryParameter("network_prefix", NetworkPrefix.ToString()); }
            if (PageSize != null) { request.AddQueryParameter("page_size", PageSize.ToString()); }
            if (RouteSource != null) { request.AddQueryParameter("route_source", RouteSource.ToString()); }
            if (SortAscending != null) { request.AddQueryParameter("sort_ascending", SortAscending.ToString()); }
            if (SortBy != null) { request.AddQueryParameter("sort_by", SortBy.ToString()); }
            request.Resource = GlobalInfraGetTier0ForwardingTableServiceURL.ToString();
            RestResponse<NSXTRoutingTableListResultType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTRoutingTableListResultType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Get operation to " + GlobalInfraGetTier0ForwardingTableServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTPolicyArpProxyTableListResultType> GetTier0GatewayArpProxies(string Tier0Id, string? Cursor = null, string? EnforcementPointPath = null, string? IncludedFields = null, long? PageSize = null, bool? SortAscending = null, string? SortBy = null, string? Source = null, string? TransportNodeId = null)
        {
            if (Tier0Id == null) { throw new System.ArgumentNullException("Tier0Id cannot be null"); }
            StringBuilder GetTier0GatewayArpProxiesServiceURL = new StringBuilder("/infra/tier-0s/{tier-0-id}/arp-proxies");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Get
            };
            GetTier0GatewayArpProxiesServiceURL.Replace("{tier-0-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(Tier0Id, System.Globalization.CultureInfo.InvariantCulture)));
            if (Cursor != null) { request.AddQueryParameter("cursor", Cursor.ToString()); }
            if (EnforcementPointPath != null) { request.AddQueryParameter("enforcement_point_path", EnforcementPointPath.ToString()); }
            if (IncludedFields != null) { request.AddQueryParameter("included_fields", IncludedFields.ToString()); }
            if (PageSize != null) { request.AddQueryParameter("page_size", PageSize.ToString()); }
            if (SortAscending != null) { request.AddQueryParameter("sort_ascending", SortAscending.ToString()); }
            if (SortBy != null) { request.AddQueryParameter("sort_by", SortBy.ToString()); }
            if (Source != null) { request.AddQueryParameter("source", Source.ToString()); }
            if (TransportNodeId != null) { request.AddQueryParameter("transport_node_id", TransportNodeId.ToString()); }
            request.Resource = GetTier0GatewayArpProxiesServiceURL.ToString();
            RestResponse<NSXTPolicyArpProxyTableListResultType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTPolicyArpProxyTableListResultType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Get operation to " + GetTier0GatewayArpProxiesServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTPimRpMappingsInCsvFormatType> GetPolicyPimRpMappingsInCsvFormat(string Tier0Id, string LocaleServicesId, string? Cursor = null, string? EdgePath = null, string? IncludedFields = null, long? PageSize = null, bool? SortAscending = null, string? SortBy = null)
        {
            if (Tier0Id == null) { throw new System.ArgumentNullException("Tier0Id cannot be null"); }
            if (LocaleServicesId == null) { throw new System.ArgumentNullException("LocaleServicesId cannot be null"); }
            StringBuilder GetPolicyPimRpMappingsInCsvFormatServiceURL = new StringBuilder("/infra/tier-0s/{tier-0-id}/locale-services/{locale-services-id}/multicast/pim-rp-mappings?format=csv");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Get
            };
            GetPolicyPimRpMappingsInCsvFormatServiceURL.Replace("{tier-0-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(Tier0Id, System.Globalization.CultureInfo.InvariantCulture)));
            GetPolicyPimRpMappingsInCsvFormatServiceURL.Replace("{locale-services-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(LocaleServicesId, System.Globalization.CultureInfo.InvariantCulture)));
            if (Cursor != null) { request.AddQueryParameter("cursor", Cursor.ToString()); }
            if (EdgePath != null) { request.AddQueryParameter("edge_path", EdgePath.ToString()); }
            if (IncludedFields != null) { request.AddQueryParameter("included_fields", IncludedFields.ToString()); }
            if (PageSize != null) { request.AddQueryParameter("page_size", PageSize.ToString()); }
            if (SortAscending != null) { request.AddQueryParameter("sort_ascending", SortAscending.ToString()); }
            if (SortBy != null) { request.AddQueryParameter("sort_by", SortBy.ToString()); }
            request.Resource = GetPolicyPimRpMappingsInCsvFormatServiceURL.ToString();
            RestResponse<NSXTPimRpMappingsInCsvFormatType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTPimRpMappingsInCsvFormatType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Get operation to " + GetPolicyPimRpMappingsInCsvFormatServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTDhcpServerStatisticsType> ReadDhcpServerStats(string ConfigId, string ConnectivityPath, string? Cursor = null, string? EnforcementPointPath = null, bool? IncludeMarkForDeleteObjects = null, string? IncludedFields = null, long? PageSize = null, bool? SortAscending = null, string? SortBy = null)
        {
            if (ConfigId == null) { throw new System.ArgumentNullException("ConfigId cannot be null"); }
            if (ConnectivityPath == null) { throw new System.ArgumentNullException("ConnectivityPath cannot be null"); }
            StringBuilder ReadDhcpServerStatsServiceURL = new StringBuilder("/infra/dhcp-server-configs/{config-id}/stats");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Get
            };
            ReadDhcpServerStatsServiceURL.Replace("{config-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(ConfigId, System.Globalization.CultureInfo.InvariantCulture)));
            if (ConnectivityPath != null) { request.AddQueryParameter("connectivity_path", ConnectivityPath.ToString()); }
            if (Cursor != null) { request.AddQueryParameter("cursor", Cursor.ToString()); }
            if (EnforcementPointPath != null) { request.AddQueryParameter("enforcement_point_path", EnforcementPointPath.ToString()); }
            if (IncludeMarkForDeleteObjects != null) { request.AddQueryParameter("include_mark_for_delete_objects", IncludeMarkForDeleteObjects.ToString()); }
            if (IncludedFields != null) { request.AddQueryParameter("included_fields", IncludedFields.ToString()); }
            if (PageSize != null) { request.AddQueryParameter("page_size", PageSize.ToString()); }
            if (SortAscending != null) { request.AddQueryParameter("sort_ascending", SortAscending.ToString()); }
            if (SortBy != null) { request.AddQueryParameter("sort_by", SortBy.ToString()); }
            request.Resource = ReadDhcpServerStatsServiceURL.ToString();
            RestResponse<NSXTDhcpServerStatisticsType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTDhcpServerStatisticsType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Get operation to " + ReadDhcpServerStatsServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTDhcpServerStateType> ReadDhcpServerState(string ConfigId, string ConnectivityPath, string? Cursor = null, string? EnforcementPointPath = null, bool? IncludeMarkForDeleteObjects = null, string? IncludedFields = null, long? PageSize = null, bool? SortAscending = null, string? SortBy = null)
        {
            if (ConfigId == null) { throw new System.ArgumentNullException("ConfigId cannot be null"); }
            if (ConnectivityPath == null) { throw new System.ArgumentNullException("ConnectivityPath cannot be null"); }
            StringBuilder ReadDhcpServerStateServiceURL = new StringBuilder("/infra/dhcp-server-configs/{config-id}/state");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Get
            };
            ReadDhcpServerStateServiceURL.Replace("{config-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(ConfigId, System.Globalization.CultureInfo.InvariantCulture)));
            if (ConnectivityPath != null) { request.AddQueryParameter("connectivity_path", ConnectivityPath.ToString()); }
            if (Cursor != null) { request.AddQueryParameter("cursor", Cursor.ToString()); }
            if (EnforcementPointPath != null) { request.AddQueryParameter("enforcement_point_path", EnforcementPointPath.ToString()); }
            if (IncludeMarkForDeleteObjects != null) { request.AddQueryParameter("include_mark_for_delete_objects", IncludeMarkForDeleteObjects.ToString()); }
            if (IncludedFields != null) { request.AddQueryParameter("included_fields", IncludedFields.ToString()); }
            if (PageSize != null) { request.AddQueryParameter("page_size", PageSize.ToString()); }
            if (SortAscending != null) { request.AddQueryParameter("sort_ascending", SortAscending.ToString()); }
            if (SortBy != null) { request.AddQueryParameter("sort_by", SortBy.ToString()); }
            request.Resource = ReadDhcpServerStateServiceURL.ToString();
            RestResponse<NSXTDhcpServerStateType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTDhcpServerStateType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Get operation to " + ReadDhcpServerStateServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTDhcpStaticBindingStateType> GlobalGlobalInfraReadInfraSegmentDhcpStaticBindingState(string SegmentId, string BindingId)
        {
            if (SegmentId == null) { throw new System.ArgumentNullException("SegmentId cannot be null"); }
            if (BindingId == null) { throw new System.ArgumentNullException("BindingId cannot be null"); }
            StringBuilder GlobalInfraReadInfraSegmentDhcpStaticBindingStateServiceURL = new StringBuilder("/global-infra/segments/{segment-id}/dhcp-static-bindings/{binding-id}/state");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Get
            };
            GlobalInfraReadInfraSegmentDhcpStaticBindingStateServiceURL.Replace("{segment-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(SegmentId, System.Globalization.CultureInfo.InvariantCulture)));
            GlobalInfraReadInfraSegmentDhcpStaticBindingStateServiceURL.Replace("{binding-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(BindingId, System.Globalization.CultureInfo.InvariantCulture)));
            request.Resource = GlobalInfraReadInfraSegmentDhcpStaticBindingStateServiceURL.ToString();
            RestResponse<NSXTDhcpStaticBindingStateType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTDhcpStaticBindingStateType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Get operation to " + GlobalInfraReadInfraSegmentDhcpStaticBindingStateServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTPolicyInterfaceStatisticsSummaryType> GetDownlinkPortStatisticsSummaryForTier1Segment(string Tier1Id, string SegmentId, string? EnforcementPointPath = null, string? Source = null)
        {
            if (Tier1Id == null) { throw new System.ArgumentNullException("Tier1Id cannot be null"); }
            if (SegmentId == null) { throw new System.ArgumentNullException("SegmentId cannot be null"); }
            StringBuilder GetDownlinkPortStatisticsSummaryForTier1SegmentServiceURL = new StringBuilder("/infra/tier-1s/{tier-1-id}/segments/{segment-id}/gateway-interface-statistics/summary");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Get
            };
            GetDownlinkPortStatisticsSummaryForTier1SegmentServiceURL.Replace("{tier-1-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(Tier1Id, System.Globalization.CultureInfo.InvariantCulture)));
            GetDownlinkPortStatisticsSummaryForTier1SegmentServiceURL.Replace("{segment-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(SegmentId, System.Globalization.CultureInfo.InvariantCulture)));
            if (EnforcementPointPath != null) { request.AddQueryParameter("enforcement_point_path", EnforcementPointPath.ToString()); }
            if (Source != null) { request.AddQueryParameter("source", Source.ToString()); }
            request.Resource = GetDownlinkPortStatisticsSummaryForTier1SegmentServiceURL.ToString();
            RestResponse<NSXTPolicyInterfaceStatisticsSummaryType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTPolicyInterfaceStatisticsSummaryType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Get operation to " + GetDownlinkPortStatisticsSummaryForTier1SegmentServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTPolicyInterfaceStatisticsSummaryType> GetTier1InterfaceStatisticsSummary(string Tier1Id, string LocaleServiceId, string InterfaceId, string? Cursor = null, string? EnforcementPointPath = null, string? IncludedFields = null, long? PageSize = null, bool? SortAscending = null, string? SortBy = null)
        {
            if (Tier1Id == null) { throw new System.ArgumentNullException("Tier1Id cannot be null"); }
            if (LocaleServiceId == null) { throw new System.ArgumentNullException("LocaleServiceId cannot be null"); }
            if (InterfaceId == null) { throw new System.ArgumentNullException("InterfaceId cannot be null"); }
            StringBuilder GetTier1InterfaceStatisticsSummaryServiceURL = new StringBuilder("/infra/tier-1s/{tier-1-id}/locale-services/{locale-service-id}/interfaces/{interface-id}/statistics/summary");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Get
            };
            GetTier1InterfaceStatisticsSummaryServiceURL.Replace("{tier-1-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(Tier1Id, System.Globalization.CultureInfo.InvariantCulture)));
            GetTier1InterfaceStatisticsSummaryServiceURL.Replace("{locale-service-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(LocaleServiceId, System.Globalization.CultureInfo.InvariantCulture)));
            GetTier1InterfaceStatisticsSummaryServiceURL.Replace("{interface-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(InterfaceId, System.Globalization.CultureInfo.InvariantCulture)));
            if (Cursor != null) { request.AddQueryParameter("cursor", Cursor.ToString()); }
            if (EnforcementPointPath != null) { request.AddQueryParameter("enforcement_point_path", EnforcementPointPath.ToString()); }
            if (IncludedFields != null) { request.AddQueryParameter("included_fields", IncludedFields.ToString()); }
            if (PageSize != null) { request.AddQueryParameter("page_size", PageSize.ToString()); }
            if (SortAscending != null) { request.AddQueryParameter("sort_ascending", SortAscending.ToString()); }
            if (SortBy != null) { request.AddQueryParameter("sort_by", SortBy.ToString()); }
            request.Resource = GetTier1InterfaceStatisticsSummaryServiceURL.ToString();
            RestResponse<NSXTPolicyInterfaceStatisticsSummaryType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTPolicyInterfaceStatisticsSummaryType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Get operation to " + GetTier1InterfaceStatisticsSummaryServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTOspfRoutesListResultType> GetOspfRoutes(string Tier0Id, string LocaleServiceId, string? Cursor = null, string? EdgePath = null, string? EnforcementPointPath = null, string? IncludedFields = null, string? NetworkPrefix = null, long? PageSize = null, bool? SortAscending = null, string? SortBy = null)
        {
            if (Tier0Id == null) { throw new System.ArgumentNullException("Tier0Id cannot be null"); }
            if (LocaleServiceId == null) { throw new System.ArgumentNullException("LocaleServiceId cannot be null"); }
            StringBuilder GetOspfRoutesServiceURL = new StringBuilder("/infra/tier-0s/{tier-0-id}/locale-services/{locale-service-id}/ospf/routes");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Get
            };
            GetOspfRoutesServiceURL.Replace("{tier-0-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(Tier0Id, System.Globalization.CultureInfo.InvariantCulture)));
            GetOspfRoutesServiceURL.Replace("{locale-service-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(LocaleServiceId, System.Globalization.CultureInfo.InvariantCulture)));
            if (Cursor != null) { request.AddQueryParameter("cursor", Cursor.ToString()); }
            if (EdgePath != null) { request.AddQueryParameter("edge_path", EdgePath.ToString()); }
            if (EnforcementPointPath != null) { request.AddQueryParameter("enforcement_point_path", EnforcementPointPath.ToString()); }
            if (IncludedFields != null) { request.AddQueryParameter("included_fields", IncludedFields.ToString()); }
            if (NetworkPrefix != null) { request.AddQueryParameter("network_prefix", NetworkPrefix.ToString()); }
            if (PageSize != null) { request.AddQueryParameter("page_size", PageSize.ToString()); }
            if (SortAscending != null) { request.AddQueryParameter("sort_ascending", SortAscending.ToString()); }
            if (SortBy != null) { request.AddQueryParameter("sort_by", SortBy.ToString()); }
            request.Resource = GetOspfRoutesServiceURL.ToString();
            RestResponse<NSXTOspfRoutesListResultType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTOspfRoutesListResultType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Get operation to " + GetOspfRoutesServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTPolicyInterfaceStatisticsSummaryType> GlobalGlobalInfraGetTier1InterfaceStatisticsSummary(string Tier1Id, string LocaleServiceId, string InterfaceId, string? Cursor = null, string? EnforcementPointPath = null, string? IncludedFields = null, long? PageSize = null, bool? SortAscending = null, string? SortBy = null)
        {
            if (Tier1Id == null) { throw new System.ArgumentNullException("Tier1Id cannot be null"); }
            if (LocaleServiceId == null) { throw new System.ArgumentNullException("LocaleServiceId cannot be null"); }
            if (InterfaceId == null) { throw new System.ArgumentNullException("InterfaceId cannot be null"); }
            StringBuilder GlobalInfraGetTier1InterfaceStatisticsSummaryServiceURL = new StringBuilder("/global-infra/tier-1s/{tier-1-id}/locale-services/{locale-service-id}/interfaces/{interface-id}/statistics/summary");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Get
            };
            GlobalInfraGetTier1InterfaceStatisticsSummaryServiceURL.Replace("{tier-1-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(Tier1Id, System.Globalization.CultureInfo.InvariantCulture)));
            GlobalInfraGetTier1InterfaceStatisticsSummaryServiceURL.Replace("{locale-service-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(LocaleServiceId, System.Globalization.CultureInfo.InvariantCulture)));
            GlobalInfraGetTier1InterfaceStatisticsSummaryServiceURL.Replace("{interface-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(InterfaceId, System.Globalization.CultureInfo.InvariantCulture)));
            if (Cursor != null) { request.AddQueryParameter("cursor", Cursor.ToString()); }
            if (EnforcementPointPath != null) { request.AddQueryParameter("enforcement_point_path", EnforcementPointPath.ToString()); }
            if (IncludedFields != null) { request.AddQueryParameter("included_fields", IncludedFields.ToString()); }
            if (PageSize != null) { request.AddQueryParameter("page_size", PageSize.ToString()); }
            if (SortAscending != null) { request.AddQueryParameter("sort_ascending", SortAscending.ToString()); }
            if (SortBy != null) { request.AddQueryParameter("sort_by", SortBy.ToString()); }
            request.Resource = GlobalInfraGetTier1InterfaceStatisticsSummaryServiceURL.ToString();
            RestResponse<NSXTPolicyInterfaceStatisticsSummaryType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTPolicyInterfaceStatisticsSummaryType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Get operation to " + GlobalInfraGetTier1InterfaceStatisticsSummaryServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTTier0GatewayStateType> GetTier0State(string Tier0Id, string? Cursor = null, string? EnforcementPointPath = null, string? IncludedFields = null, string? InterfacePath = null, long? PageSize = null, bool? SortAscending = null, string? SortBy = null, string? Type = null)
        {
            if (Tier0Id == null) { throw new System.ArgumentNullException("Tier0Id cannot be null"); }
            StringBuilder GetTier0StateServiceURL = new StringBuilder("/infra/tier-0s/{tier-0-id}/state");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Get
            };
            GetTier0StateServiceURL.Replace("{tier-0-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(Tier0Id, System.Globalization.CultureInfo.InvariantCulture)));
            if (Cursor != null) { request.AddQueryParameter("cursor", Cursor.ToString()); }
            if (EnforcementPointPath != null) { request.AddQueryParameter("enforcement_point_path", EnforcementPointPath.ToString()); }
            if (IncludedFields != null) { request.AddQueryParameter("included_fields", IncludedFields.ToString()); }
            if (InterfacePath != null) { request.AddQueryParameter("interface_path", InterfacePath.ToString()); }
            if (PageSize != null) { request.AddQueryParameter("page_size", PageSize.ToString()); }
            if (SortAscending != null) { request.AddQueryParameter("sort_ascending", SortAscending.ToString()); }
            if (SortBy != null) { request.AddQueryParameter("sort_by", SortBy.ToString()); }
            if (Type != null) { request.AddQueryParameter("type", Type.ToString()); }
            request.Resource = GetTier0StateServiceURL.ToString();
            RestResponse<NSXTTier0GatewayStateType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTTier0GatewayStateType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Get operation to " + GetTier0StateServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTSegmentPortStatusType> GetInfraSegmentPortStatus(string SegmentsId, string PortId, string? Cursor = null, string? EdgePath = null, string? EnforcementPointPath = null, bool? IncludeMarkForDeleteObjects = null, string? IncludedFields = null, long? PageSize = null, bool? SortAscending = null, string? SortBy = null)
        {
            if (SegmentsId == null) { throw new System.ArgumentNullException("SegmentsId cannot be null"); }
            if (PortId == null) { throw new System.ArgumentNullException("PortId cannot be null"); }
            StringBuilder GetInfraSegmentPortStatusServiceURL = new StringBuilder("/infra/segments/{segments-id}/ports/{port-id}/status");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Get
            };
            GetInfraSegmentPortStatusServiceURL.Replace("{segments-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(SegmentsId, System.Globalization.CultureInfo.InvariantCulture)));
            GetInfraSegmentPortStatusServiceURL.Replace("{port-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(PortId, System.Globalization.CultureInfo.InvariantCulture)));
            if (Cursor != null) { request.AddQueryParameter("cursor", Cursor.ToString()); }
            if (EdgePath != null) { request.AddQueryParameter("edge_path", EdgePath.ToString()); }
            if (EnforcementPointPath != null) { request.AddQueryParameter("enforcement_point_path", EnforcementPointPath.ToString()); }
            if (IncludeMarkForDeleteObjects != null) { request.AddQueryParameter("include_mark_for_delete_objects", IncludeMarkForDeleteObjects.ToString()); }
            if (IncludedFields != null) { request.AddQueryParameter("included_fields", IncludedFields.ToString()); }
            if (PageSize != null) { request.AddQueryParameter("page_size", PageSize.ToString()); }
            if (SortAscending != null) { request.AddQueryParameter("sort_ascending", SortAscending.ToString()); }
            if (SortBy != null) { request.AddQueryParameter("sort_by", SortBy.ToString()); }
            request.Resource = GetInfraSegmentPortStatusServiceURL.ToString();
            RestResponse<NSXTSegmentPortStatusType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTSegmentPortStatusType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Get operation to " + GetInfraSegmentPortStatusServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTGatewayRouteTableInCsvFormatType> GlobalGlobalInfraGetTier0ForwardingTableCsv(string Tier0Id, string? Cursor = null, string? EdgeId = null, string? EdgePath = null, string? EnforcementPointPath = null, string? IncludedFields = null, string? NetworkPrefix = null, long? PageSize = null, string? RouteSource = null, bool? SortAscending = null, string? SortBy = null)
        {
            if (Tier0Id == null) { throw new System.ArgumentNullException("Tier0Id cannot be null"); }
            StringBuilder GlobalInfraGetTier0ForwardingTableCsvServiceURL = new StringBuilder("/global-infra/tier-0s/{tier-0-id}/forwarding-table?format=csv");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Get
            };
            GlobalInfraGetTier0ForwardingTableCsvServiceURL.Replace("{tier-0-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(Tier0Id, System.Globalization.CultureInfo.InvariantCulture)));
            if (Cursor != null) { request.AddQueryParameter("cursor", Cursor.ToString()); }
            if (EdgeId != null) { request.AddQueryParameter("edge_id", EdgeId.ToString()); }
            if (EdgePath != null) { request.AddQueryParameter("edge_path", EdgePath.ToString()); }
            if (EnforcementPointPath != null) { request.AddQueryParameter("enforcement_point_path", EnforcementPointPath.ToString()); }
            if (IncludedFields != null) { request.AddQueryParameter("included_fields", IncludedFields.ToString()); }
            if (NetworkPrefix != null) { request.AddQueryParameter("network_prefix", NetworkPrefix.ToString()); }
            if (PageSize != null) { request.AddQueryParameter("page_size", PageSize.ToString()); }
            if (RouteSource != null) { request.AddQueryParameter("route_source", RouteSource.ToString()); }
            if (SortAscending != null) { request.AddQueryParameter("sort_ascending", SortAscending.ToString()); }
            if (SortBy != null) { request.AddQueryParameter("sort_by", SortBy.ToString()); }
            request.Resource = GlobalInfraGetTier0ForwardingTableCsvServiceURL.ToString();
            RestResponse<NSXTGatewayRouteTableInCsvFormatType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTGatewayRouteTableInCsvFormatType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Get operation to " + GlobalInfraGetTier0ForwardingTableCsvServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTInterfaceDADStateType> GlobalGlobalInfraGetTier0InterfaceDadstate(string Tier0Id, string LocaleServiceId, string InterfaceId, string? EnforcementPointPath = null)
        {
            if (Tier0Id == null) { throw new System.ArgumentNullException("Tier0Id cannot be null"); }
            if (LocaleServiceId == null) { throw new System.ArgumentNullException("LocaleServiceId cannot be null"); }
            if (InterfaceId == null) { throw new System.ArgumentNullException("InterfaceId cannot be null"); }
            StringBuilder GlobalInfraGetTier0InterfaceDadstateServiceURL = new StringBuilder("/global-infra/tier-0s/{tier-0-id}/locale-services/{locale-service-id}/interfaces/{interface-id}/dad-state");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Get
            };
            GlobalInfraGetTier0InterfaceDadstateServiceURL.Replace("{tier-0-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(Tier0Id, System.Globalization.CultureInfo.InvariantCulture)));
            GlobalInfraGetTier0InterfaceDadstateServiceURL.Replace("{locale-service-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(LocaleServiceId, System.Globalization.CultureInfo.InvariantCulture)));
            GlobalInfraGetTier0InterfaceDadstateServiceURL.Replace("{interface-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(InterfaceId, System.Globalization.CultureInfo.InvariantCulture)));
            if (EnforcementPointPath != null) { request.AddQueryParameter("enforcement_point_path", EnforcementPointPath.ToString()); }
            request.Resource = GlobalInfraGetTier0InterfaceDadstateServiceURL.ToString();
            RestResponse<NSXTInterfaceDADStateType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTInterfaceDADStateType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Get operation to " + GlobalInfraGetTier0InterfaceDadstateServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTDhcpLeasesResultType> GlobalGlobalInfraReadDhcpServerLeases(string ConfigId, string ConnectivityPath, string? Address = null, string? Cursor = null, string? EnforcementPointPath = null, bool? IncludeMarkForDeleteObjects = null, string? IncludedFields = null, long? PageSize = null, string? SegmentPath = null, bool? SortAscending = null, string? SortBy = null, string? Source = null)
        {
            if (ConfigId == null) { throw new System.ArgumentNullException("ConfigId cannot be null"); }
            if (ConnectivityPath == null) { throw new System.ArgumentNullException("ConnectivityPath cannot be null"); }
            StringBuilder GlobalInfraReadDhcpServerLeasesServiceURL = new StringBuilder("/global-infra/dhcp-server-configs/{config-id}/leases");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Get
            };
            GlobalInfraReadDhcpServerLeasesServiceURL.Replace("{config-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(ConfigId, System.Globalization.CultureInfo.InvariantCulture)));
            if (Address != null) { request.AddQueryParameter("address", Address.ToString()); }
            if (ConnectivityPath != null) { request.AddQueryParameter("connectivity_path", ConnectivityPath.ToString()); }
            if (Cursor != null) { request.AddQueryParameter("cursor", Cursor.ToString()); }
            if (EnforcementPointPath != null) { request.AddQueryParameter("enforcement_point_path", EnforcementPointPath.ToString()); }
            if (IncludeMarkForDeleteObjects != null) { request.AddQueryParameter("include_mark_for_delete_objects", IncludeMarkForDeleteObjects.ToString()); }
            if (IncludedFields != null) { request.AddQueryParameter("included_fields", IncludedFields.ToString()); }
            if (PageSize != null) { request.AddQueryParameter("page_size", PageSize.ToString()); }
            if (SegmentPath != null) { request.AddQueryParameter("segment_path", SegmentPath.ToString()); }
            if (SortAscending != null) { request.AddQueryParameter("sort_ascending", SortAscending.ToString()); }
            if (SortBy != null) { request.AddQueryParameter("sort_by", SortBy.ToString()); }
            if (Source != null) { request.AddQueryParameter("source", Source.ToString()); }
            request.Resource = GlobalInfraReadDhcpServerLeasesServiceURL.ToString();
            RestResponse<NSXTDhcpLeasesResultType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTDhcpLeasesResultType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Get operation to " + GlobalInfraReadDhcpServerLeasesServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTInterfaceArpTableInCsvFormatType> GlobalGlobalInfraGetTier1RouterLinkArpTableCsv(string Tier1Id, string? Cursor = null, string? EdgePath = null, string? EnforcementPointPath = null, string? HostTransportNodePath = null, string? IncludedFields = null, long? PageSize = null, bool? SortAscending = null, string? SortBy = null)
        {
            if (Tier1Id == null) { throw new System.ArgumentNullException("Tier1Id cannot be null"); }
            StringBuilder GlobalInfraGetTier1RouterLinkArpTableCsvServiceURL = new StringBuilder("/global-infra/tier-1s/{tier-1-id}/tier-0-interface/arp-table?format=csv");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Get
            };
            GlobalInfraGetTier1RouterLinkArpTableCsvServiceURL.Replace("{tier-1-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(Tier1Id, System.Globalization.CultureInfo.InvariantCulture)));
            if (Cursor != null) { request.AddQueryParameter("cursor", Cursor.ToString()); }
            if (EdgePath != null) { request.AddQueryParameter("edge_path", EdgePath.ToString()); }
            if (EnforcementPointPath != null) { request.AddQueryParameter("enforcement_point_path", EnforcementPointPath.ToString()); }
            if (HostTransportNodePath != null) { request.AddQueryParameter("host_transport_node_path", HostTransportNodePath.ToString()); }
            if (IncludedFields != null) { request.AddQueryParameter("included_fields", IncludedFields.ToString()); }
            if (PageSize != null) { request.AddQueryParameter("page_size", PageSize.ToString()); }
            if (SortAscending != null) { request.AddQueryParameter("sort_ascending", SortAscending.ToString()); }
            if (SortBy != null) { request.AddQueryParameter("sort_by", SortBy.ToString()); }
            request.Resource = GlobalInfraGetTier1RouterLinkArpTableCsvServiceURL.ToString();
            RestResponse<NSXTInterfaceArpTableInCsvFormatType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTInterfaceArpTableInCsvFormatType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Get operation to " + GlobalInfraGetTier1RouterLinkArpTableCsvServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTPolicyArpProxyTableCsvListResultType> GlobalGlobalInfraGetTier1InterfaceArpProxiesInCsv(string Tier1Id, string LocaleServiceId, string InterfaceId, string? EnforcementPointPath = null, string? Source = null, string? TransportNodeId = null)
        {
            if (Tier1Id == null) { throw new System.ArgumentNullException("Tier1Id cannot be null"); }
            if (LocaleServiceId == null) { throw new System.ArgumentNullException("LocaleServiceId cannot be null"); }
            if (InterfaceId == null) { throw new System.ArgumentNullException("InterfaceId cannot be null"); }
            StringBuilder GlobalInfraGetTier1InterfaceArpProxiesInCsvServiceURL = new StringBuilder("/global-infra/tier-1s/{tier-1-id}/locale-services/{locale-service-id}/interfaces/{interface-id}/arp-proxy?format=csv");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Get
            };
            GlobalInfraGetTier1InterfaceArpProxiesInCsvServiceURL.Replace("{tier-1-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(Tier1Id, System.Globalization.CultureInfo.InvariantCulture)));
            GlobalInfraGetTier1InterfaceArpProxiesInCsvServiceURL.Replace("{locale-service-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(LocaleServiceId, System.Globalization.CultureInfo.InvariantCulture)));
            GlobalInfraGetTier1InterfaceArpProxiesInCsvServiceURL.Replace("{interface-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(InterfaceId, System.Globalization.CultureInfo.InvariantCulture)));
            if (EnforcementPointPath != null) { request.AddQueryParameter("enforcement_point_path", EnforcementPointPath.ToString()); }
            if (Source != null) { request.AddQueryParameter("source", Source.ToString()); }
            if (TransportNodeId != null) { request.AddQueryParameter("transport_node_id", TransportNodeId.ToString()); }
            request.Resource = GlobalInfraGetTier1InterfaceArpProxiesInCsvServiceURL.ToString();
            RestResponse<NSXTPolicyArpProxyTableCsvListResultType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTPolicyArpProxyTableCsvListResultType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Get operation to " + GlobalInfraGetTier1InterfaceArpProxiesInCsvServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTSegmentPortStatisticsType> GetInfraSegmentPortStatistics(string SegmentsId, string PortId, string? Cursor = null, string? EdgePath = null, string? EnforcementPointPath = null, bool? IncludeMarkForDeleteObjects = null, string? IncludedFields = null, long? PageSize = null, bool? SortAscending = null, string? SortBy = null)
        {
            if (SegmentsId == null) { throw new System.ArgumentNullException("SegmentsId cannot be null"); }
            if (PortId == null) { throw new System.ArgumentNullException("PortId cannot be null"); }
            StringBuilder GetInfraSegmentPortStatisticsServiceURL = new StringBuilder("/infra/segments/{segments-id}/ports/{port-id}/statistics");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Get
            };
            GetInfraSegmentPortStatisticsServiceURL.Replace("{segments-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(SegmentsId, System.Globalization.CultureInfo.InvariantCulture)));
            GetInfraSegmentPortStatisticsServiceURL.Replace("{port-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(PortId, System.Globalization.CultureInfo.InvariantCulture)));
            if (Cursor != null) { request.AddQueryParameter("cursor", Cursor.ToString()); }
            if (EdgePath != null) { request.AddQueryParameter("edge_path", EdgePath.ToString()); }
            if (EnforcementPointPath != null) { request.AddQueryParameter("enforcement_point_path", EnforcementPointPath.ToString()); }
            if (IncludeMarkForDeleteObjects != null) { request.AddQueryParameter("include_mark_for_delete_objects", IncludeMarkForDeleteObjects.ToString()); }
            if (IncludedFields != null) { request.AddQueryParameter("included_fields", IncludedFields.ToString()); }
            if (PageSize != null) { request.AddQueryParameter("page_size", PageSize.ToString()); }
            if (SortAscending != null) { request.AddQueryParameter("sort_ascending", SortAscending.ToString()); }
            if (SortBy != null) { request.AddQueryParameter("sort_by", SortBy.ToString()); }
            request.Resource = GetInfraSegmentPortStatisticsServiceURL.ToString();
            RestResponse<NSXTSegmentPortStatisticsType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTSegmentPortStatisticsType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Get operation to " + GetInfraSegmentPortStatisticsServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTMacAddressCsvListResultType> GlobalGlobalInfraGetInfraSegmentMacTableInCsv(string SegmentId, string? EnforcementPointPath = null, string? Source = null, string? TransportNodeId = null)
        {
            if (SegmentId == null) { throw new System.ArgumentNullException("SegmentId cannot be null"); }
            StringBuilder GlobalInfraGetInfraSegmentMacTableInCsvServiceURL = new StringBuilder("/global-infra/segments/{segment-id}/mac-table?format=csv");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Get
            };
            GlobalInfraGetInfraSegmentMacTableInCsvServiceURL.Replace("{segment-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(SegmentId, System.Globalization.CultureInfo.InvariantCulture)));
            if (EnforcementPointPath != null) { request.AddQueryParameter("enforcement_point_path", EnforcementPointPath.ToString()); }
            if (Source != null) { request.AddQueryParameter("source", Source.ToString()); }
            if (TransportNodeId != null) { request.AddQueryParameter("transport_node_id", TransportNodeId.ToString()); }
            request.Resource = GlobalInfraGetInfraSegmentMacTableInCsvServiceURL.ToString();
            RestResponse<NSXTMacAddressCsvListResultType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTMacAddressCsvListResultType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Get operation to " + GlobalInfraGetInfraSegmentMacTableInCsvServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTPolicyArpProxyTableListResultType> GlobalGlobalInfraGetTier0ArpProxies(string Tier0Id, string LocaleServiceId, string? Cursor = null, string? EnforcementPointPath = null, string? IncludedFields = null, long? PageSize = null, bool? SortAscending = null, string? SortBy = null, string? Source = null, string? TransportNodeId = null)
        {
            if (Tier0Id == null) { throw new System.ArgumentNullException("Tier0Id cannot be null"); }
            if (LocaleServiceId == null) { throw new System.ArgumentNullException("LocaleServiceId cannot be null"); }
            StringBuilder GlobalInfraGetTier0ArpProxiesServiceURL = new StringBuilder("/global-infra/tier-0s/{tier-0-id}/locale-services/{locale-service-id}/arp-proxies");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Get
            };
            GlobalInfraGetTier0ArpProxiesServiceURL.Replace("{tier-0-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(Tier0Id, System.Globalization.CultureInfo.InvariantCulture)));
            GlobalInfraGetTier0ArpProxiesServiceURL.Replace("{locale-service-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(LocaleServiceId, System.Globalization.CultureInfo.InvariantCulture)));
            if (Cursor != null) { request.AddQueryParameter("cursor", Cursor.ToString()); }
            if (EnforcementPointPath != null) { request.AddQueryParameter("enforcement_point_path", EnforcementPointPath.ToString()); }
            if (IncludedFields != null) { request.AddQueryParameter("included_fields", IncludedFields.ToString()); }
            if (PageSize != null) { request.AddQueryParameter("page_size", PageSize.ToString()); }
            if (SortAscending != null) { request.AddQueryParameter("sort_ascending", SortAscending.ToString()); }
            if (SortBy != null) { request.AddQueryParameter("sort_by", SortBy.ToString()); }
            if (Source != null) { request.AddQueryParameter("source", Source.ToString()); }
            if (TransportNodeId != null) { request.AddQueryParameter("transport_node_id", TransportNodeId.ToString()); }
            request.Resource = GlobalInfraGetTier0ArpProxiesServiceURL.ToString();
            RestResponse<NSXTPolicyArpProxyTableListResultType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTPolicyArpProxyTableListResultType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Get operation to " + GlobalInfraGetTier0ArpProxiesServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTTier1GatewayStateType> GetTier1State(string Tier1Id, string? Cursor = null, string? EnforcementPointPath = null, string? IncludedFields = null, string? InterfacePath = null, long? PageSize = null, bool? SortAscending = null, string? SortBy = null, string? Type = null)
        {
            if (Tier1Id == null) { throw new System.ArgumentNullException("Tier1Id cannot be null"); }
            StringBuilder GetTier1StateServiceURL = new StringBuilder("/infra/tier-1s/{tier-1-id}/state");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Get
            };
            GetTier1StateServiceURL.Replace("{tier-1-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(Tier1Id, System.Globalization.CultureInfo.InvariantCulture)));
            if (Cursor != null) { request.AddQueryParameter("cursor", Cursor.ToString()); }
            if (EnforcementPointPath != null) { request.AddQueryParameter("enforcement_point_path", EnforcementPointPath.ToString()); }
            if (IncludedFields != null) { request.AddQueryParameter("included_fields", IncludedFields.ToString()); }
            if (InterfacePath != null) { request.AddQueryParameter("interface_path", InterfacePath.ToString()); }
            if (PageSize != null) { request.AddQueryParameter("page_size", PageSize.ToString()); }
            if (SortAscending != null) { request.AddQueryParameter("sort_ascending", SortAscending.ToString()); }
            if (SortBy != null) { request.AddQueryParameter("sort_by", SortBy.ToString()); }
            if (Type != null) { request.AddQueryParameter("type", Type.ToString()); }
            request.Resource = GetTier1StateServiceURL.ToString();
            RestResponse<NSXTTier1GatewayStateType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTTier1GatewayStateType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Get operation to " + GetTier1StateServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTDhcpLeasesResultType> ReadDhcpServerLeases(string ConfigId, string ConnectivityPath, string? Address = null, string? Cursor = null, string? EnforcementPointPath = null, bool? IncludeMarkForDeleteObjects = null, string? IncludedFields = null, long? PageSize = null, string? SegmentPath = null, bool? SortAscending = null, string? SortBy = null, string? Source = null)
        {
            if (ConfigId == null) { throw new System.ArgumentNullException("ConfigId cannot be null"); }
            if (ConnectivityPath == null) { throw new System.ArgumentNullException("ConnectivityPath cannot be null"); }
            StringBuilder ReadDhcpServerLeasesServiceURL = new StringBuilder("/infra/dhcp-server-configs/{config-id}/leases");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Get
            };
            ReadDhcpServerLeasesServiceURL.Replace("{config-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(ConfigId, System.Globalization.CultureInfo.InvariantCulture)));
            if (Address != null) { request.AddQueryParameter("address", Address.ToString()); }
            if (ConnectivityPath != null) { request.AddQueryParameter("connectivity_path", ConnectivityPath.ToString()); }
            if (Cursor != null) { request.AddQueryParameter("cursor", Cursor.ToString()); }
            if (EnforcementPointPath != null) { request.AddQueryParameter("enforcement_point_path", EnforcementPointPath.ToString()); }
            if (IncludeMarkForDeleteObjects != null) { request.AddQueryParameter("include_mark_for_delete_objects", IncludeMarkForDeleteObjects.ToString()); }
            if (IncludedFields != null) { request.AddQueryParameter("included_fields", IncludedFields.ToString()); }
            if (PageSize != null) { request.AddQueryParameter("page_size", PageSize.ToString()); }
            if (SegmentPath != null) { request.AddQueryParameter("segment_path", SegmentPath.ToString()); }
            if (SortAscending != null) { request.AddQueryParameter("sort_ascending", SortAscending.ToString()); }
            if (SortBy != null) { request.AddQueryParameter("sort_by", SortBy.ToString()); }
            if (Source != null) { request.AddQueryParameter("source", Source.ToString()); }
            request.Resource = ReadDhcpServerLeasesServiceURL.ToString();
            RestResponse<NSXTDhcpLeasesResultType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTDhcpLeasesResultType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Get operation to " + ReadDhcpServerLeasesServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTMacAddressCsvListResultType> GetTier1SegmentMacTableInCsv(string Tier1Id, string SegmentId, string? EnforcementPointPath = null, string? Source = null, string? TransportNodeId = null)
        {
            if (Tier1Id == null) { throw new System.ArgumentNullException("Tier1Id cannot be null"); }
            if (SegmentId == null) { throw new System.ArgumentNullException("SegmentId cannot be null"); }
            StringBuilder GetTier1SegmentMacTableInCsvServiceURL = new StringBuilder("/infra/tier-1s/{tier-1-id}/segments/{segment-id}/mac-table?format=csv");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Get
            };
            GetTier1SegmentMacTableInCsvServiceURL.Replace("{tier-1-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(Tier1Id, System.Globalization.CultureInfo.InvariantCulture)));
            GetTier1SegmentMacTableInCsvServiceURL.Replace("{segment-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(SegmentId, System.Globalization.CultureInfo.InvariantCulture)));
            if (EnforcementPointPath != null) { request.AddQueryParameter("enforcement_point_path", EnforcementPointPath.ToString()); }
            if (Source != null) { request.AddQueryParameter("source", Source.ToString()); }
            if (TransportNodeId != null) { request.AddQueryParameter("transport_node_id", TransportNodeId.ToString()); }
            request.Resource = GetTier1SegmentMacTableInCsvServiceURL.ToString();
            RestResponse<NSXTMacAddressCsvListResultType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTMacAddressCsvListResultType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Get operation to " + GetTier1SegmentMacTableInCsvServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTSegmentPortMacAddressListResultType> GlobalGlobalInfraGetTier1SegmentPortMacTable(string Tier1Id, string SegmentId, string PortId, string? Cursor = null, string? EnforcementPointPath = null, string? IncludedFields = null, long? PageSize = null, bool? SortAscending = null, string? SortBy = null, string? Source = null, string? TransportNodeId = null)
        {
            if (Tier1Id == null) { throw new System.ArgumentNullException("Tier1Id cannot be null"); }
            if (SegmentId == null) { throw new System.ArgumentNullException("SegmentId cannot be null"); }
            if (PortId == null) { throw new System.ArgumentNullException("PortId cannot be null"); }
            StringBuilder GlobalInfraGetTier1SegmentPortMacTableServiceURL = new StringBuilder("/global-infra/tier-1s/{tier-1-id}/segments/{segment-id}/ports/{port-id}/mac-table");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Get
            };
            GlobalInfraGetTier1SegmentPortMacTableServiceURL.Replace("{tier-1-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(Tier1Id, System.Globalization.CultureInfo.InvariantCulture)));
            GlobalInfraGetTier1SegmentPortMacTableServiceURL.Replace("{segment-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(SegmentId, System.Globalization.CultureInfo.InvariantCulture)));
            GlobalInfraGetTier1SegmentPortMacTableServiceURL.Replace("{port-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(PortId, System.Globalization.CultureInfo.InvariantCulture)));
            if (Cursor != null) { request.AddQueryParameter("cursor", Cursor.ToString()); }
            if (EnforcementPointPath != null) { request.AddQueryParameter("enforcement_point_path", EnforcementPointPath.ToString()); }
            if (IncludedFields != null) { request.AddQueryParameter("included_fields", IncludedFields.ToString()); }
            if (PageSize != null) { request.AddQueryParameter("page_size", PageSize.ToString()); }
            if (SortAscending != null) { request.AddQueryParameter("sort_ascending", SortAscending.ToString()); }
            if (SortBy != null) { request.AddQueryParameter("sort_by", SortBy.ToString()); }
            if (Source != null) { request.AddQueryParameter("source", Source.ToString()); }
            if (TransportNodeId != null) { request.AddQueryParameter("transport_node_id", TransportNodeId.ToString()); }
            request.Resource = GlobalInfraGetTier1SegmentPortMacTableServiceURL.ToString();
            RestResponse<NSXTSegmentPortMacAddressListResultType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTSegmentPortMacAddressListResultType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Get operation to " + GlobalInfraGetTier1SegmentPortMacTableServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTSegmentL2ForwarderSiteSpanInfoType> GlobalGlobalInfraGetSegmentCsSpanInfo(string Tier1Id, string SegmentId, string? Cursor = null, string? EdgePath = null, string? EnforcementPointPath = null, bool? IncludeMarkForDeleteObjects = null, string? IncludedFields = null, long? PageSize = null, bool? SortAscending = null, string? SortBy = null)
        {
            if (Tier1Id == null) { throw new System.ArgumentNullException("Tier1Id cannot be null"); }
            if (SegmentId == null) { throw new System.ArgumentNullException("SegmentId cannot be null"); }
            StringBuilder GlobalInfraGetSegmentCsSpanInfoServiceURL = new StringBuilder("/global-infra/tier-1s/{tier-1-id}/segments/{segment-id}/inter-site-forwarder/site-span-info");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Get
            };
            GlobalInfraGetSegmentCsSpanInfoServiceURL.Replace("{tier-1-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(Tier1Id, System.Globalization.CultureInfo.InvariantCulture)));
            GlobalInfraGetSegmentCsSpanInfoServiceURL.Replace("{segment-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(SegmentId, System.Globalization.CultureInfo.InvariantCulture)));
            if (Cursor != null) { request.AddQueryParameter("cursor", Cursor.ToString()); }
            if (EdgePath != null) { request.AddQueryParameter("edge_path", EdgePath.ToString()); }
            if (EnforcementPointPath != null) { request.AddQueryParameter("enforcement_point_path", EnforcementPointPath.ToString()); }
            if (IncludeMarkForDeleteObjects != null) { request.AddQueryParameter("include_mark_for_delete_objects", IncludeMarkForDeleteObjects.ToString()); }
            if (IncludedFields != null) { request.AddQueryParameter("included_fields", IncludedFields.ToString()); }
            if (PageSize != null) { request.AddQueryParameter("page_size", PageSize.ToString()); }
            if (SortAscending != null) { request.AddQueryParameter("sort_ascending", SortAscending.ToString()); }
            if (SortBy != null) { request.AddQueryParameter("sort_by", SortBy.ToString()); }
            request.Resource = GlobalInfraGetSegmentCsSpanInfoServiceURL.ToString();
            RestResponse<NSXTSegmentL2ForwarderSiteSpanInfoType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTSegmentL2ForwarderSiteSpanInfoType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Get operation to " + GlobalInfraGetSegmentCsSpanInfoServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTPolicyEdgeClusterInterSiteStatusType> GlobalGlobalInfraGetPolicyInterSiteStatus(string Tier0Id, string LocaleServicesId, string? Cursor = null, string? EdgePath = null, string? IncludedFields = null, long? PageSize = null, bool? SortAscending = null, string? SortBy = null)
        {
            if (Tier0Id == null) { throw new System.ArgumentNullException("Tier0Id cannot be null"); }
            if (LocaleServicesId == null) { throw new System.ArgumentNullException("LocaleServicesId cannot be null"); }
            StringBuilder GlobalInfraGetPolicyInterSiteStatusServiceURL = new StringBuilder("/global-infra/tier-0s/{tier-0-id}/locale-services/{locale-services-id}/inter-site/status");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Get
            };
            GlobalInfraGetPolicyInterSiteStatusServiceURL.Replace("{tier-0-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(Tier0Id, System.Globalization.CultureInfo.InvariantCulture)));
            GlobalInfraGetPolicyInterSiteStatusServiceURL.Replace("{locale-services-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(LocaleServicesId, System.Globalization.CultureInfo.InvariantCulture)));
            if (Cursor != null) { request.AddQueryParameter("cursor", Cursor.ToString()); }
            if (EdgePath != null) { request.AddQueryParameter("edge_path", EdgePath.ToString()); }
            if (IncludedFields != null) { request.AddQueryParameter("included_fields", IncludedFields.ToString()); }
            if (PageSize != null) { request.AddQueryParameter("page_size", PageSize.ToString()); }
            if (SortAscending != null) { request.AddQueryParameter("sort_ascending", SortAscending.ToString()); }
            if (SortBy != null) { request.AddQueryParameter("sort_by", SortBy.ToString()); }
            request.Resource = GlobalInfraGetPolicyInterSiteStatusServiceURL.ToString();
            RestResponse<NSXTPolicyEdgeClusterInterSiteStatusType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTPolicyEdgeClusterInterSiteStatusType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Get operation to " + GlobalInfraGetPolicyInterSiteStatusServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTInterfaceArpTableInCsvFormatType> GlobalGlobalInfraGetDownlinkPortArpTableForTier1SegmentInCsv(string Tier1Id, string SegmentId, string? Cursor = null, string? EdgePath = null, string? EnforcementPointPath = null, string? HostTransportNodePath = null, string? IncludedFields = null, long? PageSize = null, bool? SortAscending = null, string? SortBy = null)
        {
            if (Tier1Id == null) { throw new System.ArgumentNullException("Tier1Id cannot be null"); }
            if (SegmentId == null) { throw new System.ArgumentNullException("SegmentId cannot be null"); }
            StringBuilder GlobalInfraGetDownlinkPortArpTableForTier1SegmentInCsvServiceURL = new StringBuilder("/global-infra/tier-1s/{tier-1-id}/segments/{segment-id}/gateway-interface-arp-table?format=csv");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Get
            };
            GlobalInfraGetDownlinkPortArpTableForTier1SegmentInCsvServiceURL.Replace("{tier-1-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(Tier1Id, System.Globalization.CultureInfo.InvariantCulture)));
            GlobalInfraGetDownlinkPortArpTableForTier1SegmentInCsvServiceURL.Replace("{segment-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(SegmentId, System.Globalization.CultureInfo.InvariantCulture)));
            if (Cursor != null) { request.AddQueryParameter("cursor", Cursor.ToString()); }
            if (EdgePath != null) { request.AddQueryParameter("edge_path", EdgePath.ToString()); }
            if (EnforcementPointPath != null) { request.AddQueryParameter("enforcement_point_path", EnforcementPointPath.ToString()); }
            if (HostTransportNodePath != null) { request.AddQueryParameter("host_transport_node_path", HostTransportNodePath.ToString()); }
            if (IncludedFields != null) { request.AddQueryParameter("included_fields", IncludedFields.ToString()); }
            if (PageSize != null) { request.AddQueryParameter("page_size", PageSize.ToString()); }
            if (SortAscending != null) { request.AddQueryParameter("sort_ascending", SortAscending.ToString()); }
            if (SortBy != null) { request.AddQueryParameter("sort_by", SortBy.ToString()); }
            request.Resource = GlobalInfraGetDownlinkPortArpTableForTier1SegmentInCsvServiceURL.ToString();
            RestResponse<NSXTInterfaceArpTableInCsvFormatType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTInterfaceArpTableInCsvFormatType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Get operation to " + GlobalInfraGetDownlinkPortArpTableForTier1SegmentInCsvServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTPolicyInterfaceStatisticsSummaryType> GlobalGlobalInfraGetTier0RouterLinkSummaryStatistics(string Tier0Id, string Tier1Path, string? Cursor = null, string? EdgePath = null, string? EnforcementPointPath = null, bool? IncludeMarkForDeleteObjects = null, string? IncludedFields = null, long? PageSize = null, bool? SortAscending = null, string? SortBy = null)
        {
            if (Tier0Id == null) { throw new System.ArgumentNullException("Tier0Id cannot be null"); }
            if (Tier1Path == null) { throw new System.ArgumentNullException("Tier1Path cannot be null"); }
            StringBuilder GlobalInfraGetTier0RouterLinkSummaryStatisticsServiceURL = new StringBuilder("/global-infra/tier-0s/{tier-0-id}/tier-1-interface/statistics/summary");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Get
            };
            GlobalInfraGetTier0RouterLinkSummaryStatisticsServiceURL.Replace("{tier-0-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(Tier0Id, System.Globalization.CultureInfo.InvariantCulture)));
            if (Cursor != null) { request.AddQueryParameter("cursor", Cursor.ToString()); }
            if (EdgePath != null) { request.AddQueryParameter("edge_path", EdgePath.ToString()); }
            if (EnforcementPointPath != null) { request.AddQueryParameter("enforcement_point_path", EnforcementPointPath.ToString()); }
            if (IncludeMarkForDeleteObjects != null) { request.AddQueryParameter("include_mark_for_delete_objects", IncludeMarkForDeleteObjects.ToString()); }
            if (IncludedFields != null) { request.AddQueryParameter("included_fields", IncludedFields.ToString()); }
            if (PageSize != null) { request.AddQueryParameter("page_size", PageSize.ToString()); }
            if (SortAscending != null) { request.AddQueryParameter("sort_ascending", SortAscending.ToString()); }
            if (SortBy != null) { request.AddQueryParameter("sort_by", SortBy.ToString()); }
            if (Tier1Path != null) { request.AddQueryParameter("tier1_path", Tier1Path.ToString()); }
            request.Resource = GlobalInfraGetTier0RouterLinkSummaryStatisticsServiceURL.ToString();
            RestResponse<NSXTPolicyInterfaceStatisticsSummaryType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTPolicyInterfaceStatisticsSummaryType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Get operation to " + GlobalInfraGetTier0RouterLinkSummaryStatisticsServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTSegmentCrossSiteTrafficStatsType> GlobalGlobalInfraGetSegmentCsTrafficStats(string Tier1Id, string SegmentId, string? Cursor = null, string? EdgePath = null, string? EnforcementPointPath = null, bool? IncludeMarkForDeleteObjects = null, string? IncludedFields = null, long? PageSize = null, bool? SortAscending = null, string? SortBy = null)
        {
            if (Tier1Id == null) { throw new System.ArgumentNullException("Tier1Id cannot be null"); }
            if (SegmentId == null) { throw new System.ArgumentNullException("SegmentId cannot be null"); }
            StringBuilder GlobalInfraGetSegmentCsTrafficStatsServiceURL = new StringBuilder("/global-infra/tier-1s/{tier-1-id}/segments/{segment-id}/inter-site-forwarder/status");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Get
            };
            GlobalInfraGetSegmentCsTrafficStatsServiceURL.Replace("{tier-1-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(Tier1Id, System.Globalization.CultureInfo.InvariantCulture)));
            GlobalInfraGetSegmentCsTrafficStatsServiceURL.Replace("{segment-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(SegmentId, System.Globalization.CultureInfo.InvariantCulture)));
            if (Cursor != null) { request.AddQueryParameter("cursor", Cursor.ToString()); }
            if (EdgePath != null) { request.AddQueryParameter("edge_path", EdgePath.ToString()); }
            if (EnforcementPointPath != null) { request.AddQueryParameter("enforcement_point_path", EnforcementPointPath.ToString()); }
            if (IncludeMarkForDeleteObjects != null) { request.AddQueryParameter("include_mark_for_delete_objects", IncludeMarkForDeleteObjects.ToString()); }
            if (IncludedFields != null) { request.AddQueryParameter("included_fields", IncludedFields.ToString()); }
            if (PageSize != null) { request.AddQueryParameter("page_size", PageSize.ToString()); }
            if (SortAscending != null) { request.AddQueryParameter("sort_ascending", SortAscending.ToString()); }
            if (SortBy != null) { request.AddQueryParameter("sort_by", SortBy.ToString()); }
            request.Resource = GlobalInfraGetSegmentCsTrafficStatsServiceURL.ToString();
            RestResponse<NSXTSegmentCrossSiteTrafficStatsType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTSegmentCrossSiteTrafficStatsType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Get operation to " + GlobalInfraGetSegmentCsTrafficStatsServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTBridgeEndpointStatusType> Tier1SegmentBridgeEndpointStatus(string Tier1Id, string SegmentId, string BridgeProfilePath, string? EnforcementPointPath = null)
        {
            if (Tier1Id == null) { throw new System.ArgumentNullException("Tier1Id cannot be null"); }
            if (SegmentId == null) { throw new System.ArgumentNullException("SegmentId cannot be null"); }
            if (BridgeProfilePath == null) { throw new System.ArgumentNullException("BridgeProfilePath cannot be null"); }
            StringBuilder Tier1SegmentBridgeEndpointStatusServiceURL = new StringBuilder("/infra/tier-1s/{tier-1-id}/segments/{segment-id}/bep-status");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Get
            };
            Tier1SegmentBridgeEndpointStatusServiceURL.Replace("{tier-1-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(Tier1Id, System.Globalization.CultureInfo.InvariantCulture)));
            Tier1SegmentBridgeEndpointStatusServiceURL.Replace("{segment-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(SegmentId, System.Globalization.CultureInfo.InvariantCulture)));
            if (BridgeProfilePath != null) { request.AddQueryParameter("bridge_profile_path", BridgeProfilePath.ToString()); }
            if (EnforcementPointPath != null) { request.AddQueryParameter("enforcement_point_path", EnforcementPointPath.ToString()); }
            request.Resource = Tier1SegmentBridgeEndpointStatusServiceURL.ToString();
            RestResponse<NSXTBridgeEndpointStatusType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTBridgeEndpointStatusType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Get operation to " + Tier1SegmentBridgeEndpointStatusServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTPolicyInterfaceStatisticsType> GetDownlinkPortStatisticsForInfraSegment(string SegmentId, string? Cursor = null, string? EdgePath = null, string? EnforcementPointPath = null, string? HostTransportNodePath = null, string? IncludedFields = null, long? PageSize = null, bool? SortAscending = null, string? SortBy = null)
        {
            if (SegmentId == null) { throw new System.ArgumentNullException("SegmentId cannot be null"); }
            StringBuilder GetDownlinkPortStatisticsForInfraSegmentServiceURL = new StringBuilder("/infra/segments/{segment-id}/gateway-interface-statistics");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Get
            };
            GetDownlinkPortStatisticsForInfraSegmentServiceURL.Replace("{segment-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(SegmentId, System.Globalization.CultureInfo.InvariantCulture)));
            if (Cursor != null) { request.AddQueryParameter("cursor", Cursor.ToString()); }
            if (EdgePath != null) { request.AddQueryParameter("edge_path", EdgePath.ToString()); }
            if (EnforcementPointPath != null) { request.AddQueryParameter("enforcement_point_path", EnforcementPointPath.ToString()); }
            if (HostTransportNodePath != null) { request.AddQueryParameter("host_transport_node_path", HostTransportNodePath.ToString()); }
            if (IncludedFields != null) { request.AddQueryParameter("included_fields", IncludedFields.ToString()); }
            if (PageSize != null) { request.AddQueryParameter("page_size", PageSize.ToString()); }
            if (SortAscending != null) { request.AddQueryParameter("sort_ascending", SortAscending.ToString()); }
            if (SortBy != null) { request.AddQueryParameter("sort_by", SortBy.ToString()); }
            request.Resource = GetDownlinkPortStatisticsForInfraSegmentServiceURL.ToString();
            RestResponse<NSXTPolicyInterfaceStatisticsType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTPolicyInterfaceStatisticsType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Get operation to " + GetDownlinkPortStatisticsForInfraSegmentServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTPolicyArpProxyTableListResultType> GetDownlinkPortArpProxiesForTier1Segment(string Tier1Id, string SegmentId, string? Cursor = null, string? EnforcementPointPath = null, string? IncludedFields = null, long? PageSize = null, bool? SortAscending = null, string? SortBy = null, string? Source = null, string? TransportNodeId = null)
        {
            if (Tier1Id == null) { throw new System.ArgumentNullException("Tier1Id cannot be null"); }
            if (SegmentId == null) { throw new System.ArgumentNullException("SegmentId cannot be null"); }
            StringBuilder GetDownlinkPortArpProxiesForTier1SegmentServiceURL = new StringBuilder("/infra/tier-1s/{tier-1-id}/segments/{segment-id}/arp-proxy");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Get
            };
            GetDownlinkPortArpProxiesForTier1SegmentServiceURL.Replace("{tier-1-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(Tier1Id, System.Globalization.CultureInfo.InvariantCulture)));
            GetDownlinkPortArpProxiesForTier1SegmentServiceURL.Replace("{segment-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(SegmentId, System.Globalization.CultureInfo.InvariantCulture)));
            if (Cursor != null) { request.AddQueryParameter("cursor", Cursor.ToString()); }
            if (EnforcementPointPath != null) { request.AddQueryParameter("enforcement_point_path", EnforcementPointPath.ToString()); }
            if (IncludedFields != null) { request.AddQueryParameter("included_fields", IncludedFields.ToString()); }
            if (PageSize != null) { request.AddQueryParameter("page_size", PageSize.ToString()); }
            if (SortAscending != null) { request.AddQueryParameter("sort_ascending", SortAscending.ToString()); }
            if (SortBy != null) { request.AddQueryParameter("sort_by", SortBy.ToString()); }
            if (Source != null) { request.AddQueryParameter("source", Source.ToString()); }
            if (TransportNodeId != null) { request.AddQueryParameter("transport_node_id", TransportNodeId.ToString()); }
            request.Resource = GetDownlinkPortArpProxiesForTier1SegmentServiceURL.ToString();
            RestResponse<NSXTPolicyArpProxyTableListResultType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTPolicyArpProxyTableListResultType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Get operation to " + GetDownlinkPortArpProxiesForTier1SegmentServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTSegmentConfigurationStateType> GlobalGlobalInfraGetSegmentState(string Tier1Id, string SegmentsId, string? Cursor = null, string? EdgePath = null, string? EnforcementPointPath = null, bool? IncludeMarkForDeleteObjects = null, string? IncludedFields = null, long? PageSize = null, bool? SortAscending = null, string? SortBy = null)
        {
            if (Tier1Id == null) { throw new System.ArgumentNullException("Tier1Id cannot be null"); }
            if (SegmentsId == null) { throw new System.ArgumentNullException("SegmentsId cannot be null"); }
            StringBuilder GlobalInfraGetSegmentStateServiceURL = new StringBuilder("/global-infra/tier-1s/{tier-1-id}/segments/{segments-id}/state");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Get
            };
            GlobalInfraGetSegmentStateServiceURL.Replace("{tier-1-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(Tier1Id, System.Globalization.CultureInfo.InvariantCulture)));
            GlobalInfraGetSegmentStateServiceURL.Replace("{segments-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(SegmentsId, System.Globalization.CultureInfo.InvariantCulture)));
            if (Cursor != null) { request.AddQueryParameter("cursor", Cursor.ToString()); }
            if (EdgePath != null) { request.AddQueryParameter("edge_path", EdgePath.ToString()); }
            if (EnforcementPointPath != null) { request.AddQueryParameter("enforcement_point_path", EnforcementPointPath.ToString()); }
            if (IncludeMarkForDeleteObjects != null) { request.AddQueryParameter("include_mark_for_delete_objects", IncludeMarkForDeleteObjects.ToString()); }
            if (IncludedFields != null) { request.AddQueryParameter("included_fields", IncludedFields.ToString()); }
            if (PageSize != null) { request.AddQueryParameter("page_size", PageSize.ToString()); }
            if (SortAscending != null) { request.AddQueryParameter("sort_ascending", SortAscending.ToString()); }
            if (SortBy != null) { request.AddQueryParameter("sort_by", SortBy.ToString()); }
            request.Resource = GlobalInfraGetSegmentStateServiceURL.ToString();
            RestResponse<NSXTSegmentConfigurationStateType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTSegmentConfigurationStateType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Get operation to " + GlobalInfraGetSegmentStateServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTSegmentPortStateType> GetTier1SegmentPortState(string Tier1Id, string SegmentId, string PortId, string? EnforcementPointPath = null, string? Source = null)
        {
            if (Tier1Id == null) { throw new System.ArgumentNullException("Tier1Id cannot be null"); }
            if (SegmentId == null) { throw new System.ArgumentNullException("SegmentId cannot be null"); }
            if (PortId == null) { throw new System.ArgumentNullException("PortId cannot be null"); }
            StringBuilder GetTier1SegmentPortStateServiceURL = new StringBuilder("/infra/tier-1s/{tier-1-id}/segments/{segment-id}/ports/{port-id}/state");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Get
            };
            GetTier1SegmentPortStateServiceURL.Replace("{tier-1-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(Tier1Id, System.Globalization.CultureInfo.InvariantCulture)));
            GetTier1SegmentPortStateServiceURL.Replace("{segment-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(SegmentId, System.Globalization.CultureInfo.InvariantCulture)));
            GetTier1SegmentPortStateServiceURL.Replace("{port-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(PortId, System.Globalization.CultureInfo.InvariantCulture)));
            if (EnforcementPointPath != null) { request.AddQueryParameter("enforcement_point_path", EnforcementPointPath.ToString()); }
            if (Source != null) { request.AddQueryParameter("source", Source.ToString()); }
            request.Resource = GetTier1SegmentPortStateServiceURL.ToString();
            RestResponse<NSXTSegmentPortStateType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTSegmentPortStateType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Get operation to " + GetTier1SegmentPortStateServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTInterfaceArpTableInCsvFormatType> GetSegmentInterfaceArpTableCsv(string Tier1Id, string SegmentId, string? Cursor = null, string? EdgePath = null, string? EnforcementPointPath = null, string? HostTransportNodePath = null, string? IncludedFields = null, long? PageSize = null, bool? SortAscending = null, string? SortBy = null)
        {
            if (Tier1Id == null) { throw new System.ArgumentNullException("Tier1Id cannot be null"); }
            if (SegmentId == null) { throw new System.ArgumentNullException("SegmentId cannot be null"); }
            StringBuilder GetSegmentInterfaceArpTableCsvServiceURL = new StringBuilder("/infra/tier-1s/{tier-1-id}/segments/{segment-id}/arp-table?format=csv");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Get
            };
            GetSegmentInterfaceArpTableCsvServiceURL.Replace("{tier-1-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(Tier1Id, System.Globalization.CultureInfo.InvariantCulture)));
            GetSegmentInterfaceArpTableCsvServiceURL.Replace("{segment-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(SegmentId, System.Globalization.CultureInfo.InvariantCulture)));
            if (Cursor != null) { request.AddQueryParameter("cursor", Cursor.ToString()); }
            if (EdgePath != null) { request.AddQueryParameter("edge_path", EdgePath.ToString()); }
            if (EnforcementPointPath != null) { request.AddQueryParameter("enforcement_point_path", EnforcementPointPath.ToString()); }
            if (HostTransportNodePath != null) { request.AddQueryParameter("host_transport_node_path", HostTransportNodePath.ToString()); }
            if (IncludedFields != null) { request.AddQueryParameter("included_fields", IncludedFields.ToString()); }
            if (PageSize != null) { request.AddQueryParameter("page_size", PageSize.ToString()); }
            if (SortAscending != null) { request.AddQueryParameter("sort_ascending", SortAscending.ToString()); }
            if (SortBy != null) { request.AddQueryParameter("sort_by", SortBy.ToString()); }
            request.Resource = GetSegmentInterfaceArpTableCsvServiceURL.ToString();
            RestResponse<NSXTInterfaceArpTableInCsvFormatType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTInterfaceArpTableInCsvFormatType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Get operation to " + GetSegmentInterfaceArpTableCsvServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTSegmentPortStatisticsType> GlobalGlobalInfraGetInfraSegmentPortStatistics(string SegmentsId, string PortId, string? Cursor = null, string? EdgePath = null, string? EnforcementPointPath = null, bool? IncludeMarkForDeleteObjects = null, string? IncludedFields = null, long? PageSize = null, bool? SortAscending = null, string? SortBy = null)
        {
            if (SegmentsId == null) { throw new System.ArgumentNullException("SegmentsId cannot be null"); }
            if (PortId == null) { throw new System.ArgumentNullException("PortId cannot be null"); }
            StringBuilder GlobalInfraGetInfraSegmentPortStatisticsServiceURL = new StringBuilder("/global-infra/segments/{segments-id}/ports/{port-id}/statistics");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Get
            };
            GlobalInfraGetInfraSegmentPortStatisticsServiceURL.Replace("{segments-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(SegmentsId, System.Globalization.CultureInfo.InvariantCulture)));
            GlobalInfraGetInfraSegmentPortStatisticsServiceURL.Replace("{port-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(PortId, System.Globalization.CultureInfo.InvariantCulture)));
            if (Cursor != null) { request.AddQueryParameter("cursor", Cursor.ToString()); }
            if (EdgePath != null) { request.AddQueryParameter("edge_path", EdgePath.ToString()); }
            if (EnforcementPointPath != null) { request.AddQueryParameter("enforcement_point_path", EnforcementPointPath.ToString()); }
            if (IncludeMarkForDeleteObjects != null) { request.AddQueryParameter("include_mark_for_delete_objects", IncludeMarkForDeleteObjects.ToString()); }
            if (IncludedFields != null) { request.AddQueryParameter("included_fields", IncludedFields.ToString()); }
            if (PageSize != null) { request.AddQueryParameter("page_size", PageSize.ToString()); }
            if (SortAscending != null) { request.AddQueryParameter("sort_ascending", SortAscending.ToString()); }
            if (SortBy != null) { request.AddQueryParameter("sort_by", SortBy.ToString()); }
            request.Resource = GlobalInfraGetInfraSegmentPortStatisticsServiceURL.ToString();
            RestResponse<NSXTSegmentPortStatisticsType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTSegmentPortStatisticsType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Get operation to " + GlobalInfraGetInfraSegmentPortStatisticsServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTSegmentPortMacAddressListResultType> GetTier1SegmentPortMacTable(string Tier1Id, string SegmentId, string PortId, string? Cursor = null, string? EnforcementPointPath = null, string? IncludedFields = null, long? PageSize = null, bool? SortAscending = null, string? SortBy = null, string? Source = null, string? TransportNodeId = null)
        {
            if (Tier1Id == null) { throw new System.ArgumentNullException("Tier1Id cannot be null"); }
            if (SegmentId == null) { throw new System.ArgumentNullException("SegmentId cannot be null"); }
            if (PortId == null) { throw new System.ArgumentNullException("PortId cannot be null"); }
            StringBuilder GetTier1SegmentPortMacTableServiceURL = new StringBuilder("/infra/tier-1s/{tier-1-id}/segments/{segment-id}/ports/{port-id}/mac-table");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Get
            };
            GetTier1SegmentPortMacTableServiceURL.Replace("{tier-1-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(Tier1Id, System.Globalization.CultureInfo.InvariantCulture)));
            GetTier1SegmentPortMacTableServiceURL.Replace("{segment-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(SegmentId, System.Globalization.CultureInfo.InvariantCulture)));
            GetTier1SegmentPortMacTableServiceURL.Replace("{port-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(PortId, System.Globalization.CultureInfo.InvariantCulture)));
            if (Cursor != null) { request.AddQueryParameter("cursor", Cursor.ToString()); }
            if (EnforcementPointPath != null) { request.AddQueryParameter("enforcement_point_path", EnforcementPointPath.ToString()); }
            if (IncludedFields != null) { request.AddQueryParameter("included_fields", IncludedFields.ToString()); }
            if (PageSize != null) { request.AddQueryParameter("page_size", PageSize.ToString()); }
            if (SortAscending != null) { request.AddQueryParameter("sort_ascending", SortAscending.ToString()); }
            if (SortBy != null) { request.AddQueryParameter("sort_by", SortBy.ToString()); }
            if (Source != null) { request.AddQueryParameter("source", Source.ToString()); }
            if (TransportNodeId != null) { request.AddQueryParameter("transport_node_id", TransportNodeId.ToString()); }
            request.Resource = GetTier1SegmentPortMacTableServiceURL.ToString();
            RestResponse<NSXTSegmentPortMacAddressListResultType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTSegmentPortMacAddressListResultType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Get operation to " + GetTier1SegmentPortMacTableServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTInterfaceDADStateType> GlobalGlobalInfraGetDownlinkPortDadStateForTier1Segment(string Tier1Id, string SegmentId, string? EnforcementPointPath = null, string? Source = null)
        {
            if (Tier1Id == null) { throw new System.ArgumentNullException("Tier1Id cannot be null"); }
            if (SegmentId == null) { throw new System.ArgumentNullException("SegmentId cannot be null"); }
            StringBuilder GlobalInfraGetDownlinkPortDadStateForTier1SegmentServiceURL = new StringBuilder("/global-infra/tier-1s/{tier-1-id}/segments/{segment-id}/gateway-interface-dad-state");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Get
            };
            GlobalInfraGetDownlinkPortDadStateForTier1SegmentServiceURL.Replace("{tier-1-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(Tier1Id, System.Globalization.CultureInfo.InvariantCulture)));
            GlobalInfraGetDownlinkPortDadStateForTier1SegmentServiceURL.Replace("{segment-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(SegmentId, System.Globalization.CultureInfo.InvariantCulture)));
            if (EnforcementPointPath != null) { request.AddQueryParameter("enforcement_point_path", EnforcementPointPath.ToString()); }
            if (Source != null) { request.AddQueryParameter("source", Source.ToString()); }
            request.Resource = GlobalInfraGetDownlinkPortDadStateForTier1SegmentServiceURL.ToString();
            RestResponse<NSXTInterfaceDADStateType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTInterfaceDADStateType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Get operation to " + GlobalInfraGetDownlinkPortDadStateForTier1SegmentServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTInterfaceArpTableType> GetTier0RouterLinkArpTable(string Tier0Id, string Tier1Path, string? Cursor = null, string? EdgePath = null, string? EnforcementPointPath = null, bool? IncludeMarkForDeleteObjects = null, string? IncludedFields = null, long? PageSize = null, bool? SortAscending = null, string? SortBy = null)
        {
            if (Tier0Id == null) { throw new System.ArgumentNullException("Tier0Id cannot be null"); }
            if (Tier1Path == null) { throw new System.ArgumentNullException("Tier1Path cannot be null"); }
            StringBuilder GetTier0RouterLinkArpTableServiceURL = new StringBuilder("/infra/tier-0s/{tier-0-id}/tier-1-interface/arp-table");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Get
            };
            GetTier0RouterLinkArpTableServiceURL.Replace("{tier-0-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(Tier0Id, System.Globalization.CultureInfo.InvariantCulture)));
            if (Cursor != null) { request.AddQueryParameter("cursor", Cursor.ToString()); }
            if (EdgePath != null) { request.AddQueryParameter("edge_path", EdgePath.ToString()); }
            if (EnforcementPointPath != null) { request.AddQueryParameter("enforcement_point_path", EnforcementPointPath.ToString()); }
            if (IncludeMarkForDeleteObjects != null) { request.AddQueryParameter("include_mark_for_delete_objects", IncludeMarkForDeleteObjects.ToString()); }
            if (IncludedFields != null) { request.AddQueryParameter("included_fields", IncludedFields.ToString()); }
            if (PageSize != null) { request.AddQueryParameter("page_size", PageSize.ToString()); }
            if (SortAscending != null) { request.AddQueryParameter("sort_ascending", SortAscending.ToString()); }
            if (SortBy != null) { request.AddQueryParameter("sort_by", SortBy.ToString()); }
            if (Tier1Path != null) { request.AddQueryParameter("tier1_path", Tier1Path.ToString()); }
            request.Resource = GetTier0RouterLinkArpTableServiceURL.ToString();
            RestResponse<NSXTInterfaceArpTableType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTInterfaceArpTableType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Get operation to " + GetTier0RouterLinkArpTableServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTPolicyArpProxyTableListResultType> GetTier1GatewayArpProxies(string Tier1Id, string? Cursor = null, string? EnforcementPointPath = null, string? IncludedFields = null, long? PageSize = null, bool? SortAscending = null, string? SortBy = null, string? Source = null, string? TransportNodeId = null)
        {
            if (Tier1Id == null) { throw new System.ArgumentNullException("Tier1Id cannot be null"); }
            StringBuilder GetTier1GatewayArpProxiesServiceURL = new StringBuilder("/infra/tier-1s/{tier-1-id}/arp-proxies");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Get
            };
            GetTier1GatewayArpProxiesServiceURL.Replace("{tier-1-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(Tier1Id, System.Globalization.CultureInfo.InvariantCulture)));
            if (Cursor != null) { request.AddQueryParameter("cursor", Cursor.ToString()); }
            if (EnforcementPointPath != null) { request.AddQueryParameter("enforcement_point_path", EnforcementPointPath.ToString()); }
            if (IncludedFields != null) { request.AddQueryParameter("included_fields", IncludedFields.ToString()); }
            if (PageSize != null) { request.AddQueryParameter("page_size", PageSize.ToString()); }
            if (SortAscending != null) { request.AddQueryParameter("sort_ascending", SortAscending.ToString()); }
            if (SortBy != null) { request.AddQueryParameter("sort_by", SortBy.ToString()); }
            if (Source != null) { request.AddQueryParameter("source", Source.ToString()); }
            if (TransportNodeId != null) { request.AddQueryParameter("transport_node_id", TransportNodeId.ToString()); }
            request.Resource = GetTier1GatewayArpProxiesServiceURL.ToString();
            RestResponse<NSXTPolicyArpProxyTableListResultType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTPolicyArpProxyTableListResultType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Get operation to " + GetTier1GatewayArpProxiesServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTPolicyTepListResultType> GetInfraSegmentTepTable(string SegmentId, string? Cursor = null, string? EnforcementPointPath = null, string? IncludedFields = null, long? PageSize = null, bool? SortAscending = null, string? SortBy = null, string? Source = null, string? TransportNodeId = null)
        {
            if (SegmentId == null) { throw new System.ArgumentNullException("SegmentId cannot be null"); }
            StringBuilder GetInfraSegmentTepTableServiceURL = new StringBuilder("/infra/segments/{segment-id}/tep-table");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Get
            };
            GetInfraSegmentTepTableServiceURL.Replace("{segment-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(SegmentId, System.Globalization.CultureInfo.InvariantCulture)));
            if (Cursor != null) { request.AddQueryParameter("cursor", Cursor.ToString()); }
            if (EnforcementPointPath != null) { request.AddQueryParameter("enforcement_point_path", EnforcementPointPath.ToString()); }
            if (IncludedFields != null) { request.AddQueryParameter("included_fields", IncludedFields.ToString()); }
            if (PageSize != null) { request.AddQueryParameter("page_size", PageSize.ToString()); }
            if (SortAscending != null) { request.AddQueryParameter("sort_ascending", SortAscending.ToString()); }
            if (SortBy != null) { request.AddQueryParameter("sort_by", SortBy.ToString()); }
            if (Source != null) { request.AddQueryParameter("source", Source.ToString()); }
            if (TransportNodeId != null) { request.AddQueryParameter("transport_node_id", TransportNodeId.ToString()); }
            request.Resource = GetInfraSegmentTepTableServiceURL.ToString();
            RestResponse<NSXTPolicyTepListResultType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTPolicyTepListResultType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Get operation to " + GetInfraSegmentTepTableServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTRoutingTableListResultType> GlobalGlobalInfraGetTier1ForwardingTable(string Tier1Id, string? Cursor = null, string? EdgeId = null, string? EdgePath = null, string? EnforcementPointPath = null, string? IncludedFields = null, string? NetworkPrefix = null, long? PageSize = null, string? RouteSource = null, bool? SortAscending = null, string? SortBy = null)
        {
            if (Tier1Id == null) { throw new System.ArgumentNullException("Tier1Id cannot be null"); }
            StringBuilder GlobalInfraGetTier1ForwardingTableServiceURL = new StringBuilder("/global-infra/tier-1s/{tier-1-id}/forwarding-table");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Get
            };
            GlobalInfraGetTier1ForwardingTableServiceURL.Replace("{tier-1-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(Tier1Id, System.Globalization.CultureInfo.InvariantCulture)));
            if (Cursor != null) { request.AddQueryParameter("cursor", Cursor.ToString()); }
            if (EdgeId != null) { request.AddQueryParameter("edge_id", EdgeId.ToString()); }
            if (EdgePath != null) { request.AddQueryParameter("edge_path", EdgePath.ToString()); }
            if (EnforcementPointPath != null) { request.AddQueryParameter("enforcement_point_path", EnforcementPointPath.ToString()); }
            if (IncludedFields != null) { request.AddQueryParameter("included_fields", IncludedFields.ToString()); }
            if (NetworkPrefix != null) { request.AddQueryParameter("network_prefix", NetworkPrefix.ToString()); }
            if (PageSize != null) { request.AddQueryParameter("page_size", PageSize.ToString()); }
            if (RouteSource != null) { request.AddQueryParameter("route_source", RouteSource.ToString()); }
            if (SortAscending != null) { request.AddQueryParameter("sort_ascending", SortAscending.ToString()); }
            if (SortBy != null) { request.AddQueryParameter("sort_by", SortBy.ToString()); }
            request.Resource = GlobalInfraGetTier1ForwardingTableServiceURL.ToString();
            RestResponse<NSXTRoutingTableListResultType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTRoutingTableListResultType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Get operation to " + GlobalInfraGetTier1ForwardingTableServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTBgpNeighborRoutesListResultType> GlobalGlobalInfraGetTier0BgpNeighborAdvertisedRoutes(string Tier0Id, string LocaleServiceId, string NeighborId, int? Count = null, string? Cursor = null, string? EnforcementPointPath = null, string? IncludedFields = null, long? PageSize = null, bool? SortAscending = null, string? SortBy = null)
        {
            if (Tier0Id == null) { throw new System.ArgumentNullException("Tier0Id cannot be null"); }
            if (LocaleServiceId == null) { throw new System.ArgumentNullException("LocaleServiceId cannot be null"); }
            if (NeighborId == null) { throw new System.ArgumentNullException("NeighborId cannot be null"); }
            StringBuilder GlobalInfraGetTier0BgpNeighborAdvertisedRoutesServiceURL = new StringBuilder("/global-infra/tier-0s/{tier-0-id}/locale-services/{locale-service-id}/bgp/neighbors/{neighbor-id}/advertised-routes");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Get
            };
            GlobalInfraGetTier0BgpNeighborAdvertisedRoutesServiceURL.Replace("{tier-0-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(Tier0Id, System.Globalization.CultureInfo.InvariantCulture)));
            GlobalInfraGetTier0BgpNeighborAdvertisedRoutesServiceURL.Replace("{locale-service-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(LocaleServiceId, System.Globalization.CultureInfo.InvariantCulture)));
            GlobalInfraGetTier0BgpNeighborAdvertisedRoutesServiceURL.Replace("{neighbor-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(NeighborId, System.Globalization.CultureInfo.InvariantCulture)));
            if (Count != null) { request.AddQueryParameter("count", Count.ToString()); }
            if (Cursor != null) { request.AddQueryParameter("cursor", Cursor.ToString()); }
            if (EnforcementPointPath != null) { request.AddQueryParameter("enforcement_point_path", EnforcementPointPath.ToString()); }
            if (IncludedFields != null) { request.AddQueryParameter("included_fields", IncludedFields.ToString()); }
            if (PageSize != null) { request.AddQueryParameter("page_size", PageSize.ToString()); }
            if (SortAscending != null) { request.AddQueryParameter("sort_ascending", SortAscending.ToString()); }
            if (SortBy != null) { request.AddQueryParameter("sort_by", SortBy.ToString()); }
            request.Resource = GlobalInfraGetTier0BgpNeighborAdvertisedRoutesServiceURL.ToString();
            RestResponse<NSXTBgpNeighborRoutesListResultType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTBgpNeighborRoutesListResultType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Get operation to " + GlobalInfraGetTier0BgpNeighborAdvertisedRoutesServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTSegmentConfigurationStateListResultType> GetTier1SegmentsByState(string Tier1Id, string? ConfigurationState = null, string? EnforcementPointPath = null, string? Source = null)
        {
            if (Tier1Id == null) { throw new System.ArgumentNullException("Tier1Id cannot be null"); }
            StringBuilder GetTier1SegmentsByStateServiceURL = new StringBuilder("/infra/tier-1s/{tier-1-id}/segments/state");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Get
            };
            GetTier1SegmentsByStateServiceURL.Replace("{tier-1-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(Tier1Id, System.Globalization.CultureInfo.InvariantCulture)));
            if (ConfigurationState != null) { request.AddQueryParameter("configuration_state", ConfigurationState.ToString()); }
            if (EnforcementPointPath != null) { request.AddQueryParameter("enforcement_point_path", EnforcementPointPath.ToString()); }
            if (Source != null) { request.AddQueryParameter("source", Source.ToString()); }
            request.Resource = GetTier1SegmentsByStateServiceURL.ToString();
            RestResponse<NSXTSegmentConfigurationStateListResultType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTSegmentConfigurationStateListResultType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Get operation to " + GetTier1SegmentsByStateServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTPolicyTepListResultType> GlobalGlobalInfraGetInfraSegmentTepTable(string SegmentId, string? Cursor = null, string? EnforcementPointPath = null, string? IncludedFields = null, long? PageSize = null, bool? SortAscending = null, string? SortBy = null, string? Source = null, string? TransportNodeId = null)
        {
            if (SegmentId == null) { throw new System.ArgumentNullException("SegmentId cannot be null"); }
            StringBuilder GlobalInfraGetInfraSegmentTepTableServiceURL = new StringBuilder("/global-infra/segments/{segment-id}/tep-table");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Get
            };
            GlobalInfraGetInfraSegmentTepTableServiceURL.Replace("{segment-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(SegmentId, System.Globalization.CultureInfo.InvariantCulture)));
            if (Cursor != null) { request.AddQueryParameter("cursor", Cursor.ToString()); }
            if (EnforcementPointPath != null) { request.AddQueryParameter("enforcement_point_path", EnforcementPointPath.ToString()); }
            if (IncludedFields != null) { request.AddQueryParameter("included_fields", IncludedFields.ToString()); }
            if (PageSize != null) { request.AddQueryParameter("page_size", PageSize.ToString()); }
            if (SortAscending != null) { request.AddQueryParameter("sort_ascending", SortAscending.ToString()); }
            if (SortBy != null) { request.AddQueryParameter("sort_by", SortBy.ToString()); }
            if (Source != null) { request.AddQueryParameter("source", Source.ToString()); }
            if (TransportNodeId != null) { request.AddQueryParameter("transport_node_id", TransportNodeId.ToString()); }
            request.Resource = GlobalInfraGetInfraSegmentTepTableServiceURL.ToString();
            RestResponse<NSXTPolicyTepListResultType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTPolicyTepListResultType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Get operation to " + GlobalInfraGetInfraSegmentTepTableServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTInterfaceArpTableType> GlobalGlobalInfraGetTier0InterfaceArpTable(string Tier0Id, string LocaleServiceId, string InterfaceId, string? Cursor = null, string? EdgePath = null, string? EnforcementPointPath = null, string? HostTransportNodePath = null, string? IncludedFields = null, long? PageSize = null, bool? SortAscending = null, string? SortBy = null)
        {
            if (Tier0Id == null) { throw new System.ArgumentNullException("Tier0Id cannot be null"); }
            if (LocaleServiceId == null) { throw new System.ArgumentNullException("LocaleServiceId cannot be null"); }
            if (InterfaceId == null) { throw new System.ArgumentNullException("InterfaceId cannot be null"); }
            StringBuilder GlobalInfraGetTier0InterfaceArpTableServiceURL = new StringBuilder("/global-infra/tier-0s/{tier-0-id}/locale-services/{locale-service-id}/interfaces/{interface-id}/arp-table");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Get
            };
            GlobalInfraGetTier0InterfaceArpTableServiceURL.Replace("{tier-0-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(Tier0Id, System.Globalization.CultureInfo.InvariantCulture)));
            GlobalInfraGetTier0InterfaceArpTableServiceURL.Replace("{locale-service-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(LocaleServiceId, System.Globalization.CultureInfo.InvariantCulture)));
            GlobalInfraGetTier0InterfaceArpTableServiceURL.Replace("{interface-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(InterfaceId, System.Globalization.CultureInfo.InvariantCulture)));
            if (Cursor != null) { request.AddQueryParameter("cursor", Cursor.ToString()); }
            if (EdgePath != null) { request.AddQueryParameter("edge_path", EdgePath.ToString()); }
            if (EnforcementPointPath != null) { request.AddQueryParameter("enforcement_point_path", EnforcementPointPath.ToString()); }
            if (HostTransportNodePath != null) { request.AddQueryParameter("host_transport_node_path", HostTransportNodePath.ToString()); }
            if (IncludedFields != null) { request.AddQueryParameter("included_fields", IncludedFields.ToString()); }
            if (PageSize != null) { request.AddQueryParameter("page_size", PageSize.ToString()); }
            if (SortAscending != null) { request.AddQueryParameter("sort_ascending", SortAscending.ToString()); }
            if (SortBy != null) { request.AddQueryParameter("sort_by", SortBy.ToString()); }
            request.Resource = GlobalInfraGetTier0InterfaceArpTableServiceURL.ToString();
            RestResponse<NSXTInterfaceArpTableType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTInterfaceArpTableType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Get operation to " + GlobalInfraGetTier0InterfaceArpTableServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTSegmentConfigurationStateListResultType> GlobalGlobalInfraGetInfraSegmentsByState(string? ConfigurationState = null, string? EnforcementPointPath = null, string? Source = null)
        {
            StringBuilder GlobalInfraGetInfraSegmentsByStateServiceURL = new StringBuilder("/global-infra/segments/state");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Get
            };
            if (ConfigurationState != null) { request.AddQueryParameter("configuration_state", ConfigurationState.ToString()); }
            if (EnforcementPointPath != null) { request.AddQueryParameter("enforcement_point_path", EnforcementPointPath.ToString()); }
            if (Source != null) { request.AddQueryParameter("source", Source.ToString()); }
            request.Resource = GlobalInfraGetInfraSegmentsByStateServiceURL.ToString();
            RestResponse<NSXTSegmentConfigurationStateListResultType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTSegmentConfigurationStateListResultType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Get operation to " + GlobalInfraGetInfraSegmentsByStateServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTPimRpMappingsType> GetPolicyPimRpMappings(string Tier0Id, string LocaleServicesId, string? Cursor = null, string? EdgePath = null, string? IncludedFields = null, long? PageSize = null, bool? SortAscending = null, string? SortBy = null)
        {
            if (Tier0Id == null) { throw new System.ArgumentNullException("Tier0Id cannot be null"); }
            if (LocaleServicesId == null) { throw new System.ArgumentNullException("LocaleServicesId cannot be null"); }
            StringBuilder GetPolicyPimRpMappingsServiceURL = new StringBuilder("/infra/tier-0s/{tier-0-id}/locale-services/{locale-services-id}/multicast/pim-rp-mappings");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Get
            };
            GetPolicyPimRpMappingsServiceURL.Replace("{tier-0-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(Tier0Id, System.Globalization.CultureInfo.InvariantCulture)));
            GetPolicyPimRpMappingsServiceURL.Replace("{locale-services-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(LocaleServicesId, System.Globalization.CultureInfo.InvariantCulture)));
            if (Cursor != null) { request.AddQueryParameter("cursor", Cursor.ToString()); }
            if (EdgePath != null) { request.AddQueryParameter("edge_path", EdgePath.ToString()); }
            if (IncludedFields != null) { request.AddQueryParameter("included_fields", IncludedFields.ToString()); }
            if (PageSize != null) { request.AddQueryParameter("page_size", PageSize.ToString()); }
            if (SortAscending != null) { request.AddQueryParameter("sort_ascending", SortAscending.ToString()); }
            if (SortBy != null) { request.AddQueryParameter("sort_by", SortBy.ToString()); }
            request.Resource = GetPolicyPimRpMappingsServiceURL.ToString();
            RestResponse<NSXTPimRpMappingsType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTPimRpMappingsType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Get operation to " + GetPolicyPimRpMappingsServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTPolicyInterfaceStatisticsType> GetTier0InterfaceStatistics(string Tier0Id, string LocaleServiceId, string InterfaceId, string? Cursor = null, string? EdgePath = null, string? EnforcementPointPath = null, bool? IncludeMarkForDeleteObjects = null, string? IncludedFields = null, long? PageSize = null, bool? SortAscending = null, string? SortBy = null)
        {
            if (Tier0Id == null) { throw new System.ArgumentNullException("Tier0Id cannot be null"); }
            if (LocaleServiceId == null) { throw new System.ArgumentNullException("LocaleServiceId cannot be null"); }
            if (InterfaceId == null) { throw new System.ArgumentNullException("InterfaceId cannot be null"); }
            StringBuilder GetTier0InterfaceStatisticsServiceURL = new StringBuilder("/infra/tier-0s/{tier-0-id}/locale-services/{locale-service-id}/interfaces/{interface-id}/statistics");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Get
            };
            GetTier0InterfaceStatisticsServiceURL.Replace("{tier-0-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(Tier0Id, System.Globalization.CultureInfo.InvariantCulture)));
            GetTier0InterfaceStatisticsServiceURL.Replace("{locale-service-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(LocaleServiceId, System.Globalization.CultureInfo.InvariantCulture)));
            GetTier0InterfaceStatisticsServiceURL.Replace("{interface-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(InterfaceId, System.Globalization.CultureInfo.InvariantCulture)));
            if (Cursor != null) { request.AddQueryParameter("cursor", Cursor.ToString()); }
            if (EdgePath != null) { request.AddQueryParameter("edge_path", EdgePath.ToString()); }
            if (EnforcementPointPath != null) { request.AddQueryParameter("enforcement_point_path", EnforcementPointPath.ToString()); }
            if (IncludeMarkForDeleteObjects != null) { request.AddQueryParameter("include_mark_for_delete_objects", IncludeMarkForDeleteObjects.ToString()); }
            if (IncludedFields != null) { request.AddQueryParameter("included_fields", IncludedFields.ToString()); }
            if (PageSize != null) { request.AddQueryParameter("page_size", PageSize.ToString()); }
            if (SortAscending != null) { request.AddQueryParameter("sort_ascending", SortAscending.ToString()); }
            if (SortBy != null) { request.AddQueryParameter("sort_by", SortBy.ToString()); }
            request.Resource = GetTier0InterfaceStatisticsServiceURL.ToString();
            RestResponse<NSXTPolicyInterfaceStatisticsType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTPolicyInterfaceStatisticsType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Get operation to " + GetTier0InterfaceStatisticsServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTSegmentPortMacAddressListResultType> GetInfraSegmentPortMacTable(string SegmentId, string PortId, string? Cursor = null, string? EnforcementPointPath = null, string? IncludedFields = null, long? PageSize = null, bool? SortAscending = null, string? SortBy = null, string? Source = null, string? TransportNodeId = null)
        {
            if (SegmentId == null) { throw new System.ArgumentNullException("SegmentId cannot be null"); }
            if (PortId == null) { throw new System.ArgumentNullException("PortId cannot be null"); }
            StringBuilder GetInfraSegmentPortMacTableServiceURL = new StringBuilder("/infra/segments/{segment-id}/ports/{port-id}/mac-table");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Get
            };
            GetInfraSegmentPortMacTableServiceURL.Replace("{segment-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(SegmentId, System.Globalization.CultureInfo.InvariantCulture)));
            GetInfraSegmentPortMacTableServiceURL.Replace("{port-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(PortId, System.Globalization.CultureInfo.InvariantCulture)));
            if (Cursor != null) { request.AddQueryParameter("cursor", Cursor.ToString()); }
            if (EnforcementPointPath != null) { request.AddQueryParameter("enforcement_point_path", EnforcementPointPath.ToString()); }
            if (IncludedFields != null) { request.AddQueryParameter("included_fields", IncludedFields.ToString()); }
            if (PageSize != null) { request.AddQueryParameter("page_size", PageSize.ToString()); }
            if (SortAscending != null) { request.AddQueryParameter("sort_ascending", SortAscending.ToString()); }
            if (SortBy != null) { request.AddQueryParameter("sort_by", SortBy.ToString()); }
            if (Source != null) { request.AddQueryParameter("source", Source.ToString()); }
            if (TransportNodeId != null) { request.AddQueryParameter("transport_node_id", TransportNodeId.ToString()); }
            request.Resource = GetInfraSegmentPortMacTableServiceURL.ToString();
            RestResponse<NSXTSegmentPortMacAddressListResultType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTSegmentPortMacAddressListResultType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Get operation to " + GetInfraSegmentPortMacTableServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTBgpNeighborRouteDetailsInCsvFormatType> GlobalGlobalInfraGetTier0BgpNeighborRoutesInCsvFormat(string Tier0Id, string LocaleServiceId, string NeighborId, int? Count = null, string? Cursor = null, string? EnforcementPointPath = null, string? IncludedFields = null, long? PageSize = null, bool? SortAscending = null, string? SortBy = null)
        {
            if (Tier0Id == null) { throw new System.ArgumentNullException("Tier0Id cannot be null"); }
            if (LocaleServiceId == null) { throw new System.ArgumentNullException("LocaleServiceId cannot be null"); }
            if (NeighborId == null) { throw new System.ArgumentNullException("NeighborId cannot be null"); }
            StringBuilder GlobalInfraGetTier0BgpNeighborRoutesInCsvFormatServiceURL = new StringBuilder("/global-infra/tier-0s/{tier-0-id}/locale-services/{locale-service-id}/bgp/neighbors/{neighbor-id}/routes?format=csv");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Get
            };
            GlobalInfraGetTier0BgpNeighborRoutesInCsvFormatServiceURL.Replace("{tier-0-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(Tier0Id, System.Globalization.CultureInfo.InvariantCulture)));
            GlobalInfraGetTier0BgpNeighborRoutesInCsvFormatServiceURL.Replace("{locale-service-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(LocaleServiceId, System.Globalization.CultureInfo.InvariantCulture)));
            GlobalInfraGetTier0BgpNeighborRoutesInCsvFormatServiceURL.Replace("{neighbor-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(NeighborId, System.Globalization.CultureInfo.InvariantCulture)));
            if (Count != null) { request.AddQueryParameter("count", Count.ToString()); }
            if (Cursor != null) { request.AddQueryParameter("cursor", Cursor.ToString()); }
            if (EnforcementPointPath != null) { request.AddQueryParameter("enforcement_point_path", EnforcementPointPath.ToString()); }
            if (IncludedFields != null) { request.AddQueryParameter("included_fields", IncludedFields.ToString()); }
            if (PageSize != null) { request.AddQueryParameter("page_size", PageSize.ToString()); }
            if (SortAscending != null) { request.AddQueryParameter("sort_ascending", SortAscending.ToString()); }
            if (SortBy != null) { request.AddQueryParameter("sort_by", SortBy.ToString()); }
            request.Resource = GlobalInfraGetTier0BgpNeighborRoutesInCsvFormatServiceURL.ToString();
            RestResponse<NSXTBgpNeighborRouteDetailsInCsvFormatType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTBgpNeighborRouteDetailsInCsvFormatType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Get operation to " + GlobalInfraGetTier0BgpNeighborRoutesInCsvFormatServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTPolicyArpProxyTableCsvListResultType> GlobalGlobalInfraGetTier0InterfaceArpProxiesInCsv(string Tier0Id, string LocaleServiceId, string InterfaceId, string? EnforcementPointPath = null, string? Source = null, string? TransportNodeId = null)
        {
            if (Tier0Id == null) { throw new System.ArgumentNullException("Tier0Id cannot be null"); }
            if (LocaleServiceId == null) { throw new System.ArgumentNullException("LocaleServiceId cannot be null"); }
            if (InterfaceId == null) { throw new System.ArgumentNullException("InterfaceId cannot be null"); }
            StringBuilder GlobalInfraGetTier0InterfaceArpProxiesInCsvServiceURL = new StringBuilder("/global-infra/tier-0s/{tier-0-id}/locale-services/{locale-service-id}/interfaces/{interface-id}/arp-proxy?format=csv");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Get
            };
            GlobalInfraGetTier0InterfaceArpProxiesInCsvServiceURL.Replace("{tier-0-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(Tier0Id, System.Globalization.CultureInfo.InvariantCulture)));
            GlobalInfraGetTier0InterfaceArpProxiesInCsvServiceURL.Replace("{locale-service-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(LocaleServiceId, System.Globalization.CultureInfo.InvariantCulture)));
            GlobalInfraGetTier0InterfaceArpProxiesInCsvServiceURL.Replace("{interface-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(InterfaceId, System.Globalization.CultureInfo.InvariantCulture)));
            if (EnforcementPointPath != null) { request.AddQueryParameter("enforcement_point_path", EnforcementPointPath.ToString()); }
            if (Source != null) { request.AddQueryParameter("source", Source.ToString()); }
            if (TransportNodeId != null) { request.AddQueryParameter("transport_node_id", TransportNodeId.ToString()); }
            request.Resource = GlobalInfraGetTier0InterfaceArpProxiesInCsvServiceURL.ToString();
            RestResponse<NSXTPolicyArpProxyTableCsvListResultType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTPolicyArpProxyTableCsvListResultType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Get operation to " + GlobalInfraGetTier0InterfaceArpProxiesInCsvServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTInterfaceArpTableInCsvFormatType> GetTier0InterfaceArpTableCsv(string Tier0Id, string LocaleServiceId, string InterfaceId, string? Cursor = null, string? EdgePath = null, string? EnforcementPointPath = null, string? HostTransportNodePath = null, string? IncludedFields = null, long? PageSize = null, bool? SortAscending = null, string? SortBy = null)
        {
            if (Tier0Id == null) { throw new System.ArgumentNullException("Tier0Id cannot be null"); }
            if (LocaleServiceId == null) { throw new System.ArgumentNullException("LocaleServiceId cannot be null"); }
            if (InterfaceId == null) { throw new System.ArgumentNullException("InterfaceId cannot be null"); }
            StringBuilder GetTier0InterfaceArpTableCsvServiceURL = new StringBuilder("/infra/tier-0s/{tier-0-id}/locale-services/{locale-service-id}/interfaces/{interface-id}/arp-table?format=csv");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Get
            };
            GetTier0InterfaceArpTableCsvServiceURL.Replace("{tier-0-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(Tier0Id, System.Globalization.CultureInfo.InvariantCulture)));
            GetTier0InterfaceArpTableCsvServiceURL.Replace("{locale-service-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(LocaleServiceId, System.Globalization.CultureInfo.InvariantCulture)));
            GetTier0InterfaceArpTableCsvServiceURL.Replace("{interface-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(InterfaceId, System.Globalization.CultureInfo.InvariantCulture)));
            if (Cursor != null) { request.AddQueryParameter("cursor", Cursor.ToString()); }
            if (EdgePath != null) { request.AddQueryParameter("edge_path", EdgePath.ToString()); }
            if (EnforcementPointPath != null) { request.AddQueryParameter("enforcement_point_path", EnforcementPointPath.ToString()); }
            if (HostTransportNodePath != null) { request.AddQueryParameter("host_transport_node_path", HostTransportNodePath.ToString()); }
            if (IncludedFields != null) { request.AddQueryParameter("included_fields", IncludedFields.ToString()); }
            if (PageSize != null) { request.AddQueryParameter("page_size", PageSize.ToString()); }
            if (SortAscending != null) { request.AddQueryParameter("sort_ascending", SortAscending.ToString()); }
            if (SortBy != null) { request.AddQueryParameter("sort_by", SortBy.ToString()); }
            request.Resource = GetTier0InterfaceArpTableCsvServiceURL.ToString();
            RestResponse<NSXTInterfaceArpTableInCsvFormatType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTInterfaceArpTableInCsvFormatType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Get operation to " + GetTier0InterfaceArpTableCsvServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTInterfaceArpTableType> GetTier1RouterLinkArpTable(string Tier1Id, string? Cursor = null, string? EdgePath = null, string? EnforcementPointPath = null, string? HostTransportNodePath = null, string? IncludedFields = null, long? PageSize = null, bool? SortAscending = null, string? SortBy = null)
        {
            if (Tier1Id == null) { throw new System.ArgumentNullException("Tier1Id cannot be null"); }
            StringBuilder GetTier1RouterLinkArpTableServiceURL = new StringBuilder("/infra/tier-1s/{tier-1-id}/tier-0-interface/arp-table");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Get
            };
            GetTier1RouterLinkArpTableServiceURL.Replace("{tier-1-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(Tier1Id, System.Globalization.CultureInfo.InvariantCulture)));
            if (Cursor != null) { request.AddQueryParameter("cursor", Cursor.ToString()); }
            if (EdgePath != null) { request.AddQueryParameter("edge_path", EdgePath.ToString()); }
            if (EnforcementPointPath != null) { request.AddQueryParameter("enforcement_point_path", EnforcementPointPath.ToString()); }
            if (HostTransportNodePath != null) { request.AddQueryParameter("host_transport_node_path", HostTransportNodePath.ToString()); }
            if (IncludedFields != null) { request.AddQueryParameter("included_fields", IncludedFields.ToString()); }
            if (PageSize != null) { request.AddQueryParameter("page_size", PageSize.ToString()); }
            if (SortAscending != null) { request.AddQueryParameter("sort_ascending", SortAscending.ToString()); }
            if (SortBy != null) { request.AddQueryParameter("sort_by", SortBy.ToString()); }
            request.Resource = GetTier1RouterLinkArpTableServiceURL.ToString();
            RestResponse<NSXTInterfaceArpTableType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTInterfaceArpTableType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Get operation to " + GetTier1RouterLinkArpTableServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTPolicyArpProxyTableListResultType> GetDownlinkPortArpProxiesForInfraSegment(string SegmentId, string? Cursor = null, string? EnforcementPointPath = null, string? IncludedFields = null, long? PageSize = null, bool? SortAscending = null, string? SortBy = null, string? Source = null, string? TransportNodeId = null)
        {
            if (SegmentId == null) { throw new System.ArgumentNullException("SegmentId cannot be null"); }
            StringBuilder GetDownlinkPortArpProxiesForInfraSegmentServiceURL = new StringBuilder("/infra/segments/{segment-id}/arp-proxy");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Get
            };
            GetDownlinkPortArpProxiesForInfraSegmentServiceURL.Replace("{segment-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(SegmentId, System.Globalization.CultureInfo.InvariantCulture)));
            if (Cursor != null) { request.AddQueryParameter("cursor", Cursor.ToString()); }
            if (EnforcementPointPath != null) { request.AddQueryParameter("enforcement_point_path", EnforcementPointPath.ToString()); }
            if (IncludedFields != null) { request.AddQueryParameter("included_fields", IncludedFields.ToString()); }
            if (PageSize != null) { request.AddQueryParameter("page_size", PageSize.ToString()); }
            if (SortAscending != null) { request.AddQueryParameter("sort_ascending", SortAscending.ToString()); }
            if (SortBy != null) { request.AddQueryParameter("sort_by", SortBy.ToString()); }
            if (Source != null) { request.AddQueryParameter("source", Source.ToString()); }
            if (TransportNodeId != null) { request.AddQueryParameter("transport_node_id", TransportNodeId.ToString()); }
            request.Resource = GetDownlinkPortArpProxiesForInfraSegmentServiceURL.ToString();
            RestResponse<NSXTPolicyArpProxyTableListResultType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTPolicyArpProxyTableListResultType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Get operation to " + GetDownlinkPortArpProxiesForInfraSegmentServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTPolicyArpProxyTableListResultType> GlobalGlobalInfraGetTier1InterfaceArpProxies(string Tier1Id, string LocaleServiceId, string InterfaceId, string? Cursor = null, string? EnforcementPointPath = null, string? IncludedFields = null, long? PageSize = null, bool? SortAscending = null, string? SortBy = null, string? Source = null, string? TransportNodeId = null)
        {
            if (Tier1Id == null) { throw new System.ArgumentNullException("Tier1Id cannot be null"); }
            if (LocaleServiceId == null) { throw new System.ArgumentNullException("LocaleServiceId cannot be null"); }
            if (InterfaceId == null) { throw new System.ArgumentNullException("InterfaceId cannot be null"); }
            StringBuilder GlobalInfraGetTier1InterfaceArpProxiesServiceURL = new StringBuilder("/global-infra/tier-1s/{tier-1-id}/locale-services/{locale-service-id}/interfaces/{interface-id}/arp-proxy");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Get
            };
            GlobalInfraGetTier1InterfaceArpProxiesServiceURL.Replace("{tier-1-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(Tier1Id, System.Globalization.CultureInfo.InvariantCulture)));
            GlobalInfraGetTier1InterfaceArpProxiesServiceURL.Replace("{locale-service-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(LocaleServiceId, System.Globalization.CultureInfo.InvariantCulture)));
            GlobalInfraGetTier1InterfaceArpProxiesServiceURL.Replace("{interface-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(InterfaceId, System.Globalization.CultureInfo.InvariantCulture)));
            if (Cursor != null) { request.AddQueryParameter("cursor", Cursor.ToString()); }
            if (EnforcementPointPath != null) { request.AddQueryParameter("enforcement_point_path", EnforcementPointPath.ToString()); }
            if (IncludedFields != null) { request.AddQueryParameter("included_fields", IncludedFields.ToString()); }
            if (PageSize != null) { request.AddQueryParameter("page_size", PageSize.ToString()); }
            if (SortAscending != null) { request.AddQueryParameter("sort_ascending", SortAscending.ToString()); }
            if (SortBy != null) { request.AddQueryParameter("sort_by", SortBy.ToString()); }
            if (Source != null) { request.AddQueryParameter("source", Source.ToString()); }
            if (TransportNodeId != null) { request.AddQueryParameter("transport_node_id", TransportNodeId.ToString()); }
            request.Resource = GlobalInfraGetTier1InterfaceArpProxiesServiceURL.ToString();
            RestResponse<NSXTPolicyArpProxyTableListResultType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTPolicyArpProxyTableListResultType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Get operation to " + GlobalInfraGetTier1InterfaceArpProxiesServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTInterfaceArpTableInCsvFormatType> GlobalGlobalInfraGetDownlinkPortArpTableForInfraSegmentInCsv(string SegmentId, string? Cursor = null, string? EdgePath = null, string? EnforcementPointPath = null, string? HostTransportNodePath = null, string? IncludedFields = null, long? PageSize = null, bool? SortAscending = null, string? SortBy = null)
        {
            if (SegmentId == null) { throw new System.ArgumentNullException("SegmentId cannot be null"); }
            StringBuilder GlobalInfraGetDownlinkPortArpTableForInfraSegmentInCsvServiceURL = new StringBuilder("/global-infra/segments/{segment-id}/gateway-interface-arp-table?format=csv");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Get
            };
            GlobalInfraGetDownlinkPortArpTableForInfraSegmentInCsvServiceURL.Replace("{segment-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(SegmentId, System.Globalization.CultureInfo.InvariantCulture)));
            if (Cursor != null) { request.AddQueryParameter("cursor", Cursor.ToString()); }
            if (EdgePath != null) { request.AddQueryParameter("edge_path", EdgePath.ToString()); }
            if (EnforcementPointPath != null) { request.AddQueryParameter("enforcement_point_path", EnforcementPointPath.ToString()); }
            if (HostTransportNodePath != null) { request.AddQueryParameter("host_transport_node_path", HostTransportNodePath.ToString()); }
            if (IncludedFields != null) { request.AddQueryParameter("included_fields", IncludedFields.ToString()); }
            if (PageSize != null) { request.AddQueryParameter("page_size", PageSize.ToString()); }
            if (SortAscending != null) { request.AddQueryParameter("sort_ascending", SortAscending.ToString()); }
            if (SortBy != null) { request.AddQueryParameter("sort_by", SortBy.ToString()); }
            request.Resource = GlobalInfraGetDownlinkPortArpTableForInfraSegmentInCsvServiceURL.ToString();
            RestResponse<NSXTInterfaceArpTableInCsvFormatType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTInterfaceArpTableInCsvFormatType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Get operation to " + GlobalInfraGetDownlinkPortArpTableForInfraSegmentInCsvServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTDhcpStaticBindingStateType> GlobalGlobalInfraReadSegmentDhcpStaticBindingState(string Tier1Id, string SegmentId, string BindingId)
        {
            if (Tier1Id == null) { throw new System.ArgumentNullException("Tier1Id cannot be null"); }
            if (SegmentId == null) { throw new System.ArgumentNullException("SegmentId cannot be null"); }
            if (BindingId == null) { throw new System.ArgumentNullException("BindingId cannot be null"); }
            StringBuilder GlobalInfraReadSegmentDhcpStaticBindingStateServiceURL = new StringBuilder("/global-infra/tier-1s/{tier-1-id}/segments/{segment-id}/dhcp-static-bindings/{binding-id}/state");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Get
            };
            GlobalInfraReadSegmentDhcpStaticBindingStateServiceURL.Replace("{tier-1-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(Tier1Id, System.Globalization.CultureInfo.InvariantCulture)));
            GlobalInfraReadSegmentDhcpStaticBindingStateServiceURL.Replace("{segment-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(SegmentId, System.Globalization.CultureInfo.InvariantCulture)));
            GlobalInfraReadSegmentDhcpStaticBindingStateServiceURL.Replace("{binding-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(BindingId, System.Globalization.CultureInfo.InvariantCulture)));
            request.Resource = GlobalInfraReadSegmentDhcpStaticBindingStateServiceURL.ToString();
            RestResponse<NSXTDhcpStaticBindingStateType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTDhcpStaticBindingStateType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Get operation to " + GlobalInfraReadSegmentDhcpStaticBindingStateServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTSegmentPortStatisticsType> GetSegmentPortStatistics(string Tier1Id, string SegmentsId, string PortId, string? Cursor = null, string? EdgePath = null, string? EnforcementPointPath = null, bool? IncludeMarkForDeleteObjects = null, string? IncludedFields = null, long? PageSize = null, bool? SortAscending = null, string? SortBy = null)
        {
            if (Tier1Id == null) { throw new System.ArgumentNullException("Tier1Id cannot be null"); }
            if (SegmentsId == null) { throw new System.ArgumentNullException("SegmentsId cannot be null"); }
            if (PortId == null) { throw new System.ArgumentNullException("PortId cannot be null"); }
            StringBuilder GetSegmentPortStatisticsServiceURL = new StringBuilder("/infra/tier-1s/{tier-1-id}/segments/{segments-id}/ports/{port-id}/statistics");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Get
            };
            GetSegmentPortStatisticsServiceURL.Replace("{tier-1-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(Tier1Id, System.Globalization.CultureInfo.InvariantCulture)));
            GetSegmentPortStatisticsServiceURL.Replace("{segments-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(SegmentsId, System.Globalization.CultureInfo.InvariantCulture)));
            GetSegmentPortStatisticsServiceURL.Replace("{port-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(PortId, System.Globalization.CultureInfo.InvariantCulture)));
            if (Cursor != null) { request.AddQueryParameter("cursor", Cursor.ToString()); }
            if (EdgePath != null) { request.AddQueryParameter("edge_path", EdgePath.ToString()); }
            if (EnforcementPointPath != null) { request.AddQueryParameter("enforcement_point_path", EnforcementPointPath.ToString()); }
            if (IncludeMarkForDeleteObjects != null) { request.AddQueryParameter("include_mark_for_delete_objects", IncludeMarkForDeleteObjects.ToString()); }
            if (IncludedFields != null) { request.AddQueryParameter("included_fields", IncludedFields.ToString()); }
            if (PageSize != null) { request.AddQueryParameter("page_size", PageSize.ToString()); }
            if (SortAscending != null) { request.AddQueryParameter("sort_ascending", SortAscending.ToString()); }
            if (SortBy != null) { request.AddQueryParameter("sort_by", SortBy.ToString()); }
            request.Resource = GetSegmentPortStatisticsServiceURL.ToString();
            RestResponse<NSXTSegmentPortStatisticsType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTSegmentPortStatisticsType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Get operation to " + GetSegmentPortStatisticsServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTPolicyInterfaceStatisticsType> GetTier1RouterLinkStatistics(string Tier1Id, string? Cursor = null, string? EdgePath = null, string? EnforcementPointPath = null, bool? IncludeMarkForDeleteObjects = null, string? IncludedFields = null, long? PageSize = null, bool? SortAscending = null, string? SortBy = null)
        {
            if (Tier1Id == null) { throw new System.ArgumentNullException("Tier1Id cannot be null"); }
            StringBuilder GetTier1RouterLinkStatisticsServiceURL = new StringBuilder("/infra/tier-1s/{tier-1-id}/tier-0-interface/statistics");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Get
            };
            GetTier1RouterLinkStatisticsServiceURL.Replace("{tier-1-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(Tier1Id, System.Globalization.CultureInfo.InvariantCulture)));
            if (Cursor != null) { request.AddQueryParameter("cursor", Cursor.ToString()); }
            if (EdgePath != null) { request.AddQueryParameter("edge_path", EdgePath.ToString()); }
            if (EnforcementPointPath != null) { request.AddQueryParameter("enforcement_point_path", EnforcementPointPath.ToString()); }
            if (IncludeMarkForDeleteObjects != null) { request.AddQueryParameter("include_mark_for_delete_objects", IncludeMarkForDeleteObjects.ToString()); }
            if (IncludedFields != null) { request.AddQueryParameter("included_fields", IncludedFields.ToString()); }
            if (PageSize != null) { request.AddQueryParameter("page_size", PageSize.ToString()); }
            if (SortAscending != null) { request.AddQueryParameter("sort_ascending", SortAscending.ToString()); }
            if (SortBy != null) { request.AddQueryParameter("sort_by", SortBy.ToString()); }
            request.Resource = GetTier1RouterLinkStatisticsServiceURL.ToString();
            RestResponse<NSXTPolicyInterfaceStatisticsType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTPolicyInterfaceStatisticsType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Get operation to " + GetTier1RouterLinkStatisticsServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTPolicyArpProxyTableCsvListResultType> GetTier0InterfaceArpProxiesInCsv(string Tier0Id, string LocaleServiceId, string InterfaceId, string? EnforcementPointPath = null, string? Source = null, string? TransportNodeId = null)
        {
            if (Tier0Id == null) { throw new System.ArgumentNullException("Tier0Id cannot be null"); }
            if (LocaleServiceId == null) { throw new System.ArgumentNullException("LocaleServiceId cannot be null"); }
            if (InterfaceId == null) { throw new System.ArgumentNullException("InterfaceId cannot be null"); }
            StringBuilder GetTier0InterfaceArpProxiesInCsvServiceURL = new StringBuilder("/infra/tier-0s/{tier-0-id}/locale-services/{locale-service-id}/interfaces/{interface-id}/arp-proxy?format=csv");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Get
            };
            GetTier0InterfaceArpProxiesInCsvServiceURL.Replace("{tier-0-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(Tier0Id, System.Globalization.CultureInfo.InvariantCulture)));
            GetTier0InterfaceArpProxiesInCsvServiceURL.Replace("{locale-service-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(LocaleServiceId, System.Globalization.CultureInfo.InvariantCulture)));
            GetTier0InterfaceArpProxiesInCsvServiceURL.Replace("{interface-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(InterfaceId, System.Globalization.CultureInfo.InvariantCulture)));
            if (EnforcementPointPath != null) { request.AddQueryParameter("enforcement_point_path", EnforcementPointPath.ToString()); }
            if (Source != null) { request.AddQueryParameter("source", Source.ToString()); }
            if (TransportNodeId != null) { request.AddQueryParameter("transport_node_id", TransportNodeId.ToString()); }
            request.Resource = GetTier0InterfaceArpProxiesInCsvServiceURL.ToString();
            RestResponse<NSXTPolicyArpProxyTableCsvListResultType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTPolicyArpProxyTableCsvListResultType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Get operation to " + GetTier0InterfaceArpProxiesInCsvServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTPolicyArpProxyTableListResultType> GetTier1InterfaceArpProxies(string Tier1Id, string LocaleServiceId, string InterfaceId, string? Cursor = null, string? EnforcementPointPath = null, string? IncludedFields = null, long? PageSize = null, bool? SortAscending = null, string? SortBy = null, string? Source = null, string? TransportNodeId = null)
        {
            if (Tier1Id == null) { throw new System.ArgumentNullException("Tier1Id cannot be null"); }
            if (LocaleServiceId == null) { throw new System.ArgumentNullException("LocaleServiceId cannot be null"); }
            if (InterfaceId == null) { throw new System.ArgumentNullException("InterfaceId cannot be null"); }
            StringBuilder GetTier1InterfaceArpProxiesServiceURL = new StringBuilder("/infra/tier-1s/{tier-1-id}/locale-services/{locale-service-id}/interfaces/{interface-id}/arp-proxy");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Get
            };
            GetTier1InterfaceArpProxiesServiceURL.Replace("{tier-1-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(Tier1Id, System.Globalization.CultureInfo.InvariantCulture)));
            GetTier1InterfaceArpProxiesServiceURL.Replace("{locale-service-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(LocaleServiceId, System.Globalization.CultureInfo.InvariantCulture)));
            GetTier1InterfaceArpProxiesServiceURL.Replace("{interface-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(InterfaceId, System.Globalization.CultureInfo.InvariantCulture)));
            if (Cursor != null) { request.AddQueryParameter("cursor", Cursor.ToString()); }
            if (EnforcementPointPath != null) { request.AddQueryParameter("enforcement_point_path", EnforcementPointPath.ToString()); }
            if (IncludedFields != null) { request.AddQueryParameter("included_fields", IncludedFields.ToString()); }
            if (PageSize != null) { request.AddQueryParameter("page_size", PageSize.ToString()); }
            if (SortAscending != null) { request.AddQueryParameter("sort_ascending", SortAscending.ToString()); }
            if (SortBy != null) { request.AddQueryParameter("sort_by", SortBy.ToString()); }
            if (Source != null) { request.AddQueryParameter("source", Source.ToString()); }
            if (TransportNodeId != null) { request.AddQueryParameter("transport_node_id", TransportNodeId.ToString()); }
            request.Resource = GetTier1InterfaceArpProxiesServiceURL.ToString();
            RestResponse<NSXTPolicyArpProxyTableListResultType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTPolicyArpProxyTableListResultType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Get operation to " + GetTier1InterfaceArpProxiesServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTInterfaceDADStateType> GlobalGlobalInfraGetDownlinkPortDadStateForInfraSegment(string SegmentId, string? EnforcementPointPath = null, string? Source = null)
        {
            if (SegmentId == null) { throw new System.ArgumentNullException("SegmentId cannot be null"); }
            StringBuilder GlobalInfraGetDownlinkPortDadStateForInfraSegmentServiceURL = new StringBuilder("/global-infra/segments/{segment-id}/gateway-interface-dad-state");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Get
            };
            GlobalInfraGetDownlinkPortDadStateForInfraSegmentServiceURL.Replace("{segment-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(SegmentId, System.Globalization.CultureInfo.InvariantCulture)));
            if (EnforcementPointPath != null) { request.AddQueryParameter("enforcement_point_path", EnforcementPointPath.ToString()); }
            if (Source != null) { request.AddQueryParameter("source", Source.ToString()); }
            request.Resource = GlobalInfraGetDownlinkPortDadStateForInfraSegmentServiceURL.ToString();
            RestResponse<NSXTInterfaceDADStateType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTInterfaceDADStateType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Get operation to " + GlobalInfraGetDownlinkPortDadStateForInfraSegmentServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTSegmentPortStateType> GlobalGlobalInfraGetInfraSegmentPortState(string SegmentId, string PortId, string? EnforcementPointPath = null, string? Source = null)
        {
            if (SegmentId == null) { throw new System.ArgumentNullException("SegmentId cannot be null"); }
            if (PortId == null) { throw new System.ArgumentNullException("PortId cannot be null"); }
            StringBuilder GlobalInfraGetInfraSegmentPortStateServiceURL = new StringBuilder("/global-infra/segments/{segment-id}/ports/{port-id}/state");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Get
            };
            GlobalInfraGetInfraSegmentPortStateServiceURL.Replace("{segment-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(SegmentId, System.Globalization.CultureInfo.InvariantCulture)));
            GlobalInfraGetInfraSegmentPortStateServiceURL.Replace("{port-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(PortId, System.Globalization.CultureInfo.InvariantCulture)));
            if (EnforcementPointPath != null) { request.AddQueryParameter("enforcement_point_path", EnforcementPointPath.ToString()); }
            if (Source != null) { request.AddQueryParameter("source", Source.ToString()); }
            request.Resource = GlobalInfraGetInfraSegmentPortStateServiceURL.ToString();
            RestResponse<NSXTSegmentPortStateType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTSegmentPortStateType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Get operation to " + GlobalInfraGetInfraSegmentPortStateServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTPolicyArpProxyTableListResultType> GetTier0ArpProxies(string Tier0Id, string LocaleServiceId, string? Cursor = null, string? EnforcementPointPath = null, string? IncludedFields = null, long? PageSize = null, bool? SortAscending = null, string? SortBy = null, string? Source = null, string? TransportNodeId = null)
        {
            if (Tier0Id == null) { throw new System.ArgumentNullException("Tier0Id cannot be null"); }
            if (LocaleServiceId == null) { throw new System.ArgumentNullException("LocaleServiceId cannot be null"); }
            StringBuilder GetTier0ArpProxiesServiceURL = new StringBuilder("/infra/tier-0s/{tier-0-id}/locale-services/{locale-service-id}/arp-proxies");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Get
            };
            GetTier0ArpProxiesServiceURL.Replace("{tier-0-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(Tier0Id, System.Globalization.CultureInfo.InvariantCulture)));
            GetTier0ArpProxiesServiceURL.Replace("{locale-service-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(LocaleServiceId, System.Globalization.CultureInfo.InvariantCulture)));
            if (Cursor != null) { request.AddQueryParameter("cursor", Cursor.ToString()); }
            if (EnforcementPointPath != null) { request.AddQueryParameter("enforcement_point_path", EnforcementPointPath.ToString()); }
            if (IncludedFields != null) { request.AddQueryParameter("included_fields", IncludedFields.ToString()); }
            if (PageSize != null) { request.AddQueryParameter("page_size", PageSize.ToString()); }
            if (SortAscending != null) { request.AddQueryParameter("sort_ascending", SortAscending.ToString()); }
            if (SortBy != null) { request.AddQueryParameter("sort_by", SortBy.ToString()); }
            if (Source != null) { request.AddQueryParameter("source", Source.ToString()); }
            if (TransportNodeId != null) { request.AddQueryParameter("transport_node_id", TransportNodeId.ToString()); }
            request.Resource = GetTier0ArpProxiesServiceURL.ToString();
            RestResponse<NSXTPolicyArpProxyTableListResultType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTPolicyArpProxyTableListResultType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Get operation to " + GetTier0ArpProxiesServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTBgpNeighborRouteDetailsInCsvFormatType> GetTier0BgpNeighborRoutesInCsvFormat(string Tier0Id, string LocaleServiceId, string NeighborId, int? Count = null, string? Cursor = null, string? EnforcementPointPath = null, string? IncludedFields = null, long? PageSize = null, bool? SortAscending = null, string? SortBy = null)
        {
            if (Tier0Id == null) { throw new System.ArgumentNullException("Tier0Id cannot be null"); }
            if (LocaleServiceId == null) { throw new System.ArgumentNullException("LocaleServiceId cannot be null"); }
            if (NeighborId == null) { throw new System.ArgumentNullException("NeighborId cannot be null"); }
            StringBuilder GetTier0BgpNeighborRoutesInCsvFormatServiceURL = new StringBuilder("/infra/tier-0s/{tier-0-id}/locale-services/{locale-service-id}/bgp/neighbors/{neighbor-id}/routes?format=csv");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Get
            };
            GetTier0BgpNeighborRoutesInCsvFormatServiceURL.Replace("{tier-0-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(Tier0Id, System.Globalization.CultureInfo.InvariantCulture)));
            GetTier0BgpNeighborRoutesInCsvFormatServiceURL.Replace("{locale-service-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(LocaleServiceId, System.Globalization.CultureInfo.InvariantCulture)));
            GetTier0BgpNeighborRoutesInCsvFormatServiceURL.Replace("{neighbor-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(NeighborId, System.Globalization.CultureInfo.InvariantCulture)));
            if (Count != null) { request.AddQueryParameter("count", Count.ToString()); }
            if (Cursor != null) { request.AddQueryParameter("cursor", Cursor.ToString()); }
            if (EnforcementPointPath != null) { request.AddQueryParameter("enforcement_point_path", EnforcementPointPath.ToString()); }
            if (IncludedFields != null) { request.AddQueryParameter("included_fields", IncludedFields.ToString()); }
            if (PageSize != null) { request.AddQueryParameter("page_size", PageSize.ToString()); }
            if (SortAscending != null) { request.AddQueryParameter("sort_ascending", SortAscending.ToString()); }
            if (SortBy != null) { request.AddQueryParameter("sort_by", SortBy.ToString()); }
            request.Resource = GetTier0BgpNeighborRoutesInCsvFormatServiceURL.ToString();
            RestResponse<NSXTBgpNeighborRouteDetailsInCsvFormatType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTBgpNeighborRouteDetailsInCsvFormatType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Get operation to " + GetTier0BgpNeighborRoutesInCsvFormatServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTBgpNeighborRoutesListResultType> GetTier0BgpNeighborRoutes(string Tier0Id, string LocaleServiceId, string NeighborId, int? Count = null, string? Cursor = null, string? EnforcementPointPath = null, string? IncludedFields = null, long? PageSize = null, bool? SortAscending = null, string? SortBy = null)
        {
            if (Tier0Id == null) { throw new System.ArgumentNullException("Tier0Id cannot be null"); }
            if (LocaleServiceId == null) { throw new System.ArgumentNullException("LocaleServiceId cannot be null"); }
            if (NeighborId == null) { throw new System.ArgumentNullException("NeighborId cannot be null"); }
            StringBuilder GetTier0BgpNeighborRoutesServiceURL = new StringBuilder("/infra/tier-0s/{tier-0-id}/locale-services/{locale-service-id}/bgp/neighbors/{neighbor-id}/routes");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Get
            };
            GetTier0BgpNeighborRoutesServiceURL.Replace("{tier-0-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(Tier0Id, System.Globalization.CultureInfo.InvariantCulture)));
            GetTier0BgpNeighborRoutesServiceURL.Replace("{locale-service-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(LocaleServiceId, System.Globalization.CultureInfo.InvariantCulture)));
            GetTier0BgpNeighborRoutesServiceURL.Replace("{neighbor-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(NeighborId, System.Globalization.CultureInfo.InvariantCulture)));
            if (Count != null) { request.AddQueryParameter("count", Count.ToString()); }
            if (Cursor != null) { request.AddQueryParameter("cursor", Cursor.ToString()); }
            if (EnforcementPointPath != null) { request.AddQueryParameter("enforcement_point_path", EnforcementPointPath.ToString()); }
            if (IncludedFields != null) { request.AddQueryParameter("included_fields", IncludedFields.ToString()); }
            if (PageSize != null) { request.AddQueryParameter("page_size", PageSize.ToString()); }
            if (SortAscending != null) { request.AddQueryParameter("sort_ascending", SortAscending.ToString()); }
            if (SortBy != null) { request.AddQueryParameter("sort_by", SortBy.ToString()); }
            request.Resource = GetTier0BgpNeighborRoutesServiceURL.ToString();
            RestResponse<NSXTBgpNeighborRoutesListResultType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTBgpNeighborRoutesListResultType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Get operation to " + GetTier0BgpNeighborRoutesServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTInterfaceArpTableType> GlobalGlobalInfraGetTier1RouterLinkArpTable(string Tier1Id, string? Cursor = null, string? EdgePath = null, string? EnforcementPointPath = null, string? HostTransportNodePath = null, string? IncludedFields = null, long? PageSize = null, bool? SortAscending = null, string? SortBy = null)
        {
            if (Tier1Id == null) { throw new System.ArgumentNullException("Tier1Id cannot be null"); }
            StringBuilder GlobalInfraGetTier1RouterLinkArpTableServiceURL = new StringBuilder("/global-infra/tier-1s/{tier-1-id}/tier-0-interface/arp-table");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Get
            };
            GlobalInfraGetTier1RouterLinkArpTableServiceURL.Replace("{tier-1-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(Tier1Id, System.Globalization.CultureInfo.InvariantCulture)));
            if (Cursor != null) { request.AddQueryParameter("cursor", Cursor.ToString()); }
            if (EdgePath != null) { request.AddQueryParameter("edge_path", EdgePath.ToString()); }
            if (EnforcementPointPath != null) { request.AddQueryParameter("enforcement_point_path", EnforcementPointPath.ToString()); }
            if (HostTransportNodePath != null) { request.AddQueryParameter("host_transport_node_path", HostTransportNodePath.ToString()); }
            if (IncludedFields != null) { request.AddQueryParameter("included_fields", IncludedFields.ToString()); }
            if (PageSize != null) { request.AddQueryParameter("page_size", PageSize.ToString()); }
            if (SortAscending != null) { request.AddQueryParameter("sort_ascending", SortAscending.ToString()); }
            if (SortBy != null) { request.AddQueryParameter("sort_by", SortBy.ToString()); }
            request.Resource = GlobalInfraGetTier1RouterLinkArpTableServiceURL.ToString();
            RestResponse<NSXTInterfaceArpTableType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTInterfaceArpTableType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Get operation to " + GlobalInfraGetTier1RouterLinkArpTableServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTInterfaceArpTableType> GlobalGlobalInfraGetSegmentInterfaceArpTable(string Tier1Id, string SegmentId, string? Cursor = null, string? EdgePath = null, string? EnforcementPointPath = null, string? HostTransportNodePath = null, string? IncludedFields = null, long? PageSize = null, bool? SortAscending = null, string? SortBy = null)
        {
            if (Tier1Id == null) { throw new System.ArgumentNullException("Tier1Id cannot be null"); }
            if (SegmentId == null) { throw new System.ArgumentNullException("SegmentId cannot be null"); }
            StringBuilder GlobalInfraGetSegmentInterfaceArpTableServiceURL = new StringBuilder("/global-infra/tier-1s/{tier-1-id}/segments/{segment-id}/arp-table");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Get
            };
            GlobalInfraGetSegmentInterfaceArpTableServiceURL.Replace("{tier-1-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(Tier1Id, System.Globalization.CultureInfo.InvariantCulture)));
            GlobalInfraGetSegmentInterfaceArpTableServiceURL.Replace("{segment-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(SegmentId, System.Globalization.CultureInfo.InvariantCulture)));
            if (Cursor != null) { request.AddQueryParameter("cursor", Cursor.ToString()); }
            if (EdgePath != null) { request.AddQueryParameter("edge_path", EdgePath.ToString()); }
            if (EnforcementPointPath != null) { request.AddQueryParameter("enforcement_point_path", EnforcementPointPath.ToString()); }
            if (HostTransportNodePath != null) { request.AddQueryParameter("host_transport_node_path", HostTransportNodePath.ToString()); }
            if (IncludedFields != null) { request.AddQueryParameter("included_fields", IncludedFields.ToString()); }
            if (PageSize != null) { request.AddQueryParameter("page_size", PageSize.ToString()); }
            if (SortAscending != null) { request.AddQueryParameter("sort_ascending", SortAscending.ToString()); }
            if (SortBy != null) { request.AddQueryParameter("sort_by", SortBy.ToString()); }
            request.Resource = GlobalInfraGetSegmentInterfaceArpTableServiceURL.ToString();
            RestResponse<NSXTInterfaceArpTableType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTInterfaceArpTableType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Get operation to " + GlobalInfraGetSegmentInterfaceArpTableServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTSegmentStatisticsType> GetInfraSegmentStatistics(string SegmentsId, string? Cursor = null, string? EdgePath = null, string? EnforcementPointPath = null, bool? IncludeMarkForDeleteObjects = null, string? IncludedFields = null, long? PageSize = null, bool? SortAscending = null, string? SortBy = null)
        {
            if (SegmentsId == null) { throw new System.ArgumentNullException("SegmentsId cannot be null"); }
            StringBuilder GetInfraSegmentStatisticsServiceURL = new StringBuilder("/infra/segments/{segments-id}/statistics");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Get
            };
            GetInfraSegmentStatisticsServiceURL.Replace("{segments-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(SegmentsId, System.Globalization.CultureInfo.InvariantCulture)));
            if (Cursor != null) { request.AddQueryParameter("cursor", Cursor.ToString()); }
            if (EdgePath != null) { request.AddQueryParameter("edge_path", EdgePath.ToString()); }
            if (EnforcementPointPath != null) { request.AddQueryParameter("enforcement_point_path", EnforcementPointPath.ToString()); }
            if (IncludeMarkForDeleteObjects != null) { request.AddQueryParameter("include_mark_for_delete_objects", IncludeMarkForDeleteObjects.ToString()); }
            if (IncludedFields != null) { request.AddQueryParameter("included_fields", IncludedFields.ToString()); }
            if (PageSize != null) { request.AddQueryParameter("page_size", PageSize.ToString()); }
            if (SortAscending != null) { request.AddQueryParameter("sort_ascending", SortAscending.ToString()); }
            if (SortBy != null) { request.AddQueryParameter("sort_by", SortBy.ToString()); }
            request.Resource = GetInfraSegmentStatisticsServiceURL.ToString();
            RestResponse<NSXTSegmentStatisticsType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTSegmentStatisticsType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Get operation to " + GetInfraSegmentStatisticsServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTPolicyOspfDatabaseListResultType> GetOspfDatabase(string Tier0Id, string LocaleServiceId, string? AreaId = null, string? Cursor = null, string? EdgePath = null, string? IncludedFields = null, long? PageSize = null, bool? SortAscending = null, string? SortBy = null)
        {
            if (Tier0Id == null) { throw new System.ArgumentNullException("Tier0Id cannot be null"); }
            if (LocaleServiceId == null) { throw new System.ArgumentNullException("LocaleServiceId cannot be null"); }
            StringBuilder GetOspfDatabaseServiceURL = new StringBuilder("/infra/tier-0s/{tier-0-id}/locale-services/{locale-service-id}/ospf/database");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Get
            };
            GetOspfDatabaseServiceURL.Replace("{tier-0-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(Tier0Id, System.Globalization.CultureInfo.InvariantCulture)));
            GetOspfDatabaseServiceURL.Replace("{locale-service-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(LocaleServiceId, System.Globalization.CultureInfo.InvariantCulture)));
            if (AreaId != null) { request.AddQueryParameter("area_id", AreaId.ToString()); }
            if (Cursor != null) { request.AddQueryParameter("cursor", Cursor.ToString()); }
            if (EdgePath != null) { request.AddQueryParameter("edge_path", EdgePath.ToString()); }
            if (IncludedFields != null) { request.AddQueryParameter("included_fields", IncludedFields.ToString()); }
            if (PageSize != null) { request.AddQueryParameter("page_size", PageSize.ToString()); }
            if (SortAscending != null) { request.AddQueryParameter("sort_ascending", SortAscending.ToString()); }
            if (SortBy != null) { request.AddQueryParameter("sort_by", SortBy.ToString()); }
            request.Resource = GetOspfDatabaseServiceURL.ToString();
            RestResponse<NSXTPolicyOspfDatabaseListResultType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTPolicyOspfDatabaseListResultType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Get operation to " + GetOspfDatabaseServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTTier1GatewayStateType> GlobalGlobalInfraGetTier1State(string Tier1Id, string? Cursor = null, string? EnforcementPointPath = null, string? IncludedFields = null, string? InterfacePath = null, long? PageSize = null, bool? SortAscending = null, string? SortBy = null, string? Type = null)
        {
            if (Tier1Id == null) { throw new System.ArgumentNullException("Tier1Id cannot be null"); }
            StringBuilder GlobalInfraGetTier1StateServiceURL = new StringBuilder("/global-infra/tier-1s/{tier-1-id}/state");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Get
            };
            GlobalInfraGetTier1StateServiceURL.Replace("{tier-1-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(Tier1Id, System.Globalization.CultureInfo.InvariantCulture)));
            if (Cursor != null) { request.AddQueryParameter("cursor", Cursor.ToString()); }
            if (EnforcementPointPath != null) { request.AddQueryParameter("enforcement_point_path", EnforcementPointPath.ToString()); }
            if (IncludedFields != null) { request.AddQueryParameter("included_fields", IncludedFields.ToString()); }
            if (InterfacePath != null) { request.AddQueryParameter("interface_path", InterfacePath.ToString()); }
            if (PageSize != null) { request.AddQueryParameter("page_size", PageSize.ToString()); }
            if (SortAscending != null) { request.AddQueryParameter("sort_ascending", SortAscending.ToString()); }
            if (SortBy != null) { request.AddQueryParameter("sort_by", SortBy.ToString()); }
            if (Type != null) { request.AddQueryParameter("type", Type.ToString()); }
            request.Resource = GlobalInfraGetTier1StateServiceURL.ToString();
            RestResponse<NSXTTier1GatewayStateType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTTier1GatewayStateType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Get operation to " + GlobalInfraGetTier1StateServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTSegmentStatisticsType> GlobalGlobalInfraGetInfraSegmentStatistics(string SegmentsId, string? Cursor = null, string? EdgePath = null, string? EnforcementPointPath = null, bool? IncludeMarkForDeleteObjects = null, string? IncludedFields = null, long? PageSize = null, bool? SortAscending = null, string? SortBy = null)
        {
            if (SegmentsId == null) { throw new System.ArgumentNullException("SegmentsId cannot be null"); }
            StringBuilder GlobalInfraGetInfraSegmentStatisticsServiceURL = new StringBuilder("/global-infra/segments/{segments-id}/statistics");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Get
            };
            GlobalInfraGetInfraSegmentStatisticsServiceURL.Replace("{segments-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(SegmentsId, System.Globalization.CultureInfo.InvariantCulture)));
            if (Cursor != null) { request.AddQueryParameter("cursor", Cursor.ToString()); }
            if (EdgePath != null) { request.AddQueryParameter("edge_path", EdgePath.ToString()); }
            if (EnforcementPointPath != null) { request.AddQueryParameter("enforcement_point_path", EnforcementPointPath.ToString()); }
            if (IncludeMarkForDeleteObjects != null) { request.AddQueryParameter("include_mark_for_delete_objects", IncludeMarkForDeleteObjects.ToString()); }
            if (IncludedFields != null) { request.AddQueryParameter("included_fields", IncludedFields.ToString()); }
            if (PageSize != null) { request.AddQueryParameter("page_size", PageSize.ToString()); }
            if (SortAscending != null) { request.AddQueryParameter("sort_ascending", SortAscending.ToString()); }
            if (SortBy != null) { request.AddQueryParameter("sort_by", SortBy.ToString()); }
            request.Resource = GlobalInfraGetInfraSegmentStatisticsServiceURL.ToString();
            RestResponse<NSXTSegmentStatisticsType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTSegmentStatisticsType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Get operation to " + GlobalInfraGetInfraSegmentStatisticsServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTInterfaceArpTableType> GlobalGlobalInfraGetTier0RouterLinkArpTable(string Tier0Id, string Tier1Path, string? Cursor = null, string? EdgePath = null, string? EnforcementPointPath = null, bool? IncludeMarkForDeleteObjects = null, string? IncludedFields = null, long? PageSize = null, bool? SortAscending = null, string? SortBy = null)
        {
            if (Tier0Id == null) { throw new System.ArgumentNullException("Tier0Id cannot be null"); }
            if (Tier1Path == null) { throw new System.ArgumentNullException("Tier1Path cannot be null"); }
            StringBuilder GlobalInfraGetTier0RouterLinkArpTableServiceURL = new StringBuilder("/global-infra/tier-0s/{tier-0-id}/tier-1-interface/arp-table");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Get
            };
            GlobalInfraGetTier0RouterLinkArpTableServiceURL.Replace("{tier-0-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(Tier0Id, System.Globalization.CultureInfo.InvariantCulture)));
            if (Cursor != null) { request.AddQueryParameter("cursor", Cursor.ToString()); }
            if (EdgePath != null) { request.AddQueryParameter("edge_path", EdgePath.ToString()); }
            if (EnforcementPointPath != null) { request.AddQueryParameter("enforcement_point_path", EnforcementPointPath.ToString()); }
            if (IncludeMarkForDeleteObjects != null) { request.AddQueryParameter("include_mark_for_delete_objects", IncludeMarkForDeleteObjects.ToString()); }
            if (IncludedFields != null) { request.AddQueryParameter("included_fields", IncludedFields.ToString()); }
            if (PageSize != null) { request.AddQueryParameter("page_size", PageSize.ToString()); }
            if (SortAscending != null) { request.AddQueryParameter("sort_ascending", SortAscending.ToString()); }
            if (SortBy != null) { request.AddQueryParameter("sort_by", SortBy.ToString()); }
            if (Tier1Path != null) { request.AddQueryParameter("tier1_path", Tier1Path.ToString()); }
            request.Resource = GlobalInfraGetTier0RouterLinkArpTableServiceURL.ToString();
            RestResponse<NSXTInterfaceArpTableType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTInterfaceArpTableType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Get operation to " + GlobalInfraGetTier0RouterLinkArpTableServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTSegmentPortStatisticsType> GlobalGlobalInfraGetSegmentPortStatistics(string Tier1Id, string SegmentsId, string PortId, string? Cursor = null, string? EdgePath = null, string? EnforcementPointPath = null, bool? IncludeMarkForDeleteObjects = null, string? IncludedFields = null, long? PageSize = null, bool? SortAscending = null, string? SortBy = null)
        {
            if (Tier1Id == null) { throw new System.ArgumentNullException("Tier1Id cannot be null"); }
            if (SegmentsId == null) { throw new System.ArgumentNullException("SegmentsId cannot be null"); }
            if (PortId == null) { throw new System.ArgumentNullException("PortId cannot be null"); }
            StringBuilder GlobalInfraGetSegmentPortStatisticsServiceURL = new StringBuilder("/global-infra/tier-1s/{tier-1-id}/segments/{segments-id}/ports/{port-id}/statistics");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Get
            };
            GlobalInfraGetSegmentPortStatisticsServiceURL.Replace("{tier-1-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(Tier1Id, System.Globalization.CultureInfo.InvariantCulture)));
            GlobalInfraGetSegmentPortStatisticsServiceURL.Replace("{segments-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(SegmentsId, System.Globalization.CultureInfo.InvariantCulture)));
            GlobalInfraGetSegmentPortStatisticsServiceURL.Replace("{port-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(PortId, System.Globalization.CultureInfo.InvariantCulture)));
            if (Cursor != null) { request.AddQueryParameter("cursor", Cursor.ToString()); }
            if (EdgePath != null) { request.AddQueryParameter("edge_path", EdgePath.ToString()); }
            if (EnforcementPointPath != null) { request.AddQueryParameter("enforcement_point_path", EnforcementPointPath.ToString()); }
            if (IncludeMarkForDeleteObjects != null) { request.AddQueryParameter("include_mark_for_delete_objects", IncludeMarkForDeleteObjects.ToString()); }
            if (IncludedFields != null) { request.AddQueryParameter("included_fields", IncludedFields.ToString()); }
            if (PageSize != null) { request.AddQueryParameter("page_size", PageSize.ToString()); }
            if (SortAscending != null) { request.AddQueryParameter("sort_ascending", SortAscending.ToString()); }
            if (SortBy != null) { request.AddQueryParameter("sort_by", SortBy.ToString()); }
            request.Resource = GlobalInfraGetSegmentPortStatisticsServiceURL.ToString();
            RestResponse<NSXTSegmentPortStatisticsType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTSegmentPortStatisticsType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Get operation to " + GlobalInfraGetSegmentPortStatisticsServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTSegmentPortMacAddressCsvListResultType> GetTier1SegmentPortMacTableInCsv(string Tier1Id, string SegmentId, string PortId, string? EnforcementPointPath = null, string? Source = null, string? TransportNodeId = null)
        {
            if (Tier1Id == null) { throw new System.ArgumentNullException("Tier1Id cannot be null"); }
            if (SegmentId == null) { throw new System.ArgumentNullException("SegmentId cannot be null"); }
            if (PortId == null) { throw new System.ArgumentNullException("PortId cannot be null"); }
            StringBuilder GetTier1SegmentPortMacTableInCsvServiceURL = new StringBuilder("/infra/tier-1s/{tier-1-id}/segments/{segment-id}/ports/{port-id}/mac-table?format=csv");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Get
            };
            GetTier1SegmentPortMacTableInCsvServiceURL.Replace("{tier-1-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(Tier1Id, System.Globalization.CultureInfo.InvariantCulture)));
            GetTier1SegmentPortMacTableInCsvServiceURL.Replace("{segment-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(SegmentId, System.Globalization.CultureInfo.InvariantCulture)));
            GetTier1SegmentPortMacTableInCsvServiceURL.Replace("{port-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(PortId, System.Globalization.CultureInfo.InvariantCulture)));
            if (EnforcementPointPath != null) { request.AddQueryParameter("enforcement_point_path", EnforcementPointPath.ToString()); }
            if (Source != null) { request.AddQueryParameter("source", Source.ToString()); }
            if (TransportNodeId != null) { request.AddQueryParameter("transport_node_id", TransportNodeId.ToString()); }
            request.Resource = GetTier1SegmentPortMacTableInCsvServiceURL.ToString();
            RestResponse<NSXTSegmentPortMacAddressCsvListResultType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTSegmentPortMacAddressCsvListResultType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Get operation to " + GetTier1SegmentPortMacTableInCsvServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTInterfaceArpTableInCsvFormatType> GetDownlinkPortArpTableForTier1SegmentInCsv(string Tier1Id, string SegmentId, string? Cursor = null, string? EdgePath = null, string? EnforcementPointPath = null, string? HostTransportNodePath = null, string? IncludedFields = null, long? PageSize = null, bool? SortAscending = null, string? SortBy = null)
        {
            if (Tier1Id == null) { throw new System.ArgumentNullException("Tier1Id cannot be null"); }
            if (SegmentId == null) { throw new System.ArgumentNullException("SegmentId cannot be null"); }
            StringBuilder GetDownlinkPortArpTableForTier1SegmentInCsvServiceURL = new StringBuilder("/infra/tier-1s/{tier-1-id}/segments/{segment-id}/gateway-interface-arp-table?format=csv");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Get
            };
            GetDownlinkPortArpTableForTier1SegmentInCsvServiceURL.Replace("{tier-1-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(Tier1Id, System.Globalization.CultureInfo.InvariantCulture)));
            GetDownlinkPortArpTableForTier1SegmentInCsvServiceURL.Replace("{segment-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(SegmentId, System.Globalization.CultureInfo.InvariantCulture)));
            if (Cursor != null) { request.AddQueryParameter("cursor", Cursor.ToString()); }
            if (EdgePath != null) { request.AddQueryParameter("edge_path", EdgePath.ToString()); }
            if (EnforcementPointPath != null) { request.AddQueryParameter("enforcement_point_path", EnforcementPointPath.ToString()); }
            if (HostTransportNodePath != null) { request.AddQueryParameter("host_transport_node_path", HostTransportNodePath.ToString()); }
            if (IncludedFields != null) { request.AddQueryParameter("included_fields", IncludedFields.ToString()); }
            if (PageSize != null) { request.AddQueryParameter("page_size", PageSize.ToString()); }
            if (SortAscending != null) { request.AddQueryParameter("sort_ascending", SortAscending.ToString()); }
            if (SortBy != null) { request.AddQueryParameter("sort_by", SortBy.ToString()); }
            request.Resource = GetDownlinkPortArpTableForTier1SegmentInCsvServiceURL.ToString();
            RestResponse<NSXTInterfaceArpTableInCsvFormatType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTInterfaceArpTableInCsvFormatType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Get operation to " + GetDownlinkPortArpTableForTier1SegmentInCsvServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTPolicyInterfaceStatisticsSummaryType> GlobalGlobalInfraGetDownlinkPortStatisticsSummaryForInfraSegment(string SegmentId, string? EnforcementPointPath = null, string? Source = null)
        {
            if (SegmentId == null) { throw new System.ArgumentNullException("SegmentId cannot be null"); }
            StringBuilder GlobalInfraGetDownlinkPortStatisticsSummaryForInfraSegmentServiceURL = new StringBuilder("/global-infra/segments/{segment-id}/gateway-interface-statistics/summary");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Get
            };
            GlobalInfraGetDownlinkPortStatisticsSummaryForInfraSegmentServiceURL.Replace("{segment-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(SegmentId, System.Globalization.CultureInfo.InvariantCulture)));
            if (EnforcementPointPath != null) { request.AddQueryParameter("enforcement_point_path", EnforcementPointPath.ToString()); }
            if (Source != null) { request.AddQueryParameter("source", Source.ToString()); }
            request.Resource = GlobalInfraGetDownlinkPortStatisticsSummaryForInfraSegmentServiceURL.ToString();
            RestResponse<NSXTPolicyInterfaceStatisticsSummaryType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTPolicyInterfaceStatisticsSummaryType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Get operation to " + GlobalInfraGetDownlinkPortStatisticsSummaryForInfraSegmentServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTInterfaceArpTableType> GetTier0InterfaceArpTable(string Tier0Id, string LocaleServiceId, string InterfaceId, string? Cursor = null, string? EdgePath = null, string? EnforcementPointPath = null, string? HostTransportNodePath = null, string? IncludedFields = null, long? PageSize = null, bool? SortAscending = null, string? SortBy = null)
        {
            if (Tier0Id == null) { throw new System.ArgumentNullException("Tier0Id cannot be null"); }
            if (LocaleServiceId == null) { throw new System.ArgumentNullException("LocaleServiceId cannot be null"); }
            if (InterfaceId == null) { throw new System.ArgumentNullException("InterfaceId cannot be null"); }
            StringBuilder GetTier0InterfaceArpTableServiceURL = new StringBuilder("/infra/tier-0s/{tier-0-id}/locale-services/{locale-service-id}/interfaces/{interface-id}/arp-table");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Get
            };
            GetTier0InterfaceArpTableServiceURL.Replace("{tier-0-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(Tier0Id, System.Globalization.CultureInfo.InvariantCulture)));
            GetTier0InterfaceArpTableServiceURL.Replace("{locale-service-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(LocaleServiceId, System.Globalization.CultureInfo.InvariantCulture)));
            GetTier0InterfaceArpTableServiceURL.Replace("{interface-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(InterfaceId, System.Globalization.CultureInfo.InvariantCulture)));
            if (Cursor != null) { request.AddQueryParameter("cursor", Cursor.ToString()); }
            if (EdgePath != null) { request.AddQueryParameter("edge_path", EdgePath.ToString()); }
            if (EnforcementPointPath != null) { request.AddQueryParameter("enforcement_point_path", EnforcementPointPath.ToString()); }
            if (HostTransportNodePath != null) { request.AddQueryParameter("host_transport_node_path", HostTransportNodePath.ToString()); }
            if (IncludedFields != null) { request.AddQueryParameter("included_fields", IncludedFields.ToString()); }
            if (PageSize != null) { request.AddQueryParameter("page_size", PageSize.ToString()); }
            if (SortAscending != null) { request.AddQueryParameter("sort_ascending", SortAscending.ToString()); }
            if (SortBy != null) { request.AddQueryParameter("sort_by", SortBy.ToString()); }
            request.Resource = GetTier0InterfaceArpTableServiceURL.ToString();
            RestResponse<NSXTInterfaceArpTableType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTInterfaceArpTableType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Get operation to " + GetTier0InterfaceArpTableServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTPolicyInterfaceStatisticsType> GlobalGlobalInfraGetDownlinkPortStatisticsForTier1Segment(string Tier1Id, string SegmentId, string? Cursor = null, string? EdgePath = null, string? EnforcementPointPath = null, string? HostTransportNodePath = null, string? IncludedFields = null, long? PageSize = null, bool? SortAscending = null, string? SortBy = null)
        {
            if (Tier1Id == null) { throw new System.ArgumentNullException("Tier1Id cannot be null"); }
            if (SegmentId == null) { throw new System.ArgumentNullException("SegmentId cannot be null"); }
            StringBuilder GlobalInfraGetDownlinkPortStatisticsForTier1SegmentServiceURL = new StringBuilder("/global-infra/tier-1s/{tier-1-id}/segments/{segment-id}/gateway-interface-statistics");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Get
            };
            GlobalInfraGetDownlinkPortStatisticsForTier1SegmentServiceURL.Replace("{tier-1-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(Tier1Id, System.Globalization.CultureInfo.InvariantCulture)));
            GlobalInfraGetDownlinkPortStatisticsForTier1SegmentServiceURL.Replace("{segment-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(SegmentId, System.Globalization.CultureInfo.InvariantCulture)));
            if (Cursor != null) { request.AddQueryParameter("cursor", Cursor.ToString()); }
            if (EdgePath != null) { request.AddQueryParameter("edge_path", EdgePath.ToString()); }
            if (EnforcementPointPath != null) { request.AddQueryParameter("enforcement_point_path", EnforcementPointPath.ToString()); }
            if (HostTransportNodePath != null) { request.AddQueryParameter("host_transport_node_path", HostTransportNodePath.ToString()); }
            if (IncludedFields != null) { request.AddQueryParameter("included_fields", IncludedFields.ToString()); }
            if (PageSize != null) { request.AddQueryParameter("page_size", PageSize.ToString()); }
            if (SortAscending != null) { request.AddQueryParameter("sort_ascending", SortAscending.ToString()); }
            if (SortBy != null) { request.AddQueryParameter("sort_by", SortBy.ToString()); }
            request.Resource = GlobalInfraGetDownlinkPortStatisticsForTier1SegmentServiceURL.ToString();
            RestResponse<NSXTPolicyInterfaceStatisticsType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTPolicyInterfaceStatisticsType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Get operation to " + GlobalInfraGetDownlinkPortStatisticsForTier1SegmentServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTSegmentStatisticsType> GetSegmentStatistics(string Tier1Id, string SegmentsId, string? Cursor = null, string? EdgePath = null, string? EnforcementPointPath = null, bool? IncludeMarkForDeleteObjects = null, string? IncludedFields = null, long? PageSize = null, bool? SortAscending = null, string? SortBy = null)
        {
            if (Tier1Id == null) { throw new System.ArgumentNullException("Tier1Id cannot be null"); }
            if (SegmentsId == null) { throw new System.ArgumentNullException("SegmentsId cannot be null"); }
            StringBuilder GetSegmentStatisticsServiceURL = new StringBuilder("/infra/tier-1s/{tier-1-id}/segments/{segments-id}/statistics");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Get
            };
            GetSegmentStatisticsServiceURL.Replace("{tier-1-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(Tier1Id, System.Globalization.CultureInfo.InvariantCulture)));
            GetSegmentStatisticsServiceURL.Replace("{segments-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(SegmentsId, System.Globalization.CultureInfo.InvariantCulture)));
            if (Cursor != null) { request.AddQueryParameter("cursor", Cursor.ToString()); }
            if (EdgePath != null) { request.AddQueryParameter("edge_path", EdgePath.ToString()); }
            if (EnforcementPointPath != null) { request.AddQueryParameter("enforcement_point_path", EnforcementPointPath.ToString()); }
            if (IncludeMarkForDeleteObjects != null) { request.AddQueryParameter("include_mark_for_delete_objects", IncludeMarkForDeleteObjects.ToString()); }
            if (IncludedFields != null) { request.AddQueryParameter("included_fields", IncludedFields.ToString()); }
            if (PageSize != null) { request.AddQueryParameter("page_size", PageSize.ToString()); }
            if (SortAscending != null) { request.AddQueryParameter("sort_ascending", SortAscending.ToString()); }
            if (SortBy != null) { request.AddQueryParameter("sort_by", SortBy.ToString()); }
            request.Resource = GetSegmentStatisticsServiceURL.ToString();
            RestResponse<NSXTSegmentStatisticsType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTSegmentStatisticsType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Get operation to " + GetSegmentStatisticsServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTSegmentConfigurationStateType> GetInfraSegmentState(string SegmentsId, string? Cursor = null, string? EdgePath = null, string? EnforcementPointPath = null, bool? IncludeMarkForDeleteObjects = null, string? IncludedFields = null, long? PageSize = null, bool? SortAscending = null, string? SortBy = null)
        {
            if (SegmentsId == null) { throw new System.ArgumentNullException("SegmentsId cannot be null"); }
            StringBuilder GetInfraSegmentStateServiceURL = new StringBuilder("/infra/segments/{segments-id}/state");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Get
            };
            GetInfraSegmentStateServiceURL.Replace("{segments-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(SegmentsId, System.Globalization.CultureInfo.InvariantCulture)));
            if (Cursor != null) { request.AddQueryParameter("cursor", Cursor.ToString()); }
            if (EdgePath != null) { request.AddQueryParameter("edge_path", EdgePath.ToString()); }
            if (EnforcementPointPath != null) { request.AddQueryParameter("enforcement_point_path", EnforcementPointPath.ToString()); }
            if (IncludeMarkForDeleteObjects != null) { request.AddQueryParameter("include_mark_for_delete_objects", IncludeMarkForDeleteObjects.ToString()); }
            if (IncludedFields != null) { request.AddQueryParameter("included_fields", IncludedFields.ToString()); }
            if (PageSize != null) { request.AddQueryParameter("page_size", PageSize.ToString()); }
            if (SortAscending != null) { request.AddQueryParameter("sort_ascending", SortAscending.ToString()); }
            if (SortBy != null) { request.AddQueryParameter("sort_by", SortBy.ToString()); }
            request.Resource = GetInfraSegmentStateServiceURL.ToString();
            RestResponse<NSXTSegmentConfigurationStateType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTSegmentConfigurationStateType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Get operation to " + GetInfraSegmentStateServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTPolicyArpProxyTableCsvListResultType> GetTier1GatewayArpProxiesInCsv(string Tier1Id, string? EnforcementPointPath = null, string? Source = null, string? TransportNodeId = null)
        {
            if (Tier1Id == null) { throw new System.ArgumentNullException("Tier1Id cannot be null"); }
            StringBuilder GetTier1GatewayArpProxiesInCsvServiceURL = new StringBuilder("/infra/tier-1s/{tier-1-id}/arp-proxies?format=csv");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Get
            };
            GetTier1GatewayArpProxiesInCsvServiceURL.Replace("{tier-1-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(Tier1Id, System.Globalization.CultureInfo.InvariantCulture)));
            if (EnforcementPointPath != null) { request.AddQueryParameter("enforcement_point_path", EnforcementPointPath.ToString()); }
            if (Source != null) { request.AddQueryParameter("source", Source.ToString()); }
            if (TransportNodeId != null) { request.AddQueryParameter("transport_node_id", TransportNodeId.ToString()); }
            request.Resource = GetTier1GatewayArpProxiesInCsvServiceURL.ToString();
            RestResponse<NSXTPolicyArpProxyTableCsvListResultType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTPolicyArpProxyTableCsvListResultType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Get operation to " + GetTier1GatewayArpProxiesInCsvServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTInterfaceArpTableInCsvFormatType> GetTier1RouterLinkArpTableCsv(string Tier1Id, string? Cursor = null, string? EdgePath = null, string? EnforcementPointPath = null, string? HostTransportNodePath = null, string? IncludedFields = null, long? PageSize = null, bool? SortAscending = null, string? SortBy = null)
        {
            if (Tier1Id == null) { throw new System.ArgumentNullException("Tier1Id cannot be null"); }
            StringBuilder GetTier1RouterLinkArpTableCsvServiceURL = new StringBuilder("/infra/tier-1s/{tier-1-id}/tier-0-interface/arp-table?format=csv");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Get
            };
            GetTier1RouterLinkArpTableCsvServiceURL.Replace("{tier-1-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(Tier1Id, System.Globalization.CultureInfo.InvariantCulture)));
            if (Cursor != null) { request.AddQueryParameter("cursor", Cursor.ToString()); }
            if (EdgePath != null) { request.AddQueryParameter("edge_path", EdgePath.ToString()); }
            if (EnforcementPointPath != null) { request.AddQueryParameter("enforcement_point_path", EnforcementPointPath.ToString()); }
            if (HostTransportNodePath != null) { request.AddQueryParameter("host_transport_node_path", HostTransportNodePath.ToString()); }
            if (IncludedFields != null) { request.AddQueryParameter("included_fields", IncludedFields.ToString()); }
            if (PageSize != null) { request.AddQueryParameter("page_size", PageSize.ToString()); }
            if (SortAscending != null) { request.AddQueryParameter("sort_ascending", SortAscending.ToString()); }
            if (SortBy != null) { request.AddQueryParameter("sort_by", SortBy.ToString()); }
            request.Resource = GetTier1RouterLinkArpTableCsvServiceURL.ToString();
            RestResponse<NSXTInterfaceArpTableInCsvFormatType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTInterfaceArpTableInCsvFormatType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Get operation to " + GetTier1RouterLinkArpTableCsvServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTPolicyBgpNeighborsStatusListResultType> GlobalGlobalInfraGetTier0BgpNeighborsStatus(string Tier0Id, string LocaleServiceId, string? Cursor = null, string? EdgePath = null, string? EnforcementPointPath = null, bool? IncludeMarkForDeleteObjects = null, string? IncludedFields = null, long? PageSize = null, bool? SortAscending = null, string? SortBy = null)
        {
            if (Tier0Id == null) { throw new System.ArgumentNullException("Tier0Id cannot be null"); }
            if (LocaleServiceId == null) { throw new System.ArgumentNullException("LocaleServiceId cannot be null"); }
            StringBuilder GlobalInfraGetTier0BgpNeighborsStatusServiceURL = new StringBuilder("/global-infra/tier-0s/{tier-0-id}/locale-services/{locale-service-id}/bgp/neighbors/status");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Get
            };
            GlobalInfraGetTier0BgpNeighborsStatusServiceURL.Replace("{tier-0-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(Tier0Id, System.Globalization.CultureInfo.InvariantCulture)));
            GlobalInfraGetTier0BgpNeighborsStatusServiceURL.Replace("{locale-service-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(LocaleServiceId, System.Globalization.CultureInfo.InvariantCulture)));
            if (Cursor != null) { request.AddQueryParameter("cursor", Cursor.ToString()); }
            if (EdgePath != null) { request.AddQueryParameter("edge_path", EdgePath.ToString()); }
            if (EnforcementPointPath != null) { request.AddQueryParameter("enforcement_point_path", EnforcementPointPath.ToString()); }
            if (IncludeMarkForDeleteObjects != null) { request.AddQueryParameter("include_mark_for_delete_objects", IncludeMarkForDeleteObjects.ToString()); }
            if (IncludedFields != null) { request.AddQueryParameter("included_fields", IncludedFields.ToString()); }
            if (PageSize != null) { request.AddQueryParameter("page_size", PageSize.ToString()); }
            if (SortAscending != null) { request.AddQueryParameter("sort_ascending", SortAscending.ToString()); }
            if (SortBy != null) { request.AddQueryParameter("sort_by", SortBy.ToString()); }
            request.Resource = GlobalInfraGetTier0BgpNeighborsStatusServiceURL.ToString();
            RestResponse<NSXTPolicyBgpNeighborsStatusListResultType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTPolicyBgpNeighborsStatusListResultType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Get operation to " + GlobalInfraGetTier0BgpNeighborsStatusServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTBgpNeighborRoutesListResultType> GetTier0BgpNeighborAdvertisedRoutes(string Tier0Id, string LocaleServiceId, string NeighborId, int? Count = null, string? Cursor = null, string? EnforcementPointPath = null, string? IncludedFields = null, long? PageSize = null, bool? SortAscending = null, string? SortBy = null)
        {
            if (Tier0Id == null) { throw new System.ArgumentNullException("Tier0Id cannot be null"); }
            if (LocaleServiceId == null) { throw new System.ArgumentNullException("LocaleServiceId cannot be null"); }
            if (NeighborId == null) { throw new System.ArgumentNullException("NeighborId cannot be null"); }
            StringBuilder GetTier0BgpNeighborAdvertisedRoutesServiceURL = new StringBuilder("/infra/tier-0s/{tier-0-id}/locale-services/{locale-service-id}/bgp/neighbors/{neighbor-id}/advertised-routes");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Get
            };
            GetTier0BgpNeighborAdvertisedRoutesServiceURL.Replace("{tier-0-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(Tier0Id, System.Globalization.CultureInfo.InvariantCulture)));
            GetTier0BgpNeighborAdvertisedRoutesServiceURL.Replace("{locale-service-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(LocaleServiceId, System.Globalization.CultureInfo.InvariantCulture)));
            GetTier0BgpNeighborAdvertisedRoutesServiceURL.Replace("{neighbor-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(NeighborId, System.Globalization.CultureInfo.InvariantCulture)));
            if (Count != null) { request.AddQueryParameter("count", Count.ToString()); }
            if (Cursor != null) { request.AddQueryParameter("cursor", Cursor.ToString()); }
            if (EnforcementPointPath != null) { request.AddQueryParameter("enforcement_point_path", EnforcementPointPath.ToString()); }
            if (IncludedFields != null) { request.AddQueryParameter("included_fields", IncludedFields.ToString()); }
            if (PageSize != null) { request.AddQueryParameter("page_size", PageSize.ToString()); }
            if (SortAscending != null) { request.AddQueryParameter("sort_ascending", SortAscending.ToString()); }
            if (SortBy != null) { request.AddQueryParameter("sort_by", SortBy.ToString()); }
            request.Resource = GetTier0BgpNeighborAdvertisedRoutesServiceURL.ToString();
            RestResponse<NSXTBgpNeighborRoutesListResultType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTBgpNeighborRoutesListResultType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Get operation to " + GetTier0BgpNeighborAdvertisedRoutesServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTSegmentPortStateType> GetInfraSegmentPortState(string SegmentId, string PortId, string? EnforcementPointPath = null, string? Source = null)
        {
            if (SegmentId == null) { throw new System.ArgumentNullException("SegmentId cannot be null"); }
            if (PortId == null) { throw new System.ArgumentNullException("PortId cannot be null"); }
            StringBuilder GetInfraSegmentPortStateServiceURL = new StringBuilder("/infra/segments/{segment-id}/ports/{port-id}/state");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Get
            };
            GetInfraSegmentPortStateServiceURL.Replace("{segment-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(SegmentId, System.Globalization.CultureInfo.InvariantCulture)));
            GetInfraSegmentPortStateServiceURL.Replace("{port-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(PortId, System.Globalization.CultureInfo.InvariantCulture)));
            if (EnforcementPointPath != null) { request.AddQueryParameter("enforcement_point_path", EnforcementPointPath.ToString()); }
            if (Source != null) { request.AddQueryParameter("source", Source.ToString()); }
            request.Resource = GetInfraSegmentPortStateServiceURL.ToString();
            RestResponse<NSXTSegmentPortStateType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTSegmentPortStateType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Get operation to " + GetInfraSegmentPortStateServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTPolicyInterfaceStatisticsType> GlobalGlobalInfraGetTier1InterfaceStatistics(string Tier1Id, string LocaleServiceId, string InterfaceId, string? Cursor = null, string? EdgePath = null, string? EnforcementPointPath = null, bool? IncludeMarkForDeleteObjects = null, string? IncludedFields = null, long? PageSize = null, bool? SortAscending = null, string? SortBy = null)
        {
            if (Tier1Id == null) { throw new System.ArgumentNullException("Tier1Id cannot be null"); }
            if (LocaleServiceId == null) { throw new System.ArgumentNullException("LocaleServiceId cannot be null"); }
            if (InterfaceId == null) { throw new System.ArgumentNullException("InterfaceId cannot be null"); }
            StringBuilder GlobalInfraGetTier1InterfaceStatisticsServiceURL = new StringBuilder("/global-infra/tier-1s/{tier-1-id}/locale-services/{locale-service-id}/interfaces/{interface-id}/statistics");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Get
            };
            GlobalInfraGetTier1InterfaceStatisticsServiceURL.Replace("{tier-1-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(Tier1Id, System.Globalization.CultureInfo.InvariantCulture)));
            GlobalInfraGetTier1InterfaceStatisticsServiceURL.Replace("{locale-service-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(LocaleServiceId, System.Globalization.CultureInfo.InvariantCulture)));
            GlobalInfraGetTier1InterfaceStatisticsServiceURL.Replace("{interface-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(InterfaceId, System.Globalization.CultureInfo.InvariantCulture)));
            if (Cursor != null) { request.AddQueryParameter("cursor", Cursor.ToString()); }
            if (EdgePath != null) { request.AddQueryParameter("edge_path", EdgePath.ToString()); }
            if (EnforcementPointPath != null) { request.AddQueryParameter("enforcement_point_path", EnforcementPointPath.ToString()); }
            if (IncludeMarkForDeleteObjects != null) { request.AddQueryParameter("include_mark_for_delete_objects", IncludeMarkForDeleteObjects.ToString()); }
            if (IncludedFields != null) { request.AddQueryParameter("included_fields", IncludedFields.ToString()); }
            if (PageSize != null) { request.AddQueryParameter("page_size", PageSize.ToString()); }
            if (SortAscending != null) { request.AddQueryParameter("sort_ascending", SortAscending.ToString()); }
            if (SortBy != null) { request.AddQueryParameter("sort_by", SortBy.ToString()); }
            request.Resource = GlobalInfraGetTier1InterfaceStatisticsServiceURL.ToString();
            RestResponse<NSXTPolicyInterfaceStatisticsType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTPolicyInterfaceStatisticsType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Get operation to " + GlobalInfraGetTier1InterfaceStatisticsServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTPolicyInterfaceStatisticsSummaryType> GlobalGlobalInfraGetTier1RouterLinkSummaryStatistics(string Tier1Id, string? Cursor = null, string? EnforcementPointPath = null, string? IncludedFields = null, long? PageSize = null, bool? SortAscending = null, string? SortBy = null)
        {
            if (Tier1Id == null) { throw new System.ArgumentNullException("Tier1Id cannot be null"); }
            StringBuilder GlobalInfraGetTier1RouterLinkSummaryStatisticsServiceURL = new StringBuilder("/global-infra/tier-1s/{tier-1-id}/tier-0-interface/statistics/summary");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Get
            };
            GlobalInfraGetTier1RouterLinkSummaryStatisticsServiceURL.Replace("{tier-1-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(Tier1Id, System.Globalization.CultureInfo.InvariantCulture)));
            if (Cursor != null) { request.AddQueryParameter("cursor", Cursor.ToString()); }
            if (EnforcementPointPath != null) { request.AddQueryParameter("enforcement_point_path", EnforcementPointPath.ToString()); }
            if (IncludedFields != null) { request.AddQueryParameter("included_fields", IncludedFields.ToString()); }
            if (PageSize != null) { request.AddQueryParameter("page_size", PageSize.ToString()); }
            if (SortAscending != null) { request.AddQueryParameter("sort_ascending", SortAscending.ToString()); }
            if (SortBy != null) { request.AddQueryParameter("sort_by", SortBy.ToString()); }
            request.Resource = GlobalInfraGetTier1RouterLinkSummaryStatisticsServiceURL.ToString();
            RestResponse<NSXTPolicyInterfaceStatisticsSummaryType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTPolicyInterfaceStatisticsSummaryType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Get operation to " + GlobalInfraGetTier1RouterLinkSummaryStatisticsServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTInterfaceArpTableType> GlobalGlobalInfraGetInfraSegmentInterfaceArpTable(string SegmentId, string? Cursor = null, string? EdgePath = null, string? EnforcementPointPath = null, string? HostTransportNodePath = null, string? IncludedFields = null, long? PageSize = null, bool? SortAscending = null, string? SortBy = null)
        {
            if (SegmentId == null) { throw new System.ArgumentNullException("SegmentId cannot be null"); }
            StringBuilder GlobalInfraGetInfraSegmentInterfaceArpTableServiceURL = new StringBuilder("/global-infra/segments/{segment-id}/arp-table");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Get
            };
            GlobalInfraGetInfraSegmentInterfaceArpTableServiceURL.Replace("{segment-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(SegmentId, System.Globalization.CultureInfo.InvariantCulture)));
            if (Cursor != null) { request.AddQueryParameter("cursor", Cursor.ToString()); }
            if (EdgePath != null) { request.AddQueryParameter("edge_path", EdgePath.ToString()); }
            if (EnforcementPointPath != null) { request.AddQueryParameter("enforcement_point_path", EnforcementPointPath.ToString()); }
            if (HostTransportNodePath != null) { request.AddQueryParameter("host_transport_node_path", HostTransportNodePath.ToString()); }
            if (IncludedFields != null) { request.AddQueryParameter("included_fields", IncludedFields.ToString()); }
            if (PageSize != null) { request.AddQueryParameter("page_size", PageSize.ToString()); }
            if (SortAscending != null) { request.AddQueryParameter("sort_ascending", SortAscending.ToString()); }
            if (SortBy != null) { request.AddQueryParameter("sort_by", SortBy.ToString()); }
            request.Resource = GlobalInfraGetInfraSegmentInterfaceArpTableServiceURL.ToString();
            RestResponse<NSXTInterfaceArpTableType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTInterfaceArpTableType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Get operation to " + GlobalInfraGetInfraSegmentInterfaceArpTableServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTOspfDatabaseListResultInCsvFormatType> GetOspfDatabaseInCsvFormat(string Tier0Id, string LocaleServiceId, string? AreaId = null, string? Cursor = null, string? EdgePath = null, string? IncludedFields = null, long? PageSize = null, bool? SortAscending = null, string? SortBy = null)
        {
            if (Tier0Id == null) { throw new System.ArgumentNullException("Tier0Id cannot be null"); }
            if (LocaleServiceId == null) { throw new System.ArgumentNullException("LocaleServiceId cannot be null"); }
            StringBuilder GetOspfDatabaseInCsvFormatServiceURL = new StringBuilder("/infra/tier-0s/{tier-0-id}/locale-services/{locale-service-id}/ospf/database?format=csv");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Get
            };
            GetOspfDatabaseInCsvFormatServiceURL.Replace("{tier-0-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(Tier0Id, System.Globalization.CultureInfo.InvariantCulture)));
            GetOspfDatabaseInCsvFormatServiceURL.Replace("{locale-service-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(LocaleServiceId, System.Globalization.CultureInfo.InvariantCulture)));
            if (AreaId != null) { request.AddQueryParameter("area_id", AreaId.ToString()); }
            if (Cursor != null) { request.AddQueryParameter("cursor", Cursor.ToString()); }
            if (EdgePath != null) { request.AddQueryParameter("edge_path", EdgePath.ToString()); }
            if (IncludedFields != null) { request.AddQueryParameter("included_fields", IncludedFields.ToString()); }
            if (PageSize != null) { request.AddQueryParameter("page_size", PageSize.ToString()); }
            if (SortAscending != null) { request.AddQueryParameter("sort_ascending", SortAscending.ToString()); }
            if (SortBy != null) { request.AddQueryParameter("sort_by", SortBy.ToString()); }
            request.Resource = GetOspfDatabaseInCsvFormatServiceURL.ToString();
            RestResponse<NSXTOspfDatabaseListResultInCsvFormatType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTOspfDatabaseListResultInCsvFormatType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Get operation to " + GetOspfDatabaseInCsvFormatServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTPolicyInterfaceStatisticsType> GlobalGlobalInfraGetTier1RouterLinkStatistics(string Tier1Id, string? Cursor = null, string? EdgePath = null, string? EnforcementPointPath = null, bool? IncludeMarkForDeleteObjects = null, string? IncludedFields = null, long? PageSize = null, bool? SortAscending = null, string? SortBy = null)
        {
            if (Tier1Id == null) { throw new System.ArgumentNullException("Tier1Id cannot be null"); }
            StringBuilder GlobalInfraGetTier1RouterLinkStatisticsServiceURL = new StringBuilder("/global-infra/tier-1s/{tier-1-id}/tier-0-interface/statistics");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Get
            };
            GlobalInfraGetTier1RouterLinkStatisticsServiceURL.Replace("{tier-1-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(Tier1Id, System.Globalization.CultureInfo.InvariantCulture)));
            if (Cursor != null) { request.AddQueryParameter("cursor", Cursor.ToString()); }
            if (EdgePath != null) { request.AddQueryParameter("edge_path", EdgePath.ToString()); }
            if (EnforcementPointPath != null) { request.AddQueryParameter("enforcement_point_path", EnforcementPointPath.ToString()); }
            if (IncludeMarkForDeleteObjects != null) { request.AddQueryParameter("include_mark_for_delete_objects", IncludeMarkForDeleteObjects.ToString()); }
            if (IncludedFields != null) { request.AddQueryParameter("included_fields", IncludedFields.ToString()); }
            if (PageSize != null) { request.AddQueryParameter("page_size", PageSize.ToString()); }
            if (SortAscending != null) { request.AddQueryParameter("sort_ascending", SortAscending.ToString()); }
            if (SortBy != null) { request.AddQueryParameter("sort_by", SortBy.ToString()); }
            request.Resource = GlobalInfraGetTier1RouterLinkStatisticsServiceURL.ToString();
            RestResponse<NSXTPolicyInterfaceStatisticsType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTPolicyInterfaceStatisticsType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Get operation to " + GlobalInfraGetTier1RouterLinkStatisticsServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTRoutingTableListResultType> GetTier0Routes(string Tier0Id, string? Cursor = null, string? EdgeId = null, string? EdgePath = null, string? EnforcementPointPath = null, string? IncludedFields = null, string? NetworkPrefix = null, long? PageSize = null, string? RouteSource = null, bool? SortAscending = null, string? SortBy = null)
        {
            if (Tier0Id == null) { throw new System.ArgumentNullException("Tier0Id cannot be null"); }
            StringBuilder GetTier0RoutesServiceURL = new StringBuilder("/infra/tier-0s/{tier-0-id}/routing-table");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Get
            };
            GetTier0RoutesServiceURL.Replace("{tier-0-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(Tier0Id, System.Globalization.CultureInfo.InvariantCulture)));
            if (Cursor != null) { request.AddQueryParameter("cursor", Cursor.ToString()); }
            if (EdgeId != null) { request.AddQueryParameter("edge_id", EdgeId.ToString()); }
            if (EdgePath != null) { request.AddQueryParameter("edge_path", EdgePath.ToString()); }
            if (EnforcementPointPath != null) { request.AddQueryParameter("enforcement_point_path", EnforcementPointPath.ToString()); }
            if (IncludedFields != null) { request.AddQueryParameter("included_fields", IncludedFields.ToString()); }
            if (NetworkPrefix != null) { request.AddQueryParameter("network_prefix", NetworkPrefix.ToString()); }
            if (PageSize != null) { request.AddQueryParameter("page_size", PageSize.ToString()); }
            if (RouteSource != null) { request.AddQueryParameter("route_source", RouteSource.ToString()); }
            if (SortAscending != null) { request.AddQueryParameter("sort_ascending", SortAscending.ToString()); }
            if (SortBy != null) { request.AddQueryParameter("sort_by", SortBy.ToString()); }
            request.Resource = GetTier0RoutesServiceURL.ToString();
            RestResponse<NSXTRoutingTableListResultType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTRoutingTableListResultType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Get operation to " + GetTier0RoutesServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTDhcpServerStatusType> ReadDhcpServerStatus(string ConfigId, string ConnectivityPath, string? Cursor = null, string? EnforcementPointPath = null, bool? IncludeMarkForDeleteObjects = null, string? IncludedFields = null, long? PageSize = null, bool? SortAscending = null, string? SortBy = null)
        {
            if (ConfigId == null) { throw new System.ArgumentNullException("ConfigId cannot be null"); }
            if (ConnectivityPath == null) { throw new System.ArgumentNullException("ConnectivityPath cannot be null"); }
            StringBuilder ReadDhcpServerStatusServiceURL = new StringBuilder("/infra/dhcp-server-configs/{config-id}/status");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Get
            };
            ReadDhcpServerStatusServiceURL.Replace("{config-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(ConfigId, System.Globalization.CultureInfo.InvariantCulture)));
            if (ConnectivityPath != null) { request.AddQueryParameter("connectivity_path", ConnectivityPath.ToString()); }
            if (Cursor != null) { request.AddQueryParameter("cursor", Cursor.ToString()); }
            if (EnforcementPointPath != null) { request.AddQueryParameter("enforcement_point_path", EnforcementPointPath.ToString()); }
            if (IncludeMarkForDeleteObjects != null) { request.AddQueryParameter("include_mark_for_delete_objects", IncludeMarkForDeleteObjects.ToString()); }
            if (IncludedFields != null) { request.AddQueryParameter("included_fields", IncludedFields.ToString()); }
            if (PageSize != null) { request.AddQueryParameter("page_size", PageSize.ToString()); }
            if (SortAscending != null) { request.AddQueryParameter("sort_ascending", SortAscending.ToString()); }
            if (SortBy != null) { request.AddQueryParameter("sort_by", SortBy.ToString()); }
            request.Resource = ReadDhcpServerStatusServiceURL.ToString();
            RestResponse<NSXTDhcpServerStatusType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTDhcpServerStatusType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Get operation to " + ReadDhcpServerStatusServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTPolicyInterfaceStatisticsSummaryType> GlobalGlobalInfraGetDownlinkPortStatisticsSummaryForTier1Segment(string Tier1Id, string SegmentId, string? EnforcementPointPath = null, string? Source = null)
        {
            if (Tier1Id == null) { throw new System.ArgumentNullException("Tier1Id cannot be null"); }
            if (SegmentId == null) { throw new System.ArgumentNullException("SegmentId cannot be null"); }
            StringBuilder GlobalInfraGetDownlinkPortStatisticsSummaryForTier1SegmentServiceURL = new StringBuilder("/global-infra/tier-1s/{tier-1-id}/segments/{segment-id}/gateway-interface-statistics/summary");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Get
            };
            GlobalInfraGetDownlinkPortStatisticsSummaryForTier1SegmentServiceURL.Replace("{tier-1-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(Tier1Id, System.Globalization.CultureInfo.InvariantCulture)));
            GlobalInfraGetDownlinkPortStatisticsSummaryForTier1SegmentServiceURL.Replace("{segment-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(SegmentId, System.Globalization.CultureInfo.InvariantCulture)));
            if (EnforcementPointPath != null) { request.AddQueryParameter("enforcement_point_path", EnforcementPointPath.ToString()); }
            if (Source != null) { request.AddQueryParameter("source", Source.ToString()); }
            request.Resource = GlobalInfraGetDownlinkPortStatisticsSummaryForTier1SegmentServiceURL.ToString();
            RestResponse<NSXTPolicyInterfaceStatisticsSummaryType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTPolicyInterfaceStatisticsSummaryType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Get operation to " + GlobalInfraGetDownlinkPortStatisticsSummaryForTier1SegmentServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTPolicyTepListResultType> GetTier1SegmentTepTable(string Tier1Id, string SegmentId, string? Cursor = null, string? EnforcementPointPath = null, string? IncludedFields = null, long? PageSize = null, bool? SortAscending = null, string? SortBy = null, string? Source = null, string? TransportNodeId = null)
        {
            if (Tier1Id == null) { throw new System.ArgumentNullException("Tier1Id cannot be null"); }
            if (SegmentId == null) { throw new System.ArgumentNullException("SegmentId cannot be null"); }
            StringBuilder GetTier1SegmentTepTableServiceURL = new StringBuilder("/infra/tier-1s/{tier-1-id}/segments/{segment-id}/tep-table");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Get
            };
            GetTier1SegmentTepTableServiceURL.Replace("{tier-1-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(Tier1Id, System.Globalization.CultureInfo.InvariantCulture)));
            GetTier1SegmentTepTableServiceURL.Replace("{segment-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(SegmentId, System.Globalization.CultureInfo.InvariantCulture)));
            if (Cursor != null) { request.AddQueryParameter("cursor", Cursor.ToString()); }
            if (EnforcementPointPath != null) { request.AddQueryParameter("enforcement_point_path", EnforcementPointPath.ToString()); }
            if (IncludedFields != null) { request.AddQueryParameter("included_fields", IncludedFields.ToString()); }
            if (PageSize != null) { request.AddQueryParameter("page_size", PageSize.ToString()); }
            if (SortAscending != null) { request.AddQueryParameter("sort_ascending", SortAscending.ToString()); }
            if (SortBy != null) { request.AddQueryParameter("sort_by", SortBy.ToString()); }
            if (Source != null) { request.AddQueryParameter("source", Source.ToString()); }
            if (TransportNodeId != null) { request.AddQueryParameter("transport_node_id", TransportNodeId.ToString()); }
            request.Resource = GetTier1SegmentTepTableServiceURL.ToString();
            RestResponse<NSXTPolicyTepListResultType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTPolicyTepListResultType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Get operation to " + GetTier1SegmentTepTableServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTPolicyMulticastForwardingInCsvFormatType> GetPolicyMulticastForwardingInCsvFormat(string Tier0Id, string LocaleServicesId, string? Cursor = null, string? EdgePath = null, string? IncludedFields = null, long? PageSize = null, bool? SortAscending = null, string? SortBy = null)
        {
            if (Tier0Id == null) { throw new System.ArgumentNullException("Tier0Id cannot be null"); }
            if (LocaleServicesId == null) { throw new System.ArgumentNullException("LocaleServicesId cannot be null"); }
            StringBuilder GetPolicyMulticastForwardingInCsvFormatServiceURL = new StringBuilder("/infra/tier-0s/{tier-0-id}/locale-services/{locale-services-id}/multicast/forwarding?format=csv");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Get
            };
            GetPolicyMulticastForwardingInCsvFormatServiceURL.Replace("{tier-0-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(Tier0Id, System.Globalization.CultureInfo.InvariantCulture)));
            GetPolicyMulticastForwardingInCsvFormatServiceURL.Replace("{locale-services-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(LocaleServicesId, System.Globalization.CultureInfo.InvariantCulture)));
            if (Cursor != null) { request.AddQueryParameter("cursor", Cursor.ToString()); }
            if (EdgePath != null) { request.AddQueryParameter("edge_path", EdgePath.ToString()); }
            if (IncludedFields != null) { request.AddQueryParameter("included_fields", IncludedFields.ToString()); }
            if (PageSize != null) { request.AddQueryParameter("page_size", PageSize.ToString()); }
            if (SortAscending != null) { request.AddQueryParameter("sort_ascending", SortAscending.ToString()); }
            if (SortBy != null) { request.AddQueryParameter("sort_by", SortBy.ToString()); }
            request.Resource = GetPolicyMulticastForwardingInCsvFormatServiceURL.ToString();
            RestResponse<NSXTPolicyMulticastForwardingInCsvFormatType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTPolicyMulticastForwardingInCsvFormatType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Get operation to " + GetPolicyMulticastForwardingInCsvFormatServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTSegmentPortMacAddressCsvListResultType> GlobalGlobalInfraGetTier1SegmentPortMacTableInCsv(string Tier1Id, string SegmentId, string PortId, string? EnforcementPointPath = null, string? Source = null, string? TransportNodeId = null)
        {
            if (Tier1Id == null) { throw new System.ArgumentNullException("Tier1Id cannot be null"); }
            if (SegmentId == null) { throw new System.ArgumentNullException("SegmentId cannot be null"); }
            if (PortId == null) { throw new System.ArgumentNullException("PortId cannot be null"); }
            StringBuilder GlobalInfraGetTier1SegmentPortMacTableInCsvServiceURL = new StringBuilder("/global-infra/tier-1s/{tier-1-id}/segments/{segment-id}/ports/{port-id}/mac-table?format=csv");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Get
            };
            GlobalInfraGetTier1SegmentPortMacTableInCsvServiceURL.Replace("{tier-1-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(Tier1Id, System.Globalization.CultureInfo.InvariantCulture)));
            GlobalInfraGetTier1SegmentPortMacTableInCsvServiceURL.Replace("{segment-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(SegmentId, System.Globalization.CultureInfo.InvariantCulture)));
            GlobalInfraGetTier1SegmentPortMacTableInCsvServiceURL.Replace("{port-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(PortId, System.Globalization.CultureInfo.InvariantCulture)));
            if (EnforcementPointPath != null) { request.AddQueryParameter("enforcement_point_path", EnforcementPointPath.ToString()); }
            if (Source != null) { request.AddQueryParameter("source", Source.ToString()); }
            if (TransportNodeId != null) { request.AddQueryParameter("transport_node_id", TransportNodeId.ToString()); }
            request.Resource = GlobalInfraGetTier1SegmentPortMacTableInCsvServiceURL.ToString();
            RestResponse<NSXTSegmentPortMacAddressCsvListResultType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTSegmentPortMacAddressCsvListResultType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Get operation to " + GlobalInfraGetTier1SegmentPortMacTableInCsvServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTInterfaceArpTableType> GetTier1InterfaceArpTable(string Tier1Id, string LocaleServiceId, string InterfaceId, string? Cursor = null, string? EdgePath = null, string? EnforcementPointPath = null, string? HostTransportNodePath = null, string? IncludedFields = null, long? PageSize = null, bool? SortAscending = null, string? SortBy = null)
        {
            if (Tier1Id == null) { throw new System.ArgumentNullException("Tier1Id cannot be null"); }
            if (LocaleServiceId == null) { throw new System.ArgumentNullException("LocaleServiceId cannot be null"); }
            if (InterfaceId == null) { throw new System.ArgumentNullException("InterfaceId cannot be null"); }
            StringBuilder GetTier1InterfaceArpTableServiceURL = new StringBuilder("/infra/tier-1s/{tier-1-id}/locale-services/{locale-service-id}/interfaces/{interface-id}/arp-table");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Get
            };
            GetTier1InterfaceArpTableServiceURL.Replace("{tier-1-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(Tier1Id, System.Globalization.CultureInfo.InvariantCulture)));
            GetTier1InterfaceArpTableServiceURL.Replace("{locale-service-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(LocaleServiceId, System.Globalization.CultureInfo.InvariantCulture)));
            GetTier1InterfaceArpTableServiceURL.Replace("{interface-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(InterfaceId, System.Globalization.CultureInfo.InvariantCulture)));
            if (Cursor != null) { request.AddQueryParameter("cursor", Cursor.ToString()); }
            if (EdgePath != null) { request.AddQueryParameter("edge_path", EdgePath.ToString()); }
            if (EnforcementPointPath != null) { request.AddQueryParameter("enforcement_point_path", EnforcementPointPath.ToString()); }
            if (HostTransportNodePath != null) { request.AddQueryParameter("host_transport_node_path", HostTransportNodePath.ToString()); }
            if (IncludedFields != null) { request.AddQueryParameter("included_fields", IncludedFields.ToString()); }
            if (PageSize != null) { request.AddQueryParameter("page_size", PageSize.ToString()); }
            if (SortAscending != null) { request.AddQueryParameter("sort_ascending", SortAscending.ToString()); }
            if (SortBy != null) { request.AddQueryParameter("sort_by", SortBy.ToString()); }
            request.Resource = GetTier1InterfaceArpTableServiceURL.ToString();
            RestResponse<NSXTInterfaceArpTableType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTInterfaceArpTableType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Get operation to " + GetTier1InterfaceArpTableServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTInterfaceArpTableInCsvFormatType> GlobalGlobalInfraGetTier0RouterLinkArpTableCsv(string Tier0Id, string Tier1Path, string? Cursor = null, string? EdgePath = null, string? EnforcementPointPath = null, bool? IncludeMarkForDeleteObjects = null, string? IncludedFields = null, long? PageSize = null, bool? SortAscending = null, string? SortBy = null)
        {
            if (Tier0Id == null) { throw new System.ArgumentNullException("Tier0Id cannot be null"); }
            if (Tier1Path == null) { throw new System.ArgumentNullException("Tier1Path cannot be null"); }
            StringBuilder GlobalInfraGetTier0RouterLinkArpTableCsvServiceURL = new StringBuilder("/global-infra/tier-0s/{tier-0-id}/tier-1-interface/arp-table?format=csv");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Get
            };
            GlobalInfraGetTier0RouterLinkArpTableCsvServiceURL.Replace("{tier-0-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(Tier0Id, System.Globalization.CultureInfo.InvariantCulture)));
            if (Cursor != null) { request.AddQueryParameter("cursor", Cursor.ToString()); }
            if (EdgePath != null) { request.AddQueryParameter("edge_path", EdgePath.ToString()); }
            if (EnforcementPointPath != null) { request.AddQueryParameter("enforcement_point_path", EnforcementPointPath.ToString()); }
            if (IncludeMarkForDeleteObjects != null) { request.AddQueryParameter("include_mark_for_delete_objects", IncludeMarkForDeleteObjects.ToString()); }
            if (IncludedFields != null) { request.AddQueryParameter("included_fields", IncludedFields.ToString()); }
            if (PageSize != null) { request.AddQueryParameter("page_size", PageSize.ToString()); }
            if (SortAscending != null) { request.AddQueryParameter("sort_ascending", SortAscending.ToString()); }
            if (SortBy != null) { request.AddQueryParameter("sort_by", SortBy.ToString()); }
            if (Tier1Path != null) { request.AddQueryParameter("tier1_path", Tier1Path.ToString()); }
            request.Resource = GlobalInfraGetTier0RouterLinkArpTableCsvServiceURL.ToString();
            RestResponse<NSXTInterfaceArpTableInCsvFormatType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTInterfaceArpTableInCsvFormatType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Get operation to " + GlobalInfraGetTier0RouterLinkArpTableCsvServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
    }
}
