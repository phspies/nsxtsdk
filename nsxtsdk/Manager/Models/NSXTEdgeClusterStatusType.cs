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
    public class NSXTEdgeClusterStatusType 
    {
        /// <summary>
        /// Timestamp when the cluster status was last updated
        /// </summary>
        [JsonProperty(PropertyName = "last_update_timestamp")]
        public long? LastUpdateTimestamp { get; set; }
        /// <summary>
        /// Status of an edge node
        /// </summary>
        [JsonProperty(PropertyName = "edge_cluster_status", Required = Required.AllowNull)]
        [JsonConverter(typeof(StringEnumConverter))]
        public NSXTEdgeClusterStatusEdgeClusterStatusEnumType EdgeClusterStatus { get; set; }
        /// <summary>
        /// Per Edge Node Status
        /// </summary>
        [JsonProperty(PropertyName = "member_status")]
        public IList<NSXTEdgeClusterMemberStatusType> MemberStatus { get; set; }
        /// <summary>
        /// Id of the edge cluster whose status is being reported
        /// </summary>
        [JsonProperty(PropertyName = "edge_cluster_id", Required = Required.AllowNull)]
        public string EdgeClusterId { get; set; }
    }
}
