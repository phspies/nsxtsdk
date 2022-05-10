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
    public class NSProfile
    {
        private RestClient restClient;
        private int retry;
        private int timeout;
        private CancellationToken cancellationToken;

        public NSProfile(RestClient Client, CancellationToken _cancellationToken, int _timeout, int _retry)
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
        public async Task<NSXTNSSupportedAttributeTypesResultType> ListNssupportedAttributesTypes()
        {
            StringBuilder ListNssupportedAttributesTypesServiceURL = new StringBuilder("/ns-profiles/attribute-types");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Get
            };
            request.Resource = ListNssupportedAttributesTypesServiceURL.ToString();
            RestResponse<NSXTNSSupportedAttributeTypesResultType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTNSSupportedAttributeTypesResultType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Get operation to " + ListNssupportedAttributesTypesServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTNSProfileType> CreateNsprofile(NSXTNSProfileType Nsprofile)
        {
            if (Nsprofile == null) { throw new System.ArgumentNullException("Nsprofile cannot be null"); }
            StringBuilder CreateNsprofileServiceURL = new StringBuilder("/ns-profiles");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Post
            };
            request.AddJsonBody(Nsprofile);
            request.Resource = CreateNsprofileServiceURL.ToString();
            RestResponse<NSXTNSProfileType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTNSProfileType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Post operation to " + CreateNsprofileServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTNSProfileListResultType> ListNsprofiles(string? AttributeType = null, string? Cursor = null, string? IncludedFields = null, long? PageSize = null, bool? SortAscending = null, string? SortBy = null)
        {
            StringBuilder ListNsprofilesServiceURL = new StringBuilder("/ns-profiles");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Get
            };
            if (AttributeType != null) { request.AddQueryParameter("attribute_type", AttributeType.ToString()); }
            if (Cursor != null) { request.AddQueryParameter("cursor", Cursor.ToString()); }
            if (IncludedFields != null) { request.AddQueryParameter("included_fields", IncludedFields.ToString()); }
            if (PageSize != null) { request.AddQueryParameter("page_size", PageSize.ToString()); }
            if (SortAscending != null) { request.AddQueryParameter("sort_ascending", SortAscending.ToString()); }
            if (SortBy != null) { request.AddQueryParameter("sort_by", SortBy.ToString()); }
            request.Resource = ListNsprofilesServiceURL.ToString();
            RestResponse<NSXTNSProfileListResultType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTNSProfileListResultType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Get operation to " + ListNsprofilesServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTNSProfileType> UpdateNsprofile(string NsProfileId, NSXTNSProfileType Nsprofile)
        {
            if (NsProfileId == null) { throw new System.ArgumentNullException("NsProfileId cannot be null"); }
            if (Nsprofile == null) { throw new System.ArgumentNullException("Nsprofile cannot be null"); }
            StringBuilder UpdateNsprofileServiceURL = new StringBuilder("/ns-profiles/{ns-profile-id}");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Put
            };
            UpdateNsprofileServiceURL.Replace("{ns-profile-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(NsProfileId, System.Globalization.CultureInfo.InvariantCulture)));
            request.AddJsonBody(Nsprofile);
            request.Resource = UpdateNsprofileServiceURL.ToString();
            RestResponse<NSXTNSProfileType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTNSProfileType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Put operation to " + UpdateNsprofileServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task DeleteNsprofile(string NsProfileId, bool? Force = null)
        {
            if (NsProfileId == null) { throw new System.ArgumentNullException("NsProfileId cannot be null"); }
            StringBuilder DeleteNsprofileServiceURL = new StringBuilder("/ns-profiles/{ns-profile-id}");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Delete
            };
            DeleteNsprofileServiceURL.Replace("{ns-profile-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(NsProfileId, System.Globalization.CultureInfo.InvariantCulture)));
            if (Force != null) { request.AddQueryParameter("force", Force.ToString()); }
            request.Resource = DeleteNsprofileServiceURL.ToString();
            RestResponse response = await restClient.ExecuteTaskAsyncWithPolicy(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Delete operation to " + DeleteNsprofileServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTNSProfileType> ReadNsprofile(string NsProfileId)
        {
            if (NsProfileId == null) { throw new System.ArgumentNullException("NsProfileId cannot be null"); }
            StringBuilder ReadNsprofileServiceURL = new StringBuilder("/ns-profiles/{ns-profile-id}");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Get
            };
            ReadNsprofileServiceURL.Replace("{ns-profile-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(NsProfileId, System.Globalization.CultureInfo.InvariantCulture)));
            request.Resource = ReadNsprofileServiceURL.ToString();
            RestResponse<NSXTNSProfileType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTNSProfileType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Get operation to " + ReadNsprofileServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTNSSupportedAttributesListResultType> ListNssupportedAttributes(string? AttributeSource = null, string? AttributeType = null, string? Cursor = null, string? IncludedFields = null, long? PageSize = null, bool? SortAscending = null, string? SortBy = null)
        {
            StringBuilder ListNssupportedAttributesServiceURL = new StringBuilder("/ns-profiles/attributes");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Get
            };
            if (AttributeSource != null) { request.AddQueryParameter("attribute_source", AttributeSource.ToString()); }
            if (AttributeType != null) { request.AddQueryParameter("attribute_type", AttributeType.ToString()); }
            if (Cursor != null) { request.AddQueryParameter("cursor", Cursor.ToString()); }
            if (IncludedFields != null) { request.AddQueryParameter("included_fields", IncludedFields.ToString()); }
            if (PageSize != null) { request.AddQueryParameter("page_size", PageSize.ToString()); }
            if (SortAscending != null) { request.AddQueryParameter("sort_ascending", SortAscending.ToString()); }
            if (SortBy != null) { request.AddQueryParameter("sort_by", SortBy.ToString()); }
            request.Resource = ListNssupportedAttributesServiceURL.ToString();
            RestResponse<NSXTNSSupportedAttributesListResultType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTNSSupportedAttributesListResultType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Get operation to " + ListNssupportedAttributesServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
    }
}
