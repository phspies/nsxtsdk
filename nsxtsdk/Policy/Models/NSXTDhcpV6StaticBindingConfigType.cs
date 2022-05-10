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
    public class NSXTDhcpV6StaticBindingConfigType : NSXTDhcpStaticBindingConfigType
    {
        /// <summary>
        /// SNTP server IP addresses.
        /// </summary>
        [JsonProperty(PropertyName = "sntp_servers")]
        public IList<string> SntpServers { get; set; }
        /// <summary>
        /// Preferred time, in seconds. If this value is not provided, the value
        /// of lease_time*0.8 will be used.
        /// </summary>
        [JsonProperty(PropertyName = "preferred_time")]
        public long? PreferredTime { get; set; }
        /// <summary>
        /// Lease time, in seconds.
        /// </summary>
        [JsonProperty(PropertyName = "lease_time")]
        public long? LeaseTime { get; set; }
        /// <summary>
        /// The MAC address of the client host. Either client-duid or mac-address,
        /// but not both.
        /// </summary>
        [JsonProperty(PropertyName = "mac_address", Required = Required.AllowNull)]
        public string MacAddress { get; set; }
        /// <summary>
        /// When not specified, no ip address will be assigned to client host.
        /// </summary>
        [JsonProperty(PropertyName = "ip_addresses")]
        public IList<string> IpAddresses { get; set; }
        /// <summary>
        /// When not specified, no DNS nameserver will be set to client host.
        /// </summary>
        [JsonProperty(PropertyName = "dns_nameservers")]
        public IList<string> DnsNameservers { get; set; }
        /// <summary>
        /// When not specified, no domain name will be assigned to client host.
        /// </summary>
        [JsonProperty(PropertyName = "domain_names")]
        public IList<string> DomainNames { get; set; }
    }
}
