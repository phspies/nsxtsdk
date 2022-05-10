using nsxtsdk.Models;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.ComponentModel;
using NJsonSchema.Converters;
using Newtonsoft.Json.Converters;

namespace nsxtsdk.PolicyModels
{
    /// <summary>
    /// 
    /// </summary>
    [NSXTProperty(Description: @"")]
    public class NSXTALBControllerNodeVMClusterConfigType : NSXTManagedResourceType
    {
        /// <summary>
        /// The cluster IP of the Advanced Load Balancer controller node cluster. This is mandatory parameter and
        /// required for single node controller deployments as well.
        /// </summary>
        [JsonProperty(PropertyName = "cluster_ip", Required = Required.AllowNull)]
        public string ClusterIp { get; set; }
        /// <summary>
        /// The cluster name of the Advanced Load Balancer controller node cluster.
        /// </summary>
        [JsonProperty(PropertyName = "cluster_name")]
        public string? ClusterName { get; set; }
        /// <summary>
        /// ID of the Cluster maintained internally. This is different from cluster_uuid internal to
        /// Advanced Load Balancer controller.
        /// Note: This is automatically generated and cannot be modified.
        /// </summary>
        [JsonProperty(PropertyName = "cluster_uuid")]
        public string? ClusterUuid { get; set; }
    }
}
