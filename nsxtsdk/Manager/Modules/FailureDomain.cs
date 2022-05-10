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
    public class FailureDomain
    {
        private RestClient restClient;
        private int retry;
        private int timeout;
        private CancellationToken cancellationToken;

        public FailureDomain(RestClient Client, CancellationToken _cancellationToken, int _timeout, int _retry)
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
        public async Task<NSXTFailureDomainType> UpdateFailureDomain(string FailureDomainId, NSXTFailureDomainType FailureDomain)
        {
            if (FailureDomainId == null) { throw new System.ArgumentNullException("FailureDomainId cannot be null"); }
            if (FailureDomain == null) { throw new System.ArgumentNullException("FailureDomain cannot be null"); }
            StringBuilder UpdateFailureDomainServiceURL = new StringBuilder("/failure-domains/{failure-domain-id}");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Put
            };
            UpdateFailureDomainServiceURL.Replace("{failure-domain-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(FailureDomainId, System.Globalization.CultureInfo.InvariantCulture)));
            request.AddJsonBody(FailureDomain);
            request.Resource = UpdateFailureDomainServiceURL.ToString();
            RestResponse<NSXTFailureDomainType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTFailureDomainType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Put operation to " + UpdateFailureDomainServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task DeleteFailureDomain(string FailureDomainId)
        {
            if (FailureDomainId == null) { throw new System.ArgumentNullException("FailureDomainId cannot be null"); }
            StringBuilder DeleteFailureDomainServiceURL = new StringBuilder("/failure-domains/{failure-domain-id}");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Delete
            };
            DeleteFailureDomainServiceURL.Replace("{failure-domain-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(FailureDomainId, System.Globalization.CultureInfo.InvariantCulture)));
            request.Resource = DeleteFailureDomainServiceURL.ToString();
            RestResponse response = await restClient.ExecuteTaskAsyncWithPolicy(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Delete operation to " + DeleteFailureDomainServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTFailureDomainType> GetFailureDomain(string FailureDomainId)
        {
            if (FailureDomainId == null) { throw new System.ArgumentNullException("FailureDomainId cannot be null"); }
            StringBuilder GetFailureDomainServiceURL = new StringBuilder("/failure-domains/{failure-domain-id}");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Get
            };
            GetFailureDomainServiceURL.Replace("{failure-domain-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(FailureDomainId, System.Globalization.CultureInfo.InvariantCulture)));
            request.Resource = GetFailureDomainServiceURL.ToString();
            RestResponse<NSXTFailureDomainType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTFailureDomainType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Get operation to " + GetFailureDomainServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTFailureDomainType> CreateFailureDomain(NSXTFailureDomainType FailureDomain)
        {
            if (FailureDomain == null) { throw new System.ArgumentNullException("FailureDomain cannot be null"); }
            StringBuilder CreateFailureDomainServiceURL = new StringBuilder("/failure-domains");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Post
            };
            request.AddJsonBody(FailureDomain);
            request.Resource = CreateFailureDomainServiceURL.ToString();
            RestResponse<NSXTFailureDomainType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTFailureDomainType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Post operation to " + CreateFailureDomainServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTFailureDomainListResultType> ListFailureDomains()
        {
            StringBuilder ListFailureDomainsServiceURL = new StringBuilder("/failure-domains");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Get
            };
            request.Resource = ListFailureDomainsServiceURL.ToString();
            RestResponse<NSXTFailureDomainListResultType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTFailureDomainListResultType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Get operation to " + ListFailureDomainsServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
    }
}
