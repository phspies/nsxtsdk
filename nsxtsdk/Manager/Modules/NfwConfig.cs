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
    public class NfwConfig
    {
        private RestClient restClient;
        private int retry;
        private int timeout;
        private CancellationToken cancellationToken;

        public NfwConfig(RestClient Client, CancellationToken _cancellationToken, int _timeout, int _retry)
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
        public async Task<NSXTNotificationsListType> UpdateNotifications(string WatcherId, NSXTNotificationsListType NotificationsList)
        {
            if (WatcherId == null) { throw new System.ArgumentNullException("WatcherId cannot be null"); }
            if (NotificationsList == null) { throw new System.ArgumentNullException("NotificationsList cannot be null"); }
            StringBuilder UpdateNotificationsServiceURL = new StringBuilder("/notification-watchers/{watcher-id}/notifications");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Put
            };
            UpdateNotificationsServiceURL.Replace("{watcher-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(WatcherId, System.Globalization.CultureInfo.InvariantCulture)));
            request.AddJsonBody(NotificationsList);
            request.Resource = UpdateNotificationsServiceURL.ToString();
            RestResponse<NSXTNotificationsListType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTNotificationsListType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Put operation to " + UpdateNotificationsServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTNotificationsListType> GetNotifications(string WatcherId)
        {
            if (WatcherId == null) { throw new System.ArgumentNullException("WatcherId cannot be null"); }
            StringBuilder GetNotificationsServiceURL = new StringBuilder("/notification-watchers/{watcher-id}/notifications");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Get
            };
            GetNotificationsServiceURL.Replace("{watcher-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(WatcherId, System.Globalization.CultureInfo.InvariantCulture)));
            request.Resource = GetNotificationsServiceURL.ToString();
            RestResponse<NSXTNotificationsListType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTNotificationsListType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Get operation to " + GetNotificationsServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTNotificationWatcherType> UpdateNotificationWatcher(string WatcherId, NSXTNotificationWatcherType NotificationWatcher)
        {
            if (WatcherId == null) { throw new System.ArgumentNullException("WatcherId cannot be null"); }
            if (NotificationWatcher == null) { throw new System.ArgumentNullException("NotificationWatcher cannot be null"); }
            StringBuilder UpdateNotificationWatcherServiceURL = new StringBuilder("/notification-watchers/{watcher-id}");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Put
            };
            UpdateNotificationWatcherServiceURL.Replace("{watcher-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(WatcherId, System.Globalization.CultureInfo.InvariantCulture)));
            request.AddJsonBody(NotificationWatcher);
            request.Resource = UpdateNotificationWatcherServiceURL.ToString();
            RestResponse<NSXTNotificationWatcherType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTNotificationWatcherType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Put operation to " + UpdateNotificationWatcherServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTNotificationWatcherType> GetNotificationWatcher(string WatcherId)
        {
            if (WatcherId == null) { throw new System.ArgumentNullException("WatcherId cannot be null"); }
            StringBuilder GetNotificationWatcherServiceURL = new StringBuilder("/notification-watchers/{watcher-id}");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Get
            };
            GetNotificationWatcherServiceURL.Replace("{watcher-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(WatcherId, System.Globalization.CultureInfo.InvariantCulture)));
            request.Resource = GetNotificationWatcherServiceURL.ToString();
            RestResponse<NSXTNotificationWatcherType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTNotificationWatcherType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Get operation to " + GetNotificationWatcherServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task DeleteNotificationWatcher(string WatcherId)
        {
            if (WatcherId == null) { throw new System.ArgumentNullException("WatcherId cannot be null"); }
            StringBuilder DeleteNotificationWatcherServiceURL = new StringBuilder("/notification-watchers/{watcher-id}");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Delete
            };
            DeleteNotificationWatcherServiceURL.Replace("{watcher-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(WatcherId, System.Globalization.CultureInfo.InvariantCulture)));
            request.Resource = DeleteNotificationWatcherServiceURL.ToString();
            RestResponse response = await restClient.ExecuteTaskAsyncWithPolicy(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Delete operation to " + DeleteNotificationWatcherServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTNotificationsListType> DeleteUriFilters(string WatcherId, NSXTNotificationType Notification)
        {
            if (WatcherId == null) { throw new System.ArgumentNullException("WatcherId cannot be null"); }
            if (Notification == null) { throw new System.ArgumentNullException("Notification cannot be null"); }
            StringBuilder DeleteUriFiltersServiceURL = new StringBuilder("/notification-watchers/{watcher-id}/notifications?action=delete_uri_filters");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Post
            };
            DeleteUriFiltersServiceURL.Replace("{watcher-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(WatcherId, System.Globalization.CultureInfo.InvariantCulture)));
            request.AddJsonBody(Notification);
            request.Resource = DeleteUriFiltersServiceURL.ToString();
            RestResponse<NSXTNotificationsListType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTNotificationsListType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Post operation to " + DeleteUriFiltersServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTNotificationsListType> AddUriFilters(string WatcherId, NSXTNotificationType Notification)
        {
            if (WatcherId == null) { throw new System.ArgumentNullException("WatcherId cannot be null"); }
            if (Notification == null) { throw new System.ArgumentNullException("Notification cannot be null"); }
            StringBuilder AddUriFiltersServiceURL = new StringBuilder("/notification-watchers/{watcher-id}/notifications?action=add_uri_filters");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Post
            };
            AddUriFiltersServiceURL.Replace("{watcher-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(WatcherId, System.Globalization.CultureInfo.InvariantCulture)));
            request.AddJsonBody(Notification);
            request.Resource = AddUriFiltersServiceURL.ToString();
            RestResponse<NSXTNotificationsListType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTNotificationsListType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Post operation to " + AddUriFiltersServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTNotificationWatcherType> AddNotificationWatcher(NSXTNotificationWatcherType NotificationWatcher)
        {
            if (NotificationWatcher == null) { throw new System.ArgumentNullException("NotificationWatcher cannot be null"); }
            StringBuilder AddNotificationWatcherServiceURL = new StringBuilder("/notification-watchers");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Post
            };
            request.AddJsonBody(NotificationWatcher);
            request.Resource = AddNotificationWatcherServiceURL.ToString();
            RestResponse<NSXTNotificationWatcherType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTNotificationWatcherType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Post operation to " + AddNotificationWatcherServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTNotificationWatcherListResultType> ListNotificationWatchers()
        {
            StringBuilder ListNotificationWatchersServiceURL = new StringBuilder("/notification-watchers");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Get
            };
            request.Resource = ListNotificationWatchersServiceURL.ToString();
            RestResponse<NSXTNotificationWatcherListResultType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTNotificationWatcherListResultType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Get operation to " + ListNotificationWatchersServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
    }
}
