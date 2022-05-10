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
    public class DnsForwarder
    {
        private RestClient restClient;
        private int retry;
        private int timeout;
        private CancellationToken cancellationToken;

        public DnsForwarder(RestClient Client, CancellationToken _cancellationToken, int _timeout, int _retry)
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
        public async Task<NSXTDnsForwarderType> UpdateDnsForwarder(string ForwarderId, NSXTDnsForwarderType DnsForwarder)
        {
            if (ForwarderId == null) { throw new System.ArgumentNullException("ForwarderId cannot be null"); }
            if (DnsForwarder == null) { throw new System.ArgumentNullException("DnsForwarder cannot be null"); }
            StringBuilder UpdateDnsForwarderServiceURL = new StringBuilder("/dns/forwarders/{forwarder-id}");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Put
            };
            UpdateDnsForwarderServiceURL.Replace("{forwarder-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(ForwarderId, System.Globalization.CultureInfo.InvariantCulture)));
            request.AddJsonBody(DnsForwarder);
            request.Resource = UpdateDnsForwarderServiceURL.ToString();
            RestResponse<NSXTDnsForwarderType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTDnsForwarderType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Put operation to " + UpdateDnsForwarderServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTDnsForwarderType> ReadDnsForwader(string ForwarderId)
        {
            if (ForwarderId == null) { throw new System.ArgumentNullException("ForwarderId cannot be null"); }
            StringBuilder ReadDnsForwaderServiceURL = new StringBuilder("/dns/forwarders/{forwarder-id}");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Get
            };
            ReadDnsForwaderServiceURL.Replace("{forwarder-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(ForwarderId, System.Globalization.CultureInfo.InvariantCulture)));
            request.Resource = ReadDnsForwaderServiceURL.ToString();
            RestResponse<NSXTDnsForwarderType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTDnsForwarderType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Get operation to " + ReadDnsForwaderServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task DeleteDnsForwarder(string ForwarderId)
        {
            if (ForwarderId == null) { throw new System.ArgumentNullException("ForwarderId cannot be null"); }
            StringBuilder DeleteDnsForwarderServiceURL = new StringBuilder("/dns/forwarders/{forwarder-id}");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Delete
            };
            DeleteDnsForwarderServiceURL.Replace("{forwarder-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(ForwarderId, System.Globalization.CultureInfo.InvariantCulture)));
            request.Resource = DeleteDnsForwarderServiceURL.ToString();
            RestResponse response = await restClient.ExecuteTaskAsyncWithPolicy(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Delete operation to " + DeleteDnsForwarderServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTConfigurationStateType> GetDnsForwarderState(string ForwarderId, long? BarrierId = null, string? RequestId = null)
        {
            if (ForwarderId == null) { throw new System.ArgumentNullException("ForwarderId cannot be null"); }
            StringBuilder GetDnsForwarderStateServiceURL = new StringBuilder("/dns/forwarders/{forwarder-id}/state");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Get
            };
            GetDnsForwarderStateServiceURL.Replace("{forwarder-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(ForwarderId, System.Globalization.CultureInfo.InvariantCulture)));
            if (BarrierId != null) { request.AddQueryParameter("barrier_id", BarrierId.ToString()); }
            if (RequestId != null) { request.AddQueryParameter("request_id", RequestId.ToString()); }
            request.Resource = GetDnsForwarderStateServiceURL.ToString();
            RestResponse<NSXTConfigurationStateType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTConfigurationStateType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Get operation to " + GetDnsForwarderStateServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTDnsFailedQueriesType> GetFailedDnsQueries(string ForwarderId, long? Count = null)
        {
            if (ForwarderId == null) { throw new System.ArgumentNullException("ForwarderId cannot be null"); }
            StringBuilder GetFailedDnsQueriesServiceURL = new StringBuilder("/dns/forwarders/{forwarder-id}/failed-queries");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Get
            };
            GetFailedDnsQueriesServiceURL.Replace("{forwarder-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(ForwarderId, System.Globalization.CultureInfo.InvariantCulture)));
            if (Count != null) { request.AddQueryParameter("count", Count.ToString()); }
            request.Resource = GetFailedDnsQueriesServiceURL.ToString();
            RestResponse<NSXTDnsFailedQueriesType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTDnsFailedQueriesType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Get operation to " + GetFailedDnsQueriesServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTDnsForwarderType> CreateDnsForwader(NSXTDnsForwarderType DnsForwarder)
        {
            if (DnsForwarder == null) { throw new System.ArgumentNullException("DnsForwarder cannot be null"); }
            StringBuilder CreateDnsForwaderServiceURL = new StringBuilder("/dns/forwarders");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Post
            };
            request.AddJsonBody(DnsForwarder);
            request.Resource = CreateDnsForwaderServiceURL.ToString();
            RestResponse<NSXTDnsForwarderType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTDnsForwarderType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Post operation to " + CreateDnsForwaderServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTDnsForwarderListResultType> ListDnsForwaders(string? Cursor = null, string? IncludedFields = null, long? PageSize = null, bool? SortAscending = null, string? SortBy = null)
        {
            StringBuilder ListDnsForwadersServiceURL = new StringBuilder("/dns/forwarders");
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
            request.Resource = ListDnsForwadersServiceURL.ToString();
            RestResponse<NSXTDnsForwarderListResultType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTDnsForwarderListResultType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Get operation to " + ListDnsForwadersServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task DisableDnsForwarder(string ForwarderId)
        {
            if (ForwarderId == null) { throw new System.ArgumentNullException("ForwarderId cannot be null"); }
            StringBuilder DisableDnsForwarderServiceURL = new StringBuilder("/dns/forwarders/{forwarder-id}?action=disable");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Post
            };
            DisableDnsForwarderServiceURL.Replace("{forwarder-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(ForwarderId, System.Globalization.CultureInfo.InvariantCulture)));
            request.Resource = DisableDnsForwarderServiceURL.ToString();
            RestResponse response = await restClient.ExecuteTaskAsyncWithPolicy(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Post operation to " + DisableDnsForwarderServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTDnsAnswerType> LookupAddress(string ForwarderId, string? Address = null, string? ServerIp = null, string? SourceIp = null)
        {
            if (ForwarderId == null) { throw new System.ArgumentNullException("ForwarderId cannot be null"); }
            StringBuilder LookupAddressServiceURL = new StringBuilder("/dns/forwarders/{forwarder-id}/nslookup");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Get
            };
            LookupAddressServiceURL.Replace("{forwarder-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(ForwarderId, System.Globalization.CultureInfo.InvariantCulture)));
            if (Address != null) { request.AddQueryParameter("address", Address.ToString()); }
            if (ServerIp != null) { request.AddQueryParameter("server_ip", ServerIp.ToString()); }
            if (SourceIp != null) { request.AddQueryParameter("source_ip", SourceIp.ToString()); }
            request.Resource = LookupAddressServiceURL.ToString();
            RestResponse<NSXTDnsAnswerType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTDnsAnswerType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Get operation to " + LookupAddressServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task ClearDnsForwarderCache(string ForwarderId)
        {
            if (ForwarderId == null) { throw new System.ArgumentNullException("ForwarderId cannot be null"); }
            StringBuilder ClearDnsForwarderCacheServiceURL = new StringBuilder("/dns/forwarders/{forwarder-id}?action=clear_cache");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Post
            };
            ClearDnsForwarderCacheServiceURL.Replace("{forwarder-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(ForwarderId, System.Globalization.CultureInfo.InvariantCulture)));
            request.Resource = ClearDnsForwarderCacheServiceURL.ToString();
            RestResponse response = await restClient.ExecuteTaskAsyncWithPolicy(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Post operation to " + ClearDnsForwarderCacheServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task EnableDnsForwarder(string ForwarderId)
        {
            if (ForwarderId == null) { throw new System.ArgumentNullException("ForwarderId cannot be null"); }
            StringBuilder EnableDnsForwarderServiceURL = new StringBuilder("/dns/forwarders/{forwarder-id}?action=enable");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Post
            };
            EnableDnsForwarderServiceURL.Replace("{forwarder-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(ForwarderId, System.Globalization.CultureInfo.InvariantCulture)));
            request.Resource = EnableDnsForwarderServiceURL.ToString();
            RestResponse response = await restClient.ExecuteTaskAsyncWithPolicy(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Post operation to " + EnableDnsForwarderServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            
        }
    }
}
