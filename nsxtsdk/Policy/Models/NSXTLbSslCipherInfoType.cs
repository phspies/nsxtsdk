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
    /// SSL cipher
    /// </summary>
    [NSXTProperty(Description: @"SSL cipher")]
    public class NSXTLbSslCipherInfoType 
    {
        public NSXTLbSslCipherInfoType()
        {
        }
        /// <summary>
        /// Default SSL cipher flag
        /// </summary>
        [JsonProperty(PropertyName = "is_default", Required = Required.AllowNull)]
        [NSXTProperty(IsRequired: true, Description: @"Default SSL cipher flag")]
        [System.ComponentModel.DataAnnotations.Required]
        public bool IsDefault { get; set; }
        /// <summary>
        /// Secure/insecure SSL cipher flag
        /// </summary>
        [JsonProperty(PropertyName = "is_secure", Required = Required.AllowNull)]
        [NSXTProperty(IsRequired: true, Description: @"Secure/insecure SSL cipher flag")]
        [System.ComponentModel.DataAnnotations.Required]
        public bool IsSecure { get; set; }
        /// <summary>
        /// Several cipher groups might contain the same cipher suite, each cipher
        /// suite could have multiple cipher group labels.
        /// </summary>
        [JsonProperty(PropertyName = "cipher_group_labels")]
        [NSXTProperty(IsRequired: false, Description: @"Several cipher groups might contain the same cipher suite, each ciphersuite could have multiple cipher group labels.")]
        public IList<string> CipherGroupLabels { get; set; }
        /// <summary>
        /// SSL cipher
        /// </summary>
        [JsonProperty(PropertyName = "cipher", Required = Required.AllowNull)]
        [NSXTProperty(IsRequired: true, Description: @"SSL cipher")]
        [System.ComponentModel.DataAnnotations.Required]
        public NSXTLbSslCipherInfoCipherEnumType Cipher { get; set; }
    }
}
