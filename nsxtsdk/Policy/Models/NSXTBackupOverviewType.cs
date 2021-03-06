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
    /// 
    /// </summary>
    [NSXTProperty(Description: @"")]
    public class NSXTBackupOverviewType : NSXTClusterBackupInfoListResultType
    {
        /// <summary>
        /// 
        /// </summary>
        [JsonProperty(PropertyName = "current_backup_operation_status", Required = Required.AllowNull)]
        public NSXTCurrentBackupOperationStatusType CurrentBackupOperationStatus { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [JsonProperty(PropertyName = "backup_operation_history", Required = Required.AllowNull)]
        public NSXTBackupOperationHistoryType BackupOperationHistory { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [JsonProperty(PropertyName = "backup_config", Required = Required.AllowNull)]
        public NSXTBackupConfigurationType BackupConfig { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [JsonProperty(PropertyName = "restore_status", Required = Required.AllowNull)]
        public NSXTClusterRestoreStatusType RestoreStatus { get; set; }
    }
}
