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
    public class NodeSNMPService
    {
        private RestClient restClient;
        private int retry;
        private int timeout;
        private CancellationToken cancellationToken;

        public NodeSNMPService(RestClient Client, CancellationToken _cancellationToken, int _timeout, int _retry)
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
        public async Task<NSXTNodeSnmpServicePropertiesType> UpdateSnmpservice(NSXTNodeSnmpServicePropertiesType NodeSnmpServiceProperties)
        {
            if (NodeSnmpServiceProperties == null) { throw new System.ArgumentNullException("NodeSnmpServiceProperties cannot be null"); }
            StringBuilder UpdateSnmpserviceServiceURL = new StringBuilder("/node/services/snmp");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Put
            };
            request.AddJsonBody(NodeSnmpServiceProperties);
            request.Resource = UpdateSnmpserviceServiceURL.ToString();
            RestResponse<NSXTNodeSnmpServicePropertiesType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTNodeSnmpServicePropertiesType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Put operation to " + UpdateSnmpserviceServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTNodeSnmpServicePropertiesType> ReadSnmpservice(bool? ShowSensitiveData = null)
        {
            StringBuilder ReadSnmpserviceServiceURL = new StringBuilder("/node/services/snmp");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Get
            };
            if (ShowSensitiveData != null) { request.AddQueryParameter("show_sensitive_data", ShowSensitiveData.ToString()); }
            request.Resource = ReadSnmpserviceServiceURL.ToString();
            RestResponse<NSXTNodeSnmpServicePropertiesType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTNodeSnmpServicePropertiesType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Get operation to " + ReadSnmpserviceServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTNodeServiceStatusPropertiesType> CreateSnmpserviceActionStart()
        {
            StringBuilder CreateSnmpserviceActionStartServiceURL = new StringBuilder("/node/services/snmp?action=start");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Post
            };
            request.Resource = CreateSnmpserviceActionStartServiceURL.ToString();
            RestResponse<NSXTNodeServiceStatusPropertiesType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTNodeServiceStatusPropertiesType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Post operation to " + CreateSnmpserviceActionStartServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTNodeServiceStatusPropertiesType> CreateSnmpserviceActionRestart()
        {
            StringBuilder CreateSnmpserviceActionRestartServiceURL = new StringBuilder("/node/services/snmp?action=restart");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Post
            };
            request.Resource = CreateSnmpserviceActionRestartServiceURL.ToString();
            RestResponse<NSXTNodeServiceStatusPropertiesType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTNodeServiceStatusPropertiesType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Post operation to " + CreateSnmpserviceActionRestartServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTNodeServiceStatusPropertiesType> CreateSnmpserviceActionStop()
        {
            StringBuilder CreateSnmpserviceActionStopServiceURL = new StringBuilder("/node/services/snmp?action=stop");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Post
            };
            request.Resource = CreateSnmpserviceActionStopServiceURL.ToString();
            RestResponse<NSXTNodeServiceStatusPropertiesType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTNodeServiceStatusPropertiesType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Post operation to " + CreateSnmpserviceActionStopServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTNodeServiceStatusPropertiesType> ReadSnmpserviceStatus()
        {
            StringBuilder ReadSnmpserviceStatusServiceURL = new StringBuilder("/node/services/snmp/status");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Get
            };
            request.Resource = ReadSnmpserviceStatusServiceURL.ToString();
            RestResponse<NSXTNodeServiceStatusPropertiesType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTNodeServiceStatusPropertiesType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Get operation to " + ReadSnmpserviceStatusServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTNodeSnmpV3EngineIDType> UpdateSNMPV3EngineID(NSXTNodeSnmpV3EngineIDType NodeSnmpV3EngineID)
        {
            if (NodeSnmpV3EngineID == null) { throw new System.ArgumentNullException("NodeSnmpV3EngineID cannot be null"); }
            StringBuilder UpdateSNMPV3EngineIDServiceURL = new StringBuilder("/node/services/snmp/v3-engine-id");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Put
            };
            request.AddJsonBody(NodeSnmpV3EngineID);
            request.Resource = UpdateSNMPV3EngineIDServiceURL.ToString();
            RestResponse<NSXTNodeSnmpV3EngineIDType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTNodeSnmpV3EngineIDType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Put operation to " + UpdateSNMPV3EngineIDServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTNodeSnmpV3EngineIDType> ReadSNMPV3EngineID()
        {
            StringBuilder ReadSNMPV3EngineIDServiceURL = new StringBuilder("/node/services/snmp/v3-engine-id");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Get
            };
            request.Resource = ReadSNMPV3EngineIDServiceURL.ToString();
            RestResponse<NSXTNodeSnmpV3EngineIDType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTNodeSnmpV3EngineIDType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Get operation to " + ReadSNMPV3EngineIDServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
    }
}
