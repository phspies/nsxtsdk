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
    public class PolicyQoSProfileBinding
    {
        private RestClient restClient;
        private int retry;
        private int timeout;
        private CancellationToken cancellationToken;

        public PolicyQoSProfileBinding(RestClient Client, CancellationToken _cancellationToken, int _timeout, int _retry)
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
        public async Task<NSXTPortQoSProfileBindingMapType> GlobalGlobalInfraUpdatePortQoSbinding(string Tier1Id, string SegmentId, string PortId, string PortQosProfileBindingMapId, NSXTPortQoSProfileBindingMapType PortQoSprofileBindingMap)
        {
            if (Tier1Id == null) { throw new System.ArgumentNullException("Tier1Id cannot be null"); }
            if (SegmentId == null) { throw new System.ArgumentNullException("SegmentId cannot be null"); }
            if (PortId == null) { throw new System.ArgumentNullException("PortId cannot be null"); }
            if (PortQosProfileBindingMapId == null) { throw new System.ArgumentNullException("PortQosProfileBindingMapId cannot be null"); }
            if (PortQoSprofileBindingMap == null) { throw new System.ArgumentNullException("PortQoSprofileBindingMap cannot be null"); }
            StringBuilder GlobalInfraUpdatePortQoSbindingServiceURL = new StringBuilder("/global-infra/tier-1s/{tier-1-id}/segments/{segment-id}/ports/{port-id}/port-qos-profile-binding-maps/{port-qos-profile-binding-map-id}");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Put
            };
            GlobalInfraUpdatePortQoSbindingServiceURL.Replace("{tier-1-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(Tier1Id, System.Globalization.CultureInfo.InvariantCulture)));
            GlobalInfraUpdatePortQoSbindingServiceURL.Replace("{segment-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(SegmentId, System.Globalization.CultureInfo.InvariantCulture)));
            GlobalInfraUpdatePortQoSbindingServiceURL.Replace("{port-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(PortId, System.Globalization.CultureInfo.InvariantCulture)));
            GlobalInfraUpdatePortQoSbindingServiceURL.Replace("{port-qos-profile-binding-map-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(PortQosProfileBindingMapId, System.Globalization.CultureInfo.InvariantCulture)));
            request.AddJsonBody(PortQoSprofileBindingMap);
            request.Resource = GlobalInfraUpdatePortQoSbindingServiceURL.ToString();
            RestResponse<NSXTPortQoSProfileBindingMapType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTPortQoSProfileBindingMapType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Put operation to " + GlobalInfraUpdatePortQoSbindingServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTPortQoSProfileBindingMapType> GlobalGlobalInfraGetPortQoSbinding(string Tier1Id, string SegmentId, string PortId, string PortQosProfileBindingMapId)
        {
            if (Tier1Id == null) { throw new System.ArgumentNullException("Tier1Id cannot be null"); }
            if (SegmentId == null) { throw new System.ArgumentNullException("SegmentId cannot be null"); }
            if (PortId == null) { throw new System.ArgumentNullException("PortId cannot be null"); }
            if (PortQosProfileBindingMapId == null) { throw new System.ArgumentNullException("PortQosProfileBindingMapId cannot be null"); }
            StringBuilder GlobalInfraGetPortQoSbindingServiceURL = new StringBuilder("/global-infra/tier-1s/{tier-1-id}/segments/{segment-id}/ports/{port-id}/port-qos-profile-binding-maps/{port-qos-profile-binding-map-id}");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Get
            };
            GlobalInfraGetPortQoSbindingServiceURL.Replace("{tier-1-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(Tier1Id, System.Globalization.CultureInfo.InvariantCulture)));
            GlobalInfraGetPortQoSbindingServiceURL.Replace("{segment-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(SegmentId, System.Globalization.CultureInfo.InvariantCulture)));
            GlobalInfraGetPortQoSbindingServiceURL.Replace("{port-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(PortId, System.Globalization.CultureInfo.InvariantCulture)));
            GlobalInfraGetPortQoSbindingServiceURL.Replace("{port-qos-profile-binding-map-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(PortQosProfileBindingMapId, System.Globalization.CultureInfo.InvariantCulture)));
            request.Resource = GlobalInfraGetPortQoSbindingServiceURL.ToString();
            RestResponse<NSXTPortQoSProfileBindingMapType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTPortQoSProfileBindingMapType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Get operation to " + GlobalInfraGetPortQoSbindingServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task GlobalGlobalInfraPatchPortQoSbinding(string Tier1Id, string SegmentId, string PortId, string PortQosProfileBindingMapId, NSXTPortQoSProfileBindingMapType PortQoSprofileBindingMap)
        {
            if (Tier1Id == null) { throw new System.ArgumentNullException("Tier1Id cannot be null"); }
            if (SegmentId == null) { throw new System.ArgumentNullException("SegmentId cannot be null"); }
            if (PortId == null) { throw new System.ArgumentNullException("PortId cannot be null"); }
            if (PortQosProfileBindingMapId == null) { throw new System.ArgumentNullException("PortQosProfileBindingMapId cannot be null"); }
            if (PortQoSprofileBindingMap == null) { throw new System.ArgumentNullException("PortQoSprofileBindingMap cannot be null"); }
            StringBuilder GlobalInfraPatchPortQoSbindingServiceURL = new StringBuilder("/global-infra/tier-1s/{tier-1-id}/segments/{segment-id}/ports/{port-id}/port-qos-profile-binding-maps/{port-qos-profile-binding-map-id}");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Patch
            };
            GlobalInfraPatchPortQoSbindingServiceURL.Replace("{tier-1-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(Tier1Id, System.Globalization.CultureInfo.InvariantCulture)));
            GlobalInfraPatchPortQoSbindingServiceURL.Replace("{segment-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(SegmentId, System.Globalization.CultureInfo.InvariantCulture)));
            GlobalInfraPatchPortQoSbindingServiceURL.Replace("{port-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(PortId, System.Globalization.CultureInfo.InvariantCulture)));
            GlobalInfraPatchPortQoSbindingServiceURL.Replace("{port-qos-profile-binding-map-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(PortQosProfileBindingMapId, System.Globalization.CultureInfo.InvariantCulture)));
            request.AddJsonBody(PortQoSprofileBindingMap);
            request.Resource = GlobalInfraPatchPortQoSbindingServiceURL.ToString();
            RestResponse response = await restClient.ExecuteTaskAsyncWithPolicy(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Patch operation to " + GlobalInfraPatchPortQoSbindingServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task GlobalGlobalInfraDeletePortQoSbinding(string Tier1Id, string SegmentId, string PortId, string PortQosProfileBindingMapId)
        {
            if (Tier1Id == null) { throw new System.ArgumentNullException("Tier1Id cannot be null"); }
            if (SegmentId == null) { throw new System.ArgumentNullException("SegmentId cannot be null"); }
            if (PortId == null) { throw new System.ArgumentNullException("PortId cannot be null"); }
            if (PortQosProfileBindingMapId == null) { throw new System.ArgumentNullException("PortQosProfileBindingMapId cannot be null"); }
            StringBuilder GlobalInfraDeletePortQoSbindingServiceURL = new StringBuilder("/global-infra/tier-1s/{tier-1-id}/segments/{segment-id}/ports/{port-id}/port-qos-profile-binding-maps/{port-qos-profile-binding-map-id}");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Delete
            };
            GlobalInfraDeletePortQoSbindingServiceURL.Replace("{tier-1-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(Tier1Id, System.Globalization.CultureInfo.InvariantCulture)));
            GlobalInfraDeletePortQoSbindingServiceURL.Replace("{segment-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(SegmentId, System.Globalization.CultureInfo.InvariantCulture)));
            GlobalInfraDeletePortQoSbindingServiceURL.Replace("{port-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(PortId, System.Globalization.CultureInfo.InvariantCulture)));
            GlobalInfraDeletePortQoSbindingServiceURL.Replace("{port-qos-profile-binding-map-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(PortQosProfileBindingMapId, System.Globalization.CultureInfo.InvariantCulture)));
            request.Resource = GlobalInfraDeletePortQoSbindingServiceURL.ToString();
            RestResponse response = await restClient.ExecuteTaskAsyncWithPolicy(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Delete operation to " + GlobalInfraDeletePortQoSbindingServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTSegmentQoSProfileBindingMapType> UpdateSegmentQoSbinding(string Tier1Id, string SegmentId, string SegmentQosProfileBindingMapId, NSXTSegmentQoSProfileBindingMapType SegmentQoSprofileBindingMap)
        {
            if (Tier1Id == null) { throw new System.ArgumentNullException("Tier1Id cannot be null"); }
            if (SegmentId == null) { throw new System.ArgumentNullException("SegmentId cannot be null"); }
            if (SegmentQosProfileBindingMapId == null) { throw new System.ArgumentNullException("SegmentQosProfileBindingMapId cannot be null"); }
            if (SegmentQoSprofileBindingMap == null) { throw new System.ArgumentNullException("SegmentQoSprofileBindingMap cannot be null"); }
            StringBuilder UpdateSegmentQoSbindingServiceURL = new StringBuilder("/infra/tier-1s/{tier-1-id}/segments/{segment-id}/segment-qos-profile-binding-maps/{segment-qos-profile-binding-map-id}");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Put
            };
            UpdateSegmentQoSbindingServiceURL.Replace("{tier-1-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(Tier1Id, System.Globalization.CultureInfo.InvariantCulture)));
            UpdateSegmentQoSbindingServiceURL.Replace("{segment-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(SegmentId, System.Globalization.CultureInfo.InvariantCulture)));
            UpdateSegmentQoSbindingServiceURL.Replace("{segment-qos-profile-binding-map-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(SegmentQosProfileBindingMapId, System.Globalization.CultureInfo.InvariantCulture)));
            request.AddJsonBody(SegmentQoSprofileBindingMap);
            request.Resource = UpdateSegmentQoSbindingServiceURL.ToString();
            RestResponse<NSXTSegmentQoSProfileBindingMapType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTSegmentQoSProfileBindingMapType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Put operation to " + UpdateSegmentQoSbindingServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task DeleteSegmentQoSbinding(string Tier1Id, string SegmentId, string SegmentQosProfileBindingMapId)
        {
            if (Tier1Id == null) { throw new System.ArgumentNullException("Tier1Id cannot be null"); }
            if (SegmentId == null) { throw new System.ArgumentNullException("SegmentId cannot be null"); }
            if (SegmentQosProfileBindingMapId == null) { throw new System.ArgumentNullException("SegmentQosProfileBindingMapId cannot be null"); }
            StringBuilder DeleteSegmentQoSbindingServiceURL = new StringBuilder("/infra/tier-1s/{tier-1-id}/segments/{segment-id}/segment-qos-profile-binding-maps/{segment-qos-profile-binding-map-id}");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Delete
            };
            DeleteSegmentQoSbindingServiceURL.Replace("{tier-1-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(Tier1Id, System.Globalization.CultureInfo.InvariantCulture)));
            DeleteSegmentQoSbindingServiceURL.Replace("{segment-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(SegmentId, System.Globalization.CultureInfo.InvariantCulture)));
            DeleteSegmentQoSbindingServiceURL.Replace("{segment-qos-profile-binding-map-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(SegmentQosProfileBindingMapId, System.Globalization.CultureInfo.InvariantCulture)));
            request.Resource = DeleteSegmentQoSbindingServiceURL.ToString();
            RestResponse response = await restClient.ExecuteTaskAsyncWithPolicy(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Delete operation to " + DeleteSegmentQoSbindingServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTSegmentQoSProfileBindingMapType> GetSegmentQoSbinding(string Tier1Id, string SegmentId, string SegmentQosProfileBindingMapId)
        {
            if (Tier1Id == null) { throw new System.ArgumentNullException("Tier1Id cannot be null"); }
            if (SegmentId == null) { throw new System.ArgumentNullException("SegmentId cannot be null"); }
            if (SegmentQosProfileBindingMapId == null) { throw new System.ArgumentNullException("SegmentQosProfileBindingMapId cannot be null"); }
            StringBuilder GetSegmentQoSbindingServiceURL = new StringBuilder("/infra/tier-1s/{tier-1-id}/segments/{segment-id}/segment-qos-profile-binding-maps/{segment-qos-profile-binding-map-id}");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Get
            };
            GetSegmentQoSbindingServiceURL.Replace("{tier-1-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(Tier1Id, System.Globalization.CultureInfo.InvariantCulture)));
            GetSegmentQoSbindingServiceURL.Replace("{segment-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(SegmentId, System.Globalization.CultureInfo.InvariantCulture)));
            GetSegmentQoSbindingServiceURL.Replace("{segment-qos-profile-binding-map-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(SegmentQosProfileBindingMapId, System.Globalization.CultureInfo.InvariantCulture)));
            request.Resource = GetSegmentQoSbindingServiceURL.ToString();
            RestResponse<NSXTSegmentQoSProfileBindingMapType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTSegmentQoSProfileBindingMapType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Get operation to " + GetSegmentQoSbindingServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task PatchSegmentQoSbinding(string Tier1Id, string SegmentId, string SegmentQosProfileBindingMapId, NSXTSegmentQoSProfileBindingMapType SegmentQoSprofileBindingMap)
        {
            if (Tier1Id == null) { throw new System.ArgumentNullException("Tier1Id cannot be null"); }
            if (SegmentId == null) { throw new System.ArgumentNullException("SegmentId cannot be null"); }
            if (SegmentQosProfileBindingMapId == null) { throw new System.ArgumentNullException("SegmentQosProfileBindingMapId cannot be null"); }
            if (SegmentQoSprofileBindingMap == null) { throw new System.ArgumentNullException("SegmentQoSprofileBindingMap cannot be null"); }
            StringBuilder PatchSegmentQoSbindingServiceURL = new StringBuilder("/infra/tier-1s/{tier-1-id}/segments/{segment-id}/segment-qos-profile-binding-maps/{segment-qos-profile-binding-map-id}");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Patch
            };
            PatchSegmentQoSbindingServiceURL.Replace("{tier-1-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(Tier1Id, System.Globalization.CultureInfo.InvariantCulture)));
            PatchSegmentQoSbindingServiceURL.Replace("{segment-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(SegmentId, System.Globalization.CultureInfo.InvariantCulture)));
            PatchSegmentQoSbindingServiceURL.Replace("{segment-qos-profile-binding-map-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(SegmentQosProfileBindingMapId, System.Globalization.CultureInfo.InvariantCulture)));
            request.AddJsonBody(SegmentQoSprofileBindingMap);
            request.Resource = PatchSegmentQoSbindingServiceURL.ToString();
            RestResponse response = await restClient.ExecuteTaskAsyncWithPolicy(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Patch operation to " + PatchSegmentQoSbindingServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTPortQoSProfileBindingMapListResultType> GlobalGlobalInfraListPortQoSbindings(string Tier1Id, string SegmentId, string PortId, string? Cursor = null, string? IncludedFields = null, long? PageSize = null, bool? SortAscending = null, string? SortBy = null)
        {
            if (Tier1Id == null) { throw new System.ArgumentNullException("Tier1Id cannot be null"); }
            if (SegmentId == null) { throw new System.ArgumentNullException("SegmentId cannot be null"); }
            if (PortId == null) { throw new System.ArgumentNullException("PortId cannot be null"); }
            StringBuilder GlobalInfraListPortQoSbindingsServiceURL = new StringBuilder("/global-infra/tier-1s/{tier-1-id}/segments/{segment-id}/ports/{port-id}/port-qos-profile-binding-maps");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Get
            };
            GlobalInfraListPortQoSbindingsServiceURL.Replace("{tier-1-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(Tier1Id, System.Globalization.CultureInfo.InvariantCulture)));
            GlobalInfraListPortQoSbindingsServiceURL.Replace("{segment-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(SegmentId, System.Globalization.CultureInfo.InvariantCulture)));
            GlobalInfraListPortQoSbindingsServiceURL.Replace("{port-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(PortId, System.Globalization.CultureInfo.InvariantCulture)));
            if (Cursor != null) { request.AddQueryParameter("cursor", Cursor.ToString()); }
            if (IncludedFields != null) { request.AddQueryParameter("included_fields", IncludedFields.ToString()); }
            if (PageSize != null) { request.AddQueryParameter("page_size", PageSize.ToString()); }
            if (SortAscending != null) { request.AddQueryParameter("sort_ascending", SortAscending.ToString()); }
            if (SortBy != null) { request.AddQueryParameter("sort_by", SortBy.ToString()); }
            request.Resource = GlobalInfraListPortQoSbindingsServiceURL.ToString();
            RestResponse<NSXTPortQoSProfileBindingMapListResultType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTPortQoSProfileBindingMapListResultType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Get operation to " + GlobalInfraListPortQoSbindingsServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTSegmentQoSProfileBindingMapListResultType> GlobalGlobalInfraListInfraSegmentQoSbindings(string SegmentId, string? Cursor = null, string? IncludedFields = null, long? PageSize = null, bool? SortAscending = null, string? SortBy = null)
        {
            if (SegmentId == null) { throw new System.ArgumentNullException("SegmentId cannot be null"); }
            StringBuilder GlobalInfraListInfraSegmentQoSbindingsServiceURL = new StringBuilder("/global-infra/segments/{segment-id}/segment-qos-profile-binding-maps");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Get
            };
            GlobalInfraListInfraSegmentQoSbindingsServiceURL.Replace("{segment-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(SegmentId, System.Globalization.CultureInfo.InvariantCulture)));
            if (Cursor != null) { request.AddQueryParameter("cursor", Cursor.ToString()); }
            if (IncludedFields != null) { request.AddQueryParameter("included_fields", IncludedFields.ToString()); }
            if (PageSize != null) { request.AddQueryParameter("page_size", PageSize.ToString()); }
            if (SortAscending != null) { request.AddQueryParameter("sort_ascending", SortAscending.ToString()); }
            if (SortBy != null) { request.AddQueryParameter("sort_by", SortBy.ToString()); }
            request.Resource = GlobalInfraListInfraSegmentQoSbindingsServiceURL.ToString();
            RestResponse<NSXTSegmentQoSProfileBindingMapListResultType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTSegmentQoSProfileBindingMapListResultType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Get operation to " + GlobalInfraListInfraSegmentQoSbindingsServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTPortQoSProfileBindingMapListResultType> ListPortQoSbindings(string Tier1Id, string SegmentId, string PortId, string? Cursor = null, string? IncludedFields = null, long? PageSize = null, bool? SortAscending = null, string? SortBy = null)
        {
            if (Tier1Id == null) { throw new System.ArgumentNullException("Tier1Id cannot be null"); }
            if (SegmentId == null) { throw new System.ArgumentNullException("SegmentId cannot be null"); }
            if (PortId == null) { throw new System.ArgumentNullException("PortId cannot be null"); }
            StringBuilder ListPortQoSbindingsServiceURL = new StringBuilder("/infra/tier-1s/{tier-1-id}/segments/{segment-id}/ports/{port-id}/port-qos-profile-binding-maps");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Get
            };
            ListPortQoSbindingsServiceURL.Replace("{tier-1-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(Tier1Id, System.Globalization.CultureInfo.InvariantCulture)));
            ListPortQoSbindingsServiceURL.Replace("{segment-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(SegmentId, System.Globalization.CultureInfo.InvariantCulture)));
            ListPortQoSbindingsServiceURL.Replace("{port-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(PortId, System.Globalization.CultureInfo.InvariantCulture)));
            if (Cursor != null) { request.AddQueryParameter("cursor", Cursor.ToString()); }
            if (IncludedFields != null) { request.AddQueryParameter("included_fields", IncludedFields.ToString()); }
            if (PageSize != null) { request.AddQueryParameter("page_size", PageSize.ToString()); }
            if (SortAscending != null) { request.AddQueryParameter("sort_ascending", SortAscending.ToString()); }
            if (SortBy != null) { request.AddQueryParameter("sort_by", SortBy.ToString()); }
            request.Resource = ListPortQoSbindingsServiceURL.ToString();
            RestResponse<NSXTPortQoSProfileBindingMapListResultType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTPortQoSProfileBindingMapListResultType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Get operation to " + ListPortQoSbindingsServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTSegmentQoSProfileBindingMapListResultType> GlobalGlobalInfraListSegmentQoSbindings(string Tier1Id, string SegmentId, string? Cursor = null, string? IncludedFields = null, long? PageSize = null, bool? SortAscending = null, string? SortBy = null)
        {
            if (Tier1Id == null) { throw new System.ArgumentNullException("Tier1Id cannot be null"); }
            if (SegmentId == null) { throw new System.ArgumentNullException("SegmentId cannot be null"); }
            StringBuilder GlobalInfraListSegmentQoSbindingsServiceURL = new StringBuilder("/global-infra/tier-1s/{tier-1-id}/segments/{segment-id}/segment-qos-profile-binding-maps");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Get
            };
            GlobalInfraListSegmentQoSbindingsServiceURL.Replace("{tier-1-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(Tier1Id, System.Globalization.CultureInfo.InvariantCulture)));
            GlobalInfraListSegmentQoSbindingsServiceURL.Replace("{segment-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(SegmentId, System.Globalization.CultureInfo.InvariantCulture)));
            if (Cursor != null) { request.AddQueryParameter("cursor", Cursor.ToString()); }
            if (IncludedFields != null) { request.AddQueryParameter("included_fields", IncludedFields.ToString()); }
            if (PageSize != null) { request.AddQueryParameter("page_size", PageSize.ToString()); }
            if (SortAscending != null) { request.AddQueryParameter("sort_ascending", SortAscending.ToString()); }
            if (SortBy != null) { request.AddQueryParameter("sort_by", SortBy.ToString()); }
            request.Resource = GlobalInfraListSegmentQoSbindingsServiceURL.ToString();
            RestResponse<NSXTSegmentQoSProfileBindingMapListResultType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTSegmentQoSProfileBindingMapListResultType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Get operation to " + GlobalInfraListSegmentQoSbindingsServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTSegmentQoSProfileBindingMapType> GlobalGlobalInfraGetSegmentQoSbinding(string Tier1Id, string SegmentId, string SegmentQosProfileBindingMapId)
        {
            if (Tier1Id == null) { throw new System.ArgumentNullException("Tier1Id cannot be null"); }
            if (SegmentId == null) { throw new System.ArgumentNullException("SegmentId cannot be null"); }
            if (SegmentQosProfileBindingMapId == null) { throw new System.ArgumentNullException("SegmentQosProfileBindingMapId cannot be null"); }
            StringBuilder GlobalInfraGetSegmentQoSbindingServiceURL = new StringBuilder("/global-infra/tier-1s/{tier-1-id}/segments/{segment-id}/segment-qos-profile-binding-maps/{segment-qos-profile-binding-map-id}");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Get
            };
            GlobalInfraGetSegmentQoSbindingServiceURL.Replace("{tier-1-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(Tier1Id, System.Globalization.CultureInfo.InvariantCulture)));
            GlobalInfraGetSegmentQoSbindingServiceURL.Replace("{segment-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(SegmentId, System.Globalization.CultureInfo.InvariantCulture)));
            GlobalInfraGetSegmentQoSbindingServiceURL.Replace("{segment-qos-profile-binding-map-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(SegmentQosProfileBindingMapId, System.Globalization.CultureInfo.InvariantCulture)));
            request.Resource = GlobalInfraGetSegmentQoSbindingServiceURL.ToString();
            RestResponse<NSXTSegmentQoSProfileBindingMapType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTSegmentQoSProfileBindingMapType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Get operation to " + GlobalInfraGetSegmentQoSbindingServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTSegmentQoSProfileBindingMapListResultType> ListInfraSegmentQoSbindings(string SegmentId, string? Cursor = null, string? IncludedFields = null, long? PageSize = null, bool? SortAscending = null, string? SortBy = null)
        {
            if (SegmentId == null) { throw new System.ArgumentNullException("SegmentId cannot be null"); }
            StringBuilder ListInfraSegmentQoSbindingsServiceURL = new StringBuilder("/infra/segments/{segment-id}/segment-qos-profile-binding-maps");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Get
            };
            ListInfraSegmentQoSbindingsServiceURL.Replace("{segment-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(SegmentId, System.Globalization.CultureInfo.InvariantCulture)));
            if (Cursor != null) { request.AddQueryParameter("cursor", Cursor.ToString()); }
            if (IncludedFields != null) { request.AddQueryParameter("included_fields", IncludedFields.ToString()); }
            if (PageSize != null) { request.AddQueryParameter("page_size", PageSize.ToString()); }
            if (SortAscending != null) { request.AddQueryParameter("sort_ascending", SortAscending.ToString()); }
            if (SortBy != null) { request.AddQueryParameter("sort_by", SortBy.ToString()); }
            request.Resource = ListInfraSegmentQoSbindingsServiceURL.ToString();
            RestResponse<NSXTSegmentQoSProfileBindingMapListResultType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTSegmentQoSProfileBindingMapListResultType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Get operation to " + ListInfraSegmentQoSbindingsServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTSegmentQoSProfileBindingMapListResultType> ListSegmentQoSbindings(string Tier1Id, string SegmentId, string? Cursor = null, string? IncludedFields = null, long? PageSize = null, bool? SortAscending = null, string? SortBy = null)
        {
            if (Tier1Id == null) { throw new System.ArgumentNullException("Tier1Id cannot be null"); }
            if (SegmentId == null) { throw new System.ArgumentNullException("SegmentId cannot be null"); }
            StringBuilder ListSegmentQoSbindingsServiceURL = new StringBuilder("/infra/tier-1s/{tier-1-id}/segments/{segment-id}/segment-qos-profile-binding-maps");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Get
            };
            ListSegmentQoSbindingsServiceURL.Replace("{tier-1-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(Tier1Id, System.Globalization.CultureInfo.InvariantCulture)));
            ListSegmentQoSbindingsServiceURL.Replace("{segment-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(SegmentId, System.Globalization.CultureInfo.InvariantCulture)));
            if (Cursor != null) { request.AddQueryParameter("cursor", Cursor.ToString()); }
            if (IncludedFields != null) { request.AddQueryParameter("included_fields", IncludedFields.ToString()); }
            if (PageSize != null) { request.AddQueryParameter("page_size", PageSize.ToString()); }
            if (SortAscending != null) { request.AddQueryParameter("sort_ascending", SortAscending.ToString()); }
            if (SortBy != null) { request.AddQueryParameter("sort_by", SortBy.ToString()); }
            request.Resource = ListSegmentQoSbindingsServiceURL.ToString();
            RestResponse<NSXTSegmentQoSProfileBindingMapListResultType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTSegmentQoSProfileBindingMapListResultType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Get operation to " + ListSegmentQoSbindingsServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTPortQoSProfileBindingMapType> GlobalGlobalInfraUpdateInfraPortQoSbinding(string SegmentId, string PortId, string PortQosProfileBindingMapId, NSXTPortQoSProfileBindingMapType PortQoSprofileBindingMap)
        {
            if (SegmentId == null) { throw new System.ArgumentNullException("SegmentId cannot be null"); }
            if (PortId == null) { throw new System.ArgumentNullException("PortId cannot be null"); }
            if (PortQosProfileBindingMapId == null) { throw new System.ArgumentNullException("PortQosProfileBindingMapId cannot be null"); }
            if (PortQoSprofileBindingMap == null) { throw new System.ArgumentNullException("PortQoSprofileBindingMap cannot be null"); }
            StringBuilder GlobalInfraUpdateInfraPortQoSbindingServiceURL = new StringBuilder("/global-infra/segments/{segment-id}/ports/{port-id}/port-qos-profile-binding-maps/{port-qos-profile-binding-map-id}");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Put
            };
            GlobalInfraUpdateInfraPortQoSbindingServiceURL.Replace("{segment-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(SegmentId, System.Globalization.CultureInfo.InvariantCulture)));
            GlobalInfraUpdateInfraPortQoSbindingServiceURL.Replace("{port-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(PortId, System.Globalization.CultureInfo.InvariantCulture)));
            GlobalInfraUpdateInfraPortQoSbindingServiceURL.Replace("{port-qos-profile-binding-map-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(PortQosProfileBindingMapId, System.Globalization.CultureInfo.InvariantCulture)));
            request.AddJsonBody(PortQoSprofileBindingMap);
            request.Resource = GlobalInfraUpdateInfraPortQoSbindingServiceURL.ToString();
            RestResponse<NSXTPortQoSProfileBindingMapType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTPortQoSProfileBindingMapType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Put operation to " + GlobalInfraUpdateInfraPortQoSbindingServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task GlobalGlobalInfraDeleteInfraPortQoSbinding(string SegmentId, string PortId, string PortQosProfileBindingMapId)
        {
            if (SegmentId == null) { throw new System.ArgumentNullException("SegmentId cannot be null"); }
            if (PortId == null) { throw new System.ArgumentNullException("PortId cannot be null"); }
            if (PortQosProfileBindingMapId == null) { throw new System.ArgumentNullException("PortQosProfileBindingMapId cannot be null"); }
            StringBuilder GlobalInfraDeleteInfraPortQoSbindingServiceURL = new StringBuilder("/global-infra/segments/{segment-id}/ports/{port-id}/port-qos-profile-binding-maps/{port-qos-profile-binding-map-id}");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Delete
            };
            GlobalInfraDeleteInfraPortQoSbindingServiceURL.Replace("{segment-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(SegmentId, System.Globalization.CultureInfo.InvariantCulture)));
            GlobalInfraDeleteInfraPortQoSbindingServiceURL.Replace("{port-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(PortId, System.Globalization.CultureInfo.InvariantCulture)));
            GlobalInfraDeleteInfraPortQoSbindingServiceURL.Replace("{port-qos-profile-binding-map-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(PortQosProfileBindingMapId, System.Globalization.CultureInfo.InvariantCulture)));
            request.Resource = GlobalInfraDeleteInfraPortQoSbindingServiceURL.ToString();
            RestResponse response = await restClient.ExecuteTaskAsyncWithPolicy(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Delete operation to " + GlobalInfraDeleteInfraPortQoSbindingServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task GlobalGlobalInfraPatchInfraPortQoSbinding(string SegmentId, string PortId, string PortQosProfileBindingMapId, NSXTPortQoSProfileBindingMapType PortQoSprofileBindingMap)
        {
            if (SegmentId == null) { throw new System.ArgumentNullException("SegmentId cannot be null"); }
            if (PortId == null) { throw new System.ArgumentNullException("PortId cannot be null"); }
            if (PortQosProfileBindingMapId == null) { throw new System.ArgumentNullException("PortQosProfileBindingMapId cannot be null"); }
            if (PortQoSprofileBindingMap == null) { throw new System.ArgumentNullException("PortQoSprofileBindingMap cannot be null"); }
            StringBuilder GlobalInfraPatchInfraPortQoSbindingServiceURL = new StringBuilder("/global-infra/segments/{segment-id}/ports/{port-id}/port-qos-profile-binding-maps/{port-qos-profile-binding-map-id}");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Patch
            };
            GlobalInfraPatchInfraPortQoSbindingServiceURL.Replace("{segment-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(SegmentId, System.Globalization.CultureInfo.InvariantCulture)));
            GlobalInfraPatchInfraPortQoSbindingServiceURL.Replace("{port-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(PortId, System.Globalization.CultureInfo.InvariantCulture)));
            GlobalInfraPatchInfraPortQoSbindingServiceURL.Replace("{port-qos-profile-binding-map-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(PortQosProfileBindingMapId, System.Globalization.CultureInfo.InvariantCulture)));
            request.AddJsonBody(PortQoSprofileBindingMap);
            request.Resource = GlobalInfraPatchInfraPortQoSbindingServiceURL.ToString();
            RestResponse response = await restClient.ExecuteTaskAsyncWithPolicy(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Patch operation to " + GlobalInfraPatchInfraPortQoSbindingServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTPortQoSProfileBindingMapType> GlobalGlobalInfraGetInfraPortQoSbinding(string SegmentId, string PortId, string PortQosProfileBindingMapId)
        {
            if (SegmentId == null) { throw new System.ArgumentNullException("SegmentId cannot be null"); }
            if (PortId == null) { throw new System.ArgumentNullException("PortId cannot be null"); }
            if (PortQosProfileBindingMapId == null) { throw new System.ArgumentNullException("PortQosProfileBindingMapId cannot be null"); }
            StringBuilder GlobalInfraGetInfraPortQoSbindingServiceURL = new StringBuilder("/global-infra/segments/{segment-id}/ports/{port-id}/port-qos-profile-binding-maps/{port-qos-profile-binding-map-id}");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Get
            };
            GlobalInfraGetInfraPortQoSbindingServiceURL.Replace("{segment-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(SegmentId, System.Globalization.CultureInfo.InvariantCulture)));
            GlobalInfraGetInfraPortQoSbindingServiceURL.Replace("{port-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(PortId, System.Globalization.CultureInfo.InvariantCulture)));
            GlobalInfraGetInfraPortQoSbindingServiceURL.Replace("{port-qos-profile-binding-map-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(PortQosProfileBindingMapId, System.Globalization.CultureInfo.InvariantCulture)));
            request.Resource = GlobalInfraGetInfraPortQoSbindingServiceURL.ToString();
            RestResponse<NSXTPortQoSProfileBindingMapType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTPortQoSProfileBindingMapType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Get operation to " + GlobalInfraGetInfraPortQoSbindingServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTSegmentQoSProfileBindingMapType> UpdateInfraSegmentQoSbinding(string SegmentId, string SegmentQosProfileBindingMapId, NSXTSegmentQoSProfileBindingMapType SegmentQoSprofileBindingMap)
        {
            if (SegmentId == null) { throw new System.ArgumentNullException("SegmentId cannot be null"); }
            if (SegmentQosProfileBindingMapId == null) { throw new System.ArgumentNullException("SegmentQosProfileBindingMapId cannot be null"); }
            if (SegmentQoSprofileBindingMap == null) { throw new System.ArgumentNullException("SegmentQoSprofileBindingMap cannot be null"); }
            StringBuilder UpdateInfraSegmentQoSbindingServiceURL = new StringBuilder("/infra/segments/{segment-id}/segment-qos-profile-binding-maps/{segment-qos-profile-binding-map-id}");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Put
            };
            UpdateInfraSegmentQoSbindingServiceURL.Replace("{segment-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(SegmentId, System.Globalization.CultureInfo.InvariantCulture)));
            UpdateInfraSegmentQoSbindingServiceURL.Replace("{segment-qos-profile-binding-map-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(SegmentQosProfileBindingMapId, System.Globalization.CultureInfo.InvariantCulture)));
            request.AddJsonBody(SegmentQoSprofileBindingMap);
            request.Resource = UpdateInfraSegmentQoSbindingServiceURL.ToString();
            RestResponse<NSXTSegmentQoSProfileBindingMapType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTSegmentQoSProfileBindingMapType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Put operation to " + UpdateInfraSegmentQoSbindingServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task DeleteInfraSegmentQoSbinding(string SegmentId, string SegmentQosProfileBindingMapId)
        {
            if (SegmentId == null) { throw new System.ArgumentNullException("SegmentId cannot be null"); }
            if (SegmentQosProfileBindingMapId == null) { throw new System.ArgumentNullException("SegmentQosProfileBindingMapId cannot be null"); }
            StringBuilder DeleteInfraSegmentQoSbindingServiceURL = new StringBuilder("/infra/segments/{segment-id}/segment-qos-profile-binding-maps/{segment-qos-profile-binding-map-id}");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Delete
            };
            DeleteInfraSegmentQoSbindingServiceURL.Replace("{segment-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(SegmentId, System.Globalization.CultureInfo.InvariantCulture)));
            DeleteInfraSegmentQoSbindingServiceURL.Replace("{segment-qos-profile-binding-map-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(SegmentQosProfileBindingMapId, System.Globalization.CultureInfo.InvariantCulture)));
            request.Resource = DeleteInfraSegmentQoSbindingServiceURL.ToString();
            RestResponse response = await restClient.ExecuteTaskAsyncWithPolicy(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Delete operation to " + DeleteInfraSegmentQoSbindingServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task PatchInfraSegmentQoSbinding(string SegmentId, string SegmentQosProfileBindingMapId, NSXTSegmentQoSProfileBindingMapType SegmentQoSprofileBindingMap)
        {
            if (SegmentId == null) { throw new System.ArgumentNullException("SegmentId cannot be null"); }
            if (SegmentQosProfileBindingMapId == null) { throw new System.ArgumentNullException("SegmentQosProfileBindingMapId cannot be null"); }
            if (SegmentQoSprofileBindingMap == null) { throw new System.ArgumentNullException("SegmentQoSprofileBindingMap cannot be null"); }
            StringBuilder PatchInfraSegmentQoSbindingServiceURL = new StringBuilder("/infra/segments/{segment-id}/segment-qos-profile-binding-maps/{segment-qos-profile-binding-map-id}");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Patch
            };
            PatchInfraSegmentQoSbindingServiceURL.Replace("{segment-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(SegmentId, System.Globalization.CultureInfo.InvariantCulture)));
            PatchInfraSegmentQoSbindingServiceURL.Replace("{segment-qos-profile-binding-map-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(SegmentQosProfileBindingMapId, System.Globalization.CultureInfo.InvariantCulture)));
            request.AddJsonBody(SegmentQoSprofileBindingMap);
            request.Resource = PatchInfraSegmentQoSbindingServiceURL.ToString();
            RestResponse response = await restClient.ExecuteTaskAsyncWithPolicy(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Patch operation to " + PatchInfraSegmentQoSbindingServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTSegmentQoSProfileBindingMapType> GetInfraSegmentQoSbinding(string SegmentId, string SegmentQosProfileBindingMapId)
        {
            if (SegmentId == null) { throw new System.ArgumentNullException("SegmentId cannot be null"); }
            if (SegmentQosProfileBindingMapId == null) { throw new System.ArgumentNullException("SegmentQosProfileBindingMapId cannot be null"); }
            StringBuilder GetInfraSegmentQoSbindingServiceURL = new StringBuilder("/infra/segments/{segment-id}/segment-qos-profile-binding-maps/{segment-qos-profile-binding-map-id}");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Get
            };
            GetInfraSegmentQoSbindingServiceURL.Replace("{segment-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(SegmentId, System.Globalization.CultureInfo.InvariantCulture)));
            GetInfraSegmentQoSbindingServiceURL.Replace("{segment-qos-profile-binding-map-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(SegmentQosProfileBindingMapId, System.Globalization.CultureInfo.InvariantCulture)));
            request.Resource = GetInfraSegmentQoSbindingServiceURL.ToString();
            RestResponse<NSXTSegmentQoSProfileBindingMapType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTSegmentQoSProfileBindingMapType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Get operation to " + GetInfraSegmentQoSbindingServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTPortQoSProfileBindingMapType> UpdateInfraPortQoSbinding(string SegmentId, string PortId, string PortQosProfileBindingMapId, NSXTPortQoSProfileBindingMapType PortQoSprofileBindingMap)
        {
            if (SegmentId == null) { throw new System.ArgumentNullException("SegmentId cannot be null"); }
            if (PortId == null) { throw new System.ArgumentNullException("PortId cannot be null"); }
            if (PortQosProfileBindingMapId == null) { throw new System.ArgumentNullException("PortQosProfileBindingMapId cannot be null"); }
            if (PortQoSprofileBindingMap == null) { throw new System.ArgumentNullException("PortQoSprofileBindingMap cannot be null"); }
            StringBuilder UpdateInfraPortQoSbindingServiceURL = new StringBuilder("/infra/segments/{segment-id}/ports/{port-id}/port-qos-profile-binding-maps/{port-qos-profile-binding-map-id}");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Put
            };
            UpdateInfraPortQoSbindingServiceURL.Replace("{segment-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(SegmentId, System.Globalization.CultureInfo.InvariantCulture)));
            UpdateInfraPortQoSbindingServiceURL.Replace("{port-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(PortId, System.Globalization.CultureInfo.InvariantCulture)));
            UpdateInfraPortQoSbindingServiceURL.Replace("{port-qos-profile-binding-map-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(PortQosProfileBindingMapId, System.Globalization.CultureInfo.InvariantCulture)));
            request.AddJsonBody(PortQoSprofileBindingMap);
            request.Resource = UpdateInfraPortQoSbindingServiceURL.ToString();
            RestResponse<NSXTPortQoSProfileBindingMapType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTPortQoSProfileBindingMapType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Put operation to " + UpdateInfraPortQoSbindingServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task DeleteInfraPortQoSbinding(string SegmentId, string PortId, string PortQosProfileBindingMapId)
        {
            if (SegmentId == null) { throw new System.ArgumentNullException("SegmentId cannot be null"); }
            if (PortId == null) { throw new System.ArgumentNullException("PortId cannot be null"); }
            if (PortQosProfileBindingMapId == null) { throw new System.ArgumentNullException("PortQosProfileBindingMapId cannot be null"); }
            StringBuilder DeleteInfraPortQoSbindingServiceURL = new StringBuilder("/infra/segments/{segment-id}/ports/{port-id}/port-qos-profile-binding-maps/{port-qos-profile-binding-map-id}");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Delete
            };
            DeleteInfraPortQoSbindingServiceURL.Replace("{segment-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(SegmentId, System.Globalization.CultureInfo.InvariantCulture)));
            DeleteInfraPortQoSbindingServiceURL.Replace("{port-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(PortId, System.Globalization.CultureInfo.InvariantCulture)));
            DeleteInfraPortQoSbindingServiceURL.Replace("{port-qos-profile-binding-map-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(PortQosProfileBindingMapId, System.Globalization.CultureInfo.InvariantCulture)));
            request.Resource = DeleteInfraPortQoSbindingServiceURL.ToString();
            RestResponse response = await restClient.ExecuteTaskAsyncWithPolicy(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Delete operation to " + DeleteInfraPortQoSbindingServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task PatchInfraPortQoSbinding(string SegmentId, string PortId, string PortQosProfileBindingMapId, NSXTPortQoSProfileBindingMapType PortQoSprofileBindingMap)
        {
            if (SegmentId == null) { throw new System.ArgumentNullException("SegmentId cannot be null"); }
            if (PortId == null) { throw new System.ArgumentNullException("PortId cannot be null"); }
            if (PortQosProfileBindingMapId == null) { throw new System.ArgumentNullException("PortQosProfileBindingMapId cannot be null"); }
            if (PortQoSprofileBindingMap == null) { throw new System.ArgumentNullException("PortQoSprofileBindingMap cannot be null"); }
            StringBuilder PatchInfraPortQoSbindingServiceURL = new StringBuilder("/infra/segments/{segment-id}/ports/{port-id}/port-qos-profile-binding-maps/{port-qos-profile-binding-map-id}");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Patch
            };
            PatchInfraPortQoSbindingServiceURL.Replace("{segment-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(SegmentId, System.Globalization.CultureInfo.InvariantCulture)));
            PatchInfraPortQoSbindingServiceURL.Replace("{port-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(PortId, System.Globalization.CultureInfo.InvariantCulture)));
            PatchInfraPortQoSbindingServiceURL.Replace("{port-qos-profile-binding-map-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(PortQosProfileBindingMapId, System.Globalization.CultureInfo.InvariantCulture)));
            request.AddJsonBody(PortQoSprofileBindingMap);
            request.Resource = PatchInfraPortQoSbindingServiceURL.ToString();
            RestResponse response = await restClient.ExecuteTaskAsyncWithPolicy(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Patch operation to " + PatchInfraPortQoSbindingServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTPortQoSProfileBindingMapType> GetInfraPortQoSbinding(string SegmentId, string PortId, string PortQosProfileBindingMapId)
        {
            if (SegmentId == null) { throw new System.ArgumentNullException("SegmentId cannot be null"); }
            if (PortId == null) { throw new System.ArgumentNullException("PortId cannot be null"); }
            if (PortQosProfileBindingMapId == null) { throw new System.ArgumentNullException("PortQosProfileBindingMapId cannot be null"); }
            StringBuilder GetInfraPortQoSbindingServiceURL = new StringBuilder("/infra/segments/{segment-id}/ports/{port-id}/port-qos-profile-binding-maps/{port-qos-profile-binding-map-id}");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Get
            };
            GetInfraPortQoSbindingServiceURL.Replace("{segment-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(SegmentId, System.Globalization.CultureInfo.InvariantCulture)));
            GetInfraPortQoSbindingServiceURL.Replace("{port-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(PortId, System.Globalization.CultureInfo.InvariantCulture)));
            GetInfraPortQoSbindingServiceURL.Replace("{port-qos-profile-binding-map-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(PortQosProfileBindingMapId, System.Globalization.CultureInfo.InvariantCulture)));
            request.Resource = GetInfraPortQoSbindingServiceURL.ToString();
            RestResponse<NSXTPortQoSProfileBindingMapType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTPortQoSProfileBindingMapType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Get operation to " + GetInfraPortQoSbindingServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTPortQoSProfileBindingMapListResultType> ListInfraPortQoSbindings(string SegmentId, string PortId, string? Cursor = null, string? IncludedFields = null, long? PageSize = null, bool? SortAscending = null, string? SortBy = null)
        {
            if (SegmentId == null) { throw new System.ArgumentNullException("SegmentId cannot be null"); }
            if (PortId == null) { throw new System.ArgumentNullException("PortId cannot be null"); }
            StringBuilder ListInfraPortQoSbindingsServiceURL = new StringBuilder("/infra/segments/{segment-id}/ports/{port-id}/port-qos-profile-binding-maps");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Get
            };
            ListInfraPortQoSbindingsServiceURL.Replace("{segment-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(SegmentId, System.Globalization.CultureInfo.InvariantCulture)));
            ListInfraPortQoSbindingsServiceURL.Replace("{port-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(PortId, System.Globalization.CultureInfo.InvariantCulture)));
            if (Cursor != null) { request.AddQueryParameter("cursor", Cursor.ToString()); }
            if (IncludedFields != null) { request.AddQueryParameter("included_fields", IncludedFields.ToString()); }
            if (PageSize != null) { request.AddQueryParameter("page_size", PageSize.ToString()); }
            if (SortAscending != null) { request.AddQueryParameter("sort_ascending", SortAscending.ToString()); }
            if (SortBy != null) { request.AddQueryParameter("sort_by", SortBy.ToString()); }
            request.Resource = ListInfraPortQoSbindingsServiceURL.ToString();
            RestResponse<NSXTPortQoSProfileBindingMapListResultType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTPortQoSProfileBindingMapListResultType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Get operation to " + ListInfraPortQoSbindingsServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTSegmentQoSProfileBindingMapType> GlobalGlobalInfraGetInfraSegmentQoSbinding(string SegmentId, string SegmentQosProfileBindingMapId)
        {
            if (SegmentId == null) { throw new System.ArgumentNullException("SegmentId cannot be null"); }
            if (SegmentQosProfileBindingMapId == null) { throw new System.ArgumentNullException("SegmentQosProfileBindingMapId cannot be null"); }
            StringBuilder GlobalInfraGetInfraSegmentQoSbindingServiceURL = new StringBuilder("/global-infra/segments/{segment-id}/segment-qos-profile-binding-maps/{segment-qos-profile-binding-map-id}");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Get
            };
            GlobalInfraGetInfraSegmentQoSbindingServiceURL.Replace("{segment-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(SegmentId, System.Globalization.CultureInfo.InvariantCulture)));
            GlobalInfraGetInfraSegmentQoSbindingServiceURL.Replace("{segment-qos-profile-binding-map-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(SegmentQosProfileBindingMapId, System.Globalization.CultureInfo.InvariantCulture)));
            request.Resource = GlobalInfraGetInfraSegmentQoSbindingServiceURL.ToString();
            RestResponse<NSXTSegmentQoSProfileBindingMapType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTSegmentQoSProfileBindingMapType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Get operation to " + GlobalInfraGetInfraSegmentQoSbindingServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTPortQoSProfileBindingMapListResultType> GlobalGlobalInfraListInfraPortQoSbindings(string SegmentId, string PortId, string? Cursor = null, string? IncludedFields = null, long? PageSize = null, bool? SortAscending = null, string? SortBy = null)
        {
            if (SegmentId == null) { throw new System.ArgumentNullException("SegmentId cannot be null"); }
            if (PortId == null) { throw new System.ArgumentNullException("PortId cannot be null"); }
            StringBuilder GlobalInfraListInfraPortQoSbindingsServiceURL = new StringBuilder("/global-infra/segments/{segment-id}/ports/{port-id}/port-qos-profile-binding-maps");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Get
            };
            GlobalInfraListInfraPortQoSbindingsServiceURL.Replace("{segment-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(SegmentId, System.Globalization.CultureInfo.InvariantCulture)));
            GlobalInfraListInfraPortQoSbindingsServiceURL.Replace("{port-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(PortId, System.Globalization.CultureInfo.InvariantCulture)));
            if (Cursor != null) { request.AddQueryParameter("cursor", Cursor.ToString()); }
            if (IncludedFields != null) { request.AddQueryParameter("included_fields", IncludedFields.ToString()); }
            if (PageSize != null) { request.AddQueryParameter("page_size", PageSize.ToString()); }
            if (SortAscending != null) { request.AddQueryParameter("sort_ascending", SortAscending.ToString()); }
            if (SortBy != null) { request.AddQueryParameter("sort_by", SortBy.ToString()); }
            request.Resource = GlobalInfraListInfraPortQoSbindingsServiceURL.ToString();
            RestResponse<NSXTPortQoSProfileBindingMapListResultType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTPortQoSProfileBindingMapListResultType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Get operation to " + GlobalInfraListInfraPortQoSbindingsServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTPortQoSProfileBindingMapType> UpdatePortQoSbinding(string Tier1Id, string SegmentId, string PortId, string PortQosProfileBindingMapId, NSXTPortQoSProfileBindingMapType PortQoSprofileBindingMap)
        {
            if (Tier1Id == null) { throw new System.ArgumentNullException("Tier1Id cannot be null"); }
            if (SegmentId == null) { throw new System.ArgumentNullException("SegmentId cannot be null"); }
            if (PortId == null) { throw new System.ArgumentNullException("PortId cannot be null"); }
            if (PortQosProfileBindingMapId == null) { throw new System.ArgumentNullException("PortQosProfileBindingMapId cannot be null"); }
            if (PortQoSprofileBindingMap == null) { throw new System.ArgumentNullException("PortQoSprofileBindingMap cannot be null"); }
            StringBuilder UpdatePortQoSbindingServiceURL = new StringBuilder("/infra/tier-1s/{tier-1-id}/segments/{segment-id}/ports/{port-id}/port-qos-profile-binding-maps/{port-qos-profile-binding-map-id}");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Put
            };
            UpdatePortQoSbindingServiceURL.Replace("{tier-1-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(Tier1Id, System.Globalization.CultureInfo.InvariantCulture)));
            UpdatePortQoSbindingServiceURL.Replace("{segment-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(SegmentId, System.Globalization.CultureInfo.InvariantCulture)));
            UpdatePortQoSbindingServiceURL.Replace("{port-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(PortId, System.Globalization.CultureInfo.InvariantCulture)));
            UpdatePortQoSbindingServiceURL.Replace("{port-qos-profile-binding-map-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(PortQosProfileBindingMapId, System.Globalization.CultureInfo.InvariantCulture)));
            request.AddJsonBody(PortQoSprofileBindingMap);
            request.Resource = UpdatePortQoSbindingServiceURL.ToString();
            RestResponse<NSXTPortQoSProfileBindingMapType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTPortQoSProfileBindingMapType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Put operation to " + UpdatePortQoSbindingServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTPortQoSProfileBindingMapType> GetPortQoSbinding(string Tier1Id, string SegmentId, string PortId, string PortQosProfileBindingMapId)
        {
            if (Tier1Id == null) { throw new System.ArgumentNullException("Tier1Id cannot be null"); }
            if (SegmentId == null) { throw new System.ArgumentNullException("SegmentId cannot be null"); }
            if (PortId == null) { throw new System.ArgumentNullException("PortId cannot be null"); }
            if (PortQosProfileBindingMapId == null) { throw new System.ArgumentNullException("PortQosProfileBindingMapId cannot be null"); }
            StringBuilder GetPortQoSbindingServiceURL = new StringBuilder("/infra/tier-1s/{tier-1-id}/segments/{segment-id}/ports/{port-id}/port-qos-profile-binding-maps/{port-qos-profile-binding-map-id}");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Get
            };
            GetPortQoSbindingServiceURL.Replace("{tier-1-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(Tier1Id, System.Globalization.CultureInfo.InvariantCulture)));
            GetPortQoSbindingServiceURL.Replace("{segment-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(SegmentId, System.Globalization.CultureInfo.InvariantCulture)));
            GetPortQoSbindingServiceURL.Replace("{port-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(PortId, System.Globalization.CultureInfo.InvariantCulture)));
            GetPortQoSbindingServiceURL.Replace("{port-qos-profile-binding-map-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(PortQosProfileBindingMapId, System.Globalization.CultureInfo.InvariantCulture)));
            request.Resource = GetPortQoSbindingServiceURL.ToString();
            RestResponse<NSXTPortQoSProfileBindingMapType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTPortQoSProfileBindingMapType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Get operation to " + GetPortQoSbindingServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task PatchPortQoSbinding(string Tier1Id, string SegmentId, string PortId, string PortQosProfileBindingMapId, NSXTPortQoSProfileBindingMapType PortQoSprofileBindingMap)
        {
            if (Tier1Id == null) { throw new System.ArgumentNullException("Tier1Id cannot be null"); }
            if (SegmentId == null) { throw new System.ArgumentNullException("SegmentId cannot be null"); }
            if (PortId == null) { throw new System.ArgumentNullException("PortId cannot be null"); }
            if (PortQosProfileBindingMapId == null) { throw new System.ArgumentNullException("PortQosProfileBindingMapId cannot be null"); }
            if (PortQoSprofileBindingMap == null) { throw new System.ArgumentNullException("PortQoSprofileBindingMap cannot be null"); }
            StringBuilder PatchPortQoSbindingServiceURL = new StringBuilder("/infra/tier-1s/{tier-1-id}/segments/{segment-id}/ports/{port-id}/port-qos-profile-binding-maps/{port-qos-profile-binding-map-id}");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Patch
            };
            PatchPortQoSbindingServiceURL.Replace("{tier-1-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(Tier1Id, System.Globalization.CultureInfo.InvariantCulture)));
            PatchPortQoSbindingServiceURL.Replace("{segment-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(SegmentId, System.Globalization.CultureInfo.InvariantCulture)));
            PatchPortQoSbindingServiceURL.Replace("{port-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(PortId, System.Globalization.CultureInfo.InvariantCulture)));
            PatchPortQoSbindingServiceURL.Replace("{port-qos-profile-binding-map-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(PortQosProfileBindingMapId, System.Globalization.CultureInfo.InvariantCulture)));
            request.AddJsonBody(PortQoSprofileBindingMap);
            request.Resource = PatchPortQoSbindingServiceURL.ToString();
            RestResponse response = await restClient.ExecuteTaskAsyncWithPolicy(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Patch operation to " + PatchPortQoSbindingServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task DeletePortQoSbinding(string Tier1Id, string SegmentId, string PortId, string PortQosProfileBindingMapId)
        {
            if (Tier1Id == null) { throw new System.ArgumentNullException("Tier1Id cannot be null"); }
            if (SegmentId == null) { throw new System.ArgumentNullException("SegmentId cannot be null"); }
            if (PortId == null) { throw new System.ArgumentNullException("PortId cannot be null"); }
            if (PortQosProfileBindingMapId == null) { throw new System.ArgumentNullException("PortQosProfileBindingMapId cannot be null"); }
            StringBuilder DeletePortQoSbindingServiceURL = new StringBuilder("/infra/tier-1s/{tier-1-id}/segments/{segment-id}/ports/{port-id}/port-qos-profile-binding-maps/{port-qos-profile-binding-map-id}");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Delete
            };
            DeletePortQoSbindingServiceURL.Replace("{tier-1-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(Tier1Id, System.Globalization.CultureInfo.InvariantCulture)));
            DeletePortQoSbindingServiceURL.Replace("{segment-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(SegmentId, System.Globalization.CultureInfo.InvariantCulture)));
            DeletePortQoSbindingServiceURL.Replace("{port-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(PortId, System.Globalization.CultureInfo.InvariantCulture)));
            DeletePortQoSbindingServiceURL.Replace("{port-qos-profile-binding-map-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(PortQosProfileBindingMapId, System.Globalization.CultureInfo.InvariantCulture)));
            request.Resource = DeletePortQoSbindingServiceURL.ToString();
            RestResponse response = await restClient.ExecuteTaskAsyncWithPolicy(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Delete operation to " + DeletePortQoSbindingServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            
        }
    }
}
