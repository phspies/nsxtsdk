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
    public class NSXTClusterStatusType 
    {
        /// <summary>
        /// 
        /// </summary>
        [JsonProperty(PropertyName = "mgmt_cluster_status")]
        public NSXTManagementClusterStatusType MgmtClusterStatus { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [JsonProperty(PropertyName = "control_cluster_status")]
        public NSXTControllerClusterStatusType ControlClusterStatus { get; set; }
        /// <summary>
        /// Unique identifier of this cluster
        /// </summary>
        [JsonProperty(PropertyName = "cluster_id")]
        public string? ClusterId { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [JsonProperty(PropertyName = "detailed_cluster_status")]
        public NSXTAllClusterGroupStatusType DetailedClusterStatus { get; set; }
    }
}
