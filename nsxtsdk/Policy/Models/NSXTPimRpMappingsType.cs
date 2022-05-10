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
    public class NSXTPimRpMappingsType : NSXTListResultType
    {
        /// <summary>
        /// Policy path to Tier0 gateway.
        /// </summary>
        [JsonProperty(PropertyName = "gateway_path", Required = Required.AllowNull)]
        public string GatewayPath { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [JsonProperty(PropertyName = "pim_rp_mappings_per_edge")]
        public IList<NSXTPimRpMappingsPerEdgeType> PimRpMappingsPerEdge { get; set; }
    }
}
