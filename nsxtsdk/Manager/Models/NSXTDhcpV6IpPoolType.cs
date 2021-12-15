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
        [NSXTProperty(IsRequired: false, Description: @"Ip address ranges to define dynamic ip allocation ranges.")]
        public IList<NSXTIpPoolRangeType> Ranges { get; set; }
        /// <summary>
        /// Excluded addresses to define dynamic ip allocation ranges.
        /// </summary>
        [JsonProperty(PropertyName = "excluded_ranges")]
        [NSXTProperty(IsRequired: false, Description: @"Excluded addresses to define dynamic ip allocation ranges.")]
        public IList<NSXTIpPoolRangeType> ExcludedRanges { get; set; }
    }
}