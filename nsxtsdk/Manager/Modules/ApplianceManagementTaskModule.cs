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
        private RestClient restClient;
        private int retry;
        private int timeout;
        private CancellationToken cancellationToken;

        public ApplianceManagementTaskModule(RestClient Client, CancellationToken _cancellationToken, int _timeout, int _retry)
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
        public async Task DeleteApplianceManagementTask(string TaskId)
        {
            if (TaskId == null) { throw new System.ArgumentNullException("TaskId cannot be null"); }
            StringBuilder DeleteApplianceManagementTaskServiceURL = new StringBuilder("/node/tasks/{task-id}");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Delete
            };
            DeleteApplianceManagementTaskServiceURL.Replace("{task-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(TaskId, System.Globalization.CultureInfo.InvariantCulture)));
            request.Resource = DeleteApplianceManagementTaskServiceURL.ToString();
            RestResponse response = await restClient.ExecuteTaskAsyncWithPolicy(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Delete operation to " + DeleteApplianceManagementTaskServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTApplianceManagementTaskPropertiesType> ReadApplianceManagementTaskProperties(string TaskId, bool? SuppressRedirect = null)
        {
            if (TaskId == null) { throw new System.ArgumentNullException("TaskId cannot be null"); }
            StringBuilder ReadApplianceManagementTaskPropertiesServiceURL = new StringBuilder("/node/tasks/{task-id}");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Get
            };
            ReadApplianceManagementTaskPropertiesServiceURL.Replace("{task-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(TaskId, System.Globalization.CultureInfo.InvariantCulture)));
            if (SuppressRedirect != null) { request.AddQueryParameter("suppress_redirect", SuppressRedirect.ToString()); }
            request.Resource = ReadApplianceManagementTaskPropertiesServiceURL.ToString();
            RestResponse<NSXTApplianceManagementTaskPropertiesType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTApplianceManagementTaskPropertiesType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Get operation to " + ReadApplianceManagementTaskPropertiesServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task ReadAsyncApplianceManagementTaskResponse(string TaskId)
        {
            if (TaskId == null) { throw new System.ArgumentNullException("TaskId cannot be null"); }
            StringBuilder ReadAsyncApplianceManagementTaskResponseServiceURL = new StringBuilder("/node/tasks/{task-id}/response");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Get
            };
            ReadAsyncApplianceManagementTaskResponseServiceURL.Replace("{task-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(TaskId, System.Globalization.CultureInfo.InvariantCulture)));
            request.Resource = ReadAsyncApplianceManagementTaskResponseServiceURL.ToString();
            RestResponse response = await restClient.ExecuteTaskAsyncWithPolicy(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Get operation to " + ReadAsyncApplianceManagementTaskResponseServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task CancelApplianceManagementTaskCancel(string TaskId)
        {
            if (TaskId == null) { throw new System.ArgumentNullException("TaskId cannot be null"); }
            StringBuilder CancelApplianceManagementTaskCancelServiceURL = new StringBuilder("/node/tasks/{task-id}?action=cancel");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Post
            };
            CancelApplianceManagementTaskCancelServiceURL.Replace("{task-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(TaskId, System.Globalization.CultureInfo.InvariantCulture)));
            request.Resource = CancelApplianceManagementTaskCancelServiceURL.ToString();
            RestResponse response = await restClient.ExecuteTaskAsyncWithPolicy(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Post operation to " + CancelApplianceManagementTaskCancelServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTApplianceManagementTaskListResultType> ListApplianceManagementTasks(string? Fields = null, string? RequestMethod = null, string? RequestPath = null, string? RequestUri = null, string? Status = null, string? User = null)
        {
            StringBuilder ListApplianceManagementTasksServiceURL = new StringBuilder("/node/tasks");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Get
            };
            if (Fields != null) { request.AddQueryParameter("fields", Fields.ToString()); }
            if (RequestMethod != null) { request.AddQueryParameter("request_method", RequestMethod.ToString()); }
            if (RequestPath != null) { request.AddQueryParameter("request_path", RequestPath.ToString()); }
            if (RequestUri != null) { request.AddQueryParameter("request_uri", RequestUri.ToString()); }
            if (Status != null) { request.AddQueryParameter("status", Status.ToString()); }
            if (User != null) { request.AddQueryParameter("user", User.ToString()); }
            request.Resource = ListApplianceManagementTasksServiceURL.ToString();
            RestResponse<NSXTApplianceManagementTaskListResultType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTApplianceManagementTaskListResultType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Get operation to " + ListApplianceManagementTasksServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
    }
}
