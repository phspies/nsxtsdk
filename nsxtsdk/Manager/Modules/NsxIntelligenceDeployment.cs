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
    public class NsxIntelligenceDeployment
    {
        RestClient restClient;
        JsonSerializerSettings defaultSerializationSettings;
        public NsxIntelligenceDeployment(RestClient Client, JsonSerializerSettings DefaultSerializationSettings)
        {
            restClient = Client;
            defaultSerializationSettings = DefaultSerializationSettings;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public NSXTIntelligenceClusterNodeVMDeploymentRequestListType AddPaceClusterNodeVM(NSXTAddIntelligenceClusterNodeVMInfoType AddIntelligenceClusterNodeVminfo)
        {
            if (AddIntelligenceClusterNodeVminfo == null) { throw new System.ArgumentNullException("AddIntelligenceClusterNodeVminfo cannot be null"); }
            NSXTIntelligenceClusterNodeVMDeploymentRequestListType returnValue = default(NSXTIntelligenceClusterNodeVMDeploymentRequestListType);
            StringBuilder AddPaceClusterNodeVMServiceURL = new StringBuilder("/intelligence/nodes/deployments");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.POST
            };
            request.AddHeader("Content-type", "application/json");
            request.AddJsonBody(JsonConvert.SerializeObject(AddIntelligenceClusterNodeVminfo, defaultSerializationSettings));
            request.Resource = AddPaceClusterNodeVMServiceURL.ToString();
            var response = restClient.Execute(request);
            if (response.StatusCode == HttpStatusCode.OK)
			{
                returnValue = JsonConvert.DeserializeObject<NSXTIntelligenceClusterNodeVMDeploymentRequestListType>(response.Content, defaultSerializationSettings);
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
        public NSXTIntelligenceClusterNodeVMDeploymentRequestListType ListPaceClusterNodeVmdeploymentRequests()
        {
            NSXTIntelligenceClusterNodeVMDeploymentRequestListType returnValue = default(NSXTIntelligenceClusterNodeVMDeploymentRequestListType);
            StringBuilder ListPaceClusterNodeVmdeploymentRequestsServiceURL = new StringBuilder("/intelligence/nodes/deployments");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.GET
            };
            request.AddHeader("Content-type", "application/json");
            request.Resource = ListPaceClusterNodeVmdeploymentRequestsServiceURL.ToString();
            var response = restClient.Execute(request);
            if (response.StatusCode == HttpStatusCode.OK)
			{
                returnValue = JsonConvert.DeserializeObject<NSXTIntelligenceClusterNodeVMDeploymentRequestListType>(response.Content, defaultSerializationSettings);
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
        public NSXTIntelligenceClusterNodeVMDeploymentStatusReportType ReadPaceClusterNodeVmdeploymentStatus(string NodeId)
        {
            if (NodeId == null) { throw new System.ArgumentNullException("NodeId cannot be null"); }
            NSXTIntelligenceClusterNodeVMDeploymentStatusReportType returnValue = default(NSXTIntelligenceClusterNodeVMDeploymentStatusReportType);
            StringBuilder ReadPaceClusterNodeVmdeploymentStatusServiceURL = new StringBuilder("/intelligence/nodes/deployments/{node-id}/status");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.GET
            };
            request.AddHeader("Content-type", "application/json");
            ReadPaceClusterNodeVmdeploymentStatusServiceURL.Replace("{node-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(NodeId, System.Globalization.CultureInfo.InvariantCulture)));
            request.Resource = ReadPaceClusterNodeVmdeploymentStatusServiceURL.ToString();
            var response = restClient.Execute(request);
            if (response.StatusCode == HttpStatusCode.OK)
			{
                returnValue = JsonConvert.DeserializeObject<NSXTIntelligenceClusterNodeVMDeploymentStatusReportType>(response.Content, defaultSerializationSettings);
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
        public void DeleteAutoDeployedPaceClusterNodeVmdelete(string NodeId, bool? ForceDelete = null)
        {
            if (NodeId == null) { throw new System.ArgumentNullException("NodeId cannot be null"); }
            
            StringBuilder DeleteAutoDeployedPaceClusterNodeVmdeleteServiceURL = new StringBuilder("/intelligence/nodes/deployments/{node-id}?action=delete");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.POST
            };
            request.AddHeader("Content-type", "application/json");
            DeleteAutoDeployedPaceClusterNodeVmdeleteServiceURL.Replace("{node-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(NodeId, System.Globalization.CultureInfo.InvariantCulture)));
            if (ForceDelete != null) { request.AddQueryParameter("force_delete", ForceDelete.ToString()); }
            request.Resource = DeleteAutoDeployedPaceClusterNodeVmdeleteServiceURL.ToString();
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
        public NSXTIntelligenceClusterNodeVMDeploymentRequestType ReadPaceClusterNodeVmdeploymentRequest(string NodeId)
        {
            if (NodeId == null) { throw new System.ArgumentNullException("NodeId cannot be null"); }
            NSXTIntelligenceClusterNodeVMDeploymentRequestType returnValue = default(NSXTIntelligenceClusterNodeVMDeploymentRequestType);
            StringBuilder ReadPaceClusterNodeVmdeploymentRequestServiceURL = new StringBuilder("/intelligence/nodes/deployments/{node-id}");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.GET
            };
            request.AddHeader("Content-type", "application/json");
            ReadPaceClusterNodeVmdeploymentRequestServiceURL.Replace("{node-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(NodeId, System.Globalization.CultureInfo.InvariantCulture)));
            request.Resource = ReadPaceClusterNodeVmdeploymentRequestServiceURL.ToString();
            var response = restClient.Execute(request);
            if (response.StatusCode == HttpStatusCode.OK)
			{
                returnValue = JsonConvert.DeserializeObject<NSXTIntelligenceClusterNodeVMDeploymentRequestType>(response.Content, defaultSerializationSettings);
			}
            else
            {
                throw new NSXTException(response.Content, response.StatusCode.ToString());
            }
            return returnValue;
        }
    }
}