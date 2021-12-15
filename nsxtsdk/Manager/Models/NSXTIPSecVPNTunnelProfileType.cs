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
        [NSXTProperty(IsRequired: false, Description: @"Encapsulation Mode to be used for encryption of packet. Tunnel mode protects internal routing information by encrypting IP header of original packet.")]
        [NSXTDefaultProperty(Default: "TUNNEL_MODE")]
        public NSXTIpsecVpntunnelProfileEncapsulationModeEnumType? EncapsulationMode { get; set; }
        /// <summary>
        /// IPSec transform specifies IPSec security protocol.
        /// </summary>
        [JsonProperty(PropertyName = "transform_protocol")]
        [NSXTProperty(IsRequired: false, Description: @"IPSec transform specifies IPSec security protocol.")]
        [NSXTDefaultProperty(Default: "ESP")]
        public NSXTIpsecVpntunnelProfileTransformProtocolEnumType? TransformProtocol { get; set; }
        /// <summary>
        /// Algorithm to be used for message digest. Default digest algorithm is implicitly covered by default encryption algorithm
        /// "AES_GCM_128".
        /// </summary>
        [JsonProperty(PropertyName = "digest_algorithms")]
        [NSXTProperty(IsRequired: false, Description: @"Algorithm to be used for message digest. Default digest algorithm is implicitly covered by default encryption algorithm &quot;AES_GCM_128&quot;.")]
        public IList<string> DigestAlgorithms { get; set; }
        /// <summary>
        /// Encryption algorithm to encrypt/decrypt the messages exchanged between IPSec VPN initiator and responder during tunnel
        /// negotiation. Default is AES_GCM_128.
        /// </summary>
        [JsonProperty(PropertyName = "encryption_algorithms")]
        [NSXTProperty(IsRequired: false, Description: @"Encryption algorithm to encrypt/decrypt the messages exchanged between IPSec VPN initiator and responder during tunnel negotiation. Default is AES_GCM_128.")]
        public IList<string> EncryptionAlgorithms { get; set; }
        /// <summary>
        /// If true, perfect forward secrecy (PFS) is enabled.
        /// </summary>
        [JsonProperty(PropertyName = "enable_perfect_forward_secrecy")]
        [NSXTProperty(IsRequired: false, Description: @"If true, perfect forward secrecy (PFS) is enabled.")]
        [NSXTDefaultProperty(Default: "")]
        public bool? EnablePerfectForwardSecrecy { get; set; }
        /// <summary>
        /// Diffie-Hellman group to be used if PFS is enabled. Default is GROUP14.
        /// </summary>
        [JsonProperty(PropertyName = "dh_groups")]
        [NSXTProperty(IsRequired: false, Description: @"Diffie-Hellman group to be used if PFS is enabled. Default is GROUP14.")]
        public IList<string> DhGroups { get; set; }
        /// <summary>
        /// Defragmentation policy helps to handle defragmentation bit present in the inner packet. COPY copies the defragmentation
        /// bit from the inner IP packet into the outer packet. CLEAR ignores the defragmentation bit present in the inner packet.
        /// </summary>
        [JsonProperty(PropertyName = "df_policy")]
        [NSXTProperty(IsRequired: false, Description: @"Defragmentation policy helps to handle defragmentation bit present in the inner packet. COPY copies the defragmentation bit from the inner IP packet into the outer packet. CLEAR ignores the defragmentation bit present in the inner packet.")]
        [NSXTDefaultProperty(Default: "COPY")]
        public NSXTIpsecVpntunnelProfileDfPolicyEnumType? DfPolicy { get; set; }
        /// <summary>
        /// SA life time specifies the expiry time of security
        /// association. Default is 3600 seconds.
        /// </summary>
        [JsonProperty(PropertyName = "sa_life_time")]
        [NSXTProperty(IsRequired: false, Description: @"SA life time specifies the expiry time of securityassociation. Default is 3600 seconds.")]
        //[System.ComponentModel.DataAnnotations.MinLength(900)]
        //[System.ComponentModel.DataAnnotations.MaxLength(31536000)]
        [NSXTDefaultProperty(Default: "")]
        public long? SaLifeTime { get; set; }
    }
}