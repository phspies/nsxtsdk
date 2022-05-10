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
    /// Past backup operation details
    /// </summary>
    [NSXTProperty(Description: @"Past backup operation details")]
    public class NSXTBackupOperationHistoryType 
    {
        /// <summary>
        /// Statuses of previous inventory backups
        /// </summary>
        [JsonProperty(PropertyName = "inventory_backup_statuses")]
        public IList<NSXTBackupOperationStatusType> InventoryBackupStatuses { get; set; }
        /// <summary>
        /// Statuses of previous cluser backups
        /// </summary>
        [JsonProperty(PropertyName = "cluster_backup_statuses")]
        public IList<NSXTBackupOperationStatusType> ClusterBackupStatuses { get; set; }
        /// <summary>
        /// Statuses of previous node backups
        /// </summary>
        [JsonProperty(PropertyName = "node_backup_statuses")]
        public IList<NSXTBackupOperationStatusType> NodeBackupStatuses { get; set; }
    }
}
