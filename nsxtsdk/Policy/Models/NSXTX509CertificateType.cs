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
    public class NSXTX509CertificateType 
    {
        /// <summary>
        /// The order of the middle term(s) of the reduction polynomial in elliptic curve (EC) | characteristic 2 finite field.|
        /// Contents of this array are copied to protect against subsequent modification in ECDSA.
        /// </summary>
        [JsonProperty(PropertyName = "ecdsa_ec_field_f2mks")]
        public long? EcdsaEcFieldF2mks { get; set; }
        /// <summary>
        /// Certificate version (default v1).
        /// </summary>
        [JsonProperty(PropertyName = "version")]
        public string? Version { get; set; }
        /// <summary>
        /// True if this is a CA certificate.
        /// </summary>
        [JsonProperty(PropertyName = "is_ca")]
        public bool? IsCa { get; set; }
        /// <summary>
        /// The algorithm used by the Certificate Authority to sign the certificate.
        /// </summary>
        [JsonProperty(PropertyName = "signature_algorithm")]
        public string? SignatureAlgorithm { get; set; }
        /// <summary>
        /// The first coefficient of this elliptic curve in ECDSA.
        /// </summary>
        [JsonProperty(PropertyName = "ecdsa_public_key_a")]
        public string? EcdsaPublicKeyA { get; set; }
        /// <summary>
        /// An RSA public key is made up of the modulus and the public exponent. Exponent is a power number.
        /// </summary>
        [JsonProperty(PropertyName = "rsa_public_key_exponent")]
        public string? RsaPublicKeyExponent { get; set; }
        /// <summary>
        /// The first coefficient of this elliptic curve in elliptic curve (EC) | characteristic 2 finite field for ECDSA.
        /// </summary>
        [JsonProperty(PropertyName = "ecdsa_ec_field_f2mm")]
        public long? EcdsaEcFieldF2mm { get; set; }
        /// <summary>
        /// The certificate issuer's common name.
        /// </summary>
        [JsonProperty(PropertyName = "issuer_cn")]
        public string? IssuerCn { get; set; }
        /// <summary>
        /// The certificate owner's common name.
        /// </summary>
        [JsonProperty(PropertyName = "subject_cn")]
        public string? SubjectCn { get; set; }
        /// <summary>
        /// The order of generator G in ECDSA.
        /// </summary>
        [JsonProperty(PropertyName = "ecdsa_public_key_order")]
        public string? EcdsaPublicKeyOrder { get; set; }
        /// <summary>
        /// The value whose i-th bit corresponds to the i-th coefficient of the reduction polynomial | in elliptic curve (EC)
        /// characteristic 2 finite field for ECDSA.
        /// </summary>
        [JsonProperty(PropertyName = "ecdsa_ec_field_f2mrp")]
        public string? EcdsaEcFieldF2mrp { get; set; }
        /// <summary>
        /// Size measured in bits of the public/private keys used in a cryptographic algorithm.
        /// </summary>
        [JsonProperty(PropertyName = "public_key_length")]
        public long? PublicKeyLength { get; set; }
        /// <summary>
        /// The time in epoch milliseconds at which the certificate becomes valid.
        /// </summary>
        [JsonProperty(PropertyName = "not_before")]
        public long? NotBefore { get; set; }
        /// <summary>
        /// The specified prime for the elliptic curve prime finite field in ECDSA.
        /// </summary>
        [JsonProperty(PropertyName = "ecdsa_ec_field_f2pp")]
        public string? EcdsaEcFieldF2pp { get; set; }
        /// <summary>
        /// The certificate issuers complete distinguished name.
        /// </summary>
        [JsonProperty(PropertyName = "issuer")]
        public string? Issuer { get; set; }
        /// <summary>
        /// The second coefficient of this elliptic curve in ECDSA.
        /// </summary>
        [JsonProperty(PropertyName = "ecdsa_public_key_b")]
        public string? EcdsaPublicKeyB { get; set; }
        /// <summary>
        /// An RSA public key is made up of the modulus and the public exponent. Modulus is wrap around number.
        /// </summary>
        [JsonProperty(PropertyName = "rsa_public_key_modulus")]
        public string? RsaPublicKeyModulus { get; set; }
        /// <summary>
        /// One of the DSA cryptogaphic algorithm's strength parameters.
        /// </summary>
        [JsonProperty(PropertyName = "dsa_public_key_y")]
        public string? DsaPublicKeyY { get; set; }
        /// <summary>
        /// The co-factor in ECDSA.
        /// </summary>
        [JsonProperty(PropertyName = "ecdsa_public_key_cofactor")]
        public long? EcdsaPublicKeyCofactor { get; set; }
        /// <summary>
        /// The time in epoch milliseconds at which the certificate becomes invalid.
        /// </summary>
        [JsonProperty(PropertyName = "not_after")]
        public long? NotAfter { get; set; }
        /// <summary>
        /// One of the DSA cryptogaphic algorithm's strength parameters, sub-prime.
        /// </summary>
        [JsonProperty(PropertyName = "dsa_public_key_q")]
        public string? DsaPublicKeyQ { get; set; }
        /// <summary>
        /// One of the DSA cryptogaphic algorithm's strength parameters, prime.
        /// </summary>
        [JsonProperty(PropertyName = "dsa_public_key_p")]
        public string? DsaPublicKeyP { get; set; }
        /// <summary>
        /// Y co-ordinate of G (the generator which is also known as the base point) in ECDSA.
        /// </summary>
        [JsonProperty(PropertyName = "ecdsa_public_key_generator_y")]
        public string? EcdsaPublicKeyGeneratorY { get; set; }
        /// <summary>
        /// X co-ordinate of G (the generator which is also known as the base point) in ECDSA.
        /// </summary>
        [JsonProperty(PropertyName = "ecdsa_public_key_generator_x")]
        public string? EcdsaPublicKeyGeneratorX { get; set; }
        /// <summary>
        /// Cryptographic algorithm used by the public key for data encryption.
        /// </summary>
        [JsonProperty(PropertyName = "public_key_algo")]
        public string? PublicKeyAlgo { get; set; }
        /// <summary>
        /// True if this certificate is valid.
        /// </summary>
        [JsonProperty(PropertyName = "is_valid")]
        public bool? IsValid { get; set; }
        /// <summary>
        /// The bytes used during curve generation for later validation in ECDSA.| Contents of this array are copied to protect
        /// against subsequent modification.
        /// </summary>
        [JsonProperty(PropertyName = "ecdsa_public_key_seed")]
        public IList<string> EcdsaPublicKeySeed { get; set; }
        /// <summary>
        /// The signature value(the raw signature bits) used for signing and validate the cert.
        /// </summary>
        [JsonProperty(PropertyName = "signature")]
        public string? Signature { get; set; }
        /// <summary>
        /// Certificate's serial number.
        /// </summary>
        [JsonProperty(PropertyName = "serial_number")]
        public string? SerialNumber { get; set; }
        /// <summary>
        /// One of the DSA cryptogaphic algorithm's strength parameters, base.
        /// </summary>
        [JsonProperty(PropertyName = "dsa_public_key_g")]
        public string? DsaPublicKeyG { get; set; }
        /// <summary>
        /// The certificate owners complete distinguished name.
        /// </summary>
        [JsonProperty(PropertyName = "subject")]
        public string? Subject { get; set; }
        /// <summary>
        /// Represents an elliptic curve (EC) finite field in ECDSA.
        /// </summary>
        [JsonProperty(PropertyName = "ecdsa_ec_field")]
        [JsonConverter(typeof(StringEnumConverter))]
        public NSXTX509CertificateEcdsaEcFieldEnumType? EcdsaEcField { get; set; }
        /// <summary>
        /// The Curve name for the ECDSA certificate.
        /// </summary>
        [JsonProperty(PropertyName = "ecdsa_curve_name")]
        public string? EcdsaCurveName { get; set; }
    }
}
