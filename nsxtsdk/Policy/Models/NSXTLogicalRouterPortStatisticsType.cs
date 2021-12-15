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
    /// 
    /// </summary>
    [NSXTProperty(Description: @"")]
    public class NSXTLogicalRouterPortStatisticsType 
    {
        /// <summary>
        /// Per Node Statistics
        /// </summary>
        [JsonProperty(PropertyName = "per_node_statistics")]
        [NSXTProperty(IsRequired: false, Description: @"Per Node Statistics")]
        public IList<NSXTLogicalRouterPortStatisticsPerNodeType> PerNodeStatistics { get; set; }
        /// <summary>
        /// The ID of the logical router port
        /// </summary>
        [JsonProperty(PropertyName = "logical_router_port_id", Required = Required.AllowNull)]
        [NSXTProperty(IsRequired: true, Description: @"The ID of the logical router port")]
        [System.ComponentModel.DataAnnotations.Required]
        public string LogicalRouterPortId { get; set; }
    }
}
