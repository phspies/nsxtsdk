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
    public class GlobalConfigs
    {
        private RestClient restClient;
        private int retry;
        private int timeout;
        private CancellationToken cancellationToken;

        public GlobalConfigs(RestClient Client, CancellationToken _cancellationToken, int _timeout, int _retry)
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
        public async Task<NSXTGlobalConfigsType> ResyncGlobalConfigs(string ConfigType, NSXTGlobalConfigsType GlobalConfigs)
        {
            if (ConfigType == null) { throw new System.ArgumentNullException("ConfigType cannot be null"); }
            if (GlobalConfigs == null) { throw new System.ArgumentNullException("GlobalConfigs cannot be null"); }
            StringBuilder ResyncGlobalConfigsServiceURL = new StringBuilder("/global-configs/{config-type}?action=resync_config");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Put
            };
            ResyncGlobalConfigsServiceURL.Replace("{config-type}", System.Uri.EscapeDataString(Helpers.ConvertToString(ConfigType, System.Globalization.CultureInfo.InvariantCulture)));
            request.AddJsonBody(GlobalConfigs);
            request.Resource = ResyncGlobalConfigsServiceURL.ToString();
            RestResponse<NSXTGlobalConfigsType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTGlobalConfigsType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Put operation to " + ResyncGlobalConfigsServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTGlobalConfigsType> UpdateGlobalConfigs(string ConfigType, NSXTGlobalConfigsType GlobalConfigs)
        {
            if (ConfigType == null) { throw new System.ArgumentNullException("ConfigType cannot be null"); }
            if (GlobalConfigs == null) { throw new System.ArgumentNullException("GlobalConfigs cannot be null"); }
            StringBuilder UpdateGlobalConfigsServiceURL = new StringBuilder("/global-configs/{config-type}");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Put
            };
            UpdateGlobalConfigsServiceURL.Replace("{config-type}", System.Uri.EscapeDataString(Helpers.ConvertToString(ConfigType, System.Globalization.CultureInfo.InvariantCulture)));
            request.AddJsonBody(GlobalConfigs);
            request.Resource = UpdateGlobalConfigsServiceURL.ToString();
            RestResponse<NSXTGlobalConfigsType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTGlobalConfigsType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Put operation to " + UpdateGlobalConfigsServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTGlobalConfigsType> GetGlobalConfigs(string ConfigType)
        {
            if (ConfigType == null) { throw new System.ArgumentNullException("ConfigType cannot be null"); }
            StringBuilder GetGlobalConfigsServiceURL = new StringBuilder("/global-configs/{config-type}");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Get
            };
            GetGlobalConfigsServiceURL.Replace("{config-type}", System.Uri.EscapeDataString(Helpers.ConvertToString(ConfigType, System.Globalization.CultureInfo.InvariantCulture)));
            request.Resource = GetGlobalConfigsServiceURL.ToString();
            RestResponse<NSXTGlobalConfigsType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTGlobalConfigsType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Get operation to " + GetGlobalConfigsServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTGlobalConfigsListResultType> ListGlobalConfigs()
        {
            StringBuilder ListGlobalConfigsServiceURL = new StringBuilder("/global-configs");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Get
            };
            request.Resource = ListGlobalConfigsServiceURL.ToString();
            RestResponse<NSXTGlobalConfigsListResultType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTGlobalConfigsListResultType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Get operation to " + ListGlobalConfigsServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
    }
}
