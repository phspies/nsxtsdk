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
    public class MetadataProxy
    {
        private RestClient restClient;
        private int retry;
        private int timeout;
        private CancellationToken cancellationToken;

        public MetadataProxy(RestClient Client, CancellationToken _cancellationToken, int _timeout, int _retry)
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
        public async Task<NSXTMetadataProxyType> UpdateMetadataProxy(string ProxyId, NSXTMetadataProxyType MetadataProxy)
        {
            if (ProxyId == null) { throw new System.ArgumentNullException("ProxyId cannot be null"); }
            if (MetadataProxy == null) { throw new System.ArgumentNullException("MetadataProxy cannot be null"); }
            StringBuilder UpdateMetadataProxyServiceURL = new StringBuilder("/md-proxies/{proxy-id}");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Put
            };
            UpdateMetadataProxyServiceURL.Replace("{proxy-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(ProxyId, System.Globalization.CultureInfo.InvariantCulture)));
            request.AddJsonBody(MetadataProxy);
            request.Resource = UpdateMetadataProxyServiceURL.ToString();
            RestResponse<NSXTMetadataProxyType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTMetadataProxyType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Put operation to " + UpdateMetadataProxyServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTMetadataProxyType> ReadMetadataProxy(string ProxyId)
        {
            if (ProxyId == null) { throw new System.ArgumentNullException("ProxyId cannot be null"); }
            StringBuilder ReadMetadataProxyServiceURL = new StringBuilder("/md-proxies/{proxy-id}");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Get
            };
            ReadMetadataProxyServiceURL.Replace("{proxy-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(ProxyId, System.Globalization.CultureInfo.InvariantCulture)));
            request.Resource = ReadMetadataProxyServiceURL.ToString();
            RestResponse<NSXTMetadataProxyType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTMetadataProxyType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Get operation to " + ReadMetadataProxyServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task DeleteMetadataProxy(string ProxyId)
        {
            if (ProxyId == null) { throw new System.ArgumentNullException("ProxyId cannot be null"); }
            StringBuilder DeleteMetadataProxyServiceURL = new StringBuilder("/md-proxies/{proxy-id}");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Delete
            };
            DeleteMetadataProxyServiceURL.Replace("{proxy-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(ProxyId, System.Globalization.CultureInfo.InvariantCulture)));
            request.Resource = DeleteMetadataProxyServiceURL.ToString();
            RestResponse response = await restClient.ExecuteTaskAsyncWithPolicy(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Delete operation to " + DeleteMetadataProxyServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTMetadataProxyType> CreateMetadataProxy(NSXTMetadataProxyType MetadataProxy)
        {
            if (MetadataProxy == null) { throw new System.ArgumentNullException("MetadataProxy cannot be null"); }
            StringBuilder CreateMetadataProxyServiceURL = new StringBuilder("/md-proxies");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Post
            };
            request.AddJsonBody(MetadataProxy);
            request.Resource = CreateMetadataProxyServiceURL.ToString();
            RestResponse<NSXTMetadataProxyType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTMetadataProxyType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Post operation to " + CreateMetadataProxyServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTMetadataProxyListResultType> ListMetadataProxy(string? Cursor = null, string? IncludedFields = null, long? PageSize = null, bool? SortAscending = null, string? SortBy = null)
        {
            StringBuilder ListMetadataProxyServiceURL = new StringBuilder("/md-proxies");
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
            request.Resource = ListMetadataProxyServiceURL.ToString();
            RestResponse<NSXTMetadataProxyListResultType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTMetadataProxyListResultType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Get operation to " + ListMetadataProxyServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
    }
}
