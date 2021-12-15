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
    /// Advanced load balancer DnsRuleMatchTarget object
    /// </summary>
    [NSXTProperty(Description: @"Advanced load balancer DnsRuleMatchTarget object")]
    public class NSXTALBDnsRuleMatchTargetType 
    {
        /// <summary>
        /// DNS query types to match against request query type.
        /// </summary>
        [JsonProperty(PropertyName = "query_type")]
        [NSXTProperty(IsRequired: false, Description: @"DNS query types to match against request query type.")]
        public NSXTALBDnsQueryTypeMatchType QueryType { get; set; }
        /// <summary>
        /// Geographical location attribute to match against that of
        /// the client IP.
        /// </summary>
        [JsonProperty(PropertyName = "geo_location")]
        [NSXTProperty(IsRequired: false, Description: @"Geographical location attribute to match against that ofthe client IP.")]
        public NSXTALBDnsGeoLocationMatchType GeoLocation { get; set; }
        /// <summary>
        /// Domain names to match against query name.
        /// </summary>
        [JsonProperty(PropertyName = "query_name")]
        [NSXTProperty(IsRequired: false, Description: @"Domain names to match against query name.")]
        public NSXTALBDnsQueryNameMatchType QueryName { get; set; }
        /// <summary>
        /// DNS transport protocol match.
        /// </summary>
        [JsonProperty(PropertyName = "protocol")]
        [NSXTProperty(IsRequired: false, Description: @"DNS transport protocol match.")]
        public NSXTALBDnsTransportProtocolMatchType Protocol { get; set; }
        /// <summary>
        /// IP addresses to match against client IP or the EDNS client
        /// subnet IP.
        /// </summary>
        [JsonProperty(PropertyName = "client_ip_address")]
        [NSXTProperty(IsRequired: false, Description: @"IP addresses to match against client IP or the EDNS clientsubnet IP.")]
        public NSXTALBDnsClientIpMatchType ClientIpAddress { get; set; }
    }
}
