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
    public class NSXTLbPoolMemberStatisticsType 
    {
        /// <summary>
        /// 
        /// </summary>
        [JsonProperty(PropertyName = "statistics", Required = Required.AllowNull)]
        public NSXTLbStatisticsCounterType Statistics { get; set; }
        /// <summary>
        /// Pool member IP address
        /// </summary>
        [JsonProperty(PropertyName = "ip_address", Required = Required.AllowNull)]
        public string IpAddress { get; set; }
        /// <summary>
        /// The port is configured in pool member. For virtual server port range
        /// case, pool member port must be null.
        /// </summary>
        [JsonProperty(PropertyName = "port")]
        public string? Port { get; set; }
    }
}
