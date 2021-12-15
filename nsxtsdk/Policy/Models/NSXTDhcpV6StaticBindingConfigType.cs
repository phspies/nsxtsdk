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
    /// 
    /// </summary>
    [NSXTProperty(Description: @"")]
    public class NSXTDhcpV6StaticBindingConfigType : NSXTDhcpStaticBindingConfigType
    {
        /// <summary>
        /// SNTP server IP addresses.
        /// </summary>
        [JsonProperty(PropertyName = "sntp_servers")]
        [NSXTProperty(IsRequired: false, Description: @"SNTP server IP addresses.")]
        public IList<string> SntpServers { get; set; }
        /// <summary>
        /// Preferred time, in seconds. If this value is not provided, the value
        /// of lease_time*0.8 will be used.
        /// </summary>
        [JsonProperty(PropertyName = "preferred_time")]
        [NSXTProperty(IsRequired: false, Description: @"Preferred time, in seconds. If this value is not provided, the valueof lease_time*0.8 will be used.")]
        //[System.ComponentModel.DataAnnotations.MinLength(48)]
        //[System.ComponentModel.DataAnnotations.MaxLength(4294967295)]
        public long? PreferredTime { get; set; }
        /// <summary>
        /// Lease time, in seconds.
        /// </summary>
        [JsonProperty(PropertyName = "lease_time")]
        [NSXTProperty(IsRequired: false, Description: @"Lease time, in seconds.")]
        //[System.ComponentModel.DataAnnotations.MinLength(60)]
        //[System.ComponentModel.DataAnnotations.MaxLength(4294967295)]
        [NSXTDefaultProperty(Default: "")]
        public long? LeaseTime { get; set; }
        /// <summary>
        /// The MAC address of the client host. Either client-duid or mac-address,
        /// but not both.
        /// </summary>
        [JsonProperty(PropertyName = "mac_address", Required = Required.AllowNull)]
        [NSXTProperty(IsRequired: true, Description: @"The MAC address of the client host. Either client-duid or mac-address,but not both.")]
        [System.ComponentModel.DataAnnotations.Required]
        public string MacAddress { get; set; }
        /// <summary>
        /// When not specified, no ip address will be assigned to client host.
        /// </summary>
        [JsonProperty(PropertyName = "ip_addresses")]
        [NSXTProperty(IsRequired: false, Description: @"When not specified, no ip address will be assigned to client host.")]
        public IList<string> IpAddresses { get; set; }
        /// <summary>
        /// When not specified, no DNS nameserver will be set to client host.
        /// </summary>
        [JsonProperty(PropertyName = "dns_nameservers")]
        [NSXTProperty(IsRequired: false, Description: @"When not specified, no DNS nameserver will be set to client host.")]
        public IList<string> DnsNameservers { get; set; }
        /// <summary>
        /// When not specified, no domain name will be assigned to client host.
        /// </summary>
        [JsonProperty(PropertyName = "domain_names")]
        [NSXTProperty(IsRequired: false, Description: @"When not specified, no domain name will be assigned to client host.")]
        public IList<string> DomainNames { get; set; }
    }
}
