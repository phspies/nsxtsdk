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
    /// This object specifies what, where and how logs on NSX nodes are forwarded.
    /// </summary>
    [NSXTProperty(Description: @"This object specifies what, where and how logs on NSX nodes are forwarded.")]
    public class NSXTSyslogExporterType 
    {
        /// <summary>
        /// Maximum logging level for messages to be exported.
        /// </summary>
        [JsonProperty(PropertyName = "max_log_level", Required = Required.AllowNull)]
        public NSXTSyslogExporterMaxLogLevelEnumType MaxLogLevel { get; set; }
        /// <summary>
        /// Protocol to be used to export logs to syslog server.
        /// </summary>
        [JsonProperty(PropertyName = "protocol", Required = Required.AllowNull)]
        public NSXTSyslogExporterProtocolEnumType Protocol { get; set; }
        /// <summary>
        /// Server port on which syslog listener is listening.
        /// </summary>
        public long? Port { get; set; }
        /// <summary>
        /// Syslog server IP address or hostname.
        /// </summary>
        [JsonProperty(PropertyName = "server", Required = Required.AllowNull)]
        public string Server { get; set; }
    }
}
