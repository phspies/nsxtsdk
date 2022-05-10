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
    /// Advanced load balancer DnsRuleActionResponse object
    /// </summary>
    [NSXTProperty(Description: @"Advanced load balancer DnsRuleActionResponse object")]
    public class NSXTALBDnsRuleActionResponseType 
    {
        /// <summary>
        /// DNS response is authoritative.
        /// Default value when not specified in API or module is
        /// interpreted by ALB Controller as true.
        /// </summary>
        [JsonProperty(PropertyName = "authoritative")]
        public bool? Authoritative { get; set; }
        /// <summary>
        /// DNS resource record sets - (resource record set share the
        /// DNS domain name, type, and class).
        /// </summary>
        [JsonProperty(PropertyName = "resource_record_sets")]
        public IList<NSXTALBDnsRuleDnsRrSetType> ResourceRecordSets { get; set; }
        /// <summary>
        /// DNS response code.
        /// Enum options - DNS_RCODE_NOERROR, DNS_RCODE_FORMERR,
        /// DNS_RCODE_SERVFAIL, DNS_RCODE_NXDOMAIN, DNS_RCODE_NOTIMP,
        /// DNS_RCODE_REFUSED, DNS_RCODE_YXDOMAIN, DNS_RCODE_YXRRSET,
        /// DNS_RCODE_NXRRSET, DNS_RCODE_NOTAUTH, DNS_RCODE_NOTZONE.
        /// Default value when not specified in API or module is
        /// interpreted by ALB Controller as DNS_RCODE_NOERROR.
        /// </summary>
        [JsonProperty(PropertyName = "rcode")]
        [JsonConverter(typeof(StringEnumConverter))]
        public NSXTAlbdnsRuleActionResponseRcodeEnumType? Rcode { get; set; }
        /// <summary>
        /// DNS response is truncated.
        /// Default value when not specified in API or module is
        /// interpreted by ALB Controller as false.
        /// </summary>
        [JsonProperty(PropertyName = "truncation")]
        public bool? Truncation { get; set; }
    }
}
