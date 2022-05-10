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
    public class NSXTContainerNetworkPolicyType : NSXTDiscoveredResourceType
    {
        /// <summary>
        /// Network status of container network policy.
        /// </summary>
        [JsonProperty(PropertyName = "network_status")]
        [JsonConverter(typeof(StringEnumConverter))]
        public NSXTContainerNetworkPolicyNetworkStatusEnumType? NetworkStatus { get; set; }
        /// <summary>
        /// Identifier of the container cluster this network policy belongs to.
        /// </summary>
        [JsonProperty(PropertyName = "container_cluster_id")]
        public string? ContainerClusterId { get; set; }
        /// <summary>
        /// Type e.g. Network Policy, ASG.
        /// </summary>
        [JsonProperty(PropertyName = "policy_type")]
        [JsonConverter(typeof(StringEnumConverter))]
        public NSXTContainerNetworkPolicyPolicyTypeEnumType? PolicyType { get; set; }
        /// <summary>
        /// Array of additional specific properties of container network policy
        /// in key-value format.
        /// </summary>
        [JsonProperty(PropertyName = "origin_properties")]
        public IList<NSXTKeyValuePairType> OriginProperties { get; set; }
        /// <summary>
        /// Identifier of the container network policy.
        /// </summary>
        [JsonProperty(PropertyName = "external_id", Required = Required.AllowNull)]
        public string ExternalId { get; set; }
        /// <summary>
        /// Identifier of the project which this network policy belongs to.
        /// </summary>
        [JsonProperty(PropertyName = "container_project_id")]
        public string? ContainerProjectId { get; set; }
        /// <summary>
        /// List of network errors related to container network policy.
        /// </summary>
        [JsonProperty(PropertyName = "network_errors")]
        public IList<NSXTNetworkErrorType> NetworkErrors { get; set; }
        /// <summary>
        /// Container network policy specification.
        /// </summary>
        [JsonProperty(PropertyName = "spec")]
        public string? Spec { get; set; }
    }
}
