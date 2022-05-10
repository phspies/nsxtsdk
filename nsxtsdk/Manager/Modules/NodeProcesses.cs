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
    public class NodeProcesses
    {
        private RestClient restClient;
        private int retry;
        private int timeout;
        private CancellationToken cancellationToken;

        public NodeProcesses(RestClient Client, CancellationToken _cancellationToken, int _timeout, int _retry)
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
        public async Task<NSXTNodeProcessPropertiesListResultType> ListNodeProcesses()
        {
            StringBuilder ListNodeProcessesServiceURL = new StringBuilder("/node/processes");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Get
            };
            request.Resource = ListNodeProcessesServiceURL.ToString();
            RestResponse<NSXTNodeProcessPropertiesListResultType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTNodeProcessPropertiesListResultType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Get operation to " + ListNodeProcessesServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTNodeProcessPropertiesType> ReadNodeProcess(string ProcessId)
        {
            if (ProcessId == null) { throw new System.ArgumentNullException("ProcessId cannot be null"); }
            StringBuilder ReadNodeProcessServiceURL = new StringBuilder("/node/processes/{process-id}");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Get
            };
            ReadNodeProcessServiceURL.Replace("{process-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(ProcessId, System.Globalization.CultureInfo.InvariantCulture)));
            request.Resource = ReadNodeProcessServiceURL.ToString();
            RestResponse<NSXTNodeProcessPropertiesType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTNodeProcessPropertiesType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Get operation to " + ReadNodeProcessServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
    }
}
