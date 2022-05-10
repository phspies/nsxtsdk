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
    public class NSXTL2VpnServiceType : NSXTManagedResourceType
    {
        /// <summary>
        /// Full mesh topology auto disables traffic replication between connected
        /// peers. However, this property is deprecated. Please refer enable_hub
        /// property instead to control client to client forwarding via the server.
        /// The value of enable_full_mesh will not be used anymore. If enable_hub
        /// is not provided explicitly, the default value of it will be used.
        /// </summary>
        [JsonProperty(PropertyName = "enable_full_mesh")]
        public bool? EnableFullMesh { get; set; }
        /// <summary>
        /// This property only applies in SERVER mode. If set to true,
        /// traffic from any client will be replicated to all other clients.
        /// If set to false, traffic received from clients is only replicated
        /// to the local VPN endpoint.
        /// </summary>
        [JsonProperty(PropertyName = "enable_hub")]
        public bool? EnableHub { get; set; }
        /// <summary>
        /// Logical router id
        /// </summary>
        [JsonProperty(PropertyName = "logical_router_id", Required = Required.AllowNull)]
        public string LogicalRouterId { get; set; }
        /// <summary>
        /// Specify an L2VPN service mode as SERVER or CLIENT. L2VPN service
        /// in SERVER mode requires user to configure L2VPN session explicitly.
        /// L2VPN service in CLIENT mode can use peercode generated from SERVER
        /// to configure L2VPN session.
        /// </summary>
        [JsonProperty(PropertyName = "mode")]
        [JsonConverter(typeof(StringEnumConverter))]
        public NSXTL2VpnServiceModeEnumType? Mode { get; set; }
        /// <summary>
        /// IP Pool to allocate local and peer endpoint IPs for L2VpnSession logical Tap.
        /// </summary>
        [JsonProperty(PropertyName = "logical_tap_ip_pool")]
        public IList<string> LogicalTapIpPool { get; set; }
    }
}
