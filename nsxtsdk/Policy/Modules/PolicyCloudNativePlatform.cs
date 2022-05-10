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
    public class PolicyCloudNativePlatform
    {
        private RestClient restClient;
        private int retry;
        private int timeout;
        private CancellationToken cancellationToken;

        public PolicyCloudNativePlatform(RestClient Client, CancellationToken _cancellationToken, int _timeout, int _retry)
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
        public async Task<NSXTPlatformFormFactorsType> GetAvailableFormFactors(string SiteId)
        {
            if (SiteId == null) { throw new System.ArgumentNullException("SiteId cannot be null"); }
            StringBuilder GetAvailableFormFactorsServiceURL = new StringBuilder("/infra/sites/{site-id}/napp/deployment/platform/form-factors");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Get
            };
            GetAvailableFormFactorsServiceURL.Replace("{site-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(SiteId, System.Globalization.CultureInfo.InvariantCulture)));
            request.Resource = GetAvailableFormFactorsServiceURL.ToString();
            RestResponse<NSXTPlatformFormFactorsType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTPlatformFormFactorsType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Get operation to " + GetAvailableFormFactorsServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTDeploymentVersionsType> GetAvailableVersions(string SiteId)
        {
            if (SiteId == null) { throw new System.ArgumentNullException("SiteId cannot be null"); }
            StringBuilder GetAvailableVersionsServiceURL = new StringBuilder("/infra/sites/{site-id}/napp/deployment/platform/versions");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Get
            };
            GetAvailableVersionsServiceURL.Replace("{site-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(SiteId, System.Globalization.CultureInfo.InvariantCulture)));
            request.Resource = GetAvailableVersionsServiceURL.ToString();
            RestResponse<NSXTDeploymentVersionsType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTDeploymentVersionsType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Get operation to " + GetAvailableVersionsServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTDeploymentChecksStatusResultType> GetPlatformDeploymentChecksStatus(string SiteId)
        {
            if (SiteId == null) { throw new System.ArgumentNullException("SiteId cannot be null"); }
            StringBuilder GetPlatformDeploymentChecksStatusServiceURL = new StringBuilder("/infra/sites/{site-id}/napp/deployment/platform/checks/status");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Get
            };
            GetPlatformDeploymentChecksStatusServiceURL.Replace("{site-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(SiteId, System.Globalization.CultureInfo.InvariantCulture)));
            request.Resource = GetPlatformDeploymentChecksStatusServiceURL.ToString();
            RestResponse<NSXTDeploymentChecksStatusResultType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTDeploymentChecksStatusResultType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Get operation to " + GetPlatformDeploymentChecksStatusServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTDeploymentProgressStatusType> PlatformDeploymentProgress(string SiteId)
        {
            if (SiteId == null) { throw new System.ArgumentNullException("SiteId cannot be null"); }
            StringBuilder PlatformDeploymentProgressServiceURL = new StringBuilder("/infra/sites/{site-id}/napp/deployment/platform/status");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Get
            };
            PlatformDeploymentProgressServiceURL.Replace("{site-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(SiteId, System.Globalization.CultureInfo.InvariantCulture)));
            request.Resource = PlatformDeploymentProgressServiceURL.ToString();
            RestResponse<NSXTDeploymentProgressStatusType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTDeploymentProgressStatusType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Get operation to " + PlatformDeploymentProgressServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task RunDeploymentChecks(string SiteId, NSXTPlatformDeploymentChecksActionType PlatformDeploymentChecksAction)
        {
            if (SiteId == null) { throw new System.ArgumentNullException("SiteId cannot be null"); }
            if (PlatformDeploymentChecksAction == null) { throw new System.ArgumentNullException("PlatformDeploymentChecksAction cannot be null"); }
            StringBuilder RunDeploymentChecksServiceURL = new StringBuilder("/infra/sites/{site-id}/napp/deployment/platform/checks");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Put
            };
            RunDeploymentChecksServiceURL.Replace("{site-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(SiteId, System.Globalization.CultureInfo.InvariantCulture)));
            request.AddJsonBody(PlatformDeploymentChecksAction);
            request.Resource = RunDeploymentChecksServiceURL.ToString();
            RestResponse response = await restClient.ExecuteTaskAsyncWithPolicy(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Put operation to " + RunDeploymentChecksServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTPlatformDeploymentConfigType> UpdatePlatformDeploymentConfig(string SiteId, NSXTPlatformDeploymentConfigType PlatformDeploymentConfig)
        {
            if (SiteId == null) { throw new System.ArgumentNullException("SiteId cannot be null"); }
            if (PlatformDeploymentConfig == null) { throw new System.ArgumentNullException("PlatformDeploymentConfig cannot be null"); }
            StringBuilder UpdatePlatformDeploymentConfigServiceURL = new StringBuilder("/infra/sites/{site-id}/napp/deployment/platform");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Patch
            };
            UpdatePlatformDeploymentConfigServiceURL.Replace("{site-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(SiteId, System.Globalization.CultureInfo.InvariantCulture)));
            request.AddJsonBody(PlatformDeploymentConfig);
            request.Resource = UpdatePlatformDeploymentConfigServiceURL.ToString();
            RestResponse<NSXTPlatformDeploymentConfigType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTPlatformDeploymentConfigType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Patch operation to " + UpdatePlatformDeploymentConfigServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTPlatformDeploymentConfigType> GetPlatformDeploymentConfig(string SiteId)
        {
            if (SiteId == null) { throw new System.ArgumentNullException("SiteId cannot be null"); }
            StringBuilder GetPlatformDeploymentConfigServiceURL = new StringBuilder("/infra/sites/{site-id}/napp/deployment/platform");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Get
            };
            GetPlatformDeploymentConfigServiceURL.Replace("{site-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(SiteId, System.Globalization.CultureInfo.InvariantCulture)));
            request.Resource = GetPlatformDeploymentConfigServiceURL.ToString();
            RestResponse<NSXTPlatformDeploymentConfigType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTPlatformDeploymentConfigType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Get operation to " + GetPlatformDeploymentConfigServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
    }
}
