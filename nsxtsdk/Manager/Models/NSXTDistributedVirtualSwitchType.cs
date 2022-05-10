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
    public class NSXTDistributedVirtualSwitchType : NSXTVirtualSwitchType
    {
        /// <summary>
        /// Array of discovered nodes connected to this switch.
        /// </summary>
        [JsonProperty(PropertyName = "discovered_nodes")]
        public IList<NSXTDiscoveredNodeType> DiscoveredNodes { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [JsonProperty(PropertyName = "uplink_portgroup")]
        public NSXTDistributedVirtualPortgroupType UplinkPortgroup { get; set; }
        /// <summary>
        /// UUID of the switch
        /// </summary>
        [JsonProperty(PropertyName = "uuid")]
        public string? Uuid { get; set; }
        /// <summary>
        /// Key-Value map of additional properties of switch
        /// </summary>
        [JsonProperty(PropertyName = "origin_properties")]
        public IList<NSXTKeyValuePairType> OriginProperties { get; set; }
        /// <summary>
        /// It contains information about VMware specific multiple dynamic
        /// LACP groups.
        /// </summary>
        [JsonProperty(PropertyName = "lacp_group_configs")]
        public IList<NSXTLacpGroupConfigInfoType> LacpGroupConfigs { get; set; }
        /// <summary>
        /// The uniform name of uplink ports on each host.
        /// </summary>
        [JsonProperty(PropertyName = "uplink_port_names")]
        public IList<string> UplinkPortNames { get; set; }
    }
}
