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
    public class UpmIpfixCollector
    {
        private RestClient restClient;
        private int retry;
        private int timeout;
        private CancellationToken cancellationToken;

        public UpmIpfixCollector(RestClient Client, CancellationToken _cancellationToken, int _timeout, int _retry)
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
        public async Task<NSXTIpfixCollectorUpmProfileType> UpdateIpfixCollectorUpmProfile(string IpfixCollectorProfileId, NSXTIpfixCollectorUpmProfileType IpfixCollectorUpmProfile)
        {
            if (IpfixCollectorProfileId == null) { throw new System.ArgumentNullException("IpfixCollectorProfileId cannot be null"); }
            if (IpfixCollectorUpmProfile == null) { throw new System.ArgumentNullException("IpfixCollectorUpmProfile cannot be null"); }
            StringBuilder UpdateIpfixCollectorUpmProfileServiceURL = new StringBuilder("/ipfix-collector-profiles/{ipfix-collector-profile-id}");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Put
            };
            UpdateIpfixCollectorUpmProfileServiceURL.Replace("{ipfix-collector-profile-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(IpfixCollectorProfileId, System.Globalization.CultureInfo.InvariantCulture)));
            request.AddJsonBody(IpfixCollectorUpmProfile);
            request.Resource = UpdateIpfixCollectorUpmProfileServiceURL.ToString();
            RestResponse<NSXTIpfixCollectorUpmProfileType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTIpfixCollectorUpmProfileType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Put operation to " + UpdateIpfixCollectorUpmProfileServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTIpfixCollectorUpmProfileType> GetIpfixCollectorUpmProfile(string IpfixCollectorProfileId)
        {
            if (IpfixCollectorProfileId == null) { throw new System.ArgumentNullException("IpfixCollectorProfileId cannot be null"); }
            StringBuilder GetIpfixCollectorUpmProfileServiceURL = new StringBuilder("/ipfix-collector-profiles/{ipfix-collector-profile-id}");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Get
            };
            GetIpfixCollectorUpmProfileServiceURL.Replace("{ipfix-collector-profile-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(IpfixCollectorProfileId, System.Globalization.CultureInfo.InvariantCulture)));
            request.Resource = GetIpfixCollectorUpmProfileServiceURL.ToString();
            RestResponse<NSXTIpfixCollectorUpmProfileType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTIpfixCollectorUpmProfileType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Get operation to " + GetIpfixCollectorUpmProfileServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task DeleteIpfixCollectorUpmProfile(string IpfixCollectorProfileId)
        {
            if (IpfixCollectorProfileId == null) { throw new System.ArgumentNullException("IpfixCollectorProfileId cannot be null"); }
            StringBuilder DeleteIpfixCollectorUpmProfileServiceURL = new StringBuilder("/ipfix-collector-profiles/{ipfix-collector-profile-id}");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Delete
            };
            DeleteIpfixCollectorUpmProfileServiceURL.Replace("{ipfix-collector-profile-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(IpfixCollectorProfileId, System.Globalization.CultureInfo.InvariantCulture)));
            request.Resource = DeleteIpfixCollectorUpmProfileServiceURL.ToString();
            RestResponse response = await restClient.ExecuteTaskAsyncWithPolicy(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Delete operation to " + DeleteIpfixCollectorUpmProfileServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTIpfixCollectorUpmProfileType> CreateIpfixCollectorUpmProfile(NSXTIpfixCollectorUpmProfileType IpfixCollectorUpmProfile)
        {
            if (IpfixCollectorUpmProfile == null) { throw new System.ArgumentNullException("IpfixCollectorUpmProfile cannot be null"); }
            StringBuilder CreateIpfixCollectorUpmProfileServiceURL = new StringBuilder("/ipfix-collector-profiles");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Post
            };
            request.AddJsonBody(IpfixCollectorUpmProfile);
            request.Resource = CreateIpfixCollectorUpmProfileServiceURL.ToString();
            RestResponse<NSXTIpfixCollectorUpmProfileType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTIpfixCollectorUpmProfileType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Post operation to " + CreateIpfixCollectorUpmProfileServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTIpfixCollectorUpmProfileListResultType> ListIpfixCollectorUpmProfiles(string? Cursor = null, string? IncludedFields = null, long? PageSize = null, string? ProfileTypes = null, bool? SortAscending = null, string? SortBy = null)
        {
            StringBuilder ListIpfixCollectorUpmProfilesServiceURL = new StringBuilder("/ipfix-collector-profiles");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Get
            };
            if (Cursor != null) { request.AddQueryParameter("cursor", Cursor.ToString()); }
            if (IncludedFields != null) { request.AddQueryParameter("included_fields", IncludedFields.ToString()); }
            if (PageSize != null) { request.AddQueryParameter("page_size", PageSize.ToString()); }
            if (ProfileTypes != null) { request.AddQueryParameter("profile_types", ProfileTypes.ToString()); }
            if (SortAscending != null) { request.AddQueryParameter("sort_ascending", SortAscending.ToString()); }
            if (SortBy != null) { request.AddQueryParameter("sort_by", SortBy.ToString()); }
            request.Resource = ListIpfixCollectorUpmProfilesServiceURL.ToString();
            RestResponse<NSXTIpfixCollectorUpmProfileListResultType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTIpfixCollectorUpmProfileListResultType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Get operation to " + ListIpfixCollectorUpmProfilesServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
    }
}
