using nsxtsdk.Models;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.ComponentModel;
using NJsonSchema.Converters;
using Newtonsoft.Json.Converters;

namespace nsxtsdk.ManagerModels
{
    /// <summary>
    /// 
    /// </summary>
    [NSXTProperty(Description: @"")]
    public class NSXTNotificationType 
    {
        /// <summary>
        /// A string identifying feature_name.notification_name to indicate a notification watcher is interested in receiving
        /// notifications for the URI identified by the feature_name.notification_name.
        /// </summary>
        [JsonProperty(PropertyName = "notification_id")]
        public string? NotificationId { get; set; }
        /// <summary>
        /// Optional list of URIs
        /// </summary>
        [JsonProperty(PropertyName = "uri_filters")]
        public IList<string> UriFilters { get; set; }
    }
}
