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
    public class NSXTNodeStatusPropertiesType : NSXTResourceType
    {
        /// <summary>
        /// One, five, and fifteen minute load averages for the system
        /// </summary>
        [JsonProperty(PropertyName = "load_average")]
        public IList<float> LoadAverage { get; set; }
        /// <summary>
        /// Amount of swap disk in use, in kilobytes
        /// </summary>
        [JsonProperty(PropertyName = "swap_used")]
        public long? SwapUsed { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [JsonProperty(PropertyName = "cpu_usage")]
        public NSXTCpuUsageType CpuUsage { get; set; }
        /// <summary>
        /// Current time expressed in milliseconds since epoch
        /// </summary>
        [JsonProperty(PropertyName = "system_time")]
        public long? SystemTime { get; set; }
        /// <summary>
        /// Amount of disk space available on the system, in kilobytes.
        /// </summary>
        [JsonProperty(PropertyName = "disk_space_total")]
        public long? DiskSpaceTotal { get; set; }
        /// <summary>
        /// Amount of disk available for swap, in kilobytes
        /// </summary>
        [JsonProperty(PropertyName = "swap_total")]
        public long? SwapTotal { get; set; }
        /// <summary>
        /// Number of non-DPDK cores on Edge Node.
        /// </summary>
        [JsonProperty(PropertyName = "non_dpdk_cpu_cores")]
        public long? NonDpdkCpuCores { get; set; }
        /// <summary>
        /// Milliseconds since system start
        /// </summary>
        [JsonProperty(PropertyName = "uptime")]
        public long? Uptime { get; set; }
        /// <summary>
        /// Number of CPU cores on the system
        /// </summary>
        [JsonProperty(PropertyName = "cpu_cores")]
        public long? CpuCores { get; set; }
        /// <summary>
        /// Number of DPDK cores on Edge Node which are used for packet IO processing.
        /// </summary>
        [JsonProperty(PropertyName = "dpdk_cpu_cores")]
        public long? DpdkCpuCores { get; set; }
        /// <summary>
        /// Amount of RAM in use on the system, in kilobytes
        /// </summary>
        [JsonProperty(PropertyName = "mem_used")]
        public long? MemUsed { get; set; }
        /// <summary>
        /// Amount of RAM allocated to the system, in kilobytes
        /// </summary>
        [JsonProperty(PropertyName = "mem_total")]
        public long? MemTotal { get; set; }
        /// <summary>
        /// Amount of disk space in use on the system, in kilobytes
        /// </summary>
        [JsonProperty(PropertyName = "disk_space_used")]
        public long? DiskSpaceUsed { get; set; }
        /// <summary>
        /// Amount of RAM on the system that can be flushed out to disk, in kilobytes
        /// </summary>
        [JsonProperty(PropertyName = "mem_cache")]
        public long? MemCache { get; set; }
        /// <summary>
        /// Host name of the system
        /// </summary>
        [JsonProperty(PropertyName = "hostname")]
        public string? Hostname { get; set; }
        /// <summary>
        /// File systems configured on the system
        /// </summary>
        [JsonProperty(PropertyName = "file_systems")]
        public IList<NSXTNodeFileSystemPropertiesType> FileSystems { get; set; }
        /// <summary>
        /// Source of status data.
        /// </summary>
        [JsonProperty(PropertyName = "source")]
        [JsonConverter(typeof(StringEnumConverter))]
        public NSXTNodeStatusPropertiesSourceEnumType? Source { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [JsonProperty(PropertyName = "edge_mem_usage")]
        public NSXTEdgeTransportNodeMemoryUsageType EdgeMemUsage { get; set; }
    }
}
