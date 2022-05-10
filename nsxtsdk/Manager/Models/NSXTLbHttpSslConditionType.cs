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
    public class NSXTLbHttpSslConditionType : NSXTLbRuleConditionType
    {
        /// <summary>
        /// Cipher list which supported by client
        /// </summary>
        [JsonProperty(PropertyName = "client_supported_ssl_ciphers")]
        public IList<string> ClientSupportedSslCiphers { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [JsonProperty(PropertyName = "client_certificate_issuer_dn")]
        public NSXTLbClientCertificateIssuerDnConditionType ClientCertificateIssuerDn { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [JsonProperty(PropertyName = "client_certificate_subject_dn")]
        public NSXTLbClientCertificateSubjectDnConditionType ClientCertificateSubjectDn { get; set; }
        /// <summary>
        /// Cipher used for an established SSL connection
        /// </summary>
        [JsonProperty(PropertyName = "used_ssl_cipher")]
        [JsonConverter(typeof(StringEnumConverter))]
        public NSXTLbHttpSslConditionUsedSslCipherEnumType? UsedSslCipher { get; set; }
        /// <summary>
        /// The type of SSL session reused
        /// </summary>
        [JsonProperty(PropertyName = "session_reused")]
        [JsonConverter(typeof(StringEnumConverter))]
        public NSXTLbHttpSslConditionSessionReusedEnumType? SessionReused { get; set; }
        /// <summary>
        /// Protocol of an established SSL connection
        /// </summary>
        [JsonProperty(PropertyName = "used_protocol")]
        [JsonConverter(typeof(StringEnumConverter))]
        public NSXTLbHttpSslConditionUsedProtocolEnumType? UsedProtocol { get; set; }
    }
}
