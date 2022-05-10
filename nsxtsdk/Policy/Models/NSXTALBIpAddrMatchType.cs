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
    /// Advanced load balancer IpAddrMatch object
    /// </summary>
    [NSXTProperty(Description: @"Advanced load balancer IpAddrMatch object")]
    public class NSXTALBIpAddrMatchType 
    {
        /// <summary>
        /// IP address prefix(es).
        /// </summary>
        [JsonProperty(PropertyName = "prefixes")]
        public IList<NSXTALBIpAddrPrefixType> Prefixes { get; set; }
        /// <summary>
        /// IP address range(s).
        /// </summary>
        [JsonProperty(PropertyName = "ranges")]
        public IList<NSXTALBIpAddrRangeType> Ranges { get; set; }
        /// <summary>
        /// path of IP address group(s).
        /// It is a reference to an object of type IpAddrGroup.
        /// </summary>
        [JsonProperty(PropertyName = "group_paths")]
        public IList<string> GroupPaths { get; set; }
        /// <summary>
        /// IP address(es).
        /// </summary>
        [JsonProperty(PropertyName = "addrs")]
        public IList<NSXTALBIpAddrType> Addrs { get; set; }
        /// <summary>
        /// Criterion to use for IP address matching the HTTP request.
        /// Enum options - IS_IN, IS_NOT_IN.
        /// </summary>
        [JsonProperty(PropertyName = "match_criteria", Required = Required.AllowNull)]
        [JsonConverter(typeof(StringEnumConverter))]
        public NSXTAlbipAddrMatchMatchCriteriaEnumType MatchCriteria { get; set; }
    }
}
