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
    /// The configuration of the NSX cluster. The cluster configuration consists of a list of cluster node attributes.
    /// </summary>
    [NSXTProperty(Description: @"The configuration of the NSX cluster. The cluster configuration consists of a list of cluster node attributes.")]
    public class NSXTClusterConfigurationType 
    {
        /// <summary>
        /// Cluster configuration version
        /// </summary>
        [JsonProperty(PropertyName = "config_version")]
        public long? ConfigVersion { get; set; }
        /// <summary>
        /// Nodes in the cluster configuration
        /// </summary>
        [JsonProperty(PropertyName = "nodes")]
        public IList<NSXTClusterNodeType> Nodes { get; set; }
        /// <summary>
        /// UUID of the cluster
        /// </summary>
        [JsonProperty(PropertyName = "cluster_id")]
        public string? ClusterId { get; set; }
    }
}
