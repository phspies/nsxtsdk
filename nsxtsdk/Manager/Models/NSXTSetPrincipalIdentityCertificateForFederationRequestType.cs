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
    /// Data for setting a principal identity certificate
    /// </summary>
    [NSXTProperty(Description: @"Data for setting a principal identity certificate")]
    public class NSXTSetPrincipalIdentityCertificateForFederationRequestType 
    {
        /// <summary>
        /// Service type for which the certificate should be used.
        /// </summary>
        [JsonProperty(PropertyName = "service_type")]
        [JsonConverter(typeof(StringEnumConverter))]
        public NSXTSetPrincipalIdentityCertificateForFederationRequestServiceTypeEnumType? ServiceType { get; set; }
        /// <summary>
        /// Id of the certificate
        /// </summary>
        [JsonProperty(PropertyName = "cert_id")]
        public string? CertId { get; set; }
    }
}
