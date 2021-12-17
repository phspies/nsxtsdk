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

namespace nsxtsdk.ManagerModels
{
    /// <summary>
    /// 
    /// </summary>
    [NSXTProperty(Description: @"")]
    public class NSXTFirewallStatusType : NSXTManagedResourceType
    {
        public NSXTFirewallStatusType()
        {
        }
        /// <summary>
        /// Firewall status for a fabric entity or in global context where firewall is supported.
        /// </summary>
        [JsonProperty(PropertyName = "global_status", Required = Required.AllowNull)]
        [NSXTProperty(IsRequired: true, Description: @"Firewall status for a fabric entity or in global context where firewall is supported.")]
        [System.ComponentModel.DataAnnotations.Required]
        public NSXTFirewallStatusGlobalStatusEnumType GlobalStatus { get; set; }
        /// <summary>
        /// Types of firewall contexts.
        /// </summary>
        [JsonProperty(PropertyName = "context", Required = Required.AllowNull)]
        [NSXTProperty(IsRequired: true, Description: @"Types of firewall contexts.")]
        [System.ComponentModel.DataAnnotations.Required]
        public NSXTFirewallStatusContextEnumType Context { get; set; }
        /// <summary>
        /// List of firewall status on various target logical resources. This will override the global status of corresponding
        /// firewall context (e.g it will override the gloabal status of logical_routers).
        /// </summary>
        [JsonProperty(PropertyName = "target_statuses")]
        [NSXTProperty(IsRequired: false, Description: @"List of firewall status on various target logical resources. This will override the global status of corresponding firewall context (e.g it will override the gloabal status of logical_routers).")]
        public IList<NSXTTargetResourceStatusType> TargetStatuses { get; set; }
    }
}
