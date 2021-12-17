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
    /// 
    /// </summary>
    [NSXTProperty(Description: @"")]
    public class NSXTDhcpV6InfoBaseType : NSXTManagedResourceType
    {
        public NSXTDhcpV6InfoBaseType()
        {
            LeaseTime = test
        }
        /// <summary>
        /// Lease time, in seconds.
        /// </summary>
        [JsonProperty(PropertyName = "lease_time")]
        [NSXTProperty(IsRequired: false, Description: @"Lease time, in seconds.")]
        //[System.ComponentModel.DataAnnotations.MinLength(60)]
        //[System.ComponentModel.DataAnnotations.MaxLength(4294967295)]
        public long? LeaseTime { get; set; }
        /// <summary>
        /// SNTP server ips.
        /// </summary>
        [JsonProperty(PropertyName = "sntp_servers")]
        [NSXTProperty(IsRequired: false, Description: @"SNTP server ips.")]
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
        /// Primary and secondary DNS server address to assign host. They can be
        /// overridden by ip-pool or static-binding level property.
        /// </summary>
        [JsonProperty(PropertyName = "dns_nameservers")]
        [NSXTProperty(IsRequired: false, Description: @"Primary and secondary DNS server address to assign host. They can beoverridden by ip-pool or static-binding level property.")]
        public IList<string> DnsNameservers { get; set; }
        /// <summary>
        /// Host name or prefix to be assigned to host. It can be overridden by
        /// ip-pool or static-binding level property.
        /// </summary>
        [JsonProperty(PropertyName = "domain_names")]
        [NSXTProperty(IsRequired: false, Description: @"Host name or prefix to be assigned to host. It can be overridden byip-pool or static-binding level property.")]
        public IList<string> DomainNames { get; set; }
    }
}
