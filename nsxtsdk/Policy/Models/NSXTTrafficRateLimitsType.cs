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
        [NSXTProperty(IsRequired: false, Description: @"Incoming multicast traffic limit in packets per second")]
        //[System.ComponentModel.DataAnnotations.MinLength(0)]
        [NSXTDefaultProperty(Default: "")]
        public long? RxMulticast { get; set; }
        /// <summary>
        /// Outgoing multicast traffic limit in packets per second
        /// </summary>
        [JsonProperty(PropertyName = "tx_multicast")]
        [NSXTProperty(IsRequired: false, Description: @"Outgoing multicast traffic limit in packets per second")]
        //[System.ComponentModel.DataAnnotations.MinLength(0)]
        [NSXTDefaultProperty(Default: "")]
        public long? TxMulticast { get; set; }
        /// <summary>
        /// Outgoing broadcast traffic limit in packets per second
        /// </summary>
        [JsonProperty(PropertyName = "tx_broadcast")]
        [NSXTProperty(IsRequired: false, Description: @"Outgoing broadcast traffic limit in packets per second")]
        //[System.ComponentModel.DataAnnotations.MinLength(0)]
        [NSXTDefaultProperty(Default: "")]
        public long? TxBroadcast { get; set; }
        /// <summary>
        /// Incoming broadcast traffic limit in packets per second
        /// </summary>
        [JsonProperty(PropertyName = "rx_broadcast")]
        [NSXTProperty(IsRequired: false, Description: @"Incoming broadcast traffic limit in packets per second")]
        //[System.ComponentModel.DataAnnotations.MinLength(0)]
        [NSXTDefaultProperty(Default: "")]
        public long? RxBroadcast { get; set; }
    }
}