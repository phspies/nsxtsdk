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
    public class NodeLogs
    {
        private RestClient restClient;
        private int retry;
        private int timeout;
        private CancellationToken cancellationToken;

        public NodeLogs(RestClient Client, CancellationToken _cancellationToken, int _timeout, int _retry)
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
        public async Task<NSXTNodeLogPropertiesListResultType> ListNodeLogs()
        {
            StringBuilder ListNodeLogsServiceURL = new StringBuilder("/node/logs");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Get
            };
            request.Resource = ListNodeLogsServiceURL.ToString();
            RestResponse<NSXTNodeLogPropertiesListResultType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTNodeLogPropertiesListResultType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Get operation to " + ListNodeLogsServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTNodeLogPropertiesType> ReadNodeLog(string LogName)
        {
            if (LogName == null) { throw new System.ArgumentNullException("LogName cannot be null"); }
            StringBuilder ReadNodeLogServiceURL = new StringBuilder("/node/logs/{log-name}");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Get
            };
            ReadNodeLogServiceURL.Replace("{log-name}", System.Uri.EscapeDataString(Helpers.ConvertToString(LogName, System.Globalization.CultureInfo.InvariantCulture)));
            request.Resource = ReadNodeLogServiceURL.ToString();
            RestResponse<NSXTNodeLogPropertiesType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTNodeLogPropertiesType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Get operation to " + ReadNodeLogServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task ReadNodeLogData(string LogName)
        {
            if (LogName == null) { throw new System.ArgumentNullException("LogName cannot be null"); }
            StringBuilder ReadNodeLogDataServiceURL = new StringBuilder("/node/logs/{log-name}/data");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Get
            };
            ReadNodeLogDataServiceURL.Replace("{log-name}", System.Uri.EscapeDataString(Helpers.ConvertToString(LogName, System.Globalization.CultureInfo.InvariantCulture)));
            request.Resource = ReadNodeLogDataServiceURL.ToString();
            RestResponse response = await restClient.ExecuteTaskAsyncWithPolicy(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Get operation to " + ReadNodeLogDataServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            
        }
    }
}
