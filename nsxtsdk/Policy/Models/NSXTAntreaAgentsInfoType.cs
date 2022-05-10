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
    /// Antrea agents information
    /// </summary>
    [NSXTProperty(Description: @"Antrea agents information")]
    public class NSXTAntreaAgentsInfoType 
    {
        /// <summary>
        /// The number of degraded agents
        /// </summary>
        [JsonProperty(PropertyName = "degraded_agent_num")]
        public int? DegradedAgentNum { get; set; }
        /// <summary>
        /// The number of failed agents
        /// </summary>
        [JsonProperty(PropertyName = "failed_agent_num")]
        public int? FailedAgentNum { get; set; }
        /// <summary>
        /// The number of healthy agents
        /// </summary>
        [JsonProperty(PropertyName = "healthy_agent_num")]
        public int? HealthyAgentNum { get; set; }
    }
}
