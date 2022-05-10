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
    /// Cluster backup details
    /// </summary>
    [NSXTProperty(Description: @"Cluster backup details")]
    public class NSXTClusterBackupInfoType 
    {
        /// <summary>
        /// timestamp of the cluster backup file
        /// </summary>
        [JsonProperty(PropertyName = "timestamp")]
        public long? Timestamp { get; set; }
        /// <summary>
        /// ID of the node from which the backup was taken
        /// </summary>
        [JsonProperty(PropertyName = "node_id")]
        public string? NodeId { get; set; }
        /// <summary>
        /// IP address or FQDN of the node from which the backup was taken
        /// </summary>
        [JsonProperty(PropertyName = "ip_address")]
        public string? IpAddress { get; set; }
        /// <summary>
        /// Type of restore allowed
        /// </summary>
        [JsonProperty(PropertyName = "restore_type")]
        public IList<string> RestoreType { get; set; }
    }
}
