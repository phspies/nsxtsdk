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
    public class NSXTLogicalRouterUpLinkPortType : NSXTLogicalRouterPortType
    {
        /// <summary>
        /// Logical router port subnets
        /// </summary>
        [JsonProperty(PropertyName = "subnets", Required = Required.AllowNull)]
        public IList<NSXTIPSubnetType> Subnets { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [JsonProperty(PropertyName = "linked_logical_switch_port_id")]
        public NSXTResourceReferenceType LinkedLogicalSwitchPortId { get; set; }
        /// <summary>
        /// Configuration to override the neighbor discovery router advertisement
        /// prefix time parameters at the subnet level. Note that users are allowed
        /// to override the prefix time only for IPv6 subnets which are configured
        /// on the port.
        /// </summary>
        [JsonProperty(PropertyName = "ndra_prefix_config")]
        public IList<NSXTNDRAPrefixConfigType> NdraPrefixConfig { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [JsonProperty(PropertyName = "igmp_config")]
        public NSXTInterfaceIgmpLocalGroupConfigType IgmpConfig { get; set; }
        /// <summary>
        /// Member index of the edge node on the cluster
        /// </summary>
        [JsonProperty(PropertyName = "edge_cluster_member_index", Required = Required.AllowNull)]
        public long EdgeClusterMemberIndex { get; set; }
        /// <summary>
        /// Unicast Reverse Path Forwarding mode
        /// </summary>
        [JsonProperty(PropertyName = "urpf_mode")]
        [JsonConverter(typeof(StringEnumConverter))]
        public NSXTLogicalRouterUpLinkPortUrpfModeEnumType? UrpfMode { get; set; }
        /// <summary>
        /// MAC address
        /// </summary>
        [JsonProperty(PropertyName = "mac_address")]
        public string? MacAddress { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [JsonProperty(PropertyName = "pim_config")]
        public NSXTInterfacePimConfigType PimConfig { get; set; }
        /// <summary>
        /// Identifier of Neighbor Discovery Router Advertisement profile
        /// associated with port. When NDRA profile id is associated at
        /// both the port level and logical router level, the profile id
        /// specified at port level takes the precedence.
        /// </summary>
        [JsonProperty(PropertyName = "ndra_profile_id")]
        public string? NdraProfileId { get; set; }
        /// <summary>
        /// Maximum transmission unit specifies the size of the largest packet that
        /// a network protocol can transmit. If not specified, the global logical
        /// MTU set in the /api/v1/global-configs/RoutingGlobalConfig API will be
        /// used.
        /// </summary>
        [JsonProperty(PropertyName = "mtu")]
        public long? Mtu { get; set; }
    }
}
