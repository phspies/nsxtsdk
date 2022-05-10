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
    public class NSXTLBPoolMemberStatisticsType 
    {
        /// <summary>
        /// 
        /// </summary>
        [JsonProperty(PropertyName = "statistics")]
        public NSXTLBStatisticsCounterType Statistics { get; set; }
        /// <summary>
        /// Pool member IP address.
        /// </summary>
        [JsonProperty(PropertyName = "ip_address")]
        public string? IpAddress { get; set; }
        /// <summary>
        /// The port is configured in pool member. For virtual server port range
        /// case, pool member port must be null.
        /// </summary>
        [JsonProperty(PropertyName = "port")]
        public string? Port { get; set; }
    }
}
