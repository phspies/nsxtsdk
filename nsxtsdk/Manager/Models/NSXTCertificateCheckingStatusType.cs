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
    /// Result of checking a certificate
    /// </summary>
    [NSXTProperty(Description: @"Result of checking a certificate")]
    public class NSXTCertificateCheckingStatusType 
    {
        /// <summary>
        /// Status of the checked certificate.
        /// </summary>
        [JsonProperty(PropertyName = "status")]
        [JsonConverter(typeof(StringEnumConverter))]
        public NSXTCertificateCheckingStatusStatusEnumType? Status { get; set; }
        /// <summary>
        /// Error message when checking the certificate.
        /// </summary>
        [JsonProperty(PropertyName = "error_message")]
        public string? ErrorMessage { get; set; }
    }
}
