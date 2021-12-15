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
    /// Network interface properties of discovered node
    /// </summary>
    [NSXTProperty(Description: @"Network interface properties of discovered node")]
    public class NSXTDiscoveredNodeInterfacePropertiesType 
    {
        /// <summary>
        /// Mac address of the interface
        /// </summary>
        [JsonProperty(PropertyName = "physical_address")]
        [NSXTProperty(IsRequired: false, Description: @"Mac address of the interface")]
        public string? PhysicalAddress { get; set; }
        /// <summary>
        /// Switch name which is connected to nic, switch can be opaque, proxyHostSwitch or virtual
        /// </summary>
        [JsonProperty(PropertyName = "connected_switch")]
        [NSXTProperty(IsRequired: false, Description: @"Switch name which is connected to nic, switch can be opaque, proxyHostSwitch or virtual")]
        public string? ConnectedSwitch { get; set; }
        /// <summary>
        /// Type of virtual switch can be VSS, DVS or N-VDS.
        /// </summary>
        [JsonProperty(PropertyName = "connected_switch_type")]
        [NSXTProperty(IsRequired: false, Description: @"Type of virtual switch can be VSS, DVS or N-VDS.")]
        public NSXTDiscoveredNodeInterfacePropertiesConnectedSwitchTypeEnumType? ConnectedSwitchType { get; set; }
        /// <summary>
        /// Id of the network interface
        /// </summary>
        [JsonProperty(PropertyName = "interface_id")]
        [NSXTProperty(IsRequired: false, Description: @"Id of the network interface")]
        public string? InterfaceId { get; set; }
    }
}
