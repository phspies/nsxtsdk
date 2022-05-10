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
    public class NSXTIPAddressesType 
    {
        /// <summary>
        /// The IP addresses in the form of IP Address, IP Range, CIDR, used as source IPs or destination IPs of filters.
        /// </summary>
        [JsonProperty(PropertyName = "ip_addresses")]
        public IList<string> IpAddresses { get; set; }
    }
}
