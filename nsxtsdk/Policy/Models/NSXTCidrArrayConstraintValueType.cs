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
    public class NSXTCidrArrayConstraintValueType : NSXTConstraintValueType
    {
        /// <summary>
        /// This array can consist of a single IP address, IP address range or a subnet. Its type can be of either IPv4 or IPv6.
        /// Both IPv4 and IPv6 addresses within one expression is not allowed. Supported list of formats are, "192.168.1.1",
        /// "192.168.1.1-192.168.1.100", "192.168.0.0/24", "fe80::250:56ff:fe83:318c",
        /// "fe80::250:56ff:fe83:3181-fe80::250:56ff:fe83:318c", "fe80::250:56ff:fe83:318c/64".
        /// </summary>
        [JsonProperty(PropertyName = "values", Required = Required.AllowNull)]
        public IList<string> Values { get; set; }
    }
}
