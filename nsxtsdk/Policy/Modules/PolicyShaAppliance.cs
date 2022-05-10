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
    public class PolicyShaAppliance
    {
        private RestClient restClient;
        private int retry;
        private int timeout;
        private CancellationToken cancellationToken;

        public PolicyShaAppliance(RestClient Client, CancellationToken _cancellationToken, int _timeout, int _retry)
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
        public async Task<NSXTApplianceLatencyListResultType> GetAllApplianceLatencyData(string? Cursor = null, string? IncludedFields = null, long? PageSize = null, bool? SortAscending = null, string? SortBy = null)
        {
            StringBuilder GetAllApplianceLatencyDataServiceURL = new StringBuilder("/infra/sha/appliances/latency/status");
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
            request.Resource = GetAllApplianceLatencyDataServiceURL.ToString();
            RestResponse<NSXTApplianceLatencyListResultType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTApplianceLatencyListResultType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Get operation to " + GetAllApplianceLatencyDataServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTApplianceProcessDataType> GetProcessDataForAppliance(string ApplianceId)
        {
            if (ApplianceId == null) { throw new System.ArgumentNullException("ApplianceId cannot be null"); }
            StringBuilder GetProcessDataForApplianceServiceURL = new StringBuilder("/infra/sha/appliances/{appliance-id}/process/status");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Get
            };
            GetProcessDataForApplianceServiceURL.Replace("{appliance-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(ApplianceId, System.Globalization.CultureInfo.InvariantCulture)));
            request.Resource = GetProcessDataForApplianceServiceURL.ToString();
            RestResponse<NSXTApplianceProcessDataType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTApplianceProcessDataType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Get operation to " + GetProcessDataForApplianceServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTApplianceProcessListResultType> GetProcessDataForAllAppliance(string? Cursor = null, string? IncludedFields = null, long? PageSize = null, bool? SortAscending = null, string? SortBy = null)
        {
            StringBuilder GetProcessDataForAllApplianceServiceURL = new StringBuilder("/infra/sha/appliances/process/status");
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
            request.Resource = GetProcessDataForAllApplianceServiceURL.ToString();
            RestResponse<NSXTApplianceProcessListResultType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTApplianceProcessListResultType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Get operation to " + GetProcessDataForAllApplianceServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTApplianceLatencyDataType> GetApplianceLatencyData(string ApplianceId)
        {
            if (ApplianceId == null) { throw new System.ArgumentNullException("ApplianceId cannot be null"); }
            StringBuilder GetApplianceLatencyDataServiceURL = new StringBuilder("/infra/sha/appliances/{appliance-id}/latency/status");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Get
            };
            GetApplianceLatencyDataServiceURL.Replace("{appliance-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(ApplianceId, System.Globalization.CultureInfo.InvariantCulture)));
            request.Resource = GetApplianceLatencyDataServiceURL.ToString();
            RestResponse<NSXTApplianceLatencyDataType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTApplianceLatencyDataType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Get operation to " + GetApplianceLatencyDataServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
    }
}
