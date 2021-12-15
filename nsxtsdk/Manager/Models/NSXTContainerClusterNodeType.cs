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
    public class NSXTContainerClusterNodeType : NSXTDiscoveredResourceType
    {
        /// <summary>
        /// Network status of container cluster node.
        /// </summary>
        [JsonProperty(PropertyName = "network_status")]
        [NSXTProperty(IsRequired: false, Description: @"Network status of container cluster node.")]
        public NSXTContainerClusterNodeNetworkStatusEnumType? NetworkStatus { get; set; }
        /// <summary>
        /// External identifier of the container cluster.
        /// </summary>
        [JsonProperty(PropertyName = "container_cluster_id")]
        [NSXTProperty(IsRequired: false, Description: @"External identifier of the container cluster.")]
        public string? ContainerClusterId { get; set; }
        /// <summary>
        /// List of IP addresses of container cluster node.
        /// </summary>
        [JsonProperty(PropertyName = "ip_addresses")]
        [NSXTProperty(IsRequired: false, Description: @"List of IP addresses of container cluster node.")]
        public IList<string> IpAddresses { get; set; }
        /// <summary>
        /// Array of additional specific properties of container cluster node
        /// in key-value format.
        /// </summary>
        [JsonProperty(PropertyName = "origin_properties")]
        [NSXTProperty(IsRequired: false, Description: @"Array of additional specific properties of container cluster nodein key-value format.")]
        public IList<NSXTKeyValuePairType> OriginProperties { get; set; }
        /// <summary>
        /// External identifier of the container cluster node in K8S/PAS.
        /// </summary>
        [JsonProperty(PropertyName = "external_id", Required = Required.AllowNull)]
        [NSXTProperty(IsRequired: true, Description: @"External identifier of the container cluster node in K8S/PAS.")]
        [System.ComponentModel.DataAnnotations.Required]
        public string ExternalId { get; set; }
        /// <summary>
        /// List of network errors related to container cluster node.
        /// </summary>
        [JsonProperty(PropertyName = "network_errors")]
        [NSXTProperty(IsRequired: false, Description: @"List of network errors related to container cluster node.")]
        public IList<NSXTNetworkErrorType> NetworkErrors { get; set; }
    }
}
