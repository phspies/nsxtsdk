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
    public class NSXTALBSSLProfileType : NSXTPolicyConfigResourceType
    {
        /// <summary>
        /// The amount of time in seconds before an SSL session
        /// expires.
        /// Unit is SEC.
        /// Default value when not specified in API or module is
        /// interpreted by ALB Controller as 86400.
        /// </summary>
        [JsonProperty(PropertyName = "ssl_session_timeout")]
        public long? SslSessionTimeout { get; set; }
        /// <summary>
        /// Ciphers suites represented as defined by https
        /// //www.openssl.org/docs/apps/ciphers.html.
        /// Default value when not specified in API or module is
        /// interpreted by ALB Controller as AES:3DES:RC4.
        /// </summary>
        [JsonProperty(PropertyName = "accepted_ciphers")]
        public string? AcceptedCiphers { get; set; }
        /// <summary>
        /// Prefer the SSL cipher ordering presented by the client
        /// during the SSL handshake over the one specified in the SSL
        /// Profile.
        /// Default value when not specified in API or module is
        /// interpreted by ALB Controller as false.
        /// </summary>
        [JsonProperty(PropertyName = "prefer_client_cipher_ordering")]
        public bool? PreferClientCipherOrdering { get; set; }
        /// <summary>
        /// Placeholder for description of property tags of obj type
        /// SSLProfile field type str  type array.
        /// </summary>
        [JsonProperty(PropertyName = "avi_tags")]
        public IList<NSXTALBTagType> AviTags { get; set; }
        /// <summary>
        /// SSL Profile Type.
        /// Enum options - SSL_PROFILE_TYPE_APPLICATION,
        /// SSL_PROFILE_TYPE_SYSTEM.
        /// Default value when not specified in API or module is
        /// interpreted by ALB Controller as
        /// SSL_PROFILE_TYPE_APPLICATION.
        /// </summary>
        [JsonProperty(PropertyName = "type")]
        [JsonConverter(typeof(StringEnumConverter))]
        public NSXTAlbsslprofileTypeEnumType? Type { get; set; }
        /// <summary>
        /// Set of versions accepted by the server.
        /// Minimum of 1 items required.
        /// </summary>
        [JsonProperty(PropertyName = "accepted_versions", Required = Required.AllowNull)]
        public IList<NSXTALBSSLVersionType> AcceptedVersions { get; set; }
        /// <summary>
        /// List of labels to be used for granular RBAC.
        /// Allowed in Basic edition, Essentials edition, Enterprise
        /// edition.
        /// </summary>
        [JsonProperty(PropertyName = "markers")]
        public IList<NSXTALBRoleFilterMatchLabelType> Markers { get; set; }
        /// <summary>
        /// Enum options - TLS_ECDHE_ECDSA_WITH_AES_128_GCM_SHA256,
        /// TLS_ECDHE_ECDSA_WITH_AES_256_GCM_SHA384,
        /// TLS_ECDHE_RSA_WITH_AES_128_GCM_SHA256,
        /// TLS_ECDHE_RSA_WITH_AES_256_GCM_SHA384,
        /// TLS_ECDHE_ECDSA_WITH_AES_128_CBC_SHA256,
        /// TLS_ECDHE_ECDSA_WITH_AES_256_CBC_SHA384,
        /// TLS_ECDHE_RSA_WITH_AES_128_CBC_SHA256,
        /// TLS_ECDHE_RSA_WITH_AES_256_CBC_SHA384,
        /// TLS_RSA_WITH_AES_128_GCM_SHA256,
        /// TLS_RSA_WITH_AES_256_GCM_SHA384,
        /// TLS_RSA_WITH_AES_128_CBC_SHA256,
        /// TLS_RSA_WITH_AES_256_CBC_SHA256,
        /// TLS_ECDHE_ECDSA_WITH_AES_128_CBC_SHA,
        /// TLS_ECDHE_ECDSA_WITH_AES_256_CBC_SHA,
        /// TLS_ECDHE_RSA_WITH_AES_128_CBC_SHA,
        /// TLS_ECDHE_RSA_WITH_AES_256_CBC_SHA,
        /// TLS_RSA_WITH_AES_128_CBC_SHA, TLS_RSA_WITH_AES_256_CBC_SHA,
        /// TLS_RSA_WITH_3DES_EDE_CBC_SHA, TLS_AES_256_GCM_SHA384...
        /// Allowed in Basic(Allowed values-
        /// TLS_ECDHE_ECDSA_WITH_AES_128_GCM_SHA256,TLS_ECDHE_ECDSA_WITH_AES_256_GCM_SHA384,TLS_ECDHE_RSA_WITH_AES_128_GCM_SHA256,TLS_ECDHE_RSA_WITH_AES_256_GCM_SHA384,TLS_ECDHE_ECDSA_WITH_AES_128_CBC_SHA256,TLS_ECDHE_ECDSA_WITH_AES_256_CBC_SHA384,TLS_ECDHE_RSA_WITH_AES_128_CBC_SHA256,TLS_ECDHE_RSA_WITH_AES_256_CBC_SHA384,TLS_RSA_WITH_AES_128_GCM_SHA256,TLS_RSA_WITH_AES_256_GCM_SHA384,TLS_RSA_WITH_AES_128_CBC_SHA256,TLS_RSA_WITH_AES_256_CBC_SHA256,TLS_ECDHE_ECDSA_WITH_AES_128_CBC_SHA,TLS_ECDHE_ECDSA_WITH_AES_256_CBC_SHA,TLS_ECDHE_RSA_WITH_AES_128_CBC_SHA,TLS_ECDHE_RSA_WITH_AES_256_CBC_SHA,TLS_RSA_WITH_AES_128_CBC_SHA,TLS_RSA_WITH_AES_256_CBC_SHA,TLS_RSA_WITH_3DES_EDE_CBC_SHA)
        /// edition, Essentials(Allowed values-
        /// TLS_ECDHE_ECDSA_WITH_AES_128_GCM_SHA256,TLS_ECDHE_ECDSA_WITH_AES_256_GCM_SHA384,TLS_ECDHE_RSA_WITH_AES_128_GCM_SHA256,TLS_ECDHE_RSA_WITH_AES_256_GCM_SHA384,TLS_ECDHE_ECDSA_WITH_AES_128_CBC_SHA256,TLS_ECDHE_ECDSA_WITH_AES_256_CBC_SHA384,TLS_ECDHE_RSA_WITH_AES_128_CBC_SHA256,TLS_ECDHE_RSA_WITH_AES_256_CBC_SHA384,TLS_RSA_WITH_AES_128_GCM_SHA256,TLS_RSA_WITH_AES_256_GCM_SHA384,TLS_RSA_WITH_AES_128_CBC_SHA256,TLS_RSA_WITH_AES_256_CBC_SHA256,TLS_ECDHE_ECDSA_WITH_AES_128_CBC_SHA,TLS_ECDHE_ECDSA_WITH_AES_256_CBC_SHA,TLS_ECDHE_RSA_WITH_AES_128_CBC_SHA,TLS_ECDHE_RSA_WITH_AES_256_CBC_SHA,TLS_RSA_WITH_AES_128_CBC_SHA,TLS_RSA_WITH_AES_256_CBC_SHA,TLS_RSA_WITH_3DES_EDE_CBC_SHA)
        /// edition, Enterprise edition.
        /// </summary>
        [JsonProperty(PropertyName = "cipher_enums")]
        public IList<string> CipherEnums { get; set; }
        /// <summary>
        /// Send 'close notify' alert message for a clean shutdown of
        /// the SSL connection.
        /// Default value when not specified in API or module is
        /// interpreted by ALB Controller as true.
        /// </summary>
        [JsonProperty(PropertyName = "send_close_notify")]
        public bool? SendCloseNotify { get; set; }
        /// <summary>
        /// Enable SSL session re-use.
        /// Default value when not specified in API or module is
        /// interpreted by ALB Controller as true.
        /// </summary>
        [JsonProperty(PropertyName = "enable_ssl_session_reuse")]
        public bool? EnableSslSessionReuse { get; set; }
        /// <summary>
        /// Enable early data processing for TLS1.3 connections.
        /// Allowed in Basic(Allowed values- false) edition,
        /// Essentials(Allowed values- false) edition, Enterprise
        /// edition.
        /// Default value when not specified in API or module is
        /// interpreted by ALB Controller as false.
        /// </summary>
        [JsonProperty(PropertyName = "enable_early_data")]
        public bool? EnableEarlyData { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [JsonProperty(PropertyName = "ssl_rating")]
        public NSXTALBSSLRatingType SslRating { get; set; }
        /// <summary>
        /// TLS 1.3 Ciphers suites represented as defined by U(https
        /// //www.openssl.org/docs/manmaster/man1/ciphers.html).
        /// Allowed in Basic edition, Essentials edition, Enterprise
        /// edition.
        /// Special default for Basic edition is
        /// TLS_AES_256_GCM_SHA384-TLS_AES_128_GCM_SHA256, Essentials
        /// edition is TLS_AES_256_GCM_SHA384-TLS_AES_128_GCM_SHA256,
        /// Enterprise is
        /// TLS_AES_256_GCM_SHA384-TLS_CHACHA20_POLY1305_SHA256-TLS_AES_128_GCM_SHA256.
        /// Default value when not specified in API or module is
        /// interpreted by ALB Controller as
        /// TLS_AES_256_GCM_SHA384:TLS_AES_128_GCM_SHA256.
        /// </summary>
        [JsonProperty(PropertyName = "ciphersuites")]
        public string? Ciphersuites { get; set; }
    }
}
