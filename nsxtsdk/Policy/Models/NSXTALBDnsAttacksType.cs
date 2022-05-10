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
    /// Advanced load balancer DnsAttacks object
    /// </summary>
    [NSXTProperty(Description: @"Advanced load balancer DnsAttacks object")]
    public class NSXTALBDnsAttacksType 
    {
        /// <summary>
        /// Mode of dealing with the attacks - perform detection only,
        /// or detect and mitigate the attacks.
        /// </summary>
        [JsonProperty(PropertyName = "attacks")]
        public IList<NSXTALBDnsAttackType> Attacks { get; set; }
        /// <summary>
        /// Mode of dealing with the attacks - perform detection only,
        /// or detect and mitigate the attacks.
        /// Enum options - DETECTION, MITIGATION.
        /// </summary>
        [JsonProperty(PropertyName = "oper_mode")]
        [JsonConverter(typeof(StringEnumConverter))]
        public NSXTAlbdnsAttacksOperModeEnumType? OperMode { get; set; }
    }
}
