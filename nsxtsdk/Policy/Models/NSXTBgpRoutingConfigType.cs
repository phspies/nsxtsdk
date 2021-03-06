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
    public class NSXTBgpRoutingConfigType : NSXTPolicyConfigResourceType
    {
        /// <summary>
        /// Flag to enable inter SR IBGP configuration.
        /// When not specified, inter SR IBGP is automatically enabled if Tier-0
        /// is created in ACTIVE_ACTIVE ha_mode.
        /// </summary>
        [JsonProperty(PropertyName = "inter_sr_ibgp")]
        public bool? InterSrIbgp { get; set; }
        /// <summary>
        /// Specify BGP AS number for Tier-0 to advertize to BGP peers.
        /// AS number can be specified in ASPLAIN (e.g., "65546") or
        /// ASDOT (e.g., "1.10") format. Empty string disables BGP feature.
        /// It is required by normal tier0 but not required in vrf tier0.
        /// </summary>
        [JsonProperty(PropertyName = "local_as_num")]
        public string? LocalAsNum { get; set; }
        /// <summary>
        /// Flag to enable graceful restart. This field is deprecated, please use
        /// graceful_restart_config parameter for graceful restart configuration.
        /// If both parameters are set and consistent with each other
        /// (i.e. graceful_restart=false and graceful_restart_mode=HELPER_ONLY OR
        /// graceful_restart=true and graceful_restart_mode=GR_AND_HELPER)
        /// then this is allowed, but if inconsistent with each other then this
        /// is not allowed and validation error will be thrown.
        /// </summary>
        [JsonProperty(PropertyName = "graceful_restart")]
        public bool? GracefulRestart { get; set; }
        /// <summary>
        /// List of routes to be aggregated.
        /// </summary>
        [JsonProperty(PropertyName = "route_aggregations")]
        public IList<NSXTRouteAggregationEntryType> RouteAggregations { get; set; }
        /// <summary>
        /// Flag to enable BGP configuration. Disabling will stop feature and
        /// BGP peering.
        /// </summary>
        [JsonProperty(PropertyName = "enabled")]
        public bool? Enabled { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [JsonProperty(PropertyName = "graceful_restart_config")]
        public NSXTBgpGracefulRestartConfigType GracefulRestartConfig { get; set; }
        /// <summary>
        /// Flag to enable BGP multipath relax option.
        /// </summary>
        [JsonProperty(PropertyName = "multipath_relax")]
        public bool? MultipathRelax { get; set; }
        /// <summary>
        /// Flag to enable ECMP.
        /// </summary>
        [JsonProperty(PropertyName = "ecmp")]
        public bool? Ecmp { get; set; }
    }
}
