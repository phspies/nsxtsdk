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
    /// Single route redistribution rule
    /// </summary>
    [NSXTProperty(Description: @"Single route redistribution rule")]
    public class NSXTTier0RouteRedistributionRuleType 
    {
        /// <summary>
        /// Each rule can have more than one destinations. If destinations not specified for a given rule,
        /// default destionation will be BGP
        /// </summary>
        [JsonProperty(PropertyName = "destinations")]
        public IList<string> Destinations { get; set; }
        /// <summary>
        /// Route map to be associated with the redistribution rule
        /// </summary>
        [JsonProperty(PropertyName = "route_map_path")]
        public string? RouteMapPath { get; set; }
        /// <summary>
        /// Rule name
        /// </summary>
        [JsonProperty(PropertyName = "name")]
        public string? Name { get; set; }
        /// <summary>
        /// List of redistribution types
        /// </summary>
        [JsonProperty(PropertyName = "route_redistribution_types", Required = Required.AllowNull)]
        public IList<string> RouteRedistributionTypes { get; set; }
    }
}
