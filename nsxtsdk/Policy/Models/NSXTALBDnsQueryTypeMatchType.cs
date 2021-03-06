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
    /// Advanced load balancer DnsQueryTypeMatch object
    /// </summary>
    [NSXTProperty(Description: @"Advanced load balancer DnsQueryTypeMatch object")]
    public class NSXTALBDnsQueryTypeMatchType 
    {
        /// <summary>
        /// DNS query types in the request query.
        /// Enum options - DNS_RECORD_OTHER, DNS_RECORD_A,
        /// DNS_RECORD_NS, DNS_RECORD_CNAME, DNS_RECORD_SOA,
        /// DNS_RECORD_PTR, DNS_RECORD_HINFO, DNS_RECORD_MX,
        /// DNS_RECORD_TXT, DNS_RECORD_RP, DNS_RECORD_DNSKEY,
        /// DNS_RECORD_AAAA, DNS_RECORD_SRV, DNS_RECORD_OPT,
        /// DNS_RECORD_RRSIG, DNS_RECORD_AXFR, DNS_RECORD_ANY.
        /// </summary>
        [JsonProperty(PropertyName = "query_type")]
        public IList<string> QueryType { get; set; }
        /// <summary>
        /// Criterion to use for matching the DNS query typein the
        /// question section.
        /// Enum options - IS_IN, IS_NOT_IN.
        /// </summary>
        [JsonProperty(PropertyName = "match_criteria", Required = Required.AllowNull)]
        [JsonConverter(typeof(StringEnumConverter))]
        public NSXTAlbdnsQueryTypeMatchMatchCriteriaEnumType MatchCriteria { get; set; }
    }
}
