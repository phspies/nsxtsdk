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
    /// Ipaddress information of the fabric node.
    /// </summary>
    [NSXTProperty(Description: @"Ipaddress information of the fabric node.")]
    public class NSXTIpAddressInfoType 
    {
        /// <summary>
        /// Source of the ipaddress information.
        /// </summary>
        [JsonProperty(PropertyName = "source")]
        [JsonConverter(typeof(StringEnumConverter))]
        public NSXTIpAddressInfoSourceEnumType? Source { get; set; }
        /// <summary>
        /// IP Addresses of the the virtual network interface, as discovered in the source.
        /// </summary>
        [JsonProperty(PropertyName = "ip_addresses")]
        public IList<string> IpAddresses { get; set; }
    }
}
