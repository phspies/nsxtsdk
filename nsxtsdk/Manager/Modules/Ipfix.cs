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
    public class Ipfix
    {
        private RestClient restClient;
        private int retry;
        private int timeout;
        private CancellationToken cancellationToken;

        public Ipfix(RestClient Client, CancellationToken _cancellationToken, int _timeout, int _retry)
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
        public async Task<NSXTIpfixConfigType> CreateIpfixConfig(NSXTIpfixConfigType IpfixConfig)
        {
            if (IpfixConfig == null) { throw new System.ArgumentNullException("IpfixConfig cannot be null"); }
            StringBuilder CreateIpfixConfigServiceURL = new StringBuilder("/ipfix/configs");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Post
            };
            request.AddJsonBody(IpfixConfig);
            request.Resource = CreateIpfixConfigServiceURL.ToString();
            RestResponse<NSXTIpfixConfigType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTIpfixConfigType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Post operation to " + CreateIpfixConfigServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTIpfixConfigListResultType> ListIpfixConfig(string? AppliedTo = null, string? Cursor = null, string? IncludedFields = null, string? IpfixConfigType = null, long? PageSize = null, bool? SortAscending = null, string? SortBy = null)
        {
            StringBuilder ListIpfixConfigServiceURL = new StringBuilder("/ipfix/configs");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Get
            };
            if (AppliedTo != null) { request.AddQueryParameter("applied_to", AppliedTo.ToString()); }
            if (Cursor != null) { request.AddQueryParameter("cursor", Cursor.ToString()); }
            if (IncludedFields != null) { request.AddQueryParameter("included_fields", IncludedFields.ToString()); }
            if (IpfixConfigType != null) { request.AddQueryParameter("ipfix_config_type", IpfixConfigType.ToString()); }
            if (PageSize != null) { request.AddQueryParameter("page_size", PageSize.ToString()); }
            if (SortAscending != null) { request.AddQueryParameter("sort_ascending", SortAscending.ToString()); }
            if (SortBy != null) { request.AddQueryParameter("sort_by", SortBy.ToString()); }
            request.Resource = ListIpfixConfigServiceURL.ToString();
            RestResponse<NSXTIpfixConfigListResultType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTIpfixConfigListResultType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Get operation to " + ListIpfixConfigServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTIpfixConfigType> UpdateIpfixConfig(string ConfigId, NSXTIpfixConfigType IpfixConfig)
        {
            if (ConfigId == null) { throw new System.ArgumentNullException("ConfigId cannot be null"); }
            if (IpfixConfig == null) { throw new System.ArgumentNullException("IpfixConfig cannot be null"); }
            StringBuilder UpdateIpfixConfigServiceURL = new StringBuilder("/ipfix/configs/{config-id}");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Put
            };
            UpdateIpfixConfigServiceURL.Replace("{config-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(ConfigId, System.Globalization.CultureInfo.InvariantCulture)));
            request.AddJsonBody(IpfixConfig);
            request.Resource = UpdateIpfixConfigServiceURL.ToString();
            RestResponse<NSXTIpfixConfigType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTIpfixConfigType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Put operation to " + UpdateIpfixConfigServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task DeleteIpfixConfig(string ConfigId)
        {
            if (ConfigId == null) { throw new System.ArgumentNullException("ConfigId cannot be null"); }
            StringBuilder DeleteIpfixConfigServiceURL = new StringBuilder("/ipfix/configs/{config-id}");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Delete
            };
            DeleteIpfixConfigServiceURL.Replace("{config-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(ConfigId, System.Globalization.CultureInfo.InvariantCulture)));
            request.Resource = DeleteIpfixConfigServiceURL.ToString();
            RestResponse response = await restClient.ExecuteTaskAsyncWithPolicy(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Delete operation to " + DeleteIpfixConfigServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTIpfixConfigType> GetIpfixConfig(string ConfigId)
        {
            if (ConfigId == null) { throw new System.ArgumentNullException("ConfigId cannot be null"); }
            StringBuilder GetIpfixConfigServiceURL = new StringBuilder("/ipfix/configs/{config-id}");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Get
            };
            GetIpfixConfigServiceURL.Replace("{config-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(ConfigId, System.Globalization.CultureInfo.InvariantCulture)));
            request.Resource = GetIpfixConfigServiceURL.ToString();
            RestResponse<NSXTIpfixConfigType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTIpfixConfigType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Get operation to " + GetIpfixConfigServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTIpfixCollectorConfigType> CreateIpfixCollectorConfig(NSXTIpfixCollectorConfigType IpfixCollectorConfig)
        {
            if (IpfixCollectorConfig == null) { throw new System.ArgumentNullException("IpfixCollectorConfig cannot be null"); }
            StringBuilder CreateIpfixCollectorConfigServiceURL = new StringBuilder("/ipfix/collectorconfigs");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Post
            };
            request.AddJsonBody(IpfixCollectorConfig);
            request.Resource = CreateIpfixCollectorConfigServiceURL.ToString();
            RestResponse<NSXTIpfixCollectorConfigType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTIpfixCollectorConfigType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Post operation to " + CreateIpfixCollectorConfigServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTIpfixCollectorConfigListResultType> ListIpfixCollectorConfig(string? Cursor = null, string? IncludedFields = null, long? PageSize = null, bool? SortAscending = null, string? SortBy = null)
        {
            StringBuilder ListIpfixCollectorConfigServiceURL = new StringBuilder("/ipfix/collectorconfigs");
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
            request.Resource = ListIpfixCollectorConfigServiceURL.ToString();
            RestResponse<NSXTIpfixCollectorConfigListResultType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTIpfixCollectorConfigListResultType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Get operation to " + ListIpfixCollectorConfigServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTIpfixCollectorConfigType> UpdateIpfixCollectorConfig(string CollectorConfigId, NSXTIpfixCollectorConfigType IpfixCollectorConfig)
        {
            if (CollectorConfigId == null) { throw new System.ArgumentNullException("CollectorConfigId cannot be null"); }
            if (IpfixCollectorConfig == null) { throw new System.ArgumentNullException("IpfixCollectorConfig cannot be null"); }
            StringBuilder UpdateIpfixCollectorConfigServiceURL = new StringBuilder("/ipfix/collectorconfigs/{collector-config-id}");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Put
            };
            UpdateIpfixCollectorConfigServiceURL.Replace("{collector-config-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(CollectorConfigId, System.Globalization.CultureInfo.InvariantCulture)));
            request.AddJsonBody(IpfixCollectorConfig);
            request.Resource = UpdateIpfixCollectorConfigServiceURL.ToString();
            RestResponse<NSXTIpfixCollectorConfigType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTIpfixCollectorConfigType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Put operation to " + UpdateIpfixCollectorConfigServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task DeleteIpfixCollectorConfig(string CollectorConfigId)
        {
            if (CollectorConfigId == null) { throw new System.ArgumentNullException("CollectorConfigId cannot be null"); }
            StringBuilder DeleteIpfixCollectorConfigServiceURL = new StringBuilder("/ipfix/collectorconfigs/{collector-config-id}");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Delete
            };
            DeleteIpfixCollectorConfigServiceURL.Replace("{collector-config-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(CollectorConfigId, System.Globalization.CultureInfo.InvariantCulture)));
            request.Resource = DeleteIpfixCollectorConfigServiceURL.ToString();
            RestResponse response = await restClient.ExecuteTaskAsyncWithPolicy(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Delete operation to " + DeleteIpfixCollectorConfigServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTIpfixCollectorConfigType> GetIpfixCollectorConfig(string CollectorConfigId)
        {
            if (CollectorConfigId == null) { throw new System.ArgumentNullException("CollectorConfigId cannot be null"); }
            StringBuilder GetIpfixCollectorConfigServiceURL = new StringBuilder("/ipfix/collectorconfigs/{collector-config-id}");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Get
            };
            GetIpfixCollectorConfigServiceURL.Replace("{collector-config-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(CollectorConfigId, System.Globalization.CultureInfo.InvariantCulture)));
            request.Resource = GetIpfixCollectorConfigServiceURL.ToString();
            RestResponse<NSXTIpfixCollectorConfigType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTIpfixCollectorConfigType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Get operation to " + GetIpfixCollectorConfigServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
    }
}
