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
    public class NSXTLogicalDhcpServerType : NSXTManagedResourceType
    {
        /// <summary>
        /// The uuid of the attached logical port. Read only.
        /// </summary>
        [JsonProperty(PropertyName = "attached_logical_port_id")]
        public string? AttachedLogicalPortId { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [JsonProperty(PropertyName = "ipv6_dhcp_server")]
        public NSXTIPv6DhcpServerType Ipv6DhcpServer { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [JsonProperty(PropertyName = "ipv4_dhcp_server")]
        public NSXTIPv4DhcpServerType Ipv4DhcpServer { get; set; }
        /// <summary>
        /// The DHCP profile uuid the logical DHCP server references.
        /// </summary>
        [JsonProperty(PropertyName = "dhcp_profile_id", Required = Required.AllowNull)]
        public string DhcpProfileId { get; set; }
    }
}
