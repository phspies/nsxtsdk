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
using nsxtsdk.PolicyModels;

namespace nsxtapi.PolicyModules
{
    public class Tasks
    {
        RestClient restClient;
        JsonSerializerSettings defaultSerializationSettings;
        public Tasks(RestClient Client, JsonSerializerSettings DefaultSerializationSettings)
        {
            restClient = Client;
            defaultSerializationSettings = DefaultSerializationSettings;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public NSXTTaskListResultType ListTasks(string? Cursor = null, string? IncludedFields = null, long? PageSize = null, string? RequestUri = null, bool? SortAscending = null, string? SortBy = null, string? Status = null, string? User = null)
        {
            NSXTTaskListResultType returnValue = default(NSXTTaskListResultType);
            StringBuilder ListTasksServiceURL = new StringBuilder("/tasks");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.GET
            };
            request.AddHeader("Content-type", "application/json");
            if (Cursor != null) { request.AddQueryParameter("cursor", Cursor.ToString()); }
            if (IncludedFields != null) { request.AddQueryParameter("included_fields", IncludedFields.ToString()); }
            if (PageSize != null) { request.AddQueryParameter("page_size", PageSize.ToString()); }
            if (RequestUri != null) { request.AddQueryParameter("request_uri", RequestUri.ToString()); }
            if (SortAscending != null) { request.AddQueryParameter("sort_ascending", SortAscending.ToString()); }
            if (SortBy != null) { request.AddQueryParameter("sort_by", SortBy.ToString()); }
            if (Status != null) { request.AddQueryParameter("status", Status.ToString()); }
            if (User != null) { request.AddQueryParameter("user", User.ToString()); }
            request.Resource = ListTasksServiceURL.ToString();
            var response = restClient.Execute(request);
            if (response.StatusCode == HttpStatusCode.OK)
			{
                returnValue = JsonConvert.DeserializeObject<NSXTTaskListResultType>(response.Content, defaultSerializationSettings);
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
        public NSXTTaskPropertiesType ReadTaskProperties(string TaskId)
        {
            if (TaskId == null) { throw new System.ArgumentNullException("TaskId cannot be null"); }
            NSXTTaskPropertiesType returnValue = default(NSXTTaskPropertiesType);
            StringBuilder ReadTaskPropertiesServiceURL = new StringBuilder("/tasks/{task-id}");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.GET
            };
            request.AddHeader("Content-type", "application/json");
            ReadTaskPropertiesServiceURL.Replace("{task-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(TaskId, System.Globalization.CultureInfo.InvariantCulture)));
            request.Resource = ReadTaskPropertiesServiceURL.ToString();
            var response = restClient.Execute(request);
            if (response.StatusCode == HttpStatusCode.OK)
			{
                returnValue = JsonConvert.DeserializeObject<NSXTTaskPropertiesType>(response.Content, defaultSerializationSettings);
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
        public object ReadTaskResult(string TaskId)
        {
            if (TaskId == null) { throw new System.ArgumentNullException("TaskId cannot be null"); }
            object returnValue  = default(object);
            StringBuilder ReadTaskResultServiceURL = new StringBuilder("/tasks/{task-id}/response");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.GET
            };
            request.AddHeader("Content-type", "application/json");
            ReadTaskResultServiceURL.Replace("{task-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(TaskId, System.Globalization.CultureInfo.InvariantCulture)));
            request.Resource = ReadTaskResultServiceURL.ToString();
            var response = restClient.Execute(request);
            if (response.StatusCode == HttpStatusCode.OK)
			{
                returnValue = JsonConvert.DeserializeObject<object>(response.Content, defaultSerializationSettings);
			}
            else
            {
                throw new NSXTException(response.Content, response.StatusCode.ToString());
            }
            return returnValue;
        }
    }
}