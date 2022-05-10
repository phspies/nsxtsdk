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
    public class NSXTCommonAgentHostConfigurationInfoType : NSXTManagedResourceType
    {
        /// <summary>
        /// List of private IP prefix that NSX Application Platform Common Agent network flow
        /// is collected from.
        /// </summary>
        [JsonProperty(PropertyName = "private_ip_range")]
        public IList<NSXTCommonAgentPrivateIpRangeInfoType> PrivateIpRange { get; set; }
        /// <summary>
        /// Cluster id of the NSX Manager cluster.
        /// </summary>
        [JsonProperty(PropertyName = "nsx_cluster_id")]
        public string? NsxClusterId { get; set; }
        /// <summary>
        /// A truststore to establish the trust between NSX and NSX Application Platform.
        /// </summary>
        [JsonProperty(PropertyName = "truststore")]
        public string? Truststore { get; set; }
        /// <summary>
        /// A Kafka broker certificate to verify the identity of brokers.
        /// </summary>
        [JsonProperty(PropertyName = "kafka_certificate")]
        public string? KafkaCertificate { get; set; }
        /// <summary>
        /// List of NSX Application Platform ingress endpoints that host nodes contact initially.
        /// </summary>
        [JsonProperty(PropertyName = "ingress_endpoint")]
        public IList<NSXTCommonAgentEndpointInfoType> IngressEndpoint { get; set; }
        /// <summary>
        /// List of NSX Application Platform broker endpoints that host nodes contact initially.
        /// </summary>
        [JsonProperty(PropertyName = "kafka_endpoint")]
        public IList<NSXTCommonAgentEndpointInfoType> KafkaEndpoint { get; set; }
        /// <summary>
        /// A ingress certificate to verify the identity of brokers.
        /// </summary>
        [JsonProperty(PropertyName = "ingress_certificate")]
        public string? IngressCertificate { get; set; }
    }
}
