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
    /// 
    /// </summary>
    [NSXTProperty(Description: @"")]
    public class NSXTSegmentDhcpV6ConfigType : NSXTSegmentDhcpConfigType
    {
        /// <summary>
        /// Excluded addresses to define dynamic ip allocation ranges.
        /// </summary>
        [JsonProperty(PropertyName = "excluded_ranges")]
        public IList<string> ExcludedRanges { get; set; }
        /// <summary>
        /// IPv6 address of SNTP servers for subnet.
        /// </summary>
        [JsonProperty(PropertyName = "sntp_servers")]
        public IList<string> SntpServers { get; set; }
        /// <summary>
        /// The length of time that a valid address is preferred. When the
        /// preferred lifetime expires, the address becomes deprecated.
        /// </summary>
        [JsonProperty(PropertyName = "preferred_time")]
        public long? PreferredTime { get; set; }
        /// <summary>
        /// Domain names for subnet.
        /// </summary>
        [JsonProperty(PropertyName = "domain_names")]
        public IList<string> DomainNames { get; set; }
    }
}
