// <auto-generated>
// Changes may cause incorrect behavior and will be lost if the code is regenerated.
// </auto-generated>
using nsxtsdk.Models;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.ComponentModel;
using NJsonSchema.Converters;

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
        public string? PhysicalAddress { get; set; }
        /// <summary>
        /// Switch name which is connected to nic, switch can be opaque, proxyHostSwitch or virtual
        /// </summary>
        public string? ConnectedSwitch { get; set; }
        /// <summary>
        /// Type of virtual switch can be VSS, DVS or N-VDS.
        /// </summary>
        public NSXTDiscoveredNodeInterfacePropertiesConnectedSwitchTypeEnumType? ConnectedSwitchType { get; set; }
        /// <summary>
        /// Id of the network interface
        /// </summary>
        public string? InterfaceId { get; set; }
    }
}
