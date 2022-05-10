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
    public class TelemetryConfig
    {
        private RestClient restClient;
        private int retry;
        private int timeout;
        private CancellationToken cancellationToken;

        public TelemetryConfig(RestClient Client, CancellationToken _cancellationToken, int _timeout, int _retry)
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
        public async Task<NSXTTelemetryConfigType> UpdateTelemetryConfig(NSXTTelemetryConfigType TelemetryConfig)
        {
            if (TelemetryConfig == null) { throw new System.ArgumentNullException("TelemetryConfig cannot be null"); }
            StringBuilder UpdateTelemetryConfigServiceURL = new StringBuilder("/telemetry/config");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Put
            };
            request.AddJsonBody(TelemetryConfig);
            request.Resource = UpdateTelemetryConfigServiceURL.ToString();
            RestResponse<NSXTTelemetryConfigType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTTelemetryConfigType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Put operation to " + UpdateTelemetryConfigServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTTelemetryConfigType> GetTelemetryConfig()
        {
            StringBuilder GetTelemetryConfigServiceURL = new StringBuilder("/telemetry/config");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Get
            };
            request.Resource = GetTelemetryConfigServiceURL.ToString();
            RestResponse<NSXTTelemetryConfigType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTTelemetryConfigType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Get operation to " + GetTelemetryConfigServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTTelemetryAgreementType> UpdateTelemetryAgreement(NSXTTelemetryAgreementType TelemetryAgreement)
        {
            if (TelemetryAgreement == null) { throw new System.ArgumentNullException("TelemetryAgreement cannot be null"); }
            StringBuilder UpdateTelemetryAgreementServiceURL = new StringBuilder("/telemetry/agreement");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Put
            };
            request.AddJsonBody(TelemetryAgreement);
            request.Resource = UpdateTelemetryAgreementServiceURL.ToString();
            RestResponse<NSXTTelemetryAgreementType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTTelemetryAgreementType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Put operation to " + UpdateTelemetryAgreementServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTTelemetryAgreementType> GetTelemetryAgreement()
        {
            StringBuilder GetTelemetryAgreementServiceURL = new StringBuilder("/telemetry/agreement");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Get
            };
            request.Resource = GetTelemetryAgreementServiceURL.ToString();
            RestResponse<NSXTTelemetryAgreementType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTTelemetryAgreementType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Get operation to " + GetTelemetryAgreementServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
    }
}
