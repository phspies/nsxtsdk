// <auto-generated>
// Changes may cause incorrect behavior and will be lost if the code is regenerated.
// </auto-generated>
using nsxtsdk.Models;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.ComponentModel;
using NJsonSchema.Converters;

namespace nsxtsdk.ManagerModels
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
        public NSXTRemoteFileServerType RemoteFileServer { get; set; }
        /// <summary>
        /// true if automated backup is enabled
        /// </summary>
        public bool? BackupEnabled { get; set; }
        /// <summary>
        /// Passphrase used to encrypt backup files.
        /// The passphrase specified must be at least 8 characters in length and must
        /// contain at least one lowercase, one uppercase, one numeric character and one
        /// special character (any other non-space character).
        /// </summary>
        public string? Passphrase { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public NSXTBackupScheduleType BackupSchedule { get; set; }
        /// <summary>
        /// A number of seconds after a last backup, that needs to pass, before a topology change will trigger a generation of a new
        /// cluster/node backups. If parameter is not provided, then changes in a topology will not trigger a generation of
        /// cluster/node backups.
        /// </summary>
        public long? AfterInventoryUpdateInterval { get; set; }
        /// <summary>
        /// The minimum number of seconds between each upload of the inventory summary to backup server.
        /// </summary>
        public long? InventorySummaryInterval { get; set; }
    }
}
