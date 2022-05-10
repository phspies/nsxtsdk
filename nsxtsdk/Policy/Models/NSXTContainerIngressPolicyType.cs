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
    public class NSXTContainerIngressPolicyType : NSXTDiscoveredResourceType
    {
        /// <summary>
        /// Network status of container ingress.
        /// </summary>
        [JsonProperty(PropertyName = "network_status")]
        [JsonConverter(typeof(StringEnumConverter))]
        public NSXTContainerIngressPolicyNetworkStatusEnumType? NetworkStatus { get; set; }
        /// <summary>
        /// Identifier of the container cluster this ingress policy belongs to.
        /// </summary>
        [JsonProperty(PropertyName = "container_cluster_id")]
        public string? ContainerClusterId { get; set; }
        /// <summary>
        /// List of identifiers of the container application , on which ingress policy
        /// is applied. e.g. IDs of all services on which the ingress is applied in
        /// kubernetes.
        /// </summary>
        [JsonProperty(PropertyName = "container_application_ids")]
        public IList<string> ContainerApplicationIds { get; set; }
        /// <summary>
        /// Array of additional specific properties of container ingress
        /// in key-value format.
        /// </summary>
        [JsonProperty(PropertyName = "origin_properties")]
        public IList<NSXTKeyValuePairType> OriginProperties { get; set; }
        /// <summary>
        /// Identifier of the container ingress policy.
        /// </summary>
        [JsonProperty(PropertyName = "external_id", Required = Required.AllowNull)]
        public string ExternalId { get; set; }
        /// <summary>
        /// Identifier of the project which this container ingress belongs to.
        /// </summary>
        [JsonProperty(PropertyName = "container_project_id")]
        public string? ContainerProjectId { get; set; }
        /// <summary>
        /// List of network errors related to container ingress.
        /// </summary>
        [JsonProperty(PropertyName = "network_errors")]
        public IList<NSXTNetworkErrorType> NetworkErrors { get; set; }
        /// <summary>
        /// Container ingress policy specification.
        /// </summary>
        [JsonProperty(PropertyName = "spec")]
        public string? Spec { get; set; }
    }
}
