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

namespace nsxtsdk.PolicyModels
{
    /// <summary>
    /// 
    /// </summary>
    [NSXTProperty(Description: @"")]
    public class NSXTTlsTrustDataType : NSXTPolicyConfigResourceType
    {
        /// <summary>
        /// Key algorithm contained in this certificate.
        /// </summary>
        [JsonProperty(PropertyName = "key_algo")]
        [NSXTProperty(IsRequired: false, Description: @"Key algorithm contained in this certificate.")]
        public string? KeyAlgo { get; set; }
        /// <summary>
        /// private key data
        /// </summary>
        [JsonProperty(PropertyName = "private_key")]
        [NSXTProperty(IsRequired: false, Description: @"private key data")]
        public string? PrivateKey { get; set; }
        /// <summary>
        /// Password for private key encryption.
        /// </summary>
        [JsonProperty(PropertyName = "passphrase")]
        [NSXTProperty(IsRequired: false, Description: @"Password for private key encryption.")]
        public string? Passphrase { get; set; }
        /// <summary>
        /// pem encoded certificate data.
        /// </summary>
        [JsonProperty(PropertyName = "pem_encoded", Required = Required.AllowNull)]
        [NSXTProperty(IsRequired: true, Description: @"pem encoded certificate data.")]
        [System.ComponentModel.DataAnnotations.Required]
        public string PemEncoded { get; set; }
    }
}