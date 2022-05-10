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
    public class MPAConfigModule
    {
        private RestClient restClient;
        private int retry;
        private int timeout;
        private CancellationToken cancellationToken;

        public MPAConfigModule(RestClient Client, CancellationToken _cancellationToken, int _timeout, int _retry)
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
        public async Task<NSXTMPAConfigPropertiesType> UpdateMpaconfiguration(NSXTMPAConfigPropertiesType MpaconfigProperties)
        {
            if (MpaconfigProperties == null) { throw new System.ArgumentNullException("MpaconfigProperties cannot be null"); }
            StringBuilder UpdateMpaconfigurationServiceURL = new StringBuilder("/node/mpa-config");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Put
            };
            request.AddJsonBody(MpaconfigProperties);
            request.Resource = UpdateMpaconfigurationServiceURL.ToString();
            RestResponse<NSXTMPAConfigPropertiesType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTMPAConfigPropertiesType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Put operation to " + UpdateMpaconfigurationServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTMPAConfigPropertiesType> ReadMpaconfiguration()
        {
            StringBuilder ReadMpaconfigurationServiceURL = new StringBuilder("/node/mpa-config");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Get
            };
            request.Resource = ReadMpaconfigurationServiceURL.ToString();
            RestResponse<NSXTMPAConfigPropertiesType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTMPAConfigPropertiesType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Get operation to " + ReadMpaconfigurationServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task DeleteMpaconfiguration()
        {
            StringBuilder DeleteMpaconfigurationServiceURL = new StringBuilder("/node/mpa-config");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Delete
            };
            request.Resource = DeleteMpaconfigurationServiceURL.ToString();
            RestResponse response = await restClient.ExecuteTaskAsyncWithPolicy(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Delete operation to " + DeleteMpaconfigurationServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            
        }
    }
}
