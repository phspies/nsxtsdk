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
    public class NSXTActiveStandbySyncStatusType 
    {
        /// <summary>
        /// Status of synchronization between active and standby Global Manager nodes.
        /// </summary>
        [JsonProperty(PropertyName = "status", Required = Required.AllowNull)]
        [JsonConverter(typeof(StringEnumConverter))]
        public NSXTActiveStandbySyncStatusStatusEnumType Status { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [JsonProperty(PropertyName = "full_sync_status", Required = Required.AllowNull)]
        public NSXTFullSyncStatusType FullSyncStatus { get; set; }
        /// <summary>
        /// Description of the status.
        /// </summary>
        [JsonProperty(PropertyName = "description", Required = Required.AllowNull)]
        public string Description { get; set; }
        /// <summary>
        /// Indicates whether the data is consistent. Always returned as true when queried on an active Global Manager node.
        /// </summary>
        [JsonProperty(PropertyName = "is_data_consistent", Required = Required.AllowNull)]
        public bool IsDataConsistent { get; set; }
        /// <summary>
        /// Number of entries pending synchronization. This value is only returned when queried on an active Global Manager node.
        /// </summary>
        [JsonProperty(PropertyName = "remaining_entries_to_send")]
        public long? RemainingEntriesToSend { get; set; }
        /// <summary>
        /// Percentage estimate of synchronization progress. Ranges from 0 to 100. This value is only returned when queried on an
        /// active Global Manager node.
        /// </summary>
        [JsonProperty(PropertyName = "percentage_completed")]
        public long? PercentageCompleted { get; set; }
        /// <summary>
        /// Name of standby site.
        /// </summary>
        [JsonProperty(PropertyName = "standby_site", Required = Required.AllowNull)]
        public string StandbySite { get; set; }
        /// <summary>
        /// Type of synchronization currently in effect between active and standby Global Manager nodes.
        /// </summary>
        [JsonProperty(PropertyName = "sync_type", Required = Required.AllowNull)]
        [JsonConverter(typeof(StringEnumConverter))]
        public NSXTActiveStandbySyncStatusSyncTypeEnumType SyncType { get; set; }
    }
}
