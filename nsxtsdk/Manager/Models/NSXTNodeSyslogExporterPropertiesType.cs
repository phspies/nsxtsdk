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
    public class NSXTNodeSyslogExporterPropertiesType : NSXTResourceType
    {
        /// <summary>
        /// CA certificate PEM of TLS server to export to
        /// </summary>
        [JsonProperty(PropertyName = "tls_ca_pem")]
        public string? TlsCaPem { get; set; }
        /// <summary>
        /// Export protocol
        /// </summary>
        [JsonProperty(PropertyName = "protocol", Required = Required.AllowNull)]
        [JsonConverter(typeof(StringEnumConverter))]
        public NSXTNodeSyslogExporterPropertiesProtocolEnumType Protocol { get; set; }
        /// <summary>
        /// Syslog exporter name
        /// </summary>
        [JsonProperty(PropertyName = "exporter_name", Required = Required.AllowNull)]
        public string ExporterName { get; set; }
        /// <summary>
        /// Logging level to export
        /// </summary>
        [JsonProperty(PropertyName = "level", Required = Required.AllowNull)]
        [JsonConverter(typeof(StringEnumConverter))]
        public NSXTNodeSyslogExporterPropertiesLevelEnumType Level { get; set; }
        /// <summary>
        /// CA certificate PEM of the rsyslog client
        /// </summary>
        [JsonProperty(PropertyName = "tls_client_ca_pem")]
        public string? TlsClientCaPem { get; set; }
        /// <summary>
        /// Certificate PEM of the rsyslog client
        /// </summary>
        [JsonProperty(PropertyName = "tls_cert_pem")]
        public string? TlsCertPem { get; set; }
        /// <summary>
        /// IP address or hostname of server to export to
        /// </summary>
        [JsonProperty(PropertyName = "server", Required = Required.AllowNull)]
        public string Server { get; set; }
        /// <summary>
        /// Facilities to export
        /// </summary>
        [JsonProperty(PropertyName = "facilities")]
        public IList<string> Facilities { get; set; }
        /// <summary>
        /// MSGIDs to export
        /// </summary>
        [JsonProperty(PropertyName = "msgids")]
        public IList<string> Msgids { get; set; }
        /// <summary>
        /// Structured data to export
        /// </summary>
        [JsonProperty(PropertyName = "structured_data")]
        public IList<string> StructuredData { get; set; }
        /// <summary>
        /// Port to export to, defaults to 514 for TCP, TLS, UDP protocols or 9000 for LI, LI-TLS protocols
        /// </summary>
        [JsonProperty(PropertyName = "port")]
        public long? Port { get; set; }
        /// <summary>
        /// Private key PEM of the rsyslog client
        /// </summary>
        [JsonProperty(PropertyName = "tls_key_pem")]
        public string? TlsKeyPem { get; set; }
    }
}
