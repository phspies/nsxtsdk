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
    public class NSXTFeatureUsageCsvRecordType : NSXTCsvRecordType
    {
        /// <summary>
        /// count of number of concurrent users
        /// </summary>
        [JsonProperty(PropertyName = "ccu_usage_count")]
        public long? CcuUsageCount { get; set; }
        /// <summary>
        /// count of number of vms used by this feature
        /// </summary>
        [JsonProperty(PropertyName = "vm_usage_count")]
        public long? VmUsageCount { get; set; }
        /// <summary>
        /// count of number of vcpus of public cloud VMs
        /// </summary>
        [JsonProperty(PropertyName = "vcpu_usage_count")]
        public long? VcpuUsageCount { get; set; }
        /// <summary>
        /// count of number of cpu sockets used by this feature
        /// </summary>
        [JsonProperty(PropertyName = "cpu_usage_count")]
        public long? CpuUsageCount { get; set; }
        /// <summary>
        /// name of the feature
        /// </summary>
        [JsonProperty(PropertyName = "feature")]
        public string? Feature { get; set; }
        /// <summary>
        /// Number of CPU cores used by this feature
        /// </summary>
        [JsonProperty(PropertyName = "core_usage_count")]
        public long? CoreUsageCount { get; set; }
    }
}
