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
    public class NSXTContainerClusterType : NSXTDiscoveredResourceType
    {
        /// <summary>
        /// Network status of container cluster.
        /// </summary>
        [JsonProperty(PropertyName = "network_status")]
        [JsonConverter(typeof(StringEnumConverter))]
        public NSXTContainerClusterNetworkStatusEnumType? NetworkStatus { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [JsonProperty(PropertyName = "infrastructure")]
        public NSXTContainerInfrastructureInfoType Infrastructure { get; set; }
        /// <summary>
        /// Specifies supervisor container project identifier for cluster.
        /// </summary>
        [JsonProperty(PropertyName = "supervisor_project_id")]
        public string? SupervisorProjectId { get; set; }
        /// <summary>
        /// Type of the container cluster. In case of creating container cluster
        /// first time, it is expected to pass the valid cluster-type.
        /// In case of update, if there is no change in cluster-type, then this
        /// field can be omitted in the request.
        /// </summary>
        [JsonProperty(PropertyName = "cluster_type")]
        [JsonConverter(typeof(StringEnumConverter))]
        public NSXTContainerClusterClusterTypeEnumType? ClusterType { get; set; }
        /// <summary>
        /// Array of additional specific properties of container cluster
        /// in key-value format.
        /// </summary>
        [JsonProperty(PropertyName = "origin_properties")]
        public IList<NSXTKeyValuePairType> OriginProperties { get; set; }
        /// <summary>
        /// Specifies Container Network Interface type for container cluster.
        /// </summary>
        [JsonProperty(PropertyName = "cni_type")]
        [JsonConverter(typeof(StringEnumConverter))]
        public NSXTContainerClusterCniTypeEnumType? CniType { get; set; }
        /// <summary>
        /// External identifier of the container cluster.
        /// </summary>
        [JsonProperty(PropertyName = "external_id")]
        public string? ExternalId { get; set; }
        /// <summary>
        /// List of network errors related to container cluster.
        /// </summary>
        [JsonProperty(PropertyName = "network_errors")]
        public IList<NSXTNetworkErrorType> NetworkErrors { get; set; }
    }
}
