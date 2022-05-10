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
    public class NSXTLogicalRouterDownLinkPortType : NSXTLogicalRouterPortType
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
        /// Identifier of Neighbor Discovery Router Advertisement profile
        /// associated with port. When NDRA profile id is associated at
        /// both the port level and logical router level, the profile id
        /// specified at port level takes the precedence.
        /// </summary>
        [JsonProperty(PropertyName = "ndra_profile_id")]
        public string? NdraProfileId { get; set; }
        /// <summary>
        /// MAC address
        /// </summary>
        [JsonProperty(PropertyName = "mac_address")]
        public string? MacAddress { get; set; }
        /// <summary>
        /// Unicast Reverse Path Forwarding mode
        /// </summary>
        [JsonProperty(PropertyName = "urpf_mode")]
        [JsonConverter(typeof(StringEnumConverter))]
        public NSXTLogicalRouterDownLinkPortUrpfModeEnumType? UrpfMode { get; set; }
        /// <summary>
        /// Routing policies used to specify how the traffic, which matches the
        /// policy routes, will be processed.
        /// </summary>
        [JsonProperty(PropertyName = "routing_policies")]
        public IList<NSXTRoutingPolicyType> RoutingPolicies { get; set; }
        /// <summary>
        /// If this flag is set to true - it will enable multicast on the
        /// downlink interface. If this flag is set to false - it will disable
        /// multicast on the downlink interface. This is supported only on
        /// Tier0 downlinks. Default value for Tier0 downlink will be true.
        /// </summary>
        [JsonProperty(PropertyName = "enable_multicast")]
        public bool? EnableMulticast { get; set; }
        /// <summary>
        /// Configuration to override the neighbor discovery router advertisement
        /// prefix time parameters at the subnet level. Note that users are allowed
        /// to override the prefix time only for IPv6 subnets which are configured
        /// on the port.
        /// </summary>
        [JsonProperty(PropertyName = "ndra_prefix_config")]
        public IList<NSXTNDRAPrefixConfigType> NdraPrefixConfig { get; set; }
    }
}
