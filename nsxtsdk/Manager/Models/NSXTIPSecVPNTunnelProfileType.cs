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
    public class NSXTIPSecVPNTunnelProfileType : NSXTManagedResourceType
    {
        /// <summary>
        /// Encapsulation Mode to be used for encryption of packet. Tunnel mode protects internal routing information by encrypting
        /// IP header of original packet.
        /// </summary>
        [JsonProperty(PropertyName = "encapsulation_mode")]
        [JsonConverter(typeof(StringEnumConverter))]
        public NSXTIpsecVpntunnelProfileEncapsulationModeEnumType? EncapsulationMode { get; set; }
        /// <summary>
        /// IPSec transform specifies IPSec security protocol.
        /// </summary>
        [JsonProperty(PropertyName = "transform_protocol")]
        [JsonConverter(typeof(StringEnumConverter))]
        public NSXTIpsecVpntunnelProfileTransformProtocolEnumType? TransformProtocol { get; set; }
        /// <summary>
        /// Algorithm to be used for message digest. Default digest algorithm is implicitly covered by default encryption algorithm
        /// "AES_GCM_128".
        /// </summary>
        [JsonProperty(PropertyName = "digest_algorithms")]
        public IList<string> DigestAlgorithms { get; set; }
        /// <summary>
        /// Encryption algorithm to encrypt/decrypt the messages exchanged between IPSec VPN initiator and responder during tunnel
        /// negotiation. Default is AES_GCM_128.
        /// </summary>
        [JsonProperty(PropertyName = "encryption_algorithms")]
        public IList<string> EncryptionAlgorithms { get; set; }
        /// <summary>
        /// If true, perfect forward secrecy (PFS) is enabled.
        /// </summary>
        [JsonProperty(PropertyName = "enable_perfect_forward_secrecy")]
        public bool? EnablePerfectForwardSecrecy { get; set; }
        /// <summary>
        /// Diffie-Hellman group to be used if PFS is enabled. Default is GROUP14.
        /// </summary>
        [JsonProperty(PropertyName = "dh_groups")]
        public IList<string> DhGroups { get; set; }
        /// <summary>
        /// Defragmentation policy helps to handle defragmentation bit present in the inner packet. COPY copies the defragmentation
        /// bit from the inner IP packet into the outer packet. CLEAR ignores the defragmentation bit present in the inner packet.
        /// </summary>
        [JsonProperty(PropertyName = "df_policy")]
        [JsonConverter(typeof(StringEnumConverter))]
        public NSXTIpsecVpntunnelProfileDfPolicyEnumType? DfPolicy { get; set; }
        /// <summary>
        /// SA life time specifies the expiry time of security
        /// association. Default is 3600 seconds.
        /// </summary>
        [JsonProperty(PropertyName = "sa_life_time")]
        public long? SaLifeTime { get; set; }
    }
}
