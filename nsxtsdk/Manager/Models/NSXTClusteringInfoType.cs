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
    /// Clustering parameters for the controller cluster
    /// </summary>
    [NSXTProperty(Description: @"Clustering parameters for the controller cluster")]
    public class NSXTClusteringInfoType 
    {
        /// <summary>
        /// Shared secret of the cluster.
        /// </summary>
        [JsonProperty(PropertyName = "shared_secret")]
        public string? SharedSecret { get; set; }
        /// <summary>
        /// Property to indicate if the node must join an existing cluster.
        /// </summary>
        [JsonProperty(PropertyName = "join_to_existing_cluster", Required = Required.AllowNull)]
        public bool JoinToExistingCluster { get; set; }
    }
}
