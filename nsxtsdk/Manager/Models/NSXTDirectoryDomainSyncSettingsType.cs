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
    /// Domain synchronization settings
    /// </summary>
    [NSXTProperty(Description: @"Domain synchronization settings")]
    public class NSXTDirectoryDomainSyncSettingsType 
    {
        /// <summary>
        /// Sync delay after Directory domain has been successfully created.
        /// if delay is -1, initial full sync will not be triggered.
        /// </summary>
        [JsonProperty(PropertyName = "sync_delay_in_sec")]
        public int? SyncDelayInSec { get; set; }
        /// <summary>
        /// Directory domain full synchronization schedule using cron expression. For example, cron expression "0 0 12 ? * SUN *"
        /// means full sync is scheduled every Sunday midnight. If this object is null, it means there is no background cron job
        /// running for full sync.
        /// </summary>
        [JsonProperty(PropertyName = "full_sync_cron_expr")]
        public string? FullSyncCronExpr { get; set; }
        /// <summary>
        /// Directory domain delta synchronization interval time between two delta sync in minutes.
        /// </summary>
        [JsonProperty(PropertyName = "delta_sync_interval")]
        public long? DeltaSyncInterval { get; set; }
    }
}
