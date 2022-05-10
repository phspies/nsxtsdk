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
    /// Health check result on specific host switch of specific transport node.
    /// </summary>
    [NSXTProperty(Description: @"Health check result on specific host switch of specific transport node.")]
    public class NSXTHealthCheckResultOnHostSwitchType 
    {
        /// <summary>
        /// Status of VLAN-MTU health check result on host switch.
        /// </summary>
        [JsonProperty(PropertyName = "vlan_mtu_status")]
        [JsonConverter(typeof(StringEnumConverter))]
        public NSXTHealthCheckResultOnHostSwitchVlanMtuStatusEnumType? VlanMtuStatus { get; set; }
        /// <summary>
        /// Name of the host switch.
        /// </summary>
        [JsonProperty(PropertyName = "host_switch_name")]
        public string? HostSwitchName { get; set; }
        /// <summary>
        /// List of health check results per uplink on current host switch of specific
        /// transport node.
        /// </summary>
        [JsonProperty(PropertyName = "results_per_uplink")]
        public IList<NSXTHealthCheckResultPerUplinkType> ResultsPerUplink { get; set; }
        /// <summary>
        /// Timestamp of check result updated.
        /// </summary>
        [JsonProperty(PropertyName = "updated_time")]
        public long? UpdatedTime { get; set; }
    }
}
