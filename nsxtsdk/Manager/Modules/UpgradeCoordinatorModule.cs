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
    public class UpgradeCoordinatorModule
    {
        private RestClient restClient;
        private int retry;
        private int timeout;
        private CancellationToken cancellationToken;

        public UpgradeCoordinatorModule(RestClient Client, CancellationToken _cancellationToken, int _timeout, int _retry)
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
        public async Task TriggerRepositoryDrivenUcUpgrade(NSXTTriggerUcUpgradeParametersType TriggerUcUpgradeParameters)
        {
            if (TriggerUcUpgradeParameters == null) { throw new System.ArgumentNullException("TriggerUcUpgradeParameters cannot be null"); }
            StringBuilder TriggerRepositoryDrivenUcUpgradeServiceURL = new StringBuilder("/node/upgrade/uc");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Post
            };
            request.AddJsonBody(TriggerUcUpgradeParameters);
            request.Resource = TriggerRepositoryDrivenUcUpgradeServiceURL.ToString();
            RestResponse response = await restClient.ExecuteTaskAsyncWithPolicy(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Post operation to " + TriggerRepositoryDrivenUcUpgradeServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            
        }
    }
}
