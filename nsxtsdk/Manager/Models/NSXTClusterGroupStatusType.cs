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
    /// This type contains the attributes and status of a group.
    /// </summary>
    [NSXTProperty(Description: @"This type contains the attributes and status of a group.")]
    public class NSXTClusterGroupStatusType 
    {
        /// <summary>
        /// Array of group members and their statuses
        /// </summary>
        [JsonProperty(PropertyName = "members")]
        public IList<NSXTClusterGroupMemberStatusType> Members { get; set; }
        /// <summary>
        /// UUID of the group
        /// </summary>
        [JsonProperty(PropertyName = "group_id")]
        public string? GroupId { get; set; }
        /// <summary>
        /// Array of group leaders and their attributes
        /// </summary>
        [JsonProperty(PropertyName = "leaders")]
        public IList<NSXTClusterGroupServiceLeaderType> Leaders { get; set; }
        /// <summary>
        /// Group status
        /// </summary>
        [JsonProperty(PropertyName = "group_status")]
        [JsonConverter(typeof(StringEnumConverter))]
        public NSXTClusterGroupStatusGroupStatusEnumType? GroupStatus { get; set; }
        /// <summary>
        /// Type of the group
        /// </summary>
        [JsonProperty(PropertyName = "group_type")]
        [JsonConverter(typeof(StringEnumConverter))]
        public NSXTClusterGroupStatusGroupTypeEnumType? GroupType { get; set; }
    }
}
