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
    /// The certificate chain presented by a remote TLS service.
    /// </summary>
    [NSXTProperty(Description: @"The certificate chain presented by a remote TLS service.")]
    public class NSXTPeerCertificateChainType 
    {
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
    }
}
