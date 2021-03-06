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
    /// Advanced load balancer DnsRrSet object
    /// </summary>
    [NSXTProperty(Description: @"Advanced load balancer DnsRrSet object")]
    public class NSXTALBDnsRrSetType 
    {
        /// <summary>
        /// 
        /// </summary>
        [JsonProperty(PropertyName = "cname")]
        public NSXTALBDnsCnameRdataType Cname { get; set; }
        /// <summary>
        /// Time To Live for this DNS record.
        /// Allowed values are 0-2147483647.
        /// </summary>
        [JsonProperty(PropertyName = "ttl", Required = Required.AllowNull)]
        public long Ttl { get; set; }
        /// <summary>
        /// IP address in A record.
        /// </summary>
        [JsonProperty(PropertyName = "ip_addresses")]
        public IList<NSXTALBDnsARdataType> IpAddresses { get; set; }
        /// <summary>
        /// IPv6 address in AAAA record.
        /// </summary>
        [JsonProperty(PropertyName = "ip6_addresses")]
        public IList<NSXTALBDnsAAAARdataType> Ip6Addresses { get; set; }
        /// <summary>
        /// DNS record type.
        /// Enum options - DNS_RECORD_OTHER, DNS_RECORD_A,
        /// DNS_RECORD_NS, DNS_RECORD_CNAME, DNS_RECORD_SOA,
        /// DNS_RECORD_PTR, DNS_RECORD_HINFO, DNS_RECORD_MX,
        /// DNS_RECORD_TXT, DNS_RECORD_RP, DNS_RECORD_DNSKEY,
        /// DNS_RECORD_AAAA, DNS_RECORD_SRV, DNS_RECORD_OPT,
        /// DNS_RECORD_RRSIG, DNS_RECORD_AXFR, DNS_RECORD_ANY.
        /// </summary>
        [JsonProperty(PropertyName = "type", Required = Required.AllowNull)]
        [JsonConverter(typeof(StringEnumConverter))]
        public NSXTAlbdnsRrSetTypeEnumType Type { get; set; }
        /// <summary>
        /// Fully Qualified Domain Name.
        /// </summary>
        [JsonProperty(PropertyName = "fqdn", Required = Required.AllowNull)]
        public string Fqdn { get; set; }
        /// <summary>
        /// Name Server information in NS record.
        /// </summary>
        [JsonProperty(PropertyName = "nses")]
        public IList<NSXTALBDnsNsRdataType> Nses { get; set; }
    }
}
