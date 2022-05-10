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
    public class ManagementPlaneModule
    {
        private RestClient restClient;
        private int retry;
        private int timeout;
        private CancellationToken cancellationToken;

        public ManagementPlaneModule(RestClient Client, CancellationToken _cancellationToken, int _timeout, int _retry)
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
        public async Task<NSXTManagementPlanePropertiesType> UpdateManagementPlaneConfiguration(NSXTManagementPlanePropertiesType ManagementPlaneProperties)
        {
            if (ManagementPlaneProperties == null) { throw new System.ArgumentNullException("ManagementPlaneProperties cannot be null"); }
            StringBuilder UpdateManagementPlaneConfigurationServiceURL = new StringBuilder("/node/management-plane");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Put
            };
            request.AddJsonBody(ManagementPlaneProperties);
            request.Resource = UpdateManagementPlaneConfigurationServiceURL.ToString();
            RestResponse<NSXTManagementPlanePropertiesType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTManagementPlanePropertiesType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Put operation to " + UpdateManagementPlaneConfigurationServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTManagementPlanePropertiesType> ReadManagementPlaneConfiguration()
        {
            StringBuilder ReadManagementPlaneConfigurationServiceURL = new StringBuilder("/node/management-plane");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Get
            };
            request.Resource = ReadManagementPlaneConfigurationServiceURL.ToString();
            RestResponse<NSXTManagementPlanePropertiesType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTManagementPlanePropertiesType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Get operation to " + ReadManagementPlaneConfigurationServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task DeleteManagementPlaneConfiguration()
        {
            StringBuilder DeleteManagementPlaneConfigurationServiceURL = new StringBuilder("/node/management-plane");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Delete
            };
            request.Resource = DeleteManagementPlaneConfigurationServiceURL.ToString();
            RestResponse response = await restClient.ExecuteTaskAsyncWithPolicy(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Delete operation to " + DeleteManagementPlaneConfigurationServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            
        }
    }
}
