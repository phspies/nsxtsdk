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
using nsxtsdk.PolicyModels;

namespace nsxtapi.PolicyModules
{
    public class PolicyCloudNativeCommonAgent
    {
        private RestClient restClient;
        private int retry;
        private int timeout;
        private CancellationToken cancellationToken;

        public PolicyCloudNativeCommonAgent(RestClient Client, CancellationToken _cancellationToken, int _timeout, int _retry)
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
        public async Task<NSXTCommonAgentHostConfigurationInfoType> PatchCommonAgentHostConfiguration(NSXTCommonAgentHostConfigurationInfoType CommonAgentHostConfigurationInfo)
        {
            if (CommonAgentHostConfigurationInfo == null) { throw new System.ArgumentNullException("CommonAgentHostConfigurationInfo cannot be null"); }
            StringBuilder PatchCommonAgentHostConfigurationServiceURL = new StringBuilder("/infra/napp/common-agent/host-config");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Patch
            };
            request.AddJsonBody(CommonAgentHostConfigurationInfo);
            request.Resource = PatchCommonAgentHostConfigurationServiceURL.ToString();
            RestResponse<NSXTCommonAgentHostConfigurationInfoType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTCommonAgentHostConfigurationInfoType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Patch operation to " + PatchCommonAgentHostConfigurationServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTCommonAgentHostConfigurationInfoType> GetCommonAgentHostConfiguration()
        {
            StringBuilder GetCommonAgentHostConfigurationServiceURL = new StringBuilder("/infra/napp/common-agent/host-config");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Get
            };
            request.Resource = GetCommonAgentHostConfigurationServiceURL.ToString();
            RestResponse<NSXTCommonAgentHostConfigurationInfoType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTCommonAgentHostConfigurationInfoType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Get operation to " + GetCommonAgentHostConfigurationServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTCommonAgentHostConfigurationInfoType> ResetCommonAgentHostConfiguration()
        {
            StringBuilder ResetCommonAgentHostConfigurationServiceURL = new StringBuilder("/infra/napp/common-agent/host-config?action=reset");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Post
            };
            request.Resource = ResetCommonAgentHostConfigurationServiceURL.ToString();
            RestResponse<NSXTCommonAgentHostConfigurationInfoType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTCommonAgentHostConfigurationInfoType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Post operation to " + ResetCommonAgentHostConfigurationServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
    }
}
