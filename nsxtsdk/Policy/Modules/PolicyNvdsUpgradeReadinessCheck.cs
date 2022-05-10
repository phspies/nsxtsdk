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
    public class PolicyNvdsUpgradeReadinessCheck
    {
        private RestClient restClient;
        private int retry;
        private int timeout;
        private CancellationToken cancellationToken;

        public PolicyNvdsUpgradeReadinessCheck(RestClient Client, CancellationToken _cancellationToken, int _timeout, int _retry)
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
        public async Task<NSXTUpgradeTopologyType> PolicySetTargetVdsTopology(NSXTUpgradeTopologyType UpgradeTopology, string? ClusterId = null, bool? UseRecommendedTopologyConfig = null)
        {
            if (UpgradeTopology == null) { throw new System.ArgumentNullException("UpgradeTopology cannot be null"); }
            StringBuilder PolicySetTargetVdsTopologyServiceURL = new StringBuilder("/infra/nvds-urt/topology?action=apply");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Put
            };
            request.AddJsonBody(UpgradeTopology);
            if (ClusterId != null) { request.AddQueryParameter("cluster_id", ClusterId.ToString()); }
            if (UseRecommendedTopologyConfig != null) { request.AddQueryParameter("use_recommended_topology_config", UseRecommendedTopologyConfig.ToString()); }
            request.Resource = PolicySetTargetVdsTopologyServiceURL.ToString();
            RestResponse<NSXTUpgradeTopologyType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTUpgradeTopologyType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Put operation to " + PolicySetTargetVdsTopologyServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task PolicyNvdsUpgradeCleanup()
        {
            StringBuilder PolicyNvdsUpgradeCleanupServiceURL = new StringBuilder("/infra/nvds-urt?action=cleanup");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Put
            };
            request.Resource = PolicyNvdsUpgradeCleanupServiceURL.ToString();
            RestResponse response = await restClient.ExecuteTaskAsyncWithPolicy(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Put operation to " + PolicyNvdsUpgradeCleanupServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTNvdsUpgradePrecheckIdType> PolicyCreateNvdsUpgradePrecheckByClusters(NSXTPrecheckParametersType PrecheckParameters)
        {
            if (PrecheckParameters == null) { throw new System.ArgumentNullException("PrecheckParameters cannot be null"); }
            StringBuilder PolicyCreateNvdsUpgradePrecheckByClustersServiceURL = new StringBuilder("/infra/nvds-urt/precheck-by-clusters");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Put
            };
            request.AddJsonBody(PrecheckParameters);
            request.Resource = PolicyCreateNvdsUpgradePrecheckByClustersServiceURL.ToString();
            RestResponse<NSXTNvdsUpgradePrecheckIdType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTNvdsUpgradePrecheckIdType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Put operation to " + PolicyCreateNvdsUpgradePrecheckByClustersServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTNvdsUpgradePrecheckIdType> PolicyCreateNvdsUpgradePrecheck()
        {
            StringBuilder PolicyCreateNvdsUpgradePrecheckServiceURL = new StringBuilder("/infra/nvds-urt/precheck");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Put
            };
            request.Resource = PolicyCreateNvdsUpgradePrecheckServiceURL.ToString();
            RestResponse<NSXTNvdsUpgradePrecheckIdType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTNvdsUpgradePrecheckIdType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Put operation to " + PolicyCreateNvdsUpgradePrecheckServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTNvdsUpgradePrecheckIdType> PolicyGetNvdsUpgradePrecheckId()
        {
            StringBuilder PolicyGetNvdsUpgradePrecheckIdServiceURL = new StringBuilder("/infra/nvds-urt/precheck");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Get
            };
            request.Resource = PolicyGetNvdsUpgradePrecheckIdServiceURL.ToString();
            RestResponse<NSXTNvdsUpgradePrecheckIdType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTNvdsUpgradePrecheckIdType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Get operation to " + PolicyGetNvdsUpgradePrecheckIdServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task PolicyIgnoreMigrateStatus()
        {
            StringBuilder PolicyIgnoreMigrateStatusServiceURL = new StringBuilder("/infra/nvds-urt?action=ignore_migrate_status");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Put
            };
            request.Resource = PolicyIgnoreMigrateStatusServiceURL.ToString();
            RestResponse response = await restClient.ExecuteTaskAsyncWithPolicy(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Put operation to " + PolicyIgnoreMigrateStatusServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTNvdsUpgradeStatusSummaryType> PolicyGetNvdsUpgradeReadinessCheckSummary(string PrecheckId, string? ClusterId = null)
        {
            if (PrecheckId == null) { throw new System.ArgumentNullException("PrecheckId cannot be null"); }
            StringBuilder PolicyGetNvdsUpgradeReadinessCheckSummaryServiceURL = new StringBuilder("/infra/nvds-urt/status-summary/{precheck-id}");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Get
            };
            PolicyGetNvdsUpgradeReadinessCheckSummaryServiceURL.Replace("{precheck-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(PrecheckId, System.Globalization.CultureInfo.InvariantCulture)));
            if (ClusterId != null) { request.AddQueryParameter("cluster_id", ClusterId.ToString()); }
            request.Resource = PolicyGetNvdsUpgradeReadinessCheckSummaryServiceURL.ToString();
            RestResponse<NSXTNvdsUpgradeStatusSummaryType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTNvdsUpgradeStatusSummaryType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Get operation to " + PolicyGetNvdsUpgradeReadinessCheckSummaryServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTUpgradeTopologyType> PolicyGetRecommendedVdsTopology(string PrecheckId, string? ClusterId = null, string? ComputeManagerId = null, bool? ShowVdsConfig = null)
        {
            if (PrecheckId == null) { throw new System.ArgumentNullException("PrecheckId cannot be null"); }
            StringBuilder PolicyGetRecommendedVdsTopologyServiceURL = new StringBuilder("/infra/nvds-urt/topology/{precheck-id}");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Get
            };
            PolicyGetRecommendedVdsTopologyServiceURL.Replace("{precheck-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(PrecheckId, System.Globalization.CultureInfo.InvariantCulture)));
            if (ClusterId != null) { request.AddQueryParameter("cluster_id", ClusterId.ToString()); }
            if (ComputeManagerId != null) { request.AddQueryParameter("compute_manager_id", ComputeManagerId.ToString()); }
            if (ShowVdsConfig != null) { request.AddQueryParameter("show_vds_config", ShowVdsConfig.ToString()); }
            request.Resource = PolicyGetRecommendedVdsTopologyServiceURL.ToString();
            RestResponse<NSXTUpgradeTopologyType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTUpgradeTopologyType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Get operation to " + PolicyGetRecommendedVdsTopologyServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
    }
}
