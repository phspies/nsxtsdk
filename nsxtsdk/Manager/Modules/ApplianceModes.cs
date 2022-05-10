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
    public class ApplianceModes
    {
        private RestClient restClient;
        private int retry;
        private int timeout;
        private CancellationToken cancellationToken;

        public ApplianceModes(RestClient Client, CancellationToken _cancellationToken, int _timeout, int _retry)
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
        public async Task<NSXTNodeModeType> GetNodeMode()
        {
            StringBuilder GetNodeModeServiceURL = new StringBuilder("/node/mode");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Get
            };
            request.Resource = GetNodeModeServiceURL.ToString();
            RestResponse<NSXTNodeModeType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTNodeModeType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Get operation to " + GetNodeModeServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTNodeModeType> ChangeNodeMode(NSXTSwitchingToVmcModeParametersType SwitchingToVmcModeParameters)
        {
            if (SwitchingToVmcModeParameters == null) { throw new System.ArgumentNullException("SwitchingToVmcModeParameters cannot be null"); }
            StringBuilder ChangeNodeModeServiceURL = new StringBuilder("/configs/node/mode");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Post
            };
            request.AddJsonBody(SwitchingToVmcModeParameters);
            request.Resource = ChangeNodeModeServiceURL.ToString();
            RestResponse<NSXTNodeModeType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTNodeModeType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Post operation to " + ChangeNodeModeServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
    }
}
