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
    public class NSServiceGroup
    {
        private RestClient restClient;
        private int retry;
        private int timeout;
        private CancellationToken cancellationToken;

        public NSServiceGroup(RestClient Client, CancellationToken _cancellationToken, int _timeout, int _retry)
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
        public async Task<NSXTNSServiceGroupType> CreateNsserviceGroup(NSXTNSServiceGroupType NsserviceGroup)
        {
            if (NsserviceGroup == null) { throw new System.ArgumentNullException("NsserviceGroup cannot be null"); }
            StringBuilder CreateNsserviceGroupServiceURL = new StringBuilder("/ns-service-groups");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Post
            };
            request.AddJsonBody(NsserviceGroup);
            request.Resource = CreateNsserviceGroupServiceURL.ToString();
            RestResponse<NSXTNSServiceGroupType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTNSServiceGroupType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Post operation to " + CreateNsserviceGroupServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTNSServiceGroupListResultType> ListNsserviceGroups(string? Cursor = null, bool? DefaultService = null, string? IncludedFields = null, long? PageSize = null, bool? SortAscending = null, string? SortBy = null)
        {
            StringBuilder ListNsserviceGroupsServiceURL = new StringBuilder("/ns-service-groups");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Get
            };
            if (Cursor != null) { request.AddQueryParameter("cursor", Cursor.ToString()); }
            if (DefaultService != null) { request.AddQueryParameter("default_service", DefaultService.ToString()); }
            if (IncludedFields != null) { request.AddQueryParameter("included_fields", IncludedFields.ToString()); }
            if (PageSize != null) { request.AddQueryParameter("page_size", PageSize.ToString()); }
            if (SortAscending != null) { request.AddQueryParameter("sort_ascending", SortAscending.ToString()); }
            if (SortBy != null) { request.AddQueryParameter("sort_by", SortBy.ToString()); }
            request.Resource = ListNsserviceGroupsServiceURL.ToString();
            RestResponse<NSXTNSServiceGroupListResultType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTNSServiceGroupListResultType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Get operation to " + ListNsserviceGroupsServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTNSServiceGroupType> UpdateNsserviceGroup(string NsServiceGroupId, NSXTNSServiceGroupType NsserviceGroup)
        {
            if (NsServiceGroupId == null) { throw new System.ArgumentNullException("NsServiceGroupId cannot be null"); }
            if (NsserviceGroup == null) { throw new System.ArgumentNullException("NsserviceGroup cannot be null"); }
            StringBuilder UpdateNsserviceGroupServiceURL = new StringBuilder("/ns-service-groups/{ns-service-group-id}");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Put
            };
            UpdateNsserviceGroupServiceURL.Replace("{ns-service-group-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(NsServiceGroupId, System.Globalization.CultureInfo.InvariantCulture)));
            request.AddJsonBody(NsserviceGroup);
            request.Resource = UpdateNsserviceGroupServiceURL.ToString();
            RestResponse<NSXTNSServiceGroupType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTNSServiceGroupType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Put operation to " + UpdateNsserviceGroupServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task DeleteNsserviceGroup(string NsServiceGroupId, bool? Force = null)
        {
            if (NsServiceGroupId == null) { throw new System.ArgumentNullException("NsServiceGroupId cannot be null"); }
            StringBuilder DeleteNsserviceGroupServiceURL = new StringBuilder("/ns-service-groups/{ns-service-group-id}");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Delete
            };
            DeleteNsserviceGroupServiceURL.Replace("{ns-service-group-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(NsServiceGroupId, System.Globalization.CultureInfo.InvariantCulture)));
            if (Force != null) { request.AddQueryParameter("force", Force.ToString()); }
            request.Resource = DeleteNsserviceGroupServiceURL.ToString();
            RestResponse response = await restClient.ExecuteTaskAsyncWithPolicy(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Delete operation to " + DeleteNsserviceGroupServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTNSServiceGroupType> ReadNsserviceGroup(string NsServiceGroupId)
        {
            if (NsServiceGroupId == null) { throw new System.ArgumentNullException("NsServiceGroupId cannot be null"); }
            StringBuilder ReadNsserviceGroupServiceURL = new StringBuilder("/ns-service-groups/{ns-service-group-id}");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Get
            };
            ReadNsserviceGroupServiceURL.Replace("{ns-service-group-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(NsServiceGroupId, System.Globalization.CultureInfo.InvariantCulture)));
            request.Resource = ReadNsserviceGroupServiceURL.ToString();
            RestResponse<NSXTNSServiceGroupType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTNSServiceGroupType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Get operation to " + ReadNsserviceGroupServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
    }
}
