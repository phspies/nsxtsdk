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
    /// 
    /// </summary>
    [NSXTProperty(Description: @"")]
    public class NSXTLBPoolMemberStatisticsType 
    {
        public NSXTLBPoolMemberStatisticsType()
        {
        }
        /// <summary>
        /// 
        /// </summary>
        [JsonProperty(PropertyName = "statistics")]
        [NSXTProperty(IsRequired: false, Description: @"")]
        public NSXTLBStatisticsCounterType Statistics { get; set; }
        /// <summary>
        /// Pool member IP address.
        /// </summary>
        [JsonProperty(PropertyName = "ip_address")]
        [NSXTProperty(IsRequired: false, Description: @"Pool member IP address.")]
        public string? IpAddress { get; set; }
        /// <summary>
        /// The port is configured in pool member. For virtual server port range
        /// case, pool member port must be null.
        /// </summary>
        [JsonProperty(PropertyName = "port")]
        [NSXTProperty(IsRequired: false, Description: @"The port is configured in pool member. For virtual server port rangecase, pool member port must be null.")]
        public string? Port { get; set; }
    }
}
