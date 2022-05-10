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
    /// Enables traffic limit for incoming/outgoing broadcast and multicast packets. Use 0 to disable rate limiting for a
        /// specific traffic type
    /// </summary>
    [NSXTProperty(Description: @"Enables traffic limit for incoming/outgoing broadcast and multicast packets. Use 0 to disable rate limiting for a specific traffic type")]
    public class NSXTTrafficRateLimitsType 
    {
        /// <summary>
        /// Incoming multicast traffic limit in packets per second
        /// </summary>
        [JsonProperty(PropertyName = "rx_multicast")]
        public int? RxMulticast { get; set; }
        /// <summary>
        /// Outgoing multicast traffic limit in packets per second
        /// </summary>
        [JsonProperty(PropertyName = "tx_multicast")]
        public int? TxMulticast { get; set; }
        /// <summary>
        /// Outgoing broadcast traffic limit in packets per second
        /// </summary>
        [JsonProperty(PropertyName = "tx_broadcast")]
        public int? TxBroadcast { get; set; }
        /// <summary>
        /// Incoming broadcast traffic limit in packets per second
        /// </summary>
        [JsonProperty(PropertyName = "rx_broadcast")]
        public int? RxBroadcast { get; set; }
    }
}
