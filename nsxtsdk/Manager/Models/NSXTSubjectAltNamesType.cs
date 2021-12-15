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
        [NSXTProperty(IsRequired: false, Description: @"A list of DNS names in subject alternative names")]
        public IList<string> DnsNames { get; set; }
        /// <summary>
        /// A list of IP addresses in subject alternative names
        /// </summary>
        [JsonProperty(PropertyName = "ip_addresses")]
        [NSXTProperty(IsRequired: false, Description: @"A list of IP addresses in subject alternative names")]
        public IList<string> IpAddresses { get; set; }
    }
}
