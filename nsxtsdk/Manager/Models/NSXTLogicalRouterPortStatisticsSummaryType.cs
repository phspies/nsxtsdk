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
    public class NSXTLogicalRouterPortStatisticsSummaryType : NSXTAggregatedLogicalRouterPortCountersType
    {
        /// <summary>
        /// The ID of the logical router port
        /// </summary>
        [JsonProperty(PropertyName = "logical_router_port_id", Required = Required.AllowNull)]
        public string LogicalRouterPortId { get; set; }
    }
}
