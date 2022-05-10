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
    /// Advanced load balancer HealthMonitorSSLAttributes object
    /// </summary>
    [NSXTProperty(Description: @"Advanced load balancer HealthMonitorSSLAttributes object")]
    public class NSXTALBHealthMonitorSSLAttributesType 
    {
        /// <summary>
        /// SSL profile defines ciphers and SSL versions to be used for
        /// healthmonitor traffic to the back-end servers.
        /// It is a reference to an object of type SSLProfile.
        /// </summary>
        [JsonProperty(PropertyName = "ssl_profile_path", Required = Required.AllowNull)]
        public string SslProfilePath { get; set; }
        /// <summary>
        /// PKI profile used to validate the SSL certificate presented
        /// by a server.
        /// It is a reference to an object of type PKIProfile.
        /// </summary>
        [JsonProperty(PropertyName = "pki_profile_path")]
        public string? PkiProfilePath { get; set; }
        /// <summary>
        /// Service engines will present this SSL certificate to the
        /// server.
        /// It is a reference to an object of type
        /// SSLKeyAndCertificate.
        /// </summary>
        [JsonProperty(PropertyName = "ssl_key_and_certificate_path")]
        public string? SslKeyAndCertificatePath { get; set; }
        /// <summary>
        /// Fully qualified DNS hostname which will be used in the TLS
        /// SNI extension in server connections indicating SNI is
        /// enabled.
        /// </summary>
        [JsonProperty(PropertyName = "server_name")]
        public string? ServerName { get; set; }
    }
}
