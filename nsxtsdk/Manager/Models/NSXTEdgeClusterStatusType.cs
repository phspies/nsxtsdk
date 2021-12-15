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
        [NSXTProperty(IsRequired: false, Description: @"Timestamp when the cluster status was last updated")]
        public long? LastUpdateTimestamp { get; set; }
        /// <summary>
        /// Status of an edge node
        /// </summary>
        [JsonProperty(PropertyName = "edge_cluster_status", Required = Required.AllowNull)]
        [NSXTProperty(IsRequired: true, Description: @"Status of an edge node")]
        [System.ComponentModel.DataAnnotations.Required]
        public NSXTEdgeClusterStatusEdgeClusterStatusEnumType EdgeClusterStatus { get; set; }
        /// <summary>
        /// Per Edge Node Status
        /// </summary>
        [JsonProperty(PropertyName = "member_status")]
        [NSXTProperty(IsRequired: false, Description: @"Per Edge Node Status")]
        public IList<NSXTEdgeClusterMemberStatusType> MemberStatus { get; set; }
        /// <summary>
        /// Id of the edge cluster whose status is being reported
        /// </summary>
        [JsonProperty(PropertyName = "edge_cluster_id", Required = Required.AllowNull)]
        [NSXTProperty(IsRequired: true, Description: @"Id of the edge cluster whose status is being reported")]
        [System.ComponentModel.DataAnnotations.Required]
        public string EdgeClusterId { get; set; }
    }
}
