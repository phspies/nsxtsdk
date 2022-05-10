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
    public class PolicyTransportZone
    {
        private RestClient restClient;
        private int retry;
        private int timeout;
        private CancellationToken cancellationToken;

        public PolicyTransportZone(RestClient Client, CancellationToken _cancellationToken, int _timeout, int _retry)
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
        public async Task<NSXTPolicyTransportZoneType> CreateOrUpdateTransportZoneForEnforcementPoint(string SiteId, string EnforcementpointId, string TransportZoneId, NSXTPolicyTransportZoneType PolicyTransportZone)
        {
            if (SiteId == null) { throw new System.ArgumentNullException("SiteId cannot be null"); }
            if (EnforcementpointId == null) { throw new System.ArgumentNullException("EnforcementpointId cannot be null"); }
            if (TransportZoneId == null) { throw new System.ArgumentNullException("TransportZoneId cannot be null"); }
            if (PolicyTransportZone == null) { throw new System.ArgumentNullException("PolicyTransportZone cannot be null"); }
            StringBuilder CreateOrUpdateTransportZoneForEnforcementPointServiceURL = new StringBuilder("/infra/sites/{site-id}/enforcement-points/{enforcementpoint-id}/transport-zones/{transport-zone-id}");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Put
            };
            CreateOrUpdateTransportZoneForEnforcementPointServiceURL.Replace("{site-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(SiteId, System.Globalization.CultureInfo.InvariantCulture)));
            CreateOrUpdateTransportZoneForEnforcementPointServiceURL.Replace("{enforcementpoint-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(EnforcementpointId, System.Globalization.CultureInfo.InvariantCulture)));
            CreateOrUpdateTransportZoneForEnforcementPointServiceURL.Replace("{transport-zone-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(TransportZoneId, System.Globalization.CultureInfo.InvariantCulture)));
            request.AddJsonBody(PolicyTransportZone);
            request.Resource = CreateOrUpdateTransportZoneForEnforcementPointServiceURL.ToString();
            RestResponse<NSXTPolicyTransportZoneType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTPolicyTransportZoneType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Put operation to " + CreateOrUpdateTransportZoneForEnforcementPointServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTPolicyTransportZoneType> PatchTransportZoneForEnforcementPoint(string SiteId, string EnforcementpointId, string TransportZoneId, NSXTPolicyTransportZoneType PolicyTransportZone)
        {
            if (SiteId == null) { throw new System.ArgumentNullException("SiteId cannot be null"); }
            if (EnforcementpointId == null) { throw new System.ArgumentNullException("EnforcementpointId cannot be null"); }
            if (TransportZoneId == null) { throw new System.ArgumentNullException("TransportZoneId cannot be null"); }
            if (PolicyTransportZone == null) { throw new System.ArgumentNullException("PolicyTransportZone cannot be null"); }
            StringBuilder PatchTransportZoneForEnforcementPointServiceURL = new StringBuilder("/infra/sites/{site-id}/enforcement-points/{enforcementpoint-id}/transport-zones/{transport-zone-id}");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Patch
            };
            PatchTransportZoneForEnforcementPointServiceURL.Replace("{site-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(SiteId, System.Globalization.CultureInfo.InvariantCulture)));
            PatchTransportZoneForEnforcementPointServiceURL.Replace("{enforcementpoint-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(EnforcementpointId, System.Globalization.CultureInfo.InvariantCulture)));
            PatchTransportZoneForEnforcementPointServiceURL.Replace("{transport-zone-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(TransportZoneId, System.Globalization.CultureInfo.InvariantCulture)));
            request.AddJsonBody(PolicyTransportZone);
            request.Resource = PatchTransportZoneForEnforcementPointServiceURL.ToString();
            RestResponse<NSXTPolicyTransportZoneType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTPolicyTransportZoneType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Patch operation to " + PatchTransportZoneForEnforcementPointServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTPolicyTransportZoneType> ReadTransportZoneForEnforcementPoint(string SiteId, string EnforcementpointId, string TransportZoneId)
        {
            if (SiteId == null) { throw new System.ArgumentNullException("SiteId cannot be null"); }
            if (EnforcementpointId == null) { throw new System.ArgumentNullException("EnforcementpointId cannot be null"); }
            if (TransportZoneId == null) { throw new System.ArgumentNullException("TransportZoneId cannot be null"); }
            StringBuilder ReadTransportZoneForEnforcementPointServiceURL = new StringBuilder("/infra/sites/{site-id}/enforcement-points/{enforcementpoint-id}/transport-zones/{transport-zone-id}");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Get
            };
            ReadTransportZoneForEnforcementPointServiceURL.Replace("{site-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(SiteId, System.Globalization.CultureInfo.InvariantCulture)));
            ReadTransportZoneForEnforcementPointServiceURL.Replace("{enforcementpoint-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(EnforcementpointId, System.Globalization.CultureInfo.InvariantCulture)));
            ReadTransportZoneForEnforcementPointServiceURL.Replace("{transport-zone-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(TransportZoneId, System.Globalization.CultureInfo.InvariantCulture)));
            request.Resource = ReadTransportZoneForEnforcementPointServiceURL.ToString();
            RestResponse<NSXTPolicyTransportZoneType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTPolicyTransportZoneType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Get operation to " + ReadTransportZoneForEnforcementPointServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task DeleteTransportZoneForEnforcementPoint(string SiteId, string EnforcementpointId, string TransportZoneId)
        {
            if (SiteId == null) { throw new System.ArgumentNullException("SiteId cannot be null"); }
            if (EnforcementpointId == null) { throw new System.ArgumentNullException("EnforcementpointId cannot be null"); }
            if (TransportZoneId == null) { throw new System.ArgumentNullException("TransportZoneId cannot be null"); }
            StringBuilder DeleteTransportZoneForEnforcementPointServiceURL = new StringBuilder("/infra/sites/{site-id}/enforcement-points/{enforcementpoint-id}/transport-zones/{transport-zone-id}");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Delete
            };
            DeleteTransportZoneForEnforcementPointServiceURL.Replace("{site-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(SiteId, System.Globalization.CultureInfo.InvariantCulture)));
            DeleteTransportZoneForEnforcementPointServiceURL.Replace("{enforcementpoint-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(EnforcementpointId, System.Globalization.CultureInfo.InvariantCulture)));
            DeleteTransportZoneForEnforcementPointServiceURL.Replace("{transport-zone-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(TransportZoneId, System.Globalization.CultureInfo.InvariantCulture)));
            request.Resource = DeleteTransportZoneForEnforcementPointServiceURL.ToString();
            RestResponse response = await restClient.ExecuteTaskAsyncWithPolicy(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Delete operation to " + DeleteTransportZoneForEnforcementPointServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTPolicyTransportZoneType> GlobalGlobalInfraReadTransportZoneForEnforcementPoint(string SiteId, string EnforcementpointId, string TransportZoneId)
        {
            if (SiteId == null) { throw new System.ArgumentNullException("SiteId cannot be null"); }
            if (EnforcementpointId == null) { throw new System.ArgumentNullException("EnforcementpointId cannot be null"); }
            if (TransportZoneId == null) { throw new System.ArgumentNullException("TransportZoneId cannot be null"); }
            StringBuilder GlobalInfraReadTransportZoneForEnforcementPointServiceURL = new StringBuilder("/global-infra/sites/{site-id}/enforcement-points/{enforcementpoint-id}/transport-zones/{transport-zone-id}");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Get
            };
            GlobalInfraReadTransportZoneForEnforcementPointServiceURL.Replace("{site-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(SiteId, System.Globalization.CultureInfo.InvariantCulture)));
            GlobalInfraReadTransportZoneForEnforcementPointServiceURL.Replace("{enforcementpoint-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(EnforcementpointId, System.Globalization.CultureInfo.InvariantCulture)));
            GlobalInfraReadTransportZoneForEnforcementPointServiceURL.Replace("{transport-zone-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(TransportZoneId, System.Globalization.CultureInfo.InvariantCulture)));
            request.Resource = GlobalInfraReadTransportZoneForEnforcementPointServiceURL.ToString();
            RestResponse<NSXTPolicyTransportZoneType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTPolicyTransportZoneType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Get operation to " + GlobalInfraReadTransportZoneForEnforcementPointServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTPolicyTransportZoneListResultType> ListTransportZonesForEnforcementPoint(string SiteId, string EnforcementpointId, string? Cursor = null, bool? IncludeMarkForDeleteObjects = null, string? IncludedFields = null, long? PageSize = null, bool? SortAscending = null, string? SortBy = null)
        {
            if (SiteId == null) { throw new System.ArgumentNullException("SiteId cannot be null"); }
            if (EnforcementpointId == null) { throw new System.ArgumentNullException("EnforcementpointId cannot be null"); }
            StringBuilder ListTransportZonesForEnforcementPointServiceURL = new StringBuilder("/infra/sites/{site-id}/enforcement-points/{enforcementpoint-id}/transport-zones");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Get
            };
            ListTransportZonesForEnforcementPointServiceURL.Replace("{site-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(SiteId, System.Globalization.CultureInfo.InvariantCulture)));
            ListTransportZonesForEnforcementPointServiceURL.Replace("{enforcementpoint-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(EnforcementpointId, System.Globalization.CultureInfo.InvariantCulture)));
            if (Cursor != null) { request.AddQueryParameter("cursor", Cursor.ToString()); }
            if (IncludeMarkForDeleteObjects != null) { request.AddQueryParameter("include_mark_for_delete_objects", IncludeMarkForDeleteObjects.ToString()); }
            if (IncludedFields != null) { request.AddQueryParameter("included_fields", IncludedFields.ToString()); }
            if (PageSize != null) { request.AddQueryParameter("page_size", PageSize.ToString()); }
            if (SortAscending != null) { request.AddQueryParameter("sort_ascending", SortAscending.ToString()); }
            if (SortBy != null) { request.AddQueryParameter("sort_by", SortBy.ToString()); }
            request.Resource = ListTransportZonesForEnforcementPointServiceURL.ToString();
            RestResponse<NSXTPolicyTransportZoneListResultType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTPolicyTransportZoneListResultType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Get operation to " + ListTransportZonesForEnforcementPointServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTPolicyTransportZoneListResultType> GlobalGlobalInfraListTransportZonesForEnforcementPoint(string SiteId, string EnforcementpointId, string? Cursor = null, bool? IncludeMarkForDeleteObjects = null, string? IncludedFields = null, long? PageSize = null, bool? SortAscending = null, string? SortBy = null)
        {
            if (SiteId == null) { throw new System.ArgumentNullException("SiteId cannot be null"); }
            if (EnforcementpointId == null) { throw new System.ArgumentNullException("EnforcementpointId cannot be null"); }
            StringBuilder GlobalInfraListTransportZonesForEnforcementPointServiceURL = new StringBuilder("/global-infra/sites/{site-id}/enforcement-points/{enforcementpoint-id}/transport-zones");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Get
            };
            GlobalInfraListTransportZonesForEnforcementPointServiceURL.Replace("{site-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(SiteId, System.Globalization.CultureInfo.InvariantCulture)));
            GlobalInfraListTransportZonesForEnforcementPointServiceURL.Replace("{enforcementpoint-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(EnforcementpointId, System.Globalization.CultureInfo.InvariantCulture)));
            if (Cursor != null) { request.AddQueryParameter("cursor", Cursor.ToString()); }
            if (IncludeMarkForDeleteObjects != null) { request.AddQueryParameter("include_mark_for_delete_objects", IncludeMarkForDeleteObjects.ToString()); }
            if (IncludedFields != null) { request.AddQueryParameter("included_fields", IncludedFields.ToString()); }
            if (PageSize != null) { request.AddQueryParameter("page_size", PageSize.ToString()); }
            if (SortAscending != null) { request.AddQueryParameter("sort_ascending", SortAscending.ToString()); }
            if (SortBy != null) { request.AddQueryParameter("sort_by", SortBy.ToString()); }
            request.Resource = GlobalInfraListTransportZonesForEnforcementPointServiceURL.ToString();
            RestResponse<NSXTPolicyTransportZoneListResultType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTPolicyTransportZoneListResultType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Get operation to " + GlobalInfraListTransportZonesForEnforcementPointServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
    }
}
