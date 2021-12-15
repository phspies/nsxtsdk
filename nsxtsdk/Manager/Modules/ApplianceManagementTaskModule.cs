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
    public class ApplianceManagementTaskModule
    {
        RestClient restClient;
        JsonSerializerSettings defaultSerializationSettings;
        public ApplianceManagementTaskModule(RestClient Client, JsonSerializerSettings DefaultSerializationSettings)
        {
            restClient = Client;
            defaultSerializationSettings = DefaultSerializationSettings;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public void DeleteApplianceManagementTask(string TaskId)
        {
            if (TaskId == null) { throw new System.ArgumentNullException("TaskId cannot be null"); }
            
            StringBuilder DeleteApplianceManagementTaskServiceURL = new StringBuilder("/node/tasks/{task-id}");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.DELETE
            };
            request.AddHeader("Content-type", "application/json");
            DeleteApplianceManagementTaskServiceURL.Replace("{task-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(TaskId, System.Globalization.CultureInfo.InvariantCulture)));
            request.Resource = DeleteApplianceManagementTaskServiceURL.ToString();
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
        public NSXTApplianceManagementTaskPropertiesType ReadApplianceManagementTaskProperties(string TaskId, bool? SuppressRedirect = null)
        {
            if (TaskId == null) { throw new System.ArgumentNullException("TaskId cannot be null"); }
            NSXTApplianceManagementTaskPropertiesType returnValue = default(NSXTApplianceManagementTaskPropertiesType);
            StringBuilder ReadApplianceManagementTaskPropertiesServiceURL = new StringBuilder("/node/tasks/{task-id}");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.GET
            };
            request.AddHeader("Content-type", "application/json");
            ReadApplianceManagementTaskPropertiesServiceURL.Replace("{task-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(TaskId, System.Globalization.CultureInfo.InvariantCulture)));
            if (SuppressRedirect != null) { request.AddQueryParameter("suppress_redirect", SuppressRedirect.ToString()); }
            request.Resource = ReadApplianceManagementTaskPropertiesServiceURL.ToString();
            var response = restClient.Execute(request);
            if (response.StatusCode == HttpStatusCode.OK)
			{
                returnValue = JsonConvert.DeserializeObject<NSXTApplianceManagementTaskPropertiesType>(response.Content, defaultSerializationSettings);
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
        public void ReadAsyncApplianceManagementTaskResponse(string TaskId)
        {
            if (TaskId == null) { throw new System.ArgumentNullException("TaskId cannot be null"); }
            
            StringBuilder ReadAsyncApplianceManagementTaskResponseServiceURL = new StringBuilder("/node/tasks/{task-id}/response");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.GET
            };
            request.AddHeader("Content-type", "application/json");
            ReadAsyncApplianceManagementTaskResponseServiceURL.Replace("{task-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(TaskId, System.Globalization.CultureInfo.InvariantCulture)));
            request.Resource = ReadAsyncApplianceManagementTaskResponseServiceURL.ToString();
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
        public void CancelApplianceManagementTaskCancel(string TaskId)
        {
            if (TaskId == null) { throw new System.ArgumentNullException("TaskId cannot be null"); }
            
            StringBuilder CancelApplianceManagementTaskCancelServiceURL = new StringBuilder("/node/tasks/{task-id}?action=cancel");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.POST
            };
            request.AddHeader("Content-type", "application/json");
            CancelApplianceManagementTaskCancelServiceURL.Replace("{task-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(TaskId, System.Globalization.CultureInfo.InvariantCulture)));
            request.Resource = CancelApplianceManagementTaskCancelServiceURL.ToString();
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
        public NSXTApplianceManagementTaskListResultType ListApplianceManagementTasks(string? Fields = null, string? RequestMethod = null, string? RequestPath = null, string? RequestUri = null, string? Status = null, string? User = null)
        {
            NSXTApplianceManagementTaskListResultType returnValue = default(NSXTApplianceManagementTaskListResultType);
            StringBuilder ListApplianceManagementTasksServiceURL = new StringBuilder("/node/tasks");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.GET
            };
            request.AddHeader("Content-type", "application/json");
            if (Fields != null) { request.AddQueryParameter("fields", Fields.ToString()); }
            if (RequestMethod != null) { request.AddQueryParameter("request_method", RequestMethod.ToString()); }
            if (RequestPath != null) { request.AddQueryParameter("request_path", RequestPath.ToString()); }
            if (RequestUri != null) { request.AddQueryParameter("request_uri", RequestUri.ToString()); }
            if (Status != null) { request.AddQueryParameter("status", Status.ToString()); }
            if (User != null) { request.AddQueryParameter("user", User.ToString()); }
            request.Resource = ListApplianceManagementTasksServiceURL.ToString();
            var response = restClient.Execute(request);
            if (response.StatusCode == HttpStatusCode.OK)
			{
                returnValue = JsonConvert.DeserializeObject<NSXTApplianceManagementTaskListResultType>(response.Content, defaultSerializationSettings);
			}
            else
            {
                throw new NSXTException(response.Content, response.StatusCode.ToString());
            }
            return returnValue;
        }
    }
}
