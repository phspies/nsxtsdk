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
    public class Latency
    {
        private RestClient restClient;
        private int retry;
        private int timeout;
        private CancellationToken cancellationToken;

        public Latency(RestClient Client, CancellationToken _cancellationToken, int _timeout, int _retry)
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
        public async Task<NSXTLatencyStatProfileType> CreateLatencyStatProfile(NSXTLatencyStatProfileType LatencyStatProfile)
        {
            if (LatencyStatProfile == null) { throw new System.ArgumentNullException("LatencyStatProfile cannot be null"); }
            StringBuilder CreateLatencyStatProfileServiceURL = new StringBuilder("/latency-profiles");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Post
            };
            request.AddJsonBody(LatencyStatProfile);
            request.Resource = CreateLatencyStatProfileServiceURL.ToString();
            RestResponse<NSXTLatencyStatProfileType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTLatencyStatProfileType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Post operation to " + CreateLatencyStatProfileServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTLatencyStatProfileListResultType> ListLatencyProfiles(string? Cursor = null, string? IncludedFields = null, long? PageSize = null, bool? SortAscending = null, string? SortBy = null)
        {
            StringBuilder ListLatencyProfilesServiceURL = new StringBuilder("/latency-profiles");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Get
            };
            if (Cursor != null) { request.AddQueryParameter("cursor", Cursor.ToString()); }
            if (IncludedFields != null) { request.AddQueryParameter("included_fields", IncludedFields.ToString()); }
            if (PageSize != null) { request.AddQueryParameter("page_size", PageSize.ToString()); }
            if (SortAscending != null) { request.AddQueryParameter("sort_ascending", SortAscending.ToString()); }
            if (SortBy != null) { request.AddQueryParameter("sort_by", SortBy.ToString()); }
            request.Resource = ListLatencyProfilesServiceURL.ToString();
            RestResponse<NSXTLatencyStatProfileListResultType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTLatencyStatProfileListResultType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Get operation to " + ListLatencyProfilesServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTLatencyStatProfileType> UpdateLatencyProfile(string LatencyProfileId, NSXTLatencyStatProfileType LatencyStatProfile)
        {
            if (LatencyProfileId == null) { throw new System.ArgumentNullException("LatencyProfileId cannot be null"); }
            if (LatencyStatProfile == null) { throw new System.ArgumentNullException("LatencyStatProfile cannot be null"); }
            StringBuilder UpdateLatencyProfileServiceURL = new StringBuilder("/latency-profiles/{latency-profile-id}");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Put
            };
            UpdateLatencyProfileServiceURL.Replace("{latency-profile-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(LatencyProfileId, System.Globalization.CultureInfo.InvariantCulture)));
            request.AddJsonBody(LatencyStatProfile);
            request.Resource = UpdateLatencyProfileServiceURL.ToString();
            RestResponse<NSXTLatencyStatProfileType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTLatencyStatProfileType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Put operation to " + UpdateLatencyProfileServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task DeleteLatencyStatProfile(string LatencyProfileId)
        {
            if (LatencyProfileId == null) { throw new System.ArgumentNullException("LatencyProfileId cannot be null"); }
            StringBuilder DeleteLatencyStatProfileServiceURL = new StringBuilder("/latency-profiles/{latency-profile-id}");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Delete
            };
            DeleteLatencyStatProfileServiceURL.Replace("{latency-profile-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(LatencyProfileId, System.Globalization.CultureInfo.InvariantCulture)));
            request.Resource = DeleteLatencyStatProfileServiceURL.ToString();
            RestResponse response = await restClient.ExecuteTaskAsyncWithPolicy(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Delete operation to " + DeleteLatencyStatProfileServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTLatencyStatProfileType> ReadLatencyStatProfile(string LatencyProfileId)
        {
            if (LatencyProfileId == null) { throw new System.ArgumentNullException("LatencyProfileId cannot be null"); }
            StringBuilder ReadLatencyStatProfileServiceURL = new StringBuilder("/latency-profiles/{latency-profile-id}");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Get
            };
            ReadLatencyStatProfileServiceURL.Replace("{latency-profile-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(LatencyProfileId, System.Globalization.CultureInfo.InvariantCulture)));
            request.Resource = ReadLatencyStatProfileServiceURL.ToString();
            RestResponse<NSXTLatencyStatProfileType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTLatencyStatProfileType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Get operation to " + ReadLatencyStatProfileServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
    }
}
