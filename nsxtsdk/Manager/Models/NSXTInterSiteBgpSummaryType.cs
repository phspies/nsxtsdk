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
    /// 
    /// </summary>
    [NSXTProperty(Description: @"")]
    public class NSXTInterSiteBgpSummaryType 
    {
        public NSXTInterSiteBgpSummaryType()
        {
        }
        /// <summary>
        /// Timestamp when the inter-site IBgp neighbors status was last updated.
        /// </summary>
        [JsonProperty(PropertyName = "last_update_timestamp")]
        [NSXTProperty(IsRequired: false, Description: @"Timestamp when the inter-site IBgp neighbors status was last updated.")]
        public long? LastUpdateTimestamp { get; set; }
        /// <summary>
        /// Status of all inter-site IBgp neighbors.
        /// </summary>
        [JsonProperty(PropertyName = "neighbor_status")]
        [NSXTProperty(IsRequired: false, Description: @"Status of all inter-site IBgp neighbors.")]
        public IList<NSXTBgpNeighborStatusType> NeighborStatus { get; set; }
        /// <summary>
        /// Edge node id whose status is being reported.
        /// </summary>
        [JsonProperty(PropertyName = "transport_node_id")]
        [NSXTProperty(IsRequired: false, Description: @"Edge node id whose status is being reported.")]
        public string? TransportNodeId { get; set; }
    }
}
