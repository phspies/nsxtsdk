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
    public class NSXTVifAttachmentContextType : NSXTAttachmentContextType
    {
        /// <summary>
        /// Type of the VIF attached to logical port
        /// </summary>
        [JsonProperty(PropertyName = "vif_type", Required = Required.AllowNull)]
        [NSXTProperty(IsRequired: true, Description: @"Type of the VIF attached to logical port")]
        [System.ComponentModel.DataAnnotations.Required]
        public NSXTVifAttachmentContextVifTypeEnumType VifType { get; set; }
        /// <summary>
        /// VIF ID of the parent VIF if vif_type is CHILD
        /// </summary>
        [JsonProperty(PropertyName = "parent_vif_id")]
        [NSXTProperty(IsRequired: false, Description: @"VIF ID of the parent VIF if vif_type is CHILD")]
        public string? ParentVifId { get; set; }
        /// <summary>
        /// Current we use VLAN id as the traffic tag.
        /// Only effective when vif_type is CHILD.
        /// Each logical port inside a container must have a
        /// unique traffic tag. If the traffic_tag is not
        /// unique, no error is generated, but traffic will
        /// not be delivered to any port with a non-unique tag.
        /// </summary>
        [JsonProperty(PropertyName = "traffic_tag")]
        [NSXTProperty(IsRequired: false, Description: @"Current we use VLAN id as the traffic tag.Only effective when vif_type is CHILD.Each logical port inside a container must have aunique traffic tag. If the traffic_tag is notunique, no error is generated, but traffic willnot be delivered to any port with a non-unique tag.")]
        public int? TrafficTag { get; set; }
        /// <summary>
        /// Indicate application interface configuration for Bare Metal Server. Only
        /// effective when vif_type is INDEPENDENT.
        /// </summary>
        [JsonProperty(PropertyName = "bms_interface_config")]
        [NSXTProperty(IsRequired: false, Description: @"Indicate application interface configuration for Bare Metal Server. Onlyeffective when vif_type is INDEPENDENT.")]
        public NSXTAttachedInterfaceType BmsInterfaceConfig { get; set; }
        /// <summary>
        /// An application ID used to identify / look up a child VIF
        /// behind a parent VIF. Only effective when vif_type is CHILD.
        /// </summary>
        [JsonProperty(PropertyName = "app_id")]
        [NSXTProperty(IsRequired: false, Description: @"An application ID used to identify / look up a child VIFbehind a parent VIF. Only effective when vif_type is CHILD.")]
        public string? AppId { get; set; }
        /// <summary>
        /// Only effective when vif_type is INDEPENDENT.
        /// Each logical port inside a bare metal server
        /// or container must have a transport node UUID.
        /// We use transport node ID as transport node UUID.
        /// </summary>
        [JsonProperty(PropertyName = "transport_node_uuid")]
        [NSXTProperty(IsRequired: false, Description: @"Only effective when vif_type is INDEPENDENT.Each logical port inside a bare metal serveror container must have a transport node UUID.We use transport node ID as transport node UUID.")]
        public string? TransportNodeUuid { get; set; }
    }
}
