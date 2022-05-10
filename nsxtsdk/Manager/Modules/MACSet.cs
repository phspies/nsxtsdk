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
    public class MACSet
    {
        private RestClient restClient;
        private int retry;
        private int timeout;
        private CancellationToken cancellationToken;

        public MACSet(RestClient Client, CancellationToken _cancellationToken, int _timeout, int _retry)
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
        public async Task RemoveMacaddress(string MacSetId, string MacAddress)
        {
            if (MacSetId == null) { throw new System.ArgumentNullException("MacSetId cannot be null"); }
            if (MacAddress == null) { throw new System.ArgumentNullException("MacAddress cannot be null"); }
            StringBuilder RemoveMacaddressServiceURL = new StringBuilder("/mac-sets/{mac-set-id}/members/{mac-address}");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Delete
            };
            RemoveMacaddressServiceURL.Replace("{mac-set-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(MacSetId, System.Globalization.CultureInfo.InvariantCulture)));
            RemoveMacaddressServiceURL.Replace("{mac-address}", System.Uri.EscapeDataString(Helpers.ConvertToString(MacAddress, System.Globalization.CultureInfo.InvariantCulture)));
            request.Resource = RemoveMacaddressServiceURL.ToString();
            RestResponse response = await restClient.ExecuteTaskAsyncWithPolicy(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Delete operation to " + RemoveMacaddressServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTMACAddressElementType> AddMacaddress(string MacSetId, NSXTMACAddressElementType MacaddressElement)
        {
            if (MacSetId == null) { throw new System.ArgumentNullException("MacSetId cannot be null"); }
            if (MacaddressElement == null) { throw new System.ArgumentNullException("MacaddressElement cannot be null"); }
            StringBuilder AddMacaddressServiceURL = new StringBuilder("/mac-sets/{mac-set-id}/members");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Post
            };
            AddMacaddressServiceURL.Replace("{mac-set-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(MacSetId, System.Globalization.CultureInfo.InvariantCulture)));
            request.AddJsonBody(MacaddressElement);
            request.Resource = AddMacaddressServiceURL.ToString();
            RestResponse<NSXTMACAddressElementType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTMACAddressElementType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Post operation to " + AddMacaddressServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTMACAddressElementListResultType> GetMacaddresses(string MacSetId)
        {
            if (MacSetId == null) { throw new System.ArgumentNullException("MacSetId cannot be null"); }
            StringBuilder GetMacaddressesServiceURL = new StringBuilder("/mac-sets/{mac-set-id}/members");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Get
            };
            GetMacaddressesServiceURL.Replace("{mac-set-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(MacSetId, System.Globalization.CultureInfo.InvariantCulture)));
            request.Resource = GetMacaddressesServiceURL.ToString();
            RestResponse<NSXTMACAddressElementListResultType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTMACAddressElementListResultType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Get operation to " + GetMacaddressesServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTMACSetType> UpdateMacset(string MacSetId, NSXTMACSetType Macset)
        {
            if (MacSetId == null) { throw new System.ArgumentNullException("MacSetId cannot be null"); }
            if (Macset == null) { throw new System.ArgumentNullException("Macset cannot be null"); }
            StringBuilder UpdateMacsetServiceURL = new StringBuilder("/mac-sets/{mac-set-id}");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Put
            };
            UpdateMacsetServiceURL.Replace("{mac-set-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(MacSetId, System.Globalization.CultureInfo.InvariantCulture)));
            request.AddJsonBody(Macset);
            request.Resource = UpdateMacsetServiceURL.ToString();
            RestResponse<NSXTMACSetType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTMACSetType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Put operation to " + UpdateMacsetServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task DeleteMacset(string MacSetId, bool? Force = null)
        {
            if (MacSetId == null) { throw new System.ArgumentNullException("MacSetId cannot be null"); }
            StringBuilder DeleteMacsetServiceURL = new StringBuilder("/mac-sets/{mac-set-id}");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Delete
            };
            DeleteMacsetServiceURL.Replace("{mac-set-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(MacSetId, System.Globalization.CultureInfo.InvariantCulture)));
            if (Force != null) { request.AddQueryParameter("force", Force.ToString()); }
            request.Resource = DeleteMacsetServiceURL.ToString();
            RestResponse response = await restClient.ExecuteTaskAsyncWithPolicy(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Delete operation to " + DeleteMacsetServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTMACSetType> ReadMacset(string MacSetId)
        {
            if (MacSetId == null) { throw new System.ArgumentNullException("MacSetId cannot be null"); }
            StringBuilder ReadMacsetServiceURL = new StringBuilder("/mac-sets/{mac-set-id}");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Get
            };
            ReadMacsetServiceURL.Replace("{mac-set-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(MacSetId, System.Globalization.CultureInfo.InvariantCulture)));
            request.Resource = ReadMacsetServiceURL.ToString();
            RestResponse<NSXTMACSetType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTMACSetType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Get operation to " + ReadMacsetServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTMACSetType> CreateMacset(NSXTMACSetType Macset)
        {
            if (Macset == null) { throw new System.ArgumentNullException("Macset cannot be null"); }
            StringBuilder CreateMacsetServiceURL = new StringBuilder("/mac-sets");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Post
            };
            request.AddJsonBody(Macset);
            request.Resource = CreateMacsetServiceURL.ToString();
            RestResponse<NSXTMACSetType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTMACSetType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Post operation to " + CreateMacsetServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTMACSetListResultType> ListMacsets(string? Cursor = null, string? IncludedFields = null, long? PageSize = null, bool? SortAscending = null, string? SortBy = null)
        {
            StringBuilder ListMacsetsServiceURL = new StringBuilder("/mac-sets");
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
            request.Resource = ListMacsetsServiceURL.ToString();
            RestResponse<NSXTMACSetListResultType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTMACSetListResultType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Get operation to " + ListMacsetsServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
    }
}
