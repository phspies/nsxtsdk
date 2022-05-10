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
    /// Antrea Controller status, including component status, connected agent and CONTROLLER_ prefix conditions status.
    /// </summary>
    [NSXTProperty(Description: @"Antrea Controller status, including component status, connected agent and CONTROLLER_ prefix conditions status.")]
    public class NSXTAntreaControllerStatusType 
    {
        /// <summary>
        /// Indicate overall healthy status.
        /// </summary>
        [JsonProperty(PropertyName = "status")]
        [JsonConverter(typeof(StringEnumConverter))]
        public NSXTAntreaControllerStatusStatusEnumType? Status { get; set; }
        /// <summary>
        /// Collection of controller related conditions.
        /// </summary>
        [JsonProperty(PropertyName = "conditions")]
        public IList<NSXTComponentConditionItemType> Conditions { get; set; }
        /// <summary>
        /// If status is UNKNOWN, this number is meaningless.
        /// </summary>
        [JsonProperty(PropertyName = "connected_agent_num")]
        public int? ConnectedAgentNum { get; set; }
    }
}
