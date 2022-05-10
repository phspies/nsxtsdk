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
    public class NSXTBridgeEndpointProfileType : NSXTManagedResourceType
    {
        /// <summary>
        /// Faileover mode can be preemmptive or non-preemptive
        /// </summary>
        [JsonProperty(PropertyName = "failover_mode")]
        [JsonConverter(typeof(StringEnumConverter))]
        public NSXTBridgeEndpointProfileFailoverModeEnumType? FailoverMode { get; set; }
        /// <summary>
        /// First index will be used as the preferred member
        /// </summary>
        [JsonProperty(PropertyName = "edge_cluster_member_indexes")]
        public int? EdgeClusterMemberIndexes { get; set; }
        /// <summary>
        /// High avaialability mode can be active-active or active-standby
        /// </summary>
        [JsonProperty(PropertyName = "high_availability_mode")]
        [JsonConverter(typeof(StringEnumConverter))]
        public NSXTBridgeEndpointProfileHighAvailabilityModeEnumType? HighAvailabilityMode { get; set; }
        /// <summary>
        /// UUID of the edge cluster for this bridge endpoint
        /// </summary>
        [JsonProperty(PropertyName = "edge_cluster_id", Required = Required.AllowNull)]
        public string EdgeClusterId { get; set; }
    }
}
