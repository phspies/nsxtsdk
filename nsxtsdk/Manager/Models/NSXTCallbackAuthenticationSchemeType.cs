// <auto-generated>
// Changes may cause incorrect behavior and will be lost if the code is regenerated.
// </auto-generated>
using nsxtsdk.Models;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.ComponentModel;
using NJsonSchema.Converters;

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
        public string? Username { get; set; }
        /// <summary>
        /// Certificate ID with a valid certificate and private key, procured from trust-management API.
        /// </summary>
        public string? CertificateId { get; set; }
        /// <summary>
        /// Authentication scheme to use when making notification requests to the partner console. Specify one of BASIC_AUTH or
        /// CERTIFICATE.
        /// </summary>
        [JsonProperty(PropertyName = "scheme_name", Required = Required.AllowNull)]
        public NSXTCallbackAuthenticationSchemeSchemeNameEnumType SchemeName { get; set; }
        /// <summary>
        /// Password to use if scheme_name is BASIC_AUTH.
        /// </summary>
        public string? Password { get; set; }
    }
}
