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
    public class TransportZoneProfile
    {
        private RestClient restClient;
        private int retry;
        private int timeout;
        private CancellationToken cancellationToken;

        public TransportZoneProfile(RestClient Client, CancellationToken _cancellationToken, int _timeout, int _retry)
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
        public async Task<NSXTTransportZoneProfileType> CreateTransportZoneProfile(NSXTTransportZoneProfileType TransportZoneProfile)
        {
            if (TransportZoneProfile == null) { throw new System.ArgumentNullException("TransportZoneProfile cannot be null"); }
            StringBuilder CreateTransportZoneProfileServiceURL = new StringBuilder("/transportzone-profiles");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Post
            };
            request.AddJsonBody(TransportZoneProfile);
            request.Resource = CreateTransportZoneProfileServiceURL.ToString();
            RestResponse<NSXTTransportZoneProfileType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTTransportZoneProfileType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Post operation to " + CreateTransportZoneProfileServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTTransportZoneProfileListResultType> ListTransportZoneProfiles(string? Cursor = null, bool? IncludeSystemOwned = null, string? IncludedFields = null, long? PageSize = null, string? ResourceType = null, bool? SortAscending = null, string? SortBy = null)
        {
            StringBuilder ListTransportZoneProfilesServiceURL = new StringBuilder("/transportzone-profiles");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Get
            };
            if (Cursor != null) { request.AddQueryParameter("cursor", Cursor.ToString()); }
            if (IncludeSystemOwned != null) { request.AddQueryParameter("include_system_owned", IncludeSystemOwned.ToString()); }
            if (IncludedFields != null) { request.AddQueryParameter("included_fields", IncludedFields.ToString()); }
            if (PageSize != null) { request.AddQueryParameter("page_size", PageSize.ToString()); }
            if (ResourceType != null) { request.AddQueryParameter("resource_type", ResourceType.ToString()); }
            if (SortAscending != null) { request.AddQueryParameter("sort_ascending", SortAscending.ToString()); }
            if (SortBy != null) { request.AddQueryParameter("sort_by", SortBy.ToString()); }
            request.Resource = ListTransportZoneProfilesServiceURL.ToString();
            RestResponse<NSXTTransportZoneProfileListResultType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTTransportZoneProfileListResultType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Get operation to " + ListTransportZoneProfilesServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTTransportZoneProfileType> UpdateTransportZoneProfile(string TransportzoneProfileId, NSXTTransportZoneProfileType TransportZoneProfile)
        {
            if (TransportzoneProfileId == null) { throw new System.ArgumentNullException("TransportzoneProfileId cannot be null"); }
            if (TransportZoneProfile == null) { throw new System.ArgumentNullException("TransportZoneProfile cannot be null"); }
            StringBuilder UpdateTransportZoneProfileServiceURL = new StringBuilder("/transportzone-profiles/{transportzone-profile-id}");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Put
            };
            UpdateTransportZoneProfileServiceURL.Replace("{transportzone-profile-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(TransportzoneProfileId, System.Globalization.CultureInfo.InvariantCulture)));
            request.AddJsonBody(TransportZoneProfile);
            request.Resource = UpdateTransportZoneProfileServiceURL.ToString();
            RestResponse<NSXTTransportZoneProfileType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTTransportZoneProfileType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Put operation to " + UpdateTransportZoneProfileServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task DeleteTransportZoneProfile(string TransportzoneProfileId)
        {
            if (TransportzoneProfileId == null) { throw new System.ArgumentNullException("TransportzoneProfileId cannot be null"); }
            StringBuilder DeleteTransportZoneProfileServiceURL = new StringBuilder("/transportzone-profiles/{transportzone-profile-id}");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Delete
            };
            DeleteTransportZoneProfileServiceURL.Replace("{transportzone-profile-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(TransportzoneProfileId, System.Globalization.CultureInfo.InvariantCulture)));
            request.Resource = DeleteTransportZoneProfileServiceURL.ToString();
            RestResponse response = await restClient.ExecuteTaskAsyncWithPolicy(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Delete operation to " + DeleteTransportZoneProfileServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTTransportZoneProfileType> GetTransportZoneProfile(string TransportzoneProfileId)
        {
            if (TransportzoneProfileId == null) { throw new System.ArgumentNullException("TransportzoneProfileId cannot be null"); }
            StringBuilder GetTransportZoneProfileServiceURL = new StringBuilder("/transportzone-profiles/{transportzone-profile-id}");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Get
            };
            GetTransportZoneProfileServiceURL.Replace("{transportzone-profile-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(TransportzoneProfileId, System.Globalization.CultureInfo.InvariantCulture)));
            request.Resource = GetTransportZoneProfileServiceURL.ToString();
            RestResponse<NSXTTransportZoneProfileType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTTransportZoneProfileType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Get operation to " + GetTransportZoneProfileServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
    }
}
