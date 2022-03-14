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
        public double? AvgCpuCoreUsageDpdk { get; set; }
        /// <summary>
        /// Indicates the highest cpu utilization value among non_dpdk cores in percentage.
        /// </summary>
        public double? HighestCpuCoreUsageNonDpdk { get; set; }
        /// <summary>
        /// Indicates the average usage of all non-DPDK cores in percentage.
        /// </summary>
        public double? AvgCpuCoreUsageNonDpdk { get; set; }
        /// <summary>
        /// Indicates the highest CPU utilization value among DPDK cores in percentage.
        /// </summary>
        public double? HighestCpuCoreUsageDpdk { get; set; }
    }
}
