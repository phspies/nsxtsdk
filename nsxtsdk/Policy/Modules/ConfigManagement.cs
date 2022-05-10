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
    public class ConfigManagement
    {
        private RestClient restClient;
        private int retry;
        private int timeout;
        private CancellationToken cancellationToken;

        public ConfigManagement(RestClient Client, CancellationToken _cancellationToken, int _timeout, int _retry)
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
        public async Task<NSXTManagementConfigType> UpdateManagementConfig(NSXTManagementConfigType ManagementConfig)
        {
            if (ManagementConfig == null) { throw new System.ArgumentNullException("ManagementConfig cannot be null"); }
            StringBuilder UpdateManagementConfigServiceURL = new StringBuilder("/configs/management");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Put
            };
            request.AddJsonBody(ManagementConfig);
            request.Resource = UpdateManagementConfigServiceURL.ToString();
            RestResponse<NSXTManagementConfigType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTManagementConfigType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Put operation to " + UpdateManagementConfigServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTManagementConfigType> ReadManagementConfig()
        {
            StringBuilder ReadManagementConfigServiceURL = new StringBuilder("/configs/management");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Get
            };
            request.Resource = ReadManagementConfigServiceURL.ToString();
            RestResponse<NSXTManagementConfigType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTManagementConfigType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Get operation to " + ReadManagementConfigServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
    }
}
