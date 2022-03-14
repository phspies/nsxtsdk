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
    /// Cluster restore status
    /// </summary>
    [NSXTProperty(Description: @"Cluster restore status")]
    public class NSXTClusterRestoreStatusType 
    {
        /// <summary>
        /// 
        /// </summary>
        public NSXTGlobalRestoreStatusType Status { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public NSXTRestoreStepType Step { get; set; }
        /// <summary>
        /// The list of allowed endpoints, based on the current state of
        /// the restore process
        /// </summary>
        public IList<NSXTResourceLinkType> Endpoints { get; set; }
        /// <summary>
        /// Total number of steps in the entire restore process
        /// </summary>
        public long? TotalSteps { get; set; }
        /// <summary>
        /// Timestamp when restore was started in epoch millisecond
        /// </summary>
        public long? RestoreStartTime { get; set; }
        /// <summary>
        /// Timestamp when restore was completed in epoch millisecond
        /// </summary>
        public long? RestoreEndTime { get; set; }
        /// <summary>
        /// List of actions that are not allowed
        /// </summary>
        public IList<string> NotAllowedActions { get; set; }
        /// <summary>
        /// Timestamp when backup was initiated in epoch millisecond
        /// </summary>
        public long? BackupTimestamp { get; set; }
        /// <summary>
        /// Unique id for backup request
        /// </summary>
        public string? Id { get; set; }
        /// <summary>
        /// Instructions for users to reconcile Restore operations
        /// </summary>
        public IList<NSXTInstructionInfoType> Instructions { get; set; }
    }
}
