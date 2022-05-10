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
    public class NSXTOspfRoutingConfigType : NSXTPolicyConfigResourceType
    {
        /// <summary>
        /// List of summary address configruation to summarize or filter external routes based on the
        /// setting of advertise flag in each OspfSummaryAddressConfig
        /// </summary>
        [JsonProperty(PropertyName = "summary_addresses")]
        public IList<NSXTOspfSummaryAddressConfigType> SummaryAddresses { get; set; }
        /// <summary>
        /// Flag to enable/disable advertisement of default route into OSPF domain.
        /// The default route should be present in the edge only then it redistributes the
        /// same into OSPF domain only if this flag is set to TRUE.
        /// </summary>
        [JsonProperty(PropertyName = "default_originate")]
        public bool? DefaultOriginate { get; set; }
        /// <summary>
        /// Configuration field to hold OSPF Restart mode .
        /// </summary>
        [JsonProperty(PropertyName = "graceful_restart_mode")]
        [JsonConverter(typeof(StringEnumConverter))]
        public NSXTOspfRoutingConfigGracefulRestartModeEnumType? GracefulRestartMode { get; set; }
        /// <summary>
        /// Flag to enable OSPF routing protocol. Disabling will stop feature and
        /// OSPF peering.
        /// </summary>
        [JsonProperty(PropertyName = "enabled")]
        public bool? Enabled { get; set; }
        /// <summary>
        /// Flag to enable ECMP.
        /// </summary>
        [JsonProperty(PropertyName = "ecmp")]
        public bool? Ecmp { get; set; }
    }
}
