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
    public class NSXTLBClientSslProfileType : NSXTLBSslProfileType
    {
        /// <summary>
        /// SSL session caching allows SSL client and server to reuse previously
        /// negotiated security parameters avoiding the expensive public key
        /// operation during handshake.
        /// </summary>
        [JsonProperty(PropertyName = "session_cache_enabled")]
        public bool? SessionCacheEnabled { get; set; }
        /// <summary>
        /// Session cache timeout specifies how long the SSL session parameters
        /// are held on to and can be reused.
        /// </summary>
        [JsonProperty(PropertyName = "session_cache_timeout")]
        public long? SessionCacheTimeout { get; set; }
        /// <summary>
        /// It is a label of cipher group which is mostly consumed by GUI.
        /// </summary>
        [JsonProperty(PropertyName = "cipher_group_label")]
        [JsonConverter(typeof(StringEnumConverter))]
        public NSXTLbclientSslProfileCipherGroupLabelEnumType? CipherGroupLabel { get; set; }
        /// <summary>
        /// This flag is set to true when all the ciphers and protocols are FIPS
        /// compliant. It is set to false when one of the ciphers or protocols are
        /// not FIPS compliant..
        /// </summary>
        [JsonProperty(PropertyName = "is_fips")]
        public bool? IsFips { get; set; }
        /// <summary>
        /// This flag is set to true when all the ciphers and protocols are secure.
        /// It is set to false when one of the ciphers or protocols is insecure.
        /// </summary>
        [JsonProperty(PropertyName = "is_secure")]
        public bool? IsSecure { get; set; }
        /// <summary>
        /// During SSL handshake as part of the SSL client Hello client sends an
        /// ordered list of ciphers that it can support (or prefers) and typically
        /// server selects the first one from the top of that list it can also
        /// support. For Perfect Forward Secrecy(PFS), server could override the
        /// client's preference.
        /// </summary>
        [JsonProperty(PropertyName = "prefer_server_ciphers")]
        public bool? PreferServerCiphers { get; set; }
        /// <summary>
        /// Supported SSL cipher list to client side.
        /// </summary>
        [JsonProperty(PropertyName = "ciphers")]
        public IList<string> Ciphers { get; set; }
        /// <summary>
        /// SSL versions TLS1.1 and TLS1.2 are supported and enabled by default.
        /// SSLv2, SSLv3, and TLS1.0 are supported, but disabled by default.
        /// </summary>
        [JsonProperty(PropertyName = "protocols")]
        public IList<string> Protocols { get; set; }
    }
}
