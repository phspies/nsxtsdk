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
    /// Configuration for taking manual/automated backup
    /// </summary>
    [NSXTProperty(Description: @"Configuration for taking manual/automated backup")]
    public class NSXTBackupConfigurationType 
    {
        /// <summary>
        /// 
        /// </summary>
        [JsonProperty(PropertyName = "remote_file_server")]
        public NSXTRemoteFileServerType RemoteFileServer { get; set; }
        /// <summary>
        /// true if automated backup is enabled
        /// </summary>
        [JsonProperty(PropertyName = "backup_enabled")]
        public bool? BackupEnabled { get; set; }
        /// <summary>
        /// Passphrase used to encrypt backup files.
        /// The passphrase specified must be at least 8 characters in length and must
        /// contain at least one lowercase, one uppercase, one numeric character and one
        /// special character (any other non-space character).
        /// </summary>
        [JsonProperty(PropertyName = "passphrase")]
        public string? Passphrase { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [JsonProperty(PropertyName = "backup_schedule")]
        public NSXTBackupScheduleType BackupSchedule { get; set; }
        /// <summary>
        /// A number of seconds after a last backup, that needs to pass, before a topology change will trigger a generation of a new
        /// cluster/node backups. If parameter is not provided, then changes in a topology will not trigger a generation of
        /// cluster/node backups.
        /// </summary>
        [JsonProperty(PropertyName = "after_inventory_update_interval")]
        public long? AfterInventoryUpdateInterval { get; set; }
        /// <summary>
        /// The minimum number of seconds between each upload of the inventory summary to backup server.
        /// </summary>
        [JsonProperty(PropertyName = "inventory_summary_interval")]
        public long? InventorySummaryInterval { get; set; }
    }
}
