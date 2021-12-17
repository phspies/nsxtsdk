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
    /// Route Redistribution config
    /// </summary>
    [NSXTProperty(Description: @"Route Redistribution config")]
    public class NSXTTier0RouteRedistributionConfigType 
    {
        public NSXTTier0RouteRedistributionConfigType()
        {
            BgpEnabled = test
        }
        /// <summary>
        /// List of redistribution rules.
        /// </summary>
        [JsonProperty(PropertyName = "redistribution_rules")]
        [NSXTProperty(IsRequired: false, Description: @"List of redistribution rules.")]
        public IList<NSXTTier0RouteRedistributionRuleType> RedistributionRules { get; set; }
        /// <summary>
        /// Flag to enable route redistribution for OSPF.
        /// </summary>
        [JsonProperty(PropertyName = "ospf_enabled")]
        [NSXTProperty(IsRequired: false, Description: @"Flag to enable route redistribution for OSPF.")]
        public bool? OspfEnabled { get; set; }
        /// <summary>
        /// Flag to enable route redistribution for BGP.
        /// </summary>
        [JsonProperty(PropertyName = "bgp_enabled")]
        [NSXTProperty(IsRequired: false, Description: @"Flag to enable route redistribution for BGP.")]
        public bool? BgpEnabled { get; set; }
    }
}
