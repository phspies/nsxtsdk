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
    /// Represents details of the last full sync if full sync is not running,
        /// otherwise returns the status of current full sync.
    /// </summary>
    [NSXTProperty(Description: @"Represents details of the last full sync if full sync is not running,otherwise returns the status of current full sync.")]
    public class NSXTFullSyncInfoType 
    {
        /// <summary>
        /// Full sync status
        /// </summary>
        [JsonProperty(PropertyName = "status")]
        [JsonConverter(typeof(StringEnumConverter))]
        public NSXTFullSyncInfoStatusEnumType? Status { get; set; }
        /// <summary>
        /// Errors if any
        /// </summary>
        [JsonProperty(PropertyName = "errors")]
        public IList<string> Errors { get; set; }
        /// <summary>
        /// Start time of applying full state on receiver side
        /// </summary>
        [JsonProperty(PropertyName = "receiver_start_time")]
        public long? ReceiverStartTime { get; set; }
        /// <summary>
        /// End time of completing applying full state on receiver side
        /// </summary>
        [JsonProperty(PropertyName = "receiver_end_time")]
        public long? ReceiverEndTime { get; set; }
        /// <summary>
        /// Errors if any
        /// </summary>
        [JsonProperty(PropertyName = "warnings")]
        public IList<string> Warnings { get; set; }
        /// <summary>
        /// Full sync start time
        /// </summary>
        [JsonProperty(PropertyName = "start_time")]
        public long? StartTime { get; set; }
        /// <summary>
        /// Full sync can happen for various internal reasons, as well user can request for one. The code provides the
        /// classification of possible reasons to start a full sync.
        /// </summary>
        [JsonProperty(PropertyName = "reason_code")]
        [JsonConverter(typeof(StringEnumConverter))]
        public NSXTFullSyncInfoReasonCodeEnumType? ReasonCode { get; set; }
        /// <summary>
        /// Full sync id
        /// </summary>
        [JsonProperty(PropertyName = "fullSyncId")]
        public string? FullSyncId { get; set; }
        /// <summary>
        /// End time of streaming full state from source
        /// </summary>
        [JsonProperty(PropertyName = "data_streaming_from_source_end_time")]
        public long? DataStreamingFromSourceEndTime { get; set; }
        /// <summary>
        /// Description of full sync reason
        /// </summary>
        [JsonProperty(PropertyName = "reason")]
        public string? Reason { get; set; }
        /// <summary>
        /// Full sync end time
        /// </summary>
        [JsonProperty(PropertyName = "end_time")]
        public long? EndTime { get; set; }
        /// <summary>
        /// This is optional information, provides useful insights on receiver side
        /// once async channel hands over full state data to receiver.
        /// </summary>
        [JsonProperty(PropertyName = "receiver_state")]
        public string? ReceiverState { get; set; }
        /// <summary>
        /// Time taken by application receiver to apply the full state received
        /// </summary>
        [JsonProperty(PropertyName = "receiver_time_to_apply_in_millis")]
        public long? ReceiverTimeToApplyInMillis { get; set; }
        /// <summary>
        /// This provides the insights into current full sync stage if in progress.
        /// </summary>
        [JsonProperty(PropertyName = "stage")]
        [JsonConverter(typeof(StringEnumConverter))]
        public NSXTFullSyncInfoStageEnumType? Stage { get; set; }
        /// <summary>
        /// Start time of streaming full state from source
        /// </summary>
        [JsonProperty(PropertyName = "data_streaming_from_source_start_time")]
        public long? DataStreamingFromSourceStartTime { get; set; }
        /// <summary>
        /// Details about full sync on sender side
        /// </summary>
        [JsonProperty(PropertyName = "data_streaming_from_source_progress")]
        public string? DataStreamingFromSourceProgress { get; set; }
    }
}
