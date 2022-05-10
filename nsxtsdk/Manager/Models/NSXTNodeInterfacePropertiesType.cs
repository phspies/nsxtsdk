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
    /// Node network interface properties
    /// </summary>
    [NSXTProperty(Description: @"Node network interface properties")]
    public class NSXTNodeInterfacePropertiesType 
    {
        /// <summary>
        /// Indicates whether interface is managed by the host
        /// </summary>
        [JsonProperty(PropertyName = "host_managed")]
        public bool? HostManaged { get; set; }
        /// <summary>
        /// UUID of the interface
        /// </summary>
        [JsonProperty(PropertyName = "interface_uuid")]
        public string? InterfaceUuid { get; set; }
        /// <summary>
        /// Type of switch associated with the interface.
        /// </summary>
        [JsonProperty(PropertyName = "connected_switch_type")]
        [JsonConverter(typeof(StringEnumConverter))]
        public NSXTNodeInterfacePropertiesConnectedSwitchTypeEnumType? ConnectedSwitchType { get; set; }
        /// <summary>
        /// Interface administration status
        /// </summary>
        [JsonProperty(PropertyName = "link_status")]
        [JsonConverter(typeof(StringEnumConverter))]
        public NSXTNodeInterfacePropertiesLinkStatusEnumType? LinkStatus { get; set; }
        /// <summary>
        /// Indicates whether interface is enabled for Enhanced Networking Stack
        /// </summary>
        [JsonProperty(PropertyName = "ens_enabled")]
        public bool? EnsEnabled { get; set; }
        /// <summary>
        /// Interface Type
        /// </summary>
        [JsonProperty(PropertyName = "interface_type")]
        [JsonConverter(typeof(StringEnumConverter))]
        public NSXTNodeInterfacePropertiesInterfaceTypeEnumType? InterfaceType { get; set; }
        /// <summary>
        /// Connected switch
        /// </summary>
        [JsonProperty(PropertyName = "connected_switch")]
        public string? ConnectedSwitch { get; set; }
        /// <summary>
        /// Interface ID
        /// </summary>
        [JsonProperty(PropertyName = "interface_id")]
        public string? InterfaceId { get; set; }
        /// <summary>
        /// Source of status data
        /// </summary>
        [JsonProperty(PropertyName = "source")]
        [JsonConverter(typeof(StringEnumConverter))]
        public NSXTNodeInterfacePropertiesSourceEnumType? Source { get; set; }
        /// <summary>
        /// Interface administration status
        /// </summary>
        [JsonProperty(PropertyName = "admin_status")]
        [JsonConverter(typeof(StringEnumConverter))]
        public NSXTNodeInterfacePropertiesAdminStatusEnumType? AdminStatus { get; set; }
        /// <summary>
        /// PCI device.
        /// </summary>
        [JsonProperty(PropertyName = "pci")]
        public string? Pci { get; set; }
        /// <summary>
        /// Indicates whether backing of VIRTUAL network interface is managed by NSX
        /// </summary>
        [JsonProperty(PropertyName = "backing_nsx_managed")]
        public bool? BackingNsxManaged { get; set; }
        /// <summary>
        /// Device key.
        /// </summary>
        [JsonProperty(PropertyName = "key")]
        public string? Key { get; set; }
        /// <summary>
        /// IP Alias
        /// </summary>
        [JsonProperty(PropertyName = "interface_alias")]
        public IList<NSXTNodeInterfaceAliasType> InterfaceAlias { get; set; }
        /// <summary>
        /// Device name.
        /// </summary>
        [JsonProperty(PropertyName = "device")]
        public string? Device { get; set; }
        /// <summary>
        /// LPort Attachment Id assigned to VIRTUAL network interface of a node
        /// </summary>
        [JsonProperty(PropertyName = "lport_attachment_id")]
        public string? LportAttachmentId { get; set; }
        /// <summary>
        /// Interface MTU
        /// </summary>
        [JsonProperty(PropertyName = "mtu")]
        public long? Mtu { get; set; }
        /// <summary>
        /// Driver name.
        /// </summary>
        [JsonProperty(PropertyName = "driver")]
        public string? Driver { get; set; }
        /// <summary>
        /// This boolean property describes if network interface is capable for Enhanced Networking Stack interrupt
        /// </summary>
        [JsonProperty(PropertyName = "ens_interrupt_capable")]
        public bool? EnsInterruptCapable { get; set; }
        /// <summary>
        /// Interface capability for Enhanced Networking Stack
        /// </summary>
        [JsonProperty(PropertyName = "ens_capable")]
        public bool? EnsCapable { get; set; }
        /// <summary>
        /// This boolean property describes if network interface is enabled for Enhanced Networking Stack interrupt
        /// </summary>
        [JsonProperty(PropertyName = "ens_interrupt_enabled")]
        public bool? EnsInterruptEnabled { get; set; }
    }
}
