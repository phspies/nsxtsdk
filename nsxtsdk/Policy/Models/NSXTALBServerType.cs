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
    /// Advanced load balancer Server object
    /// </summary>
    [NSXTProperty(Description: @"Advanced load balancer Server object")]
    public class NSXTALBServerType 
    {
        /// <summary>
        /// If statically learned.
        /// Default value when not specified in API or module is
        /// interpreted by ALB Controller as false.
        /// </summary>
        [JsonProperty(PropertyName = "is_static")]
        public bool? IsStatic { get; set; }
        /// <summary>
        /// UID of server in external orchestration systems.
        /// </summary>
        [JsonProperty(PropertyName = "external_orchestration_id")]
        public string? ExternalOrchestrationId { get; set; }
        /// <summary>
        /// (internal-use) Discovered networks providing reachability
        /// for server IP.
        /// This field is used internally by Avi, not editable by the
        /// user.
        /// </summary>
        [JsonProperty(PropertyName = "discovered_networks")]
        public IList<NSXTALBDiscoveredNetworkType> DiscoveredNetworks { get; set; }
        /// <summary>
        /// Header value for custom header persistence.
        /// </summary>
        [JsonProperty(PropertyName = "prst_hdr_val")]
        public string? PrstHdrVal { get; set; }
        /// <summary>
        /// A description of the Server.
        /// </summary>
        [JsonProperty(PropertyName = "description")]
        public string? Description { get; set; }
        /// <summary>
        /// Availability-zone of the server VM.
        /// </summary>
        [JsonProperty(PropertyName = "availability_zone")]
        public string? AvailabilityZone { get; set; }
        /// <summary>
        /// Name of autoscaling group this server belongs to.
        /// Allowed in Essentials edition, Enterprise edition.
        /// </summary>
        [JsonProperty(PropertyName = "autoscaling_group_name")]
        public string? AutoscalingGroupName { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [JsonProperty(PropertyName = "ip", Required = Required.AllowNull)]
        public NSXTALBIpAddrType Ip { get; set; }
        /// <summary>
        /// DNS resolvable name of the server.
        /// May be used in place of the IP address.
        /// </summary>
        [JsonProperty(PropertyName = "hostname")]
        public string? Hostname { get; set; }
        /// <summary>
        /// Enable, Disable or Graceful Disable determine if new or
        /// existing connections to the server are allowed.
        /// Default value when not specified in API or module is
        /// interpreted by ALB Controller as true.
        /// </summary>
        [JsonProperty(PropertyName = "enabled")]
        public bool? Enabled { get; set; }
        /// <summary>
        /// MAC address of server.
        /// </summary>
        [JsonProperty(PropertyName = "mac_address")]
        public string? MacAddress { get; set; }
        /// <summary>
        /// Verify server belongs to a discovered network or reachable
        /// via a discovered network.
        /// Verify reachable network isn't the OpenStack management
        /// network.
        /// Default value when not specified in API or module is
        /// interpreted by ALB Controller as false.
        /// </summary>
        [JsonProperty(PropertyName = "verify_network")]
        public bool? VerifyNetwork { get; set; }
        /// <summary>
        /// Hostname of the node where the server VM or container
        /// resides.
        /// </summary>
        [JsonProperty(PropertyName = "server_node")]
        public string? ServerNode { get; set; }
        /// <summary>
        /// UUID identifying VM in OpenStack and other external
        /// compute.
        /// </summary>
        [JsonProperty(PropertyName = "external_uuid")]
        public string? ExternalUuid { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [JsonProperty(PropertyName = "location")]
        public NSXTALBGeoLocationType Location { get; set; }
        /// <summary>
        /// Auto resolve server's IP using DNS name.
        /// Allowed in Basic(Allowed values- false) edition,
        /// Essentials(Allowed values- false) edition, Enterprise
        /// edition.
        /// Default value when not specified in API or module is
        /// interpreted by ALB Controller as false.
        /// </summary>
        [JsonProperty(PropertyName = "resolve_server_by_dns")]
        public bool? ResolveServerByDns { get; set; }
        /// <summary>
        /// Ratio of selecting eligible servers in the pool.
        /// Allowed values are 1-20.
        /// Default value when not specified in API or module is
        /// interpreted by ALB Controller as 1.
        /// </summary>
        [JsonProperty(PropertyName = "ratio")]
        public long? Ratio { get; set; }
        /// <summary>
        /// Rewrite incoming Host Header to server name.
        /// Default value when not specified in API or module is
        /// interpreted by ALB Controller as false.
        /// </summary>
        [JsonProperty(PropertyName = "rewrite_host_header")]
        public bool? RewriteHostHeader { get; set; }
        /// <summary>
        /// Optionally specify the servers port number.
        /// This will override the pool's default server port
        /// attribute.
        /// Allowed values are 1-65535.
        /// Special values are 0- 'use backend port in pool'.
        /// </summary>
        [JsonProperty(PropertyName = "port")]
        public long? Port { get; set; }
    }
}
