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
    public class NSXTDhcpServerConfigType : NSXTPolicyConfigResourceType
    {
        /// <summary>
        /// DHCP server address in CIDR format. Both IPv4 and IPv6 address families
        /// are supported.
        /// Prefix length should be less than or equal to 30 for IPv4 address
        /// family and less than or equal to 126 for IPv6.
        /// When not specified, IPv4 value is auto-assigned to 100.96.0.1/30.
        /// Ignored when this object is configured at a Segment.
        /// </summary>
        [JsonProperty(PropertyName = "server_addresses")]
        public IList<string> ServerAddresses { get; set; }
        /// <summary>
        /// Policy paths to edge nodes on which the DHCP servers run. The first edge node
        /// is assigned as active edge, and second one as stanby edge. If only one edge node
        /// is specified, the DHCP servers will run without HA support.
        /// When this property is not specified, edge nodes are auto-assigned during
        /// realization of the DHCP server.
        /// </summary>
        [JsonProperty(PropertyName = "preferred_edge_paths")]
        public IList<string> PreferredEdgePaths { get; set; }
        /// <summary>
        /// DHCP server address in CIDR format. Prefix length should be less than
        /// or equal to 30. DHCP server is deployed as DHCP relay service.
        /// This property is deprecated, use server_addresses instead. Both
        /// properties cannot be specified together with different new values.
        /// </summary>
        [JsonProperty(PropertyName = "server_address")]
        public string? ServerAddress { get; set; }
        /// <summary>
        /// The reference to the edge cluster using the policy path of the edge cluster.
        /// Auto assigned if only one edge cluster is configured
        /// on enforcement-point.
        /// Modifying edge cluster will reallocate DHCP server to the new edge cluster.
        /// Please note that re-allocating edge-cluster will result in losing of all exisitng
        /// DHCP lease information.
        /// Change edge cluster only when losing DHCP leases is not a real problem,
        /// e.g. cross-site migration or failover and all client hosts will be reboot and
        /// get new IP addresses.
        /// </summary>
        [JsonProperty(PropertyName = "edge_cluster_path")]
        public string? EdgeClusterPath { get; set; }
        /// <summary>
        /// IP address lease time in seconds.
        /// </summary>
        [JsonProperty(PropertyName = "lease_time")]
        public long? LeaseTime { get; set; }
    }
}
