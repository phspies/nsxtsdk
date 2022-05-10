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
    public class NSXTClusterConfigType : NSXTRevisionedResourceType
    {
        /// <summary>
        /// True if control cluster nodes may be added or removed
        /// </summary>
        [JsonProperty(PropertyName = "control_cluster_changes_allowed")]
        public bool? ControlClusterChangesAllowed { get; set; }
        /// <summary>
        /// Configuration of each node in cluster
        /// </summary>
        [JsonProperty(PropertyName = "nodes")]
        public IList<NSXTClusterNodeInfoType> Nodes { get; set; }
        /// <summary>
        /// True if management cluster nodes may be added or removed
        /// </summary>
        [JsonProperty(PropertyName = "mgmt_cluster_changes_allowed")]
        public bool? MgmtClusterChangesAllowed { get; set; }
        /// <summary>
        /// Unique identifier of this cluster
        /// </summary>
        [JsonProperty(PropertyName = "cluster_id")]
        public string? ClusterId { get; set; }
    }
}
