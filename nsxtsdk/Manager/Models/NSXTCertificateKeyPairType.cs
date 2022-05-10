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
    public class NSXTCertificateKeyPairType 
    {
        /// <summary>
        /// The private key must include the enclosing "-----BEGIN RSA PRIVATE KEY-----" and "-----END RSA PRIVATE KEY-----". An
        /// empty string is returned in read responses.
        /// </summary>
        [JsonProperty(PropertyName = "rsa_private_key")]
        public string? RsaPrivateKey { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [JsonProperty(PropertyName = "certificate", Required = Required.AllowNull)]
        public NSXTSecurityCertificateType Certificate { get; set; }
    }
}
