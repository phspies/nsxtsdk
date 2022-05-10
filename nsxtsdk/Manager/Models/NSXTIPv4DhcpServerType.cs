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
    /// DHCP server to support IPv4 DHCP service. Properties defined at DHCP server
        /// level can be overridden by ip-pool or static-binding level properties.
    /// </summary>
    [NSXTProperty(Description: @"DHCP server to support IPv4 DHCP service. Properties defined at DHCP serverlevel can be overridden by ip-pool or static-binding level properties.")]
    public class NSXTIPv4DhcpServerType 
    {
        /// <summary>
        /// 
        /// </summary>
        [JsonProperty(PropertyName = "options")]
        public NSXTDhcpOptionsType Options { get; set; }
        /// <summary>
        /// Enable or disable monitoring of DHCP ip-pools usage. When enabled, system events are
        /// generated when pool usage exceeds the configured thresholds.
        /// System events can be viewed in REST API /api/v2/hpm/alarms
        /// </summary>
        [JsonProperty(PropertyName = "monitor_ippool_usage")]
        public bool? MonitorIppoolUsage { get; set; }
        /// <summary>
        /// DHCP server ip in CIDR format.
        /// </summary>
        [JsonProperty(PropertyName = "dhcp_server_ip", Required = Required.AllowNull)]
        public string DhcpServerIp { get; set; }
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
        [JsonProperty(PropertyName = "domain_name")]
        public string? DomainName { get; set; }
        /// <summary>
        /// Gateway ip to be assigned to host. It can be overridden by ip-pool or
        /// static-binding level property.
        /// </summary>
        [JsonProperty(PropertyName = "gateway_ip")]
        public string? GatewayIp { get; set; }
    }
}
