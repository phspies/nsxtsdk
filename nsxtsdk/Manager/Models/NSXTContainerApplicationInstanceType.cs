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
    public class NSXTContainerApplicationInstanceType : NSXTDiscoveredResourceType
    {
        /// <summary>
        /// Status of the container application instance.
        /// </summary>
        [JsonProperty(PropertyName = "status")]
        [JsonConverter(typeof(StringEnumConverter))]
        public NSXTContainerApplicationInstanceStatusEnumType? Status { get; set; }
        /// <summary>
        /// Network status of container application instance.
        /// </summary>
        [JsonProperty(PropertyName = "network_status")]
        [JsonConverter(typeof(StringEnumConverter))]
        public NSXTContainerApplicationInstanceNetworkStatusEnumType? NetworkStatus { get; set; }
        /// <summary>
        /// Identifier of the container cluster this application instance belongs to.
        /// </summary>
        [JsonProperty(PropertyName = "container_cluster_id")]
        public string? ContainerClusterId { get; set; }
        /// <summary>
        /// Cluster node id where application instance is running.
        /// </summary>
        [JsonProperty(PropertyName = "cluster_node_id")]
        public string? ClusterNodeId { get; set; }
        /// <summary>
        /// Identifier of the container application instance on container cluster.
        /// </summary>
        [JsonProperty(PropertyName = "external_id", Required = Required.AllowNull)]
        public string ExternalId { get; set; }
        /// <summary>
        /// Array of additional specific properties of container application instance
        /// in key-value format.
        /// </summary>
        [JsonProperty(PropertyName = "origin_properties")]
        public IList<NSXTKeyValuePairType> OriginProperties { get; set; }
        /// <summary>
        /// List of identifiers of the container application.
        /// </summary>
        [JsonProperty(PropertyName = "container_application_ids")]
        public IList<string> ContainerApplicationIds { get; set; }
        /// <summary>
        /// Identifier of the container project which this container application instance
        /// belongs to.
        /// </summary>
        [JsonProperty(PropertyName = "container_project_id")]
        public string? ContainerProjectId { get; set; }
        /// <summary>
        /// List of network errors related to container application instance.
        /// </summary>
        [JsonProperty(PropertyName = "network_errors")]
        public IList<NSXTNetworkErrorType> NetworkErrors { get; set; }
    }
}
