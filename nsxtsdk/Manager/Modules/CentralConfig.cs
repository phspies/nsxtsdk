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
    public class CentralConfig
    {
        private RestClient restClient;
        private int retry;
        private int timeout;
        private CancellationToken cancellationToken;

        public CentralConfig(RestClient Client, CancellationToken _cancellationToken, int _timeout, int _retry)
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
        public async Task<NSXTCentralNodeConfigProfileType> UpdateCentralNodeConfigProfile(string NodeConfigProfileId, NSXTCentralNodeConfigProfileType CentralNodeConfigProfile)
        {
            if (NodeConfigProfileId == null) { throw new System.ArgumentNullException("NodeConfigProfileId cannot be null"); }
            if (CentralNodeConfigProfile == null) { throw new System.ArgumentNullException("CentralNodeConfigProfile cannot be null"); }
            StringBuilder UpdateCentralNodeConfigProfileServiceURL = new StringBuilder("/configs/central-config/node-config-profiles/{node-config-profile-id}");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Put
            };
            UpdateCentralNodeConfigProfileServiceURL.Replace("{node-config-profile-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(NodeConfigProfileId, System.Globalization.CultureInfo.InvariantCulture)));
            request.AddJsonBody(CentralNodeConfigProfile);
            request.Resource = UpdateCentralNodeConfigProfileServiceURL.ToString();
            RestResponse<NSXTCentralNodeConfigProfileType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTCentralNodeConfigProfileType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Put operation to " + UpdateCentralNodeConfigProfileServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTCentralNodeConfigProfileListResultType> ListCentralNodeConfigProfiles()
        {
            StringBuilder ListCentralNodeConfigProfilesServiceURL = new StringBuilder("/configs/central-config/node-config-profiles");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Get
            };
            request.Resource = ListCentralNodeConfigProfilesServiceURL.ToString();
            RestResponse<NSXTCentralNodeConfigProfileListResultType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTCentralNodeConfigProfileListResultType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Get operation to " + ListCentralNodeConfigProfilesServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTCentralNodeConfigProfileType> ReadCentralNodeConfigProfile(string ProfileId, bool? ShowSensitiveData = null)
        {
            if (ProfileId == null) { throw new System.ArgumentNullException("ProfileId cannot be null"); }
            StringBuilder ReadCentralNodeConfigProfileServiceURL = new StringBuilder("/configs/central-config/node-config-profiles/{profile-id}");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Get
            };
            ReadCentralNodeConfigProfileServiceURL.Replace("{profile-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(ProfileId, System.Globalization.CultureInfo.InvariantCulture)));
            if (ShowSensitiveData != null) { request.AddQueryParameter("show_sensitive_data", ShowSensitiveData.ToString()); }
            request.Resource = ReadCentralNodeConfigProfileServiceURL.ToString();
            RestResponse<NSXTCentralNodeConfigProfileType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTCentralNodeConfigProfileType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Get operation to " + ReadCentralNodeConfigProfileServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTCentralConfigPropertiesType> UpdateCentralConfigProperties(NSXTCentralConfigPropertiesType CentralConfigProperties)
        {
            if (CentralConfigProperties == null) { throw new System.ArgumentNullException("CentralConfigProperties cannot be null"); }
            StringBuilder UpdateCentralConfigPropertiesServiceURL = new StringBuilder("/node/central-config");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Put
            };
            request.AddJsonBody(CentralConfigProperties);
            request.Resource = UpdateCentralConfigPropertiesServiceURL.ToString();
            RestResponse<NSXTCentralConfigPropertiesType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTCentralConfigPropertiesType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Put operation to " + UpdateCentralConfigPropertiesServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTCentralConfigPropertiesType> ReadCentralConfigProperties()
        {
            StringBuilder ReadCentralConfigPropertiesServiceURL = new StringBuilder("/node/central-config");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Get
            };
            request.Resource = ReadCentralConfigPropertiesServiceURL.ToString();
            RestResponse<NSXTCentralConfigPropertiesType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTCentralConfigPropertiesType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Get operation to " + ReadCentralConfigPropertiesServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
    }
}
