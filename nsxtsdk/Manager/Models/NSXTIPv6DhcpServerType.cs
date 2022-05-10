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
    /// DHCP server to support IPv6 DHCP service. Properties defined at DHCP server
        /// level can be overridden by ip-pool or static-binding level properties.
    /// </summary>
    [NSXTProperty(Description: @"DHCP server to support IPv6 DHCP service. Properties defined at DHCP serverlevel can be overridden by ip-pool or static-binding level properties.")]
    public class NSXTIPv6DhcpServerType 
    {
        /// <summary>
        /// DHCP server ip in CIDR format.
        /// </summary>
        [JsonProperty(PropertyName = "dhcp_server_ip")]
        public string? DhcpServerIp { get; set; }
        /// <summary>
        /// DHCP server id.
        /// </summary>
        [JsonProperty(PropertyName = "server_id")]
        public string? ServerId { get; set; }
        /// <summary>
        /// Primary and secondary DNS server address to assign host. They can be
        /// overridden by ip-pool or static-binding level property.
        /// </summary>
        [JsonProperty(PropertyName = "dns_nameservers")]
        public IList<string> DnsNameservers { get; set; }
        /// <summary>
        /// SNTP server ips.
        /// </summary>
        [JsonProperty(PropertyName = "sntp_servers")]
        public IList<string> SntpServers { get; set; }
        /// <summary>
        /// Host name or prefix to be assigned to host. It can be overridden by
        /// ip-pool or static-binding level property.
        /// </summary>
        [JsonProperty(PropertyName = "domain_names")]
        public IList<string> DomainNames { get; set; }
    }
}
