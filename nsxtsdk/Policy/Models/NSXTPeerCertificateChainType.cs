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
    /// The certificate chain presented by a remote TLS service.
    /// </summary>
    [NSXTProperty(Description: @"The certificate chain presented by a remote TLS service.")]
    public class NSXTPeerCertificateChainType 
    {
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
    }
}