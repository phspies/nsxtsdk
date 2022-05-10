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
    public class NSXTTrustObjectDataType : NSXTManagedResourceType
    {
        /// <summary>
        /// Key algorithm contained in this certificate.
        /// </summary>
        [JsonProperty(PropertyName = "key_algo")]
        public string? KeyAlgo { get; set; }
        /// <summary>
        /// Private key data.
        /// </summary>
        [JsonProperty(PropertyName = "private_key")]
        public string? PrivateKey { get; set; }
        /// <summary>
        /// Password for private key encryption.
        /// </summary>
        [JsonProperty(PropertyName = "passphrase")]
        public string? Passphrase { get; set; }
        /// <summary>
        /// PEM encoded certificate data.
        /// </summary>
        [JsonProperty(PropertyName = "pem_encoded", Required = Required.AllowNull)]
        public string PemEncoded { get; set; }
        /// <summary>
        /// Purpose of this certificate. Can be empty or set to "signing-ca".
        /// </summary>
        [JsonProperty(PropertyName = "purpose")]
        [JsonConverter(typeof(StringEnumConverter))]
        public NSXTTrustObjectDataPurposeEnumType? Purpose { get; set; }
    }
}
