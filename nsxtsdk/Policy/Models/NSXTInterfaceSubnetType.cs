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
    /// Subnet specification for interface connectivity
    /// </summary>
    [NSXTProperty(Description: @"Subnet specification for interface connectivity")]
    public class NSXTInterfaceSubnetType 
    {
        /// <summary>
        /// IP addresses assigned to interface
        /// </summary>
        [JsonProperty(PropertyName = "ip_addresses", Required = Required.AllowNull)]
        public IList<string> IpAddresses { get; set; }
        /// <summary>
        /// Subnet prefix length
        /// </summary>
        [JsonProperty(PropertyName = "prefix_len", Required = Required.AllowNull)]
        public int PrefixLen { get; set; }
    }
}
