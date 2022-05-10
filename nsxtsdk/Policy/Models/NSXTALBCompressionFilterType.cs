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
    /// Advanced load balancer CompressionFilter object
    /// </summary>
    [NSXTProperty(Description: @"Advanced load balancer CompressionFilter object")]
    public class NSXTALBCompressionFilterType 
    {
        /// <summary>
        /// It is a reference to an object of type IpAddrGroup.
        /// </summary>
        [JsonProperty(PropertyName = "ip_addrs_path")]
        public string? IpAddrsPath { get; set; }
        /// <summary>
        /// Placeholder for description of property ip_addr_ranges of
        /// obj type CompressionFilter field type str  type array.
        /// </summary>
        [JsonProperty(PropertyName = "ip_addr_ranges")]
        public IList<NSXTALBIpAddrRangeType> IpAddrRanges { get; set; }
        /// <summary>
        /// It is a reference to an object of type StringGroup.
        /// </summary>
        [JsonProperty(PropertyName = "devices_path")]
        public string? DevicesPath { get; set; }
        /// <summary>
        /// Name of the object.
        /// </summary>
        [JsonProperty(PropertyName = "name", Required = Required.AllowNull)]
        public string Name { get; set; }
        /// <summary>
        /// Number of index.
        /// </summary>
        [JsonProperty(PropertyName = "index", Required = Required.AllowNull)]
        public long Index { get; set; }
        /// <summary>
        /// Placeholder for description of property ip_addr_prefixes of
        /// obj type CompressionFilter field type str  type array.
        /// </summary>
        [JsonProperty(PropertyName = "ip_addr_prefixes")]
        public IList<NSXTALBIpAddrPrefixType> IpAddrPrefixes { get; set; }
        /// <summary>
        /// Enum options - AGGRESSIVE_COMPRESSION, NORMAL_COMPRESSION,
        /// NO_COMPRESSION.
        /// Default value when not specified in API or module is
        /// interpreted by ALB Controller as NORMAL_COMPRESSION.
        /// </summary>
        [JsonProperty(PropertyName = "level", Required = Required.AllowNull)]
        [JsonConverter(typeof(StringEnumConverter))]
        public NSXTAlbcompressionFilterLevelEnumType Level { get; set; }
        /// <summary>
        /// Placeholder for description of property ip_addrs of obj
        /// type CompressionFilter field type str  type array.
        /// </summary>
        [JsonProperty(PropertyName = "ip_addrs")]
        public IList<NSXTALBIpAddrType> IpAddrs { get; set; }
        /// <summary>
        /// Whether to apply Filter when group criteria is matched or
        /// not.
        /// Enum options - IS_IN, IS_NOT_IN.
        /// Default value when not specified in API or module is
        /// interpreted by ALB Controller as IS_IN.
        /// </summary>
        [JsonProperty(PropertyName = "match")]
        [JsonConverter(typeof(StringEnumConverter))]
        public NSXTAlbcompressionFilterMatchEnumType? Match { get; set; }
        /// <summary>
        /// Placeholder for description of property user_agent of obj
        /// type CompressionFilter field type str  type array.
        /// </summary>
        [JsonProperty(PropertyName = "user_agent")]
        public IList<string> UserAgent { get; set; }
    }
}
