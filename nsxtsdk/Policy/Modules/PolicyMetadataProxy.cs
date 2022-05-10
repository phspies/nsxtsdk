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
using nsxtsdk.PolicyModels;

namespace nsxtapi.PolicyModules
{
    public class PolicyMetadataProxy
    {
        private RestClient restClient;
        private int retry;
        private int timeout;
        private CancellationToken cancellationToken;

        public PolicyMetadataProxy(RestClient Client, CancellationToken _cancellationToken, int _timeout, int _retry)
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
        public async Task<NSXTPolicyMetadataProxyStatusType> ReadMetadataProxyStatus(string MetadataProxyId, string? EnforcementPointPath = null, string? SegmentPath = null, string? Source = null)
        {
            if (MetadataProxyId == null) { throw new System.ArgumentNullException("MetadataProxyId cannot be null"); }
            StringBuilder ReadMetadataProxyStatusServiceURL = new StringBuilder("/infra/metadata-proxies/{metadata-proxy-id}/status");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Get
            };
            ReadMetadataProxyStatusServiceURL.Replace("{metadata-proxy-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(MetadataProxyId, System.Globalization.CultureInfo.InvariantCulture)));
            if (EnforcementPointPath != null) { request.AddQueryParameter("enforcement_point_path", EnforcementPointPath.ToString()); }
            if (SegmentPath != null) { request.AddQueryParameter("segment_path", SegmentPath.ToString()); }
            if (Source != null) { request.AddQueryParameter("source", Source.ToString()); }
            request.Resource = ReadMetadataProxyStatusServiceURL.ToString();
            RestResponse<NSXTPolicyMetadataProxyStatusType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTPolicyMetadataProxyStatusType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Get operation to " + ReadMetadataProxyStatusServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTPolicyMetadataProxyStatisticsType> GlobalGlobalInfraReadMetadataProxyStatistics(string MetadataProxyId, string? EnforcementPointPath = null, string? SegmentPath = null, string? Source = null)
        {
            if (MetadataProxyId == null) { throw new System.ArgumentNullException("MetadataProxyId cannot be null"); }
            StringBuilder GlobalInfraReadMetadataProxyStatisticsServiceURL = new StringBuilder("/global-infra/metadata-proxies/{metadata-proxy-id}/statistics");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Get
            };
            GlobalInfraReadMetadataProxyStatisticsServiceURL.Replace("{metadata-proxy-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(MetadataProxyId, System.Globalization.CultureInfo.InvariantCulture)));
            if (EnforcementPointPath != null) { request.AddQueryParameter("enforcement_point_path", EnforcementPointPath.ToString()); }
            if (SegmentPath != null) { request.AddQueryParameter("segment_path", SegmentPath.ToString()); }
            if (Source != null) { request.AddQueryParameter("source", Source.ToString()); }
            request.Resource = GlobalInfraReadMetadataProxyStatisticsServiceURL.ToString();
            RestResponse<NSXTPolicyMetadataProxyStatisticsType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTPolicyMetadataProxyStatisticsType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Get operation to " + GlobalInfraReadMetadataProxyStatisticsServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTPolicyMetadataProxyStatusType> GlobalGlobalInfraReadMetadataProxyStatus(string MetadataProxyId, string? EnforcementPointPath = null, string? SegmentPath = null, string? Source = null)
        {
            if (MetadataProxyId == null) { throw new System.ArgumentNullException("MetadataProxyId cannot be null"); }
            StringBuilder GlobalInfraReadMetadataProxyStatusServiceURL = new StringBuilder("/global-infra/metadata-proxies/{metadata-proxy-id}/status");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Get
            };
            GlobalInfraReadMetadataProxyStatusServiceURL.Replace("{metadata-proxy-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(MetadataProxyId, System.Globalization.CultureInfo.InvariantCulture)));
            if (EnforcementPointPath != null) { request.AddQueryParameter("enforcement_point_path", EnforcementPointPath.ToString()); }
            if (SegmentPath != null) { request.AddQueryParameter("segment_path", SegmentPath.ToString()); }
            if (Source != null) { request.AddQueryParameter("source", Source.ToString()); }
            request.Resource = GlobalInfraReadMetadataProxyStatusServiceURL.ToString();
            RestResponse<NSXTPolicyMetadataProxyStatusType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTPolicyMetadataProxyStatusType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Get operation to " + GlobalInfraReadMetadataProxyStatusServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTMetadataProxyConfigType> UpdateMetadataProxyConfig(string MetadataProxyId, NSXTMetadataProxyConfigType MetadataProxyConfig)
        {
            if (MetadataProxyId == null) { throw new System.ArgumentNullException("MetadataProxyId cannot be null"); }
            if (MetadataProxyConfig == null) { throw new System.ArgumentNullException("MetadataProxyConfig cannot be null"); }
            StringBuilder UpdateMetadataProxyConfigServiceURL = new StringBuilder("/infra/metadata-proxies/{metadata-proxy-id}");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Put
            };
            UpdateMetadataProxyConfigServiceURL.Replace("{metadata-proxy-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(MetadataProxyId, System.Globalization.CultureInfo.InvariantCulture)));
            request.AddJsonBody(MetadataProxyConfig);
            request.Resource = UpdateMetadataProxyConfigServiceURL.ToString();
            RestResponse<NSXTMetadataProxyConfigType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTMetadataProxyConfigType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Put operation to " + UpdateMetadataProxyConfigServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTMetadataProxyConfigType> ReadMetadataProxyConfig(string MetadataProxyId)
        {
            if (MetadataProxyId == null) { throw new System.ArgumentNullException("MetadataProxyId cannot be null"); }
            StringBuilder ReadMetadataProxyConfigServiceURL = new StringBuilder("/infra/metadata-proxies/{metadata-proxy-id}");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Get
            };
            ReadMetadataProxyConfigServiceURL.Replace("{metadata-proxy-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(MetadataProxyId, System.Globalization.CultureInfo.InvariantCulture)));
            request.Resource = ReadMetadataProxyConfigServiceURL.ToString();
            RestResponse<NSXTMetadataProxyConfigType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTMetadataProxyConfigType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Get operation to " + ReadMetadataProxyConfigServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task DeleteMetadataProxyConfig(string MetadataProxyId)
        {
            if (MetadataProxyId == null) { throw new System.ArgumentNullException("MetadataProxyId cannot be null"); }
            StringBuilder DeleteMetadataProxyConfigServiceURL = new StringBuilder("/infra/metadata-proxies/{metadata-proxy-id}");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Delete
            };
            DeleteMetadataProxyConfigServiceURL.Replace("{metadata-proxy-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(MetadataProxyId, System.Globalization.CultureInfo.InvariantCulture)));
            request.Resource = DeleteMetadataProxyConfigServiceURL.ToString();
            RestResponse response = await restClient.ExecuteTaskAsyncWithPolicy(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Delete operation to " + DeleteMetadataProxyConfigServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task PatchMetadataProxyConfig(string MetadataProxyId, NSXTMetadataProxyConfigType MetadataProxyConfig)
        {
            if (MetadataProxyId == null) { throw new System.ArgumentNullException("MetadataProxyId cannot be null"); }
            if (MetadataProxyConfig == null) { throw new System.ArgumentNullException("MetadataProxyConfig cannot be null"); }
            StringBuilder PatchMetadataProxyConfigServiceURL = new StringBuilder("/infra/metadata-proxies/{metadata-proxy-id}");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Patch
            };
            PatchMetadataProxyConfigServiceURL.Replace("{metadata-proxy-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(MetadataProxyId, System.Globalization.CultureInfo.InvariantCulture)));
            request.AddJsonBody(MetadataProxyConfig);
            request.Resource = PatchMetadataProxyConfigServiceURL.ToString();
            RestResponse response = await restClient.ExecuteTaskAsyncWithPolicy(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Patch operation to " + PatchMetadataProxyConfigServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTPolicyMetadataProxyStatisticsType> ReadMetadataProxyStatistics(string MetadataProxyId, string? EnforcementPointPath = null, string? SegmentPath = null, string? Source = null)
        {
            if (MetadataProxyId == null) { throw new System.ArgumentNullException("MetadataProxyId cannot be null"); }
            StringBuilder ReadMetadataProxyStatisticsServiceURL = new StringBuilder("/infra/metadata-proxies/{metadata-proxy-id}/statistics");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Get
            };
            ReadMetadataProxyStatisticsServiceURL.Replace("{metadata-proxy-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(MetadataProxyId, System.Globalization.CultureInfo.InvariantCulture)));
            if (EnforcementPointPath != null) { request.AddQueryParameter("enforcement_point_path", EnforcementPointPath.ToString()); }
            if (SegmentPath != null) { request.AddQueryParameter("segment_path", SegmentPath.ToString()); }
            if (Source != null) { request.AddQueryParameter("source", Source.ToString()); }
            request.Resource = ReadMetadataProxyStatisticsServiceURL.ToString();
            RestResponse<NSXTPolicyMetadataProxyStatisticsType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTPolicyMetadataProxyStatisticsType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Get operation to " + ReadMetadataProxyStatisticsServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTMetadataProxyConfigListResultType> ListMetadataProxyConfig(string? Cursor = null, bool? IncludeMarkForDeleteObjects = null, string? IncludedFields = null, long? PageSize = null, bool? SortAscending = null, string? SortBy = null)
        {
            StringBuilder ListMetadataProxyConfigServiceURL = new StringBuilder("/infra/metadata-proxies");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Get
            };
            if (Cursor != null) { request.AddQueryParameter("cursor", Cursor.ToString()); }
            if (IncludeMarkForDeleteObjects != null) { request.AddQueryParameter("include_mark_for_delete_objects", IncludeMarkForDeleteObjects.ToString()); }
            if (IncludedFields != null) { request.AddQueryParameter("included_fields", IncludedFields.ToString()); }
            if (PageSize != null) { request.AddQueryParameter("page_size", PageSize.ToString()); }
            if (SortAscending != null) { request.AddQueryParameter("sort_ascending", SortAscending.ToString()); }
            if (SortBy != null) { request.AddQueryParameter("sort_by", SortBy.ToString()); }
            request.Resource = ListMetadataProxyConfigServiceURL.ToString();
            RestResponse<NSXTMetadataProxyConfigListResultType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTMetadataProxyConfigListResultType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Get operation to " + ListMetadataProxyConfigServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
    }
}
