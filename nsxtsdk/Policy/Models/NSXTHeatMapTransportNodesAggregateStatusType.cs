// <auto-generated>
// Changes may cause incorrect behavior and will be lost if the code is regenerated.
// </auto-generated>
using nsxtsdk.Models;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.ComponentModel;
using NJsonSchema.Converters;

namespace nsxtsdk.PolicyModels
{
    /// <summary>
    /// 
    /// </summary>
    [NSXTProperty(Description: @"")]
    public class NSXTHeatMapTransportNodesAggregateStatusType 
    {
        /// <summary>
        /// Number of transport nodes that are degraded
        /// </summary>
        public int? DegradedCount { get; set; }
        /// <summary>
        /// Number of transport nodes that are down
        /// </summary>
        public int? DownCount { get; set; }
        /// <summary>
        /// Number of transport nodes with unknown status
        /// </summary>
        public int? UnknownCount { get; set; }
        /// <summary>
        /// Number of transport nodes that are up
        /// </summary>
        public int? UpCount { get; set; }
    }
}
