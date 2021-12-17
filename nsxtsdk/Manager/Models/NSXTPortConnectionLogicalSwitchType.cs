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
    public class NSXTPortConnectionLogicalSwitchType : NSXTPortConnectionEntityType
    {
        public NSXTPortConnectionLogicalSwitchType()
        {
        }
        /// <summary>
        /// States of Logical Ports that are attached to a VIF/VM
        /// </summary>
        [JsonProperty(PropertyName = "vm_ports_states")]
        [NSXTProperty(IsRequired: false, Description: @"States of Logical Ports that are attached to a VIF/VM")]
        public IList<NSXTLogicalPortStateType> VmPortsStates { get; set; }
        /// <summary>
        /// Logical Ports that are attached to a VIF/VM
        /// </summary>
        [JsonProperty(PropertyName = "vm_ports")]
        [NSXTProperty(IsRequired: false, Description: @"Logical Ports that are attached to a VIF/VM")]
        public IList<NSXTLogicalPortType> VmPorts { get; set; }
        /// <summary>
        /// Virutal Network Interfaces that are attached to the Logical Ports
        /// </summary>
        [JsonProperty(PropertyName = "vm_vnics")]
        [NSXTProperty(IsRequired: false, Description: @"Virutal Network Interfaces that are attached to the Logical Ports")]
        public IList<NSXTVirtualNetworkInterfaceType> VmVnics { get; set; }
        /// <summary>
        /// Logical Ports that are attached to a router
        /// </summary>
        [JsonProperty(PropertyName = "router_ports")]
        [NSXTProperty(IsRequired: false, Description: @"Logical Ports that are attached to a router")]
        public IList<NSXTLogicalPortType> RouterPorts { get; set; }
    }
}
