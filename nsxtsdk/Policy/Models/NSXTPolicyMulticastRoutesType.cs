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
    /// Multicast Routes.
    /// </summary>
    [NSXTProperty(Description: @"Multicast Routes.")]
    public class NSXTPolicyMulticastRoutesType 
    {
        /// <summary>
        /// Policy path to Tier0 gateway.
        /// </summary>
        [JsonProperty(PropertyName = "gateway_path", Required = Required.AllowNull)]
        [NSXTProperty(IsRequired: true, Description: @"Policy path to Tier0 gateway.")]
        [System.ComponentModel.DataAnnotations.Required]
        public string GatewayPath { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [JsonProperty(PropertyName = "mcast_routes_per_edge")]
        [NSXTProperty(IsRequired: false, Description: @"")]
        public IList<NSXTMulticastRoutesPerEdgeType> McastRoutesPerEdge { get; set; }
    }
}
