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
    public class NSXTContainerApplicationInstanceType : NSXTDiscoveredResourceType
    {
        /// <summary>
        /// Status of the container application instance.
        /// </summary>
        [JsonProperty(PropertyName = "status")]
        [NSXTProperty(IsRequired: false, Description: @"Status of the container application instance.")]
        public NSXTContainerApplicationInstanceStatusEnumType? Status { get; set; }
        /// <summary>
        /// Network status of container application instance.
        /// </summary>
        [JsonProperty(PropertyName = "network_status")]
        [NSXTProperty(IsRequired: false, Description: @"Network status of container application instance.")]
        public NSXTContainerApplicationInstanceNetworkStatusEnumType? NetworkStatus { get; set; }
        /// <summary>
        /// Identifier of the container cluster this application instance belongs to.
        /// </summary>
        [JsonProperty(PropertyName = "container_cluster_id")]
        [NSXTProperty(IsRequired: false, Description: @"Identifier of the container cluster this application instance belongs to.")]
        public string? ContainerClusterId { get; set; }
        /// <summary>
        /// Cluster node id where application instance is running.
        /// </summary>
        [JsonProperty(PropertyName = "cluster_node_id")]
        [NSXTProperty(IsRequired: false, Description: @"Cluster node id where application instance is running.")]
        public string? ClusterNodeId { get; set; }
        /// <summary>
        /// Identifier of the container application instance on container cluster.
        /// </summary>
        [JsonProperty(PropertyName = "external_id", Required = Required.AllowNull)]
        [NSXTProperty(IsRequired: true, Description: @"Identifier of the container application instance on container cluster.")]
        [System.ComponentModel.DataAnnotations.Required]
        public string ExternalId { get; set; }
        /// <summary>
        /// Array of additional specific properties of container application instance
        /// in key-value format.
        /// </summary>
        [JsonProperty(PropertyName = "origin_properties")]
        [NSXTProperty(IsRequired: false, Description: @"Array of additional specific properties of container application instancein key-value format.")]
        public IList<NSXTKeyValuePairType> OriginProperties { get; set; }
        /// <summary>
        /// List of identifiers of the container application.
        /// </summary>
        [JsonProperty(PropertyName = "container_application_ids")]
        [NSXTProperty(IsRequired: false, Description: @"List of identifiers of the container application.")]
        public IList<string> ContainerApplicationIds { get; set; }
        /// <summary>
        /// Identifier of the container project which this container application instance
        /// belongs to.
        /// </summary>
        [JsonProperty(PropertyName = "container_project_id")]
        [NSXTProperty(IsRequired: false, Description: @"Identifier of the container project which this container application instancebelongs to.")]
        public string? ContainerProjectId { get; set; }
        /// <summary>
        /// List of network errors related to container application instance.
        /// </summary>
        [JsonProperty(PropertyName = "network_errors")]
        [NSXTProperty(IsRequired: false, Description: @"List of network errors related to container application instance.")]
        public IList<NSXTNetworkErrorType> NetworkErrors { get; set; }
    }
}
