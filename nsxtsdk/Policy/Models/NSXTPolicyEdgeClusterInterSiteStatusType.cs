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
    public class NSXTPolicyEdgeClusterInterSiteStatusType 
    {
        /// <summary>
        /// Timestamp when the edge cluster inter-site status was last updated.
        /// </summary>
        [JsonProperty(PropertyName = "last_update_timestamp")]
        [NSXTProperty(IsRequired: false, Description: @"Timestamp when the edge cluster inter-site status was last updated.")]
        public long? LastUpdateTimestamp { get; set; }
        /// <summary>
        /// Overall status of all edge nodes IBGP status in the edge cluster.
        /// </summary>
        [JsonProperty(PropertyName = "overall_status")]
        [NSXTProperty(IsRequired: false, Description: @"Overall status of all edge nodes IBGP status in the edge cluster.")]
        public NSXTPolicyEdgeClusterInterSiteStatusOverallStatusEnumType? OverallStatus { get; set; }
        /// <summary>
        /// Name of the edge cluster whose status is being reported.
        /// </summary>
        [JsonProperty(PropertyName = "edge_cluster_name")]
        [NSXTProperty(IsRequired: false, Description: @"Name of the edge cluster whose status is being reported.")]
        public string? EdgeClusterName { get; set; }
        /// <summary>
        /// Per edge node inter-site status.
        /// </summary>
        [JsonProperty(PropertyName = "member_status")]
        [NSXTProperty(IsRequired: false, Description: @"Per edge node inter-site status.")]
        public IList<NSXTPolicyEdgeClusterMemberInterSiteStatusType> MemberStatus { get; set; }
        /// <summary>
        /// Policy path of the edge cluster whose status is being reported.
        /// </summary>
        [JsonProperty(PropertyName = "edge_cluster_path")]
        [NSXTProperty(IsRequired: false, Description: @"Policy path of the edge cluster whose status is being reported.")]
        public string? EdgeClusterPath { get; set; }
    }
}
