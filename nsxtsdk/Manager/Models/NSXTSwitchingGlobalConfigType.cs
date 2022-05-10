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
    public class NSXTSwitchingGlobalConfigType : NSXTGlobalConfigsType
    {
        /// <summary>
        /// This is a global max ARP limit per logical router per transport
        /// node. It is applied to all the logical routers present on all types
        /// of transport nodes in the NSX domain. Updates to the field are
        /// allowed only through /policy/api/v1/infra/global-config API.
        /// </summary>
        [JsonProperty(PropertyName = "arp_limit_per_lr")]
        public int? ArpLimitPerLr { get; set; }
        /// <summary>
        /// When this flag is set true, certain types of BUM packets will be sent to all VTEPs in the global VTEP table, ignoring
        /// the logical switching span.
        /// </summary>
        [JsonProperty(PropertyName = "global_replication_mode_enabled")]
        public bool? GlobalReplicationModeEnabled { get; set; }
        /// <summary>
        /// This value defines the upper threshold for the MTU value that can be configured at a physical uplink level or a logical
        /// routing uplink level in a NSX domain. All Uplink profiles validate against this value so that the MTU specified in an
        /// Uplink profile does not exceed this global upper threshold. Similarly, when this value is modified, the new value must
        /// be greater than or equal to any existing Uplink profile's MTU. This value is also validated to be greater than or equal
        /// to physical_uplink_mtu in SwitchingGlobalConfig and logical_uplink_mtu in RoutingGlobalConfig.
        /// </summary>
        [JsonProperty(PropertyName = "uplink_mtu_threshold")]
        public int? UplinkMtuThreshold { get; set; }
        /// <summary>
        /// This is the global default MTU for all the physical remote tunnel endpoints in an NSX domain. Please consider intersite
        /// link MTU minus any external overhead when defining the MTU. If this value is not set, the default value of 1500 will be
        /// used.
        /// </summary>
        [JsonProperty(PropertyName = "remote_tunnel_physical_mtu")]
        public int? RemoteTunnelPhysicalMtu { get; set; }
        /// <summary>
        /// This is the global default MTU for all the physical uplinks in a NSX domain. This is the default value for the optional
        /// uplink profile MTU field. When the MTU value is not specified in the uplink profile, this global value will be used.
        /// This value can be overridden by providing a value for the optional MTU field in the uplink profile. Whenever this value
        /// is updated, the updated value will only be propagated to the uplinks that don't have the MTU value in their uplink
        /// profiles. If this value is not set, the default value of 1700 will be used. The Transport Node state can be monitored to
        /// confirm if the updated MTU value has been realized.
        /// </summary>
        [JsonProperty(PropertyName = "physical_uplink_mtu")]
        public int? PhysicalUplinkMtu { get; set; }
    }
}
