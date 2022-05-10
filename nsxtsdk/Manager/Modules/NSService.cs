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
    public class NSService
    {
        private RestClient restClient;
        private int retry;
        private int timeout;
        private CancellationToken cancellationToken;

        public NSService(RestClient Client, CancellationToken _cancellationToken, int _timeout, int _retry)
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
        public async Task<NSXTNSServiceType> UpdateNsservice(string NsServiceId, NSXTNSServiceType Nsservice)
        {
            if (NsServiceId == null) { throw new System.ArgumentNullException("NsServiceId cannot be null"); }
            if (Nsservice == null) { throw new System.ArgumentNullException("Nsservice cannot be null"); }
            StringBuilder UpdateNsserviceServiceURL = new StringBuilder("/ns-services/{ns-service-id}");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Put
            };
            UpdateNsserviceServiceURL.Replace("{ns-service-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(NsServiceId, System.Globalization.CultureInfo.InvariantCulture)));
            request.AddJsonBody(Nsservice);
            request.Resource = UpdateNsserviceServiceURL.ToString();
            RestResponse<NSXTNSServiceType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTNSServiceType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Put operation to " + UpdateNsserviceServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task DeleteNsservice(string NsServiceId, bool? Force = null)
        {
            if (NsServiceId == null) { throw new System.ArgumentNullException("NsServiceId cannot be null"); }
            StringBuilder DeleteNsserviceServiceURL = new StringBuilder("/ns-services/{ns-service-id}");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Delete
            };
            DeleteNsserviceServiceURL.Replace("{ns-service-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(NsServiceId, System.Globalization.CultureInfo.InvariantCulture)));
            if (Force != null) { request.AddQueryParameter("force", Force.ToString()); }
            request.Resource = DeleteNsserviceServiceURL.ToString();
            RestResponse response = await restClient.ExecuteTaskAsyncWithPolicy(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Delete operation to " + DeleteNsserviceServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTNSServiceType> ReadNsservice(string NsServiceId)
        {
            if (NsServiceId == null) { throw new System.ArgumentNullException("NsServiceId cannot be null"); }
            StringBuilder ReadNsserviceServiceURL = new StringBuilder("/ns-services/{ns-service-id}");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Get
            };
            ReadNsserviceServiceURL.Replace("{ns-service-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(NsServiceId, System.Globalization.CultureInfo.InvariantCulture)));
            request.Resource = ReadNsserviceServiceURL.ToString();
            RestResponse<NSXTNSServiceType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTNSServiceType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Get operation to " + ReadNsserviceServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTNSServiceType> CreateNsservice(NSXTNSServiceType Nsservice)
        {
            if (Nsservice == null) { throw new System.ArgumentNullException("Nsservice cannot be null"); }
            StringBuilder CreateNsserviceServiceURL = new StringBuilder("/ns-services");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Post
            };
            request.AddJsonBody(Nsservice);
            request.Resource = CreateNsserviceServiceURL.ToString();
            RestResponse<NSXTNSServiceType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTNSServiceType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Post operation to " + CreateNsserviceServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTNSServiceListResultType> ListNsservices(string? Cursor = null, bool? DefaultService = null, string? IncludedFields = null, long? PageSize = null, bool? SortAscending = null, string? SortBy = null)
        {
            StringBuilder ListNsservicesServiceURL = new StringBuilder("/ns-services");
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
            request.Resource = ListNsservicesServiceURL.ToString();
            RestResponse<NSXTNSServiceListResultType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTNSServiceListResultType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Get operation to " + ListNsservicesServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
    }
}
