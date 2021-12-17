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
    /// Detailed view of the datapath memory usage. Details out the heap and per memory pool point in time usage.
    /// </summary>
    [NSXTProperty(Description: @"Detailed view of the datapath memory usage. Details out the heap and per memory pool point in time usage.")]
    public class NSXTEdgeTransportNodeDatapathMemoryUsageType 
    {
        public NSXTEdgeTransportNodeDatapathMemoryUsageType()
        {
        }
        /// <summary>
        /// Highest percentage usage value among datapath memory pools.
        /// </summary>
        [JsonProperty(PropertyName = "highest_datapath_mem_pool_usage")]
        [NSXTProperty(IsRequired: false, Description: @"Highest percentage usage value among datapath memory pools.")]
        public double? HighestDatapathMemPoolUsage { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [JsonProperty(PropertyName = "datapath_mem_pools_usage")]
        [NSXTProperty(IsRequired: false, Description: @"")]
        public IList<NSXTEdgeTransportNodeDatapathMemoryPoolUsageType> DatapathMemPoolsUsage { get; set; }
        /// <summary>
        /// Percentage of heap memory in use.
        /// </summary>
        [JsonProperty(PropertyName = "datapath_heap_usage")]
        [NSXTProperty(IsRequired: false, Description: @"Percentage of heap memory in use.")]
        public double? DatapathHeapUsage { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [JsonProperty(PropertyName = "highest_datapath_mem_pool_usage_names")]
        [NSXTProperty(IsRequired: false, Description: @"")]
        public IList<string> HighestDatapathMemPoolUsageNames { get; set; }
    }
}
