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
    /// 
    /// </summary>
    [NSXTProperty(Description: @"")]
    public class NSXTPolicyDnsForwarderType : NSXTPolicyConfigResourceType
    {
        /// <summary>
        /// Set log_level to DISABLED will stop dumping fowarder log.
        /// </summary>
        [JsonProperty(PropertyName = "log_level")]
        [JsonConverter(typeof(StringEnumConverter))]
        public NSXTPolicyDnsForwarderLogLevelEnumType? LogLevel { get; set; }
        /// <summary>
        /// Cache size in KB.
        /// </summary>
        [JsonProperty(PropertyName = "cache_size")]
        public int? CacheSize { get; set; }
        /// <summary>
        /// The flag, which suggests whether the DNS forwarder is enabled or
        /// disabled. The default is True.
        /// </summary>
        [JsonProperty(PropertyName = "enabled")]
        public bool? Enabled { get; set; }
        /// <summary>
        /// Max of 5 DNS servers can be configured
        /// </summary>
        [JsonProperty(PropertyName = "conditional_forwarder_zone_paths")]
        public IList<string> ConditionalForwarderZonePaths { get; set; }
        /// <summary>
        /// This is the zone to which DNS requests are forwarded by default
        /// </summary>
        [JsonProperty(PropertyName = "default_forwarder_zone_path", Required = Required.AllowNull)]
        public string DefaultForwarderZonePath { get; set; }
        /// <summary>
        /// This is the IP on which the DNS Forwarder listens.
        /// </summary>
        [JsonProperty(PropertyName = "listener_ip", Required = Required.AllowNull)]
        public string ListenerIp { get; set; }
    }
}
