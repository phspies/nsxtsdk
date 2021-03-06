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
    public class NSXTIPFIXL2ProfileType : NSXTPolicyConfigResourceType
    {
        /// <summary>
        /// This priority field is used to resolve conflicts in Segment
        /// Ports which are covered by more than one IPFIX profiles. The IPFIX
        /// exporter will send records to Collectors in highest priority
        /// profile (lowest number) only.
        /// </summary>
        [JsonProperty(PropertyName = "priority")]
        public int? Priority { get; set; }
        /// <summary>
        /// The time in seconds after a flow is expired if
        /// no more packets matching this flow are received by the cache.
        /// </summary>
        [JsonProperty(PropertyName = "idle_timeout")]
        public int? IdleTimeout { get; set; }
        /// <summary>
        /// Policy path for IPFIX collector profile. User can specify only one IPFIX collector.
        /// </summary>
        [JsonProperty(PropertyName = "ipfix_collector_profile_path", Required = Required.AllowNull)]
        public string IpfixCollectorProfilePath { get; set; }
        /// <summary>
        /// The maximum number of flow entries in
        /// each exporter flow cache.
        /// </summary>
        [JsonProperty(PropertyName = "max_flows")]
        public long? MaxFlows { get; set; }
        /// <summary>
        /// An identifier that is unique to the exporting process and used to
        /// meter the flows.
        /// </summary>
        [JsonProperty(PropertyName = "observation_domain_id")]
        public long? ObservationDomainId { get; set; }
        /// <summary>
        /// The time in seconds after a flow is expired even if
        /// more packets matching this flow are received by the cache.
        /// </summary>
        [JsonProperty(PropertyName = "active_timeout")]
        public int? ActiveTimeout { get; set; }
        /// <summary>
        /// This property controls whether overlay flow info is included in the
        /// sample result.
        /// </summary>
        [JsonProperty(PropertyName = "export_overlay_flow")]
        public bool? ExportOverlayFlow { get; set; }
        /// <summary>
        /// The probability in percentage that a packet is sampled,
        /// in range 0-100. The probability is equal for every packet.
        /// </summary>
        [JsonProperty(PropertyName = "packet_sample_probability", Required = Required.AllowNull)]
        public double PacketSampleProbability { get; set; }
    }
}
