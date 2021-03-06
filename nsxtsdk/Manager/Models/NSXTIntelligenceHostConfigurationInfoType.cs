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
    public class NSXTIntelligenceHostConfigurationInfoType : NSXTManagedResourceType
    {
        /// <summary>
        /// Maximum active network flow to collect in collection interval for Bare Metal server.
        /// </summary>
        [JsonProperty(PropertyName = "max_active_flow_count_bm")]
        public long? MaxActiveFlowCountBm { get; set; }
        /// <summary>
        /// Interval in minute of reporting VM guest context data to NSX-Intelligence.
        /// Recommend to keep this value the same as flow_data_collection_interval.
        /// </summary>
        [JsonProperty(PropertyName = "context_data_collection_interval")]
        public long? ContextDataCollectionInterval { get; set; }
        /// <summary>
        /// A truststore to establish the trust between NSX and NSX-Intelligence brokers.
        /// </summary>
        [JsonProperty(PropertyName = "broker_truststore")]
        public string? BrokerTruststore { get; set; }
        /// <summary>
        /// Interval in minute of reporting network flow data to NSX-Intelligence.
        /// Recommend to keep this value the same as context_data_collection_interval.
        /// </summary>
        [JsonProperty(PropertyName = "flow_data_collection_interval")]
        public long? FlowDataCollectionInterval { get; set; }
        /// <summary>
        /// A broker certificate to verify the identity of brokers.
        /// </summary>
        [JsonProperty(PropertyName = "broker_certificate")]
        public string? BrokerCertificate { get; set; }
        /// <summary>
        /// List of windows user sid to collect context data.
        /// Empty implies all users.
        /// </summary>
        [JsonProperty(PropertyName = "context_user_sids")]
        public IList<string> ContextUserSids { get; set; }
        /// <summary>
        /// Enable NSX-Intelligence context data collection in host nodes.
        /// </summary>
        [JsonProperty(PropertyName = "enable_context_data_collection")]
        public bool? EnableContextDataCollection { get; set; }
        /// <summary>
        /// List of linux user uid to collect context data.
        /// Empty implies all users.
        /// </summary>
        [JsonProperty(PropertyName = "context_user_uids")]
        public IList<string> ContextUserUids { get; set; }
        /// <summary>
        /// Enable NSX-Intelligence flow data collection in host nodes.
        /// </summary>
        [JsonProperty(PropertyName = "enable_flow_data_collection")]
        public bool? EnableFlowDataCollection { get; set; }
        /// <summary>
        /// Enable NSX-Intelligence deep packet inspection in host nodes.
        /// </summary>
        [JsonProperty(PropertyName = "enable_deep_packet_inspection")]
        public bool? EnableDeepPacketInspection { get; set; }
        /// <summary>
        /// List of hashes of processes to collect context data.
        /// Empty implies all processes.
        /// </summary>
        [JsonProperty(PropertyName = "context_process_hashes")]
        public IList<string> ContextProcessHashes { get; set; }
        /// <summary>
        /// Enable NSX-Intelligence data collection in host nodes.
        /// 
        /// This property has been deprecated.
        /// To enable flow data collection,
        /// use property enable_flow_data_collection instead.
        /// To enable context data collection,
        /// use property enable_context_data_collection instead.
        /// 
        /// When this property is set to false, no data collection
        /// is performed even if enable_flow_data_collection or
        /// enable_context_data_collection is set to true.
        /// 
        /// When this property is set to true, property
        /// enable_flow_data_collection and enable_context_data_collection
        /// control whether to collect flow data and context data separately.
        /// </summary>
        [JsonProperty(PropertyName = "enable_data_collection")]
        public bool? EnableDataCollection { get; set; }
        /// <summary>
        /// When this property is set to true, if the source or destination
        /// of network traffic uses an IP address that is not included in
        /// property private_ip_prefix, it is reported as ANY (255.255.255.255)
        /// to NSX-Intelligence.
        /// 
        /// When this property is set to false, the original IP addresses of
        /// network traffic are reported to NSX-Intelligence,
        /// regardless whether they are included in property private_ip_prefix.
        /// </summary>
        [JsonProperty(PropertyName = "enable_external_ip_aggregation")]
        public bool? EnableExternalIpAggregation { get; set; }
        /// <summary>
        /// List of processes to collect context data.
        /// Empty implies all processes.
        /// </summary>
        [JsonProperty(PropertyName = "context_process_names")]
        public IList<string> ContextProcessNames { get; set; }
        /// <summary>
        /// List of NSX-Intelligence broker endpoints that host nodes contact initially.
        /// </summary>
        [JsonProperty(PropertyName = "broker_bootstrap_servers")]
        public IList<NSXTIntelligenceBrokerEndpointInfoType> BrokerBootstrapServers { get; set; }
        /// <summary>
        /// Maximum inactive network flow to collect in collection interval for Bare Metal server.
        /// </summary>
        [JsonProperty(PropertyName = "max_inactive_flow_count_bm")]
        public long? MaxInactiveFlowCountBm { get; set; }
        /// <summary>
        /// Maximum inactive network flow to collect in collection interval.
        /// </summary>
        [JsonProperty(PropertyName = "max_inactive_flow_count")]
        public long? MaxInactiveFlowCount { get; set; }
        /// <summary>
        /// List of private IP prefix that NSX-Intelligence network flow
        /// is collected from.
        /// </summary>
        [JsonProperty(PropertyName = "private_ip_prefix")]
        public IList<NSXTIntelligenceFlowPrivateIpPrefixInfoType> PrivateIpPrefix { get; set; }
        /// <summary>
        /// Maximum active network flow to collect in collection interval.
        /// </summary>
        [JsonProperty(PropertyName = "max_active_flow_count")]
        public long? MaxActiveFlowCount { get; set; }
    }
}
