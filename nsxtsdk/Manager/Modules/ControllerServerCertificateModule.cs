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
    public class ControllerServerCertificateModule
    {
        RestClient restClient;
        JsonSerializerSettings defaultSerializationSettings;
        int retry;
        int timeout;
        CancellationToken cancellationToken;
        public ControllerServerCertificateModule(RestClient Client, JsonSerializerSettings DefaultSerializationSettings, CancellationToken _cancellationToken, int _timeout, int _retry)

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
        public async Task<NSXTCertificateKeyPairType> ReadControllerServerCertificate()
        {
            NSXTCertificateKeyPairType returnValue = default(NSXTCertificateKeyPairType);
            StringBuilder ReadControllerServerCertificateServiceURL = new StringBuilder("/node/services/controller/controller-certificate");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.GET
            };
            request.AddHeader("Content-type", "application/json");
            request.Resource = ReadControllerServerCertificateServiceURL.ToString();
            IRestResponse<NSXTCertificateKeyPairType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTCertificateKeyPairType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP GET operation to " + ReadControllerServerCertificateServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, null);
			}
            return response.Data;
        }
    }
}
