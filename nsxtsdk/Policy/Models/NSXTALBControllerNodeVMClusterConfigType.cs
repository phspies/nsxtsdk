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

namespace nsxtsdk.PolicyModels
{
    /// <summary>
    /// 
    /// </summary>
    [NSXTProperty(Description: @"")]
    public class NSXTALBControllerNodeVMClusterConfigType : NSXTManagedResourceType
    {
        public NSXTALBControllerNodeVMClusterConfigType()
        {
        }
        /// <summary>
        /// The cluster IP of the Advanced Load Balancer controller node cluster. This is mandatory parameter and
        /// required for single node controller deployments as well.
        /// </summary>
        [JsonProperty(PropertyName = "cluster_ip", Required = Required.AllowNull)]
        [NSXTProperty(IsRequired: true, Description: @"The cluster IP of the Advanced Load Balancer controller node cluster. This is mandatory parameter andrequired for single node controller deployments as well.")]
        [System.ComponentModel.DataAnnotations.Required]
        public string ClusterIp { get; set; }
        /// <summary>
        /// The cluster name of the Advanced Load Balancer controller node cluster.
        /// </summary>
        [JsonProperty(PropertyName = "cluster_name")]
        [NSXTProperty(IsRequired: false, Description: @"The cluster name of the Advanced Load Balancer controller node cluster.")]
        public string? ClusterName { get; set; }
        /// <summary>
        /// ID of the Cluster maintained internally. This is different from cluster_uuid internal to
        /// Advanced Load Balancer controller.
        /// Note: This is automatically generated and cannot be modified.
        /// </summary>
        [JsonProperty(PropertyName = "cluster_uuid")]
        [NSXTProperty(IsRequired: false, Description: @"ID of the Cluster maintained internally. This is different from cluster_uuid internal toAdvanced Load Balancer controller.Note: This is automatically generated and cannot be modified.")]
        public string? ClusterUuid { get; set; }
    }
}