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
    public class NSXTAgentStatusCountType 
    {
        public NSXTAgentStatusCountType()
        {
        }
        /// <summary>
        /// Roll-up agent status
        /// </summary>
        [JsonProperty(PropertyName = "status")]
        [NSXTProperty(IsRequired: false, Description: @"Roll-up agent status")]
        public NSXTAgentStatusCountStatusEnumType? Status { get; set; }
        /// <summary>
        /// Down count
        /// </summary>
        [JsonProperty(PropertyName = "down_count")]
        [NSXTProperty(IsRequired: false, Description: @"Down count")]
        public int? DownCount { get; set; }
        /// <summary>
        /// List of agent statuses belonging to the transport node
        /// </summary>
        [JsonProperty(PropertyName = "agents")]
        [NSXTProperty(IsRequired: false, Description: @"List of agent statuses belonging to the transport node")]
        public IList<NSXTAgentStatusType> Agents { get; set; }
        /// <summary>
        /// Up count
        /// </summary>
        [JsonProperty(PropertyName = "up_count")]
        [NSXTProperty(IsRequired: false, Description: @"Up count")]
        public int? UpCount { get; set; }
    }
}
