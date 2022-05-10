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
    public class CentralApiModule
    {
        private RestClient restClient;
        private int retry;
        private int timeout;
        private CancellationToken cancellationToken;

        public CentralApiModule(RestClient Client, CancellationToken _cancellationToken, int _timeout, int _retry)
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
        public async Task InvokePutTransportNodeCentralAPI(string TargetNodeId, string TargetUri)
        {
            if (TargetNodeId == null) { throw new System.ArgumentNullException("TargetNodeId cannot be null"); }
            if (TargetUri == null) { throw new System.ArgumentNullException("TargetUri cannot be null"); }
            StringBuilder InvokePutTransportNodeCentralAPIServiceURL = new StringBuilder("/transport-nodes/{target-node-id}/{target-uri}");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Put
            };
            InvokePutTransportNodeCentralAPIServiceURL.Replace("{target-node-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(TargetNodeId, System.Globalization.CultureInfo.InvariantCulture)));
            InvokePutTransportNodeCentralAPIServiceURL.Replace("{target-uri}", System.Uri.EscapeDataString(Helpers.ConvertToString(TargetUri, System.Globalization.CultureInfo.InvariantCulture)));
            request.Resource = InvokePutTransportNodeCentralAPIServiceURL.ToString();
            RestResponse response = await restClient.ExecuteTaskAsyncWithPolicy(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Put operation to " + InvokePutTransportNodeCentralAPIServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task InvokePostTransportNodeCentralAPI(string TargetNodeId, string TargetUri)
        {
            if (TargetNodeId == null) { throw new System.ArgumentNullException("TargetNodeId cannot be null"); }
            if (TargetUri == null) { throw new System.ArgumentNullException("TargetUri cannot be null"); }
            StringBuilder InvokePostTransportNodeCentralAPIServiceURL = new StringBuilder("/transport-nodes/{target-node-id}/{target-uri}");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Post
            };
            InvokePostTransportNodeCentralAPIServiceURL.Replace("{target-node-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(TargetNodeId, System.Globalization.CultureInfo.InvariantCulture)));
            InvokePostTransportNodeCentralAPIServiceURL.Replace("{target-uri}", System.Uri.EscapeDataString(Helpers.ConvertToString(TargetUri, System.Globalization.CultureInfo.InvariantCulture)));
            request.Resource = InvokePostTransportNodeCentralAPIServiceURL.ToString();
            RestResponse response = await restClient.ExecuteTaskAsyncWithPolicy(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Post operation to " + InvokePostTransportNodeCentralAPIServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task InvokeDeleteTransportNodeCentralAPI(string TargetNodeId, string TargetUri)
        {
            if (TargetNodeId == null) { throw new System.ArgumentNullException("TargetNodeId cannot be null"); }
            if (TargetUri == null) { throw new System.ArgumentNullException("TargetUri cannot be null"); }
            StringBuilder InvokeDeleteTransportNodeCentralAPIServiceURL = new StringBuilder("/transport-nodes/{target-node-id}/{target-uri}");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Delete
            };
            InvokeDeleteTransportNodeCentralAPIServiceURL.Replace("{target-node-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(TargetNodeId, System.Globalization.CultureInfo.InvariantCulture)));
            InvokeDeleteTransportNodeCentralAPIServiceURL.Replace("{target-uri}", System.Uri.EscapeDataString(Helpers.ConvertToString(TargetUri, System.Globalization.CultureInfo.InvariantCulture)));
            request.Resource = InvokeDeleteTransportNodeCentralAPIServiceURL.ToString();
            RestResponse response = await restClient.ExecuteTaskAsyncWithPolicy(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Delete operation to " + InvokeDeleteTransportNodeCentralAPIServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task InvokeGetTransportNodeCentralAPI(string TargetNodeId, string TargetUri)
        {
            if (TargetNodeId == null) { throw new System.ArgumentNullException("TargetNodeId cannot be null"); }
            if (TargetUri == null) { throw new System.ArgumentNullException("TargetUri cannot be null"); }
            StringBuilder InvokeGetTransportNodeCentralAPIServiceURL = new StringBuilder("/transport-nodes/{target-node-id}/{target-uri}");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Get
            };
            InvokeGetTransportNodeCentralAPIServiceURL.Replace("{target-node-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(TargetNodeId, System.Globalization.CultureInfo.InvariantCulture)));
            InvokeGetTransportNodeCentralAPIServiceURL.Replace("{target-uri}", System.Uri.EscapeDataString(Helpers.ConvertToString(TargetUri, System.Globalization.CultureInfo.InvariantCulture)));
            request.Resource = InvokeGetTransportNodeCentralAPIServiceURL.ToString();
            RestResponse response = await restClient.ExecuteTaskAsyncWithPolicy(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Get operation to " + InvokeGetTransportNodeCentralAPIServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task InvokePutClusterCentralAPI(string TargetNodeId, string TargetUri)
        {
            if (TargetNodeId == null) { throw new System.ArgumentNullException("TargetNodeId cannot be null"); }
            if (TargetUri == null) { throw new System.ArgumentNullException("TargetUri cannot be null"); }
            StringBuilder InvokePutClusterCentralAPIServiceURL = new StringBuilder("/cluster/{target-node-id}/{target-uri}");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Put
            };
            InvokePutClusterCentralAPIServiceURL.Replace("{target-node-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(TargetNodeId, System.Globalization.CultureInfo.InvariantCulture)));
            InvokePutClusterCentralAPIServiceURL.Replace("{target-uri}", System.Uri.EscapeDataString(Helpers.ConvertToString(TargetUri, System.Globalization.CultureInfo.InvariantCulture)));
            request.Resource = InvokePutClusterCentralAPIServiceURL.ToString();
            RestResponse response = await restClient.ExecuteTaskAsyncWithPolicy(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Put operation to " + InvokePutClusterCentralAPIServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task InvokePostClusterCentralAPI(string TargetNodeId, string TargetUri)
        {
            if (TargetNodeId == null) { throw new System.ArgumentNullException("TargetNodeId cannot be null"); }
            if (TargetUri == null) { throw new System.ArgumentNullException("TargetUri cannot be null"); }
            StringBuilder InvokePostClusterCentralAPIServiceURL = new StringBuilder("/cluster/{target-node-id}/{target-uri}");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Post
            };
            InvokePostClusterCentralAPIServiceURL.Replace("{target-node-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(TargetNodeId, System.Globalization.CultureInfo.InvariantCulture)));
            InvokePostClusterCentralAPIServiceURL.Replace("{target-uri}", System.Uri.EscapeDataString(Helpers.ConvertToString(TargetUri, System.Globalization.CultureInfo.InvariantCulture)));
            request.Resource = InvokePostClusterCentralAPIServiceURL.ToString();
            RestResponse response = await restClient.ExecuteTaskAsyncWithPolicy(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Post operation to " + InvokePostClusterCentralAPIServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task InvokeDeleteClusterCentralAPI(string TargetNodeId, string TargetUri)
        {
            if (TargetNodeId == null) { throw new System.ArgumentNullException("TargetNodeId cannot be null"); }
            if (TargetUri == null) { throw new System.ArgumentNullException("TargetUri cannot be null"); }
            StringBuilder InvokeDeleteClusterCentralAPIServiceURL = new StringBuilder("/cluster/{target-node-id}/{target-uri}");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Delete
            };
            InvokeDeleteClusterCentralAPIServiceURL.Replace("{target-node-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(TargetNodeId, System.Globalization.CultureInfo.InvariantCulture)));
            InvokeDeleteClusterCentralAPIServiceURL.Replace("{target-uri}", System.Uri.EscapeDataString(Helpers.ConvertToString(TargetUri, System.Globalization.CultureInfo.InvariantCulture)));
            request.Resource = InvokeDeleteClusterCentralAPIServiceURL.ToString();
            RestResponse response = await restClient.ExecuteTaskAsyncWithPolicy(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Delete operation to " + InvokeDeleteClusterCentralAPIServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task InvokeGetClusterCentralAPI(string TargetNodeId, string TargetUri)
        {
            if (TargetNodeId == null) { throw new System.ArgumentNullException("TargetNodeId cannot be null"); }
            if (TargetUri == null) { throw new System.ArgumentNullException("TargetUri cannot be null"); }
            StringBuilder InvokeGetClusterCentralAPIServiceURL = new StringBuilder("/cluster/{target-node-id}/{target-uri}");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Get
            };
            InvokeGetClusterCentralAPIServiceURL.Replace("{target-node-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(TargetNodeId, System.Globalization.CultureInfo.InvariantCulture)));
            InvokeGetClusterCentralAPIServiceURL.Replace("{target-uri}", System.Uri.EscapeDataString(Helpers.ConvertToString(TargetUri, System.Globalization.CultureInfo.InvariantCulture)));
            request.Resource = InvokeGetClusterCentralAPIServiceURL.ToString();
            RestResponse response = await restClient.ExecuteTaskAsyncWithPolicy(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Get operation to " + InvokeGetClusterCentralAPIServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            
        }
    }
}
