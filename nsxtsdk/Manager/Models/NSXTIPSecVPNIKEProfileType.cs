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
    public class NSXTIPSecVPNIKEProfileType : NSXTManagedResourceType
    {
        /// <summary>
        /// Algorithm to be used for message digest during Internet Key Exchange(IKE) negotiation. Default is SHA2_256.
        /// </summary>
        [JsonProperty(PropertyName = "digest_algorithms")]
        public IList<string> DigestAlgorithms { get; set; }
        /// <summary>
        /// Encryption algorithm is used during Internet Key Exchange(IKE) negotiation. Default is AES_128.
        /// </summary>
        [JsonProperty(PropertyName = "encryption_algorithms")]
        public IList<string> EncryptionAlgorithms { get; set; }
        /// <summary>
        /// Diffie-Hellman group to be used if PFS is enabled. Default is GROUP14.
        /// </summary>
        [JsonProperty(PropertyName = "dh_groups")]
        public IList<string> DhGroups { get; set; }
        /// <summary>
        /// Life time for security association. Default is 86400 seconds (1 day).
        /// </summary>
        [JsonProperty(PropertyName = "sa_life_time")]
        public long? SaLifeTime { get; set; }
        /// <summary>
        /// IKE protocol version to be used. IKE-Flex will initiate IKE-V2 and responds to both IKE-V1 and IKE-V2.
        /// </summary>
        [JsonProperty(PropertyName = "ike_version")]
        [JsonConverter(typeof(StringEnumConverter))]
        public NSXTIpsecVpnikeprofileIkeVersionEnumType? IkeVersion { get; set; }
    }
}
