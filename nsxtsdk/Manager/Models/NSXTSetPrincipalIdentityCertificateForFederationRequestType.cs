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
    /// Data for setting a principal identity certificate
    /// </summary>
    [NSXTProperty(Description: @"Data for setting a principal identity certificate")]
    public class NSXTSetPrincipalIdentityCertificateForFederationRequestType 
    {
        /// <summary>
        /// Service type for which the certificate should be used.
        /// </summary>
        [JsonProperty(PropertyName = "service_type")]
        [NSXTProperty(IsRequired: false, Description: @"Service type for which the certificate should be used.")]
        public NSXTSetPrincipalIdentityCertificateForFederationRequestServiceTypeEnumType? ServiceType { get; set; }
        /// <summary>
        /// Id of the certificate
        /// </summary>
        [JsonProperty(PropertyName = "cert_id")]
        [NSXTProperty(IsRequired: false, Description: @"Id of the certificate")]
        public string? CertId { get; set; }
    }
}
