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
    public class NSXTVIPSubnetType 
    {
        /// <summary>
        /// Subnet Prefix Length
        /// </summary>
        [JsonProperty(PropertyName = "prefix_length", Required = Required.AllowNull)]
        public long PrefixLength { get; set; }
        /// <summary>
        /// Array of IP address subnets which will be used as floating IP addresses. | These IPs will move and will be owned by
        /// Active node.
        /// </summary>
        [JsonProperty(PropertyName = "active_vip_addresses", Required = Required.AllowNull)]
        public IList<string> ActiveVipAddresses { get; set; }
    }
}
