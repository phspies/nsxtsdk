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
    public class NSXTIPFIXDFWProfileType : NSXTPolicyConfigResourceType
    {
        /// <summary>
        /// Policy path for IPFIX collector profiles. IPFIX data from
        /// these logical segments will be sent to all specified IPFIX
        /// collectors.
        /// </summary>
        [JsonProperty(PropertyName = "ipfix_dfw_collector_profile_path", Required = Required.AllowNull)]
        public string IpfixDfwCollectorProfilePath { get; set; }
        /// <summary>
        /// This priority field is used to resolve conflicts in Segment
        /// Ports which are covered by more than one IPFIX profiles. The IPFIX
        /// exporter will send records to Collectors in highest priority
        /// profile (lowest number) only.
        /// </summary>
        [JsonProperty(PropertyName = "priority")]
        public int? Priority { get; set; }
        /// <summary>
        /// For long standing active flows, IPFIX records will be sent
        /// per timeout period in minutes.
        /// </summary>
        [JsonProperty(PropertyName = "active_flow_export_timeout", Required = Required.AllowNull)]
        public int ActiveFlowExportTimeout { get; set; }
        /// <summary>
        /// An identifier that is unique to the exporting process
        /// and used to meter the flows.
        /// </summary>
        [JsonProperty(PropertyName = "observation_domain_id")]
        public int? ObservationDomainId { get; set; }
    }
}
