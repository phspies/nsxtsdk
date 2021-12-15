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
    /// Advanced load balancer DnsTransportProtocolMatch object
    /// </summary>
    [NSXTProperty(Description: @"Advanced load balancer DnsTransportProtocolMatch object")]
    public class NSXTALBDnsTransportProtocolMatchType 
    {
        /// <summary>
        /// Protocol to match against transport protocol used by DNS
        /// query.
        /// Enum options - DNS_OVER_UDP, DNS_OVER_TCP.
        /// </summary>
        [JsonProperty(PropertyName = "protocol", Required = Required.AllowNull)]
        [NSXTProperty(IsRequired: true, Description: @"Protocol to match against transport protocol used by DNSquery.Enum options - DNS_OVER_UDP, DNS_OVER_TCP.")]
        [System.ComponentModel.DataAnnotations.Required]
        public NSXTAlbdnsTransportProtocolMatchProtocolEnumType Protocol { get; set; }
        /// <summary>
        /// Criterion to use for matching the DNS transport protocol.
        /// Enum options - IS_IN, IS_NOT_IN.
        /// </summary>
        [JsonProperty(PropertyName = "match_criteria", Required = Required.AllowNull)]
        [NSXTProperty(IsRequired: true, Description: @"Criterion to use for matching the DNS transport protocol.Enum options - IS_IN, IS_NOT_IN.")]
        [System.ComponentModel.DataAnnotations.Required]
        public NSXTAlbdnsTransportProtocolMatchMatchCriteriaEnumType MatchCriteria { get; set; }
    }
}