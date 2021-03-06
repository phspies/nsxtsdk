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
    public class NSXTDnsForwarderType : NSXTManagedResourceType
    {
        /// <summary>
        /// The conditional zone forwarders. During matching a zone forwarder,
        /// the DNS forwarder will use the conditional fowarder with the longest
        /// domain name that matches the query.
        /// </summary>
        [JsonProperty(PropertyName = "conditional_forwarders")]
        public IList<NSXTConditionalForwarderZoneType> ConditionalForwarders { get; set; }
        /// <summary>
        /// Specify the LogicalRouter where the DnsForwarder runs. The HA mode
        /// of the hosting LogicalRouter must be Active/Standby.
        /// </summary>
        [JsonProperty(PropertyName = "logical_router_id", Required = Required.AllowNull)]
        public string LogicalRouterId { get; set; }
        /// <summary>
        /// One DNS answer cache entry will consume ~120 bytes. Hence 1 KB cache
        /// size can cache ~8 DNS answer entries, and the default 1024 KB cache
        /// size can hold ~8k DNS answer entries.
        /// </summary>
        [JsonProperty(PropertyName = "cache_size")]
        public int? CacheSize { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [JsonProperty(PropertyName = "default_forwarder", Required = Required.AllowNull)]
        public NSXTForwarderZoneType DefaultForwarder { get; set; }
        /// <summary>
        /// Log level of the DNS forwarder
        /// </summary>
        [JsonProperty(PropertyName = "log_level")]
        [JsonConverter(typeof(StringEnumConverter))]
        public NSXTDnsForwarderLogLevelEnumType? LogLevel { get; set; }
        /// <summary>
        /// Flag to enable/disable the forwarder
        /// </summary>
        [JsonProperty(PropertyName = "enabled")]
        public bool? Enabled { get; set; }
        /// <summary>
        /// The ip address the DNS forwarder listens on. It can be an ip address
        /// already owned by the logical-router uplink port or router-link, or a
        /// loopback port ip address. But it can not be a downlink port address.
        /// User needs to ensure the address is reachable via router or NAT from
        /// both client VMs and upstream servers. User will need to create Firewall
        /// rules if needed to allow such traffic on a Tier-1 or Tier-0.
        /// </summary>
        [JsonProperty(PropertyName = "listener_ip", Required = Required.AllowNull)]
        public string ListenerIp { get; set; }
    }
}
