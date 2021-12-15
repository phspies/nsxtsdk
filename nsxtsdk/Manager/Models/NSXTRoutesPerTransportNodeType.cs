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

namespace nsxtsdk.ManagerModels
{
    /// <summary>
    /// BGP routes per transport node.
    /// </summary>
    [NSXTProperty(Description: @"BGP routes per transport node.")]
    public class NSXTRoutesPerTransportNodeType 
    {
        /// <summary>
        /// Array of BGP neighbor route details for this transport node.
        /// </summary>
        [JsonProperty(PropertyName = "routes")]
        [NSXTProperty(IsRequired: false, Description: @"Array of BGP neighbor route details for this transport node.")]
        public IList<NSXTRouteDetailsType> Routes { get; set; }
        /// <summary>
        /// BGP neighbor source address.
        /// </summary>
        [JsonProperty(PropertyName = "source_address")]
        [NSXTProperty(IsRequired: false, Description: @"BGP neighbor source address.")]
        public string? SourceAddress { get; set; }
        /// <summary>
        /// Transport node id
        /// </summary>
        [JsonProperty(PropertyName = "transport_node_id")]
        [NSXTProperty(IsRequired: false, Description: @"Transport node id")]
        public string? TransportNodeId { get; set; }
    }
}