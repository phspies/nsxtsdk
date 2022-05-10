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
    /// PIM Rendezvous Point Mappings Per Edge.
    /// </summary>
    [NSXTProperty(Description: @"PIM Rendezvous Point Mappings Per Edge.")]
    public class NSXTPimRpMappingsPerEdgeType 
    {
        /// <summary>
        /// 
        /// </summary>
        [JsonProperty(PropertyName = "pim_rp_mappings")]
        public IList<NSXTPimRpMappingType> PimRpMappings { get; set; }
        /// <summary>
        /// Policy path to edge node.
        /// </summary>
        [JsonProperty(PropertyName = "edge_path", Required = Required.AllowNull)]
        public string EdgePath { get; set; }
    }
}
