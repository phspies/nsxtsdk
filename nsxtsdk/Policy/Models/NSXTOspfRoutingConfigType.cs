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

namespace nsxtsdk.PolicyModels
{
    /// <summary>
    /// 
    /// </summary>
    [NSXTProperty(Description: @"")]
    public class NSXTOspfRoutingConfigType : NSXTPolicyConfigResourceType
    {
        public NSXTOspfRoutingConfigType()
        {
            GracefulRestartMode = test
            Ecmp = test
        }
        /// <summary>
        /// List of summary address configruation to summarize or filter external routes based on the
        /// setting of advertise flag in each OspfSummaryAddressConfig
        /// </summary>
        [JsonProperty(PropertyName = "summary_addresses")]
        [NSXTProperty(IsRequired: false, Description: @"List of summary address configruation to summarize or filter external routes based on thesetting of advertise flag in each OspfSummaryAddressConfig")]
        public IList<NSXTOspfSummaryAddressConfigType> SummaryAddresses { get; set; }
        /// <summary>
        /// Flag to enable/disable advertisement of default route into OSPF domain.
        /// The default route should be present in the edge only then it redistributes the
        /// same into OSPF domain only if this flag is set to TRUE.
        /// </summary>
        [JsonProperty(PropertyName = "default_originate")]
        [NSXTProperty(IsRequired: false, Description: @"Flag to enable/disable advertisement of default route into OSPF domain.The default route should be present in the edge only then it redistributes thesame into OSPF domain only if this flag is set to TRUE.")]
        public bool? DefaultOriginate { get; set; }
        /// <summary>
        /// Configuration field to hold OSPF Restart mode .
        /// </summary>
        [JsonProperty(PropertyName = "graceful_restart_mode")]
        [NSXTProperty(IsRequired: false, Description: @"Configuration field to hold OSPF Restart mode .")]
        public NSXTOspfRoutingConfigGracefulRestartModeEnumType? GracefulRestartMode { get; set; }
        /// <summary>
        /// Flag to enable OSPF routing protocol. Disabling will stop feature and
        /// OSPF peering.
        /// </summary>
        [JsonProperty(PropertyName = "enabled")]
        [NSXTProperty(IsRequired: false, Description: @"Flag to enable OSPF routing protocol. Disabling will stop feature andOSPF peering.")]
        public bool? Enabled { get; set; }
        /// <summary>
        /// Flag to enable ECMP.
        /// </summary>
        [JsonProperty(PropertyName = "ecmp")]
        [NSXTProperty(IsRequired: false, Description: @"Flag to enable ECMP.")]
        public bool? Ecmp { get; set; }
    }
}
