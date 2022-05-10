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
        private RestClient restClient;
        private int retry;
        private int timeout;
        private CancellationToken cancellationToken;

        public Monitoring(RestClient Client, CancellationToken _cancellationToken, int _timeout, int _retry)
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
        public async Task BulkUpdateAlarms(string NewStatus, long? After = null, long? Before = null, string? Cursor = null, string? EventType = null, string? FeatureName = null, string? Id = null, string? IntentPath = null, string? NodeId = null, string? NodeResourceType = null, long? PageSize = null, string? Severity = null, bool? SortAscending = null, string? SortBy = null, string? Status = null, long? SuppressDuration = null)
        {
            if (NewStatus == null) { throw new System.ArgumentNullException("NewStatus cannot be null"); }
            StringBuilder BulkUpdateAlarmsServiceURL = new StringBuilder("/alarms?action=set_status");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Post
            };
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
            RestResponse response = await restClient.ExecuteTaskAsyncWithPolicy(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Post operation to " + BulkUpdateAlarmsServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTAlarmType> GetAlarm(string AlarmId)
        {
            if (AlarmId == null) { throw new System.ArgumentNullException("AlarmId cannot be null"); }
            StringBuilder GetAlarmServiceURL = new StringBuilder("/alarms/{alarm-id}");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Get
            };
            GetAlarmServiceURL.Replace("{alarm-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(AlarmId, System.Globalization.CultureInfo.InvariantCulture)));
            request.Resource = GetAlarmServiceURL.ToString();
            RestResponse<NSXTAlarmType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTAlarmType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Get operation to " + GetAlarmServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTEventListResultType> ListEvents()
        {
            StringBuilder ListEventsServiceURL = new StringBuilder("/events");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Get
            };
            request.Resource = ListEventsServiceURL.ToString();
            RestResponse<NSXTEventListResultType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTEventListResultType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Get operation to " + ListEventsServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
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
            StringBuilder UpdateEventServiceURL = new StringBuilder("/events/{event-id}");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Put
            };
            UpdateEventServiceURL.Replace("{event-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(EventId, System.Globalization.CultureInfo.InvariantCulture)));
            request.AddJsonBody(MonitoringEvent);
            request.Resource = UpdateEventServiceURL.ToString();
            RestResponse<NSXTMonitoringEventType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTMonitoringEventType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Put operation to " + UpdateEventServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
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
            StringBuilder GetEventServiceURL = new StringBuilder("/events/{event-id}");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Get
            };
            GetEventServiceURL.Replace("{event-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(EventId, System.Globalization.CultureInfo.InvariantCulture)));
            request.Resource = GetEventServiceURL.ToString();
            RestResponse<NSXTMonitoringEventType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTMonitoringEventType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Get operation to " + GetEventServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTAlarmsListResultType> GetAlarms(long? After = null, long? Before = null, string? Cursor = null, string? EventType = null, string? FeatureName = null, string? Id = null, string? IntentPath = null, string? NodeId = null, string? NodeResourceType = null, long? PageSize = null, string? Severity = null, bool? SortAscending = null, string? SortBy = null, string? Status = null)
        {
            StringBuilder GetAlarmsServiceURL = new StringBuilder("/alarms");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Get
            };
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
            RestResponse<NSXTAlarmsListResultType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTAlarmsListResultType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Get operation to " + GetAlarmsServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
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
            StringBuilder ResetEventValuesServiceURL = new StringBuilder("/events/{event-id}?action=set_default");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Post
            };
            ResetEventValuesServiceURL.Replace("{event-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(EventId, System.Globalization.CultureInfo.InvariantCulture)));
            request.Resource = ResetEventValuesServiceURL.ToString();
            RestResponse<NSXTMonitoringEventType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTMonitoringEventType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Post operation to " + ResetEventValuesServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
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
            StringBuilder UpdateAlarmStatusServiceURL = new StringBuilder("/alarms/{alarm-id}?action=set_status");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Post
            };
            UpdateAlarmStatusServiceURL.Replace("{alarm-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(AlarmId, System.Globalization.CultureInfo.InvariantCulture)));
            if (NewStatus != null) { request.AddQueryParameter("new_status", NewStatus.ToString()); }
            if (SuppressDuration != null) { request.AddQueryParameter("suppress_duration", SuppressDuration.ToString()); }
            request.Resource = UpdateAlarmStatusServiceURL.ToString();
            RestResponse<NSXTAlarmType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTAlarmType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Post operation to " + UpdateAlarmStatusServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
    }
}
