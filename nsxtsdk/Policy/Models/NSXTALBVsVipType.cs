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
    public class NSXTALBVsVipType : NSXTPolicyConfigResourceType
    {
        /// <summary>
        /// Force placement on all Service Engines in the Service
        /// Engine Group (Container clouds only).
        /// Allowed in Basic(Allowed values- false) edition,
        /// Essentials(Allowed values- false) edition, Enterprise
        /// edition.
        /// Default value when not specified in API or module is
        /// interpreted by ALB Controller as false.
        /// </summary>
        [JsonProperty(PropertyName = "east_west_placement")]
        public bool? EastWestPlacement { get; set; }
        /// <summary>
        /// It is a reference to an object of type Cloud.
        /// </summary>
        [JsonProperty(PropertyName = "cloud_name")]
        public string? CloudName { get; set; }
        /// <summary>
        /// List of Virtual Service IPs and other shareable entities.
        /// </summary>
        [JsonProperty(PropertyName = "vip")]
        public IList<NSXTALBVipType> Vip { get; set; }
        /// <summary>
        /// Select BGP peers, using peer label, for VsVip
        /// advertisement.
        /// Maximum of 128 items allowed.
        /// </summary>
        [JsonProperty(PropertyName = "bgp_peer_labels")]
        public IList<string> BgpPeerLabels { get; set; }
        /// <summary>
        /// This sets the placement scope of virtualservice to given
        /// tier1 logical router in Nsx-t.
        /// </summary>
        [JsonProperty(PropertyName = "tier1_path")]
        public string? Tier1Path { get; set; }
        /// <summary>
        /// Virtual Routing Context that the Virtual Service is bound
        /// to.
        /// This is used to provide the isolation of the set of
        /// networks the application is attached to.
        /// It is a reference to an object of type VrfContext.
        /// </summary>
        [JsonProperty(PropertyName = "vrf_context_name")]
        public string? VrfContextName { get; set; }
        /// <summary>
        /// Checksum of cloud configuration for VsVip.
        /// Internally set by cloud connector.
        /// </summary>
        [JsonProperty(PropertyName = "vsvip_cloud_config_cksum")]
        public string? VsvipCloudConfigCksum { get; set; }
        /// <summary>
        /// Service discovery specific data including fully qualified
        /// domain name, type and Time-To-Live of the DNS record.
        /// Maximum of 1000 items allowed.
        /// Allowed in Basic edition, Essentials edition, Enterprise
        /// edition.
        /// </summary>
        [JsonProperty(PropertyName = "dns_info")]
        public IList<NSXTALBDnsInfoType> DnsInfo { get; set; }
        /// <summary>
        /// This overrides the cloud level default and needs to match
        /// the SE Group value in which it will be used if the SE Group
        /// use_standard_alb value is set.
        /// This is only used when FIP is used for VS on Azure Cloud.
        /// Allowed in Basic edition, Essentials edition, Enterprise
        /// edition.
        /// </summary>
        [JsonProperty(PropertyName = "use_standard_alb")]
        public bool? UseStandardAlb { get; set; }
        /// <summary>
        /// List of labels to be used for granular RBAC.
        /// Allowed in Basic edition, Essentials edition, Enterprise
        /// edition.
        /// </summary>
        [JsonProperty(PropertyName = "markers")]
        public IList<NSXTALBRoleFilterMatchLabelType> Markers { get; set; }
    }
}
