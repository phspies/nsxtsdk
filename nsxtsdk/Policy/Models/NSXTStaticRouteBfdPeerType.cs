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
    public class NSXTStaticRouteBfdPeerType : NSXTPolicyConfigResourceType
    {
        /// <summary>
        /// Bfd Profile is not supported for IPv6 networks.
        /// </summary>
        [JsonProperty(PropertyName = "bfd_profile_path")]
        public string? BfdProfilePath { get; set; }
        /// <summary>
        /// Only IPv4 addresses are supported. Only a single BFD config per peer address is allowed.
        /// </summary>
        [JsonProperty(PropertyName = "peer_address", Required = Required.AllowNull)]
        public string PeerAddress { get; set; }
        /// <summary>
        /// Array of Tier0 external interface IP addresses. BFD peering is established from all these source addresses to the
        /// neighbor specified in peer_address. Only IPv4 addresses are supported.
        /// </summary>
        [JsonProperty(PropertyName = "source_addresses")]
        public IList<string> SourceAddresses { get; set; }
        /// <summary>
        /// Flag to enable BFD peer.
        /// </summary>
        [JsonProperty(PropertyName = "enabled")]
        public bool? Enabled { get; set; }
        /// <summary>
        /// Represents the array of policy paths of locale services where this BFD peer should
        /// get relalized on.
        /// The locale service service and this BFD peer must belong to the same router.
        /// Default scope is empty.
        /// </summary>
        [JsonProperty(PropertyName = "scope")]
        public IList<string> Scope { get; set; }
    }
}
