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
    /// Cluster restore status
    /// </summary>
    [NSXTProperty(Description: @"Cluster restore status")]
    public class NSXTClusterRestoreStatusType 
    {
        /// <summary>
        /// 
        /// </summary>
        [JsonProperty(PropertyName = "status")]
        public NSXTGlobalRestoreStatusType Status { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [JsonProperty(PropertyName = "step")]
        public NSXTRestoreStepType Step { get; set; }
        /// <summary>
        /// The list of allowed endpoints, based on the current state of
        /// the restore process
        /// </summary>
        [JsonProperty(PropertyName = "endpoints")]
        public IList<NSXTResourceLinkType> Endpoints { get; set; }
        /// <summary>
        /// Total number of steps in the entire restore process
        /// </summary>
        [JsonProperty(PropertyName = "total_steps")]
        public long? TotalSteps { get; set; }
        /// <summary>
        /// Timestamp when restore was started in epoch millisecond
        /// </summary>
        [JsonProperty(PropertyName = "restore_start_time")]
        public long? RestoreStartTime { get; set; }
        /// <summary>
        /// Timestamp when restore was completed in epoch millisecond
        /// </summary>
        [JsonProperty(PropertyName = "restore_end_time")]
        public long? RestoreEndTime { get; set; }
        /// <summary>
        /// List of actions that are not allowed
        /// </summary>
        [JsonProperty(PropertyName = "not_allowed_actions")]
        public IList<string> NotAllowedActions { get; set; }
        /// <summary>
        /// Timestamp when backup was initiated in epoch millisecond
        /// </summary>
        [JsonProperty(PropertyName = "backup_timestamp")]
        public long? BackupTimestamp { get; set; }
        /// <summary>
        /// Unique id for backup request
        /// </summary>
        [JsonProperty(PropertyName = "id")]
        public string? Id { get; set; }
        /// <summary>
        /// Instructions for users to reconcile Restore operations
        /// </summary>
        [JsonProperty(PropertyName = "instructions")]
        public IList<NSXTInstructionInfoType> Instructions { get; set; }
    }
}
