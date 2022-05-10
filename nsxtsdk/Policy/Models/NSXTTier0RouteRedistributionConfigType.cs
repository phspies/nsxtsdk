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
    /// Route Redistribution config
    /// </summary>
    [NSXTProperty(Description: @"Route Redistribution config")]
    public class NSXTTier0RouteRedistributionConfigType 
    {
        /// <summary>
        /// List of redistribution rules.
        /// </summary>
        [JsonProperty(PropertyName = "redistribution_rules")]
        public IList<NSXTTier0RouteRedistributionRuleType> RedistributionRules { get; set; }
        /// <summary>
        /// Flag to enable route redistribution for OSPF.
        /// </summary>
        [JsonProperty(PropertyName = "ospf_enabled")]
        public bool? OspfEnabled { get; set; }
        /// <summary>
        /// Flag to enable route redistribution for BGP.
        /// </summary>
        [JsonProperty(PropertyName = "bgp_enabled")]
        public bool? BgpEnabled { get; set; }
    }
}
