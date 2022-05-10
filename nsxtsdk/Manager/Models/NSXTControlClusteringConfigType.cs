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
    public class NSXTControlClusteringConfigType : NSXTClusteringConfigType
    {
        /// <summary>
        /// Specifies whether or not the cluster node VM should try to join to
        /// the existing control cluster or initialize a new one.
        /// Only required in uncertainty case, i.e. when there are manually-
        /// deployed controllers that are registered but not connected to the
        /// cluster and no auto-deployed controllers are part of the cluster.
        /// </summary>
        [JsonProperty(PropertyName = "join_to_existing_cluster")]
        public bool? JoinToExistingCluster { get; set; }
        /// <summary>
        /// Shared secret to be used when joining the cluster node VM to a control
        /// cluster or for initializing a new cluster with the VM.
        /// Must contain at least 4 unique characters and be at least 6 characters
        /// long.
        /// </summary>
        [JsonProperty(PropertyName = "shared_secret")]
        public string? SharedSecret { get; set; }
    }
}
