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
    public class PolicySecurityProfileBinding
    {
        private RestClient restClient;
        private int retry;
        private int timeout;
        private CancellationToken cancellationToken;

        public PolicySecurityProfileBinding(RestClient Client, CancellationToken _cancellationToken, int _timeout, int _retry)
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
        public async Task<NSXTSegmentSecurityProfileBindingMapType> CreateOrUpdateSegmentSecurityProfileBinding(string Tier1Id, string SegmentId, string SegmentSecurityProfileBindingMapId, NSXTSegmentSecurityProfileBindingMapType SegmentSecurityProfileBindingMap)
        {
            if (Tier1Id == null) { throw new System.ArgumentNullException("Tier1Id cannot be null"); }
            if (SegmentId == null) { throw new System.ArgumentNullException("SegmentId cannot be null"); }
            if (SegmentSecurityProfileBindingMapId == null) { throw new System.ArgumentNullException("SegmentSecurityProfileBindingMapId cannot be null"); }
            if (SegmentSecurityProfileBindingMap == null) { throw new System.ArgumentNullException("SegmentSecurityProfileBindingMap cannot be null"); }
            StringBuilder CreateOrUpdateSegmentSecurityProfileBindingServiceURL = new StringBuilder("/infra/tier-1s/{tier-1-id}/segments/{segment-id}/segment-security-profile-binding-maps/{segment-security-profile-binding-map-id}");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Put
            };
            CreateOrUpdateSegmentSecurityProfileBindingServiceURL.Replace("{tier-1-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(Tier1Id, System.Globalization.CultureInfo.InvariantCulture)));
            CreateOrUpdateSegmentSecurityProfileBindingServiceURL.Replace("{segment-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(SegmentId, System.Globalization.CultureInfo.InvariantCulture)));
            CreateOrUpdateSegmentSecurityProfileBindingServiceURL.Replace("{segment-security-profile-binding-map-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(SegmentSecurityProfileBindingMapId, System.Globalization.CultureInfo.InvariantCulture)));
            request.AddJsonBody(SegmentSecurityProfileBindingMap);
            request.Resource = CreateOrUpdateSegmentSecurityProfileBindingServiceURL.ToString();
            RestResponse<NSXTSegmentSecurityProfileBindingMapType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTSegmentSecurityProfileBindingMapType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Put operation to " + CreateOrUpdateSegmentSecurityProfileBindingServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task DeleteSegmentSecurityProfileBinding(string Tier1Id, string SegmentId, string SegmentSecurityProfileBindingMapId)
        {
            if (Tier1Id == null) { throw new System.ArgumentNullException("Tier1Id cannot be null"); }
            if (SegmentId == null) { throw new System.ArgumentNullException("SegmentId cannot be null"); }
            if (SegmentSecurityProfileBindingMapId == null) { throw new System.ArgumentNullException("SegmentSecurityProfileBindingMapId cannot be null"); }
            StringBuilder DeleteSegmentSecurityProfileBindingServiceURL = new StringBuilder("/infra/tier-1s/{tier-1-id}/segments/{segment-id}/segment-security-profile-binding-maps/{segment-security-profile-binding-map-id}");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Delete
            };
            DeleteSegmentSecurityProfileBindingServiceURL.Replace("{tier-1-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(Tier1Id, System.Globalization.CultureInfo.InvariantCulture)));
            DeleteSegmentSecurityProfileBindingServiceURL.Replace("{segment-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(SegmentId, System.Globalization.CultureInfo.InvariantCulture)));
            DeleteSegmentSecurityProfileBindingServiceURL.Replace("{segment-security-profile-binding-map-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(SegmentSecurityProfileBindingMapId, System.Globalization.CultureInfo.InvariantCulture)));
            request.Resource = DeleteSegmentSecurityProfileBindingServiceURL.ToString();
            RestResponse response = await restClient.ExecuteTaskAsyncWithPolicy(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Delete operation to " + DeleteSegmentSecurityProfileBindingServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task PatchSegmentSecurityProfileBinding(string Tier1Id, string SegmentId, string SegmentSecurityProfileBindingMapId, NSXTSegmentSecurityProfileBindingMapType SegmentSecurityProfileBindingMap)
        {
            if (Tier1Id == null) { throw new System.ArgumentNullException("Tier1Id cannot be null"); }
            if (SegmentId == null) { throw new System.ArgumentNullException("SegmentId cannot be null"); }
            if (SegmentSecurityProfileBindingMapId == null) { throw new System.ArgumentNullException("SegmentSecurityProfileBindingMapId cannot be null"); }
            if (SegmentSecurityProfileBindingMap == null) { throw new System.ArgumentNullException("SegmentSecurityProfileBindingMap cannot be null"); }
            StringBuilder PatchSegmentSecurityProfileBindingServiceURL = new StringBuilder("/infra/tier-1s/{tier-1-id}/segments/{segment-id}/segment-security-profile-binding-maps/{segment-security-profile-binding-map-id}");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Patch
            };
            PatchSegmentSecurityProfileBindingServiceURL.Replace("{tier-1-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(Tier1Id, System.Globalization.CultureInfo.InvariantCulture)));
            PatchSegmentSecurityProfileBindingServiceURL.Replace("{segment-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(SegmentId, System.Globalization.CultureInfo.InvariantCulture)));
            PatchSegmentSecurityProfileBindingServiceURL.Replace("{segment-security-profile-binding-map-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(SegmentSecurityProfileBindingMapId, System.Globalization.CultureInfo.InvariantCulture)));
            request.AddJsonBody(SegmentSecurityProfileBindingMap);
            request.Resource = PatchSegmentSecurityProfileBindingServiceURL.ToString();
            RestResponse response = await restClient.ExecuteTaskAsyncWithPolicy(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Patch operation to " + PatchSegmentSecurityProfileBindingServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTSegmentSecurityProfileBindingMapType> GetSegmentSecurityProfileBinding(string Tier1Id, string SegmentId, string SegmentSecurityProfileBindingMapId)
        {
            if (Tier1Id == null) { throw new System.ArgumentNullException("Tier1Id cannot be null"); }
            if (SegmentId == null) { throw new System.ArgumentNullException("SegmentId cannot be null"); }
            if (SegmentSecurityProfileBindingMapId == null) { throw new System.ArgumentNullException("SegmentSecurityProfileBindingMapId cannot be null"); }
            StringBuilder GetSegmentSecurityProfileBindingServiceURL = new StringBuilder("/infra/tier-1s/{tier-1-id}/segments/{segment-id}/segment-security-profile-binding-maps/{segment-security-profile-binding-map-id}");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Get
            };
            GetSegmentSecurityProfileBindingServiceURL.Replace("{tier-1-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(Tier1Id, System.Globalization.CultureInfo.InvariantCulture)));
            GetSegmentSecurityProfileBindingServiceURL.Replace("{segment-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(SegmentId, System.Globalization.CultureInfo.InvariantCulture)));
            GetSegmentSecurityProfileBindingServiceURL.Replace("{segment-security-profile-binding-map-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(SegmentSecurityProfileBindingMapId, System.Globalization.CultureInfo.InvariantCulture)));
            request.Resource = GetSegmentSecurityProfileBindingServiceURL.ToString();
            RestResponse<NSXTSegmentSecurityProfileBindingMapType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTSegmentSecurityProfileBindingMapType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Get operation to " + GetSegmentSecurityProfileBindingServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTSegmentSecurityProfileBindingMapListResultType> ListInfraSegmentSecurityProfileBindings(string SegmentId, string? Cursor = null, string? IncludedFields = null, long? PageSize = null, bool? SortAscending = null, string? SortBy = null)
        {
            if (SegmentId == null) { throw new System.ArgumentNullException("SegmentId cannot be null"); }
            StringBuilder ListInfraSegmentSecurityProfileBindingsServiceURL = new StringBuilder("/infra/segments/{segment-id}/segment-security-profile-binding-maps");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Get
            };
            ListInfraSegmentSecurityProfileBindingsServiceURL.Replace("{segment-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(SegmentId, System.Globalization.CultureInfo.InvariantCulture)));
            if (Cursor != null) { request.AddQueryParameter("cursor", Cursor.ToString()); }
            if (IncludedFields != null) { request.AddQueryParameter("included_fields", IncludedFields.ToString()); }
            if (PageSize != null) { request.AddQueryParameter("page_size", PageSize.ToString()); }
            if (SortAscending != null) { request.AddQueryParameter("sort_ascending", SortAscending.ToString()); }
            if (SortBy != null) { request.AddQueryParameter("sort_by", SortBy.ToString()); }
            request.Resource = ListInfraSegmentSecurityProfileBindingsServiceURL.ToString();
            RestResponse<NSXTSegmentSecurityProfileBindingMapListResultType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTSegmentSecurityProfileBindingMapListResultType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Get operation to " + ListInfraSegmentSecurityProfileBindingsServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTPortSecurityProfileBindingMapType> GlobalGlobalInfraCreateOrUpdateInfraSegmentPortSecurityProfileBinding(string SegmentId, string PortId, string PortSecurityProfileBindingMapId, NSXTPortSecurityProfileBindingMapType PortSecurityProfileBindingMap)
        {
            if (SegmentId == null) { throw new System.ArgumentNullException("SegmentId cannot be null"); }
            if (PortId == null) { throw new System.ArgumentNullException("PortId cannot be null"); }
            if (PortSecurityProfileBindingMapId == null) { throw new System.ArgumentNullException("PortSecurityProfileBindingMapId cannot be null"); }
            if (PortSecurityProfileBindingMap == null) { throw new System.ArgumentNullException("PortSecurityProfileBindingMap cannot be null"); }
            StringBuilder GlobalInfraCreateOrUpdateInfraSegmentPortSecurityProfileBindingServiceURL = new StringBuilder("/global-infra/segments/{segment-id}/ports/{port-id}/port-security-profile-binding-maps/{port-security-profile-binding-map-id}");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Put
            };
            GlobalInfraCreateOrUpdateInfraSegmentPortSecurityProfileBindingServiceURL.Replace("{segment-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(SegmentId, System.Globalization.CultureInfo.InvariantCulture)));
            GlobalInfraCreateOrUpdateInfraSegmentPortSecurityProfileBindingServiceURL.Replace("{port-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(PortId, System.Globalization.CultureInfo.InvariantCulture)));
            GlobalInfraCreateOrUpdateInfraSegmentPortSecurityProfileBindingServiceURL.Replace("{port-security-profile-binding-map-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(PortSecurityProfileBindingMapId, System.Globalization.CultureInfo.InvariantCulture)));
            request.AddJsonBody(PortSecurityProfileBindingMap);
            request.Resource = GlobalInfraCreateOrUpdateInfraSegmentPortSecurityProfileBindingServiceURL.ToString();
            RestResponse<NSXTPortSecurityProfileBindingMapType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTPortSecurityProfileBindingMapType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Put operation to " + GlobalInfraCreateOrUpdateInfraSegmentPortSecurityProfileBindingServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task GlobalGlobalInfraPatchInfraSegmentPortSecurityProfileBinding(string SegmentId, string PortId, string PortSecurityProfileBindingMapId, NSXTPortSecurityProfileBindingMapType PortSecurityProfileBindingMap)
        {
            if (SegmentId == null) { throw new System.ArgumentNullException("SegmentId cannot be null"); }
            if (PortId == null) { throw new System.ArgumentNullException("PortId cannot be null"); }
            if (PortSecurityProfileBindingMapId == null) { throw new System.ArgumentNullException("PortSecurityProfileBindingMapId cannot be null"); }
            if (PortSecurityProfileBindingMap == null) { throw new System.ArgumentNullException("PortSecurityProfileBindingMap cannot be null"); }
            StringBuilder GlobalInfraPatchInfraSegmentPortSecurityProfileBindingServiceURL = new StringBuilder("/global-infra/segments/{segment-id}/ports/{port-id}/port-security-profile-binding-maps/{port-security-profile-binding-map-id}");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Patch
            };
            GlobalInfraPatchInfraSegmentPortSecurityProfileBindingServiceURL.Replace("{segment-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(SegmentId, System.Globalization.CultureInfo.InvariantCulture)));
            GlobalInfraPatchInfraSegmentPortSecurityProfileBindingServiceURL.Replace("{port-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(PortId, System.Globalization.CultureInfo.InvariantCulture)));
            GlobalInfraPatchInfraSegmentPortSecurityProfileBindingServiceURL.Replace("{port-security-profile-binding-map-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(PortSecurityProfileBindingMapId, System.Globalization.CultureInfo.InvariantCulture)));
            request.AddJsonBody(PortSecurityProfileBindingMap);
            request.Resource = GlobalInfraPatchInfraSegmentPortSecurityProfileBindingServiceURL.ToString();
            RestResponse response = await restClient.ExecuteTaskAsyncWithPolicy(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Patch operation to " + GlobalInfraPatchInfraSegmentPortSecurityProfileBindingServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTPortSecurityProfileBindingMapType> GlobalGlobalInfraGetInfraSegmentPortSecurityProfileBinding(string SegmentId, string PortId, string PortSecurityProfileBindingMapId)
        {
            if (SegmentId == null) { throw new System.ArgumentNullException("SegmentId cannot be null"); }
            if (PortId == null) { throw new System.ArgumentNullException("PortId cannot be null"); }
            if (PortSecurityProfileBindingMapId == null) { throw new System.ArgumentNullException("PortSecurityProfileBindingMapId cannot be null"); }
            StringBuilder GlobalInfraGetInfraSegmentPortSecurityProfileBindingServiceURL = new StringBuilder("/global-infra/segments/{segment-id}/ports/{port-id}/port-security-profile-binding-maps/{port-security-profile-binding-map-id}");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Get
            };
            GlobalInfraGetInfraSegmentPortSecurityProfileBindingServiceURL.Replace("{segment-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(SegmentId, System.Globalization.CultureInfo.InvariantCulture)));
            GlobalInfraGetInfraSegmentPortSecurityProfileBindingServiceURL.Replace("{port-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(PortId, System.Globalization.CultureInfo.InvariantCulture)));
            GlobalInfraGetInfraSegmentPortSecurityProfileBindingServiceURL.Replace("{port-security-profile-binding-map-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(PortSecurityProfileBindingMapId, System.Globalization.CultureInfo.InvariantCulture)));
            request.Resource = GlobalInfraGetInfraSegmentPortSecurityProfileBindingServiceURL.ToString();
            RestResponse<NSXTPortSecurityProfileBindingMapType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTPortSecurityProfileBindingMapType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Get operation to " + GlobalInfraGetInfraSegmentPortSecurityProfileBindingServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task GlobalGlobalInfraDeleteInfraSegmentPortSecurityProfileBinding(string SegmentId, string PortId, string PortSecurityProfileBindingMapId)
        {
            if (SegmentId == null) { throw new System.ArgumentNullException("SegmentId cannot be null"); }
            if (PortId == null) { throw new System.ArgumentNullException("PortId cannot be null"); }
            if (PortSecurityProfileBindingMapId == null) { throw new System.ArgumentNullException("PortSecurityProfileBindingMapId cannot be null"); }
            StringBuilder GlobalInfraDeleteInfraSegmentPortSecurityProfileBindingServiceURL = new StringBuilder("/global-infra/segments/{segment-id}/ports/{port-id}/port-security-profile-binding-maps/{port-security-profile-binding-map-id}");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Delete
            };
            GlobalInfraDeleteInfraSegmentPortSecurityProfileBindingServiceURL.Replace("{segment-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(SegmentId, System.Globalization.CultureInfo.InvariantCulture)));
            GlobalInfraDeleteInfraSegmentPortSecurityProfileBindingServiceURL.Replace("{port-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(PortId, System.Globalization.CultureInfo.InvariantCulture)));
            GlobalInfraDeleteInfraSegmentPortSecurityProfileBindingServiceURL.Replace("{port-security-profile-binding-map-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(PortSecurityProfileBindingMapId, System.Globalization.CultureInfo.InvariantCulture)));
            request.Resource = GlobalInfraDeleteInfraSegmentPortSecurityProfileBindingServiceURL.ToString();
            RestResponse response = await restClient.ExecuteTaskAsyncWithPolicy(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Delete operation to " + GlobalInfraDeleteInfraSegmentPortSecurityProfileBindingServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTPortSecurityProfileBindingMapType> CreateOrUpdatePortSecurityProfileBinding(string Tier1Id, string SegmentId, string PortId, string PortSecurityProfileBindingMapId, NSXTPortSecurityProfileBindingMapType PortSecurityProfileBindingMap)
        {
            if (Tier1Id == null) { throw new System.ArgumentNullException("Tier1Id cannot be null"); }
            if (SegmentId == null) { throw new System.ArgumentNullException("SegmentId cannot be null"); }
            if (PortId == null) { throw new System.ArgumentNullException("PortId cannot be null"); }
            if (PortSecurityProfileBindingMapId == null) { throw new System.ArgumentNullException("PortSecurityProfileBindingMapId cannot be null"); }
            if (PortSecurityProfileBindingMap == null) { throw new System.ArgumentNullException("PortSecurityProfileBindingMap cannot be null"); }
            StringBuilder CreateOrUpdatePortSecurityProfileBindingServiceURL = new StringBuilder("/infra/tier-1s/{tier-1-id}/segments/{segment-id}/ports/{port-id}/port-security-profile-binding-maps/{port-security-profile-binding-map-id}");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Put
            };
            CreateOrUpdatePortSecurityProfileBindingServiceURL.Replace("{tier-1-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(Tier1Id, System.Globalization.CultureInfo.InvariantCulture)));
            CreateOrUpdatePortSecurityProfileBindingServiceURL.Replace("{segment-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(SegmentId, System.Globalization.CultureInfo.InvariantCulture)));
            CreateOrUpdatePortSecurityProfileBindingServiceURL.Replace("{port-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(PortId, System.Globalization.CultureInfo.InvariantCulture)));
            CreateOrUpdatePortSecurityProfileBindingServiceURL.Replace("{port-security-profile-binding-map-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(PortSecurityProfileBindingMapId, System.Globalization.CultureInfo.InvariantCulture)));
            request.AddJsonBody(PortSecurityProfileBindingMap);
            request.Resource = CreateOrUpdatePortSecurityProfileBindingServiceURL.ToString();
            RestResponse<NSXTPortSecurityProfileBindingMapType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTPortSecurityProfileBindingMapType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Put operation to " + CreateOrUpdatePortSecurityProfileBindingServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTPortSecurityProfileBindingMapType> GetPortSecurityProfileBinding(string Tier1Id, string SegmentId, string PortId, string PortSecurityProfileBindingMapId)
        {
            if (Tier1Id == null) { throw new System.ArgumentNullException("Tier1Id cannot be null"); }
            if (SegmentId == null) { throw new System.ArgumentNullException("SegmentId cannot be null"); }
            if (PortId == null) { throw new System.ArgumentNullException("PortId cannot be null"); }
            if (PortSecurityProfileBindingMapId == null) { throw new System.ArgumentNullException("PortSecurityProfileBindingMapId cannot be null"); }
            StringBuilder GetPortSecurityProfileBindingServiceURL = new StringBuilder("/infra/tier-1s/{tier-1-id}/segments/{segment-id}/ports/{port-id}/port-security-profile-binding-maps/{port-security-profile-binding-map-id}");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Get
            };
            GetPortSecurityProfileBindingServiceURL.Replace("{tier-1-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(Tier1Id, System.Globalization.CultureInfo.InvariantCulture)));
            GetPortSecurityProfileBindingServiceURL.Replace("{segment-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(SegmentId, System.Globalization.CultureInfo.InvariantCulture)));
            GetPortSecurityProfileBindingServiceURL.Replace("{port-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(PortId, System.Globalization.CultureInfo.InvariantCulture)));
            GetPortSecurityProfileBindingServiceURL.Replace("{port-security-profile-binding-map-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(PortSecurityProfileBindingMapId, System.Globalization.CultureInfo.InvariantCulture)));
            request.Resource = GetPortSecurityProfileBindingServiceURL.ToString();
            RestResponse<NSXTPortSecurityProfileBindingMapType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTPortSecurityProfileBindingMapType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Get operation to " + GetPortSecurityProfileBindingServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task PatchPortSecurityProfileBinding(string Tier1Id, string SegmentId, string PortId, string PortSecurityProfileBindingMapId, NSXTPortSecurityProfileBindingMapType PortSecurityProfileBindingMap)
        {
            if (Tier1Id == null) { throw new System.ArgumentNullException("Tier1Id cannot be null"); }
            if (SegmentId == null) { throw new System.ArgumentNullException("SegmentId cannot be null"); }
            if (PortId == null) { throw new System.ArgumentNullException("PortId cannot be null"); }
            if (PortSecurityProfileBindingMapId == null) { throw new System.ArgumentNullException("PortSecurityProfileBindingMapId cannot be null"); }
            if (PortSecurityProfileBindingMap == null) { throw new System.ArgumentNullException("PortSecurityProfileBindingMap cannot be null"); }
            StringBuilder PatchPortSecurityProfileBindingServiceURL = new StringBuilder("/infra/tier-1s/{tier-1-id}/segments/{segment-id}/ports/{port-id}/port-security-profile-binding-maps/{port-security-profile-binding-map-id}");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Patch
            };
            PatchPortSecurityProfileBindingServiceURL.Replace("{tier-1-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(Tier1Id, System.Globalization.CultureInfo.InvariantCulture)));
            PatchPortSecurityProfileBindingServiceURL.Replace("{segment-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(SegmentId, System.Globalization.CultureInfo.InvariantCulture)));
            PatchPortSecurityProfileBindingServiceURL.Replace("{port-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(PortId, System.Globalization.CultureInfo.InvariantCulture)));
            PatchPortSecurityProfileBindingServiceURL.Replace("{port-security-profile-binding-map-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(PortSecurityProfileBindingMapId, System.Globalization.CultureInfo.InvariantCulture)));
            request.AddJsonBody(PortSecurityProfileBindingMap);
            request.Resource = PatchPortSecurityProfileBindingServiceURL.ToString();
            RestResponse response = await restClient.ExecuteTaskAsyncWithPolicy(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Patch operation to " + PatchPortSecurityProfileBindingServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task DeletePortSecurityProfileBinding(string Tier1Id, string SegmentId, string PortId, string PortSecurityProfileBindingMapId)
        {
            if (Tier1Id == null) { throw new System.ArgumentNullException("Tier1Id cannot be null"); }
            if (SegmentId == null) { throw new System.ArgumentNullException("SegmentId cannot be null"); }
            if (PortId == null) { throw new System.ArgumentNullException("PortId cannot be null"); }
            if (PortSecurityProfileBindingMapId == null) { throw new System.ArgumentNullException("PortSecurityProfileBindingMapId cannot be null"); }
            StringBuilder DeletePortSecurityProfileBindingServiceURL = new StringBuilder("/infra/tier-1s/{tier-1-id}/segments/{segment-id}/ports/{port-id}/port-security-profile-binding-maps/{port-security-profile-binding-map-id}");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Delete
            };
            DeletePortSecurityProfileBindingServiceURL.Replace("{tier-1-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(Tier1Id, System.Globalization.CultureInfo.InvariantCulture)));
            DeletePortSecurityProfileBindingServiceURL.Replace("{segment-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(SegmentId, System.Globalization.CultureInfo.InvariantCulture)));
            DeletePortSecurityProfileBindingServiceURL.Replace("{port-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(PortId, System.Globalization.CultureInfo.InvariantCulture)));
            DeletePortSecurityProfileBindingServiceURL.Replace("{port-security-profile-binding-map-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(PortSecurityProfileBindingMapId, System.Globalization.CultureInfo.InvariantCulture)));
            request.Resource = DeletePortSecurityProfileBindingServiceURL.ToString();
            RestResponse response = await restClient.ExecuteTaskAsyncWithPolicy(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Delete operation to " + DeletePortSecurityProfileBindingServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTSegmentSecurityProfileBindingMapType> GlobalGlobalInfraGetSegmentSecurityProfileBinding(string Tier1Id, string SegmentId, string SegmentSecurityProfileBindingMapId)
        {
            if (Tier1Id == null) { throw new System.ArgumentNullException("Tier1Id cannot be null"); }
            if (SegmentId == null) { throw new System.ArgumentNullException("SegmentId cannot be null"); }
            if (SegmentSecurityProfileBindingMapId == null) { throw new System.ArgumentNullException("SegmentSecurityProfileBindingMapId cannot be null"); }
            StringBuilder GlobalInfraGetSegmentSecurityProfileBindingServiceURL = new StringBuilder("/global-infra/tier-1s/{tier-1-id}/segments/{segment-id}/segment-security-profile-binding-maps/{segment-security-profile-binding-map-id}");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Get
            };
            GlobalInfraGetSegmentSecurityProfileBindingServiceURL.Replace("{tier-1-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(Tier1Id, System.Globalization.CultureInfo.InvariantCulture)));
            GlobalInfraGetSegmentSecurityProfileBindingServiceURL.Replace("{segment-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(SegmentId, System.Globalization.CultureInfo.InvariantCulture)));
            GlobalInfraGetSegmentSecurityProfileBindingServiceURL.Replace("{segment-security-profile-binding-map-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(SegmentSecurityProfileBindingMapId, System.Globalization.CultureInfo.InvariantCulture)));
            request.Resource = GlobalInfraGetSegmentSecurityProfileBindingServiceURL.ToString();
            RestResponse<NSXTSegmentSecurityProfileBindingMapType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTSegmentSecurityProfileBindingMapType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Get operation to " + GlobalInfraGetSegmentSecurityProfileBindingServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTSegmentSecurityProfileBindingMapListResultType> GlobalGlobalInfraListSegmentSecurityProfileBindings(string Tier1Id, string SegmentId, string? Cursor = null, string? IncludedFields = null, long? PageSize = null, bool? SortAscending = null, string? SortBy = null)
        {
            if (Tier1Id == null) { throw new System.ArgumentNullException("Tier1Id cannot be null"); }
            if (SegmentId == null) { throw new System.ArgumentNullException("SegmentId cannot be null"); }
            StringBuilder GlobalInfraListSegmentSecurityProfileBindingsServiceURL = new StringBuilder("/global-infra/tier-1s/{tier-1-id}/segments/{segment-id}/segment-security-profile-binding-maps");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Get
            };
            GlobalInfraListSegmentSecurityProfileBindingsServiceURL.Replace("{tier-1-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(Tier1Id, System.Globalization.CultureInfo.InvariantCulture)));
            GlobalInfraListSegmentSecurityProfileBindingsServiceURL.Replace("{segment-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(SegmentId, System.Globalization.CultureInfo.InvariantCulture)));
            if (Cursor != null) { request.AddQueryParameter("cursor", Cursor.ToString()); }
            if (IncludedFields != null) { request.AddQueryParameter("included_fields", IncludedFields.ToString()); }
            if (PageSize != null) { request.AddQueryParameter("page_size", PageSize.ToString()); }
            if (SortAscending != null) { request.AddQueryParameter("sort_ascending", SortAscending.ToString()); }
            if (SortBy != null) { request.AddQueryParameter("sort_by", SortBy.ToString()); }
            request.Resource = GlobalInfraListSegmentSecurityProfileBindingsServiceURL.ToString();
            RestResponse<NSXTSegmentSecurityProfileBindingMapListResultType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTSegmentSecurityProfileBindingMapListResultType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Get operation to " + GlobalInfraListSegmentSecurityProfileBindingsServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTPortSecurityProfileBindingMapListResultType> GlobalGlobalInfraListInfraSegmentPortSecurityProfileBindings(string SegmentId, string PortId, string? Cursor = null, string? IncludedFields = null, long? PageSize = null, bool? SortAscending = null, string? SortBy = null)
        {
            if (SegmentId == null) { throw new System.ArgumentNullException("SegmentId cannot be null"); }
            if (PortId == null) { throw new System.ArgumentNullException("PortId cannot be null"); }
            StringBuilder GlobalInfraListInfraSegmentPortSecurityProfileBindingsServiceURL = new StringBuilder("/global-infra/segments/{segment-id}/ports/{port-id}/port-security-profile-binding-maps");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Get
            };
            GlobalInfraListInfraSegmentPortSecurityProfileBindingsServiceURL.Replace("{segment-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(SegmentId, System.Globalization.CultureInfo.InvariantCulture)));
            GlobalInfraListInfraSegmentPortSecurityProfileBindingsServiceURL.Replace("{port-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(PortId, System.Globalization.CultureInfo.InvariantCulture)));
            if (Cursor != null) { request.AddQueryParameter("cursor", Cursor.ToString()); }
            if (IncludedFields != null) { request.AddQueryParameter("included_fields", IncludedFields.ToString()); }
            if (PageSize != null) { request.AddQueryParameter("page_size", PageSize.ToString()); }
            if (SortAscending != null) { request.AddQueryParameter("sort_ascending", SortAscending.ToString()); }
            if (SortBy != null) { request.AddQueryParameter("sort_by", SortBy.ToString()); }
            request.Resource = GlobalInfraListInfraSegmentPortSecurityProfileBindingsServiceURL.ToString();
            RestResponse<NSXTPortSecurityProfileBindingMapListResultType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTPortSecurityProfileBindingMapListResultType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Get operation to " + GlobalInfraListInfraSegmentPortSecurityProfileBindingsServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTPortSecurityProfileBindingMapType> GlobalGlobalInfraCreateOrUpdatePortSecurityProfileBinding(string Tier1Id, string SegmentId, string PortId, string PortSecurityProfileBindingMapId, NSXTPortSecurityProfileBindingMapType PortSecurityProfileBindingMap)
        {
            if (Tier1Id == null) { throw new System.ArgumentNullException("Tier1Id cannot be null"); }
            if (SegmentId == null) { throw new System.ArgumentNullException("SegmentId cannot be null"); }
            if (PortId == null) { throw new System.ArgumentNullException("PortId cannot be null"); }
            if (PortSecurityProfileBindingMapId == null) { throw new System.ArgumentNullException("PortSecurityProfileBindingMapId cannot be null"); }
            if (PortSecurityProfileBindingMap == null) { throw new System.ArgumentNullException("PortSecurityProfileBindingMap cannot be null"); }
            StringBuilder GlobalInfraCreateOrUpdatePortSecurityProfileBindingServiceURL = new StringBuilder("/global-infra/tier-1s/{tier-1-id}/segments/{segment-id}/ports/{port-id}/port-security-profile-binding-maps/{port-security-profile-binding-map-id}");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Put
            };
            GlobalInfraCreateOrUpdatePortSecurityProfileBindingServiceURL.Replace("{tier-1-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(Tier1Id, System.Globalization.CultureInfo.InvariantCulture)));
            GlobalInfraCreateOrUpdatePortSecurityProfileBindingServiceURL.Replace("{segment-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(SegmentId, System.Globalization.CultureInfo.InvariantCulture)));
            GlobalInfraCreateOrUpdatePortSecurityProfileBindingServiceURL.Replace("{port-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(PortId, System.Globalization.CultureInfo.InvariantCulture)));
            GlobalInfraCreateOrUpdatePortSecurityProfileBindingServiceURL.Replace("{port-security-profile-binding-map-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(PortSecurityProfileBindingMapId, System.Globalization.CultureInfo.InvariantCulture)));
            request.AddJsonBody(PortSecurityProfileBindingMap);
            request.Resource = GlobalInfraCreateOrUpdatePortSecurityProfileBindingServiceURL.ToString();
            RestResponse<NSXTPortSecurityProfileBindingMapType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTPortSecurityProfileBindingMapType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Put operation to " + GlobalInfraCreateOrUpdatePortSecurityProfileBindingServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTPortSecurityProfileBindingMapType> GlobalGlobalInfraGetPortSecurityProfileBinding(string Tier1Id, string SegmentId, string PortId, string PortSecurityProfileBindingMapId)
        {
            if (Tier1Id == null) { throw new System.ArgumentNullException("Tier1Id cannot be null"); }
            if (SegmentId == null) { throw new System.ArgumentNullException("SegmentId cannot be null"); }
            if (PortId == null) { throw new System.ArgumentNullException("PortId cannot be null"); }
            if (PortSecurityProfileBindingMapId == null) { throw new System.ArgumentNullException("PortSecurityProfileBindingMapId cannot be null"); }
            StringBuilder GlobalInfraGetPortSecurityProfileBindingServiceURL = new StringBuilder("/global-infra/tier-1s/{tier-1-id}/segments/{segment-id}/ports/{port-id}/port-security-profile-binding-maps/{port-security-profile-binding-map-id}");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Get
            };
            GlobalInfraGetPortSecurityProfileBindingServiceURL.Replace("{tier-1-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(Tier1Id, System.Globalization.CultureInfo.InvariantCulture)));
            GlobalInfraGetPortSecurityProfileBindingServiceURL.Replace("{segment-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(SegmentId, System.Globalization.CultureInfo.InvariantCulture)));
            GlobalInfraGetPortSecurityProfileBindingServiceURL.Replace("{port-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(PortId, System.Globalization.CultureInfo.InvariantCulture)));
            GlobalInfraGetPortSecurityProfileBindingServiceURL.Replace("{port-security-profile-binding-map-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(PortSecurityProfileBindingMapId, System.Globalization.CultureInfo.InvariantCulture)));
            request.Resource = GlobalInfraGetPortSecurityProfileBindingServiceURL.ToString();
            RestResponse<NSXTPortSecurityProfileBindingMapType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTPortSecurityProfileBindingMapType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Get operation to " + GlobalInfraGetPortSecurityProfileBindingServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task GlobalGlobalInfraPatchPortSecurityProfileBinding(string Tier1Id, string SegmentId, string PortId, string PortSecurityProfileBindingMapId, NSXTPortSecurityProfileBindingMapType PortSecurityProfileBindingMap)
        {
            if (Tier1Id == null) { throw new System.ArgumentNullException("Tier1Id cannot be null"); }
            if (SegmentId == null) { throw new System.ArgumentNullException("SegmentId cannot be null"); }
            if (PortId == null) { throw new System.ArgumentNullException("PortId cannot be null"); }
            if (PortSecurityProfileBindingMapId == null) { throw new System.ArgumentNullException("PortSecurityProfileBindingMapId cannot be null"); }
            if (PortSecurityProfileBindingMap == null) { throw new System.ArgumentNullException("PortSecurityProfileBindingMap cannot be null"); }
            StringBuilder GlobalInfraPatchPortSecurityProfileBindingServiceURL = new StringBuilder("/global-infra/tier-1s/{tier-1-id}/segments/{segment-id}/ports/{port-id}/port-security-profile-binding-maps/{port-security-profile-binding-map-id}");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Patch
            };
            GlobalInfraPatchPortSecurityProfileBindingServiceURL.Replace("{tier-1-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(Tier1Id, System.Globalization.CultureInfo.InvariantCulture)));
            GlobalInfraPatchPortSecurityProfileBindingServiceURL.Replace("{segment-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(SegmentId, System.Globalization.CultureInfo.InvariantCulture)));
            GlobalInfraPatchPortSecurityProfileBindingServiceURL.Replace("{port-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(PortId, System.Globalization.CultureInfo.InvariantCulture)));
            GlobalInfraPatchPortSecurityProfileBindingServiceURL.Replace("{port-security-profile-binding-map-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(PortSecurityProfileBindingMapId, System.Globalization.CultureInfo.InvariantCulture)));
            request.AddJsonBody(PortSecurityProfileBindingMap);
            request.Resource = GlobalInfraPatchPortSecurityProfileBindingServiceURL.ToString();
            RestResponse response = await restClient.ExecuteTaskAsyncWithPolicy(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Patch operation to " + GlobalInfraPatchPortSecurityProfileBindingServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task GlobalGlobalInfraDeletePortSecurityProfileBinding(string Tier1Id, string SegmentId, string PortId, string PortSecurityProfileBindingMapId)
        {
            if (Tier1Id == null) { throw new System.ArgumentNullException("Tier1Id cannot be null"); }
            if (SegmentId == null) { throw new System.ArgumentNullException("SegmentId cannot be null"); }
            if (PortId == null) { throw new System.ArgumentNullException("PortId cannot be null"); }
            if (PortSecurityProfileBindingMapId == null) { throw new System.ArgumentNullException("PortSecurityProfileBindingMapId cannot be null"); }
            StringBuilder GlobalInfraDeletePortSecurityProfileBindingServiceURL = new StringBuilder("/global-infra/tier-1s/{tier-1-id}/segments/{segment-id}/ports/{port-id}/port-security-profile-binding-maps/{port-security-profile-binding-map-id}");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Delete
            };
            GlobalInfraDeletePortSecurityProfileBindingServiceURL.Replace("{tier-1-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(Tier1Id, System.Globalization.CultureInfo.InvariantCulture)));
            GlobalInfraDeletePortSecurityProfileBindingServiceURL.Replace("{segment-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(SegmentId, System.Globalization.CultureInfo.InvariantCulture)));
            GlobalInfraDeletePortSecurityProfileBindingServiceURL.Replace("{port-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(PortId, System.Globalization.CultureInfo.InvariantCulture)));
            GlobalInfraDeletePortSecurityProfileBindingServiceURL.Replace("{port-security-profile-binding-map-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(PortSecurityProfileBindingMapId, System.Globalization.CultureInfo.InvariantCulture)));
            request.Resource = GlobalInfraDeletePortSecurityProfileBindingServiceURL.ToString();
            RestResponse response = await restClient.ExecuteTaskAsyncWithPolicy(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Delete operation to " + GlobalInfraDeletePortSecurityProfileBindingServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTPortSecurityProfileBindingMapListResultType> GlobalGlobalInfraListPortSecurityProfileBindings(string Tier1Id, string SegmentId, string PortId, string? Cursor = null, string? IncludedFields = null, long? PageSize = null, bool? SortAscending = null, string? SortBy = null)
        {
            if (Tier1Id == null) { throw new System.ArgumentNullException("Tier1Id cannot be null"); }
            if (SegmentId == null) { throw new System.ArgumentNullException("SegmentId cannot be null"); }
            if (PortId == null) { throw new System.ArgumentNullException("PortId cannot be null"); }
            StringBuilder GlobalInfraListPortSecurityProfileBindingsServiceURL = new StringBuilder("/global-infra/tier-1s/{tier-1-id}/segments/{segment-id}/ports/{port-id}/port-security-profile-binding-maps");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Get
            };
            GlobalInfraListPortSecurityProfileBindingsServiceURL.Replace("{tier-1-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(Tier1Id, System.Globalization.CultureInfo.InvariantCulture)));
            GlobalInfraListPortSecurityProfileBindingsServiceURL.Replace("{segment-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(SegmentId, System.Globalization.CultureInfo.InvariantCulture)));
            GlobalInfraListPortSecurityProfileBindingsServiceURL.Replace("{port-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(PortId, System.Globalization.CultureInfo.InvariantCulture)));
            if (Cursor != null) { request.AddQueryParameter("cursor", Cursor.ToString()); }
            if (IncludedFields != null) { request.AddQueryParameter("included_fields", IncludedFields.ToString()); }
            if (PageSize != null) { request.AddQueryParameter("page_size", PageSize.ToString()); }
            if (SortAscending != null) { request.AddQueryParameter("sort_ascending", SortAscending.ToString()); }
            if (SortBy != null) { request.AddQueryParameter("sort_by", SortBy.ToString()); }
            request.Resource = GlobalInfraListPortSecurityProfileBindingsServiceURL.ToString();
            RestResponse<NSXTPortSecurityProfileBindingMapListResultType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTPortSecurityProfileBindingMapListResultType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Get operation to " + GlobalInfraListPortSecurityProfileBindingsServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTSegmentSecurityProfileBindingMapType> CreateOrUpdateInfraSegmentSecurityProfileBinding(string SegmentId, string SegmentSecurityProfileBindingMapId, NSXTSegmentSecurityProfileBindingMapType SegmentSecurityProfileBindingMap)
        {
            if (SegmentId == null) { throw new System.ArgumentNullException("SegmentId cannot be null"); }
            if (SegmentSecurityProfileBindingMapId == null) { throw new System.ArgumentNullException("SegmentSecurityProfileBindingMapId cannot be null"); }
            if (SegmentSecurityProfileBindingMap == null) { throw new System.ArgumentNullException("SegmentSecurityProfileBindingMap cannot be null"); }
            StringBuilder CreateOrUpdateInfraSegmentSecurityProfileBindingServiceURL = new StringBuilder("/infra/segments/{segment-id}/segment-security-profile-binding-maps/{segment-security-profile-binding-map-id}");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Put
            };
            CreateOrUpdateInfraSegmentSecurityProfileBindingServiceURL.Replace("{segment-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(SegmentId, System.Globalization.CultureInfo.InvariantCulture)));
            CreateOrUpdateInfraSegmentSecurityProfileBindingServiceURL.Replace("{segment-security-profile-binding-map-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(SegmentSecurityProfileBindingMapId, System.Globalization.CultureInfo.InvariantCulture)));
            request.AddJsonBody(SegmentSecurityProfileBindingMap);
            request.Resource = CreateOrUpdateInfraSegmentSecurityProfileBindingServiceURL.ToString();
            RestResponse<NSXTSegmentSecurityProfileBindingMapType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTSegmentSecurityProfileBindingMapType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Put operation to " + CreateOrUpdateInfraSegmentSecurityProfileBindingServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task DeleteInfraSegmentSecurityProfileBinding(string SegmentId, string SegmentSecurityProfileBindingMapId)
        {
            if (SegmentId == null) { throw new System.ArgumentNullException("SegmentId cannot be null"); }
            if (SegmentSecurityProfileBindingMapId == null) { throw new System.ArgumentNullException("SegmentSecurityProfileBindingMapId cannot be null"); }
            StringBuilder DeleteInfraSegmentSecurityProfileBindingServiceURL = new StringBuilder("/infra/segments/{segment-id}/segment-security-profile-binding-maps/{segment-security-profile-binding-map-id}");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Delete
            };
            DeleteInfraSegmentSecurityProfileBindingServiceURL.Replace("{segment-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(SegmentId, System.Globalization.CultureInfo.InvariantCulture)));
            DeleteInfraSegmentSecurityProfileBindingServiceURL.Replace("{segment-security-profile-binding-map-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(SegmentSecurityProfileBindingMapId, System.Globalization.CultureInfo.InvariantCulture)));
            request.Resource = DeleteInfraSegmentSecurityProfileBindingServiceURL.ToString();
            RestResponse response = await restClient.ExecuteTaskAsyncWithPolicy(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Delete operation to " + DeleteInfraSegmentSecurityProfileBindingServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTSegmentSecurityProfileBindingMapType> GetInfraSegmentSecurityProfileBinding(string SegmentId, string SegmentSecurityProfileBindingMapId)
        {
            if (SegmentId == null) { throw new System.ArgumentNullException("SegmentId cannot be null"); }
            if (SegmentSecurityProfileBindingMapId == null) { throw new System.ArgumentNullException("SegmentSecurityProfileBindingMapId cannot be null"); }
            StringBuilder GetInfraSegmentSecurityProfileBindingServiceURL = new StringBuilder("/infra/segments/{segment-id}/segment-security-profile-binding-maps/{segment-security-profile-binding-map-id}");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Get
            };
            GetInfraSegmentSecurityProfileBindingServiceURL.Replace("{segment-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(SegmentId, System.Globalization.CultureInfo.InvariantCulture)));
            GetInfraSegmentSecurityProfileBindingServiceURL.Replace("{segment-security-profile-binding-map-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(SegmentSecurityProfileBindingMapId, System.Globalization.CultureInfo.InvariantCulture)));
            request.Resource = GetInfraSegmentSecurityProfileBindingServiceURL.ToString();
            RestResponse<NSXTSegmentSecurityProfileBindingMapType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTSegmentSecurityProfileBindingMapType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Get operation to " + GetInfraSegmentSecurityProfileBindingServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task PatchInfraSegmentSecurityProfileBinding(string SegmentId, string SegmentSecurityProfileBindingMapId, NSXTSegmentSecurityProfileBindingMapType SegmentSecurityProfileBindingMap)
        {
            if (SegmentId == null) { throw new System.ArgumentNullException("SegmentId cannot be null"); }
            if (SegmentSecurityProfileBindingMapId == null) { throw new System.ArgumentNullException("SegmentSecurityProfileBindingMapId cannot be null"); }
            if (SegmentSecurityProfileBindingMap == null) { throw new System.ArgumentNullException("SegmentSecurityProfileBindingMap cannot be null"); }
            StringBuilder PatchInfraSegmentSecurityProfileBindingServiceURL = new StringBuilder("/infra/segments/{segment-id}/segment-security-profile-binding-maps/{segment-security-profile-binding-map-id}");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Patch
            };
            PatchInfraSegmentSecurityProfileBindingServiceURL.Replace("{segment-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(SegmentId, System.Globalization.CultureInfo.InvariantCulture)));
            PatchInfraSegmentSecurityProfileBindingServiceURL.Replace("{segment-security-profile-binding-map-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(SegmentSecurityProfileBindingMapId, System.Globalization.CultureInfo.InvariantCulture)));
            request.AddJsonBody(SegmentSecurityProfileBindingMap);
            request.Resource = PatchInfraSegmentSecurityProfileBindingServiceURL.ToString();
            RestResponse response = await restClient.ExecuteTaskAsyncWithPolicy(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Patch operation to " + PatchInfraSegmentSecurityProfileBindingServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTPortSecurityProfileBindingMapListResultType> ListInfraSegmentPortSecurityProfileBindings(string SegmentId, string PortId, string? Cursor = null, string? IncludedFields = null, long? PageSize = null, bool? SortAscending = null, string? SortBy = null)
        {
            if (SegmentId == null) { throw new System.ArgumentNullException("SegmentId cannot be null"); }
            if (PortId == null) { throw new System.ArgumentNullException("PortId cannot be null"); }
            StringBuilder ListInfraSegmentPortSecurityProfileBindingsServiceURL = new StringBuilder("/infra/segments/{segment-id}/ports/{port-id}/port-security-profile-binding-maps");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Get
            };
            ListInfraSegmentPortSecurityProfileBindingsServiceURL.Replace("{segment-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(SegmentId, System.Globalization.CultureInfo.InvariantCulture)));
            ListInfraSegmentPortSecurityProfileBindingsServiceURL.Replace("{port-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(PortId, System.Globalization.CultureInfo.InvariantCulture)));
            if (Cursor != null) { request.AddQueryParameter("cursor", Cursor.ToString()); }
            if (IncludedFields != null) { request.AddQueryParameter("included_fields", IncludedFields.ToString()); }
            if (PageSize != null) { request.AddQueryParameter("page_size", PageSize.ToString()); }
            if (SortAscending != null) { request.AddQueryParameter("sort_ascending", SortAscending.ToString()); }
            if (SortBy != null) { request.AddQueryParameter("sort_by", SortBy.ToString()); }
            request.Resource = ListInfraSegmentPortSecurityProfileBindingsServiceURL.ToString();
            RestResponse<NSXTPortSecurityProfileBindingMapListResultType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTPortSecurityProfileBindingMapListResultType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Get operation to " + ListInfraSegmentPortSecurityProfileBindingsServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTSegmentSecurityProfileBindingMapListResultType> GlobalGlobalInfraListInfraSegmentSecurityProfileBindings(string SegmentId, string? Cursor = null, string? IncludedFields = null, long? PageSize = null, bool? SortAscending = null, string? SortBy = null)
        {
            if (SegmentId == null) { throw new System.ArgumentNullException("SegmentId cannot be null"); }
            StringBuilder GlobalInfraListInfraSegmentSecurityProfileBindingsServiceURL = new StringBuilder("/global-infra/segments/{segment-id}/segment-security-profile-binding-maps");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Get
            };
            GlobalInfraListInfraSegmentSecurityProfileBindingsServiceURL.Replace("{segment-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(SegmentId, System.Globalization.CultureInfo.InvariantCulture)));
            if (Cursor != null) { request.AddQueryParameter("cursor", Cursor.ToString()); }
            if (IncludedFields != null) { request.AddQueryParameter("included_fields", IncludedFields.ToString()); }
            if (PageSize != null) { request.AddQueryParameter("page_size", PageSize.ToString()); }
            if (SortAscending != null) { request.AddQueryParameter("sort_ascending", SortAscending.ToString()); }
            if (SortBy != null) { request.AddQueryParameter("sort_by", SortBy.ToString()); }
            request.Resource = GlobalInfraListInfraSegmentSecurityProfileBindingsServiceURL.ToString();
            RestResponse<NSXTSegmentSecurityProfileBindingMapListResultType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTSegmentSecurityProfileBindingMapListResultType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Get operation to " + GlobalInfraListInfraSegmentSecurityProfileBindingsServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTSegmentSecurityProfileBindingMapType> GlobalGlobalInfraGetInfraSegmentSecurityProfileBinding(string SegmentId, string SegmentSecurityProfileBindingMapId)
        {
            if (SegmentId == null) { throw new System.ArgumentNullException("SegmentId cannot be null"); }
            if (SegmentSecurityProfileBindingMapId == null) { throw new System.ArgumentNullException("SegmentSecurityProfileBindingMapId cannot be null"); }
            StringBuilder GlobalInfraGetInfraSegmentSecurityProfileBindingServiceURL = new StringBuilder("/global-infra/segments/{segment-id}/segment-security-profile-binding-maps/{segment-security-profile-binding-map-id}");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Get
            };
            GlobalInfraGetInfraSegmentSecurityProfileBindingServiceURL.Replace("{segment-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(SegmentId, System.Globalization.CultureInfo.InvariantCulture)));
            GlobalInfraGetInfraSegmentSecurityProfileBindingServiceURL.Replace("{segment-security-profile-binding-map-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(SegmentSecurityProfileBindingMapId, System.Globalization.CultureInfo.InvariantCulture)));
            request.Resource = GlobalInfraGetInfraSegmentSecurityProfileBindingServiceURL.ToString();
            RestResponse<NSXTSegmentSecurityProfileBindingMapType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTSegmentSecurityProfileBindingMapType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Get operation to " + GlobalInfraGetInfraSegmentSecurityProfileBindingServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTPortSecurityProfileBindingMapType> CreateOrUpdateInfraSegmentPortSecurityProfileBinding(string SegmentId, string PortId, string PortSecurityProfileBindingMapId, NSXTPortSecurityProfileBindingMapType PortSecurityProfileBindingMap)
        {
            if (SegmentId == null) { throw new System.ArgumentNullException("SegmentId cannot be null"); }
            if (PortId == null) { throw new System.ArgumentNullException("PortId cannot be null"); }
            if (PortSecurityProfileBindingMapId == null) { throw new System.ArgumentNullException("PortSecurityProfileBindingMapId cannot be null"); }
            if (PortSecurityProfileBindingMap == null) { throw new System.ArgumentNullException("PortSecurityProfileBindingMap cannot be null"); }
            StringBuilder CreateOrUpdateInfraSegmentPortSecurityProfileBindingServiceURL = new StringBuilder("/infra/segments/{segment-id}/ports/{port-id}/port-security-profile-binding-maps/{port-security-profile-binding-map-id}");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Put
            };
            CreateOrUpdateInfraSegmentPortSecurityProfileBindingServiceURL.Replace("{segment-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(SegmentId, System.Globalization.CultureInfo.InvariantCulture)));
            CreateOrUpdateInfraSegmentPortSecurityProfileBindingServiceURL.Replace("{port-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(PortId, System.Globalization.CultureInfo.InvariantCulture)));
            CreateOrUpdateInfraSegmentPortSecurityProfileBindingServiceURL.Replace("{port-security-profile-binding-map-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(PortSecurityProfileBindingMapId, System.Globalization.CultureInfo.InvariantCulture)));
            request.AddJsonBody(PortSecurityProfileBindingMap);
            request.Resource = CreateOrUpdateInfraSegmentPortSecurityProfileBindingServiceURL.ToString();
            RestResponse<NSXTPortSecurityProfileBindingMapType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTPortSecurityProfileBindingMapType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Put operation to " + CreateOrUpdateInfraSegmentPortSecurityProfileBindingServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task PatchInfraSegmentPortSecurityProfileBinding(string SegmentId, string PortId, string PortSecurityProfileBindingMapId, NSXTPortSecurityProfileBindingMapType PortSecurityProfileBindingMap)
        {
            if (SegmentId == null) { throw new System.ArgumentNullException("SegmentId cannot be null"); }
            if (PortId == null) { throw new System.ArgumentNullException("PortId cannot be null"); }
            if (PortSecurityProfileBindingMapId == null) { throw new System.ArgumentNullException("PortSecurityProfileBindingMapId cannot be null"); }
            if (PortSecurityProfileBindingMap == null) { throw new System.ArgumentNullException("PortSecurityProfileBindingMap cannot be null"); }
            StringBuilder PatchInfraSegmentPortSecurityProfileBindingServiceURL = new StringBuilder("/infra/segments/{segment-id}/ports/{port-id}/port-security-profile-binding-maps/{port-security-profile-binding-map-id}");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Patch
            };
            PatchInfraSegmentPortSecurityProfileBindingServiceURL.Replace("{segment-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(SegmentId, System.Globalization.CultureInfo.InvariantCulture)));
            PatchInfraSegmentPortSecurityProfileBindingServiceURL.Replace("{port-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(PortId, System.Globalization.CultureInfo.InvariantCulture)));
            PatchInfraSegmentPortSecurityProfileBindingServiceURL.Replace("{port-security-profile-binding-map-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(PortSecurityProfileBindingMapId, System.Globalization.CultureInfo.InvariantCulture)));
            request.AddJsonBody(PortSecurityProfileBindingMap);
            request.Resource = PatchInfraSegmentPortSecurityProfileBindingServiceURL.ToString();
            RestResponse response = await restClient.ExecuteTaskAsyncWithPolicy(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Patch operation to " + PatchInfraSegmentPortSecurityProfileBindingServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTPortSecurityProfileBindingMapType> GetInfraSegmentPortSecurityProfileBinding(string SegmentId, string PortId, string PortSecurityProfileBindingMapId)
        {
            if (SegmentId == null) { throw new System.ArgumentNullException("SegmentId cannot be null"); }
            if (PortId == null) { throw new System.ArgumentNullException("PortId cannot be null"); }
            if (PortSecurityProfileBindingMapId == null) { throw new System.ArgumentNullException("PortSecurityProfileBindingMapId cannot be null"); }
            StringBuilder GetInfraSegmentPortSecurityProfileBindingServiceURL = new StringBuilder("/infra/segments/{segment-id}/ports/{port-id}/port-security-profile-binding-maps/{port-security-profile-binding-map-id}");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Get
            };
            GetInfraSegmentPortSecurityProfileBindingServiceURL.Replace("{segment-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(SegmentId, System.Globalization.CultureInfo.InvariantCulture)));
            GetInfraSegmentPortSecurityProfileBindingServiceURL.Replace("{port-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(PortId, System.Globalization.CultureInfo.InvariantCulture)));
            GetInfraSegmentPortSecurityProfileBindingServiceURL.Replace("{port-security-profile-binding-map-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(PortSecurityProfileBindingMapId, System.Globalization.CultureInfo.InvariantCulture)));
            request.Resource = GetInfraSegmentPortSecurityProfileBindingServiceURL.ToString();
            RestResponse<NSXTPortSecurityProfileBindingMapType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTPortSecurityProfileBindingMapType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Get operation to " + GetInfraSegmentPortSecurityProfileBindingServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task DeleteInfraSegmentPortSecurityProfileBinding(string SegmentId, string PortId, string PortSecurityProfileBindingMapId)
        {
            if (SegmentId == null) { throw new System.ArgumentNullException("SegmentId cannot be null"); }
            if (PortId == null) { throw new System.ArgumentNullException("PortId cannot be null"); }
            if (PortSecurityProfileBindingMapId == null) { throw new System.ArgumentNullException("PortSecurityProfileBindingMapId cannot be null"); }
            StringBuilder DeleteInfraSegmentPortSecurityProfileBindingServiceURL = new StringBuilder("/infra/segments/{segment-id}/ports/{port-id}/port-security-profile-binding-maps/{port-security-profile-binding-map-id}");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Delete
            };
            DeleteInfraSegmentPortSecurityProfileBindingServiceURL.Replace("{segment-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(SegmentId, System.Globalization.CultureInfo.InvariantCulture)));
            DeleteInfraSegmentPortSecurityProfileBindingServiceURL.Replace("{port-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(PortId, System.Globalization.CultureInfo.InvariantCulture)));
            DeleteInfraSegmentPortSecurityProfileBindingServiceURL.Replace("{port-security-profile-binding-map-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(PortSecurityProfileBindingMapId, System.Globalization.CultureInfo.InvariantCulture)));
            request.Resource = DeleteInfraSegmentPortSecurityProfileBindingServiceURL.ToString();
            RestResponse response = await restClient.ExecuteTaskAsyncWithPolicy(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Delete operation to " + DeleteInfraSegmentPortSecurityProfileBindingServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTPortSecurityProfileBindingMapListResultType> ListPortSecurityProfileBindings(string Tier1Id, string SegmentId, string PortId, string? Cursor = null, string? IncludedFields = null, long? PageSize = null, bool? SortAscending = null, string? SortBy = null)
        {
            if (Tier1Id == null) { throw new System.ArgumentNullException("Tier1Id cannot be null"); }
            if (SegmentId == null) { throw new System.ArgumentNullException("SegmentId cannot be null"); }
            if (PortId == null) { throw new System.ArgumentNullException("PortId cannot be null"); }
            StringBuilder ListPortSecurityProfileBindingsServiceURL = new StringBuilder("/infra/tier-1s/{tier-1-id}/segments/{segment-id}/ports/{port-id}/port-security-profile-binding-maps");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Get
            };
            ListPortSecurityProfileBindingsServiceURL.Replace("{tier-1-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(Tier1Id, System.Globalization.CultureInfo.InvariantCulture)));
            ListPortSecurityProfileBindingsServiceURL.Replace("{segment-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(SegmentId, System.Globalization.CultureInfo.InvariantCulture)));
            ListPortSecurityProfileBindingsServiceURL.Replace("{port-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(PortId, System.Globalization.CultureInfo.InvariantCulture)));
            if (Cursor != null) { request.AddQueryParameter("cursor", Cursor.ToString()); }
            if (IncludedFields != null) { request.AddQueryParameter("included_fields", IncludedFields.ToString()); }
            if (PageSize != null) { request.AddQueryParameter("page_size", PageSize.ToString()); }
            if (SortAscending != null) { request.AddQueryParameter("sort_ascending", SortAscending.ToString()); }
            if (SortBy != null) { request.AddQueryParameter("sort_by", SortBy.ToString()); }
            request.Resource = ListPortSecurityProfileBindingsServiceURL.ToString();
            RestResponse<NSXTPortSecurityProfileBindingMapListResultType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTPortSecurityProfileBindingMapListResultType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Get operation to " + ListPortSecurityProfileBindingsServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTSegmentSecurityProfileBindingMapListResultType> ListSegmentSecurityProfileBindings(string Tier1Id, string SegmentId, string? Cursor = null, string? IncludedFields = null, long? PageSize = null, bool? SortAscending = null, string? SortBy = null)
        {
            if (Tier1Id == null) { throw new System.ArgumentNullException("Tier1Id cannot be null"); }
            if (SegmentId == null) { throw new System.ArgumentNullException("SegmentId cannot be null"); }
            StringBuilder ListSegmentSecurityProfileBindingsServiceURL = new StringBuilder("/infra/tier-1s/{tier-1-id}/segments/{segment-id}/segment-security-profile-binding-maps");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Get
            };
            ListSegmentSecurityProfileBindingsServiceURL.Replace("{tier-1-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(Tier1Id, System.Globalization.CultureInfo.InvariantCulture)));
            ListSegmentSecurityProfileBindingsServiceURL.Replace("{segment-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(SegmentId, System.Globalization.CultureInfo.InvariantCulture)));
            if (Cursor != null) { request.AddQueryParameter("cursor", Cursor.ToString()); }
            if (IncludedFields != null) { request.AddQueryParameter("included_fields", IncludedFields.ToString()); }
            if (PageSize != null) { request.AddQueryParameter("page_size", PageSize.ToString()); }
            if (SortAscending != null) { request.AddQueryParameter("sort_ascending", SortAscending.ToString()); }
            if (SortBy != null) { request.AddQueryParameter("sort_by", SortBy.ToString()); }
            request.Resource = ListSegmentSecurityProfileBindingsServiceURL.ToString();
            RestResponse<NSXTSegmentSecurityProfileBindingMapListResultType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTSegmentSecurityProfileBindingMapListResultType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Get operation to " + ListSegmentSecurityProfileBindingsServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
    }
}
