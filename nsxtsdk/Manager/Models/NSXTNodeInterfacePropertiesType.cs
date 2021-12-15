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
    /// Node network interface properties
    /// </summary>
    [NSXTProperty(Description: @"Node network interface properties")]
    public class NSXTNodeInterfacePropertiesType 
    {
        /// <summary>
        /// Indicates whether interface is managed by the host
        /// </summary>
        [JsonProperty(PropertyName = "host_managed")]
        [NSXTProperty(IsRequired: false, Description: @"Indicates whether interface is managed by the host")]
        public bool? HostManaged { get; set; }
        /// <summary>
        /// Type of switch associated with the interface.
        /// </summary>
        [JsonProperty(PropertyName = "connected_switch_type")]
        [NSXTProperty(IsRequired: false, Description: @"Type of switch associated with the interface.")]
        public NSXTNodeInterfacePropertiesConnectedSwitchTypeEnumType? ConnectedSwitchType { get; set; }
        /// <summary>
        /// Interface administration status
        /// </summary>
        [JsonProperty(PropertyName = "link_status")]
        [NSXTProperty(IsRequired: false, Description: @"Interface administration status")]
        public NSXTNodeInterfacePropertiesLinkStatusEnumType? LinkStatus { get; set; }
        /// <summary>
        /// Indicates whether interface is enabled for Enhanced Networking Stack
        /// </summary>
        [JsonProperty(PropertyName = "ens_enabled")]
        [NSXTProperty(IsRequired: false, Description: @"Indicates whether interface is enabled for Enhanced Networking Stack")]
        public bool? EnsEnabled { get; set; }
        /// <summary>
        /// Interface Type
        /// </summary>
        [JsonProperty(PropertyName = "interface_type")]
        [NSXTProperty(IsRequired: false, Description: @"Interface Type")]
        public NSXTNodeInterfacePropertiesInterfaceTypeEnumType? InterfaceType { get; set; }
        /// <summary>
        /// Connected switch
        /// </summary>
        [JsonProperty(PropertyName = "connected_switch")]
        [NSXTProperty(IsRequired: false, Description: @"Connected switch")]
        public string? ConnectedSwitch { get; set; }
        /// <summary>
        /// Interface ID
        /// </summary>
        [JsonProperty(PropertyName = "interface_id")]
        [NSXTProperty(IsRequired: false, Description: @"Interface ID")]
        public string? InterfaceId { get; set; }
        /// <summary>
        /// Source of status data
        /// </summary>
        [JsonProperty(PropertyName = "source")]
        [NSXTProperty(IsRequired: false, Description: @"Source of status data")]
        public NSXTNodeInterfacePropertiesSourceEnumType? Source { get; set; }
        /// <summary>
        /// Interface administration status
        /// </summary>
        [JsonProperty(PropertyName = "admin_status")]
        [NSXTProperty(IsRequired: false, Description: @"Interface administration status")]
        public NSXTNodeInterfacePropertiesAdminStatusEnumType? AdminStatus { get; set; }
        /// <summary>
        /// PCI device.
        /// </summary>
        [JsonProperty(PropertyName = "pci")]
        [NSXTProperty(IsRequired: false, Description: @"PCI device.")]
        public string? Pci { get; set; }
        /// <summary>
        /// Indicates whether backing of VIRTUAL network interface is managed by NSX
        /// </summary>
        [JsonProperty(PropertyName = "backing_nsx_managed")]
        [NSXTProperty(IsRequired: false, Description: @"Indicates whether backing of VIRTUAL network interface is managed by NSX")]
        public bool? BackingNsxManaged { get; set; }
        /// <summary>
        /// Device key.
        /// </summary>
        [JsonProperty(PropertyName = "key")]
        [NSXTProperty(IsRequired: false, Description: @"Device key.")]
        public string? Key { get; set; }
        /// <summary>
        /// IP Alias
        /// </summary>
        [JsonProperty(PropertyName = "interface_alias")]
        [NSXTProperty(IsRequired: false, Description: @"IP Alias")]
        public IList<NSXTNodeInterfaceAliasType> InterfaceAlias { get; set; }
        /// <summary>
        /// Device name.
        /// </summary>
        [JsonProperty(PropertyName = "device")]
        [NSXTProperty(IsRequired: false, Description: @"Device name.")]
        public string? Device { get; set; }
        /// <summary>
        /// LPort Attachment Id assigned to VIRTUAL network interface of a node
        /// </summary>
        [JsonProperty(PropertyName = "lport_attachment_id")]
        [NSXTProperty(IsRequired: false, Description: @"LPort Attachment Id assigned to VIRTUAL network interface of a node")]
        public string? LportAttachmentId { get; set; }
        /// <summary>
        /// Interface MTU
        /// </summary>
        [JsonProperty(PropertyName = "mtu")]
        [NSXTProperty(IsRequired: false, Description: @"Interface MTU")]
        public long? Mtu { get; set; }
        /// <summary>
        /// Driver name.
        /// </summary>
        [JsonProperty(PropertyName = "driver")]
        [NSXTProperty(IsRequired: false, Description: @"Driver name.")]
        public string? Driver { get; set; }
        /// <summary>
        /// This boolean property describes if network interface is capable for Enhanced Networking Stack interrupt
        /// </summary>
        [JsonProperty(PropertyName = "ens_interrupt_capable")]
        [NSXTProperty(IsRequired: false, Description: @"This boolean property describes if network interface is capable for Enhanced Networking Stack interrupt")]
        public bool? EnsInterruptCapable { get; set; }
        /// <summary>
        /// Interface capability for Enhanced Networking Stack
        /// </summary>
        [JsonProperty(PropertyName = "ens_capable")]
        [NSXTProperty(IsRequired: false, Description: @"Interface capability for Enhanced Networking Stack")]
        public bool? EnsCapable { get; set; }
        /// <summary>
        /// This boolean property describes if network interface is enabled for Enhanced Networking Stack interrupt
        /// </summary>
        [JsonProperty(PropertyName = "ens_interrupt_enabled")]
        [NSXTProperty(IsRequired: false, Description: @"This boolean property describes if network interface is enabled for Enhanced Networking Stack interrupt")]
        public bool? EnsInterruptEnabled { get; set; }
    }
}
