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
    public class NSXTAgentStatusCountType 
    {
        /// <summary>
        /// Roll-up agent status
        /// </summary>
        [JsonProperty(PropertyName = "status")]
        [JsonConverter(typeof(StringEnumConverter))]
        public NSXTAgentStatusCountStatusEnumType? Status { get; set; }
        /// <summary>
        /// Down count
        /// </summary>
        [JsonProperty(PropertyName = "down_count")]
        public int? DownCount { get; set; }
        /// <summary>
        /// List of agent statuses belonging to the transport node
        /// </summary>
        [JsonProperty(PropertyName = "agents")]
        public IList<NSXTAgentStatusType> Agents { get; set; }
        /// <summary>
        /// Up count
        /// </summary>
        [JsonProperty(PropertyName = "up_count")]
        public int? UpCount { get; set; }
    }
}
