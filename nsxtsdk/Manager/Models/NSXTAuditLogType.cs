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
    /// Audit log in RFC5424 format
    /// </summary>
    [NSXTProperty(Description: @"Audit log in RFC5424 format")]
    public class NSXTAuditLogType 
    {
        public NSXTAuditLogType()
        {
        }
        /// <summary>
        /// Priority field of the log
        /// </summary>
        [JsonProperty(PropertyName = "priority", Required = Required.AllowNull)]
        [NSXTProperty(IsRequired: true, Description: @"Priority field of the log")]
        [System.ComponentModel.DataAnnotations.Required]
        public long Priority { get; set; }
        /// <summary>
        /// Process ID field of the log
        /// </summary>
        [JsonProperty(PropertyName = "procid", Required = Required.AllowNull)]
        [NSXTProperty(IsRequired: true, Description: @"Process ID field of the log")]
        [System.ComponentModel.DataAnnotations.Required]
        public long Procid { get; set; }
        /// <summary>
        /// Facility field of the log
        /// </summary>
        [JsonProperty(PropertyName = "facility", Required = Required.AllowNull)]
        [NSXTProperty(IsRequired: true, Description: @"Facility field of the log")]
        [System.ComponentModel.DataAnnotations.Required]
        public long Facility { get; set; }
        /// <summary>
        /// Full log with both header and message
        /// </summary>
        [JsonProperty(PropertyName = "full_log", Required = Required.AllowNull)]
        [NSXTProperty(IsRequired: true, Description: @"Full log with both header and message")]
        [System.ComponentModel.DataAnnotations.Required]
        public string FullLog { get; set; }
        /// <summary>
        /// Message ID field of the log
        /// </summary>
        [JsonProperty(PropertyName = "msgid", Required = Required.AllowNull)]
        [NSXTProperty(IsRequired: true, Description: @"Message ID field of the log")]
        [System.ComponentModel.DataAnnotations.Required]
        public string Msgid { get; set; }
        /// <summary>
        /// Application name field of the log
        /// </summary>
        [JsonProperty(PropertyName = "appname", Required = Required.AllowNull)]
        [NSXTProperty(IsRequired: true, Description: @"Application name field of the log")]
        [System.ComponentModel.DataAnnotations.Required]
        public string Appname { get; set; }
        /// <summary>
        /// Date and time in UTC of the log
        /// </summary>
        [JsonProperty(PropertyName = "timestamp", Required = Required.AllowNull)]
        [NSXTProperty(IsRequired: true, Description: @"Date and time in UTC of the log")]
        [System.ComponentModel.DataAnnotations.Required]
        public string Timestamp { get; set; }
        /// <summary>
        /// Message field of the log
        /// </summary>
        [JsonProperty(PropertyName = "message", Required = Required.AllowNull)]
        [NSXTProperty(IsRequired: true, Description: @"Message field of the log")]
        [System.ComponentModel.DataAnnotations.Required]
        public string Message { get; set; }
        /// <summary>
        /// Hostname field of the log
        /// </summary>
        [JsonProperty(PropertyName = "hostname", Required = Required.AllowNull)]
        [NSXTProperty(IsRequired: true, Description: @"Hostname field of the log")]
        [System.ComponentModel.DataAnnotations.Required]
        public string Hostname { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [JsonProperty(PropertyName = "struct_data", Required = Required.AllowNull)]
        [NSXTProperty(IsRequired: true, Description: @"")]
        [System.ComponentModel.DataAnnotations.Required]
        public NSXTStructuredDataType StructData { get; set; }
    }
}
