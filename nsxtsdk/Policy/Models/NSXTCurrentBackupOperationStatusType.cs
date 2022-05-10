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
    /// Current backup operation status
    /// </summary>
    [NSXTProperty(Description: @"Current backup operation status")]
    public class NSXTCurrentBackupOperationStatusType 
    {
        /// <summary>
        /// Current step of operation
        /// </summary>
        [JsonProperty(PropertyName = "current_step")]
        [JsonConverter(typeof(StringEnumConverter))]
        public NSXTCurrentBackupOperationStatusCurrentStepEnumType? CurrentStep { get; set; }
        /// <summary>
        /// Unique identifier of current backup
        /// </summary>
        [JsonProperty(PropertyName = "backup_id")]
        public string? BackupId { get; set; }
        /// <summary>
        /// Additional human-readable status information about current step
        /// </summary>
        [JsonProperty(PropertyName = "current_step_message")]
        public string? CurrentStepMessage { get; set; }
        /// <summary>
        /// Time when operation is expected to end
        /// </summary>
        [JsonProperty(PropertyName = "end_time")]
        public long? EndTime { get; set; }
        /// <summary>
        /// Type of operation that is in progress. Returns none if no operation is in progress, in which case
        /// none of the other fields will be set.
        /// </summary>
        [JsonProperty(PropertyName = "operation_type")]
        [JsonConverter(typeof(StringEnumConverter))]
        public NSXTCurrentBackupOperationStatusOperationTypeEnumType? OperationType { get; set; }
        /// <summary>
        /// Time when operation was started
        /// </summary>
        [JsonProperty(PropertyName = "start_time")]
        public long? StartTime { get; set; }
    }
}
