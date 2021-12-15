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
        [NSXTProperty(IsRequired: false, Description: @"Log level that needs to be redirected.")]
        [NSXTDefaultProperty(Default: "INFO")]
        public NSXTSyslogConfigurationLogLevelEnumType? LogLevel { get; set; }
        /// <summary>
        /// Supported Syslog protocol.
        /// </summary>
        [JsonProperty(PropertyName = "protocol")]
        [NSXTProperty(IsRequired: false, Description: @"Supported Syslog protocol.")]
        [NSXTDefaultProperty(Default: "UDP")]
        public NSXTSyslogConfigurationProtocolEnumType? Protocol { get; set; }
        /// <summary>
        /// Syslog server listening port.
        /// </summary>
        [JsonProperty(PropertyName = "port")]
        [NSXTProperty(IsRequired: false, Description: @"Syslog server listening port.")]
        [NSXTDefaultProperty(Default: "514")]
        public string? Port { get; set; }
        /// <summary>
        /// Display name of the syslog server
        /// </summary>
        [JsonProperty(PropertyName = "name")]
        [NSXTProperty(IsRequired: false, Description: @"Display name of the syslog server")]
        public string? Name { get; set; }
        /// <summary>
        /// Syslog server Ip or fqdn.
        /// </summary>
        [JsonProperty(PropertyName = "server", Required = Required.AllowNull)]
        [NSXTProperty(IsRequired: true, Description: @"Syslog server Ip or fqdn.")]
        [System.ComponentModel.DataAnnotations.Required]
        public string Server { get; set; }
    }
}
