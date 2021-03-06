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
    public class NSXTIpfixSwitchUpmProfileType : NSXTIpfixUpmProfileType
    {
        /// <summary>
        /// This priority field is used to resolve conflicts in logical ports/switch
        /// which inherit multiple switch IPFIX profiles from NSGroups.
        /// 
        /// Override rule is : for multiple profiles inherited from NSGroups, the
        /// one with highest priority (lowest number) overrides others; the profile
        /// directly applied to logical switch overrides profiles inherited from
        /// NSGroup; the profile directly applied to logical port overides profiles
        /// inherited from logical switch and/or nsgroup;
        /// 
        /// The IPFIX exporter will send records to collectors of final effective
        /// profile only.
        /// </summary>
        [JsonProperty(PropertyName = "priority", Required = Required.AllowNull)]
        public int Priority { get; set; }
        /// <summary>
        /// Each IPFIX switching profile can have its own collector profile.
        /// </summary>
        [JsonProperty(PropertyName = "collector_profile", Required = Required.AllowNull)]
        public string CollectorProfile { get; set; }
        /// <summary>
        /// The time in seconds after a flow is expired if no more packets matching
        /// this flow are received by the cache.
        /// </summary>
        [JsonProperty(PropertyName = "idle_timeout")]
        public int? IdleTimeout { get; set; }
        /// <summary>
        /// The maximum number of flow entries in each exporter flow cache.
        /// </summary>
        [JsonProperty(PropertyName = "max_flows")]
        public long? MaxFlows { get; set; }
        /// <summary>
        /// An identifier that is unique to the exporting process and used to
        /// meter the Flows.
        /// </summary>
        [JsonProperty(PropertyName = "observation_domain_id", Required = Required.AllowNull)]
        public long ObservationDomainId { get; set; }
        /// <summary>
        /// The time in seconds after a flow is expired even if more packets
        /// matching this Flow are received by the cache.
        /// </summary>
        [JsonProperty(PropertyName = "active_timeout")]
        public int? ActiveTimeout { get; set; }
        /// <summary>
        /// It controls whether sample result includes overlay flow info.
        /// </summary>
        [JsonProperty(PropertyName = "export_overlay_flow")]
        public bool? ExportOverlayFlow { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [JsonProperty(PropertyName = "applied_tos")]
        public NSXTAppliedTosType AppliedTos { get; set; }
        /// <summary>
        /// The probability in percentage that a packet is sampled. The value should be
        /// in range (0,100] and can only have three decimal places at most. The probability
        /// is equal for every packet.
        /// </summary>
        [JsonProperty(PropertyName = "packet_sample_probability")]
        public double? PacketSampleProbability { get; set; }
    }
}
