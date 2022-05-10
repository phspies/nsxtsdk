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
    /// Directory domain synchronization statistics
    /// </summary>
    [NSXTProperty(Description: @"Directory domain synchronization statistics")]
    public class NSXTDirectoryDomainSyncStatsType 
    {
        /// <summary>
        /// Directory domain previous sync status. It could be one of the following two states.
        /// </summary>
        [JsonProperty(PropertyName = "prev_sync_status")]
        [JsonConverter(typeof(StringEnumConverter))]
        public NSXTDirectoryDomainSyncStatsPrevSyncStatusEnumType? PrevSyncStatus { get; set; }
        /// <summary>
        /// All the historical full sync are counted in calculating the average full sync time in milliseconds.
        /// </summary>
        [JsonProperty(PropertyName = "avg_full_sync_time")]
        public long? AvgFullSyncTime { get; set; }
        /// <summary>
        /// Directory domain previous sync type. It could be one of the following five states. Right after the directory domain is
        /// configured, this field is set to IDLE.
        /// </summary>
        [JsonProperty(PropertyName = "prev_sync_type")]
        [JsonConverter(typeof(StringEnumConverter))]
        public NSXTDirectoryDomainSyncStatsPrevSyncTypeEnumType? PrevSyncType { get; set; }
        /// <summary>
        /// number of successful historical full sync initiated either by system or by API request.
        /// </summary>
        [JsonProperty(PropertyName = "num_full_sync")]
        public long? NumFullSync { get; set; }
        /// <summary>
        /// Since what time the current state has begun. The time is expressed in millisecond epoch time.
        /// </summary>
        [JsonProperty(PropertyName = "current_state_begin_time")]
        public long? CurrentStateBeginTime { get; set; }
        /// <summary>
        /// All the historical delta sync are counted in calculating the average delta sync time in milliseconds.
        /// </summary>
        [JsonProperty(PropertyName = "avg_delta_sync_time")]
        public long? AvgDeltaSyncTime { get; set; }
        /// <summary>
        /// Directory domain previous sync status error if last status was failure.
        /// </summary>
        [JsonProperty(PropertyName = "prev_sync_error")]
        public string? PrevSyncError { get; set; }
        /// <summary>
        /// Current running state of the directory domain in synchronization life cycle. It could be one of the following five
        /// states. SELECTIVE_FULL_SYNC and SELECTIVE_DELTA_SYNC are sync states for selective sync.
        /// </summary>
        [JsonProperty(PropertyName = "current_state")]
        [JsonConverter(typeof(StringEnumConverter))]
        public NSXTDirectoryDomainSyncStatsCurrentStateEnumType? CurrentState { get; set; }
        /// <summary>
        /// number of successful historical delta sync initiated either by system or by API request.
        /// </summary>
        [JsonProperty(PropertyName = "num_delta_sync")]
        public long? NumDeltaSync { get; set; }
        /// <summary>
        /// Directory domain previous sync ending time expressed in millisecond epoch time.
        /// </summary>
        [JsonProperty(PropertyName = "prev_sync_end_time")]
        public long? PrevSyncEndTime { get; set; }
    }
}
