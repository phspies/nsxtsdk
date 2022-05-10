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
    /// Tier-0 vrf configuration.
    /// </summary>
    [NSXTProperty(Description: @"Tier-0 vrf configuration.")]
    public class NSXTTier0VrfConfigType 
    {
        /// <summary>
        /// Route targets.
        /// </summary>
        [JsonProperty(PropertyName = "route_targets")]
        public IList<NSXTVrfRouteTargetsType> RouteTargets { get; set; }
        /// <summary>
        /// L3 VNI associated with the VRF for overlay traffic of ethernet virtual
        /// private network (EVPN). It must be unique and available from the VNI
        /// pool defined for EVPN service. It is required for VRF to participate
        /// in the EVPN service in INLINE mode.
        /// </summary>
        [JsonProperty(PropertyName = "evpn_transit_vni")]
        public int? EvpnTransitVni { get; set; }
        /// <summary>
        /// Default tier0 path. Cannot be modified after realization.
        /// </summary>
        [JsonProperty(PropertyName = "tier0_path", Required = Required.AllowNull)]
        public string Tier0Path { get; set; }
        /// <summary>
        /// Route distinguisher with format in IPAddress:<number> or ASN:<number>.
        /// </summary>
        [JsonProperty(PropertyName = "route_distinguisher")]
        public string? RouteDistinguisher { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [JsonProperty(PropertyName = "evpn_l2_vni_config")]
        public NSXTVrfEvpnL2VniConfigType EvpnL2VniConfig { get; set; }
    }
}
