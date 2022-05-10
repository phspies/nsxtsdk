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
    /// Pool member.
    /// </summary>
    [NSXTProperty(Description: @"Pool member.")]
    public class NSXTLBPoolMemberType 
    {
        /// <summary>
        /// To ensure members are not overloaded, connections to a member can be
        /// capped by the load balancer. When a member reaches this limit, it is
        /// skipped during server selection.
        /// If it is not specified, it means that connections are unlimited.
        /// </summary>
        [JsonProperty(PropertyName = "max_concurrent_connections")]
        public long? MaxConcurrentConnections { get; set; }
        /// <summary>
        /// Member admin state.
        /// </summary>
        [JsonProperty(PropertyName = "admin_state")]
        [JsonConverter(typeof(StringEnumConverter))]
        public NSXTLbpoolMemberAdminStateEnumType? AdminState { get; set; }
        /// <summary>
        /// Backup servers are typically configured with a sorry page indicating to
        /// the user that the application is currently unavailable. While the pool
        /// is active (a specified minimum number of pool members are active)
        /// BACKUP members are skipped during server selection. When the pool is
        /// inactive, incoming connections are sent to only the BACKUP member(s).
        /// </summary>
        [JsonProperty(PropertyName = "backup_member")]
        public bool? BackupMember { get; set; }
        /// <summary>
        /// Pool member weight is used for WEIGHTED_ROUND_ROBIN balancing
        /// algorithm. The weight value would be ignored in other algorithms.
        /// </summary>
        [JsonProperty(PropertyName = "weight")]
        public long? Weight { get; set; }
        /// <summary>
        /// Pool member name.
        /// </summary>
        [JsonProperty(PropertyName = "display_name")]
        public string? DisplayName { get; set; }
        /// <summary>
        /// Pool member IP address.
        /// </summary>
        [JsonProperty(PropertyName = "ip_address", Required = Required.AllowNull)]
        public string IpAddress { get; set; }
        /// <summary>
        /// If port is specified, all connections will be sent to this port. Only
        /// single port is supported.
        /// If unset, the same port the client connected to will be used, it could
        /// be overrode by default_pool_member_port setting in virtual server.
        /// The port should not specified for port range case.
        /// </summary>
        [JsonProperty(PropertyName = "port")]
        public string? Port { get; set; }
    }
}
