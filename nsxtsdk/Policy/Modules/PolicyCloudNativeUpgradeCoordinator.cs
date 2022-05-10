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
    public class PolicyCloudNativeUpgradeCoordinator
    {
        private RestClient restClient;
        private int retry;
        private int timeout;
        private CancellationToken cancellationToken;

        public PolicyCloudNativeUpgradeCoordinator(RestClient Client, CancellationToken _cancellationToken, int _timeout, int _retry)
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
        public async Task<NSXTDeploymentChecksStatusResultType> GetUcdeploymentChecksStatus(string SiteId)
        {
            if (SiteId == null) { throw new System.ArgumentNullException("SiteId cannot be null"); }
            StringBuilder GetUcdeploymentChecksStatusServiceURL = new StringBuilder("/infra/sites/{site-id}/napp/deployment/upgrade-coordinator/checks/status");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Get
            };
            GetUcdeploymentChecksStatusServiceURL.Replace("{site-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(SiteId, System.Globalization.CultureInfo.InvariantCulture)));
            request.Resource = GetUcdeploymentChecksStatusServiceURL.ToString();
            RestResponse<NSXTDeploymentChecksStatusResultType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTDeploymentChecksStatusResultType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Get operation to " + GetUcdeploymentChecksStatusServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTDeploymentProgressStatusType> GetUpgradeCoordinatorDeploymentProgressStatus(string SiteId)
        {
            if (SiteId == null) { throw new System.ArgumentNullException("SiteId cannot be null"); }
            StringBuilder GetUpgradeCoordinatorDeploymentProgressStatusServiceURL = new StringBuilder("/infra/sites/{site-id}/napp/deployment/upgrade-coordinator/status");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Get
            };
            GetUpgradeCoordinatorDeploymentProgressStatusServiceURL.Replace("{site-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(SiteId, System.Globalization.CultureInfo.InvariantCulture)));
            request.Resource = GetUpgradeCoordinatorDeploymentProgressStatusServiceURL.ToString();
            RestResponse<NSXTDeploymentProgressStatusType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTDeploymentProgressStatusType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Get operation to " + GetUpgradeCoordinatorDeploymentProgressStatusServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTDeploymentVersionsType> GetAvailableUcversions(string SiteId)
        {
            if (SiteId == null) { throw new System.ArgumentNullException("SiteId cannot be null"); }
            StringBuilder GetAvailableUcversionsServiceURL = new StringBuilder("/infra/sites/{site-id}/napp/deployment/upgrade-coordinator/versions");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Get
            };
            GetAvailableUcversionsServiceURL.Replace("{site-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(SiteId, System.Globalization.CultureInfo.InvariantCulture)));
            request.Resource = GetAvailableUcversionsServiceURL.ToString();
            RestResponse<NSXTDeploymentVersionsType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTDeploymentVersionsType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Get operation to " + GetAvailableUcversionsServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task RunUcdeploymentChecks(string SiteId, NSXTDeploymentChecksActionType DeploymentChecksAction)
        {
            if (SiteId == null) { throw new System.ArgumentNullException("SiteId cannot be null"); }
            if (DeploymentChecksAction == null) { throw new System.ArgumentNullException("DeploymentChecksAction cannot be null"); }
            StringBuilder RunUcdeploymentChecksServiceURL = new StringBuilder("/infra/sites/{site-id}/napp/deployment/upgrade-coordinator/checks");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Put
            };
            RunUcdeploymentChecksServiceURL.Replace("{site-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(SiteId, System.Globalization.CultureInfo.InvariantCulture)));
            request.AddJsonBody(DeploymentChecksAction);
            request.Resource = RunUcdeploymentChecksServiceURL.ToString();
            RestResponse response = await restClient.ExecuteTaskAsyncWithPolicy(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Put operation to " + RunUcdeploymentChecksServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTUpgradeCoordinatorDeploymentConfigType> UpdateUpgradeCoordinatorDeploymentConfig(string SiteId, NSXTUpgradeCoordinatorDeploymentConfigType UpgradeCoordinatorDeploymentConfig)
        {
            if (SiteId == null) { throw new System.ArgumentNullException("SiteId cannot be null"); }
            if (UpgradeCoordinatorDeploymentConfig == null) { throw new System.ArgumentNullException("UpgradeCoordinatorDeploymentConfig cannot be null"); }
            StringBuilder UpdateUpgradeCoordinatorDeploymentConfigServiceURL = new StringBuilder("/infra/sites/{site-id}/napp/deployment/upgrade-coordinator");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Patch
            };
            UpdateUpgradeCoordinatorDeploymentConfigServiceURL.Replace("{site-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(SiteId, System.Globalization.CultureInfo.InvariantCulture)));
            request.AddJsonBody(UpgradeCoordinatorDeploymentConfig);
            request.Resource = UpdateUpgradeCoordinatorDeploymentConfigServiceURL.ToString();
            RestResponse<NSXTUpgradeCoordinatorDeploymentConfigType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTUpgradeCoordinatorDeploymentConfigType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Patch operation to " + UpdateUpgradeCoordinatorDeploymentConfigServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTUpgradeCoordinatorDeploymentConfigType> GetUpgradeCoordinatorDeploymentConfig(string SiteId)
        {
            if (SiteId == null) { throw new System.ArgumentNullException("SiteId cannot be null"); }
            StringBuilder GetUpgradeCoordinatorDeploymentConfigServiceURL = new StringBuilder("/infra/sites/{site-id}/napp/deployment/upgrade-coordinator");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Get
            };
            GetUpgradeCoordinatorDeploymentConfigServiceURL.Replace("{site-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(SiteId, System.Globalization.CultureInfo.InvariantCulture)));
            request.Resource = GetUpgradeCoordinatorDeploymentConfigServiceURL.ToString();
            RestResponse<NSXTUpgradeCoordinatorDeploymentConfigType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTUpgradeCoordinatorDeploymentConfigType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Get operation to " + GetUpgradeCoordinatorDeploymentConfigServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
    }
}
