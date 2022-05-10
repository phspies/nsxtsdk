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
    public class LogicalSwitch
    {
        private RestClient restClient;
        private int retry;
        private int timeout;
        private CancellationToken cancellationToken;

        public LogicalSwitch(RestClient Client, CancellationToken _cancellationToken, int _timeout, int _retry)
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
        public async Task<NSXTLogicalSwitchType> CreateLogicalSwitch(NSXTLogicalSwitchType LogicalSwitch)
        {
            if (LogicalSwitch == null) { throw new System.ArgumentNullException("LogicalSwitch cannot be null"); }
            StringBuilder CreateLogicalSwitchServiceURL = new StringBuilder("/logical-switches");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Post
            };
            request.AddJsonBody(LogicalSwitch);
            request.Resource = CreateLogicalSwitchServiceURL.ToString();
            RestResponse<NSXTLogicalSwitchType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTLogicalSwitchType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Post operation to " + CreateLogicalSwitchServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTLogicalSwitchListResultType> ListLogicalSwitches(string? Cursor = null, bool? Diagnostic = null, string? IncludedFields = null, long? PageSize = null, bool? SortAscending = null, string? SortBy = null, string? SwitchType = null, string? SwitchingProfileId = null, string? TransportType = null, string? TransportZoneId = null, string? UplinkTeamingPolicyName = null, long? Vlan = null, int? Vni = null)
        {
            StringBuilder ListLogicalSwitchesServiceURL = new StringBuilder("/logical-switches");
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
            if (SwitchType != null) { request.AddQueryParameter("switch_type", SwitchType.ToString()); }
            if (SwitchingProfileId != null) { request.AddQueryParameter("switching_profile_id", SwitchingProfileId.ToString()); }
            if (TransportType != null) { request.AddQueryParameter("transport_type", TransportType.ToString()); }
            if (TransportZoneId != null) { request.AddQueryParameter("transport_zone_id", TransportZoneId.ToString()); }
            if (UplinkTeamingPolicyName != null) { request.AddQueryParameter("uplink_teaming_policy_name", UplinkTeamingPolicyName.ToString()); }
            if (Vlan != null) { request.AddQueryParameter("vlan", Vlan.ToString()); }
            if (Vni != null) { request.AddQueryParameter("vni", Vni.ToString()); }
            request.Resource = ListLogicalSwitchesServiceURL.ToString();
            RestResponse<NSXTLogicalSwitchListResultType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTLogicalSwitchListResultType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Get operation to " + ListLogicalSwitchesServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTLogicalSwitchStateType> GetLogicalSwitchState(string LswitchId)
        {
            if (LswitchId == null) { throw new System.ArgumentNullException("LswitchId cannot be null"); }
            StringBuilder GetLogicalSwitchStateServiceURL = new StringBuilder("/logical-switches/{lswitch-id}/state");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Get
            };
            GetLogicalSwitchStateServiceURL.Replace("{lswitch-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(LswitchId, System.Globalization.CultureInfo.InvariantCulture)));
            request.Resource = GetLogicalSwitchStateServiceURL.ToString();
            RestResponse<NSXTLogicalSwitchStateType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTLogicalSwitchStateType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Get operation to " + GetLogicalSwitchStateServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTLogicalSwitchStatusType> GetLogicalSwitchStatus(string LswitchId)
        {
            if (LswitchId == null) { throw new System.ArgumentNullException("LswitchId cannot be null"); }
            StringBuilder GetLogicalSwitchStatusServiceURL = new StringBuilder("/logical-switches/{lswitch-id}/summary");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Get
            };
            GetLogicalSwitchStatusServiceURL.Replace("{lswitch-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(LswitchId, System.Globalization.CultureInfo.InvariantCulture)));
            request.Resource = GetLogicalSwitchStatusServiceURL.ToString();
            RestResponse<NSXTLogicalSwitchStatusType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTLogicalSwitchStatusType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Get operation to " + GetLogicalSwitchStatusServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTLogicalSwitchType> UpdateLogicalSwitch(string LswitchId, NSXTLogicalSwitchType LogicalSwitch)
        {
            if (LswitchId == null) { throw new System.ArgumentNullException("LswitchId cannot be null"); }
            if (LogicalSwitch == null) { throw new System.ArgumentNullException("LogicalSwitch cannot be null"); }
            StringBuilder UpdateLogicalSwitchServiceURL = new StringBuilder("/logical-switches/{lswitch-id}");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Put
            };
            UpdateLogicalSwitchServiceURL.Replace("{lswitch-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(LswitchId, System.Globalization.CultureInfo.InvariantCulture)));
            request.AddJsonBody(LogicalSwitch);
            request.Resource = UpdateLogicalSwitchServiceURL.ToString();
            RestResponse<NSXTLogicalSwitchType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTLogicalSwitchType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Put operation to " + UpdateLogicalSwitchServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task DeleteLogicalSwitch(string LswitchId, bool? Cascade = null, bool? Detach = null)
        {
            if (LswitchId == null) { throw new System.ArgumentNullException("LswitchId cannot be null"); }
            StringBuilder DeleteLogicalSwitchServiceURL = new StringBuilder("/logical-switches/{lswitch-id}");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Delete
            };
            DeleteLogicalSwitchServiceURL.Replace("{lswitch-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(LswitchId, System.Globalization.CultureInfo.InvariantCulture)));
            if (Cascade != null) { request.AddQueryParameter("cascade", Cascade.ToString()); }
            if (Detach != null) { request.AddQueryParameter("detach", Detach.ToString()); }
            request.Resource = DeleteLogicalSwitchServiceURL.ToString();
            RestResponse response = await restClient.ExecuteTaskAsyncWithPolicy(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Delete operation to " + DeleteLogicalSwitchServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTLogicalSwitchType> GetLogicalSwitch(string LswitchId)
        {
            if (LswitchId == null) { throw new System.ArgumentNullException("LswitchId cannot be null"); }
            StringBuilder GetLogicalSwitchServiceURL = new StringBuilder("/logical-switches/{lswitch-id}");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Get
            };
            GetLogicalSwitchServiceURL.Replace("{lswitch-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(LswitchId, System.Globalization.CultureInfo.InvariantCulture)));
            request.Resource = GetLogicalSwitchServiceURL.ToString();
            RestResponse<NSXTLogicalSwitchType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTLogicalSwitchType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Get operation to " + GetLogicalSwitchServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTLogicalSwitchStateListResultType> ListLogicalSwitchesByState(string? Status = null)
        {
            StringBuilder ListLogicalSwitchesByStateServiceURL = new StringBuilder("/logical-switches/state");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Get
            };
            if (Status != null) { request.AddQueryParameter("status", Status.ToString()); }
            request.Resource = ListLogicalSwitchesByStateServiceURL.ToString();
            RestResponse<NSXTLogicalSwitchStateListResultType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTLogicalSwitchStateListResultType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Get operation to " + ListLogicalSwitchesByStateServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
    }
}
