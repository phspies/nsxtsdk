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
    /// 
    /// </summary>
    [NSXTProperty(Description: @"")]
    public class NSXTProxyType : NSXTManagedResourceType
    {
        /// <summary>
        /// Specify the user name used to authenticate with the proxy server, if required.
        /// </summary>
        [JsonProperty(PropertyName = "username")]
        public string? Username { get; set; }
        /// <summary>
        /// Specify the fully qualified domain name, or ip address, of the proxy server.
        /// </summary>
        [JsonProperty(PropertyName = "host", Required = Required.AllowNull)]
        public string Host { get; set; }
        /// <summary>
        /// Specify the password used to authenticate with the proxy server, if required.
        /// </summary>
        [JsonProperty(PropertyName = "password")]
        public string? Password { get; set; }
        /// <summary>
        /// The scheme accepted by the proxy server. Specify one of HTTP and HTTPS.
        /// </summary>
        [JsonProperty(PropertyName = "scheme", Required = Required.AllowNull)]
        [JsonConverter(typeof(StringEnumConverter))]
        public NSXTProxySchemeEnumType Scheme { get; set; }
        /// <summary>
        /// Flag to indicate if proxy is enabled. When set to true, a scheme, host
        /// and port must be provided.
        /// </summary>
        [JsonProperty(PropertyName = "enabled", Required = Required.AllowNull)]
        public bool Enabled { get; set; }
        /// <summary>
        /// Specify the port of the proxy server.
        /// </summary>
        [JsonProperty(PropertyName = "port", Required = Required.AllowNull)]
        public int Port { get; set; }
    }
}
