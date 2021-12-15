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
    /// Advanced configuration for Policy connectivity
    /// </summary>
    [NSXTProperty(Description: @"Advanced configuration for Policy connectivity")]
    public class NSXTConnectivityAdvancedConfigType 
    {
        /// <summary>
        /// Connectivity configuration to manually connect (ON) or disconnect (OFF)
        /// a Tier1 segment from corresponding Tier1 gateway. Only valid for Tier1
        /// Segments.
        /// This property is ignored for L2 VPN extended segments when subnets
        /// property is not specified.
        /// This property does not apply to VLAN backed segments. VLAN backed segments
        /// with connectivity OFF does not affect its layer-2 connectivity.
        /// </summary>
        [JsonProperty(PropertyName = "connectivity")]
        [NSXTProperty(IsRequired: false, Description: @"Connectivity configuration to manually connect (ON) or disconnect (OFF)a Tier1 segment from corresponding Tier1 gateway. Only valid for Tier1Segments.This property is ignored for L2 VPN extended segments when subnetsproperty is not specified.This property does not apply to VLAN backed segments. VLAN backed segmentswith connectivity OFF does not affect its layer-2 connectivity.")]
        [NSXTDefaultProperty(Default: "ON")]
        public NSXTConnectivityAdvancedConfigConnectivityEnumType? Connectivity { get; set; }
    }
}
