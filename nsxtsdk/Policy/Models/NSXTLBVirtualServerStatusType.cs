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
    public class NSXTLBVirtualServerStatusType : NSXTLBVirtualServerStatusPerEPType
    {
        /// <summary>
        /// UP means that all primary members in default pool are in UP status.
        /// For L7 virtual server, if there is no default pool, the virtual server
        /// would be treated as UP.
        /// PARTIALLY_UP means that some(not all) primary members in default pool
        /// are in UP status. The size of these active primary members should be
        /// larger than or equal to the certain number(min_active_members) which is
        /// defined in LBPool. When there are no backup members which are in the UP
        /// status, the number(min_active_members) would be ignored.
        /// PRIMARY_DOWN means that less than certain(min_active_members) primary
        /// members in default pool are in UP status but backup members are in UP
        /// status, the connections would be dispatched to backup members.
        /// DOWN means that all primary and backup members are in DOWN status.
        /// DETACHED means that the virtual server is not bound to any service.
        /// DISABLED means that the admin state of the virtual server is disabled.
        /// UNKOWN means that no status reported from transport-nodes. The
        /// associated load balancer service may be working(or not working).
        /// </summary>
        [JsonProperty(PropertyName = "status")]
        [JsonConverter(typeof(StringEnumConverter))]
        public NSXTLbvirtualServerStatusStatusEnumType? Status { get; set; }
        /// <summary>
        /// Timestamp when the data was last updated.
        /// </summary>
        [JsonProperty(PropertyName = "last_update_timestamp")]
        public long? LastUpdateTimestamp { get; set; }
        /// <summary>
        /// load balancer virtual server object path.
        /// </summary>
        [JsonProperty(PropertyName = "virtual_server_path")]
        public string? VirtualServerPath { get; set; }
    }
}
