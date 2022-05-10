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
    /// Point in time usage of system, datapath, swap and cache memory in edge node.
    /// </summary>
    [NSXTProperty(Description: @"Point in time usage of system, datapath, swap and cache memory in edge node.")]
    public class NSXTEdgeTransportNodeMemoryUsageType 
    {
        /// <summary>
        /// Percentage of RAM on the system that can be flushed out to disk.
        /// </summary>
        [JsonProperty(PropertyName = "cache_usage")]
        public double? CacheUsage { get; set; }
        /// <summary>
        /// Percentage of swap disk in use.
        /// </summary>
        [JsonProperty(PropertyName = "swap_usage")]
        public double? SwapUsage { get; set; }
        /// <summary>
        /// Percentage of RAM in use on edge node.
        /// </summary>
        [JsonProperty(PropertyName = "system_mem_usage")]
        public double? SystemMemUsage { get; set; }
        /// <summary>
        /// Percentage of memory in use by datapath processes which includes RES and hugepage memory.
        /// </summary>
        [JsonProperty(PropertyName = "datapath_total_usage")]
        public double? DatapathTotalUsage { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [JsonProperty(PropertyName = "datapath_mem_usage_details")]
        public NSXTEdgeTransportNodeDatapathMemoryUsageType DatapathMemUsageDetails { get; set; }
    }
}
