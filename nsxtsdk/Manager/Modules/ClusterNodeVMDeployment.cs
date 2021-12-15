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
    public class ClusterNodeVMDeployment
    {
        RestClient restClient;
        JsonSerializerSettings defaultSerializationSettings;
        public ClusterNodeVMDeployment(RestClient Client, JsonSerializerSettings DefaultSerializationSettings)
        {
            restClient = Client;
            defaultSerializationSettings = DefaultSerializationSettings;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public NSXTClusterNodeVMDeploymentStatusReportType ReadClusterNodeVmdeploymentStatus(string NodeId)
        {
            if (NodeId == null) { throw new System.ArgumentNullException("NodeId cannot be null"); }
            NSXTClusterNodeVMDeploymentStatusReportType returnValue = default(NSXTClusterNodeVMDeploymentStatusReportType);
            StringBuilder ReadClusterNodeVmdeploymentStatusServiceURL = new StringBuilder("/cluster/nodes/deployments/{node-id}/status");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.GET
            };
            request.AddHeader("Content-type", "application/json");
            ReadClusterNodeVmdeploymentStatusServiceURL.Replace("{node-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(NodeId, System.Globalization.CultureInfo.InvariantCulture)));
            request.Resource = ReadClusterNodeVmdeploymentStatusServiceURL.ToString();
            var response = restClient.Execute(request);
            if (response.StatusCode == HttpStatusCode.OK)
			{
                returnValue = JsonConvert.DeserializeObject<NSXTClusterNodeVMDeploymentStatusReportType>(response.Content, defaultSerializationSettings);
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
        public void PerformRepoSyncRepoSync()
        {
            
            StringBuilder PerformRepoSyncRepoSyncServiceURL = new StringBuilder("/cluster/node?action=repo_sync");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.POST
            };
            request.AddHeader("Content-type", "application/json");
            request.Resource = PerformRepoSyncRepoSyncServiceURL.ToString();
            var response = restClient.Execute(request);
            if (response.StatusCode == HttpStatusCode.OK)
			{
                
			}
            else
            {
                throw new NSXTException(response.Content, response.StatusCode.ToString());
            }
            
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public void DeleteAutoDeployedClusterNodeVmdelete(string NodeId, bool? ForceDelete = null)
        {
            if (NodeId == null) { throw new System.ArgumentNullException("NodeId cannot be null"); }
            
            StringBuilder DeleteAutoDeployedClusterNodeVmdeleteServiceURL = new StringBuilder("/cluster/nodes/deployments/{node-id}?action=delete");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.POST
            };
            request.AddHeader("Content-type", "application/json");
            DeleteAutoDeployedClusterNodeVmdeleteServiceURL.Replace("{node-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(NodeId, System.Globalization.CultureInfo.InvariantCulture)));
            if (ForceDelete != null) { request.AddQueryParameter("force_delete", ForceDelete.ToString()); }
            request.Resource = DeleteAutoDeployedClusterNodeVmdeleteServiceURL.ToString();
            var response = restClient.Execute(request);
            if (response.StatusCode == HttpStatusCode.OK)
			{
                
			}
            else
            {
                throw new NSXTException(response.Content, response.StatusCode.ToString());
            }
            
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public NSXTRepoSyncStatusReportType GetRepoSyncStatus(string NodeId)
        {
            if (NodeId == null) { throw new System.ArgumentNullException("NodeId cannot be null"); }
            NSXTRepoSyncStatusReportType returnValue = default(NSXTRepoSyncStatusReportType);
            StringBuilder GetRepoSyncStatusServiceURL = new StringBuilder("/cluster/nodes/{node-id}/repo_sync/status");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.GET
            };
            request.AddHeader("Content-type", "application/json");
            GetRepoSyncStatusServiceURL.Replace("{node-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(NodeId, System.Globalization.CultureInfo.InvariantCulture)));
            request.Resource = GetRepoSyncStatusServiceURL.ToString();
            var response = restClient.Execute(request);
            if (response.StatusCode == HttpStatusCode.OK)
			{
                returnValue = JsonConvert.DeserializeObject<NSXTRepoSyncStatusReportType>(response.Content, defaultSerializationSettings);
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
        public NSXTClusterNodeVMDeploymentRequestListType AddClusterNodeVM(NSXTAddClusterNodeVMInfoType AddClusterNodeVminfo)
        {
            if (AddClusterNodeVminfo == null) { throw new System.ArgumentNullException("AddClusterNodeVminfo cannot be null"); }
            NSXTClusterNodeVMDeploymentRequestListType returnValue = default(NSXTClusterNodeVMDeploymentRequestListType);
            StringBuilder AddClusterNodeVMServiceURL = new StringBuilder("/cluster/nodes/deployments");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.POST
            };
            request.AddHeader("Content-type", "application/json");
            request.AddJsonBody(JsonConvert.SerializeObject(AddClusterNodeVminfo, defaultSerializationSettings));
            request.Resource = AddClusterNodeVMServiceURL.ToString();
            var response = restClient.Execute(request);
            if (response.StatusCode == HttpStatusCode.OK)
			{
                returnValue = JsonConvert.DeserializeObject<NSXTClusterNodeVMDeploymentRequestListType>(response.Content, defaultSerializationSettings);
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
        public NSXTClusterNodeVMDeploymentRequestListType ListClusterNodeVmdeploymentRequests()
        {
            NSXTClusterNodeVMDeploymentRequestListType returnValue = default(NSXTClusterNodeVMDeploymentRequestListType);
            StringBuilder ListClusterNodeVmdeploymentRequestsServiceURL = new StringBuilder("/cluster/nodes/deployments");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.GET
            };
            request.AddHeader("Content-type", "application/json");
            request.Resource = ListClusterNodeVmdeploymentRequestsServiceURL.ToString();
            var response = restClient.Execute(request);
            if (response.StatusCode == HttpStatusCode.OK)
			{
                returnValue = JsonConvert.DeserializeObject<NSXTClusterNodeVMDeploymentRequestListType>(response.Content, defaultSerializationSettings);
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
        public NSXTClusterNodeVMDeploymentRequestType ReadClusterNodeVmdeploymentRequest(string NodeId)
        {
            if (NodeId == null) { throw new System.ArgumentNullException("NodeId cannot be null"); }
            NSXTClusterNodeVMDeploymentRequestType returnValue = default(NSXTClusterNodeVMDeploymentRequestType);
            StringBuilder ReadClusterNodeVmdeploymentRequestServiceURL = new StringBuilder("/cluster/nodes/deployments/{node-id}");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.GET
            };
            request.AddHeader("Content-type", "application/json");
            ReadClusterNodeVmdeploymentRequestServiceURL.Replace("{node-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(NodeId, System.Globalization.CultureInfo.InvariantCulture)));
            request.Resource = ReadClusterNodeVmdeploymentRequestServiceURL.ToString();
            var response = restClient.Execute(request);
            if (response.StatusCode == HttpStatusCode.OK)
			{
                returnValue = JsonConvert.DeserializeObject<NSXTClusterNodeVMDeploymentRequestType>(response.Content, defaultSerializationSettings);
			}
            else
            {
                throw new NSXTException(response.Content, response.StatusCode.ToString());
            }
            return returnValue;
        }
    }
}