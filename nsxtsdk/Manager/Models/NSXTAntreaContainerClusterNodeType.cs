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
    /// Antrea container cluster and its nodes requiring a support bundle
    /// </summary>
    [NSXTProperty(Description: @"Antrea container cluster and its nodes requiring a support bundle")]
    public class NSXTAntreaContainerClusterNodeType 
    {
        /// <summary>
        /// List of at most 200 container node UUIDs requiring a support bundle
        /// </summary>
        [JsonProperty(PropertyName = "nodes")]
        public IList<string> Nodes { get; set; }
        /// <summary>
        /// The UUID of the container cluster
        /// </summary>
        [JsonProperty(PropertyName = "cluster_id", Required = Required.AllowNull)]
        public string ClusterId { get; set; }
    }
}
