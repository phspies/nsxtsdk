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
    public class UpgradeNodeActions
    {
        private RestClient restClient;
        private int retry;
        private int timeout;
        private CancellationToken cancellationToken;

        public UpgradeNodeActions(RestClient Client, CancellationToken _cancellationToken, int _timeout, int _retry)
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
        public async Task<NSXTUpgradeProgressStatusType> GetUpgradeProgressStatus()
        {
            StringBuilder GetUpgradeProgressStatusServiceURL = new StringBuilder("/node/upgrade/progress-status");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Get
            };
            request.Resource = GetUpgradeProgressStatusServiceURL.ToString();
            RestResponse<NSXTUpgradeProgressStatusType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTUpgradeProgressStatusType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Get operation to " + GetUpgradeProgressStatusServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTUpgradeTaskPropertiesType> ExecuteUpgradeTask(NSXTUpgradeTaskPropertiesType UpgradeTaskProperties, string? Action = null)
        {
            if (UpgradeTaskProperties == null) { throw new System.ArgumentNullException("UpgradeTaskProperties cannot be null"); }
            StringBuilder ExecuteUpgradeTaskServiceURL = new StringBuilder("/node/upgrade/performtask");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Post
            };
            request.AddJsonBody(UpgradeTaskProperties);
            if (Action != null) { request.AddQueryParameter("action", Action.ToString()); }
            request.Resource = ExecuteUpgradeTaskServiceURL.ToString();
            RestResponse<NSXTUpgradeTaskPropertiesType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTUpgradeTaskPropertiesType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Post operation to " + ExecuteUpgradeTaskServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTUpgradeStatusSummaryType> GetNodeUpgradeStatusSummary()
        {
            StringBuilder GetNodeUpgradeStatusSummaryServiceURL = new StringBuilder("/node/upgrade/status-summary");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Get
            };
            request.Resource = GetNodeUpgradeStatusSummaryServiceURL.ToString();
            RestResponse<NSXTUpgradeStatusSummaryType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTUpgradeStatusSummaryType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Get operation to " + GetNodeUpgradeStatusSummaryServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTUpgradeTaskPropertiesType> GetUpgradeTaskStatus(string? BundleName = null, string? UpgradeTaskId = null)
        {
            StringBuilder GetUpgradeTaskStatusServiceURL = new StringBuilder("/node/upgrade");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Get
            };
            if (BundleName != null) { request.AddQueryParameter("bundle_name", BundleName.ToString()); }
            if (UpgradeTaskId != null) { request.AddQueryParameter("upgrade_task_id", UpgradeTaskId.ToString()); }
            request.Resource = GetUpgradeTaskStatusServiceURL.ToString();
            RestResponse<NSXTUpgradeTaskPropertiesType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTUpgradeTaskPropertiesType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Get operation to " + GetUpgradeTaskStatusServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
    }
}
