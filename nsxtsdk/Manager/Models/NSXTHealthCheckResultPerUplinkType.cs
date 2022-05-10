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
    /// Health check result for specific uplink.
    /// </summary>
    [NSXTProperty(Description: @"Health check result for specific uplink.")]
    public class NSXTHealthCheckResultPerUplinkType 
    {
        /// <summary>
        /// Name of the uplink.
        /// </summary>
        [JsonProperty(PropertyName = "uplink_name")]
        public string? UplinkName { get; set; }
        /// <summary>
        /// List of VLAN ID ranges which are allowed by VLAN and MTU settings.
        /// </summary>
        [JsonProperty(PropertyName = "vlan_and_mtu_allowed")]
        public IList<NSXTHealthCheckVlanRangeType> VlanAndMtuAllowed { get; set; }
        /// <summary>
        /// List of VLAN ID ranges which may be disallowed by VLAN settings.
        /// </summary>
        [JsonProperty(PropertyName = "vlan_disallowed")]
        public IList<NSXTHealthCheckVlanRangeType> VlanDisallowed { get; set; }
        /// <summary>
        /// List of VLAN ID ranges which are allowed by VLAN settings but may be
        /// disallowed by MTU settings.
        /// </summary>
        [JsonProperty(PropertyName = "mtu_disallowed")]
        public IList<NSXTHealthCheckVlanRangeType> MtuDisallowed { get; set; }
    }
}
