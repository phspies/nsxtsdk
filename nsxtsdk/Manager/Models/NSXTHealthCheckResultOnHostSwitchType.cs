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
        [NSXTProperty(IsRequired: false, Description: @"Status of VLAN-MTU health check result on host switch.")]
        public NSXTHealthCheckResultOnHostSwitchVlanMtuStatusEnumType? VlanMtuStatus { get; set; }
        /// <summary>
        /// Name of the host switch.
        /// </summary>
        [JsonProperty(PropertyName = "host_switch_name")]
        [NSXTProperty(IsRequired: false, Description: @"Name of the host switch.")]
        public string? HostSwitchName { get; set; }
        /// <summary>
        /// List of health check results per uplink on current host switch of specific
        /// transport node.
        /// </summary>
        [JsonProperty(PropertyName = "results_per_uplink")]
        [NSXTProperty(IsRequired: false, Description: @"List of health check results per uplink on current host switch of specifictransport node.")]
        public IList<NSXTHealthCheckResultPerUplinkType> ResultsPerUplink { get; set; }
        /// <summary>
        /// Timestamp of check result updated.
        /// </summary>
        [JsonProperty(PropertyName = "updated_time")]
        [NSXTProperty(IsRequired: false, Description: @"Timestamp of check result updated.")]
        public long? UpdatedTime { get; set; }
    }
}