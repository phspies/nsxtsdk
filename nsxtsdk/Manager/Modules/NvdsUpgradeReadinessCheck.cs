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
    public class NvdsUpgradeReadinessCheck
    {
        private RestClient restClient;
        private int retry;
        private int timeout;
        private CancellationToken cancellationToken;

        public NvdsUpgradeReadinessCheck(RestClient Client, CancellationToken _cancellationToken, int _timeout, int _retry)
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
        public async Task<NSXTNvdsUpgradePrecheckIdType> CreateNvdsUpgradePrecheck()
        {
            StringBuilder CreateNvdsUpgradePrecheckServiceURL = new StringBuilder("/nvds-urt/precheck");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Post
            };
            request.Resource = CreateNvdsUpgradePrecheckServiceURL.ToString();
            RestResponse<NSXTNvdsUpgradePrecheckIdType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTNvdsUpgradePrecheckIdType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Post operation to " + CreateNvdsUpgradePrecheckServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTNvdsUpgradePrecheckIdType> GetNvdsUpgradePrecheckId()
        {
            StringBuilder GetNvdsUpgradePrecheckIdServiceURL = new StringBuilder("/nvds-urt/precheck");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Get
            };
            request.Resource = GetNvdsUpgradePrecheckIdServiceURL.ToString();
            RestResponse<NSXTNvdsUpgradePrecheckIdType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTNvdsUpgradePrecheckIdType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Get operation to " + GetNvdsUpgradePrecheckIdServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task IgnoreMigrateStatus()
        {
            StringBuilder IgnoreMigrateStatusServiceURL = new StringBuilder("/nvds-urt?action=ignore_migrate_status");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Post
            };
            request.Resource = IgnoreMigrateStatusServiceURL.ToString();
            RestResponse response = await restClient.ExecuteTaskAsyncWithPolicy(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Post operation to " + IgnoreMigrateStatusServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTNvdsUpgradePrecheckIdType> CreateNvdsUpgradePrecheckByClusters(NSXTPrecheckParametersType PrecheckParameters)
        {
            if (PrecheckParameters == null) { throw new System.ArgumentNullException("PrecheckParameters cannot be null"); }
            StringBuilder CreateNvdsUpgradePrecheckByClustersServiceURL = new StringBuilder("/nvds-urt/precheck-by-clusters");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Post
            };
            request.AddJsonBody(PrecheckParameters);
            request.Resource = CreateNvdsUpgradePrecheckByClustersServiceURL.ToString();
            RestResponse<NSXTNvdsUpgradePrecheckIdType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTNvdsUpgradePrecheckIdType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Post operation to " + CreateNvdsUpgradePrecheckByClustersServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTNvdsUpgradeStatusSummaryType> GetNvdsUpgradeReadinessCheckSummary(string PrecheckId, string? ClusterId = null)
        {
            if (PrecheckId == null) { throw new System.ArgumentNullException("PrecheckId cannot be null"); }
            StringBuilder GetNvdsUpgradeReadinessCheckSummaryServiceURL = new StringBuilder("/nvds-urt/status-summary/{precheck-id}");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Get
            };
            GetNvdsUpgradeReadinessCheckSummaryServiceURL.Replace("{precheck-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(PrecheckId, System.Globalization.CultureInfo.InvariantCulture)));
            if (ClusterId != null) { request.AddQueryParameter("cluster_id", ClusterId.ToString()); }
            request.Resource = GetNvdsUpgradeReadinessCheckSummaryServiceURL.ToString();
            RestResponse<NSXTNvdsUpgradeStatusSummaryType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTNvdsUpgradeStatusSummaryType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Get operation to " + GetNvdsUpgradeReadinessCheckSummaryServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task NvdsUpgradeCleanup()
        {
            StringBuilder NvdsUpgradeCleanupServiceURL = new StringBuilder("/nvds-urt?action=cleanup");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Post
            };
            request.Resource = NvdsUpgradeCleanupServiceURL.ToString();
            RestResponse response = await restClient.ExecuteTaskAsyncWithPolicy(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Post operation to " + NvdsUpgradeCleanupServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTUpgradeTopologyType> SetTargetVdsTopology(NSXTUpgradeTopologyType UpgradeTopology, string? ClusterId = null, bool? UseRecommendedTopologyConfig = null)
        {
            if (UpgradeTopology == null) { throw new System.ArgumentNullException("UpgradeTopology cannot be null"); }
            StringBuilder SetTargetVdsTopologyServiceURL = new StringBuilder("/nvds-urt/topology?action=apply");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Post
            };
            request.AddJsonBody(UpgradeTopology);
            if (ClusterId != null) { request.AddQueryParameter("cluster_id", ClusterId.ToString()); }
            if (UseRecommendedTopologyConfig != null) { request.AddQueryParameter("use_recommended_topology_config", UseRecommendedTopologyConfig.ToString()); }
            request.Resource = SetTargetVdsTopologyServiceURL.ToString();
            RestResponse<NSXTUpgradeTopologyType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTUpgradeTopologyType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Post operation to " + SetTargetVdsTopologyServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTUpgradeTopologyType> GetRecommendedVdsTopology(string PrecheckId, string? ClusterId = null, string? ComputeManagerId = null, bool? ShowVdsConfig = null)
        {
            if (PrecheckId == null) { throw new System.ArgumentNullException("PrecheckId cannot be null"); }
            StringBuilder GetRecommendedVdsTopologyServiceURL = new StringBuilder("/nvds-urt/topology/{precheck-id}");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Get
            };
            GetRecommendedVdsTopologyServiceURL.Replace("{precheck-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(PrecheckId, System.Globalization.CultureInfo.InvariantCulture)));
            if (ClusterId != null) { request.AddQueryParameter("cluster_id", ClusterId.ToString()); }
            if (ComputeManagerId != null) { request.AddQueryParameter("compute_manager_id", ComputeManagerId.ToString()); }
            if (ShowVdsConfig != null) { request.AddQueryParameter("show_vds_config", ShowVdsConfig.ToString()); }
            request.Resource = GetRecommendedVdsTopologyServiceURL.ToString();
            RestResponse<NSXTUpgradeTopologyType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTUpgradeTopologyType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Get operation to " + GetRecommendedVdsTopologyServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
    }
}
