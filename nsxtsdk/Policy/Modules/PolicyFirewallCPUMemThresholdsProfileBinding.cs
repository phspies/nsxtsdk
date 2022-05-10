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
    public class PolicyFirewallCPUMemThresholdsProfileBinding
    {
        private RestClient restClient;
        private int retry;
        private int timeout;
        private CancellationToken cancellationToken;

        public PolicyFirewallCPUMemThresholdsProfileBinding(RestClient Client, CancellationToken _cancellationToken, int _timeout, int _retry)
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
        public async Task<NSXTPolicyFirewallCPUMemThresholdsProfileBindingMapListResultType> GlobalGlobalInfraListPolicyFirewallCpumemThresholdsProfileBindingMaps(string? Cursor = null, bool? IncludeMarkForDeleteObjects = null, string? IncludedFields = null, long? PageSize = null, bool? SortAscending = null, string? SortBy = null)
        {
            StringBuilder GlobalInfraListPolicyFirewallCpumemThresholdsProfileBindingMapsServiceURL = new StringBuilder("/global-infra/settings/firewall/cpu-mem-thresholds-profile-binding-maps");
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
            request.Resource = GlobalInfraListPolicyFirewallCpumemThresholdsProfileBindingMapsServiceURL.ToString();
            RestResponse<NSXTPolicyFirewallCPUMemThresholdsProfileBindingMapListResultType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTPolicyFirewallCPUMemThresholdsProfileBindingMapListResultType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Get operation to " + GlobalInfraListPolicyFirewallCpumemThresholdsProfileBindingMapsServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTPolicyFirewallCPUMemThresholdsProfileBindingMapType> UpdatePolicyFirewallCpumemThresholdsProfileBindingMap(string CpuMemThresholdsProfileBindingMapId, NSXTPolicyFirewallCPUMemThresholdsProfileBindingMapType PolicyFirewallCpumemThresholdsProfileBindingMap)
        {
            if (CpuMemThresholdsProfileBindingMapId == null) { throw new System.ArgumentNullException("CpuMemThresholdsProfileBindingMapId cannot be null"); }
            if (PolicyFirewallCpumemThresholdsProfileBindingMap == null) { throw new System.ArgumentNullException("PolicyFirewallCpumemThresholdsProfileBindingMap cannot be null"); }
            StringBuilder UpdatePolicyFirewallCpumemThresholdsProfileBindingMapServiceURL = new StringBuilder("/infra/settings/firewall/cpu-mem-thresholds-profile-binding-maps/{cpu-mem-thresholds-profile-binding-map-id}");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Put
            };
            UpdatePolicyFirewallCpumemThresholdsProfileBindingMapServiceURL.Replace("{cpu-mem-thresholds-profile-binding-map-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(CpuMemThresholdsProfileBindingMapId, System.Globalization.CultureInfo.InvariantCulture)));
            request.AddJsonBody(PolicyFirewallCpumemThresholdsProfileBindingMap);
            request.Resource = UpdatePolicyFirewallCpumemThresholdsProfileBindingMapServiceURL.ToString();
            RestResponse<NSXTPolicyFirewallCPUMemThresholdsProfileBindingMapType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTPolicyFirewallCPUMemThresholdsProfileBindingMapType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Put operation to " + UpdatePolicyFirewallCpumemThresholdsProfileBindingMapServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTPolicyFirewallCPUMemThresholdsProfileBindingMapType> GetPolicyFirewallCpumemThresholdsProfileBindingMap(string CpuMemThresholdsProfileBindingMapId)
        {
            if (CpuMemThresholdsProfileBindingMapId == null) { throw new System.ArgumentNullException("CpuMemThresholdsProfileBindingMapId cannot be null"); }
            StringBuilder GetPolicyFirewallCpumemThresholdsProfileBindingMapServiceURL = new StringBuilder("/infra/settings/firewall/cpu-mem-thresholds-profile-binding-maps/{cpu-mem-thresholds-profile-binding-map-id}");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Get
            };
            GetPolicyFirewallCpumemThresholdsProfileBindingMapServiceURL.Replace("{cpu-mem-thresholds-profile-binding-map-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(CpuMemThresholdsProfileBindingMapId, System.Globalization.CultureInfo.InvariantCulture)));
            request.Resource = GetPolicyFirewallCpumemThresholdsProfileBindingMapServiceURL.ToString();
            RestResponse<NSXTPolicyFirewallCPUMemThresholdsProfileBindingMapType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTPolicyFirewallCPUMemThresholdsProfileBindingMapType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Get operation to " + GetPolicyFirewallCpumemThresholdsProfileBindingMapServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task DeletePolicyFirewallCpumemThresholdsProfileBindingMap(string CpuMemThresholdsProfileBindingMapId)
        {
            if (CpuMemThresholdsProfileBindingMapId == null) { throw new System.ArgumentNullException("CpuMemThresholdsProfileBindingMapId cannot be null"); }
            StringBuilder DeletePolicyFirewallCpumemThresholdsProfileBindingMapServiceURL = new StringBuilder("/infra/settings/firewall/cpu-mem-thresholds-profile-binding-maps/{cpu-mem-thresholds-profile-binding-map-id}");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Delete
            };
            DeletePolicyFirewallCpumemThresholdsProfileBindingMapServiceURL.Replace("{cpu-mem-thresholds-profile-binding-map-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(CpuMemThresholdsProfileBindingMapId, System.Globalization.CultureInfo.InvariantCulture)));
            request.Resource = DeletePolicyFirewallCpumemThresholdsProfileBindingMapServiceURL.ToString();
            RestResponse response = await restClient.ExecuteTaskAsyncWithPolicy(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Delete operation to " + DeletePolicyFirewallCpumemThresholdsProfileBindingMapServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task PatchPolicyFirewallCpumemThresholdsProfileBindingMap(string CpuMemThresholdsProfileBindingMapId, NSXTPolicyFirewallCPUMemThresholdsProfileBindingMapType PolicyFirewallCpumemThresholdsProfileBindingMap)
        {
            if (CpuMemThresholdsProfileBindingMapId == null) { throw new System.ArgumentNullException("CpuMemThresholdsProfileBindingMapId cannot be null"); }
            if (PolicyFirewallCpumemThresholdsProfileBindingMap == null) { throw new System.ArgumentNullException("PolicyFirewallCpumemThresholdsProfileBindingMap cannot be null"); }
            StringBuilder PatchPolicyFirewallCpumemThresholdsProfileBindingMapServiceURL = new StringBuilder("/infra/settings/firewall/cpu-mem-thresholds-profile-binding-maps/{cpu-mem-thresholds-profile-binding-map-id}");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Patch
            };
            PatchPolicyFirewallCpumemThresholdsProfileBindingMapServiceURL.Replace("{cpu-mem-thresholds-profile-binding-map-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(CpuMemThresholdsProfileBindingMapId, System.Globalization.CultureInfo.InvariantCulture)));
            request.AddJsonBody(PolicyFirewallCpumemThresholdsProfileBindingMap);
            request.Resource = PatchPolicyFirewallCpumemThresholdsProfileBindingMapServiceURL.ToString();
            RestResponse response = await restClient.ExecuteTaskAsyncWithPolicy(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Patch operation to " + PatchPolicyFirewallCpumemThresholdsProfileBindingMapServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTPolicyFirewallCPUMemThresholdsProfileBindingMapListResultType> ListPolicyFirewallCpumemThresholdsProfileBindingMaps(string? Cursor = null, bool? IncludeMarkForDeleteObjects = null, string? IncludedFields = null, long? PageSize = null, bool? SortAscending = null, string? SortBy = null)
        {
            StringBuilder ListPolicyFirewallCpumemThresholdsProfileBindingMapsServiceURL = new StringBuilder("/infra/settings/firewall/cpu-mem-thresholds-profile-binding-maps");
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
            request.Resource = ListPolicyFirewallCpumemThresholdsProfileBindingMapsServiceURL.ToString();
            RestResponse<NSXTPolicyFirewallCPUMemThresholdsProfileBindingMapListResultType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTPolicyFirewallCPUMemThresholdsProfileBindingMapListResultType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Get operation to " + ListPolicyFirewallCpumemThresholdsProfileBindingMapsServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
    }
}
