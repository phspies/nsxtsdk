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
    /// Advanced load balancer CertificateAuthority object
    /// </summary>
    [NSXTProperty(Description: @"Advanced load balancer CertificateAuthority object")]
    public class NSXTALBCertificateAuthorityType 
    {
        /// <summary>
        /// It is a reference to an object of type
        /// SSLKeyAndCertificate.
        /// </summary>
        [JsonProperty(PropertyName = "ca_path")]
        [NSXTProperty(IsRequired: false, Description: @"It is a reference to an object of typeSSLKeyAndCertificate.")]
        public string? CaPath { get; set; }
        /// <summary>
        /// Name of the object.
        /// </summary>
        [JsonProperty(PropertyName = "name")]
        [NSXTProperty(IsRequired: false, Description: @"Name of the object.")]
        public string? Name { get; set; }
    }
}