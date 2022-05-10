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
    /// Advanced load balancer DnsAttack object
    /// </summary>
    [NSXTProperty(Description: @"Advanced load balancer DnsAttack object")]
    public class NSXTALBDnsAttackType 
    {
        /// <summary>
        /// Threshold, in terms of DNS packet per second, for the DNS
        /// attack vector.
        /// </summary>
        [JsonProperty(PropertyName = "threshold")]
        public long? Threshold { get; set; }
        /// <summary>
        /// Time in minutes after which mitigation will be deactivated.
        /// Allowed values are 1-4294967295.
        /// Special values are 0- 'blocked for ever'.
        /// Unit is MIN.
        /// Default value when not specified in API or module is
        /// interpreted by ALB Controller as 60.
        /// </summary>
        [JsonProperty(PropertyName = "max_mitigation_age")]
        public long? MaxMitigationAge { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [JsonProperty(PropertyName = "mitigation_action")]
        public NSXTALBAttackMitigationActionType MitigationAction { get; set; }
        /// <summary>
        /// Enable or disable the mitigation of the attack vector.
        /// Default value when not specified in API or module is
        /// interpreted by ALB Controller as true.
        /// </summary>
        [JsonProperty(PropertyName = "enabled")]
        public bool? Enabled { get; set; }
        /// <summary>
        /// The DNS attack vector.
        /// Enum options - DNS_REFLECTION, DNS_NXDOMAIN,
        /// DNS_AMPLIFICATION_EGRESS.
        /// </summary>
        [JsonProperty(PropertyName = "attack_vector", Required = Required.AllowNull)]
        [JsonConverter(typeof(StringEnumConverter))]
        public NSXTAlbdnsAttackAttackVectorEnumType AttackVector { get; set; }
    }
}
