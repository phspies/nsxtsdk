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
    /// Advanced load balancer TacacsPlusAuthSettings object
    /// </summary>
    [NSXTProperty(Description: @"Advanced load balancer TacacsPlusAuthSettings object")]
    public class NSXTALBTacacsPlusAuthSettingsType 
    {
        /// <summary>
        /// TACACS+ authorization attribute value pairs.
        /// </summary>
        [JsonProperty(PropertyName = "authorization_attrs")]
        public IList<NSXTALBAuthTacacsPlusAttributeValuePairType> AuthorizationAttrs { get; set; }
        /// <summary>
        /// TACACS+ server shared secret.
        /// </summary>
        [JsonProperty(PropertyName = "password")]
        public string? Password { get; set; }
        /// <summary>
        /// TACACS+ server listening port.
        /// Default value when not specified in API or module is
        /// interpreted by ALB Controller as 49.
        /// </summary>
        [JsonProperty(PropertyName = "port")]
        public long? Port { get; set; }
        /// <summary>
        /// TACACS+ service.
        /// Enum options - AUTH_TACACS_PLUS_SERVICE_NONE,
        /// AUTH_TACACS_PLUS_SERVICE_LOGIN,
        /// AUTH_TACACS_PLUS_SERVICE_ENABLE,
        /// AUTH_TACACS_PLUS_SERVICE_PPP, AUTH_TACACS_PLUS_SERVICE_ARAP,
        /// AUTH_TACACS_PLUS_SERVICE_PT, AUTH_TACACS_PLUS_SERVICE_RCMD,
        /// AUTH_TACACS_PLUS_SERVICE_X25, AUTH_TACACS_PLUS_SERVICE_NASI,
        /// AUTH_TACACS_PLUS_SERVICE_FWPROXY.
        /// Default value when not specified in API or module is
        /// interpreted by ALB Controller as
        /// AUTH_TACACS_PLUS_SERVICE_LOGIN.
        /// </summary>
        [JsonProperty(PropertyName = "service")]
        [JsonConverter(typeof(StringEnumConverter))]
        public NSXTAlbtacacsPlusAuthSettingsServiceEnumType? Service { get; set; }
        /// <summary>
        /// TACACS+ server IP address or FQDN.
        /// Minimum of 1 items required.
        /// </summary>
        [JsonProperty(PropertyName = "server", Required = Required.AllowNull)]
        public IList<string> Server { get; set; }
    }
}
