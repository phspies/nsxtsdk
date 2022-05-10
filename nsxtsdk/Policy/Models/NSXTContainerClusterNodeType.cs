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
    public class NSXTContainerClusterNodeType : NSXTDiscoveredResourceType
    {
        /// <summary>
        /// Network status of container cluster node.
        /// </summary>
        [JsonProperty(PropertyName = "network_status")]
        [JsonConverter(typeof(StringEnumConverter))]
        public NSXTContainerClusterNodeNetworkStatusEnumType? NetworkStatus { get; set; }
        /// <summary>
        /// Specifies identifier of container cluster node given by infrastructure provider
        /// of container cluster. e.g. in case of vSpehere, it will be instance uuid of worker
        /// node virtual machine.
        /// </summary>
        [JsonProperty(PropertyName = "provider_id")]
        public string? ProviderId { get; set; }
        /// <summary>
        /// Specifies Container Network Interface agent status of container cluster node.
        /// </summary>
        [JsonProperty(PropertyName = "cni_agent_status")]
        [JsonConverter(typeof(StringEnumConverter))]
        public NSXTContainerClusterNodeCniAgentStatusEnumType? CniAgentStatus { get; set; }
        /// <summary>
        /// List of IP addresses of container cluster node.
        /// </summary>
        [JsonProperty(PropertyName = "ip_addresses")]
        public IList<string> IpAddresses { get; set; }
        /// <summary>
        /// Array of additional specific properties of container cluster node
        /// in key-value format.
        /// </summary>
        [JsonProperty(PropertyName = "origin_properties")]
        public IList<NSXTKeyValuePairType> OriginProperties { get; set; }
        /// <summary>
        /// External identifier of the container cluster node in K8S/PAS.
        /// </summary>
        [JsonProperty(PropertyName = "external_id", Required = Required.AllowNull)]
        public string ExternalId { get; set; }
        /// <summary>
        /// External identifier of the container cluster.
        /// </summary>
        [JsonProperty(PropertyName = "container_cluster_id")]
        public string? ContainerClusterId { get; set; }
        /// <summary>
        /// List of network errors related to container cluster node.
        /// </summary>
        [JsonProperty(PropertyName = "network_errors")]
        public IList<NSXTNetworkErrorType> NetworkErrors { get; set; }
    }
}
