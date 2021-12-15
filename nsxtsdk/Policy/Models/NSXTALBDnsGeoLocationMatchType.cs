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
    /// Advanced load balancer DnsGeoLocationMatch object
    /// </summary>
    [NSXTProperty(Description: @"Advanced load balancer DnsGeoLocationMatch object")]
    public class NSXTALBDnsGeoLocationMatchType 
    {
        /// <summary>
        /// Geographical location of the client IP to be used in the
        /// match.
        /// This location is of the format Country/State/City e.g.
        /// US/CA/Santa Clara.
        /// </summary>
        [JsonProperty(PropertyName = "geolocation_name")]
        [NSXTProperty(IsRequired: false, Description: @"Geographical location of the client IP to be used in thematch.This location is of the format Country/State/City e.g.US/CA/Santa Clara.")]
        public string? GeolocationName { get; set; }
        /// <summary>
        /// Use the IP address from the EDNS client subnet option, if
        /// available, to derive geo location of the DNS query.
        /// Default value when not specified in API or module is
        /// interpreted by ALB Controller as true.
        /// </summary>
        [JsonProperty(PropertyName = "use_edns_client_subnet_ip")]
        [NSXTProperty(IsRequired: false, Description: @"Use the IP address from the EDNS client subnet option, ifavailable, to derive geo location of the DNS query.Default value when not specified in API or module isinterpreted by ALB Controller as true.")]
        [NSXTDefaultProperty(Default: "")]
        public bool? UseEdnsClientSubnetIp { get; set; }
        /// <summary>
        /// Geolocation tag for the client IP.
        /// This could be any string value for the client IP, e.g.
        /// client IPs from US East Coast geolocation would be tagged
        /// as 'East Coast'.
        /// </summary>
        [JsonProperty(PropertyName = "geolocation_tag")]
        [NSXTProperty(IsRequired: false, Description: @"Geolocation tag for the client IP.This could be any string value for the client IP, e.g.client IPs from US East Coast geolocation would be taggedas &apos;East Coast&apos;.")]
        public string? GeolocationTag { get; set; }
        /// <summary>
        /// Criterion to use for matching the client IP's geographical
        /// location.
        /// Enum options - IS_IN, IS_NOT_IN.
        /// </summary>
        [JsonProperty(PropertyName = "match_criteria", Required = Required.AllowNull)]
        [NSXTProperty(IsRequired: true, Description: @"Criterion to use for matching the client IP&apos;s geographicallocation.Enum options - IS_IN, IS_NOT_IN.")]
        [System.ComponentModel.DataAnnotations.Required]
        public NSXTAlbdnsGeoLocationMatchMatchCriteriaEnumType MatchCriteria { get; set; }
    }
}
