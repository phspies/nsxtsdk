// <auto-generated>
// Changes may cause incorrect behavior and will be lost if the code is regenerated.
// </auto-generated>
using nsxtsdk.Models;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using NJsonSchema.Converters;
using System.ComponentModel;

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
        [NSXTProperty(IsRequired: false, Description: @"MSS defines the maximum amount of data that a host is willing toaccept in a single TCP segment. This field is set in TCP headerduring connection establishment. To avoid packet fragmentation,you can set this field depending on uplink MTU and VPN overhead.This is an optional field and in case it is left unconfigured,best possible MSS value will be calculated based on effectivemtu of uplink interface. Supported MSS range is 108 to 8852.")]
        //[System.ComponentModel.DataAnnotations.MinLength(108)]
        //[System.ComponentModel.DataAnnotations.MaxLength(8860)]
        public long? MaxSegmentSize { get; set; }
        /// <summary>
        /// Specifies the traffic direction for which to apply MSS Clamping.
        /// </summary>
        [JsonProperty(PropertyName = "direction")]
        [NSXTProperty(IsRequired: false, Description: @"Specifies the traffic direction for which to apply MSS Clamping.")]
        [NSXTDefaultProperty(Default: "BOTH")]
        public NSXTL2TcpMaxSegmentSizeClampingDirectionEnumType? Direction { get; set; }
    }
}
