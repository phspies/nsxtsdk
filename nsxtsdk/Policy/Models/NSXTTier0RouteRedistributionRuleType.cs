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
    /// Single route redistribution rule
    /// </summary>
    [NSXTProperty(Description: @"Single route redistribution rule")]
    public class NSXTTier0RouteRedistributionRuleType 
    {
        public NSXTTier0RouteRedistributionRuleType()
        {
        }
        /// <summary>
        /// Each rule can have more than one destinations. If destinations not specified for a given rule,
        /// default destionation will be BGP
        /// </summary>
        [JsonProperty(PropertyName = "destinations")]
        [NSXTProperty(IsRequired: false, Description: @"Each rule can have more than one destinations. If destinations not specified for a given rule,default destionation will be BGP")]
        public IList<string> Destinations { get; set; }
        /// <summary>
        /// Route map to be associated with the redistribution rule
        /// </summary>
        [JsonProperty(PropertyName = "route_map_path")]
        [NSXTProperty(IsRequired: false, Description: @"Route map to be associated with the redistribution rule")]
        public string? RouteMapPath { get; set; }
        /// <summary>
        /// Rule name
        /// </summary>
        [JsonProperty(PropertyName = "name")]
        [NSXTProperty(IsRequired: false, Description: @"Rule name")]
        public string? Name { get; set; }
        /// <summary>
        /// List of redistribution types
        /// </summary>
        [JsonProperty(PropertyName = "route_redistribution_types", Required = Required.AllowNull)]
        [NSXTProperty(IsRequired: true, Description: @"List of redistribution types")]
        [System.ComponentModel.DataAnnotations.Required]
        public IList<string> RouteRedistributionTypes { get; set; }
    }
}
