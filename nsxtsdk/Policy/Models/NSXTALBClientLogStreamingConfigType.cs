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
    /// Advanced load balancer ClientLogStreamingConfig object
    /// </summary>
    [NSXTProperty(Description: @"Advanced load balancer ClientLogStreamingConfig object")]
    public class NSXTALBClientLogStreamingConfigType 
    {
        /// <summary>
        /// The service port to use for the external servers.
        /// If multiple external servers have been specified, the
        /// single port number specified here will apply to all those
        /// servers for which an explicit port number has not been
        /// specified in the external server list.
        /// Default value when not specified in API or module is
        /// interpreted by ALB Controller as 514.
        /// </summary>
        [JsonProperty(PropertyName = "external_server_port")]
        public long? ExternalServerPort { get; set; }
        /// <summary>
        /// Protocol to use for streaming logs.
        /// Enum options - LOG_STREAMING_PROTOCOL_UDP,
        /// LOG_STREAMING_PROTOCOL_SYSLOG_OVER_UDP,
        /// LOG_STREAMING_PROTOCOL_TCP,
        /// LOG_STREAMING_PROTOCOL_SYSLOG_OVER_TCP,
        /// LOG_STREAMING_PROTOCOL_RAW_OVER_UDP,
        /// LOG_STREAMING_PROTOCOL_TLS,
        /// LOG_STREAMING_PROTOCOL_SYSLOG_OVER_TLS.
        /// Default value when not specified in API or module is
        /// interpreted by ALB Controller as LOG_STREAMING_PROTOCOL_UDP.
        /// </summary>
        [JsonProperty(PropertyName = "protocol")]
        [JsonConverter(typeof(StringEnumConverter))]
        public NSXTAlbclientLogStreamingConfigProtocolEnumType? Protocol { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [JsonProperty(PropertyName = "syslog_config")]
        public NSXTALBStreamingSyslogConfigType SyslogConfig { get; set; }
        /// <summary>
        /// Maximum number of logs per second streamed to the remote
        /// server.
        /// By default, 100 logs per second are streamed.
        /// Set this to zero(0) to not enforce any limit.
        /// Default value when not specified in API or module is
        /// interpreted by ALB Controller as 100.
        /// </summary>
        [JsonProperty(PropertyName = "max_logs_per_second")]
        public long? MaxLogsPerSecond { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [JsonProperty(PropertyName = "format_config")]
        public NSXTALBClientLogStreamingFormatType FormatConfig { get; set; }
        /// <summary>
        /// Type of logs to stream to the external server.
        /// Default is LOGS_ALL, i.e., send all logs.
        /// Enum options - LOGS_SIGNIFICANT_ONLY, LOGS_UDF_ONLY,
        /// LOGS_UDF_SIGNIFICANT, LOGS_ALL.
        /// Default value when not specified in API or module is
        /// interpreted by ALB Controller as LOGS_ALL.
        /// </summary>
        [JsonProperty(PropertyName = "log_types_to_send")]
        [JsonConverter(typeof(StringEnumConverter))]
        public NSXTAlbclientLogStreamingConfigLogTypesToSendEnumType? LogTypesToSend { get; set; }
        /// <summary>
        /// IP address or hostnames (FQDNs) of destination servers.
        /// If an FQDN is provided, this should be resolvable on Avi
        /// Service Engines.
        /// Multiple servers are supported by furnishing a
        /// comma-separated list of IP addresses or host names, for
        /// example, 11.11.11.11,23.12.12.4.
        /// Optionally, a separate port can be specified for each
        /// external server in the list, for example, 11.11.11.11
        /// 234,12.12.12.12 343.
        /// </summary>
        [JsonProperty(PropertyName = "external_server", Required = Required.AllowNull)]
        public string ExternalServer { get; set; }
    }
}
