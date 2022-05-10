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
    public class ServiceConfig
    {
        private RestClient restClient;
        private int retry;
        private int timeout;
        private CancellationToken cancellationToken;

        public ServiceConfig(RestClient Client, CancellationToken _cancellationToken, int _timeout, int _retry)
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
        public async Task<NSXTEffectiveProfileListResultType> EffectiveProfiles(string ResourceId, string ResourceType, string? Cursor = null, string? IncludedFields = null, long? PageSize = null, string? ProfileType = null, bool? SortAscending = null, string? SortBy = null)
        {
            if (ResourceId == null) { throw new System.ArgumentNullException("ResourceId cannot be null"); }
            if (ResourceType == null) { throw new System.ArgumentNullException("ResourceType cannot be null"); }
            StringBuilder EffectiveProfilesServiceURL = new StringBuilder("/service-configs/effective-profiles");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Get
            };
            if (Cursor != null) { request.AddQueryParameter("cursor", Cursor.ToString()); }
            if (IncludedFields != null) { request.AddQueryParameter("included_fields", IncludedFields.ToString()); }
            if (PageSize != null) { request.AddQueryParameter("page_size", PageSize.ToString()); }
            if (ProfileType != null) { request.AddQueryParameter("profile_type", ProfileType.ToString()); }
            if (ResourceId != null) { request.AddQueryParameter("resource_id", ResourceId.ToString()); }
            if (ResourceType != null) { request.AddQueryParameter("resource_type", ResourceType.ToString()); }
            if (SortAscending != null) { request.AddQueryParameter("sort_ascending", SortAscending.ToString()); }
            if (SortBy != null) { request.AddQueryParameter("sort_by", SortBy.ToString()); }
            request.Resource = EffectiveProfilesServiceURL.ToString();
            RestResponse<NSXTEffectiveProfileListResultType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTEffectiveProfileListResultType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Get operation to " + EffectiveProfilesServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTServiceConfigListResultType> ServiceConfigBatchOperation(NSXTServiceConfigListType ServiceConfigList)
        {
            if (ServiceConfigList == null) { throw new System.ArgumentNullException("ServiceConfigList cannot be null"); }
            StringBuilder ServiceConfigBatchOperationServiceURL = new StringBuilder("/service-configs/batch");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Post
            };
            request.AddJsonBody(ServiceConfigList);
            request.Resource = ServiceConfigBatchOperationServiceURL.ToString();
            RestResponse<NSXTServiceConfigListResultType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTServiceConfigListResultType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Post operation to " + ServiceConfigBatchOperationServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTServiceConfigType> CreateServiceConfig(NSXTServiceConfigType ServiceConfig)
        {
            if (ServiceConfig == null) { throw new System.ArgumentNullException("ServiceConfig cannot be null"); }
            StringBuilder CreateServiceConfigServiceURL = new StringBuilder("/service-configs");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Post
            };
            request.AddJsonBody(ServiceConfig);
            request.Resource = CreateServiceConfigServiceURL.ToString();
            RestResponse<NSXTServiceConfigType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTServiceConfigType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Post operation to " + CreateServiceConfigServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTServiceConfigListResultType> ListServiceConfigs(string? Cursor = null, string? IncludedFields = null, long? PageSize = null, string? ProfileType = null, bool? SortAscending = null, string? SortBy = null)
        {
            StringBuilder ListServiceConfigsServiceURL = new StringBuilder("/service-configs");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Get
            };
            if (Cursor != null) { request.AddQueryParameter("cursor", Cursor.ToString()); }
            if (IncludedFields != null) { request.AddQueryParameter("included_fields", IncludedFields.ToString()); }
            if (PageSize != null) { request.AddQueryParameter("page_size", PageSize.ToString()); }
            if (ProfileType != null) { request.AddQueryParameter("profile_type", ProfileType.ToString()); }
            if (SortAscending != null) { request.AddQueryParameter("sort_ascending", SortAscending.ToString()); }
            if (SortBy != null) { request.AddQueryParameter("sort_by", SortBy.ToString()); }
            request.Resource = ListServiceConfigsServiceURL.ToString();
            RestResponse<NSXTServiceConfigListResultType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTServiceConfigListResultType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Get operation to " + ListServiceConfigsServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTServiceConfigType> UpdateServiceConfig(string ConfigSetId, NSXTServiceConfigType ServiceConfig)
        {
            if (ConfigSetId == null) { throw new System.ArgumentNullException("ConfigSetId cannot be null"); }
            if (ServiceConfig == null) { throw new System.ArgumentNullException("ServiceConfig cannot be null"); }
            StringBuilder UpdateServiceConfigServiceURL = new StringBuilder("/service-configs/{config-set-id}");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Put
            };
            UpdateServiceConfigServiceURL.Replace("{config-set-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(ConfigSetId, System.Globalization.CultureInfo.InvariantCulture)));
            request.AddJsonBody(ServiceConfig);
            request.Resource = UpdateServiceConfigServiceURL.ToString();
            RestResponse<NSXTServiceConfigType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTServiceConfigType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Put operation to " + UpdateServiceConfigServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTServiceConfigType> ReadServiceConfig(string ConfigSetId)
        {
            if (ConfigSetId == null) { throw new System.ArgumentNullException("ConfigSetId cannot be null"); }
            StringBuilder ReadServiceConfigServiceURL = new StringBuilder("/service-configs/{config-set-id}");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Get
            };
            ReadServiceConfigServiceURL.Replace("{config-set-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(ConfigSetId, System.Globalization.CultureInfo.InvariantCulture)));
            request.Resource = ReadServiceConfigServiceURL.ToString();
            RestResponse<NSXTServiceConfigType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTServiceConfigType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Get operation to " + ReadServiceConfigServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task DeleteServiceConfig(string ConfigSetId)
        {
            if (ConfigSetId == null) { throw new System.ArgumentNullException("ConfigSetId cannot be null"); }
            StringBuilder DeleteServiceConfigServiceURL = new StringBuilder("/service-configs/{config-set-id}");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Delete
            };
            DeleteServiceConfigServiceURL.Replace("{config-set-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(ConfigSetId, System.Globalization.CultureInfo.InvariantCulture)));
            request.Resource = DeleteServiceConfigServiceURL.ToString();
            RestResponse response = await restClient.ExecuteTaskAsyncWithPolicy(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Delete operation to " + DeleteServiceConfigServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            
        }
    }
}
