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
    public class NSXTCertificateType : NSXTManagedResourceType
    {
        public NSXTCertificateType()
        {
        }
        /// <summary>
        /// Purpose of this certificate. Can be empty or set to "signing-ca".
        /// </summary>
        [JsonProperty(PropertyName = "purpose")]
        [NSXTProperty(IsRequired: false, Description: @"Purpose of this certificate. Can be empty or set to &quot;signing-ca&quot;.")]
        public NSXTCertificatePurposeEnumType? Purpose { get; set; }
        /// <summary>
        /// List of node IDs with services, that are using this certificate.
        /// </summary>
        [JsonProperty(PropertyName = "used_by")]
        [NSXTProperty(IsRequired: false, Description: @"List of node IDs with services, that are using this certificate.")]
        public IList<NSXTNodeIdServicesMapType> UsedBy { get; set; }
        /// <summary>
        /// List of X509Certificates.
        /// </summary>
        [JsonProperty(PropertyName = "details")]
        [NSXTProperty(IsRequired: false, Description: @"List of X509Certificates.")]
        public IList<NSXTX509CertificateType> Details { get; set; }
        /// <summary>
        /// PEM encoded certificate data.
        /// </summary>
        [JsonProperty(PropertyName = "pem_encoded", Required = Required.AllowNull)]
        [NSXTProperty(IsRequired: true, Description: @"PEM encoded certificate data.")]
        [System.ComponentModel.DataAnnotations.Required]
        public string PemEncoded { get; set; }
        /// <summary>
        /// Whether we have the private key for this certificate.
        /// </summary>
        [JsonProperty(PropertyName = "has_private_key")]
        [NSXTProperty(IsRequired: false, Description: @"Whether we have the private key for this certificate.")]
        public bool? HasPrivateKey { get; set; }
    }
}
