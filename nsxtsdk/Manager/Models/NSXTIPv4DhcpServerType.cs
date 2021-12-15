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
    /// DHCP server to support IPv4 DHCP service. Properties defined at DHCP server
        /// level can be overridden by ip-pool or static-binding level properties.
    /// </summary>
    [NSXTProperty(Description: @"DHCP server to support IPv4 DHCP service. Properties defined at DHCP serverlevel can be overridden by ip-pool or static-binding level properties.")]
    public class NSXTIPv4DhcpServerType 
    {
        /// <summary>
        /// Defines the default options for all ip-pools and static-bindings of this server.
        /// These options will be ignored if options are defined for ip-pools or static-bindings.
        /// </summary>
        [JsonProperty(PropertyName = "options")]
        [NSXTProperty(IsRequired: false, Description: @"Defines the default options for all ip-pools and static-bindings of this server.These options will be ignored if options are defined for ip-pools or static-bindings.")]
        public NSXTDhcpOptionsType Options { get; set; }
        /// <summary>
        /// Enable or disable monitoring of DHCP ip-pools usage. When enabled, system events are
        /// generated when pool usage exceeds the configured thresholds.
        /// System events can be viewed in REST API /api/v2/hpm/alarms
        /// </summary>
        [JsonProperty(PropertyName = "monitor_ippool_usage")]
        [NSXTProperty(IsRequired: false, Description: @"Enable or disable monitoring of DHCP ip-pools usage. When enabled, system events aregenerated when pool usage exceeds the configured thresholds.System events can be viewed in REST API /api/v2/hpm/alarms")]
        public bool? MonitorIppoolUsage { get; set; }
        /// <summary>
        /// DHCP server ip in CIDR format.
        /// </summary>
        [JsonProperty(PropertyName = "dhcp_server_ip", Required = Required.AllowNull)]
        [NSXTProperty(IsRequired: true, Description: @"DHCP server ip in CIDR format.")]
        [System.ComponentModel.DataAnnotations.Required]
        public string DhcpServerIp { get; set; }
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
        [JsonProperty(PropertyName = "domain_name")]
        [NSXTProperty(IsRequired: false, Description: @"Host name or prefix to be assigned to host. It can be overridden byip-pool or static-binding level property.")]
        public string? DomainName { get; set; }
        /// <summary>
        /// Gateway ip to be assigned to host. It can be overridden by ip-pool or
        /// static-binding level property.
        /// </summary>
        [JsonProperty(PropertyName = "gateway_ip")]
        [NSXTProperty(IsRequired: false, Description: @"Gateway ip to be assigned to host. It can be overridden by ip-pool orstatic-binding level property.")]
        public string? GatewayIp { get; set; }
    }
}
