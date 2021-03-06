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
    /// Index for cross site allocation for edge cluster
        /// and its members referred by gateway.
    /// </summary>
    [NSXTProperty(Description: @"Index for cross site allocation for edge clusterand its members referred by gateway.")]
    public class NSXTSiteAllocationIndexForEdgeType 
    {
        /// <summary>
        /// Unqiue edge cluster node index across sites based on stretch of the
        /// Gateway. For example, if a Gateway is streched to sites S1 with one
        /// edge cluster of 3 nodes and site S2 with one edge cluster of 2 nodes,
        /// the in the Global Manager will allocate the index for 5 edge nodes
        /// and 2 cluster in the rage 0 to 7.
        /// </summary>
        [JsonProperty(PropertyName = "index")]
        public long? Index { get; set; }
        /// <summary>
        /// Edge cluster or edge node path
        /// </summary>
        [JsonProperty(PropertyName = "target_resource_path")]
        public string? TargetResourcePath { get; set; }
    }
}
