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
    public class NsxIntelligenceHostConfiguration
    {
        private RestClient restClient;
        private int retry;
        private int timeout;
        private CancellationToken cancellationToken;

        public NsxIntelligenceHostConfiguration(RestClient Client, CancellationToken _cancellationToken, int _timeout, int _retry)
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
        public async Task<NSXTIntelligenceHostConfigurationInfoType> ResetPaceHostConfiguration()
        {
            StringBuilder ResetPaceHostConfigurationServiceURL = new StringBuilder("/intelligence/host-config?action=reset");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Post
            };
            request.Resource = ResetPaceHostConfigurationServiceURL.ToString();
            RestResponse<NSXTIntelligenceHostConfigurationInfoType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTIntelligenceHostConfigurationInfoType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Post operation to " + ResetPaceHostConfigurationServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTIntelligenceHostConfigurationInfoType> PatchPaceHostConfiguration(NSXTIntelligenceHostConfigurationInfoType IntelligenceHostConfigurationInfo)
        {
            if (IntelligenceHostConfigurationInfo == null) { throw new System.ArgumentNullException("IntelligenceHostConfigurationInfo cannot be null"); }
            StringBuilder PatchPaceHostConfigurationServiceURL = new StringBuilder("/intelligence/host-config");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Patch
            };
            request.AddJsonBody(IntelligenceHostConfigurationInfo);
            request.Resource = PatchPaceHostConfigurationServiceURL.ToString();
            RestResponse<NSXTIntelligenceHostConfigurationInfoType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTIntelligenceHostConfigurationInfoType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Patch operation to " + PatchPaceHostConfigurationServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTIntelligenceHostConfigurationInfoType> GetPaceHostConfiguration()
        {
            StringBuilder GetPaceHostConfigurationServiceURL = new StringBuilder("/intelligence/host-config");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Get
            };
            request.Resource = GetPaceHostConfigurationServiceURL.ToString();
            RestResponse<NSXTIntelligenceHostConfigurationInfoType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTIntelligenceHostConfigurationInfoType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Get operation to " + GetPaceHostConfigurationServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
    }
}
