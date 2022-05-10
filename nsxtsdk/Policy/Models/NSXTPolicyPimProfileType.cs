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
    public class NSXTPolicyPimProfileType : NSXTPolicyConfigResourceType
    {
        /// <summary>
        /// Static IPv4 multicast address and assciated multicast groups configuration.
        /// </summary>
        [JsonProperty(PropertyName = "rp_address_multicast_ranges")]
        public IList<NSXTRpAddressMulticastRangesType> RpAddressMulticastRanges { get; set; }
        /// <summary>
        /// Enable/disable bootstrap messaging Configuration.
        /// </summary>
        [JsonProperty(PropertyName = "bsm_enabled")]
        public bool? BsmEnabled { get; set; }
        /// <summary>
        /// Static IPv4 multicast address configuration.
        /// </summary>
        [JsonProperty(PropertyName = "rp_address")]
        public string? RpAddress { get; set; }
    }
}
