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
    /// 
    /// </summary>
    [NSXTProperty(Description: @"")]
    public class NSXTBgpConfigType : NSXTManagedResourceType
    {
        /// <summary>
        /// 
        /// </summary>
        [JsonProperty(PropertyName = "inter_sr_ibgp")]
        public NSXTInterSRRoutingConfigType InterSrIbgp { get; set; }
        /// <summary>
        /// This is a deprecated property, Please use 'as_num' instead. For VRF logical router, the as_number from parent logical
        /// router will be effective.
        /// </summary>
        [JsonProperty(PropertyName = "as_number")]
        public long? AsNumber { get; set; }
        /// <summary>
        /// List of routes to be aggregated
        /// </summary>
        [JsonProperty(PropertyName = "route_aggregation")]
        public IList<NSXTBgpRouteAggregationType> RouteAggregation { get; set; }
        /// <summary>
        /// Logical router id
        /// </summary>
        [JsonProperty(PropertyName = "logical_router_id")]
        public string? LogicalRouterId { get; set; }
        /// <summary>
        /// Flag to enable graceful restart. This field is deprecated, kindly use
        /// graceful_restart_config parameter for graceful restart configuration.
        /// If both parameters are set and consistent with each other
        /// [i.e. graceful_restart=false and graceful_restart_mode=HELPER_ONLY OR
        /// graceful_restart=true and graceful_restart_mode=GR_AND_HELPER]
        /// then this is allowed, but if inconsistent with each other then this
        /// is not allowed and validation error will be thrown. For VRF logical router,
        /// the settings from parent logical router will be effective.
        /// </summary>
        [JsonProperty(PropertyName = "graceful_restart")]
        public bool? GracefulRestart { get; set; }
        /// <summary>
        /// For VRF logical router, the as_num from parent logical router will be effective.
        /// </summary>
        [JsonProperty(PropertyName = "as_num")]
        public string? AsNum { get; set; }
        /// <summary>
        /// While creation of BGP config this flag will be set to
        /// - true for Tier0 logical router with Active-Active high-availability
        /// mode
        /// - false for Tier0 logical router with Active-Standby high-availanility
        /// mode.
        /// User can change this value while updating the config. If this
        /// property is not specified in the payload, the default value will be
        /// considered as false irrespective of the high-availability mode.
        /// </summary>
        [JsonProperty(PropertyName = "enabled")]
        public bool? Enabled { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [JsonProperty(PropertyName = "graceful_restart_config")]
        public NSXTGracefulRestartConfigType GracefulRestartConfig { get; set; }
        /// <summary>
        /// For TIER0 logical router, default is true. For VRF logical router, the settings from parent logical router will be
        /// effective.
        /// </summary>
        [JsonProperty(PropertyName = "multipath_relax")]
        public bool? MultipathRelax { get; set; }
        /// <summary>
        /// While creation of BGP config this flag will be set to true
        /// User can change this value while updating BGP config. If this property
        /// is not specified in the payload, the default value will be considered
        /// as true.
        /// </summary>
        [JsonProperty(PropertyName = "ecmp")]
        public bool? Ecmp { get; set; }
    }
}
