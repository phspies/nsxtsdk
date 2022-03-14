// <auto-generated>
// Changes may cause incorrect behavior and will be lost if the code is regenerated.
// </auto-generated>

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
        RestClient restClient;
        JsonSerializerSettings defaultSerializationSettings;
        int retry;
        int timeout;
        CancellationToken cancellationToken;
        public RegistrationTokenEndPoint(RestClient Client, JsonSerializerSettings DefaultSerializationSettings, CancellationToken _cancellationToken, int _timeout, int _retry)

        {
            restClient = Client;
            defaultSerializationSettings = DefaultSerializationSettings;
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
            NSXTRegistrationTokenType returnValue = default(NSXTRegistrationTokenType);
            StringBuilder CreateRegistrationTokenServiceURL = new StringBuilder("/aaa/registration-token");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.POST
            };
            request.AddHeader("Content-type", "application/json");
            request.Resource = CreateRegistrationTokenServiceURL.ToString();
            IRestResponse<NSXTRegistrationTokenType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTRegistrationTokenType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP POST operation to " + CreateRegistrationTokenServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, null);
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
                Method = Method.DELETE
            };
            request.AddHeader("Content-type", "application/json");
            DeleteRegistrationTokenServiceURL.Replace("{token}", System.Uri.EscapeDataString(Helpers.ConvertToString(Token, System.Globalization.CultureInfo.InvariantCulture)));
            request.Resource = DeleteRegistrationTokenServiceURL.ToString();
            IRestResponse response = await restClient.ExecuteTaskAsyncWithPolicy(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP DELETE operation to " + DeleteRegistrationTokenServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, null);
			}
            
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTRegistrationTokenType> GetRegistrationToken(string Token)
        {
            if (Token == null) { throw new System.ArgumentNullException("Token cannot be null"); }
            NSXTRegistrationTokenType returnValue = default(NSXTRegistrationTokenType);
            StringBuilder GetRegistrationTokenServiceURL = new StringBuilder("/aaa/registration-token/{token}");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.GET
            };
            request.AddHeader("Content-type", "application/json");
            GetRegistrationTokenServiceURL.Replace("{token}", System.Uri.EscapeDataString(Helpers.ConvertToString(Token, System.Globalization.CultureInfo.InvariantCulture)));
            request.Resource = GetRegistrationTokenServiceURL.ToString();
            IRestResponse<NSXTRegistrationTokenType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTRegistrationTokenType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP GET operation to " + GetRegistrationTokenServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, null);
			}
            return response.Data;
        }
    }
}
