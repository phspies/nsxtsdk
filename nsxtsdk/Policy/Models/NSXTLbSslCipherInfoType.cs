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
    /// SSL cipher
    /// </summary>
    [NSXTProperty(Description: @"SSL cipher")]
    public class NSXTLbSslCipherInfoType 
    {
        /// <summary>
        /// Default SSL cipher flag
        /// </summary>
        [JsonProperty(PropertyName = "is_default", Required = Required.AllowNull)]
        public bool IsDefault { get; set; }
        /// <summary>
        /// Secure/insecure SSL cipher flag
        /// </summary>
        [JsonProperty(PropertyName = "is_secure", Required = Required.AllowNull)]
        public bool IsSecure { get; set; }
        /// <summary>
        /// Several cipher groups might contain the same cipher suite, each cipher
        /// suite could have multiple cipher group labels.
        /// </summary>
        [JsonProperty(PropertyName = "cipher_group_labels")]
        public IList<string> CipherGroupLabels { get; set; }
        /// <summary>
        /// SSL cipher
        /// </summary>
        [JsonProperty(PropertyName = "cipher", Required = Required.AllowNull)]
        [JsonConverter(typeof(StringEnumConverter))]
        public NSXTLbSslCipherInfoCipherEnumType Cipher { get; set; }
    }
}
