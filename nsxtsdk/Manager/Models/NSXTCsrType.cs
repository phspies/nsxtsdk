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
    public class NSXTCsrType : NSXTManagedResourceType
    {
        /// <summary>
        /// Size measured in bits of the public key used in a cryptographic algorithm.
        /// </summary>
        [JsonProperty(PropertyName = "key_size")]
        public long? KeySize { get; set; }
        /// <summary>
        /// PEM encoded certificate data.
        /// </summary>
        [JsonProperty(PropertyName = "pem_encoded")]
        public string? PemEncoded { get; set; }
        /// <summary>
        /// Cryptographic algorithm (asymmetric) used by the public key for data encryption.
        /// </summary>
        [JsonProperty(PropertyName = "algorithm")]
        [JsonConverter(typeof(StringEnumConverter))]
        public NSXTCsrAlgorithmEnumType? Algorithm { get; set; }
        /// <summary>
        /// Whether the CSR is for a CA certificate.
        /// </summary>
        [JsonProperty(PropertyName = "is_ca")]
        public bool? IsCa { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [JsonProperty(PropertyName = "subject", Required = Required.AllowNull)]
        public NSXTPrincipalType Subject { get; set; }
    }
}
