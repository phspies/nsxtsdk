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
    public class NSXTTlsInspectionInternalProfileType : NSXTTlsProfileType
    {
        /// <summary>
        /// Action to take when TLS handshake fails.
        /// </summary>
        [JsonProperty(PropertyName = "decryption_fail_action")]
        [JsonConverter(typeof(StringEnumConverter))]
        public NSXTTlsInspectionInternalProfileDecryptionFailActionEnumType? DecryptionFailAction { get; set; }
        /// <summary>
        /// Server's list of cipher suites. Required if CryptoEnforcement
        /// is ENFORCE. e.g. TLS_ECDHE_RSA_WITH_AES_128_GCM_SHA256.
        /// </summary>
        [JsonProperty(PropertyName = "server_cipher_suite")]
        public IList<string> ServerCipherSuite { get; set; }
        /// <summary>
        /// If enforced and if TLS protocol Client/Server Hello has none of the
        /// permitted TLS versions or ciphers then the connection is immediately terminated.
        /// </summary>
        [JsonProperty(PropertyName = "crypto_enforcement")]
        [JsonConverter(typeof(StringEnumConverter))]
        public NSXTTlsInspectionInternalProfileCryptoEnforcementEnumType? CryptoEnforcement { get; set; }
        /// <summary>
        /// Pre-defined config settings. Settings could be one of Balanced, High Fidelity, High Security, Custom
        /// </summary>
        [JsonProperty(PropertyName = "tls_config_setting")]
        [JsonConverter(typeof(StringEnumConverter))]
        public NSXTTlsInspectionInternalProfileTlsConfigSettingEnumType? TlsConfigSetting { get; set; }
        /// <summary>
        /// Server certificate presented to the client.
        /// </summary>
        [JsonProperty(PropertyName = "server_certs_key", Required = Required.AllowNull)]
        public IList<string> ServerCertsKey { get; set; }
        /// <summary>
        /// Client's list of cipher suites. Required if CryptoEnforcement
        /// is ENFORCE. e.g. TLS_ECDHE_RSA_WITH_AES_128_GCM_SHA256.
        /// </summary>
        [JsonProperty(PropertyName = "client_cipher_suite")]
        public IList<string> ClientCipherSuite { get; set; }
        /// <summary>
        /// Client's minimum TLS version to enforce. Required if CryptoEnforcement is ENFORCE. Supported versions are TLS1.1 and
        /// TLS1.2.
        /// </summary>
        [JsonProperty(PropertyName = "client_min_tls_version")]
        [JsonConverter(typeof(StringEnumConverter))]
        public NSXTTlsInspectionInternalProfileClientMinTlsVersionEnumType? ClientMinTlsVersion { get; set; }
        /// <summary>
        /// true - enable the ocsp must staple, false - disable it.
        /// </summary>
        [JsonProperty(PropertyName = "ocsp_must_staple")]
        public bool? OcspMustStaple { get; set; }
        /// <summary>
        /// Server's minimum TLS version to enforce. Required if CryptoEnforcement is ENFORCE. supported versions are TLS1.1 and
        /// TLS1.2.
        /// </summary>
        [JsonProperty(PropertyName = "server_min_tls_version")]
        [JsonConverter(typeof(StringEnumConverter))]
        public NSXTTlsInspectionInternalProfileServerMinTlsVersionEnumType? ServerMinTlsVersion { get; set; }
        /// <summary>
        /// Server's maximum TLS version to enforce. Required if CryptoEnforcement is ENFORCE. Supported versions are TLS1.0, TLS1.1
        /// and TLS1.2
        /// </summary>
        [JsonProperty(PropertyName = "server_max_tls_version")]
        [JsonConverter(typeof(StringEnumConverter))]
        public NSXTTlsInspectionInternalProfileServerMaxTlsVersionEnumType? ServerMaxTlsVersion { get; set; }
        /// <summary>
        /// Client's maximum TLS version to enforce. Required if CryptoEnforcement is ENFORCE. Supported versions are TLS1.1 and
        /// TLS1.2.
        /// </summary>
        [JsonProperty(PropertyName = "client_max_tls_version")]
        [JsonConverter(typeof(StringEnumConverter))]
        public NSXTTlsInspectionInternalProfileClientMaxTlsVersionEnumType? ClientMaxTlsVersion { get; set; }
        /// <summary>
        /// Default server certificate presented to the user.
        /// </summary>
        [JsonProperty(PropertyName = "default_cert_key")]
        public string? DefaultCertKey { get; set; }
        /// <summary>
        /// true - enable the certificate validation; false - disable it.
        /// </summary>
        [JsonProperty(PropertyName = "certificate_validation")]
        public bool? CertificateValidation { get; set; }
    }
}
