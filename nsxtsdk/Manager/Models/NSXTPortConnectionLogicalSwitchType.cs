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
    public class NSXTPortConnectionLogicalSwitchType : NSXTPortConnectionEntityType
    {
        /// <summary>
        /// States of Logical Ports that are attached to a VIF/VM
        /// </summary>
        [JsonProperty(PropertyName = "vm_ports_states")]
        public IList<NSXTLogicalPortStateType> VmPortsStates { get; set; }
        /// <summary>
        /// Logical Ports that are attached to a VIF/VM
        /// </summary>
        [JsonProperty(PropertyName = "vm_ports")]
        public IList<NSXTLogicalPortType> VmPorts { get; set; }
        /// <summary>
        /// Virutal Network Interfaces that are attached to the Logical Ports
        /// </summary>
        [JsonProperty(PropertyName = "vm_vnics")]
        public IList<NSXTVirtualNetworkInterfaceType> VmVnics { get; set; }
        /// <summary>
        /// Logical Ports that are attached to a router
        /// </summary>
        [JsonProperty(PropertyName = "router_ports")]
        public IList<NSXTLogicalPortType> RouterPorts { get; set; }
    }
}
