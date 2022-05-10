using nsxtsdk.Models;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.ComponentModel;
using NJsonSchema.Converters;
using Newtonsoft.Json.Converters;

namespace nsxtsdk.PolicyModels
{
    /// <summary>
    /// Detail information about port attachment
    /// </summary>
    [NSXTProperty(Description: @"Detail information about port attachment")]
    public class NSXTPortAttachmentType 
    {
        /// <summary>
        /// Not valid when type field is INDEPENDENT, mainly used to identify
        /// traffic from different ports in container use case.
        /// </summary>
        [JsonProperty(PropertyName = "traffic_tag")]
        public long? TrafficTag { get; set; }
        /// <summary>
        /// Indicate how IP will be allocated for the port
        /// </summary>
        [JsonProperty(PropertyName = "allocate_addresses")]
        [JsonConverter(typeof(StringEnumConverter))]
        public NSXTPortAttachmentAllocateAddressesEnumType? AllocateAddresses { get; set; }
        /// <summary>
        /// Flag to indicate if hyperbus configuration is required.
        /// </summary>
        [JsonProperty(PropertyName = "hyperbus_mode")]
        [JsonConverter(typeof(StringEnumConverter))]
        public NSXTPortAttachmentHyperbusModeEnumType? HyperbusMode { get; set; }
        /// <summary>
        /// Set to PARENT when type field is CHILD. Read only field.
        /// </summary>
        [JsonProperty(PropertyName = "context_type")]
        [JsonConverter(typeof(StringEnumConverter))]
        public NSXTPortAttachmentContextTypeEnumType? ContextType { get; set; }
        /// <summary>
        /// If type is CHILD and the parent port is on the same segment as the child port, then this
        /// field should be VIF ID of the parent port.
        /// If type is CHILD and the parent port is on a different segment, then this
        /// field should be policy path of the parent port.
        /// If type is INDEPENDENT/STATIC, then this field should be transport node ID.
        /// </summary>
        [JsonProperty(PropertyName = "context_id")]
        public string? ContextId { get; set; }
        /// <summary>
        /// List of Evpn tenant VLAN IDs the Parent logical-port serves in Evpn Route-Server mode. Only effective when attachment
        /// type is PARENT and the logical-port is attached to vRouter VM.
        /// </summary>
        [JsonProperty(PropertyName = "evpn_vlans")]
        public IList<string> EvpnVlans { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [JsonProperty(PropertyName = "bms_interface_config")]
        public NSXTAttachedInterfaceEntryType BmsInterfaceConfig { get; set; }
        /// <summary>
        /// Type of port attachment. STATIC is added to replace INDEPENDENT. INDEPENDENT type and PARENT type are deprecated.
        /// </summary>
        [JsonProperty(PropertyName = "type")]
        [JsonConverter(typeof(StringEnumConverter))]
        public NSXTPortAttachmentTypeEnumType? Type { get; set; }
        /// <summary>
        /// ID used to identify/look up a child attachment behind a parent attachment
        /// </summary>
        [JsonProperty(PropertyName = "app_id")]
        public string? AppId { get; set; }
        /// <summary>
        /// VIF UUID on NSX Manager. If the attachement type is PARENT, this property is required.
        /// </summary>
        [JsonProperty(PropertyName = "id")]
        public string? Id { get; set; }
    }
}
