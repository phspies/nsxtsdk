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
    public class NSXTIPSecVpnServiceType : NSXTPolicyConfigResourceType
    {
        /// <summary>
        /// Log level for internet key exchange (IKE).
        /// </summary>
        [JsonProperty(PropertyName = "ike_log_level")]
        [JsonConverter(typeof(StringEnumConverter))]
        public NSXTIpsecVpnServiceIkeLogLevelEnumType? IkeLogLevel { get; set; }
        /// <summary>
        /// Bypass policy rules are configured using VPN service.
        /// Bypass rules always have higher priority over protect
        /// rules and they affect all policy based vpn sessions associated
        /// with the IPSec VPN service. Protect rules are defined per
        /// policy based vpn session.
        /// </summary>
        [JsonProperty(PropertyName = "bypass_rules")]
        public IList<NSXTIPSecVpnRuleType> BypassRules { get; set; }
        /// <summary>
        /// Enable/disable IPSec HA state sync. IPSec HA state sync can be disabled if in case there are performance issues w.r.t.
        /// the state sync messages.
        /// </summary>
        [JsonProperty(PropertyName = "ha_sync")]
        public bool? HaSync { get; set; }
        /// <summary>
        /// If true, enable VPN services under tier-0/tier-1.
        /// </summary>
        [JsonProperty(PropertyName = "enabled")]
        public bool? Enabled { get; set; }
    }
}
