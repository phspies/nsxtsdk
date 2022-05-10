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
    public class NSXTNsxTDNSForwarderStatusType : NSXTDNSForwarderStatusPerEnforcementPointType
    {
        /// <summary>
        /// UP means the DNS forwarder is working correctly on the active transport
        /// node and the stand-by transport node (if present). Failover will occur
        /// if either node goes down.
        /// DOWN means the DNS forwarder is down on both active transport node and
        /// standby node (if present). The DNS forwarder does not function in this
        /// situation.
        /// Error means there is some error on one or both transport node, or no
        /// status was reported from one or both transport nodes. The DNS forwarder
        /// may be working (or not working).
        /// NO_BACKUP means DNS forwarder is working in only one transport node,
        /// either because it is down on the standby node, or no standby is configured.
        /// An forwarder outage will occur if the active node goes down.
        /// </summary>
        [JsonProperty(PropertyName = "status")]
        [JsonConverter(typeof(StringEnumConverter))]
        public NSXTNsxTdnsforwarderStatusStatusEnumType? Status { get; set; }
        /// <summary>
        /// Time stamp of the current status, in ms
        /// </summary>
        [JsonProperty(PropertyName = "timestamp")]
        public long? Timestamp { get; set; }
        /// <summary>
        /// Extra message, if available
        /// </summary>
        [JsonProperty(PropertyName = "extra_message")]
        public string? ExtraMessage { get; set; }
    }
}
