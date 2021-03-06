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
    /// Audit log in RFC5424 format
    /// </summary>
    [NSXTProperty(Description: @"Audit log in RFC5424 format")]
    public class NSXTAuditLogType 
    {
        /// <summary>
        /// Priority field of the log
        /// </summary>
        [JsonProperty(PropertyName = "priority", Required = Required.AllowNull)]
        public long Priority { get; set; }
        /// <summary>
        /// Process ID field of the log
        /// </summary>
        [JsonProperty(PropertyName = "procid", Required = Required.AllowNull)]
        public long Procid { get; set; }
        /// <summary>
        /// Facility field of the log
        /// </summary>
        [JsonProperty(PropertyName = "facility", Required = Required.AllowNull)]
        public long Facility { get; set; }
        /// <summary>
        /// Full log with both header and message
        /// </summary>
        [JsonProperty(PropertyName = "full_log", Required = Required.AllowNull)]
        public string FullLog { get; set; }
        /// <summary>
        /// Message ID field of the log
        /// </summary>
        [JsonProperty(PropertyName = "msgid", Required = Required.AllowNull)]
        public string Msgid { get; set; }
        /// <summary>
        /// Application name field of the log
        /// </summary>
        [JsonProperty(PropertyName = "appname", Required = Required.AllowNull)]
        public string Appname { get; set; }
        /// <summary>
        /// Date and time in UTC of the log
        /// </summary>
        [JsonProperty(PropertyName = "timestamp", Required = Required.AllowNull)]
        public string Timestamp { get; set; }
        /// <summary>
        /// Message field of the log
        /// </summary>
        [JsonProperty(PropertyName = "message", Required = Required.AllowNull)]
        public string Message { get; set; }
        /// <summary>
        /// Hostname field of the log
        /// </summary>
        [JsonProperty(PropertyName = "hostname", Required = Required.AllowNull)]
        public string Hostname { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [JsonProperty(PropertyName = "struct_data", Required = Required.AllowNull)]
        public NSXTStructuredDataType StructData { get; set; }
    }
}
