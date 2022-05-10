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
    /// A collection of subject alternative names
    /// </summary>
    [NSXTProperty(Description: @"A collection of subject alternative names")]
    public class NSXTSubjectAltNamesType 
    {
        /// <summary>
        /// A list of DNS names in subject alternative names
        /// </summary>
        [JsonProperty(PropertyName = "dns_names")]
        public IList<string> DnsNames { get; set; }
        /// <summary>
        /// A list of IP addresses in subject alternative names
        /// </summary>
        [JsonProperty(PropertyName = "ip_addresses")]
        public IList<string> IpAddresses { get; set; }
    }
}
