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
    /// Advanced Load Balancer controller cluster information about nodes in the cluster and cluster information.
    /// </summary>
    [NSXTProperty(Description: @"Advanced Load Balancer controller cluster information about nodes in the cluster and cluster information.")]
    public class NSXTALBControllerClusterInfoType 
    {
        /// <summary>
        /// Advanced Load Balancer controller cluster name.
        /// </summary>
        [JsonProperty(PropertyName = "cluster_name")]
        public string? ClusterName { get; set; }
        /// <summary>
        /// Advanced Load Balancer cluster state not STABLE reason.
        /// </summary>
        [JsonProperty(PropertyName = "reason")]
        public string? Reason { get; set; }
        /// <summary>
        /// Advanced Load Balancer controller cluster version.
        /// </summary>
        [JsonProperty(PropertyName = "version")]
        public string? Version { get; set; }
        /// <summary>
        /// Advanced Load Balancer controller cluster state.
        /// </summary>
        [JsonProperty(PropertyName = "cluster_state")]
        public string? ClusterState { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [JsonProperty(PropertyName = "error")]
        public NSXTAlbControllerClusterRuntimeErrorType Error { get; set; }
        /// <summary>
        /// ID of the Cluster maintained internally.
        /// Note: This is automatically generated and cannot be modified.
        /// </summary>
        [JsonProperty(PropertyName = "cluster_uuid")]
        public string? ClusterUuid { get; set; }
        /// <summary>
        /// Advanced Load Balancer controller node information
        /// </summary>
        [JsonProperty(PropertyName = "nodes")]
        public IList<NSXTALBControllerNodeInfoType> Nodes { get; set; }
        /// <summary>
        /// Advanced Load Balancer controller cluster virtual_ip.
        /// </summary>
        [JsonProperty(PropertyName = "virtual_ip")]
        public string? VirtualIp { get; set; }
    }
}
