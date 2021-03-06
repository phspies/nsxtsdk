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
    public class NSXTLogicalPortType : NSXTManagedResourceType
    {
        /// <summary>
        /// Id of the Logical switch that this port belongs to.
        /// </summary>
        [JsonProperty(PropertyName = "logical_switch_id", Required = Required.AllowNull)]
        public string LogicalSwitchId { get; set; }
        /// <summary>
        /// Set initial state when a new logical port is created. 'UNBLOCKED_VLAN'
        /// means new port will be unblocked on traffic in creation, also VLAN will
        /// be set with corresponding logical switch setting. This port setting
        /// can only be configured at port creation (POST), and cannot be modified.
        /// 'RESTORE_VIF' fetches and restores VIF attachment from ESX host.
        /// </summary>
        [JsonProperty(PropertyName = "init_state")]
        [JsonConverter(typeof(StringEnumConverter))]
        public NSXTLogicalPortInitStateEnumType? InitState { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [JsonProperty(PropertyName = "switching_profile_ids")]
        public IList<NSXTSwitchingProfileTypeIdEntryType> SwitchingProfileIds { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [JsonProperty(PropertyName = "attachment")]
        public NSXTLogicalPortAttachmentType Attachment { get; set; }
        /// <summary>
        /// The internal_id of the logical port may or may not be identical to it's
        /// managed resource ID. If a VirtualMachine connected to logical port
        /// migrates from one site to another, then on the destination site, it
        /// will be connected to different logical port managed resource. However,
        /// the internal_id field will be persisted across vmotion.
        /// </summary>
        [JsonProperty(PropertyName = "internal_id")]
        public string? InternalId { get; set; }
        /// <summary>
        /// This property could be used for vendor specific configuration in key value
        /// string pairs. Logical port setting will override logical switch setting if
        /// the same key was set on both logical switch and logical port.
        /// </summary>
        [JsonProperty(PropertyName = "extra_configs")]
        public IList<NSXTExtraConfigType> ExtraConfigs { get; set; }
        /// <summary>
        /// IP Discovery module uses various mechanisms to discover address
        /// bindings being used on each port. If a user would like to ignore
        /// any specific discovered address bindings or prevent the discovery
        /// of a particular set of discovered bindings, then those address
        /// bindings can be provided here. Currently IP range in CIDR format
        /// is not supported.
        /// </summary>
        [JsonProperty(PropertyName = "ignore_address_bindings")]
        public IList<NSXTPacketAddressClassifierType> IgnoreAddressBindings { get; set; }
        /// <summary>
        /// Each address binding must contain both an IPElement and MAC address.
        /// VLAN ID is optional. This binding configuration can be used by
        /// features such as spoof-guard and overrides any discovered bindings.
        /// Any non unique entries are deduplicated to generate a unique set
        /// of address bindings and then stored. For IP addresses, a subnet
        /// address cannot have host bits set. A maximum of 128 unique address
        /// bindings is allowed per port.
        /// </summary>
        [JsonProperty(PropertyName = "address_bindings")]
        public IList<NSXTPacketAddressClassifierType> AddressBindings { get; set; }
        /// <summary>
        /// ID populated by NSX when NSX on DVPG is used to indicate the source distributed virtual port and the corresponding
        /// distributed virtual switch. This ID is populated only for logical ports that belong to a logical switch of type DVPG.
        /// </summary>
        [JsonProperty(PropertyName = "origin_id")]
        public string? OriginId { get; set; }
        /// <summary>
        /// Represents Desired state of the logical port
        /// </summary>
        [JsonProperty(PropertyName = "admin_state", Required = Required.AllowNull)]
        [JsonConverter(typeof(StringEnumConverter))]
        public NSXTLogicalPortAdminStateEnumType AdminState { get; set; }
    }
}
