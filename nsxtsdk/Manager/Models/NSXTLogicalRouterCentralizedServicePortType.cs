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
    public class NSXTLogicalRouterCentralizedServicePortType : NSXTLogicalRouterPortType
    {
        /// <summary>
        /// 
        /// </summary>
        [JsonProperty(PropertyName = "linked_logical_switch_port_id")]
        public NSXTResourceReferenceType LinkedLogicalSwitchPortId { get; set; }
        /// <summary>
        /// Logical router port subnets
        /// </summary>
        [JsonProperty(PropertyName = "subnets")]
        public IList<NSXTIPSubnetType> Subnets { get; set; }
        /// <summary>
        /// Port is exclusively used for N-S service insertion
        /// </summary>
        [JsonProperty(PropertyName = "enable_netx")]
        public bool? EnableNetx { get; set; }
        /// <summary>
        /// Unicast Reverse Path Forwarding mode
        /// </summary>
        [JsonProperty(PropertyName = "urpf_mode")]
        [JsonConverter(typeof(StringEnumConverter))]
        public NSXTLogicalRouterCentralizedServicePortUrpfModeEnumType? UrpfMode { get; set; }
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
