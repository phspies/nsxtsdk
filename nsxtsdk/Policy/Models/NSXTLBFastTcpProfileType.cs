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
    public class NSXTLBFastTcpProfileType : NSXTLBAppProfileType
    {
        /// <summary>
        /// It is used to specify how long a closing TCP connection (both FINs
        /// received or a RST is received) should be kept for this application
        /// before cleaning up the connection.
        /// </summary>
        [JsonProperty(PropertyName = "close_timeout")]
        public long? CloseTimeout { get; set; }
        /// <summary>
        /// It is used to configure how long an idle TCP connection in ESTABLISHED
        /// state should be kept for this application before cleaning up.
        /// </summary>
        [JsonProperty(PropertyName = "idle_timeout")]
        public long? IdleTimeout { get; set; }
        /// <summary>
        /// If flow mirroring is enabled, all the flows to the bounded virtual
        /// server are mirrored to the standby node.
        /// </summary>
        [JsonProperty(PropertyName = "ha_flow_mirroring_enabled")]
        public bool? HaFlowMirroringEnabled { get; set; }
    }
}
