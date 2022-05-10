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
    public class NSXTPolicyEdgeClusterInterSiteBgpSummaryType : NSXTListResultType
    {
        /// <summary>
        /// Edge cluster path whose status is being reported.
        /// </summary>
        [JsonProperty(PropertyName = "edge_cluster_path")]
        public string? EdgeClusterPath { get; set; }
        /// <summary>
        /// Status of all edge nodes within cluster.
        /// </summary>
        [JsonProperty(PropertyName = "edge_nodes")]
        public IList<NSXTPolicyEdgeNodeInterSiteBgpSummaryType> EdgeNodes { get; set; }
    }
}
