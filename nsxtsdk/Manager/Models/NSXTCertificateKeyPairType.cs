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
    public class NSXTCertificateKeyPairType 
    {
        /// <summary>
        /// The private key must include the enclosing "-----BEGIN RSA PRIVATE KEY-----" and "-----END RSA PRIVATE KEY-----". An
        /// empty string is returned in read responses.
        /// </summary>
        [JsonProperty(PropertyName = "rsa_private_key")]
        [NSXTProperty(IsRequired: false, Description: @"The private key must include the enclosing &quot;-----BEGIN RSA PRIVATE KEY-----&quot; and &quot;-----END RSA PRIVATE KEY-----&quot;. An empty string is returned in read responses.")]
        public string? RsaPrivateKey { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [JsonProperty(PropertyName = "certificate", Required = Required.AllowNull)]
        [NSXTProperty(IsRequired: true, Description: @"")]
        [System.ComponentModel.DataAnnotations.Required]
        public NSXTSecurityCertificateType Certificate { get; set; }
    }
}
