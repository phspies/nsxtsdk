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
    public class NSXTDhcpV6InfoBaseType : NSXTManagedResourceType
    {
        /// <summary>
        /// Lease time, in seconds.
        /// </summary>
        [JsonProperty(PropertyName = "lease_time")]
        public long? LeaseTime { get; set; }
        /// <summary>
        /// SNTP server ips.
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
        /// Primary and secondary DNS server address to assign host. They can be
        /// overridden by ip-pool or static-binding level property.
        /// </summary>
        [JsonProperty(PropertyName = "dns_nameservers")]
        public IList<string> DnsNameservers { get; set; }
        /// <summary>
        /// Host name or prefix to be assigned to host. It can be overridden by
        /// ip-pool or static-binding level property.
        /// </summary>
        [JsonProperty(PropertyName = "domain_names")]
        public IList<string> DomainNames { get; set; }
    }
}
