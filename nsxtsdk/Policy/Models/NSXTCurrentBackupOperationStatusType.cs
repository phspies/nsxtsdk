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

namespace nsxtsdk.PolicyModels
{
    /// <summary>
    /// Current backup operation status
    /// </summary>
    [NSXTProperty(Description: @"Current backup operation status")]
    public class NSXTCurrentBackupOperationStatusType 
    {
        public NSXTCurrentBackupOperationStatusType()
        {
        }
        /// <summary>
        /// Current step of operation
        /// </summary>
        [JsonProperty(PropertyName = "current_step")]
        [NSXTProperty(IsRequired: false, Description: @"Current step of operation")]
        public NSXTCurrentBackupOperationStatusCurrentStepEnumType? CurrentStep { get; set; }
        /// <summary>
        /// Unique identifier of current backup
        /// </summary>
        [JsonProperty(PropertyName = "backup_id")]
        [NSXTProperty(IsRequired: false, Description: @"Unique identifier of current backup")]
        public string? BackupId { get; set; }
        /// <summary>
        /// Additional human-readable status information about current step
        /// </summary>
        [JsonProperty(PropertyName = "current_step_message")]
        [NSXTProperty(IsRequired: false, Description: @"Additional human-readable status information about current step")]
        public string? CurrentStepMessage { get; set; }
        /// <summary>
        /// Time when operation is expected to end
        /// </summary>
        [JsonProperty(PropertyName = "end_time")]
        [NSXTProperty(IsRequired: false, Description: @"Time when operation is expected to end")]
        public long? EndTime { get; set; }
        /// <summary>
        /// Type of operation that is in progress. Returns none if no operation is in progress, in which case
        /// none of the other fields will be set.
        /// </summary>
        [JsonProperty(PropertyName = "operation_type")]
        [NSXTProperty(IsRequired: false, Description: @"Type of operation that is in progress. Returns none if no operation is in progress, in which casenone of the other fields will be set.")]
        public NSXTCurrentBackupOperationStatusOperationTypeEnumType? OperationType { get; set; }
        /// <summary>
        /// Time when operation was started
        /// </summary>
        [JsonProperty(PropertyName = "start_time")]
        [NSXTProperty(IsRequired: false, Description: @"Time when operation was started")]
        public long? StartTime { get; set; }
    }
}
