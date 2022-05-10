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
    /// Configuration for automatically joining a cluster node to the
        /// cluster after it is deployed. ClusteringConfig is required
        /// if any of the deployment nodes has CONTROLLER role.
    /// </summary>
    [NSXTProperty(Description: @"Configuration for automatically joining a cluster node to thecluster after it is deployed. ClusteringConfig is requiredif any of the deployment nodes has CONTROLLER role.")]
    public class NSXTClusteringConfigType 
    {
        /// <summary>
        /// Specifies the type of clustering config to be used.
        /// </summary>
        [JsonProperty(PropertyName = "clustering_type", Required = Required.AllowNull)]
        [JsonConverter(typeof(StringEnumConverter))]
        public NSXTClusteringConfigClusteringTypeEnumType ClusteringType { get; set; }
    }
}
