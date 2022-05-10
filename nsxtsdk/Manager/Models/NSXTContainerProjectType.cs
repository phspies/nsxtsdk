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
    public class NSXTContainerProjectType : NSXTDiscoveredResourceType
    {
        /// <summary>
        /// Network status of container project.
        /// </summary>
        [JsonProperty(PropertyName = "network_status")]
        [JsonConverter(typeof(StringEnumConverter))]
        public NSXTContainerProjectNetworkStatusEnumType? NetworkStatus { get; set; }
        /// <summary>
        /// Identifier of the container cluster to which this project/namespace belongs.
        /// </summary>
        [JsonProperty(PropertyName = "container_cluster_id")]
        public string? ContainerClusterId { get; set; }
        /// <summary>
        /// Array of additional specific properties of container project
        /// in key-value format.
        /// </summary>
        [JsonProperty(PropertyName = "origin_properties")]
        public IList<NSXTKeyValuePairType> OriginProperties { get; set; }
        /// <summary>
        /// External identifier of the container project.
        /// </summary>
        [JsonProperty(PropertyName = "external_id", Required = Required.AllowNull)]
        public string ExternalId { get; set; }
        /// <summary>
        /// List of network errors related to container project.
        /// </summary>
        [JsonProperty(PropertyName = "network_errors")]
        public IList<NSXTNetworkErrorType> NetworkErrors { get; set; }
    }
}
