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
    public class NSXTL3VpnType : NSXTPolicyConfigResourceType
    {
        /// <summary>
        /// This field is used to resolve conflicts in case of a remote site being
        /// behind NAT as remote public ip address is not enough. If it is not the
        /// case the remote public address should be provided here. If not provided,
        /// the value of this field is set to remote_public_address.
        /// </summary>
        [JsonProperty(PropertyName = "remote_private_address")]
        public string? RemotePrivateAddress { get; set; }
        /// <summary>
        /// Algorithm to be used for message digest during tunnel establishment.
        /// Default algorithm is empty.
        /// </summary>
        [JsonProperty(PropertyName = "tunnel_digest_algorithms")]
        public IList<string> TunnelDigestAlgorithms { get; set; }
        /// <summary>
        /// List of IPSec pre-shared keys used for IPSec authentication. If not
        /// specified, the older passphrase values are retained if there are any.
        /// </summary>
        [JsonProperty(PropertyName = "passphrases")]
        public IList<string> Passphrases { get; set; }
        /// <summary>
        /// If true, perfect forward secrecy (PFS) is enabled.
        /// </summary>
        [JsonProperty(PropertyName = "enable_perfect_forward_secrecy")]
        public bool? EnablePerfectForwardSecrecy { get; set; }
        /// <summary>
        /// Algorithm to be used for message digest during Internet Key Exchange(IKE)
        /// negotiation. Default is SHA2_256.
        /// </summary>
        [JsonProperty(PropertyName = "ike_digest_algorithms")]
        public IList<string> IkeDigestAlgorithms { get; set; }
        /// <summary>
        /// IKE protocol version to be used. IKE-Flex will initiate IKE-V2 and responds
        /// to both IKE-V1 and IKE-V2.
        /// </summary>
        [JsonProperty(PropertyName = "ike_version")]
        [JsonConverter(typeof(StringEnumConverter))]
        public NSXTL3VpnIkeVersionEnumType? IkeVersion { get; set; }
        /// <summary>
        /// Algorithm to be used during Internet Key Exchange(IKE) negotiation.
        /// Default is AES_128.
        /// </summary>
        [JsonProperty(PropertyName = "ike_encryption_algorithms")]
        public IList<string> IkeEncryptionAlgorithms { get; set; }
        /// <summary>
        /// IPv4 address of local gateway
        /// </summary>
        [JsonProperty(PropertyName = "local_address", Required = Required.AllowNull)]
        public string LocalAddress { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [JsonProperty(PropertyName = "l3vpn_session", Required = Required.AllowNull)]
        public NSXTL3VpnSessionType L3vpnSession { get; set; }
        /// <summary>
        /// Diffie-Hellman group to be used if PFS is enabled. Default group is GROUP14.
        /// </summary>
        [JsonProperty(PropertyName = "dh_groups")]
        public IList<string> DhGroups { get; set; }
        /// <summary>
        /// Encryption algorithm to encrypt/decrypt the messages exchanged between
        /// IPSec VPN initiator and responder during tunnel negotiation. Default is
        /// AES_GCM_128.
        /// </summary>
        [JsonProperty(PropertyName = "tunnel_encryption_algorithms")]
        public IList<string> TunnelEncryptionAlgorithms { get; set; }
        /// <summary>
        /// Flag to enable L3Vpn. Default is enabled.
        /// </summary>
        [JsonProperty(PropertyName = "enabled")]
        public bool? Enabled { get; set; }
        /// <summary>
        /// Public IPv4 address of remote gateway
        /// </summary>
        [JsonProperty(PropertyName = "remote_public_address", Required = Required.AllowNull)]
        public string RemotePublicAddress { get; set; }
    }
}
