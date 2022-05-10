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
    public class AuthenticationPolicyModule
    {
        private RestClient restClient;
        private int retry;
        private int timeout;
        private CancellationToken cancellationToken;

        public AuthenticationPolicyModule(RestClient Client, CancellationToken _cancellationToken, int _timeout, int _retry)
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
        public async Task<NSXTAuthenticationPolicyPropertiesType> UpdateAuthenticationPolicyProperties(NSXTAuthenticationPolicyPropertiesType AuthenticationPolicyProperties)
        {
            if (AuthenticationPolicyProperties == null) { throw new System.ArgumentNullException("AuthenticationPolicyProperties cannot be null"); }
            StringBuilder UpdateAuthenticationPolicyPropertiesServiceURL = new StringBuilder("/node/aaa/auth-policy");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Put
            };
            request.AddJsonBody(AuthenticationPolicyProperties);
            request.Resource = UpdateAuthenticationPolicyPropertiesServiceURL.ToString();
            RestResponse<NSXTAuthenticationPolicyPropertiesType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTAuthenticationPolicyPropertiesType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Put operation to " + UpdateAuthenticationPolicyPropertiesServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTAuthenticationPolicyPropertiesType> ReadAuthenticationPolicyProperties()
        {
            StringBuilder ReadAuthenticationPolicyPropertiesServiceURL = new StringBuilder("/node/aaa/auth-policy");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Get
            };
            request.Resource = ReadAuthenticationPolicyPropertiesServiceURL.ToString();
            RestResponse<NSXTAuthenticationPolicyPropertiesType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTAuthenticationPolicyPropertiesType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Get operation to " + ReadAuthenticationPolicyPropertiesServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
    }
}
