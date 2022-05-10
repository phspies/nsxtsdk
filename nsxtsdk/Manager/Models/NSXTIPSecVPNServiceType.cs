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
    public class NSXTIPSecVPNServiceType : NSXTManagedResourceType
    {
        /// <summary>
        /// Log level for internet key exchange (IKE).
        /// </summary>
        [JsonProperty(PropertyName = "ike_log_level")]
        [JsonConverter(typeof(StringEnumConverter))]
        public NSXTIpsecVpnserviceIkeLogLevelEnumType? IkeLogLevel { get; set; }
        /// <summary>
        /// Logical router id.
        /// </summary>
        [JsonProperty(PropertyName = "logical_router_id", Required = Required.AllowNull)]
        public string LogicalRouterId { get; set; }
        /// <summary>
        /// Enable/disable IPSec HA state sync. IPSec HA state sync
        /// can be disabled in case there are performance issues with
        /// the state sync messages. Default is to enable HA Sync.
        /// </summary>
        [JsonProperty(PropertyName = "ipsec_ha_sync")]
        public bool? IpsecHaSync { get; set; }
        /// <summary>
        /// Bypass policy rules are configured using VPN service.
        /// Bypass rules always have higher priority over protect
        /// rules and they affect all policy based vpn sessions associated
        /// with the IPSec VPN service. Protect rules are defined per
        /// policy based vpn session.
        /// </summary>
        [JsonProperty(PropertyName = "bypass_rules")]
        public IList<NSXTIPSecVPNPolicyRuleType> BypassRules { get; set; }
        /// <summary>
        /// If true, enable VPN services for given logical router.
        /// </summary>
        [JsonProperty(PropertyName = "enabled")]
        public bool? Enabled { get; set; }
    }
}
