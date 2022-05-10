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
    public class NSXTEdgeHighAvailabilityProfileType : NSXTClusterProfileType
    {
        /// <summary>
        /// 
        /// </summary>
        [JsonProperty(PropertyName = "standby_relocation_config")]
        public NSXTStandbyRelocationConfigType StandbyRelocationConfig { get; set; }
        /// <summary>
        /// Number of times a packet is missed before BFD declares the neighbor down.
        /// </summary>
        [JsonProperty(PropertyName = "bfd_declare_dead_multiple")]
        public long? BfdDeclareDeadMultiple { get; set; }
        /// <summary>
        /// the time interval (in millisec) between probe packets for heartbeat purpose
        /// </summary>
        [JsonProperty(PropertyName = "bfd_probe_interval")]
        public long? BfdProbeInterval { get; set; }
        /// <summary>
        /// BFD allowed hops
        /// </summary>
        [JsonProperty(PropertyName = "bfd_allowed_hops")]
        public long? BfdAllowedHops { get; set; }
    }
}
