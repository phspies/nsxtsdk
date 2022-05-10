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
    /// Network interface properties of discovered node
    /// </summary>
    [NSXTProperty(Description: @"Network interface properties of discovered node")]
    public class NSXTDiscoveredNodeInterfacePropertiesType 
    {
        /// <summary>
        /// Mac address of the interface
        /// </summary>
        [JsonProperty(PropertyName = "physical_address")]
        public string? PhysicalAddress { get; set; }
        /// <summary>
        /// Switch name which is connected to nic, switch can be opaque, proxyHostSwitch or virtual
        /// </summary>
        [JsonProperty(PropertyName = "connected_switch")]
        public string? ConnectedSwitch { get; set; }
        /// <summary>
        /// Type of virtual switch can be VSS, DVS or N-VDS.
        /// </summary>
        [JsonProperty(PropertyName = "connected_switch_type")]
        [JsonConverter(typeof(StringEnumConverter))]
        public NSXTDiscoveredNodeInterfacePropertiesConnectedSwitchTypeEnumType? ConnectedSwitchType { get; set; }
        /// <summary>
        /// Id of the network interface
        /// </summary>
        [JsonProperty(PropertyName = "interface_id")]
        public string? InterfaceId { get; set; }
    }
}
