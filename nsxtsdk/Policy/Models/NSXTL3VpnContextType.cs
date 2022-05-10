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
    public class NSXTL3VpnContextType : NSXTPolicyConfigResourceType
    {
        /// <summary>
        /// Log level for internet key exchange (IKE).
        /// </summary>
        [JsonProperty(PropertyName = "ike_log_level")]
        [JsonConverter(typeof(StringEnumConverter))]
        public NSXTL3VpnContextIkeLogLevelEnumType? IkeLogLevel { get; set; }
        /// <summary>
        /// If true, enable L3Vpn Service for given tier-0. Enabling/disabling this
        /// service affects all L3Vpns under the given tier-0.
        /// </summary>
        [JsonProperty(PropertyName = "enabled")]
        public bool? Enabled { get; set; }
        /// <summary>
        /// Bypass L3Vpn rules that will be shared across L3Vpns. Only Bypass action is
        /// supported on these L3Vpn rules.
        /// </summary>
        [JsonProperty(PropertyName = "bypass_rules")]
        public IList<NSXTL3VpnRuleType> BypassRules { get; set; }
        /// <summary>
        /// Local gateway IPv4 addresses available for configuration of each L3Vpn.
        /// </summary>
        [JsonProperty(PropertyName = "available_local_addresses")]
        public IList<NSXTPolicyIPAddressInfoType> AvailableLocalAddresses { get; set; }
        /// <summary>
        /// Policy path referencing Label. A label is used as a mechanism to group
        /// route-based L3Vpns in order to apply edge firewall rules on members' VTIs.
        /// </summary>
        [JsonProperty(PropertyName = "label")]
        public string? Label { get; set; }
    }
}
