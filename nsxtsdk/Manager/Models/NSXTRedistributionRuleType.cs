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
    public class NSXTRedistributionRuleType 
    {
        /// <summary>
        /// Array of redistribution protocols
        /// </summary>
        [JsonProperty(PropertyName = "sources", Required = Required.AllowNull)]
        public IList<string> Sources { get; set; }
        /// <summary>
        /// RouteMap Id for the filter
        /// </summary>
        [JsonProperty(PropertyName = "route_map_id")]
        public string? RouteMapId { get; set; }
        /// <summary>
        /// Address family for Route Redistribution
        /// </summary>
        [JsonProperty(PropertyName = "address_family")]
        [JsonConverter(typeof(StringEnumConverter))]
        public NSXTRedistributionRuleAddressFamilyEnumType? AddressFamily { get; set; }
        /// <summary>
        /// Display name
        /// </summary>
        [JsonProperty(PropertyName = "display_name")]
        public string? DisplayName { get; set; }
        /// <summary>
        /// Destination redistribution protocol
        /// </summary>
        [JsonProperty(PropertyName = "destination")]
        [JsonConverter(typeof(StringEnumConverter))]
        public NSXTRedistributionRuleDestinationEnumType? Destination { get; set; }
        /// <summary>
        /// Description
        /// </summary>
        [JsonProperty(PropertyName = "description")]
        public string? Description { get; set; }
    }
}
