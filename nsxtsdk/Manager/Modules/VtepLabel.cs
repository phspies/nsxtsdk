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
    public class VtepLabel
    {
        private RestClient restClient;
        private int retry;
        private int timeout;
        private CancellationToken cancellationToken;

        public VtepLabel(RestClient Client, CancellationToken _cancellationToken, int _timeout, int _retry)
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
        public async Task<NSXTVtepLabelPoolType> ReadVtepLabelPool(string PoolId)
        {
            if (PoolId == null) { throw new System.ArgumentNullException("PoolId cannot be null"); }
            StringBuilder ReadVtepLabelPoolServiceURL = new StringBuilder("/pools/vtep-label-pools/{pool-id}");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Get
            };
            ReadVtepLabelPoolServiceURL.Replace("{pool-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(PoolId, System.Globalization.CultureInfo.InvariantCulture)));
            request.Resource = ReadVtepLabelPoolServiceURL.ToString();
            RestResponse<NSXTVtepLabelPoolType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTVtepLabelPoolType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Get operation to " + ReadVtepLabelPoolServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTVtepLabelPoolListResultType> ListVtepLabelPools(string? Cursor = null, string? IncludedFields = null, long? PageSize = null, bool? SortAscending = null, string? SortBy = null)
        {
            StringBuilder ListVtepLabelPoolsServiceURL = new StringBuilder("/pools/vtep-label-pools");
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
            request.Resource = ListVtepLabelPoolsServiceURL.ToString();
            RestResponse<NSXTVtepLabelPoolListResultType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTVtepLabelPoolListResultType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Get operation to " + ListVtepLabelPoolsServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
    }
}
