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
    /// Advanced load balancer DnsRuleDnsRrSet object
    /// </summary>
    [NSXTProperty(Description: @"Advanced load balancer DnsRuleDnsRrSet object")]
    public class NSXTALBDnsRuleDnsRrSetType 
    {
        /// <summary>
        /// 
        /// </summary>
        [JsonProperty(PropertyName = "resource_record_set", Required = Required.AllowNull)]
        public NSXTALBDnsRrSetType ResourceRecordSet { get; set; }
        /// <summary>
        /// DNS message section for the resource record set.
        /// Enum options - DNS_MESSAGE_SECTION_QUESTION,
        /// DNS_MESSAGE_SECTION_ANSWER, DNS_MESSAGE_SECTION_AUTHORITY,
        /// DNS_MESSAGE_SECTION_ADDITIONAL.
        /// Default value when not specified in API or module is
        /// interpreted by ALB Controller as DNS_MESSAGE_SECTION_ANSWER.
        /// </summary>
        [JsonProperty(PropertyName = "section")]
        [JsonConverter(typeof(StringEnumConverter))]
        public NSXTAlbdnsRuleDnsRrSetSectionEnumType? Section { get; set; }
    }
}
