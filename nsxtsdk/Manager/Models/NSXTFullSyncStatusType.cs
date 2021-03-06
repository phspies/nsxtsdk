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
    public class NSXTFullSyncStatusType 
    {
        /// <summary>
        /// Status of full sync.
        /// </summary>
        [JsonProperty(PropertyName = "status", Required = Required.AllowNull)]
        [JsonConverter(typeof(StringEnumConverter))]
        public NSXTFullSyncStatusStatusEnumType Status { get; set; }
        /// <summary>
        /// Time at which the full sync was completed.
        /// </summary>
        [JsonProperty(PropertyName = "completed_at", Required = Required.AllowNull)]
        public string CompletedAt { get; set; }
        /// <summary>
        /// Identifier for the full sync.
        /// </summary>
        [JsonProperty(PropertyName = "sync_id", Required = Required.AllowNull)]
        public string SyncId { get; set; }
        /// <summary>
        /// Type of full sync.
        /// </summary>
        [JsonProperty(PropertyName = "sync_type", Required = Required.AllowNull)]
        [JsonConverter(typeof(StringEnumConverter))]
        public NSXTFullSyncStatusSyncTypeEnumType SyncType { get; set; }
        /// <summary>
        /// Snapshot version targeted by full sync.
        /// </summary>
        [JsonProperty(PropertyName = "snapshot_version", Required = Required.AllowNull)]
        public string SnapshotVersion { get; set; }
    }
}
