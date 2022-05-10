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
    public class NSXTLbSnatIpElementType 
    {
        /// <summary>
        /// Ip address or ip range such as 1.1.1.1 or 1.1.1.101-1.1.1.160
        /// </summary>
        [JsonProperty(PropertyName = "ip_address", Required = Required.AllowNull)]
        public string IpAddress { get; set; }
        /// <summary>
        /// Subnet prefix length should be not specified if there is only one single
        /// IP address or IP range.
        /// </summary>
        [JsonProperty(PropertyName = "prefix_length")]
        public long? PrefixLength { get; set; }
    }
}
