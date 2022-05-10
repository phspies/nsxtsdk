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
    public class PolicyDfw
    {
        private RestClient restClient;
        private int retry;
        private int timeout;
        private CancellationToken cancellationToken;

        public PolicyDfw(RestClient Client, CancellationToken _cancellationToken, int _timeout, int _retry)
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
        public async Task<NSXTCommunicationMapType> ReviseCommunicationMaps(string DomainId, string CommunicationMapId, NSXTCommunicationMapType CommunicationMap, string? AnchorPath = null, string? Operation = null)
        {
            if (DomainId == null) { throw new System.ArgumentNullException("DomainId cannot be null"); }
            if (CommunicationMapId == null) { throw new System.ArgumentNullException("CommunicationMapId cannot be null"); }
            if (CommunicationMap == null) { throw new System.ArgumentNullException("CommunicationMap cannot be null"); }
            StringBuilder ReviseCommunicationMapsServiceURL = new StringBuilder("/infra/domains/{domain-id}/communication-maps/{communication-map-id}?action=revise");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Post
            };
            ReviseCommunicationMapsServiceURL.Replace("{domain-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(DomainId, System.Globalization.CultureInfo.InvariantCulture)));
            ReviseCommunicationMapsServiceURL.Replace("{communication-map-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(CommunicationMapId, System.Globalization.CultureInfo.InvariantCulture)));
            request.AddJsonBody(CommunicationMap);
            if (AnchorPath != null) { request.AddQueryParameter("anchor_path", AnchorPath.ToString()); }
            if (Operation != null) { request.AddQueryParameter("operation", Operation.ToString()); }
            request.Resource = ReviseCommunicationMapsServiceURL.ToString();
            RestResponse<NSXTCommunicationMapType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTCommunicationMapType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Post operation to " + ReviseCommunicationMapsServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTCommunicationMapType> UpdateCommunicationMapForDomain(string DomainId, string CommunicationMapId, NSXTCommunicationMapType CommunicationMap)
        {
            if (DomainId == null) { throw new System.ArgumentNullException("DomainId cannot be null"); }
            if (CommunicationMapId == null) { throw new System.ArgumentNullException("CommunicationMapId cannot be null"); }
            if (CommunicationMap == null) { throw new System.ArgumentNullException("CommunicationMap cannot be null"); }
            StringBuilder UpdateCommunicationMapForDomainServiceURL = new StringBuilder("/infra/domains/{domain-id}/communication-maps/{communication-map-id}");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Put
            };
            UpdateCommunicationMapForDomainServiceURL.Replace("{domain-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(DomainId, System.Globalization.CultureInfo.InvariantCulture)));
            UpdateCommunicationMapForDomainServiceURL.Replace("{communication-map-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(CommunicationMapId, System.Globalization.CultureInfo.InvariantCulture)));
            request.AddJsonBody(CommunicationMap);
            request.Resource = UpdateCommunicationMapForDomainServiceURL.ToString();
            RestResponse<NSXTCommunicationMapType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTCommunicationMapType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Put operation to " + UpdateCommunicationMapForDomainServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTCommunicationMapType> ReadCommunicationMapForDomain(string DomainId, string CommunicationMapId)
        {
            if (DomainId == null) { throw new System.ArgumentNullException("DomainId cannot be null"); }
            if (CommunicationMapId == null) { throw new System.ArgumentNullException("CommunicationMapId cannot be null"); }
            StringBuilder ReadCommunicationMapForDomainServiceURL = new StringBuilder("/infra/domains/{domain-id}/communication-maps/{communication-map-id}");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Get
            };
            ReadCommunicationMapForDomainServiceURL.Replace("{domain-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(DomainId, System.Globalization.CultureInfo.InvariantCulture)));
            ReadCommunicationMapForDomainServiceURL.Replace("{communication-map-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(CommunicationMapId, System.Globalization.CultureInfo.InvariantCulture)));
            request.Resource = ReadCommunicationMapForDomainServiceURL.ToString();
            RestResponse<NSXTCommunicationMapType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTCommunicationMapType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Get operation to " + ReadCommunicationMapForDomainServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task DeleteCommunicationMapForDomain(string DomainId, string CommunicationMapId)
        {
            if (DomainId == null) { throw new System.ArgumentNullException("DomainId cannot be null"); }
            if (CommunicationMapId == null) { throw new System.ArgumentNullException("CommunicationMapId cannot be null"); }
            StringBuilder DeleteCommunicationMapForDomainServiceURL = new StringBuilder("/infra/domains/{domain-id}/communication-maps/{communication-map-id}");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Delete
            };
            DeleteCommunicationMapForDomainServiceURL.Replace("{domain-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(DomainId, System.Globalization.CultureInfo.InvariantCulture)));
            DeleteCommunicationMapForDomainServiceURL.Replace("{communication-map-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(CommunicationMapId, System.Globalization.CultureInfo.InvariantCulture)));
            request.Resource = DeleteCommunicationMapForDomainServiceURL.ToString();
            RestResponse response = await restClient.ExecuteTaskAsyncWithPolicy(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Delete operation to " + DeleteCommunicationMapForDomainServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task PatchCommunicationMapForDomain(string DomainId, string CommunicationMapId, NSXTCommunicationMapType CommunicationMap)
        {
            if (DomainId == null) { throw new System.ArgumentNullException("DomainId cannot be null"); }
            if (CommunicationMapId == null) { throw new System.ArgumentNullException("CommunicationMapId cannot be null"); }
            if (CommunicationMap == null) { throw new System.ArgumentNullException("CommunicationMap cannot be null"); }
            StringBuilder PatchCommunicationMapForDomainServiceURL = new StringBuilder("/infra/domains/{domain-id}/communication-maps/{communication-map-id}");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Patch
            };
            PatchCommunicationMapForDomainServiceURL.Replace("{domain-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(DomainId, System.Globalization.CultureInfo.InvariantCulture)));
            PatchCommunicationMapForDomainServiceURL.Replace("{communication-map-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(CommunicationMapId, System.Globalization.CultureInfo.InvariantCulture)));
            request.AddJsonBody(CommunicationMap);
            request.Resource = PatchCommunicationMapForDomainServiceURL.ToString();
            RestResponse response = await restClient.ExecuteTaskAsyncWithPolicy(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Patch operation to " + PatchCommunicationMapForDomainServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTCommunicationMapListResultType> ListCommunicationMapsForDomain(string DomainId, string? Cursor = null, bool? IncludeMarkForDeleteObjects = null, string? IncludedFields = null, long? PageSize = null, bool? SortAscending = null, string? SortBy = null)
        {
            if (DomainId == null) { throw new System.ArgumentNullException("DomainId cannot be null"); }
            StringBuilder ListCommunicationMapsForDomainServiceURL = new StringBuilder("/infra/domains/{domain-id}/communication-maps");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Get
            };
            ListCommunicationMapsForDomainServiceURL.Replace("{domain-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(DomainId, System.Globalization.CultureInfo.InvariantCulture)));
            if (Cursor != null) { request.AddQueryParameter("cursor", Cursor.ToString()); }
            if (IncludeMarkForDeleteObjects != null) { request.AddQueryParameter("include_mark_for_delete_objects", IncludeMarkForDeleteObjects.ToString()); }
            if (IncludedFields != null) { request.AddQueryParameter("included_fields", IncludedFields.ToString()); }
            if (PageSize != null) { request.AddQueryParameter("page_size", PageSize.ToString()); }
            if (SortAscending != null) { request.AddQueryParameter("sort_ascending", SortAscending.ToString()); }
            if (SortBy != null) { request.AddQueryParameter("sort_by", SortBy.ToString()); }
            request.Resource = ListCommunicationMapsForDomainServiceURL.ToString();
            RestResponse<NSXTCommunicationMapListResultType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTCommunicationMapListResultType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Get operation to " + ListCommunicationMapsForDomainServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTCommunicationEntryListResultType> ListCommunicationEntry(string DomainId, string CommunicationMapId, string? Cursor = null, bool? IncludeMarkForDeleteObjects = null, string? IncludedFields = null, long? PageSize = null, bool? SortAscending = null, string? SortBy = null)
        {
            if (DomainId == null) { throw new System.ArgumentNullException("DomainId cannot be null"); }
            if (CommunicationMapId == null) { throw new System.ArgumentNullException("CommunicationMapId cannot be null"); }
            StringBuilder ListCommunicationEntryServiceURL = new StringBuilder("/infra/domains/{domain-id}/communication-maps/{communication-map-id}/communication-entries");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Get
            };
            ListCommunicationEntryServiceURL.Replace("{domain-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(DomainId, System.Globalization.CultureInfo.InvariantCulture)));
            ListCommunicationEntryServiceURL.Replace("{communication-map-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(CommunicationMapId, System.Globalization.CultureInfo.InvariantCulture)));
            if (Cursor != null) { request.AddQueryParameter("cursor", Cursor.ToString()); }
            if (IncludeMarkForDeleteObjects != null) { request.AddQueryParameter("include_mark_for_delete_objects", IncludeMarkForDeleteObjects.ToString()); }
            if (IncludedFields != null) { request.AddQueryParameter("included_fields", IncludedFields.ToString()); }
            if (PageSize != null) { request.AddQueryParameter("page_size", PageSize.ToString()); }
            if (SortAscending != null) { request.AddQueryParameter("sort_ascending", SortAscending.ToString()); }
            if (SortBy != null) { request.AddQueryParameter("sort_by", SortBy.ToString()); }
            request.Resource = ListCommunicationEntryServiceURL.ToString();
            RestResponse<NSXTCommunicationEntryListResultType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTCommunicationEntryListResultType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Get operation to " + ListCommunicationEntryServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTCommunicationEntryType> ReviseCommunicationEntry(string DomainId, string CommunicationMapId, string CommunicationEntryId, NSXTCommunicationEntryType CommunicationEntry, string? AnchorPath = null, string? Operation = null)
        {
            if (DomainId == null) { throw new System.ArgumentNullException("DomainId cannot be null"); }
            if (CommunicationMapId == null) { throw new System.ArgumentNullException("CommunicationMapId cannot be null"); }
            if (CommunicationEntryId == null) { throw new System.ArgumentNullException("CommunicationEntryId cannot be null"); }
            if (CommunicationEntry == null) { throw new System.ArgumentNullException("CommunicationEntry cannot be null"); }
            StringBuilder ReviseCommunicationEntryServiceURL = new StringBuilder("/infra/domains/{domain-id}/communication-maps/{communication-map-id}/communication-entries/{communication-entry-id}?action=revise");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Post
            };
            ReviseCommunicationEntryServiceURL.Replace("{domain-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(DomainId, System.Globalization.CultureInfo.InvariantCulture)));
            ReviseCommunicationEntryServiceURL.Replace("{communication-map-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(CommunicationMapId, System.Globalization.CultureInfo.InvariantCulture)));
            ReviseCommunicationEntryServiceURL.Replace("{communication-entry-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(CommunicationEntryId, System.Globalization.CultureInfo.InvariantCulture)));
            request.AddJsonBody(CommunicationEntry);
            if (AnchorPath != null) { request.AddQueryParameter("anchor_path", AnchorPath.ToString()); }
            if (Operation != null) { request.AddQueryParameter("operation", Operation.ToString()); }
            request.Resource = ReviseCommunicationEntryServiceURL.ToString();
            RestResponse<NSXTCommunicationEntryType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTCommunicationEntryType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Post operation to " + ReviseCommunicationEntryServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTCommunicationEntryType> UpdateCommunicationEntry(string DomainId, string CommunicationMapId, string CommunicationEntryId, NSXTCommunicationEntryType CommunicationEntry)
        {
            if (DomainId == null) { throw new System.ArgumentNullException("DomainId cannot be null"); }
            if (CommunicationMapId == null) { throw new System.ArgumentNullException("CommunicationMapId cannot be null"); }
            if (CommunicationEntryId == null) { throw new System.ArgumentNullException("CommunicationEntryId cannot be null"); }
            if (CommunicationEntry == null) { throw new System.ArgumentNullException("CommunicationEntry cannot be null"); }
            StringBuilder UpdateCommunicationEntryServiceURL = new StringBuilder("/infra/domains/{domain-id}/communication-maps/{communication-map-id}/communication-entries/{communication-entry-id}");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Put
            };
            UpdateCommunicationEntryServiceURL.Replace("{domain-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(DomainId, System.Globalization.CultureInfo.InvariantCulture)));
            UpdateCommunicationEntryServiceURL.Replace("{communication-map-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(CommunicationMapId, System.Globalization.CultureInfo.InvariantCulture)));
            UpdateCommunicationEntryServiceURL.Replace("{communication-entry-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(CommunicationEntryId, System.Globalization.CultureInfo.InvariantCulture)));
            request.AddJsonBody(CommunicationEntry);
            request.Resource = UpdateCommunicationEntryServiceURL.ToString();
            RestResponse<NSXTCommunicationEntryType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTCommunicationEntryType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Put operation to " + UpdateCommunicationEntryServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTCommunicationEntryType> ReadCommunicationEntry(string DomainId, string CommunicationMapId, string CommunicationEntryId)
        {
            if (DomainId == null) { throw new System.ArgumentNullException("DomainId cannot be null"); }
            if (CommunicationMapId == null) { throw new System.ArgumentNullException("CommunicationMapId cannot be null"); }
            if (CommunicationEntryId == null) { throw new System.ArgumentNullException("CommunicationEntryId cannot be null"); }
            StringBuilder ReadCommunicationEntryServiceURL = new StringBuilder("/infra/domains/{domain-id}/communication-maps/{communication-map-id}/communication-entries/{communication-entry-id}");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Get
            };
            ReadCommunicationEntryServiceURL.Replace("{domain-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(DomainId, System.Globalization.CultureInfo.InvariantCulture)));
            ReadCommunicationEntryServiceURL.Replace("{communication-map-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(CommunicationMapId, System.Globalization.CultureInfo.InvariantCulture)));
            ReadCommunicationEntryServiceURL.Replace("{communication-entry-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(CommunicationEntryId, System.Globalization.CultureInfo.InvariantCulture)));
            request.Resource = ReadCommunicationEntryServiceURL.ToString();
            RestResponse<NSXTCommunicationEntryType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTCommunicationEntryType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Get operation to " + ReadCommunicationEntryServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task DeleteCommunicationEntry(string DomainId, string CommunicationMapId, string CommunicationEntryId)
        {
            if (DomainId == null) { throw new System.ArgumentNullException("DomainId cannot be null"); }
            if (CommunicationMapId == null) { throw new System.ArgumentNullException("CommunicationMapId cannot be null"); }
            if (CommunicationEntryId == null) { throw new System.ArgumentNullException("CommunicationEntryId cannot be null"); }
            StringBuilder DeleteCommunicationEntryServiceURL = new StringBuilder("/infra/domains/{domain-id}/communication-maps/{communication-map-id}/communication-entries/{communication-entry-id}");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Delete
            };
            DeleteCommunicationEntryServiceURL.Replace("{domain-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(DomainId, System.Globalization.CultureInfo.InvariantCulture)));
            DeleteCommunicationEntryServiceURL.Replace("{communication-map-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(CommunicationMapId, System.Globalization.CultureInfo.InvariantCulture)));
            DeleteCommunicationEntryServiceURL.Replace("{communication-entry-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(CommunicationEntryId, System.Globalization.CultureInfo.InvariantCulture)));
            request.Resource = DeleteCommunicationEntryServiceURL.ToString();
            RestResponse response = await restClient.ExecuteTaskAsyncWithPolicy(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Delete operation to " + DeleteCommunicationEntryServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task PatchCommunicationEntry(string DomainId, string CommunicationMapId, string CommunicationEntryId, NSXTCommunicationEntryType CommunicationEntry)
        {
            if (DomainId == null) { throw new System.ArgumentNullException("DomainId cannot be null"); }
            if (CommunicationMapId == null) { throw new System.ArgumentNullException("CommunicationMapId cannot be null"); }
            if (CommunicationEntryId == null) { throw new System.ArgumentNullException("CommunicationEntryId cannot be null"); }
            if (CommunicationEntry == null) { throw new System.ArgumentNullException("CommunicationEntry cannot be null"); }
            StringBuilder PatchCommunicationEntryServiceURL = new StringBuilder("/infra/domains/{domain-id}/communication-maps/{communication-map-id}/communication-entries/{communication-entry-id}");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Patch
            };
            PatchCommunicationEntryServiceURL.Replace("{domain-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(DomainId, System.Globalization.CultureInfo.InvariantCulture)));
            PatchCommunicationEntryServiceURL.Replace("{communication-map-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(CommunicationMapId, System.Globalization.CultureInfo.InvariantCulture)));
            PatchCommunicationEntryServiceURL.Replace("{communication-entry-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(CommunicationEntryId, System.Globalization.CultureInfo.InvariantCulture)));
            request.AddJsonBody(CommunicationEntry);
            request.Resource = PatchCommunicationEntryServiceURL.ToString();
            RestResponse response = await restClient.ExecuteTaskAsyncWithPolicy(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Patch operation to " + PatchCommunicationEntryServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            
        }
    }
}
