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
    public class PolicyConnectivity
    {
        private RestClient restClient;
        private int retry;
        private int timeout;
        private CancellationToken cancellationToken;

        public PolicyConnectivity(RestClient Client, CancellationToken _cancellationToken, int _timeout, int _retry)
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
        public async Task<NSXTDhcpStaticBindingConfigListResultType> GlobalGlobalInfraListSegmentDhcpStaticBinding(string Tier1Id, string SegmentId, string? Cursor = null, bool? IncludeMarkForDeleteObjects = null, string? IncludedFields = null, long? PageSize = null, bool? SortAscending = null, string? SortBy = null)
        {
            if (Tier1Id == null) { throw new System.ArgumentNullException("Tier1Id cannot be null"); }
            if (SegmentId == null) { throw new System.ArgumentNullException("SegmentId cannot be null"); }
            StringBuilder GlobalInfraListSegmentDhcpStaticBindingServiceURL = new StringBuilder("/global-infra/tier-1s/{tier-1-id}/segments/{segment-id}/dhcp-static-binding-configs");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Get
            };
            GlobalInfraListSegmentDhcpStaticBindingServiceURL.Replace("{tier-1-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(Tier1Id, System.Globalization.CultureInfo.InvariantCulture)));
            GlobalInfraListSegmentDhcpStaticBindingServiceURL.Replace("{segment-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(SegmentId, System.Globalization.CultureInfo.InvariantCulture)));
            if (Cursor != null) { request.AddQueryParameter("cursor", Cursor.ToString()); }
            if (IncludeMarkForDeleteObjects != null) { request.AddQueryParameter("include_mark_for_delete_objects", IncludeMarkForDeleteObjects.ToString()); }
            if (IncludedFields != null) { request.AddQueryParameter("included_fields", IncludedFields.ToString()); }
            if (PageSize != null) { request.AddQueryParameter("page_size", PageSize.ToString()); }
            if (SortAscending != null) { request.AddQueryParameter("sort_ascending", SortAscending.ToString()); }
            if (SortBy != null) { request.AddQueryParameter("sort_by", SortBy.ToString()); }
            request.Resource = GlobalInfraListSegmentDhcpStaticBindingServiceURL.ToString();
            RestResponse<NSXTDhcpStaticBindingConfigListResultType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTDhcpStaticBindingConfigListResultType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Get operation to " + GlobalInfraListSegmentDhcpStaticBindingServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTDhcpRelayConfigListResultType> GlobalGlobalInfraListDhcpRelayConfig(string? Cursor = null, bool? IncludeMarkForDeleteObjects = null, string? IncludedFields = null, long? PageSize = null, bool? SortAscending = null, string? SortBy = null)
        {
            StringBuilder GlobalInfraListDhcpRelayConfigServiceURL = new StringBuilder("/global-infra/dhcp-relay-configs");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Get
            };
            if (Cursor != null) { request.AddQueryParameter("cursor", Cursor.ToString()); }
            if (IncludeMarkForDeleteObjects != null) { request.AddQueryParameter("include_mark_for_delete_objects", IncludeMarkForDeleteObjects.ToString()); }
            if (IncludedFields != null) { request.AddQueryParameter("included_fields", IncludedFields.ToString()); }
            if (PageSize != null) { request.AddQueryParameter("page_size", PageSize.ToString()); }
            if (SortAscending != null) { request.AddQueryParameter("sort_ascending", SortAscending.ToString()); }
            if (SortBy != null) { request.AddQueryParameter("sort_by", SortBy.ToString()); }
            request.Resource = GlobalInfraListDhcpRelayConfigServiceURL.ToString();
            RestResponse<NSXTDhcpRelayConfigListResultType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTDhcpRelayConfigListResultType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Get operation to " + GlobalInfraListDhcpRelayConfigServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTDhcpRelayConfigListResultType> ListDhcpRelayConfig(string? Cursor = null, bool? IncludeMarkForDeleteObjects = null, string? IncludedFields = null, long? PageSize = null, bool? SortAscending = null, string? SortBy = null)
        {
            StringBuilder ListDhcpRelayConfigServiceURL = new StringBuilder("/infra/dhcp-relay-configs");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Get
            };
            if (Cursor != null) { request.AddQueryParameter("cursor", Cursor.ToString()); }
            if (IncludeMarkForDeleteObjects != null) { request.AddQueryParameter("include_mark_for_delete_objects", IncludeMarkForDeleteObjects.ToString()); }
            if (IncludedFields != null) { request.AddQueryParameter("included_fields", IncludedFields.ToString()); }
            if (PageSize != null) { request.AddQueryParameter("page_size", PageSize.ToString()); }
            if (SortAscending != null) { request.AddQueryParameter("sort_ascending", SortAscending.ToString()); }
            if (SortBy != null) { request.AddQueryParameter("sort_by", SortBy.ToString()); }
            request.Resource = ListDhcpRelayConfigServiceURL.ToString();
            RestResponse<NSXTDhcpRelayConfigListResultType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTDhcpRelayConfigListResultType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Get operation to " + ListDhcpRelayConfigServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTDhcpServerConfigType> GlobalGlobalInfraReadDhcpServerConfig(string DhcpServerConfigId)
        {
            if (DhcpServerConfigId == null) { throw new System.ArgumentNullException("DhcpServerConfigId cannot be null"); }
            StringBuilder GlobalInfraReadDhcpServerConfigServiceURL = new StringBuilder("/global-infra/dhcp-server-configs/{dhcp-server-config-id}");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Get
            };
            GlobalInfraReadDhcpServerConfigServiceURL.Replace("{dhcp-server-config-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(DhcpServerConfigId, System.Globalization.CultureInfo.InvariantCulture)));
            request.Resource = GlobalInfraReadDhcpServerConfigServiceURL.ToString();
            RestResponse<NSXTDhcpServerConfigType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTDhcpServerConfigType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Get operation to " + GlobalInfraReadDhcpServerConfigServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTAntreaTraceflowConfigType> UpdateAntreaTraceflowConfig(string TraceflowId, NSXTAntreaTraceflowConfigType AntreaTraceflowConfig)
        {
            if (TraceflowId == null) { throw new System.ArgumentNullException("TraceflowId cannot be null"); }
            if (AntreaTraceflowConfig == null) { throw new System.ArgumentNullException("AntreaTraceflowConfig cannot be null"); }
            StringBuilder UpdateAntreaTraceflowConfigServiceURL = new StringBuilder("/infra/antrea/traceflows/{traceflow-id}");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Put
            };
            UpdateAntreaTraceflowConfigServiceURL.Replace("{traceflow-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(TraceflowId, System.Globalization.CultureInfo.InvariantCulture)));
            request.AddJsonBody(AntreaTraceflowConfig);
            request.Resource = UpdateAntreaTraceflowConfigServiceURL.ToString();
            RestResponse<NSXTAntreaTraceflowConfigType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTAntreaTraceflowConfigType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Put operation to " + UpdateAntreaTraceflowConfigServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTAntreaTraceflowConfigType> ReadAntreaTraceflowConfig(string TraceflowId)
        {
            if (TraceflowId == null) { throw new System.ArgumentNullException("TraceflowId cannot be null"); }
            StringBuilder ReadAntreaTraceflowConfigServiceURL = new StringBuilder("/infra/antrea/traceflows/{traceflow-id}");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Get
            };
            ReadAntreaTraceflowConfigServiceURL.Replace("{traceflow-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(TraceflowId, System.Globalization.CultureInfo.InvariantCulture)));
            request.Resource = ReadAntreaTraceflowConfigServiceURL.ToString();
            RestResponse<NSXTAntreaTraceflowConfigType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTAntreaTraceflowConfigType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Get operation to " + ReadAntreaTraceflowConfigServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task PatchAntreaTraceflowConfig(string TraceflowId, NSXTAntreaTraceflowConfigType AntreaTraceflowConfig)
        {
            if (TraceflowId == null) { throw new System.ArgumentNullException("TraceflowId cannot be null"); }
            if (AntreaTraceflowConfig == null) { throw new System.ArgumentNullException("AntreaTraceflowConfig cannot be null"); }
            StringBuilder PatchAntreaTraceflowConfigServiceURL = new StringBuilder("/infra/antrea/traceflows/{traceflow-id}");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Patch
            };
            PatchAntreaTraceflowConfigServiceURL.Replace("{traceflow-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(TraceflowId, System.Globalization.CultureInfo.InvariantCulture)));
            request.AddJsonBody(AntreaTraceflowConfig);
            request.Resource = PatchAntreaTraceflowConfigServiceURL.ToString();
            RestResponse response = await restClient.ExecuteTaskAsyncWithPolicy(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Patch operation to " + PatchAntreaTraceflowConfigServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTAntreaTraceflowConfigType> RestartAntreaTraceflow(string TraceflowId, string? Action = null)
        {
            if (TraceflowId == null) { throw new System.ArgumentNullException("TraceflowId cannot be null"); }
            StringBuilder RestartAntreaTraceflowServiceURL = new StringBuilder("/infra/antrea/traceflows/{traceflow-id}");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Post
            };
            RestartAntreaTraceflowServiceURL.Replace("{traceflow-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(TraceflowId, System.Globalization.CultureInfo.InvariantCulture)));
            if (Action != null) { request.AddQueryParameter("action", Action.ToString()); }
            request.Resource = RestartAntreaTraceflowServiceURL.ToString();
            RestResponse<NSXTAntreaTraceflowConfigType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTAntreaTraceflowConfigType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Post operation to " + RestartAntreaTraceflowServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task DeleteAntreaTraceflowConfig(string TraceflowId)
        {
            if (TraceflowId == null) { throw new System.ArgumentNullException("TraceflowId cannot be null"); }
            StringBuilder DeleteAntreaTraceflowConfigServiceURL = new StringBuilder("/infra/antrea/traceflows/{traceflow-id}");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Delete
            };
            DeleteAntreaTraceflowConfigServiceURL.Replace("{traceflow-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(TraceflowId, System.Globalization.CultureInfo.InvariantCulture)));
            request.Resource = DeleteAntreaTraceflowConfigServiceURL.ToString();
            RestResponse response = await restClient.ExecuteTaskAsyncWithPolicy(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Delete operation to " + DeleteAntreaTraceflowConfigServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTSegmentType> CreateOrReplaceInfraSegment(string SegmentId, NSXTSegmentType Segment)
        {
            if (SegmentId == null) { throw new System.ArgumentNullException("SegmentId cannot be null"); }
            if (Segment == null) { throw new System.ArgumentNullException("Segment cannot be null"); }
            StringBuilder CreateOrReplaceInfraSegmentServiceURL = new StringBuilder("/infra/segments/{segment-id}");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Put
            };
            CreateOrReplaceInfraSegmentServiceURL.Replace("{segment-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(SegmentId, System.Globalization.CultureInfo.InvariantCulture)));
            request.AddJsonBody(Segment);
            request.Resource = CreateOrReplaceInfraSegmentServiceURL.ToString();
            RestResponse<NSXTSegmentType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTSegmentType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Put operation to " + CreateOrReplaceInfraSegmentServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTSegmentType> ReadInfraSegment(string SegmentId)
        {
            if (SegmentId == null) { throw new System.ArgumentNullException("SegmentId cannot be null"); }
            StringBuilder ReadInfraSegmentServiceURL = new StringBuilder("/infra/segments/{segment-id}");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Get
            };
            ReadInfraSegmentServiceURL.Replace("{segment-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(SegmentId, System.Globalization.CultureInfo.InvariantCulture)));
            request.Resource = ReadInfraSegmentServiceURL.ToString();
            RestResponse<NSXTSegmentType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTSegmentType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Get operation to " + ReadInfraSegmentServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task PatchInfraSegment(string SegmentId, NSXTSegmentType Segment)
        {
            if (SegmentId == null) { throw new System.ArgumentNullException("SegmentId cannot be null"); }
            if (Segment == null) { throw new System.ArgumentNullException("Segment cannot be null"); }
            StringBuilder PatchInfraSegmentServiceURL = new StringBuilder("/infra/segments/{segment-id}");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Patch
            };
            PatchInfraSegmentServiceURL.Replace("{segment-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(SegmentId, System.Globalization.CultureInfo.InvariantCulture)));
            request.AddJsonBody(Segment);
            request.Resource = PatchInfraSegmentServiceURL.ToString();
            RestResponse response = await restClient.ExecuteTaskAsyncWithPolicy(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Patch operation to " + PatchInfraSegmentServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task DeleteInfraSegment(string SegmentId)
        {
            if (SegmentId == null) { throw new System.ArgumentNullException("SegmentId cannot be null"); }
            StringBuilder DeleteInfraSegmentServiceURL = new StringBuilder("/infra/segments/{segment-id}");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Delete
            };
            DeleteInfraSegmentServiceURL.Replace("{segment-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(SegmentId, System.Globalization.CultureInfo.InvariantCulture)));
            request.Resource = DeleteInfraSegmentServiceURL.ToString();
            RestResponse response = await restClient.ExecuteTaskAsyncWithPolicy(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Delete operation to " + DeleteInfraSegmentServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTDhcpStaticBindingConfigType> GlobalGlobalInfraReadSegmentDhcpStaticBinding(string Tier1Id, string SegmentId, string BindingId)
        {
            if (Tier1Id == null) { throw new System.ArgumentNullException("Tier1Id cannot be null"); }
            if (SegmentId == null) { throw new System.ArgumentNullException("SegmentId cannot be null"); }
            if (BindingId == null) { throw new System.ArgumentNullException("BindingId cannot be null"); }
            StringBuilder GlobalInfraReadSegmentDhcpStaticBindingServiceURL = new StringBuilder("/global-infra/tier-1s/{tier-1-id}/segments/{segment-id}/dhcp-static-binding-configs/{binding-id}");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Get
            };
            GlobalInfraReadSegmentDhcpStaticBindingServiceURL.Replace("{tier-1-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(Tier1Id, System.Globalization.CultureInfo.InvariantCulture)));
            GlobalInfraReadSegmentDhcpStaticBindingServiceURL.Replace("{segment-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(SegmentId, System.Globalization.CultureInfo.InvariantCulture)));
            GlobalInfraReadSegmentDhcpStaticBindingServiceURL.Replace("{binding-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(BindingId, System.Globalization.CultureInfo.InvariantCulture)));
            request.Resource = GlobalInfraReadSegmentDhcpStaticBindingServiceURL.ToString();
            RestResponse<NSXTDhcpStaticBindingConfigType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTDhcpStaticBindingConfigType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Get operation to " + GlobalInfraReadSegmentDhcpStaticBindingServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTGatewayQosProfileType> GlobalGlobalInfraCreateOrReplaceGatewayQosProfile(string QosProfileId, NSXTGatewayQosProfileType GatewayQosProfile, bool? Override = null)
        {
            if (QosProfileId == null) { throw new System.ArgumentNullException("QosProfileId cannot be null"); }
            if (GatewayQosProfile == null) { throw new System.ArgumentNullException("GatewayQosProfile cannot be null"); }
            StringBuilder GlobalInfraCreateOrReplaceGatewayQosProfileServiceURL = new StringBuilder("/global-infra/gateway-qos-profiles/{qos-profile-id}");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Put
            };
            GlobalInfraCreateOrReplaceGatewayQosProfileServiceURL.Replace("{qos-profile-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(QosProfileId, System.Globalization.CultureInfo.InvariantCulture)));
            request.AddJsonBody(GatewayQosProfile);
            if (Override != null) { request.AddQueryParameter("override", Override.ToString()); }
            request.Resource = GlobalInfraCreateOrReplaceGatewayQosProfileServiceURL.ToString();
            RestResponse<NSXTGatewayQosProfileType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTGatewayQosProfileType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Put operation to " + GlobalInfraCreateOrReplaceGatewayQosProfileServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task GlobalGlobalInfraPatchGatewayQosProfile(string QosProfileId, NSXTGatewayQosProfileType GatewayQosProfile, bool? Override = null)
        {
            if (QosProfileId == null) { throw new System.ArgumentNullException("QosProfileId cannot be null"); }
            if (GatewayQosProfile == null) { throw new System.ArgumentNullException("GatewayQosProfile cannot be null"); }
            StringBuilder GlobalInfraPatchGatewayQosProfileServiceURL = new StringBuilder("/global-infra/gateway-qos-profiles/{qos-profile-id}");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Patch
            };
            GlobalInfraPatchGatewayQosProfileServiceURL.Replace("{qos-profile-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(QosProfileId, System.Globalization.CultureInfo.InvariantCulture)));
            request.AddJsonBody(GatewayQosProfile);
            if (Override != null) { request.AddQueryParameter("override", Override.ToString()); }
            request.Resource = GlobalInfraPatchGatewayQosProfileServiceURL.ToString();
            RestResponse response = await restClient.ExecuteTaskAsyncWithPolicy(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Patch operation to " + GlobalInfraPatchGatewayQosProfileServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task GlobalGlobalInfraDeleteGatewayQosProfile(string QosProfileId, bool? Override = null)
        {
            if (QosProfileId == null) { throw new System.ArgumentNullException("QosProfileId cannot be null"); }
            StringBuilder GlobalInfraDeleteGatewayQosProfileServiceURL = new StringBuilder("/global-infra/gateway-qos-profiles/{qos-profile-id}");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Delete
            };
            GlobalInfraDeleteGatewayQosProfileServiceURL.Replace("{qos-profile-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(QosProfileId, System.Globalization.CultureInfo.InvariantCulture)));
            if (Override != null) { request.AddQueryParameter("override", Override.ToString()); }
            request.Resource = GlobalInfraDeleteGatewayQosProfileServiceURL.ToString();
            RestResponse response = await restClient.ExecuteTaskAsyncWithPolicy(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Delete operation to " + GlobalInfraDeleteGatewayQosProfileServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTGatewayQosProfileType> GlobalGlobalInfraReadGatewayQosProfile(string QosProfileId)
        {
            if (QosProfileId == null) { throw new System.ArgumentNullException("QosProfileId cannot be null"); }
            StringBuilder GlobalInfraReadGatewayQosProfileServiceURL = new StringBuilder("/global-infra/gateway-qos-profiles/{qos-profile-id}");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Get
            };
            GlobalInfraReadGatewayQosProfileServiceURL.Replace("{qos-profile-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(QosProfileId, System.Globalization.CultureInfo.InvariantCulture)));
            request.Resource = GlobalInfraReadGatewayQosProfileServiceURL.ToString();
            RestResponse<NSXTGatewayQosProfileType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTGatewayQosProfileType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Get operation to " + GlobalInfraReadGatewayQosProfileServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTStaticRoutesType> GlobalGlobalInfraCreateOrReplaceTier0StaticRoutes(string Tier0Id, string RouteId, NSXTStaticRoutesType StaticRoutes)
        {
            if (Tier0Id == null) { throw new System.ArgumentNullException("Tier0Id cannot be null"); }
            if (RouteId == null) { throw new System.ArgumentNullException("RouteId cannot be null"); }
            if (StaticRoutes == null) { throw new System.ArgumentNullException("StaticRoutes cannot be null"); }
            StringBuilder GlobalInfraCreateOrReplaceTier0StaticRoutesServiceURL = new StringBuilder("/global-infra/tier-0s/{tier-0-id}/static-routes/{route-id}");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Put
            };
            GlobalInfraCreateOrReplaceTier0StaticRoutesServiceURL.Replace("{tier-0-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(Tier0Id, System.Globalization.CultureInfo.InvariantCulture)));
            GlobalInfraCreateOrReplaceTier0StaticRoutesServiceURL.Replace("{route-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(RouteId, System.Globalization.CultureInfo.InvariantCulture)));
            request.AddJsonBody(StaticRoutes);
            request.Resource = GlobalInfraCreateOrReplaceTier0StaticRoutesServiceURL.ToString();
            RestResponse<NSXTStaticRoutesType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTStaticRoutesType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Put operation to " + GlobalInfraCreateOrReplaceTier0StaticRoutesServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTStaticRoutesType> GlobalGlobalInfraReadTier0StaticRoutes(string Tier0Id, string RouteId)
        {
            if (Tier0Id == null) { throw new System.ArgumentNullException("Tier0Id cannot be null"); }
            if (RouteId == null) { throw new System.ArgumentNullException("RouteId cannot be null"); }
            StringBuilder GlobalInfraReadTier0StaticRoutesServiceURL = new StringBuilder("/global-infra/tier-0s/{tier-0-id}/static-routes/{route-id}");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Get
            };
            GlobalInfraReadTier0StaticRoutesServiceURL.Replace("{tier-0-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(Tier0Id, System.Globalization.CultureInfo.InvariantCulture)));
            GlobalInfraReadTier0StaticRoutesServiceURL.Replace("{route-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(RouteId, System.Globalization.CultureInfo.InvariantCulture)));
            request.Resource = GlobalInfraReadTier0StaticRoutesServiceURL.ToString();
            RestResponse<NSXTStaticRoutesType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTStaticRoutesType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Get operation to " + GlobalInfraReadTier0StaticRoutesServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTTier0RouteMapType> CreateOrReplaceRouteMap(string Tier0Id, string RouteMapId, NSXTTier0RouteMapType Tier0RouteMap)
        {
            if (Tier0Id == null) { throw new System.ArgumentNullException("Tier0Id cannot be null"); }
            if (RouteMapId == null) { throw new System.ArgumentNullException("RouteMapId cannot be null"); }
            if (Tier0RouteMap == null) { throw new System.ArgumentNullException("Tier0RouteMap cannot be null"); }
            StringBuilder CreateOrReplaceRouteMapServiceURL = new StringBuilder("/infra/tier-0s/{tier-0-id}/route-maps/{route-map-id}");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Put
            };
            CreateOrReplaceRouteMapServiceURL.Replace("{tier-0-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(Tier0Id, System.Globalization.CultureInfo.InvariantCulture)));
            CreateOrReplaceRouteMapServiceURL.Replace("{route-map-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(RouteMapId, System.Globalization.CultureInfo.InvariantCulture)));
            request.AddJsonBody(Tier0RouteMap);
            request.Resource = CreateOrReplaceRouteMapServiceURL.ToString();
            RestResponse<NSXTTier0RouteMapType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTTier0RouteMapType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Put operation to " + CreateOrReplaceRouteMapServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task RemoveRouteMap(string Tier0Id, string RouteMapId)
        {
            if (Tier0Id == null) { throw new System.ArgumentNullException("Tier0Id cannot be null"); }
            if (RouteMapId == null) { throw new System.ArgumentNullException("RouteMapId cannot be null"); }
            StringBuilder RemoveRouteMapServiceURL = new StringBuilder("/infra/tier-0s/{tier-0-id}/route-maps/{route-map-id}");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Delete
            };
            RemoveRouteMapServiceURL.Replace("{tier-0-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(Tier0Id, System.Globalization.CultureInfo.InvariantCulture)));
            RemoveRouteMapServiceURL.Replace("{route-map-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(RouteMapId, System.Globalization.CultureInfo.InvariantCulture)));
            request.Resource = RemoveRouteMapServiceURL.ToString();
            RestResponse response = await restClient.ExecuteTaskAsyncWithPolicy(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Delete operation to " + RemoveRouteMapServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task PatchRouteMap(string Tier0Id, string RouteMapId, NSXTTier0RouteMapType Tier0RouteMap)
        {
            if (Tier0Id == null) { throw new System.ArgumentNullException("Tier0Id cannot be null"); }
            if (RouteMapId == null) { throw new System.ArgumentNullException("RouteMapId cannot be null"); }
            if (Tier0RouteMap == null) { throw new System.ArgumentNullException("Tier0RouteMap cannot be null"); }
            StringBuilder PatchRouteMapServiceURL = new StringBuilder("/infra/tier-0s/{tier-0-id}/route-maps/{route-map-id}");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Patch
            };
            PatchRouteMapServiceURL.Replace("{tier-0-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(Tier0Id, System.Globalization.CultureInfo.InvariantCulture)));
            PatchRouteMapServiceURL.Replace("{route-map-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(RouteMapId, System.Globalization.CultureInfo.InvariantCulture)));
            request.AddJsonBody(Tier0RouteMap);
            request.Resource = PatchRouteMapServiceURL.ToString();
            RestResponse response = await restClient.ExecuteTaskAsyncWithPolicy(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Patch operation to " + PatchRouteMapServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTTier0RouteMapType> GetRouteMap(string Tier0Id, string RouteMapId)
        {
            if (Tier0Id == null) { throw new System.ArgumentNullException("Tier0Id cannot be null"); }
            if (RouteMapId == null) { throw new System.ArgumentNullException("RouteMapId cannot be null"); }
            StringBuilder GetRouteMapServiceURL = new StringBuilder("/infra/tier-0s/{tier-0-id}/route-maps/{route-map-id}");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Get
            };
            GetRouteMapServiceURL.Replace("{tier-0-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(Tier0Id, System.Globalization.CultureInfo.InvariantCulture)));
            GetRouteMapServiceURL.Replace("{route-map-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(RouteMapId, System.Globalization.CultureInfo.InvariantCulture)));
            request.Resource = GetRouteMapServiceURL.ToString();
            RestResponse<NSXTTier0RouteMapType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTTier0RouteMapType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Get operation to " + GetRouteMapServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTSegmentPortListResultType> ListInfraSegmentPorts(string SegmentId, string? Cursor = null, bool? IncludeMarkForDeleteObjects = null, string? IncludedFields = null, long? PageSize = null, bool? SortAscending = null, string? SortBy = null)
        {
            if (SegmentId == null) { throw new System.ArgumentNullException("SegmentId cannot be null"); }
            StringBuilder ListInfraSegmentPortsServiceURL = new StringBuilder("/infra/segments/{segment-id}/ports");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Get
            };
            ListInfraSegmentPortsServiceURL.Replace("{segment-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(SegmentId, System.Globalization.CultureInfo.InvariantCulture)));
            if (Cursor != null) { request.AddQueryParameter("cursor", Cursor.ToString()); }
            if (IncludeMarkForDeleteObjects != null) { request.AddQueryParameter("include_mark_for_delete_objects", IncludeMarkForDeleteObjects.ToString()); }
            if (IncludedFields != null) { request.AddQueryParameter("included_fields", IncludedFields.ToString()); }
            if (PageSize != null) { request.AddQueryParameter("page_size", PageSize.ToString()); }
            if (SortAscending != null) { request.AddQueryParameter("sort_ascending", SortAscending.ToString()); }
            if (SortBy != null) { request.AddQueryParameter("sort_by", SortBy.ToString()); }
            request.Resource = ListInfraSegmentPortsServiceURL.ToString();
            RestResponse<NSXTSegmentPortListResultType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTSegmentPortListResultType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Get operation to " + ListInfraSegmentPortsServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTDhcpStaticBindingConfigListResultType> ListInfraSegmentDhcpStaticBinding(string SegmentId, string? Cursor = null, bool? IncludeMarkForDeleteObjects = null, string? IncludedFields = null, long? PageSize = null, bool? SortAscending = null, string? SortBy = null)
        {
            if (SegmentId == null) { throw new System.ArgumentNullException("SegmentId cannot be null"); }
            StringBuilder ListInfraSegmentDhcpStaticBindingServiceURL = new StringBuilder("/infra/segments/{segment-id}/dhcp-static-binding-configs");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Get
            };
            ListInfraSegmentDhcpStaticBindingServiceURL.Replace("{segment-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(SegmentId, System.Globalization.CultureInfo.InvariantCulture)));
            if (Cursor != null) { request.AddQueryParameter("cursor", Cursor.ToString()); }
            if (IncludeMarkForDeleteObjects != null) { request.AddQueryParameter("include_mark_for_delete_objects", IncludeMarkForDeleteObjects.ToString()); }
            if (IncludedFields != null) { request.AddQueryParameter("included_fields", IncludedFields.ToString()); }
            if (PageSize != null) { request.AddQueryParameter("page_size", PageSize.ToString()); }
            if (SortAscending != null) { request.AddQueryParameter("sort_ascending", SortAscending.ToString()); }
            if (SortBy != null) { request.AddQueryParameter("sort_by", SortBy.ToString()); }
            request.Resource = ListInfraSegmentDhcpStaticBindingServiceURL.ToString();
            RestResponse<NSXTDhcpStaticBindingConfigListResultType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTDhcpStaticBindingConfigListResultType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Get operation to " + ListInfraSegmentDhcpStaticBindingServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTSegmentType> CreateOrReplaceInfraSegmentWithForce(string SegmentId, NSXTSegmentType Segment)
        {
            if (SegmentId == null) { throw new System.ArgumentNullException("SegmentId cannot be null"); }
            if (Segment == null) { throw new System.ArgumentNullException("Segment cannot be null"); }
            StringBuilder CreateOrReplaceInfraSegmentWithForceServiceURL = new StringBuilder("/infra/segments/{segment-id}?force=true");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Put
            };
            CreateOrReplaceInfraSegmentWithForceServiceURL.Replace("{segment-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(SegmentId, System.Globalization.CultureInfo.InvariantCulture)));
            request.AddJsonBody(Segment);
            request.Resource = CreateOrReplaceInfraSegmentWithForceServiceURL.ToString();
            RestResponse<NSXTSegmentType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTSegmentType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Put operation to " + CreateOrReplaceInfraSegmentWithForceServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task ForceDeleteInfraSegment(string SegmentId, bool? Cascade = null)
        {
            if (SegmentId == null) { throw new System.ArgumentNullException("SegmentId cannot be null"); }
            StringBuilder ForceDeleteInfraSegmentServiceURL = new StringBuilder("/infra/segments/{segment-id}?force=true");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Delete
            };
            ForceDeleteInfraSegmentServiceURL.Replace("{segment-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(SegmentId, System.Globalization.CultureInfo.InvariantCulture)));
            if (Cascade != null) { request.AddQueryParameter("cascade", Cascade.ToString()); }
            request.Resource = ForceDeleteInfraSegmentServiceURL.ToString();
            RestResponse response = await restClient.ExecuteTaskAsyncWithPolicy(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Delete operation to " + ForceDeleteInfraSegmentServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task PatchInfraSegmentWithForce(string SegmentId, NSXTSegmentType Segment)
        {
            if (SegmentId == null) { throw new System.ArgumentNullException("SegmentId cannot be null"); }
            if (Segment == null) { throw new System.ArgumentNullException("Segment cannot be null"); }
            StringBuilder PatchInfraSegmentWithForceServiceURL = new StringBuilder("/infra/segments/{segment-id}?force=true");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Patch
            };
            PatchInfraSegmentWithForceServiceURL.Replace("{segment-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(SegmentId, System.Globalization.CultureInfo.InvariantCulture)));
            request.AddJsonBody(Segment);
            request.Resource = PatchInfraSegmentWithForceServiceURL.ToString();
            RestResponse response = await restClient.ExecuteTaskAsyncWithPolicy(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Patch operation to " + PatchInfraSegmentWithForceServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTSegmentPortListResultType> GlobalGlobalInfraListInfraSegmentPorts(string SegmentId, string? Cursor = null, bool? IncludeMarkForDeleteObjects = null, string? IncludedFields = null, long? PageSize = null, bool? SortAscending = null, string? SortBy = null)
        {
            if (SegmentId == null) { throw new System.ArgumentNullException("SegmentId cannot be null"); }
            StringBuilder GlobalInfraListInfraSegmentPortsServiceURL = new StringBuilder("/global-infra/segments/{segment-id}/ports");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Get
            };
            GlobalInfraListInfraSegmentPortsServiceURL.Replace("{segment-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(SegmentId, System.Globalization.CultureInfo.InvariantCulture)));
            if (Cursor != null) { request.AddQueryParameter("cursor", Cursor.ToString()); }
            if (IncludeMarkForDeleteObjects != null) { request.AddQueryParameter("include_mark_for_delete_objects", IncludeMarkForDeleteObjects.ToString()); }
            if (IncludedFields != null) { request.AddQueryParameter("included_fields", IncludedFields.ToString()); }
            if (PageSize != null) { request.AddQueryParameter("page_size", PageSize.ToString()); }
            if (SortAscending != null) { request.AddQueryParameter("sort_ascending", SortAscending.ToString()); }
            if (SortBy != null) { request.AddQueryParameter("sort_by", SortBy.ToString()); }
            request.Resource = GlobalInfraListInfraSegmentPortsServiceURL.ToString();
            RestResponse<NSXTSegmentPortListResultType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTSegmentPortListResultType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Get operation to " + GlobalInfraListInfraSegmentPortsServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTPrefixListResultType> ListPrefixLists(string Tier0Id, string? Cursor = null, bool? IncludeMarkForDeleteObjects = null, string? IncludedFields = null, long? PageSize = null, bool? SortAscending = null, string? SortBy = null)
        {
            if (Tier0Id == null) { throw new System.ArgumentNullException("Tier0Id cannot be null"); }
            StringBuilder ListPrefixListsServiceURL = new StringBuilder("/infra/tier-0s/{tier-0-id}/prefix-lists");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Get
            };
            ListPrefixListsServiceURL.Replace("{tier-0-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(Tier0Id, System.Globalization.CultureInfo.InvariantCulture)));
            if (Cursor != null) { request.AddQueryParameter("cursor", Cursor.ToString()); }
            if (IncludeMarkForDeleteObjects != null) { request.AddQueryParameter("include_mark_for_delete_objects", IncludeMarkForDeleteObjects.ToString()); }
            if (IncludedFields != null) { request.AddQueryParameter("included_fields", IncludedFields.ToString()); }
            if (PageSize != null) { request.AddQueryParameter("page_size", PageSize.ToString()); }
            if (SortAscending != null) { request.AddQueryParameter("sort_ascending", SortAscending.ToString()); }
            if (SortBy != null) { request.AddQueryParameter("sort_by", SortBy.ToString()); }
            request.Resource = ListPrefixListsServiceURL.ToString();
            RestResponse<NSXTPrefixListResultType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTPrefixListResultType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Get operation to " + ListPrefixListsServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task DeleteDhcpLease(string SegmentId, NSXTDhcpDeleteLeasesType DhcpDeleteLeases, string? EnforcementPointPath = null)
        {
            if (SegmentId == null) { throw new System.ArgumentNullException("SegmentId cannot be null"); }
            if (DhcpDeleteLeases == null) { throw new System.ArgumentNullException("DhcpDeleteLeases cannot be null"); }
            StringBuilder DeleteDhcpLeaseServiceURL = new StringBuilder("/infra/segments/{segment-id}?action=delete_dhcp_leases");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Post
            };
            DeleteDhcpLeaseServiceURL.Replace("{segment-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(SegmentId, System.Globalization.CultureInfo.InvariantCulture)));
            request.AddJsonBody(DhcpDeleteLeases);
            if (EnforcementPointPath != null) { request.AddQueryParameter("enforcement_point_path", EnforcementPointPath.ToString()); }
            request.Resource = DeleteDhcpLeaseServiceURL.ToString();
            RestResponse response = await restClient.ExecuteTaskAsyncWithPolicy(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Post operation to " + DeleteDhcpLeaseServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTStaticRouteBfdPeerType> GlobalGlobalInfraReadStaticRouteBfdPeer(string Tier0Id, string BfdPeerId)
        {
            if (Tier0Id == null) { throw new System.ArgumentNullException("Tier0Id cannot be null"); }
            if (BfdPeerId == null) { throw new System.ArgumentNullException("BfdPeerId cannot be null"); }
            StringBuilder GlobalInfraReadStaticRouteBfdPeerServiceURL = new StringBuilder("/global-infra/tier-0s/{tier-0-id}/static-routes/bfd-peers/{bfd-peer-id}");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Get
            };
            GlobalInfraReadStaticRouteBfdPeerServiceURL.Replace("{tier-0-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(Tier0Id, System.Globalization.CultureInfo.InvariantCulture)));
            GlobalInfraReadStaticRouteBfdPeerServiceURL.Replace("{bfd-peer-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(BfdPeerId, System.Globalization.CultureInfo.InvariantCulture)));
            request.Resource = GlobalInfraReadStaticRouteBfdPeerServiceURL.ToString();
            RestResponse<NSXTStaticRouteBfdPeerType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTStaticRouteBfdPeerType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Get operation to " + GlobalInfraReadStaticRouteBfdPeerServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTEvpnTenantConfigType> CreateOrUpdateEvpnTenantConfig(string ConfigId, NSXTEvpnTenantConfigType EvpnTenantConfig)
        {
            if (ConfigId == null) { throw new System.ArgumentNullException("ConfigId cannot be null"); }
            if (EvpnTenantConfig == null) { throw new System.ArgumentNullException("EvpnTenantConfig cannot be null"); }
            StringBuilder CreateOrUpdateEvpnTenantConfigServiceURL = new StringBuilder("/infra/evpn-tenant-configs/{config-id}");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Put
            };
            CreateOrUpdateEvpnTenantConfigServiceURL.Replace("{config-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(ConfigId, System.Globalization.CultureInfo.InvariantCulture)));
            request.AddJsonBody(EvpnTenantConfig);
            request.Resource = CreateOrUpdateEvpnTenantConfigServiceURL.ToString();
            RestResponse<NSXTEvpnTenantConfigType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTEvpnTenantConfigType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Put operation to " + CreateOrUpdateEvpnTenantConfigServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task DeleteEvpnTenantConfig(string ConfigId)
        {
            if (ConfigId == null) { throw new System.ArgumentNullException("ConfigId cannot be null"); }
            StringBuilder DeleteEvpnTenantConfigServiceURL = new StringBuilder("/infra/evpn-tenant-configs/{config-id}");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Delete
            };
            DeleteEvpnTenantConfigServiceURL.Replace("{config-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(ConfigId, System.Globalization.CultureInfo.InvariantCulture)));
            request.Resource = DeleteEvpnTenantConfigServiceURL.ToString();
            RestResponse response = await restClient.ExecuteTaskAsyncWithPolicy(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Delete operation to " + DeleteEvpnTenantConfigServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTEvpnTenantConfigType> ReadEvpnTenantConfig(string ConfigId)
        {
            if (ConfigId == null) { throw new System.ArgumentNullException("ConfigId cannot be null"); }
            StringBuilder ReadEvpnTenantConfigServiceURL = new StringBuilder("/infra/evpn-tenant-configs/{config-id}");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Get
            };
            ReadEvpnTenantConfigServiceURL.Replace("{config-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(ConfigId, System.Globalization.CultureInfo.InvariantCulture)));
            request.Resource = ReadEvpnTenantConfigServiceURL.ToString();
            RestResponse<NSXTEvpnTenantConfigType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTEvpnTenantConfigType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Get operation to " + ReadEvpnTenantConfigServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task PatchEvpnTenantConfig(string ConfigId, NSXTEvpnTenantConfigType EvpnTenantConfig)
        {
            if (ConfigId == null) { throw new System.ArgumentNullException("ConfigId cannot be null"); }
            if (EvpnTenantConfig == null) { throw new System.ArgumentNullException("EvpnTenantConfig cannot be null"); }
            StringBuilder PatchEvpnTenantConfigServiceURL = new StringBuilder("/infra/evpn-tenant-configs/{config-id}");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Patch
            };
            PatchEvpnTenantConfigServiceURL.Replace("{config-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(ConfigId, System.Globalization.CultureInfo.InvariantCulture)));
            request.AddJsonBody(EvpnTenantConfig);
            request.Resource = PatchEvpnTenantConfigServiceURL.ToString();
            RestResponse response = await restClient.ExecuteTaskAsyncWithPolicy(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Patch operation to " + PatchEvpnTenantConfigServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTEvpnTunnelEndpointConfigType> CreateOrUpdateEvpnTunnelEndpointConfig(string Tier0Id, string LocaleServicesId, string TunnelEndpointId, NSXTEvpnTunnelEndpointConfigType EvpnTunnelEndpointConfig)
        {
            if (Tier0Id == null) { throw new System.ArgumentNullException("Tier0Id cannot be null"); }
            if (LocaleServicesId == null) { throw new System.ArgumentNullException("LocaleServicesId cannot be null"); }
            if (TunnelEndpointId == null) { throw new System.ArgumentNullException("TunnelEndpointId cannot be null"); }
            if (EvpnTunnelEndpointConfig == null) { throw new System.ArgumentNullException("EvpnTunnelEndpointConfig cannot be null"); }
            StringBuilder CreateOrUpdateEvpnTunnelEndpointConfigServiceURL = new StringBuilder("/infra/tier-0s/{tier-0-id}/locale-services/{locale-services-id}/evpn-tunnel-endpoints/{tunnel-endpoint-id}");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Put
            };
            CreateOrUpdateEvpnTunnelEndpointConfigServiceURL.Replace("{tier-0-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(Tier0Id, System.Globalization.CultureInfo.InvariantCulture)));
            CreateOrUpdateEvpnTunnelEndpointConfigServiceURL.Replace("{locale-services-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(LocaleServicesId, System.Globalization.CultureInfo.InvariantCulture)));
            CreateOrUpdateEvpnTunnelEndpointConfigServiceURL.Replace("{tunnel-endpoint-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(TunnelEndpointId, System.Globalization.CultureInfo.InvariantCulture)));
            request.AddJsonBody(EvpnTunnelEndpointConfig);
            request.Resource = CreateOrUpdateEvpnTunnelEndpointConfigServiceURL.ToString();
            RestResponse<NSXTEvpnTunnelEndpointConfigType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTEvpnTunnelEndpointConfigType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Put operation to " + CreateOrUpdateEvpnTunnelEndpointConfigServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task PatchEvpnTunnelEndpointConfig(string Tier0Id, string LocaleServicesId, string TunnelEndpointId, NSXTEvpnTunnelEndpointConfigType EvpnTunnelEndpointConfig)
        {
            if (Tier0Id == null) { throw new System.ArgumentNullException("Tier0Id cannot be null"); }
            if (LocaleServicesId == null) { throw new System.ArgumentNullException("LocaleServicesId cannot be null"); }
            if (TunnelEndpointId == null) { throw new System.ArgumentNullException("TunnelEndpointId cannot be null"); }
            if (EvpnTunnelEndpointConfig == null) { throw new System.ArgumentNullException("EvpnTunnelEndpointConfig cannot be null"); }
            StringBuilder PatchEvpnTunnelEndpointConfigServiceURL = new StringBuilder("/infra/tier-0s/{tier-0-id}/locale-services/{locale-services-id}/evpn-tunnel-endpoints/{tunnel-endpoint-id}");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Patch
            };
            PatchEvpnTunnelEndpointConfigServiceURL.Replace("{tier-0-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(Tier0Id, System.Globalization.CultureInfo.InvariantCulture)));
            PatchEvpnTunnelEndpointConfigServiceURL.Replace("{locale-services-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(LocaleServicesId, System.Globalization.CultureInfo.InvariantCulture)));
            PatchEvpnTunnelEndpointConfigServiceURL.Replace("{tunnel-endpoint-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(TunnelEndpointId, System.Globalization.CultureInfo.InvariantCulture)));
            request.AddJsonBody(EvpnTunnelEndpointConfig);
            request.Resource = PatchEvpnTunnelEndpointConfigServiceURL.ToString();
            RestResponse response = await restClient.ExecuteTaskAsyncWithPolicy(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Patch operation to " + PatchEvpnTunnelEndpointConfigServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task DeleteEvpnTunnelEndpointConfig(string Tier0Id, string LocaleServicesId, string TunnelEndpointId)
        {
            if (Tier0Id == null) { throw new System.ArgumentNullException("Tier0Id cannot be null"); }
            if (LocaleServicesId == null) { throw new System.ArgumentNullException("LocaleServicesId cannot be null"); }
            if (TunnelEndpointId == null) { throw new System.ArgumentNullException("TunnelEndpointId cannot be null"); }
            StringBuilder DeleteEvpnTunnelEndpointConfigServiceURL = new StringBuilder("/infra/tier-0s/{tier-0-id}/locale-services/{locale-services-id}/evpn-tunnel-endpoints/{tunnel-endpoint-id}");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Delete
            };
            DeleteEvpnTunnelEndpointConfigServiceURL.Replace("{tier-0-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(Tier0Id, System.Globalization.CultureInfo.InvariantCulture)));
            DeleteEvpnTunnelEndpointConfigServiceURL.Replace("{locale-services-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(LocaleServicesId, System.Globalization.CultureInfo.InvariantCulture)));
            DeleteEvpnTunnelEndpointConfigServiceURL.Replace("{tunnel-endpoint-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(TunnelEndpointId, System.Globalization.CultureInfo.InvariantCulture)));
            request.Resource = DeleteEvpnTunnelEndpointConfigServiceURL.ToString();
            RestResponse response = await restClient.ExecuteTaskAsyncWithPolicy(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Delete operation to " + DeleteEvpnTunnelEndpointConfigServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTEvpnTunnelEndpointConfigType> ReadEvpnTunnelEndpointConfig(string Tier0Id, string LocaleServicesId, string TunnelEndpointId)
        {
            if (Tier0Id == null) { throw new System.ArgumentNullException("Tier0Id cannot be null"); }
            if (LocaleServicesId == null) { throw new System.ArgumentNullException("LocaleServicesId cannot be null"); }
            if (TunnelEndpointId == null) { throw new System.ArgumentNullException("TunnelEndpointId cannot be null"); }
            StringBuilder ReadEvpnTunnelEndpointConfigServiceURL = new StringBuilder("/infra/tier-0s/{tier-0-id}/locale-services/{locale-services-id}/evpn-tunnel-endpoints/{tunnel-endpoint-id}");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Get
            };
            ReadEvpnTunnelEndpointConfigServiceURL.Replace("{tier-0-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(Tier0Id, System.Globalization.CultureInfo.InvariantCulture)));
            ReadEvpnTunnelEndpointConfigServiceURL.Replace("{locale-services-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(LocaleServicesId, System.Globalization.CultureInfo.InvariantCulture)));
            ReadEvpnTunnelEndpointConfigServiceURL.Replace("{tunnel-endpoint-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(TunnelEndpointId, System.Globalization.CultureInfo.InvariantCulture)));
            request.Resource = ReadEvpnTunnelEndpointConfigServiceURL.ToString();
            RestResponse<NSXTEvpnTunnelEndpointConfigType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTEvpnTunnelEndpointConfigType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Get operation to " + ReadEvpnTunnelEndpointConfigServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTTier0InterfaceListResultType> ListTier0Interfaces(string Tier0Id, string LocaleServiceId, string? Cursor = null, bool? IncludeMarkForDeleteObjects = null, string? IncludedFields = null, long? PageSize = null, bool? SortAscending = null, string? SortBy = null)
        {
            if (Tier0Id == null) { throw new System.ArgumentNullException("Tier0Id cannot be null"); }
            if (LocaleServiceId == null) { throw new System.ArgumentNullException("LocaleServiceId cannot be null"); }
            StringBuilder ListTier0InterfacesServiceURL = new StringBuilder("/infra/tier-0s/{tier-0-id}/locale-services/{locale-service-id}/interfaces");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Get
            };
            ListTier0InterfacesServiceURL.Replace("{tier-0-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(Tier0Id, System.Globalization.CultureInfo.InvariantCulture)));
            ListTier0InterfacesServiceURL.Replace("{locale-service-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(LocaleServiceId, System.Globalization.CultureInfo.InvariantCulture)));
            if (Cursor != null) { request.AddQueryParameter("cursor", Cursor.ToString()); }
            if (IncludeMarkForDeleteObjects != null) { request.AddQueryParameter("include_mark_for_delete_objects", IncludeMarkForDeleteObjects.ToString()); }
            if (IncludedFields != null) { request.AddQueryParameter("included_fields", IncludedFields.ToString()); }
            if (PageSize != null) { request.AddQueryParameter("page_size", PageSize.ToString()); }
            if (SortAscending != null) { request.AddQueryParameter("sort_ascending", SortAscending.ToString()); }
            if (SortBy != null) { request.AddQueryParameter("sort_by", SortBy.ToString()); }
            request.Resource = ListTier0InterfacesServiceURL.ToString();
            RestResponse<NSXTTier0InterfaceListResultType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTTier0InterfaceListResultType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Get operation to " + ListTier0InterfacesServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTIpv6DadProfileListResultType> ListIpv6DadProfiles(string? Cursor = null, bool? IncludeMarkForDeleteObjects = null, string? IncludedFields = null, long? PageSize = null, bool? SortAscending = null, string? SortBy = null)
        {
            StringBuilder ListIpv6DadProfilesServiceURL = new StringBuilder("/infra/ipv6-dad-profiles");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Get
            };
            if (Cursor != null) { request.AddQueryParameter("cursor", Cursor.ToString()); }
            if (IncludeMarkForDeleteObjects != null) { request.AddQueryParameter("include_mark_for_delete_objects", IncludeMarkForDeleteObjects.ToString()); }
            if (IncludedFields != null) { request.AddQueryParameter("included_fields", IncludedFields.ToString()); }
            if (PageSize != null) { request.AddQueryParameter("page_size", PageSize.ToString()); }
            if (SortAscending != null) { request.AddQueryParameter("sort_ascending", SortAscending.ToString()); }
            if (SortBy != null) { request.AddQueryParameter("sort_by", SortBy.ToString()); }
            request.Resource = ListIpv6DadProfilesServiceURL.ToString();
            RestResponse<NSXTIpv6DadProfileListResultType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTIpv6DadProfileListResultType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Get operation to " + ListIpv6DadProfilesServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTEvpnTunnelEndpointConfigListResultType> ListEvpnTunnelEndpointConfig(string Tier0Id, string LocaleServicesId, string? Cursor = null, bool? IncludeMarkForDeleteObjects = null, string? IncludedFields = null, long? PageSize = null, bool? SortAscending = null, string? SortBy = null)
        {
            if (Tier0Id == null) { throw new System.ArgumentNullException("Tier0Id cannot be null"); }
            if (LocaleServicesId == null) { throw new System.ArgumentNullException("LocaleServicesId cannot be null"); }
            StringBuilder ListEvpnTunnelEndpointConfigServiceURL = new StringBuilder("/infra/tier-0s/{tier-0-id}/locale-services/{locale-services-id}/evpn-tunnel-endpoints");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Get
            };
            ListEvpnTunnelEndpointConfigServiceURL.Replace("{tier-0-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(Tier0Id, System.Globalization.CultureInfo.InvariantCulture)));
            ListEvpnTunnelEndpointConfigServiceURL.Replace("{locale-services-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(LocaleServicesId, System.Globalization.CultureInfo.InvariantCulture)));
            if (Cursor != null) { request.AddQueryParameter("cursor", Cursor.ToString()); }
            if (IncludeMarkForDeleteObjects != null) { request.AddQueryParameter("include_mark_for_delete_objects", IncludeMarkForDeleteObjects.ToString()); }
            if (IncludedFields != null) { request.AddQueryParameter("included_fields", IncludedFields.ToString()); }
            if (PageSize != null) { request.AddQueryParameter("page_size", PageSize.ToString()); }
            if (SortAscending != null) { request.AddQueryParameter("sort_ascending", SortAscending.ToString()); }
            if (SortBy != null) { request.AddQueryParameter("sort_by", SortBy.ToString()); }
            request.Resource = ListEvpnTunnelEndpointConfigServiceURL.ToString();
            RestResponse<NSXTEvpnTunnelEndpointConfigListResultType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTEvpnTunnelEndpointConfigListResultType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Get operation to " + ListEvpnTunnelEndpointConfigServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTLocaleServicesListResultType> GlobalGlobalInfraListTier0LocaleServices(string Tier0Id, string? Cursor = null, bool? IncludeMarkForDeleteObjects = null, string? IncludedFields = null, long? PageSize = null, bool? SortAscending = null, string? SortBy = null)
        {
            if (Tier0Id == null) { throw new System.ArgumentNullException("Tier0Id cannot be null"); }
            StringBuilder GlobalInfraListTier0LocaleServicesServiceURL = new StringBuilder("/global-infra/tier-0s/{tier-0-id}/locale-services");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Get
            };
            GlobalInfraListTier0LocaleServicesServiceURL.Replace("{tier-0-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(Tier0Id, System.Globalization.CultureInfo.InvariantCulture)));
            if (Cursor != null) { request.AddQueryParameter("cursor", Cursor.ToString()); }
            if (IncludeMarkForDeleteObjects != null) { request.AddQueryParameter("include_mark_for_delete_objects", IncludeMarkForDeleteObjects.ToString()); }
            if (IncludedFields != null) { request.AddQueryParameter("included_fields", IncludedFields.ToString()); }
            if (PageSize != null) { request.AddQueryParameter("page_size", PageSize.ToString()); }
            if (SortAscending != null) { request.AddQueryParameter("sort_ascending", SortAscending.ToString()); }
            if (SortBy != null) { request.AddQueryParameter("sort_by", SortBy.ToString()); }
            request.Resource = GlobalInfraListTier0LocaleServicesServiceURL.ToString();
            RestResponse<NSXTLocaleServicesListResultType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTLocaleServicesListResultType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Get operation to " + GlobalInfraListTier0LocaleServicesServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTTier1ListResultType> GlobalGlobalInfraListTier1(string? Cursor = null, bool? IncludeMarkForDeleteObjects = null, string? IncludedFields = null, long? PageSize = null, bool? SortAscending = null, string? SortBy = null)
        {
            StringBuilder GlobalInfraListTier1ServiceURL = new StringBuilder("/global-infra/tier-1s");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Get
            };
            if (Cursor != null) { request.AddQueryParameter("cursor", Cursor.ToString()); }
            if (IncludeMarkForDeleteObjects != null) { request.AddQueryParameter("include_mark_for_delete_objects", IncludeMarkForDeleteObjects.ToString()); }
            if (IncludedFields != null) { request.AddQueryParameter("included_fields", IncludedFields.ToString()); }
            if (PageSize != null) { request.AddQueryParameter("page_size", PageSize.ToString()); }
            if (SortAscending != null) { request.AddQueryParameter("sort_ascending", SortAscending.ToString()); }
            if (SortBy != null) { request.AddQueryParameter("sort_by", SortBy.ToString()); }
            request.Resource = GlobalInfraListTier1ServiceURL.ToString();
            RestResponse<NSXTTier1ListResultType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTTier1ListResultType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Get operation to " + GlobalInfraListTier1ServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTPrefixListResultType> GlobalGlobalInfraListPrefixLists(string Tier0Id, string? Cursor = null, bool? IncludeMarkForDeleteObjects = null, string? IncludedFields = null, long? PageSize = null, bool? SortAscending = null, string? SortBy = null)
        {
            if (Tier0Id == null) { throw new System.ArgumentNullException("Tier0Id cannot be null"); }
            StringBuilder GlobalInfraListPrefixListsServiceURL = new StringBuilder("/global-infra/tier-0s/{tier-0-id}/prefix-lists");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Get
            };
            GlobalInfraListPrefixListsServiceURL.Replace("{tier-0-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(Tier0Id, System.Globalization.CultureInfo.InvariantCulture)));
            if (Cursor != null) { request.AddQueryParameter("cursor", Cursor.ToString()); }
            if (IncludeMarkForDeleteObjects != null) { request.AddQueryParameter("include_mark_for_delete_objects", IncludeMarkForDeleteObjects.ToString()); }
            if (IncludedFields != null) { request.AddQueryParameter("included_fields", IncludedFields.ToString()); }
            if (PageSize != null) { request.AddQueryParameter("page_size", PageSize.ToString()); }
            if (SortAscending != null) { request.AddQueryParameter("sort_ascending", SortAscending.ToString()); }
            if (SortBy != null) { request.AddQueryParameter("sort_by", SortBy.ToString()); }
            request.Resource = GlobalInfraListPrefixListsServiceURL.ToString();
            RestResponse<NSXTPrefixListResultType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTPrefixListResultType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Get operation to " + GlobalInfraListPrefixListsServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTTier0RouteMapListResultType> ListAllRouteMaps(string Tier0Id, string? Cursor = null, bool? IncludeMarkForDeleteObjects = null, string? IncludedFields = null, long? PageSize = null, bool? SortAscending = null, string? SortBy = null)
        {
            if (Tier0Id == null) { throw new System.ArgumentNullException("Tier0Id cannot be null"); }
            StringBuilder ListAllRouteMapsServiceURL = new StringBuilder("/infra/tier-0s/{tier-0-id}/route-maps");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Get
            };
            ListAllRouteMapsServiceURL.Replace("{tier-0-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(Tier0Id, System.Globalization.CultureInfo.InvariantCulture)));
            if (Cursor != null) { request.AddQueryParameter("cursor", Cursor.ToString()); }
            if (IncludeMarkForDeleteObjects != null) { request.AddQueryParameter("include_mark_for_delete_objects", IncludeMarkForDeleteObjects.ToString()); }
            if (IncludedFields != null) { request.AddQueryParameter("included_fields", IncludedFields.ToString()); }
            if (PageSize != null) { request.AddQueryParameter("page_size", PageSize.ToString()); }
            if (SortAscending != null) { request.AddQueryParameter("sort_ascending", SortAscending.ToString()); }
            if (SortBy != null) { request.AddQueryParameter("sort_by", SortBy.ToString()); }
            request.Resource = ListAllRouteMapsServiceURL.ToString();
            RestResponse<NSXTTier0RouteMapListResultType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTTier0RouteMapListResultType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Get operation to " + ListAllRouteMapsServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTServiceInterfaceListResultType> ListServiceInterfaces(string Tier0Id, string LocaleServiceId, string? Cursor = null, bool? IncludeMarkForDeleteObjects = null, string? IncludedFields = null, long? PageSize = null, bool? SortAscending = null, string? SortBy = null)
        {
            if (Tier0Id == null) { throw new System.ArgumentNullException("Tier0Id cannot be null"); }
            if (LocaleServiceId == null) { throw new System.ArgumentNullException("LocaleServiceId cannot be null"); }
            StringBuilder ListServiceInterfacesServiceURL = new StringBuilder("/infra/tier-0s/{tier-0-id}/locale-services/{locale-service-id}/service-interfaces");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Get
            };
            ListServiceInterfacesServiceURL.Replace("{tier-0-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(Tier0Id, System.Globalization.CultureInfo.InvariantCulture)));
            ListServiceInterfacesServiceURL.Replace("{locale-service-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(LocaleServiceId, System.Globalization.CultureInfo.InvariantCulture)));
            if (Cursor != null) { request.AddQueryParameter("cursor", Cursor.ToString()); }
            if (IncludeMarkForDeleteObjects != null) { request.AddQueryParameter("include_mark_for_delete_objects", IncludeMarkForDeleteObjects.ToString()); }
            if (IncludedFields != null) { request.AddQueryParameter("included_fields", IncludedFields.ToString()); }
            if (PageSize != null) { request.AddQueryParameter("page_size", PageSize.ToString()); }
            if (SortAscending != null) { request.AddQueryParameter("sort_ascending", SortAscending.ToString()); }
            if (SortBy != null) { request.AddQueryParameter("sort_by", SortBy.ToString()); }
            request.Resource = ListServiceInterfacesServiceURL.ToString();
            RestResponse<NSXTServiceInterfaceListResultType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTServiceInterfaceListResultType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Get operation to " + ListServiceInterfacesServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTIpv6DadProfileListResultType> GlobalGlobalInfraListIpv6DadProfiles(string? Cursor = null, bool? IncludeMarkForDeleteObjects = null, string? IncludedFields = null, long? PageSize = null, bool? SortAscending = null, string? SortBy = null)
        {
            StringBuilder GlobalInfraListIpv6DadProfilesServiceURL = new StringBuilder("/global-infra/ipv6-dad-profiles");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Get
            };
            if (Cursor != null) { request.AddQueryParameter("cursor", Cursor.ToString()); }
            if (IncludeMarkForDeleteObjects != null) { request.AddQueryParameter("include_mark_for_delete_objects", IncludeMarkForDeleteObjects.ToString()); }
            if (IncludedFields != null) { request.AddQueryParameter("included_fields", IncludedFields.ToString()); }
            if (PageSize != null) { request.AddQueryParameter("page_size", PageSize.ToString()); }
            if (SortAscending != null) { request.AddQueryParameter("sort_ascending", SortAscending.ToString()); }
            if (SortBy != null) { request.AddQueryParameter("sort_by", SortBy.ToString()); }
            request.Resource = GlobalInfraListIpv6DadProfilesServiceURL.ToString();
            RestResponse<NSXTIpv6DadProfileListResultType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTIpv6DadProfileListResultType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Get operation to " + GlobalInfraListIpv6DadProfilesServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTTraceflowObservationListResultType> ListTraceflowObservations(string TraceflowId, string? EnforcementPointPath = null)
        {
            if (TraceflowId == null) { throw new System.ArgumentNullException("TraceflowId cannot be null"); }
            StringBuilder ListTraceflowObservationsServiceURL = new StringBuilder("/infra/traceflows/{traceflow-id}/observations");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Get
            };
            ListTraceflowObservationsServiceURL.Replace("{traceflow-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(TraceflowId, System.Globalization.CultureInfo.InvariantCulture)));
            if (EnforcementPointPath != null) { request.AddQueryParameter("enforcement_point_path", EnforcementPointPath.ToString()); }
            request.Resource = ListTraceflowObservationsServiceURL.ToString();
            RestResponse<NSXTTraceflowObservationListResultType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTTraceflowObservationListResultType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Get operation to " + ListTraceflowObservationsServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTTier0Type> CreateOrReplaceTier0(string Tier0Id, NSXTTier0Type Tier0)
        {
            if (Tier0Id == null) { throw new System.ArgumentNullException("Tier0Id cannot be null"); }
            if (Tier0 == null) { throw new System.ArgumentNullException("Tier0 cannot be null"); }
            StringBuilder CreateOrReplaceTier0ServiceURL = new StringBuilder("/infra/tier-0s/{tier-0-id}");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Put
            };
            CreateOrReplaceTier0ServiceURL.Replace("{tier-0-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(Tier0Id, System.Globalization.CultureInfo.InvariantCulture)));
            request.AddJsonBody(Tier0);
            request.Resource = CreateOrReplaceTier0ServiceURL.ToString();
            RestResponse<NSXTTier0Type> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTTier0Type>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Put operation to " + CreateOrReplaceTier0ServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task DeleteTier0(string Tier0Id)
        {
            if (Tier0Id == null) { throw new System.ArgumentNullException("Tier0Id cannot be null"); }
            StringBuilder DeleteTier0ServiceURL = new StringBuilder("/infra/tier-0s/{tier-0-id}");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Delete
            };
            DeleteTier0ServiceURL.Replace("{tier-0-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(Tier0Id, System.Globalization.CultureInfo.InvariantCulture)));
            request.Resource = DeleteTier0ServiceURL.ToString();
            RestResponse response = await restClient.ExecuteTaskAsyncWithPolicy(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Delete operation to " + DeleteTier0ServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task PatchTier0(string Tier0Id, NSXTTier0Type Tier0)
        {
            if (Tier0Id == null) { throw new System.ArgumentNullException("Tier0Id cannot be null"); }
            if (Tier0 == null) { throw new System.ArgumentNullException("Tier0 cannot be null"); }
            StringBuilder PatchTier0ServiceURL = new StringBuilder("/infra/tier-0s/{tier-0-id}");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Patch
            };
            PatchTier0ServiceURL.Replace("{tier-0-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(Tier0Id, System.Globalization.CultureInfo.InvariantCulture)));
            request.AddJsonBody(Tier0);
            request.Resource = PatchTier0ServiceURL.ToString();
            RestResponse response = await restClient.ExecuteTaskAsyncWithPolicy(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Patch operation to " + PatchTier0ServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTTier0Type> ReadTier0(string Tier0Id)
        {
            if (Tier0Id == null) { throw new System.ArgumentNullException("Tier0Id cannot be null"); }
            StringBuilder ReadTier0ServiceURL = new StringBuilder("/infra/tier-0s/{tier-0-id}");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Get
            };
            ReadTier0ServiceURL.Replace("{tier-0-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(Tier0Id, System.Globalization.CultureInfo.InvariantCulture)));
            request.Resource = ReadTier0ServiceURL.ToString();
            RestResponse<NSXTTier0Type> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTTier0Type>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Get operation to " + ReadTier0ServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTLocaleServicesType> CreateOrReplaceTier0LocaleServices(string Tier0Id, string LocaleServicesId, NSXTLocaleServicesType LocaleServices)
        {
            if (Tier0Id == null) { throw new System.ArgumentNullException("Tier0Id cannot be null"); }
            if (LocaleServicesId == null) { throw new System.ArgumentNullException("LocaleServicesId cannot be null"); }
            if (LocaleServices == null) { throw new System.ArgumentNullException("LocaleServices cannot be null"); }
            StringBuilder CreateOrReplaceTier0LocaleServicesServiceURL = new StringBuilder("/infra/tier-0s/{tier-0-id}/locale-services/{locale-services-id}");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Put
            };
            CreateOrReplaceTier0LocaleServicesServiceURL.Replace("{tier-0-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(Tier0Id, System.Globalization.CultureInfo.InvariantCulture)));
            CreateOrReplaceTier0LocaleServicesServiceURL.Replace("{locale-services-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(LocaleServicesId, System.Globalization.CultureInfo.InvariantCulture)));
            request.AddJsonBody(LocaleServices);
            request.Resource = CreateOrReplaceTier0LocaleServicesServiceURL.ToString();
            RestResponse<NSXTLocaleServicesType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTLocaleServicesType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Put operation to " + CreateOrReplaceTier0LocaleServicesServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTLocaleServicesType> ReadTier0LocaleServices(string Tier0Id, string LocaleServicesId)
        {
            if (Tier0Id == null) { throw new System.ArgumentNullException("Tier0Id cannot be null"); }
            if (LocaleServicesId == null) { throw new System.ArgumentNullException("LocaleServicesId cannot be null"); }
            StringBuilder ReadTier0LocaleServicesServiceURL = new StringBuilder("/infra/tier-0s/{tier-0-id}/locale-services/{locale-services-id}");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Get
            };
            ReadTier0LocaleServicesServiceURL.Replace("{tier-0-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(Tier0Id, System.Globalization.CultureInfo.InvariantCulture)));
            ReadTier0LocaleServicesServiceURL.Replace("{locale-services-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(LocaleServicesId, System.Globalization.CultureInfo.InvariantCulture)));
            request.Resource = ReadTier0LocaleServicesServiceURL.ToString();
            RestResponse<NSXTLocaleServicesType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTLocaleServicesType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Get operation to " + ReadTier0LocaleServicesServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task DeleteTier0LocaleServices(string Tier0Id, string LocaleServicesId)
        {
            if (Tier0Id == null) { throw new System.ArgumentNullException("Tier0Id cannot be null"); }
            if (LocaleServicesId == null) { throw new System.ArgumentNullException("LocaleServicesId cannot be null"); }
            StringBuilder DeleteTier0LocaleServicesServiceURL = new StringBuilder("/infra/tier-0s/{tier-0-id}/locale-services/{locale-services-id}");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Delete
            };
            DeleteTier0LocaleServicesServiceURL.Replace("{tier-0-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(Tier0Id, System.Globalization.CultureInfo.InvariantCulture)));
            DeleteTier0LocaleServicesServiceURL.Replace("{locale-services-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(LocaleServicesId, System.Globalization.CultureInfo.InvariantCulture)));
            request.Resource = DeleteTier0LocaleServicesServiceURL.ToString();
            RestResponse response = await restClient.ExecuteTaskAsyncWithPolicy(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Delete operation to " + DeleteTier0LocaleServicesServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task PatchTier0LocaleServices(string Tier0Id, string LocaleServicesId, NSXTLocaleServicesType LocaleServices)
        {
            if (Tier0Id == null) { throw new System.ArgumentNullException("Tier0Id cannot be null"); }
            if (LocaleServicesId == null) { throw new System.ArgumentNullException("LocaleServicesId cannot be null"); }
            if (LocaleServices == null) { throw new System.ArgumentNullException("LocaleServices cannot be null"); }
            StringBuilder PatchTier0LocaleServicesServiceURL = new StringBuilder("/infra/tier-0s/{tier-0-id}/locale-services/{locale-services-id}");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Patch
            };
            PatchTier0LocaleServicesServiceURL.Replace("{tier-0-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(Tier0Id, System.Globalization.CultureInfo.InvariantCulture)));
            PatchTier0LocaleServicesServiceURL.Replace("{locale-services-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(LocaleServicesId, System.Globalization.CultureInfo.InvariantCulture)));
            request.AddJsonBody(LocaleServices);
            request.Resource = PatchTier0LocaleServicesServiceURL.ToString();
            RestResponse response = await restClient.ExecuteTaskAsyncWithPolicy(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Patch operation to " + PatchTier0LocaleServicesServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTDhcpStaticBindingConfigType> CreateOrReplaceSegmentDhcpStaticBinding(string Tier1Id, string SegmentId, string BindingId, NSXTDhcpStaticBindingConfigType DhcpStaticBindingConfig)
        {
            if (Tier1Id == null) { throw new System.ArgumentNullException("Tier1Id cannot be null"); }
            if (SegmentId == null) { throw new System.ArgumentNullException("SegmentId cannot be null"); }
            if (BindingId == null) { throw new System.ArgumentNullException("BindingId cannot be null"); }
            if (DhcpStaticBindingConfig == null) { throw new System.ArgumentNullException("DhcpStaticBindingConfig cannot be null"); }
            StringBuilder CreateOrReplaceSegmentDhcpStaticBindingServiceURL = new StringBuilder("/infra/tier-1s/{tier-1-id}/segments/{segment-id}/dhcp-static-binding-configs/{binding-id}");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Put
            };
            CreateOrReplaceSegmentDhcpStaticBindingServiceURL.Replace("{tier-1-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(Tier1Id, System.Globalization.CultureInfo.InvariantCulture)));
            CreateOrReplaceSegmentDhcpStaticBindingServiceURL.Replace("{segment-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(SegmentId, System.Globalization.CultureInfo.InvariantCulture)));
            CreateOrReplaceSegmentDhcpStaticBindingServiceURL.Replace("{binding-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(BindingId, System.Globalization.CultureInfo.InvariantCulture)));
            request.AddJsonBody(DhcpStaticBindingConfig);
            request.Resource = CreateOrReplaceSegmentDhcpStaticBindingServiceURL.ToString();
            RestResponse<NSXTDhcpStaticBindingConfigType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTDhcpStaticBindingConfigType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Put operation to " + CreateOrReplaceSegmentDhcpStaticBindingServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task PatchSegmentDhcpStaticBinding(string Tier1Id, string SegmentId, string BindingId, NSXTDhcpStaticBindingConfigType DhcpStaticBindingConfig)
        {
            if (Tier1Id == null) { throw new System.ArgumentNullException("Tier1Id cannot be null"); }
            if (SegmentId == null) { throw new System.ArgumentNullException("SegmentId cannot be null"); }
            if (BindingId == null) { throw new System.ArgumentNullException("BindingId cannot be null"); }
            if (DhcpStaticBindingConfig == null) { throw new System.ArgumentNullException("DhcpStaticBindingConfig cannot be null"); }
            StringBuilder PatchSegmentDhcpStaticBindingServiceURL = new StringBuilder("/infra/tier-1s/{tier-1-id}/segments/{segment-id}/dhcp-static-binding-configs/{binding-id}");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Patch
            };
            PatchSegmentDhcpStaticBindingServiceURL.Replace("{tier-1-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(Tier1Id, System.Globalization.CultureInfo.InvariantCulture)));
            PatchSegmentDhcpStaticBindingServiceURL.Replace("{segment-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(SegmentId, System.Globalization.CultureInfo.InvariantCulture)));
            PatchSegmentDhcpStaticBindingServiceURL.Replace("{binding-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(BindingId, System.Globalization.CultureInfo.InvariantCulture)));
            request.AddJsonBody(DhcpStaticBindingConfig);
            request.Resource = PatchSegmentDhcpStaticBindingServiceURL.ToString();
            RestResponse response = await restClient.ExecuteTaskAsyncWithPolicy(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Patch operation to " + PatchSegmentDhcpStaticBindingServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTDhcpStaticBindingConfigType> ReadSegmentDhcpStaticBinding(string Tier1Id, string SegmentId, string BindingId)
        {
            if (Tier1Id == null) { throw new System.ArgumentNullException("Tier1Id cannot be null"); }
            if (SegmentId == null) { throw new System.ArgumentNullException("SegmentId cannot be null"); }
            if (BindingId == null) { throw new System.ArgumentNullException("BindingId cannot be null"); }
            StringBuilder ReadSegmentDhcpStaticBindingServiceURL = new StringBuilder("/infra/tier-1s/{tier-1-id}/segments/{segment-id}/dhcp-static-binding-configs/{binding-id}");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Get
            };
            ReadSegmentDhcpStaticBindingServiceURL.Replace("{tier-1-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(Tier1Id, System.Globalization.CultureInfo.InvariantCulture)));
            ReadSegmentDhcpStaticBindingServiceURL.Replace("{segment-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(SegmentId, System.Globalization.CultureInfo.InvariantCulture)));
            ReadSegmentDhcpStaticBindingServiceURL.Replace("{binding-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(BindingId, System.Globalization.CultureInfo.InvariantCulture)));
            request.Resource = ReadSegmentDhcpStaticBindingServiceURL.ToString();
            RestResponse<NSXTDhcpStaticBindingConfigType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTDhcpStaticBindingConfigType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Get operation to " + ReadSegmentDhcpStaticBindingServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task DeleteSegmentDhcpStaticBinding(string Tier1Id, string SegmentId, string BindingId)
        {
            if (Tier1Id == null) { throw new System.ArgumentNullException("Tier1Id cannot be null"); }
            if (SegmentId == null) { throw new System.ArgumentNullException("SegmentId cannot be null"); }
            if (BindingId == null) { throw new System.ArgumentNullException("BindingId cannot be null"); }
            StringBuilder DeleteSegmentDhcpStaticBindingServiceURL = new StringBuilder("/infra/tier-1s/{tier-1-id}/segments/{segment-id}/dhcp-static-binding-configs/{binding-id}");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Delete
            };
            DeleteSegmentDhcpStaticBindingServiceURL.Replace("{tier-1-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(Tier1Id, System.Globalization.CultureInfo.InvariantCulture)));
            DeleteSegmentDhcpStaticBindingServiceURL.Replace("{segment-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(SegmentId, System.Globalization.CultureInfo.InvariantCulture)));
            DeleteSegmentDhcpStaticBindingServiceURL.Replace("{binding-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(BindingId, System.Globalization.CultureInfo.InvariantCulture)));
            request.Resource = DeleteSegmentDhcpStaticBindingServiceURL.ToString();
            RestResponse response = await restClient.ExecuteTaskAsyncWithPolicy(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Delete operation to " + DeleteSegmentDhcpStaticBindingServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTTraceflowConfigListResultType> ListTraceflowConfig(string? Cursor = null, bool? IncludeMarkForDeleteObjects = null, string? IncludedFields = null, long? PageSize = null, bool? SortAscending = null, string? SortBy = null)
        {
            StringBuilder ListTraceflowConfigServiceURL = new StringBuilder("/infra/traceflows");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Get
            };
            if (Cursor != null) { request.AddQueryParameter("cursor", Cursor.ToString()); }
            if (IncludeMarkForDeleteObjects != null) { request.AddQueryParameter("include_mark_for_delete_objects", IncludeMarkForDeleteObjects.ToString()); }
            if (IncludedFields != null) { request.AddQueryParameter("included_fields", IncludedFields.ToString()); }
            if (PageSize != null) { request.AddQueryParameter("page_size", PageSize.ToString()); }
            if (SortAscending != null) { request.AddQueryParameter("sort_ascending", SortAscending.ToString()); }
            if (SortBy != null) { request.AddQueryParameter("sort_by", SortBy.ToString()); }
            request.Resource = ListTraceflowConfigServiceURL.ToString();
            RestResponse<NSXTTraceflowConfigListResultType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTTraceflowConfigListResultType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Get operation to " + ListTraceflowConfigServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTServiceInterfaceType> GlobalGlobalInfraReadServiceInterface(string Tier0Id, string LocaleServiceId, string InterfaceId)
        {
            if (Tier0Id == null) { throw new System.ArgumentNullException("Tier0Id cannot be null"); }
            if (LocaleServiceId == null) { throw new System.ArgumentNullException("LocaleServiceId cannot be null"); }
            if (InterfaceId == null) { throw new System.ArgumentNullException("InterfaceId cannot be null"); }
            StringBuilder GlobalInfraReadServiceInterfaceServiceURL = new StringBuilder("/global-infra/tier-0s/{tier-0-id}/locale-services/{locale-service-id}/service-interfaces/{interface-id}");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Get
            };
            GlobalInfraReadServiceInterfaceServiceURL.Replace("{tier-0-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(Tier0Id, System.Globalization.CultureInfo.InvariantCulture)));
            GlobalInfraReadServiceInterfaceServiceURL.Replace("{locale-service-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(LocaleServiceId, System.Globalization.CultureInfo.InvariantCulture)));
            GlobalInfraReadServiceInterfaceServiceURL.Replace("{interface-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(InterfaceId, System.Globalization.CultureInfo.InvariantCulture)));
            request.Resource = GlobalInfraReadServiceInterfaceServiceURL.ToString();
            RestResponse<NSXTServiceInterfaceType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTServiceInterfaceType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Get operation to " + GlobalInfraReadServiceInterfaceServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTStaticRouteBfdPeerListResultType> GlobalGlobalInfraListStaticRouteBfdPeer(string Tier0Id, string? Cursor = null, bool? IncludeMarkForDeleteObjects = null, string? IncludedFields = null, long? PageSize = null, bool? SortAscending = null, string? SortBy = null)
        {
            if (Tier0Id == null) { throw new System.ArgumentNullException("Tier0Id cannot be null"); }
            StringBuilder GlobalInfraListStaticRouteBfdPeerServiceURL = new StringBuilder("/global-infra/tier-0s/{tier-0-id}/static-routes/bfd-peers");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Get
            };
            GlobalInfraListStaticRouteBfdPeerServiceURL.Replace("{tier-0-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(Tier0Id, System.Globalization.CultureInfo.InvariantCulture)));
            if (Cursor != null) { request.AddQueryParameter("cursor", Cursor.ToString()); }
            if (IncludeMarkForDeleteObjects != null) { request.AddQueryParameter("include_mark_for_delete_objects", IncludeMarkForDeleteObjects.ToString()); }
            if (IncludedFields != null) { request.AddQueryParameter("included_fields", IncludedFields.ToString()); }
            if (PageSize != null) { request.AddQueryParameter("page_size", PageSize.ToString()); }
            if (SortAscending != null) { request.AddQueryParameter("sort_ascending", SortAscending.ToString()); }
            if (SortBy != null) { request.AddQueryParameter("sort_by", SortBy.ToString()); }
            request.Resource = GlobalInfraListStaticRouteBfdPeerServiceURL.ToString();
            RestResponse<NSXTStaticRouteBfdPeerListResultType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTStaticRouteBfdPeerListResultType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Get operation to " + GlobalInfraListStaticRouteBfdPeerServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTDhcpStaticBindingConfigListResultType> GlobalGlobalInfraListInfraSegmentDhcpStaticBinding(string SegmentId, string? Cursor = null, bool? IncludeMarkForDeleteObjects = null, string? IncludedFields = null, long? PageSize = null, bool? SortAscending = null, string? SortBy = null)
        {
            if (SegmentId == null) { throw new System.ArgumentNullException("SegmentId cannot be null"); }
            StringBuilder GlobalInfraListInfraSegmentDhcpStaticBindingServiceURL = new StringBuilder("/global-infra/segments/{segment-id}/dhcp-static-binding-configs");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Get
            };
            GlobalInfraListInfraSegmentDhcpStaticBindingServiceURL.Replace("{segment-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(SegmentId, System.Globalization.CultureInfo.InvariantCulture)));
            if (Cursor != null) { request.AddQueryParameter("cursor", Cursor.ToString()); }
            if (IncludeMarkForDeleteObjects != null) { request.AddQueryParameter("include_mark_for_delete_objects", IncludeMarkForDeleteObjects.ToString()); }
            if (IncludedFields != null) { request.AddQueryParameter("included_fields", IncludedFields.ToString()); }
            if (PageSize != null) { request.AddQueryParameter("page_size", PageSize.ToString()); }
            if (SortAscending != null) { request.AddQueryParameter("sort_ascending", SortAscending.ToString()); }
            if (SortBy != null) { request.AddQueryParameter("sort_by", SortBy.ToString()); }
            request.Resource = GlobalInfraListInfraSegmentDhcpStaticBindingServiceURL.ToString();
            RestResponse<NSXTDhcpStaticBindingConfigListResultType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTDhcpStaticBindingConfigListResultType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Get operation to " + GlobalInfraListInfraSegmentDhcpStaticBindingServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTTier0ListResultType> GlobalGlobalInfraListTier0s(string? Cursor = null, bool? IncludeMarkForDeleteObjects = null, string? IncludedFields = null, long? PageSize = null, bool? SortAscending = null, string? SortBy = null)
        {
            StringBuilder GlobalInfraListTier0sServiceURL = new StringBuilder("/global-infra/tier-0s");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Get
            };
            if (Cursor != null) { request.AddQueryParameter("cursor", Cursor.ToString()); }
            if (IncludeMarkForDeleteObjects != null) { request.AddQueryParameter("include_mark_for_delete_objects", IncludeMarkForDeleteObjects.ToString()); }
            if (IncludedFields != null) { request.AddQueryParameter("included_fields", IncludedFields.ToString()); }
            if (PageSize != null) { request.AddQueryParameter("page_size", PageSize.ToString()); }
            if (SortAscending != null) { request.AddQueryParameter("sort_ascending", SortAscending.ToString()); }
            if (SortBy != null) { request.AddQueryParameter("sort_by", SortBy.ToString()); }
            request.Resource = GlobalInfraListTier0sServiceURL.ToString();
            RestResponse<NSXTTier0ListResultType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTTier0ListResultType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Get operation to " + GlobalInfraListTier0sServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTTraceflowConfigType> UpdateTraceflowConfig(string TraceflowId, NSXTTraceflowConfigType TraceflowConfig)
        {
            if (TraceflowId == null) { throw new System.ArgumentNullException("TraceflowId cannot be null"); }
            if (TraceflowConfig == null) { throw new System.ArgumentNullException("TraceflowConfig cannot be null"); }
            StringBuilder UpdateTraceflowConfigServiceURL = new StringBuilder("/infra/traceflows/{traceflow-id}");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Put
            };
            UpdateTraceflowConfigServiceURL.Replace("{traceflow-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(TraceflowId, System.Globalization.CultureInfo.InvariantCulture)));
            request.AddJsonBody(TraceflowConfig);
            request.Resource = UpdateTraceflowConfigServiceURL.ToString();
            RestResponse<NSXTTraceflowConfigType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTTraceflowConfigType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Put operation to " + UpdateTraceflowConfigServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTTraceflowConfigType> RestartTraceflow(string TraceflowId, string? Action = null)
        {
            if (TraceflowId == null) { throw new System.ArgumentNullException("TraceflowId cannot be null"); }
            StringBuilder RestartTraceflowServiceURL = new StringBuilder("/infra/traceflows/{traceflow-id}");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Post
            };
            RestartTraceflowServiceURL.Replace("{traceflow-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(TraceflowId, System.Globalization.CultureInfo.InvariantCulture)));
            if (Action != null) { request.AddQueryParameter("action", Action.ToString()); }
            request.Resource = RestartTraceflowServiceURL.ToString();
            RestResponse<NSXTTraceflowConfigType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTTraceflowConfigType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Post operation to " + RestartTraceflowServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task PatchTraceflowConfig(string TraceflowId, NSXTTraceflowConfigType TraceflowConfig)
        {
            if (TraceflowId == null) { throw new System.ArgumentNullException("TraceflowId cannot be null"); }
            if (TraceflowConfig == null) { throw new System.ArgumentNullException("TraceflowConfig cannot be null"); }
            StringBuilder PatchTraceflowConfigServiceURL = new StringBuilder("/infra/traceflows/{traceflow-id}");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Patch
            };
            PatchTraceflowConfigServiceURL.Replace("{traceflow-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(TraceflowId, System.Globalization.CultureInfo.InvariantCulture)));
            request.AddJsonBody(TraceflowConfig);
            request.Resource = PatchTraceflowConfigServiceURL.ToString();
            RestResponse response = await restClient.ExecuteTaskAsyncWithPolicy(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Patch operation to " + PatchTraceflowConfigServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTTraceflowConfigType> ReadTraceflowConfig(string TraceflowId)
        {
            if (TraceflowId == null) { throw new System.ArgumentNullException("TraceflowId cannot be null"); }
            StringBuilder ReadTraceflowConfigServiceURL = new StringBuilder("/infra/traceflows/{traceflow-id}");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Get
            };
            ReadTraceflowConfigServiceURL.Replace("{traceflow-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(TraceflowId, System.Globalization.CultureInfo.InvariantCulture)));
            request.Resource = ReadTraceflowConfigServiceURL.ToString();
            RestResponse<NSXTTraceflowConfigType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTTraceflowConfigType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Get operation to " + ReadTraceflowConfigServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task DeleteTraceflowConfig(string TraceflowId)
        {
            if (TraceflowId == null) { throw new System.ArgumentNullException("TraceflowId cannot be null"); }
            StringBuilder DeleteTraceflowConfigServiceURL = new StringBuilder("/infra/traceflows/{traceflow-id}");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Delete
            };
            DeleteTraceflowConfigServiceURL.Replace("{traceflow-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(TraceflowId, System.Globalization.CultureInfo.InvariantCulture)));
            request.Resource = DeleteTraceflowConfigServiceURL.ToString();
            RestResponse response = await restClient.ExecuteTaskAsyncWithPolicy(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Delete operation to " + DeleteTraceflowConfigServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTVniPoolConfigListResultType> ListVniPoolConfig(string? Cursor = null, bool? IncludeMarkForDeleteObjects = null, string? IncludedFields = null, long? PageSize = null, bool? SortAscending = null, string? SortBy = null)
        {
            StringBuilder ListVniPoolConfigServiceURL = new StringBuilder("/infra/vni-pools");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Get
            };
            if (Cursor != null) { request.AddQueryParameter("cursor", Cursor.ToString()); }
            if (IncludeMarkForDeleteObjects != null) { request.AddQueryParameter("include_mark_for_delete_objects", IncludeMarkForDeleteObjects.ToString()); }
            if (IncludedFields != null) { request.AddQueryParameter("included_fields", IncludedFields.ToString()); }
            if (PageSize != null) { request.AddQueryParameter("page_size", PageSize.ToString()); }
            if (SortAscending != null) { request.AddQueryParameter("sort_ascending", SortAscending.ToString()); }
            if (SortBy != null) { request.AddQueryParameter("sort_by", SortBy.ToString()); }
            request.Resource = ListVniPoolConfigServiceURL.ToString();
            RestResponse<NSXTVniPoolConfigListResultType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTVniPoolConfigListResultType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Get operation to " + ListVniPoolConfigServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTStaticRoutesListResultType> ListTier0StaticRoutes(string Tier0Id, string? Cursor = null, bool? IncludeMarkForDeleteObjects = null, string? IncludedFields = null, long? PageSize = null, bool? SortAscending = null, string? SortBy = null)
        {
            if (Tier0Id == null) { throw new System.ArgumentNullException("Tier0Id cannot be null"); }
            StringBuilder ListTier0StaticRoutesServiceURL = new StringBuilder("/infra/tier-0s/{tier-0-id}/static-routes");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Get
            };
            ListTier0StaticRoutesServiceURL.Replace("{tier-0-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(Tier0Id, System.Globalization.CultureInfo.InvariantCulture)));
            if (Cursor != null) { request.AddQueryParameter("cursor", Cursor.ToString()); }
            if (IncludeMarkForDeleteObjects != null) { request.AddQueryParameter("include_mark_for_delete_objects", IncludeMarkForDeleteObjects.ToString()); }
            if (IncludedFields != null) { request.AddQueryParameter("included_fields", IncludedFields.ToString()); }
            if (PageSize != null) { request.AddQueryParameter("page_size", PageSize.ToString()); }
            if (SortAscending != null) { request.AddQueryParameter("sort_ascending", SortAscending.ToString()); }
            if (SortBy != null) { request.AddQueryParameter("sort_by", SortBy.ToString()); }
            request.Resource = ListTier0StaticRoutesServiceURL.ToString();
            RestResponse<NSXTStaticRoutesListResultType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTStaticRoutesListResultType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Get operation to " + ListTier0StaticRoutesServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTTier0InterfaceListResultType> GlobalGlobalInfraListTier0Interfaces(string Tier0Id, string LocaleServiceId, string? Cursor = null, bool? IncludeMarkForDeleteObjects = null, string? IncludedFields = null, long? PageSize = null, bool? SortAscending = null, string? SortBy = null)
        {
            if (Tier0Id == null) { throw new System.ArgumentNullException("Tier0Id cannot be null"); }
            if (LocaleServiceId == null) { throw new System.ArgumentNullException("LocaleServiceId cannot be null"); }
            StringBuilder GlobalInfraListTier0InterfacesServiceURL = new StringBuilder("/global-infra/tier-0s/{tier-0-id}/locale-services/{locale-service-id}/interfaces");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Get
            };
            GlobalInfraListTier0InterfacesServiceURL.Replace("{tier-0-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(Tier0Id, System.Globalization.CultureInfo.InvariantCulture)));
            GlobalInfraListTier0InterfacesServiceURL.Replace("{locale-service-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(LocaleServiceId, System.Globalization.CultureInfo.InvariantCulture)));
            if (Cursor != null) { request.AddQueryParameter("cursor", Cursor.ToString()); }
            if (IncludeMarkForDeleteObjects != null) { request.AddQueryParameter("include_mark_for_delete_objects", IncludeMarkForDeleteObjects.ToString()); }
            if (IncludedFields != null) { request.AddQueryParameter("included_fields", IncludedFields.ToString()); }
            if (PageSize != null) { request.AddQueryParameter("page_size", PageSize.ToString()); }
            if (SortAscending != null) { request.AddQueryParameter("sort_ascending", SortAscending.ToString()); }
            if (SortBy != null) { request.AddQueryParameter("sort_by", SortBy.ToString()); }
            request.Resource = GlobalInfraListTier0InterfacesServiceURL.ToString();
            RestResponse<NSXTTier0InterfaceListResultType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTTier0InterfaceListResultType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Get operation to " + GlobalInfraListTier0InterfacesServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTL2BridgeEndpointProfileType> UpdateL2BridgeProfile(string SiteId, string EnforcementPointId, string ProfileId, NSXTL2BridgeEndpointProfileType L2BridgeEndpointProfile)
        {
            if (SiteId == null) { throw new System.ArgumentNullException("SiteId cannot be null"); }
            if (EnforcementPointId == null) { throw new System.ArgumentNullException("EnforcementPointId cannot be null"); }
            if (ProfileId == null) { throw new System.ArgumentNullException("ProfileId cannot be null"); }
            if (L2BridgeEndpointProfile == null) { throw new System.ArgumentNullException("L2BridgeEndpointProfile cannot be null"); }
            StringBuilder UpdateL2BridgeProfileServiceURL = new StringBuilder("/infra/sites/{site-id}/enforcement-points/{enforcement-point-id}/edge-bridge-profiles/{profile-id}");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Put
            };
            UpdateL2BridgeProfileServiceURL.Replace("{site-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(SiteId, System.Globalization.CultureInfo.InvariantCulture)));
            UpdateL2BridgeProfileServiceURL.Replace("{enforcement-point-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(EnforcementPointId, System.Globalization.CultureInfo.InvariantCulture)));
            UpdateL2BridgeProfileServiceURL.Replace("{profile-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(ProfileId, System.Globalization.CultureInfo.InvariantCulture)));
            request.AddJsonBody(L2BridgeEndpointProfile);
            request.Resource = UpdateL2BridgeProfileServiceURL.ToString();
            RestResponse<NSXTL2BridgeEndpointProfileType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTL2BridgeEndpointProfileType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Put operation to " + UpdateL2BridgeProfileServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTL2BridgeEndpointProfileType> ReadL2BridgeProfile(string SiteId, string EnforcementPointId, string ProfileId)
        {
            if (SiteId == null) { throw new System.ArgumentNullException("SiteId cannot be null"); }
            if (EnforcementPointId == null) { throw new System.ArgumentNullException("EnforcementPointId cannot be null"); }
            if (ProfileId == null) { throw new System.ArgumentNullException("ProfileId cannot be null"); }
            StringBuilder ReadL2BridgeProfileServiceURL = new StringBuilder("/infra/sites/{site-id}/enforcement-points/{enforcement-point-id}/edge-bridge-profiles/{profile-id}");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Get
            };
            ReadL2BridgeProfileServiceURL.Replace("{site-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(SiteId, System.Globalization.CultureInfo.InvariantCulture)));
            ReadL2BridgeProfileServiceURL.Replace("{enforcement-point-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(EnforcementPointId, System.Globalization.CultureInfo.InvariantCulture)));
            ReadL2BridgeProfileServiceURL.Replace("{profile-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(ProfileId, System.Globalization.CultureInfo.InvariantCulture)));
            request.Resource = ReadL2BridgeProfileServiceURL.ToString();
            RestResponse<NSXTL2BridgeEndpointProfileType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTL2BridgeEndpointProfileType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Get operation to " + ReadL2BridgeProfileServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task DeleteL2BridgeProfile(string SiteId, string EnforcementPointId, string ProfileId)
        {
            if (SiteId == null) { throw new System.ArgumentNullException("SiteId cannot be null"); }
            if (EnforcementPointId == null) { throw new System.ArgumentNullException("EnforcementPointId cannot be null"); }
            if (ProfileId == null) { throw new System.ArgumentNullException("ProfileId cannot be null"); }
            StringBuilder DeleteL2BridgeProfileServiceURL = new StringBuilder("/infra/sites/{site-id}/enforcement-points/{enforcement-point-id}/edge-bridge-profiles/{profile-id}");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Delete
            };
            DeleteL2BridgeProfileServiceURL.Replace("{site-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(SiteId, System.Globalization.CultureInfo.InvariantCulture)));
            DeleteL2BridgeProfileServiceURL.Replace("{enforcement-point-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(EnforcementPointId, System.Globalization.CultureInfo.InvariantCulture)));
            DeleteL2BridgeProfileServiceURL.Replace("{profile-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(ProfileId, System.Globalization.CultureInfo.InvariantCulture)));
            request.Resource = DeleteL2BridgeProfileServiceURL.ToString();
            RestResponse response = await restClient.ExecuteTaskAsyncWithPolicy(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Delete operation to " + DeleteL2BridgeProfileServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task PatchL2BridgeProfile(string SiteId, string EnforcementPointId, string ProfileId, NSXTL2BridgeEndpointProfileType L2BridgeEndpointProfile)
        {
            if (SiteId == null) { throw new System.ArgumentNullException("SiteId cannot be null"); }
            if (EnforcementPointId == null) { throw new System.ArgumentNullException("EnforcementPointId cannot be null"); }
            if (ProfileId == null) { throw new System.ArgumentNullException("ProfileId cannot be null"); }
            if (L2BridgeEndpointProfile == null) { throw new System.ArgumentNullException("L2BridgeEndpointProfile cannot be null"); }
            StringBuilder PatchL2BridgeProfileServiceURL = new StringBuilder("/infra/sites/{site-id}/enforcement-points/{enforcement-point-id}/edge-bridge-profiles/{profile-id}");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Patch
            };
            PatchL2BridgeProfileServiceURL.Replace("{site-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(SiteId, System.Globalization.CultureInfo.InvariantCulture)));
            PatchL2BridgeProfileServiceURL.Replace("{enforcement-point-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(EnforcementPointId, System.Globalization.CultureInfo.InvariantCulture)));
            PatchL2BridgeProfileServiceURL.Replace("{profile-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(ProfileId, System.Globalization.CultureInfo.InvariantCulture)));
            request.AddJsonBody(L2BridgeEndpointProfile);
            request.Resource = PatchL2BridgeProfileServiceURL.ToString();
            RestResponse response = await restClient.ExecuteTaskAsyncWithPolicy(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Patch operation to " + PatchL2BridgeProfileServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTSegmentPortType> CreateOrReplaceInfraSegmentPort(string SegmentId, string PortId, NSXTSegmentPortType SegmentPort)
        {
            if (SegmentId == null) { throw new System.ArgumentNullException("SegmentId cannot be null"); }
            if (PortId == null) { throw new System.ArgumentNullException("PortId cannot be null"); }
            if (SegmentPort == null) { throw new System.ArgumentNullException("SegmentPort cannot be null"); }
            StringBuilder CreateOrReplaceInfraSegmentPortServiceURL = new StringBuilder("/infra/segments/{segment-id}/ports/{port-id}");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Put
            };
            CreateOrReplaceInfraSegmentPortServiceURL.Replace("{segment-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(SegmentId, System.Globalization.CultureInfo.InvariantCulture)));
            CreateOrReplaceInfraSegmentPortServiceURL.Replace("{port-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(PortId, System.Globalization.CultureInfo.InvariantCulture)));
            request.AddJsonBody(SegmentPort);
            request.Resource = CreateOrReplaceInfraSegmentPortServiceURL.ToString();
            RestResponse<NSXTSegmentPortType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTSegmentPortType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Put operation to " + CreateOrReplaceInfraSegmentPortServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task PatchInfraSegmentPort(string SegmentId, string PortId, NSXTSegmentPortType SegmentPort)
        {
            if (SegmentId == null) { throw new System.ArgumentNullException("SegmentId cannot be null"); }
            if (PortId == null) { throw new System.ArgumentNullException("PortId cannot be null"); }
            if (SegmentPort == null) { throw new System.ArgumentNullException("SegmentPort cannot be null"); }
            StringBuilder PatchInfraSegmentPortServiceURL = new StringBuilder("/infra/segments/{segment-id}/ports/{port-id}");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Patch
            };
            PatchInfraSegmentPortServiceURL.Replace("{segment-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(SegmentId, System.Globalization.CultureInfo.InvariantCulture)));
            PatchInfraSegmentPortServiceURL.Replace("{port-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(PortId, System.Globalization.CultureInfo.InvariantCulture)));
            request.AddJsonBody(SegmentPort);
            request.Resource = PatchInfraSegmentPortServiceURL.ToString();
            RestResponse response = await restClient.ExecuteTaskAsyncWithPolicy(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Patch operation to " + PatchInfraSegmentPortServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task DeleteInfraSegmentPort(string SegmentId, string PortId)
        {
            if (SegmentId == null) { throw new System.ArgumentNullException("SegmentId cannot be null"); }
            if (PortId == null) { throw new System.ArgumentNullException("PortId cannot be null"); }
            StringBuilder DeleteInfraSegmentPortServiceURL = new StringBuilder("/infra/segments/{segment-id}/ports/{port-id}");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Delete
            };
            DeleteInfraSegmentPortServiceURL.Replace("{segment-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(SegmentId, System.Globalization.CultureInfo.InvariantCulture)));
            DeleteInfraSegmentPortServiceURL.Replace("{port-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(PortId, System.Globalization.CultureInfo.InvariantCulture)));
            request.Resource = DeleteInfraSegmentPortServiceURL.ToString();
            RestResponse response = await restClient.ExecuteTaskAsyncWithPolicy(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Delete operation to " + DeleteInfraSegmentPortServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTSegmentPortType> GetInfraSegmentPort(string SegmentId, string PortId)
        {
            if (SegmentId == null) { throw new System.ArgumentNullException("SegmentId cannot be null"); }
            if (PortId == null) { throw new System.ArgumentNullException("PortId cannot be null"); }
            StringBuilder GetInfraSegmentPortServiceURL = new StringBuilder("/infra/segments/{segment-id}/ports/{port-id}");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Get
            };
            GetInfraSegmentPortServiceURL.Replace("{segment-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(SegmentId, System.Globalization.CultureInfo.InvariantCulture)));
            GetInfraSegmentPortServiceURL.Replace("{port-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(PortId, System.Globalization.CultureInfo.InvariantCulture)));
            request.Resource = GetInfraSegmentPortServiceURL.ToString();
            RestResponse<NSXTSegmentPortType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTSegmentPortType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Get operation to " + GetInfraSegmentPortServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTSegmentListResultType> GlobalGlobalInfraListSegments(string Tier1Id, string? Cursor = null, bool? IncludeMarkForDeleteObjects = null, string? IncludedFields = null, long? PageSize = null, string? SegmentType = null, bool? SortAscending = null, string? SortBy = null)
        {
            if (Tier1Id == null) { throw new System.ArgumentNullException("Tier1Id cannot be null"); }
            StringBuilder GlobalInfraListSegmentsServiceURL = new StringBuilder("/global-infra/tier-1s/{tier-1-id}/segments");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Get
            };
            GlobalInfraListSegmentsServiceURL.Replace("{tier-1-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(Tier1Id, System.Globalization.CultureInfo.InvariantCulture)));
            if (Cursor != null) { request.AddQueryParameter("cursor", Cursor.ToString()); }
            if (IncludeMarkForDeleteObjects != null) { request.AddQueryParameter("include_mark_for_delete_objects", IncludeMarkForDeleteObjects.ToString()); }
            if (IncludedFields != null) { request.AddQueryParameter("included_fields", IncludedFields.ToString()); }
            if (PageSize != null) { request.AddQueryParameter("page_size", PageSize.ToString()); }
            if (SegmentType != null) { request.AddQueryParameter("segment_type", SegmentType.ToString()); }
            if (SortAscending != null) { request.AddQueryParameter("sort_ascending", SortAscending.ToString()); }
            if (SortBy != null) { request.AddQueryParameter("sort_by", SortBy.ToString()); }
            request.Resource = GlobalInfraListSegmentsServiceURL.ToString();
            RestResponse<NSXTSegmentListResultType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTSegmentListResultType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Get operation to " + GlobalInfraListSegmentsServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTLocaleServicesType> GlobalGlobalInfraReadTier1LocaleServices(string Tier1Id, string LocaleServicesId)
        {
            if (Tier1Id == null) { throw new System.ArgumentNullException("Tier1Id cannot be null"); }
            if (LocaleServicesId == null) { throw new System.ArgumentNullException("LocaleServicesId cannot be null"); }
            StringBuilder GlobalInfraReadTier1LocaleServicesServiceURL = new StringBuilder("/global-infra/tier-1s/{tier-1-id}/locale-services/{locale-services-id}");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Get
            };
            GlobalInfraReadTier1LocaleServicesServiceURL.Replace("{tier-1-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(Tier1Id, System.Globalization.CultureInfo.InvariantCulture)));
            GlobalInfraReadTier1LocaleServicesServiceURL.Replace("{locale-services-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(LocaleServicesId, System.Globalization.CultureInfo.InvariantCulture)));
            request.Resource = GlobalInfraReadTier1LocaleServicesServiceURL.ToString();
            RestResponse<NSXTLocaleServicesType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTLocaleServicesType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Get operation to " + GlobalInfraReadTier1LocaleServicesServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTLiveTraceConfigListResultType> ListLiveTraceConfig(string? Cursor = null, bool? IncludeMarkForDeleteObjects = null, string? IncludedFields = null, long? PageSize = null, bool? SortAscending = null, string? SortBy = null)
        {
            StringBuilder ListLiveTraceConfigServiceURL = new StringBuilder("/infra/livetraces");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Get
            };
            if (Cursor != null) { request.AddQueryParameter("cursor", Cursor.ToString()); }
            if (IncludeMarkForDeleteObjects != null) { request.AddQueryParameter("include_mark_for_delete_objects", IncludeMarkForDeleteObjects.ToString()); }
            if (IncludedFields != null) { request.AddQueryParameter("included_fields", IncludedFields.ToString()); }
            if (PageSize != null) { request.AddQueryParameter("page_size", PageSize.ToString()); }
            if (SortAscending != null) { request.AddQueryParameter("sort_ascending", SortAscending.ToString()); }
            if (SortBy != null) { request.AddQueryParameter("sort_by", SortBy.ToString()); }
            request.Resource = ListLiveTraceConfigServiceURL.ToString();
            RestResponse<NSXTLiveTraceConfigListResultType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTLiveTraceConfigListResultType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Get operation to " + ListLiveTraceConfigServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTServiceInterfaceListResultType> GlobalGlobalInfraListTier1ServiceInterfaces(string Tier1Id, string LocaleServiceId, string? Cursor = null, bool? IncludeMarkForDeleteObjects = null, string? IncludedFields = null, long? PageSize = null, bool? SortAscending = null, string? SortBy = null)
        {
            if (Tier1Id == null) { throw new System.ArgumentNullException("Tier1Id cannot be null"); }
            if (LocaleServiceId == null) { throw new System.ArgumentNullException("LocaleServiceId cannot be null"); }
            StringBuilder GlobalInfraListTier1ServiceInterfacesServiceURL = new StringBuilder("/global-infra/tier-1s/{tier-1-id}/locale-services/{locale-service-id}/service-interfaces");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Get
            };
            GlobalInfraListTier1ServiceInterfacesServiceURL.Replace("{tier-1-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(Tier1Id, System.Globalization.CultureInfo.InvariantCulture)));
            GlobalInfraListTier1ServiceInterfacesServiceURL.Replace("{locale-service-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(LocaleServiceId, System.Globalization.CultureInfo.InvariantCulture)));
            if (Cursor != null) { request.AddQueryParameter("cursor", Cursor.ToString()); }
            if (IncludeMarkForDeleteObjects != null) { request.AddQueryParameter("include_mark_for_delete_objects", IncludeMarkForDeleteObjects.ToString()); }
            if (IncludedFields != null) { request.AddQueryParameter("included_fields", IncludedFields.ToString()); }
            if (PageSize != null) { request.AddQueryParameter("page_size", PageSize.ToString()); }
            if (SortAscending != null) { request.AddQueryParameter("sort_ascending", SortAscending.ToString()); }
            if (SortBy != null) { request.AddQueryParameter("sort_by", SortBy.ToString()); }
            request.Resource = GlobalInfraListTier1ServiceInterfacesServiceURL.ToString();
            RestResponse<NSXTServiceInterfaceListResultType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTServiceInterfaceListResultType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Get operation to " + GlobalInfraListTier1ServiceInterfacesServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTIpv6NdraProfileType> GlobalGlobalInfraCreateOrReplaceIpv6NdraProfile(string NdraProfileId, NSXTIpv6NdraProfileType Ipv6NdraProfile, bool? Override = null)
        {
            if (NdraProfileId == null) { throw new System.ArgumentNullException("NdraProfileId cannot be null"); }
            if (Ipv6NdraProfile == null) { throw new System.ArgumentNullException("Ipv6NdraProfile cannot be null"); }
            StringBuilder GlobalInfraCreateOrReplaceIpv6NdraProfileServiceURL = new StringBuilder("/global-infra/ipv6-ndra-profiles/{ndra-profile-id}");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Put
            };
            GlobalInfraCreateOrReplaceIpv6NdraProfileServiceURL.Replace("{ndra-profile-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(NdraProfileId, System.Globalization.CultureInfo.InvariantCulture)));
            request.AddJsonBody(Ipv6NdraProfile);
            if (Override != null) { request.AddQueryParameter("override", Override.ToString()); }
            request.Resource = GlobalInfraCreateOrReplaceIpv6NdraProfileServiceURL.ToString();
            RestResponse<NSXTIpv6NdraProfileType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTIpv6NdraProfileType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Put operation to " + GlobalInfraCreateOrReplaceIpv6NdraProfileServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task GlobalGlobalInfraDeleteIpv6NdraProfile(string NdraProfileId, bool? Override = null)
        {
            if (NdraProfileId == null) { throw new System.ArgumentNullException("NdraProfileId cannot be null"); }
            StringBuilder GlobalInfraDeleteIpv6NdraProfileServiceURL = new StringBuilder("/global-infra/ipv6-ndra-profiles/{ndra-profile-id}");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Delete
            };
            GlobalInfraDeleteIpv6NdraProfileServiceURL.Replace("{ndra-profile-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(NdraProfileId, System.Globalization.CultureInfo.InvariantCulture)));
            if (Override != null) { request.AddQueryParameter("override", Override.ToString()); }
            request.Resource = GlobalInfraDeleteIpv6NdraProfileServiceURL.ToString();
            RestResponse response = await restClient.ExecuteTaskAsyncWithPolicy(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Delete operation to " + GlobalInfraDeleteIpv6NdraProfileServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task GlobalGlobalInfraPatchIpv6NdraProfile(string NdraProfileId, NSXTIpv6NdraProfileType Ipv6NdraProfile, bool? Override = null)
        {
            if (NdraProfileId == null) { throw new System.ArgumentNullException("NdraProfileId cannot be null"); }
            if (Ipv6NdraProfile == null) { throw new System.ArgumentNullException("Ipv6NdraProfile cannot be null"); }
            StringBuilder GlobalInfraPatchIpv6NdraProfileServiceURL = new StringBuilder("/global-infra/ipv6-ndra-profiles/{ndra-profile-id}");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Patch
            };
            GlobalInfraPatchIpv6NdraProfileServiceURL.Replace("{ndra-profile-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(NdraProfileId, System.Globalization.CultureInfo.InvariantCulture)));
            request.AddJsonBody(Ipv6NdraProfile);
            if (Override != null) { request.AddQueryParameter("override", Override.ToString()); }
            request.Resource = GlobalInfraPatchIpv6NdraProfileServiceURL.ToString();
            RestResponse response = await restClient.ExecuteTaskAsyncWithPolicy(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Patch operation to " + GlobalInfraPatchIpv6NdraProfileServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTIpv6NdraProfileType> GlobalGlobalInfraReadIpv6NdraProfile(string NdraProfileId)
        {
            if (NdraProfileId == null) { throw new System.ArgumentNullException("NdraProfileId cannot be null"); }
            StringBuilder GlobalInfraReadIpv6NdraProfileServiceURL = new StringBuilder("/global-infra/ipv6-ndra-profiles/{ndra-profile-id}");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Get
            };
            GlobalInfraReadIpv6NdraProfileServiceURL.Replace("{ndra-profile-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(NdraProfileId, System.Globalization.CultureInfo.InvariantCulture)));
            request.Resource = GlobalInfraReadIpv6NdraProfileServiceURL.ToString();
            RestResponse<NSXTIpv6NdraProfileType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTIpv6NdraProfileType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Get operation to " + GlobalInfraReadIpv6NdraProfileServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTSegmentType> GlobalGlobalInfraReadInfraSegment(string SegmentId)
        {
            if (SegmentId == null) { throw new System.ArgumentNullException("SegmentId cannot be null"); }
            StringBuilder GlobalInfraReadInfraSegmentServiceURL = new StringBuilder("/global-infra/segments/{segment-id}");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Get
            };
            GlobalInfraReadInfraSegmentServiceURL.Replace("{segment-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(SegmentId, System.Globalization.CultureInfo.InvariantCulture)));
            request.Resource = GlobalInfraReadInfraSegmentServiceURL.ToString();
            RestResponse<NSXTSegmentType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTSegmentType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Get operation to " + GlobalInfraReadInfraSegmentServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTTier0RouteMapType> GlobalGlobalInfraGetRouteMap(string Tier0Id, string RouteMapId)
        {
            if (Tier0Id == null) { throw new System.ArgumentNullException("Tier0Id cannot be null"); }
            if (RouteMapId == null) { throw new System.ArgumentNullException("RouteMapId cannot be null"); }
            StringBuilder GlobalInfraGetRouteMapServiceURL = new StringBuilder("/global-infra/tier-0s/{tier-0-id}/route-maps/{route-map-id}");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Get
            };
            GlobalInfraGetRouteMapServiceURL.Replace("{tier-0-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(Tier0Id, System.Globalization.CultureInfo.InvariantCulture)));
            GlobalInfraGetRouteMapServiceURL.Replace("{route-map-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(RouteMapId, System.Globalization.CultureInfo.InvariantCulture)));
            request.Resource = GlobalInfraGetRouteMapServiceURL.ToString();
            RestResponse<NSXTTier0RouteMapType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTTier0RouteMapType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Get operation to " + GlobalInfraGetRouteMapServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTSegmentListResultType> ListAllInfraSegments(string? Cursor = null, bool? IncludeMarkForDeleteObjects = null, string? IncludedFields = null, long? PageSize = null, string? SegmentType = null, bool? SortAscending = null, string? SortBy = null)
        {
            StringBuilder ListAllInfraSegmentsServiceURL = new StringBuilder("/infra/segments");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Get
            };
            if (Cursor != null) { request.AddQueryParameter("cursor", Cursor.ToString()); }
            if (IncludeMarkForDeleteObjects != null) { request.AddQueryParameter("include_mark_for_delete_objects", IncludeMarkForDeleteObjects.ToString()); }
            if (IncludedFields != null) { request.AddQueryParameter("included_fields", IncludedFields.ToString()); }
            if (PageSize != null) { request.AddQueryParameter("page_size", PageSize.ToString()); }
            if (SegmentType != null) { request.AddQueryParameter("segment_type", SegmentType.ToString()); }
            if (SortAscending != null) { request.AddQueryParameter("sort_ascending", SortAscending.ToString()); }
            if (SortBy != null) { request.AddQueryParameter("sort_by", SortBy.ToString()); }
            request.Resource = ListAllInfraSegmentsServiceURL.ToString();
            RestResponse<NSXTSegmentListResultType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTSegmentListResultType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Get operation to " + ListAllInfraSegmentsServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTLiveTraceStatusType> ReadLiveTraceStatus(string LivetraceId, string? EnforcementPointPath = null)
        {
            if (LivetraceId == null) { throw new System.ArgumentNullException("LivetraceId cannot be null"); }
            StringBuilder ReadLiveTraceStatusServiceURL = new StringBuilder("/infra/livetraces/{livetrace-id}/status");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Get
            };
            ReadLiveTraceStatusServiceURL.Replace("{livetrace-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(LivetraceId, System.Globalization.CultureInfo.InvariantCulture)));
            if (EnforcementPointPath != null) { request.AddQueryParameter("enforcement_point_path", EnforcementPointPath.ToString()); }
            request.Resource = ReadLiveTraceStatusServiceURL.ToString();
            RestResponse<NSXTLiveTraceStatusType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTLiveTraceStatusType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Get operation to " + ReadLiveTraceStatusServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTTier0RouteMapListResultType> GlobalGlobalInfraListAllRouteMaps(string Tier0Id, string? Cursor = null, bool? IncludeMarkForDeleteObjects = null, string? IncludedFields = null, long? PageSize = null, bool? SortAscending = null, string? SortBy = null)
        {
            if (Tier0Id == null) { throw new System.ArgumentNullException("Tier0Id cannot be null"); }
            StringBuilder GlobalInfraListAllRouteMapsServiceURL = new StringBuilder("/global-infra/tier-0s/{tier-0-id}/route-maps");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Get
            };
            GlobalInfraListAllRouteMapsServiceURL.Replace("{tier-0-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(Tier0Id, System.Globalization.CultureInfo.InvariantCulture)));
            if (Cursor != null) { request.AddQueryParameter("cursor", Cursor.ToString()); }
            if (IncludeMarkForDeleteObjects != null) { request.AddQueryParameter("include_mark_for_delete_objects", IncludeMarkForDeleteObjects.ToString()); }
            if (IncludedFields != null) { request.AddQueryParameter("included_fields", IncludedFields.ToString()); }
            if (PageSize != null) { request.AddQueryParameter("page_size", PageSize.ToString()); }
            if (SortAscending != null) { request.AddQueryParameter("sort_ascending", SortAscending.ToString()); }
            if (SortBy != null) { request.AddQueryParameter("sort_by", SortBy.ToString()); }
            request.Resource = GlobalInfraListAllRouteMapsServiceURL.ToString();
            RestResponse<NSXTTier0RouteMapListResultType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTTier0RouteMapListResultType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Get operation to " + GlobalInfraListAllRouteMapsServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTServiceSegmentType> CreateServiceSegment(string ServiceSegmentId, NSXTServiceSegmentType ServiceSegment)
        {
            if (ServiceSegmentId == null) { throw new System.ArgumentNullException("ServiceSegmentId cannot be null"); }
            if (ServiceSegment == null) { throw new System.ArgumentNullException("ServiceSegment cannot be null"); }
            StringBuilder CreateServiceSegmentServiceURL = new StringBuilder("/infra/segments/service-segments/{service-segment-id}");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Put
            };
            CreateServiceSegmentServiceURL.Replace("{service-segment-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(ServiceSegmentId, System.Globalization.CultureInfo.InvariantCulture)));
            request.AddJsonBody(ServiceSegment);
            request.Resource = CreateServiceSegmentServiceURL.ToString();
            RestResponse<NSXTServiceSegmentType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTServiceSegmentType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Put operation to " + CreateServiceSegmentServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTServiceSegmentType> ReadServiceSegment(string ServiceSegmentId)
        {
            if (ServiceSegmentId == null) { throw new System.ArgumentNullException("ServiceSegmentId cannot be null"); }
            StringBuilder ReadServiceSegmentServiceURL = new StringBuilder("/infra/segments/service-segments/{service-segment-id}");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Get
            };
            ReadServiceSegmentServiceURL.Replace("{service-segment-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(ServiceSegmentId, System.Globalization.CultureInfo.InvariantCulture)));
            request.Resource = ReadServiceSegmentServiceURL.ToString();
            RestResponse<NSXTServiceSegmentType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTServiceSegmentType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Get operation to " + ReadServiceSegmentServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task DeleteServiceSegment(string ServiceSegmentId)
        {
            if (ServiceSegmentId == null) { throw new System.ArgumentNullException("ServiceSegmentId cannot be null"); }
            StringBuilder DeleteServiceSegmentServiceURL = new StringBuilder("/infra/segments/service-segments/{service-segment-id}");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Delete
            };
            DeleteServiceSegmentServiceURL.Replace("{service-segment-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(ServiceSegmentId, System.Globalization.CultureInfo.InvariantCulture)));
            request.Resource = DeleteServiceSegmentServiceURL.ToString();
            RestResponse response = await restClient.ExecuteTaskAsyncWithPolicy(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Delete operation to " + DeleteServiceSegmentServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task PatchServiceSegment(string ServiceSegmentId, NSXTServiceSegmentType ServiceSegment)
        {
            if (ServiceSegmentId == null) { throw new System.ArgumentNullException("ServiceSegmentId cannot be null"); }
            if (ServiceSegment == null) { throw new System.ArgumentNullException("ServiceSegment cannot be null"); }
            StringBuilder PatchServiceSegmentServiceURL = new StringBuilder("/infra/segments/service-segments/{service-segment-id}");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Patch
            };
            PatchServiceSegmentServiceURL.Replace("{service-segment-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(ServiceSegmentId, System.Globalization.CultureInfo.InvariantCulture)));
            request.AddJsonBody(ServiceSegment);
            request.Resource = PatchServiceSegmentServiceURL.ToString();
            RestResponse response = await restClient.ExecuteTaskAsyncWithPolicy(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Patch operation to " + PatchServiceSegmentServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTDhcpStaticBindingConfigListResultType> ListSegmentDhcpStaticBinding(string Tier1Id, string SegmentId, string? Cursor = null, bool? IncludeMarkForDeleteObjects = null, string? IncludedFields = null, long? PageSize = null, bool? SortAscending = null, string? SortBy = null)
        {
            if (Tier1Id == null) { throw new System.ArgumentNullException("Tier1Id cannot be null"); }
            if (SegmentId == null) { throw new System.ArgumentNullException("SegmentId cannot be null"); }
            StringBuilder ListSegmentDhcpStaticBindingServiceURL = new StringBuilder("/infra/tier-1s/{tier-1-id}/segments/{segment-id}/dhcp-static-binding-configs");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Get
            };
            ListSegmentDhcpStaticBindingServiceURL.Replace("{tier-1-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(Tier1Id, System.Globalization.CultureInfo.InvariantCulture)));
            ListSegmentDhcpStaticBindingServiceURL.Replace("{segment-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(SegmentId, System.Globalization.CultureInfo.InvariantCulture)));
            if (Cursor != null) { request.AddQueryParameter("cursor", Cursor.ToString()); }
            if (IncludeMarkForDeleteObjects != null) { request.AddQueryParameter("include_mark_for_delete_objects", IncludeMarkForDeleteObjects.ToString()); }
            if (IncludedFields != null) { request.AddQueryParameter("included_fields", IncludedFields.ToString()); }
            if (PageSize != null) { request.AddQueryParameter("page_size", PageSize.ToString()); }
            if (SortAscending != null) { request.AddQueryParameter("sort_ascending", SortAscending.ToString()); }
            if (SortBy != null) { request.AddQueryParameter("sort_by", SortBy.ToString()); }
            request.Resource = ListSegmentDhcpStaticBindingServiceURL.ToString();
            RestResponse<NSXTDhcpStaticBindingConfigListResultType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTDhcpStaticBindingConfigListResultType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Get operation to " + ListSegmentDhcpStaticBindingServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTL2BridgeEndpointProfileListResultType> ListL2BridgeProfiles(string SiteId, string EnforcementPointId, string? Cursor = null, string? IncludedFields = null, long? PageSize = null, bool? SortAscending = null, string? SortBy = null)
        {
            if (SiteId == null) { throw new System.ArgumentNullException("SiteId cannot be null"); }
            if (EnforcementPointId == null) { throw new System.ArgumentNullException("EnforcementPointId cannot be null"); }
            StringBuilder ListL2BridgeProfilesServiceURL = new StringBuilder("/infra/sites/{site-id}/enforcement-points/{enforcement-point-id}/edge-bridge-profiles");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Get
            };
            ListL2BridgeProfilesServiceURL.Replace("{site-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(SiteId, System.Globalization.CultureInfo.InvariantCulture)));
            ListL2BridgeProfilesServiceURL.Replace("{enforcement-point-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(EnforcementPointId, System.Globalization.CultureInfo.InvariantCulture)));
            if (Cursor != null) { request.AddQueryParameter("cursor", Cursor.ToString()); }
            if (IncludedFields != null) { request.AddQueryParameter("included_fields", IncludedFields.ToString()); }
            if (PageSize != null) { request.AddQueryParameter("page_size", PageSize.ToString()); }
            if (SortAscending != null) { request.AddQueryParameter("sort_ascending", SortAscending.ToString()); }
            if (SortBy != null) { request.AddQueryParameter("sort_by", SortBy.ToString()); }
            request.Resource = ListL2BridgeProfilesServiceURL.ToString();
            RestResponse<NSXTL2BridgeEndpointProfileListResultType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTL2BridgeEndpointProfileListResultType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Get operation to " + ListL2BridgeProfilesServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTDhcpRelayConfigType> GlobalGlobalInfraReadDhcpRelayConfig(string DhcpRelayConfigId)
        {
            if (DhcpRelayConfigId == null) { throw new System.ArgumentNullException("DhcpRelayConfigId cannot be null"); }
            StringBuilder GlobalInfraReadDhcpRelayConfigServiceURL = new StringBuilder("/global-infra/dhcp-relay-configs/{dhcp-relay-config-id}");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Get
            };
            GlobalInfraReadDhcpRelayConfigServiceURL.Replace("{dhcp-relay-config-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(DhcpRelayConfigId, System.Globalization.CultureInfo.InvariantCulture)));
            request.Resource = GlobalInfraReadDhcpRelayConfigServiceURL.ToString();
            RestResponse<NSXTDhcpRelayConfigType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTDhcpRelayConfigType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Get operation to " + GlobalInfraReadDhcpRelayConfigServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task DeleteDhcpLeaseUnderTier1(string Tier1Id, string SegmentId, NSXTDhcpDeleteLeasesType DhcpDeleteLeases, string? EnforcementPointPath = null)
        {
            if (Tier1Id == null) { throw new System.ArgumentNullException("Tier1Id cannot be null"); }
            if (SegmentId == null) { throw new System.ArgumentNullException("SegmentId cannot be null"); }
            if (DhcpDeleteLeases == null) { throw new System.ArgumentNullException("DhcpDeleteLeases cannot be null"); }
            StringBuilder DeleteDhcpLeaseUnderTier1ServiceURL = new StringBuilder("/infra/tier-1s/{tier1-id}/segments/{segment-id}?action=delete_dhcp_leases");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Post
            };
            DeleteDhcpLeaseUnderTier1ServiceURL.Replace("{tier1-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(Tier1Id, System.Globalization.CultureInfo.InvariantCulture)));
            DeleteDhcpLeaseUnderTier1ServiceURL.Replace("{segment-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(SegmentId, System.Globalization.CultureInfo.InvariantCulture)));
            request.AddJsonBody(DhcpDeleteLeases);
            if (EnforcementPointPath != null) { request.AddQueryParameter("enforcement_point_path", EnforcementPointPath.ToString()); }
            request.Resource = DeleteDhcpLeaseUnderTier1ServiceURL.ToString();
            RestResponse response = await restClient.ExecuteTaskAsyncWithPolicy(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Post operation to " + DeleteDhcpLeaseUnderTier1ServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTSegmentPortType> GlobalGlobalInfraCreateOrReplaceInfraSegmentPort(string SegmentId, string PortId, NSXTSegmentPortType SegmentPort)
        {
            if (SegmentId == null) { throw new System.ArgumentNullException("SegmentId cannot be null"); }
            if (PortId == null) { throw new System.ArgumentNullException("PortId cannot be null"); }
            if (SegmentPort == null) { throw new System.ArgumentNullException("SegmentPort cannot be null"); }
            StringBuilder GlobalInfraCreateOrReplaceInfraSegmentPortServiceURL = new StringBuilder("/global-infra/segments/{segment-id}/ports/{port-id}");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Put
            };
            GlobalInfraCreateOrReplaceInfraSegmentPortServiceURL.Replace("{segment-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(SegmentId, System.Globalization.CultureInfo.InvariantCulture)));
            GlobalInfraCreateOrReplaceInfraSegmentPortServiceURL.Replace("{port-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(PortId, System.Globalization.CultureInfo.InvariantCulture)));
            request.AddJsonBody(SegmentPort);
            request.Resource = GlobalInfraCreateOrReplaceInfraSegmentPortServiceURL.ToString();
            RestResponse<NSXTSegmentPortType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTSegmentPortType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Put operation to " + GlobalInfraCreateOrReplaceInfraSegmentPortServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task GlobalGlobalInfraPatchInfraSegmentPort(string SegmentId, string PortId, NSXTSegmentPortType SegmentPort)
        {
            if (SegmentId == null) { throw new System.ArgumentNullException("SegmentId cannot be null"); }
            if (PortId == null) { throw new System.ArgumentNullException("PortId cannot be null"); }
            if (SegmentPort == null) { throw new System.ArgumentNullException("SegmentPort cannot be null"); }
            StringBuilder GlobalInfraPatchInfraSegmentPortServiceURL = new StringBuilder("/global-infra/segments/{segment-id}/ports/{port-id}");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Patch
            };
            GlobalInfraPatchInfraSegmentPortServiceURL.Replace("{segment-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(SegmentId, System.Globalization.CultureInfo.InvariantCulture)));
            GlobalInfraPatchInfraSegmentPortServiceURL.Replace("{port-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(PortId, System.Globalization.CultureInfo.InvariantCulture)));
            request.AddJsonBody(SegmentPort);
            request.Resource = GlobalInfraPatchInfraSegmentPortServiceURL.ToString();
            RestResponse response = await restClient.ExecuteTaskAsyncWithPolicy(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Patch operation to " + GlobalInfraPatchInfraSegmentPortServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task GlobalGlobalInfraDeleteInfraSegmentPort(string SegmentId, string PortId)
        {
            if (SegmentId == null) { throw new System.ArgumentNullException("SegmentId cannot be null"); }
            if (PortId == null) { throw new System.ArgumentNullException("PortId cannot be null"); }
            StringBuilder GlobalInfraDeleteInfraSegmentPortServiceURL = new StringBuilder("/global-infra/segments/{segment-id}/ports/{port-id}");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Delete
            };
            GlobalInfraDeleteInfraSegmentPortServiceURL.Replace("{segment-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(SegmentId, System.Globalization.CultureInfo.InvariantCulture)));
            GlobalInfraDeleteInfraSegmentPortServiceURL.Replace("{port-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(PortId, System.Globalization.CultureInfo.InvariantCulture)));
            request.Resource = GlobalInfraDeleteInfraSegmentPortServiceURL.ToString();
            RestResponse response = await restClient.ExecuteTaskAsyncWithPolicy(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Delete operation to " + GlobalInfraDeleteInfraSegmentPortServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTSegmentPortType> GlobalGlobalInfraGetInfraSegmentPort(string SegmentId, string PortId)
        {
            if (SegmentId == null) { throw new System.ArgumentNullException("SegmentId cannot be null"); }
            if (PortId == null) { throw new System.ArgumentNullException("PortId cannot be null"); }
            StringBuilder GlobalInfraGetInfraSegmentPortServiceURL = new StringBuilder("/global-infra/segments/{segment-id}/ports/{port-id}");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Get
            };
            GlobalInfraGetInfraSegmentPortServiceURL.Replace("{segment-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(SegmentId, System.Globalization.CultureInfo.InvariantCulture)));
            GlobalInfraGetInfraSegmentPortServiceURL.Replace("{port-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(PortId, System.Globalization.CultureInfo.InvariantCulture)));
            request.Resource = GlobalInfraGetInfraSegmentPortServiceURL.ToString();
            RestResponse<NSXTSegmentPortType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTSegmentPortType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Get operation to " + GlobalInfraGetInfraSegmentPortServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTDhcpServerConfigListResultType> GlobalGlobalInfraListDhcpServerConfig(string? Cursor = null, bool? IncludeMarkForDeleteObjects = null, string? IncludedFields = null, long? PageSize = null, bool? SortAscending = null, string? SortBy = null)
        {
            StringBuilder GlobalInfraListDhcpServerConfigServiceURL = new StringBuilder("/global-infra/dhcp-server-configs");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Get
            };
            if (Cursor != null) { request.AddQueryParameter("cursor", Cursor.ToString()); }
            if (IncludeMarkForDeleteObjects != null) { request.AddQueryParameter("include_mark_for_delete_objects", IncludeMarkForDeleteObjects.ToString()); }
            if (IncludedFields != null) { request.AddQueryParameter("included_fields", IncludedFields.ToString()); }
            if (PageSize != null) { request.AddQueryParameter("page_size", PageSize.ToString()); }
            if (SortAscending != null) { request.AddQueryParameter("sort_ascending", SortAscending.ToString()); }
            if (SortBy != null) { request.AddQueryParameter("sort_by", SortBy.ToString()); }
            request.Resource = GlobalInfraListDhcpServerConfigServiceURL.ToString();
            RestResponse<NSXTDhcpServerConfigListResultType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTDhcpServerConfigListResultType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Get operation to " + GlobalInfraListDhcpServerConfigServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTBgpRoutingConfigType> GlobalGlobalInfraCreateOrReplaceBgpRoutingConfig(string Tier0Id, string LocaleServiceId, NSXTBgpRoutingConfigType BgpRoutingConfig, bool? Override = null)
        {
            if (Tier0Id == null) { throw new System.ArgumentNullException("Tier0Id cannot be null"); }
            if (LocaleServiceId == null) { throw new System.ArgumentNullException("LocaleServiceId cannot be null"); }
            if (BgpRoutingConfig == null) { throw new System.ArgumentNullException("BgpRoutingConfig cannot be null"); }
            StringBuilder GlobalInfraCreateOrReplaceBgpRoutingConfigServiceURL = new StringBuilder("/global-infra/tier-0s/{tier-0-id}/locale-services/{locale-service-id}/bgp");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Put
            };
            GlobalInfraCreateOrReplaceBgpRoutingConfigServiceURL.Replace("{tier-0-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(Tier0Id, System.Globalization.CultureInfo.InvariantCulture)));
            GlobalInfraCreateOrReplaceBgpRoutingConfigServiceURL.Replace("{locale-service-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(LocaleServiceId, System.Globalization.CultureInfo.InvariantCulture)));
            request.AddJsonBody(BgpRoutingConfig);
            if (Override != null) { request.AddQueryParameter("override", Override.ToString()); }
            request.Resource = GlobalInfraCreateOrReplaceBgpRoutingConfigServiceURL.ToString();
            RestResponse<NSXTBgpRoutingConfigType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTBgpRoutingConfigType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Put operation to " + GlobalInfraCreateOrReplaceBgpRoutingConfigServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTBgpRoutingConfigType> GlobalGlobalInfraReadBgpRoutingConfig(string Tier0Id, string LocaleServiceId)
        {
            if (Tier0Id == null) { throw new System.ArgumentNullException("Tier0Id cannot be null"); }
            if (LocaleServiceId == null) { throw new System.ArgumentNullException("LocaleServiceId cannot be null"); }
            StringBuilder GlobalInfraReadBgpRoutingConfigServiceURL = new StringBuilder("/global-infra/tier-0s/{tier-0-id}/locale-services/{locale-service-id}/bgp");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Get
            };
            GlobalInfraReadBgpRoutingConfigServiceURL.Replace("{tier-0-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(Tier0Id, System.Globalization.CultureInfo.InvariantCulture)));
            GlobalInfraReadBgpRoutingConfigServiceURL.Replace("{locale-service-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(LocaleServiceId, System.Globalization.CultureInfo.InvariantCulture)));
            request.Resource = GlobalInfraReadBgpRoutingConfigServiceURL.ToString();
            RestResponse<NSXTBgpRoutingConfigType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTBgpRoutingConfigType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Get operation to " + GlobalInfraReadBgpRoutingConfigServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task GlobalGlobalInfraPatchBgpRoutingConfig(string Tier0Id, string LocaleServiceId, NSXTBgpRoutingConfigType BgpRoutingConfig, bool? Override = null)
        {
            if (Tier0Id == null) { throw new System.ArgumentNullException("Tier0Id cannot be null"); }
            if (LocaleServiceId == null) { throw new System.ArgumentNullException("LocaleServiceId cannot be null"); }
            if (BgpRoutingConfig == null) { throw new System.ArgumentNullException("BgpRoutingConfig cannot be null"); }
            StringBuilder GlobalInfraPatchBgpRoutingConfigServiceURL = new StringBuilder("/global-infra/tier-0s/{tier-0-id}/locale-services/{locale-service-id}/bgp");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Patch
            };
            GlobalInfraPatchBgpRoutingConfigServiceURL.Replace("{tier-0-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(Tier0Id, System.Globalization.CultureInfo.InvariantCulture)));
            GlobalInfraPatchBgpRoutingConfigServiceURL.Replace("{locale-service-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(LocaleServiceId, System.Globalization.CultureInfo.InvariantCulture)));
            request.AddJsonBody(BgpRoutingConfig);
            if (Override != null) { request.AddQueryParameter("override", Override.ToString()); }
            request.Resource = GlobalInfraPatchBgpRoutingConfigServiceURL.ToString();
            RestResponse response = await restClient.ExecuteTaskAsyncWithPolicy(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Patch operation to " + GlobalInfraPatchBgpRoutingConfigServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task GlobalGlobalInfraDeleteOverriddenBgpRoutingConfig(string Tier0Id, string LocaleServiceId, bool? Override = null)
        {
            if (Tier0Id == null) { throw new System.ArgumentNullException("Tier0Id cannot be null"); }
            if (LocaleServiceId == null) { throw new System.ArgumentNullException("LocaleServiceId cannot be null"); }
            StringBuilder GlobalInfraDeleteOverriddenBgpRoutingConfigServiceURL = new StringBuilder("/global-infra/tier-0s/{tier-0-id}/locale-services/{locale-service-id}/bgp");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Delete
            };
            GlobalInfraDeleteOverriddenBgpRoutingConfigServiceURL.Replace("{tier-0-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(Tier0Id, System.Globalization.CultureInfo.InvariantCulture)));
            GlobalInfraDeleteOverriddenBgpRoutingConfigServiceURL.Replace("{locale-service-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(LocaleServiceId, System.Globalization.CultureInfo.InvariantCulture)));
            if (Override != null) { request.AddQueryParameter("override", Override.ToString()); }
            request.Resource = GlobalInfraDeleteOverriddenBgpRoutingConfigServiceURL.ToString();
            RestResponse response = await restClient.ExecuteTaskAsyncWithPolicy(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Delete operation to " + GlobalInfraDeleteOverriddenBgpRoutingConfigServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task ForceDeleteSegment(string Tier1Id, string SegmentId)
        {
            if (Tier1Id == null) { throw new System.ArgumentNullException("Tier1Id cannot be null"); }
            if (SegmentId == null) { throw new System.ArgumentNullException("SegmentId cannot be null"); }
            StringBuilder ForceDeleteSegmentServiceURL = new StringBuilder("/infra/tier-1s/{tier-1-id}/segments/{segment-id}?force=true");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Delete
            };
            ForceDeleteSegmentServiceURL.Replace("{tier-1-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(Tier1Id, System.Globalization.CultureInfo.InvariantCulture)));
            ForceDeleteSegmentServiceURL.Replace("{segment-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(SegmentId, System.Globalization.CultureInfo.InvariantCulture)));
            request.Resource = ForceDeleteSegmentServiceURL.ToString();
            RestResponse response = await restClient.ExecuteTaskAsyncWithPolicy(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Delete operation to " + ForceDeleteSegmentServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTBgpNeighborConfigType> GlobalGlobalInfraCreateOrReplaceBgpNeighborConfig(string Tier0Id, string LocaleServiceId, string NeighborId, NSXTBgpNeighborConfigType BgpNeighborConfig, bool? Override = null)
        {
            if (Tier0Id == null) { throw new System.ArgumentNullException("Tier0Id cannot be null"); }
            if (LocaleServiceId == null) { throw new System.ArgumentNullException("LocaleServiceId cannot be null"); }
            if (NeighborId == null) { throw new System.ArgumentNullException("NeighborId cannot be null"); }
            if (BgpNeighborConfig == null) { throw new System.ArgumentNullException("BgpNeighborConfig cannot be null"); }
            StringBuilder GlobalInfraCreateOrReplaceBgpNeighborConfigServiceURL = new StringBuilder("/global-infra/tier-0s/{tier-0-id}/locale-services/{locale-service-id}/bgp/neighbors/{neighbor-id}");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Put
            };
            GlobalInfraCreateOrReplaceBgpNeighborConfigServiceURL.Replace("{tier-0-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(Tier0Id, System.Globalization.CultureInfo.InvariantCulture)));
            GlobalInfraCreateOrReplaceBgpNeighborConfigServiceURL.Replace("{locale-service-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(LocaleServiceId, System.Globalization.CultureInfo.InvariantCulture)));
            GlobalInfraCreateOrReplaceBgpNeighborConfigServiceURL.Replace("{neighbor-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(NeighborId, System.Globalization.CultureInfo.InvariantCulture)));
            request.AddJsonBody(BgpNeighborConfig);
            if (Override != null) { request.AddQueryParameter("override", Override.ToString()); }
            request.Resource = GlobalInfraCreateOrReplaceBgpNeighborConfigServiceURL.ToString();
            RestResponse<NSXTBgpNeighborConfigType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTBgpNeighborConfigType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Put operation to " + GlobalInfraCreateOrReplaceBgpNeighborConfigServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTBgpNeighborConfigType> GlobalGlobalInfraReadBgpNeighborConfig(string Tier0Id, string LocaleServiceId, string NeighborId)
        {
            if (Tier0Id == null) { throw new System.ArgumentNullException("Tier0Id cannot be null"); }
            if (LocaleServiceId == null) { throw new System.ArgumentNullException("LocaleServiceId cannot be null"); }
            if (NeighborId == null) { throw new System.ArgumentNullException("NeighborId cannot be null"); }
            StringBuilder GlobalInfraReadBgpNeighborConfigServiceURL = new StringBuilder("/global-infra/tier-0s/{tier-0-id}/locale-services/{locale-service-id}/bgp/neighbors/{neighbor-id}");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Get
            };
            GlobalInfraReadBgpNeighborConfigServiceURL.Replace("{tier-0-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(Tier0Id, System.Globalization.CultureInfo.InvariantCulture)));
            GlobalInfraReadBgpNeighborConfigServiceURL.Replace("{locale-service-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(LocaleServiceId, System.Globalization.CultureInfo.InvariantCulture)));
            GlobalInfraReadBgpNeighborConfigServiceURL.Replace("{neighbor-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(NeighborId, System.Globalization.CultureInfo.InvariantCulture)));
            request.Resource = GlobalInfraReadBgpNeighborConfigServiceURL.ToString();
            RestResponse<NSXTBgpNeighborConfigType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTBgpNeighborConfigType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Get operation to " + GlobalInfraReadBgpNeighborConfigServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task GlobalGlobalInfraPatchBgpNeighborConfig(string Tier0Id, string LocaleServiceId, string NeighborId, NSXTBgpNeighborConfigType BgpNeighborConfig, bool? Override = null)
        {
            if (Tier0Id == null) { throw new System.ArgumentNullException("Tier0Id cannot be null"); }
            if (LocaleServiceId == null) { throw new System.ArgumentNullException("LocaleServiceId cannot be null"); }
            if (NeighborId == null) { throw new System.ArgumentNullException("NeighborId cannot be null"); }
            if (BgpNeighborConfig == null) { throw new System.ArgumentNullException("BgpNeighborConfig cannot be null"); }
            StringBuilder GlobalInfraPatchBgpNeighborConfigServiceURL = new StringBuilder("/global-infra/tier-0s/{tier-0-id}/locale-services/{locale-service-id}/bgp/neighbors/{neighbor-id}");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Patch
            };
            GlobalInfraPatchBgpNeighborConfigServiceURL.Replace("{tier-0-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(Tier0Id, System.Globalization.CultureInfo.InvariantCulture)));
            GlobalInfraPatchBgpNeighborConfigServiceURL.Replace("{locale-service-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(LocaleServiceId, System.Globalization.CultureInfo.InvariantCulture)));
            GlobalInfraPatchBgpNeighborConfigServiceURL.Replace("{neighbor-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(NeighborId, System.Globalization.CultureInfo.InvariantCulture)));
            request.AddJsonBody(BgpNeighborConfig);
            if (Override != null) { request.AddQueryParameter("override", Override.ToString()); }
            request.Resource = GlobalInfraPatchBgpNeighborConfigServiceURL.ToString();
            RestResponse response = await restClient.ExecuteTaskAsyncWithPolicy(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Patch operation to " + GlobalInfraPatchBgpNeighborConfigServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task GlobalGlobalInfraDeleteBgpNeighborConfig(string Tier0Id, string LocaleServiceId, string NeighborId, bool? Override = null)
        {
            if (Tier0Id == null) { throw new System.ArgumentNullException("Tier0Id cannot be null"); }
            if (LocaleServiceId == null) { throw new System.ArgumentNullException("LocaleServiceId cannot be null"); }
            if (NeighborId == null) { throw new System.ArgumentNullException("NeighborId cannot be null"); }
            StringBuilder GlobalInfraDeleteBgpNeighborConfigServiceURL = new StringBuilder("/global-infra/tier-0s/{tier-0-id}/locale-services/{locale-service-id}/bgp/neighbors/{neighbor-id}");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Delete
            };
            GlobalInfraDeleteBgpNeighborConfigServiceURL.Replace("{tier-0-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(Tier0Id, System.Globalization.CultureInfo.InvariantCulture)));
            GlobalInfraDeleteBgpNeighborConfigServiceURL.Replace("{locale-service-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(LocaleServiceId, System.Globalization.CultureInfo.InvariantCulture)));
            GlobalInfraDeleteBgpNeighborConfigServiceURL.Replace("{neighbor-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(NeighborId, System.Globalization.CultureInfo.InvariantCulture)));
            if (Override != null) { request.AddQueryParameter("override", Override.ToString()); }
            request.Resource = GlobalInfraDeleteBgpNeighborConfigServiceURL.ToString();
            RestResponse response = await restClient.ExecuteTaskAsyncWithPolicy(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Delete operation to " + GlobalInfraDeleteBgpNeighborConfigServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTAntreaTraceflowObservationListResultType> ListAntreaTraceflowObservations(string TraceflowId, string? EnforcementPointPath = null)
        {
            if (TraceflowId == null) { throw new System.ArgumentNullException("TraceflowId cannot be null"); }
            StringBuilder ListAntreaTraceflowObservationsServiceURL = new StringBuilder("/infra/antrea/traceflows/{traceflow-id}/observations");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Get
            };
            ListAntreaTraceflowObservationsServiceURL.Replace("{traceflow-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(TraceflowId, System.Globalization.CultureInfo.InvariantCulture)));
            if (EnforcementPointPath != null) { request.AddQueryParameter("enforcement_point_path", EnforcementPointPath.ToString()); }
            request.Resource = ListAntreaTraceflowObservationsServiceURL.ToString();
            RestResponse<NSXTAntreaTraceflowObservationListResultType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTAntreaTraceflowObservationListResultType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Get operation to " + ListAntreaTraceflowObservationsServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTStaticRoutesListResultType> ListTier1StaticRoutes(string Tier1Id, string? Cursor = null, bool? IncludeMarkForDeleteObjects = null, string? IncludedFields = null, long? PageSize = null, bool? SortAscending = null, string? SortBy = null)
        {
            if (Tier1Id == null) { throw new System.ArgumentNullException("Tier1Id cannot be null"); }
            StringBuilder ListTier1StaticRoutesServiceURL = new StringBuilder("/infra/tier-1s/{tier-1-id}/static-routes");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Get
            };
            ListTier1StaticRoutesServiceURL.Replace("{tier-1-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(Tier1Id, System.Globalization.CultureInfo.InvariantCulture)));
            if (Cursor != null) { request.AddQueryParameter("cursor", Cursor.ToString()); }
            if (IncludeMarkForDeleteObjects != null) { request.AddQueryParameter("include_mark_for_delete_objects", IncludeMarkForDeleteObjects.ToString()); }
            if (IncludedFields != null) { request.AddQueryParameter("included_fields", IncludedFields.ToString()); }
            if (PageSize != null) { request.AddQueryParameter("page_size", PageSize.ToString()); }
            if (SortAscending != null) { request.AddQueryParameter("sort_ascending", SortAscending.ToString()); }
            if (SortBy != null) { request.AddQueryParameter("sort_by", SortBy.ToString()); }
            request.Resource = ListTier1StaticRoutesServiceURL.ToString();
            RestResponse<NSXTStaticRoutesListResultType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTStaticRoutesListResultType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Get operation to " + ListTier1StaticRoutesServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTPrefixListType> GlobalGlobalInfraReadPrefixList(string Tier0Id, string PrefixListId)
        {
            if (Tier0Id == null) { throw new System.ArgumentNullException("Tier0Id cannot be null"); }
            if (PrefixListId == null) { throw new System.ArgumentNullException("PrefixListId cannot be null"); }
            StringBuilder GlobalInfraReadPrefixListServiceURL = new StringBuilder("/global-infra/tier-0s/{tier-0-id}/prefix-lists/{prefix-list-id}");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Get
            };
            GlobalInfraReadPrefixListServiceURL.Replace("{tier-0-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(Tier0Id, System.Globalization.CultureInfo.InvariantCulture)));
            GlobalInfraReadPrefixListServiceURL.Replace("{prefix-list-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(PrefixListId, System.Globalization.CultureInfo.InvariantCulture)));
            request.Resource = GlobalInfraReadPrefixListServiceURL.ToString();
            RestResponse<NSXTPrefixListType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTPrefixListType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Get operation to " + GlobalInfraReadPrefixListServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTBgpNeighborConfigType> CreateOrReplaceBgpNeighborConfig(string Tier0Id, string LocaleServiceId, string NeighborId, NSXTBgpNeighborConfigType BgpNeighborConfig, bool? Override = null)
        {
            if (Tier0Id == null) { throw new System.ArgumentNullException("Tier0Id cannot be null"); }
            if (LocaleServiceId == null) { throw new System.ArgumentNullException("LocaleServiceId cannot be null"); }
            if (NeighborId == null) { throw new System.ArgumentNullException("NeighborId cannot be null"); }
            if (BgpNeighborConfig == null) { throw new System.ArgumentNullException("BgpNeighborConfig cannot be null"); }
            StringBuilder CreateOrReplaceBgpNeighborConfigServiceURL = new StringBuilder("/infra/tier-0s/{tier-0-id}/locale-services/{locale-service-id}/bgp/neighbors/{neighbor-id}");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Put
            };
            CreateOrReplaceBgpNeighborConfigServiceURL.Replace("{tier-0-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(Tier0Id, System.Globalization.CultureInfo.InvariantCulture)));
            CreateOrReplaceBgpNeighborConfigServiceURL.Replace("{locale-service-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(LocaleServiceId, System.Globalization.CultureInfo.InvariantCulture)));
            CreateOrReplaceBgpNeighborConfigServiceURL.Replace("{neighbor-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(NeighborId, System.Globalization.CultureInfo.InvariantCulture)));
            request.AddJsonBody(BgpNeighborConfig);
            if (Override != null) { request.AddQueryParameter("override", Override.ToString()); }
            request.Resource = CreateOrReplaceBgpNeighborConfigServiceURL.ToString();
            RestResponse<NSXTBgpNeighborConfigType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTBgpNeighborConfigType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Put operation to " + CreateOrReplaceBgpNeighborConfigServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTBgpNeighborConfigType> ReadBgpNeighborConfig(string Tier0Id, string LocaleServiceId, string NeighborId)
        {
            if (Tier0Id == null) { throw new System.ArgumentNullException("Tier0Id cannot be null"); }
            if (LocaleServiceId == null) { throw new System.ArgumentNullException("LocaleServiceId cannot be null"); }
            if (NeighborId == null) { throw new System.ArgumentNullException("NeighborId cannot be null"); }
            StringBuilder ReadBgpNeighborConfigServiceURL = new StringBuilder("/infra/tier-0s/{tier-0-id}/locale-services/{locale-service-id}/bgp/neighbors/{neighbor-id}");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Get
            };
            ReadBgpNeighborConfigServiceURL.Replace("{tier-0-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(Tier0Id, System.Globalization.CultureInfo.InvariantCulture)));
            ReadBgpNeighborConfigServiceURL.Replace("{locale-service-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(LocaleServiceId, System.Globalization.CultureInfo.InvariantCulture)));
            ReadBgpNeighborConfigServiceURL.Replace("{neighbor-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(NeighborId, System.Globalization.CultureInfo.InvariantCulture)));
            request.Resource = ReadBgpNeighborConfigServiceURL.ToString();
            RestResponse<NSXTBgpNeighborConfigType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTBgpNeighborConfigType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Get operation to " + ReadBgpNeighborConfigServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task PatchBgpNeighborConfig(string Tier0Id, string LocaleServiceId, string NeighborId, NSXTBgpNeighborConfigType BgpNeighborConfig, bool? Override = null)
        {
            if (Tier0Id == null) { throw new System.ArgumentNullException("Tier0Id cannot be null"); }
            if (LocaleServiceId == null) { throw new System.ArgumentNullException("LocaleServiceId cannot be null"); }
            if (NeighborId == null) { throw new System.ArgumentNullException("NeighborId cannot be null"); }
            if (BgpNeighborConfig == null) { throw new System.ArgumentNullException("BgpNeighborConfig cannot be null"); }
            StringBuilder PatchBgpNeighborConfigServiceURL = new StringBuilder("/infra/tier-0s/{tier-0-id}/locale-services/{locale-service-id}/bgp/neighbors/{neighbor-id}");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Patch
            };
            PatchBgpNeighborConfigServiceURL.Replace("{tier-0-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(Tier0Id, System.Globalization.CultureInfo.InvariantCulture)));
            PatchBgpNeighborConfigServiceURL.Replace("{locale-service-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(LocaleServiceId, System.Globalization.CultureInfo.InvariantCulture)));
            PatchBgpNeighborConfigServiceURL.Replace("{neighbor-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(NeighborId, System.Globalization.CultureInfo.InvariantCulture)));
            request.AddJsonBody(BgpNeighborConfig);
            if (Override != null) { request.AddQueryParameter("override", Override.ToString()); }
            request.Resource = PatchBgpNeighborConfigServiceURL.ToString();
            RestResponse response = await restClient.ExecuteTaskAsyncWithPolicy(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Patch operation to " + PatchBgpNeighborConfigServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task DeleteBgpNeighborConfig(string Tier0Id, string LocaleServiceId, string NeighborId, bool? Override = null)
        {
            if (Tier0Id == null) { throw new System.ArgumentNullException("Tier0Id cannot be null"); }
            if (LocaleServiceId == null) { throw new System.ArgumentNullException("LocaleServiceId cannot be null"); }
            if (NeighborId == null) { throw new System.ArgumentNullException("NeighborId cannot be null"); }
            StringBuilder DeleteBgpNeighborConfigServiceURL = new StringBuilder("/infra/tier-0s/{tier-0-id}/locale-services/{locale-service-id}/bgp/neighbors/{neighbor-id}");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Delete
            };
            DeleteBgpNeighborConfigServiceURL.Replace("{tier-0-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(Tier0Id, System.Globalization.CultureInfo.InvariantCulture)));
            DeleteBgpNeighborConfigServiceURL.Replace("{locale-service-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(LocaleServiceId, System.Globalization.CultureInfo.InvariantCulture)));
            DeleteBgpNeighborConfigServiceURL.Replace("{neighbor-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(NeighborId, System.Globalization.CultureInfo.InvariantCulture)));
            if (Override != null) { request.AddQueryParameter("override", Override.ToString()); }
            request.Resource = DeleteBgpNeighborConfigServiceURL.ToString();
            RestResponse response = await restClient.ExecuteTaskAsyncWithPolicy(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Delete operation to " + DeleteBgpNeighborConfigServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTBfdProfileListResultType> ListBfdProfile(string? Cursor = null, bool? IncludeMarkForDeleteObjects = null, string? IncludedFields = null, long? PageSize = null, bool? SortAscending = null, string? SortBy = null)
        {
            StringBuilder ListBfdProfileServiceURL = new StringBuilder("/infra/bfd-profiles");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Get
            };
            if (Cursor != null) { request.AddQueryParameter("cursor", Cursor.ToString()); }
            if (IncludeMarkForDeleteObjects != null) { request.AddQueryParameter("include_mark_for_delete_objects", IncludeMarkForDeleteObjects.ToString()); }
            if (IncludedFields != null) { request.AddQueryParameter("included_fields", IncludedFields.ToString()); }
            if (PageSize != null) { request.AddQueryParameter("page_size", PageSize.ToString()); }
            if (SortAscending != null) { request.AddQueryParameter("sort_ascending", SortAscending.ToString()); }
            if (SortBy != null) { request.AddQueryParameter("sort_by", SortBy.ToString()); }
            request.Resource = ListBfdProfileServiceURL.ToString();
            RestResponse<NSXTBfdProfileListResultType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTBfdProfileListResultType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Get operation to " + ListBfdProfileServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTCommunityListListResultType> ListCommunityList(string Tier0Id, string? Cursor = null, bool? IncludeMarkForDeleteObjects = null, string? IncludedFields = null, long? PageSize = null, bool? SortAscending = null, string? SortBy = null)
        {
            if (Tier0Id == null) { throw new System.ArgumentNullException("Tier0Id cannot be null"); }
            StringBuilder ListCommunityListServiceURL = new StringBuilder("/infra/tier-0s/{tier-0-id}/community-lists");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Get
            };
            ListCommunityListServiceURL.Replace("{tier-0-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(Tier0Id, System.Globalization.CultureInfo.InvariantCulture)));
            if (Cursor != null) { request.AddQueryParameter("cursor", Cursor.ToString()); }
            if (IncludeMarkForDeleteObjects != null) { request.AddQueryParameter("include_mark_for_delete_objects", IncludeMarkForDeleteObjects.ToString()); }
            if (IncludedFields != null) { request.AddQueryParameter("included_fields", IncludedFields.ToString()); }
            if (PageSize != null) { request.AddQueryParameter("page_size", PageSize.ToString()); }
            if (SortAscending != null) { request.AddQueryParameter("sort_ascending", SortAscending.ToString()); }
            if (SortBy != null) { request.AddQueryParameter("sort_by", SortBy.ToString()); }
            request.Resource = ListCommunityListServiceURL.ToString();
            RestResponse<NSXTCommunityListListResultType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTCommunityListListResultType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Get operation to " + ListCommunityListServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTTier1Type> CreateOrReplaceTier1(string Tier1Id, NSXTTier1Type Tier1)
        {
            if (Tier1Id == null) { throw new System.ArgumentNullException("Tier1Id cannot be null"); }
            if (Tier1 == null) { throw new System.ArgumentNullException("Tier1 cannot be null"); }
            StringBuilder CreateOrReplaceTier1ServiceURL = new StringBuilder("/infra/tier-1s/{tier-1-id}");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Put
            };
            CreateOrReplaceTier1ServiceURL.Replace("{tier-1-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(Tier1Id, System.Globalization.CultureInfo.InvariantCulture)));
            request.AddJsonBody(Tier1);
            request.Resource = CreateOrReplaceTier1ServiceURL.ToString();
            RestResponse<NSXTTier1Type> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTTier1Type>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Put operation to " + CreateOrReplaceTier1ServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task DeleteTier1(string Tier1Id)
        {
            if (Tier1Id == null) { throw new System.ArgumentNullException("Tier1Id cannot be null"); }
            StringBuilder DeleteTier1ServiceURL = new StringBuilder("/infra/tier-1s/{tier-1-id}");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Delete
            };
            DeleteTier1ServiceURL.Replace("{tier-1-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(Tier1Id, System.Globalization.CultureInfo.InvariantCulture)));
            request.Resource = DeleteTier1ServiceURL.ToString();
            RestResponse response = await restClient.ExecuteTaskAsyncWithPolicy(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Delete operation to " + DeleteTier1ServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task PatchTier1(string Tier1Id, NSXTTier1Type Tier1)
        {
            if (Tier1Id == null) { throw new System.ArgumentNullException("Tier1Id cannot be null"); }
            if (Tier1 == null) { throw new System.ArgumentNullException("Tier1 cannot be null"); }
            StringBuilder PatchTier1ServiceURL = new StringBuilder("/infra/tier-1s/{tier-1-id}");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Patch
            };
            PatchTier1ServiceURL.Replace("{tier-1-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(Tier1Id, System.Globalization.CultureInfo.InvariantCulture)));
            request.AddJsonBody(Tier1);
            request.Resource = PatchTier1ServiceURL.ToString();
            RestResponse response = await restClient.ExecuteTaskAsyncWithPolicy(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Patch operation to " + PatchTier1ServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTTier1Type> ReadTier1(string Tier1Id)
        {
            if (Tier1Id == null) { throw new System.ArgumentNullException("Tier1Id cannot be null"); }
            StringBuilder ReadTier1ServiceURL = new StringBuilder("/infra/tier-1s/{tier-1-id}");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Get
            };
            ReadTier1ServiceURL.Replace("{tier-1-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(Tier1Id, System.Globalization.CultureInfo.InvariantCulture)));
            request.Resource = ReadTier1ServiceURL.ToString();
            RestResponse<NSXTTier1Type> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTTier1Type>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Get operation to " + ReadTier1ServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTSegmentType> CreateOrReplaceSegment(string Tier1Id, string SegmentId, NSXTSegmentType Segment)
        {
            if (Tier1Id == null) { throw new System.ArgumentNullException("Tier1Id cannot be null"); }
            if (SegmentId == null) { throw new System.ArgumentNullException("SegmentId cannot be null"); }
            if (Segment == null) { throw new System.ArgumentNullException("Segment cannot be null"); }
            StringBuilder CreateOrReplaceSegmentServiceURL = new StringBuilder("/infra/tier-1s/{tier-1-id}/segments/{segment-id}");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Put
            };
            CreateOrReplaceSegmentServiceURL.Replace("{tier-1-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(Tier1Id, System.Globalization.CultureInfo.InvariantCulture)));
            CreateOrReplaceSegmentServiceURL.Replace("{segment-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(SegmentId, System.Globalization.CultureInfo.InvariantCulture)));
            request.AddJsonBody(Segment);
            request.Resource = CreateOrReplaceSegmentServiceURL.ToString();
            RestResponse<NSXTSegmentType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTSegmentType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Put operation to " + CreateOrReplaceSegmentServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTSegmentType> ReadSegment(string Tier1Id, string SegmentId)
        {
            if (Tier1Id == null) { throw new System.ArgumentNullException("Tier1Id cannot be null"); }
            if (SegmentId == null) { throw new System.ArgumentNullException("SegmentId cannot be null"); }
            StringBuilder ReadSegmentServiceURL = new StringBuilder("/infra/tier-1s/{tier-1-id}/segments/{segment-id}");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Get
            };
            ReadSegmentServiceURL.Replace("{tier-1-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(Tier1Id, System.Globalization.CultureInfo.InvariantCulture)));
            ReadSegmentServiceURL.Replace("{segment-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(SegmentId, System.Globalization.CultureInfo.InvariantCulture)));
            request.Resource = ReadSegmentServiceURL.ToString();
            RestResponse<NSXTSegmentType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTSegmentType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Get operation to " + ReadSegmentServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task PatchSegment(string Tier1Id, string SegmentId, NSXTSegmentType Segment)
        {
            if (Tier1Id == null) { throw new System.ArgumentNullException("Tier1Id cannot be null"); }
            if (SegmentId == null) { throw new System.ArgumentNullException("SegmentId cannot be null"); }
            if (Segment == null) { throw new System.ArgumentNullException("Segment cannot be null"); }
            StringBuilder PatchSegmentServiceURL = new StringBuilder("/infra/tier-1s/{tier-1-id}/segments/{segment-id}");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Patch
            };
            PatchSegmentServiceURL.Replace("{tier-1-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(Tier1Id, System.Globalization.CultureInfo.InvariantCulture)));
            PatchSegmentServiceURL.Replace("{segment-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(SegmentId, System.Globalization.CultureInfo.InvariantCulture)));
            request.AddJsonBody(Segment);
            request.Resource = PatchSegmentServiceURL.ToString();
            RestResponse response = await restClient.ExecuteTaskAsyncWithPolicy(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Patch operation to " + PatchSegmentServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task DeleteSegment(string Tier1Id, string SegmentId)
        {
            if (Tier1Id == null) { throw new System.ArgumentNullException("Tier1Id cannot be null"); }
            if (SegmentId == null) { throw new System.ArgumentNullException("SegmentId cannot be null"); }
            StringBuilder DeleteSegmentServiceURL = new StringBuilder("/infra/tier-1s/{tier-1-id}/segments/{segment-id}");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Delete
            };
            DeleteSegmentServiceURL.Replace("{tier-1-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(Tier1Id, System.Globalization.CultureInfo.InvariantCulture)));
            DeleteSegmentServiceURL.Replace("{segment-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(SegmentId, System.Globalization.CultureInfo.InvariantCulture)));
            request.Resource = DeleteSegmentServiceURL.ToString();
            RestResponse response = await restClient.ExecuteTaskAsyncWithPolicy(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Delete operation to " + DeleteSegmentServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTIpv6DadProfileType> GlobalGlobalInfraCreateOrReplaceIpv6DadProfile(string DadProfileId, NSXTIpv6DadProfileType Ipv6DadProfile, bool? Override = null)
        {
            if (DadProfileId == null) { throw new System.ArgumentNullException("DadProfileId cannot be null"); }
            if (Ipv6DadProfile == null) { throw new System.ArgumentNullException("Ipv6DadProfile cannot be null"); }
            StringBuilder GlobalInfraCreateOrReplaceIpv6DadProfileServiceURL = new StringBuilder("/global-infra/ipv6-dad-profiles/{dad-profile-id}");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Put
            };
            GlobalInfraCreateOrReplaceIpv6DadProfileServiceURL.Replace("{dad-profile-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(DadProfileId, System.Globalization.CultureInfo.InvariantCulture)));
            request.AddJsonBody(Ipv6DadProfile);
            if (Override != null) { request.AddQueryParameter("override", Override.ToString()); }
            request.Resource = GlobalInfraCreateOrReplaceIpv6DadProfileServiceURL.ToString();
            RestResponse<NSXTIpv6DadProfileType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTIpv6DadProfileType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Put operation to " + GlobalInfraCreateOrReplaceIpv6DadProfileServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTIpv6DadProfileType> GlobalGlobalInfraReadIpv6DadProfile(string DadProfileId)
        {
            if (DadProfileId == null) { throw new System.ArgumentNullException("DadProfileId cannot be null"); }
            StringBuilder GlobalInfraReadIpv6DadProfileServiceURL = new StringBuilder("/global-infra/ipv6-dad-profiles/{dad-profile-id}");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Get
            };
            GlobalInfraReadIpv6DadProfileServiceURL.Replace("{dad-profile-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(DadProfileId, System.Globalization.CultureInfo.InvariantCulture)));
            request.Resource = GlobalInfraReadIpv6DadProfileServiceURL.ToString();
            RestResponse<NSXTIpv6DadProfileType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTIpv6DadProfileType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Get operation to " + GlobalInfraReadIpv6DadProfileServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task GlobalGlobalInfraPatchIpv6DadProfile(string DadProfileId, NSXTIpv6DadProfileType Ipv6DadProfile, bool? Override = null)
        {
            if (DadProfileId == null) { throw new System.ArgumentNullException("DadProfileId cannot be null"); }
            if (Ipv6DadProfile == null) { throw new System.ArgumentNullException("Ipv6DadProfile cannot be null"); }
            StringBuilder GlobalInfraPatchIpv6DadProfileServiceURL = new StringBuilder("/global-infra/ipv6-dad-profiles/{dad-profile-id}");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Patch
            };
            GlobalInfraPatchIpv6DadProfileServiceURL.Replace("{dad-profile-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(DadProfileId, System.Globalization.CultureInfo.InvariantCulture)));
            request.AddJsonBody(Ipv6DadProfile);
            if (Override != null) { request.AddQueryParameter("override", Override.ToString()); }
            request.Resource = GlobalInfraPatchIpv6DadProfileServiceURL.ToString();
            RestResponse response = await restClient.ExecuteTaskAsyncWithPolicy(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Patch operation to " + GlobalInfraPatchIpv6DadProfileServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task GlobalGlobalInfraDeleteIpv6DadProfile(string DadProfileId, bool? Override = null)
        {
            if (DadProfileId == null) { throw new System.ArgumentNullException("DadProfileId cannot be null"); }
            StringBuilder GlobalInfraDeleteIpv6DadProfileServiceURL = new StringBuilder("/global-infra/ipv6-dad-profiles/{dad-profile-id}");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Delete
            };
            GlobalInfraDeleteIpv6DadProfileServiceURL.Replace("{dad-profile-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(DadProfileId, System.Globalization.CultureInfo.InvariantCulture)));
            if (Override != null) { request.AddQueryParameter("override", Override.ToString()); }
            request.Resource = GlobalInfraDeleteIpv6DadProfileServiceURL.ToString();
            RestResponse response = await restClient.ExecuteTaskAsyncWithPolicy(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Delete operation to " + GlobalInfraDeleteIpv6DadProfileServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTSegmentPortType> GlobalGlobalInfraCreateOrReplaceTier1SegmentPort(string Tier1Id, string SegmentId, string PortId, NSXTSegmentPortType SegmentPort)
        {
            if (Tier1Id == null) { throw new System.ArgumentNullException("Tier1Id cannot be null"); }
            if (SegmentId == null) { throw new System.ArgumentNullException("SegmentId cannot be null"); }
            if (PortId == null) { throw new System.ArgumentNullException("PortId cannot be null"); }
            if (SegmentPort == null) { throw new System.ArgumentNullException("SegmentPort cannot be null"); }
            StringBuilder GlobalInfraCreateOrReplaceTier1SegmentPortServiceURL = new StringBuilder("/global-infra/tier-1s/{tier-1-id}/segments/{segment-id}/ports/{port-id}");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Put
            };
            GlobalInfraCreateOrReplaceTier1SegmentPortServiceURL.Replace("{tier-1-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(Tier1Id, System.Globalization.CultureInfo.InvariantCulture)));
            GlobalInfraCreateOrReplaceTier1SegmentPortServiceURL.Replace("{segment-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(SegmentId, System.Globalization.CultureInfo.InvariantCulture)));
            GlobalInfraCreateOrReplaceTier1SegmentPortServiceURL.Replace("{port-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(PortId, System.Globalization.CultureInfo.InvariantCulture)));
            request.AddJsonBody(SegmentPort);
            request.Resource = GlobalInfraCreateOrReplaceTier1SegmentPortServiceURL.ToString();
            RestResponse<NSXTSegmentPortType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTSegmentPortType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Put operation to " + GlobalInfraCreateOrReplaceTier1SegmentPortServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task GlobalGlobalInfraDeleteTier1SegmentPort(string Tier1Id, string SegmentId, string PortId)
        {
            if (Tier1Id == null) { throw new System.ArgumentNullException("Tier1Id cannot be null"); }
            if (SegmentId == null) { throw new System.ArgumentNullException("SegmentId cannot be null"); }
            if (PortId == null) { throw new System.ArgumentNullException("PortId cannot be null"); }
            StringBuilder GlobalInfraDeleteTier1SegmentPortServiceURL = new StringBuilder("/global-infra/tier-1s/{tier-1-id}/segments/{segment-id}/ports/{port-id}");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Delete
            };
            GlobalInfraDeleteTier1SegmentPortServiceURL.Replace("{tier-1-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(Tier1Id, System.Globalization.CultureInfo.InvariantCulture)));
            GlobalInfraDeleteTier1SegmentPortServiceURL.Replace("{segment-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(SegmentId, System.Globalization.CultureInfo.InvariantCulture)));
            GlobalInfraDeleteTier1SegmentPortServiceURL.Replace("{port-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(PortId, System.Globalization.CultureInfo.InvariantCulture)));
            request.Resource = GlobalInfraDeleteTier1SegmentPortServiceURL.ToString();
            RestResponse response = await restClient.ExecuteTaskAsyncWithPolicy(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Delete operation to " + GlobalInfraDeleteTier1SegmentPortServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task GlobalGlobalInfraPatchTier1SegmentPort(string Tier1Id, string SegmentId, string PortId, NSXTSegmentPortType SegmentPort)
        {
            if (Tier1Id == null) { throw new System.ArgumentNullException("Tier1Id cannot be null"); }
            if (SegmentId == null) { throw new System.ArgumentNullException("SegmentId cannot be null"); }
            if (PortId == null) { throw new System.ArgumentNullException("PortId cannot be null"); }
            if (SegmentPort == null) { throw new System.ArgumentNullException("SegmentPort cannot be null"); }
            StringBuilder GlobalInfraPatchTier1SegmentPortServiceURL = new StringBuilder("/global-infra/tier-1s/{tier-1-id}/segments/{segment-id}/ports/{port-id}");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Patch
            };
            GlobalInfraPatchTier1SegmentPortServiceURL.Replace("{tier-1-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(Tier1Id, System.Globalization.CultureInfo.InvariantCulture)));
            GlobalInfraPatchTier1SegmentPortServiceURL.Replace("{segment-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(SegmentId, System.Globalization.CultureInfo.InvariantCulture)));
            GlobalInfraPatchTier1SegmentPortServiceURL.Replace("{port-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(PortId, System.Globalization.CultureInfo.InvariantCulture)));
            request.AddJsonBody(SegmentPort);
            request.Resource = GlobalInfraPatchTier1SegmentPortServiceURL.ToString();
            RestResponse response = await restClient.ExecuteTaskAsyncWithPolicy(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Patch operation to " + GlobalInfraPatchTier1SegmentPortServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTSegmentPortType> GlobalGlobalInfraGetTier1SegmentPort(string Tier1Id, string SegmentId, string PortId)
        {
            if (Tier1Id == null) { throw new System.ArgumentNullException("Tier1Id cannot be null"); }
            if (SegmentId == null) { throw new System.ArgumentNullException("SegmentId cannot be null"); }
            if (PortId == null) { throw new System.ArgumentNullException("PortId cannot be null"); }
            StringBuilder GlobalInfraGetTier1SegmentPortServiceURL = new StringBuilder("/global-infra/tier-1s/{tier-1-id}/segments/{segment-id}/ports/{port-id}");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Get
            };
            GlobalInfraGetTier1SegmentPortServiceURL.Replace("{tier-1-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(Tier1Id, System.Globalization.CultureInfo.InvariantCulture)));
            GlobalInfraGetTier1SegmentPortServiceURL.Replace("{segment-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(SegmentId, System.Globalization.CultureInfo.InvariantCulture)));
            GlobalInfraGetTier1SegmentPortServiceURL.Replace("{port-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(PortId, System.Globalization.CultureInfo.InvariantCulture)));
            request.Resource = GlobalInfraGetTier1SegmentPortServiceURL.ToString();
            RestResponse<NSXTSegmentPortType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTSegmentPortType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Get operation to " + GlobalInfraGetTier1SegmentPortServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTLiveTraceListResultType> ListLiveTraceStatus(string? EnforcementPointPath = null)
        {
            StringBuilder ListLiveTraceStatusServiceURL = new StringBuilder("/infra/livetraces/statuses");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Get
            };
            if (EnforcementPointPath != null) { request.AddQueryParameter("enforcement_point_path", EnforcementPointPath.ToString()); }
            request.Resource = ListLiveTraceStatusServiceURL.ToString();
            RestResponse<NSXTLiveTraceListResultType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTLiveTraceListResultType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Get operation to " + ListLiveTraceStatusServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTStaticRoutesListResultType> GlobalGlobalInfraListTier1StaticRoutes(string Tier1Id, string? Cursor = null, bool? IncludeMarkForDeleteObjects = null, string? IncludedFields = null, long? PageSize = null, bool? SortAscending = null, string? SortBy = null)
        {
            if (Tier1Id == null) { throw new System.ArgumentNullException("Tier1Id cannot be null"); }
            StringBuilder GlobalInfraListTier1StaticRoutesServiceURL = new StringBuilder("/global-infra/tier-1s/{tier-1-id}/static-routes");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Get
            };
            GlobalInfraListTier1StaticRoutesServiceURL.Replace("{tier-1-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(Tier1Id, System.Globalization.CultureInfo.InvariantCulture)));
            if (Cursor != null) { request.AddQueryParameter("cursor", Cursor.ToString()); }
            if (IncludeMarkForDeleteObjects != null) { request.AddQueryParameter("include_mark_for_delete_objects", IncludeMarkForDeleteObjects.ToString()); }
            if (IncludedFields != null) { request.AddQueryParameter("included_fields", IncludedFields.ToString()); }
            if (PageSize != null) { request.AddQueryParameter("page_size", PageSize.ToString()); }
            if (SortAscending != null) { request.AddQueryParameter("sort_ascending", SortAscending.ToString()); }
            if (SortBy != null) { request.AddQueryParameter("sort_by", SortBy.ToString()); }
            request.Resource = GlobalInfraListTier1StaticRoutesServiceURL.ToString();
            RestResponse<NSXTStaticRoutesListResultType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTStaticRoutesListResultType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Get operation to " + GlobalInfraListTier1StaticRoutesServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTServiceInterfaceType> CreateServiceInterface(string Tier0Id, string LocaleServiceId, string InterfaceId, NSXTServiceInterfaceType ServiceInterface)
        {
            if (Tier0Id == null) { throw new System.ArgumentNullException("Tier0Id cannot be null"); }
            if (LocaleServiceId == null) { throw new System.ArgumentNullException("LocaleServiceId cannot be null"); }
            if (InterfaceId == null) { throw new System.ArgumentNullException("InterfaceId cannot be null"); }
            if (ServiceInterface == null) { throw new System.ArgumentNullException("ServiceInterface cannot be null"); }
            StringBuilder CreateServiceInterfaceServiceURL = new StringBuilder("/infra/tier-0s/{tier-0-id}/locale-services/{locale-service-id}/service-interfaces/{interface-id}");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Put
            };
            CreateServiceInterfaceServiceURL.Replace("{tier-0-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(Tier0Id, System.Globalization.CultureInfo.InvariantCulture)));
            CreateServiceInterfaceServiceURL.Replace("{locale-service-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(LocaleServiceId, System.Globalization.CultureInfo.InvariantCulture)));
            CreateServiceInterfaceServiceURL.Replace("{interface-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(InterfaceId, System.Globalization.CultureInfo.InvariantCulture)));
            request.AddJsonBody(ServiceInterface);
            request.Resource = CreateServiceInterfaceServiceURL.ToString();
            RestResponse<NSXTServiceInterfaceType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTServiceInterfaceType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Put operation to " + CreateServiceInterfaceServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task PatchServiceInterface(string Tier0Id, string LocaleServiceId, string InterfaceId, NSXTServiceInterfaceType ServiceInterface)
        {
            if (Tier0Id == null) { throw new System.ArgumentNullException("Tier0Id cannot be null"); }
            if (LocaleServiceId == null) { throw new System.ArgumentNullException("LocaleServiceId cannot be null"); }
            if (InterfaceId == null) { throw new System.ArgumentNullException("InterfaceId cannot be null"); }
            if (ServiceInterface == null) { throw new System.ArgumentNullException("ServiceInterface cannot be null"); }
            StringBuilder PatchServiceInterfaceServiceURL = new StringBuilder("/infra/tier-0s/{tier-0-id}/locale-services/{locale-service-id}/service-interfaces/{interface-id}");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Patch
            };
            PatchServiceInterfaceServiceURL.Replace("{tier-0-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(Tier0Id, System.Globalization.CultureInfo.InvariantCulture)));
            PatchServiceInterfaceServiceURL.Replace("{locale-service-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(LocaleServiceId, System.Globalization.CultureInfo.InvariantCulture)));
            PatchServiceInterfaceServiceURL.Replace("{interface-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(InterfaceId, System.Globalization.CultureInfo.InvariantCulture)));
            request.AddJsonBody(ServiceInterface);
            request.Resource = PatchServiceInterfaceServiceURL.ToString();
            RestResponse response = await restClient.ExecuteTaskAsyncWithPolicy(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Patch operation to " + PatchServiceInterfaceServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task DeleteServiceInterface(string Tier0Id, string LocaleServiceId, string InterfaceId)
        {
            if (Tier0Id == null) { throw new System.ArgumentNullException("Tier0Id cannot be null"); }
            if (LocaleServiceId == null) { throw new System.ArgumentNullException("LocaleServiceId cannot be null"); }
            if (InterfaceId == null) { throw new System.ArgumentNullException("InterfaceId cannot be null"); }
            StringBuilder DeleteServiceInterfaceServiceURL = new StringBuilder("/infra/tier-0s/{tier-0-id}/locale-services/{locale-service-id}/service-interfaces/{interface-id}");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Delete
            };
            DeleteServiceInterfaceServiceURL.Replace("{tier-0-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(Tier0Id, System.Globalization.CultureInfo.InvariantCulture)));
            DeleteServiceInterfaceServiceURL.Replace("{locale-service-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(LocaleServiceId, System.Globalization.CultureInfo.InvariantCulture)));
            DeleteServiceInterfaceServiceURL.Replace("{interface-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(InterfaceId, System.Globalization.CultureInfo.InvariantCulture)));
            request.Resource = DeleteServiceInterfaceServiceURL.ToString();
            RestResponse response = await restClient.ExecuteTaskAsyncWithPolicy(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Delete operation to " + DeleteServiceInterfaceServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTServiceInterfaceType> ReadServiceInterface(string Tier0Id, string LocaleServiceId, string InterfaceId)
        {
            if (Tier0Id == null) { throw new System.ArgumentNullException("Tier0Id cannot be null"); }
            if (LocaleServiceId == null) { throw new System.ArgumentNullException("LocaleServiceId cannot be null"); }
            if (InterfaceId == null) { throw new System.ArgumentNullException("InterfaceId cannot be null"); }
            StringBuilder ReadServiceInterfaceServiceURL = new StringBuilder("/infra/tier-0s/{tier-0-id}/locale-services/{locale-service-id}/service-interfaces/{interface-id}");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Get
            };
            ReadServiceInterfaceServiceURL.Replace("{tier-0-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(Tier0Id, System.Globalization.CultureInfo.InvariantCulture)));
            ReadServiceInterfaceServiceURL.Replace("{locale-service-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(LocaleServiceId, System.Globalization.CultureInfo.InvariantCulture)));
            ReadServiceInterfaceServiceURL.Replace("{interface-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(InterfaceId, System.Globalization.CultureInfo.InvariantCulture)));
            request.Resource = ReadServiceInterfaceServiceURL.ToString();
            RestResponse<NSXTServiceInterfaceType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTServiceInterfaceType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Get operation to " + ReadServiceInterfaceServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTIpv6NdraProfileListResultType> GlobalGlobalInfraListIpv6NdraProfiles(string? Cursor = null, bool? IncludeMarkForDeleteObjects = null, string? IncludedFields = null, long? PageSize = null, bool? SortAscending = null, string? SortBy = null)
        {
            StringBuilder GlobalInfraListIpv6NdraProfilesServiceURL = new StringBuilder("/global-infra/ipv6-ndra-profiles");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Get
            };
            if (Cursor != null) { request.AddQueryParameter("cursor", Cursor.ToString()); }
            if (IncludeMarkForDeleteObjects != null) { request.AddQueryParameter("include_mark_for_delete_objects", IncludeMarkForDeleteObjects.ToString()); }
            if (IncludedFields != null) { request.AddQueryParameter("included_fields", IncludedFields.ToString()); }
            if (PageSize != null) { request.AddQueryParameter("page_size", PageSize.ToString()); }
            if (SortAscending != null) { request.AddQueryParameter("sort_ascending", SortAscending.ToString()); }
            if (SortBy != null) { request.AddQueryParameter("sort_by", SortBy.ToString()); }
            request.Resource = GlobalInfraListIpv6NdraProfilesServiceURL.ToString();
            RestResponse<NSXTIpv6NdraProfileListResultType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTIpv6NdraProfileListResultType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Get operation to " + GlobalInfraListIpv6NdraProfilesServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTTier1InterfaceType> CreateOrReplaceTier1Interface(string Tier1Id, string LocaleServicesId, string InterfaceId, NSXTTier1InterfaceType Tier1Interface)
        {
            if (Tier1Id == null) { throw new System.ArgumentNullException("Tier1Id cannot be null"); }
            if (LocaleServicesId == null) { throw new System.ArgumentNullException("LocaleServicesId cannot be null"); }
            if (InterfaceId == null) { throw new System.ArgumentNullException("InterfaceId cannot be null"); }
            if (Tier1Interface == null) { throw new System.ArgumentNullException("Tier1Interface cannot be null"); }
            StringBuilder CreateOrReplaceTier1InterfaceServiceURL = new StringBuilder("/infra/tier-1s/{tier-1-id}/locale-services/{locale-services-id}/interfaces/{interface-id}");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Put
            };
            CreateOrReplaceTier1InterfaceServiceURL.Replace("{tier-1-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(Tier1Id, System.Globalization.CultureInfo.InvariantCulture)));
            CreateOrReplaceTier1InterfaceServiceURL.Replace("{locale-services-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(LocaleServicesId, System.Globalization.CultureInfo.InvariantCulture)));
            CreateOrReplaceTier1InterfaceServiceURL.Replace("{interface-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(InterfaceId, System.Globalization.CultureInfo.InvariantCulture)));
            request.AddJsonBody(Tier1Interface);
            request.Resource = CreateOrReplaceTier1InterfaceServiceURL.ToString();
            RestResponse<NSXTTier1InterfaceType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTTier1InterfaceType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Put operation to " + CreateOrReplaceTier1InterfaceServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task DeleteTier1Interface(string Tier1Id, string LocaleServicesId, string InterfaceId)
        {
            if (Tier1Id == null) { throw new System.ArgumentNullException("Tier1Id cannot be null"); }
            if (LocaleServicesId == null) { throw new System.ArgumentNullException("LocaleServicesId cannot be null"); }
            if (InterfaceId == null) { throw new System.ArgumentNullException("InterfaceId cannot be null"); }
            StringBuilder DeleteTier1InterfaceServiceURL = new StringBuilder("/infra/tier-1s/{tier-1-id}/locale-services/{locale-services-id}/interfaces/{interface-id}");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Delete
            };
            DeleteTier1InterfaceServiceURL.Replace("{tier-1-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(Tier1Id, System.Globalization.CultureInfo.InvariantCulture)));
            DeleteTier1InterfaceServiceURL.Replace("{locale-services-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(LocaleServicesId, System.Globalization.CultureInfo.InvariantCulture)));
            DeleteTier1InterfaceServiceURL.Replace("{interface-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(InterfaceId, System.Globalization.CultureInfo.InvariantCulture)));
            request.Resource = DeleteTier1InterfaceServiceURL.ToString();
            RestResponse response = await restClient.ExecuteTaskAsyncWithPolicy(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Delete operation to " + DeleteTier1InterfaceServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTTier1InterfaceType> ReadTier1Interface(string Tier1Id, string LocaleServicesId, string InterfaceId)
        {
            if (Tier1Id == null) { throw new System.ArgumentNullException("Tier1Id cannot be null"); }
            if (LocaleServicesId == null) { throw new System.ArgumentNullException("LocaleServicesId cannot be null"); }
            if (InterfaceId == null) { throw new System.ArgumentNullException("InterfaceId cannot be null"); }
            StringBuilder ReadTier1InterfaceServiceURL = new StringBuilder("/infra/tier-1s/{tier-1-id}/locale-services/{locale-services-id}/interfaces/{interface-id}");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Get
            };
            ReadTier1InterfaceServiceURL.Replace("{tier-1-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(Tier1Id, System.Globalization.CultureInfo.InvariantCulture)));
            ReadTier1InterfaceServiceURL.Replace("{locale-services-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(LocaleServicesId, System.Globalization.CultureInfo.InvariantCulture)));
            ReadTier1InterfaceServiceURL.Replace("{interface-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(InterfaceId, System.Globalization.CultureInfo.InvariantCulture)));
            request.Resource = ReadTier1InterfaceServiceURL.ToString();
            RestResponse<NSXTTier1InterfaceType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTTier1InterfaceType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Get operation to " + ReadTier1InterfaceServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task PatchTier1Interface(string Tier1Id, string LocaleServicesId, string InterfaceId, NSXTTier1InterfaceType Tier1Interface)
        {
            if (Tier1Id == null) { throw new System.ArgumentNullException("Tier1Id cannot be null"); }
            if (LocaleServicesId == null) { throw new System.ArgumentNullException("LocaleServicesId cannot be null"); }
            if (InterfaceId == null) { throw new System.ArgumentNullException("InterfaceId cannot be null"); }
            if (Tier1Interface == null) { throw new System.ArgumentNullException("Tier1Interface cannot be null"); }
            StringBuilder PatchTier1InterfaceServiceURL = new StringBuilder("/infra/tier-1s/{tier-1-id}/locale-services/{locale-services-id}/interfaces/{interface-id}");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Patch
            };
            PatchTier1InterfaceServiceURL.Replace("{tier-1-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(Tier1Id, System.Globalization.CultureInfo.InvariantCulture)));
            PatchTier1InterfaceServiceURL.Replace("{locale-services-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(LocaleServicesId, System.Globalization.CultureInfo.InvariantCulture)));
            PatchTier1InterfaceServiceURL.Replace("{interface-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(InterfaceId, System.Globalization.CultureInfo.InvariantCulture)));
            request.AddJsonBody(Tier1Interface);
            request.Resource = PatchTier1InterfaceServiceURL.ToString();
            RestResponse response = await restClient.ExecuteTaskAsyncWithPolicy(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Patch operation to " + PatchTier1InterfaceServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTServiceInterfaceListResultType> GlobalGlobalInfraListServiceInterfaces(string Tier0Id, string LocaleServiceId, string? Cursor = null, bool? IncludeMarkForDeleteObjects = null, string? IncludedFields = null, long? PageSize = null, bool? SortAscending = null, string? SortBy = null)
        {
            if (Tier0Id == null) { throw new System.ArgumentNullException("Tier0Id cannot be null"); }
            if (LocaleServiceId == null) { throw new System.ArgumentNullException("LocaleServiceId cannot be null"); }
            StringBuilder GlobalInfraListServiceInterfacesServiceURL = new StringBuilder("/global-infra/tier-0s/{tier-0-id}/locale-services/{locale-service-id}/service-interfaces");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Get
            };
            GlobalInfraListServiceInterfacesServiceURL.Replace("{tier-0-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(Tier0Id, System.Globalization.CultureInfo.InvariantCulture)));
            GlobalInfraListServiceInterfacesServiceURL.Replace("{locale-service-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(LocaleServiceId, System.Globalization.CultureInfo.InvariantCulture)));
            if (Cursor != null) { request.AddQueryParameter("cursor", Cursor.ToString()); }
            if (IncludeMarkForDeleteObjects != null) { request.AddQueryParameter("include_mark_for_delete_objects", IncludeMarkForDeleteObjects.ToString()); }
            if (IncludedFields != null) { request.AddQueryParameter("included_fields", IncludedFields.ToString()); }
            if (PageSize != null) { request.AddQueryParameter("page_size", PageSize.ToString()); }
            if (SortAscending != null) { request.AddQueryParameter("sort_ascending", SortAscending.ToString()); }
            if (SortBy != null) { request.AddQueryParameter("sort_by", SortBy.ToString()); }
            request.Resource = GlobalInfraListServiceInterfacesServiceURL.ToString();
            RestResponse<NSXTServiceInterfaceListResultType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTServiceInterfaceListResultType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Get operation to " + GlobalInfraListServiceInterfacesServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTSegmentListResultType> ListSegments(string Tier1Id, string? Cursor = null, bool? IncludeMarkForDeleteObjects = null, string? IncludedFields = null, long? PageSize = null, string? SegmentType = null, bool? SortAscending = null, string? SortBy = null)
        {
            if (Tier1Id == null) { throw new System.ArgumentNullException("Tier1Id cannot be null"); }
            StringBuilder ListSegmentsServiceURL = new StringBuilder("/infra/tier-1s/{tier-1-id}/segments");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Get
            };
            ListSegmentsServiceURL.Replace("{tier-1-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(Tier1Id, System.Globalization.CultureInfo.InvariantCulture)));
            if (Cursor != null) { request.AddQueryParameter("cursor", Cursor.ToString()); }
            if (IncludeMarkForDeleteObjects != null) { request.AddQueryParameter("include_mark_for_delete_objects", IncludeMarkForDeleteObjects.ToString()); }
            if (IncludedFields != null) { request.AddQueryParameter("included_fields", IncludedFields.ToString()); }
            if (PageSize != null) { request.AddQueryParameter("page_size", PageSize.ToString()); }
            if (SegmentType != null) { request.AddQueryParameter("segment_type", SegmentType.ToString()); }
            if (SortAscending != null) { request.AddQueryParameter("sort_ascending", SortAscending.ToString()); }
            if (SortBy != null) { request.AddQueryParameter("sort_by", SortBy.ToString()); }
            request.Resource = ListSegmentsServiceURL.ToString();
            RestResponse<NSXTSegmentListResultType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTSegmentListResultType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Get operation to " + ListSegmentsServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTStaticARPConfigType> GlobalGlobalInfraReadStaticArpconfig(string Tier1Id, string SegmentId)
        {
            if (Tier1Id == null) { throw new System.ArgumentNullException("Tier1Id cannot be null"); }
            if (SegmentId == null) { throw new System.ArgumentNullException("SegmentId cannot be null"); }
            StringBuilder GlobalInfraReadStaticArpconfigServiceURL = new StringBuilder("/global-infra/tier-1s/{tier-1-id}/segments/{segment-id}/static-arp");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Get
            };
            GlobalInfraReadStaticArpconfigServiceURL.Replace("{tier-1-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(Tier1Id, System.Globalization.CultureInfo.InvariantCulture)));
            GlobalInfraReadStaticArpconfigServiceURL.Replace("{segment-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(SegmentId, System.Globalization.CultureInfo.InvariantCulture)));
            request.Resource = GlobalInfraReadStaticArpconfigServiceURL.ToString();
            RestResponse<NSXTStaticARPConfigType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTStaticARPConfigType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Get operation to " + GlobalInfraReadStaticArpconfigServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTPrefixListType> CreateOrReplacePrefixList(string Tier0Id, string PrefixListId, NSXTPrefixListType PrefixList)
        {
            if (Tier0Id == null) { throw new System.ArgumentNullException("Tier0Id cannot be null"); }
            if (PrefixListId == null) { throw new System.ArgumentNullException("PrefixListId cannot be null"); }
            if (PrefixList == null) { throw new System.ArgumentNullException("PrefixList cannot be null"); }
            StringBuilder CreateOrReplacePrefixListServiceURL = new StringBuilder("/infra/tier-0s/{tier-0-id}/prefix-lists/{prefix-list-id}");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Put
            };
            CreateOrReplacePrefixListServiceURL.Replace("{tier-0-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(Tier0Id, System.Globalization.CultureInfo.InvariantCulture)));
            CreateOrReplacePrefixListServiceURL.Replace("{prefix-list-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(PrefixListId, System.Globalization.CultureInfo.InvariantCulture)));
            request.AddJsonBody(PrefixList);
            request.Resource = CreateOrReplacePrefixListServiceURL.ToString();
            RestResponse<NSXTPrefixListType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTPrefixListType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Put operation to " + CreateOrReplacePrefixListServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTPrefixListType> ReadPrefixList(string Tier0Id, string PrefixListId)
        {
            if (Tier0Id == null) { throw new System.ArgumentNullException("Tier0Id cannot be null"); }
            if (PrefixListId == null) { throw new System.ArgumentNullException("PrefixListId cannot be null"); }
            StringBuilder ReadPrefixListServiceURL = new StringBuilder("/infra/tier-0s/{tier-0-id}/prefix-lists/{prefix-list-id}");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Get
            };
            ReadPrefixListServiceURL.Replace("{tier-0-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(Tier0Id, System.Globalization.CultureInfo.InvariantCulture)));
            ReadPrefixListServiceURL.Replace("{prefix-list-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(PrefixListId, System.Globalization.CultureInfo.InvariantCulture)));
            request.Resource = ReadPrefixListServiceURL.ToString();
            RestResponse<NSXTPrefixListType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTPrefixListType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Get operation to " + ReadPrefixListServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task PatchPrefixList(string Tier0Id, string PrefixListId, NSXTPrefixListType PrefixList)
        {
            if (Tier0Id == null) { throw new System.ArgumentNullException("Tier0Id cannot be null"); }
            if (PrefixListId == null) { throw new System.ArgumentNullException("PrefixListId cannot be null"); }
            if (PrefixList == null) { throw new System.ArgumentNullException("PrefixList cannot be null"); }
            StringBuilder PatchPrefixListServiceURL = new StringBuilder("/infra/tier-0s/{tier-0-id}/prefix-lists/{prefix-list-id}");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Patch
            };
            PatchPrefixListServiceURL.Replace("{tier-0-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(Tier0Id, System.Globalization.CultureInfo.InvariantCulture)));
            PatchPrefixListServiceURL.Replace("{prefix-list-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(PrefixListId, System.Globalization.CultureInfo.InvariantCulture)));
            request.AddJsonBody(PrefixList);
            request.Resource = PatchPrefixListServiceURL.ToString();
            RestResponse response = await restClient.ExecuteTaskAsyncWithPolicy(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Patch operation to " + PatchPrefixListServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task DeletePrefixList(string Tier0Id, string PrefixListId)
        {
            if (Tier0Id == null) { throw new System.ArgumentNullException("Tier0Id cannot be null"); }
            if (PrefixListId == null) { throw new System.ArgumentNullException("PrefixListId cannot be null"); }
            StringBuilder DeletePrefixListServiceURL = new StringBuilder("/infra/tier-0s/{tier-0-id}/prefix-lists/{prefix-list-id}");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Delete
            };
            DeletePrefixListServiceURL.Replace("{tier-0-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(Tier0Id, System.Globalization.CultureInfo.InvariantCulture)));
            DeletePrefixListServiceURL.Replace("{prefix-list-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(PrefixListId, System.Globalization.CultureInfo.InvariantCulture)));
            request.Resource = DeletePrefixListServiceURL.ToString();
            RestResponse response = await restClient.ExecuteTaskAsyncWithPolicy(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Delete operation to " + DeletePrefixListServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTTier1ListResultType> ListTier1(string? Cursor = null, bool? IncludeMarkForDeleteObjects = null, string? IncludedFields = null, long? PageSize = null, bool? SortAscending = null, string? SortBy = null)
        {
            StringBuilder ListTier1ServiceURL = new StringBuilder("/infra/tier-1s");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Get
            };
            if (Cursor != null) { request.AddQueryParameter("cursor", Cursor.ToString()); }
            if (IncludeMarkForDeleteObjects != null) { request.AddQueryParameter("include_mark_for_delete_objects", IncludeMarkForDeleteObjects.ToString()); }
            if (IncludedFields != null) { request.AddQueryParameter("included_fields", IncludedFields.ToString()); }
            if (PageSize != null) { request.AddQueryParameter("page_size", PageSize.ToString()); }
            if (SortAscending != null) { request.AddQueryParameter("sort_ascending", SortAscending.ToString()); }
            if (SortBy != null) { request.AddQueryParameter("sort_by", SortBy.ToString()); }
            request.Resource = ListTier1ServiceURL.ToString();
            RestResponse<NSXTTier1ListResultType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTTier1ListResultType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Get operation to " + ListTier1ServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTIpv6NdraProfileListResultType> ListIpv6NdraProfiles(string? Cursor = null, bool? IncludeMarkForDeleteObjects = null, string? IncludedFields = null, long? PageSize = null, bool? SortAscending = null, string? SortBy = null)
        {
            StringBuilder ListIpv6NdraProfilesServiceURL = new StringBuilder("/infra/ipv6-ndra-profiles");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Get
            };
            if (Cursor != null) { request.AddQueryParameter("cursor", Cursor.ToString()); }
            if (IncludeMarkForDeleteObjects != null) { request.AddQueryParameter("include_mark_for_delete_objects", IncludeMarkForDeleteObjects.ToString()); }
            if (IncludedFields != null) { request.AddQueryParameter("included_fields", IncludedFields.ToString()); }
            if (PageSize != null) { request.AddQueryParameter("page_size", PageSize.ToString()); }
            if (SortAscending != null) { request.AddQueryParameter("sort_ascending", SortAscending.ToString()); }
            if (SortBy != null) { request.AddQueryParameter("sort_by", SortBy.ToString()); }
            request.Resource = ListIpv6NdraProfilesServiceURL.ToString();
            RestResponse<NSXTIpv6NdraProfileListResultType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTIpv6NdraProfileListResultType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Get operation to " + ListIpv6NdraProfilesServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTServiceInterfaceListResultType> ListTier1ServiceInterfaces(string Tier1Id, string LocaleServiceId, string? Cursor = null, bool? IncludeMarkForDeleteObjects = null, string? IncludedFields = null, long? PageSize = null, bool? SortAscending = null, string? SortBy = null)
        {
            if (Tier1Id == null) { throw new System.ArgumentNullException("Tier1Id cannot be null"); }
            if (LocaleServiceId == null) { throw new System.ArgumentNullException("LocaleServiceId cannot be null"); }
            StringBuilder ListTier1ServiceInterfacesServiceURL = new StringBuilder("/infra/tier-1s/{tier-1-id}/locale-services/{locale-service-id}/service-interfaces");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Get
            };
            ListTier1ServiceInterfacesServiceURL.Replace("{tier-1-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(Tier1Id, System.Globalization.CultureInfo.InvariantCulture)));
            ListTier1ServiceInterfacesServiceURL.Replace("{locale-service-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(LocaleServiceId, System.Globalization.CultureInfo.InvariantCulture)));
            if (Cursor != null) { request.AddQueryParameter("cursor", Cursor.ToString()); }
            if (IncludeMarkForDeleteObjects != null) { request.AddQueryParameter("include_mark_for_delete_objects", IncludeMarkForDeleteObjects.ToString()); }
            if (IncludedFields != null) { request.AddQueryParameter("included_fields", IncludedFields.ToString()); }
            if (PageSize != null) { request.AddQueryParameter("page_size", PageSize.ToString()); }
            if (SortAscending != null) { request.AddQueryParameter("sort_ascending", SortAscending.ToString()); }
            if (SortBy != null) { request.AddQueryParameter("sort_by", SortBy.ToString()); }
            request.Resource = ListTier1ServiceInterfacesServiceURL.ToString();
            RestResponse<NSXTServiceInterfaceListResultType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTServiceInterfaceListResultType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Get operation to " + ListTier1ServiceInterfacesServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTEvpnConfigType> CreateOrUpdateEvpnConfig(string Tier0Id, NSXTEvpnConfigType EvpnConfig)
        {
            if (Tier0Id == null) { throw new System.ArgumentNullException("Tier0Id cannot be null"); }
            if (EvpnConfig == null) { throw new System.ArgumentNullException("EvpnConfig cannot be null"); }
            StringBuilder CreateOrUpdateEvpnConfigServiceURL = new StringBuilder("/infra/tier-0s/{tier-0-id}/evpn");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Put
            };
            CreateOrUpdateEvpnConfigServiceURL.Replace("{tier-0-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(Tier0Id, System.Globalization.CultureInfo.InvariantCulture)));
            request.AddJsonBody(EvpnConfig);
            request.Resource = CreateOrUpdateEvpnConfigServiceURL.ToString();
            RestResponse<NSXTEvpnConfigType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTEvpnConfigType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Put operation to " + CreateOrUpdateEvpnConfigServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task PatchEvpnConfig(string Tier0Id, NSXTEvpnConfigType EvpnConfig)
        {
            if (Tier0Id == null) { throw new System.ArgumentNullException("Tier0Id cannot be null"); }
            if (EvpnConfig == null) { throw new System.ArgumentNullException("EvpnConfig cannot be null"); }
            StringBuilder PatchEvpnConfigServiceURL = new StringBuilder("/infra/tier-0s/{tier-0-id}/evpn");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Patch
            };
            PatchEvpnConfigServiceURL.Replace("{tier-0-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(Tier0Id, System.Globalization.CultureInfo.InvariantCulture)));
            request.AddJsonBody(EvpnConfig);
            request.Resource = PatchEvpnConfigServiceURL.ToString();
            RestResponse response = await restClient.ExecuteTaskAsyncWithPolicy(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Patch operation to " + PatchEvpnConfigServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTEvpnConfigType> ReadEvpnConfig(string Tier0Id)
        {
            if (Tier0Id == null) { throw new System.ArgumentNullException("Tier0Id cannot be null"); }
            StringBuilder ReadEvpnConfigServiceURL = new StringBuilder("/infra/tier-0s/{tier-0-id}/evpn");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Get
            };
            ReadEvpnConfigServiceURL.Replace("{tier-0-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(Tier0Id, System.Globalization.CultureInfo.InvariantCulture)));
            request.Resource = ReadEvpnConfigServiceURL.ToString();
            RestResponse<NSXTEvpnConfigType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTEvpnConfigType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Get operation to " + ReadEvpnConfigServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTBfdProfileListResultType> GlobalGlobalInfraListBfdProfile(string? Cursor = null, bool? IncludeMarkForDeleteObjects = null, string? IncludedFields = null, long? PageSize = null, bool? SortAscending = null, string? SortBy = null)
        {
            StringBuilder GlobalInfraListBfdProfileServiceURL = new StringBuilder("/global-infra/bfd-profiles");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Get
            };
            if (Cursor != null) { request.AddQueryParameter("cursor", Cursor.ToString()); }
            if (IncludeMarkForDeleteObjects != null) { request.AddQueryParameter("include_mark_for_delete_objects", IncludeMarkForDeleteObjects.ToString()); }
            if (IncludedFields != null) { request.AddQueryParameter("included_fields", IncludedFields.ToString()); }
            if (PageSize != null) { request.AddQueryParameter("page_size", PageSize.ToString()); }
            if (SortAscending != null) { request.AddQueryParameter("sort_ascending", SortAscending.ToString()); }
            if (SortBy != null) { request.AddQueryParameter("sort_by", SortBy.ToString()); }
            request.Resource = GlobalInfraListBfdProfileServiceURL.ToString();
            RestResponse<NSXTBfdProfileListResultType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTBfdProfileListResultType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Get operation to " + GlobalInfraListBfdProfileServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTDhcpRelayConfigType> CreateOrReplaceDhcpRelayConfig(string DhcpRelayConfigId, NSXTDhcpRelayConfigType DhcpRelayConfig)
        {
            if (DhcpRelayConfigId == null) { throw new System.ArgumentNullException("DhcpRelayConfigId cannot be null"); }
            if (DhcpRelayConfig == null) { throw new System.ArgumentNullException("DhcpRelayConfig cannot be null"); }
            StringBuilder CreateOrReplaceDhcpRelayConfigServiceURL = new StringBuilder("/infra/dhcp-relay-configs/{dhcp-relay-config-id}");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Put
            };
            CreateOrReplaceDhcpRelayConfigServiceURL.Replace("{dhcp-relay-config-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(DhcpRelayConfigId, System.Globalization.CultureInfo.InvariantCulture)));
            request.AddJsonBody(DhcpRelayConfig);
            request.Resource = CreateOrReplaceDhcpRelayConfigServiceURL.ToString();
            RestResponse<NSXTDhcpRelayConfigType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTDhcpRelayConfigType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Put operation to " + CreateOrReplaceDhcpRelayConfigServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task DeleteDhcpRelayConfig(string DhcpRelayConfigId)
        {
            if (DhcpRelayConfigId == null) { throw new System.ArgumentNullException("DhcpRelayConfigId cannot be null"); }
            StringBuilder DeleteDhcpRelayConfigServiceURL = new StringBuilder("/infra/dhcp-relay-configs/{dhcp-relay-config-id}");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Delete
            };
            DeleteDhcpRelayConfigServiceURL.Replace("{dhcp-relay-config-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(DhcpRelayConfigId, System.Globalization.CultureInfo.InvariantCulture)));
            request.Resource = DeleteDhcpRelayConfigServiceURL.ToString();
            RestResponse response = await restClient.ExecuteTaskAsyncWithPolicy(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Delete operation to " + DeleteDhcpRelayConfigServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTDhcpRelayConfigType> ReadDhcpRelayConfig(string DhcpRelayConfigId)
        {
            if (DhcpRelayConfigId == null) { throw new System.ArgumentNullException("DhcpRelayConfigId cannot be null"); }
            StringBuilder ReadDhcpRelayConfigServiceURL = new StringBuilder("/infra/dhcp-relay-configs/{dhcp-relay-config-id}");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Get
            };
            ReadDhcpRelayConfigServiceURL.Replace("{dhcp-relay-config-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(DhcpRelayConfigId, System.Globalization.CultureInfo.InvariantCulture)));
            request.Resource = ReadDhcpRelayConfigServiceURL.ToString();
            RestResponse<NSXTDhcpRelayConfigType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTDhcpRelayConfigType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Get operation to " + ReadDhcpRelayConfigServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task PatchDhcpRelayConfig(string DhcpRelayConfigId, NSXTDhcpRelayConfigType DhcpRelayConfig)
        {
            if (DhcpRelayConfigId == null) { throw new System.ArgumentNullException("DhcpRelayConfigId cannot be null"); }
            if (DhcpRelayConfig == null) { throw new System.ArgumentNullException("DhcpRelayConfig cannot be null"); }
            StringBuilder PatchDhcpRelayConfigServiceURL = new StringBuilder("/infra/dhcp-relay-configs/{dhcp-relay-config-id}");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Patch
            };
            PatchDhcpRelayConfigServiceURL.Replace("{dhcp-relay-config-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(DhcpRelayConfigId, System.Globalization.CultureInfo.InvariantCulture)));
            request.AddJsonBody(DhcpRelayConfig);
            request.Resource = PatchDhcpRelayConfigServiceURL.ToString();
            RestResponse response = await restClient.ExecuteTaskAsyncWithPolicy(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Patch operation to " + PatchDhcpRelayConfigServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTBfdProfileType> UpdateBfdProfile(string BfdProfileId, NSXTBfdProfileType BfdProfile, bool? Override = null)
        {
            if (BfdProfileId == null) { throw new System.ArgumentNullException("BfdProfileId cannot be null"); }
            if (BfdProfile == null) { throw new System.ArgumentNullException("BfdProfile cannot be null"); }
            StringBuilder UpdateBfdProfileServiceURL = new StringBuilder("/infra/bfd-profiles/{bfd-profile-id}");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Put
            };
            UpdateBfdProfileServiceURL.Replace("{bfd-profile-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(BfdProfileId, System.Globalization.CultureInfo.InvariantCulture)));
            request.AddJsonBody(BfdProfile);
            if (Override != null) { request.AddQueryParameter("override", Override.ToString()); }
            request.Resource = UpdateBfdProfileServiceURL.ToString();
            RestResponse<NSXTBfdProfileType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTBfdProfileType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Put operation to " + UpdateBfdProfileServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task PatchBfdProfile(string BfdProfileId, NSXTBfdProfileType BfdProfile, bool? Override = null)
        {
            if (BfdProfileId == null) { throw new System.ArgumentNullException("BfdProfileId cannot be null"); }
            if (BfdProfile == null) { throw new System.ArgumentNullException("BfdProfile cannot be null"); }
            StringBuilder PatchBfdProfileServiceURL = new StringBuilder("/infra/bfd-profiles/{bfd-profile-id}");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Patch
            };
            PatchBfdProfileServiceURL.Replace("{bfd-profile-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(BfdProfileId, System.Globalization.CultureInfo.InvariantCulture)));
            request.AddJsonBody(BfdProfile);
            if (Override != null) { request.AddQueryParameter("override", Override.ToString()); }
            request.Resource = PatchBfdProfileServiceURL.ToString();
            RestResponse response = await restClient.ExecuteTaskAsyncWithPolicy(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Patch operation to " + PatchBfdProfileServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTBfdProfileType> ReadBfdProfile(string BfdProfileId)
        {
            if (BfdProfileId == null) { throw new System.ArgumentNullException("BfdProfileId cannot be null"); }
            StringBuilder ReadBfdProfileServiceURL = new StringBuilder("/infra/bfd-profiles/{bfd-profile-id}");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Get
            };
            ReadBfdProfileServiceURL.Replace("{bfd-profile-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(BfdProfileId, System.Globalization.CultureInfo.InvariantCulture)));
            request.Resource = ReadBfdProfileServiceURL.ToString();
            RestResponse<NSXTBfdProfileType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTBfdProfileType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Get operation to " + ReadBfdProfileServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task DeleteBfdProfile(string BfdProfileId, bool? Override = null)
        {
            if (BfdProfileId == null) { throw new System.ArgumentNullException("BfdProfileId cannot be null"); }
            StringBuilder DeleteBfdProfileServiceURL = new StringBuilder("/infra/bfd-profiles/{bfd-profile-id}");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Delete
            };
            DeleteBfdProfileServiceURL.Replace("{bfd-profile-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(BfdProfileId, System.Globalization.CultureInfo.InvariantCulture)));
            if (Override != null) { request.AddQueryParameter("override", Override.ToString()); }
            request.Resource = DeleteBfdProfileServiceURL.ToString();
            RestResponse response = await restClient.ExecuteTaskAsyncWithPolicy(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Delete operation to " + DeleteBfdProfileServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTTier1InterfaceListResultType> GlobalGlobalInfraListTier1Interfaces(string Tier1Id, string LocaleServicesId, string? Cursor = null, bool? IncludeMarkForDeleteObjects = null, string? IncludedFields = null, long? PageSize = null, bool? SortAscending = null, string? SortBy = null)
        {
            if (Tier1Id == null) { throw new System.ArgumentNullException("Tier1Id cannot be null"); }
            if (LocaleServicesId == null) { throw new System.ArgumentNullException("LocaleServicesId cannot be null"); }
            StringBuilder GlobalInfraListTier1InterfacesServiceURL = new StringBuilder("/global-infra/tier-1s/{tier-1-id}/locale-services/{locale-services-id}/interfaces");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Get
            };
            GlobalInfraListTier1InterfacesServiceURL.Replace("{tier-1-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(Tier1Id, System.Globalization.CultureInfo.InvariantCulture)));
            GlobalInfraListTier1InterfacesServiceURL.Replace("{locale-services-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(LocaleServicesId, System.Globalization.CultureInfo.InvariantCulture)));
            if (Cursor != null) { request.AddQueryParameter("cursor", Cursor.ToString()); }
            if (IncludeMarkForDeleteObjects != null) { request.AddQueryParameter("include_mark_for_delete_objects", IncludeMarkForDeleteObjects.ToString()); }
            if (IncludedFields != null) { request.AddQueryParameter("included_fields", IncludedFields.ToString()); }
            if (PageSize != null) { request.AddQueryParameter("page_size", PageSize.ToString()); }
            if (SortAscending != null) { request.AddQueryParameter("sort_ascending", SortAscending.ToString()); }
            if (SortBy != null) { request.AddQueryParameter("sort_by", SortBy.ToString()); }
            request.Resource = GlobalInfraListTier1InterfacesServiceURL.ToString();
            RestResponse<NSXTTier1InterfaceListResultType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTTier1InterfaceListResultType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Get operation to " + GlobalInfraListTier1InterfacesServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTLocaleServicesType> GlobalGlobalInfraReadTier0LocaleServices(string Tier0Id, string LocaleServicesId)
        {
            if (Tier0Id == null) { throw new System.ArgumentNullException("Tier0Id cannot be null"); }
            if (LocaleServicesId == null) { throw new System.ArgumentNullException("LocaleServicesId cannot be null"); }
            StringBuilder GlobalInfraReadTier0LocaleServicesServiceURL = new StringBuilder("/global-infra/tier-0s/{tier-0-id}/locale-services/{locale-services-id}");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Get
            };
            GlobalInfraReadTier0LocaleServicesServiceURL.Replace("{tier-0-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(Tier0Id, System.Globalization.CultureInfo.InvariantCulture)));
            GlobalInfraReadTier0LocaleServicesServiceURL.Replace("{locale-services-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(LocaleServicesId, System.Globalization.CultureInfo.InvariantCulture)));
            request.Resource = GlobalInfraReadTier0LocaleServicesServiceURL.ToString();
            RestResponse<NSXTLocaleServicesType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTLocaleServicesType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Get operation to " + GlobalInfraReadTier0LocaleServicesServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTSegmentPortType> CreateOrReplaceTier1SegmentPort(string Tier1Id, string SegmentId, string PortId, NSXTSegmentPortType SegmentPort)
        {
            if (Tier1Id == null) { throw new System.ArgumentNullException("Tier1Id cannot be null"); }
            if (SegmentId == null) { throw new System.ArgumentNullException("SegmentId cannot be null"); }
            if (PortId == null) { throw new System.ArgumentNullException("PortId cannot be null"); }
            if (SegmentPort == null) { throw new System.ArgumentNullException("SegmentPort cannot be null"); }
            StringBuilder CreateOrReplaceTier1SegmentPortServiceURL = new StringBuilder("/infra/tier-1s/{tier-1-id}/segments/{segment-id}/ports/{port-id}");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Put
            };
            CreateOrReplaceTier1SegmentPortServiceURL.Replace("{tier-1-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(Tier1Id, System.Globalization.CultureInfo.InvariantCulture)));
            CreateOrReplaceTier1SegmentPortServiceURL.Replace("{segment-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(SegmentId, System.Globalization.CultureInfo.InvariantCulture)));
            CreateOrReplaceTier1SegmentPortServiceURL.Replace("{port-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(PortId, System.Globalization.CultureInfo.InvariantCulture)));
            request.AddJsonBody(SegmentPort);
            request.Resource = CreateOrReplaceTier1SegmentPortServiceURL.ToString();
            RestResponse<NSXTSegmentPortType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTSegmentPortType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Put operation to " + CreateOrReplaceTier1SegmentPortServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task DeleteTier1SegmentPort(string Tier1Id, string SegmentId, string PortId)
        {
            if (Tier1Id == null) { throw new System.ArgumentNullException("Tier1Id cannot be null"); }
            if (SegmentId == null) { throw new System.ArgumentNullException("SegmentId cannot be null"); }
            if (PortId == null) { throw new System.ArgumentNullException("PortId cannot be null"); }
            StringBuilder DeleteTier1SegmentPortServiceURL = new StringBuilder("/infra/tier-1s/{tier-1-id}/segments/{segment-id}/ports/{port-id}");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Delete
            };
            DeleteTier1SegmentPortServiceURL.Replace("{tier-1-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(Tier1Id, System.Globalization.CultureInfo.InvariantCulture)));
            DeleteTier1SegmentPortServiceURL.Replace("{segment-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(SegmentId, System.Globalization.CultureInfo.InvariantCulture)));
            DeleteTier1SegmentPortServiceURL.Replace("{port-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(PortId, System.Globalization.CultureInfo.InvariantCulture)));
            request.Resource = DeleteTier1SegmentPortServiceURL.ToString();
            RestResponse response = await restClient.ExecuteTaskAsyncWithPolicy(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Delete operation to " + DeleteTier1SegmentPortServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task PatchTier1SegmentPort(string Tier1Id, string SegmentId, string PortId, NSXTSegmentPortType SegmentPort)
        {
            if (Tier1Id == null) { throw new System.ArgumentNullException("Tier1Id cannot be null"); }
            if (SegmentId == null) { throw new System.ArgumentNullException("SegmentId cannot be null"); }
            if (PortId == null) { throw new System.ArgumentNullException("PortId cannot be null"); }
            if (SegmentPort == null) { throw new System.ArgumentNullException("SegmentPort cannot be null"); }
            StringBuilder PatchTier1SegmentPortServiceURL = new StringBuilder("/infra/tier-1s/{tier-1-id}/segments/{segment-id}/ports/{port-id}");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Patch
            };
            PatchTier1SegmentPortServiceURL.Replace("{tier-1-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(Tier1Id, System.Globalization.CultureInfo.InvariantCulture)));
            PatchTier1SegmentPortServiceURL.Replace("{segment-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(SegmentId, System.Globalization.CultureInfo.InvariantCulture)));
            PatchTier1SegmentPortServiceURL.Replace("{port-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(PortId, System.Globalization.CultureInfo.InvariantCulture)));
            request.AddJsonBody(SegmentPort);
            request.Resource = PatchTier1SegmentPortServiceURL.ToString();
            RestResponse response = await restClient.ExecuteTaskAsyncWithPolicy(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Patch operation to " + PatchTier1SegmentPortServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTSegmentPortType> GetTier1SegmentPort(string Tier1Id, string SegmentId, string PortId)
        {
            if (Tier1Id == null) { throw new System.ArgumentNullException("Tier1Id cannot be null"); }
            if (SegmentId == null) { throw new System.ArgumentNullException("SegmentId cannot be null"); }
            if (PortId == null) { throw new System.ArgumentNullException("PortId cannot be null"); }
            StringBuilder GetTier1SegmentPortServiceURL = new StringBuilder("/infra/tier-1s/{tier-1-id}/segments/{segment-id}/ports/{port-id}");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Get
            };
            GetTier1SegmentPortServiceURL.Replace("{tier-1-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(Tier1Id, System.Globalization.CultureInfo.InvariantCulture)));
            GetTier1SegmentPortServiceURL.Replace("{segment-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(SegmentId, System.Globalization.CultureInfo.InvariantCulture)));
            GetTier1SegmentPortServiceURL.Replace("{port-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(PortId, System.Globalization.CultureInfo.InvariantCulture)));
            request.Resource = GetTier1SegmentPortServiceURL.ToString();
            RestResponse<NSXTSegmentPortType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTSegmentPortType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Get operation to " + GetTier1SegmentPortServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTGatewayQosProfileListResultType> ListGatewayQosProfiles(string? Cursor = null, bool? IncludeMarkForDeleteObjects = null, string? IncludedFields = null, long? PageSize = null, bool? SortAscending = null, string? SortBy = null)
        {
            StringBuilder ListGatewayQosProfilesServiceURL = new StringBuilder("/infra/gateway-qos-profiles");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Get
            };
            if (Cursor != null) { request.AddQueryParameter("cursor", Cursor.ToString()); }
            if (IncludeMarkForDeleteObjects != null) { request.AddQueryParameter("include_mark_for_delete_objects", IncludeMarkForDeleteObjects.ToString()); }
            if (IncludedFields != null) { request.AddQueryParameter("included_fields", IncludedFields.ToString()); }
            if (PageSize != null) { request.AddQueryParameter("page_size", PageSize.ToString()); }
            if (SortAscending != null) { request.AddQueryParameter("sort_ascending", SortAscending.ToString()); }
            if (SortBy != null) { request.AddQueryParameter("sort_by", SortBy.ToString()); }
            request.Resource = ListGatewayQosProfilesServiceURL.ToString();
            RestResponse<NSXTGatewayQosProfileListResultType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTGatewayQosProfileListResultType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Get operation to " + ListGatewayQosProfilesServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTTier0ListResultType> ListTier0s(string? Cursor = null, bool? IncludeMarkForDeleteObjects = null, string? IncludedFields = null, long? PageSize = null, bool? SortAscending = null, string? SortBy = null)
        {
            StringBuilder ListTier0sServiceURL = new StringBuilder("/infra/tier-0s");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Get
            };
            if (Cursor != null) { request.AddQueryParameter("cursor", Cursor.ToString()); }
            if (IncludeMarkForDeleteObjects != null) { request.AddQueryParameter("include_mark_for_delete_objects", IncludeMarkForDeleteObjects.ToString()); }
            if (IncludedFields != null) { request.AddQueryParameter("included_fields", IncludedFields.ToString()); }
            if (PageSize != null) { request.AddQueryParameter("page_size", PageSize.ToString()); }
            if (SortAscending != null) { request.AddQueryParameter("sort_ascending", SortAscending.ToString()); }
            if (SortBy != null) { request.AddQueryParameter("sort_by", SortBy.ToString()); }
            request.Resource = ListTier0sServiceURL.ToString();
            RestResponse<NSXTTier0ListResultType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTTier0ListResultType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Get operation to " + ListTier0sServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTBgpRoutingConfigType> CreateOrReplaceBgpRoutingConfig(string Tier0Id, string LocaleServiceId, NSXTBgpRoutingConfigType BgpRoutingConfig, bool? Override = null)
        {
            if (Tier0Id == null) { throw new System.ArgumentNullException("Tier0Id cannot be null"); }
            if (LocaleServiceId == null) { throw new System.ArgumentNullException("LocaleServiceId cannot be null"); }
            if (BgpRoutingConfig == null) { throw new System.ArgumentNullException("BgpRoutingConfig cannot be null"); }
            StringBuilder CreateOrReplaceBgpRoutingConfigServiceURL = new StringBuilder("/infra/tier-0s/{tier-0-id}/locale-services/{locale-service-id}/bgp");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Put
            };
            CreateOrReplaceBgpRoutingConfigServiceURL.Replace("{tier-0-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(Tier0Id, System.Globalization.CultureInfo.InvariantCulture)));
            CreateOrReplaceBgpRoutingConfigServiceURL.Replace("{locale-service-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(LocaleServiceId, System.Globalization.CultureInfo.InvariantCulture)));
            request.AddJsonBody(BgpRoutingConfig);
            if (Override != null) { request.AddQueryParameter("override", Override.ToString()); }
            request.Resource = CreateOrReplaceBgpRoutingConfigServiceURL.ToString();
            RestResponse<NSXTBgpRoutingConfigType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTBgpRoutingConfigType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Put operation to " + CreateOrReplaceBgpRoutingConfigServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTBgpRoutingConfigType> ReadBgpRoutingConfig(string Tier0Id, string LocaleServiceId)
        {
            if (Tier0Id == null) { throw new System.ArgumentNullException("Tier0Id cannot be null"); }
            if (LocaleServiceId == null) { throw new System.ArgumentNullException("LocaleServiceId cannot be null"); }
            StringBuilder ReadBgpRoutingConfigServiceURL = new StringBuilder("/infra/tier-0s/{tier-0-id}/locale-services/{locale-service-id}/bgp");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Get
            };
            ReadBgpRoutingConfigServiceURL.Replace("{tier-0-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(Tier0Id, System.Globalization.CultureInfo.InvariantCulture)));
            ReadBgpRoutingConfigServiceURL.Replace("{locale-service-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(LocaleServiceId, System.Globalization.CultureInfo.InvariantCulture)));
            request.Resource = ReadBgpRoutingConfigServiceURL.ToString();
            RestResponse<NSXTBgpRoutingConfigType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTBgpRoutingConfigType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Get operation to " + ReadBgpRoutingConfigServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task PatchBgpRoutingConfig(string Tier0Id, string LocaleServiceId, NSXTBgpRoutingConfigType BgpRoutingConfig, bool? Override = null)
        {
            if (Tier0Id == null) { throw new System.ArgumentNullException("Tier0Id cannot be null"); }
            if (LocaleServiceId == null) { throw new System.ArgumentNullException("LocaleServiceId cannot be null"); }
            if (BgpRoutingConfig == null) { throw new System.ArgumentNullException("BgpRoutingConfig cannot be null"); }
            StringBuilder PatchBgpRoutingConfigServiceURL = new StringBuilder("/infra/tier-0s/{tier-0-id}/locale-services/{locale-service-id}/bgp");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Patch
            };
            PatchBgpRoutingConfigServiceURL.Replace("{tier-0-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(Tier0Id, System.Globalization.CultureInfo.InvariantCulture)));
            PatchBgpRoutingConfigServiceURL.Replace("{locale-service-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(LocaleServiceId, System.Globalization.CultureInfo.InvariantCulture)));
            request.AddJsonBody(BgpRoutingConfig);
            if (Override != null) { request.AddQueryParameter("override", Override.ToString()); }
            request.Resource = PatchBgpRoutingConfigServiceURL.ToString();
            RestResponse response = await restClient.ExecuteTaskAsyncWithPolicy(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Patch operation to " + PatchBgpRoutingConfigServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTAntreaTraceflowStatusType> ReadAntreaTraceflowStatus(string TraceflowId, string? EnforcementPointPath = null)
        {
            if (TraceflowId == null) { throw new System.ArgumentNullException("TraceflowId cannot be null"); }
            StringBuilder ReadAntreaTraceflowStatusServiceURL = new StringBuilder("/infra/antrea/traceflows/{traceflow-id}/status");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Get
            };
            ReadAntreaTraceflowStatusServiceURL.Replace("{traceflow-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(TraceflowId, System.Globalization.CultureInfo.InvariantCulture)));
            if (EnforcementPointPath != null) { request.AddQueryParameter("enforcement_point_path", EnforcementPointPath.ToString()); }
            request.Resource = ReadAntreaTraceflowStatusServiceURL.ToString();
            RestResponse<NSXTAntreaTraceflowStatusType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTAntreaTraceflowStatusType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Get operation to " + ReadAntreaTraceflowStatusServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTStaticRoutesListResultType> GlobalGlobalInfraListTier0StaticRoutes(string Tier0Id, string? Cursor = null, bool? IncludeMarkForDeleteObjects = null, string? IncludedFields = null, long? PageSize = null, bool? SortAscending = null, string? SortBy = null)
        {
            if (Tier0Id == null) { throw new System.ArgumentNullException("Tier0Id cannot be null"); }
            StringBuilder GlobalInfraListTier0StaticRoutesServiceURL = new StringBuilder("/global-infra/tier-0s/{tier-0-id}/static-routes");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Get
            };
            GlobalInfraListTier0StaticRoutesServiceURL.Replace("{tier-0-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(Tier0Id, System.Globalization.CultureInfo.InvariantCulture)));
            if (Cursor != null) { request.AddQueryParameter("cursor", Cursor.ToString()); }
            if (IncludeMarkForDeleteObjects != null) { request.AddQueryParameter("include_mark_for_delete_objects", IncludeMarkForDeleteObjects.ToString()); }
            if (IncludedFields != null) { request.AddQueryParameter("included_fields", IncludedFields.ToString()); }
            if (PageSize != null) { request.AddQueryParameter("page_size", PageSize.ToString()); }
            if (SortAscending != null) { request.AddQueryParameter("sort_ascending", SortAscending.ToString()); }
            if (SortBy != null) { request.AddQueryParameter("sort_by", SortBy.ToString()); }
            request.Resource = GlobalInfraListTier0StaticRoutesServiceURL.ToString();
            RestResponse<NSXTStaticRoutesListResultType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTStaticRoutesListResultType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Get operation to " + GlobalInfraListTier0StaticRoutesServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTStaticRouteBfdPeerListResultType> ListStaticRouteBfdPeer(string Tier0Id, string? Cursor = null, bool? IncludeMarkForDeleteObjects = null, string? IncludedFields = null, long? PageSize = null, bool? SortAscending = null, string? SortBy = null)
        {
            if (Tier0Id == null) { throw new System.ArgumentNullException("Tier0Id cannot be null"); }
            StringBuilder ListStaticRouteBfdPeerServiceURL = new StringBuilder("/infra/tier-0s/{tier-0-id}/static-routes/bfd-peers");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Get
            };
            ListStaticRouteBfdPeerServiceURL.Replace("{tier-0-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(Tier0Id, System.Globalization.CultureInfo.InvariantCulture)));
            if (Cursor != null) { request.AddQueryParameter("cursor", Cursor.ToString()); }
            if (IncludeMarkForDeleteObjects != null) { request.AddQueryParameter("include_mark_for_delete_objects", IncludeMarkForDeleteObjects.ToString()); }
            if (IncludedFields != null) { request.AddQueryParameter("included_fields", IncludedFields.ToString()); }
            if (PageSize != null) { request.AddQueryParameter("page_size", PageSize.ToString()); }
            if (SortAscending != null) { request.AddQueryParameter("sort_ascending", SortAscending.ToString()); }
            if (SortBy != null) { request.AddQueryParameter("sort_by", SortBy.ToString()); }
            request.Resource = ListStaticRouteBfdPeerServiceURL.ToString();
            RestResponse<NSXTStaticRouteBfdPeerListResultType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTStaticRouteBfdPeerListResultType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Get operation to " + ListStaticRouteBfdPeerServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTSegmentPortListResultType> GlobalGlobalInfraListTier1SegmentPorts(string Tier1Id, string SegmentId, string? Cursor = null, bool? IncludeMarkForDeleteObjects = null, string? IncludedFields = null, long? PageSize = null, bool? SortAscending = null, string? SortBy = null)
        {
            if (Tier1Id == null) { throw new System.ArgumentNullException("Tier1Id cannot be null"); }
            if (SegmentId == null) { throw new System.ArgumentNullException("SegmentId cannot be null"); }
            StringBuilder GlobalInfraListTier1SegmentPortsServiceURL = new StringBuilder("/global-infra/tier-1s/{tier-1-id}/segments/{segment-id}/ports");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Get
            };
            GlobalInfraListTier1SegmentPortsServiceURL.Replace("{tier-1-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(Tier1Id, System.Globalization.CultureInfo.InvariantCulture)));
            GlobalInfraListTier1SegmentPortsServiceURL.Replace("{segment-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(SegmentId, System.Globalization.CultureInfo.InvariantCulture)));
            if (Cursor != null) { request.AddQueryParameter("cursor", Cursor.ToString()); }
            if (IncludeMarkForDeleteObjects != null) { request.AddQueryParameter("include_mark_for_delete_objects", IncludeMarkForDeleteObjects.ToString()); }
            if (IncludedFields != null) { request.AddQueryParameter("included_fields", IncludedFields.ToString()); }
            if (PageSize != null) { request.AddQueryParameter("page_size", PageSize.ToString()); }
            if (SortAscending != null) { request.AddQueryParameter("sort_ascending", SortAscending.ToString()); }
            if (SortBy != null) { request.AddQueryParameter("sort_by", SortBy.ToString()); }
            request.Resource = GlobalInfraListTier1SegmentPortsServiceURL.ToString();
            RestResponse<NSXTSegmentPortListResultType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTSegmentPortListResultType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Get operation to " + GlobalInfraListTier1SegmentPortsServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTServiceInterfaceType> GlobalGlobalInfraReadTier1ServiceInterface(string Tier1Id, string LocaleServiceId, string InterfaceId)
        {
            if (Tier1Id == null) { throw new System.ArgumentNullException("Tier1Id cannot be null"); }
            if (LocaleServiceId == null) { throw new System.ArgumentNullException("LocaleServiceId cannot be null"); }
            if (InterfaceId == null) { throw new System.ArgumentNullException("InterfaceId cannot be null"); }
            StringBuilder GlobalInfraReadTier1ServiceInterfaceServiceURL = new StringBuilder("/global-infra/tier-1s/{tier-1-id}/locale-services/{locale-service-id}/service-interfaces/{interface-id}");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Get
            };
            GlobalInfraReadTier1ServiceInterfaceServiceURL.Replace("{tier-1-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(Tier1Id, System.Globalization.CultureInfo.InvariantCulture)));
            GlobalInfraReadTier1ServiceInterfaceServiceURL.Replace("{locale-service-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(LocaleServiceId, System.Globalization.CultureInfo.InvariantCulture)));
            GlobalInfraReadTier1ServiceInterfaceServiceURL.Replace("{interface-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(InterfaceId, System.Globalization.CultureInfo.InvariantCulture)));
            request.Resource = GlobalInfraReadTier1ServiceInterfaceServiceURL.ToString();
            RestResponse<NSXTServiceInterfaceType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTServiceInterfaceType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Get operation to " + GlobalInfraReadTier1ServiceInterfaceServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTEvpnTenantConfigListResultType> ListEvpnTenantConfig(string? Cursor = null, bool? IncludeMarkForDeleteObjects = null, string? IncludedFields = null, long? PageSize = null, bool? SortAscending = null, string? SortBy = null)
        {
            StringBuilder ListEvpnTenantConfigServiceURL = new StringBuilder("/infra/evpn-tenant-configs");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Get
            };
            if (Cursor != null) { request.AddQueryParameter("cursor", Cursor.ToString()); }
            if (IncludeMarkForDeleteObjects != null) { request.AddQueryParameter("include_mark_for_delete_objects", IncludeMarkForDeleteObjects.ToString()); }
            if (IncludedFields != null) { request.AddQueryParameter("included_fields", IncludedFields.ToString()); }
            if (PageSize != null) { request.AddQueryParameter("page_size", PageSize.ToString()); }
            if (SortAscending != null) { request.AddQueryParameter("sort_ascending", SortAscending.ToString()); }
            if (SortBy != null) { request.AddQueryParameter("sort_by", SortBy.ToString()); }
            request.Resource = ListEvpnTenantConfigServiceURL.ToString();
            RestResponse<NSXTEvpnTenantConfigListResultType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTEvpnTenantConfigListResultType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Get operation to " + ListEvpnTenantConfigServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTBgpNeighborConfigListResultType> GlobalGlobalInfraListBgpNeighborConfigs(string Tier0Id, string LocaleServiceId, string? Cursor = null, bool? IncludeMarkForDeleteObjects = null, string? IncludedFields = null, long? PageSize = null, bool? SortAscending = null, string? SortBy = null)
        {
            if (Tier0Id == null) { throw new System.ArgumentNullException("Tier0Id cannot be null"); }
            if (LocaleServiceId == null) { throw new System.ArgumentNullException("LocaleServiceId cannot be null"); }
            StringBuilder GlobalInfraListBgpNeighborConfigsServiceURL = new StringBuilder("/global-infra/tier-0s/{tier-0-id}/locale-services/{locale-service-id}/bgp/neighbors");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Get
            };
            GlobalInfraListBgpNeighborConfigsServiceURL.Replace("{tier-0-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(Tier0Id, System.Globalization.CultureInfo.InvariantCulture)));
            GlobalInfraListBgpNeighborConfigsServiceURL.Replace("{locale-service-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(LocaleServiceId, System.Globalization.CultureInfo.InvariantCulture)));
            if (Cursor != null) { request.AddQueryParameter("cursor", Cursor.ToString()); }
            if (IncludeMarkForDeleteObjects != null) { request.AddQueryParameter("include_mark_for_delete_objects", IncludeMarkForDeleteObjects.ToString()); }
            if (IncludedFields != null) { request.AddQueryParameter("included_fields", IncludedFields.ToString()); }
            if (PageSize != null) { request.AddQueryParameter("page_size", PageSize.ToString()); }
            if (SortAscending != null) { request.AddQueryParameter("sort_ascending", SortAscending.ToString()); }
            if (SortBy != null) { request.AddQueryParameter("sort_by", SortBy.ToString()); }
            request.Resource = GlobalInfraListBgpNeighborConfigsServiceURL.ToString();
            RestResponse<NSXTBgpNeighborConfigListResultType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTBgpNeighborConfigListResultType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Get operation to " + GlobalInfraListBgpNeighborConfigsServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTLocaleServicesType> CreateOrReplaceTier1LocaleServices(string Tier1Id, string LocaleServicesId, NSXTLocaleServicesType LocaleServices)
        {
            if (Tier1Id == null) { throw new System.ArgumentNullException("Tier1Id cannot be null"); }
            if (LocaleServicesId == null) { throw new System.ArgumentNullException("LocaleServicesId cannot be null"); }
            if (LocaleServices == null) { throw new System.ArgumentNullException("LocaleServices cannot be null"); }
            StringBuilder CreateOrReplaceTier1LocaleServicesServiceURL = new StringBuilder("/infra/tier-1s/{tier-1-id}/locale-services/{locale-services-id}");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Put
            };
            CreateOrReplaceTier1LocaleServicesServiceURL.Replace("{tier-1-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(Tier1Id, System.Globalization.CultureInfo.InvariantCulture)));
            CreateOrReplaceTier1LocaleServicesServiceURL.Replace("{locale-services-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(LocaleServicesId, System.Globalization.CultureInfo.InvariantCulture)));
            request.AddJsonBody(LocaleServices);
            request.Resource = CreateOrReplaceTier1LocaleServicesServiceURL.ToString();
            RestResponse<NSXTLocaleServicesType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTLocaleServicesType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Put operation to " + CreateOrReplaceTier1LocaleServicesServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTLocaleServicesType> ReadTier1LocaleServices(string Tier1Id, string LocaleServicesId)
        {
            if (Tier1Id == null) { throw new System.ArgumentNullException("Tier1Id cannot be null"); }
            if (LocaleServicesId == null) { throw new System.ArgumentNullException("LocaleServicesId cannot be null"); }
            StringBuilder ReadTier1LocaleServicesServiceURL = new StringBuilder("/infra/tier-1s/{tier-1-id}/locale-services/{locale-services-id}");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Get
            };
            ReadTier1LocaleServicesServiceURL.Replace("{tier-1-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(Tier1Id, System.Globalization.CultureInfo.InvariantCulture)));
            ReadTier1LocaleServicesServiceURL.Replace("{locale-services-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(LocaleServicesId, System.Globalization.CultureInfo.InvariantCulture)));
            request.Resource = ReadTier1LocaleServicesServiceURL.ToString();
            RestResponse<NSXTLocaleServicesType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTLocaleServicesType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Get operation to " + ReadTier1LocaleServicesServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task DeleteTier1LocaleServices(string Tier1Id, string LocaleServicesId)
        {
            if (Tier1Id == null) { throw new System.ArgumentNullException("Tier1Id cannot be null"); }
            if (LocaleServicesId == null) { throw new System.ArgumentNullException("LocaleServicesId cannot be null"); }
            StringBuilder DeleteTier1LocaleServicesServiceURL = new StringBuilder("/infra/tier-1s/{tier-1-id}/locale-services/{locale-services-id}");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Delete
            };
            DeleteTier1LocaleServicesServiceURL.Replace("{tier-1-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(Tier1Id, System.Globalization.CultureInfo.InvariantCulture)));
            DeleteTier1LocaleServicesServiceURL.Replace("{locale-services-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(LocaleServicesId, System.Globalization.CultureInfo.InvariantCulture)));
            request.Resource = DeleteTier1LocaleServicesServiceURL.ToString();
            RestResponse response = await restClient.ExecuteTaskAsyncWithPolicy(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Delete operation to " + DeleteTier1LocaleServicesServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task PatchTier1LocaleServices(string Tier1Id, string LocaleServicesId, NSXTLocaleServicesType LocaleServices)
        {
            if (Tier1Id == null) { throw new System.ArgumentNullException("Tier1Id cannot be null"); }
            if (LocaleServicesId == null) { throw new System.ArgumentNullException("LocaleServicesId cannot be null"); }
            if (LocaleServices == null) { throw new System.ArgumentNullException("LocaleServices cannot be null"); }
            StringBuilder PatchTier1LocaleServicesServiceURL = new StringBuilder("/infra/tier-1s/{tier-1-id}/locale-services/{locale-services-id}");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Patch
            };
            PatchTier1LocaleServicesServiceURL.Replace("{tier-1-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(Tier1Id, System.Globalization.CultureInfo.InvariantCulture)));
            PatchTier1LocaleServicesServiceURL.Replace("{locale-services-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(LocaleServicesId, System.Globalization.CultureInfo.InvariantCulture)));
            request.AddJsonBody(LocaleServices);
            request.Resource = PatchTier1LocaleServicesServiceURL.ToString();
            RestResponse response = await restClient.ExecuteTaskAsyncWithPolicy(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Patch operation to " + PatchTier1LocaleServicesServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTTraceflowType> ReadTraceflowStatus(string TraceflowId, string? EnforcementPointPath = null)
        {
            if (TraceflowId == null) { throw new System.ArgumentNullException("TraceflowId cannot be null"); }
            StringBuilder ReadTraceflowStatusServiceURL = new StringBuilder("/infra/traceflows/{traceflow-id}/status");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Get
            };
            ReadTraceflowStatusServiceURL.Replace("{traceflow-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(TraceflowId, System.Globalization.CultureInfo.InvariantCulture)));
            if (EnforcementPointPath != null) { request.AddQueryParameter("enforcement_point_path", EnforcementPointPath.ToString()); }
            request.Resource = ReadTraceflowStatusServiceURL.ToString();
            RestResponse<NSXTTraceflowType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTTraceflowType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Get operation to " + ReadTraceflowStatusServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTTier1InterfaceType> GlobalGlobalInfraReadTier1Interface(string Tier1Id, string LocaleServicesId, string InterfaceId)
        {
            if (Tier1Id == null) { throw new System.ArgumentNullException("Tier1Id cannot be null"); }
            if (LocaleServicesId == null) { throw new System.ArgumentNullException("LocaleServicesId cannot be null"); }
            if (InterfaceId == null) { throw new System.ArgumentNullException("InterfaceId cannot be null"); }
            StringBuilder GlobalInfraReadTier1InterfaceServiceURL = new StringBuilder("/global-infra/tier-1s/{tier-1-id}/locale-services/{locale-services-id}/interfaces/{interface-id}");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Get
            };
            GlobalInfraReadTier1InterfaceServiceURL.Replace("{tier-1-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(Tier1Id, System.Globalization.CultureInfo.InvariantCulture)));
            GlobalInfraReadTier1InterfaceServiceURL.Replace("{locale-services-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(LocaleServicesId, System.Globalization.CultureInfo.InvariantCulture)));
            GlobalInfraReadTier1InterfaceServiceURL.Replace("{interface-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(InterfaceId, System.Globalization.CultureInfo.InvariantCulture)));
            request.Resource = GlobalInfraReadTier1InterfaceServiceURL.ToString();
            RestResponse<NSXTTier1InterfaceType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTTier1InterfaceType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Get operation to " + GlobalInfraReadTier1InterfaceServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task Tier0GatewayReprocess(string Tier0Id, string? EnforcementPointPath = null)
        {
            if (Tier0Id == null) { throw new System.ArgumentNullException("Tier0Id cannot be null"); }
            StringBuilder Tier0GatewayReprocessServiceURL = new StringBuilder("/infra/tier-0s/{tier-0-id}?action=reprocess");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Post
            };
            Tier0GatewayReprocessServiceURL.Replace("{tier-0-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(Tier0Id, System.Globalization.CultureInfo.InvariantCulture)));
            if (EnforcementPointPath != null) { request.AddQueryParameter("enforcement_point_path", EnforcementPointPath.ToString()); }
            request.Resource = Tier0GatewayReprocessServiceURL.ToString();
            RestResponse response = await restClient.ExecuteTaskAsyncWithPolicy(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Post operation to " + Tier0GatewayReprocessServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTSegmentListResultType> GlobalGlobalInfraListAllInfraSegments(string? Cursor = null, bool? IncludeMarkForDeleteObjects = null, string? IncludedFields = null, long? PageSize = null, string? SegmentType = null, bool? SortAscending = null, string? SortBy = null)
        {
            StringBuilder GlobalInfraListAllInfraSegmentsServiceURL = new StringBuilder("/global-infra/segments");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Get
            };
            if (Cursor != null) { request.AddQueryParameter("cursor", Cursor.ToString()); }
            if (IncludeMarkForDeleteObjects != null) { request.AddQueryParameter("include_mark_for_delete_objects", IncludeMarkForDeleteObjects.ToString()); }
            if (IncludedFields != null) { request.AddQueryParameter("included_fields", IncludedFields.ToString()); }
            if (PageSize != null) { request.AddQueryParameter("page_size", PageSize.ToString()); }
            if (SegmentType != null) { request.AddQueryParameter("segment_type", SegmentType.ToString()); }
            if (SortAscending != null) { request.AddQueryParameter("sort_ascending", SortAscending.ToString()); }
            if (SortBy != null) { request.AddQueryParameter("sort_by", SortBy.ToString()); }
            request.Resource = GlobalInfraListAllInfraSegmentsServiceURL.ToString();
            RestResponse<NSXTSegmentListResultType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTSegmentListResultType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Get operation to " + GlobalInfraListAllInfraSegmentsServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTBgpNeighborConfigListResultType> ListBgpNeighborConfigs(string Tier0Id, string LocaleServiceId, string? Cursor = null, bool? IncludeMarkForDeleteObjects = null, string? IncludedFields = null, long? PageSize = null, bool? SortAscending = null, string? SortBy = null)
        {
            if (Tier0Id == null) { throw new System.ArgumentNullException("Tier0Id cannot be null"); }
            if (LocaleServiceId == null) { throw new System.ArgumentNullException("LocaleServiceId cannot be null"); }
            StringBuilder ListBgpNeighborConfigsServiceURL = new StringBuilder("/infra/tier-0s/{tier-0-id}/locale-services/{locale-service-id}/bgp/neighbors");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Get
            };
            ListBgpNeighborConfigsServiceURL.Replace("{tier-0-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(Tier0Id, System.Globalization.CultureInfo.InvariantCulture)));
            ListBgpNeighborConfigsServiceURL.Replace("{locale-service-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(LocaleServiceId, System.Globalization.CultureInfo.InvariantCulture)));
            if (Cursor != null) { request.AddQueryParameter("cursor", Cursor.ToString()); }
            if (IncludeMarkForDeleteObjects != null) { request.AddQueryParameter("include_mark_for_delete_objects", IncludeMarkForDeleteObjects.ToString()); }
            if (IncludedFields != null) { request.AddQueryParameter("included_fields", IncludedFields.ToString()); }
            if (PageSize != null) { request.AddQueryParameter("page_size", PageSize.ToString()); }
            if (SortAscending != null) { request.AddQueryParameter("sort_ascending", SortAscending.ToString()); }
            if (SortBy != null) { request.AddQueryParameter("sort_by", SortBy.ToString()); }
            request.Resource = ListBgpNeighborConfigsServiceURL.ToString();
            RestResponse<NSXTBgpNeighborConfigListResultType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTBgpNeighborConfigListResultType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Get operation to " + ListBgpNeighborConfigsServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTTier0InterfaceType> CreateOrReplaceTier0Interface(string Tier0Id, string LocaleServiceId, string InterfaceId, NSXTTier0InterfaceType Tier0Interface, bool? Override = null)
        {
            if (Tier0Id == null) { throw new System.ArgumentNullException("Tier0Id cannot be null"); }
            if (LocaleServiceId == null) { throw new System.ArgumentNullException("LocaleServiceId cannot be null"); }
            if (InterfaceId == null) { throw new System.ArgumentNullException("InterfaceId cannot be null"); }
            if (Tier0Interface == null) { throw new System.ArgumentNullException("Tier0Interface cannot be null"); }
            StringBuilder CreateOrReplaceTier0InterfaceServiceURL = new StringBuilder("/infra/tier-0s/{tier-0-id}/locale-services/{locale-service-id}/interfaces/{interface-id}");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Put
            };
            CreateOrReplaceTier0InterfaceServiceURL.Replace("{tier-0-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(Tier0Id, System.Globalization.CultureInfo.InvariantCulture)));
            CreateOrReplaceTier0InterfaceServiceURL.Replace("{locale-service-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(LocaleServiceId, System.Globalization.CultureInfo.InvariantCulture)));
            CreateOrReplaceTier0InterfaceServiceURL.Replace("{interface-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(InterfaceId, System.Globalization.CultureInfo.InvariantCulture)));
            request.AddJsonBody(Tier0Interface);
            if (Override != null) { request.AddQueryParameter("override", Override.ToString()); }
            request.Resource = CreateOrReplaceTier0InterfaceServiceURL.ToString();
            RestResponse<NSXTTier0InterfaceType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTTier0InterfaceType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Put operation to " + CreateOrReplaceTier0InterfaceServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task DeleteTier0Interface(string Tier0Id, string LocaleServiceId, string InterfaceId, bool? Override = null)
        {
            if (Tier0Id == null) { throw new System.ArgumentNullException("Tier0Id cannot be null"); }
            if (LocaleServiceId == null) { throw new System.ArgumentNullException("LocaleServiceId cannot be null"); }
            if (InterfaceId == null) { throw new System.ArgumentNullException("InterfaceId cannot be null"); }
            StringBuilder DeleteTier0InterfaceServiceURL = new StringBuilder("/infra/tier-0s/{tier-0-id}/locale-services/{locale-service-id}/interfaces/{interface-id}");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Delete
            };
            DeleteTier0InterfaceServiceURL.Replace("{tier-0-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(Tier0Id, System.Globalization.CultureInfo.InvariantCulture)));
            DeleteTier0InterfaceServiceURL.Replace("{locale-service-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(LocaleServiceId, System.Globalization.CultureInfo.InvariantCulture)));
            DeleteTier0InterfaceServiceURL.Replace("{interface-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(InterfaceId, System.Globalization.CultureInfo.InvariantCulture)));
            if (Override != null) { request.AddQueryParameter("override", Override.ToString()); }
            request.Resource = DeleteTier0InterfaceServiceURL.ToString();
            RestResponse response = await restClient.ExecuteTaskAsyncWithPolicy(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Delete operation to " + DeleteTier0InterfaceServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTTier0InterfaceType> ReadTier0Interface(string Tier0Id, string LocaleServiceId, string InterfaceId)
        {
            if (Tier0Id == null) { throw new System.ArgumentNullException("Tier0Id cannot be null"); }
            if (LocaleServiceId == null) { throw new System.ArgumentNullException("LocaleServiceId cannot be null"); }
            if (InterfaceId == null) { throw new System.ArgumentNullException("InterfaceId cannot be null"); }
            StringBuilder ReadTier0InterfaceServiceURL = new StringBuilder("/infra/tier-0s/{tier-0-id}/locale-services/{locale-service-id}/interfaces/{interface-id}");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Get
            };
            ReadTier0InterfaceServiceURL.Replace("{tier-0-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(Tier0Id, System.Globalization.CultureInfo.InvariantCulture)));
            ReadTier0InterfaceServiceURL.Replace("{locale-service-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(LocaleServiceId, System.Globalization.CultureInfo.InvariantCulture)));
            ReadTier0InterfaceServiceURL.Replace("{interface-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(InterfaceId, System.Globalization.CultureInfo.InvariantCulture)));
            request.Resource = ReadTier0InterfaceServiceURL.ToString();
            RestResponse<NSXTTier0InterfaceType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTTier0InterfaceType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Get operation to " + ReadTier0InterfaceServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task PatchTier0Interface(string Tier0Id, string LocaleServiceId, string InterfaceId, NSXTTier0InterfaceType Tier0Interface, bool? Override = null)
        {
            if (Tier0Id == null) { throw new System.ArgumentNullException("Tier0Id cannot be null"); }
            if (LocaleServiceId == null) { throw new System.ArgumentNullException("LocaleServiceId cannot be null"); }
            if (InterfaceId == null) { throw new System.ArgumentNullException("InterfaceId cannot be null"); }
            if (Tier0Interface == null) { throw new System.ArgumentNullException("Tier0Interface cannot be null"); }
            StringBuilder PatchTier0InterfaceServiceURL = new StringBuilder("/infra/tier-0s/{tier-0-id}/locale-services/{locale-service-id}/interfaces/{interface-id}");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Patch
            };
            PatchTier0InterfaceServiceURL.Replace("{tier-0-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(Tier0Id, System.Globalization.CultureInfo.InvariantCulture)));
            PatchTier0InterfaceServiceURL.Replace("{locale-service-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(LocaleServiceId, System.Globalization.CultureInfo.InvariantCulture)));
            PatchTier0InterfaceServiceURL.Replace("{interface-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(InterfaceId, System.Globalization.CultureInfo.InvariantCulture)));
            request.AddJsonBody(Tier0Interface);
            if (Override != null) { request.AddQueryParameter("override", Override.ToString()); }
            request.Resource = PatchTier0InterfaceServiceURL.ToString();
            RestResponse response = await restClient.ExecuteTaskAsyncWithPolicy(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Patch operation to " + PatchTier0InterfaceServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTLocaleServicesListResultType> ListTier0LocaleServices(string Tier0Id, string? Cursor = null, bool? IncludeMarkForDeleteObjects = null, string? IncludedFields = null, long? PageSize = null, bool? SortAscending = null, string? SortBy = null)
        {
            if (Tier0Id == null) { throw new System.ArgumentNullException("Tier0Id cannot be null"); }
            StringBuilder ListTier0LocaleServicesServiceURL = new StringBuilder("/infra/tier-0s/{tier-0-id}/locale-services");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Get
            };
            ListTier0LocaleServicesServiceURL.Replace("{tier-0-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(Tier0Id, System.Globalization.CultureInfo.InvariantCulture)));
            if (Cursor != null) { request.AddQueryParameter("cursor", Cursor.ToString()); }
            if (IncludeMarkForDeleteObjects != null) { request.AddQueryParameter("include_mark_for_delete_objects", IncludeMarkForDeleteObjects.ToString()); }
            if (IncludedFields != null) { request.AddQueryParameter("included_fields", IncludedFields.ToString()); }
            if (PageSize != null) { request.AddQueryParameter("page_size", PageSize.ToString()); }
            if (SortAscending != null) { request.AddQueryParameter("sort_ascending", SortAscending.ToString()); }
            if (SortBy != null) { request.AddQueryParameter("sort_by", SortBy.ToString()); }
            request.Resource = ListTier0LocaleServicesServiceURL.ToString();
            RestResponse<NSXTLocaleServicesListResultType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTLocaleServicesListResultType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Get operation to " + ListTier0LocaleServicesServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTStaticRoutesType> GlobalGlobalInfraReadTier1StaticRoutes(string Tier1Id, string RouteId)
        {
            if (Tier1Id == null) { throw new System.ArgumentNullException("Tier1Id cannot be null"); }
            if (RouteId == null) { throw new System.ArgumentNullException("RouteId cannot be null"); }
            StringBuilder GlobalInfraReadTier1StaticRoutesServiceURL = new StringBuilder("/global-infra/tier-1s/{tier-1-id}/static-routes/{route-id}");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Get
            };
            GlobalInfraReadTier1StaticRoutesServiceURL.Replace("{tier-1-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(Tier1Id, System.Globalization.CultureInfo.InvariantCulture)));
            GlobalInfraReadTier1StaticRoutesServiceURL.Replace("{route-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(RouteId, System.Globalization.CultureInfo.InvariantCulture)));
            request.Resource = GlobalInfraReadTier1StaticRoutesServiceURL.ToString();
            RestResponse<NSXTStaticRoutesType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTStaticRoutesType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Get operation to " + GlobalInfraReadTier1StaticRoutesServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTTier0Type> GlobalGlobalInfraReadTier0(string Tier0Id)
        {
            if (Tier0Id == null) { throw new System.ArgumentNullException("Tier0Id cannot be null"); }
            StringBuilder GlobalInfraReadTier0ServiceURL = new StringBuilder("/global-infra/tier-0s/{tier-0-id}");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Get
            };
            GlobalInfraReadTier0ServiceURL.Replace("{tier-0-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(Tier0Id, System.Globalization.CultureInfo.InvariantCulture)));
            request.Resource = GlobalInfraReadTier0ServiceURL.ToString();
            RestResponse<NSXTTier0Type> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTTier0Type>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Get operation to " + GlobalInfraReadTier0ServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTGatewayQosProfileType> CreateOrReplaceGatewayQosProfile(string QosProfileId, NSXTGatewayQosProfileType GatewayQosProfile, bool? Override = null)
        {
            if (QosProfileId == null) { throw new System.ArgumentNullException("QosProfileId cannot be null"); }
            if (GatewayQosProfile == null) { throw new System.ArgumentNullException("GatewayQosProfile cannot be null"); }
            StringBuilder CreateOrReplaceGatewayQosProfileServiceURL = new StringBuilder("/infra/gateway-qos-profiles/{qos-profile-id}");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Put
            };
            CreateOrReplaceGatewayQosProfileServiceURL.Replace("{qos-profile-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(QosProfileId, System.Globalization.CultureInfo.InvariantCulture)));
            request.AddJsonBody(GatewayQosProfile);
            if (Override != null) { request.AddQueryParameter("override", Override.ToString()); }
            request.Resource = CreateOrReplaceGatewayQosProfileServiceURL.ToString();
            RestResponse<NSXTGatewayQosProfileType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTGatewayQosProfileType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Put operation to " + CreateOrReplaceGatewayQosProfileServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task PatchGatewayQosProfile(string QosProfileId, NSXTGatewayQosProfileType GatewayQosProfile, bool? Override = null)
        {
            if (QosProfileId == null) { throw new System.ArgumentNullException("QosProfileId cannot be null"); }
            if (GatewayQosProfile == null) { throw new System.ArgumentNullException("GatewayQosProfile cannot be null"); }
            StringBuilder PatchGatewayQosProfileServiceURL = new StringBuilder("/infra/gateway-qos-profiles/{qos-profile-id}");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Patch
            };
            PatchGatewayQosProfileServiceURL.Replace("{qos-profile-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(QosProfileId, System.Globalization.CultureInfo.InvariantCulture)));
            request.AddJsonBody(GatewayQosProfile);
            if (Override != null) { request.AddQueryParameter("override", Override.ToString()); }
            request.Resource = PatchGatewayQosProfileServiceURL.ToString();
            RestResponse response = await restClient.ExecuteTaskAsyncWithPolicy(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Patch operation to " + PatchGatewayQosProfileServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task DeleteGatewayQosProfile(string QosProfileId, bool? Override = null)
        {
            if (QosProfileId == null) { throw new System.ArgumentNullException("QosProfileId cannot be null"); }
            StringBuilder DeleteGatewayQosProfileServiceURL = new StringBuilder("/infra/gateway-qos-profiles/{qos-profile-id}");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Delete
            };
            DeleteGatewayQosProfileServiceURL.Replace("{qos-profile-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(QosProfileId, System.Globalization.CultureInfo.InvariantCulture)));
            if (Override != null) { request.AddQueryParameter("override", Override.ToString()); }
            request.Resource = DeleteGatewayQosProfileServiceURL.ToString();
            RestResponse response = await restClient.ExecuteTaskAsyncWithPolicy(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Delete operation to " + DeleteGatewayQosProfileServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTGatewayQosProfileType> ReadGatewayQosProfile(string QosProfileId)
        {
            if (QosProfileId == null) { throw new System.ArgumentNullException("QosProfileId cannot be null"); }
            StringBuilder ReadGatewayQosProfileServiceURL = new StringBuilder("/infra/gateway-qos-profiles/{qos-profile-id}");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Get
            };
            ReadGatewayQosProfileServiceURL.Replace("{qos-profile-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(QosProfileId, System.Globalization.CultureInfo.InvariantCulture)));
            request.Resource = ReadGatewayQosProfileServiceURL.ToString();
            RestResponse<NSXTGatewayQosProfileType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTGatewayQosProfileType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Get operation to " + ReadGatewayQosProfileServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTTier1InterfaceListResultType> ListTier1Interfaces(string Tier1Id, string LocaleServicesId, string? Cursor = null, bool? IncludeMarkForDeleteObjects = null, string? IncludedFields = null, long? PageSize = null, bool? SortAscending = null, string? SortBy = null)
        {
            if (Tier1Id == null) { throw new System.ArgumentNullException("Tier1Id cannot be null"); }
            if (LocaleServicesId == null) { throw new System.ArgumentNullException("LocaleServicesId cannot be null"); }
            StringBuilder ListTier1InterfacesServiceURL = new StringBuilder("/infra/tier-1s/{tier-1-id}/locale-services/{locale-services-id}/interfaces");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Get
            };
            ListTier1InterfacesServiceURL.Replace("{tier-1-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(Tier1Id, System.Globalization.CultureInfo.InvariantCulture)));
            ListTier1InterfacesServiceURL.Replace("{locale-services-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(LocaleServicesId, System.Globalization.CultureInfo.InvariantCulture)));
            if (Cursor != null) { request.AddQueryParameter("cursor", Cursor.ToString()); }
            if (IncludeMarkForDeleteObjects != null) { request.AddQueryParameter("include_mark_for_delete_objects", IncludeMarkForDeleteObjects.ToString()); }
            if (IncludedFields != null) { request.AddQueryParameter("included_fields", IncludedFields.ToString()); }
            if (PageSize != null) { request.AddQueryParameter("page_size", PageSize.ToString()); }
            if (SortAscending != null) { request.AddQueryParameter("sort_ascending", SortAscending.ToString()); }
            if (SortBy != null) { request.AddQueryParameter("sort_by", SortBy.ToString()); }
            request.Resource = ListTier1InterfacesServiceURL.ToString();
            RestResponse<NSXTTier1InterfaceListResultType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTTier1InterfaceListResultType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Get operation to " + ListTier1InterfacesServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTDhcpStaticBindingConfigType> CreateOrReplaceInfraSegmentDhcpStaticBinding(string SegmentId, string BindingId, NSXTDhcpStaticBindingConfigType DhcpStaticBindingConfig)
        {
            if (SegmentId == null) { throw new System.ArgumentNullException("SegmentId cannot be null"); }
            if (BindingId == null) { throw new System.ArgumentNullException("BindingId cannot be null"); }
            if (DhcpStaticBindingConfig == null) { throw new System.ArgumentNullException("DhcpStaticBindingConfig cannot be null"); }
            StringBuilder CreateOrReplaceInfraSegmentDhcpStaticBindingServiceURL = new StringBuilder("/infra/segments/{segment-id}/dhcp-static-binding-configs/{binding-id}");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Put
            };
            CreateOrReplaceInfraSegmentDhcpStaticBindingServiceURL.Replace("{segment-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(SegmentId, System.Globalization.CultureInfo.InvariantCulture)));
            CreateOrReplaceInfraSegmentDhcpStaticBindingServiceURL.Replace("{binding-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(BindingId, System.Globalization.CultureInfo.InvariantCulture)));
            request.AddJsonBody(DhcpStaticBindingConfig);
            request.Resource = CreateOrReplaceInfraSegmentDhcpStaticBindingServiceURL.ToString();
            RestResponse<NSXTDhcpStaticBindingConfigType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTDhcpStaticBindingConfigType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Put operation to " + CreateOrReplaceInfraSegmentDhcpStaticBindingServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTDhcpStaticBindingConfigType> ReadInfraSegmentDhcpStaticBinding(string SegmentId, string BindingId)
        {
            if (SegmentId == null) { throw new System.ArgumentNullException("SegmentId cannot be null"); }
            if (BindingId == null) { throw new System.ArgumentNullException("BindingId cannot be null"); }
            StringBuilder ReadInfraSegmentDhcpStaticBindingServiceURL = new StringBuilder("/infra/segments/{segment-id}/dhcp-static-binding-configs/{binding-id}");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Get
            };
            ReadInfraSegmentDhcpStaticBindingServiceURL.Replace("{segment-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(SegmentId, System.Globalization.CultureInfo.InvariantCulture)));
            ReadInfraSegmentDhcpStaticBindingServiceURL.Replace("{binding-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(BindingId, System.Globalization.CultureInfo.InvariantCulture)));
            request.Resource = ReadInfraSegmentDhcpStaticBindingServiceURL.ToString();
            RestResponse<NSXTDhcpStaticBindingConfigType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTDhcpStaticBindingConfigType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Get operation to " + ReadInfraSegmentDhcpStaticBindingServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task DeleteInfraSegmentDhcpStaticBinding(string SegmentId, string BindingId)
        {
            if (SegmentId == null) { throw new System.ArgumentNullException("SegmentId cannot be null"); }
            if (BindingId == null) { throw new System.ArgumentNullException("BindingId cannot be null"); }
            StringBuilder DeleteInfraSegmentDhcpStaticBindingServiceURL = new StringBuilder("/infra/segments/{segment-id}/dhcp-static-binding-configs/{binding-id}");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Delete
            };
            DeleteInfraSegmentDhcpStaticBindingServiceURL.Replace("{segment-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(SegmentId, System.Globalization.CultureInfo.InvariantCulture)));
            DeleteInfraSegmentDhcpStaticBindingServiceURL.Replace("{binding-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(BindingId, System.Globalization.CultureInfo.InvariantCulture)));
            request.Resource = DeleteInfraSegmentDhcpStaticBindingServiceURL.ToString();
            RestResponse response = await restClient.ExecuteTaskAsyncWithPolicy(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Delete operation to " + DeleteInfraSegmentDhcpStaticBindingServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task PatchInfraSegmentDhcpStaticBinding(string SegmentId, string BindingId, NSXTDhcpStaticBindingConfigType DhcpStaticBindingConfig)
        {
            if (SegmentId == null) { throw new System.ArgumentNullException("SegmentId cannot be null"); }
            if (BindingId == null) { throw new System.ArgumentNullException("BindingId cannot be null"); }
            if (DhcpStaticBindingConfig == null) { throw new System.ArgumentNullException("DhcpStaticBindingConfig cannot be null"); }
            StringBuilder PatchInfraSegmentDhcpStaticBindingServiceURL = new StringBuilder("/infra/segments/{segment-id}/dhcp-static-binding-configs/{binding-id}");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Patch
            };
            PatchInfraSegmentDhcpStaticBindingServiceURL.Replace("{segment-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(SegmentId, System.Globalization.CultureInfo.InvariantCulture)));
            PatchInfraSegmentDhcpStaticBindingServiceURL.Replace("{binding-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(BindingId, System.Globalization.CultureInfo.InvariantCulture)));
            request.AddJsonBody(DhcpStaticBindingConfig);
            request.Resource = PatchInfraSegmentDhcpStaticBindingServiceURL.ToString();
            RestResponse response = await restClient.ExecuteTaskAsyncWithPolicy(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Patch operation to " + PatchInfraSegmentDhcpStaticBindingServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTCommunityListType> CreateOrReplaceCommunityList(string Tier0Id, string CommunityListId, NSXTCommunityListType CommunityList)
        {
            if (Tier0Id == null) { throw new System.ArgumentNullException("Tier0Id cannot be null"); }
            if (CommunityListId == null) { throw new System.ArgumentNullException("CommunityListId cannot be null"); }
            if (CommunityList == null) { throw new System.ArgumentNullException("CommunityList cannot be null"); }
            StringBuilder CreateOrReplaceCommunityListServiceURL = new StringBuilder("/infra/tier-0s/{tier-0-id}/community-lists/{community-list-id}");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Put
            };
            CreateOrReplaceCommunityListServiceURL.Replace("{tier-0-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(Tier0Id, System.Globalization.CultureInfo.InvariantCulture)));
            CreateOrReplaceCommunityListServiceURL.Replace("{community-list-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(CommunityListId, System.Globalization.CultureInfo.InvariantCulture)));
            request.AddJsonBody(CommunityList);
            request.Resource = CreateOrReplaceCommunityListServiceURL.ToString();
            RestResponse<NSXTCommunityListType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTCommunityListType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Put operation to " + CreateOrReplaceCommunityListServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task DeleteCommunityList(string Tier0Id, string CommunityListId)
        {
            if (Tier0Id == null) { throw new System.ArgumentNullException("Tier0Id cannot be null"); }
            if (CommunityListId == null) { throw new System.ArgumentNullException("CommunityListId cannot be null"); }
            StringBuilder DeleteCommunityListServiceURL = new StringBuilder("/infra/tier-0s/{tier-0-id}/community-lists/{community-list-id}");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Delete
            };
            DeleteCommunityListServiceURL.Replace("{tier-0-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(Tier0Id, System.Globalization.CultureInfo.InvariantCulture)));
            DeleteCommunityListServiceURL.Replace("{community-list-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(CommunityListId, System.Globalization.CultureInfo.InvariantCulture)));
            request.Resource = DeleteCommunityListServiceURL.ToString();
            RestResponse response = await restClient.ExecuteTaskAsyncWithPolicy(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Delete operation to " + DeleteCommunityListServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task PatchCommunityList(string Tier0Id, string CommunityListId, NSXTCommunityListType CommunityList)
        {
            if (Tier0Id == null) { throw new System.ArgumentNullException("Tier0Id cannot be null"); }
            if (CommunityListId == null) { throw new System.ArgumentNullException("CommunityListId cannot be null"); }
            if (CommunityList == null) { throw new System.ArgumentNullException("CommunityList cannot be null"); }
            StringBuilder PatchCommunityListServiceURL = new StringBuilder("/infra/tier-0s/{tier-0-id}/community-lists/{community-list-id}");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Patch
            };
            PatchCommunityListServiceURL.Replace("{tier-0-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(Tier0Id, System.Globalization.CultureInfo.InvariantCulture)));
            PatchCommunityListServiceURL.Replace("{community-list-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(CommunityListId, System.Globalization.CultureInfo.InvariantCulture)));
            request.AddJsonBody(CommunityList);
            request.Resource = PatchCommunityListServiceURL.ToString();
            RestResponse response = await restClient.ExecuteTaskAsyncWithPolicy(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Patch operation to " + PatchCommunityListServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTCommunityListType> ReadCommunityList(string Tier0Id, string CommunityListId)
        {
            if (Tier0Id == null) { throw new System.ArgumentNullException("Tier0Id cannot be null"); }
            if (CommunityListId == null) { throw new System.ArgumentNullException("CommunityListId cannot be null"); }
            StringBuilder ReadCommunityListServiceURL = new StringBuilder("/infra/tier-0s/{tier-0-id}/community-lists/{community-list-id}");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Get
            };
            ReadCommunityListServiceURL.Replace("{tier-0-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(Tier0Id, System.Globalization.CultureInfo.InvariantCulture)));
            ReadCommunityListServiceURL.Replace("{community-list-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(CommunityListId, System.Globalization.CultureInfo.InvariantCulture)));
            request.Resource = ReadCommunityListServiceURL.ToString();
            RestResponse<NSXTCommunityListType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTCommunityListType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Get operation to " + ReadCommunityListServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTStaticRoutesType> CreateOrReplaceTier1StaticRoutes(string Tier1Id, string RouteId, NSXTStaticRoutesType StaticRoutes)
        {
            if (Tier1Id == null) { throw new System.ArgumentNullException("Tier1Id cannot be null"); }
            if (RouteId == null) { throw new System.ArgumentNullException("RouteId cannot be null"); }
            if (StaticRoutes == null) { throw new System.ArgumentNullException("StaticRoutes cannot be null"); }
            StringBuilder CreateOrReplaceTier1StaticRoutesServiceURL = new StringBuilder("/infra/tier-1s/{tier-1-id}/static-routes/{route-id}");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Put
            };
            CreateOrReplaceTier1StaticRoutesServiceURL.Replace("{tier-1-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(Tier1Id, System.Globalization.CultureInfo.InvariantCulture)));
            CreateOrReplaceTier1StaticRoutesServiceURL.Replace("{route-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(RouteId, System.Globalization.CultureInfo.InvariantCulture)));
            request.AddJsonBody(StaticRoutes);
            request.Resource = CreateOrReplaceTier1StaticRoutesServiceURL.ToString();
            RestResponse<NSXTStaticRoutesType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTStaticRoutesType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Put operation to " + CreateOrReplaceTier1StaticRoutesServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTStaticRoutesType> ReadTier1StaticRoutes(string Tier1Id, string RouteId)
        {
            if (Tier1Id == null) { throw new System.ArgumentNullException("Tier1Id cannot be null"); }
            if (RouteId == null) { throw new System.ArgumentNullException("RouteId cannot be null"); }
            StringBuilder ReadTier1StaticRoutesServiceURL = new StringBuilder("/infra/tier-1s/{tier-1-id}/static-routes/{route-id}");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Get
            };
            ReadTier1StaticRoutesServiceURL.Replace("{tier-1-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(Tier1Id, System.Globalization.CultureInfo.InvariantCulture)));
            ReadTier1StaticRoutesServiceURL.Replace("{route-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(RouteId, System.Globalization.CultureInfo.InvariantCulture)));
            request.Resource = ReadTier1StaticRoutesServiceURL.ToString();
            RestResponse<NSXTStaticRoutesType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTStaticRoutesType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Get operation to " + ReadTier1StaticRoutesServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task PatchTier1StaticRoutes(string Tier1Id, string RouteId, NSXTStaticRoutesType StaticRoutes)
        {
            if (Tier1Id == null) { throw new System.ArgumentNullException("Tier1Id cannot be null"); }
            if (RouteId == null) { throw new System.ArgumentNullException("RouteId cannot be null"); }
            if (StaticRoutes == null) { throw new System.ArgumentNullException("StaticRoutes cannot be null"); }
            StringBuilder PatchTier1StaticRoutesServiceURL = new StringBuilder("/infra/tier-1s/{tier-1-id}/static-routes/{route-id}");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Patch
            };
            PatchTier1StaticRoutesServiceURL.Replace("{tier-1-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(Tier1Id, System.Globalization.CultureInfo.InvariantCulture)));
            PatchTier1StaticRoutesServiceURL.Replace("{route-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(RouteId, System.Globalization.CultureInfo.InvariantCulture)));
            request.AddJsonBody(StaticRoutes);
            request.Resource = PatchTier1StaticRoutesServiceURL.ToString();
            RestResponse response = await restClient.ExecuteTaskAsyncWithPolicy(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Patch operation to " + PatchTier1StaticRoutesServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task DeleteTier1StaticRoutes(string Tier1Id, string RouteId)
        {
            if (Tier1Id == null) { throw new System.ArgumentNullException("Tier1Id cannot be null"); }
            if (RouteId == null) { throw new System.ArgumentNullException("RouteId cannot be null"); }
            StringBuilder DeleteTier1StaticRoutesServiceURL = new StringBuilder("/infra/tier-1s/{tier-1-id}/static-routes/{route-id}");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Delete
            };
            DeleteTier1StaticRoutesServiceURL.Replace("{tier-1-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(Tier1Id, System.Globalization.CultureInfo.InvariantCulture)));
            DeleteTier1StaticRoutesServiceURL.Replace("{route-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(RouteId, System.Globalization.CultureInfo.InvariantCulture)));
            request.Resource = DeleteTier1StaticRoutesServiceURL.ToString();
            RestResponse response = await restClient.ExecuteTaskAsyncWithPolicy(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Delete operation to " + DeleteTier1StaticRoutesServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTStaticARPConfigType> CreateOrReplaceStaticArpconfig(string Tier1Id, string SegmentId, NSXTStaticARPConfigType StaticArpconfig)
        {
            if (Tier1Id == null) { throw new System.ArgumentNullException("Tier1Id cannot be null"); }
            if (SegmentId == null) { throw new System.ArgumentNullException("SegmentId cannot be null"); }
            if (StaticArpconfig == null) { throw new System.ArgumentNullException("StaticArpconfig cannot be null"); }
            StringBuilder CreateOrReplaceStaticArpconfigServiceURL = new StringBuilder("/infra/tier-1s/{tier-1-id}/segments/{segment-id}/static-arp");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Put
            };
            CreateOrReplaceStaticArpconfigServiceURL.Replace("{tier-1-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(Tier1Id, System.Globalization.CultureInfo.InvariantCulture)));
            CreateOrReplaceStaticArpconfigServiceURL.Replace("{segment-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(SegmentId, System.Globalization.CultureInfo.InvariantCulture)));
            request.AddJsonBody(StaticArpconfig);
            request.Resource = CreateOrReplaceStaticArpconfigServiceURL.ToString();
            RestResponse<NSXTStaticARPConfigType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTStaticARPConfigType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Put operation to " + CreateOrReplaceStaticArpconfigServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task DeleteStaticArpconfig(string Tier1Id, string SegmentId)
        {
            if (Tier1Id == null) { throw new System.ArgumentNullException("Tier1Id cannot be null"); }
            if (SegmentId == null) { throw new System.ArgumentNullException("SegmentId cannot be null"); }
            StringBuilder DeleteStaticArpconfigServiceURL = new StringBuilder("/infra/tier-1s/{tier-1-id}/segments/{segment-id}/static-arp");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Delete
            };
            DeleteStaticArpconfigServiceURL.Replace("{tier-1-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(Tier1Id, System.Globalization.CultureInfo.InvariantCulture)));
            DeleteStaticArpconfigServiceURL.Replace("{segment-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(SegmentId, System.Globalization.CultureInfo.InvariantCulture)));
            request.Resource = DeleteStaticArpconfigServiceURL.ToString();
            RestResponse response = await restClient.ExecuteTaskAsyncWithPolicy(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Delete operation to " + DeleteStaticArpconfigServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTStaticARPConfigType> ReadStaticArpconfig(string Tier1Id, string SegmentId)
        {
            if (Tier1Id == null) { throw new System.ArgumentNullException("Tier1Id cannot be null"); }
            if (SegmentId == null) { throw new System.ArgumentNullException("SegmentId cannot be null"); }
            StringBuilder ReadStaticArpconfigServiceURL = new StringBuilder("/infra/tier-1s/{tier-1-id}/segments/{segment-id}/static-arp");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Get
            };
            ReadStaticArpconfigServiceURL.Replace("{tier-1-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(Tier1Id, System.Globalization.CultureInfo.InvariantCulture)));
            ReadStaticArpconfigServiceURL.Replace("{segment-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(SegmentId, System.Globalization.CultureInfo.InvariantCulture)));
            request.Resource = ReadStaticArpconfigServiceURL.ToString();
            RestResponse<NSXTStaticARPConfigType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTStaticARPConfigType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Get operation to " + ReadStaticArpconfigServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task PatchStaticArpconfig(string Tier1Id, string SegmentId, NSXTStaticARPConfigType StaticArpconfig)
        {
            if (Tier1Id == null) { throw new System.ArgumentNullException("Tier1Id cannot be null"); }
            if (SegmentId == null) { throw new System.ArgumentNullException("SegmentId cannot be null"); }
            if (StaticArpconfig == null) { throw new System.ArgumentNullException("StaticArpconfig cannot be null"); }
            StringBuilder PatchStaticArpconfigServiceURL = new StringBuilder("/infra/tier-1s/{tier-1-id}/segments/{segment-id}/static-arp");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Patch
            };
            PatchStaticArpconfigServiceURL.Replace("{tier-1-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(Tier1Id, System.Globalization.CultureInfo.InvariantCulture)));
            PatchStaticArpconfigServiceURL.Replace("{segment-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(SegmentId, System.Globalization.CultureInfo.InvariantCulture)));
            request.AddJsonBody(StaticArpconfig);
            request.Resource = PatchStaticArpconfigServiceURL.ToString();
            RestResponse response = await restClient.ExecuteTaskAsyncWithPolicy(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Patch operation to " + PatchStaticArpconfigServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTServiceSegmentListResultType> ListServiceSegments(string? Cursor = null, string? IncludedFields = null, long? PageSize = null, bool? SortAscending = null, string? SortBy = null)
        {
            StringBuilder ListServiceSegmentsServiceURL = new StringBuilder("/infra/segments/service-segments");
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
            request.Resource = ListServiceSegmentsServiceURL.ToString();
            RestResponse<NSXTServiceSegmentListResultType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTServiceSegmentListResultType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Get operation to " + ListServiceSegmentsServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTLocaleServicesListResultType> GlobalGlobalInfraListTier1LocaleServices(string Tier1Id, string? Cursor = null, bool? IncludeMarkForDeleteObjects = null, string? IncludedFields = null, long? PageSize = null, bool? SortAscending = null, string? SortBy = null)
        {
            if (Tier1Id == null) { throw new System.ArgumentNullException("Tier1Id cannot be null"); }
            StringBuilder GlobalInfraListTier1LocaleServicesServiceURL = new StringBuilder("/global-infra/tier-1s/{tier-1-id}/locale-services");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Get
            };
            GlobalInfraListTier1LocaleServicesServiceURL.Replace("{tier-1-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(Tier1Id, System.Globalization.CultureInfo.InvariantCulture)));
            if (Cursor != null) { request.AddQueryParameter("cursor", Cursor.ToString()); }
            if (IncludeMarkForDeleteObjects != null) { request.AddQueryParameter("include_mark_for_delete_objects", IncludeMarkForDeleteObjects.ToString()); }
            if (IncludedFields != null) { request.AddQueryParameter("included_fields", IncludedFields.ToString()); }
            if (PageSize != null) { request.AddQueryParameter("page_size", PageSize.ToString()); }
            if (SortAscending != null) { request.AddQueryParameter("sort_ascending", SortAscending.ToString()); }
            if (SortBy != null) { request.AddQueryParameter("sort_by", SortBy.ToString()); }
            request.Resource = GlobalInfraListTier1LocaleServicesServiceURL.ToString();
            RestResponse<NSXTLocaleServicesListResultType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTLocaleServicesListResultType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Get operation to " + GlobalInfraListTier1LocaleServicesServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTStaticRouteBfdPeerType> UpdateStaticRouteBfdPeer(string Tier0Id, string BfdPeerId, NSXTStaticRouteBfdPeerType StaticRouteBfdPeer)
        {
            if (Tier0Id == null) { throw new System.ArgumentNullException("Tier0Id cannot be null"); }
            if (BfdPeerId == null) { throw new System.ArgumentNullException("BfdPeerId cannot be null"); }
            if (StaticRouteBfdPeer == null) { throw new System.ArgumentNullException("StaticRouteBfdPeer cannot be null"); }
            StringBuilder UpdateStaticRouteBfdPeerServiceURL = new StringBuilder("/infra/tier-0s/{tier-0-id}/static-routes/bfd-peers/{bfd-peer-id}");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Put
            };
            UpdateStaticRouteBfdPeerServiceURL.Replace("{tier-0-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(Tier0Id, System.Globalization.CultureInfo.InvariantCulture)));
            UpdateStaticRouteBfdPeerServiceURL.Replace("{bfd-peer-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(BfdPeerId, System.Globalization.CultureInfo.InvariantCulture)));
            request.AddJsonBody(StaticRouteBfdPeer);
            request.Resource = UpdateStaticRouteBfdPeerServiceURL.ToString();
            RestResponse<NSXTStaticRouteBfdPeerType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTStaticRouteBfdPeerType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Put operation to " + UpdateStaticRouteBfdPeerServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task PatchStaticRouteBfdPeer(string Tier0Id, string BfdPeerId, NSXTStaticRouteBfdPeerType StaticRouteBfdPeer)
        {
            if (Tier0Id == null) { throw new System.ArgumentNullException("Tier0Id cannot be null"); }
            if (BfdPeerId == null) { throw new System.ArgumentNullException("BfdPeerId cannot be null"); }
            if (StaticRouteBfdPeer == null) { throw new System.ArgumentNullException("StaticRouteBfdPeer cannot be null"); }
            StringBuilder PatchStaticRouteBfdPeerServiceURL = new StringBuilder("/infra/tier-0s/{tier-0-id}/static-routes/bfd-peers/{bfd-peer-id}");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Patch
            };
            PatchStaticRouteBfdPeerServiceURL.Replace("{tier-0-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(Tier0Id, System.Globalization.CultureInfo.InvariantCulture)));
            PatchStaticRouteBfdPeerServiceURL.Replace("{bfd-peer-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(BfdPeerId, System.Globalization.CultureInfo.InvariantCulture)));
            request.AddJsonBody(StaticRouteBfdPeer);
            request.Resource = PatchStaticRouteBfdPeerServiceURL.ToString();
            RestResponse response = await restClient.ExecuteTaskAsyncWithPolicy(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Patch operation to " + PatchStaticRouteBfdPeerServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task DeleteStaticRouteBfdPeer(string Tier0Id, string BfdPeerId)
        {
            if (Tier0Id == null) { throw new System.ArgumentNullException("Tier0Id cannot be null"); }
            if (BfdPeerId == null) { throw new System.ArgumentNullException("BfdPeerId cannot be null"); }
            StringBuilder DeleteStaticRouteBfdPeerServiceURL = new StringBuilder("/infra/tier-0s/{tier-0-id}/static-routes/bfd-peers/{bfd-peer-id}");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Delete
            };
            DeleteStaticRouteBfdPeerServiceURL.Replace("{tier-0-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(Tier0Id, System.Globalization.CultureInfo.InvariantCulture)));
            DeleteStaticRouteBfdPeerServiceURL.Replace("{bfd-peer-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(BfdPeerId, System.Globalization.CultureInfo.InvariantCulture)));
            request.Resource = DeleteStaticRouteBfdPeerServiceURL.ToString();
            RestResponse response = await restClient.ExecuteTaskAsyncWithPolicy(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Delete operation to " + DeleteStaticRouteBfdPeerServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTStaticRouteBfdPeerType> ReadStaticRouteBfdPeer(string Tier0Id, string BfdPeerId)
        {
            if (Tier0Id == null) { throw new System.ArgumentNullException("Tier0Id cannot be null"); }
            if (BfdPeerId == null) { throw new System.ArgumentNullException("BfdPeerId cannot be null"); }
            StringBuilder ReadStaticRouteBfdPeerServiceURL = new StringBuilder("/infra/tier-0s/{tier-0-id}/static-routes/bfd-peers/{bfd-peer-id}");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Get
            };
            ReadStaticRouteBfdPeerServiceURL.Replace("{tier-0-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(Tier0Id, System.Globalization.CultureInfo.InvariantCulture)));
            ReadStaticRouteBfdPeerServiceURL.Replace("{bfd-peer-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(BfdPeerId, System.Globalization.CultureInfo.InvariantCulture)));
            request.Resource = ReadStaticRouteBfdPeerServiceURL.ToString();
            RestResponse<NSXTStaticRouteBfdPeerType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTStaticRouteBfdPeerType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Get operation to " + ReadStaticRouteBfdPeerServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTDhcpStaticBindingConfigType> GlobalGlobalInfraReadInfraSegmentDhcpStaticBinding(string SegmentId, string BindingId)
        {
            if (SegmentId == null) { throw new System.ArgumentNullException("SegmentId cannot be null"); }
            if (BindingId == null) { throw new System.ArgumentNullException("BindingId cannot be null"); }
            StringBuilder GlobalInfraReadInfraSegmentDhcpStaticBindingServiceURL = new StringBuilder("/global-infra/segments/{segment-id}/dhcp-static-binding-configs/{binding-id}");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Get
            };
            GlobalInfraReadInfraSegmentDhcpStaticBindingServiceURL.Replace("{segment-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(SegmentId, System.Globalization.CultureInfo.InvariantCulture)));
            GlobalInfraReadInfraSegmentDhcpStaticBindingServiceURL.Replace("{binding-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(BindingId, System.Globalization.CultureInfo.InvariantCulture)));
            request.Resource = GlobalInfraReadInfraSegmentDhcpStaticBindingServiceURL.ToString();
            RestResponse<NSXTDhcpStaticBindingConfigType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTDhcpStaticBindingConfigType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Get operation to " + GlobalInfraReadInfraSegmentDhcpStaticBindingServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTVniPoolConfigType> CreateOrUpdateVniPoolConfig(string VniPoolId, NSXTVniPoolConfigType VniPoolConfig)
        {
            if (VniPoolId == null) { throw new System.ArgumentNullException("VniPoolId cannot be null"); }
            if (VniPoolConfig == null) { throw new System.ArgumentNullException("VniPoolConfig cannot be null"); }
            StringBuilder CreateOrUpdateVniPoolConfigServiceURL = new StringBuilder("/infra/vni-pools/{vni-pool-id}");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Put
            };
            CreateOrUpdateVniPoolConfigServiceURL.Replace("{vni-pool-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(VniPoolId, System.Globalization.CultureInfo.InvariantCulture)));
            request.AddJsonBody(VniPoolConfig);
            request.Resource = CreateOrUpdateVniPoolConfigServiceURL.ToString();
            RestResponse<NSXTVniPoolConfigType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTVniPoolConfigType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Put operation to " + CreateOrUpdateVniPoolConfigServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task PatchVniPoolConfig(string VniPoolId, NSXTVniPoolConfigType VniPoolConfig)
        {
            if (VniPoolId == null) { throw new System.ArgumentNullException("VniPoolId cannot be null"); }
            if (VniPoolConfig == null) { throw new System.ArgumentNullException("VniPoolConfig cannot be null"); }
            StringBuilder PatchVniPoolConfigServiceURL = new StringBuilder("/infra/vni-pools/{vni-pool-id}");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Patch
            };
            PatchVniPoolConfigServiceURL.Replace("{vni-pool-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(VniPoolId, System.Globalization.CultureInfo.InvariantCulture)));
            request.AddJsonBody(VniPoolConfig);
            request.Resource = PatchVniPoolConfigServiceURL.ToString();
            RestResponse response = await restClient.ExecuteTaskAsyncWithPolicy(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Patch operation to " + PatchVniPoolConfigServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task DeleteVniPoolConfig(string VniPoolId)
        {
            if (VniPoolId == null) { throw new System.ArgumentNullException("VniPoolId cannot be null"); }
            StringBuilder DeleteVniPoolConfigServiceURL = new StringBuilder("/infra/vni-pools/{vni-pool-id}");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Delete
            };
            DeleteVniPoolConfigServiceURL.Replace("{vni-pool-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(VniPoolId, System.Globalization.CultureInfo.InvariantCulture)));
            request.Resource = DeleteVniPoolConfigServiceURL.ToString();
            RestResponse response = await restClient.ExecuteTaskAsyncWithPolicy(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Delete operation to " + DeleteVniPoolConfigServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTVniPoolConfigType> ReadVniPoolConfig(string VniPoolId)
        {
            if (VniPoolId == null) { throw new System.ArgumentNullException("VniPoolId cannot be null"); }
            StringBuilder ReadVniPoolConfigServiceURL = new StringBuilder("/infra/vni-pools/{vni-pool-id}");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Get
            };
            ReadVniPoolConfigServiceURL.Replace("{vni-pool-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(VniPoolId, System.Globalization.CultureInfo.InvariantCulture)));
            request.Resource = ReadVniPoolConfigServiceURL.ToString();
            RestResponse<NSXTVniPoolConfigType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTVniPoolConfigType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Get operation to " + ReadVniPoolConfigServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTTier0InterfaceType> GlobalGlobalInfraCreateOrReplaceTier0Interface(string Tier0Id, string LocaleServiceId, string InterfaceId, NSXTTier0InterfaceType Tier0Interface, bool? Override = null)
        {
            if (Tier0Id == null) { throw new System.ArgumentNullException("Tier0Id cannot be null"); }
            if (LocaleServiceId == null) { throw new System.ArgumentNullException("LocaleServiceId cannot be null"); }
            if (InterfaceId == null) { throw new System.ArgumentNullException("InterfaceId cannot be null"); }
            if (Tier0Interface == null) { throw new System.ArgumentNullException("Tier0Interface cannot be null"); }
            StringBuilder GlobalInfraCreateOrReplaceTier0InterfaceServiceURL = new StringBuilder("/global-infra/tier-0s/{tier-0-id}/locale-services/{locale-service-id}/interfaces/{interface-id}");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Put
            };
            GlobalInfraCreateOrReplaceTier0InterfaceServiceURL.Replace("{tier-0-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(Tier0Id, System.Globalization.CultureInfo.InvariantCulture)));
            GlobalInfraCreateOrReplaceTier0InterfaceServiceURL.Replace("{locale-service-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(LocaleServiceId, System.Globalization.CultureInfo.InvariantCulture)));
            GlobalInfraCreateOrReplaceTier0InterfaceServiceURL.Replace("{interface-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(InterfaceId, System.Globalization.CultureInfo.InvariantCulture)));
            request.AddJsonBody(Tier0Interface);
            if (Override != null) { request.AddQueryParameter("override", Override.ToString()); }
            request.Resource = GlobalInfraCreateOrReplaceTier0InterfaceServiceURL.ToString();
            RestResponse<NSXTTier0InterfaceType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTTier0InterfaceType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Put operation to " + GlobalInfraCreateOrReplaceTier0InterfaceServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task GlobalGlobalInfraDeleteTier0Interface(string Tier0Id, string LocaleServiceId, string InterfaceId, bool? Override = null)
        {
            if (Tier0Id == null) { throw new System.ArgumentNullException("Tier0Id cannot be null"); }
            if (LocaleServiceId == null) { throw new System.ArgumentNullException("LocaleServiceId cannot be null"); }
            if (InterfaceId == null) { throw new System.ArgumentNullException("InterfaceId cannot be null"); }
            StringBuilder GlobalInfraDeleteTier0InterfaceServiceURL = new StringBuilder("/global-infra/tier-0s/{tier-0-id}/locale-services/{locale-service-id}/interfaces/{interface-id}");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Delete
            };
            GlobalInfraDeleteTier0InterfaceServiceURL.Replace("{tier-0-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(Tier0Id, System.Globalization.CultureInfo.InvariantCulture)));
            GlobalInfraDeleteTier0InterfaceServiceURL.Replace("{locale-service-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(LocaleServiceId, System.Globalization.CultureInfo.InvariantCulture)));
            GlobalInfraDeleteTier0InterfaceServiceURL.Replace("{interface-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(InterfaceId, System.Globalization.CultureInfo.InvariantCulture)));
            if (Override != null) { request.AddQueryParameter("override", Override.ToString()); }
            request.Resource = GlobalInfraDeleteTier0InterfaceServiceURL.ToString();
            RestResponse response = await restClient.ExecuteTaskAsyncWithPolicy(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Delete operation to " + GlobalInfraDeleteTier0InterfaceServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTTier0InterfaceType> GlobalGlobalInfraReadTier0Interface(string Tier0Id, string LocaleServiceId, string InterfaceId)
        {
            if (Tier0Id == null) { throw new System.ArgumentNullException("Tier0Id cannot be null"); }
            if (LocaleServiceId == null) { throw new System.ArgumentNullException("LocaleServiceId cannot be null"); }
            if (InterfaceId == null) { throw new System.ArgumentNullException("InterfaceId cannot be null"); }
            StringBuilder GlobalInfraReadTier0InterfaceServiceURL = new StringBuilder("/global-infra/tier-0s/{tier-0-id}/locale-services/{locale-service-id}/interfaces/{interface-id}");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Get
            };
            GlobalInfraReadTier0InterfaceServiceURL.Replace("{tier-0-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(Tier0Id, System.Globalization.CultureInfo.InvariantCulture)));
            GlobalInfraReadTier0InterfaceServiceURL.Replace("{locale-service-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(LocaleServiceId, System.Globalization.CultureInfo.InvariantCulture)));
            GlobalInfraReadTier0InterfaceServiceURL.Replace("{interface-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(InterfaceId, System.Globalization.CultureInfo.InvariantCulture)));
            request.Resource = GlobalInfraReadTier0InterfaceServiceURL.ToString();
            RestResponse<NSXTTier0InterfaceType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTTier0InterfaceType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Get operation to " + GlobalInfraReadTier0InterfaceServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task GlobalGlobalInfraPatchTier0Interface(string Tier0Id, string LocaleServiceId, string InterfaceId, NSXTTier0InterfaceType Tier0Interface, bool? Override = null)
        {
            if (Tier0Id == null) { throw new System.ArgumentNullException("Tier0Id cannot be null"); }
            if (LocaleServiceId == null) { throw new System.ArgumentNullException("LocaleServiceId cannot be null"); }
            if (InterfaceId == null) { throw new System.ArgumentNullException("InterfaceId cannot be null"); }
            if (Tier0Interface == null) { throw new System.ArgumentNullException("Tier0Interface cannot be null"); }
            StringBuilder GlobalInfraPatchTier0InterfaceServiceURL = new StringBuilder("/global-infra/tier-0s/{tier-0-id}/locale-services/{locale-service-id}/interfaces/{interface-id}");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Patch
            };
            GlobalInfraPatchTier0InterfaceServiceURL.Replace("{tier-0-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(Tier0Id, System.Globalization.CultureInfo.InvariantCulture)));
            GlobalInfraPatchTier0InterfaceServiceURL.Replace("{locale-service-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(LocaleServiceId, System.Globalization.CultureInfo.InvariantCulture)));
            GlobalInfraPatchTier0InterfaceServiceURL.Replace("{interface-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(InterfaceId, System.Globalization.CultureInfo.InvariantCulture)));
            request.AddJsonBody(Tier0Interface);
            if (Override != null) { request.AddQueryParameter("override", Override.ToString()); }
            request.Resource = GlobalInfraPatchTier0InterfaceServiceURL.ToString();
            RestResponse response = await restClient.ExecuteTaskAsyncWithPolicy(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Patch operation to " + GlobalInfraPatchTier0InterfaceServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTStaticRoutesType> CreateOrReplaceTier0StaticRoutes(string Tier0Id, string RouteId, NSXTStaticRoutesType StaticRoutes)
        {
            if (Tier0Id == null) { throw new System.ArgumentNullException("Tier0Id cannot be null"); }
            if (RouteId == null) { throw new System.ArgumentNullException("RouteId cannot be null"); }
            if (StaticRoutes == null) { throw new System.ArgumentNullException("StaticRoutes cannot be null"); }
            StringBuilder CreateOrReplaceTier0StaticRoutesServiceURL = new StringBuilder("/infra/tier-0s/{tier-0-id}/static-routes/{route-id}");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Put
            };
            CreateOrReplaceTier0StaticRoutesServiceURL.Replace("{tier-0-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(Tier0Id, System.Globalization.CultureInfo.InvariantCulture)));
            CreateOrReplaceTier0StaticRoutesServiceURL.Replace("{route-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(RouteId, System.Globalization.CultureInfo.InvariantCulture)));
            request.AddJsonBody(StaticRoutes);
            request.Resource = CreateOrReplaceTier0StaticRoutesServiceURL.ToString();
            RestResponse<NSXTStaticRoutesType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTStaticRoutesType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Put operation to " + CreateOrReplaceTier0StaticRoutesServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task DeleteTier0StaticRoutes(string Tier0Id, string RouteId)
        {
            if (Tier0Id == null) { throw new System.ArgumentNullException("Tier0Id cannot be null"); }
            if (RouteId == null) { throw new System.ArgumentNullException("RouteId cannot be null"); }
            StringBuilder DeleteTier0StaticRoutesServiceURL = new StringBuilder("/infra/tier-0s/{tier-0-id}/static-routes/{route-id}");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Delete
            };
            DeleteTier0StaticRoutesServiceURL.Replace("{tier-0-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(Tier0Id, System.Globalization.CultureInfo.InvariantCulture)));
            DeleteTier0StaticRoutesServiceURL.Replace("{route-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(RouteId, System.Globalization.CultureInfo.InvariantCulture)));
            request.Resource = DeleteTier0StaticRoutesServiceURL.ToString();
            RestResponse response = await restClient.ExecuteTaskAsyncWithPolicy(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Delete operation to " + DeleteTier0StaticRoutesServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTStaticRoutesType> ReadTier0StaticRoutes(string Tier0Id, string RouteId)
        {
            if (Tier0Id == null) { throw new System.ArgumentNullException("Tier0Id cannot be null"); }
            if (RouteId == null) { throw new System.ArgumentNullException("RouteId cannot be null"); }
            StringBuilder ReadTier0StaticRoutesServiceURL = new StringBuilder("/infra/tier-0s/{tier-0-id}/static-routes/{route-id}");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Get
            };
            ReadTier0StaticRoutesServiceURL.Replace("{tier-0-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(Tier0Id, System.Globalization.CultureInfo.InvariantCulture)));
            ReadTier0StaticRoutesServiceURL.Replace("{route-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(RouteId, System.Globalization.CultureInfo.InvariantCulture)));
            request.Resource = ReadTier0StaticRoutesServiceURL.ToString();
            RestResponse<NSXTStaticRoutesType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTStaticRoutesType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Get operation to " + ReadTier0StaticRoutesServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task PatchTier0StaticRoutes(string Tier0Id, string RouteId, NSXTStaticRoutesType StaticRoutes)
        {
            if (Tier0Id == null) { throw new System.ArgumentNullException("Tier0Id cannot be null"); }
            if (RouteId == null) { throw new System.ArgumentNullException("RouteId cannot be null"); }
            if (StaticRoutes == null) { throw new System.ArgumentNullException("StaticRoutes cannot be null"); }
            StringBuilder PatchTier0StaticRoutesServiceURL = new StringBuilder("/infra/tier-0s/{tier-0-id}/static-routes/{route-id}");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Patch
            };
            PatchTier0StaticRoutesServiceURL.Replace("{tier-0-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(Tier0Id, System.Globalization.CultureInfo.InvariantCulture)));
            PatchTier0StaticRoutesServiceURL.Replace("{route-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(RouteId, System.Globalization.CultureInfo.InvariantCulture)));
            request.AddJsonBody(StaticRoutes);
            request.Resource = PatchTier0StaticRoutesServiceURL.ToString();
            RestResponse response = await restClient.ExecuteTaskAsyncWithPolicy(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Patch operation to " + PatchTier0StaticRoutesServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTIpv6NdraProfileType> CreateOrReplaceIpv6NdraProfile(string NdraProfileId, NSXTIpv6NdraProfileType Ipv6NdraProfile, bool? Override = null)
        {
            if (NdraProfileId == null) { throw new System.ArgumentNullException("NdraProfileId cannot be null"); }
            if (Ipv6NdraProfile == null) { throw new System.ArgumentNullException("Ipv6NdraProfile cannot be null"); }
            StringBuilder CreateOrReplaceIpv6NdraProfileServiceURL = new StringBuilder("/infra/ipv6-ndra-profiles/{ndra-profile-id}");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Put
            };
            CreateOrReplaceIpv6NdraProfileServiceURL.Replace("{ndra-profile-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(NdraProfileId, System.Globalization.CultureInfo.InvariantCulture)));
            request.AddJsonBody(Ipv6NdraProfile);
            if (Override != null) { request.AddQueryParameter("override", Override.ToString()); }
            request.Resource = CreateOrReplaceIpv6NdraProfileServiceURL.ToString();
            RestResponse<NSXTIpv6NdraProfileType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTIpv6NdraProfileType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Put operation to " + CreateOrReplaceIpv6NdraProfileServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task DeleteIpv6NdraProfile(string NdraProfileId, bool? Override = null)
        {
            if (NdraProfileId == null) { throw new System.ArgumentNullException("NdraProfileId cannot be null"); }
            StringBuilder DeleteIpv6NdraProfileServiceURL = new StringBuilder("/infra/ipv6-ndra-profiles/{ndra-profile-id}");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Delete
            };
            DeleteIpv6NdraProfileServiceURL.Replace("{ndra-profile-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(NdraProfileId, System.Globalization.CultureInfo.InvariantCulture)));
            if (Override != null) { request.AddQueryParameter("override", Override.ToString()); }
            request.Resource = DeleteIpv6NdraProfileServiceURL.ToString();
            RestResponse response = await restClient.ExecuteTaskAsyncWithPolicy(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Delete operation to " + DeleteIpv6NdraProfileServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task PatchIpv6NdraProfile(string NdraProfileId, NSXTIpv6NdraProfileType Ipv6NdraProfile, bool? Override = null)
        {
            if (NdraProfileId == null) { throw new System.ArgumentNullException("NdraProfileId cannot be null"); }
            if (Ipv6NdraProfile == null) { throw new System.ArgumentNullException("Ipv6NdraProfile cannot be null"); }
            StringBuilder PatchIpv6NdraProfileServiceURL = new StringBuilder("/infra/ipv6-ndra-profiles/{ndra-profile-id}");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Patch
            };
            PatchIpv6NdraProfileServiceURL.Replace("{ndra-profile-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(NdraProfileId, System.Globalization.CultureInfo.InvariantCulture)));
            request.AddJsonBody(Ipv6NdraProfile);
            if (Override != null) { request.AddQueryParameter("override", Override.ToString()); }
            request.Resource = PatchIpv6NdraProfileServiceURL.ToString();
            RestResponse response = await restClient.ExecuteTaskAsyncWithPolicy(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Patch operation to " + PatchIpv6NdraProfileServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTIpv6NdraProfileType> ReadIpv6NdraProfile(string NdraProfileId)
        {
            if (NdraProfileId == null) { throw new System.ArgumentNullException("NdraProfileId cannot be null"); }
            StringBuilder ReadIpv6NdraProfileServiceURL = new StringBuilder("/infra/ipv6-ndra-profiles/{ndra-profile-id}");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Get
            };
            ReadIpv6NdraProfileServiceURL.Replace("{ndra-profile-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(NdraProfileId, System.Globalization.CultureInfo.InvariantCulture)));
            request.Resource = ReadIpv6NdraProfileServiceURL.ToString();
            RestResponse<NSXTIpv6NdraProfileType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTIpv6NdraProfileType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Get operation to " + ReadIpv6NdraProfileServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTTier1Type> GlobalGlobalInfraReadTier1(string Tier1Id)
        {
            if (Tier1Id == null) { throw new System.ArgumentNullException("Tier1Id cannot be null"); }
            StringBuilder GlobalInfraReadTier1ServiceURL = new StringBuilder("/global-infra/tier-1s/{tier-1-id}");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Get
            };
            GlobalInfraReadTier1ServiceURL.Replace("{tier-1-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(Tier1Id, System.Globalization.CultureInfo.InvariantCulture)));
            request.Resource = GlobalInfraReadTier1ServiceURL.ToString();
            RestResponse<NSXTTier1Type> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTTier1Type>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Get operation to " + GlobalInfraReadTier1ServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTDhcpServerConfigListResultType> ListDhcpServerConfig(string? Cursor = null, bool? IncludeMarkForDeleteObjects = null, string? IncludedFields = null, long? PageSize = null, bool? SortAscending = null, string? SortBy = null)
        {
            StringBuilder ListDhcpServerConfigServiceURL = new StringBuilder("/infra/dhcp-server-configs");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Get
            };
            if (Cursor != null) { request.AddQueryParameter("cursor", Cursor.ToString()); }
            if (IncludeMarkForDeleteObjects != null) { request.AddQueryParameter("include_mark_for_delete_objects", IncludeMarkForDeleteObjects.ToString()); }
            if (IncludedFields != null) { request.AddQueryParameter("included_fields", IncludedFields.ToString()); }
            if (PageSize != null) { request.AddQueryParameter("page_size", PageSize.ToString()); }
            if (SortAscending != null) { request.AddQueryParameter("sort_ascending", SortAscending.ToString()); }
            if (SortBy != null) { request.AddQueryParameter("sort_by", SortBy.ToString()); }
            request.Resource = ListDhcpServerConfigServiceURL.ToString();
            RestResponse<NSXTDhcpServerConfigListResultType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTDhcpServerConfigListResultType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Get operation to " + ListDhcpServerConfigServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTServiceInterfaceType> CreateTier1ServiceInterface(string Tier1Id, string LocaleServiceId, string InterfaceId, NSXTServiceInterfaceType ServiceInterface)
        {
            if (Tier1Id == null) { throw new System.ArgumentNullException("Tier1Id cannot be null"); }
            if (LocaleServiceId == null) { throw new System.ArgumentNullException("LocaleServiceId cannot be null"); }
            if (InterfaceId == null) { throw new System.ArgumentNullException("InterfaceId cannot be null"); }
            if (ServiceInterface == null) { throw new System.ArgumentNullException("ServiceInterface cannot be null"); }
            StringBuilder CreateTier1ServiceInterfaceServiceURL = new StringBuilder("/infra/tier-1s/{tier-1-id}/locale-services/{locale-service-id}/service-interfaces/{interface-id}");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Put
            };
            CreateTier1ServiceInterfaceServiceURL.Replace("{tier-1-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(Tier1Id, System.Globalization.CultureInfo.InvariantCulture)));
            CreateTier1ServiceInterfaceServiceURL.Replace("{locale-service-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(LocaleServiceId, System.Globalization.CultureInfo.InvariantCulture)));
            CreateTier1ServiceInterfaceServiceURL.Replace("{interface-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(InterfaceId, System.Globalization.CultureInfo.InvariantCulture)));
            request.AddJsonBody(ServiceInterface);
            request.Resource = CreateTier1ServiceInterfaceServiceURL.ToString();
            RestResponse<NSXTServiceInterfaceType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTServiceInterfaceType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Put operation to " + CreateTier1ServiceInterfaceServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task DeleteTier1ServiceInterface(string Tier1Id, string LocaleServiceId, string InterfaceId)
        {
            if (Tier1Id == null) { throw new System.ArgumentNullException("Tier1Id cannot be null"); }
            if (LocaleServiceId == null) { throw new System.ArgumentNullException("LocaleServiceId cannot be null"); }
            if (InterfaceId == null) { throw new System.ArgumentNullException("InterfaceId cannot be null"); }
            StringBuilder DeleteTier1ServiceInterfaceServiceURL = new StringBuilder("/infra/tier-1s/{tier-1-id}/locale-services/{locale-service-id}/service-interfaces/{interface-id}");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Delete
            };
            DeleteTier1ServiceInterfaceServiceURL.Replace("{tier-1-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(Tier1Id, System.Globalization.CultureInfo.InvariantCulture)));
            DeleteTier1ServiceInterfaceServiceURL.Replace("{locale-service-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(LocaleServiceId, System.Globalization.CultureInfo.InvariantCulture)));
            DeleteTier1ServiceInterfaceServiceURL.Replace("{interface-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(InterfaceId, System.Globalization.CultureInfo.InvariantCulture)));
            request.Resource = DeleteTier1ServiceInterfaceServiceURL.ToString();
            RestResponse response = await restClient.ExecuteTaskAsyncWithPolicy(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Delete operation to " + DeleteTier1ServiceInterfaceServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task PatchTier1ServiceInterface(string Tier1Id, string LocaleServiceId, string InterfaceId, NSXTServiceInterfaceType ServiceInterface)
        {
            if (Tier1Id == null) { throw new System.ArgumentNullException("Tier1Id cannot be null"); }
            if (LocaleServiceId == null) { throw new System.ArgumentNullException("LocaleServiceId cannot be null"); }
            if (InterfaceId == null) { throw new System.ArgumentNullException("InterfaceId cannot be null"); }
            if (ServiceInterface == null) { throw new System.ArgumentNullException("ServiceInterface cannot be null"); }
            StringBuilder PatchTier1ServiceInterfaceServiceURL = new StringBuilder("/infra/tier-1s/{tier-1-id}/locale-services/{locale-service-id}/service-interfaces/{interface-id}");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Patch
            };
            PatchTier1ServiceInterfaceServiceURL.Replace("{tier-1-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(Tier1Id, System.Globalization.CultureInfo.InvariantCulture)));
            PatchTier1ServiceInterfaceServiceURL.Replace("{locale-service-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(LocaleServiceId, System.Globalization.CultureInfo.InvariantCulture)));
            PatchTier1ServiceInterfaceServiceURL.Replace("{interface-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(InterfaceId, System.Globalization.CultureInfo.InvariantCulture)));
            request.AddJsonBody(ServiceInterface);
            request.Resource = PatchTier1ServiceInterfaceServiceURL.ToString();
            RestResponse response = await restClient.ExecuteTaskAsyncWithPolicy(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Patch operation to " + PatchTier1ServiceInterfaceServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTServiceInterfaceType> ReadTier1ServiceInterface(string Tier1Id, string LocaleServiceId, string InterfaceId)
        {
            if (Tier1Id == null) { throw new System.ArgumentNullException("Tier1Id cannot be null"); }
            if (LocaleServiceId == null) { throw new System.ArgumentNullException("LocaleServiceId cannot be null"); }
            if (InterfaceId == null) { throw new System.ArgumentNullException("InterfaceId cannot be null"); }
            StringBuilder ReadTier1ServiceInterfaceServiceURL = new StringBuilder("/infra/tier-1s/{tier-1-id}/locale-services/{locale-service-id}/service-interfaces/{interface-id}");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Get
            };
            ReadTier1ServiceInterfaceServiceURL.Replace("{tier-1-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(Tier1Id, System.Globalization.CultureInfo.InvariantCulture)));
            ReadTier1ServiceInterfaceServiceURL.Replace("{locale-service-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(LocaleServiceId, System.Globalization.CultureInfo.InvariantCulture)));
            ReadTier1ServiceInterfaceServiceURL.Replace("{interface-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(InterfaceId, System.Globalization.CultureInfo.InvariantCulture)));
            request.Resource = ReadTier1ServiceInterfaceServiceURL.ToString();
            RestResponse<NSXTServiceInterfaceType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTServiceInterfaceType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Get operation to " + ReadTier1ServiceInterfaceServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task Tier1GatewayReprocess(string Tier1Id, string? EnforcementPointPath = null)
        {
            if (Tier1Id == null) { throw new System.ArgumentNullException("Tier1Id cannot be null"); }
            StringBuilder Tier1GatewayReprocessServiceURL = new StringBuilder("/infra/tier-1s/{tier-1-id}?action=reprocess");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Post
            };
            Tier1GatewayReprocessServiceURL.Replace("{tier-1-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(Tier1Id, System.Globalization.CultureInfo.InvariantCulture)));
            if (EnforcementPointPath != null) { request.AddQueryParameter("enforcement_point_path", EnforcementPointPath.ToString()); }
            request.Resource = Tier1GatewayReprocessServiceURL.ToString();
            RestResponse response = await restClient.ExecuteTaskAsyncWithPolicy(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Post operation to " + Tier1GatewayReprocessServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTBfdProfileType> GlobalGlobalInfraUpdateBfdProfile(string BfdProfileId, NSXTBfdProfileType BfdProfile, bool? Override = null)
        {
            if (BfdProfileId == null) { throw new System.ArgumentNullException("BfdProfileId cannot be null"); }
            if (BfdProfile == null) { throw new System.ArgumentNullException("BfdProfile cannot be null"); }
            StringBuilder GlobalInfraUpdateBfdProfileServiceURL = new StringBuilder("/global-infra/bfd-profiles/{bfd-profile-id}");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Put
            };
            GlobalInfraUpdateBfdProfileServiceURL.Replace("{bfd-profile-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(BfdProfileId, System.Globalization.CultureInfo.InvariantCulture)));
            request.AddJsonBody(BfdProfile);
            if (Override != null) { request.AddQueryParameter("override", Override.ToString()); }
            request.Resource = GlobalInfraUpdateBfdProfileServiceURL.ToString();
            RestResponse<NSXTBfdProfileType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTBfdProfileType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Put operation to " + GlobalInfraUpdateBfdProfileServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task GlobalGlobalInfraPatchBfdProfile(string BfdProfileId, NSXTBfdProfileType BfdProfile, bool? Override = null)
        {
            if (BfdProfileId == null) { throw new System.ArgumentNullException("BfdProfileId cannot be null"); }
            if (BfdProfile == null) { throw new System.ArgumentNullException("BfdProfile cannot be null"); }
            StringBuilder GlobalInfraPatchBfdProfileServiceURL = new StringBuilder("/global-infra/bfd-profiles/{bfd-profile-id}");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Patch
            };
            GlobalInfraPatchBfdProfileServiceURL.Replace("{bfd-profile-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(BfdProfileId, System.Globalization.CultureInfo.InvariantCulture)));
            request.AddJsonBody(BfdProfile);
            if (Override != null) { request.AddQueryParameter("override", Override.ToString()); }
            request.Resource = GlobalInfraPatchBfdProfileServiceURL.ToString();
            RestResponse response = await restClient.ExecuteTaskAsyncWithPolicy(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Patch operation to " + GlobalInfraPatchBfdProfileServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTBfdProfileType> GlobalGlobalInfraReadBfdProfile(string BfdProfileId)
        {
            if (BfdProfileId == null) { throw new System.ArgumentNullException("BfdProfileId cannot be null"); }
            StringBuilder GlobalInfraReadBfdProfileServiceURL = new StringBuilder("/global-infra/bfd-profiles/{bfd-profile-id}");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Get
            };
            GlobalInfraReadBfdProfileServiceURL.Replace("{bfd-profile-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(BfdProfileId, System.Globalization.CultureInfo.InvariantCulture)));
            request.Resource = GlobalInfraReadBfdProfileServiceURL.ToString();
            RestResponse<NSXTBfdProfileType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTBfdProfileType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Get operation to " + GlobalInfraReadBfdProfileServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task GlobalGlobalInfraDeleteBfdProfile(string BfdProfileId, bool? Override = null)
        {
            if (BfdProfileId == null) { throw new System.ArgumentNullException("BfdProfileId cannot be null"); }
            StringBuilder GlobalInfraDeleteBfdProfileServiceURL = new StringBuilder("/global-infra/bfd-profiles/{bfd-profile-id}");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Delete
            };
            GlobalInfraDeleteBfdProfileServiceURL.Replace("{bfd-profile-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(BfdProfileId, System.Globalization.CultureInfo.InvariantCulture)));
            if (Override != null) { request.AddQueryParameter("override", Override.ToString()); }
            request.Resource = GlobalInfraDeleteBfdProfileServiceURL.ToString();
            RestResponse response = await restClient.ExecuteTaskAsyncWithPolicy(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Delete operation to " + GlobalInfraDeleteBfdProfileServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTSegmentPortListResultType> ListTier1SegmentPorts(string Tier1Id, string SegmentId, string? Cursor = null, bool? IncludeMarkForDeleteObjects = null, string? IncludedFields = null, long? PageSize = null, bool? SortAscending = null, string? SortBy = null)
        {
            if (Tier1Id == null) { throw new System.ArgumentNullException("Tier1Id cannot be null"); }
            if (SegmentId == null) { throw new System.ArgumentNullException("SegmentId cannot be null"); }
            StringBuilder ListTier1SegmentPortsServiceURL = new StringBuilder("/infra/tier-1s/{tier-1-id}/segments/{segment-id}/ports");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Get
            };
            ListTier1SegmentPortsServiceURL.Replace("{tier-1-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(Tier1Id, System.Globalization.CultureInfo.InvariantCulture)));
            ListTier1SegmentPortsServiceURL.Replace("{segment-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(SegmentId, System.Globalization.CultureInfo.InvariantCulture)));
            if (Cursor != null) { request.AddQueryParameter("cursor", Cursor.ToString()); }
            if (IncludeMarkForDeleteObjects != null) { request.AddQueryParameter("include_mark_for_delete_objects", IncludeMarkForDeleteObjects.ToString()); }
            if (IncludedFields != null) { request.AddQueryParameter("included_fields", IncludedFields.ToString()); }
            if (PageSize != null) { request.AddQueryParameter("page_size", PageSize.ToString()); }
            if (SortAscending != null) { request.AddQueryParameter("sort_ascending", SortAscending.ToString()); }
            if (SortBy != null) { request.AddQueryParameter("sort_by", SortBy.ToString()); }
            request.Resource = ListTier1SegmentPortsServiceURL.ToString();
            RestResponse<NSXTSegmentPortListResultType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTSegmentPortListResultType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Get operation to " + ListTier1SegmentPortsServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTAntreaTraceflowConfigListResultType> ListAntreaTraceflowConfig(string? Cursor = null, bool? IncludeMarkForDeleteObjects = null, string? IncludedFields = null, long? PageSize = null, bool? SortAscending = null, string? SortBy = null)
        {
            StringBuilder ListAntreaTraceflowConfigServiceURL = new StringBuilder("/infra/antrea/traceflows");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Get
            };
            if (Cursor != null) { request.AddQueryParameter("cursor", Cursor.ToString()); }
            if (IncludeMarkForDeleteObjects != null) { request.AddQueryParameter("include_mark_for_delete_objects", IncludeMarkForDeleteObjects.ToString()); }
            if (IncludedFields != null) { request.AddQueryParameter("included_fields", IncludedFields.ToString()); }
            if (PageSize != null) { request.AddQueryParameter("page_size", PageSize.ToString()); }
            if (SortAscending != null) { request.AddQueryParameter("sort_ascending", SortAscending.ToString()); }
            if (SortBy != null) { request.AddQueryParameter("sort_by", SortBy.ToString()); }
            request.Resource = ListAntreaTraceflowConfigServiceURL.ToString();
            RestResponse<NSXTAntreaTraceflowConfigListResultType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTAntreaTraceflowConfigListResultType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Get operation to " + ListAntreaTraceflowConfigServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTDhcpServerConfigType> CreateOrReplaceDhcpServerConfig(string DhcpServerConfigId, NSXTDhcpServerConfigType DhcpServerConfig)
        {
            if (DhcpServerConfigId == null) { throw new System.ArgumentNullException("DhcpServerConfigId cannot be null"); }
            if (DhcpServerConfig == null) { throw new System.ArgumentNullException("DhcpServerConfig cannot be null"); }
            StringBuilder CreateOrReplaceDhcpServerConfigServiceURL = new StringBuilder("/infra/dhcp-server-configs/{dhcp-server-config-id}");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Put
            };
            CreateOrReplaceDhcpServerConfigServiceURL.Replace("{dhcp-server-config-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(DhcpServerConfigId, System.Globalization.CultureInfo.InvariantCulture)));
            request.AddJsonBody(DhcpServerConfig);
            request.Resource = CreateOrReplaceDhcpServerConfigServiceURL.ToString();
            RestResponse<NSXTDhcpServerConfigType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTDhcpServerConfigType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Put operation to " + CreateOrReplaceDhcpServerConfigServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTDhcpServerConfigType> ReadDhcpServerConfig(string DhcpServerConfigId)
        {
            if (DhcpServerConfigId == null) { throw new System.ArgumentNullException("DhcpServerConfigId cannot be null"); }
            StringBuilder ReadDhcpServerConfigServiceURL = new StringBuilder("/infra/dhcp-server-configs/{dhcp-server-config-id}");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Get
            };
            ReadDhcpServerConfigServiceURL.Replace("{dhcp-server-config-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(DhcpServerConfigId, System.Globalization.CultureInfo.InvariantCulture)));
            request.Resource = ReadDhcpServerConfigServiceURL.ToString();
            RestResponse<NSXTDhcpServerConfigType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTDhcpServerConfigType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Get operation to " + ReadDhcpServerConfigServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task PatchDhcpServerConfig(string DhcpServerConfigId, NSXTDhcpServerConfigType DhcpServerConfig)
        {
            if (DhcpServerConfigId == null) { throw new System.ArgumentNullException("DhcpServerConfigId cannot be null"); }
            if (DhcpServerConfig == null) { throw new System.ArgumentNullException("DhcpServerConfig cannot be null"); }
            StringBuilder PatchDhcpServerConfigServiceURL = new StringBuilder("/infra/dhcp-server-configs/{dhcp-server-config-id}");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Patch
            };
            PatchDhcpServerConfigServiceURL.Replace("{dhcp-server-config-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(DhcpServerConfigId, System.Globalization.CultureInfo.InvariantCulture)));
            request.AddJsonBody(DhcpServerConfig);
            request.Resource = PatchDhcpServerConfigServiceURL.ToString();
            RestResponse response = await restClient.ExecuteTaskAsyncWithPolicy(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Patch operation to " + PatchDhcpServerConfigServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task DeleteDhcpServerConfig(string DhcpServerConfigId)
        {
            if (DhcpServerConfigId == null) { throw new System.ArgumentNullException("DhcpServerConfigId cannot be null"); }
            StringBuilder DeleteDhcpServerConfigServiceURL = new StringBuilder("/infra/dhcp-server-configs/{dhcp-server-config-id}");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Delete
            };
            DeleteDhcpServerConfigServiceURL.Replace("{dhcp-server-config-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(DhcpServerConfigId, System.Globalization.CultureInfo.InvariantCulture)));
            request.Resource = DeleteDhcpServerConfigServiceURL.ToString();
            RestResponse response = await restClient.ExecuteTaskAsyncWithPolicy(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Delete operation to " + DeleteDhcpServerConfigServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTLiveTraceResultType> ReadLiveTraceResult(string LivetraceId, string? EnforcementPointPath = null)
        {
            if (LivetraceId == null) { throw new System.ArgumentNullException("LivetraceId cannot be null"); }
            StringBuilder ReadLiveTraceResultServiceURL = new StringBuilder("/infra/livetraces/{livetrace-id}/result");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Get
            };
            ReadLiveTraceResultServiceURL.Replace("{livetrace-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(LivetraceId, System.Globalization.CultureInfo.InvariantCulture)));
            if (EnforcementPointPath != null) { request.AddQueryParameter("enforcement_point_path", EnforcementPointPath.ToString()); }
            request.Resource = ReadLiveTraceResultServiceURL.ToString();
            RestResponse<NSXTLiveTraceResultType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTLiveTraceResultType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Get operation to " + ReadLiveTraceResultServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTSegmentType> GlobalGlobalInfraReadSegment(string Tier1Id, string SegmentId)
        {
            if (Tier1Id == null) { throw new System.ArgumentNullException("Tier1Id cannot be null"); }
            if (SegmentId == null) { throw new System.ArgumentNullException("SegmentId cannot be null"); }
            StringBuilder GlobalInfraReadSegmentServiceURL = new StringBuilder("/global-infra/tier-1s/{tier-1-id}/segments/{segment-id}");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Get
            };
            GlobalInfraReadSegmentServiceURL.Replace("{tier-1-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(Tier1Id, System.Globalization.CultureInfo.InvariantCulture)));
            GlobalInfraReadSegmentServiceURL.Replace("{segment-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(SegmentId, System.Globalization.CultureInfo.InvariantCulture)));
            request.Resource = GlobalInfraReadSegmentServiceURL.ToString();
            RestResponse<NSXTSegmentType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTSegmentType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Get operation to " + GlobalInfraReadSegmentServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTCommunityListListResultType> GlobalGlobalInfraListCommunityList(string Tier0Id, string? Cursor = null, bool? IncludeMarkForDeleteObjects = null, string? IncludedFields = null, long? PageSize = null, bool? SortAscending = null, string? SortBy = null)
        {
            if (Tier0Id == null) { throw new System.ArgumentNullException("Tier0Id cannot be null"); }
            StringBuilder GlobalInfraListCommunityListServiceURL = new StringBuilder("/global-infra/tier-0s/{tier-0-id}/community-lists");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Get
            };
            GlobalInfraListCommunityListServiceURL.Replace("{tier-0-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(Tier0Id, System.Globalization.CultureInfo.InvariantCulture)));
            if (Cursor != null) { request.AddQueryParameter("cursor", Cursor.ToString()); }
            if (IncludeMarkForDeleteObjects != null) { request.AddQueryParameter("include_mark_for_delete_objects", IncludeMarkForDeleteObjects.ToString()); }
            if (IncludedFields != null) { request.AddQueryParameter("included_fields", IncludedFields.ToString()); }
            if (PageSize != null) { request.AddQueryParameter("page_size", PageSize.ToString()); }
            if (SortAscending != null) { request.AddQueryParameter("sort_ascending", SortAscending.ToString()); }
            if (SortBy != null) { request.AddQueryParameter("sort_by", SortBy.ToString()); }
            request.Resource = GlobalInfraListCommunityListServiceURL.ToString();
            RestResponse<NSXTCommunityListListResultType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTCommunityListListResultType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Get operation to " + GlobalInfraListCommunityListServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTLocaleServicesListResultType> ListTier1LocaleServices(string Tier1Id, string? Cursor = null, bool? IncludeMarkForDeleteObjects = null, string? IncludedFields = null, long? PageSize = null, bool? SortAscending = null, string? SortBy = null)
        {
            if (Tier1Id == null) { throw new System.ArgumentNullException("Tier1Id cannot be null"); }
            StringBuilder ListTier1LocaleServicesServiceURL = new StringBuilder("/infra/tier-1s/{tier-1-id}/locale-services");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Get
            };
            ListTier1LocaleServicesServiceURL.Replace("{tier-1-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(Tier1Id, System.Globalization.CultureInfo.InvariantCulture)));
            if (Cursor != null) { request.AddQueryParameter("cursor", Cursor.ToString()); }
            if (IncludeMarkForDeleteObjects != null) { request.AddQueryParameter("include_mark_for_delete_objects", IncludeMarkForDeleteObjects.ToString()); }
            if (IncludedFields != null) { request.AddQueryParameter("included_fields", IncludedFields.ToString()); }
            if (PageSize != null) { request.AddQueryParameter("page_size", PageSize.ToString()); }
            if (SortAscending != null) { request.AddQueryParameter("sort_ascending", SortAscending.ToString()); }
            if (SortBy != null) { request.AddQueryParameter("sort_by", SortBy.ToString()); }
            request.Resource = ListTier1LocaleServicesServiceURL.ToString();
            RestResponse<NSXTLocaleServicesListResultType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTLocaleServicesListResultType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Get operation to " + ListTier1LocaleServicesServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTIpv6DadProfileType> CreateOrReplaceIpv6DadProfile(string DadProfileId, NSXTIpv6DadProfileType Ipv6DadProfile, bool? Override = null)
        {
            if (DadProfileId == null) { throw new System.ArgumentNullException("DadProfileId cannot be null"); }
            if (Ipv6DadProfile == null) { throw new System.ArgumentNullException("Ipv6DadProfile cannot be null"); }
            StringBuilder CreateOrReplaceIpv6DadProfileServiceURL = new StringBuilder("/infra/ipv6-dad-profiles/{dad-profile-id}");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Put
            };
            CreateOrReplaceIpv6DadProfileServiceURL.Replace("{dad-profile-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(DadProfileId, System.Globalization.CultureInfo.InvariantCulture)));
            request.AddJsonBody(Ipv6DadProfile);
            if (Override != null) { request.AddQueryParameter("override", Override.ToString()); }
            request.Resource = CreateOrReplaceIpv6DadProfileServiceURL.ToString();
            RestResponse<NSXTIpv6DadProfileType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTIpv6DadProfileType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Put operation to " + CreateOrReplaceIpv6DadProfileServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTIpv6DadProfileType> ReadIpv6DadProfile(string DadProfileId)
        {
            if (DadProfileId == null) { throw new System.ArgumentNullException("DadProfileId cannot be null"); }
            StringBuilder ReadIpv6DadProfileServiceURL = new StringBuilder("/infra/ipv6-dad-profiles/{dad-profile-id}");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Get
            };
            ReadIpv6DadProfileServiceURL.Replace("{dad-profile-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(DadProfileId, System.Globalization.CultureInfo.InvariantCulture)));
            request.Resource = ReadIpv6DadProfileServiceURL.ToString();
            RestResponse<NSXTIpv6DadProfileType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTIpv6DadProfileType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Get operation to " + ReadIpv6DadProfileServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task PatchIpv6DadProfile(string DadProfileId, NSXTIpv6DadProfileType Ipv6DadProfile, bool? Override = null)
        {
            if (DadProfileId == null) { throw new System.ArgumentNullException("DadProfileId cannot be null"); }
            if (Ipv6DadProfile == null) { throw new System.ArgumentNullException("Ipv6DadProfile cannot be null"); }
            StringBuilder PatchIpv6DadProfileServiceURL = new StringBuilder("/infra/ipv6-dad-profiles/{dad-profile-id}");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Patch
            };
            PatchIpv6DadProfileServiceURL.Replace("{dad-profile-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(DadProfileId, System.Globalization.CultureInfo.InvariantCulture)));
            request.AddJsonBody(Ipv6DadProfile);
            if (Override != null) { request.AddQueryParameter("override", Override.ToString()); }
            request.Resource = PatchIpv6DadProfileServiceURL.ToString();
            RestResponse response = await restClient.ExecuteTaskAsyncWithPolicy(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Patch operation to " + PatchIpv6DadProfileServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task DeleteIpv6DadProfile(string DadProfileId, bool? Override = null)
        {
            if (DadProfileId == null) { throw new System.ArgumentNullException("DadProfileId cannot be null"); }
            StringBuilder DeleteIpv6DadProfileServiceURL = new StringBuilder("/infra/ipv6-dad-profiles/{dad-profile-id}");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Delete
            };
            DeleteIpv6DadProfileServiceURL.Replace("{dad-profile-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(DadProfileId, System.Globalization.CultureInfo.InvariantCulture)));
            if (Override != null) { request.AddQueryParameter("override", Override.ToString()); }
            request.Resource = DeleteIpv6DadProfileServiceURL.ToString();
            RestResponse response = await restClient.ExecuteTaskAsyncWithPolicy(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Delete operation to " + DeleteIpv6DadProfileServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTLiveTraceConfigType> UpdateLiveTraceConfig(string LivetraceId, NSXTLiveTraceConfigType LiveTraceConfig)
        {
            if (LivetraceId == null) { throw new System.ArgumentNullException("LivetraceId cannot be null"); }
            if (LiveTraceConfig == null) { throw new System.ArgumentNullException("LiveTraceConfig cannot be null"); }
            StringBuilder UpdateLiveTraceConfigServiceURL = new StringBuilder("/infra/livetraces/{livetrace-id}");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Put
            };
            UpdateLiveTraceConfigServiceURL.Replace("{livetrace-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(LivetraceId, System.Globalization.CultureInfo.InvariantCulture)));
            request.AddJsonBody(LiveTraceConfig);
            request.Resource = UpdateLiveTraceConfigServiceURL.ToString();
            RestResponse<NSXTLiveTraceConfigType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTLiveTraceConfigType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Put operation to " + UpdateLiveTraceConfigServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTLiveTraceConfigType> RestartLivetrace(string LivetraceId, string? Action = null)
        {
            if (LivetraceId == null) { throw new System.ArgumentNullException("LivetraceId cannot be null"); }
            StringBuilder RestartLivetraceServiceURL = new StringBuilder("/infra/livetraces/{livetrace-id}");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Post
            };
            RestartLivetraceServiceURL.Replace("{livetrace-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(LivetraceId, System.Globalization.CultureInfo.InvariantCulture)));
            if (Action != null) { request.AddQueryParameter("action", Action.ToString()); }
            request.Resource = RestartLivetraceServiceURL.ToString();
            RestResponse<NSXTLiveTraceConfigType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTLiveTraceConfigType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Post operation to " + RestartLivetraceServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task PatchLiveTraceConfig(string LivetraceId, NSXTLiveTraceConfigType LiveTraceConfig)
        {
            if (LivetraceId == null) { throw new System.ArgumentNullException("LivetraceId cannot be null"); }
            if (LiveTraceConfig == null) { throw new System.ArgumentNullException("LiveTraceConfig cannot be null"); }
            StringBuilder PatchLiveTraceConfigServiceURL = new StringBuilder("/infra/livetraces/{livetrace-id}");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Patch
            };
            PatchLiveTraceConfigServiceURL.Replace("{livetrace-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(LivetraceId, System.Globalization.CultureInfo.InvariantCulture)));
            request.AddJsonBody(LiveTraceConfig);
            request.Resource = PatchLiveTraceConfigServiceURL.ToString();
            RestResponse response = await restClient.ExecuteTaskAsyncWithPolicy(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Patch operation to " + PatchLiveTraceConfigServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTLiveTraceConfigType> ReadLiveTraceConfig(string LivetraceId)
        {
            if (LivetraceId == null) { throw new System.ArgumentNullException("LivetraceId cannot be null"); }
            StringBuilder ReadLiveTraceConfigServiceURL = new StringBuilder("/infra/livetraces/{livetrace-id}");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Get
            };
            ReadLiveTraceConfigServiceURL.Replace("{livetrace-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(LivetraceId, System.Globalization.CultureInfo.InvariantCulture)));
            request.Resource = ReadLiveTraceConfigServiceURL.ToString();
            RestResponse<NSXTLiveTraceConfigType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTLiveTraceConfigType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Get operation to " + ReadLiveTraceConfigServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task DeleteLiveTraceConfig(string LivetraceId)
        {
            if (LivetraceId == null) { throw new System.ArgumentNullException("LivetraceId cannot be null"); }
            StringBuilder DeleteLiveTraceConfigServiceURL = new StringBuilder("/infra/livetraces/{livetrace-id}");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Delete
            };
            DeleteLiveTraceConfigServiceURL.Replace("{livetrace-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(LivetraceId, System.Globalization.CultureInfo.InvariantCulture)));
            request.Resource = DeleteLiveTraceConfigServiceURL.ToString();
            RestResponse response = await restClient.ExecuteTaskAsyncWithPolicy(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Delete operation to " + DeleteLiveTraceConfigServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTCommunityListType> GlobalGlobalInfraReadCommunityList(string Tier0Id, string CommunityListId)
        {
            if (Tier0Id == null) { throw new System.ArgumentNullException("Tier0Id cannot be null"); }
            if (CommunityListId == null) { throw new System.ArgumentNullException("CommunityListId cannot be null"); }
            StringBuilder GlobalInfraReadCommunityListServiceURL = new StringBuilder("/global-infra/tier-0s/{tier-0-id}/community-lists/{community-list-id}");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Get
            };
            GlobalInfraReadCommunityListServiceURL.Replace("{tier-0-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(Tier0Id, System.Globalization.CultureInfo.InvariantCulture)));
            GlobalInfraReadCommunityListServiceURL.Replace("{community-list-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(CommunityListId, System.Globalization.CultureInfo.InvariantCulture)));
            request.Resource = GlobalInfraReadCommunityListServiceURL.ToString();
            RestResponse<NSXTCommunityListType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTCommunityListType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Get operation to " + GlobalInfraReadCommunityListServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTGatewayQosProfileListResultType> GlobalGlobalInfraListGatewayQosProfiles(string? Cursor = null, bool? IncludeMarkForDeleteObjects = null, string? IncludedFields = null, long? PageSize = null, bool? SortAscending = null, string? SortBy = null)
        {
            StringBuilder GlobalInfraListGatewayQosProfilesServiceURL = new StringBuilder("/global-infra/gateway-qos-profiles");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Get
            };
            if (Cursor != null) { request.AddQueryParameter("cursor", Cursor.ToString()); }
            if (IncludeMarkForDeleteObjects != null) { request.AddQueryParameter("include_mark_for_delete_objects", IncludeMarkForDeleteObjects.ToString()); }
            if (IncludedFields != null) { request.AddQueryParameter("included_fields", IncludedFields.ToString()); }
            if (PageSize != null) { request.AddQueryParameter("page_size", PageSize.ToString()); }
            if (SortAscending != null) { request.AddQueryParameter("sort_ascending", SortAscending.ToString()); }
            if (SortBy != null) { request.AddQueryParameter("sort_by", SortBy.ToString()); }
            request.Resource = GlobalInfraListGatewayQosProfilesServiceURL.ToString();
            RestResponse<NSXTGatewayQosProfileListResultType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTGatewayQosProfileListResultType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Get operation to " + GlobalInfraListGatewayQosProfilesServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
    }
}
