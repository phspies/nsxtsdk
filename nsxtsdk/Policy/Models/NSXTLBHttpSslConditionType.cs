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
    public class NSXTLBHttpSslConditionType : NSXTLBRuleConditionType
    {
        /// <summary>
        /// Cipher list which supported by client.
        /// </summary>
        [JsonProperty(PropertyName = "client_supported_ssl_ciphers")]
        public IList<string> ClientSupportedSslCiphers { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [JsonProperty(PropertyName = "client_certificate_issuer_dn")]
        public NSXTLBClientCertificateIssuerDnConditionType ClientCertificateIssuerDn { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [JsonProperty(PropertyName = "client_certificate_subject_dn")]
        public NSXTLBClientCertificateSubjectDnConditionType ClientCertificateSubjectDn { get; set; }
        /// <summary>
        /// Cipher used for an established SSL connection.
        /// </summary>
        [JsonProperty(PropertyName = "used_ssl_cipher")]
        [JsonConverter(typeof(StringEnumConverter))]
        public NSXTLbhttpSslConditionUsedSslCipherEnumType? UsedSslCipher { get; set; }
        /// <summary>
        /// The type of SSL session reused.
        /// </summary>
        [JsonProperty(PropertyName = "session_reused")]
        [JsonConverter(typeof(StringEnumConverter))]
        public NSXTLbhttpSslConditionSessionReusedEnumType? SessionReused { get; set; }
        /// <summary>
        /// Protocol of an established SSL connection.
        /// </summary>
        [JsonProperty(PropertyName = "used_protocol")]
        [JsonConverter(typeof(StringEnumConverter))]
        public NSXTLbhttpSslConditionUsedProtocolEnumType? UsedProtocol { get; set; }
    }
}
