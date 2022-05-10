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
    /// Each cluster node entity provides multiple services. When working in a group, each service can elect a cluster node
        /// entity to be the leader of the service. Leader election helps in coordination of the service. The leader holds a
        /// renewable lease on the leadership for a fixed period of time. The lease version is incremented every time the leadership
        /// lease is renewed. This type contains the attributes of a leader.
    /// </summary>
    [NSXTProperty(Description: @"Each cluster node entity provides multiple services. When working in a group, each service can elect a cluster node entity to be the leader of the service. Leader election helps in coordination of the service. The leader holds a renewable lease on the leadership for a fixed period of time. The lease version is incremented every time the leadership lease is renewed. This type contains the attributes of a leader.")]
    public class NSXTClusterGroupServiceLeaderType 
    {
        /// <summary>
        /// Name of the service
        /// </summary>
        [JsonProperty(PropertyName = "service_name")]
        public string? ServiceName { get; set; }
        /// <summary>
        /// Number of times the lease has been renewed
        /// </summary>
        [JsonProperty(PropertyName = "lease_version")]
        public long? LeaseVersion { get; set; }
        /// <summary>
        /// Member UUID of the leader
        /// </summary>
        [JsonProperty(PropertyName = "leader_uuid")]
        public string? LeaderUuid { get; set; }
    }
}
