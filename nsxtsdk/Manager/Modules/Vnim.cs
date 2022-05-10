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
    public class Vnim
    {
        private RestClient restClient;
        private int retry;
        private int timeout;
        private CancellationToken cancellationToken;

        public Vnim(RestClient Client, CancellationToken _cancellationToken, int _timeout, int _retry)
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
        public async Task<NSXTVniPoolType> CreateVnipool(NSXTVniPoolType VniPool)
        {
            if (VniPool == null) { throw new System.ArgumentNullException("VniPool cannot be null"); }
            StringBuilder CreateVnipoolServiceURL = new StringBuilder("/pools/vni-pools");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Post
            };
            request.AddJsonBody(VniPool);
            request.Resource = CreateVnipoolServiceURL.ToString();
            RestResponse<NSXTVniPoolType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTVniPoolType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Post operation to " + CreateVnipoolServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTVniPoolListResultType> ListVnipools(string? Cursor = null, string? IncludedFields = null, long? PageSize = null, bool? SortAscending = null, string? SortBy = null)
        {
            StringBuilder ListVnipoolsServiceURL = new StringBuilder("/pools/vni-pools");
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
            request.Resource = ListVnipoolsServiceURL.ToString();
            RestResponse<NSXTVniPoolListResultType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTVniPoolListResultType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Get operation to " + ListVnipoolsServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTVniPoolType> UpdateVnipool(string PoolId, NSXTVniPoolType VniPool)
        {
            if (PoolId == null) { throw new System.ArgumentNullException("PoolId cannot be null"); }
            if (VniPool == null) { throw new System.ArgumentNullException("VniPool cannot be null"); }
            StringBuilder UpdateVnipoolServiceURL = new StringBuilder("/pools/vni-pools/{pool-id}");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Put
            };
            UpdateVnipoolServiceURL.Replace("{pool-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(PoolId, System.Globalization.CultureInfo.InvariantCulture)));
            request.AddJsonBody(VniPool);
            request.Resource = UpdateVnipoolServiceURL.ToString();
            RestResponse<NSXTVniPoolType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTVniPoolType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Put operation to " + UpdateVnipoolServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTVniPoolType> ReadVnipool(string PoolId)
        {
            if (PoolId == null) { throw new System.ArgumentNullException("PoolId cannot be null"); }
            StringBuilder ReadVnipoolServiceURL = new StringBuilder("/pools/vni-pools/{pool-id}");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Get
            };
            ReadVnipoolServiceURL.Replace("{pool-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(PoolId, System.Globalization.CultureInfo.InvariantCulture)));
            request.Resource = ReadVnipoolServiceURL.ToString();
            RestResponse<NSXTVniPoolType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTVniPoolType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Get operation to " + ReadVnipoolServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task DeleteVnipool(string PoolId, bool? Force = null)
        {
            if (PoolId == null) { throw new System.ArgumentNullException("PoolId cannot be null"); }
            StringBuilder DeleteVnipoolServiceURL = new StringBuilder("/pools/vni-pools/{pool-id}");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Delete
            };
            DeleteVnipoolServiceURL.Replace("{pool-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(PoolId, System.Globalization.CultureInfo.InvariantCulture)));
            if (Force != null) { request.AddQueryParameter("force", Force.ToString()); }
            request.Resource = DeleteVnipoolServiceURL.ToString();
            RestResponse response = await restClient.ExecuteTaskAsyncWithPolicy(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Delete operation to " + DeleteVnipoolServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            
        }
    }
}
