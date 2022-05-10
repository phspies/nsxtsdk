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
    public class NSXTTlsTrustDataType : NSXTPolicyConfigResourceType
    {
        /// <summary>
        /// Key algorithm contained in this certificate.
        /// </summary>
        [JsonProperty(PropertyName = "key_algo")]
        public string? KeyAlgo { get; set; }
        /// <summary>
        /// private key data
        /// </summary>
        [JsonProperty(PropertyName = "private_key")]
        public string? PrivateKey { get; set; }
        /// <summary>
        /// Password for private key encryption.
        /// </summary>
        [JsonProperty(PropertyName = "passphrase")]
        public string? Passphrase { get; set; }
        /// <summary>
        /// pem encoded certificate data.
        /// </summary>
        [JsonProperty(PropertyName = "pem_encoded", Required = Required.AllowNull)]
        public string PemEncoded { get; set; }
        /// <summary>
        /// Purpose of this certificate. Can be empty or set to "signing-ca".
        /// </summary>
        [JsonProperty(PropertyName = "purpose")]
        [JsonConverter(typeof(StringEnumConverter))]
        public NSXTTlsTrustDataPurposeEnumType? Purpose { get; set; }
    }
}
