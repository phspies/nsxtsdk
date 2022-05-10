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
    public class IPSet
    {
        private RestClient restClient;
        private int retry;
        private int timeout;
        private CancellationToken cancellationToken;

        public IPSet(RestClient Client, CancellationToken _cancellationToken, int _timeout, int _retry)
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
        public async Task<NSXTIPAddressElementListResultType> GetIpaddresses(string IpSetId)
        {
            if (IpSetId == null) { throw new System.ArgumentNullException("IpSetId cannot be null"); }
            StringBuilder GetIpaddressesServiceURL = new StringBuilder("/ip-sets/{ip-set-id}/members");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Get
            };
            GetIpaddressesServiceURL.Replace("{ip-set-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(IpSetId, System.Globalization.CultureInfo.InvariantCulture)));
            request.Resource = GetIpaddressesServiceURL.ToString();
            RestResponse<NSXTIPAddressElementListResultType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTIPAddressElementListResultType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Get operation to " + GetIpaddressesServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTIPSetType> CreateIpset(NSXTIPSetType Ipset)
        {
            if (Ipset == null) { throw new System.ArgumentNullException("Ipset cannot be null"); }
            StringBuilder CreateIpsetServiceURL = new StringBuilder("/ip-sets");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Post
            };
            request.AddJsonBody(Ipset);
            request.Resource = CreateIpsetServiceURL.ToString();
            RestResponse<NSXTIPSetType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTIPSetType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Post operation to " + CreateIpsetServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTIPSetListResultType> ListIpsets(string? Cursor = null, string? IncludedFields = null, long? PageSize = null, bool? SortAscending = null, string? SortBy = null)
        {
            StringBuilder ListIpsetsServiceURL = new StringBuilder("/ip-sets");
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
            request.Resource = ListIpsetsServiceURL.ToString();
            RestResponse<NSXTIPSetListResultType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTIPSetListResultType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Get operation to " + ListIpsetsServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTIPSetType> UpdateIpset(string IpSetId, NSXTIPSetType Ipset)
        {
            if (IpSetId == null) { throw new System.ArgumentNullException("IpSetId cannot be null"); }
            if (Ipset == null) { throw new System.ArgumentNullException("Ipset cannot be null"); }
            StringBuilder UpdateIpsetServiceURL = new StringBuilder("/ip-sets/{ip-set-id}");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Put
            };
            UpdateIpsetServiceURL.Replace("{ip-set-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(IpSetId, System.Globalization.CultureInfo.InvariantCulture)));
            request.AddJsonBody(Ipset);
            request.Resource = UpdateIpsetServiceURL.ToString();
            RestResponse<NSXTIPSetType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTIPSetType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Put operation to " + UpdateIpsetServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTIPAddressElementType> AddRemoveIpaddress(string IpSetId, NSXTIPAddressElementType IpaddressElement, string Action)
        {
            if (IpSetId == null) { throw new System.ArgumentNullException("IpSetId cannot be null"); }
            if (IpaddressElement == null) { throw new System.ArgumentNullException("IpaddressElement cannot be null"); }
            if (Action == null) { throw new System.ArgumentNullException("Action cannot be null"); }
            StringBuilder AddRemoveIpaddressServiceURL = new StringBuilder("/ip-sets/{ip-set-id}");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Post
            };
            AddRemoveIpaddressServiceURL.Replace("{ip-set-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(IpSetId, System.Globalization.CultureInfo.InvariantCulture)));
            request.AddJsonBody(IpaddressElement);
            if (Action != null) { request.AddQueryParameter("action", Action.ToString()); }
            request.Resource = AddRemoveIpaddressServiceURL.ToString();
            RestResponse<NSXTIPAddressElementType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTIPAddressElementType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Post operation to " + AddRemoveIpaddressServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task DeleteIpset(string IpSetId, bool? Force = null)
        {
            if (IpSetId == null) { throw new System.ArgumentNullException("IpSetId cannot be null"); }
            StringBuilder DeleteIpsetServiceURL = new StringBuilder("/ip-sets/{ip-set-id}");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Delete
            };
            DeleteIpsetServiceURL.Replace("{ip-set-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(IpSetId, System.Globalization.CultureInfo.InvariantCulture)));
            if (Force != null) { request.AddQueryParameter("force", Force.ToString()); }
            request.Resource = DeleteIpsetServiceURL.ToString();
            RestResponse response = await restClient.ExecuteTaskAsyncWithPolicy(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Delete operation to " + DeleteIpsetServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTIPSetType> ReadIpset(string IpSetId)
        {
            if (IpSetId == null) { throw new System.ArgumentNullException("IpSetId cannot be null"); }
            StringBuilder ReadIpsetServiceURL = new StringBuilder("/ip-sets/{ip-set-id}");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Get
            };
            ReadIpsetServiceURL.Replace("{ip-set-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(IpSetId, System.Globalization.CultureInfo.InvariantCulture)));
            request.Resource = ReadIpsetServiceURL.ToString();
            RestResponse<NSXTIPSetType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTIPSetType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Get operation to " + ReadIpsetServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
    }
}
