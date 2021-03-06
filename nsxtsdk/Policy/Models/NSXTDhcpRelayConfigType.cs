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
    public class NSXTDhcpRelayConfigType : NSXTPolicyConfigResourceType
    {
        /// <summary>
        /// DHCP server IP addresses for DHCP relay configuration.
        /// Both IPv4 and IPv6 addresses are supported.
        /// </summary>
        [JsonProperty(PropertyName = "server_addresses", Required = Required.AllowNull)]
        public IList<string> ServerAddresses { get; set; }
    }
}
