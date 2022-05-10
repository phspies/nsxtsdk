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
    public class InventoryCloudObj
    {
        private RestClient restClient;
        private int retry;
        private int timeout;
        private CancellationToken cancellationToken;

        public InventoryCloudObj(RestClient Client, CancellationToken _cancellationToken, int _timeout, int _retry)
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
        public async Task<NSXTCloudNativeServiceInstanceType> GetCloudNativeServiceInstance(string ExternalId)
        {
            if (ExternalId == null) { throw new System.ArgumentNullException("ExternalId cannot be null"); }
            StringBuilder GetCloudNativeServiceInstanceServiceURL = new StringBuilder("/fabric/cloud-native-service-instances/{external-id}");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Get
            };
            GetCloudNativeServiceInstanceServiceURL.Replace("{external-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(ExternalId, System.Globalization.CultureInfo.InvariantCulture)));
            request.Resource = GetCloudNativeServiceInstanceServiceURL.ToString();
            RestResponse<NSXTCloudNativeServiceInstanceType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTCloudNativeServiceInstanceType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Get operation to " + GetCloudNativeServiceInstanceServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTCloudNativeServiceInstanceListResultType> ListAllCloudNativeServiceInstances(string? Cursor = null, string? DisplayName = null, string? IncludedFields = null, long? PageSize = null, string? ServiceType = null, bool? SortAscending = null, string? SortBy = null, string? Source = null)
        {
            StringBuilder ListAllCloudNativeServiceInstancesServiceURL = new StringBuilder("/fabric/cloud-native-service-instances");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Get
            };
            if (Cursor != null) { request.AddQueryParameter("cursor", Cursor.ToString()); }
            if (DisplayName != null) { request.AddQueryParameter("display_name", DisplayName.ToString()); }
            if (IncludedFields != null) { request.AddQueryParameter("included_fields", IncludedFields.ToString()); }
            if (PageSize != null) { request.AddQueryParameter("page_size", PageSize.ToString()); }
            if (ServiceType != null) { request.AddQueryParameter("service_type", ServiceType.ToString()); }
            if (SortAscending != null) { request.AddQueryParameter("sort_ascending", SortAscending.ToString()); }
            if (SortBy != null) { request.AddQueryParameter("sort_by", SortBy.ToString()); }
            if (Source != null) { request.AddQueryParameter("source", Source.ToString()); }
            request.Resource = ListAllCloudNativeServiceInstancesServiceURL.ToString();
            RestResponse<NSXTCloudNativeServiceInstanceListResultType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTCloudNativeServiceInstanceListResultType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Get operation to " + ListAllCloudNativeServiceInstancesServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
    }
}
