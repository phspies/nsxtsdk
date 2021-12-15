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
        [NSXTProperty(IsRequired: false, Description: @"Mode of dealing with the attacks - perform detection only,or detect and mitigate the attacks.")]
        public IList<NSXTALBDnsAttackType> Attacks { get; set; }
        /// <summary>
        /// Mode of dealing with the attacks - perform detection only,
        /// or detect and mitigate the attacks.
        /// Enum options - DETECTION, MITIGATION.
        /// </summary>
        [JsonProperty(PropertyName = "oper_mode")]
        [NSXTProperty(IsRequired: false, Description: @"Mode of dealing with the attacks - perform detection only,or detect and mitigate the attacks.Enum options - DETECTION, MITIGATION.")]
        public NSXTAlbdnsAttacksOperModeEnumType? OperMode { get; set; }
    }
}