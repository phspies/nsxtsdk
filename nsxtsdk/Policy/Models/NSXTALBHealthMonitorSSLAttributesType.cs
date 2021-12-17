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
    /// Advanced load balancer HealthMonitorSSLAttributes object
    /// </summary>
    [NSXTProperty(Description: @"Advanced load balancer HealthMonitorSSLAttributes object")]
    public class NSXTALBHealthMonitorSSLAttributesType 
    {
        public NSXTALBHealthMonitorSSLAttributesType()
        {
        }
        /// <summary>
        /// SSL profile defines ciphers and SSL versions to be used for
        /// healthmonitor traffic to the back-end servers.
        /// It is a reference to an object of type SSLProfile.
        /// </summary>
        [JsonProperty(PropertyName = "ssl_profile_path", Required = Required.AllowNull)]
        [NSXTProperty(IsRequired: true, Description: @"SSL profile defines ciphers and SSL versions to be used forhealthmonitor traffic to the back-end servers.It is a reference to an object of type SSLProfile.")]
        [System.ComponentModel.DataAnnotations.Required]
        public string SslProfilePath { get; set; }
        /// <summary>
        /// PKI profile used to validate the SSL certificate presented
        /// by a server.
        /// It is a reference to an object of type PKIProfile.
        /// </summary>
        [JsonProperty(PropertyName = "pki_profile_path")]
        [NSXTProperty(IsRequired: false, Description: @"PKI profile used to validate the SSL certificate presentedby a server.It is a reference to an object of type PKIProfile.")]
        public string? PkiProfilePath { get; set; }
        /// <summary>
        /// Service engines will present this SSL certificate to the
        /// server.
        /// It is a reference to an object of type
        /// SSLKeyAndCertificate.
        /// </summary>
        [JsonProperty(PropertyName = "ssl_key_and_certificate_path")]
        [NSXTProperty(IsRequired: false, Description: @"Service engines will present this SSL certificate to theserver.It is a reference to an object of typeSSLKeyAndCertificate.")]
        public string? SslKeyAndCertificatePath { get; set; }
        /// <summary>
        /// Fully qualified DNS hostname which will be used in the TLS
        /// SNI extension in server connections indicating SNI is
        /// enabled.
        /// </summary>
        [JsonProperty(PropertyName = "server_name")]
        [NSXTProperty(IsRequired: false, Description: @"Fully qualified DNS hostname which will be used in the TLSSNI extension in server connections indicating SNI isenabled.")]
        public string? ServerName { get; set; }
    }
}
