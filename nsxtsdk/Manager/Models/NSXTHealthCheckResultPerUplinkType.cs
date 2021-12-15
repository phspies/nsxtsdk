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
    /// Health check result for specific uplink.
    /// </summary>
    [NSXTProperty(Description: @"Health check result for specific uplink.")]
    public class NSXTHealthCheckResultPerUplinkType 
    {
        /// <summary>
        /// Name of the uplink.
        /// </summary>
        [JsonProperty(PropertyName = "uplink_name")]
        [NSXTProperty(IsRequired: false, Description: @"Name of the uplink.")]
        public string? UplinkName { get; set; }
        /// <summary>
        /// List of VLAN ID ranges which are allowed by VLAN and MTU settings.
        /// </summary>
        [JsonProperty(PropertyName = "vlan_and_mtu_allowed")]
        [NSXTProperty(IsRequired: false, Description: @"List of VLAN ID ranges which are allowed by VLAN and MTU settings.")]
        public IList<NSXTHealthCheckVlanRangeType> VlanAndMtuAllowed { get; set; }
        /// <summary>
        /// List of VLAN ID ranges which may be disallowed by VLAN settings.
        /// </summary>
        [JsonProperty(PropertyName = "vlan_disallowed")]
        [NSXTProperty(IsRequired: false, Description: @"List of VLAN ID ranges which may be disallowed by VLAN settings.")]
        public IList<NSXTHealthCheckVlanRangeType> VlanDisallowed { get; set; }
        /// <summary>
        /// List of VLAN ID ranges which are allowed by VLAN settings but may be
        /// disallowed by MTU settings.
        /// </summary>
        [JsonProperty(PropertyName = "mtu_disallowed")]
        [NSXTProperty(IsRequired: false, Description: @"List of VLAN ID ranges which are allowed by VLAN settings but may bedisallowed by MTU settings.")]
        public IList<NSXTHealthCheckVlanRangeType> MtuDisallowed { get; set; }
    }
}
