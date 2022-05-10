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
    public class NSXTTelemetryProxyType : NSXTManagedResourceType
    {
        /// <summary>
        /// Specify the user name used to authenticate with the proxy server, if required.
        /// </summary>
        [JsonProperty(PropertyName = "username")]
        public string? Username { get; set; }
        /// <summary>
        /// Specify the password used to authenticate with the proxy server, if required.
        /// A GET call on /telemetry/config returns a non-meaningful password to maintain
        /// security. To change the password to a new value, issue a PUT call after updating
        /// this field. To remove the password, issue a PUT call after emptying this field.
        /// To retain a previously set password, issue a PUT call keeping the non-meaningful
        /// value obtained from the GET call.
        /// </summary>
        [JsonProperty(PropertyName = "password")]
        public string? Password { get; set; }
        /// <summary>
        /// The scheme accepted by the proxy server. Specify one of HTTP and HTTPS.
        /// </summary>
        [JsonProperty(PropertyName = "scheme", Required = Required.AllowNull)]
        [JsonConverter(typeof(StringEnumConverter))]
        public NSXTTelemetryProxySchemeEnumType Scheme { get; set; }
        /// <summary>
        /// Specify the fully qualified domain name, or ip address, of the proxy server.
        /// </summary>
        [JsonProperty(PropertyName = "hostname", Required = Required.AllowNull)]
        public string Hostname { get; set; }
        /// <summary>
        /// Specify the port of the proxy server.
        /// </summary>
        [JsonProperty(PropertyName = "port", Required = Required.AllowNull)]
        public int Port { get; set; }
    }
}
