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
    public class NSXTSecurityCertificateType 
    {
        /// <summary>
        /// X.509 certificate in text form
        /// </summary>
        [JsonProperty(PropertyName = "text")]
        [NSXTProperty(IsRequired: false, Description: @"X.509 certificate in text form")]
        public string? Text { get; set; }
        /// <summary>
        /// The time when the certificate starts being valid
        /// </summary>
        [JsonProperty(PropertyName = "valid_from")]
        [NSXTProperty(IsRequired: false, Description: @"The time when the certificate starts being valid")]
        public string? ValidFrom { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [JsonProperty(PropertyName = "ssh_public_key")]
        [NSXTProperty(IsRequired: false, Description: @"")]
        public string? SshPublicKey { get; set; }
        /// <summary>
        /// The time when the certificate stops being valid
        /// </summary>
        [JsonProperty(PropertyName = "valid_to")]
        [NSXTProperty(IsRequired: false, Description: @"The time when the certificate stops being valid")]
        public string? ValidTo { get; set; }
        /// <summary>
        /// The certificate must include the enclosing "-----BEGIN CERTIFICATE-----" and "-----END CERTIFICATE-----"
        /// </summary>
        [JsonProperty(PropertyName = "pem_encoded", Required = Required.AllowNull)]
        [NSXTProperty(IsRequired: true, Description: @"The certificate must include the enclosing &quot;-----BEGIN CERTIFICATE-----&quot; and &quot;-----END CERTIFICATE-----&quot;")]
        [System.ComponentModel.DataAnnotations.Required]
        public string PemEncoded { get; set; }
    }
}
