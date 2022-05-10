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
    public class NSXTNotificationWatcherType : NSXTManagedResourceType
    {
        /// <summary>
        /// Optional description that can be associated with this NotificationWatcher.
        /// </summary>
        [JsonProperty(PropertyName = "description")]
        public string? Description { get; set; }
        /// <summary>
        /// Optional time duration (in seconds) to specify request timeout to notification watcher. If the send reaches the timeout,
        /// will try to send refresh_needed as true in the next time interval. The default value is 30 seconds.
        /// </summary>
        [JsonProperty(PropertyName = "send_timeout")]
        public long? SendTimeout { get; set; }
        /// <summary>
        /// URI notification requests should be made on the specified server.
        /// </summary>
        [JsonProperty(PropertyName = "uri", Required = Required.AllowNull)]
        public string Uri { get; set; }
        /// <summary>
        /// System generated identifier to identify a notification watcher uniquely.
        /// </summary>
        [JsonProperty(PropertyName = "id")]
        public string? Id { get; set; }
        /// <summary>
        /// Contains the hex-encoded SHA256 thumbprint of the HTTPS certificate. It must be specified if use_https is set to true.
        /// </summary>
        [JsonProperty(PropertyName = "certificate_sha256_thumbprint")]
        public string? CertificateSha256Thumbprint { get; set; }
        /// <summary>
        /// Type of method notification requests should be made on the specified server. The value must be set to POST.
        /// </summary>
        [JsonProperty(PropertyName = "method", Required = Required.AllowNull)]
        [JsonConverter(typeof(StringEnumConverter))]
        public NSXTNotificationWatcherMethodEnumType Method { get; set; }
        /// <summary>
        /// Optional time interval (in seconds) for which notification URIs will be accumulated. At the end of the time interval the
        /// accumulated notification URIs will be sent to this NotificationWatcher in the form of zero (nothing accumulated) or more
        /// notification requests as soon as possible. If it is not specified, the NotificationWatcher should expected to receive
        /// notifications at any time.
        /// </summary>
        [JsonProperty(PropertyName = "send_interval")]
        public long? SendInterval { get; set; }
        /// <summary>
        /// If the number of notification URIs accumulated in specified send_interval exceeds max_send_uri_count, then multiple
        /// notification requests (each with max_send_uri_count or less number of notification URIs) will be sent to this
        /// NotificationWatcher. The default value is 5000.
        /// </summary>
        [JsonProperty(PropertyName = "max_send_uri_count")]
        public long? MaxSendUriCount { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [JsonProperty(PropertyName = "authentication_scheme", Required = Required.AllowNull)]
        public NSXTNotificationAuthenticationSchemeType AuthenticationScheme { get; set; }
        /// <summary>
        /// IP address or fully qualified domain name of the partner/customer watcher.
        /// </summary>
        [JsonProperty(PropertyName = "server", Required = Required.AllowNull)]
        public string Server { get; set; }
        /// <summary>
        /// Optional integer port value to specify a non-standard HTTP or HTTPS port.
        /// </summary>
        [JsonProperty(PropertyName = "port")]
        public long? Port { get; set; }
        /// <summary>
        /// Optional field, when set to true indicates REST API server should use HTTPS.
        /// </summary>
        [JsonProperty(PropertyName = "use_https")]
        public bool? UseHttps { get; set; }
    }
}
