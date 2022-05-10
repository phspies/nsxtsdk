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
    /// CallbackAuthenticationScheme describes how notification requests should authenticate to the server.
    /// </summary>
    [NSXTProperty(Description: @"CallbackAuthenticationScheme describes how notification requests should authenticate to the server.")]
    public class NSXTCallbackAuthenticationSchemeType 
    {
        /// <summary>
        /// Username to use if scheme_name is BASIC_AUTH.
        /// </summary>
        [JsonProperty(PropertyName = "username")]
        public string? Username { get; set; }
        /// <summary>
        /// Certificate ID with a valid certificate and private key, procured from trust-management API.
        /// </summary>
        [JsonProperty(PropertyName = "certificate_id")]
        public string? CertificateId { get; set; }
        /// <summary>
        /// Authentication scheme to use when making notification requests to the partner console. Specify one of BASIC_AUTH or
        /// CERTIFICATE.
        /// </summary>
        [JsonProperty(PropertyName = "scheme_name", Required = Required.AllowNull)]
        [JsonConverter(typeof(StringEnumConverter))]
        public NSXTCallbackAuthenticationSchemeSchemeNameEnumType SchemeName { get; set; }
        /// <summary>
        /// Password to use if scheme_name is BASIC_AUTH.
        /// </summary>
        [JsonProperty(PropertyName = "password")]
        public string? Password { get; set; }
    }
}
