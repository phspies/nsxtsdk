using nsxtsdk.Models;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.ComponentModel;
using NJsonSchema.Converters;
using Newtonsoft.Json.Converters;

namespace nsxtsdk.PolicyModels
{
    /// <summary>
    /// User Login/Logout event Map
    /// </summary>
    [NSXTProperty(Description: @"User Login/Logout event Map")]
    public class NSXTLoginLogoutEventMapType 
    {
        /// <summary>
        /// 
        /// </summary>
        [JsonProperty(PropertyName = "event_source", Required = Required.AllowNull)]
        [JsonConverter(typeof(StringEnumConverter))]
        public NSXTLoginLogoutEventMapEventSourceEnumType EventSource { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [JsonProperty(PropertyName = "event_type", Required = Required.AllowNull)]
        [JsonConverter(typeof(StringEnumConverter))]
        public NSXTLoginLogoutEventMapEventTypeEnumType EventType { get; set; }
        /// <summary>
        /// Timestamp in milliseconds since epoch
        /// </summary>
        [JsonProperty(PropertyName = "event_time", Required = Required.AllowNull)]
        public long EventTime { get; set; }
        /// <summary>
        /// IP Address of user
        /// </summary>
        [JsonProperty(PropertyName = "ip_address", Required = Required.AllowNull)]
        public string IpAddress { get; set; }
        /// <summary>
        /// User name
        /// </summary>
        [JsonProperty(PropertyName = "user_name", Required = Required.AllowNull)]
        public string UserName { get; set; }
        /// <summary>
        /// Domain name
        /// </summary>
        [JsonProperty(PropertyName = "domain_name", Required = Required.AllowNull)]
        public string DomainName { get; set; }
    }
}
