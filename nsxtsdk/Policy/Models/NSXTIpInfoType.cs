// <auto-generated>
// Changes may cause incorrect behavior and will be lost if the code is regenerated.
// </auto-generated>
using nsxtsdk.Models;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.ComponentModel;
using NJsonSchema.Converters;

namespace nsxtsdk.PolicyModels
{
    /// <summary>
    /// 
    /// </summary>
    [NSXTProperty(Description: @"")]
    public class NSXTIPInfoType 
    {
        /// <summary>
        /// IPv4 Addresses
        /// </summary>
        [JsonProperty(PropertyName = "ip_addresses", Required = Required.AllowNull)]
        public IList<string> IpAddresses { get; set; }
        /// <summary>
        /// Subnet Prefix Length
        /// </summary>
        [JsonProperty(PropertyName = "prefix_length", Required = Required.AllowNull)]
        public long PrefixLength { get; set; }
    }
}
