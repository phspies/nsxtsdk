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
    public class PolicyMonitoringProfileBinding
    {
        private RestClient restClient;
        private int retry;
        private int timeout;
        private CancellationToken cancellationToken;

        public PolicyMonitoringProfileBinding(RestClient Client, CancellationToken _cancellationToken, int _timeout, int _retry)
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
        public async Task<NSXTPortMonitoringProfileBindingMapType> UpdateInfraPortMonitoringBinding(string InfraSegmentId, string InfraPortId, string PortMonitoringProfileBindingMapId, NSXTPortMonitoringProfileBindingMapType PortMonitoringProfileBindingMap)
        {
            if (InfraSegmentId == null) { throw new System.ArgumentNullException("InfraSegmentId cannot be null"); }
            if (InfraPortId == null) { throw new System.ArgumentNullException("InfraPortId cannot be null"); }
            if (PortMonitoringProfileBindingMapId == null) { throw new System.ArgumentNullException("PortMonitoringProfileBindingMapId cannot be null"); }
            if (PortMonitoringProfileBindingMap == null) { throw new System.ArgumentNullException("PortMonitoringProfileBindingMap cannot be null"); }
            StringBuilder UpdateInfraPortMonitoringBindingServiceURL = new StringBuilder("/infra/segments/{infra-segment-id}/ports/{infra-port-id}/port-monitoring-profile-binding-maps/{port-monitoring-profile-binding-map-id}");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Put
            };
            UpdateInfraPortMonitoringBindingServiceURL.Replace("{infra-segment-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(InfraSegmentId, System.Globalization.CultureInfo.InvariantCulture)));
            UpdateInfraPortMonitoringBindingServiceURL.Replace("{infra-port-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(InfraPortId, System.Globalization.CultureInfo.InvariantCulture)));
            UpdateInfraPortMonitoringBindingServiceURL.Replace("{port-monitoring-profile-binding-map-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(PortMonitoringProfileBindingMapId, System.Globalization.CultureInfo.InvariantCulture)));
            request.AddJsonBody(PortMonitoringProfileBindingMap);
            request.Resource = UpdateInfraPortMonitoringBindingServiceURL.ToString();
            RestResponse<NSXTPortMonitoringProfileBindingMapType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTPortMonitoringProfileBindingMapType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Put operation to " + UpdateInfraPortMonitoringBindingServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task DeleteInfraPortMonitoringBinding(string InfraSegmentId, string InfraPortId, string PortMonitoringProfileBindingMapId)
        {
            if (InfraSegmentId == null) { throw new System.ArgumentNullException("InfraSegmentId cannot be null"); }
            if (InfraPortId == null) { throw new System.ArgumentNullException("InfraPortId cannot be null"); }
            if (PortMonitoringProfileBindingMapId == null) { throw new System.ArgumentNullException("PortMonitoringProfileBindingMapId cannot be null"); }
            StringBuilder DeleteInfraPortMonitoringBindingServiceURL = new StringBuilder("/infra/segments/{infra-segment-id}/ports/{infra-port-id}/port-monitoring-profile-binding-maps/{port-monitoring-profile-binding-map-id}");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Delete
            };
            DeleteInfraPortMonitoringBindingServiceURL.Replace("{infra-segment-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(InfraSegmentId, System.Globalization.CultureInfo.InvariantCulture)));
            DeleteInfraPortMonitoringBindingServiceURL.Replace("{infra-port-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(InfraPortId, System.Globalization.CultureInfo.InvariantCulture)));
            DeleteInfraPortMonitoringBindingServiceURL.Replace("{port-monitoring-profile-binding-map-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(PortMonitoringProfileBindingMapId, System.Globalization.CultureInfo.InvariantCulture)));
            request.Resource = DeleteInfraPortMonitoringBindingServiceURL.ToString();
            RestResponse response = await restClient.ExecuteTaskAsyncWithPolicy(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Delete operation to " + DeleteInfraPortMonitoringBindingServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTPortMonitoringProfileBindingMapType> GetInfraPortMonitoringBinding(string InfraSegmentId, string InfraPortId, string PortMonitoringProfileBindingMapId)
        {
            if (InfraSegmentId == null) { throw new System.ArgumentNullException("InfraSegmentId cannot be null"); }
            if (InfraPortId == null) { throw new System.ArgumentNullException("InfraPortId cannot be null"); }
            if (PortMonitoringProfileBindingMapId == null) { throw new System.ArgumentNullException("PortMonitoringProfileBindingMapId cannot be null"); }
            StringBuilder GetInfraPortMonitoringBindingServiceURL = new StringBuilder("/infra/segments/{infra-segment-id}/ports/{infra-port-id}/port-monitoring-profile-binding-maps/{port-monitoring-profile-binding-map-id}");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Get
            };
            GetInfraPortMonitoringBindingServiceURL.Replace("{infra-segment-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(InfraSegmentId, System.Globalization.CultureInfo.InvariantCulture)));
            GetInfraPortMonitoringBindingServiceURL.Replace("{infra-port-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(InfraPortId, System.Globalization.CultureInfo.InvariantCulture)));
            GetInfraPortMonitoringBindingServiceURL.Replace("{port-monitoring-profile-binding-map-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(PortMonitoringProfileBindingMapId, System.Globalization.CultureInfo.InvariantCulture)));
            request.Resource = GetInfraPortMonitoringBindingServiceURL.ToString();
            RestResponse<NSXTPortMonitoringProfileBindingMapType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTPortMonitoringProfileBindingMapType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Get operation to " + GetInfraPortMonitoringBindingServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task PatchInfraPortMonitoringBinding(string InfraSegmentId, string InfraPortId, string PortMonitoringProfileBindingMapId, NSXTPortMonitoringProfileBindingMapType PortMonitoringProfileBindingMap)
        {
            if (InfraSegmentId == null) { throw new System.ArgumentNullException("InfraSegmentId cannot be null"); }
            if (InfraPortId == null) { throw new System.ArgumentNullException("InfraPortId cannot be null"); }
            if (PortMonitoringProfileBindingMapId == null) { throw new System.ArgumentNullException("PortMonitoringProfileBindingMapId cannot be null"); }
            if (PortMonitoringProfileBindingMap == null) { throw new System.ArgumentNullException("PortMonitoringProfileBindingMap cannot be null"); }
            StringBuilder PatchInfraPortMonitoringBindingServiceURL = new StringBuilder("/infra/segments/{infra-segment-id}/ports/{infra-port-id}/port-monitoring-profile-binding-maps/{port-monitoring-profile-binding-map-id}");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Patch
            };
            PatchInfraPortMonitoringBindingServiceURL.Replace("{infra-segment-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(InfraSegmentId, System.Globalization.CultureInfo.InvariantCulture)));
            PatchInfraPortMonitoringBindingServiceURL.Replace("{infra-port-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(InfraPortId, System.Globalization.CultureInfo.InvariantCulture)));
            PatchInfraPortMonitoringBindingServiceURL.Replace("{port-monitoring-profile-binding-map-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(PortMonitoringProfileBindingMapId, System.Globalization.CultureInfo.InvariantCulture)));
            request.AddJsonBody(PortMonitoringProfileBindingMap);
            request.Resource = PatchInfraPortMonitoringBindingServiceURL.ToString();
            RestResponse response = await restClient.ExecuteTaskAsyncWithPolicy(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Patch operation to " + PatchInfraPortMonitoringBindingServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTPortMonitoringProfileBindingMapListResultType> ListInfraPortMonitoringBindings(string InfraSegmentId, string InfraPortId, string? Cursor = null, bool? IncludeMarkForDeleteObjects = null, string? IncludedFields = null, long? PageSize = null, bool? SortAscending = null, string? SortBy = null)
        {
            if (InfraSegmentId == null) { throw new System.ArgumentNullException("InfraSegmentId cannot be null"); }
            if (InfraPortId == null) { throw new System.ArgumentNullException("InfraPortId cannot be null"); }
            StringBuilder ListInfraPortMonitoringBindingsServiceURL = new StringBuilder("/infra/segments/{infra-segment-id}/ports/{infra-port-id}/port-monitoring-profile-binding-maps");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Get
            };
            ListInfraPortMonitoringBindingsServiceURL.Replace("{infra-segment-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(InfraSegmentId, System.Globalization.CultureInfo.InvariantCulture)));
            ListInfraPortMonitoringBindingsServiceURL.Replace("{infra-port-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(InfraPortId, System.Globalization.CultureInfo.InvariantCulture)));
            if (Cursor != null) { request.AddQueryParameter("cursor", Cursor.ToString()); }
            if (IncludeMarkForDeleteObjects != null) { request.AddQueryParameter("include_mark_for_delete_objects", IncludeMarkForDeleteObjects.ToString()); }
            if (IncludedFields != null) { request.AddQueryParameter("included_fields", IncludedFields.ToString()); }
            if (PageSize != null) { request.AddQueryParameter("page_size", PageSize.ToString()); }
            if (SortAscending != null) { request.AddQueryParameter("sort_ascending", SortAscending.ToString()); }
            if (SortBy != null) { request.AddQueryParameter("sort_by", SortBy.ToString()); }
            request.Resource = ListInfraPortMonitoringBindingsServiceURL.ToString();
            RestResponse<NSXTPortMonitoringProfileBindingMapListResultType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTPortMonitoringProfileBindingMapListResultType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Get operation to " + ListInfraPortMonitoringBindingsServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTPortMonitoringProfileBindingMapListResultType> GlobalGlobalInfraListInfraPortMonitoringBindings(string InfraSegmentId, string InfraPortId, string? Cursor = null, bool? IncludeMarkForDeleteObjects = null, string? IncludedFields = null, long? PageSize = null, bool? SortAscending = null, string? SortBy = null)
        {
            if (InfraSegmentId == null) { throw new System.ArgumentNullException("InfraSegmentId cannot be null"); }
            if (InfraPortId == null) { throw new System.ArgumentNullException("InfraPortId cannot be null"); }
            StringBuilder GlobalInfraListInfraPortMonitoringBindingsServiceURL = new StringBuilder("/global-infra/segments/{infra-segment-id}/ports/{infra-port-id}/port-monitoring-profile-binding-maps");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Get
            };
            GlobalInfraListInfraPortMonitoringBindingsServiceURL.Replace("{infra-segment-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(InfraSegmentId, System.Globalization.CultureInfo.InvariantCulture)));
            GlobalInfraListInfraPortMonitoringBindingsServiceURL.Replace("{infra-port-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(InfraPortId, System.Globalization.CultureInfo.InvariantCulture)));
            if (Cursor != null) { request.AddQueryParameter("cursor", Cursor.ToString()); }
            if (IncludeMarkForDeleteObjects != null) { request.AddQueryParameter("include_mark_for_delete_objects", IncludeMarkForDeleteObjects.ToString()); }
            if (IncludedFields != null) { request.AddQueryParameter("included_fields", IncludedFields.ToString()); }
            if (PageSize != null) { request.AddQueryParameter("page_size", PageSize.ToString()); }
            if (SortAscending != null) { request.AddQueryParameter("sort_ascending", SortAscending.ToString()); }
            if (SortBy != null) { request.AddQueryParameter("sort_by", SortBy.ToString()); }
            request.Resource = GlobalInfraListInfraPortMonitoringBindingsServiceURL.ToString();
            RestResponse<NSXTPortMonitoringProfileBindingMapListResultType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTPortMonitoringProfileBindingMapListResultType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Get operation to " + GlobalInfraListInfraPortMonitoringBindingsServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTSegmentMonitoringProfileBindingMapListResultType> ListSegmentMonitoringBindings(string Tier1Id, string SegmentId, string? Cursor = null, bool? IncludeMarkForDeleteObjects = null, string? IncludedFields = null, long? PageSize = null, bool? SortAscending = null, string? SortBy = null)
        {
            if (Tier1Id == null) { throw new System.ArgumentNullException("Tier1Id cannot be null"); }
            if (SegmentId == null) { throw new System.ArgumentNullException("SegmentId cannot be null"); }
            StringBuilder ListSegmentMonitoringBindingsServiceURL = new StringBuilder("/infra/tier-1s/{tier-1-id}/segments/{segment-id}/segment-monitoring-profile-binding-maps");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Get
            };
            ListSegmentMonitoringBindingsServiceURL.Replace("{tier-1-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(Tier1Id, System.Globalization.CultureInfo.InvariantCulture)));
            ListSegmentMonitoringBindingsServiceURL.Replace("{segment-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(SegmentId, System.Globalization.CultureInfo.InvariantCulture)));
            if (Cursor != null) { request.AddQueryParameter("cursor", Cursor.ToString()); }
            if (IncludeMarkForDeleteObjects != null) { request.AddQueryParameter("include_mark_for_delete_objects", IncludeMarkForDeleteObjects.ToString()); }
            if (IncludedFields != null) { request.AddQueryParameter("included_fields", IncludedFields.ToString()); }
            if (PageSize != null) { request.AddQueryParameter("page_size", PageSize.ToString()); }
            if (SortAscending != null) { request.AddQueryParameter("sort_ascending", SortAscending.ToString()); }
            if (SortBy != null) { request.AddQueryParameter("sort_by", SortBy.ToString()); }
            request.Resource = ListSegmentMonitoringBindingsServiceURL.ToString();
            RestResponse<NSXTSegmentMonitoringProfileBindingMapListResultType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTSegmentMonitoringProfileBindingMapListResultType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Get operation to " + ListSegmentMonitoringBindingsServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTSegmentMonitoringProfileBindingMapListResultType> GlobalGlobalInfraListSegmentMonitoringBindings(string Tier1Id, string SegmentId, string? Cursor = null, bool? IncludeMarkForDeleteObjects = null, string? IncludedFields = null, long? PageSize = null, bool? SortAscending = null, string? SortBy = null)
        {
            if (Tier1Id == null) { throw new System.ArgumentNullException("Tier1Id cannot be null"); }
            if (SegmentId == null) { throw new System.ArgumentNullException("SegmentId cannot be null"); }
            StringBuilder GlobalInfraListSegmentMonitoringBindingsServiceURL = new StringBuilder("/global-infra/tier-1s/{tier-1-id}/segments/{segment-id}/segment-monitoring-profile-binding-maps");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Get
            };
            GlobalInfraListSegmentMonitoringBindingsServiceURL.Replace("{tier-1-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(Tier1Id, System.Globalization.CultureInfo.InvariantCulture)));
            GlobalInfraListSegmentMonitoringBindingsServiceURL.Replace("{segment-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(SegmentId, System.Globalization.CultureInfo.InvariantCulture)));
            if (Cursor != null) { request.AddQueryParameter("cursor", Cursor.ToString()); }
            if (IncludeMarkForDeleteObjects != null) { request.AddQueryParameter("include_mark_for_delete_objects", IncludeMarkForDeleteObjects.ToString()); }
            if (IncludedFields != null) { request.AddQueryParameter("included_fields", IncludedFields.ToString()); }
            if (PageSize != null) { request.AddQueryParameter("page_size", PageSize.ToString()); }
            if (SortAscending != null) { request.AddQueryParameter("sort_ascending", SortAscending.ToString()); }
            if (SortBy != null) { request.AddQueryParameter("sort_by", SortBy.ToString()); }
            request.Resource = GlobalInfraListSegmentMonitoringBindingsServiceURL.ToString();
            RestResponse<NSXTSegmentMonitoringProfileBindingMapListResultType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTSegmentMonitoringProfileBindingMapListResultType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Get operation to " + GlobalInfraListSegmentMonitoringBindingsServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTSegmentMonitoringProfileBindingMapType> GlobalGlobalInfraGetSegmentMonitoringBinding(string Tier1Id, string SegmentId, string SegmentMonitoringProfileBindingMapId)
        {
            if (Tier1Id == null) { throw new System.ArgumentNullException("Tier1Id cannot be null"); }
            if (SegmentId == null) { throw new System.ArgumentNullException("SegmentId cannot be null"); }
            if (SegmentMonitoringProfileBindingMapId == null) { throw new System.ArgumentNullException("SegmentMonitoringProfileBindingMapId cannot be null"); }
            StringBuilder GlobalInfraGetSegmentMonitoringBindingServiceURL = new StringBuilder("/global-infra/tier-1s/{tier-1-id}/segments/{segment-id}/segment-monitoring-profile-binding-maps/{segment-monitoring-profile-binding-map-id}");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Get
            };
            GlobalInfraGetSegmentMonitoringBindingServiceURL.Replace("{tier-1-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(Tier1Id, System.Globalization.CultureInfo.InvariantCulture)));
            GlobalInfraGetSegmentMonitoringBindingServiceURL.Replace("{segment-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(SegmentId, System.Globalization.CultureInfo.InvariantCulture)));
            GlobalInfraGetSegmentMonitoringBindingServiceURL.Replace("{segment-monitoring-profile-binding-map-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(SegmentMonitoringProfileBindingMapId, System.Globalization.CultureInfo.InvariantCulture)));
            request.Resource = GlobalInfraGetSegmentMonitoringBindingServiceURL.ToString();
            RestResponse<NSXTSegmentMonitoringProfileBindingMapType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTSegmentMonitoringProfileBindingMapType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Get operation to " + GlobalInfraGetSegmentMonitoringBindingServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTGroupMonitoringProfileBindingMapType> GlobalGlobalInfraGetGroupMonitoringBinding(string DomainId, string GroupId, string GroupMonitoringProfileBindingMapId)
        {
            if (DomainId == null) { throw new System.ArgumentNullException("DomainId cannot be null"); }
            if (GroupId == null) { throw new System.ArgumentNullException("GroupId cannot be null"); }
            if (GroupMonitoringProfileBindingMapId == null) { throw new System.ArgumentNullException("GroupMonitoringProfileBindingMapId cannot be null"); }
            StringBuilder GlobalInfraGetGroupMonitoringBindingServiceURL = new StringBuilder("/global-infra/domains/{domain-id}/groups/{group-id}/group-monitoring-profile-binding-maps/{group-monitoring-profile-binding-map-id}");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Get
            };
            GlobalInfraGetGroupMonitoringBindingServiceURL.Replace("{domain-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(DomainId, System.Globalization.CultureInfo.InvariantCulture)));
            GlobalInfraGetGroupMonitoringBindingServiceURL.Replace("{group-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(GroupId, System.Globalization.CultureInfo.InvariantCulture)));
            GlobalInfraGetGroupMonitoringBindingServiceURL.Replace("{group-monitoring-profile-binding-map-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(GroupMonitoringProfileBindingMapId, System.Globalization.CultureInfo.InvariantCulture)));
            request.Resource = GlobalInfraGetGroupMonitoringBindingServiceURL.ToString();
            RestResponse<NSXTGroupMonitoringProfileBindingMapType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTGroupMonitoringProfileBindingMapType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Get operation to " + GlobalInfraGetGroupMonitoringBindingServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTSegmentMonitoringProfileBindingMapType> UpdateSegmentMonitoringBinding(string Tier1Id, string SegmentId, string SegmentMonitoringProfileBindingMapId, NSXTSegmentMonitoringProfileBindingMapType SegmentMonitoringProfileBindingMap)
        {
            if (Tier1Id == null) { throw new System.ArgumentNullException("Tier1Id cannot be null"); }
            if (SegmentId == null) { throw new System.ArgumentNullException("SegmentId cannot be null"); }
            if (SegmentMonitoringProfileBindingMapId == null) { throw new System.ArgumentNullException("SegmentMonitoringProfileBindingMapId cannot be null"); }
            if (SegmentMonitoringProfileBindingMap == null) { throw new System.ArgumentNullException("SegmentMonitoringProfileBindingMap cannot be null"); }
            StringBuilder UpdateSegmentMonitoringBindingServiceURL = new StringBuilder("/infra/tier-1s/{tier-1-id}/segments/{segment-id}/segment-monitoring-profile-binding-maps/{segment-monitoring-profile-binding-map-id}");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Put
            };
            UpdateSegmentMonitoringBindingServiceURL.Replace("{tier-1-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(Tier1Id, System.Globalization.CultureInfo.InvariantCulture)));
            UpdateSegmentMonitoringBindingServiceURL.Replace("{segment-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(SegmentId, System.Globalization.CultureInfo.InvariantCulture)));
            UpdateSegmentMonitoringBindingServiceURL.Replace("{segment-monitoring-profile-binding-map-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(SegmentMonitoringProfileBindingMapId, System.Globalization.CultureInfo.InvariantCulture)));
            request.AddJsonBody(SegmentMonitoringProfileBindingMap);
            request.Resource = UpdateSegmentMonitoringBindingServiceURL.ToString();
            RestResponse<NSXTSegmentMonitoringProfileBindingMapType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTSegmentMonitoringProfileBindingMapType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Put operation to " + UpdateSegmentMonitoringBindingServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTSegmentMonitoringProfileBindingMapType> GetSegmentMonitoringBinding(string Tier1Id, string SegmentId, string SegmentMonitoringProfileBindingMapId)
        {
            if (Tier1Id == null) { throw new System.ArgumentNullException("Tier1Id cannot be null"); }
            if (SegmentId == null) { throw new System.ArgumentNullException("SegmentId cannot be null"); }
            if (SegmentMonitoringProfileBindingMapId == null) { throw new System.ArgumentNullException("SegmentMonitoringProfileBindingMapId cannot be null"); }
            StringBuilder GetSegmentMonitoringBindingServiceURL = new StringBuilder("/infra/tier-1s/{tier-1-id}/segments/{segment-id}/segment-monitoring-profile-binding-maps/{segment-monitoring-profile-binding-map-id}");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Get
            };
            GetSegmentMonitoringBindingServiceURL.Replace("{tier-1-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(Tier1Id, System.Globalization.CultureInfo.InvariantCulture)));
            GetSegmentMonitoringBindingServiceURL.Replace("{segment-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(SegmentId, System.Globalization.CultureInfo.InvariantCulture)));
            GetSegmentMonitoringBindingServiceURL.Replace("{segment-monitoring-profile-binding-map-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(SegmentMonitoringProfileBindingMapId, System.Globalization.CultureInfo.InvariantCulture)));
            request.Resource = GetSegmentMonitoringBindingServiceURL.ToString();
            RestResponse<NSXTSegmentMonitoringProfileBindingMapType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTSegmentMonitoringProfileBindingMapType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Get operation to " + GetSegmentMonitoringBindingServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task DeleteSegmentMonitoringBinding(string Tier1Id, string SegmentId, string SegmentMonitoringProfileBindingMapId)
        {
            if (Tier1Id == null) { throw new System.ArgumentNullException("Tier1Id cannot be null"); }
            if (SegmentId == null) { throw new System.ArgumentNullException("SegmentId cannot be null"); }
            if (SegmentMonitoringProfileBindingMapId == null) { throw new System.ArgumentNullException("SegmentMonitoringProfileBindingMapId cannot be null"); }
            StringBuilder DeleteSegmentMonitoringBindingServiceURL = new StringBuilder("/infra/tier-1s/{tier-1-id}/segments/{segment-id}/segment-monitoring-profile-binding-maps/{segment-monitoring-profile-binding-map-id}");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Delete
            };
            DeleteSegmentMonitoringBindingServiceURL.Replace("{tier-1-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(Tier1Id, System.Globalization.CultureInfo.InvariantCulture)));
            DeleteSegmentMonitoringBindingServiceURL.Replace("{segment-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(SegmentId, System.Globalization.CultureInfo.InvariantCulture)));
            DeleteSegmentMonitoringBindingServiceURL.Replace("{segment-monitoring-profile-binding-map-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(SegmentMonitoringProfileBindingMapId, System.Globalization.CultureInfo.InvariantCulture)));
            request.Resource = DeleteSegmentMonitoringBindingServiceURL.ToString();
            RestResponse response = await restClient.ExecuteTaskAsyncWithPolicy(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Delete operation to " + DeleteSegmentMonitoringBindingServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task PatchSegmentMonitoringBinding(string Tier1Id, string SegmentId, string SegmentMonitoringProfileBindingMapId, NSXTSegmentMonitoringProfileBindingMapType SegmentMonitoringProfileBindingMap)
        {
            if (Tier1Id == null) { throw new System.ArgumentNullException("Tier1Id cannot be null"); }
            if (SegmentId == null) { throw new System.ArgumentNullException("SegmentId cannot be null"); }
            if (SegmentMonitoringProfileBindingMapId == null) { throw new System.ArgumentNullException("SegmentMonitoringProfileBindingMapId cannot be null"); }
            if (SegmentMonitoringProfileBindingMap == null) { throw new System.ArgumentNullException("SegmentMonitoringProfileBindingMap cannot be null"); }
            StringBuilder PatchSegmentMonitoringBindingServiceURL = new StringBuilder("/infra/tier-1s/{tier-1-id}/segments/{segment-id}/segment-monitoring-profile-binding-maps/{segment-monitoring-profile-binding-map-id}");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Patch
            };
            PatchSegmentMonitoringBindingServiceURL.Replace("{tier-1-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(Tier1Id, System.Globalization.CultureInfo.InvariantCulture)));
            PatchSegmentMonitoringBindingServiceURL.Replace("{segment-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(SegmentId, System.Globalization.CultureInfo.InvariantCulture)));
            PatchSegmentMonitoringBindingServiceURL.Replace("{segment-monitoring-profile-binding-map-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(SegmentMonitoringProfileBindingMapId, System.Globalization.CultureInfo.InvariantCulture)));
            request.AddJsonBody(SegmentMonitoringProfileBindingMap);
            request.Resource = PatchSegmentMonitoringBindingServiceURL.ToString();
            RestResponse response = await restClient.ExecuteTaskAsyncWithPolicy(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Patch operation to " + PatchSegmentMonitoringBindingServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTMirrorStackStatusListResultType> GetSegmentMonitoringBindingMirrorStackStatus(string Tier1Id, string SegmentId, string SegmentMonitoringProfileBindingMapId, string? Cursor = null, string? EnforcementPointPath = null, string? IncludedFields = null, long? PageSize = null, bool? SortAscending = null, string? SortBy = null)
        {
            if (Tier1Id == null) { throw new System.ArgumentNullException("Tier1Id cannot be null"); }
            if (SegmentId == null) { throw new System.ArgumentNullException("SegmentId cannot be null"); }
            if (SegmentMonitoringProfileBindingMapId == null) { throw new System.ArgumentNullException("SegmentMonitoringProfileBindingMapId cannot be null"); }
            StringBuilder GetSegmentMonitoringBindingMirrorStackStatusServiceURL = new StringBuilder("/infra/tier-1s/{tier-1-id}/segments/{segment-id}/segment-monitoring-profile-binding-maps/{segment-monitoring-profile-binding-map-id}/mirror-stack-status");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Get
            };
            GetSegmentMonitoringBindingMirrorStackStatusServiceURL.Replace("{tier-1-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(Tier1Id, System.Globalization.CultureInfo.InvariantCulture)));
            GetSegmentMonitoringBindingMirrorStackStatusServiceURL.Replace("{segment-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(SegmentId, System.Globalization.CultureInfo.InvariantCulture)));
            GetSegmentMonitoringBindingMirrorStackStatusServiceURL.Replace("{segment-monitoring-profile-binding-map-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(SegmentMonitoringProfileBindingMapId, System.Globalization.CultureInfo.InvariantCulture)));
            if (Cursor != null) { request.AddQueryParameter("cursor", Cursor.ToString()); }
            if (EnforcementPointPath != null) { request.AddQueryParameter("enforcement_point_path", EnforcementPointPath.ToString()); }
            if (IncludedFields != null) { request.AddQueryParameter("included_fields", IncludedFields.ToString()); }
            if (PageSize != null) { request.AddQueryParameter("page_size", PageSize.ToString()); }
            if (SortAscending != null) { request.AddQueryParameter("sort_ascending", SortAscending.ToString()); }
            if (SortBy != null) { request.AddQueryParameter("sort_by", SortBy.ToString()); }
            request.Resource = GetSegmentMonitoringBindingMirrorStackStatusServiceURL.ToString();
            RestResponse<NSXTMirrorStackStatusListResultType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTMirrorStackStatusListResultType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Get operation to " + GetSegmentMonitoringBindingMirrorStackStatusServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTSegmentMonitoringProfileBindingMapListResultType> ListInfraSegmentMonitoringBindings(string InfraSegmentId, string? Cursor = null, bool? IncludeMarkForDeleteObjects = null, string? IncludedFields = null, long? PageSize = null, bool? SortAscending = null, string? SortBy = null)
        {
            if (InfraSegmentId == null) { throw new System.ArgumentNullException("InfraSegmentId cannot be null"); }
            StringBuilder ListInfraSegmentMonitoringBindingsServiceURL = new StringBuilder("/infra/segments/{infra-segment-id}/segment-monitoring-profile-binding-maps");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Get
            };
            ListInfraSegmentMonitoringBindingsServiceURL.Replace("{infra-segment-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(InfraSegmentId, System.Globalization.CultureInfo.InvariantCulture)));
            if (Cursor != null) { request.AddQueryParameter("cursor", Cursor.ToString()); }
            if (IncludeMarkForDeleteObjects != null) { request.AddQueryParameter("include_mark_for_delete_objects", IncludeMarkForDeleteObjects.ToString()); }
            if (IncludedFields != null) { request.AddQueryParameter("included_fields", IncludedFields.ToString()); }
            if (PageSize != null) { request.AddQueryParameter("page_size", PageSize.ToString()); }
            if (SortAscending != null) { request.AddQueryParameter("sort_ascending", SortAscending.ToString()); }
            if (SortBy != null) { request.AddQueryParameter("sort_by", SortBy.ToString()); }
            request.Resource = ListInfraSegmentMonitoringBindingsServiceURL.ToString();
            RestResponse<NSXTSegmentMonitoringProfileBindingMapListResultType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTSegmentMonitoringProfileBindingMapListResultType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Get operation to " + ListInfraSegmentMonitoringBindingsServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTPortMonitoringProfileBindingMapType> GlobalGlobalInfraUpdatePortMonitoringBinding(string Tier1Id, string SegmentId, string PortId, string PortMonitoringProfileBindingMapId, NSXTPortMonitoringProfileBindingMapType PortMonitoringProfileBindingMap)
        {
            if (Tier1Id == null) { throw new System.ArgumentNullException("Tier1Id cannot be null"); }
            if (SegmentId == null) { throw new System.ArgumentNullException("SegmentId cannot be null"); }
            if (PortId == null) { throw new System.ArgumentNullException("PortId cannot be null"); }
            if (PortMonitoringProfileBindingMapId == null) { throw new System.ArgumentNullException("PortMonitoringProfileBindingMapId cannot be null"); }
            if (PortMonitoringProfileBindingMap == null) { throw new System.ArgumentNullException("PortMonitoringProfileBindingMap cannot be null"); }
            StringBuilder GlobalInfraUpdatePortMonitoringBindingServiceURL = new StringBuilder("/global-infra/tier-1s/{tier-1-id}/segments/{segment-id}/ports/{port-id}/port-monitoring-profile-binding-maps/{port-monitoring-profile-binding-map-id}");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Put
            };
            GlobalInfraUpdatePortMonitoringBindingServiceURL.Replace("{tier-1-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(Tier1Id, System.Globalization.CultureInfo.InvariantCulture)));
            GlobalInfraUpdatePortMonitoringBindingServiceURL.Replace("{segment-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(SegmentId, System.Globalization.CultureInfo.InvariantCulture)));
            GlobalInfraUpdatePortMonitoringBindingServiceURL.Replace("{port-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(PortId, System.Globalization.CultureInfo.InvariantCulture)));
            GlobalInfraUpdatePortMonitoringBindingServiceURL.Replace("{port-monitoring-profile-binding-map-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(PortMonitoringProfileBindingMapId, System.Globalization.CultureInfo.InvariantCulture)));
            request.AddJsonBody(PortMonitoringProfileBindingMap);
            request.Resource = GlobalInfraUpdatePortMonitoringBindingServiceURL.ToString();
            RestResponse<NSXTPortMonitoringProfileBindingMapType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTPortMonitoringProfileBindingMapType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Put operation to " + GlobalInfraUpdatePortMonitoringBindingServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task GlobalGlobalInfraPatchPortMonitoringBinding(string Tier1Id, string SegmentId, string PortId, string PortMonitoringProfileBindingMapId, NSXTPortMonitoringProfileBindingMapType PortMonitoringProfileBindingMap)
        {
            if (Tier1Id == null) { throw new System.ArgumentNullException("Tier1Id cannot be null"); }
            if (SegmentId == null) { throw new System.ArgumentNullException("SegmentId cannot be null"); }
            if (PortId == null) { throw new System.ArgumentNullException("PortId cannot be null"); }
            if (PortMonitoringProfileBindingMapId == null) { throw new System.ArgumentNullException("PortMonitoringProfileBindingMapId cannot be null"); }
            if (PortMonitoringProfileBindingMap == null) { throw new System.ArgumentNullException("PortMonitoringProfileBindingMap cannot be null"); }
            StringBuilder GlobalInfraPatchPortMonitoringBindingServiceURL = new StringBuilder("/global-infra/tier-1s/{tier-1-id}/segments/{segment-id}/ports/{port-id}/port-monitoring-profile-binding-maps/{port-monitoring-profile-binding-map-id}");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Patch
            };
            GlobalInfraPatchPortMonitoringBindingServiceURL.Replace("{tier-1-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(Tier1Id, System.Globalization.CultureInfo.InvariantCulture)));
            GlobalInfraPatchPortMonitoringBindingServiceURL.Replace("{segment-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(SegmentId, System.Globalization.CultureInfo.InvariantCulture)));
            GlobalInfraPatchPortMonitoringBindingServiceURL.Replace("{port-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(PortId, System.Globalization.CultureInfo.InvariantCulture)));
            GlobalInfraPatchPortMonitoringBindingServiceURL.Replace("{port-monitoring-profile-binding-map-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(PortMonitoringProfileBindingMapId, System.Globalization.CultureInfo.InvariantCulture)));
            request.AddJsonBody(PortMonitoringProfileBindingMap);
            request.Resource = GlobalInfraPatchPortMonitoringBindingServiceURL.ToString();
            RestResponse response = await restClient.ExecuteTaskAsyncWithPolicy(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Patch operation to " + GlobalInfraPatchPortMonitoringBindingServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTPortMonitoringProfileBindingMapType> GlobalGlobalInfraGetPortMonitoringBinding(string Tier1Id, string SegmentId, string PortId, string PortMonitoringProfileBindingMapId)
        {
            if (Tier1Id == null) { throw new System.ArgumentNullException("Tier1Id cannot be null"); }
            if (SegmentId == null) { throw new System.ArgumentNullException("SegmentId cannot be null"); }
            if (PortId == null) { throw new System.ArgumentNullException("PortId cannot be null"); }
            if (PortMonitoringProfileBindingMapId == null) { throw new System.ArgumentNullException("PortMonitoringProfileBindingMapId cannot be null"); }
            StringBuilder GlobalInfraGetPortMonitoringBindingServiceURL = new StringBuilder("/global-infra/tier-1s/{tier-1-id}/segments/{segment-id}/ports/{port-id}/port-monitoring-profile-binding-maps/{port-monitoring-profile-binding-map-id}");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Get
            };
            GlobalInfraGetPortMonitoringBindingServiceURL.Replace("{tier-1-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(Tier1Id, System.Globalization.CultureInfo.InvariantCulture)));
            GlobalInfraGetPortMonitoringBindingServiceURL.Replace("{segment-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(SegmentId, System.Globalization.CultureInfo.InvariantCulture)));
            GlobalInfraGetPortMonitoringBindingServiceURL.Replace("{port-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(PortId, System.Globalization.CultureInfo.InvariantCulture)));
            GlobalInfraGetPortMonitoringBindingServiceURL.Replace("{port-monitoring-profile-binding-map-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(PortMonitoringProfileBindingMapId, System.Globalization.CultureInfo.InvariantCulture)));
            request.Resource = GlobalInfraGetPortMonitoringBindingServiceURL.ToString();
            RestResponse<NSXTPortMonitoringProfileBindingMapType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTPortMonitoringProfileBindingMapType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Get operation to " + GlobalInfraGetPortMonitoringBindingServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task GlobalGlobalInfraDeletePortMonitoringBinding(string Tier1Id, string SegmentId, string PortId, string PortMonitoringProfileBindingMapId)
        {
            if (Tier1Id == null) { throw new System.ArgumentNullException("Tier1Id cannot be null"); }
            if (SegmentId == null) { throw new System.ArgumentNullException("SegmentId cannot be null"); }
            if (PortId == null) { throw new System.ArgumentNullException("PortId cannot be null"); }
            if (PortMonitoringProfileBindingMapId == null) { throw new System.ArgumentNullException("PortMonitoringProfileBindingMapId cannot be null"); }
            StringBuilder GlobalInfraDeletePortMonitoringBindingServiceURL = new StringBuilder("/global-infra/tier-1s/{tier-1-id}/segments/{segment-id}/ports/{port-id}/port-monitoring-profile-binding-maps/{port-monitoring-profile-binding-map-id}");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Delete
            };
            GlobalInfraDeletePortMonitoringBindingServiceURL.Replace("{tier-1-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(Tier1Id, System.Globalization.CultureInfo.InvariantCulture)));
            GlobalInfraDeletePortMonitoringBindingServiceURL.Replace("{segment-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(SegmentId, System.Globalization.CultureInfo.InvariantCulture)));
            GlobalInfraDeletePortMonitoringBindingServiceURL.Replace("{port-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(PortId, System.Globalization.CultureInfo.InvariantCulture)));
            GlobalInfraDeletePortMonitoringBindingServiceURL.Replace("{port-monitoring-profile-binding-map-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(PortMonitoringProfileBindingMapId, System.Globalization.CultureInfo.InvariantCulture)));
            request.Resource = GlobalInfraDeletePortMonitoringBindingServiceURL.ToString();
            RestResponse response = await restClient.ExecuteTaskAsyncWithPolicy(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Delete operation to " + GlobalInfraDeletePortMonitoringBindingServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTPortMonitoringProfileBindingMapType> UpdatePortMonitoringBinding(string Tier1Id, string SegmentId, string PortId, string PortMonitoringProfileBindingMapId, NSXTPortMonitoringProfileBindingMapType PortMonitoringProfileBindingMap)
        {
            if (Tier1Id == null) { throw new System.ArgumentNullException("Tier1Id cannot be null"); }
            if (SegmentId == null) { throw new System.ArgumentNullException("SegmentId cannot be null"); }
            if (PortId == null) { throw new System.ArgumentNullException("PortId cannot be null"); }
            if (PortMonitoringProfileBindingMapId == null) { throw new System.ArgumentNullException("PortMonitoringProfileBindingMapId cannot be null"); }
            if (PortMonitoringProfileBindingMap == null) { throw new System.ArgumentNullException("PortMonitoringProfileBindingMap cannot be null"); }
            StringBuilder UpdatePortMonitoringBindingServiceURL = new StringBuilder("/infra/tier-1s/{tier-1-id}/segments/{segment-id}/ports/{port-id}/port-monitoring-profile-binding-maps/{port-monitoring-profile-binding-map-id}");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Put
            };
            UpdatePortMonitoringBindingServiceURL.Replace("{tier-1-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(Tier1Id, System.Globalization.CultureInfo.InvariantCulture)));
            UpdatePortMonitoringBindingServiceURL.Replace("{segment-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(SegmentId, System.Globalization.CultureInfo.InvariantCulture)));
            UpdatePortMonitoringBindingServiceURL.Replace("{port-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(PortId, System.Globalization.CultureInfo.InvariantCulture)));
            UpdatePortMonitoringBindingServiceURL.Replace("{port-monitoring-profile-binding-map-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(PortMonitoringProfileBindingMapId, System.Globalization.CultureInfo.InvariantCulture)));
            request.AddJsonBody(PortMonitoringProfileBindingMap);
            request.Resource = UpdatePortMonitoringBindingServiceURL.ToString();
            RestResponse<NSXTPortMonitoringProfileBindingMapType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTPortMonitoringProfileBindingMapType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Put operation to " + UpdatePortMonitoringBindingServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task PatchPortMonitoringBinding(string Tier1Id, string SegmentId, string PortId, string PortMonitoringProfileBindingMapId, NSXTPortMonitoringProfileBindingMapType PortMonitoringProfileBindingMap)
        {
            if (Tier1Id == null) { throw new System.ArgumentNullException("Tier1Id cannot be null"); }
            if (SegmentId == null) { throw new System.ArgumentNullException("SegmentId cannot be null"); }
            if (PortId == null) { throw new System.ArgumentNullException("PortId cannot be null"); }
            if (PortMonitoringProfileBindingMapId == null) { throw new System.ArgumentNullException("PortMonitoringProfileBindingMapId cannot be null"); }
            if (PortMonitoringProfileBindingMap == null) { throw new System.ArgumentNullException("PortMonitoringProfileBindingMap cannot be null"); }
            StringBuilder PatchPortMonitoringBindingServiceURL = new StringBuilder("/infra/tier-1s/{tier-1-id}/segments/{segment-id}/ports/{port-id}/port-monitoring-profile-binding-maps/{port-monitoring-profile-binding-map-id}");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Patch
            };
            PatchPortMonitoringBindingServiceURL.Replace("{tier-1-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(Tier1Id, System.Globalization.CultureInfo.InvariantCulture)));
            PatchPortMonitoringBindingServiceURL.Replace("{segment-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(SegmentId, System.Globalization.CultureInfo.InvariantCulture)));
            PatchPortMonitoringBindingServiceURL.Replace("{port-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(PortId, System.Globalization.CultureInfo.InvariantCulture)));
            PatchPortMonitoringBindingServiceURL.Replace("{port-monitoring-profile-binding-map-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(PortMonitoringProfileBindingMapId, System.Globalization.CultureInfo.InvariantCulture)));
            request.AddJsonBody(PortMonitoringProfileBindingMap);
            request.Resource = PatchPortMonitoringBindingServiceURL.ToString();
            RestResponse response = await restClient.ExecuteTaskAsyncWithPolicy(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Patch operation to " + PatchPortMonitoringBindingServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTPortMonitoringProfileBindingMapType> GetPortMonitoringBinding(string Tier1Id, string SegmentId, string PortId, string PortMonitoringProfileBindingMapId)
        {
            if (Tier1Id == null) { throw new System.ArgumentNullException("Tier1Id cannot be null"); }
            if (SegmentId == null) { throw new System.ArgumentNullException("SegmentId cannot be null"); }
            if (PortId == null) { throw new System.ArgumentNullException("PortId cannot be null"); }
            if (PortMonitoringProfileBindingMapId == null) { throw new System.ArgumentNullException("PortMonitoringProfileBindingMapId cannot be null"); }
            StringBuilder GetPortMonitoringBindingServiceURL = new StringBuilder("/infra/tier-1s/{tier-1-id}/segments/{segment-id}/ports/{port-id}/port-monitoring-profile-binding-maps/{port-monitoring-profile-binding-map-id}");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Get
            };
            GetPortMonitoringBindingServiceURL.Replace("{tier-1-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(Tier1Id, System.Globalization.CultureInfo.InvariantCulture)));
            GetPortMonitoringBindingServiceURL.Replace("{segment-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(SegmentId, System.Globalization.CultureInfo.InvariantCulture)));
            GetPortMonitoringBindingServiceURL.Replace("{port-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(PortId, System.Globalization.CultureInfo.InvariantCulture)));
            GetPortMonitoringBindingServiceURL.Replace("{port-monitoring-profile-binding-map-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(PortMonitoringProfileBindingMapId, System.Globalization.CultureInfo.InvariantCulture)));
            request.Resource = GetPortMonitoringBindingServiceURL.ToString();
            RestResponse<NSXTPortMonitoringProfileBindingMapType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTPortMonitoringProfileBindingMapType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Get operation to " + GetPortMonitoringBindingServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task DeletePortMonitoringBinding(string Tier1Id, string SegmentId, string PortId, string PortMonitoringProfileBindingMapId)
        {
            if (Tier1Id == null) { throw new System.ArgumentNullException("Tier1Id cannot be null"); }
            if (SegmentId == null) { throw new System.ArgumentNullException("SegmentId cannot be null"); }
            if (PortId == null) { throw new System.ArgumentNullException("PortId cannot be null"); }
            if (PortMonitoringProfileBindingMapId == null) { throw new System.ArgumentNullException("PortMonitoringProfileBindingMapId cannot be null"); }
            StringBuilder DeletePortMonitoringBindingServiceURL = new StringBuilder("/infra/tier-1s/{tier-1-id}/segments/{segment-id}/ports/{port-id}/port-monitoring-profile-binding-maps/{port-monitoring-profile-binding-map-id}");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Delete
            };
            DeletePortMonitoringBindingServiceURL.Replace("{tier-1-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(Tier1Id, System.Globalization.CultureInfo.InvariantCulture)));
            DeletePortMonitoringBindingServiceURL.Replace("{segment-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(SegmentId, System.Globalization.CultureInfo.InvariantCulture)));
            DeletePortMonitoringBindingServiceURL.Replace("{port-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(PortId, System.Globalization.CultureInfo.InvariantCulture)));
            DeletePortMonitoringBindingServiceURL.Replace("{port-monitoring-profile-binding-map-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(PortMonitoringProfileBindingMapId, System.Globalization.CultureInfo.InvariantCulture)));
            request.Resource = DeletePortMonitoringBindingServiceURL.ToString();
            RestResponse response = await restClient.ExecuteTaskAsyncWithPolicy(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Delete operation to " + DeletePortMonitoringBindingServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTMirrorStackStatusListResultType> GetInfraPortMonitoringBindingMirrorStackStatus(string InfraSegmentId, string InfraPortId, string PortMonitoringProfileBindingMapId, string? Cursor = null, string? EnforcementPointPath = null, string? IncludedFields = null, long? PageSize = null, bool? SortAscending = null, string? SortBy = null)
        {
            if (InfraSegmentId == null) { throw new System.ArgumentNullException("InfraSegmentId cannot be null"); }
            if (InfraPortId == null) { throw new System.ArgumentNullException("InfraPortId cannot be null"); }
            if (PortMonitoringProfileBindingMapId == null) { throw new System.ArgumentNullException("PortMonitoringProfileBindingMapId cannot be null"); }
            StringBuilder GetInfraPortMonitoringBindingMirrorStackStatusServiceURL = new StringBuilder("/infra/segments/{infra-segment-id}/ports/{infra-port-id}/port-monitoring-profile-binding-maps/{port-monitoring-profile-binding-map-id}/mirror-stack-status");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Get
            };
            GetInfraPortMonitoringBindingMirrorStackStatusServiceURL.Replace("{infra-segment-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(InfraSegmentId, System.Globalization.CultureInfo.InvariantCulture)));
            GetInfraPortMonitoringBindingMirrorStackStatusServiceURL.Replace("{infra-port-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(InfraPortId, System.Globalization.CultureInfo.InvariantCulture)));
            GetInfraPortMonitoringBindingMirrorStackStatusServiceURL.Replace("{port-monitoring-profile-binding-map-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(PortMonitoringProfileBindingMapId, System.Globalization.CultureInfo.InvariantCulture)));
            if (Cursor != null) { request.AddQueryParameter("cursor", Cursor.ToString()); }
            if (EnforcementPointPath != null) { request.AddQueryParameter("enforcement_point_path", EnforcementPointPath.ToString()); }
            if (IncludedFields != null) { request.AddQueryParameter("included_fields", IncludedFields.ToString()); }
            if (PageSize != null) { request.AddQueryParameter("page_size", PageSize.ToString()); }
            if (SortAscending != null) { request.AddQueryParameter("sort_ascending", SortAscending.ToString()); }
            if (SortBy != null) { request.AddQueryParameter("sort_by", SortBy.ToString()); }
            request.Resource = GetInfraPortMonitoringBindingMirrorStackStatusServiceURL.ToString();
            RestResponse<NSXTMirrorStackStatusListResultType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTMirrorStackStatusListResultType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Get operation to " + GetInfraPortMonitoringBindingMirrorStackStatusServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTGroupMonitoringProfileBindingMapListResultType> ListGroupMonitoringBindings(string DomainId, string GroupId, string? Cursor = null, bool? IncludeMarkForDeleteObjects = null, string? IncludedFields = null, long? PageSize = null, bool? SortAscending = null, string? SortBy = null)
        {
            if (DomainId == null) { throw new System.ArgumentNullException("DomainId cannot be null"); }
            if (GroupId == null) { throw new System.ArgumentNullException("GroupId cannot be null"); }
            StringBuilder ListGroupMonitoringBindingsServiceURL = new StringBuilder("/infra/domains/{domain-id}/groups/{group-id}/group-monitoring-profile-binding-maps");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Get
            };
            ListGroupMonitoringBindingsServiceURL.Replace("{domain-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(DomainId, System.Globalization.CultureInfo.InvariantCulture)));
            ListGroupMonitoringBindingsServiceURL.Replace("{group-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(GroupId, System.Globalization.CultureInfo.InvariantCulture)));
            if (Cursor != null) { request.AddQueryParameter("cursor", Cursor.ToString()); }
            if (IncludeMarkForDeleteObjects != null) { request.AddQueryParameter("include_mark_for_delete_objects", IncludeMarkForDeleteObjects.ToString()); }
            if (IncludedFields != null) { request.AddQueryParameter("included_fields", IncludedFields.ToString()); }
            if (PageSize != null) { request.AddQueryParameter("page_size", PageSize.ToString()); }
            if (SortAscending != null) { request.AddQueryParameter("sort_ascending", SortAscending.ToString()); }
            if (SortBy != null) { request.AddQueryParameter("sort_by", SortBy.ToString()); }
            request.Resource = ListGroupMonitoringBindingsServiceURL.ToString();
            RestResponse<NSXTGroupMonitoringProfileBindingMapListResultType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTGroupMonitoringProfileBindingMapListResultType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Get operation to " + ListGroupMonitoringBindingsServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTMirrorStackStatusListResultType> GetInfraSegmentMonitoringBindingMirrorStackStatus(string InfraSegmentId, string SegmentMonitoringProfileBindingMapId, string? Cursor = null, string? EnforcementPointPath = null, string? IncludedFields = null, long? PageSize = null, bool? SortAscending = null, string? SortBy = null)
        {
            if (InfraSegmentId == null) { throw new System.ArgumentNullException("InfraSegmentId cannot be null"); }
            if (SegmentMonitoringProfileBindingMapId == null) { throw new System.ArgumentNullException("SegmentMonitoringProfileBindingMapId cannot be null"); }
            StringBuilder GetInfraSegmentMonitoringBindingMirrorStackStatusServiceURL = new StringBuilder("/infra/segments/{infra-segment-id}/segment-monitoring-profile-binding-maps/{segment-monitoring-profile-binding-map-id}/mirror-stack-status");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Get
            };
            GetInfraSegmentMonitoringBindingMirrorStackStatusServiceURL.Replace("{infra-segment-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(InfraSegmentId, System.Globalization.CultureInfo.InvariantCulture)));
            GetInfraSegmentMonitoringBindingMirrorStackStatusServiceURL.Replace("{segment-monitoring-profile-binding-map-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(SegmentMonitoringProfileBindingMapId, System.Globalization.CultureInfo.InvariantCulture)));
            if (Cursor != null) { request.AddQueryParameter("cursor", Cursor.ToString()); }
            if (EnforcementPointPath != null) { request.AddQueryParameter("enforcement_point_path", EnforcementPointPath.ToString()); }
            if (IncludedFields != null) { request.AddQueryParameter("included_fields", IncludedFields.ToString()); }
            if (PageSize != null) { request.AddQueryParameter("page_size", PageSize.ToString()); }
            if (SortAscending != null) { request.AddQueryParameter("sort_ascending", SortAscending.ToString()); }
            if (SortBy != null) { request.AddQueryParameter("sort_by", SortBy.ToString()); }
            request.Resource = GetInfraSegmentMonitoringBindingMirrorStackStatusServiceURL.ToString();
            RestResponse<NSXTMirrorStackStatusListResultType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTMirrorStackStatusListResultType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Get operation to " + GetInfraSegmentMonitoringBindingMirrorStackStatusServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTMirrorStackStatusListResultType> GlobalGlobalInfraGetInfraSegmentMonitoringBindingMirrorStackStatus(string InfraSegmentId, string SegmentMonitoringProfileBindingMapId, string? Cursor = null, string? EnforcementPointPath = null, string? IncludedFields = null, long? PageSize = null, bool? SortAscending = null, string? SortBy = null)
        {
            if (InfraSegmentId == null) { throw new System.ArgumentNullException("InfraSegmentId cannot be null"); }
            if (SegmentMonitoringProfileBindingMapId == null) { throw new System.ArgumentNullException("SegmentMonitoringProfileBindingMapId cannot be null"); }
            StringBuilder GlobalInfraGetInfraSegmentMonitoringBindingMirrorStackStatusServiceURL = new StringBuilder("/global-infra/segments/{infra-segment-id}/segment-monitoring-profile-binding-maps/{segment-monitoring-profile-binding-map-id}/mirror-stack-status");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Get
            };
            GlobalInfraGetInfraSegmentMonitoringBindingMirrorStackStatusServiceURL.Replace("{infra-segment-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(InfraSegmentId, System.Globalization.CultureInfo.InvariantCulture)));
            GlobalInfraGetInfraSegmentMonitoringBindingMirrorStackStatusServiceURL.Replace("{segment-monitoring-profile-binding-map-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(SegmentMonitoringProfileBindingMapId, System.Globalization.CultureInfo.InvariantCulture)));
            if (Cursor != null) { request.AddQueryParameter("cursor", Cursor.ToString()); }
            if (EnforcementPointPath != null) { request.AddQueryParameter("enforcement_point_path", EnforcementPointPath.ToString()); }
            if (IncludedFields != null) { request.AddQueryParameter("included_fields", IncludedFields.ToString()); }
            if (PageSize != null) { request.AddQueryParameter("page_size", PageSize.ToString()); }
            if (SortAscending != null) { request.AddQueryParameter("sort_ascending", SortAscending.ToString()); }
            if (SortBy != null) { request.AddQueryParameter("sort_by", SortBy.ToString()); }
            request.Resource = GlobalInfraGetInfraSegmentMonitoringBindingMirrorStackStatusServiceURL.ToString();
            RestResponse<NSXTMirrorStackStatusListResultType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTMirrorStackStatusListResultType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Get operation to " + GlobalInfraGetInfraSegmentMonitoringBindingMirrorStackStatusServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTGroupMonitoringProfileBindingMapType> UpdateGroupMonitoringBinding(string DomainId, string GroupId, string GroupMonitoringProfileBindingMapId, NSXTGroupMonitoringProfileBindingMapType GroupMonitoringProfileBindingMap)
        {
            if (DomainId == null) { throw new System.ArgumentNullException("DomainId cannot be null"); }
            if (GroupId == null) { throw new System.ArgumentNullException("GroupId cannot be null"); }
            if (GroupMonitoringProfileBindingMapId == null) { throw new System.ArgumentNullException("GroupMonitoringProfileBindingMapId cannot be null"); }
            if (GroupMonitoringProfileBindingMap == null) { throw new System.ArgumentNullException("GroupMonitoringProfileBindingMap cannot be null"); }
            StringBuilder UpdateGroupMonitoringBindingServiceURL = new StringBuilder("/infra/domains/{domain-id}/groups/{group-id}/group-monitoring-profile-binding-maps/{group-monitoring-profile-binding-map-id}");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Put
            };
            UpdateGroupMonitoringBindingServiceURL.Replace("{domain-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(DomainId, System.Globalization.CultureInfo.InvariantCulture)));
            UpdateGroupMonitoringBindingServiceURL.Replace("{group-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(GroupId, System.Globalization.CultureInfo.InvariantCulture)));
            UpdateGroupMonitoringBindingServiceURL.Replace("{group-monitoring-profile-binding-map-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(GroupMonitoringProfileBindingMapId, System.Globalization.CultureInfo.InvariantCulture)));
            request.AddJsonBody(GroupMonitoringProfileBindingMap);
            request.Resource = UpdateGroupMonitoringBindingServiceURL.ToString();
            RestResponse<NSXTGroupMonitoringProfileBindingMapType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTGroupMonitoringProfileBindingMapType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Put operation to " + UpdateGroupMonitoringBindingServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task DeleteGroupMonitoringBinding(string DomainId, string GroupId, string GroupMonitoringProfileBindingMapId)
        {
            if (DomainId == null) { throw new System.ArgumentNullException("DomainId cannot be null"); }
            if (GroupId == null) { throw new System.ArgumentNullException("GroupId cannot be null"); }
            if (GroupMonitoringProfileBindingMapId == null) { throw new System.ArgumentNullException("GroupMonitoringProfileBindingMapId cannot be null"); }
            StringBuilder DeleteGroupMonitoringBindingServiceURL = new StringBuilder("/infra/domains/{domain-id}/groups/{group-id}/group-monitoring-profile-binding-maps/{group-monitoring-profile-binding-map-id}");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Delete
            };
            DeleteGroupMonitoringBindingServiceURL.Replace("{domain-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(DomainId, System.Globalization.CultureInfo.InvariantCulture)));
            DeleteGroupMonitoringBindingServiceURL.Replace("{group-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(GroupId, System.Globalization.CultureInfo.InvariantCulture)));
            DeleteGroupMonitoringBindingServiceURL.Replace("{group-monitoring-profile-binding-map-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(GroupMonitoringProfileBindingMapId, System.Globalization.CultureInfo.InvariantCulture)));
            request.Resource = DeleteGroupMonitoringBindingServiceURL.ToString();
            RestResponse response = await restClient.ExecuteTaskAsyncWithPolicy(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Delete operation to " + DeleteGroupMonitoringBindingServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTGroupMonitoringProfileBindingMapType> GetGroupMonitoringBinding(string DomainId, string GroupId, string GroupMonitoringProfileBindingMapId)
        {
            if (DomainId == null) { throw new System.ArgumentNullException("DomainId cannot be null"); }
            if (GroupId == null) { throw new System.ArgumentNullException("GroupId cannot be null"); }
            if (GroupMonitoringProfileBindingMapId == null) { throw new System.ArgumentNullException("GroupMonitoringProfileBindingMapId cannot be null"); }
            StringBuilder GetGroupMonitoringBindingServiceURL = new StringBuilder("/infra/domains/{domain-id}/groups/{group-id}/group-monitoring-profile-binding-maps/{group-monitoring-profile-binding-map-id}");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Get
            };
            GetGroupMonitoringBindingServiceURL.Replace("{domain-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(DomainId, System.Globalization.CultureInfo.InvariantCulture)));
            GetGroupMonitoringBindingServiceURL.Replace("{group-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(GroupId, System.Globalization.CultureInfo.InvariantCulture)));
            GetGroupMonitoringBindingServiceURL.Replace("{group-monitoring-profile-binding-map-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(GroupMonitoringProfileBindingMapId, System.Globalization.CultureInfo.InvariantCulture)));
            request.Resource = GetGroupMonitoringBindingServiceURL.ToString();
            RestResponse<NSXTGroupMonitoringProfileBindingMapType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTGroupMonitoringProfileBindingMapType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Get operation to " + GetGroupMonitoringBindingServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task PatchGroupMonitoringBinding(string DomainId, string GroupId, string GroupMonitoringProfileBindingMapId, NSXTGroupMonitoringProfileBindingMapType GroupMonitoringProfileBindingMap)
        {
            if (DomainId == null) { throw new System.ArgumentNullException("DomainId cannot be null"); }
            if (GroupId == null) { throw new System.ArgumentNullException("GroupId cannot be null"); }
            if (GroupMonitoringProfileBindingMapId == null) { throw new System.ArgumentNullException("GroupMonitoringProfileBindingMapId cannot be null"); }
            if (GroupMonitoringProfileBindingMap == null) { throw new System.ArgumentNullException("GroupMonitoringProfileBindingMap cannot be null"); }
            StringBuilder PatchGroupMonitoringBindingServiceURL = new StringBuilder("/infra/domains/{domain-id}/groups/{group-id}/group-monitoring-profile-binding-maps/{group-monitoring-profile-binding-map-id}");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Patch
            };
            PatchGroupMonitoringBindingServiceURL.Replace("{domain-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(DomainId, System.Globalization.CultureInfo.InvariantCulture)));
            PatchGroupMonitoringBindingServiceURL.Replace("{group-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(GroupId, System.Globalization.CultureInfo.InvariantCulture)));
            PatchGroupMonitoringBindingServiceURL.Replace("{group-monitoring-profile-binding-map-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(GroupMonitoringProfileBindingMapId, System.Globalization.CultureInfo.InvariantCulture)));
            request.AddJsonBody(GroupMonitoringProfileBindingMap);
            request.Resource = PatchGroupMonitoringBindingServiceURL.ToString();
            RestResponse response = await restClient.ExecuteTaskAsyncWithPolicy(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Patch operation to " + PatchGroupMonitoringBindingServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTPortMonitoringProfileBindingMapType> GlobalGlobalInfraUpdateInfraPortMonitoringBinding(string InfraSegmentId, string InfraPortId, string PortMonitoringProfileBindingMapId, NSXTPortMonitoringProfileBindingMapType PortMonitoringProfileBindingMap)
        {
            if (InfraSegmentId == null) { throw new System.ArgumentNullException("InfraSegmentId cannot be null"); }
            if (InfraPortId == null) { throw new System.ArgumentNullException("InfraPortId cannot be null"); }
            if (PortMonitoringProfileBindingMapId == null) { throw new System.ArgumentNullException("PortMonitoringProfileBindingMapId cannot be null"); }
            if (PortMonitoringProfileBindingMap == null) { throw new System.ArgumentNullException("PortMonitoringProfileBindingMap cannot be null"); }
            StringBuilder GlobalInfraUpdateInfraPortMonitoringBindingServiceURL = new StringBuilder("/global-infra/segments/{infra-segment-id}/ports/{infra-port-id}/port-monitoring-profile-binding-maps/{port-monitoring-profile-binding-map-id}");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Put
            };
            GlobalInfraUpdateInfraPortMonitoringBindingServiceURL.Replace("{infra-segment-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(InfraSegmentId, System.Globalization.CultureInfo.InvariantCulture)));
            GlobalInfraUpdateInfraPortMonitoringBindingServiceURL.Replace("{infra-port-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(InfraPortId, System.Globalization.CultureInfo.InvariantCulture)));
            GlobalInfraUpdateInfraPortMonitoringBindingServiceURL.Replace("{port-monitoring-profile-binding-map-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(PortMonitoringProfileBindingMapId, System.Globalization.CultureInfo.InvariantCulture)));
            request.AddJsonBody(PortMonitoringProfileBindingMap);
            request.Resource = GlobalInfraUpdateInfraPortMonitoringBindingServiceURL.ToString();
            RestResponse<NSXTPortMonitoringProfileBindingMapType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTPortMonitoringProfileBindingMapType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Put operation to " + GlobalInfraUpdateInfraPortMonitoringBindingServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task GlobalGlobalInfraDeleteInfraPortMonitoringBinding(string InfraSegmentId, string InfraPortId, string PortMonitoringProfileBindingMapId)
        {
            if (InfraSegmentId == null) { throw new System.ArgumentNullException("InfraSegmentId cannot be null"); }
            if (InfraPortId == null) { throw new System.ArgumentNullException("InfraPortId cannot be null"); }
            if (PortMonitoringProfileBindingMapId == null) { throw new System.ArgumentNullException("PortMonitoringProfileBindingMapId cannot be null"); }
            StringBuilder GlobalInfraDeleteInfraPortMonitoringBindingServiceURL = new StringBuilder("/global-infra/segments/{infra-segment-id}/ports/{infra-port-id}/port-monitoring-profile-binding-maps/{port-monitoring-profile-binding-map-id}");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Delete
            };
            GlobalInfraDeleteInfraPortMonitoringBindingServiceURL.Replace("{infra-segment-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(InfraSegmentId, System.Globalization.CultureInfo.InvariantCulture)));
            GlobalInfraDeleteInfraPortMonitoringBindingServiceURL.Replace("{infra-port-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(InfraPortId, System.Globalization.CultureInfo.InvariantCulture)));
            GlobalInfraDeleteInfraPortMonitoringBindingServiceURL.Replace("{port-monitoring-profile-binding-map-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(PortMonitoringProfileBindingMapId, System.Globalization.CultureInfo.InvariantCulture)));
            request.Resource = GlobalInfraDeleteInfraPortMonitoringBindingServiceURL.ToString();
            RestResponse response = await restClient.ExecuteTaskAsyncWithPolicy(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Delete operation to " + GlobalInfraDeleteInfraPortMonitoringBindingServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTPortMonitoringProfileBindingMapType> GlobalGlobalInfraGetInfraPortMonitoringBinding(string InfraSegmentId, string InfraPortId, string PortMonitoringProfileBindingMapId)
        {
            if (InfraSegmentId == null) { throw new System.ArgumentNullException("InfraSegmentId cannot be null"); }
            if (InfraPortId == null) { throw new System.ArgumentNullException("InfraPortId cannot be null"); }
            if (PortMonitoringProfileBindingMapId == null) { throw new System.ArgumentNullException("PortMonitoringProfileBindingMapId cannot be null"); }
            StringBuilder GlobalInfraGetInfraPortMonitoringBindingServiceURL = new StringBuilder("/global-infra/segments/{infra-segment-id}/ports/{infra-port-id}/port-monitoring-profile-binding-maps/{port-monitoring-profile-binding-map-id}");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Get
            };
            GlobalInfraGetInfraPortMonitoringBindingServiceURL.Replace("{infra-segment-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(InfraSegmentId, System.Globalization.CultureInfo.InvariantCulture)));
            GlobalInfraGetInfraPortMonitoringBindingServiceURL.Replace("{infra-port-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(InfraPortId, System.Globalization.CultureInfo.InvariantCulture)));
            GlobalInfraGetInfraPortMonitoringBindingServiceURL.Replace("{port-monitoring-profile-binding-map-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(PortMonitoringProfileBindingMapId, System.Globalization.CultureInfo.InvariantCulture)));
            request.Resource = GlobalInfraGetInfraPortMonitoringBindingServiceURL.ToString();
            RestResponse<NSXTPortMonitoringProfileBindingMapType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTPortMonitoringProfileBindingMapType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Get operation to " + GlobalInfraGetInfraPortMonitoringBindingServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task GlobalGlobalInfraPatchInfraPortMonitoringBinding(string InfraSegmentId, string InfraPortId, string PortMonitoringProfileBindingMapId, NSXTPortMonitoringProfileBindingMapType PortMonitoringProfileBindingMap)
        {
            if (InfraSegmentId == null) { throw new System.ArgumentNullException("InfraSegmentId cannot be null"); }
            if (InfraPortId == null) { throw new System.ArgumentNullException("InfraPortId cannot be null"); }
            if (PortMonitoringProfileBindingMapId == null) { throw new System.ArgumentNullException("PortMonitoringProfileBindingMapId cannot be null"); }
            if (PortMonitoringProfileBindingMap == null) { throw new System.ArgumentNullException("PortMonitoringProfileBindingMap cannot be null"); }
            StringBuilder GlobalInfraPatchInfraPortMonitoringBindingServiceURL = new StringBuilder("/global-infra/segments/{infra-segment-id}/ports/{infra-port-id}/port-monitoring-profile-binding-maps/{port-monitoring-profile-binding-map-id}");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Patch
            };
            GlobalInfraPatchInfraPortMonitoringBindingServiceURL.Replace("{infra-segment-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(InfraSegmentId, System.Globalization.CultureInfo.InvariantCulture)));
            GlobalInfraPatchInfraPortMonitoringBindingServiceURL.Replace("{infra-port-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(InfraPortId, System.Globalization.CultureInfo.InvariantCulture)));
            GlobalInfraPatchInfraPortMonitoringBindingServiceURL.Replace("{port-monitoring-profile-binding-map-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(PortMonitoringProfileBindingMapId, System.Globalization.CultureInfo.InvariantCulture)));
            request.AddJsonBody(PortMonitoringProfileBindingMap);
            request.Resource = GlobalInfraPatchInfraPortMonitoringBindingServiceURL.ToString();
            RestResponse response = await restClient.ExecuteTaskAsyncWithPolicy(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Patch operation to " + GlobalInfraPatchInfraPortMonitoringBindingServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTMirrorStackStatusListResultType> GetGroupMonitoringBindingMirrorStackStatus(string DomainId, string GroupId, string GroupMonitoringProfileBindingMapId, string? Cursor = null, string? EnforcementPointPath = null, string? IncludedFields = null, long? PageSize = null, bool? SortAscending = null, string? SortBy = null)
        {
            if (DomainId == null) { throw new System.ArgumentNullException("DomainId cannot be null"); }
            if (GroupId == null) { throw new System.ArgumentNullException("GroupId cannot be null"); }
            if (GroupMonitoringProfileBindingMapId == null) { throw new System.ArgumentNullException("GroupMonitoringProfileBindingMapId cannot be null"); }
            StringBuilder GetGroupMonitoringBindingMirrorStackStatusServiceURL = new StringBuilder("/infra/domains/{domain-id}/groups/{group-id}/group-monitoring-profile-binding-maps/{group-monitoring-profile-binding-map-id}/mirror-stack-status");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Get
            };
            GetGroupMonitoringBindingMirrorStackStatusServiceURL.Replace("{domain-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(DomainId, System.Globalization.CultureInfo.InvariantCulture)));
            GetGroupMonitoringBindingMirrorStackStatusServiceURL.Replace("{group-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(GroupId, System.Globalization.CultureInfo.InvariantCulture)));
            GetGroupMonitoringBindingMirrorStackStatusServiceURL.Replace("{group-monitoring-profile-binding-map-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(GroupMonitoringProfileBindingMapId, System.Globalization.CultureInfo.InvariantCulture)));
            if (Cursor != null) { request.AddQueryParameter("cursor", Cursor.ToString()); }
            if (EnforcementPointPath != null) { request.AddQueryParameter("enforcement_point_path", EnforcementPointPath.ToString()); }
            if (IncludedFields != null) { request.AddQueryParameter("included_fields", IncludedFields.ToString()); }
            if (PageSize != null) { request.AddQueryParameter("page_size", PageSize.ToString()); }
            if (SortAscending != null) { request.AddQueryParameter("sort_ascending", SortAscending.ToString()); }
            if (SortBy != null) { request.AddQueryParameter("sort_by", SortBy.ToString()); }
            request.Resource = GetGroupMonitoringBindingMirrorStackStatusServiceURL.ToString();
            RestResponse<NSXTMirrorStackStatusListResultType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTMirrorStackStatusListResultType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Get operation to " + GetGroupMonitoringBindingMirrorStackStatusServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTMirrorStackStatusListResultType> GlobalGlobalInfraGetPortMonitoringBindingMirrorStackStatus(string Tier1Id, string SegmentId, string PortId, string PortMonitoringProfileBindingMapId, string? Cursor = null, string? EnforcementPointPath = null, string? IncludedFields = null, long? PageSize = null, bool? SortAscending = null, string? SortBy = null)
        {
            if (Tier1Id == null) { throw new System.ArgumentNullException("Tier1Id cannot be null"); }
            if (SegmentId == null) { throw new System.ArgumentNullException("SegmentId cannot be null"); }
            if (PortId == null) { throw new System.ArgumentNullException("PortId cannot be null"); }
            if (PortMonitoringProfileBindingMapId == null) { throw new System.ArgumentNullException("PortMonitoringProfileBindingMapId cannot be null"); }
            StringBuilder GlobalInfraGetPortMonitoringBindingMirrorStackStatusServiceURL = new StringBuilder("/global-infra/tier-1s/{tier-1-id}/segments/{segment-id}/ports/{port-id}/port-monitoring-profile-binding-maps/{port-monitoring-profile-binding-map-id}/mirror-stack-status");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Get
            };
            GlobalInfraGetPortMonitoringBindingMirrorStackStatusServiceURL.Replace("{tier-1-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(Tier1Id, System.Globalization.CultureInfo.InvariantCulture)));
            GlobalInfraGetPortMonitoringBindingMirrorStackStatusServiceURL.Replace("{segment-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(SegmentId, System.Globalization.CultureInfo.InvariantCulture)));
            GlobalInfraGetPortMonitoringBindingMirrorStackStatusServiceURL.Replace("{port-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(PortId, System.Globalization.CultureInfo.InvariantCulture)));
            GlobalInfraGetPortMonitoringBindingMirrorStackStatusServiceURL.Replace("{port-monitoring-profile-binding-map-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(PortMonitoringProfileBindingMapId, System.Globalization.CultureInfo.InvariantCulture)));
            if (Cursor != null) { request.AddQueryParameter("cursor", Cursor.ToString()); }
            if (EnforcementPointPath != null) { request.AddQueryParameter("enforcement_point_path", EnforcementPointPath.ToString()); }
            if (IncludedFields != null) { request.AddQueryParameter("included_fields", IncludedFields.ToString()); }
            if (PageSize != null) { request.AddQueryParameter("page_size", PageSize.ToString()); }
            if (SortAscending != null) { request.AddQueryParameter("sort_ascending", SortAscending.ToString()); }
            if (SortBy != null) { request.AddQueryParameter("sort_by", SortBy.ToString()); }
            request.Resource = GlobalInfraGetPortMonitoringBindingMirrorStackStatusServiceURL.ToString();
            RestResponse<NSXTMirrorStackStatusListResultType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTMirrorStackStatusListResultType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Get operation to " + GlobalInfraGetPortMonitoringBindingMirrorStackStatusServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTMirrorStackStatusListResultType> GlobalGlobalInfraGetGroupMonitoringBindingMirrorStackStatus(string DomainId, string GroupId, string GroupMonitoringProfileBindingMapId, string? Cursor = null, string? EnforcementPointPath = null, string? IncludedFields = null, long? PageSize = null, bool? SortAscending = null, string? SortBy = null)
        {
            if (DomainId == null) { throw new System.ArgumentNullException("DomainId cannot be null"); }
            if (GroupId == null) { throw new System.ArgumentNullException("GroupId cannot be null"); }
            if (GroupMonitoringProfileBindingMapId == null) { throw new System.ArgumentNullException("GroupMonitoringProfileBindingMapId cannot be null"); }
            StringBuilder GlobalInfraGetGroupMonitoringBindingMirrorStackStatusServiceURL = new StringBuilder("/global-infra/domains/{domain-id}/groups/{group-id}/group-monitoring-profile-binding-maps/{group-monitoring-profile-binding-map-id}/mirror-stack-status");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Get
            };
            GlobalInfraGetGroupMonitoringBindingMirrorStackStatusServiceURL.Replace("{domain-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(DomainId, System.Globalization.CultureInfo.InvariantCulture)));
            GlobalInfraGetGroupMonitoringBindingMirrorStackStatusServiceURL.Replace("{group-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(GroupId, System.Globalization.CultureInfo.InvariantCulture)));
            GlobalInfraGetGroupMonitoringBindingMirrorStackStatusServiceURL.Replace("{group-monitoring-profile-binding-map-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(GroupMonitoringProfileBindingMapId, System.Globalization.CultureInfo.InvariantCulture)));
            if (Cursor != null) { request.AddQueryParameter("cursor", Cursor.ToString()); }
            if (EnforcementPointPath != null) { request.AddQueryParameter("enforcement_point_path", EnforcementPointPath.ToString()); }
            if (IncludedFields != null) { request.AddQueryParameter("included_fields", IncludedFields.ToString()); }
            if (PageSize != null) { request.AddQueryParameter("page_size", PageSize.ToString()); }
            if (SortAscending != null) { request.AddQueryParameter("sort_ascending", SortAscending.ToString()); }
            if (SortBy != null) { request.AddQueryParameter("sort_by", SortBy.ToString()); }
            request.Resource = GlobalInfraGetGroupMonitoringBindingMirrorStackStatusServiceURL.ToString();
            RestResponse<NSXTMirrorStackStatusListResultType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTMirrorStackStatusListResultType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Get operation to " + GlobalInfraGetGroupMonitoringBindingMirrorStackStatusServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTMirrorStackStatusListResultType> GetPortMonitoringBindingMirrorStackStatus(string Tier1Id, string SegmentId, string PortId, string PortMonitoringProfileBindingMapId, string? Cursor = null, string? EnforcementPointPath = null, string? IncludedFields = null, long? PageSize = null, bool? SortAscending = null, string? SortBy = null)
        {
            if (Tier1Id == null) { throw new System.ArgumentNullException("Tier1Id cannot be null"); }
            if (SegmentId == null) { throw new System.ArgumentNullException("SegmentId cannot be null"); }
            if (PortId == null) { throw new System.ArgumentNullException("PortId cannot be null"); }
            if (PortMonitoringProfileBindingMapId == null) { throw new System.ArgumentNullException("PortMonitoringProfileBindingMapId cannot be null"); }
            StringBuilder GetPortMonitoringBindingMirrorStackStatusServiceURL = new StringBuilder("/infra/tier-1s/{tier-1-id}/segments/{segment-id}/ports/{port-id}/port-monitoring-profile-binding-maps/{port-monitoring-profile-binding-map-id}/mirror-stack-status");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Get
            };
            GetPortMonitoringBindingMirrorStackStatusServiceURL.Replace("{tier-1-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(Tier1Id, System.Globalization.CultureInfo.InvariantCulture)));
            GetPortMonitoringBindingMirrorStackStatusServiceURL.Replace("{segment-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(SegmentId, System.Globalization.CultureInfo.InvariantCulture)));
            GetPortMonitoringBindingMirrorStackStatusServiceURL.Replace("{port-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(PortId, System.Globalization.CultureInfo.InvariantCulture)));
            GetPortMonitoringBindingMirrorStackStatusServiceURL.Replace("{port-monitoring-profile-binding-map-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(PortMonitoringProfileBindingMapId, System.Globalization.CultureInfo.InvariantCulture)));
            if (Cursor != null) { request.AddQueryParameter("cursor", Cursor.ToString()); }
            if (EnforcementPointPath != null) { request.AddQueryParameter("enforcement_point_path", EnforcementPointPath.ToString()); }
            if (IncludedFields != null) { request.AddQueryParameter("included_fields", IncludedFields.ToString()); }
            if (PageSize != null) { request.AddQueryParameter("page_size", PageSize.ToString()); }
            if (SortAscending != null) { request.AddQueryParameter("sort_ascending", SortAscending.ToString()); }
            if (SortBy != null) { request.AddQueryParameter("sort_by", SortBy.ToString()); }
            request.Resource = GetPortMonitoringBindingMirrorStackStatusServiceURL.ToString();
            RestResponse<NSXTMirrorStackStatusListResultType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTMirrorStackStatusListResultType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Get operation to " + GetPortMonitoringBindingMirrorStackStatusServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTSegmentMonitoringProfileBindingMapType> UpdateInfraSegmentMonitoringBinding(string InfraSegmentId, string SegmentMonitoringProfileBindingMapId, NSXTSegmentMonitoringProfileBindingMapType SegmentMonitoringProfileBindingMap)
        {
            if (InfraSegmentId == null) { throw new System.ArgumentNullException("InfraSegmentId cannot be null"); }
            if (SegmentMonitoringProfileBindingMapId == null) { throw new System.ArgumentNullException("SegmentMonitoringProfileBindingMapId cannot be null"); }
            if (SegmentMonitoringProfileBindingMap == null) { throw new System.ArgumentNullException("SegmentMonitoringProfileBindingMap cannot be null"); }
            StringBuilder UpdateInfraSegmentMonitoringBindingServiceURL = new StringBuilder("/infra/segments/{infra-segment-id}/segment-monitoring-profile-binding-maps/{segment-monitoring-profile-binding-map-id}");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Put
            };
            UpdateInfraSegmentMonitoringBindingServiceURL.Replace("{infra-segment-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(InfraSegmentId, System.Globalization.CultureInfo.InvariantCulture)));
            UpdateInfraSegmentMonitoringBindingServiceURL.Replace("{segment-monitoring-profile-binding-map-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(SegmentMonitoringProfileBindingMapId, System.Globalization.CultureInfo.InvariantCulture)));
            request.AddJsonBody(SegmentMonitoringProfileBindingMap);
            request.Resource = UpdateInfraSegmentMonitoringBindingServiceURL.ToString();
            RestResponse<NSXTSegmentMonitoringProfileBindingMapType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTSegmentMonitoringProfileBindingMapType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Put operation to " + UpdateInfraSegmentMonitoringBindingServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task PatchInfraSegmentMonitoringBinding(string InfraSegmentId, string SegmentMonitoringProfileBindingMapId, NSXTSegmentMonitoringProfileBindingMapType SegmentMonitoringProfileBindingMap)
        {
            if (InfraSegmentId == null) { throw new System.ArgumentNullException("InfraSegmentId cannot be null"); }
            if (SegmentMonitoringProfileBindingMapId == null) { throw new System.ArgumentNullException("SegmentMonitoringProfileBindingMapId cannot be null"); }
            if (SegmentMonitoringProfileBindingMap == null) { throw new System.ArgumentNullException("SegmentMonitoringProfileBindingMap cannot be null"); }
            StringBuilder PatchInfraSegmentMonitoringBindingServiceURL = new StringBuilder("/infra/segments/{infra-segment-id}/segment-monitoring-profile-binding-maps/{segment-monitoring-profile-binding-map-id}");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Patch
            };
            PatchInfraSegmentMonitoringBindingServiceURL.Replace("{infra-segment-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(InfraSegmentId, System.Globalization.CultureInfo.InvariantCulture)));
            PatchInfraSegmentMonitoringBindingServiceURL.Replace("{segment-monitoring-profile-binding-map-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(SegmentMonitoringProfileBindingMapId, System.Globalization.CultureInfo.InvariantCulture)));
            request.AddJsonBody(SegmentMonitoringProfileBindingMap);
            request.Resource = PatchInfraSegmentMonitoringBindingServiceURL.ToString();
            RestResponse response = await restClient.ExecuteTaskAsyncWithPolicy(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Patch operation to " + PatchInfraSegmentMonitoringBindingServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task DeleteInfraSegmentMonitoringBinding(string InfraSegmentId, string SegmentMonitoringProfileBindingMapId)
        {
            if (InfraSegmentId == null) { throw new System.ArgumentNullException("InfraSegmentId cannot be null"); }
            if (SegmentMonitoringProfileBindingMapId == null) { throw new System.ArgumentNullException("SegmentMonitoringProfileBindingMapId cannot be null"); }
            StringBuilder DeleteInfraSegmentMonitoringBindingServiceURL = new StringBuilder("/infra/segments/{infra-segment-id}/segment-monitoring-profile-binding-maps/{segment-monitoring-profile-binding-map-id}");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Delete
            };
            DeleteInfraSegmentMonitoringBindingServiceURL.Replace("{infra-segment-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(InfraSegmentId, System.Globalization.CultureInfo.InvariantCulture)));
            DeleteInfraSegmentMonitoringBindingServiceURL.Replace("{segment-monitoring-profile-binding-map-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(SegmentMonitoringProfileBindingMapId, System.Globalization.CultureInfo.InvariantCulture)));
            request.Resource = DeleteInfraSegmentMonitoringBindingServiceURL.ToString();
            RestResponse response = await restClient.ExecuteTaskAsyncWithPolicy(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Delete operation to " + DeleteInfraSegmentMonitoringBindingServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTSegmentMonitoringProfileBindingMapType> GetInfraSegmentMonitoringBinding(string InfraSegmentId, string SegmentMonitoringProfileBindingMapId)
        {
            if (InfraSegmentId == null) { throw new System.ArgumentNullException("InfraSegmentId cannot be null"); }
            if (SegmentMonitoringProfileBindingMapId == null) { throw new System.ArgumentNullException("SegmentMonitoringProfileBindingMapId cannot be null"); }
            StringBuilder GetInfraSegmentMonitoringBindingServiceURL = new StringBuilder("/infra/segments/{infra-segment-id}/segment-monitoring-profile-binding-maps/{segment-monitoring-profile-binding-map-id}");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Get
            };
            GetInfraSegmentMonitoringBindingServiceURL.Replace("{infra-segment-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(InfraSegmentId, System.Globalization.CultureInfo.InvariantCulture)));
            GetInfraSegmentMonitoringBindingServiceURL.Replace("{segment-monitoring-profile-binding-map-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(SegmentMonitoringProfileBindingMapId, System.Globalization.CultureInfo.InvariantCulture)));
            request.Resource = GetInfraSegmentMonitoringBindingServiceURL.ToString();
            RestResponse<NSXTSegmentMonitoringProfileBindingMapType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTSegmentMonitoringProfileBindingMapType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Get operation to " + GetInfraSegmentMonitoringBindingServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTMirrorStackStatusListResultType> GlobalGlobalInfraGetSegmentMonitoringBindingMirrorStackStatus(string Tier1Id, string SegmentId, string SegmentMonitoringProfileBindingMapId, string? Cursor = null, string? EnforcementPointPath = null, string? IncludedFields = null, long? PageSize = null, bool? SortAscending = null, string? SortBy = null)
        {
            if (Tier1Id == null) { throw new System.ArgumentNullException("Tier1Id cannot be null"); }
            if (SegmentId == null) { throw new System.ArgumentNullException("SegmentId cannot be null"); }
            if (SegmentMonitoringProfileBindingMapId == null) { throw new System.ArgumentNullException("SegmentMonitoringProfileBindingMapId cannot be null"); }
            StringBuilder GlobalInfraGetSegmentMonitoringBindingMirrorStackStatusServiceURL = new StringBuilder("/global-infra/tier-1s/{tier-1-id}/segments/{segment-id}/segment-monitoring-profile-binding-maps/{segment-monitoring-profile-binding-map-id}/mirror-stack-status");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Get
            };
            GlobalInfraGetSegmentMonitoringBindingMirrorStackStatusServiceURL.Replace("{tier-1-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(Tier1Id, System.Globalization.CultureInfo.InvariantCulture)));
            GlobalInfraGetSegmentMonitoringBindingMirrorStackStatusServiceURL.Replace("{segment-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(SegmentId, System.Globalization.CultureInfo.InvariantCulture)));
            GlobalInfraGetSegmentMonitoringBindingMirrorStackStatusServiceURL.Replace("{segment-monitoring-profile-binding-map-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(SegmentMonitoringProfileBindingMapId, System.Globalization.CultureInfo.InvariantCulture)));
            if (Cursor != null) { request.AddQueryParameter("cursor", Cursor.ToString()); }
            if (EnforcementPointPath != null) { request.AddQueryParameter("enforcement_point_path", EnforcementPointPath.ToString()); }
            if (IncludedFields != null) { request.AddQueryParameter("included_fields", IncludedFields.ToString()); }
            if (PageSize != null) { request.AddQueryParameter("page_size", PageSize.ToString()); }
            if (SortAscending != null) { request.AddQueryParameter("sort_ascending", SortAscending.ToString()); }
            if (SortBy != null) { request.AddQueryParameter("sort_by", SortBy.ToString()); }
            request.Resource = GlobalInfraGetSegmentMonitoringBindingMirrorStackStatusServiceURL.ToString();
            RestResponse<NSXTMirrorStackStatusListResultType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTMirrorStackStatusListResultType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Get operation to " + GlobalInfraGetSegmentMonitoringBindingMirrorStackStatusServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTSegmentMonitoringProfileBindingMapListResultType> GlobalGlobalInfraListInfraSegmentMonitoringBindings(string InfraSegmentId, string? Cursor = null, bool? IncludeMarkForDeleteObjects = null, string? IncludedFields = null, long? PageSize = null, bool? SortAscending = null, string? SortBy = null)
        {
            if (InfraSegmentId == null) { throw new System.ArgumentNullException("InfraSegmentId cannot be null"); }
            StringBuilder GlobalInfraListInfraSegmentMonitoringBindingsServiceURL = new StringBuilder("/global-infra/segments/{infra-segment-id}/segment-monitoring-profile-binding-maps");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Get
            };
            GlobalInfraListInfraSegmentMonitoringBindingsServiceURL.Replace("{infra-segment-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(InfraSegmentId, System.Globalization.CultureInfo.InvariantCulture)));
            if (Cursor != null) { request.AddQueryParameter("cursor", Cursor.ToString()); }
            if (IncludeMarkForDeleteObjects != null) { request.AddQueryParameter("include_mark_for_delete_objects", IncludeMarkForDeleteObjects.ToString()); }
            if (IncludedFields != null) { request.AddQueryParameter("included_fields", IncludedFields.ToString()); }
            if (PageSize != null) { request.AddQueryParameter("page_size", PageSize.ToString()); }
            if (SortAscending != null) { request.AddQueryParameter("sort_ascending", SortAscending.ToString()); }
            if (SortBy != null) { request.AddQueryParameter("sort_by", SortBy.ToString()); }
            request.Resource = GlobalInfraListInfraSegmentMonitoringBindingsServiceURL.ToString();
            RestResponse<NSXTSegmentMonitoringProfileBindingMapListResultType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTSegmentMonitoringProfileBindingMapListResultType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Get operation to " + GlobalInfraListInfraSegmentMonitoringBindingsServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTSegmentMonitoringProfileBindingMapType> GlobalGlobalInfraGetInfraSegmentMonitoringBinding(string InfraSegmentId, string SegmentMonitoringProfileBindingMapId)
        {
            if (InfraSegmentId == null) { throw new System.ArgumentNullException("InfraSegmentId cannot be null"); }
            if (SegmentMonitoringProfileBindingMapId == null) { throw new System.ArgumentNullException("SegmentMonitoringProfileBindingMapId cannot be null"); }
            StringBuilder GlobalInfraGetInfraSegmentMonitoringBindingServiceURL = new StringBuilder("/global-infra/segments/{infra-segment-id}/segment-monitoring-profile-binding-maps/{segment-monitoring-profile-binding-map-id}");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Get
            };
            GlobalInfraGetInfraSegmentMonitoringBindingServiceURL.Replace("{infra-segment-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(InfraSegmentId, System.Globalization.CultureInfo.InvariantCulture)));
            GlobalInfraGetInfraSegmentMonitoringBindingServiceURL.Replace("{segment-monitoring-profile-binding-map-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(SegmentMonitoringProfileBindingMapId, System.Globalization.CultureInfo.InvariantCulture)));
            request.Resource = GlobalInfraGetInfraSegmentMonitoringBindingServiceURL.ToString();
            RestResponse<NSXTSegmentMonitoringProfileBindingMapType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTSegmentMonitoringProfileBindingMapType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Get operation to " + GlobalInfraGetInfraSegmentMonitoringBindingServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTGroupMonitoringProfileBindingMapListResultType> GlobalGlobalInfraListGroupMonitoringBindings(string DomainId, string GroupId, string? Cursor = null, bool? IncludeMarkForDeleteObjects = null, string? IncludedFields = null, long? PageSize = null, bool? SortAscending = null, string? SortBy = null)
        {
            if (DomainId == null) { throw new System.ArgumentNullException("DomainId cannot be null"); }
            if (GroupId == null) { throw new System.ArgumentNullException("GroupId cannot be null"); }
            StringBuilder GlobalInfraListGroupMonitoringBindingsServiceURL = new StringBuilder("/global-infra/domains/{domain-id}/groups/{group-id}/group-monitoring-profile-binding-maps");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Get
            };
            GlobalInfraListGroupMonitoringBindingsServiceURL.Replace("{domain-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(DomainId, System.Globalization.CultureInfo.InvariantCulture)));
            GlobalInfraListGroupMonitoringBindingsServiceURL.Replace("{group-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(GroupId, System.Globalization.CultureInfo.InvariantCulture)));
            if (Cursor != null) { request.AddQueryParameter("cursor", Cursor.ToString()); }
            if (IncludeMarkForDeleteObjects != null) { request.AddQueryParameter("include_mark_for_delete_objects", IncludeMarkForDeleteObjects.ToString()); }
            if (IncludedFields != null) { request.AddQueryParameter("included_fields", IncludedFields.ToString()); }
            if (PageSize != null) { request.AddQueryParameter("page_size", PageSize.ToString()); }
            if (SortAscending != null) { request.AddQueryParameter("sort_ascending", SortAscending.ToString()); }
            if (SortBy != null) { request.AddQueryParameter("sort_by", SortBy.ToString()); }
            request.Resource = GlobalInfraListGroupMonitoringBindingsServiceURL.ToString();
            RestResponse<NSXTGroupMonitoringProfileBindingMapListResultType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTGroupMonitoringProfileBindingMapListResultType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Get operation to " + GlobalInfraListGroupMonitoringBindingsServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTPortMonitoringProfileBindingMapListResultType> GlobalGlobalInfraListPortMonitoringBindings(string Tier1Id, string SegmentId, string PortId, string? Cursor = null, bool? IncludeMarkForDeleteObjects = null, string? IncludedFields = null, long? PageSize = null, bool? SortAscending = null, string? SortBy = null)
        {
            if (Tier1Id == null) { throw new System.ArgumentNullException("Tier1Id cannot be null"); }
            if (SegmentId == null) { throw new System.ArgumentNullException("SegmentId cannot be null"); }
            if (PortId == null) { throw new System.ArgumentNullException("PortId cannot be null"); }
            StringBuilder GlobalInfraListPortMonitoringBindingsServiceURL = new StringBuilder("/global-infra/tier-1s/{tier-1-id}/segments/{segment-id}/ports/{port-id}/port-monitoring-profile-binding-maps");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Get
            };
            GlobalInfraListPortMonitoringBindingsServiceURL.Replace("{tier-1-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(Tier1Id, System.Globalization.CultureInfo.InvariantCulture)));
            GlobalInfraListPortMonitoringBindingsServiceURL.Replace("{segment-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(SegmentId, System.Globalization.CultureInfo.InvariantCulture)));
            GlobalInfraListPortMonitoringBindingsServiceURL.Replace("{port-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(PortId, System.Globalization.CultureInfo.InvariantCulture)));
            if (Cursor != null) { request.AddQueryParameter("cursor", Cursor.ToString()); }
            if (IncludeMarkForDeleteObjects != null) { request.AddQueryParameter("include_mark_for_delete_objects", IncludeMarkForDeleteObjects.ToString()); }
            if (IncludedFields != null) { request.AddQueryParameter("included_fields", IncludedFields.ToString()); }
            if (PageSize != null) { request.AddQueryParameter("page_size", PageSize.ToString()); }
            if (SortAscending != null) { request.AddQueryParameter("sort_ascending", SortAscending.ToString()); }
            if (SortBy != null) { request.AddQueryParameter("sort_by", SortBy.ToString()); }
            request.Resource = GlobalInfraListPortMonitoringBindingsServiceURL.ToString();
            RestResponse<NSXTPortMonitoringProfileBindingMapListResultType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTPortMonitoringProfileBindingMapListResultType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Get operation to " + GlobalInfraListPortMonitoringBindingsServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTMirrorStackStatusListResultType> GlobalGlobalInfraGetInfraPortMonitoringBindingMirrorStackStatus(string InfraSegmentId, string InfraPortId, string PortMonitoringProfileBindingMapId, string? Cursor = null, string? EnforcementPointPath = null, string? IncludedFields = null, long? PageSize = null, bool? SortAscending = null, string? SortBy = null)
        {
            if (InfraSegmentId == null) { throw new System.ArgumentNullException("InfraSegmentId cannot be null"); }
            if (InfraPortId == null) { throw new System.ArgumentNullException("InfraPortId cannot be null"); }
            if (PortMonitoringProfileBindingMapId == null) { throw new System.ArgumentNullException("PortMonitoringProfileBindingMapId cannot be null"); }
            StringBuilder GlobalInfraGetInfraPortMonitoringBindingMirrorStackStatusServiceURL = new StringBuilder("/global-infra/segments/{infra-segment-id}/ports/{infra-port-id}/port-monitoring-profile-binding-maps/{port-monitoring-profile-binding-map-id}/mirror-stack-status");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Get
            };
            GlobalInfraGetInfraPortMonitoringBindingMirrorStackStatusServiceURL.Replace("{infra-segment-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(InfraSegmentId, System.Globalization.CultureInfo.InvariantCulture)));
            GlobalInfraGetInfraPortMonitoringBindingMirrorStackStatusServiceURL.Replace("{infra-port-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(InfraPortId, System.Globalization.CultureInfo.InvariantCulture)));
            GlobalInfraGetInfraPortMonitoringBindingMirrorStackStatusServiceURL.Replace("{port-monitoring-profile-binding-map-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(PortMonitoringProfileBindingMapId, System.Globalization.CultureInfo.InvariantCulture)));
            if (Cursor != null) { request.AddQueryParameter("cursor", Cursor.ToString()); }
            if (EnforcementPointPath != null) { request.AddQueryParameter("enforcement_point_path", EnforcementPointPath.ToString()); }
            if (IncludedFields != null) { request.AddQueryParameter("included_fields", IncludedFields.ToString()); }
            if (PageSize != null) { request.AddQueryParameter("page_size", PageSize.ToString()); }
            if (SortAscending != null) { request.AddQueryParameter("sort_ascending", SortAscending.ToString()); }
            if (SortBy != null) { request.AddQueryParameter("sort_by", SortBy.ToString()); }
            request.Resource = GlobalInfraGetInfraPortMonitoringBindingMirrorStackStatusServiceURL.ToString();
            RestResponse<NSXTMirrorStackStatusListResultType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTMirrorStackStatusListResultType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Get operation to " + GlobalInfraGetInfraPortMonitoringBindingMirrorStackStatusServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTPortMonitoringProfileBindingMapListResultType> ListPortMonitoringBindings(string Tier1Id, string SegmentId, string PortId, string? Cursor = null, bool? IncludeMarkForDeleteObjects = null, string? IncludedFields = null, long? PageSize = null, bool? SortAscending = null, string? SortBy = null)
        {
            if (Tier1Id == null) { throw new System.ArgumentNullException("Tier1Id cannot be null"); }
            if (SegmentId == null) { throw new System.ArgumentNullException("SegmentId cannot be null"); }
            if (PortId == null) { throw new System.ArgumentNullException("PortId cannot be null"); }
            StringBuilder ListPortMonitoringBindingsServiceURL = new StringBuilder("/infra/tier-1s/{tier-1-id}/segments/{segment-id}/ports/{port-id}/port-monitoring-profile-binding-maps");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Get
            };
            ListPortMonitoringBindingsServiceURL.Replace("{tier-1-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(Tier1Id, System.Globalization.CultureInfo.InvariantCulture)));
            ListPortMonitoringBindingsServiceURL.Replace("{segment-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(SegmentId, System.Globalization.CultureInfo.InvariantCulture)));
            ListPortMonitoringBindingsServiceURL.Replace("{port-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(PortId, System.Globalization.CultureInfo.InvariantCulture)));
            if (Cursor != null) { request.AddQueryParameter("cursor", Cursor.ToString()); }
            if (IncludeMarkForDeleteObjects != null) { request.AddQueryParameter("include_mark_for_delete_objects", IncludeMarkForDeleteObjects.ToString()); }
            if (IncludedFields != null) { request.AddQueryParameter("included_fields", IncludedFields.ToString()); }
            if (PageSize != null) { request.AddQueryParameter("page_size", PageSize.ToString()); }
            if (SortAscending != null) { request.AddQueryParameter("sort_ascending", SortAscending.ToString()); }
            if (SortBy != null) { request.AddQueryParameter("sort_by", SortBy.ToString()); }
            request.Resource = ListPortMonitoringBindingsServiceURL.ToString();
            RestResponse<NSXTPortMonitoringProfileBindingMapListResultType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTPortMonitoringProfileBindingMapListResultType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Get operation to " + ListPortMonitoringBindingsServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
    }
}
