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
    /// 
    /// </summary>
    [NSXTProperty(Description: @"")]
    public class NSXTNodeSyslogExporterPropertiesType : NSXTResourceType
    {
        /// <summary>
        /// CA certificate PEM of TLS server to export to
        /// </summary>
        [JsonProperty(PropertyName = "tls_ca_pem")]
        [NSXTProperty(IsRequired: false, Description: @"CA certificate PEM of TLS server to export to")]
        public string? TlsCaPem { get; set; }
        /// <summary>
        /// Export protocol
        /// </summary>
        [JsonProperty(PropertyName = "protocol", Required = Required.AllowNull)]
        [NSXTProperty(IsRequired: true, Description: @"Export protocol")]
        [System.ComponentModel.DataAnnotations.Required]
        public NSXTNodeSyslogExporterPropertiesProtocolEnumType Protocol { get; set; }
        /// <summary>
        /// Syslog exporter name
        /// </summary>
        [JsonProperty(PropertyName = "exporter_name", Required = Required.AllowNull)]
        [NSXTProperty(IsRequired: true, Description: @"Syslog exporter name")]
        [System.ComponentModel.DataAnnotations.Required]
        public string ExporterName { get; set; }
        /// <summary>
        /// Logging level to export
        /// </summary>
        [JsonProperty(PropertyName = "level", Required = Required.AllowNull)]
        [NSXTProperty(IsRequired: true, Description: @"Logging level to export")]
        [System.ComponentModel.DataAnnotations.Required]
        public NSXTNodeSyslogExporterPropertiesLevelEnumType Level { get; set; }
        /// <summary>
        /// CA certificate PEM of the rsyslog client
        /// </summary>
        [JsonProperty(PropertyName = "tls_client_ca_pem")]
        [NSXTProperty(IsRequired: false, Description: @"CA certificate PEM of the rsyslog client")]
        public string? TlsClientCaPem { get; set; }
        /// <summary>
        /// Certificate PEM of the rsyslog client
        /// </summary>
        [JsonProperty(PropertyName = "tls_cert_pem")]
        [NSXTProperty(IsRequired: false, Description: @"Certificate PEM of the rsyslog client")]
        public string? TlsCertPem { get; set; }
        /// <summary>
        /// IP address or hostname of server to export to
        /// </summary>
        [JsonProperty(PropertyName = "server", Required = Required.AllowNull)]
        [NSXTProperty(IsRequired: true, Description: @"IP address or hostname of server to export to")]
        [System.ComponentModel.DataAnnotations.Required]
        public string Server { get; set; }
        /// <summary>
        /// Facilities to export
        /// </summary>
        [JsonProperty(PropertyName = "facilities")]
        [NSXTProperty(IsRequired: false, Description: @"Facilities to export")]
        public IList<string> Facilities { get; set; }
        /// <summary>
        /// MSGIDs to export
        /// </summary>
        [JsonProperty(PropertyName = "msgids")]
        [NSXTProperty(IsRequired: false, Description: @"MSGIDs to export")]
        public IList<string> Msgids { get; set; }
        /// <summary>
        /// Structured data to export
        /// </summary>
        [JsonProperty(PropertyName = "structured_data")]
        [NSXTProperty(IsRequired: false, Description: @"Structured data to export")]
        public IList<string> StructuredData { get; set; }
        /// <summary>
        /// Port to export to, defaults to 514 for TCP, TLS, UDP protocols or 9000 for LI, LI-TLS protocols
        /// </summary>
        [JsonProperty(PropertyName = "port")]
        [NSXTProperty(IsRequired: false, Description: @"Port to export to, defaults to 514 for TCP, TLS, UDP protocols or 9000 for LI, LI-TLS protocols")]
        //[System.ComponentModel.DataAnnotations.MinLength(1)]
        //[System.ComponentModel.DataAnnotations.MaxLength(65535)]
        public long? Port { get; set; }
        /// <summary>
        /// Private key PEM of the rsyslog client
        /// </summary>
        [JsonProperty(PropertyName = "tls_key_pem")]
        [NSXTProperty(IsRequired: false, Description: @"Private key PEM of the rsyslog client")]
        public string? TlsKeyPem { get; set; }
    }
}
