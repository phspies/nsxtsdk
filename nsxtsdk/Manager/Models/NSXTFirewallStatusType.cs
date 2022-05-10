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
    public class NSXTFirewallStatusType : NSXTManagedResourceType
    {
        /// <summary>
        /// Firewall status for a fabric entity or in global context where firewall is supported.
        /// </summary>
        [JsonProperty(PropertyName = "global_status", Required = Required.AllowNull)]
        [JsonConverter(typeof(StringEnumConverter))]
        public NSXTFirewallStatusGlobalStatusEnumType GlobalStatus { get; set; }
        /// <summary>
        /// Types of firewall contexts.
        /// </summary>
        [JsonProperty(PropertyName = "context", Required = Required.AllowNull)]
        [JsonConverter(typeof(StringEnumConverter))]
        public NSXTFirewallStatusContextEnumType Context { get; set; }
        /// <summary>
        /// List of firewall status on various target logical resources. This will override the global status of corresponding
        /// firewall context (e.g it will override the gloabal status of logical_routers).
        /// </summary>
        [JsonProperty(PropertyName = "target_statuses")]
        public IList<NSXTTargetResourceStatusType> TargetStatuses { get; set; }
    }
}
