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
    public class NSXTLogicalRouterCentralizedServicePortType : NSXTLogicalRouterPortType
    {
        /// <summary>
        /// Reference to the logical switch port to connect to
        /// </summary>
        [JsonProperty(PropertyName = "linked_logical_switch_port_id")]
        [NSXTProperty(IsRequired: false, Description: @"Reference to the logical switch port to connect to")]
        public NSXTResourceReferenceType LinkedLogicalSwitchPortId { get; set; }
        /// <summary>
        /// Logical router port subnets
        /// </summary>
        [JsonProperty(PropertyName = "subnets")]
        [NSXTProperty(IsRequired: false, Description: @"Logical router port subnets")]
        public IList<NSXTIPSubnetType> Subnets { get; set; }
        /// <summary>
        /// Port is exclusively used for N-S service insertion
        /// </summary>
        [JsonProperty(PropertyName = "enable_netx")]
        [NSXTProperty(IsRequired: false, Description: @"Port is exclusively used for N-S service insertion")]
        public bool? EnableNetx { get; set; }
        /// <summary>
        /// Unicast Reverse Path Forwarding mode
        /// </summary>
        [JsonProperty(PropertyName = "urpf_mode")]
        [NSXTProperty(IsRequired: false, Description: @"Unicast Reverse Path Forwarding mode")]
        [NSXTDefaultProperty(Default: "STRICT")]
        public NSXTLogicalRouterCentralizedServicePortUrpfModeEnumType? UrpfMode { get; set; }
        /// <summary>
        /// Identifier of Neighbor Discovery Router Advertisement profile
        /// associated with port. When NDRA profile id is associated at
        /// both the port level and logical router level, the profile id
        /// specified at port level takes the precedence.
        /// </summary>
        [JsonProperty(PropertyName = "ndra_profile_id")]
        [NSXTProperty(IsRequired: false, Description: @"Identifier of Neighbor Discovery Router Advertisement profileassociated with port. When NDRA profile id is associated atboth the port level and logical router level, the profile idspecified at port level takes the precedence.")]
        public string? NdraProfileId { get; set; }
        /// <summary>
        /// Maximum transmission unit specifies the size of the largest packet that
        /// a network protocol can transmit. If not specified, the global logical
        /// MTU set in the /api/v1/global-configs/RoutingGlobalConfig API will be
        /// used.
        /// </summary>
        [JsonProperty(PropertyName = "mtu")]
        [NSXTProperty(IsRequired: false, Description: @"Maximum transmission unit specifies the size of the largest packet thata network protocol can transmit. If not specified, the global logicalMTU set in the /api/v1/global-configs/RoutingGlobalConfig API will beused.")]
        //[System.ComponentModel.DataAnnotations.MinLength(64)]
        public long? Mtu { get; set; }
    }
}
