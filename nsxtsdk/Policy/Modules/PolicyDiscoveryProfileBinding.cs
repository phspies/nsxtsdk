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
    public class PolicyDiscoveryProfileBinding
    {
        private RestClient restClient;
        private int retry;
        private int timeout;
        private CancellationToken cancellationToken;

        public PolicyDiscoveryProfileBinding(RestClient Client, CancellationToken _cancellationToken, int _timeout, int _retry)
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
        public async Task<NSXTSegmentDiscoveryProfileBindingMapListResultType> ListInfraSegmentDiscoveryBindings(string InfraSegmentId, string? Cursor = null, bool? IncludeMarkForDeleteObjects = null, string? IncludedFields = null, long? PageSize = null, bool? SortAscending = null, string? SortBy = null)
        {
            if (InfraSegmentId == null) { throw new System.ArgumentNullException("InfraSegmentId cannot be null"); }
            StringBuilder ListInfraSegmentDiscoveryBindingsServiceURL = new StringBuilder("/infra/segments/{infra-segment-id}/segment-discovery-profile-binding-maps");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Get
            };
            ListInfraSegmentDiscoveryBindingsServiceURL.Replace("{infra-segment-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(InfraSegmentId, System.Globalization.CultureInfo.InvariantCulture)));
            if (Cursor != null) { request.AddQueryParameter("cursor", Cursor.ToString()); }
            if (IncludeMarkForDeleteObjects != null) { request.AddQueryParameter("include_mark_for_delete_objects", IncludeMarkForDeleteObjects.ToString()); }
            if (IncludedFields != null) { request.AddQueryParameter("included_fields", IncludedFields.ToString()); }
            if (PageSize != null) { request.AddQueryParameter("page_size", PageSize.ToString()); }
            if (SortAscending != null) { request.AddQueryParameter("sort_ascending", SortAscending.ToString()); }
            if (SortBy != null) { request.AddQueryParameter("sort_by", SortBy.ToString()); }
            request.Resource = ListInfraSegmentDiscoveryBindingsServiceURL.ToString();
            RestResponse<NSXTSegmentDiscoveryProfileBindingMapListResultType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTSegmentDiscoveryProfileBindingMapListResultType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Get operation to " + ListInfraSegmentDiscoveryBindingsServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTGroupDiscoveryProfileBindingMapType> UpdateGroupDiscoveryProfileBinding(string DomainId, string GroupId, string DiscoveryProfileBindingMapId, NSXTGroupDiscoveryProfileBindingMapType GroupDiscoveryProfileBindingMap)
        {
            if (DomainId == null) { throw new System.ArgumentNullException("DomainId cannot be null"); }
            if (GroupId == null) { throw new System.ArgumentNullException("GroupId cannot be null"); }
            if (DiscoveryProfileBindingMapId == null) { throw new System.ArgumentNullException("DiscoveryProfileBindingMapId cannot be null"); }
            if (GroupDiscoveryProfileBindingMap == null) { throw new System.ArgumentNullException("GroupDiscoveryProfileBindingMap cannot be null"); }
            StringBuilder UpdateGroupDiscoveryProfileBindingServiceURL = new StringBuilder("/infra/domains/{domain-id}/groups/{group-id}/discovery-profile-binding-maps/{discovery-profile-binding-map-id}");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Put
            };
            UpdateGroupDiscoveryProfileBindingServiceURL.Replace("{domain-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(DomainId, System.Globalization.CultureInfo.InvariantCulture)));
            UpdateGroupDiscoveryProfileBindingServiceURL.Replace("{group-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(GroupId, System.Globalization.CultureInfo.InvariantCulture)));
            UpdateGroupDiscoveryProfileBindingServiceURL.Replace("{discovery-profile-binding-map-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(DiscoveryProfileBindingMapId, System.Globalization.CultureInfo.InvariantCulture)));
            request.AddJsonBody(GroupDiscoveryProfileBindingMap);
            request.Resource = UpdateGroupDiscoveryProfileBindingServiceURL.ToString();
            RestResponse<NSXTGroupDiscoveryProfileBindingMapType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTGroupDiscoveryProfileBindingMapType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Put operation to " + UpdateGroupDiscoveryProfileBindingServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task PatchGroupDiscoveryProfileBinding(string DomainId, string GroupId, string DiscoveryProfileBindingMapId, NSXTGroupDiscoveryProfileBindingMapType GroupDiscoveryProfileBindingMap)
        {
            if (DomainId == null) { throw new System.ArgumentNullException("DomainId cannot be null"); }
            if (GroupId == null) { throw new System.ArgumentNullException("GroupId cannot be null"); }
            if (DiscoveryProfileBindingMapId == null) { throw new System.ArgumentNullException("DiscoveryProfileBindingMapId cannot be null"); }
            if (GroupDiscoveryProfileBindingMap == null) { throw new System.ArgumentNullException("GroupDiscoveryProfileBindingMap cannot be null"); }
            StringBuilder PatchGroupDiscoveryProfileBindingServiceURL = new StringBuilder("/infra/domains/{domain-id}/groups/{group-id}/discovery-profile-binding-maps/{discovery-profile-binding-map-id}");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Patch
            };
            PatchGroupDiscoveryProfileBindingServiceURL.Replace("{domain-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(DomainId, System.Globalization.CultureInfo.InvariantCulture)));
            PatchGroupDiscoveryProfileBindingServiceURL.Replace("{group-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(GroupId, System.Globalization.CultureInfo.InvariantCulture)));
            PatchGroupDiscoveryProfileBindingServiceURL.Replace("{discovery-profile-binding-map-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(DiscoveryProfileBindingMapId, System.Globalization.CultureInfo.InvariantCulture)));
            request.AddJsonBody(GroupDiscoveryProfileBindingMap);
            request.Resource = PatchGroupDiscoveryProfileBindingServiceURL.ToString();
            RestResponse response = await restClient.ExecuteTaskAsyncWithPolicy(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Patch operation to " + PatchGroupDiscoveryProfileBindingServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTGroupDiscoveryProfileBindingMapType> GetGroupDiscoveryProfileBinding(string DomainId, string GroupId, string DiscoveryProfileBindingMapId)
        {
            if (DomainId == null) { throw new System.ArgumentNullException("DomainId cannot be null"); }
            if (GroupId == null) { throw new System.ArgumentNullException("GroupId cannot be null"); }
            if (DiscoveryProfileBindingMapId == null) { throw new System.ArgumentNullException("DiscoveryProfileBindingMapId cannot be null"); }
            StringBuilder GetGroupDiscoveryProfileBindingServiceURL = new StringBuilder("/infra/domains/{domain-id}/groups/{group-id}/discovery-profile-binding-maps/{discovery-profile-binding-map-id}");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Get
            };
            GetGroupDiscoveryProfileBindingServiceURL.Replace("{domain-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(DomainId, System.Globalization.CultureInfo.InvariantCulture)));
            GetGroupDiscoveryProfileBindingServiceURL.Replace("{group-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(GroupId, System.Globalization.CultureInfo.InvariantCulture)));
            GetGroupDiscoveryProfileBindingServiceURL.Replace("{discovery-profile-binding-map-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(DiscoveryProfileBindingMapId, System.Globalization.CultureInfo.InvariantCulture)));
            request.Resource = GetGroupDiscoveryProfileBindingServiceURL.ToString();
            RestResponse<NSXTGroupDiscoveryProfileBindingMapType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTGroupDiscoveryProfileBindingMapType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Get operation to " + GetGroupDiscoveryProfileBindingServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task DeleteGroupDiscoveryProfileBinding(string DomainId, string GroupId, string DiscoveryProfileBindingMapId)
        {
            if (DomainId == null) { throw new System.ArgumentNullException("DomainId cannot be null"); }
            if (GroupId == null) { throw new System.ArgumentNullException("GroupId cannot be null"); }
            if (DiscoveryProfileBindingMapId == null) { throw new System.ArgumentNullException("DiscoveryProfileBindingMapId cannot be null"); }
            StringBuilder DeleteGroupDiscoveryProfileBindingServiceURL = new StringBuilder("/infra/domains/{domain-id}/groups/{group-id}/discovery-profile-binding-maps/{discovery-profile-binding-map-id}");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Delete
            };
            DeleteGroupDiscoveryProfileBindingServiceURL.Replace("{domain-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(DomainId, System.Globalization.CultureInfo.InvariantCulture)));
            DeleteGroupDiscoveryProfileBindingServiceURL.Replace("{group-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(GroupId, System.Globalization.CultureInfo.InvariantCulture)));
            DeleteGroupDiscoveryProfileBindingServiceURL.Replace("{discovery-profile-binding-map-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(DiscoveryProfileBindingMapId, System.Globalization.CultureInfo.InvariantCulture)));
            request.Resource = DeleteGroupDiscoveryProfileBindingServiceURL.ToString();
            RestResponse response = await restClient.ExecuteTaskAsyncWithPolicy(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Delete operation to " + DeleteGroupDiscoveryProfileBindingServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTSegmentDiscoveryProfileBindingMapListResultType> ListSegmentDiscoveryBindings(string Tier1Id, string SegmentId, string? Cursor = null, bool? IncludeMarkForDeleteObjects = null, string? IncludedFields = null, long? PageSize = null, bool? SortAscending = null, string? SortBy = null)
        {
            if (Tier1Id == null) { throw new System.ArgumentNullException("Tier1Id cannot be null"); }
            if (SegmentId == null) { throw new System.ArgumentNullException("SegmentId cannot be null"); }
            StringBuilder ListSegmentDiscoveryBindingsServiceURL = new StringBuilder("/infra/tier-1s/{tier-1-id}/segments/{segment-id}/segment-discovery-profile-binding-maps");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Get
            };
            ListSegmentDiscoveryBindingsServiceURL.Replace("{tier-1-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(Tier1Id, System.Globalization.CultureInfo.InvariantCulture)));
            ListSegmentDiscoveryBindingsServiceURL.Replace("{segment-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(SegmentId, System.Globalization.CultureInfo.InvariantCulture)));
            if (Cursor != null) { request.AddQueryParameter("cursor", Cursor.ToString()); }
            if (IncludeMarkForDeleteObjects != null) { request.AddQueryParameter("include_mark_for_delete_objects", IncludeMarkForDeleteObjects.ToString()); }
            if (IncludedFields != null) { request.AddQueryParameter("included_fields", IncludedFields.ToString()); }
            if (PageSize != null) { request.AddQueryParameter("page_size", PageSize.ToString()); }
            if (SortAscending != null) { request.AddQueryParameter("sort_ascending", SortAscending.ToString()); }
            if (SortBy != null) { request.AddQueryParameter("sort_by", SortBy.ToString()); }
            request.Resource = ListSegmentDiscoveryBindingsServiceURL.ToString();
            RestResponse<NSXTSegmentDiscoveryProfileBindingMapListResultType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTSegmentDiscoveryProfileBindingMapListResultType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Get operation to " + ListSegmentDiscoveryBindingsServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTSegmentDiscoveryProfileBindingMapType> UpdateInfraSegmentDiscoveryBinding(string InfraSegmentId, string SegmentDiscoveryProfileBindingMapId, NSXTSegmentDiscoveryProfileBindingMapType SegmentDiscoveryProfileBindingMap)
        {
            if (InfraSegmentId == null) { throw new System.ArgumentNullException("InfraSegmentId cannot be null"); }
            if (SegmentDiscoveryProfileBindingMapId == null) { throw new System.ArgumentNullException("SegmentDiscoveryProfileBindingMapId cannot be null"); }
            if (SegmentDiscoveryProfileBindingMap == null) { throw new System.ArgumentNullException("SegmentDiscoveryProfileBindingMap cannot be null"); }
            StringBuilder UpdateInfraSegmentDiscoveryBindingServiceURL = new StringBuilder("/infra/segments/{infra-segment-id}/segment-discovery-profile-binding-maps/{segment-discovery-profile-binding-map-id}");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Put
            };
            UpdateInfraSegmentDiscoveryBindingServiceURL.Replace("{infra-segment-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(InfraSegmentId, System.Globalization.CultureInfo.InvariantCulture)));
            UpdateInfraSegmentDiscoveryBindingServiceURL.Replace("{segment-discovery-profile-binding-map-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(SegmentDiscoveryProfileBindingMapId, System.Globalization.CultureInfo.InvariantCulture)));
            request.AddJsonBody(SegmentDiscoveryProfileBindingMap);
            request.Resource = UpdateInfraSegmentDiscoveryBindingServiceURL.ToString();
            RestResponse<NSXTSegmentDiscoveryProfileBindingMapType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTSegmentDiscoveryProfileBindingMapType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Put operation to " + UpdateInfraSegmentDiscoveryBindingServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task DeleteInfraSegmentDiscoveryBinding(string InfraSegmentId, string SegmentDiscoveryProfileBindingMapId)
        {
            if (InfraSegmentId == null) { throw new System.ArgumentNullException("InfraSegmentId cannot be null"); }
            if (SegmentDiscoveryProfileBindingMapId == null) { throw new System.ArgumentNullException("SegmentDiscoveryProfileBindingMapId cannot be null"); }
            StringBuilder DeleteInfraSegmentDiscoveryBindingServiceURL = new StringBuilder("/infra/segments/{infra-segment-id}/segment-discovery-profile-binding-maps/{segment-discovery-profile-binding-map-id}");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Delete
            };
            DeleteInfraSegmentDiscoveryBindingServiceURL.Replace("{infra-segment-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(InfraSegmentId, System.Globalization.CultureInfo.InvariantCulture)));
            DeleteInfraSegmentDiscoveryBindingServiceURL.Replace("{segment-discovery-profile-binding-map-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(SegmentDiscoveryProfileBindingMapId, System.Globalization.CultureInfo.InvariantCulture)));
            request.Resource = DeleteInfraSegmentDiscoveryBindingServiceURL.ToString();
            RestResponse response = await restClient.ExecuteTaskAsyncWithPolicy(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Delete operation to " + DeleteInfraSegmentDiscoveryBindingServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTSegmentDiscoveryProfileBindingMapType> GetInfraSegmentDiscoveryBinding(string InfraSegmentId, string SegmentDiscoveryProfileBindingMapId)
        {
            if (InfraSegmentId == null) { throw new System.ArgumentNullException("InfraSegmentId cannot be null"); }
            if (SegmentDiscoveryProfileBindingMapId == null) { throw new System.ArgumentNullException("SegmentDiscoveryProfileBindingMapId cannot be null"); }
            StringBuilder GetInfraSegmentDiscoveryBindingServiceURL = new StringBuilder("/infra/segments/{infra-segment-id}/segment-discovery-profile-binding-maps/{segment-discovery-profile-binding-map-id}");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Get
            };
            GetInfraSegmentDiscoveryBindingServiceURL.Replace("{infra-segment-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(InfraSegmentId, System.Globalization.CultureInfo.InvariantCulture)));
            GetInfraSegmentDiscoveryBindingServiceURL.Replace("{segment-discovery-profile-binding-map-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(SegmentDiscoveryProfileBindingMapId, System.Globalization.CultureInfo.InvariantCulture)));
            request.Resource = GetInfraSegmentDiscoveryBindingServiceURL.ToString();
            RestResponse<NSXTSegmentDiscoveryProfileBindingMapType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTSegmentDiscoveryProfileBindingMapType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Get operation to " + GetInfraSegmentDiscoveryBindingServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task PatchInfraSegmentDiscoveryBinding(string InfraSegmentId, string SegmentDiscoveryProfileBindingMapId, NSXTSegmentDiscoveryProfileBindingMapType SegmentDiscoveryProfileBindingMap)
        {
            if (InfraSegmentId == null) { throw new System.ArgumentNullException("InfraSegmentId cannot be null"); }
            if (SegmentDiscoveryProfileBindingMapId == null) { throw new System.ArgumentNullException("SegmentDiscoveryProfileBindingMapId cannot be null"); }
            if (SegmentDiscoveryProfileBindingMap == null) { throw new System.ArgumentNullException("SegmentDiscoveryProfileBindingMap cannot be null"); }
            StringBuilder PatchInfraSegmentDiscoveryBindingServiceURL = new StringBuilder("/infra/segments/{infra-segment-id}/segment-discovery-profile-binding-maps/{segment-discovery-profile-binding-map-id}");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Patch
            };
            PatchInfraSegmentDiscoveryBindingServiceURL.Replace("{infra-segment-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(InfraSegmentId, System.Globalization.CultureInfo.InvariantCulture)));
            PatchInfraSegmentDiscoveryBindingServiceURL.Replace("{segment-discovery-profile-binding-map-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(SegmentDiscoveryProfileBindingMapId, System.Globalization.CultureInfo.InvariantCulture)));
            request.AddJsonBody(SegmentDiscoveryProfileBindingMap);
            request.Resource = PatchInfraSegmentDiscoveryBindingServiceURL.ToString();
            RestResponse response = await restClient.ExecuteTaskAsyncWithPolicy(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Patch operation to " + PatchInfraSegmentDiscoveryBindingServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTPortDiscoveryProfileBindingMapListResultType> GlobalGlobalInfraListPortDiscoveryBindings(string Tier1Id, string SegmentId, string PortId, string? Cursor = null, bool? IncludeMarkForDeleteObjects = null, string? IncludedFields = null, long? PageSize = null, bool? SortAscending = null, string? SortBy = null)
        {
            if (Tier1Id == null) { throw new System.ArgumentNullException("Tier1Id cannot be null"); }
            if (SegmentId == null) { throw new System.ArgumentNullException("SegmentId cannot be null"); }
            if (PortId == null) { throw new System.ArgumentNullException("PortId cannot be null"); }
            StringBuilder GlobalInfraListPortDiscoveryBindingsServiceURL = new StringBuilder("/global-infra/tier-1s/{tier-1-id}/segments/{segment-id}/ports/{port-id}/port-discovery-profile-binding-maps");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Get
            };
            GlobalInfraListPortDiscoveryBindingsServiceURL.Replace("{tier-1-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(Tier1Id, System.Globalization.CultureInfo.InvariantCulture)));
            GlobalInfraListPortDiscoveryBindingsServiceURL.Replace("{segment-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(SegmentId, System.Globalization.CultureInfo.InvariantCulture)));
            GlobalInfraListPortDiscoveryBindingsServiceURL.Replace("{port-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(PortId, System.Globalization.CultureInfo.InvariantCulture)));
            if (Cursor != null) { request.AddQueryParameter("cursor", Cursor.ToString()); }
            if (IncludeMarkForDeleteObjects != null) { request.AddQueryParameter("include_mark_for_delete_objects", IncludeMarkForDeleteObjects.ToString()); }
            if (IncludedFields != null) { request.AddQueryParameter("included_fields", IncludedFields.ToString()); }
            if (PageSize != null) { request.AddQueryParameter("page_size", PageSize.ToString()); }
            if (SortAscending != null) { request.AddQueryParameter("sort_ascending", SortAscending.ToString()); }
            if (SortBy != null) { request.AddQueryParameter("sort_by", SortBy.ToString()); }
            request.Resource = GlobalInfraListPortDiscoveryBindingsServiceURL.ToString();
            RestResponse<NSXTPortDiscoveryProfileBindingMapListResultType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTPortDiscoveryProfileBindingMapListResultType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Get operation to " + GlobalInfraListPortDiscoveryBindingsServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTPortDiscoveryProfileBindingMapType> UpdateInfraPortDiscoveryBinding(string InfraSegmentId, string InfraPortId, string PortDiscoveryProfileBindingMapId, NSXTPortDiscoveryProfileBindingMapType PortDiscoveryProfileBindingMap)
        {
            if (InfraSegmentId == null) { throw new System.ArgumentNullException("InfraSegmentId cannot be null"); }
            if (InfraPortId == null) { throw new System.ArgumentNullException("InfraPortId cannot be null"); }
            if (PortDiscoveryProfileBindingMapId == null) { throw new System.ArgumentNullException("PortDiscoveryProfileBindingMapId cannot be null"); }
            if (PortDiscoveryProfileBindingMap == null) { throw new System.ArgumentNullException("PortDiscoveryProfileBindingMap cannot be null"); }
            StringBuilder UpdateInfraPortDiscoveryBindingServiceURL = new StringBuilder("/infra/segments/{infra-segment-id}/ports/{infra-port-id}/port-discovery-profile-binding-maps/{port-discovery-profile-binding-map-id}");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Put
            };
            UpdateInfraPortDiscoveryBindingServiceURL.Replace("{infra-segment-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(InfraSegmentId, System.Globalization.CultureInfo.InvariantCulture)));
            UpdateInfraPortDiscoveryBindingServiceURL.Replace("{infra-port-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(InfraPortId, System.Globalization.CultureInfo.InvariantCulture)));
            UpdateInfraPortDiscoveryBindingServiceURL.Replace("{port-discovery-profile-binding-map-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(PortDiscoveryProfileBindingMapId, System.Globalization.CultureInfo.InvariantCulture)));
            request.AddJsonBody(PortDiscoveryProfileBindingMap);
            request.Resource = UpdateInfraPortDiscoveryBindingServiceURL.ToString();
            RestResponse<NSXTPortDiscoveryProfileBindingMapType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTPortDiscoveryProfileBindingMapType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Put operation to " + UpdateInfraPortDiscoveryBindingServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task PatchInfraPortDiscoveryBinding(string InfraSegmentId, string InfraPortId, string PortDiscoveryProfileBindingMapId, NSXTPortDiscoveryProfileBindingMapType PortDiscoveryProfileBindingMap)
        {
            if (InfraSegmentId == null) { throw new System.ArgumentNullException("InfraSegmentId cannot be null"); }
            if (InfraPortId == null) { throw new System.ArgumentNullException("InfraPortId cannot be null"); }
            if (PortDiscoveryProfileBindingMapId == null) { throw new System.ArgumentNullException("PortDiscoveryProfileBindingMapId cannot be null"); }
            if (PortDiscoveryProfileBindingMap == null) { throw new System.ArgumentNullException("PortDiscoveryProfileBindingMap cannot be null"); }
            StringBuilder PatchInfraPortDiscoveryBindingServiceURL = new StringBuilder("/infra/segments/{infra-segment-id}/ports/{infra-port-id}/port-discovery-profile-binding-maps/{port-discovery-profile-binding-map-id}");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Patch
            };
            PatchInfraPortDiscoveryBindingServiceURL.Replace("{infra-segment-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(InfraSegmentId, System.Globalization.CultureInfo.InvariantCulture)));
            PatchInfraPortDiscoveryBindingServiceURL.Replace("{infra-port-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(InfraPortId, System.Globalization.CultureInfo.InvariantCulture)));
            PatchInfraPortDiscoveryBindingServiceURL.Replace("{port-discovery-profile-binding-map-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(PortDiscoveryProfileBindingMapId, System.Globalization.CultureInfo.InvariantCulture)));
            request.AddJsonBody(PortDiscoveryProfileBindingMap);
            request.Resource = PatchInfraPortDiscoveryBindingServiceURL.ToString();
            RestResponse response = await restClient.ExecuteTaskAsyncWithPolicy(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Patch operation to " + PatchInfraPortDiscoveryBindingServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task DeleteInfraPortDiscoveryBinding(string InfraSegmentId, string InfraPortId, string PortDiscoveryProfileBindingMapId)
        {
            if (InfraSegmentId == null) { throw new System.ArgumentNullException("InfraSegmentId cannot be null"); }
            if (InfraPortId == null) { throw new System.ArgumentNullException("InfraPortId cannot be null"); }
            if (PortDiscoveryProfileBindingMapId == null) { throw new System.ArgumentNullException("PortDiscoveryProfileBindingMapId cannot be null"); }
            StringBuilder DeleteInfraPortDiscoveryBindingServiceURL = new StringBuilder("/infra/segments/{infra-segment-id}/ports/{infra-port-id}/port-discovery-profile-binding-maps/{port-discovery-profile-binding-map-id}");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Delete
            };
            DeleteInfraPortDiscoveryBindingServiceURL.Replace("{infra-segment-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(InfraSegmentId, System.Globalization.CultureInfo.InvariantCulture)));
            DeleteInfraPortDiscoveryBindingServiceURL.Replace("{infra-port-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(InfraPortId, System.Globalization.CultureInfo.InvariantCulture)));
            DeleteInfraPortDiscoveryBindingServiceURL.Replace("{port-discovery-profile-binding-map-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(PortDiscoveryProfileBindingMapId, System.Globalization.CultureInfo.InvariantCulture)));
            request.Resource = DeleteInfraPortDiscoveryBindingServiceURL.ToString();
            RestResponse response = await restClient.ExecuteTaskAsyncWithPolicy(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Delete operation to " + DeleteInfraPortDiscoveryBindingServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTPortDiscoveryProfileBindingMapType> GetInfraPortDiscoveryBinding(string InfraSegmentId, string InfraPortId, string PortDiscoveryProfileBindingMapId)
        {
            if (InfraSegmentId == null) { throw new System.ArgumentNullException("InfraSegmentId cannot be null"); }
            if (InfraPortId == null) { throw new System.ArgumentNullException("InfraPortId cannot be null"); }
            if (PortDiscoveryProfileBindingMapId == null) { throw new System.ArgumentNullException("PortDiscoveryProfileBindingMapId cannot be null"); }
            StringBuilder GetInfraPortDiscoveryBindingServiceURL = new StringBuilder("/infra/segments/{infra-segment-id}/ports/{infra-port-id}/port-discovery-profile-binding-maps/{port-discovery-profile-binding-map-id}");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Get
            };
            GetInfraPortDiscoveryBindingServiceURL.Replace("{infra-segment-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(InfraSegmentId, System.Globalization.CultureInfo.InvariantCulture)));
            GetInfraPortDiscoveryBindingServiceURL.Replace("{infra-port-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(InfraPortId, System.Globalization.CultureInfo.InvariantCulture)));
            GetInfraPortDiscoveryBindingServiceURL.Replace("{port-discovery-profile-binding-map-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(PortDiscoveryProfileBindingMapId, System.Globalization.CultureInfo.InvariantCulture)));
            request.Resource = GetInfraPortDiscoveryBindingServiceURL.ToString();
            RestResponse<NSXTPortDiscoveryProfileBindingMapType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTPortDiscoveryProfileBindingMapType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Get operation to " + GetInfraPortDiscoveryBindingServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTPortDiscoveryProfileBindingMapListResultType> GlobalGlobalInfraListInfraPortDiscoveryBindings(string InfraSegmentId, string InfraPortId, string? Cursor = null, bool? IncludeMarkForDeleteObjects = null, string? IncludedFields = null, long? PageSize = null, bool? SortAscending = null, string? SortBy = null)
        {
            if (InfraSegmentId == null) { throw new System.ArgumentNullException("InfraSegmentId cannot be null"); }
            if (InfraPortId == null) { throw new System.ArgumentNullException("InfraPortId cannot be null"); }
            StringBuilder GlobalInfraListInfraPortDiscoveryBindingsServiceURL = new StringBuilder("/global-infra/segments/{infra-segment-id}/ports/{infra-port-id}/port-discovery-profile-binding-maps");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Get
            };
            GlobalInfraListInfraPortDiscoveryBindingsServiceURL.Replace("{infra-segment-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(InfraSegmentId, System.Globalization.CultureInfo.InvariantCulture)));
            GlobalInfraListInfraPortDiscoveryBindingsServiceURL.Replace("{infra-port-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(InfraPortId, System.Globalization.CultureInfo.InvariantCulture)));
            if (Cursor != null) { request.AddQueryParameter("cursor", Cursor.ToString()); }
            if (IncludeMarkForDeleteObjects != null) { request.AddQueryParameter("include_mark_for_delete_objects", IncludeMarkForDeleteObjects.ToString()); }
            if (IncludedFields != null) { request.AddQueryParameter("included_fields", IncludedFields.ToString()); }
            if (PageSize != null) { request.AddQueryParameter("page_size", PageSize.ToString()); }
            if (SortAscending != null) { request.AddQueryParameter("sort_ascending", SortAscending.ToString()); }
            if (SortBy != null) { request.AddQueryParameter("sort_by", SortBy.ToString()); }
            request.Resource = GlobalInfraListInfraPortDiscoveryBindingsServiceURL.ToString();
            RestResponse<NSXTPortDiscoveryProfileBindingMapListResultType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTPortDiscoveryProfileBindingMapListResultType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Get operation to " + GlobalInfraListInfraPortDiscoveryBindingsServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTPortDiscoveryProfileBindingMapListResultType> ListInfraPortDiscoveryBindings(string InfraSegmentId, string InfraPortId, string? Cursor = null, bool? IncludeMarkForDeleteObjects = null, string? IncludedFields = null, long? PageSize = null, bool? SortAscending = null, string? SortBy = null)
        {
            if (InfraSegmentId == null) { throw new System.ArgumentNullException("InfraSegmentId cannot be null"); }
            if (InfraPortId == null) { throw new System.ArgumentNullException("InfraPortId cannot be null"); }
            StringBuilder ListInfraPortDiscoveryBindingsServiceURL = new StringBuilder("/infra/segments/{infra-segment-id}/ports/{infra-port-id}/port-discovery-profile-binding-maps");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Get
            };
            ListInfraPortDiscoveryBindingsServiceURL.Replace("{infra-segment-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(InfraSegmentId, System.Globalization.CultureInfo.InvariantCulture)));
            ListInfraPortDiscoveryBindingsServiceURL.Replace("{infra-port-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(InfraPortId, System.Globalization.CultureInfo.InvariantCulture)));
            if (Cursor != null) { request.AddQueryParameter("cursor", Cursor.ToString()); }
            if (IncludeMarkForDeleteObjects != null) { request.AddQueryParameter("include_mark_for_delete_objects", IncludeMarkForDeleteObjects.ToString()); }
            if (IncludedFields != null) { request.AddQueryParameter("included_fields", IncludedFields.ToString()); }
            if (PageSize != null) { request.AddQueryParameter("page_size", PageSize.ToString()); }
            if (SortAscending != null) { request.AddQueryParameter("sort_ascending", SortAscending.ToString()); }
            if (SortBy != null) { request.AddQueryParameter("sort_by", SortBy.ToString()); }
            request.Resource = ListInfraPortDiscoveryBindingsServiceURL.ToString();
            RestResponse<NSXTPortDiscoveryProfileBindingMapListResultType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTPortDiscoveryProfileBindingMapListResultType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Get operation to " + ListInfraPortDiscoveryBindingsServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTPortDiscoveryProfileBindingMapType> GlobalGlobalInfraUpdateInfraPortDiscoveryBinding(string InfraSegmentId, string InfraPortId, string PortDiscoveryProfileBindingMapId, NSXTPortDiscoveryProfileBindingMapType PortDiscoveryProfileBindingMap)
        {
            if (InfraSegmentId == null) { throw new System.ArgumentNullException("InfraSegmentId cannot be null"); }
            if (InfraPortId == null) { throw new System.ArgumentNullException("InfraPortId cannot be null"); }
            if (PortDiscoveryProfileBindingMapId == null) { throw new System.ArgumentNullException("PortDiscoveryProfileBindingMapId cannot be null"); }
            if (PortDiscoveryProfileBindingMap == null) { throw new System.ArgumentNullException("PortDiscoveryProfileBindingMap cannot be null"); }
            StringBuilder GlobalInfraUpdateInfraPortDiscoveryBindingServiceURL = new StringBuilder("/global-infra/segments/{infra-segment-id}/ports/{infra-port-id}/port-discovery-profile-binding-maps/{port-discovery-profile-binding-map-id}");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Put
            };
            GlobalInfraUpdateInfraPortDiscoveryBindingServiceURL.Replace("{infra-segment-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(InfraSegmentId, System.Globalization.CultureInfo.InvariantCulture)));
            GlobalInfraUpdateInfraPortDiscoveryBindingServiceURL.Replace("{infra-port-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(InfraPortId, System.Globalization.CultureInfo.InvariantCulture)));
            GlobalInfraUpdateInfraPortDiscoveryBindingServiceURL.Replace("{port-discovery-profile-binding-map-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(PortDiscoveryProfileBindingMapId, System.Globalization.CultureInfo.InvariantCulture)));
            request.AddJsonBody(PortDiscoveryProfileBindingMap);
            request.Resource = GlobalInfraUpdateInfraPortDiscoveryBindingServiceURL.ToString();
            RestResponse<NSXTPortDiscoveryProfileBindingMapType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTPortDiscoveryProfileBindingMapType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Put operation to " + GlobalInfraUpdateInfraPortDiscoveryBindingServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task GlobalGlobalInfraPatchInfraPortDiscoveryBinding(string InfraSegmentId, string InfraPortId, string PortDiscoveryProfileBindingMapId, NSXTPortDiscoveryProfileBindingMapType PortDiscoveryProfileBindingMap)
        {
            if (InfraSegmentId == null) { throw new System.ArgumentNullException("InfraSegmentId cannot be null"); }
            if (InfraPortId == null) { throw new System.ArgumentNullException("InfraPortId cannot be null"); }
            if (PortDiscoveryProfileBindingMapId == null) { throw new System.ArgumentNullException("PortDiscoveryProfileBindingMapId cannot be null"); }
            if (PortDiscoveryProfileBindingMap == null) { throw new System.ArgumentNullException("PortDiscoveryProfileBindingMap cannot be null"); }
            StringBuilder GlobalInfraPatchInfraPortDiscoveryBindingServiceURL = new StringBuilder("/global-infra/segments/{infra-segment-id}/ports/{infra-port-id}/port-discovery-profile-binding-maps/{port-discovery-profile-binding-map-id}");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Patch
            };
            GlobalInfraPatchInfraPortDiscoveryBindingServiceURL.Replace("{infra-segment-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(InfraSegmentId, System.Globalization.CultureInfo.InvariantCulture)));
            GlobalInfraPatchInfraPortDiscoveryBindingServiceURL.Replace("{infra-port-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(InfraPortId, System.Globalization.CultureInfo.InvariantCulture)));
            GlobalInfraPatchInfraPortDiscoveryBindingServiceURL.Replace("{port-discovery-profile-binding-map-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(PortDiscoveryProfileBindingMapId, System.Globalization.CultureInfo.InvariantCulture)));
            request.AddJsonBody(PortDiscoveryProfileBindingMap);
            request.Resource = GlobalInfraPatchInfraPortDiscoveryBindingServiceURL.ToString();
            RestResponse response = await restClient.ExecuteTaskAsyncWithPolicy(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Patch operation to " + GlobalInfraPatchInfraPortDiscoveryBindingServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task GlobalGlobalInfraDeleteInfraPortDiscoveryBinding(string InfraSegmentId, string InfraPortId, string PortDiscoveryProfileBindingMapId)
        {
            if (InfraSegmentId == null) { throw new System.ArgumentNullException("InfraSegmentId cannot be null"); }
            if (InfraPortId == null) { throw new System.ArgumentNullException("InfraPortId cannot be null"); }
            if (PortDiscoveryProfileBindingMapId == null) { throw new System.ArgumentNullException("PortDiscoveryProfileBindingMapId cannot be null"); }
            StringBuilder GlobalInfraDeleteInfraPortDiscoveryBindingServiceURL = new StringBuilder("/global-infra/segments/{infra-segment-id}/ports/{infra-port-id}/port-discovery-profile-binding-maps/{port-discovery-profile-binding-map-id}");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Delete
            };
            GlobalInfraDeleteInfraPortDiscoveryBindingServiceURL.Replace("{infra-segment-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(InfraSegmentId, System.Globalization.CultureInfo.InvariantCulture)));
            GlobalInfraDeleteInfraPortDiscoveryBindingServiceURL.Replace("{infra-port-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(InfraPortId, System.Globalization.CultureInfo.InvariantCulture)));
            GlobalInfraDeleteInfraPortDiscoveryBindingServiceURL.Replace("{port-discovery-profile-binding-map-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(PortDiscoveryProfileBindingMapId, System.Globalization.CultureInfo.InvariantCulture)));
            request.Resource = GlobalInfraDeleteInfraPortDiscoveryBindingServiceURL.ToString();
            RestResponse response = await restClient.ExecuteTaskAsyncWithPolicy(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Delete operation to " + GlobalInfraDeleteInfraPortDiscoveryBindingServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTPortDiscoveryProfileBindingMapType> GlobalGlobalInfraGetInfraPortDiscoveryBinding(string InfraSegmentId, string InfraPortId, string PortDiscoveryProfileBindingMapId)
        {
            if (InfraSegmentId == null) { throw new System.ArgumentNullException("InfraSegmentId cannot be null"); }
            if (InfraPortId == null) { throw new System.ArgumentNullException("InfraPortId cannot be null"); }
            if (PortDiscoveryProfileBindingMapId == null) { throw new System.ArgumentNullException("PortDiscoveryProfileBindingMapId cannot be null"); }
            StringBuilder GlobalInfraGetInfraPortDiscoveryBindingServiceURL = new StringBuilder("/global-infra/segments/{infra-segment-id}/ports/{infra-port-id}/port-discovery-profile-binding-maps/{port-discovery-profile-binding-map-id}");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Get
            };
            GlobalInfraGetInfraPortDiscoveryBindingServiceURL.Replace("{infra-segment-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(InfraSegmentId, System.Globalization.CultureInfo.InvariantCulture)));
            GlobalInfraGetInfraPortDiscoveryBindingServiceURL.Replace("{infra-port-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(InfraPortId, System.Globalization.CultureInfo.InvariantCulture)));
            GlobalInfraGetInfraPortDiscoveryBindingServiceURL.Replace("{port-discovery-profile-binding-map-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(PortDiscoveryProfileBindingMapId, System.Globalization.CultureInfo.InvariantCulture)));
            request.Resource = GlobalInfraGetInfraPortDiscoveryBindingServiceURL.ToString();
            RestResponse<NSXTPortDiscoveryProfileBindingMapType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTPortDiscoveryProfileBindingMapType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Get operation to " + GlobalInfraGetInfraPortDiscoveryBindingServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTGroupDiscoveryProfileBindingMapListResultType> GlobalGlobalInfraListGroupDiscoveryProfileBindings(string DomainId, string GroupId, string? Cursor = null, bool? IncludeMarkForDeleteObjects = null, string? IncludedFields = null, long? PageSize = null, bool? SortAscending = null, string? SortBy = null)
        {
            if (DomainId == null) { throw new System.ArgumentNullException("DomainId cannot be null"); }
            if (GroupId == null) { throw new System.ArgumentNullException("GroupId cannot be null"); }
            StringBuilder GlobalInfraListGroupDiscoveryProfileBindingsServiceURL = new StringBuilder("/global-infra/domains/{domain-id}/groups/{group-id}/discovery-profile-binding-maps");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Get
            };
            GlobalInfraListGroupDiscoveryProfileBindingsServiceURL.Replace("{domain-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(DomainId, System.Globalization.CultureInfo.InvariantCulture)));
            GlobalInfraListGroupDiscoveryProfileBindingsServiceURL.Replace("{group-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(GroupId, System.Globalization.CultureInfo.InvariantCulture)));
            if (Cursor != null) { request.AddQueryParameter("cursor", Cursor.ToString()); }
            if (IncludeMarkForDeleteObjects != null) { request.AddQueryParameter("include_mark_for_delete_objects", IncludeMarkForDeleteObjects.ToString()); }
            if (IncludedFields != null) { request.AddQueryParameter("included_fields", IncludedFields.ToString()); }
            if (PageSize != null) { request.AddQueryParameter("page_size", PageSize.ToString()); }
            if (SortAscending != null) { request.AddQueryParameter("sort_ascending", SortAscending.ToString()); }
            if (SortBy != null) { request.AddQueryParameter("sort_by", SortBy.ToString()); }
            request.Resource = GlobalInfraListGroupDiscoveryProfileBindingsServiceURL.ToString();
            RestResponse<NSXTGroupDiscoveryProfileBindingMapListResultType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTGroupDiscoveryProfileBindingMapListResultType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Get operation to " + GlobalInfraListGroupDiscoveryProfileBindingsServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTSegmentDiscoveryProfileBindingMapListResultType> GlobalGlobalInfraListSegmentDiscoveryBindings(string Tier1Id, string SegmentId, string? Cursor = null, bool? IncludeMarkForDeleteObjects = null, string? IncludedFields = null, long? PageSize = null, bool? SortAscending = null, string? SortBy = null)
        {
            if (Tier1Id == null) { throw new System.ArgumentNullException("Tier1Id cannot be null"); }
            if (SegmentId == null) { throw new System.ArgumentNullException("SegmentId cannot be null"); }
            StringBuilder GlobalInfraListSegmentDiscoveryBindingsServiceURL = new StringBuilder("/global-infra/tier-1s/{tier-1-id}/segments/{segment-id}/segment-discovery-profile-binding-maps");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Get
            };
            GlobalInfraListSegmentDiscoveryBindingsServiceURL.Replace("{tier-1-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(Tier1Id, System.Globalization.CultureInfo.InvariantCulture)));
            GlobalInfraListSegmentDiscoveryBindingsServiceURL.Replace("{segment-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(SegmentId, System.Globalization.CultureInfo.InvariantCulture)));
            if (Cursor != null) { request.AddQueryParameter("cursor", Cursor.ToString()); }
            if (IncludeMarkForDeleteObjects != null) { request.AddQueryParameter("include_mark_for_delete_objects", IncludeMarkForDeleteObjects.ToString()); }
            if (IncludedFields != null) { request.AddQueryParameter("included_fields", IncludedFields.ToString()); }
            if (PageSize != null) { request.AddQueryParameter("page_size", PageSize.ToString()); }
            if (SortAscending != null) { request.AddQueryParameter("sort_ascending", SortAscending.ToString()); }
            if (SortBy != null) { request.AddQueryParameter("sort_by", SortBy.ToString()); }
            request.Resource = GlobalInfraListSegmentDiscoveryBindingsServiceURL.ToString();
            RestResponse<NSXTSegmentDiscoveryProfileBindingMapListResultType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTSegmentDiscoveryProfileBindingMapListResultType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Get operation to " + GlobalInfraListSegmentDiscoveryBindingsServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTGroupDiscoveryProfileBindingMapListResultType> ListGroupDiscoveryProfileBindings(string DomainId, string GroupId, string? Cursor = null, bool? IncludeMarkForDeleteObjects = null, string? IncludedFields = null, long? PageSize = null, bool? SortAscending = null, string? SortBy = null)
        {
            if (DomainId == null) { throw new System.ArgumentNullException("DomainId cannot be null"); }
            if (GroupId == null) { throw new System.ArgumentNullException("GroupId cannot be null"); }
            StringBuilder ListGroupDiscoveryProfileBindingsServiceURL = new StringBuilder("/infra/domains/{domain-id}/groups/{group-id}/discovery-profile-binding-maps");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Get
            };
            ListGroupDiscoveryProfileBindingsServiceURL.Replace("{domain-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(DomainId, System.Globalization.CultureInfo.InvariantCulture)));
            ListGroupDiscoveryProfileBindingsServiceURL.Replace("{group-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(GroupId, System.Globalization.CultureInfo.InvariantCulture)));
            if (Cursor != null) { request.AddQueryParameter("cursor", Cursor.ToString()); }
            if (IncludeMarkForDeleteObjects != null) { request.AddQueryParameter("include_mark_for_delete_objects", IncludeMarkForDeleteObjects.ToString()); }
            if (IncludedFields != null) { request.AddQueryParameter("included_fields", IncludedFields.ToString()); }
            if (PageSize != null) { request.AddQueryParameter("page_size", PageSize.ToString()); }
            if (SortAscending != null) { request.AddQueryParameter("sort_ascending", SortAscending.ToString()); }
            if (SortBy != null) { request.AddQueryParameter("sort_by", SortBy.ToString()); }
            request.Resource = ListGroupDiscoveryProfileBindingsServiceURL.ToString();
            RestResponse<NSXTGroupDiscoveryProfileBindingMapListResultType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTGroupDiscoveryProfileBindingMapListResultType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Get operation to " + ListGroupDiscoveryProfileBindingsServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTSegmentDiscoveryProfileBindingMapType> GlobalGlobalInfraGetInfraSegmentDiscoveryBinding(string InfraSegmentId, string SegmentDiscoveryProfileBindingMapId)
        {
            if (InfraSegmentId == null) { throw new System.ArgumentNullException("InfraSegmentId cannot be null"); }
            if (SegmentDiscoveryProfileBindingMapId == null) { throw new System.ArgumentNullException("SegmentDiscoveryProfileBindingMapId cannot be null"); }
            StringBuilder GlobalInfraGetInfraSegmentDiscoveryBindingServiceURL = new StringBuilder("/global-infra/segments/{infra-segment-id}/segment-discovery-profile-binding-maps/{segment-discovery-profile-binding-map-id}");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Get
            };
            GlobalInfraGetInfraSegmentDiscoveryBindingServiceURL.Replace("{infra-segment-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(InfraSegmentId, System.Globalization.CultureInfo.InvariantCulture)));
            GlobalInfraGetInfraSegmentDiscoveryBindingServiceURL.Replace("{segment-discovery-profile-binding-map-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(SegmentDiscoveryProfileBindingMapId, System.Globalization.CultureInfo.InvariantCulture)));
            request.Resource = GlobalInfraGetInfraSegmentDiscoveryBindingServiceURL.ToString();
            RestResponse<NSXTSegmentDiscoveryProfileBindingMapType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTSegmentDiscoveryProfileBindingMapType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Get operation to " + GlobalInfraGetInfraSegmentDiscoveryBindingServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTPortDiscoveryProfileBindingMapListResultType> ListPortDiscoveryBindings(string Tier1Id, string SegmentId, string PortId, string? Cursor = null, bool? IncludeMarkForDeleteObjects = null, string? IncludedFields = null, long? PageSize = null, bool? SortAscending = null, string? SortBy = null)
        {
            if (Tier1Id == null) { throw new System.ArgumentNullException("Tier1Id cannot be null"); }
            if (SegmentId == null) { throw new System.ArgumentNullException("SegmentId cannot be null"); }
            if (PortId == null) { throw new System.ArgumentNullException("PortId cannot be null"); }
            StringBuilder ListPortDiscoveryBindingsServiceURL = new StringBuilder("/infra/tier-1s/{tier-1-id}/segments/{segment-id}/ports/{port-id}/port-discovery-profile-binding-maps");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Get
            };
            ListPortDiscoveryBindingsServiceURL.Replace("{tier-1-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(Tier1Id, System.Globalization.CultureInfo.InvariantCulture)));
            ListPortDiscoveryBindingsServiceURL.Replace("{segment-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(SegmentId, System.Globalization.CultureInfo.InvariantCulture)));
            ListPortDiscoveryBindingsServiceURL.Replace("{port-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(PortId, System.Globalization.CultureInfo.InvariantCulture)));
            if (Cursor != null) { request.AddQueryParameter("cursor", Cursor.ToString()); }
            if (IncludeMarkForDeleteObjects != null) { request.AddQueryParameter("include_mark_for_delete_objects", IncludeMarkForDeleteObjects.ToString()); }
            if (IncludedFields != null) { request.AddQueryParameter("included_fields", IncludedFields.ToString()); }
            if (PageSize != null) { request.AddQueryParameter("page_size", PageSize.ToString()); }
            if (SortAscending != null) { request.AddQueryParameter("sort_ascending", SortAscending.ToString()); }
            if (SortBy != null) { request.AddQueryParameter("sort_by", SortBy.ToString()); }
            request.Resource = ListPortDiscoveryBindingsServiceURL.ToString();
            RestResponse<NSXTPortDiscoveryProfileBindingMapListResultType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTPortDiscoveryProfileBindingMapListResultType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Get operation to " + ListPortDiscoveryBindingsServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTGroupDiscoveryProfileBindingMapType> GlobalGlobalInfraGetGroupDiscoveryProfileBinding(string DomainId, string GroupId, string DiscoveryProfileBindingMapId)
        {
            if (DomainId == null) { throw new System.ArgumentNullException("DomainId cannot be null"); }
            if (GroupId == null) { throw new System.ArgumentNullException("GroupId cannot be null"); }
            if (DiscoveryProfileBindingMapId == null) { throw new System.ArgumentNullException("DiscoveryProfileBindingMapId cannot be null"); }
            StringBuilder GlobalInfraGetGroupDiscoveryProfileBindingServiceURL = new StringBuilder("/global-infra/domains/{domain-id}/groups/{group-id}/discovery-profile-binding-maps/{discovery-profile-binding-map-id}");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Get
            };
            GlobalInfraGetGroupDiscoveryProfileBindingServiceURL.Replace("{domain-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(DomainId, System.Globalization.CultureInfo.InvariantCulture)));
            GlobalInfraGetGroupDiscoveryProfileBindingServiceURL.Replace("{group-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(GroupId, System.Globalization.CultureInfo.InvariantCulture)));
            GlobalInfraGetGroupDiscoveryProfileBindingServiceURL.Replace("{discovery-profile-binding-map-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(DiscoveryProfileBindingMapId, System.Globalization.CultureInfo.InvariantCulture)));
            request.Resource = GlobalInfraGetGroupDiscoveryProfileBindingServiceURL.ToString();
            RestResponse<NSXTGroupDiscoveryProfileBindingMapType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTGroupDiscoveryProfileBindingMapType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Get operation to " + GlobalInfraGetGroupDiscoveryProfileBindingServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTPortDiscoveryProfileBindingMapType> GlobalGlobalInfraUpdatePortDiscoveryBinding(string Tier1Id, string SegmentId, string PortId, string PortDiscoveryProfileBindingMapId, NSXTPortDiscoveryProfileBindingMapType PortDiscoveryProfileBindingMap)
        {
            if (Tier1Id == null) { throw new System.ArgumentNullException("Tier1Id cannot be null"); }
            if (SegmentId == null) { throw new System.ArgumentNullException("SegmentId cannot be null"); }
            if (PortId == null) { throw new System.ArgumentNullException("PortId cannot be null"); }
            if (PortDiscoveryProfileBindingMapId == null) { throw new System.ArgumentNullException("PortDiscoveryProfileBindingMapId cannot be null"); }
            if (PortDiscoveryProfileBindingMap == null) { throw new System.ArgumentNullException("PortDiscoveryProfileBindingMap cannot be null"); }
            StringBuilder GlobalInfraUpdatePortDiscoveryBindingServiceURL = new StringBuilder("/global-infra/tier-1s/{tier-1-id}/segments/{segment-id}/ports/{port-id}/port-discovery-profile-binding-maps/{port-discovery-profile-binding-map-id}");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Put
            };
            GlobalInfraUpdatePortDiscoveryBindingServiceURL.Replace("{tier-1-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(Tier1Id, System.Globalization.CultureInfo.InvariantCulture)));
            GlobalInfraUpdatePortDiscoveryBindingServiceURL.Replace("{segment-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(SegmentId, System.Globalization.CultureInfo.InvariantCulture)));
            GlobalInfraUpdatePortDiscoveryBindingServiceURL.Replace("{port-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(PortId, System.Globalization.CultureInfo.InvariantCulture)));
            GlobalInfraUpdatePortDiscoveryBindingServiceURL.Replace("{port-discovery-profile-binding-map-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(PortDiscoveryProfileBindingMapId, System.Globalization.CultureInfo.InvariantCulture)));
            request.AddJsonBody(PortDiscoveryProfileBindingMap);
            request.Resource = GlobalInfraUpdatePortDiscoveryBindingServiceURL.ToString();
            RestResponse<NSXTPortDiscoveryProfileBindingMapType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTPortDiscoveryProfileBindingMapType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Put operation to " + GlobalInfraUpdatePortDiscoveryBindingServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTPortDiscoveryProfileBindingMapType> GlobalGlobalInfraGetPortDiscoveryBinding(string Tier1Id, string SegmentId, string PortId, string PortDiscoveryProfileBindingMapId)
        {
            if (Tier1Id == null) { throw new System.ArgumentNullException("Tier1Id cannot be null"); }
            if (SegmentId == null) { throw new System.ArgumentNullException("SegmentId cannot be null"); }
            if (PortId == null) { throw new System.ArgumentNullException("PortId cannot be null"); }
            if (PortDiscoveryProfileBindingMapId == null) { throw new System.ArgumentNullException("PortDiscoveryProfileBindingMapId cannot be null"); }
            StringBuilder GlobalInfraGetPortDiscoveryBindingServiceURL = new StringBuilder("/global-infra/tier-1s/{tier-1-id}/segments/{segment-id}/ports/{port-id}/port-discovery-profile-binding-maps/{port-discovery-profile-binding-map-id}");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Get
            };
            GlobalInfraGetPortDiscoveryBindingServiceURL.Replace("{tier-1-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(Tier1Id, System.Globalization.CultureInfo.InvariantCulture)));
            GlobalInfraGetPortDiscoveryBindingServiceURL.Replace("{segment-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(SegmentId, System.Globalization.CultureInfo.InvariantCulture)));
            GlobalInfraGetPortDiscoveryBindingServiceURL.Replace("{port-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(PortId, System.Globalization.CultureInfo.InvariantCulture)));
            GlobalInfraGetPortDiscoveryBindingServiceURL.Replace("{port-discovery-profile-binding-map-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(PortDiscoveryProfileBindingMapId, System.Globalization.CultureInfo.InvariantCulture)));
            request.Resource = GlobalInfraGetPortDiscoveryBindingServiceURL.ToString();
            RestResponse<NSXTPortDiscoveryProfileBindingMapType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTPortDiscoveryProfileBindingMapType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Get operation to " + GlobalInfraGetPortDiscoveryBindingServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task GlobalGlobalInfraPatchPortDiscoveryBinding(string Tier1Id, string SegmentId, string PortId, string PortDiscoveryProfileBindingMapId, NSXTPortDiscoveryProfileBindingMapType PortDiscoveryProfileBindingMap)
        {
            if (Tier1Id == null) { throw new System.ArgumentNullException("Tier1Id cannot be null"); }
            if (SegmentId == null) { throw new System.ArgumentNullException("SegmentId cannot be null"); }
            if (PortId == null) { throw new System.ArgumentNullException("PortId cannot be null"); }
            if (PortDiscoveryProfileBindingMapId == null) { throw new System.ArgumentNullException("PortDiscoveryProfileBindingMapId cannot be null"); }
            if (PortDiscoveryProfileBindingMap == null) { throw new System.ArgumentNullException("PortDiscoveryProfileBindingMap cannot be null"); }
            StringBuilder GlobalInfraPatchPortDiscoveryBindingServiceURL = new StringBuilder("/global-infra/tier-1s/{tier-1-id}/segments/{segment-id}/ports/{port-id}/port-discovery-profile-binding-maps/{port-discovery-profile-binding-map-id}");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Patch
            };
            GlobalInfraPatchPortDiscoveryBindingServiceURL.Replace("{tier-1-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(Tier1Id, System.Globalization.CultureInfo.InvariantCulture)));
            GlobalInfraPatchPortDiscoveryBindingServiceURL.Replace("{segment-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(SegmentId, System.Globalization.CultureInfo.InvariantCulture)));
            GlobalInfraPatchPortDiscoveryBindingServiceURL.Replace("{port-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(PortId, System.Globalization.CultureInfo.InvariantCulture)));
            GlobalInfraPatchPortDiscoveryBindingServiceURL.Replace("{port-discovery-profile-binding-map-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(PortDiscoveryProfileBindingMapId, System.Globalization.CultureInfo.InvariantCulture)));
            request.AddJsonBody(PortDiscoveryProfileBindingMap);
            request.Resource = GlobalInfraPatchPortDiscoveryBindingServiceURL.ToString();
            RestResponse response = await restClient.ExecuteTaskAsyncWithPolicy(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Patch operation to " + GlobalInfraPatchPortDiscoveryBindingServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task GlobalGlobalInfraDeletePortDiscoveryBinding(string Tier1Id, string SegmentId, string PortId, string PortDiscoveryProfileBindingMapId)
        {
            if (Tier1Id == null) { throw new System.ArgumentNullException("Tier1Id cannot be null"); }
            if (SegmentId == null) { throw new System.ArgumentNullException("SegmentId cannot be null"); }
            if (PortId == null) { throw new System.ArgumentNullException("PortId cannot be null"); }
            if (PortDiscoveryProfileBindingMapId == null) { throw new System.ArgumentNullException("PortDiscoveryProfileBindingMapId cannot be null"); }
            StringBuilder GlobalInfraDeletePortDiscoveryBindingServiceURL = new StringBuilder("/global-infra/tier-1s/{tier-1-id}/segments/{segment-id}/ports/{port-id}/port-discovery-profile-binding-maps/{port-discovery-profile-binding-map-id}");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Delete
            };
            GlobalInfraDeletePortDiscoveryBindingServiceURL.Replace("{tier-1-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(Tier1Id, System.Globalization.CultureInfo.InvariantCulture)));
            GlobalInfraDeletePortDiscoveryBindingServiceURL.Replace("{segment-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(SegmentId, System.Globalization.CultureInfo.InvariantCulture)));
            GlobalInfraDeletePortDiscoveryBindingServiceURL.Replace("{port-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(PortId, System.Globalization.CultureInfo.InvariantCulture)));
            GlobalInfraDeletePortDiscoveryBindingServiceURL.Replace("{port-discovery-profile-binding-map-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(PortDiscoveryProfileBindingMapId, System.Globalization.CultureInfo.InvariantCulture)));
            request.Resource = GlobalInfraDeletePortDiscoveryBindingServiceURL.ToString();
            RestResponse response = await restClient.ExecuteTaskAsyncWithPolicy(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Delete operation to " + GlobalInfraDeletePortDiscoveryBindingServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTSegmentDiscoveryProfileBindingMapListResultType> GlobalGlobalInfraListInfraSegmentDiscoveryBindings(string InfraSegmentId, string? Cursor = null, bool? IncludeMarkForDeleteObjects = null, string? IncludedFields = null, long? PageSize = null, bool? SortAscending = null, string? SortBy = null)
        {
            if (InfraSegmentId == null) { throw new System.ArgumentNullException("InfraSegmentId cannot be null"); }
            StringBuilder GlobalInfraListInfraSegmentDiscoveryBindingsServiceURL = new StringBuilder("/global-infra/segments/{infra-segment-id}/segment-discovery-profile-binding-maps");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Get
            };
            GlobalInfraListInfraSegmentDiscoveryBindingsServiceURL.Replace("{infra-segment-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(InfraSegmentId, System.Globalization.CultureInfo.InvariantCulture)));
            if (Cursor != null) { request.AddQueryParameter("cursor", Cursor.ToString()); }
            if (IncludeMarkForDeleteObjects != null) { request.AddQueryParameter("include_mark_for_delete_objects", IncludeMarkForDeleteObjects.ToString()); }
            if (IncludedFields != null) { request.AddQueryParameter("included_fields", IncludedFields.ToString()); }
            if (PageSize != null) { request.AddQueryParameter("page_size", PageSize.ToString()); }
            if (SortAscending != null) { request.AddQueryParameter("sort_ascending", SortAscending.ToString()); }
            if (SortBy != null) { request.AddQueryParameter("sort_by", SortBy.ToString()); }
            request.Resource = GlobalInfraListInfraSegmentDiscoveryBindingsServiceURL.ToString();
            RestResponse<NSXTSegmentDiscoveryProfileBindingMapListResultType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTSegmentDiscoveryProfileBindingMapListResultType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Get operation to " + GlobalInfraListInfraSegmentDiscoveryBindingsServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTPortDiscoveryProfileBindingMapType> UpdatePortDiscoveryBinding(string Tier1Id, string SegmentId, string PortId, string PortDiscoveryProfileBindingMapId, NSXTPortDiscoveryProfileBindingMapType PortDiscoveryProfileBindingMap)
        {
            if (Tier1Id == null) { throw new System.ArgumentNullException("Tier1Id cannot be null"); }
            if (SegmentId == null) { throw new System.ArgumentNullException("SegmentId cannot be null"); }
            if (PortId == null) { throw new System.ArgumentNullException("PortId cannot be null"); }
            if (PortDiscoveryProfileBindingMapId == null) { throw new System.ArgumentNullException("PortDiscoveryProfileBindingMapId cannot be null"); }
            if (PortDiscoveryProfileBindingMap == null) { throw new System.ArgumentNullException("PortDiscoveryProfileBindingMap cannot be null"); }
            StringBuilder UpdatePortDiscoveryBindingServiceURL = new StringBuilder("/infra/tier-1s/{tier-1-id}/segments/{segment-id}/ports/{port-id}/port-discovery-profile-binding-maps/{port-discovery-profile-binding-map-id}");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Put
            };
            UpdatePortDiscoveryBindingServiceURL.Replace("{tier-1-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(Tier1Id, System.Globalization.CultureInfo.InvariantCulture)));
            UpdatePortDiscoveryBindingServiceURL.Replace("{segment-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(SegmentId, System.Globalization.CultureInfo.InvariantCulture)));
            UpdatePortDiscoveryBindingServiceURL.Replace("{port-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(PortId, System.Globalization.CultureInfo.InvariantCulture)));
            UpdatePortDiscoveryBindingServiceURL.Replace("{port-discovery-profile-binding-map-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(PortDiscoveryProfileBindingMapId, System.Globalization.CultureInfo.InvariantCulture)));
            request.AddJsonBody(PortDiscoveryProfileBindingMap);
            request.Resource = UpdatePortDiscoveryBindingServiceURL.ToString();
            RestResponse<NSXTPortDiscoveryProfileBindingMapType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTPortDiscoveryProfileBindingMapType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Put operation to " + UpdatePortDiscoveryBindingServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTPortDiscoveryProfileBindingMapType> GetPortDiscoveryBinding(string Tier1Id, string SegmentId, string PortId, string PortDiscoveryProfileBindingMapId)
        {
            if (Tier1Id == null) { throw new System.ArgumentNullException("Tier1Id cannot be null"); }
            if (SegmentId == null) { throw new System.ArgumentNullException("SegmentId cannot be null"); }
            if (PortId == null) { throw new System.ArgumentNullException("PortId cannot be null"); }
            if (PortDiscoveryProfileBindingMapId == null) { throw new System.ArgumentNullException("PortDiscoveryProfileBindingMapId cannot be null"); }
            StringBuilder GetPortDiscoveryBindingServiceURL = new StringBuilder("/infra/tier-1s/{tier-1-id}/segments/{segment-id}/ports/{port-id}/port-discovery-profile-binding-maps/{port-discovery-profile-binding-map-id}");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Get
            };
            GetPortDiscoveryBindingServiceURL.Replace("{tier-1-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(Tier1Id, System.Globalization.CultureInfo.InvariantCulture)));
            GetPortDiscoveryBindingServiceURL.Replace("{segment-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(SegmentId, System.Globalization.CultureInfo.InvariantCulture)));
            GetPortDiscoveryBindingServiceURL.Replace("{port-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(PortId, System.Globalization.CultureInfo.InvariantCulture)));
            GetPortDiscoveryBindingServiceURL.Replace("{port-discovery-profile-binding-map-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(PortDiscoveryProfileBindingMapId, System.Globalization.CultureInfo.InvariantCulture)));
            request.Resource = GetPortDiscoveryBindingServiceURL.ToString();
            RestResponse<NSXTPortDiscoveryProfileBindingMapType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTPortDiscoveryProfileBindingMapType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Get operation to " + GetPortDiscoveryBindingServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task PatchPortDiscoveryBinding(string Tier1Id, string SegmentId, string PortId, string PortDiscoveryProfileBindingMapId, NSXTPortDiscoveryProfileBindingMapType PortDiscoveryProfileBindingMap)
        {
            if (Tier1Id == null) { throw new System.ArgumentNullException("Tier1Id cannot be null"); }
            if (SegmentId == null) { throw new System.ArgumentNullException("SegmentId cannot be null"); }
            if (PortId == null) { throw new System.ArgumentNullException("PortId cannot be null"); }
            if (PortDiscoveryProfileBindingMapId == null) { throw new System.ArgumentNullException("PortDiscoveryProfileBindingMapId cannot be null"); }
            if (PortDiscoveryProfileBindingMap == null) { throw new System.ArgumentNullException("PortDiscoveryProfileBindingMap cannot be null"); }
            StringBuilder PatchPortDiscoveryBindingServiceURL = new StringBuilder("/infra/tier-1s/{tier-1-id}/segments/{segment-id}/ports/{port-id}/port-discovery-profile-binding-maps/{port-discovery-profile-binding-map-id}");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Patch
            };
            PatchPortDiscoveryBindingServiceURL.Replace("{tier-1-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(Tier1Id, System.Globalization.CultureInfo.InvariantCulture)));
            PatchPortDiscoveryBindingServiceURL.Replace("{segment-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(SegmentId, System.Globalization.CultureInfo.InvariantCulture)));
            PatchPortDiscoveryBindingServiceURL.Replace("{port-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(PortId, System.Globalization.CultureInfo.InvariantCulture)));
            PatchPortDiscoveryBindingServiceURL.Replace("{port-discovery-profile-binding-map-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(PortDiscoveryProfileBindingMapId, System.Globalization.CultureInfo.InvariantCulture)));
            request.AddJsonBody(PortDiscoveryProfileBindingMap);
            request.Resource = PatchPortDiscoveryBindingServiceURL.ToString();
            RestResponse response = await restClient.ExecuteTaskAsyncWithPolicy(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Patch operation to " + PatchPortDiscoveryBindingServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task DeletePortDiscoveryBinding(string Tier1Id, string SegmentId, string PortId, string PortDiscoveryProfileBindingMapId)
        {
            if (Tier1Id == null) { throw new System.ArgumentNullException("Tier1Id cannot be null"); }
            if (SegmentId == null) { throw new System.ArgumentNullException("SegmentId cannot be null"); }
            if (PortId == null) { throw new System.ArgumentNullException("PortId cannot be null"); }
            if (PortDiscoveryProfileBindingMapId == null) { throw new System.ArgumentNullException("PortDiscoveryProfileBindingMapId cannot be null"); }
            StringBuilder DeletePortDiscoveryBindingServiceURL = new StringBuilder("/infra/tier-1s/{tier-1-id}/segments/{segment-id}/ports/{port-id}/port-discovery-profile-binding-maps/{port-discovery-profile-binding-map-id}");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Delete
            };
            DeletePortDiscoveryBindingServiceURL.Replace("{tier-1-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(Tier1Id, System.Globalization.CultureInfo.InvariantCulture)));
            DeletePortDiscoveryBindingServiceURL.Replace("{segment-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(SegmentId, System.Globalization.CultureInfo.InvariantCulture)));
            DeletePortDiscoveryBindingServiceURL.Replace("{port-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(PortId, System.Globalization.CultureInfo.InvariantCulture)));
            DeletePortDiscoveryBindingServiceURL.Replace("{port-discovery-profile-binding-map-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(PortDiscoveryProfileBindingMapId, System.Globalization.CultureInfo.InvariantCulture)));
            request.Resource = DeletePortDiscoveryBindingServiceURL.ToString();
            RestResponse response = await restClient.ExecuteTaskAsyncWithPolicy(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Delete operation to " + DeletePortDiscoveryBindingServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTSegmentDiscoveryProfileBindingMapType> UpdateSegmentDiscoveryBinding(string Tier1Id, string SegmentId, string SegmentDiscoveryProfileBindingMapId, NSXTSegmentDiscoveryProfileBindingMapType SegmentDiscoveryProfileBindingMap)
        {
            if (Tier1Id == null) { throw new System.ArgumentNullException("Tier1Id cannot be null"); }
            if (SegmentId == null) { throw new System.ArgumentNullException("SegmentId cannot be null"); }
            if (SegmentDiscoveryProfileBindingMapId == null) { throw new System.ArgumentNullException("SegmentDiscoveryProfileBindingMapId cannot be null"); }
            if (SegmentDiscoveryProfileBindingMap == null) { throw new System.ArgumentNullException("SegmentDiscoveryProfileBindingMap cannot be null"); }
            StringBuilder UpdateSegmentDiscoveryBindingServiceURL = new StringBuilder("/infra/tier-1s/{tier-1-id}/segments/{segment-id}/segment-discovery-profile-binding-maps/{segment-discovery-profile-binding-map-id}");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Put
            };
            UpdateSegmentDiscoveryBindingServiceURL.Replace("{tier-1-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(Tier1Id, System.Globalization.CultureInfo.InvariantCulture)));
            UpdateSegmentDiscoveryBindingServiceURL.Replace("{segment-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(SegmentId, System.Globalization.CultureInfo.InvariantCulture)));
            UpdateSegmentDiscoveryBindingServiceURL.Replace("{segment-discovery-profile-binding-map-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(SegmentDiscoveryProfileBindingMapId, System.Globalization.CultureInfo.InvariantCulture)));
            request.AddJsonBody(SegmentDiscoveryProfileBindingMap);
            request.Resource = UpdateSegmentDiscoveryBindingServiceURL.ToString();
            RestResponse<NSXTSegmentDiscoveryProfileBindingMapType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTSegmentDiscoveryProfileBindingMapType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Put operation to " + UpdateSegmentDiscoveryBindingServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTSegmentDiscoveryProfileBindingMapType> GetSegmentDiscoveryBinding(string Tier1Id, string SegmentId, string SegmentDiscoveryProfileBindingMapId)
        {
            if (Tier1Id == null) { throw new System.ArgumentNullException("Tier1Id cannot be null"); }
            if (SegmentId == null) { throw new System.ArgumentNullException("SegmentId cannot be null"); }
            if (SegmentDiscoveryProfileBindingMapId == null) { throw new System.ArgumentNullException("SegmentDiscoveryProfileBindingMapId cannot be null"); }
            StringBuilder GetSegmentDiscoveryBindingServiceURL = new StringBuilder("/infra/tier-1s/{tier-1-id}/segments/{segment-id}/segment-discovery-profile-binding-maps/{segment-discovery-profile-binding-map-id}");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Get
            };
            GetSegmentDiscoveryBindingServiceURL.Replace("{tier-1-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(Tier1Id, System.Globalization.CultureInfo.InvariantCulture)));
            GetSegmentDiscoveryBindingServiceURL.Replace("{segment-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(SegmentId, System.Globalization.CultureInfo.InvariantCulture)));
            GetSegmentDiscoveryBindingServiceURL.Replace("{segment-discovery-profile-binding-map-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(SegmentDiscoveryProfileBindingMapId, System.Globalization.CultureInfo.InvariantCulture)));
            request.Resource = GetSegmentDiscoveryBindingServiceURL.ToString();
            RestResponse<NSXTSegmentDiscoveryProfileBindingMapType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTSegmentDiscoveryProfileBindingMapType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Get operation to " + GetSegmentDiscoveryBindingServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task DeleteSegmentDiscoveryBinding(string Tier1Id, string SegmentId, string SegmentDiscoveryProfileBindingMapId)
        {
            if (Tier1Id == null) { throw new System.ArgumentNullException("Tier1Id cannot be null"); }
            if (SegmentId == null) { throw new System.ArgumentNullException("SegmentId cannot be null"); }
            if (SegmentDiscoveryProfileBindingMapId == null) { throw new System.ArgumentNullException("SegmentDiscoveryProfileBindingMapId cannot be null"); }
            StringBuilder DeleteSegmentDiscoveryBindingServiceURL = new StringBuilder("/infra/tier-1s/{tier-1-id}/segments/{segment-id}/segment-discovery-profile-binding-maps/{segment-discovery-profile-binding-map-id}");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Delete
            };
            DeleteSegmentDiscoveryBindingServiceURL.Replace("{tier-1-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(Tier1Id, System.Globalization.CultureInfo.InvariantCulture)));
            DeleteSegmentDiscoveryBindingServiceURL.Replace("{segment-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(SegmentId, System.Globalization.CultureInfo.InvariantCulture)));
            DeleteSegmentDiscoveryBindingServiceURL.Replace("{segment-discovery-profile-binding-map-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(SegmentDiscoveryProfileBindingMapId, System.Globalization.CultureInfo.InvariantCulture)));
            request.Resource = DeleteSegmentDiscoveryBindingServiceURL.ToString();
            RestResponse response = await restClient.ExecuteTaskAsyncWithPolicy(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Delete operation to " + DeleteSegmentDiscoveryBindingServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task PatchSegmentDiscoveryBinding(string Tier1Id, string SegmentId, string SegmentDiscoveryProfileBindingMapId, NSXTSegmentDiscoveryProfileBindingMapType SegmentDiscoveryProfileBindingMap)
        {
            if (Tier1Id == null) { throw new System.ArgumentNullException("Tier1Id cannot be null"); }
            if (SegmentId == null) { throw new System.ArgumentNullException("SegmentId cannot be null"); }
            if (SegmentDiscoveryProfileBindingMapId == null) { throw new System.ArgumentNullException("SegmentDiscoveryProfileBindingMapId cannot be null"); }
            if (SegmentDiscoveryProfileBindingMap == null) { throw new System.ArgumentNullException("SegmentDiscoveryProfileBindingMap cannot be null"); }
            StringBuilder PatchSegmentDiscoveryBindingServiceURL = new StringBuilder("/infra/tier-1s/{tier-1-id}/segments/{segment-id}/segment-discovery-profile-binding-maps/{segment-discovery-profile-binding-map-id}");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Patch
            };
            PatchSegmentDiscoveryBindingServiceURL.Replace("{tier-1-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(Tier1Id, System.Globalization.CultureInfo.InvariantCulture)));
            PatchSegmentDiscoveryBindingServiceURL.Replace("{segment-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(SegmentId, System.Globalization.CultureInfo.InvariantCulture)));
            PatchSegmentDiscoveryBindingServiceURL.Replace("{segment-discovery-profile-binding-map-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(SegmentDiscoveryProfileBindingMapId, System.Globalization.CultureInfo.InvariantCulture)));
            request.AddJsonBody(SegmentDiscoveryProfileBindingMap);
            request.Resource = PatchSegmentDiscoveryBindingServiceURL.ToString();
            RestResponse response = await restClient.ExecuteTaskAsyncWithPolicy(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Patch operation to " + PatchSegmentDiscoveryBindingServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTSegmentDiscoveryProfileBindingMapType> GlobalGlobalInfraGetSegmentDiscoveryBinding(string Tier1Id, string SegmentId, string SegmentDiscoveryProfileBindingMapId)
        {
            if (Tier1Id == null) { throw new System.ArgumentNullException("Tier1Id cannot be null"); }
            if (SegmentId == null) { throw new System.ArgumentNullException("SegmentId cannot be null"); }
            if (SegmentDiscoveryProfileBindingMapId == null) { throw new System.ArgumentNullException("SegmentDiscoveryProfileBindingMapId cannot be null"); }
            StringBuilder GlobalInfraGetSegmentDiscoveryBindingServiceURL = new StringBuilder("/global-infra/tier-1s/{tier-1-id}/segments/{segment-id}/segment-discovery-profile-binding-maps/{segment-discovery-profile-binding-map-id}");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Get
            };
            GlobalInfraGetSegmentDiscoveryBindingServiceURL.Replace("{tier-1-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(Tier1Id, System.Globalization.CultureInfo.InvariantCulture)));
            GlobalInfraGetSegmentDiscoveryBindingServiceURL.Replace("{segment-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(SegmentId, System.Globalization.CultureInfo.InvariantCulture)));
            GlobalInfraGetSegmentDiscoveryBindingServiceURL.Replace("{segment-discovery-profile-binding-map-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(SegmentDiscoveryProfileBindingMapId, System.Globalization.CultureInfo.InvariantCulture)));
            request.Resource = GlobalInfraGetSegmentDiscoveryBindingServiceURL.ToString();
            RestResponse<NSXTSegmentDiscoveryProfileBindingMapType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTSegmentDiscoveryProfileBindingMapType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Get operation to " + GlobalInfraGetSegmentDiscoveryBindingServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
    }
}
