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
    public class NSXTIPAddressElementType : NSXTRevisionedResourceType
    {
        /// <summary>
        /// IPElement can be a single IP address, IP address range or a Subnet. Its
        /// type can be of IPv4 or IPv6. Supported list of formats are "192.168.1.1",
        /// "192.168.1.1-192.168.1.100", "192.168.0.0/24",
        /// "fe80::250:56ff:fe83:318c",
        /// "fe80::250:56ff:fe83:3181-fe80::250:56ff:fe83:318c",
        /// "fe80::250:56ff:fe83:318c/64"
        /// </summary>
        [JsonProperty(PropertyName = "ip_address", Required = Required.AllowNull)]
        public string IpAddress { get; set; }
    }
}
