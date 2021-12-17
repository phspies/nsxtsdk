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
    public class NSXTClusterConfigType : NSXTRevisionedResourceType
    {
        public NSXTClusterConfigType()
        {
        }
        /// <summary>
        /// True if control cluster nodes may be added or removed
        /// </summary>
        [JsonProperty(PropertyName = "control_cluster_changes_allowed")]
        [NSXTProperty(IsRequired: false, Description: @"True if control cluster nodes may be added or removed")]
        public bool? ControlClusterChangesAllowed { get; set; }
        /// <summary>
        /// Configuration of each node in cluster
        /// </summary>
        [JsonProperty(PropertyName = "nodes")]
        [NSXTProperty(IsRequired: false, Description: @"Configuration of each node in cluster")]
        public IList<NSXTClusterNodeInfoType> Nodes { get; set; }
        /// <summary>
        /// True if management cluster nodes may be added or removed
        /// </summary>
        [JsonProperty(PropertyName = "mgmt_cluster_changes_allowed")]
        [NSXTProperty(IsRequired: false, Description: @"True if management cluster nodes may be added or removed")]
        public bool? MgmtClusterChangesAllowed { get; set; }
        /// <summary>
        /// Unique identifier of this cluster
        /// </summary>
        [JsonProperty(PropertyName = "cluster_id")]
        [NSXTProperty(IsRequired: false, Description: @"Unique identifier of this cluster")]
        public string? ClusterId { get; set; }
    }
}
