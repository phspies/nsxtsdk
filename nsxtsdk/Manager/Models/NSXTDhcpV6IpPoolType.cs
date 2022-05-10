using nsxtsdk.Models;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.ComponentModel;
using NJsonSchema.Converters;
using Newtonsoft.Json.Converters;

namespace nsxtsdk.ManagerModels
{
    /// <summary>
    /// 
    /// </summary>
    [NSXTProperty(Description: @"")]
    public class NSXTDhcpV6IpPoolType : NSXTDhcpV6InfoBaseType
    {
        /// <summary>
        /// Ip address ranges to define dynamic ip allocation ranges.
        /// </summary>
        [JsonProperty(PropertyName = "ranges")]
        public IList<NSXTIpPoolRangeType> Ranges { get; set; }
        /// <summary>
        /// Excluded addresses to define dynamic ip allocation ranges.
        /// </summary>
        [JsonProperty(PropertyName = "excluded_ranges")]
        public IList<NSXTIpPoolRangeType> ExcludedRanges { get; set; }
    }
}
