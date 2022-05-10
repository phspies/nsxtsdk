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
    public class NSXTNodePropertiesType : NSXTResourceType
    {
        /// <summary>
        /// Current time expressed in milliseconds since epoch
        /// </summary>
        [JsonProperty(PropertyName = "system_time")]
        public long? SystemTime { get; set; }
        /// <summary>
        /// Node Unique Identifier
        /// </summary>
        [JsonProperty(PropertyName = "node_uuid")]
        public string? NodeUuid { get; set; }
        /// <summary>
        /// Message of the day to display when users login to node using the NSX CLI
        /// </summary>
        [JsonProperty(PropertyName = "motd")]
        public object Motd { get; set; }
        /// <summary>
        /// NSX CLI inactivity timeout, set to 0 to configure no timeout
        /// </summary>
        [JsonProperty(PropertyName = "cli_timeout")]
        public long? CliTimeout { get; set; }
        /// <summary>
        /// Kernel version
        /// </summary>
        [JsonProperty(PropertyName = "kernel_version")]
        public string? KernelVersion { get; set; }
        /// <summary>
        /// Export restrictions in effect, if any
        /// </summary>
        [JsonProperty(PropertyName = "export_type")]
        [JsonConverter(typeof(StringEnumConverter))]
        public NSXTNodePropertiesExportTypeEnumType? ExportType { get; set; }
        /// <summary>
        /// Product version
        /// </summary>
        [JsonProperty(PropertyName = "product_version")]
        public string? ProductVersion { get; set; }
        /// <summary>
        /// Node version
        /// </summary>
        [JsonProperty(PropertyName = "node_version")]
        public string? NodeVersion { get; set; }
        /// <summary>
        /// Node type
        /// </summary>
        [JsonProperty(PropertyName = "node_type")]
        [JsonConverter(typeof(StringEnumConverter))]
        public NSXTNodePropertiesNodeTypeEnumType? NodeType { get; set; }
        /// <summary>
        /// System date time in UTC
        /// </summary>
        [JsonProperty(PropertyName = "system_datetime")]
        public string? SystemDatetime { get; set; }
        /// <summary>
        /// Fully qualified domain name
        /// </summary>
        [JsonProperty(PropertyName = "fully_qualified_domain_name")]
        public string? FullyQualifiedDomainName { get; set; }
        /// <summary>
        /// Timezone
        /// </summary>
        [JsonProperty(PropertyName = "timezone")]
        public string? Timezone { get; set; }
        /// <summary>
        /// NSX CLI command history limit, set to 0 to configure no history size limit
        /// </summary>
        [JsonProperty(PropertyName = "cli_history_size")]
        public long? CliHistorySize { get; set; }
        /// <summary>
        /// Host name or fully qualified domain name of node
        /// </summary>
        [JsonProperty(PropertyName = "hostname")]
        public string? Hostname { get; set; }
        /// <summary>
        /// NSX CLI display datetime stamp in command output
        /// </summary>
        [JsonProperty(PropertyName = "cli_output_datetime")]
        public bool? CliOutputDatetime { get; set; }
    }
}
