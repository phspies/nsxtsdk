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
    /// Point in time usage of system, datapath, swap and cache memory in edge node.
    /// </summary>
    [NSXTProperty(Description: @"Point in time usage of system, datapath, swap and cache memory in edge node.")]
    public class NSXTEdgeTransportNodeMemoryUsageType 
    {
        public NSXTEdgeTransportNodeMemoryUsageType()
        {
        }
        /// <summary>
        /// Percentage of RAM on the system that can be flushed out to disk.
        /// </summary>
        [JsonProperty(PropertyName = "cache_usage")]
        [NSXTProperty(IsRequired: false, Description: @"Percentage of RAM on the system that can be flushed out to disk.")]
        public double? CacheUsage { get; set; }
        /// <summary>
        /// Percentage of swap disk in use.
        /// </summary>
        [JsonProperty(PropertyName = "swap_usage")]
        [NSXTProperty(IsRequired: false, Description: @"Percentage of swap disk in use.")]
        public double? SwapUsage { get; set; }
        /// <summary>
        /// Percentage of RAM in use on edge node.
        /// </summary>
        [JsonProperty(PropertyName = "system_mem_usage")]
        [NSXTProperty(IsRequired: false, Description: @"Percentage of RAM in use on edge node.")]
        public double? SystemMemUsage { get; set; }
        /// <summary>
        /// Percentage of memory in use by datapath processes which includes RES and hugepage memory.
        /// </summary>
        [JsonProperty(PropertyName = "datapath_total_usage")]
        [NSXTProperty(IsRequired: false, Description: @"Percentage of memory in use by datapath processes which includes RES and hugepage memory.")]
        public double? DatapathTotalUsage { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [JsonProperty(PropertyName = "datapath_mem_usage_details")]
        [NSXTProperty(IsRequired: false, Description: @"")]
        public NSXTEdgeTransportNodeDatapathMemoryUsageType DatapathMemUsageDetails { get; set; }
    }
}
