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
    /// Advanced load balancer DnsInfo object
    /// </summary>
    [NSXTProperty(Description: @"Advanced load balancer DnsInfo object")]
    public class NSXTALBDnsInfoType 
    {
        /// <summary>
        /// 
        /// </summary>
        [JsonProperty(PropertyName = "cname")]
        public NSXTALBDnsCnameRdataType Cname { get; set; }
        /// <summary>
        /// Specifies the algorithm to pick the IP address(es) to be
        /// returned, when multiple entries are configured.
        /// This does not apply if num_records_in_response is 0.
        /// Default is consistent hash.
        /// Enum options - DNS_RECORD_RESPONSE_ROUND_ROBIN,
        /// DNS_RECORD_RESPONSE_CONSISTENT_HASH.
        /// Default value when not specified in API or module is
        /// interpreted by ALB Controller as
        /// DNS_RECORD_RESPONSE_CONSISTENT_HASH.
        /// </summary>
        [JsonProperty(PropertyName = "algorithm")]
        [JsonConverter(typeof(StringEnumConverter))]
        public NSXTAlbdnsInfoAlgorithmEnumType? Algorithm { get; set; }
        /// <summary>
        /// Time to live for fqdn record.
        /// Default value is chosen from DNS profile for this cloud if
        /// no value provided.
        /// </summary>
        [JsonProperty(PropertyName = "ttl")]
        public long? Ttl { get; set; }
        /// <summary>
        /// Specifies the number of records returned for this FQDN.
        /// Enter 0 to return all records.
        /// Default is 0.
        /// Allowed values are 0-20.
        /// Special values are 0- 'Return all records'.
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
        /// Default value when not specified in API or module is
        /// interpreted by ALB Controller as DNS_RECORD_A.
        /// </summary>
        [JsonProperty(PropertyName = "type")]
        [JsonConverter(typeof(StringEnumConverter))]
        public NSXTAlbdnsInfoTypeEnumType? Type { get; set; }
        /// <summary>
        /// Fully qualified domain name.
        /// </summary>
        [JsonProperty(PropertyName = "fqdn")]
        public string? Fqdn { get; set; }
        /// <summary>
        /// Any metadata associated with this record.
        /// </summary>
        [JsonProperty(PropertyName = "metadata")]
        public string? Metadata { get; set; }
    }
}
