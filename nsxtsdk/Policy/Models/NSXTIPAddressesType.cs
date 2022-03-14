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
    public class NSXTIPAddressesType 
    {
        /// <summary>
        /// The IP addresses in the form of IP Address, IP Range, CIDR, used as source IPs or destination IPs of filters.
        /// </summary>
        public IList<string> IpAddresses { get; set; }
    }
}
