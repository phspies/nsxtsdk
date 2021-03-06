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
    /// 
    /// </summary>
    [NSXTProperty(Description: @"")]
    public class NSXTLBFastUdpProfileType : NSXTLBAppProfileType
    {
        /// <summary>
        /// Though UDP is a connectionless protocol, for the purposes of load
        /// balancing, all UDP packets with the same flow signature (source and
        /// destination IP/ports and IP protocol) received within the idle timeout
        /// period are considered to belong to the same connection and are sent to
        /// the same backend server. If no packets are received for idle timeout
        /// period, the connection (association between flow signature and the
        /// selected server) is cleaned up.
        /// </summary>
        [JsonProperty(PropertyName = "idle_timeout")]
        public long? IdleTimeout { get; set; }
        /// <summary>
        /// If flow mirroring is enabled, all the flows to the bounded virtual
        /// server are mirrored to the standby node.
        /// </summary>
        [JsonProperty(PropertyName = "flow_mirroring_enabled")]
        public bool? FlowMirroringEnabled { get; set; }
    }
}
