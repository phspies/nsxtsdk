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
    public class NSXTOspfAreaConfigType : NSXTPolicyConfigResourceType
    {
        /// <summary>
        /// OSPF area-id either in decimal or dotted format.
        /// </summary>
        [JsonProperty(PropertyName = "area_id", Required = Required.AllowNull)]
        public string AreaId { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [JsonProperty(PropertyName = "authentication")]
        public NSXTOspfAuthenticationConfigType Authentication { get; set; }
        /// <summary>
        /// Configures OSPF area with defined area type. If area_type field not specified, default is NSSA.
        /// </summary>
        [JsonProperty(PropertyName = "area_type")]
        [JsonConverter(typeof(StringEnumConverter))]
        public NSXTOspfAreaConfigAreaTypeEnumType? AreaType { get; set; }
    }
}
