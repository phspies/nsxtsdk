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
    /// Detailed view of the datapath memory usage. Details out the heap and per memory pool point in time usage.
    /// </summary>
    [NSXTProperty(Description: @"Detailed view of the datapath memory usage. Details out the heap and per memory pool point in time usage.")]
    public class NSXTEdgeTransportNodeDatapathMemoryUsageType 
    {
        /// <summary>
        /// Highest percentage usage value among datapath memory pools.
        /// </summary>
        [JsonProperty(PropertyName = "highest_datapath_mem_pool_usage")]
        public double? HighestDatapathMemPoolUsage { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [JsonProperty(PropertyName = "datapath_mem_pools_usage")]
        public IList<NSXTEdgeTransportNodeDatapathMemoryPoolUsageType> DatapathMemPoolsUsage { get; set; }
        /// <summary>
        /// Percentage of heap memory in use.
        /// </summary>
        [JsonProperty(PropertyName = "datapath_heap_usage")]
        public double? DatapathHeapUsage { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [JsonProperty(PropertyName = "highest_datapath_mem_pool_usage_names")]
        public IList<string> HighestDatapathMemPoolUsageNames { get; set; }
    }
}
