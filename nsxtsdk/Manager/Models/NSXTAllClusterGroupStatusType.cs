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
    /// A list of the statuses of all the groups in the cluster.
    /// </summary>
    [NSXTProperty(Description: @"A list of the statuses of all the groups in the cluster.")]
    public class NSXTAllClusterGroupStatusType 
    {
        /// <summary>
        /// Overall status of the cluster
        /// </summary>
        [JsonProperty(PropertyName = "overall_status")]
        [JsonConverter(typeof(StringEnumConverter))]
        public NSXTAllClusterGroupStatusOverallStatusEnumType? OverallStatus { get; set; }
        /// <summary>
        /// UUID of the cluster
        /// </summary>
        [JsonProperty(PropertyName = "cluster_id")]
        public string? ClusterId { get; set; }
        /// <summary>
        /// Array of groups and their statuses
        /// </summary>
        [JsonProperty(PropertyName = "groups")]
        public IList<NSXTClusterGroupStatusType> Groups { get; set; }
    }
}
