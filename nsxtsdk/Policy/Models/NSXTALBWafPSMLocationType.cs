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
    /// Advanced load balancer WafPSMLocation object
    /// </summary>
    [NSXTProperty(Description: @"Advanced load balancer WafPSMLocation object")]
    public class NSXTALBWafPSMLocationType 
    {
        /// <summary>
        /// A list of rules which should be applied on this location.
        /// Maximum of 1024 items allowed.
        /// </summary>
        [JsonProperty(PropertyName = "rules")]
        public IList<NSXTALBWafPSMRuleType> Rules { get; set; }
        /// <summary>
        /// Location index, this is used to determine the order of the
        /// locations.
        /// </summary>
        [JsonProperty(PropertyName = "index", Required = Required.AllowNull)]
        public long Index { get; set; }
        /// <summary>
        /// Free-text comment about this location.
        /// </summary>
        [JsonProperty(PropertyName = "description")]
        public string? Description { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [JsonProperty(PropertyName = "match")]
        public NSXTALBWafPSMLocationMatchType Match { get; set; }
        /// <summary>
        /// User defined name for this location, it must be unique in
        /// the group.
        /// </summary>
        [JsonProperty(PropertyName = "name", Required = Required.AllowNull)]
        public string Name { get; set; }
    }
}
