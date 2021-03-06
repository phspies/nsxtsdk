using nsxtsdk.Models;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.ComponentModel;
using NJsonSchema.Converters;
using Newtonsoft.Json.Converters;

namespace nsxtsdk.ManagerModels
{
    /// <summary>
    /// Logical router configuration parameters.
    /// </summary>
    [NSXTProperty(Description: @"Logical router configuration parameters.")]
    public class NSXTLogicalRouterConfigType 
    {
        /// <summary>
        /// CIDR block defining service router to distributed router links.
        /// If the value for this field is not provided, then it will be
        /// considered as default IPv4 CIDR-
        /// "169.254.0.0/28" for logical router with ACTIVE_STANDBY HA mode
        /// "169.254.0.0/24" for logical router with ACTIVE_ACTIVE HA mode
        /// </summary>
        [JsonProperty(PropertyName = "internal_transit_network")]
        public string? InternalTransitNetwork { get; set; }
        /// <summary>
        /// Transport zone of the logical router. If specified then all downlink switches should belong to this transport zone and
        /// an error will be thrown if transport zone of the downlink switch doesn't match with this transport zone. All internal
        /// and external transit switches will be created in this transport zone.
        /// </summary>
        [JsonProperty(PropertyName = "transport_zone_id")]
        public string? TransportZoneId { get; set; }
        /// <summary>
        /// This configuration can be defined only for Active-Standby LogicalRouter to provide | redundancy. For mulitple uplink
        /// ports, multiple HaVipConfigs must be defined | and each config will pair exactly two uplink ports. The VIP will move and
        /// will | always be owned by the Active node. Note - when HaVipConfig[s] are defined, | configuring dynamic-routing is
        /// disallowed.
        /// </summary>
        [JsonProperty(PropertyName = "ha_vip_configs")]
        public IList<NSXTHaVipConfigType> HaVipConfigs { get; set; }
        /// <summary>
        /// CIDR block defining addresses for Tier0 to Tier1 links.
        /// If the value for this field is not provided, then it will be
        /// considered as default IPv4 CIDR "100.64.0.0/16"
        /// </summary>
        [JsonProperty(PropertyName = "external_transit_networks")]
        public IList<string> ExternalTransitNetworks { get; set; }
    }
}
