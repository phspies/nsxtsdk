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
    public class NSXTCertificateType : NSXTManagedResourceType
    {
        /// <summary>
        /// Purpose of this certificate. Can be empty or set to "signing-ca".
        /// </summary>
        [JsonProperty(PropertyName = "purpose")]
        [JsonConverter(typeof(StringEnumConverter))]
        public NSXTCertificatePurposeEnumType? Purpose { get; set; }
        /// <summary>
        /// List of node IDs with services, that are using this certificate.
        /// </summary>
        [JsonProperty(PropertyName = "used_by")]
        public IList<NSXTNodeIdServicesMapType> UsedBy { get; set; }
        /// <summary>
        /// List of X509Certificates.
        /// </summary>
        [JsonProperty(PropertyName = "details")]
        public IList<NSXTX509CertificateType> Details { get; set; }
        /// <summary>
        /// PEM encoded certificate data.
        /// </summary>
        [JsonProperty(PropertyName = "pem_encoded", Required = Required.AllowNull)]
        public string PemEncoded { get; set; }
        /// <summary>
        /// Whether we have the private key for this certificate.
        /// </summary>
        [JsonProperty(PropertyName = "has_private_key")]
        public bool? HasPrivateKey { get; set; }
    }
}
