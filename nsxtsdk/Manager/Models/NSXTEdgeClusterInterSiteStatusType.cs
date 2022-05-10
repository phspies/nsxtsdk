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
    public class NSXTEdgeClusterInterSiteStatusType 
    {
        /// <summary>
        /// Timestamp when the edge cluster inter-site status was last updated.
        /// </summary>
        [JsonProperty(PropertyName = "last_update_timestamp")]
        public long? LastUpdateTimestamp { get; set; }
        /// <summary>
        /// Overall status of all edge nodes IBGP status in the edge cluster.
        /// </summary>
        [JsonProperty(PropertyName = "overall_status")]
        [JsonConverter(typeof(StringEnumConverter))]
        public NSXTEdgeClusterInterSiteStatusOverallStatusEnumType? OverallStatus { get; set; }
        /// <summary>
        /// Name of the edge cluster whose status is being reported.
        /// </summary>
        [JsonProperty(PropertyName = "edge_cluster_name")]
        public string? EdgeClusterName { get; set; }
        /// <summary>
        /// Per edge node inter-site status.
        /// </summary>
        [JsonProperty(PropertyName = "member_status")]
        public IList<NSXTEdgeClusterMemberInterSiteStatusType> MemberStatus { get; set; }
        /// <summary>
        /// Id of the edge cluster whose status is being reported.
        /// </summary>
        [JsonProperty(PropertyName = "edge_cluster_id")]
        public string? EdgeClusterId { get; set; }
    }
}
