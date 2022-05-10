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
    public class NSXTAuditLogListResultType : NSXTListResultType
    {
        /// <summary>
        /// Timestamp of the last full audit log collection
        /// </summary>
        [JsonProperty(PropertyName = "last_full_sync_timestamp", Required = Required.AllowNull)]
        public string LastFullSyncTimestamp { get; set; }
        /// <summary>
        /// Audit log results
        /// </summary>
        [JsonProperty(PropertyName = "results", Required = Required.AllowNull)]
        public IList<NSXTAuditLogType> Results { get; set; }
    }
}
