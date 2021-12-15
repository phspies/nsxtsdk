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
    public class NSXTLogicalRouterUpLinkPortType : NSXTLogicalRouterPortType
    {
        /// <summary>
        /// Logical router port subnets
        /// </summary>
        [JsonProperty(PropertyName = "subnets", Required = Required.AllowNull)]
        [NSXTProperty(IsRequired: true, Description: @"Logical router port subnets")]
        [System.ComponentModel.DataAnnotations.Required]
        public IList<NSXTIPSubnetType> Subnets { get; set; }
        /// <summary>
        /// Reference to the logical switch port to connect to
        /// </summary>
        [JsonProperty(PropertyName = "linked_logical_switch_port_id")]
        [NSXTProperty(IsRequired: false, Description: @"Reference to the logical switch port to connect to")]
        public NSXTResourceReferenceType LinkedLogicalSwitchPortId { get; set; }
        /// <summary>
        /// Configuration to override the neighbor discovery router advertisement
        /// prefix time parameters at the subnet level. Note that users are allowed
        /// to override the prefix time only for IPv6 subnets which are configured
        /// on the port.
        /// </summary>
        [JsonProperty(PropertyName = "ndra_prefix_config")]
        [NSXTProperty(IsRequired: false, Description: @"Configuration to override the neighbor discovery router advertisementprefix time parameters at the subnet level. Note that users are allowedto override the prefix time only for IPv6 subnets which are configuredon the port.")]
        public IList<NSXTNDRAPrefixConfigType> NdraPrefixConfig { get; set; }
        /// <summary>
        /// Interface IGMP[Internet Group Management Protocol] local group config parameters.
        /// </summary>
        [JsonProperty(PropertyName = "igmp_config")]
        [NSXTProperty(IsRequired: false, Description: @"Interface IGMP[Internet Group Management Protocol] local group config parameters.")]
        public NSXTInterfaceIgmpLocalGroupConfigType IgmpConfig { get; set; }
        /// <summary>
        /// Member index of the edge node on the cluster
        /// </summary>
        [JsonProperty(PropertyName = "edge_cluster_member_index", Required = Required.AllowNull)]
        [NSXTProperty(IsRequired: true, Description: @"Member index of the edge node on the cluster")]
        [System.ComponentModel.DataAnnotations.Required]
        public long EdgeClusterMemberIndex { get; set; }
        /// <summary>
        /// Unicast Reverse Path Forwarding mode
        /// </summary>
        [JsonProperty(PropertyName = "urpf_mode")]
        [NSXTProperty(IsRequired: false, Description: @"Unicast Reverse Path Forwarding mode")]
        [NSXTDefaultProperty(Default: "STRICT")]
        public NSXTLogicalRouterUpLinkPortUrpfModeEnumType? UrpfMode { get; set; }
        /// <summary>
        /// MAC address
        /// </summary>
        [JsonProperty(PropertyName = "mac_address")]
        [NSXTProperty(IsRequired: false, Description: @"MAC address")]
        public string? MacAddress { get; set; }
        /// <summary>
        /// PIM[Protocol Independent Multicast] configuration parameters.
        /// </summary>
        [JsonProperty(PropertyName = "pim_config")]
        [NSXTProperty(IsRequired: false, Description: @"PIM[Protocol Independent Multicast] configuration parameters.")]
        public NSXTInterfacePimConfigType PimConfig { get; set; }
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