// <auto-generated>
// Changes may cause incorrect behavior and will be lost if the code is regenerated.
// </auto-generated>
using nsxtsdk.Models;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using NJsonSchema.Converters;
using System.ComponentModel;

namespace nsxtsdk.PolicyModels
{
    /// <summary>
    /// 
    /// </summary>
    [NSXTProperty(Description: @"")]
    public class NSXTInitiateClusterRestoreRequestType 
    {
        /// <summary>
        /// Timestamp of the backed-up configuration from which
        /// the appliance will be restored
        /// </summary>
        [JsonProperty(PropertyName = "timestamp")]
        [NSXTProperty(IsRequired: false, Description: @"Timestamp of the backed-up configuration from whichthe appliance will be restored")]
        public long? Timestamp { get; set; }
        /// <summary>
        /// Unique id of the backed-up configuration from which
        /// the appliance will be restored
        /// </summary>
        [JsonProperty(PropertyName = "node_id")]
        [NSXTProperty(IsRequired: false, Description: @"Unique id of the backed-up configuration from whichthe appliance will be restored")]
        public string? NodeId { get; set; }
        /// <summary>
        /// IP address or FQDN of the node from which the backup was taken
        /// </summary>
        [JsonProperty(PropertyName = "ip_address")]
        [NSXTProperty(IsRequired: false, Description: @"IP address or FQDN of the node from which the backup was taken")]
        public string? IpAddress { get; set; }
    }
}