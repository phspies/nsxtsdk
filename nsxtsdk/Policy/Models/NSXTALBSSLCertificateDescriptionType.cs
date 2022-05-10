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
    /// Advanced load balancer SSLCertificateDescription object
    /// </summary>
    [NSXTProperty(Description: @"Advanced load balancer SSLCertificateDescription object")]
    public class NSXTALBSSLCertificateDescriptionType 
    {
        /// <summary>
        /// common_name of SSLCertificateDescription.
        /// </summary>
        [JsonProperty(PropertyName = "common_name")]
        public string? CommonName { get; set; }
        /// <summary>
        /// state of SSLCertificateDescription.
        /// </summary>
        [JsonProperty(PropertyName = "state")]
        public string? State { get; set; }
        /// <summary>
        /// organization of SSLCertificateDescription.
        /// </summary>
        [JsonProperty(PropertyName = "organization")]
        public string? Organization { get; set; }
        /// <summary>
        /// locality of SSLCertificateDescription.
        /// </summary>
        [JsonProperty(PropertyName = "locality")]
        public string? Locality { get; set; }
        /// <summary>
        /// distinguished_name of SSLCertificateDescription.
        /// </summary>
        [JsonProperty(PropertyName = "distinguished_name")]
        public string? DistinguishedName { get; set; }
        /// <summary>
        /// country of SSLCertificateDescription.
        /// </summary>
        [JsonProperty(PropertyName = "country")]
        public string? Country { get; set; }
        /// <summary>
        /// organization_unit of SSLCertificateDescription.
        /// </summary>
        [JsonProperty(PropertyName = "organization_unit")]
        public string? OrganizationUnit { get; set; }
        /// <summary>
        /// email_address of SSLCertificateDescription.
        /// </summary>
        [JsonProperty(PropertyName = "email_address")]
        public string? EmailAddress { get; set; }
    }
}
