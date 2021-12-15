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
    public class NSXTClusterStatusType 
    {
        /// <summary>
        /// The current status of the management cluster
        /// </summary>
        [JsonProperty(PropertyName = "mgmt_cluster_status")]
        [NSXTProperty(IsRequired: false, Description: @"The current status of the management cluster")]
        public NSXTManagementClusterStatusType MgmtClusterStatus { get; set; }
        /// <summary>
        /// The current status of the control cluster
        /// </summary>
        [JsonProperty(PropertyName = "control_cluster_status")]
        [NSXTProperty(IsRequired: false, Description: @"The current status of the control cluster")]
        public NSXTControllerClusterStatusType ControlClusterStatus { get; set; }
        /// <summary>
        /// Unique identifier of this cluster
        /// </summary>
        [JsonProperty(PropertyName = "cluster_id")]
        [NSXTProperty(IsRequired: false, Description: @"Unique identifier of this cluster")]
        public string? ClusterId { get; set; }
        /// <summary>
        /// Status of all the cluster groups
        /// </summary>
        [JsonProperty(PropertyName = "detailed_cluster_status")]
        [NSXTProperty(IsRequired: false, Description: @"Status of all the cluster groups")]
        public NSXTAllClusterGroupStatusType DetailedClusterStatus { get; set; }
    }
}