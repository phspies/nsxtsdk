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
    public class NSXTBgpNeighborAddressFamilyType 
    {
        /// <summary>
        /// Id of the IPPrefix List to be used for IN direction filter
        /// </summary>
        [JsonProperty(PropertyName = "in_filter_ipprefixlist_id")]
        public string? InFilterIpprefixlistId { get; set; }
        /// <summary>
        /// Id of the RouteMap to be used for OUT direction filter
        /// </summary>
        [JsonProperty(PropertyName = "out_filter_routemap_id")]
        public string? OutFilterRoutemapId { get; set; }
        /// <summary>
        /// Address family type
        /// </summary>
        [JsonProperty(PropertyName = "type", Required = Required.AllowNull)]
        [JsonConverter(typeof(StringEnumConverter))]
        public NSXTBgpNeighborAddressFamilyTypeEnumType Type { get; set; }
        /// <summary>
        /// Id of the RouteMap to be used for IN direction filter
        /// </summary>
        [JsonProperty(PropertyName = "in_filter_routemap_id")]
        public string? InFilterRoutemapId { get; set; }
        /// <summary>
        /// Enable this address family
        /// </summary>
        [JsonProperty(PropertyName = "enabled")]
        public bool? Enabled { get; set; }
        /// <summary>
        /// Id of the IPPrefixList to be used for OUT direction filter
        /// </summary>
        [JsonProperty(PropertyName = "out_filter_ipprefixlist_id")]
        public string? OutFilterIpprefixlistId { get; set; }
        /// <summary>
        /// Maximum number of routes supported on the address family
        /// </summary>
        [JsonProperty(PropertyName = "maximum_routes")]
        public long? MaximumRoutes { get; set; }
    }
}
