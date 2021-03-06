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
    /// Advanced load balancer DosThreshold object
    /// </summary>
    [NSXTProperty(Description: @"Advanced load balancer DosThreshold object")]
    public class NSXTALBDosThresholdType 
    {
        /// <summary>
        /// Maximum number of packets or connections or requests in a
        /// given interval of time to be deemed as attack.
        /// </summary>
        [JsonProperty(PropertyName = "max_value", Required = Required.AllowNull)]
        public long MaxValue { get; set; }
        /// <summary>
        /// Attack type.
        /// Enum options - LAND, SMURF, ICMP_PING_FLOOD,
        /// UNKOWN_PROTOCOL, TEARDROP, IP_FRAG_OVERRUN,
        /// IP_FRAG_TOOSMALL, IP_FRAG_FULL, IP_FRAG_INCOMPLETE,
        /// PORT_SCAN, TCP_NON_SYN_FLOOD_OLD, SYN_FLOOD, BAD_RST_FLOOD,
        /// MALFORMED_FLOOD, FAKE_SESSION, ZERO_WINDOW_STRESS,
        /// SMALL_WINDOW_STRESS, DOS_HTTP_TIMEOUT, DOS_HTTP_ERROR,
        /// DOS_HTTP_ABORT...
        /// </summary>
        [JsonProperty(PropertyName = "attack", Required = Required.AllowNull)]
        [JsonConverter(typeof(StringEnumConverter))]
        public NSXTAlbdosThresholdAttackEnumType Attack { get; set; }
        /// <summary>
        /// Minimum number of packets or connections or requests in a
        /// given interval of time to be deemed as attack.
        /// </summary>
        [JsonProperty(PropertyName = "min_value", Required = Required.AllowNull)]
        public long MinValue { get; set; }
    }
}
