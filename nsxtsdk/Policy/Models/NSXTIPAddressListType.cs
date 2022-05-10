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
    /// Collection of IP Addresses.
    /// </summary>
    [NSXTProperty(Description: @"Collection of IP Addresses.")]
    public class NSXTIPAddressListType 
    {
        /// <summary>
        /// The array contains IP addresses.
        /// </summary>
        [JsonProperty(PropertyName = "ip_addresses", Required = Required.AllowNull)]
        public IList<string> IpAddresses { get; set; }
    }
}
