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
    public class ShaApplianceMonitor
    {
        private RestClient restClient;
        private int retry;
        private int timeout;
        private CancellationToken cancellationToken;

        public ShaApplianceMonitor(RestClient Client, CancellationToken _cancellationToken, int _timeout, int _retry)
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
        public async Task<NSXTApplianceLatencyListResultType> ShowAllApplianceLatencyData(string? Cursor = null, string? IncludedFields = null, long? PageSize = null, bool? SortAscending = null, string? SortBy = null)
        {
            StringBuilder ShowAllApplianceLatencyDataServiceURL = new StringBuilder("/systemhealth/appliances/latency/status");
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
            request.Resource = ShowAllApplianceLatencyDataServiceURL.ToString();
            RestResponse<NSXTApplianceLatencyListResultType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTApplianceLatencyListResultType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Get operation to " + ShowAllApplianceLatencyDataServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTApplianceLatencyDataType> ShowApplianceLatencyData(string ApplianceId)
        {
            if (ApplianceId == null) { throw new System.ArgumentNullException("ApplianceId cannot be null"); }
            StringBuilder ShowApplianceLatencyDataServiceURL = new StringBuilder("/systemhealth/appliances/{appliance-id}/latency/status");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Get
            };
            ShowApplianceLatencyDataServiceURL.Replace("{appliance-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(ApplianceId, System.Globalization.CultureInfo.InvariantCulture)));
            request.Resource = ShowApplianceLatencyDataServiceURL.ToString();
            RestResponse<NSXTApplianceLatencyDataType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTApplianceLatencyDataType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Get operation to " + ShowApplianceLatencyDataServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTApplianceProcessListResultType> ShowAllapplianceProcessData(string? Cursor = null, string? IncludedFields = null, long? PageSize = null, bool? SortAscending = null, string? SortBy = null)
        {
            StringBuilder ShowAllapplianceProcessDataServiceURL = new StringBuilder("/systemhealth/appliances/process/status");
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
            request.Resource = ShowAllapplianceProcessDataServiceURL.ToString();
            RestResponse<NSXTApplianceProcessListResultType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTApplianceProcessListResultType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Get operation to " + ShowAllapplianceProcessDataServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTApplianceProcessDataType> ShowApplianceProcessData(string ApplianceId)
        {
            if (ApplianceId == null) { throw new System.ArgumentNullException("ApplianceId cannot be null"); }
            StringBuilder ShowApplianceProcessDataServiceURL = new StringBuilder("/systemhealth/appliances/{appliance-id}/process/status");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Get
            };
            ShowApplianceProcessDataServiceURL.Replace("{appliance-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(ApplianceId, System.Globalization.CultureInfo.InvariantCulture)));
            request.Resource = ShowApplianceProcessDataServiceURL.ToString();
            RestResponse<NSXTApplianceProcessDataType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTApplianceProcessDataType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Get operation to " + ShowApplianceProcessDataServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
    }
}
