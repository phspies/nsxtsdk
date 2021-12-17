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
    /// PIM Rendezvous Point Mappings Per Edge.
    /// </summary>
    [NSXTProperty(Description: @"PIM Rendezvous Point Mappings Per Edge.")]
    public class NSXTPimRpMappingsPerEdgeType 
    {
        public NSXTPimRpMappingsPerEdgeType()
        {
        }
        /// <summary>
        /// 
        /// </summary>
        [JsonProperty(PropertyName = "pim_rp_mappings")]
        [NSXTProperty(IsRequired: false, Description: @"")]
        public IList<NSXTPimRpMappingType> PimRpMappings { get; set; }
        /// <summary>
        /// Policy path to edge node.
        /// </summary>
        [JsonProperty(PropertyName = "edge_path", Required = Required.AllowNull)]
        [NSXTProperty(IsRequired: true, Description: @"Policy path to edge node.")]
        [System.ComponentModel.DataAnnotations.Required]
        public string EdgePath { get; set; }
    }
}
