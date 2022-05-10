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
    public class NSXTBgpNeighborType : NSXTManagedResourceType
    {
        /// <summary>
        /// BGP Graceful Restart mode. If specified, then it will take precedence
        /// over global Graceful Restart mode configured in logical router
        /// BgpConfig otherwise BgpConfig level Graceful Restart mode will be
        /// applicable for peer.
        /// </summary>
        [JsonProperty(PropertyName = "graceful_restart_mode")]
        [JsonConverter(typeof(StringEnumConverter))]
        public NSXTBgpNeighborGracefulRestartModeEnumType? GracefulRestartMode { get; set; }
        /// <summary>
        /// This is a deprecated property, Please use 'remote_as_num' instead.
        /// </summary>
        [JsonProperty(PropertyName = "remote_as")]
        public long? RemoteAs { get; set; }
        /// <summary>
        /// This is a deprecated property, Please use 'address_family' instead.
        /// </summary>
        [JsonProperty(PropertyName = "filter_out_ipprefixlist_id")]
        public string? FilterOutIpprefixlistId { get; set; }
        /// <summary>
        /// Wait period (seconds) before declaring peer dead
        /// </summary>
        [JsonProperty(PropertyName = "hold_down_timer")]
        public long? HoldDownTimer { get; set; }
        /// <summary>
        /// BGP neighborship will be formed from all these source addresses to this neighbour.
        /// </summary>
        [JsonProperty(PropertyName = "source_addresses")]
        public IList<string> SourceAddresses { get; set; }
        /// <summary>
        /// This value is set on TTL(time to live) of BGP header.
        /// When router receives the BGP packet, it decrements the TTL. The default
        /// value of TTL is one when BPG request is initiated.So in the case of a
        /// BGP peer multiple hops away and and value of TTL is one, then  next
        /// router in the path will decrement the TTL to 0, realize it cant forward
        /// the packet and will drop it. If the hop count value to reach neighbor
        /// is equal to or less than the maximum_hop_limit value then intermediate
        /// router decrements the TTL count by one and forwards the request to
        /// BGP neighour. If the hop count value is greater than the maximum_hop_limit
        /// value then intermediate router discards the request when TTL becomes 0.
        /// </summary>
        [JsonProperty(PropertyName = "maximum_hop_limit")]
        public int? MaximumHopLimit { get; set; }
        /// <summary>
        /// Flag to enable this BGP Neighbor
        /// </summary>
        [JsonProperty(PropertyName = "enabled")]
        public bool? Enabled { get; set; }
        /// <summary>
        /// 4 Byte ASN of the neighbor in ASPLAIN/ASDOT Format
        /// </summary>
        [JsonProperty(PropertyName = "remote_as_num")]
        public string? RemoteAsNum { get; set; }
        /// <summary>
        /// User can enable the neighbor for the specific address families and also define filters per address family.
        /// When the neighbor is created, it is default enabled for IPV4_UNICAST address family for backward compatibility reasons.
        /// User can change that if required, by defining the address family configuration.
        /// </summary>
        [JsonProperty(PropertyName = "address_families")]
        public IList<NSXTBgpNeighborAddressFamilyType> AddressFamilies { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [JsonProperty(PropertyName = "bfd_config")]
        public NSXTBfdConfigParametersType BfdConfig { get; set; }
        /// <summary>
        /// Logical router id
        /// </summary>
        [JsonProperty(PropertyName = "logical_router_id")]
        public string? LogicalRouterId { get; set; }
        /// <summary>
        /// This is a deprecated property, Please  use 'address_family' instead.
        /// </summary>
        [JsonProperty(PropertyName = "filter_in_ipprefixlist_id")]
        public string? FilterInIpprefixlistId { get; set; }
        /// <summary>
        /// This is a deprecated property, Please use 'address_family' instead.
        /// </summary>
        [JsonProperty(PropertyName = "filter_out_routemap_id")]
        public string? FilterOutRoutemapId { get; set; }
        /// <summary>
        /// This is a deprecated property, Please use 'address_family' instead.
        /// </summary>
        [JsonProperty(PropertyName = "filter_in_routemap_id")]
        public string? FilterInRoutemapId { get; set; }
        /// <summary>
        /// Frequency (seconds) with which keep alive messages are sent to peers
        /// </summary>
        [JsonProperty(PropertyName = "keep_alive_timer")]
        public long? KeepAliveTimer { get; set; }
        /// <summary>
        /// User can create (POST) the neighbor with or without the password.
        /// The view (GET) on the neighbor, would never reveal if the password is set or not.
        /// The password can be set later using edit neighbor workFlow (PUT)
        /// On the edit neighbor (PUT), if the user does not specify the password property, the
        /// older value is retained. Maximum length of this field is 20 characters.
        /// </summary>
        [JsonProperty(PropertyName = "password")]
        public string? Password { get; set; }
        /// <summary>
        /// Deprecated - do not provide a value for this field. Use source_addresses instead.
        /// </summary>
        [JsonProperty(PropertyName = "source_address")]
        public string? SourceAddress { get; set; }
        /// <summary>
        /// Flag to enable allowas_in option for BGP neighbor
        /// </summary>
        [JsonProperty(PropertyName = "allow_as_in")]
        public bool? AllowAsIn { get; set; }
        /// <summary>
        /// Flag to enable BFD for this BGP Neighbor. Enable this if the neighbor supports BFD as this will lead to faster
        /// convergence.
        /// </summary>
        [JsonProperty(PropertyName = "enable_bfd")]
        public bool? EnableBfd { get; set; }
        /// <summary>
        /// Neighbor IP Address
        /// </summary>
        [JsonProperty(PropertyName = "neighbor_address", Required = Required.AllowNull)]
        public string NeighborAddress { get; set; }
    }
}
