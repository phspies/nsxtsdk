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
    /// Advanced load balancer HealthMonitorDNS object
    /// </summary>
    [NSXTProperty(Description: @"Advanced load balancer HealthMonitorDNS object")]
    public class NSXTALBHealthMonitorDNSType 
    {
        /// <summary>
        /// When No Error is selected, a DNS query will be marked
        /// failed is any error code is returned by the server.
        /// With Any selected, the monitor ignores error code in the
        /// responses.
        /// Enum options - RCODE_NO_ERROR, RCODE_ANYTHING.
        /// Default value when not specified in API or module is
        /// interpreted by ALB Controller as RCODE_NO_ERROR.
        /// </summary>
        [JsonProperty(PropertyName = "rcode")]
        [JsonConverter(typeof(StringEnumConverter))]
        public NSXTAlbhealthMonitorDNSRcodeEnumType? Rcode { get; set; }
        /// <summary>
        /// The resource record of the queried DNS server's response
        /// for the Request Name must include the IP address defined in
        /// this field.
        /// </summary>
        [JsonProperty(PropertyName = "response_string")]
        public string? ResponseString { get; set; }
        /// <summary>
        /// The DNS monitor will query the DNS server for the fully
        /// qualified name in this field.
        /// </summary>
        [JsonProperty(PropertyName = "query_name", Required = Required.AllowNull)]
        public string QueryName { get; set; }
        /// <summary>
        /// Query_Type  Response has atleast one answer of which
        /// the resource record type matches the query type   Any_Type
        /// Response should contain atleast one answer  AnyThing  An
        /// empty answer is enough.
        /// Enum options - DNS_QUERY_TYPE, DNS_ANY_TYPE, DNS_ANY_THING.
        /// Default value when not specified in API or module is
        /// interpreted by ALB Controller as DNS_QUERY_TYPE.
        /// </summary>
        [JsonProperty(PropertyName = "qtype")]
        [JsonConverter(typeof(StringEnumConverter))]
        public NSXTAlbhealthMonitorDNSQtypeEnumType? Qtype { get; set; }
        /// <summary>
        /// Resource record type used in the healthmonitor DNS query,
        /// only A or AAAA type supported.
        /// Enum options - DNS_RECORD_OTHER, DNS_RECORD_A,
        /// DNS_RECORD_NS, DNS_RECORD_CNAME, DNS_RECORD_SOA,
        /// DNS_RECORD_PTR, DNS_RECORD_HINFO, DNS_RECORD_MX,
        /// DNS_RECORD_TXT, DNS_RECORD_RP, DNS_RECORD_DNSKEY,
        /// DNS_RECORD_AAAA, DNS_RECORD_SRV, DNS_RECORD_OPT,
        /// DNS_RECORD_RRSIG, DNS_RECORD_AXFR, DNS_RECORD_ANY.
        /// Default value when not specified in API or module is
        /// interpreted by ALB Controller as DNS_RECORD_A.
        /// </summary>
        [JsonProperty(PropertyName = "record_type")]
        [JsonConverter(typeof(StringEnumConverter))]
        public NSXTAlbhealthMonitorDNSRecordTypeEnumType? RecordType { get; set; }
    }
}
