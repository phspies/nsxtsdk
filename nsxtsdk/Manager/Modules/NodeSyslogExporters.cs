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
    public class NodeSyslogExporters
    {
        private RestClient restClient;
        private int retry;
        private int timeout;
        private CancellationToken cancellationToken;

        public NodeSyslogExporters(RestClient Client, CancellationToken _cancellationToken, int _timeout, int _retry)
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
        public async Task<NSXTNodeSyslogExporterPropertiesType> PostNodeSyslogExporter(NSXTNodeSyslogExporterPropertiesType NodeSyslogExporterProperties)
        {
            if (NodeSyslogExporterProperties == null) { throw new System.ArgumentNullException("NodeSyslogExporterProperties cannot be null"); }
            StringBuilder PostNodeSyslogExporterServiceURL = new StringBuilder("/node/services/syslog/exporters");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Post
            };
            request.AddJsonBody(NodeSyslogExporterProperties);
            request.Resource = PostNodeSyslogExporterServiceURL.ToString();
            RestResponse<NSXTNodeSyslogExporterPropertiesType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTNodeSyslogExporterPropertiesType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Post operation to " + PostNodeSyslogExporterServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTNodeSyslogExporterPropertiesListResultType> ListNodeSyslogExporters()
        {
            StringBuilder ListNodeSyslogExportersServiceURL = new StringBuilder("/node/services/syslog/exporters");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Get
            };
            request.Resource = ListNodeSyslogExportersServiceURL.ToString();
            RestResponse<NSXTNodeSyslogExporterPropertiesListResultType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTNodeSyslogExporterPropertiesListResultType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Get operation to " + ListNodeSyslogExportersServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task DeleteNodeSyslogExporterAll()
        {
            StringBuilder DeleteNodeSyslogExporterAllServiceURL = new StringBuilder("/node/services/syslog/exporters");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Delete
            };
            request.Resource = DeleteNodeSyslogExporterAllServiceURL.ToString();
            RestResponse response = await restClient.ExecuteTaskAsyncWithPolicy(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Delete operation to " + DeleteNodeSyslogExporterAllServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTNodeSyslogExporterPropertiesType> ReadNodeSyslogExporter(string ExporterName)
        {
            if (ExporterName == null) { throw new System.ArgumentNullException("ExporterName cannot be null"); }
            StringBuilder ReadNodeSyslogExporterServiceURL = new StringBuilder("/node/services/syslog/exporters/{exporter-name}");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Get
            };
            ReadNodeSyslogExporterServiceURL.Replace("{exporter-name}", System.Uri.EscapeDataString(Helpers.ConvertToString(ExporterName, System.Globalization.CultureInfo.InvariantCulture)));
            request.Resource = ReadNodeSyslogExporterServiceURL.ToString();
            RestResponse<NSXTNodeSyslogExporterPropertiesType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTNodeSyslogExporterPropertiesType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Get operation to " + ReadNodeSyslogExporterServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task DeleteNodeSyslogExporter(string ExporterName)
        {
            if (ExporterName == null) { throw new System.ArgumentNullException("ExporterName cannot be null"); }
            StringBuilder DeleteNodeSyslogExporterServiceURL = new StringBuilder("/node/services/syslog/exporters/{exporter-name}");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Delete
            };
            DeleteNodeSyslogExporterServiceURL.Replace("{exporter-name}", System.Uri.EscapeDataString(Helpers.ConvertToString(ExporterName, System.Globalization.CultureInfo.InvariantCulture)));
            request.Resource = DeleteNodeSyslogExporterServiceURL.ToString();
            RestResponse response = await restClient.ExecuteTaskAsyncWithPolicy(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Delete operation to " + DeleteNodeSyslogExporterServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task VerifyNodeSyslogExporterVerify()
        {
            StringBuilder VerifyNodeSyslogExporterVerifyServiceURL = new StringBuilder("/node/services/syslog/exporters?action=verify");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Post
            };
            request.Resource = VerifyNodeSyslogExporterVerifyServiceURL.ToString();
            RestResponse response = await restClient.ExecuteTaskAsyncWithPolicy(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Post operation to " + VerifyNodeSyslogExporterVerifyServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            
        }
    }
}
