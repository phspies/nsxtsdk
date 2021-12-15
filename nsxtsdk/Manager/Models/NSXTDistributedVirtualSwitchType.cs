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
    /// 
    /// </summary>
    [NSXTProperty(Description: @"")]
    public class NSXTDistributedVirtualSwitchType : NSXTVirtualSwitchType
    {
        /// <summary>
        /// Array of discovered nodes connected to this switch.
        /// </summary>
        [JsonProperty(PropertyName = "discovered_nodes")]
        [NSXTProperty(IsRequired: false, Description: @"Array of discovered nodes connected to this switch.")]
        public IList<NSXTDiscoveredNodeType> DiscoveredNodes { get; set; }
        /// <summary>
        /// Uplink portgroup of distributed virtual switch
        /// </summary>
        [JsonProperty(PropertyName = "uplink_portgroup")]
        [NSXTProperty(IsRequired: false, Description: @"Uplink portgroup of distributed virtual switch")]
        public NSXTDistributedVirtualPortgroupType UplinkPortgroup { get; set; }
        /// <summary>
        /// UUID of the switch
        /// </summary>
        [JsonProperty(PropertyName = "uuid")]
        [NSXTProperty(IsRequired: false, Description: @"UUID of the switch")]
        public string? Uuid { get; set; }
        /// <summary>
        /// Key-Value map of additional properties of switch
        /// </summary>
        [JsonProperty(PropertyName = "origin_properties")]
        [NSXTProperty(IsRequired: false, Description: @"Key-Value map of additional properties of switch")]
        public IList<NSXTKeyValuePairType> OriginProperties { get; set; }
        /// <summary>
        /// It contains information about VMware specific multiple dynamic
        /// LACP groups.
        /// </summary>
        [JsonProperty(PropertyName = "lacp_group_configs")]
        [NSXTProperty(IsRequired: false, Description: @"It contains information about VMware specific multiple dynamicLACP groups.")]
        public IList<NSXTLacpGroupConfigInfoType> LacpGroupConfigs { get; set; }
        /// <summary>
        /// The uniform name of uplink ports on each host.
        /// </summary>
        [JsonProperty(PropertyName = "uplink_port_names")]
        [NSXTProperty(IsRequired: false, Description: @"The uniform name of uplink ports on each host.")]
        public IList<string> UplinkPortNames { get; set; }
    }
}
