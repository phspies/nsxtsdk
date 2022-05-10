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
    public class NSXTTlsCrlType : NSXTPolicyConfigResourceType
    {
        /// <summary>
        /// Certificates revoked by subject and public key hash
        /// </summary>
        [JsonProperty(PropertyName = "details_revoked_by_subject_and_public_key_hash")]
        public IList<NSXTSubjectPublicKeyHashType> DetailsRevokedBySubjectAndPublicKeyHash { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [JsonProperty(PropertyName = "details")]
        public NSXTX509CrlType Details { get; set; }
        /// <summary>
        /// Pem encoded crl data.
        /// </summary>
        [JsonProperty(PropertyName = "pem_encoded")]
        public string? PemEncoded { get; set; }
        /// <summary>
        /// JSON-encoded OneCRL-like object
        /// </summary>
        [JsonProperty(PropertyName = "one_crl")]
        public string? OneCrl { get; set; }
        /// <summary>
        /// The type of the CRL. It can be "OneCRL" or "X509" (default).
        /// </summary>
        [JsonProperty(PropertyName = "crl_type")]
        [JsonConverter(typeof(StringEnumConverter))]
        public NSXTTlsCrlCrlTypeEnumType? CrlType { get; set; }
        /// <summary>
        /// Certificates revoked by issuer and serial number
        /// </summary>
        [JsonProperty(PropertyName = "details_revoked_by_issuer_and_serial_number")]
        public IList<NSXTIssuerSerialNumberType> DetailsRevokedByIssuerAndSerialNumber { get; set; }
    }
}
