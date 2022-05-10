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
    /// Routing policy details.
    /// </summary>
    [NSXTProperty(Description: @"Routing policy details.")]
    public class NSXTRoutingPolicyType 
    {
        /// <summary>
        /// Array of next hop to prefix lists mapping.
        /// </summary>
        [JsonProperty(PropertyName = "next_hop_prefix_lists_mappings", Required = Required.AllowNull)]
        public IList<NSXTNextHopPrefixListsMappingType> NextHopPrefixListsMappings { get; set; }
        /// <summary>
        /// Routing policy type.
        /// </summary>
        [JsonProperty(PropertyName = "routing_policy_type")]
        [JsonConverter(typeof(StringEnumConverter))]
        public NSXTRoutingPolicyRoutingPolicyTypeEnumType? RoutingPolicyType { get; set; }
    }
}
