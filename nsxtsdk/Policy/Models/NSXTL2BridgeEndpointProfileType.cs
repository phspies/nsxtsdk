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
    public class NSXTL2BridgeEndpointProfileType : NSXTPolicyConfigResourceType
    {
        /// <summary>
        /// Failover mode for the edge bridge cluster
        /// </summary>
        [JsonProperty(PropertyName = "failover_mode")]
        [JsonConverter(typeof(StringEnumConverter))]
        public NSXTL2BridgeEndpointProfileFailoverModeEnumType? FailoverMode { get; set; }
        /// <summary>
        /// High avaialability mode can be active-active or active-standby. High availability mode cannot be modified after
        /// realization.
        /// </summary>
        [JsonProperty(PropertyName = "ha_mode")]
        [JsonConverter(typeof(StringEnumConverter))]
        public NSXTL2BridgeEndpointProfileHaModeEnumType? HaMode { get; set; }
        /// <summary>
        /// List of policy paths to edge nodes. Edge allocation for L2 bridging.
        /// </summary>
        [JsonProperty(PropertyName = "edge_paths")]
        public IList<string> EdgePaths { get; set; }
    }
}
