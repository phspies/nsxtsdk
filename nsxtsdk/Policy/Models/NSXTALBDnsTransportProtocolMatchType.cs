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
        [JsonConverter(typeof(StringEnumConverter))]
        public NSXTAlbdnsTransportProtocolMatchProtocolEnumType Protocol { get; set; }
        /// <summary>
        /// Criterion to use for matching the DNS transport protocol.
        /// Enum options - IS_IN, IS_NOT_IN.
        /// </summary>
        [JsonProperty(PropertyName = "match_criteria", Required = Required.AllowNull)]
        [JsonConverter(typeof(StringEnumConverter))]
        public NSXTAlbdnsTransportProtocolMatchMatchCriteriaEnumType MatchCriteria { get; set; }
    }
}
