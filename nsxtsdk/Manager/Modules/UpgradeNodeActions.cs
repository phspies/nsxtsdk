// <auto-generated>
// Changes may cause incorrect behavior and will be lost if the code is regenerated.
// </auto-generated>

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
        RestClient restClient;
        JsonSerializerSettings defaultSerializationSettings;
        public UpgradeNodeActions(RestClient Client, JsonSerializerSettings DefaultSerializationSettings)
        {
            restClient = Client;
            defaultSerializationSettings = DefaultSerializationSettings;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public NSXTUpgradeProgressStatusType GetUpgradeProgressStatus()
        {
            NSXTUpgradeProgressStatusType returnValue = default(NSXTUpgradeProgressStatusType);
            StringBuilder GetUpgradeProgressStatusServiceURL = new StringBuilder("/node/upgrade/progress-status");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.GET
            };
            request.AddHeader("Content-type", "application/json");
            request.Resource = GetUpgradeProgressStatusServiceURL.ToString();
            var response = restClient.Execute(request);
            if (response.StatusCode == HttpStatusCode.OK)
			{
                returnValue = JsonConvert.DeserializeObject<NSXTUpgradeProgressStatusType>(response.Content, defaultSerializationSettings);
			}
            else
            {
                throw new NSXTException(response.Content, response.StatusCode.ToString());
            }
            return returnValue;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public NSXTUpgradeTaskPropertiesType ExecuteUpgradeTask(NSXTUpgradeTaskPropertiesType UpgradeTaskProperties, string? Action = null)
        {
            if (UpgradeTaskProperties == null) { throw new System.ArgumentNullException("UpgradeTaskProperties cannot be null"); }
            NSXTUpgradeTaskPropertiesType returnValue = default(NSXTUpgradeTaskPropertiesType);
            StringBuilder ExecuteUpgradeTaskServiceURL = new StringBuilder("/node/upgrade/performtask");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.POST
            };
            request.AddHeader("Content-type", "application/json");
            request.AddJsonBody(JsonConvert.SerializeObject(UpgradeTaskProperties, defaultSerializationSettings));
            if (Action != null) { request.AddQueryParameter("action", Action.ToString()); }
            request.Resource = ExecuteUpgradeTaskServiceURL.ToString();
            var response = restClient.Execute(request);
            if (response.StatusCode == HttpStatusCode.OK)
			{
                returnValue = JsonConvert.DeserializeObject<NSXTUpgradeTaskPropertiesType>(response.Content, defaultSerializationSettings);
			}
            else
            {
                throw new NSXTException(response.Content, response.StatusCode.ToString());
            }
            return returnValue;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public NSXTUpgradeStatusSummaryType GetNodeUpgradeStatusSummary()
        {
            NSXTUpgradeStatusSummaryType returnValue = default(NSXTUpgradeStatusSummaryType);
            StringBuilder GetNodeUpgradeStatusSummaryServiceURL = new StringBuilder("/node/upgrade/status-summary");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.GET
            };
            request.AddHeader("Content-type", "application/json");
            request.Resource = GetNodeUpgradeStatusSummaryServiceURL.ToString();
            var response = restClient.Execute(request);
            if (response.StatusCode == HttpStatusCode.OK)
			{
                returnValue = JsonConvert.DeserializeObject<NSXTUpgradeStatusSummaryType>(response.Content, defaultSerializationSettings);
			}
            else
            {
                throw new NSXTException(response.Content, response.StatusCode.ToString());
            }
            return returnValue;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public NSXTUpgradeTaskPropertiesType GetUpgradeTaskStatus(string? BundleName = null, string? UpgradeTaskId = null)
        {
            NSXTUpgradeTaskPropertiesType returnValue = default(NSXTUpgradeTaskPropertiesType);
            StringBuilder GetUpgradeTaskStatusServiceURL = new StringBuilder("/node/upgrade");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.GET
            };
            request.AddHeader("Content-type", "application/json");
            if (BundleName != null) { request.AddQueryParameter("bundle_name", BundleName.ToString()); }
            if (UpgradeTaskId != null) { request.AddQueryParameter("upgrade_task_id", UpgradeTaskId.ToString()); }
            request.Resource = GetUpgradeTaskStatusServiceURL.ToString();
            var response = restClient.Execute(request);
            if (response.StatusCode == HttpStatusCode.OK)
			{
                returnValue = JsonConvert.DeserializeObject<NSXTUpgradeTaskPropertiesType>(response.Content, defaultSerializationSettings);
			}
            else
            {
                throw new NSXTException(response.Content, response.StatusCode.ToString());
            }
            return returnValue;
        }
    }
}
