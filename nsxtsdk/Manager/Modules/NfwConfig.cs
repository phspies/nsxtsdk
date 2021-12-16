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
    public class NfwConfig
    {
        RestClient restClient;
        JsonSerializerSettings defaultSerializationSettings;
        public NfwConfig(RestClient Client, JsonSerializerSettings DefaultSerializationSettings)
        {
            restClient = Client;
            defaultSerializationSettings = DefaultSerializationSettings;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public NSXTNotificationsListType UpdateNotifications(string WatcherId, NSXTNotificationsListType NotificationsList)
        {
            if (WatcherId == null) { throw new System.ArgumentNullException("WatcherId cannot be null"); }
            if (NotificationsList == null) { throw new System.ArgumentNullException("NotificationsList cannot be null"); }
            NSXTNotificationsListType returnValue = default(NSXTNotificationsListType);
            StringBuilder UpdateNotificationsServiceURL = new StringBuilder("/notification-watchers/{watcher-id}/notifications");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.PUT
            };
            request.AddHeader("Content-type", "application/json");
            UpdateNotificationsServiceURL.Replace("{watcher-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(WatcherId, System.Globalization.CultureInfo.InvariantCulture)));
            request.AddJsonBody(JsonConvert.SerializeObject(NotificationsList, defaultSerializationSettings));
            request.Resource = UpdateNotificationsServiceURL.ToString();
            var response = restClient.Execute(request);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP PUT operation to " + UpdateNotificationsServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, null);
			}
            else
			{
				try
				{
					returnValue = JsonConvert.DeserializeObject<NSXTNotificationsListType>(response.Content, defaultSerializationSettings);
				}
				catch (Exception ex)
				{
					var message = "Could not deserialize the response body string as " + typeof(NSXTNotificationsListType).FullName + ".";
					throw new NSXTException(message, (int)response.StatusCode, response.Content, response.Headers, ex.InnerException);
				}
			}
			return returnValue;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public NSXTNotificationsListType GetNotifications(string WatcherId)
        {
            if (WatcherId == null) { throw new System.ArgumentNullException("WatcherId cannot be null"); }
            NSXTNotificationsListType returnValue = default(NSXTNotificationsListType);
            StringBuilder GetNotificationsServiceURL = new StringBuilder("/notification-watchers/{watcher-id}/notifications");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.GET
            };
            request.AddHeader("Content-type", "application/json");
            GetNotificationsServiceURL.Replace("{watcher-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(WatcherId, System.Globalization.CultureInfo.InvariantCulture)));
            request.Resource = GetNotificationsServiceURL.ToString();
            var response = restClient.Execute(request);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP GET operation to " + GetNotificationsServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, null);
			}
            else
			{
				try
				{
					returnValue = JsonConvert.DeserializeObject<NSXTNotificationsListType>(response.Content, defaultSerializationSettings);
				}
				catch (Exception ex)
				{
					var message = "Could not deserialize the response body string as " + typeof(NSXTNotificationsListType).FullName + ".";
					throw new NSXTException(message, (int)response.StatusCode, response.Content, response.Headers, ex.InnerException);
				}
			}
			return returnValue;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public NSXTNotificationWatcherType UpdateNotificationWatcher(string WatcherId, NSXTNotificationWatcherType NotificationWatcher)
        {
            if (WatcherId == null) { throw new System.ArgumentNullException("WatcherId cannot be null"); }
            if (NotificationWatcher == null) { throw new System.ArgumentNullException("NotificationWatcher cannot be null"); }
            NSXTNotificationWatcherType returnValue = default(NSXTNotificationWatcherType);
            StringBuilder UpdateNotificationWatcherServiceURL = new StringBuilder("/notification-watchers/{watcher-id}");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.PUT
            };
            request.AddHeader("Content-type", "application/json");
            UpdateNotificationWatcherServiceURL.Replace("{watcher-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(WatcherId, System.Globalization.CultureInfo.InvariantCulture)));
            request.AddJsonBody(JsonConvert.SerializeObject(NotificationWatcher, defaultSerializationSettings));
            request.Resource = UpdateNotificationWatcherServiceURL.ToString();
            var response = restClient.Execute(request);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP PUT operation to " + UpdateNotificationWatcherServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, null);
			}
            else
			{
				try
				{
					returnValue = JsonConvert.DeserializeObject<NSXTNotificationWatcherType>(response.Content, defaultSerializationSettings);
				}
				catch (Exception ex)
				{
					var message = "Could not deserialize the response body string as " + typeof(NSXTNotificationWatcherType).FullName + ".";
					throw new NSXTException(message, (int)response.StatusCode, response.Content, response.Headers, ex.InnerException);
				}
			}
			return returnValue;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public NSXTNotificationWatcherType GetNotificationWatcher(string WatcherId)
        {
            if (WatcherId == null) { throw new System.ArgumentNullException("WatcherId cannot be null"); }
            NSXTNotificationWatcherType returnValue = default(NSXTNotificationWatcherType);
            StringBuilder GetNotificationWatcherServiceURL = new StringBuilder("/notification-watchers/{watcher-id}");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.GET
            };
            request.AddHeader("Content-type", "application/json");
            GetNotificationWatcherServiceURL.Replace("{watcher-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(WatcherId, System.Globalization.CultureInfo.InvariantCulture)));
            request.Resource = GetNotificationWatcherServiceURL.ToString();
            var response = restClient.Execute(request);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP GET operation to " + GetNotificationWatcherServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, null);
			}
            else
			{
				try
				{
					returnValue = JsonConvert.DeserializeObject<NSXTNotificationWatcherType>(response.Content, defaultSerializationSettings);
				}
				catch (Exception ex)
				{
					var message = "Could not deserialize the response body string as " + typeof(NSXTNotificationWatcherType).FullName + ".";
					throw new NSXTException(message, (int)response.StatusCode, response.Content, response.Headers, ex.InnerException);
				}
			}
			return returnValue;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public void DeleteNotificationWatcher(string WatcherId)
        {
            if (WatcherId == null) { throw new System.ArgumentNullException("WatcherId cannot be null"); }
            
            StringBuilder DeleteNotificationWatcherServiceURL = new StringBuilder("/notification-watchers/{watcher-id}");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.DELETE
            };
            request.AddHeader("Content-type", "application/json");
            DeleteNotificationWatcherServiceURL.Replace("{watcher-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(WatcherId, System.Globalization.CultureInfo.InvariantCulture)));
            request.Resource = DeleteNotificationWatcherServiceURL.ToString();
            var response = restClient.Execute(request);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP DELETE operation to " + DeleteNotificationWatcherServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, null);
			}
            
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public NSXTNotificationsListType DeleteUriFiltersDeleteUriFilters(string WatcherId, NSXTNotificationType Notification)
        {
            if (WatcherId == null) { throw new System.ArgumentNullException("WatcherId cannot be null"); }
            if (Notification == null) { throw new System.ArgumentNullException("Notification cannot be null"); }
            NSXTNotificationsListType returnValue = default(NSXTNotificationsListType);
            StringBuilder DeleteUriFiltersDeleteUriFiltersServiceURL = new StringBuilder("/notification-watchers/{watcher-id}/notifications?action=delete_uri_filters");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.POST
            };
            request.AddHeader("Content-type", "application/json");
            DeleteUriFiltersDeleteUriFiltersServiceURL.Replace("{watcher-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(WatcherId, System.Globalization.CultureInfo.InvariantCulture)));
            request.AddJsonBody(JsonConvert.SerializeObject(Notification, defaultSerializationSettings));
            request.Resource = DeleteUriFiltersDeleteUriFiltersServiceURL.ToString();
            var response = restClient.Execute(request);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP POST operation to " + DeleteUriFiltersDeleteUriFiltersServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, null);
			}
            else
			{
				try
				{
					returnValue = JsonConvert.DeserializeObject<NSXTNotificationsListType>(response.Content, defaultSerializationSettings);
				}
				catch (Exception ex)
				{
					var message = "Could not deserialize the response body string as " + typeof(NSXTNotificationsListType).FullName + ".";
					throw new NSXTException(message, (int)response.StatusCode, response.Content, response.Headers, ex.InnerException);
				}
			}
			return returnValue;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public NSXTNotificationsListType AddUriFiltersAddUriFilters(string WatcherId, NSXTNotificationType Notification)
        {
            if (WatcherId == null) { throw new System.ArgumentNullException("WatcherId cannot be null"); }
            if (Notification == null) { throw new System.ArgumentNullException("Notification cannot be null"); }
            NSXTNotificationsListType returnValue = default(NSXTNotificationsListType);
            StringBuilder AddUriFiltersAddUriFiltersServiceURL = new StringBuilder("/notification-watchers/{watcher-id}/notifications?action=add_uri_filters");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.POST
            };
            request.AddHeader("Content-type", "application/json");
            AddUriFiltersAddUriFiltersServiceURL.Replace("{watcher-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(WatcherId, System.Globalization.CultureInfo.InvariantCulture)));
            request.AddJsonBody(JsonConvert.SerializeObject(Notification, defaultSerializationSettings));
            request.Resource = AddUriFiltersAddUriFiltersServiceURL.ToString();
            var response = restClient.Execute(request);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP POST operation to " + AddUriFiltersAddUriFiltersServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, null);
			}
            else
			{
				try
				{
					returnValue = JsonConvert.DeserializeObject<NSXTNotificationsListType>(response.Content, defaultSerializationSettings);
				}
				catch (Exception ex)
				{
					var message = "Could not deserialize the response body string as " + typeof(NSXTNotificationsListType).FullName + ".";
					throw new NSXTException(message, (int)response.StatusCode, response.Content, response.Headers, ex.InnerException);
				}
			}
			return returnValue;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public NSXTNotificationWatcherType AddNotificationWatcher(NSXTNotificationWatcherType NotificationWatcher)
        {
            if (NotificationWatcher == null) { throw new System.ArgumentNullException("NotificationWatcher cannot be null"); }
            NSXTNotificationWatcherType returnValue = default(NSXTNotificationWatcherType);
            StringBuilder AddNotificationWatcherServiceURL = new StringBuilder("/notification-watchers");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.POST
            };
            request.AddHeader("Content-type", "application/json");
            request.AddJsonBody(JsonConvert.SerializeObject(NotificationWatcher, defaultSerializationSettings));
            request.Resource = AddNotificationWatcherServiceURL.ToString();
            var response = restClient.Execute(request);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP POST operation to " + AddNotificationWatcherServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, null);
			}
            else
			{
				try
				{
					returnValue = JsonConvert.DeserializeObject<NSXTNotificationWatcherType>(response.Content, defaultSerializationSettings);
				}
				catch (Exception ex)
				{
					var message = "Could not deserialize the response body string as " + typeof(NSXTNotificationWatcherType).FullName + ".";
					throw new NSXTException(message, (int)response.StatusCode, response.Content, response.Headers, ex.InnerException);
				}
			}
			return returnValue;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public NSXTNotificationWatcherListResultType ListNotificationWatchers()
        {
            NSXTNotificationWatcherListResultType returnValue = default(NSXTNotificationWatcherListResultType);
            StringBuilder ListNotificationWatchersServiceURL = new StringBuilder("/notification-watchers");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.GET
            };
            request.AddHeader("Content-type", "application/json");
            request.Resource = ListNotificationWatchersServiceURL.ToString();
            var response = restClient.Execute(request);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP GET operation to " + ListNotificationWatchersServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, null);
			}
            else
			{
				try
				{
					returnValue = JsonConvert.DeserializeObject<NSXTNotificationWatcherListResultType>(response.Content, defaultSerializationSettings);
				}
				catch (Exception ex)
				{
					var message = "Could not deserialize the response body string as " + typeof(NSXTNotificationWatcherListResultType).FullName + ".";
					throw new NSXTException(message, (int)response.StatusCode, response.Content, response.Headers, ex.InnerException);
				}
			}
			return returnValue;
        }
    }
}
