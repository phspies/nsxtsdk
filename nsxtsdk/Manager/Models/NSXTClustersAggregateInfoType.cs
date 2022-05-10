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
    public class NSXTClustersAggregateInfoType 
    {
        /// <summary>
        /// Array of Management Nodes
        /// </summary>
        [JsonProperty(PropertyName = "management_cluster", Required = Required.AllowNull)]
        public IList<NSXTManagementNodeAggregateInfoType> ManagementCluster { get; set; }
        /// <summary>
        /// Array of Controller Nodes
        /// </summary>
        [JsonProperty(PropertyName = "controller_cluster", Required = Required.AllowNull)]
        public IList<NSXTControllerNodeAggregateInfoType> ControllerCluster { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [JsonProperty(PropertyName = "cluster_status")]
        public NSXTAllClusterGroupStatusType ClusterStatus { get; set; }
    }
}
