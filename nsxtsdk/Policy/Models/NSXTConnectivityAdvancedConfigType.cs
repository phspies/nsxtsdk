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
    /// Advanced configuration for Policy connectivity
    /// </summary>
    [NSXTProperty(Description: @"Advanced configuration for Policy connectivity")]
    public class NSXTConnectivityAdvancedConfigType 
    {
        /// <summary>
        /// Connectivity configuration to manually connect (ON) or disconnect (OFF)
        /// Tier-0/Tier1 segment from corresponding gateway.
        /// This property does not apply to VLAN backed segments. VLAN backed segments
        /// with connectivity OFF does not affect its layer-2 connectivity.
        /// </summary>
        [JsonProperty(PropertyName = "connectivity")]
        [JsonConverter(typeof(StringEnumConverter))]
        public NSXTConnectivityAdvancedConfigConnectivityEnumType? Connectivity { get; set; }
    }
}
