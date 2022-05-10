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
    public class NodeProxyService
    {
        private RestClient restClient;
        private int retry;
        private int timeout;
        private CancellationToken cancellationToken;

        public NodeProxyService(RestClient Client, CancellationToken _cancellationToken, int _timeout, int _retry)
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
        public async Task CreateProxyServiceActionStopStop()
        {
            StringBuilder CreateProxyServiceActionStopStopServiceURL = new StringBuilder("/node/services/http?action=stop");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Post
            };
            request.Resource = CreateProxyServiceActionStopStopServiceURL.ToString();
            RestResponse response = await restClient.ExecuteTaskAsyncWithPolicy(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Post operation to " + CreateProxyServiceActionStopStopServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTNodeServiceStatusPropertiesType> CreateProxyServiceActionStartStart()
        {
            StringBuilder CreateProxyServiceActionStartStartServiceURL = new StringBuilder("/node/services/http?action=start");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Post
            };
            request.Resource = CreateProxyServiceActionStartStartServiceURL.ToString();
            RestResponse<NSXTNodeServiceStatusPropertiesType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTNodeServiceStatusPropertiesType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Post operation to " + CreateProxyServiceActionStartStartServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTNodeServiceStatusPropertiesType> ReadProxyServiceStatus()
        {
            StringBuilder ReadProxyServiceStatusServiceURL = new StringBuilder("/node/services/http/status");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Get
            };
            request.Resource = ReadProxyServiceStatusServiceURL.ToString();
            RestResponse<NSXTNodeServiceStatusPropertiesType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTNodeServiceStatusPropertiesType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Get operation to " + ReadProxyServiceStatusServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task CreateProxyServiceActionRestartRestart()
        {
            StringBuilder CreateProxyServiceActionRestartRestartServiceURL = new StringBuilder("/node/services/http?action=restart");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Post
            };
            request.Resource = CreateProxyServiceActionRestartRestartServiceURL.ToString();
            RestResponse response = await restClient.ExecuteTaskAsyncWithPolicy(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Post operation to " + CreateProxyServiceActionRestartRestartServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task CreateProxyServiceApplyCertificateActionApplyCertificate(string CertificateId)
        {
            if (CertificateId == null) { throw new System.ArgumentNullException("CertificateId cannot be null"); }
            StringBuilder CreateProxyServiceApplyCertificateActionApplyCertificateServiceURL = new StringBuilder("/node/services/http?action=apply_certificate");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Post
            };
            if (CertificateId != null) { request.AddQueryParameter("certificate_id", CertificateId.ToString()); }
            request.Resource = CreateProxyServiceApplyCertificateActionApplyCertificateServiceURL.ToString();
            RestResponse response = await restClient.ExecuteTaskAsyncWithPolicy(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Post operation to " + CreateProxyServiceApplyCertificateActionApplyCertificateServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTNodeHttpServicePropertiesType> UpdateProxyService(NSXTNodeHttpServicePropertiesType NodeHttpServiceProperties)
        {
            if (NodeHttpServiceProperties == null) { throw new System.ArgumentNullException("NodeHttpServiceProperties cannot be null"); }
            StringBuilder UpdateProxyServiceServiceURL = new StringBuilder("/node/services/http");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Put
            };
            request.AddJsonBody(NodeHttpServiceProperties);
            request.Resource = UpdateProxyServiceServiceURL.ToString();
            RestResponse<NSXTNodeHttpServicePropertiesType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTNodeHttpServicePropertiesType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Put operation to " + UpdateProxyServiceServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTNodeHttpServicePropertiesType> ReadProxyService()
        {
            StringBuilder ReadProxyServiceServiceURL = new StringBuilder("/node/services/http");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Get
            };
            request.Resource = ReadProxyServiceServiceURL.ToString();
            RestResponse<NSXTNodeHttpServicePropertiesType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTNodeHttpServicePropertiesType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Get operation to " + ReadProxyServiceServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
    }
}
