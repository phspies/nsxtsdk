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
        public string? CaPath { get; set; }
        /// <summary>
        /// Name of the object.
        /// </summary>
        [JsonProperty(PropertyName = "name")]
        public string? Name { get; set; }
    }
}
