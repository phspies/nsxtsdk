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
    public class NSXTLBPoolStatusType : NSXTLBPoolStatusPerEPType
    {
        /// <summary>
        /// UP means that all primary members are in UP status.
        /// PARTIALLY_UP means that some(not all) primary members are in UP
        /// status, the number of these active members is larger or equal to
        /// certain number(min_active_members) which is defined in LBPool.
        /// When there are no backup members which are in the UP status, the
        /// number(min_active_members) would be ignored.
        /// PRIMARY_DOWN means that less than certain(min_active_members) primary
        /// members are in UP status but backup members are in UP status,
        /// connections to this pool would be dispatched to backup members.
        /// DOWN means that all primary and backup members are DOWN.
        /// DETACHED means that the pool is not bound to any virtual server.
        /// UNKOWN means that no status reported from transport-nodes. The
        /// associated load balancer service may be working(or not working).
        /// </summary>
        [JsonProperty(PropertyName = "status")]
        [JsonConverter(typeof(StringEnumConverter))]
        public NSXTLbpoolStatusStatusEnumType? Status { get; set; }
        /// <summary>
        /// Timestamp when the data was last updated.
        /// </summary>
        [JsonProperty(PropertyName = "last_update_timestamp")]
        public long? LastUpdateTimestamp { get; set; }
        /// <summary>
        /// Load balancer pool object path.
        /// </summary>
        [JsonProperty(PropertyName = "pool_path")]
        public string? PoolPath { get; set; }
        /// <summary>
        /// Status of load balancer pool members.
        /// </summary>
        [JsonProperty(PropertyName = "members")]
        public IList<NSXTLBPoolMemberStatusType> Members { get; set; }
    }
}
