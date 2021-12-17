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
    /// Backup operation status
    /// </summary>
    [NSXTProperty(Description: @"Backup operation status")]
    public class NSXTBackupOperationStatusType 
    {
        public NSXTBackupOperationStatusType()
        {
        }
        /// <summary>
        /// Unique identifier of a backup
        /// </summary>
        [JsonProperty(PropertyName = "backup_id", Required = Required.AllowNull)]
        [NSXTProperty(IsRequired: true, Description: @"Unique identifier of a backup")]
        [System.ComponentModel.DataAnnotations.Required]
        public string BackupId { get; set; }
        /// <summary>
        /// Time when operation was ended
        /// </summary>
        [JsonProperty(PropertyName = "end_time")]
        [NSXTProperty(IsRequired: false, Description: @"Time when operation was ended")]
        public long? EndTime { get; set; }
        /// <summary>
        /// True if backup is successfully completed, else false
        /// </summary>
        [JsonProperty(PropertyName = "success", Required = Required.AllowNull)]
        [NSXTProperty(IsRequired: true, Description: @"True if backup is successfully completed, else false")]
        [System.ComponentModel.DataAnnotations.Required]
        public bool Success { get; set; }
        /// <summary>
        /// Time when operation was started
        /// </summary>
        [JsonProperty(PropertyName = "start_time")]
        [NSXTProperty(IsRequired: false, Description: @"Time when operation was started")]
        public long? StartTime { get; set; }
        /// <summary>
        /// Error code details
        /// </summary>
        [JsonProperty(PropertyName = "error_message")]
        [NSXTProperty(IsRequired: false, Description: @"Error code details")]
        public string? ErrorMessage { get; set; }
        /// <summary>
        /// Error code
        /// </summary>
        [JsonProperty(PropertyName = "error_code")]
        [NSXTProperty(IsRequired: false, Description: @"Error code")]
        public NSXTBackupOperationStatusErrorCodeEnumType? ErrorCode { get; set; }
    }
}
