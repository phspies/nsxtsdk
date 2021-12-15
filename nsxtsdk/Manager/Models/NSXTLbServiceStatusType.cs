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
    public class NSXTLbServiceStatusType 
    {
        /// <summary>
        /// Cpu usage in percentage
        /// </summary>
        [JsonProperty(PropertyName = "cpu_usage")]
        [NSXTProperty(IsRequired: false, Description: @"Cpu usage in percentage")]
        public long? CpuUsage { get; set; }
        /// <summary>
        /// Memory usage in percentage
        /// </summary>
        [JsonProperty(PropertyName = "memory_usage")]
        [NSXTProperty(IsRequired: false, Description: @"Memory usage in percentage")]
        public long? MemoryUsage { get; set; }
        /// <summary>
        /// Timestamp when the data was last updated
        /// </summary>
        [JsonProperty(PropertyName = "last_update_timestamp")]
        [NSXTProperty(IsRequired: false, Description: @"Timestamp when the data was last updated")]
        public long? LastUpdateTimestamp { get; set; }
        /// <summary>
        /// Error message, if available
        /// </summary>
        [JsonProperty(PropertyName = "error_message")]
        [NSXTProperty(IsRequired: false, Description: @"Error message, if available")]
        public string? ErrorMessage { get; set; }
        /// <summary>
        /// Ids of load balancer service related standby transport nodes
        /// </summary>
        [JsonProperty(PropertyName = "standby_transport_nodes")]
        [NSXTProperty(IsRequired: false, Description: @"Ids of load balancer service related standby transport nodes")]
        public IList<string> StandbyTransportNodes { get; set; }
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
        [NSXTProperty(IsRequired: false, Description: @"UP means the load balancer service is working fine on bothtransport-nodes(if have);PARTIALLY_UP means that some DLB instances on transport node areworking successfully and some instances are not working successfully;DOWN means the load balancer service is down on both transport-nodes(if have), hence the load balancer will not respond to any requests;ERROR means error happens on transport-node(s) or no status isreported from transport-node(s). The load balancer service may beworking (or not working);NO_STANDBY means load balancer service is working in one of thetransport node while not in the other transport-node (if have). Henceif the load balancer service in the working transport-node goes down,the load balancer service will go down;DETACHED means that the load balancer service has no attachment settingand is not instantiated in any transport nodes;DISABLED means that admin state of load balancer service is DISABLED;UNKNOWN means that no status reported from transport-nodes.The loadbalancer service may be working(or not working).")]
        public NSXTLbServiceStatusServiceStatusEnumType? ServiceStatus { get; set; }
        /// <summary>
        /// status of load balancer virtual servers
        /// </summary>
        [JsonProperty(PropertyName = "virtual_servers")]
        [NSXTProperty(IsRequired: false, Description: @"status of load balancer virtual servers")]
        public IList<NSXTLbVirtualServerStatusType> VirtualServers { get; set; }
        /// <summary>
        /// Ids of load balancer service related active transport nodes
        /// </summary>
        [JsonProperty(PropertyName = "active_transport_nodes")]
        [NSXTProperty(IsRequired: false, Description: @"Ids of load balancer service related active transport nodes")]
        public IList<string> ActiveTransportNodes { get; set; }
        /// <summary>
        /// Details of load balancer service instance per transport node.
        /// </summary>
        [JsonProperty(PropertyName = "instance_detail_per_tn")]
        [NSXTProperty(IsRequired: false, Description: @"Details of load balancer service instance per transport node.")]
        public IList<NSXTLbServiceInstanceDetailPerTransportNodeType> InstanceDetailPerTn { get; set; }
        /// <summary>
        /// status of load balancer pools
        /// </summary>
        [JsonProperty(PropertyName = "pools")]
        [NSXTProperty(IsRequired: false, Description: @"status of load balancer pools")]
        public IList<NSXTLbPoolStatusType> Pools { get; set; }
        /// <summary>
        /// Load balancer service identifier
        /// </summary>
        [JsonProperty(PropertyName = "service_id", Required = Required.AllowNull)]
        [NSXTProperty(IsRequired: true, Description: @"Load balancer service identifier")]
        [System.ComponentModel.DataAnnotations.Required]
        public string ServiceId { get; set; }
    }
}
