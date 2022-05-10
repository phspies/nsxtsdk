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
    /// Static IPv4 multicast address and assciated multicast group ranges.
    /// </summary>
    [NSXTProperty(Description: @"Static IPv4 multicast address and assciated multicast group ranges.")]
    public class NSXTRpAddressMulticastRangesType 
    {
        /// <summary>
        /// Assciated multicast group ranges configuration.
        /// </summary>
        [JsonProperty(PropertyName = "multicast_ranges")]
        public IList<string> MulticastRanges { get; set; }
        /// <summary>
        /// Static IPv4 multicast address configuration.
        /// </summary>
        [JsonProperty(PropertyName = "rp_address", Required = Required.AllowNull)]
        public string RpAddress { get; set; }
    }
}
