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
    public class PolicySystemConfig
    {
        private RestClient restClient;
        private int retry;
        private int timeout;
        private CancellationToken cancellationToken;

        public PolicySystemConfig(RestClient Client, CancellationToken _cancellationToken, int _timeout, int _retry)
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
        public async Task UpdatePartialPatchConfig(NSXTPartialPatchConfigType PartialPatchConfig)
        {
            if (PartialPatchConfig == null) { throw new System.ArgumentNullException("PartialPatchConfig cannot be null"); }
            StringBuilder UpdatePartialPatchConfigServiceURL = new StringBuilder("/system-config/nsx-partial-patch-config");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Patch
            };
            request.AddJsonBody(PartialPatchConfig);
            request.Resource = UpdatePartialPatchConfigServiceURL.ToString();
            RestResponse response = await restClient.ExecuteTaskAsyncWithPolicy(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Patch operation to " + UpdatePartialPatchConfigServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTPartialPatchConfigType> GetPartialPatchConfiguration()
        {
            StringBuilder GetPartialPatchConfigurationServiceURL = new StringBuilder("/system-config/nsx-partial-patch-config");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Get
            };
            request.Resource = GetPartialPatchConfigurationServiceURL.ToString();
            RestResponse<NSXTPartialPatchConfigType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTPartialPatchConfigType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Get operation to " + GetPartialPatchConfigurationServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
    }
}
