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
    public class VersionWhitelist
    {
        private RestClient restClient;
        private int retry;
        private int timeout;
        private CancellationToken cancellationToken;

        public VersionWhitelist(RestClient Client, CancellationToken _cancellationToken, int _timeout, int _retry)
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
        public async Task<NSXTAcceptableComponentVersionListType> GetVersionWhitelist()
        {
            StringBuilder GetVersionWhitelistServiceURL = new StringBuilder("/upgrade/version-whitelist");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Get
            };
            request.Resource = GetVersionWhitelistServiceURL.ToString();
            RestResponse<NSXTAcceptableComponentVersionListType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTAcceptableComponentVersionListType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Get operation to " + GetVersionWhitelistServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task UpdateVersionWhitelist(string ComponentType, NSXTVersionListType VersionList)
        {
            if (ComponentType == null) { throw new System.ArgumentNullException("ComponentType cannot be null"); }
            if (VersionList == null) { throw new System.ArgumentNullException("VersionList cannot be null"); }
            StringBuilder UpdateVersionWhitelistServiceURL = new StringBuilder("/upgrade/version-whitelist/{component_type}");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Put
            };
            UpdateVersionWhitelistServiceURL.Replace("{component_type}", System.Uri.EscapeDataString(Helpers.ConvertToString(ComponentType, System.Globalization.CultureInfo.InvariantCulture)));
            request.AddJsonBody(VersionList);
            request.Resource = UpdateVersionWhitelistServiceURL.ToString();
            RestResponse response = await restClient.ExecuteTaskAsyncWithPolicy(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Put operation to " + UpdateVersionWhitelistServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTAcceptableComponentVersionType> GetVersionWhitelistByComponent(string ComponentType)
        {
            if (ComponentType == null) { throw new System.ArgumentNullException("ComponentType cannot be null"); }
            StringBuilder GetVersionWhitelistByComponentServiceURL = new StringBuilder("/upgrade/version-whitelist/{component_type}");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Get
            };
            GetVersionWhitelistByComponentServiceURL.Replace("{component_type}", System.Uri.EscapeDataString(Helpers.ConvertToString(ComponentType, System.Globalization.CultureInfo.InvariantCulture)));
            request.Resource = GetVersionWhitelistByComponentServiceURL.ToString();
            RestResponse<NSXTAcceptableComponentVersionType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTAcceptableComponentVersionType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Get operation to " + GetVersionWhitelistByComponentServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
    }
}
