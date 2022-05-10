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
    /// Backup operation status
    /// </summary>
    [NSXTProperty(Description: @"Backup operation status")]
    public class NSXTBackupOperationStatusType 
    {
        /// <summary>
        /// Unique identifier of a backup
        /// </summary>
        [JsonProperty(PropertyName = "backup_id", Required = Required.AllowNull)]
        public string BackupId { get; set; }
        /// <summary>
        /// Time when operation was ended
        /// </summary>
        [JsonProperty(PropertyName = "end_time")]
        public long? EndTime { get; set; }
        /// <summary>
        /// True if backup is successfully completed, else false
        /// </summary>
        [JsonProperty(PropertyName = "success", Required = Required.AllowNull)]
        public bool Success { get; set; }
        /// <summary>
        /// Time when operation was started
        /// </summary>
        [JsonProperty(PropertyName = "start_time")]
        public long? StartTime { get; set; }
        /// <summary>
        /// Error code details
        /// </summary>
        [JsonProperty(PropertyName = "error_message")]
        public string? ErrorMessage { get; set; }
        /// <summary>
        /// Error code
        /// </summary>
        [JsonProperty(PropertyName = "error_code")]
        [JsonConverter(typeof(StringEnumConverter))]
        public NSXTBackupOperationStatusErrorCodeEnumType? ErrorCode { get; set; }
    }
}
