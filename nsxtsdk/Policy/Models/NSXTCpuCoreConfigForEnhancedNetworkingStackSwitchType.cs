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
    /// Non Uniform Memory Access (NUMA) nodes and Logical cpu cores (Lcores) per NUMA node configuration for Enhanced
        /// Networking Stack enabled HostSwitch.
    /// </summary>
    [NSXTProperty(Description: @"Non Uniform Memory Access (NUMA) nodes and Logical cpu cores (Lcores) per NUMA node configuration for Enhanced Networking Stack enabled HostSwitch.")]
    public class NSXTCpuCoreConfigForEnhancedNetworkingStackSwitchType 
    {
        /// <summary>
        /// Number of Logical cpu cores (Lcores) to be placed on a specified NUMA node
        /// </summary>
        [JsonProperty(PropertyName = "num_lcores", Required = Required.AllowNull)]
        public int NumLcores { get; set; }
        /// <summary>
        /// Unique index of the Non Uniform Memory Access (NUMA) node
        /// </summary>
        [JsonProperty(PropertyName = "numa_node_index", Required = Required.AllowNull)]
        public int NumaNodeIndex { get; set; }
    }
}
