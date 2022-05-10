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
    public class HealthCheck
    {
        private RestClient restClient;
        private int retry;
        private int timeout;
        private CancellationToken cancellationToken;

        public HealthCheck(RestClient Client, CancellationToken _cancellationToken, int _timeout, int _retry)
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
        public async Task<NSXTAutomaticHealthCheckListResultType> ListAutomaticHealthChecks(string? Cursor = null, string? IncludedFields = null, long? PageSize = null, bool? SortAscending = null, string? SortBy = null)
        {
            StringBuilder ListAutomaticHealthChecksServiceURL = new StringBuilder("/automatic-health-checks");
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
            request.Resource = ListAutomaticHealthChecksServiceURL.ToString();
            RestResponse<NSXTAutomaticHealthCheckListResultType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTAutomaticHealthCheckListResultType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Get operation to " + ListAutomaticHealthChecksServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTManualHealthCheckType> CreateManualHealthCheck(NSXTManualHealthCheckType ManualHealthCheck)
        {
            if (ManualHealthCheck == null) { throw new System.ArgumentNullException("ManualHealthCheck cannot be null"); }
            StringBuilder CreateManualHealthCheckServiceURL = new StringBuilder("/manual-health-checks");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Post
            };
            request.AddJsonBody(ManualHealthCheck);
            request.Resource = CreateManualHealthCheckServiceURL.ToString();
            RestResponse<NSXTManualHealthCheckType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTManualHealthCheckType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Post operation to " + CreateManualHealthCheckServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTManualHealthCheckListResultType> ListManualHealthChecks(string? Cursor = null, string? IncludedFields = null, long? PageSize = null, bool? SortAscending = null, string? SortBy = null)
        {
            StringBuilder ListManualHealthChecksServiceURL = new StringBuilder("/manual-health-checks");
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
            request.Resource = ListManualHealthChecksServiceURL.ToString();
            RestResponse<NSXTManualHealthCheckListResultType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTManualHealthCheckListResultType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Get operation to " + ListManualHealthChecksServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTAutomaticHealthCheckType> GetAutomaticHealthCheck(string TransportZoneId)
        {
            if (TransportZoneId == null) { throw new System.ArgumentNullException("TransportZoneId cannot be null"); }
            StringBuilder GetAutomaticHealthCheckServiceURL = new StringBuilder("/automatic-health-checks/transport-zones/{transport-zone-id}");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Get
            };
            GetAutomaticHealthCheckServiceURL.Replace("{transport-zone-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(TransportZoneId, System.Globalization.CultureInfo.InvariantCulture)));
            request.Resource = GetAutomaticHealthCheckServiceURL.ToString();
            RestResponse<NSXTAutomaticHealthCheckType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTAutomaticHealthCheckType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Get operation to " + GetAutomaticHealthCheckServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTAutomaticHealthCheckToggleType> UpdateAutomaticHealthCheckToggle(NSXTAutomaticHealthCheckToggleType AutomaticHealthCheckToggle)
        {
            if (AutomaticHealthCheckToggle == null) { throw new System.ArgumentNullException("AutomaticHealthCheckToggle cannot be null"); }
            StringBuilder UpdateAutomaticHealthCheckToggleServiceURL = new StringBuilder("/automatic-health-check-toggle");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Put
            };
            request.AddJsonBody(AutomaticHealthCheckToggle);
            request.Resource = UpdateAutomaticHealthCheckToggleServiceURL.ToString();
            RestResponse<NSXTAutomaticHealthCheckToggleType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTAutomaticHealthCheckToggleType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Put operation to " + UpdateAutomaticHealthCheckToggleServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTAutomaticHealthCheckToggleType> GetAutomaticHealthCheckToggle()
        {
            StringBuilder GetAutomaticHealthCheckToggleServiceURL = new StringBuilder("/automatic-health-check-toggle");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Get
            };
            request.Resource = GetAutomaticHealthCheckToggleServiceURL.ToString();
            RestResponse<NSXTAutomaticHealthCheckToggleType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTAutomaticHealthCheckToggleType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Get operation to " + GetAutomaticHealthCheckToggleServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task DeleteManualHealthCheck(string ManualHealthCheckId)
        {
            if (ManualHealthCheckId == null) { throw new System.ArgumentNullException("ManualHealthCheckId cannot be null"); }
            StringBuilder DeleteManualHealthCheckServiceURL = new StringBuilder("/manual-health-checks/{manual-health-check-id}");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Delete
            };
            DeleteManualHealthCheckServiceURL.Replace("{manual-health-check-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(ManualHealthCheckId, System.Globalization.CultureInfo.InvariantCulture)));
            request.Resource = DeleteManualHealthCheckServiceURL.ToString();
            RestResponse response = await restClient.ExecuteTaskAsyncWithPolicy(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Delete operation to " + DeleteManualHealthCheckServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTManualHealthCheckType> GetManualHealthCheck(string ManualHealthCheckId)
        {
            if (ManualHealthCheckId == null) { throw new System.ArgumentNullException("ManualHealthCheckId cannot be null"); }
            StringBuilder GetManualHealthCheckServiceURL = new StringBuilder("/manual-health-checks/{manual-health-check-id}");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Get
            };
            GetManualHealthCheckServiceURL.Replace("{manual-health-check-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(ManualHealthCheckId, System.Globalization.CultureInfo.InvariantCulture)));
            request.Resource = GetManualHealthCheckServiceURL.ToString();
            RestResponse<NSXTManualHealthCheckType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTManualHealthCheckType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Get operation to " + GetManualHealthCheckServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
    }
}
