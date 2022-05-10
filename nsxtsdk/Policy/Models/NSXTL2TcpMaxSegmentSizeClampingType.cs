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
    /// TCP MSS Clamping Direction and Value.
    /// </summary>
    [NSXTProperty(Description: @"TCP MSS Clamping Direction and Value.")]
    public class NSXTL2TcpMaxSegmentSizeClampingType 
    {
        /// <summary>
        /// MSS defines the maximum amount of data that a host is willing to
        /// accept in a single TCP segment. This field is set in TCP header
        /// during connection establishment. To avoid packet fragmentation,
        /// you can set this field depending on uplink MTU and VPN overhead.
        /// This is an optional field and in case it is left unconfigured,
        /// best possible MSS value will be calculated based on effective
        /// mtu of uplink interface. Supported MSS range is 108 to 8852.
        /// </summary>
        [JsonProperty(PropertyName = "max_segment_size")]
        public long? MaxSegmentSize { get; set; }
        /// <summary>
        /// Specifies the traffic direction for which to apply MSS Clamping.
        /// </summary>
        [JsonProperty(PropertyName = "direction")]
        [JsonConverter(typeof(StringEnumConverter))]
        public NSXTL2TcpMaxSegmentSizeClampingDirectionEnumType? Direction { get; set; }
    }
}
