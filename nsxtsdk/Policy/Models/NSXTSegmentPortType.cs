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

namespace nsxtsdk.PolicyModels
{
    /// <summary>
    /// 
    /// </summary>
    [NSXTProperty(Description: @"")]
    public class NSXTSegmentPortType : NSXTPolicyConfigResourceType
    {
        public NSXTSegmentPortType()
        {
            AdminState = test
        }
        /// <summary>
        /// Set initial state when a new logical port is created. 'UNBLOCKED_VLAN'
        /// means new port will be unblocked on traffic in creation, also VLAN will
        /// be set with corresponding logical switch setting. This port setting
        /// can only be configured at port creation, and cannot be modified.
        /// 'RESTORE_VIF' fetches and restores VIF attachment from ESX host.
        /// </summary>
        [JsonProperty(PropertyName = "init_state")]
        [NSXTProperty(IsRequired: false, Description: @"Set initial state when a new logical port is created. &apos;UNBLOCKED_VLAN&apos;means new port will be unblocked on traffic in creation, also VLAN willbe set with corresponding logical switch setting. This port settingcan only be configured at port creation, and cannot be modified.&apos;RESTORE_VIF&apos; fetches and restores VIF attachment from ESX host.")]
        public NSXTSegmentPortInitStateEnumType? InitState { get; set; }
        /// <summary>
        /// Represents desired state of the segment port
        /// </summary>
        [JsonProperty(PropertyName = "admin_state")]
        [NSXTProperty(IsRequired: false, Description: @"Represents desired state of the segment port")]
        public NSXTSegmentPortAdminStateEnumType? AdminState { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [JsonProperty(PropertyName = "attachment")]
        [NSXTProperty(IsRequired: false, Description: @"")]
        public NSXTPortAttachmentType Attachment { get; set; }
        /// <summary>
        /// ID populated by NSX when NSX on DVPG is used to indicate the source Distributed Virtual Port
        /// and the corresponding Distributed Virtual Switch. This ID is populated only for ports attached to
        /// discovered segments.
        /// </summary>
        [JsonProperty(PropertyName = "origin_id")]
        [NSXTProperty(IsRequired: false, Description: @"ID populated by NSX when NSX on DVPG is used to indicate the source Distributed Virtual Portand the corresponding Distributed Virtual Switch. This ID is populated only for ports attached todiscovered segments.")]
        public string? OriginId { get; set; }
        /// <summary>
        /// IP Discovery module uses various mechanisms to discover address
        /// bindings being used on each segment port. If a user would like to
        /// ignore any specific discovered address bindings or prevent the
        /// discovery of a particular set of discovered bindings, then those
        /// address bindings can be provided here. Currently IP range in CIDR format
        /// is not supported.
        /// </summary>
        [JsonProperty(PropertyName = "ignored_address_bindings")]
        [NSXTProperty(IsRequired: false, Description: @"IP Discovery module uses various mechanisms to discover addressbindings being used on each segment port. If a user would like toignore any specific discovered address bindings or prevent thediscovery of a particular set of discovered bindings, then thoseaddress bindings can be provided here. Currently IP range in CIDR formatis not supported.")]
        public IList<NSXTPortAddressBindingEntryType> IgnoredAddressBindings { get; set; }
        /// <summary>
        /// Static address binding used for the port.
        /// </summary>
        [JsonProperty(PropertyName = "address_bindings")]
        [NSXTProperty(IsRequired: false, Description: @"Static address binding used for the port.")]
        public IList<NSXTPortAddressBindingEntryType> AddressBindings { get; set; }
        /// <summary>
        /// This property could be used for vendor specific configuration in key value
        /// string pairs. Segment port setting will override segment setting if
        /// the same key was set on both segment and segment port.
        /// </summary>
        [JsonProperty(PropertyName = "extra_configs")]
        [NSXTProperty(IsRequired: false, Description: @"This property could be used for vendor specific configuration in key valuestring pairs. Segment port setting will override segment setting ifthe same key was set on both segment and segment port.")]
        public IList<NSXTSegmentExtraConfigType> ExtraConfigs { get; set; }
        /// <summary>
        /// This field will refer to the source site on which the segment
        /// port is discovered. This field is populated by GM, when it
        /// receives corresponding notification from LM.
        /// </summary>
        [JsonProperty(PropertyName = "source_site_id")]
        [NSXTProperty(IsRequired: false, Description: @"This field will refer to the source site on which the segmentport is discovered. This field is populated by GM, when itreceives corresponding notification from LM.")]
        public string? SourceSiteId { get; set; }
    }
}
