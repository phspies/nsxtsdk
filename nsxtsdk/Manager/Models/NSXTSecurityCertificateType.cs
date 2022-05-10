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
    public class NSXTSecurityCertificateType 
    {
        /// <summary>
        /// X.509 certificate in text form
        /// </summary>
        [JsonProperty(PropertyName = "text")]
        public string? Text { get; set; }
        /// <summary>
        /// The time when the certificate starts being valid
        /// </summary>
        [JsonProperty(PropertyName = "valid_from")]
        public string? ValidFrom { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [JsonProperty(PropertyName = "ssh_public_key")]
        public string? SshPublicKey { get; set; }
        /// <summary>
        /// The time when the certificate stops being valid
        /// </summary>
        [JsonProperty(PropertyName = "valid_to")]
        public string? ValidTo { get; set; }
        /// <summary>
        /// The certificate must include the enclosing "-----BEGIN CERTIFICATE-----" and "-----END CERTIFICATE-----"
        /// </summary>
        [JsonProperty(PropertyName = "pem_encoded", Required = Required.AllowNull)]
        public string PemEncoded { get; set; }
    }
}
