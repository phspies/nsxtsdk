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
    /// Syslog server configuration parameters
    /// </summary>
    [NSXTProperty(Description: @"Syslog server configuration parameters")]
    public class NSXTSyslogConfigurationType 
    {
        /// <summary>
        /// Log level that needs to be redirected.
        /// </summary>
        [JsonProperty(PropertyName = "log_level")]
        [JsonConverter(typeof(StringEnumConverter))]
        public NSXTSyslogConfigurationLogLevelEnumType? LogLevel { get; set; }
        /// <summary>
        /// Supported Syslog protocol.
        /// </summary>
        [JsonProperty(PropertyName = "protocol")]
        [JsonConverter(typeof(StringEnumConverter))]
        public NSXTSyslogConfigurationProtocolEnumType? Protocol { get; set; }
        /// <summary>
        /// Syslog server listening port.
        /// </summary>
        [JsonProperty(PropertyName = "port")]
        public string? Port { get; set; }
        /// <summary>
        /// Display name of the syslog server
        /// </summary>
        [JsonProperty(PropertyName = "name")]
        public string? Name { get; set; }
        /// <summary>
        /// Syslog server Ip or fqdn.
        /// </summary>
        [JsonProperty(PropertyName = "server", Required = Required.AllowNull)]
        public string Server { get; set; }
    }
}
