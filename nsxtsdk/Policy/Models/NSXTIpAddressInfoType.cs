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
    /// Ipaddress information of the fabric node.
    /// </summary>
    [NSXTProperty(Description: @"Ipaddress information of the fabric node.")]
    public class NSXTIpAddressInfoType 
    {
        /// <summary>
        /// Source of the ipaddress information.
        /// </summary>
        [JsonProperty(PropertyName = "source")]
        [NSXTProperty(IsRequired: false, Description: @"Source of the ipaddress information.")]
        public NSXTIpAddressInfoSourceEnumType? Source { get; set; }
        /// <summary>
        /// IP Addresses of the the virtual network interface, as discovered in the source.
        /// </summary>
        [JsonProperty(PropertyName = "ip_addresses")]
        [NSXTProperty(IsRequired: false, Description: @"IP Addresses of the the virtual network interface, as discovered in the source.")]
        public IList<string> IpAddresses { get; set; }
    }
}
