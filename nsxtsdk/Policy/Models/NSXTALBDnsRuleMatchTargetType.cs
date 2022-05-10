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
    /// Advanced load balancer DnsRuleMatchTarget object
    /// </summary>
    [NSXTProperty(Description: @"Advanced load balancer DnsRuleMatchTarget object")]
    public class NSXTALBDnsRuleMatchTargetType 
    {
        /// <summary>
        /// 
        /// </summary>
        [JsonProperty(PropertyName = "query_type")]
        public NSXTALBDnsQueryTypeMatchType QueryType { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [JsonProperty(PropertyName = "geo_location")]
        public NSXTALBDnsGeoLocationMatchType GeoLocation { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [JsonProperty(PropertyName = "query_name")]
        public NSXTALBDnsQueryNameMatchType QueryName { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [JsonProperty(PropertyName = "protocol")]
        public NSXTALBDnsTransportProtocolMatchType Protocol { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [JsonProperty(PropertyName = "client_ip_address")]
        public NSXTALBDnsClientIpMatchType ClientIpAddress { get; set; }
    }
}
