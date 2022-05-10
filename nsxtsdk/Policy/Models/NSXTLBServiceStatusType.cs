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
    public class NSXTLBServiceStatusType : NSXTLBServiceStatusPerEPType
    {
        /// <summary>
        /// Cpu usage in percentage.
        /// </summary>
        [JsonProperty(PropertyName = "cpu_usage")]
        public long? CpuUsage { get; set; }
        /// <summary>
        /// Memory usage in percentage.
        /// </summary>
        [JsonProperty(PropertyName = "memory_usage")]
        public long? MemoryUsage { get; set; }
        /// <summary>
        /// Timestamp when the data was last updated.
        /// </summary>
        [JsonProperty(PropertyName = "last_update_timestamp")]
        public long? LastUpdateTimestamp { get; set; }
        /// <summary>
        /// Error message, if available.
        /// </summary>
        [JsonProperty(PropertyName = "error_message")]
        public string? ErrorMessage { get; set; }
        /// <summary>
        /// UP means the load balancer service is working fine on both
        /// transport-nodes(if have);
        /// PARTIALLY_UP means that some DLB instances on transport node are
        /// working successfully and some instances are not working successfully;
        /// DOWN means the load balancer service is down on both transport-nodes
        /// (if have), hence the load balancer will not respond to any requests;
        /// ERROR means error happens on transport-node(s) or no status is
        /// reported from transport-node(s). The load balancer service may be
        /// working (or not working);
        /// NO_STANDBY means load balancer service is working in one of the
        /// transport node while not in the other transport-node (if have). Hence
        /// if the load balancer service in the working transport-node goes down,
        /// the load balancer service will go down;
        /// DETACHED means that the load balancer service has no attachment setting
        /// and is not instantiated in any transport nodes;
        /// DISABLED means that admin state of load balancer service is DISABLED;
        /// UNKNOWN means that no status reported from transport-nodes.The load
        /// balancer service may be working(or not working).
        /// </summary>
        [JsonProperty(PropertyName = "service_status")]
        [JsonConverter(typeof(StringEnumConverter))]
        public NSXTLbserviceStatusServiceStatusEnumType? ServiceStatus { get; set; }
        /// <summary>
        /// status of load balancer virtual servers.
        /// </summary>
        [JsonProperty(PropertyName = "virtual_servers")]
        public IList<NSXTLBVirtualServerStatusType> VirtualServers { get; set; }
        /// <summary>
        /// Ids of load balancer service related active transport nodes.
        /// </summary>
        [JsonProperty(PropertyName = "active_transport_nodes")]
        public IList<string> ActiveTransportNodes { get; set; }
        /// <summary>
        /// Details of load balancer service instance per transport node.
        /// </summary>
        [JsonProperty(PropertyName = "instance_detail_per_tn")]
        public IList<NSXTLBServiceInstanceDetailPerTransportNodeType> InstanceDetailPerTn { get; set; }
        /// <summary>
        /// status of load balancer pools.
        /// </summary>
        [JsonProperty(PropertyName = "pools")]
        public IList<NSXTLBPoolStatusType> Pools { get; set; }
        /// <summary>
        /// Ids of load balancer service related standby transport nodes.
        /// </summary>
        [JsonProperty(PropertyName = "standby_transport_nodes")]
        public IList<string> StandbyTransportNodes { get; set; }
        /// <summary>
        /// Load balancer service object path.
        /// </summary>
        [JsonProperty(PropertyName = "service_path")]
        public string? ServicePath { get; set; }
    }
}
