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
    /// The settings are used during deployment and consequent update of an edge,
        /// unless indicated otherwise.
        /// These settings are editable for manually deployed edge nodes as well.
        /// If using DHCP, you must leave the following fields unset: search_domains,
        /// management_port_subnets, dns_servers and default_gateway_addresses.
        /// EdgeNodeSettings reports current values configured on the edge node.
        /// If the settings lag with actual state on the edge,
        /// these may be refreshed at NSX Manager using API POST api/v1/transport-nodes
        /// /<transport-node-id>?action=refresh_node_configuration&resource_type=
        /// EdgeNode
    /// </summary>
    [NSXTProperty(Description: @"The settings are used during deployment and consequent update of an edge,unless indicated otherwise.These settings are editable for manually deployed edge nodes as well.If using DHCP, you must leave the following fields unset: search_domains,management_port_subnets, dns_servers and default_gateway_addresses.EdgeNodeSettings reports current values configured on the edge node.If the settings lag with actual state on the edge,these may be refreshed at NSX Manager using API POST api/v1/transport-nodes/&amp;lt;transport-node-id&amp;gt;?action=refresh_node_configuration&amp;resource_type=EdgeNode")]
    public class NSXTEdgeNodeSettingsType 
    {
        /// <summary>
        /// List of NTP servers.
        /// </summary>
        [JsonProperty(PropertyName = "ntp_servers")]
        public IList<string> NtpServers { get; set; }
        /// <summary>
        /// List of DNS servers.
        /// </summary>
        [JsonProperty(PropertyName = "dns_servers")]
        public IList<string> DnsServers { get; set; }
        /// <summary>
        /// List of Syslog server configuration.
        /// </summary>
        [JsonProperty(PropertyName = "syslog_servers")]
        public IList<NSXTSyslogConfigurationType> SyslogServers { get; set; }
        /// <summary>
        /// Array of additional specific properties for advanced or cloud-
        /// specific deployments in key-value format.
        /// </summary>
        [JsonProperty(PropertyName = "advanced_configuration")]
        public IList<NSXTKeyValuePairType> AdvancedConfiguration { get; set; }
        /// <summary>
        /// List of domain names that are used to complete unqualified host names.
        /// </summary>
        [JsonProperty(PropertyName = "search_domains")]
        public IList<string> SearchDomains { get; set; }
        /// <summary>
        /// Host name or FQDN for edge node.
        /// </summary>
        [JsonProperty(PropertyName = "hostname", Required = Required.AllowNull)]
        public string Hostname { get; set; }
        /// <summary>
        /// Enabling SSH service is not recommended for security reasons.
        /// </summary>
        [JsonProperty(PropertyName = "enable_ssh")]
        public bool? EnableSsh { get; set; }
        /// <summary>
        /// Allowing root SSH logins is not recommended for security reasons.
        /// Edit of this property is not supported when updating transport node.
        /// Use the CLI to change this property.
        /// </summary>
        [JsonProperty(PropertyName = "allow_ssh_root_login")]
        public bool? AllowSshRootLogin { get; set; }
    }
}
