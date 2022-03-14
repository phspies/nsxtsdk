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
    public class Monitoring
    {
        RestClient restClient;
        JsonSerializerSettings defaultSerializationSettings;
        int retry;
        int timeout;
        CancellationToken cancellationToken;
        public Monitoring(RestClient Client, JsonSerializerSettings DefaultSerializationSettings, CancellationToken _cancellationToken, int _timeout, int _retry)

        {
            restClient = Client;
            defaultSerializationSettings = DefaultSerializationSettings;
            retry = _retry;
            timeout = _timeout;
            cancellationToken = _cancellationToken;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task BulkUpdateAlarms(string NewStatus, long? After = null, long? Before = null, string? Cursor = null, string? EventType = null, string? FeatureName = null, string? Id = null, string? IntentPath = null, string? NodeId = null, string? NodeResourceType = null, long? PageSize = null, string? Severity = null, bool? SortAscending = null, string? SortBy = null, string? Status = null, long? SuppressDuration = null)
        {
            if (NewStatus == null) { throw new System.ArgumentNullException("NewStatus cannot be null"); }
            
            StringBuilder BulkUpdateAlarmsServiceURL = new StringBuilder("/alarms?action=set_status");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.POST
            };
            request.AddHeader("Content-type", "application/json");
            if (After != null) { request.AddQueryParameter("after", After.ToString()); }
            if (Before != null) { request.AddQueryParameter("before", Before.ToString()); }
            if (Cursor != null) { request.AddQueryParameter("cursor", Cursor.ToString()); }
            if (EventType != null) { request.AddQueryParameter("event_type", EventType.ToString()); }
            if (FeatureName != null) { request.AddQueryParameter("feature_name", FeatureName.ToString()); }
            if (Id != null) { request.AddQueryParameter("id", Id.ToString()); }
            if (IntentPath != null) { request.AddQueryParameter("intent_path", IntentPath.ToString()); }
            if (NewStatus != null) { request.AddQueryParameter("new_status", NewStatus.ToString()); }
            if (NodeId != null) { request.AddQueryParameter("node_id", NodeId.ToString()); }
            if (NodeResourceType != null) { request.AddQueryParameter("node_resource_type", NodeResourceType.ToString()); }
            if (PageSize != null) { request.AddQueryParameter("page_size", PageSize.ToString()); }
            if (Severity != null) { request.AddQueryParameter("severity", Severity.ToString()); }
            if (SortAscending != null) { request.AddQueryParameter("sort_ascending", SortAscending.ToString()); }
            if (SortBy != null) { request.AddQueryParameter("sort_by", SortBy.ToString()); }
            if (Status != null) { request.AddQueryParameter("status", Status.ToString()); }
            if (SuppressDuration != null) { request.AddQueryParameter("suppress_duration", SuppressDuration.ToString()); }
            request.Resource = BulkUpdateAlarmsServiceURL.ToString();
            IRestResponse response = await restClient.ExecuteTaskAsyncWithPolicy(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP POST operation to " + BulkUpdateAlarmsServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, null);
			}
            
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTAlarmType> GetAlarm(string AlarmId)
        {
            if (AlarmId == null) { throw new System.ArgumentNullException("AlarmId cannot be null"); }
            NSXTAlarmType returnValue = default(NSXTAlarmType);
            StringBuilder GetAlarmServiceURL = new StringBuilder("/alarms/{alarm-id}");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.GET
            };
            request.AddHeader("Content-type", "application/json");
            GetAlarmServiceURL.Replace("{alarm-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(AlarmId, System.Globalization.CultureInfo.InvariantCulture)));
            request.Resource = GetAlarmServiceURL.ToString();
            IRestResponse<NSXTAlarmType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTAlarmType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP GET operation to " + GetAlarmServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, null);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTEventListResultType> ListEvents()
        {
            NSXTEventListResultType returnValue = default(NSXTEventListResultType);
            StringBuilder ListEventsServiceURL = new StringBuilder("/events");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.GET
            };
            request.AddHeader("Content-type", "application/json");
            request.Resource = ListEventsServiceURL.ToString();
            IRestResponse<NSXTEventListResultType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTEventListResultType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP GET operation to " + ListEventsServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, null);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTMonitoringEventType> UpdateEvent(string EventId, NSXTMonitoringEventType MonitoringEvent)
        {
            if (EventId == null) { throw new System.ArgumentNullException("EventId cannot be null"); }
            if (MonitoringEvent == null) { throw new System.ArgumentNullException("MonitoringEvent cannot be null"); }
            NSXTMonitoringEventType returnValue = default(NSXTMonitoringEventType);
            StringBuilder UpdateEventServiceURL = new StringBuilder("/events/{event-id}");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.PUT
            };
            request.AddHeader("Content-type", "application/json");
            UpdateEventServiceURL.Replace("{event-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(EventId, System.Globalization.CultureInfo.InvariantCulture)));
            request.AddJsonBody(JsonConvert.SerializeObject(MonitoringEvent, defaultSerializationSettings));
            request.Resource = UpdateEventServiceURL.ToString();
            IRestResponse<NSXTMonitoringEventType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTMonitoringEventType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP PUT operation to " + UpdateEventServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, null);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTMonitoringEventType> GetEvent(string EventId)
        {
            if (EventId == null) { throw new System.ArgumentNullException("EventId cannot be null"); }
            NSXTMonitoringEventType returnValue = default(NSXTMonitoringEventType);
            StringBuilder GetEventServiceURL = new StringBuilder("/events/{event-id}");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.GET
            };
            request.AddHeader("Content-type", "application/json");
            GetEventServiceURL.Replace("{event-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(EventId, System.Globalization.CultureInfo.InvariantCulture)));
            request.Resource = GetEventServiceURL.ToString();
            IRestResponse<NSXTMonitoringEventType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTMonitoringEventType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP GET operation to " + GetEventServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, null);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTAlarmsListResultType> GetAlarms(long? After = null, long? Before = null, string? Cursor = null, string? EventType = null, string? FeatureName = null, string? Id = null, string? IntentPath = null, string? NodeId = null, string? NodeResourceType = null, long? PageSize = null, string? Severity = null, bool? SortAscending = null, string? SortBy = null, string? Status = null)
        {
            NSXTAlarmsListResultType returnValue = default(NSXTAlarmsListResultType);
            StringBuilder GetAlarmsServiceURL = new StringBuilder("/alarms");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.GET
            };
            request.AddHeader("Content-type", "application/json");
            if (After != null) { request.AddQueryParameter("after", After.ToString()); }
            if (Before != null) { request.AddQueryParameter("before", Before.ToString()); }
            if (Cursor != null) { request.AddQueryParameter("cursor", Cursor.ToString()); }
            if (EventType != null) { request.AddQueryParameter("event_type", EventType.ToString()); }
            if (FeatureName != null) { request.AddQueryParameter("feature_name", FeatureName.ToString()); }
            if (Id != null) { request.AddQueryParameter("id", Id.ToString()); }
            if (IntentPath != null) { request.AddQueryParameter("intent_path", IntentPath.ToString()); }
            if (NodeId != null) { request.AddQueryParameter("node_id", NodeId.ToString()); }
            if (NodeResourceType != null) { request.AddQueryParameter("node_resource_type", NodeResourceType.ToString()); }
            if (PageSize != null) { request.AddQueryParameter("page_size", PageSize.ToString()); }
            if (Severity != null) { request.AddQueryParameter("severity", Severity.ToString()); }
            if (SortAscending != null) { request.AddQueryParameter("sort_ascending", SortAscending.ToString()); }
            if (SortBy != null) { request.AddQueryParameter("sort_by", SortBy.ToString()); }
            if (Status != null) { request.AddQueryParameter("status", Status.ToString()); }
            request.Resource = GetAlarmsServiceURL.ToString();
            IRestResponse<NSXTAlarmsListResultType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTAlarmsListResultType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP GET operation to " + GetAlarmsServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, null);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTMonitoringEventType> ResetEventValues(string EventId)
        {
            if (EventId == null) { throw new System.ArgumentNullException("EventId cannot be null"); }
            NSXTMonitoringEventType returnValue = default(NSXTMonitoringEventType);
            StringBuilder ResetEventValuesServiceURL = new StringBuilder("/events/{event-id}?action=set_default");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.POST
            };
            request.AddHeader("Content-type", "application/json");
            ResetEventValuesServiceURL.Replace("{event-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(EventId, System.Globalization.CultureInfo.InvariantCulture)));
            request.Resource = ResetEventValuesServiceURL.ToString();
            IRestResponse<NSXTMonitoringEventType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTMonitoringEventType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP POST operation to " + ResetEventValuesServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, null);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTAlarmType> UpdateAlarmStatus(string AlarmId, string NewStatus, long? SuppressDuration = null)
        {
            if (AlarmId == null) { throw new System.ArgumentNullException("AlarmId cannot be null"); }
            if (NewStatus == null) { throw new System.ArgumentNullException("NewStatus cannot be null"); }
            NSXTAlarmType returnValue = default(NSXTAlarmType);
            StringBuilder UpdateAlarmStatusServiceURL = new StringBuilder("/alarms/{alarm-id}?action=set_status");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.POST
            };
            request.AddHeader("Content-type", "application/json");
            UpdateAlarmStatusServiceURL.Replace("{alarm-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(AlarmId, System.Globalization.CultureInfo.InvariantCulture)));
            if (NewStatus != null) { request.AddQueryParameter("new_status", NewStatus.ToString()); }
            if (SuppressDuration != null) { request.AddQueryParameter("suppress_duration", SuppressDuration.ToString()); }
            request.Resource = UpdateAlarmStatusServiceURL.ToString();
            IRestResponse<NSXTAlarmType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTAlarmType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP POST operation to " + UpdateAlarmStatusServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, null);
			}
            return response.Data;
        }
    }
}
