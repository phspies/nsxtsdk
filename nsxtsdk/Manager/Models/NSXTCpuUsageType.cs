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
    /// CPU usage of DPDK and non-DPDK cores
    /// </summary>
    [NSXTProperty(Description: @"CPU usage of DPDK and non-DPDK cores")]
    public class NSXTCpuUsageType 
    {
        /// <summary>
        /// Indicates the average usage of all DPDK cores in percentage.
        /// </summary>
        [JsonProperty(PropertyName = "avg_cpu_core_usage_dpdk")]
        public double? AvgCpuCoreUsageDpdk { get; set; }
        /// <summary>
        /// Indicates the highest cpu utilization value among non_dpdk cores in percentage.
        /// </summary>
        [JsonProperty(PropertyName = "highest_cpu_core_usage_non_dpdk")]
        public double? HighestCpuCoreUsageNonDpdk { get; set; }
        /// <summary>
        /// Indicates the average usage of all non-DPDK cores in percentage.
        /// </summary>
        [JsonProperty(PropertyName = "avg_cpu_core_usage_non_dpdk")]
        public double? AvgCpuCoreUsageNonDpdk { get; set; }
        /// <summary>
        /// Indicates the highest CPU utilization value among DPDK cores in percentage.
        /// </summary>
        [JsonProperty(PropertyName = "highest_cpu_core_usage_dpdk")]
        public double? HighestCpuCoreUsageDpdk { get; set; }
    }
}
