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
    /// Advanced load balancer DnsRecord object
    /// </summary>
    [NSXTProperty(Description: @"Advanced load balancer DnsRecord object")]
    public class NSXTALBDnsRecordType 
    {
        /// <summary>
        /// Specifies the algorithm to pick the IP address(es) to be
        /// returned, when multiple entries are configured.
        /// This does not apply if num_records_in_response is 0.
        /// Default is round-robin.
        /// Enum options - DNS_RECORD_RESPONSE_ROUND_ROBIN,
        /// DNS_RECORD_RESPONSE_CONSISTENT_HASH.
        /// Default value when not specified in API or module is
        /// interpreted by ALB Controller as
        /// DNS_RECORD_RESPONSE_ROUND_ROBIN.
        /// </summary>
        [JsonProperty(PropertyName = "algorithm")]
        [JsonConverter(typeof(StringEnumConverter))]
        public NSXTAlbdnsRecordAlgorithmEnumType? Algorithm { get; set; }
        /// <summary>
        /// Details of DNS record.
        /// </summary>
        [JsonProperty(PropertyName = "description")]
        public string? Description { get; set; }
        /// <summary>
        /// Enable wild-card match of fqdn  if an exact match is not
        /// found in the DNS table, the longest match is chosen by
        /// wild-carding the fqdn in the DNS request.
        /// Default is false.
        /// Default value when not specified in API or module is
        /// interpreted by ALB Controller as false.
        /// </summary>
        [JsonProperty(PropertyName = "wildcard_match")]
        public bool? WildcardMatch { get; set; }
        /// <summary>
        /// Specifies the number of records returned by the DNS
        /// service.
        /// Enter 0 to return all records.
        /// Default is 0.
        /// Allowed values are 0-20.
        /// Special values are 0- 'Return all records'.
        /// Default value when not specified in API or module is
        /// interpreted by ALB Controller as 0.
        /// </summary>
        [JsonProperty(PropertyName = "num_records_in_response")]
        public long? NumRecordsInResponse { get; set; }
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
        public NSXTAlbdnsRecordTypeEnumType Type { get; set; }
        /// <summary>
        /// Fully Qualified Domain Name.
        /// Minimum of 1 items required.
        /// </summary>
        [JsonProperty(PropertyName = "fqdn", Required = Required.AllowNull)]
        public IList<string> Fqdn { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [JsonProperty(PropertyName = "cname")]
        public NSXTALBDnsCnameRdataType Cname { get; set; }
        /// <summary>
        /// Text record.
        /// Maximum of 4 items allowed.
        /// </summary>
        [JsonProperty(PropertyName = "txt_records")]
        public IList<NSXTALBDnsTxtRdataType> TxtRecords { get; set; }
        /// <summary>
        /// Service locator info in SRV record.
        /// Maximum of 4 items allowed.
        /// </summary>
        [JsonProperty(PropertyName = "service_locator")]
        public IList<NSXTALBDnsSrvRdataType> ServiceLocator { get; set; }
        /// <summary>
        /// Time To Live for this DNS record.
        /// </summary>
        [JsonProperty(PropertyName = "ttl")]
        public long? Ttl { get; set; }
        /// <summary>
        /// IPv6 address in AAAA record.
        /// Maximum of 4 items allowed.
        /// </summary>
        [JsonProperty(PropertyName = "ip6_address")]
        public IList<NSXTALBDnsAAAARdataType> Ip6Address { get; set; }
        /// <summary>
        /// Configured FQDNs are delegated domains (i.e.
        /// they represent a zone cut).
        /// Default value when not specified in API or module is
        /// interpreted by ALB Controller as false.
        /// </summary>
        [JsonProperty(PropertyName = "delegated")]
        public bool? Delegated { get; set; }
        /// <summary>
        /// Name Server information in NS record.
        /// Maximum of 13 items allowed.
        /// </summary>
        [JsonProperty(PropertyName = "ns")]
        public IList<NSXTALBDnsNsRdataType> Ns { get; set; }
        /// <summary>
        /// IP address in A record.
        /// Maximum of 4 items allowed.
        /// </summary>
        [JsonProperty(PropertyName = "ip_address")]
        public IList<NSXTALBDnsARdataType> IpAddress { get; set; }
        /// <summary>
        /// MX record.
        /// Maximum of 4 items allowed.
        /// </summary>
        [JsonProperty(PropertyName = "mx_records")]
        public IList<NSXTALBDnsMxRdataType> MxRecords { get; set; }
        /// <summary>
        /// Internal metadata for the DNS record.
        /// </summary>
        [JsonProperty(PropertyName = "metadata")]
        public string? Metadata { get; set; }
    }
}
