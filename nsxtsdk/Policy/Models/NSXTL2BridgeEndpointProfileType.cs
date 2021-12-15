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
        [NSXTProperty(IsRequired: false, Description: @"Failover mode for the edge bridge cluster")]
        [NSXTDefaultProperty(Default: "PREEMPTIVE")]
        public NSXTL2BridgeEndpointProfileFailoverModeEnumType? FailoverMode { get; set; }
        /// <summary>
        /// High avaialability mode can be active-active or active-standby. High availability mode cannot be modified after
        /// realization.
        /// </summary>
        [JsonProperty(PropertyName = "ha_mode")]
        [NSXTProperty(IsRequired: false, Description: @"High avaialability mode can be active-active or active-standby. High availability mode cannot be modified after realization.")]
        [NSXTDefaultProperty(Default: "ACTIVE_STANDBY")]
        public NSXTL2BridgeEndpointProfileHaModeEnumType? HaMode { get; set; }
        /// <summary>
        /// List of policy paths to edge nodes. Edge allocation for L2 bridging.
        /// </summary>
        [JsonProperty(PropertyName = "edge_paths")]
        [NSXTProperty(IsRequired: false, Description: @"List of policy paths to edge nodes. Edge allocation for L2 bridging.")]
        public IList<string> EdgePaths { get; set; }
    }
}
