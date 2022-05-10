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
    /// Returns the certificate and thumbprint of a remote TLS listener, if the
        /// listener is running and accepting requests. If the certificate cannot be
        /// retrieved, the result property describes the problem.
    /// </summary>
    [NSXTProperty(Description: @"Returns the certificate and thumbprint of a remote TLS listener, if thelistener is running and accepting requests. If the certificate cannot beretrieved, the result property describes the problem.")]
    public class NSXTTlsListenerCertificateType 
    {
        /// <summary>
        /// Result of get certificate operation.
        /// </summary>
        [JsonProperty(PropertyName = "result")]
        [JsonConverter(typeof(StringEnumConverter))]
        public NSXTTlsListenerCertificateResultEnumType? Result { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [JsonProperty(PropertyName = "certificate")]
        public NSXTX509CertificateType Certificate { get; set; }
        /// <summary>
        /// The SHA-256 thumbprint of the TLS listener.
        /// </summary>
        [JsonProperty(PropertyName = "thumbprint")]
        public string? Thumbprint { get; set; }
    }
}
