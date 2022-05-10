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
    public class RegistrationTokenEndPoint
    {
        private RestClient restClient;
        private int retry;
        private int timeout;
        private CancellationToken cancellationToken;

        public RegistrationTokenEndPoint(RestClient Client, CancellationToken _cancellationToken, int _timeout, int _retry)
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
        public async Task<NSXTRegistrationTokenType> CreateRegistrationToken()
        {
            StringBuilder CreateRegistrationTokenServiceURL = new StringBuilder("/aaa/registration-token");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Post
            };
            request.Resource = CreateRegistrationTokenServiceURL.ToString();
            RestResponse<NSXTRegistrationTokenType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTRegistrationTokenType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Post operation to " + CreateRegistrationTokenServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task DeleteRegistrationToken(string Token)
        {
            if (Token == null) { throw new System.ArgumentNullException("Token cannot be null"); }
            StringBuilder DeleteRegistrationTokenServiceURL = new StringBuilder("/aaa/registration-token/{token}");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Delete
            };
            DeleteRegistrationTokenServiceURL.Replace("{token}", System.Uri.EscapeDataString(Helpers.ConvertToString(Token, System.Globalization.CultureInfo.InvariantCulture)));
            request.Resource = DeleteRegistrationTokenServiceURL.ToString();
            RestResponse response = await restClient.ExecuteTaskAsyncWithPolicy(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Delete operation to " + DeleteRegistrationTokenServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTRegistrationTokenType> GetRegistrationToken(string Token)
        {
            if (Token == null) { throw new System.ArgumentNullException("Token cannot be null"); }
            StringBuilder GetRegistrationTokenServiceURL = new StringBuilder("/aaa/registration-token/{token}");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Get
            };
            GetRegistrationTokenServiceURL.Replace("{token}", System.Uri.EscapeDataString(Helpers.ConvertToString(Token, System.Globalization.CultureInfo.InvariantCulture)));
            request.Resource = GetRegistrationTokenServiceURL.ToString();
            RestResponse<NSXTRegistrationTokenType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTRegistrationTokenType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Get operation to " + GetRegistrationTokenServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
    }
}
