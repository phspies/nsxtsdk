// <auto-generated>
// Changes may cause incorrect behavior and will be lost if the code is regenerated.
// </auto-generated>
using nsxtsdk.Models;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.ComponentModel;
using NJsonSchema.Converters;

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
        public NSXTContainerIngressPolicyNetworkStatusEnumType? NetworkStatus { get; set; }
        /// <summary>
        /// Identifier of the container cluster this ingress policy belongs to.
        /// </summary>
        public string? ContainerClusterId { get; set; }
        /// <summary>
        /// List of identifiers of the container application , on which ingress policy
        /// is applied. e.g. IDs of all services on which the ingress is applied in
        /// kubernetes.
        /// </summary>
        public IList<string> ContainerApplicationIds { get; set; }
        /// <summary>
        /// Array of additional specific properties of container ingress
        /// in key-value format.
        /// </summary>
        public IList<NSXTKeyValuePairType> OriginProperties { get; set; }
        /// <summary>
        /// Identifier of the container ingress policy.
        /// </summary>
        [JsonProperty(PropertyName = "external_id", Required = Required.AllowNull)]
        public string ExternalId { get; set; }
        /// <summary>
        /// Identifier of the project which this container ingress belongs to.
        /// </summary>
        public string? ContainerProjectId { get; set; }
        /// <summary>
        /// List of network errors related to container ingress.
        /// </summary>
        public IList<NSXTNetworkErrorType> NetworkErrors { get; set; }
        /// <summary>
        /// Container ingress policy specification.
        /// </summary>
        public string? Spec { get; set; }
    }
}
